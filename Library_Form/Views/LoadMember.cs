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
    public partial class LoadMember : Form, INewMemberView
    {
        private NewMemberPresenter _newMemberPresenter;
        public LoadMember()
        {
            InitializeComponent();
        }
        public string GetMemberId()
        {
            return txtMemberId.Text;
        }

        public string GetMemberName()
        {
            return txtMemberName.Text;
        }

        public string GetMemberLastName()
        {
            return txtMemberLastName.Text;
        }

        public bool GetVipMember()
        {
            return rbVip.Checked;
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

        private void btnLoadMember_Click(object sender, EventArgs e)
        {
            _newMemberPresenter = new NewMemberPresenter(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
