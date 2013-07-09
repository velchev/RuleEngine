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
                if (r.QuestionsAndAnswers.SequenceEqual(currentSelection))
                {
                    return r.Result;
                }
            }

            foreach (var r in rules)
            {
                foreach (var questionAndAnswer in r.QuestionsAndAnswers)
                {
                    if (questionAndAnswer.Key == currentSelection[0].Key 
                        && questionAndAnswer.Value == (int) Rule.SpecialRules.NotDefined)
                    {
                        return r.Result;
                    }
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

            return currentSelection.Count == (int)Question.QuestionType.SingleChoice;
        }
    }
}