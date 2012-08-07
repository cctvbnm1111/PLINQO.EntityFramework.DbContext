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
    public static partial class ShiftExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static AdventureWorks.Data.Entities.Shift GetByKey(this System.Linq.IQueryable<AdventureWorks.Data.Entities.Shift> queryable, byte shiftID)
        {
            var dbSet = queryable as System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Shift>;
            if (dbSet != null)
                return dbSet.Find(shiftID);
                
            return queryable.FirstOrDefault(s => s.ShiftID == shiftID);
        }

        /// <summary>
        /// Gets an instance by using a unique index.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        public static AdventureWorks.Data.Entities.Shift GetByName(this IQueryable<AdventureWorks.Data.Entities.Shift> queryable, string name)
        {
            return queryable.FirstOrDefault(s => s.Name == name);
        }

        /// <summary>
        /// Gets an instance by using a unique index.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        public static AdventureWorks.Data.Entities.Shift GetByStartTimeEndTime(this IQueryable<AdventureWorks.Data.Entities.Shift> queryable, System.DateTime startTime, System.DateTime endTime)
        {
            return queryable.FirstOrDefault(s => s.StartTime == startTime
                && s.EndTime == endTime);
        }
    }
}

