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
using System.Linq;
using System.Text;

namespace AdventureWorks.Data.Queries
{
    public static partial class CreditCardExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static AdventureWorks.Data.Entities.CreditCard GetByKey(this System.Linq.IQueryable<AdventureWorks.Data.Entities.CreditCard> queryable, int creditCardID)
        {
            var dbSet = queryable as System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.CreditCard>;
            if (dbSet != null)
                return dbSet.Find(creditCardID);
                
            return queryable.FirstOrDefault(c => c.CreditCardID == creditCardID);
        }

        /// <summary>
        /// Gets an instance by using a unique index.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        public static AdventureWorks.Data.Entities.CreditCard GetByCardNumber(this IQueryable<AdventureWorks.Data.Entities.CreditCard> queryable, string cardNumber)
        {
            return queryable.FirstOrDefault(c => c.CardNumber == cardNumber);
        }
    }
}

