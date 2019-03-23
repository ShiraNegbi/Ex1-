using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
  
    public class FunctionsContainer
    {
        public delegate double DoubleToDouble(double x);
        private Dictionary<String, DoubleToDouble> dictionary;

        public FunctionsContainer()
        {
            this.dictionary = new Dictionary<string, DoubleToDouble>();
        }

        public List<String> getAllMissions()
        {
            List<String> missions = new List<string>();
            foreach (String name in dictionary)
            {
                missions.Add(name);
            }
            return missions;
        }

        // Define the indexer to allow client code to use [] notation.
        public DoubleToDouble this[String str]
        {
            get { return this.dictionary[str]; }
            set { this.dictionary[str] = value; }
        }
        //a dictionary from string to function double func(double d) with delegate, syntax from google
        // a pointer to a func
        // indexer - syntax from google
        // func printavailable
        // constructor
    }
}
