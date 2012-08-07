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
    public static partial class ProductDescriptionExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static AdventureWorks.Data.Entities.ProductDescription GetByKey(this System.Linq.IQueryable<AdventureWorks.Data.Entities.ProductDescription> queryable, int productDescriptionID)
        {
            var dbSet = queryable as System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductDescription>;
            if (dbSet != null)
                return dbSet.Find(productDescriptionID);
                
            return queryable.FirstOrDefault(p => p.ProductDescriptionID == productDescriptionID);
        }

        /// <summary>
        /// Gets an instance by using a unique index.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        public static AdventureWorks.Data.Entities.ProductDescription GetByRowguid(this IQueryable<AdventureWorks.Data.Entities.ProductDescription> queryable, System.Guid rowguid)
        {
            return queryable.FirstOrDefault(p => p.Rowguid == rowguid);
        }
    }
}

