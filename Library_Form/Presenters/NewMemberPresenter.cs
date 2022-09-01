using Library_Form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Form.Presenters
{
    public class NewMemberPresenter
    {
        private INewMemberView _newMemberView;
        private Library _library;

        public NewMemberPresenter(INewMemberView newMemberView)
        {
            this._newMemberView = newMemberView;
            _library = Library.GetInstance();
            string message = null;
            string memberName;
            string memberLastName;
            int memberId;
            bool vip;
            memberName = newMemberView.GetMemberName();
            memberLastName = newMemberView.GetMemberLastName();
            vip = newMemberView.GetVipMember();
            if (ValidateMemberData(memberName, memberLastName))
            {
                try

                {
                    memberId = Convert.ToInt32(newMemberView.GetMemberId());
                    newMemberView.ShowMessage(_library.AddMember(memberName, memberLastName, memberId, vip, ref message), message);
                }
                catch (FormatException)
                {
                    message = "El campo ID sólo admite números";
                    newMemberView.ShowMessage(false, message);
                }
            }

        }

        private bool ValidateMemberData(string name, string lastName)
        {
            if (name == "" || name == null || lastName == "" || lastName == null || _newMemberView.GetMemberId() == "" || _newMemberView.GetMemberId() == null)
            {
                _newMemberView.ShowMessage(false, "Por favor, complete todos los campos");
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}