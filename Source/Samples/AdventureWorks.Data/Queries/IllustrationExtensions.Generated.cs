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
    public static partial class IllustrationExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static AdventureWorks.Data.Entities.Illustration GetByKey(this System.Linq.IQueryable<AdventureWorks.Data.Entities.Illustration> queryable, int illustrationID)
        {
            var dbSet = queryable as System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Illustration>;
            if (dbSet != null)
                return dbSet.Find(illustrationID);
                
            return queryable.FirstOrDefault(i => i.IllustrationID == illustrationID);
        }
    }
}

