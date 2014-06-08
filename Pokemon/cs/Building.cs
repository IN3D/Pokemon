using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Building
    {
        public string Name { get; set; }
        public string Description { get; set; }

        protected Building[] rooms;
    }
}
