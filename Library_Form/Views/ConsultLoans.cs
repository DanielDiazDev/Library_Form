using Library_Form.Models;
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
    public partial class ConsultLoans : Form, ILoanListView
    {
        private LoanListPresenter _loanListPresenter;
        public ConsultLoans()
        {
            InitializeComponent();
            _loanListPresenter = new LoanListPresenter(this);
        }
        void ILoanListView.FillTable(List<Loan> loanList)
        {
            if (loanList != null)
            {
                for (int i = 0; i < loanList.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = loanList[i].Copy.Name;
                    dataGridView1.Rows[i].Cells[1].Value = loanList[i].Copy.EditionYear;
                    dataGridView1.Rows[i].Cells[2].Value = loanList[i].Member.Name + " " + loanList[i].Member.LastName;
                    dataGridView1.Rows[i].Cells[3].Value = loanList[i].Member.IdNumber;
                    dataGridView1.Rows[i].Cells[4].Value = loanList[i].LoanDate;
                    dataGridView1.Rows[i].Cells[5].Value = loanList[i].ExpireDate;
                    dataGridView1.Rows[i].Cells[6].Value = loanList[i].Returned ? "Si" : "No";
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}