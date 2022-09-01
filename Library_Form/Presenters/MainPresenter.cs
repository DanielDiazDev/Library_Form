using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Form.Presenters
{
    public class MainPresenter
    {
        private IMainView _mainView;
        public MainPresenter(IMainView mainView, EnumViews eView)
        {
            this._mainView = mainView;
            switch (eView)
            {
                case EnumViews.NewMember:
                    this._mainView.CreateNewMemberView();
                    break;
                case EnumViews.NewBook:
                    this._mainView.CreateNewBookView();
                    break;

                case EnumViews.NewLoan:
                    this._mainView.CreateLoanView();
                    break;
                case EnumViews.LoanList:
                    this._mainView.CreateLoanListView();
                    break;
                case EnumViews.ReturnBook:
                    this._mainView.CreateReturnBookView();
                    break;
                case EnumViews.CopiesList:
                    this._mainView.CreateCopyListView();
                    break;
                default:
                    break;
            }
        }
    }
}
