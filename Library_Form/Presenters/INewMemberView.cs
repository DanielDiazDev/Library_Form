using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Form.Presenters
{
    public interface INewMemberView
    {
        void ShowMessage(bool success, string message);
        string GetMemberName();
        string GetMemberLastName();
        string GetMemberId();
        bool GetVipMember();
    }
}
