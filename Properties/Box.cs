using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    class Box
    {
        // member or class variables -> affects the whole box object -> these are removed when the properties are used
        private int length;
        private int height;
        private int width;
        private int volume;

        // properties include the class variables
        public int Length { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }


        public Box(int length, int height, int width)
        {
            Length = length;
            Height = height;
            Width = width;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}.", Length, Height, Width, volume = Length*Width*Height);
        }

    }
}
