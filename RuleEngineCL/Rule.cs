// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Rule.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Rule type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RuleEngineCL
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The rule.
    /// </summary>
    public class Rule
    {
        #region Properties

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the q and a. (questions and answers)
        /// </summary>
        public List<KeyValuePair<int, int>> QandA { get; set; }

        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        public String Result { get; set; }
        #endregion



        #region Methods

        /// <summary>
        /// Parses the qestions and answers.
        /// </summary>
        /// <param name="questionsAndAnswers">The questions and answers.</param>
        /// <returns></returns>
        public static List<KeyValuePair<int, int>> ParseQestionsAndAnswers(string questionsAndAnswers)
        {
            var result = new List<KeyValuePair<int, int>>();

            KeyValuePair<int, int> kvp;

            string[] arr = questionsAndAnswers.Split('#');
            foreach (var s in arr)
            {
                string q = s.Split('=')[0];
                string[] answers = s.Split('=')[1].Split(',');
                foreach (var answer in answers)
                {
                    kvp = new KeyValuePair<int, int>(int.Parse(q), int.Parse(answer));
                    result.Add(kvp);
                }
            }

            return result;
        }
        #endregion
    }
}
