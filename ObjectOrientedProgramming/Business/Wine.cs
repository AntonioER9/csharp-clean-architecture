using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Business
{
    public class Wine : Drink
    {
        private const string Category = "Wine";
        public Wine(int quantity) : base(quantity)
        {
        }
        public override string GetCategory() => Category;

    }
}