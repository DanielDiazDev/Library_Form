using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Form.Presenters
{
    public interface ILoanView
    {
        string GetMemberId();
        string GetBookIsbn();
        void ShowMessage(bool success, string result);
    }
}
