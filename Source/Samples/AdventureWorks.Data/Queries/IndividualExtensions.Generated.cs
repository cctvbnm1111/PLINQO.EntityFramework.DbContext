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
    public static partial class IndividualExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static AdventureWorks.Data.Entities.Individual GetByKey(this System.Linq.IQueryable<AdventureWorks.Data.Entities.Individual> queryable, int customerID)
        {
            var dbSet = queryable as System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Individual>;
            if (dbSet != null)
                return dbSet.Find(customerID);
                
            return queryable.FirstOrDefault(i => i.CustomerID == customerID);
        }

        public static IQueryable<AdventureWorks.Data.Entities.Individual> ByDemographics(this IQueryable<AdventureWorks.Data.Entities.Individual> queryable, string demographics)
        {
            return queryable.Where(i => (i.Demographics == demographics || (demographics == null && i.Demographics == null)));
        }

        public static IQueryable<AdventureWorks.Data.Entities.Individual> ByContactID(this IQueryable<AdventureWorks.Data.Entities.Individual> queryable, int contactID)
        {
            return queryable.Where(i => i.ContactID == contactID);
        }
    }
}
