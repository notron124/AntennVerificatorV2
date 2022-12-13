using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntennVerificator
{
    public class Picture
    {
        public int ID { get; set; }
        public string Path { get; set; }
        public Picture(string path)
        {
            Path = path;
        }
    }

}
