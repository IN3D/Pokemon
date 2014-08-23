/*
 * What am I doing here?
 *
 * Shouldn't this stuff just be
 * in the globals class?
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Model
{
    public static class StaticGameData
    {
        public static Pokemon.Core.Types[] types = new Pokemon.Core.Types[18];
    }
}
