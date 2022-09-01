using Library_Form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Form.Presenters
{
    public class LoanPresenter
    {
        private ILoanView _loanView;
        private Library _library;

        public LoanPresenter(ILoanView loanView)
        {
            this._loanView = loanView;
            _library = Library.GetInstance();
            try
            {
                int memberId = Convert.ToInt32(loanView.GetMemberId());
                long bookIsbn = Convert.ToInt64(loanView.GetBookIsbn());
                string message = null;
                loanView.ShowMessage(_library.AddLoan(memberId, bookIsbn, ref message), message);
            }
            catch (FormatException)
            {
                loanView.ShowMessage(false, "Los campos solo permiten numeros");
            }
        }
    }
}
