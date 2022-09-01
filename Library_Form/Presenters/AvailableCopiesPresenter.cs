using Library_Form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Form.Presenters
{
    public class AvailableCopiesPresenter
    {
        private IAvailableCopiesView _availableCopiesView;
        private Library _library;

        public AvailableCopiesPresenter(IAvailableCopiesView availableCopiesView)
        {
            this._availableCopiesView = availableCopiesView;
            _library = Library.GetInstance();
            if(availableCopiesView.GetIsbn().Length == 13)
            {
                try
                {
                    long isbn = Convert.ToInt64(_availableCopiesView.GetIsbn());
                    List<Copy> copiesList = _library.FindBook(isbn).CopiesList.ToList<Copy>();
                    if(copiesList != null)
                    {
                        availableCopiesView.FillTable(copiesList);
                    }
                }
                catch
                {
                    availableCopiesView.ShowMessage("El ISBN tiene que tener solo numeros");
                }
            }
            else
            {
                availableCopiesView.ShowMessage("El ISBN solo puede tener 13 digitos");
            }
        }
    }
}
