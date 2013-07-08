using System;
using System.Collections.Generic;
using System.Linq;

namespace RuleEngineCL
{
    /// <summary>
    /// 
    /// </summary>
    public class Answer
    {
        /// <summary>
        /// Evaluates the specified current selection.
        /// </summary>
        /// <param name="currentSelection">The current selection.</param>
        /// <param name="rules">The rules.</param>
        /// <returns></returns>
        public static String Evaluate(List<KeyValuePair<int, int>> currentSelection, List<Rule> rules)
        {
            foreach (var r in rules)
            {
                if (r.QandA.SequenceEqual(currentSelection))
                {
                    return r.Result;
                }
            }
            return "Not defined result";
        }
    }
}