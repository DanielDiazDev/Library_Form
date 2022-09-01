using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Form.Models
{
    public class VipMember : Member
    {
        private int _monthlyPremium;

        public int MonthlyPremium { get => _monthlyPremium; set => _monthlyPremium = value; }
        public VipMember(string name, string lastName, int idNumber) : base(name, lastName, idNumber)
        {
            this.BorrowMax = 3;
        }
    }
}
