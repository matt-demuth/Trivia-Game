using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemuthTriviaGameApp
{
    class Question_Unit
    {
        private string[] answer = new string[4];
        private string question;
        private string correct;
        private string info;

        public string Question
        {
            set
            {
                question = value;
            }
            get
            {
                return question;
            }
        }

        public string[] Answer
        {
            set
            {
                answer = value;
            }
            get
            {
                return answer;
            }
        }


        public string Correct
        {
            set
            {
                correct = value;
            }
            get
            {
                return correct;
            }
        }

        public string Info
        {
            set
            {
                info = value;
            }
            get
            {
                return info;
            }
        }
    }
}
