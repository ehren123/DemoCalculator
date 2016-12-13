using System;

namespace DemoCalc
{
    // Event args for textbox.
    class CalcEventArgs : EventArgs
    {
        public string Current { get; set; }

        public CalcEventArgs(string current)
        {
            Current = current;
        }
        
    }
}