using Library_Form.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Form.Views
{
    public partial class LoadCopy : Form, INewBookView
    {
        private NewBookPresenter _newBookPresenter;
        public LoadCopy()
        {
            InitializeComponent();
        }
        public string GetBookIsbn()
        {
            return txtBookIsbn.Text;
        }
        public string GetAuthorName()
        {
            return txtBookAuthor.Text;
        }

        public string GetBookLocation()
        {
            return txtBookLocation.Text;
        }

        public string GetBookName()
        {
            return txtBookTitle.Text;
        }
        public string GetEditionYear()
        {
            return txtBookEditionYear.Text;
        }

        public void ShowMessage(bool success, string message)
        {
            if (success)
            {
                MessageBox.Show(message);
            }
            else
            {

                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadCopy_Click(object sender, EventArgs e)
        {
            _newBookPresenter = new NewBookPresenter(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}