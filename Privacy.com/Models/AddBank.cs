using System;
using System.ComponentModel.DataAnnotations;

namespace PrivacyCom.Models
{
    /// <summary>
    /// This is the object used to create bank accounts
    /// </summary>
    public class AddBank
    {
        /// <summary>
        /// Required
        /// The routing number of the bank account
        /// </summary>
        ///  <param name="string"></param>
        [Required(ErrorMessage ="Routing Number is required")]
        public string RoutingNumber { get; set; }

        /// <summary>
        /// Required
        /// The account number of the bank account
        /// </summary>
        ///  <param name="string"></param>
        [Required(ErrorMessage = "Account Number is required")]
        public string AccountNumber { get; set; }


        /// <summary>
        /// Optional
        /// The name associated with the bank account.
        /// This property is only for identification purposes, and has no bearing on the external properties of the bank.
        /// </summary>
        ///  <param name="string"></param>
        public string AccountName { get; set; }
    }
}
