using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Form.Models
{
    public class Book
    {
        //Atributos
        protected string name;
        protected long isbn;
        protected string authorName;
        private Queue<Copy> _copiesList;

        //Propiedades
        public Queue<Copy> CopiesList { get => _copiesList; }
        public string Name { get => name; }
        public long Isbn { get => isbn; }
        public string AuthorName { get => authorName; }

        //Constructor
        public Book(string name, long isbn, string authorName)
        {
            this.name = name;
            this.isbn = isbn;
            this.authorName = authorName;
            _copiesList = new Queue<Copy>();
        }

        //Metodos
        public void AddCopy(int editionYear, string location)
        {
            _copiesList.Enqueue(new Copy(name, isbn, authorName, editionYear, location));
        }
        public void AddCopy(Copy copy)
        {
            _copiesList.Enqueue(copy);
        }
        public bool AvailableCopies()
        {
            return _copiesList != null && _copiesList.Count > 0;
        }
        public Copy BorrowCopy()
        {
            return _copiesList.Dequeue();
        }
        public void ReturnCopy(Copy c)
        {
            _copiesList.Enqueue(c);
        }
    }
}
