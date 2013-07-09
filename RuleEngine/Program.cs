// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Softopia">
//   
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RuleEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using RuleEngineCL;

    /// <summary>
    /// The program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        static void Main(string[] args)
        {
            var quetions = DBAccess.LoadQuestions(Environment.CurrentDirectory.Replace("bin\\Debug", "\\Data\\Questions.xml"));
            foreach (var q in quetions)
            {
                Console.WriteLine(q.ToString());
            }

            var rules = DBAccess.LoadRules(Environment.CurrentDirectory.Replace("bin\\Debug", "\\Data\\Rules.xml"));
            foreach (var r in rules)
            {
                Console.WriteLine(r.ToString());
            }

            Console.WriteLine();

            var testResult = new List<KeyValuePair<int, int>>();
            testResult.Add(new KeyValuePair<int, int>(1, 1));
            //testResult.Add(new KeyValuePair<int, int>(1, 2));
            //testResult.Add(new KeyValuePair<int, int>(2, 1));

            //foreach (var r in rules)
            //{
            //    if (r.QuestionsAndAnswers.SequenceEqual(testResult))
            //    {
            //        Console.Write(r.Result);
            //    }
            //}
            //Console.WriteLine();


            //string s = Answer.Evaluate(testResult, rules);
            //Console.WriteLine(s);


            //testResult.Clear();
            //testResult.Add(new KeyValuePair<int, int>(3, 1));
            //testResult.Add(new KeyValuePair<int, int>(3, 2));
            //testResult.Add(new KeyValuePair<int, int>(3, 3));
            //testResult.Add(new KeyValuePair<int, int>(2, 1));

            //Console.WriteLine(Answer.Evaluate(testResult, rules));

            //var selection = new List<KeyValuePair<int, int>>
            //    {
            //        new KeyValuePair<int, int>(1, 1),
            //        new KeyValuePair<int, int>(1, 2)
            //    };

            //Console.WriteLine(Answer.ValidateCurrentAnswer(selection, quetions[0]) ? "Is valid" : "Is not valid");


            testResult.Clear();
            testResult.Add(new KeyValuePair<int, int>(1, 1));
            testResult.Add(new KeyValuePair<int, int>(1, 212)); 
            //if there is no rule for that question will return the default rule, even if there are more rules and other defaults for the otehr rules
            testResult.Add(new KeyValuePair<int, int>(4, 1));
            Console.WriteLine(Answer.Evaluate(testResult, rules));


            //Test all the questions of the quiz
            testResult.Clear();
            testResult.Add(new KeyValuePair<int, int>(1, 1));
            testResult.Add(new KeyValuePair<int, int>(2, 1));
            testResult.Add(new KeyValuePair<int, int>(3, 1));
            testResult.Add(new KeyValuePair<int, int>(3, 2));
            testResult.Add(new KeyValuePair<int, int>(4, 3));
            Console.WriteLine(Answer.Evaluate(testResult, rules));


        }
    }
}
