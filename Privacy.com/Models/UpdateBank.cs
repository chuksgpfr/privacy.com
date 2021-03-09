using System;
namespace PrivacyCom.Models
{
    public class UpdateBank
    {
        /// <summary>
        /// 	The token of the bank account to edit.
        /// </summary>
        /// <param name="string"></param>
        public string Token { get; set; }


        /// <summary>
        /// The desired state of the bank account.
        ///If a bank account is set to DELETED, all cards linked to this account will no longer be associated with it.
        ///If there are no other bank accounts in state ENABLED on the account, authorizations will not be accepted on the card until a new funding account is added.
        /// </summary>
        /// <param name="string"></param>
        public string State { get; set; }
    }
}
