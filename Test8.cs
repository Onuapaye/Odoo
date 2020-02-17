using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OdooTest
{
    class Test8
    {

        public void MatchOdooExpression()
        {
            string[] odooText = { "Odoo", "#rules", "I am bismark" };

            foreach (string element in odooText)
            {
                bool result = IsAMatch(element);
                //Console.WriteLine("isMatch => " + x);

                if (result)
                {
                    Console.WriteLine("A match is found as " + '\"' + element + '\"');
                }
                else
                {
                    Console.WriteLine("A match is not found as " + '\"' + element + '\"');
                }
            }
        }

        private bool IsAMatch(string odooText)
        {
            string regXPattern = @"(Odoo|#rules)"; // or "/(Odoo|#rules)/gm) for reg tester
            Regex regEx = new Regex(regXPattern);
            //Match match = regEx.Match(odooText);

            if (regEx.IsMatch(odooText))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
