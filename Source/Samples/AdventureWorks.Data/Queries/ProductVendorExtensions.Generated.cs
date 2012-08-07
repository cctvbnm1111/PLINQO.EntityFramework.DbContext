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
    public static partial class ProductVendorExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static AdventureWorks.Data.Entities.ProductVendor GetByKey(this System.Linq.IQueryable<AdventureWorks.Data.Entities.ProductVendor> queryable, int productID, int vendorID)
        {
            var dbSet = queryable as System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductVendor>;
            if (dbSet != null)
                return dbSet.Find(productID, vendorID);
                
            return queryable.FirstOrDefault(p => p.ProductID == productID
                && p.VendorID == vendorID);
        }

        public static IQueryable<AdventureWorks.Data.Entities.ProductVendor> ByUnitMeasureCode(this IQueryable<AdventureWorks.Data.Entities.ProductVendor> queryable, string unitMeasureCode)
        {
            return queryable.Where(p => p.UnitMeasureCode == unitMeasureCode);
        }

        public static IQueryable<AdventureWorks.Data.Entities.ProductVendor> ByVendorID(this IQueryable<AdventureWorks.Data.Entities.ProductVendor> queryable, int vendorID)
        {
            return queryable.Where(p => p.VendorID == vendorID);
        }

        public static IQueryable<AdventureWorks.Data.Entities.ProductVendor> ByProductID(this IQueryable<AdventureWorks.Data.Entities.ProductVendor> queryable, int productID)
        {
            return queryable.Where(p => p.ProductID == productID);
        }
    }
}

