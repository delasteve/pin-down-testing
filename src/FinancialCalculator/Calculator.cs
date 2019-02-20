using System.Collections.Generic;
using System.Linq;

namespace FinancialCalculator
{
    public class Calculator
    {
        public decimal Sum(IList<decimal> numbers)
        {
            // return numbers.Aggregate(0m, (current, next) => current + Math.Round(next, 2, MidpointRounding.AwayFromZero));

            // Michael Bolton and Sumir were here - 2/19/1999
            // PS. Screw Lumbergh!
            return numbers.Aggregate(0m, (current, next) => current + MischievousRounder.Round(next));
        }
    }
}
