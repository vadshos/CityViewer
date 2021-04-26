using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityViewer
{
    class CityModel
    {
        public CityModel()
        {

        }
        public BindingList<string> PathesToImg { get; set; }
        public string NameCity { get; set; }
        public string PathToWiki { get; set; }
        public int CountVisited { get; set; }
        public override string ToString()
        {
            return NameCity;
        }
    }
}
