using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework_0._0.Classes
{
    [Serializable]
    public class ManageQuestions
    {
        string questions, correctAnswer, incorrectAnswer1, incorrectAnswer2, incorrectAnswer3;
        bool askedBefore = false;
  
        public ManageQuestions() //Creates question without parameters
        {
            questions = "";
            correctAnswer = "";
            askedBefore = false;
        }
        public ManageQuestions(string questions, string correctAnswer) //Creates question with parameters
        {
            Question = questions;
            CorrectAnswer = correctAnswer;
            AskedBefore = false;
            IncorrectAnswer1 = incorrectAnswer1;
            IncorrectAnswer2 = incorrectAnswer2;
            IncorrectAnswer3 = incorrectAnswer3;
        }
        public string Question
        {
            get { return questions; }
            set { questions = value; }
        }
        public string CorrectAnswer
        {
            get { return correctAnswer; }
            set { correctAnswer = value; }
        }
        public string IncorrectAnswer1
        {
            get { return incorrectAnswer1; }
            set { incorrectAnswer1 = value; }
        }
        public string IncorrectAnswer2
        {
            get { return incorrectAnswer2; }
            set { incorrectAnswer2 = value; }
        }
        public string IncorrectAnswer3
        {
            get { return incorrectAnswer3; }
            set { incorrectAnswer3 = value; }
        }
        public bool AskedBefore
        {
            get { return askedBefore; }
            set { askedBefore = value; }
        }
    }


}
