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
    public static partial class SalesOrderHeaderExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static AdventureWorks.Data.Entities.SalesOrderHeader GetByKey(this System.Linq.IQueryable<AdventureWorks.Data.Entities.SalesOrderHeader> queryable, int salesOrderID)
        {
            var dbSet = queryable as System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.SalesOrderHeader>;
            if (dbSet != null)
                return dbSet.Find(salesOrderID);
                
            return queryable.FirstOrDefault(s => s.SalesOrderID == salesOrderID);
        }

        /// <summary>
        /// Gets an instance by using a unique index.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        public static AdventureWorks.Data.Entities.SalesOrderHeader GetByRowguid(this IQueryable<AdventureWorks.Data.Entities.SalesOrderHeader> queryable, System.Guid rowguid)
        {
            return queryable.FirstOrDefault(s => s.Rowguid == rowguid);
        }

        /// <summary>
        /// Gets an instance by using a unique index.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        public static AdventureWorks.Data.Entities.SalesOrderHeader GetBySalesOrderNumber(this IQueryable<AdventureWorks.Data.Entities.SalesOrderHeader> queryable, string salesOrderNumber)
        {
            return queryable.FirstOrDefault(s => s.SalesOrderNumber == salesOrderNumber);
        }

        public static IQueryable<AdventureWorks.Data.Entities.SalesOrderHeader> ByCustomerID(this IQueryable<AdventureWorks.Data.Entities.SalesOrderHeader> queryable, int customerID)
        {
            return queryable.Where(s => s.CustomerID == customerID);
        }

        public static IQueryable<AdventureWorks.Data.Entities.SalesOrderHeader> BySalesPersonID(this IQueryable<AdventureWorks.Data.Entities.SalesOrderHeader> queryable, int? salesPersonID)
        {
            return queryable.Where(s => (s.SalesPersonID == salesPersonID || (salesPersonID == null && s.SalesPersonID == null)));
        }

        public static IQueryable<AdventureWorks.Data.Entities.SalesOrderHeader> ByContactID(this IQueryable<AdventureWorks.Data.Entities.SalesOrderHeader> queryable, int contactID)
        {
            return queryable.Where(s => s.ContactID == contactID);
        }

        public static IQueryable<AdventureWorks.Data.Entities.SalesOrderHeader> ByTerritoryID(this IQueryable<AdventureWorks.Data.Entities.SalesOrderHeader> queryable, int? territoryID)
        {
            return queryable.Where(s => (s.TerritoryID == territoryID || (territoryID == null && s.TerritoryID == null)));
        }

        public static IQueryable<AdventureWorks.Data.Entities.SalesOrderHeader> ByBillToAddressID(this IQueryable<AdventureWorks.Data.Entities.SalesOrderHeader> queryable, int billToAddressID)
        {
            return queryable.Where(s => s.BillToAddressID == billToAddressID);
        }

        public static IQueryable<AdventureWorks.Data.Entities.SalesOrderHeader> ByShipToAddressID(this IQueryable<AdventureWorks.Data.Entities.SalesOrderHeader> queryable, int shipToAddressID)
        {
            return queryable.Where(s => s.ShipToAddressID == shipToAddressID);
        }

        public static IQueryable<AdventureWorks.Data.Entities.SalesOrderHeader> ByShipMethodID(this IQueryable<AdventureWorks.Data.Entities.SalesOrderHeader> queryable, int shipMethodID)
        {
            return queryable.Where(s => s.ShipMethodID == shipMethodID);
        }

        public static IQueryable<AdventureWorks.Data.Entities.SalesOrderHeader> ByCreditCardID(this IQueryable<AdventureWorks.Data.Entities.SalesOrderHeader> queryable, int? creditCardID)
        {
            return queryable.Where(s => (s.CreditCardID == creditCardID || (creditCardID == null && s.CreditCardID == null)));
        }

        public static IQueryable<AdventureWorks.Data.Entities.SalesOrderHeader> ByCurrencyRateID(this IQueryable<AdventureWorks.Data.Entities.SalesOrderHeader> queryable, int? currencyRateID)
        {
            return queryable.Where(s => (s.CurrencyRateID == currencyRateID || (currencyRateID == null && s.CurrencyRateID == null)));
        }
    }
}

