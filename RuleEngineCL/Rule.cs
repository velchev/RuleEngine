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
    using System.Text;

    /// <summary>
    /// The rule.
    /// </summary>
    public class Rule
    {
        public enum SpecialRules
        {
            NotDefined = -1
        }
        #region Properties

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the q and a. (questions and answers)
        /// </summary>
        public List<KeyValuePair<int, int>> QuestionsAndAnswers { get; set; }

        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        public String Result { get; set; }
        #endregion



        #region Methods


        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            var questionsAndAnswers = new StringBuilder();
            foreach (var qestionAndAnswer in QuestionsAndAnswers)
            {
                questionsAndAnswers.Append(string.Format(" #key[{0}], value[{1}]", qestionAndAnswer.Key, qestionAndAnswer.Value));
            }

            return string.Format("Rule [Id:{0}, QuestionsAndAnswers:{1}, Result:{2}]",
                                 this.Id,
                                 questionsAndAnswers,
                                this.Result);
        }

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
                    kvp = new KeyValuePair<int, int>(int.Parse(q), (int)SpecialRules.NotDefined);
                    result.Add(kvp);
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
