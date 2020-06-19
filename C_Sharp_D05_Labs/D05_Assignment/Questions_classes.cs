using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace D05_Assignment
{
    abstract class Question
    {

        ///Design a Class to represent the Question Object,
        ///Question is constructed from a Body, Marks, and Header and ……..
        ///

        string body, header;
        int marks;

        public Question(string body = "", string header = "", int marks = 0)
        {
            this.body = body;
            this.header = header;
            this.marks = marks;
        }
    }

    ///We want the application to accept different Question Types,
    ///True or False, Choose One and Choose All
    ///each has a different way off representation. 
    ///

    class TfQuestion : Question
    {
        TfAnswer answer /*= new TfAnswer()*/;
        
        public TfQuestion(string body = "", string header = "",
            int marks = 0 , string modelAnswer = "")
            : base(body, header, marks)
        {
            answer.Body = modelAnswer;

        }
    }

    class ChooseOneQuestion : Question
    {
        public ChooseOneQuestion(string body = "", string header = "", int marks = 0)
            : base(body, header, marks)
        {
        }
    }

    class ChooseAllQuestion : Question
    {
        public ChooseAllQuestion(string body = "", string header = "", int marks = 0)
            : base(body, header, marks)
        {
        }
    }

    class QuestionList<Question> : List<Question>
    {
        public new void Add(Question item)
        {
            base.Add(item);
            //TextWriter
        }

        
    }




}
