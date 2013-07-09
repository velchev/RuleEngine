// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DBAccess.cs" company="Softopia">
//   
// </copyright>
// <summary>
//   Defines the DBAccess type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RuleEngineCL
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using RuleEngine;

    /// <summary>
    /// Something like DB layer which works with the data - it could be XML or Relational Database
    /// </summary>
    public class DBAccess
    {
        /// <summary>
        /// The load questions.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns>
        /// The <see cref="List" />.
        /// </returns>
        public static List<Question> LoadQuestions(string filePath)
        {
            var quetions = new List<Question>();
            var xelement = XElement.Load(filePath);
            var elements = xelement.Elements();
            foreach (var element in elements)
            {
                var question = new Question();
                question.Id = int.Parse(element.Element("Id").Value);
                question.Text = element.Element("Text").Value;
                question.Type = Question.ParseEnum<Question.QuestionType>(element.Attribute("Type").Value);
                foreach (var xElement in element.Element("Options").Elements("Option").ToList())
                {
                    var option = new Option();
                    option.Id = int.Parse(xElement.Element("Id").Value);
                    option.Text = xElement.Element("Text").Value;

                    question.Options.Add(option);
                }
                quetions.Add(question);
            }

            return quetions;
        }

        /// <summary>
        /// The load rules.
        /// </summary>
        /// <param name="filePath">
        /// The file path.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public static List<Rule> LoadRules(string filePath)
        {
            var rules = new List<Rule>();
            var rElement = XElement.Load(filePath);
            var rElements = rElement.Elements();

            foreach (var element in rElements)
            {
                var rule = new Rule();
                rule.Id = int.Parse(element.Element("Id").Value);
                rule.Result = element.Element("Result").Value;
                rule.QuestionsAndAnswers = Rule.ParseQestionsAndAnswers(element.Element("Qestions").Value);
                rules.Add(rule);
            }

            return rules;
        }
    }
}