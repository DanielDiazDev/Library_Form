using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Form.Presenters
{
    public interface IMainView
    {
        void CreateLoanView();
        void CreateLoanListView();
        void CreateReturnBookView();
        void CreateNewMemberView();
        void CreateNewBookView();
        void CreateCopyListView();
    }
}
