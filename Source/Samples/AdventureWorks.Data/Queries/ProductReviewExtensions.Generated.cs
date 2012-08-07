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
    public static partial class ProductReviewExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static AdventureWorks.Data.Entities.ProductReview GetByKey(this System.Linq.IQueryable<AdventureWorks.Data.Entities.ProductReview> queryable, int productReviewID)
        {
            var dbSet = queryable as System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductReview>;
            if (dbSet != null)
                return dbSet.Find(productReviewID);
                
            return queryable.FirstOrDefault(p => p.ProductReviewID == productReviewID);
        }

        public static IQueryable<AdventureWorks.Data.Entities.ProductReview> ByProductIDReviewerName(this IQueryable<AdventureWorks.Data.Entities.ProductReview> queryable, int productID, string reviewerName)
        {
            return queryable.Where(p => p.ProductID == productID
                && p.ReviewerName == reviewerName);
        }

        public static IQueryable<AdventureWorks.Data.Entities.ProductReview> ByProductID(this IQueryable<AdventureWorks.Data.Entities.ProductReview> queryable, int productID)
        {
            return queryable.Where(p => p.ProductID == productID);
        }
    }
}

