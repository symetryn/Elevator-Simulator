using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ElevatorSimulator
{
    public partial class ElevatorForm : Form
    {
        Elevator E;
        Door D;
        Button B;
        DatabaseOperation Do;
        Boolean ElevatorQued;
        Boolean UpCount, DownCount;

        public ElevatorForm()
        {
            InitializeComponent();
            DoubleBuffered = true;           
            E=new Elevator();
            E.Position = 0;
            D = new Door();
            B = new Button();
            Do = new DatabaseOperation();
        }

     
        // timer to open door
        private void DoorOpenTimer_Tick(object sender, EventArgs e)
        {
                //enabling buttons and database update
                BtnRequestTop.Enabled = true;
                BtnRequestBot.Enabled = true;
                BtnFirstFloor.Enabled = true;
                BtnSecondFloor.Enabled = true;
                DownCount = false;
                UpCount = false;
                DoorCloseTimer.Stop();
                if (E.Position == 1)//lighting buttons
                {
                    B.Off(BtnSecondFloor, 2);
                    B.Off(BtnRequestTop, 4);
                    
                }
                else if (E.Position == 0)
                {
                    B.Off(BtnRequestBot, 3);
                    B.Off(BtnFirstFloor, 1);
                    
                }
                
            //starting a delay for running door close tier
            Delay.Start();
            ForceOpen.Enabled = true;

            if (E.Position == 1)
            {
                D.Open(LeftDoorTop, RightDoorTop, DoorOpenTimer, DoorCloseTimer, Delay);
                BtnRequestTop.Enabled = false;

               
            }
            else if (E.Position == 0)
            {
                BtnRequestBot.Enabled = false;
                D.Open(LeftDoorBot, RightDoorBot, DoorOpenTimer, DoorCloseTimer, Delay);

                
            }
        }

        

       
        //timer to close door
        private void DoorCloseTimer_Tick(object sender, EventArgs e)
        {
            Delay.Stop();
            BtnRequestTop.Enabled = true;
            BtnRequestBot.Enabled = true;
            BtnFirstFloor.Enabled = true;
            BtnSecondFloor.Enabled = true;
            if (E.Position == 1)
            {
                D.Close(LeftDoorTop, RightDoorTop, DoorCloseTimer);
                
                if (ElevatorQued)//checking if elevator was qued
                {
                    if (!DownCount)//loading the data into data base only once
                    {
                        Do.InsertData("Moving Down");
                        Do.LoadData(Log);
                        DownCount = true;
                    }
                    if (D.DoorClosed(LeftDoorBot, RightDoorBot))
                    {
                        ElevatorQued = false;
                        Moves.Start();
                    }
                }
            }
            else if (E.Position == 0)
            {
                D.Close(LeftDoorBot, RightDoorBot, DoorCloseTimer);
                if (ElevatorQued)
                {
                    if (!UpCount)
                    {
                        Do.InsertData("Moving Up");
                        Do.LoadData(Log);
                        UpCount = true;
                    }
                    if (D.DoorClosed(LeftDoorTop, RightDoorTop))
                    {
                        ElevatorQued = false;
                        MoveUp.Start();
                    }
                }
            
            }

        }
       
       
        //Timer to move down
        private void MoveDown_Tick(object sender, EventArgs e)
        {

            if (!DownCount)
            {
                Do.InsertData("Moving Down");
                Do.LoadData(Log);
                DownCount = true;
            }
           
            MoveUp.Stop();
            
            E.MoveDown(panel2, DoorOpenTimer, Moves, LeftDoorTop, RightDoorTop,DisplayPanel,Log);

        }
        //timer method to move up
        private void MoveUp_Tick(object sender, EventArgs e)
        {
            if (!UpCount)
            {
                Do.InsertData("Moving Up");
                Do.LoadData(Log);
                UpCount = true;
            }
           Moves.Stop();
           E.MoveUp(panel2,DoorOpenTimer,MoveUp,LeftDoorBot,RightDoorBot,DisplayPanel,Log); 
        }

        
            
        private void BtnRequestBot_Click(object sender, EventArgs e)
        {
            
            if (MoveUp.Enabled)//if lift is moving up que the elevator
            {
                ElevatorQued = true;
                B.Glow(BtnRequestBot, 3);
            }
            else if (E.Position == 0)//open door if on same floor
            {
                DoorCloseTimer.Stop();
                DoorOpenTimer.Start();
            }
            else if (Moves.Enabled == false)//move to the floor
            {
                
                B.Glow(BtnRequestBot, 3);
                BtnFirstFloor.Enabled = false;
                DoorCloseTimer.Stop();
                ForceOpen.Enabled = false;
                DoorOpenTimer.Stop();
                MoveUp.Stop();
                DoorCloseTimer.Start();
                Moves.Start();
            }
        }

        private void BtnRequestTop_Click(object sender, EventArgs e)
        {
            
            if (Moves.Enabled)
            {
                B.Glow(BtnRequestTop, 4);
                ElevatorQued = true;

            }
            else if (E.Position==1)
            {
            DoorCloseTimer.Stop();
            DoorOpenTimer.Start();
            }

            else if (MoveUp.Enabled == false)
            {
                
                DoorCloseTimer.Stop();
                DoorOpenTimer.Stop();
                B.Glow(BtnRequestTop, 4);

                BtnSecondFloor.Enabled = false;

                ForceOpen.Enabled = false;
                DisplayPanel.BackgroundImage = global::ElevatorSimulator.Properties.Resources.ElevatorUp;
                DoorCloseTimer.Start();
                MoveUp.Start();


            } 
        }
        //force opening door
        private void ForceOpen_Click(object sender, EventArgs e)
        {
            if (!Moves.Enabled && !MoveUp.Enabled)
            {
                DoorCloseTimer.Stop();
                DoorOpenTimer.Start();
            }
            
        }
        //force closing door
        private void ForceClose_Click(object sender, EventArgs e)
        {
            
                DoorOpenTimer.Stop();
                DoorCloseTimer.Start();
            
        }
        //delay to close the door
        private void Delay_Tick(object sender, EventArgs e)
        {
           
            DoorCloseTimer.Start();
            
        }
        //Calling second floor
        private void BtnSecondFloor_Click(object sender, EventArgs e)
        {
            if (Moves.Enabled)
            {
                B.Glow(BtnSecondFloor, 2);
                ElevatorQued = true;

            }
            else if (E.Position == 1 && !ElevatorQued)
            {
                DoorCloseTimer.Stop();
                DoorOpenTimer.Start();
               
            }
            else
            {
                
                Do.InsertData("Moving to First floor");
                Do.LoadData(Log);
                
                BtnFirstFloor.Enabled = false;
                B.Glow(BtnSecondFloor, 2);
                DoorCloseTimer.Stop();
                DoorOpenTimer.Stop();
                ForceOpen.Enabled = false;
                DisplayPanel.BackgroundImage = global::ElevatorSimulator.Properties.Resources.ElevatorUp;
                DoorCloseTimer.Start();
                MoveUp.Start();

            }
        }
        //Calling first floor
        private void BtnFirstFloor_Click(object sender, EventArgs e)
        {
            if (MoveUp.Enabled)
            {
                ElevatorQued = true;
                B.Glow(BtnFirstFloor, 1);
            }
            else if (E.Position == 0)
            {
                DoorCloseTimer.Stop();
                DoorOpenTimer.Start();
            }    
            else
            {
               
                Do.InsertData("Moving to Ground Floor");
                Do.LoadData(Log);
                
                BtnSecondFloor.Enabled = false;
                B.Glow(BtnFirstFloor, 1);
                DoorCloseTimer.Stop();
                DoorOpenTimer.Stop();
                ForceOpen.Enabled = false;
                DoorOpenTimer.Stop();
                MoveUp.Stop();
                DoorCloseTimer.Start();

                Moves.Start();
            }
        }
        // loading data log
        private void ElevatorForm_Load(object sender, EventArgs e)
        {
            GlobalConnection.OpenConnection();
            Do.LoadData(Log);
            DataGridViewColumn column = Log.Columns[0];
            column.Width = 60;
            column = Log.Columns[1];
            column.Width = 80;
            column = Log.Columns[2];
            column.Width = 160;
            Log.FirstDisplayedScrollingRowIndex = Log.RowCount - 1;

        }
       
    }
}
