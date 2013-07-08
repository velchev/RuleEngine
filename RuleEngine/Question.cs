using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngine
{
    public class Question
    {
        public int ID { get; set; }
        public int Step { get; set; }
        public string Text { get; set; }
        List<Option> Options { get; set; }
        public QuestionType Type { get; set; }

        public override string ToString()
        {
            return string.Format("ID:{0}, Step:{1}, Text:{2}, Type:{3}", ID.ToString(), Step.ToString(), Text,
                                 Type);
        }

        public enum QuestionType
        {
            SingleChoice,
            MultipleChoice,
            WrittenAnswer
        }

        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
