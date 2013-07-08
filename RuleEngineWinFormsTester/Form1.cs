using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RuleEngine;
using RuleEngineCL;

namespace RuleEngineWinFormsTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var quetions = DBAccess.LoadQuestions(Environment.CurrentDirectory.Replace("bin\\Debug", "//Data//Questions.xml"));

            foreach (var q in quetions[0].Options)
            {
                chkListAnswers.Items.Add(q.Text,false);
            }
        }

        private void LoadQuestion(Question q)
        {
            
        }
    }
}
