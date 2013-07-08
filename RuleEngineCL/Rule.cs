// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Rule.cs" company="Softopia">
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

            string[] arr = questionsAndAnswers.Split('#');
            foreach (var s in arr)
            {
                string[] split = s.Split('=');
                string q = split[0];
                KeyValuePair<int, int> kvp;
                if (split.Length == 1)
                {
                    kvp = new KeyValuePair<int, int>();
                }
                else
                {
                    string[] answers = s.Split('=')[1].Split(',');
                    foreach (var answer in answers)
                    {
                        kvp = new KeyValuePair<int, int>(int.Parse(q), int.Parse(answer));
                        result.Add(kvp);
                    }
                }

            }

            return result;
        }
        #endregion
    }
}
