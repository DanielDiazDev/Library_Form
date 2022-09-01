using Library_Form.Presenters;
using Library_Form.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Form
{
    public partial class Main : Form, IMainView
    {
        private MainPresenter _mainPresenter;
        public Main()
        {
            InitializeComponent();
        }

        public void CreateNewBookView()
        {
            new LoadCopy().Show();
        }
        public void CreateNewMemberView()
        {
            new LoadMember().Show();
        }
        public void CreateReturnBookView()
        {
            new ReturnBook().Show();
        }
        public void CreateLoanView()
        {
            new NewLoan().Show();
        }
        public void CreateLoanListView()
        {
            new ConsultLoans().Show();
        }
        public void CreateCopyListView()
        {
            new ConsultCopies().Show();
        }

        private void btnLoadMember_Click(object sender, EventArgs e)
        {
            _mainPresenter = new MainPresenter(this, EnumViews.NewMember);
        }

        private void btnLoadCopy_Click(object sender, EventArgs e)
        {
            _mainPresenter = new MainPresenter(this, EnumViews.NewBook);

        }

        private void btnNewLoan_Click(object sender, EventArgs e)
        {
            _mainPresenter = new MainPresenter(this, EnumViews.NewLoan);

        }

        private void btnConsultLoans_Click(object sender, EventArgs e)
        {
            _mainPresenter = new MainPresenter(this, EnumViews.LoanList);

        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            _mainPresenter = new MainPresenter(this, EnumViews.ReturnBook);

        }

        private void btnConsultCopies_Click(object sender, EventArgs e)
        {
            _mainPresenter = new MainPresenter(this, EnumViews.CopiesList);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
