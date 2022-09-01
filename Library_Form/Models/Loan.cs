using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Form.Models
{
    public class Loan
    {
        private Copy _copy;
        private Member _member;
        private DateTime _loanDate;
        private DateTime _expireDate;
        private bool _returned;

        public Copy Copy { get => _copy; set => _copy = value; }
        public Member Member { get => _member; set => _member = value; }
        public DateTime LoanDate { get => _loanDate; set => _loanDate = value; }
        public DateTime ExpireDate { get => _expireDate; set => _expireDate = value; }
        public bool Returned { get => _returned; set => _returned = value; }

        public Loan(Member member, Copy copy)
        {
            this._member = member;
            this._copy = copy;
            _loanDate = DateTime.Now;
            _expireDate = _loanDate.AddDays(5);
            _returned = false;
        }
    }
}
