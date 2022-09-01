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
    public partial class ConsultCopies : Form, IAvailableCopiesView
    {
        private AvailableCopiesPresenter _availablesCopiesPresenter;
        public ConsultCopies()
        {
            InitializeComponent();
        }
        public void FillTable(List<Copy> copiesList)
        {
            if (copiesList != null)
            {
                for (int i = 0; i < copiesList.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = copiesList[i].Name;
                    dataGridView1.Rows[i].Cells[1].Value = copiesList[i].Isbn;
                    dataGridView1.Rows[i].Cells[2].Value = copiesList[i].EditionYear;
                    dataGridView1.Rows[i].Cells[3].Value = copiesList[i].Location;
                    dataGridView1.Rows[i].Cells[4].Value = copiesList[i].AuthorName;
                }
            }
        }
        public string GetIsbn()
        {
            return txtIsbn.Text;
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _availablesCopiesPresenter = new AvailableCopiesPresenter(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}