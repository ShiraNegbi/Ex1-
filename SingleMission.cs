using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        // implement constructors and funcs
        // implement interface finctions
        private DoubleToDouble Func { get; set; }

        public double Calculate(double value)
        {
            return this.Func(value);
        }

        public SingleMission(DooubleToDouble func, String name)
        {
            this.Type = "Single";
            this.Func = func;
            this.Name = name;
        }
    }
}
