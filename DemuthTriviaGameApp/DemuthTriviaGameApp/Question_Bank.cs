using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemuthTriviaGameApp
{
    class Question_Bank
    {
        private Question_Unit[] questionBank = new Question_Unit[10];
        private string fileName = "Trivia.txt";
        private const int NumberQuestions = 10;
        private const int NumberAnswers = 4;

        public int ReadFile()
        {
            int index1 = 0;
            StreamReader streamReader = new StreamReader(this.fileName);
            for (string str = streamReader.ReadLine(); str != null; str = streamReader.ReadLine())
            {
                this.questionBank[index1] = new Question_Unit();
                this.questionBank[index1].Question = str;
                for (int index2 = 0; index2 < 4; ++index2)
                    this.questionBank[index1].Answer[index2] = streamReader.ReadLine();
                this.questionBank[index1].Correct = streamReader.ReadLine();
                this.questionBank[index1].Info = streamReader.ReadLine();
                ++index1;
            }
            return index1;
        }

        public string GetQuestion(int index)
        {
            return this.questionBank[index].Question;
        }

        public string[] GetAnswers(int index)
        {
            string[] strArray = new string[4];
            return this.questionBank[index].Answer;
        }

        public string GetCorrect(int index)
        {
            return this.questionBank[index].Correct;
        }

        public string GetAdditionalInfo(int index)
        {
            return this.questionBank[index].Info;
        }
    }
}
