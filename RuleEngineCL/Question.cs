// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Question.cs" company="Softopia">
//   
// </copyright>
// <summary>
//   The question.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



namespace RuleEngine
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The question.
    /// </summary>
    public class Question
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Question"/> class.
        /// </summary>
        public Question()
        {
            Options = new List<Option>();

        }
        #endregion

        /// <summary>
        /// Parses the enum.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }

        #region Properties
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        /// <value>
        /// The Id.
        /// </value>
        public int Id { get; set; }
        
        /// <summary>
        /// Gets or sets the step. The sptes represents the sequence of questions.
        /// </summary>
        /// <value>
        /// The step.
        /// </value>
        public int Step { get; set; }

        /// <summary>
        /// Gets or sets the text of the question.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the possible options of the question.
        /// </summary>
        /// <value>
        /// The options.
        /// </value>
        public List<Option> Options { get; set; }

        /// <summary>
        /// Gets or sets the type.[Single Choice, Multiple Choice
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public QuestionType Type { get; set; }
        #endregion

        /// <summary>
        /// Returns string which describes the object
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            return string.Format("Question [Id:{0}, Step:{1}, Text:{2}, Type:{3}]",
                            this.Id, 
                            this.Step, 
                            this.Text,
                            this.Type);
        }

        /// <summary>
        /// Type of the supported questions
        /// </summary>
        public enum QuestionType
        {
            /// <summary>
            /// Single choice Question
            /// </summary>
            SingleChoice = 1,

            /// <summary>
            /// Multiple choice Question
            /// </summary>
            MultipleChoice = 2
        }
    }
}