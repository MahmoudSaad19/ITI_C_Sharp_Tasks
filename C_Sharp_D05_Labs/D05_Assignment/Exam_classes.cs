using System;
using System.Collections.Generic;
using System.Text;

namespace D05_Assignment
{
    abstract class Exam
    {
        ///Design a Base class: Exam, exam class describe the common attributes
        ///concerning the exam, Time, number of Questions,
        ///

        int Time , numberofQuestions;
        Answer answer;

        protected Exam(int time = 0, int numberofQuestions = 1)
        {
            Time = time;
            this.numberofQuestions = numberofQuestions;
        }

    }

    ///We have two types of Exams , Practice Exam and Final Exam ,
    ///Practice exam shows the right answer after finishing taking the Exam ,
    ///while the Final Exam Only Shows The Question and Answers . 
    ///

    class PracticeExam : Exam
    {
        public PracticeExam(int time = 0, int numberofQuestions = 1) 
            : base(time, numberofQuestions)
        {
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void showsRightAnswer() { }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    class FinalExam : Exam
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void ShowQuestions_Answers () { }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
