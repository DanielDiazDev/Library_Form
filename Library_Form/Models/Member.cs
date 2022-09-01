using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Form.Models
{
    public class Member
    {
        protected string name;
        protected string lastName;
        protected int idNumber;
        protected List<Copy> borrowedCopies;
        protected int borrowMax = 1;

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int IdNumber { get => idNumber; set => idNumber = value; }
        public List<Copy> BorrowedCopies { get => borrowedCopies; set => borrowedCopies = value; }
        public int BorrowMax { get => borrowMax; set => borrowMax = value; }

        public Member(string name, string lastName, int idNumber)
        {
            this.name = name;
            this.lastName = lastName;   
            this.idNumber = idNumber;
            BorrowedCopies = new List<Copy>();
        }
        public bool CanBorrow()
        {
            return BorrowedCopies.Count < BorrowMax;
        }
        public void Borrow(Copy copy)
        {
            BorrowedCopies.Add(copy);
        }
        public Copy ReturnCopy(Copy copy)
        {
            Copy aux = BorrowedCopies.Find(x => x.Isbn == copy.Isbn && x.EditionYear == copy.EditionYear);
            BorrowedCopies.Remove(aux);
            return aux;
        }
    }
}
