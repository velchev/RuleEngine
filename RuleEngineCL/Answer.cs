// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Answer.cs" company="Softopia">
//   
// </copyright>
// <summary>
//   Answer
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RuleEngineCL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using RuleEngine;

    /// <summary>
    /// Answer
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
                //if there is no rule - then this is the default rule
                //if (r.QandA.Count == 0)
                //{
                //    return r.Result;
                //}

                if (r.QandA.SequenceEqual(currentSelection))
                {
                    return r.Result;
                }
            }

            
            return "Not defined result";
        }

        /// <summary>
        /// The validate current answer.
        /// </summary>
        /// <param name="currentSelection">
        /// The current selection.
        /// </param>
        /// <param name="question">
        /// The question.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public static bool ValidateCurrentAnswer(List<KeyValuePair<int, int>> currentSelection, Question question)
        {
            if (question.Type == Question.QuestionType.MultipleChoice)
            {
                return true;
            }

            if (currentSelection.Count > 1)
            { 
                return false;
            }
            
            return true;
        }
    }
}