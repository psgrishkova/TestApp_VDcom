using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp_VDcom.train
{
    public class Wagon
    {
        private bool light = false;

        public Wagon(bool light)
        {
            this.light = light;
        }

        public void turnOn() => light = true;
        public void turnOff() => light = false;

        public bool Light { get => light; set => light = value; }

        public override string ToString()
        {
            return "This is a wagon with light " + (this.light ? "on" : "off"); 
        }
    }
}
