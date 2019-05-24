using System;
using System.Windows.Forms;

namespace Crazy_Buttons
{
    class ButtonCompare : Button, IComparable
    {
        public int CompareTo(object obj)
        {
            ButtonCompare temp = (ButtonCompare)obj;
            if (Location.X > temp.Location.X)
                return -1;
            if (Location.X < temp.Location.X)
                return 1;
            return 0;
        }
    }
}
