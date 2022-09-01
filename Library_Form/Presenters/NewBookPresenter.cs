using Library_Form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Form.Presenters
{
    public class NewBookPresenter
    {
        private INewBookView _newBookView;
        private Library _library;


        public NewBookPresenter(INewBookView newBookView)
        {
            this._newBookView = newBookView;
            _library = Library.GetInstance();
            string message = null;
            string title = newBookView.GetBookName();
            string author = newBookView.GetAuthorName();
            string location = newBookView.GetBookLocation();
            if (ValidateBookData(title, author, location))
            {
                try
                {
                    int editionYear = Convert.ToInt32(newBookView.GetEditionYear());
                    long isbn = Convert.ToInt64(newBookView.GetBookIsbn());
                    if (ValidateYear(editionYear))
                    {
                        _library.AddBook(title, isbn, author, editionYear, location, ref message);
                        newBookView.ShowMessage(true, message);
                    }
                    else
                    {
                        message = "El año no es válido.";
                        newBookView.ShowMessage(false, message);
                    }
                }
                catch (FormatException)
                {
                    message = "Los campos Edición e ISBN sólo admiten números";
                    newBookView.ShowMessage(false, message);
                }
                catch (Exception e)
                {
                    message = $"Ha dado un error. \n Error: {e.Message}";
                    newBookView.ShowMessage(false, message);
                }
            }
        }

        private bool ValidateBookData(string title, string author, string location)
        {
            if (title == "" || title == null || author == "" || author == null || location == "" || location == null || _newBookView.GetEditionYear() == "" || _newBookView.GetEditionYear() == null || _newBookView.GetBookIsbn() == "" || _newBookView.GetBookIsbn() == null)
            {
                _newBookView.ShowMessage(false, "Por favor, complete todos los campos.");
                return false;
            }
            else if (_newBookView.GetBookIsbn().Length != 13)
            {
                _newBookView.ShowMessage(false, "El ISBN debe consistir de trece dígitos.");
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