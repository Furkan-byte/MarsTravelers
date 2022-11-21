using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Mars
    {
        public Mars(int locationX,int locationY)
        {
            Location_X = locationX;
            Location_Y = locationY;
        }
        public int Location_x { get; set; }
        public int Location_y { get; set; }
        public int Location_X
        {
            get { return Location_x; }
            set
            {
                
                if (value < 0)
                {
                   
                        throw new ArgumentOutOfRangeException("Location x cannot be lower from 0");
                    
                }
                Location_x = value;
            }
        }
        public int Location_Y
        {
            get
            {
                return Location_y;
            }
            set
            {
                if (value < 0)
                {

                    throw new ArgumentOutOfRangeException("Location y cannot be lower from 0");

                }
                Location_y = value;
            }
        }
    }
}
