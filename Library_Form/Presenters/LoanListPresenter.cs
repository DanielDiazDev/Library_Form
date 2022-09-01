using Library_Form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Form.Presenters
{
    public class LoanListPresenter
    {
        private ILoanListView _loanListView;
        private Library _library;

        public LoanListPresenter(ILoanListView loanListView)
        {
            this._loanListView = loanListView;
            _library = Library.GetInstance();
            loanListView.FillTable(_library.LoanList);
        }
    }
}
