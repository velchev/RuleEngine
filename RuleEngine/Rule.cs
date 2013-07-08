using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngine
{
    public class Rule
    {
        public int ID { get; set; }
        public List<KeyValuePair<int, int>> QandA { get; set; }
        public String Result { get; set; }

        public static List<KeyValuePair<int, int>> ParseQandA(string qanda)
        {
            List<KeyValuePair<int, int>> result = new List<KeyValuePair<int, int>>();

            KeyValuePair<int, int> kvp;

            String[] arr = qanda.Split('#');
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
    }
}
