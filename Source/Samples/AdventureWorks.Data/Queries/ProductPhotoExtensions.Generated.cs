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
    public static partial class ProductPhotoExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static AdventureWorks.Data.Entities.ProductPhoto GetByKey(this System.Linq.IQueryable<AdventureWorks.Data.Entities.ProductPhoto> queryable, int productPhotoID)
        {
            var dbSet = queryable as System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductPhoto>;
            if (dbSet != null)
                return dbSet.Find(productPhotoID);
                
            return queryable.FirstOrDefault(p => p.ProductPhotoID == productPhotoID);
        }
    }
}
