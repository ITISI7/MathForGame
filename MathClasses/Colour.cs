﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Colour
    {
        public UInt32 colour;
       

        public Colour()
        {
            
        }
        public Colour(byte red, byte green, byte blue, byte alpha)
        {

        }

        public byte GetRed()
        {
            UInt32 value = colour & 0xff000000;
            return (byte)((value) >> 24);
            
        }
        public void SetRed(byte red)
        {
            colour = colour & 0x00ffffff;
            colour |= (UInt32)red << 24;
        }
        
        public byte GetGreen()
        {
            UInt32 value = colour & 0xff000000;
            return (byte)((value) >> 24);
        }
        public void SetGreen(byte green)
        {
            colour = colour & 0x00ffffff;
            colour |= (UInt32)green << 24;
        }
        public byte GetBlue()
        {
            UInt32 value = colour & 0xff000000;
            return (byte)((value) >> 24);
        }
        public void SetBlue(byte blue)
        {
            colour = colour & 0x00ffffff;
            colour |= (UInt32)blue << 24;
        }
        public byte GetAlpha()
        {
            UInt32 value = colour & 0xff000000;
            return (byte)((value) >> 24);
        }
        public void SetAlpha(byte alpha)
        {
            colour = colour & 0x00ffffff;
            colour |= (UInt32)alpha << 24;
        }
       
       


    }
}
