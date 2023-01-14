using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendApps.Mediator
{
    internal class Mediator
    {
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }
       
        
        public void UpdateImage(string ırl)
        {
            foreach(var student in Students)
            {
                student.ReceiveImage(ırl);
            }
        }
        public void SendQuestion(string question ,Student student)
        {
            Teacher.ReveiveQuestion(question, student);
        }
        public void RecieevAnswer(string answer,Student student)
        {
            student.RecieevAnswer(answer);
        }
    
    }
    internal abstract class CıurseMember
    {
        protected Mediator Mediator;

        public CıurseMember(Mediator mediator)
        {
            Mediator = mediator;
        }
    }
    internal class Teacher : CıurseMember
    {
       
        public string Name { get; set; }
        public Teacher(Mediator mediator)
            :base(mediator)
        {
           
        }

        internal void ReveiveQuestion(string question, Student student)
        {
            Console.WriteLine("Teacjer receive question from {0},{1}",student.Name, question);
        }
        public void SendNewImage(string url)
        {
            Console.WriteLine("Teacher new send  new  slide {0}", url);
            Mediator.UpdateImage(url);
        }
        public void Answerquestion(string Answer,Student Student)
        {
            Console.WriteLine("Teacher answeer question {0},{1}", Answer, Student.Name);
        }
    }
    internal class Student : CıurseMember
    {
        public Student(Mediator mediator) : base(mediator)
        {
        }

        public string  Name { get;  set; }

        internal void ReceiveImage(string  url)
          
        {
            Console.WriteLine("{1} Student receive image {0}" , url, Name);
        }

        internal void RecieevAnswer(string answer)
        {
            Console.WriteLine("Student receive answer {0}", answer);
        }
    }
}


