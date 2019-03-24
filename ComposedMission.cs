using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        // implement constructors and funcs
        // implement interface finctions
        private List<DoubleToDouble> Funcs;

        public double Calculate(double value)
        {
            double result = value;
            foreach (DoubleToDouble f in this.Funcs)
            {
                result = f(result);
            }
            return result;
        }

        public ComposedMission(String name)
        {
            this.Type = "Composed";
            this.Name = name;
            this.Funcs = new List<DoubleToDouble>();
        }

        public ComposedMission Add(DoubleToDouble func)
        {
            this.Funcs.Add(func);
            return this;
        }
    }
}
