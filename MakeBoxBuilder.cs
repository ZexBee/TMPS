using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class MakeBoxBuilder
    {
        private readonly MakeBox _makeBox = new MakeBox();
        public void Length(double length)
        {
            _makeBox.Length = length;
        }
        public void Width(double width)
        {
            _makeBox.Width = width;
        }
        public void Height(double height)
        {
            _makeBox.Height = height;
        }
        public void TextOnBox(string textOnBox)
        {
            _makeBox.TextOnBox = textOnBox;
        }
        public void Wrapped(bool wrapped)
        {
            _makeBox.Wrapped = wrapped;
        }
        public void To(string to)
        {
            _makeBox.To = to;
        }

        public MakeBox Build()
        {
            return _makeBox;
        }
    }
}
