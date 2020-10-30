using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Colour
    {
        public static UInt32 colour;
       

        public Colour()
        {
            colour = 0;
        }
    
        public void SetRed(byte red)
        {
            colour = colour & 0x00ffffff;
            colour |= (UInt32)red << 24;
        }

       
        public byte GetRed()
        {
            return (byte)((colour & 0xff000000) >> 24);
            UInt32 value = colour & 0xff000000;
        }


    }
}
