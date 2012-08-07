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
    public static partial class StateProvinceExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static AdventureWorks.Data.Entities.StateProvince GetByKey(this System.Linq.IQueryable<AdventureWorks.Data.Entities.StateProvince> queryable, int stateProvinceID)
        {
            var dbSet = queryable as System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.StateProvince>;
            if (dbSet != null)
                return dbSet.Find(stateProvinceID);
                
            return queryable.FirstOrDefault(s => s.StateProvinceID == stateProvinceID);
        }

        /// <summary>
        /// Gets an instance by using a unique index.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        public static AdventureWorks.Data.Entities.StateProvince GetByName(this IQueryable<AdventureWorks.Data.Entities.StateProvince> queryable, string name)
        {
            return queryable.FirstOrDefault(s => s.Name == name);
        }

        /// <summary>
        /// Gets an instance by using a unique index.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        public static AdventureWorks.Data.Entities.StateProvince GetByRowguid(this IQueryable<AdventureWorks.Data.Entities.StateProvince> queryable, System.Guid rowguid)
        {
            return queryable.FirstOrDefault(s => s.Rowguid == rowguid);
        }

        /// <summary>
        /// Gets an instance by using a unique index.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        public static AdventureWorks.Data.Entities.StateProvince GetByStateProvinceCodeCountryRegionCode(this IQueryable<AdventureWorks.Data.Entities.StateProvince> queryable, string stateProvinceCode, string countryRegionCode)
        {
            return queryable.FirstOrDefault(s => s.StateProvinceCode == stateProvinceCode
                && s.CountryRegionCode == countryRegionCode);
        }

        public static IQueryable<AdventureWorks.Data.Entities.StateProvince> ByCountryRegionCode(this IQueryable<AdventureWorks.Data.Entities.StateProvince> queryable, string countryRegionCode)
        {
            return queryable.Where(s => s.CountryRegionCode == countryRegionCode);
        }

        public static IQueryable<AdventureWorks.Data.Entities.StateProvince> ByTerritoryID(this IQueryable<AdventureWorks.Data.Entities.StateProvince> queryable, int territoryID)
        {
            return queryable.Where(s => s.TerritoryID == territoryID);
        }
    }
}

