using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendApps.DesignPaterns.Memento
{
    internal class Memento
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public DateTime LastEdited { get; set; }
        public Memento(string title, string author, string isbn, DateTime lastEdited) {
            Title= title;
            Author= author; 
            Isbn= isbn;
            LastEdited = lastEdited;
        }  
    }
    internal class Book
    {
       
        private string title;
        private string author;
        private string isbn;
        private DateTime lastEdited;
        public DateTime LastEdited
        {
            get { return lastEdited; }
            set { lastEdited = value;
               
            }
        }
        public Memento CreateUndı()
        {
            return new Memento(title, author, isbn, LastEdited);
        }
        public void RestoreFromUndo(Memento memnto)
        {
            title = memnto.Title;
            author = memnto.Author;
            isbn = memnto.Isbn;
            lastEdited = memnto.LastEdited;
        }
        public void showBook()
        {
            Console.WriteLine("{0},{1},{2} EDİTED {3} ", Isbn, Title, Author, LastEdited.ToString());
        }

        public string Title
        {
            get { return title; }
            set { title = value;
                SetLastEdited();
            }
        }
        public string Author
        {
            get { return author; }
            set { author = value;
                SetLastEdited();
            }
        }
        public string? Isbn
        {
            get { return isbn; }
            set {
                isbn = value;
                SetLastEdited();
            }
        }
        private void SetLastEdited()
        {
            lastEdited = DateTime.UtcNow;    
        }
       
        

    }
    internal class CareTaker
    {
        public Memento? Memento { get; set; }
    }
}
