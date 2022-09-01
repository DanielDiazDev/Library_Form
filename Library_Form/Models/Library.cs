using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Form.Models
{
    public class Library
    {
        private List<Book> _bookList;
        private List<Member> _memberList;
        private List<Loan> _loanList;
        private static Library _instance;

        public List<Book> BookList { get => _bookList; set => _bookList = value; }
        public List<Member> MemberList { get => _memberList; set => _memberList = value; }
        public List<Loan> LoanList { get => _loanList; set => _loanList = value; }
        public static Library Instance { get => _instance; set => _instance = value; }

        public Library()
        {
            _bookList = new List<Book>();
            _memberList = new List<Member>();
            _loanList = new List<Loan>();
        }
        public static Library GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Library();
            }
            return _instance;
        }
        public Book FindBook(long isbn)
        {
            return _bookList.Find(x => x.Isbn == isbn);
        }
        public bool AddLoan(int memberId, long isbn, ref string message)
        {
            Member member = _memberList.Find(x => x.IdNumber == memberId);
            if(member == null)
            {
                message = "El numero ID del socio no se encuentra en el registro";
                return false;
            }
            else if (!member.CanBorrow())
            {
                message = "El socio a superado el limite de prestamos solicitados";
                return false;
            }
            Book book = _bookList.Find(x => x.Isbn == isbn);
            if(book == null)
            {
                message = "El libro no se encuentra en el registro";
                return false;
            }
            else if (!book.AvailableCopies())
            {
                message = "El libro no posee copias disponibles para prestamos";
                return false;
            }
            else
            {
                Copy copy = book.BorrowCopy();
                _loanList.Add(new Loan(member, copy));
                member.Borrow(copy);
                message = $"Se genero el prestamo del libro de manera correcta: \n Titulo: {copy.Name} \n Autor: {copy.AuthorName} \n Edicion: {copy.EditionYear} \n ISBN: {copy.Isbn}";
                return true;
            }
        }
        public void AddBook(string name, long isbn, string authorName, int editionYear, string location, ref string message)
        {
            Book book = _bookList.Find(x => x.Isbn == isbn);
            if( book == null)
            {
                book = new Book(name, isbn, authorName);
                _bookList.Add(book);
            }
            book.AddCopy(editionYear, location);
            message = "El ejemplar fue cargado correctamente";
        }
        public bool AddMember(string name, string lastName, int idNumber, bool vip, ref string message)
        {
            Member member = _memberList.Find(x => x.IdNumber == idNumber);
            if( member == null)
            {
                if (vip)
                {
                    _memberList.Add(new VipMember(name, lastName, idNumber));
                }
                else
                {
                    _memberList.Add(new Member(name, lastName, idNumber));
                }
                message = "El usuario fue cargado con exito";
                return true;
            }
            else
            {
                message = "El ID ya se encuentra registrado";
                return false;
            }
        }

        public bool ReturnBook(long isbn, int editionYear, ref string message)
        {
            Book book = _bookList.Find(x => x.Isbn == isbn);
            if(book == null)
            {
                message = "El libro no se encuentra registrado en el sistema";
                return false;
            }
            else
            {
                Loan loan = _loanList.Find(x=> x.Copy.Isbn == isbn && x.Copy.EditionYear == editionYear);
                if(loan == null)
                {
                    message = "El ejemplar no se encuentra registrado como prestado";
                    return false;
                }
                else
                {
                    Copy copy = loan.Copy;
                    Member member = loan.Member;
                    book.ReturnCopy(copy);
                    member.ReturnCopy(copy);
                    loan.Returned = true;
                    message = "El ejemplar fue devuelto demanera correcta";
                    return true;
                }
            }
        }
    }
}
