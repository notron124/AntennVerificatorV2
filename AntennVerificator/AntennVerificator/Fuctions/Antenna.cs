using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntennVerificator
{
    public class Antenna
    {
        public string Name { get; set; }
        public string FrequencyWidth { get; set; }
        public string Description { get; set; }
        public string FreqDots { get; set; }


        public Antenna() {}

        //Конструктор
        public Antenna(string name, string freq, string description, string freqdots)
        {
            Name = name;
            FrequencyWidth = freq;
            Description = description;
            FreqDots = freqdots;
        }

    }


}
