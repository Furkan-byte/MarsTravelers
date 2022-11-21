using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Travelers
    {
        public Travelers(Mars mars)
        {
            Mars = mars;
        }
        private int TravelerLocation_x;
        private int TravelerLocation_y;
        public Mars Mars { get; set; }
        public int TravelerLocation_X { get 
            {
                return TravelerLocation_x;
            } 
            set
            {
                if (value > Mars.Location_X)
                {

                    value = Mars.Location_X;

                }
                else if(value < 0)
                {
                    value = 0;
                }
                TravelerLocation_x = value;
            } }
        public int TravelerLocation_Y {
            get
            {
                return TravelerLocation_y;
            }
            set
            {
                if (value > Mars.Location_Y)
                {

                    value = Mars.Location_Y;

                }
                else if (value < 0)
                {
                    value = 0;
                }
                TravelerLocation_y = value;
            }
        }
        public string TravelerDirection { get; set; }

        public void SetTravelerInfo(int x,int y,string direction)
        {
            TravelerLocation_X = x; 
            TravelerLocation_Y = y;
            TravelerDirection = direction;
        }

        public string GetTravelerInfo()
        {
            return TravelerLocation_X + " " + TravelerLocation_Y+ " " + TravelerDirection;
        }
        public void TurnLeft()
        {
            if (TravelerDirection == "N")
            {
                TravelerDirection = "W";
            }
            else if (TravelerDirection == "W")
            {
                TravelerDirection = "S";
            }
            else if(TravelerDirection == "S")
            {
                TravelerDirection = "E";
            }
            else if(TravelerDirection == "E")
            {
                TravelerDirection = "N";
            }
        }

        public void TurnRight()
        {
            if (TravelerDirection == "N")
            {
                TravelerDirection = "E";
            }
            else if (TravelerDirection == "E")
            {
                TravelerDirection = "S";
            }
            else if (TravelerDirection == "S")
            {
                TravelerDirection = "W";
            }
            else if (TravelerDirection == "W")
            {
                TravelerDirection = "N";
            }
        }
        public void MoveForward()
        {
            if (TravelerDirection == "N")
            {
                TravelerLocation_Y += 1;
            }
            else if (TravelerDirection == "W")
            {
                TravelerLocation_X -= 1;
            }
            else if (TravelerDirection == "S")
            {
                TravelerLocation_Y -= 1;
            }
            else if (TravelerDirection == "E")
            {
                TravelerLocation_X += 1;
            }
        }
    }
}
