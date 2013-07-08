using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using RuleEngine;

namespace RuleEngineCL
{
    /// <summary>
    /// 
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
            XElement xelement = XElement.Load(filePath);
            IEnumerable<XElement> elements = xelement.Elements();
            foreach (var element in elements)
            {
                var question = new Question();
                question.ID = int.Parse(element.Element("ID").Value);
                question.Text = element.Element("Text").Value;
                question.Type = Question.ParseEnum<Question.QuestionType>(element.Attribute("Type").Value);
                foreach (var xElement in element.Element("Options").Elements("Option").ToList())
                {
                    var option = new Option();
                    option.ID = int.Parse(xElement.Element("ID").Value);
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
                rule.ID = int.Parse(element.Element("ID").Value);
                rule.Result = element.Element("Result").Value;
                rule.QandA = Rule.ParseQestionsAndAnswers(element.Element("Qestions").Value);
                rules.Add(rule);
            }

            return rules;
        }
    }
}
