using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzMVC.Models
{
    public class FizzBuzz
    {
        //I need:

        //Fizzvalue
        public int FizzValue { get; set; } = 3;

        //Buzzvalue
        public int BuzzValue { get; set; } = 5;

        //A way to output my results
        public List<string> Results { get; set; } = new List<string>();
    }

}
