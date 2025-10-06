using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace At_day__at_night
{
    class Computer
    {
        public string Type { get; set; }
        public string CPU { get; set; }
        public string MotherBoard { get; set; }
        public string RAM { get; set; }
        public string DiscDriver { get; set; }

        public override string ToString()
        {
            return $"Type: {Type} , CPU: {CPU}, MotherBoard: {MotherBoard}, RAM: {RAM}, DiscDriver: {DiscDriver}";
        }
    }

}
