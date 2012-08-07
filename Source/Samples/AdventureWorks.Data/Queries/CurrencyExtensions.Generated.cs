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
    public static partial class CurrencyExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static AdventureWorks.Data.Entities.Currency GetByKey(this System.Linq.IQueryable<AdventureWorks.Data.Entities.Currency> queryable, string currencyCode)
        {
            var dbSet = queryable as System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Currency>;
            if (dbSet != null)
                return dbSet.Find(currencyCode);
                
            return queryable.FirstOrDefault(c => c.CurrencyCode == currencyCode);
        }

        /// <summary>
        /// Gets an instance by using a unique index.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        public static AdventureWorks.Data.Entities.Currency GetByName(this IQueryable<AdventureWorks.Data.Entities.Currency> queryable, string name)
        {
            return queryable.FirstOrDefault(c => c.Name == name);
        }
    }
}

