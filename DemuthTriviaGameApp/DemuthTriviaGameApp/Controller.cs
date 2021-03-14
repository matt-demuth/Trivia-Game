using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemuthTriviaGameApp
{
    class Controller
    {
        public void Play()
        {
            this.Welcome();
            string str;
            do
            {
                Console.Clear();
                if (this.PlayAgain() == 0)
                {
                    str = "N";
                }
                else
                {
                    Console.Write("\n\nWould you like to play again? (Y or N): ");
                    str = Console.ReadLine().ToUpper();
                    if (str.Length > 0)
                        str = str.Substring(0, 1);
                }
            }
            while (str == "Y");
        }

        public int PlayAgain()
        {
            int index = 0;
            int num1 = 0;
            string[] strArray = new string[4];
            Question_Bank questionBank = new Question_Bank();
            try
            {
                num1 = questionBank.ReadFile();
            }
            catch (IOException ex)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine(ex.Message);
            }
            int num2 = 0;
            while (index < num1)
            {
                Console.WriteLine("\n\n\n");
                Console.WriteLine("Question " + (object)(index + 1) + ": \n");
                Console.WriteLine(questionBank.GetQuestion(index));
                string[] answers = questionBank.GetAnswers(index);
                Console.WriteLine("\n  A. " + answers[0] + "\tB. " + answers[1]);
                Console.WriteLine("  C. " + answers[2] + "\tD. " + answers[3]);
                Console.Write("\n\nWhat is your answer: ");
                string upper = Console.ReadLine().ToUpper();
                string correctAnswer = questionBank.GetCorrect(index);
                if (upper == correctAnswer)
                {
                    Console.WriteLine("\nYou are correct!");
                    ++num2;
                }
                else
                    Console.WriteLine("\nSorry you are wrong\nThe correct answer is " + correctAnswer);
                Console.WriteLine("\n" + questionBank.GetAdditionalInfo(index));
                ++index;
                Console.WriteLine("\n\n\nPlease press the Enter key when you are ready to contnue");
                Console.ReadLine();
                Console.Clear();
            }
            if ((uint)num1 > 0U)
            {
                Console.Clear();
                Console.WriteLine("\n\n\n");
                Console.WriteLine("You had " + (object)num2 + " correct answers out of " + (object)num1 + " questions.");
                Console.WriteLine("This gives you a percentage of {0:P}", (object)((double)num2 / (double)num1));
            }
            return num1;
        }

        public void Welcome()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\tLet's play a game of trivia.  You will be shown a series of questions,");
            Console.WriteLine("\tone at a time.  Each question will have four possible answers, only one");
            Console.WriteLine("\tis the correct answer.  Your job is to pick the correct answer.");
            Console.Write("\n\nPress the Enter key when you are ready to begin.  Good Luck     ");
            Console.ReadLine();
        }
    }
}
