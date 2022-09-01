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
    public partial class NewLoan : Form, ILoanView
    {
        private LoanPresenter _loanPresenter = null;
        public NewLoan()
        {
            InitializeComponent();
        }
        public string GetMemberId()
        {
            return txtMemberId.Text;
        }

        public string GetBookIsbn()
        {
            return txtBookIsbn.Text;
        }

        public void ShowMessage(bool success, string result)
        {
            if (success)
            {
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewLoan_Click(object sender, EventArgs e)
        {
            _loanPresenter = new LoanPresenter(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}