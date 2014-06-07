using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.cs
{
    class Area
    {
        public string Name { get; set; }
        public string description { get; set; }
        protected int[] neighbors;
        protected Person[] peopleInArea;
        protected Building[] buildingsInArea;

    }
}
