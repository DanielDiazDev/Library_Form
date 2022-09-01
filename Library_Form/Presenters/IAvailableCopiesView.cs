using Library_Form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Form.Presenters
{
    public interface IAvailableCopiesView
    {
         void FillTable(List<Copy> copiesList);
         string GetIsbn();
         void ShowMessage(string message);
    }
}
