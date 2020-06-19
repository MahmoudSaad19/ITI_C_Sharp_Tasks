using System;
using System.Collections.Generic;
using System.Text;

namespace D05_Assignment
{
    abstract class Answer
    {
        string body;

        public string Body { get => body; set => body = value; }
    }

    class TfAnswer : Answer
    {
        
    }

    class AnswerList<Answer> : List<Answer>
    {
        Question question;
    }
}
