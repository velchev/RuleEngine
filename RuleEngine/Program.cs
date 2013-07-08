using System;
using System.Collections.Generic;
using System.Linq;
using RuleEngineCL;

namespace RuleEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var quetions = DBAccess.LoadQuestions(Environment.CurrentDirectory.Replace("bin\\Debug", "//Data//Questions.xml"));
            foreach (var q in quetions)
            {
                Console.WriteLine(q.ToString());
            }

            var rules = DBAccess.LoadRules(Environment.CurrentDirectory.Replace("bin\\Debug", "//Data//Rules.xml"));
            foreach (var r in rules)
            {
                Console.Write(r.ID);
            }

            Console.WriteLine();

            var testResult = new List<KeyValuePair<int, int>>();
            testResult.Add(new KeyValuePair<int, int>(1, 1));
            //testResult.Add(new KeyValuePair<int, int>(1, 2));
            //testResult.Add(new KeyValuePair<int, int>(2, 1));

            foreach (var r in rules)
            {
                if (r.QandA.SequenceEqual(testResult))
                {
                    Console.Write(r.Result);
                }
            }
            Console.WriteLine();


            string s = Answer.Evaluate(testResult, rules);
            Console.WriteLine(s);


            testResult.Clear();
            testResult.Add(new KeyValuePair<int, int>(3, 1));
            testResult.Add(new KeyValuePair<int, int>(3, 2));
            testResult.Add(new KeyValuePair<int, int>(3, 3));
            testResult.Add(new KeyValuePair<int, int>(2, 1));

            Console.WriteLine(Answer.Evaluate(testResult, rules));
        }
    }
}
