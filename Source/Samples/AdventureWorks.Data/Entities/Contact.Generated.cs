﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Data.Entities
{
    public partial class Contact
    {
        public Contact()
        {
            Employees = new List<Employee>();
            VendorContacts = new List<VendorContact>();
            CreditCards = new List<CreditCard>();
            Individuals = new List<Individual>();
            SalesOrderHeaders = new List<SalesOrderHeader>();
            StoreContacts = new List<StoreContact>();
        }

        public int ContactID { get; set; }
        public bool NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string EmailAddress { get; set; }
        public int EmailPromotion { get; set; }
        public string Phone { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string AdditionalContactInfo { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<VendorContact> VendorContacts { get; set; }
        public virtual ICollection<CreditCard> CreditCards { get; set; }
        public virtual ICollection<Individual> Individuals { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public virtual ICollection<StoreContact> StoreContacts { get; set; }
    }
}