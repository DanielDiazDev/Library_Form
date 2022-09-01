using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Form.Presenters
{
    public interface IReturnBookView
    {
        string GetBookIsbn();
        string GetEditionYear();
        void ShowMessage(bool success, string message);
    }
}
