using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSimulator
{
    class Button
    {   //swaps images with that of glowing according to PicturePos value
        public void Glow(System.Windows.Forms.PictureBox Btn,int PicturePos)
        { 
            switch(PicturePos){
                case 1:
                    Btn.BackgroundImage = global::ElevatorSimulator.Properties.Resources.groundIconActive;
                    break;
                case 2:
                    Btn.BackgroundImage = global::ElevatorSimulator.Properties.Resources.FirstFloorActive;
                    break;
                case 3:
                    Btn.BackgroundImage = global::ElevatorSimulator.Properties.Resources.BtnRequestUpActive;
                    break;
                case 4:
                    Btn.BackgroundImage = global::ElevatorSimulator.Properties.Resources.BtnRequestDownActive;
                    break;
            }
        }
        //swaps images with that of turned off according to PicturePos value
        public void Off(System.Windows.Forms.PictureBox Btn, int PicturePos)
        {
            switch (PicturePos)
            {
                case 1:
                    Btn.BackgroundImage = global::ElevatorSimulator.Properties.Resources.iconground;
                    break;
                case 2:
                    Btn.BackgroundImage = global::ElevatorSimulator.Properties.Resources.icon1st;
                    break;
                case 3:
                    Btn.BackgroundImage = global::ElevatorSimulator.Properties.Resources.BtnRequestUp;
                    break;
                case 4:
                    Btn.BackgroundImage = global::ElevatorSimulator.Properties.Resources.BtnRequestDown;
                    break;
            }
        }
    }
}
