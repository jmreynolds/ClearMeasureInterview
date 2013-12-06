using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OurCoolThings
{
    public class Utilities
    {


        public static IEnumerable<string> FizzBuzzer(int firstNumber, int lastNumber, List<ReplacementRules> replacementRules)
        {
            
            for (int i = firstNumber; i < lastNumber+1; i++)
            {
                string outPut = i.ToString();

                foreach (var replacementRule in replacementRules)
                {
                    if (replacementRule.Divisors.Count == 1)
                    {
                        if (i%replacementRule.Divisors.First() == 0) outPut = replacementRule.Label;
                    }
                    else
                    {
                        var success = false;
                        foreach (var divisor in replacementRule.Divisors)
                        {
                            if(i%divisor!=0) 
                            {
                                success=false;
                                break;
                            }
                            success = true;
                        }
                        if (success) outPut = replacementRule.Label;
                    }
                        
                }

                //if (i%3 == 0) outPut = "Fizz";
                //if (i%5 == 0) outPut = "Buzz";
                //if (i%3 == 0 && i%5 == 0) outPut = "FizzBuzz";
                yield return outPut;
            }
        }
    }

    public class ReplacementRules
    {
        public ReplacementRules()
        {
            Divisors = new List<int>();
            Label = string.Empty;
        }
        public List<int> Divisors { get; set; }
        public string Label { get; set; }
    }
}