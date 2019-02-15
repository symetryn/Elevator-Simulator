using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ElevatorSimulator
{

   
    class Elevator
    {
        public int Position { get; set; }
       

        //code to move up the elevator
        public void MoveUp(Panel panel, Timer DoorOpenTimer, Timer MoveUpTimer, PictureBox LeftDoorBot, PictureBox RightDoorBot, PictureBox display, DataGridView Log)
        {
            Door d = new Door();
            DatabaseOperation Do= new DatabaseOperation();
           
                if (panel.Location.Y == 70)
                {
                    Position = 1;
                    DoorOpenTimer.Start();
                    MoveUpTimer.Stop();
                    display.BackgroundImage = global::ElevatorSimulator.Properties.Resources.FirstFloor;
                    
                    Do.InsertData("Reached First Floor");
                    Do.LoadData(Log);
                }
                else if (d.DoorClosed(LeftDoorBot, RightDoorBot))
                {
                    panel.Location = new Point(panel.Location.X, panel.Location.Y - 1);
                    display.BackgroundImage = global::ElevatorSimulator.Properties.Resources.ElevatorUp;
                }
        }
        //code to move down the elevator
        public void MoveDown(Panel panel, Timer DoorOpenTimer, Timer MoveDownTimer, PictureBox LeftDoorTop, PictureBox RightDoorTop,
            PictureBox Display,DataGridView Log)
        {
            Door d = new Door();
            DatabaseOperation Do = new DatabaseOperation();
            
            if (panel.Location.Y == 361)
            {
                Position = 0;
                DoorOpenTimer.Start();
                MoveDownTimer.Stop();
                Display.BackgroundImage = global::ElevatorSimulator.Properties.Resources.GroundFloor;
                
                Do.InsertData("Reached Ground Floor");
                Do.LoadData(Log);
                
            }
            else if (d.DoorClosed(LeftDoorTop, RightDoorTop))
            {
                panel.Location = new Point(panel.Location.X, panel.Location.Y + 1);
                Display.BackgroundImage = global::ElevatorSimulator.Properties.Resources.ElevatorDown;
            }

        }
       
    
    }
}
