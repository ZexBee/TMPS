using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class MakeBox
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public string TextOnBox { get; set; }
        public bool Wrapped { get; set; }
        public string To { get; set; }
        
        public MakeBox(double length,double width,double height
            string textOnBox,bool wrapped,string to)
        {
            Length = length;
            Width = width;
            Height = height;
            TextOnBox = textOnBox;
            Wrapped = wrapped;
            To = to;

        }





    }
}
