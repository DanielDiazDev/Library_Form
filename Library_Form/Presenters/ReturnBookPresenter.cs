using Library_Form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Form.Presenters
{
    public class ReturnBookPresenter
    {
        private IReturnBookView _returnBookView;
        private Library _library;

        public ReturnBookPresenter(IReturnBookView returnBookView)
        {
            this._returnBookView = returnBookView;
            _library = Library.GetInstance();
            string message = null;
            if (ValidateBookData())
            {
                try
                {
                    int editionYear = Convert.ToInt32(returnBookView.GetEditionYear());
                    long isbn = Convert.ToInt64(returnBookView.GetBookIsbn());
                    if (ValidateYear(editionYear))
                    {
                        _library.ReturnBook(isbn, editionYear, ref message);
                        returnBookView.ShowMessage(true, message);
                    }
                    else
                    {
                        message = "El año ingresado no es válido.";
                        returnBookView.ShowMessage(false, message);
                    }
                }
                catch (FormatException)
                {
                    message = "Los campos Edición e ISBN sólo admiten números";
                    returnBookView.ShowMessage(false, message);
                }
                catch (Exception e)
                {
                    message = $"Se ha producido un error. \n Error: {e.Message}";
                    returnBookView.ShowMessage(false, message);
                }
            }
        }

        private bool ValidateBookData()
        {
            if (_returnBookView.GetEditionYear() == "" || _returnBookView.GetEditionYear() == null || _returnBookView.GetBookIsbn() == "" || _returnBookView.GetBookIsbn() == null)
            {
                _returnBookView.ShowMessage(false, "Por favor, complete todos los campos.");
                return false;
            }
            else if (_returnBookView.GetBookIsbn().Length != 13)
            {
                _returnBookView.ShowMessage(false, "El ISBN debe consistir de trece dígitos.");
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ValidateYear(int editionYear)
        {
            return editionYear <= DateTime.Now.Year;
        }

    }


}