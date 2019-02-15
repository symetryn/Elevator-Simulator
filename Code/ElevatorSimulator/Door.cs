using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorSimulator
{
    class Door
    {
        private int CloseLeftX = 0;
        private int CloseRightX = 53;
        private int OpenRightX = 106;
        private int OpenLeftX = -53;
        //to open the door
        public void Open(PictureBox Left, PictureBox Right, Timer OpenTimer,Timer CloseTimer,Timer Delay)
        {

            int RightDoorX = Right.Location.X;
            int RightDoorY = Right.Location.Y;
            int LeftDoorX = Left.Location.X;
            int LeftDoorY = Left.Location.Y;
            if (RightDoorX > OpenRightX && LeftDoorX < OpenLeftX)
            {
                OpenTimer.Stop();
                Delay.Start();
                

            }
            else
            {
                
                Right.Location = new Point(RightDoorX + 1, RightDoorY);
                Left.Location = new Point(LeftDoorX - 1, RightDoorY);

            }
        }
        //to close the door
        public void Close(PictureBox Left, PictureBox Right, Timer CloseTimer)
        {
            int RightDoorX = Right.Location.X;
            int RightDoorY = Right.Location.Y;
            int LeftDoorX = Left.Location.X;
            int LeftDoorY = Left.Location.Y;
            if (LeftDoorX == CloseLeftX && RightDoorX == CloseRightX)
            {
                CloseTimer.Stop();

            }
            else
            {

                Right.Location = new Point(RightDoorX - 1, RightDoorY);
                Left.Location = new Point(LeftDoorX + 1, RightDoorY);

            }
        }
        //check if door closed 
        public bool DoorClosed(PictureBox Left, PictureBox Right)
        {
            int RightDoorX = Right.Location.X;
            int RightDoorY = Right.Location.Y;
            int LeftDoorX = Left.Location.X;
            int LeftDoorY = Left.Location.Y;
            if (LeftDoorX == CloseLeftX && RightDoorX == CloseRightX)
                return true;
            else
                return false;
        }
        //check if door open
        public bool DoorOpened(PictureBox Left, PictureBox Right)
        {
            int RightDoorX = Right.Location.X;
            int RightDoorY = Right.Location.Y;
            int LeftDoorX = Left.Location.X;
            int LeftDoorY = Left.Location.Y;
            if (LeftDoorX <= OpenLeftX && RightDoorX >= OpenRightX)
                return true;
            else
                return false;
        }

      
    }
}
    
