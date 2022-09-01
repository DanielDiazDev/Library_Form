using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Form.Presenters
{
    public interface INewBookView
    {
        string GetBookIsbn();
        string GetAuthorName();
        string GetBookLocation();
        string GetBookName();
        string GetEditionYear();
        void ShowMessage(bool success, string message);


    }
}
