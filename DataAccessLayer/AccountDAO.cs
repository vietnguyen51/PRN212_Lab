using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AccountDAO
    {
        public AccountMember<> GetAccountById(string accountID)
        {
            AccountMember member = new AccountMember();
            if (accountID.Equals("PS0001"))
            {
                member.MemberId = accountID;
                member.MemberPassword = "@1";
                member.MemberRole = 1;
            }
            return member;
        }
    }
}
