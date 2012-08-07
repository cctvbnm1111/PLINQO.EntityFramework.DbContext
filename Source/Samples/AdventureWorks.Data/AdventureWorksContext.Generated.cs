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

namespace AdventureWorks.Data
{
    public interface IDbContext : IDisposable
    {
        System.Data.Entity.Database Database { get; }
        System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; }
        System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; }

        System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity);
        System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors();

        System.Data.Entity.DbSet Set(Type entityType);
        System.Data.Entity.IDbSet<TEntity> Set<TEntity>() where TEntity : class;

        int SaveChanges();
    }

    public partial interface IAdventureWorksContext : IDbContext
    {
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.AWBuildVersion> AWBuildVersions { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.DatabaseLog> DatabaseLogs { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ErrorLog> ErrorLogs { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Department> Departments { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Employee> Employees { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Contact> Contacts { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Address> Address { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Shift> Shifts { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.EmployeePayHistory> EmployeePayHistories { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.JobCandidate> JobCandidates { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.StateProvince> StateProvinces { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.AddressType> AddressTypes { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ContactType> ContactTypes { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.CountryRegion> CountryRegions { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.SalesTerritory> SalesTerritories { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.BillOfMaterials> BillOfMaterials { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Product> Products { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.UnitMeasure> UnitMeasures { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Culture> Cultures { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Document> Documents { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Illustration> Illustrations { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Location> Locations { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductModel> ProductModels { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductSubcategory> ProductSubcategories { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductCategory> ProductCategories { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductCostHistory> ProductCostHistories { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductDescription> ProductDescriptions { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductInventory> ProductInventories { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductListPriceHistory> ProductListPriceHistories { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductPhoto> ProductPhotos { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductReview> ProductReviews { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ScrapReason> ScrapReasons { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.TransactionHistory> TransactionHistories { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.TransactionHistoryArchive> TransactionHistoryArchives { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.WorkOrder> WorkOrders { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.WorkOrderRouting> WorkOrderRoutings { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductVendor> ProductVendors { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Vendor> Vendors { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ShipMethod> ShipMethods { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.VendorAddress> VendorAddresses { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.VendorContact> VendorContacts { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.CreditCard> CreditCards { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Currency> Currencies { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.CurrencyRate> CurrencyRates { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Customer> Customers { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.CustomerAddress> CustomerAddresses { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Individual> Individuals { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.SalesOrderDetail> SalesOrderDetails { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.SalesOrderHeader> SalesOrderHeaders { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.SpecialOfferProduct> SpecialOfferProducts { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.SalesPerson> SalesPeople { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.SalesReason> SalesReasons { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.SalesTaxRate> SalesTaxRates { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.SalesTerritoryHistory> SalesTerritoryHistories { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ShoppingCartItem> ShoppingCartItems { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.SpecialOffer> SpecialOffers { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Store> Stores { get; set; }
        System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.StoreContact> StoreContacts { get; set; }
    }

    public partial class AdventureWorksContext
        : System.Data.Entity.DbContext, IAdventureWorksContext
    {
        public AdventureWorksContext()
            :base("Name=AdventureWorksContext")
        { }

        public AdventureWorksContext(System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base("Name=AdventureWorksContext", model)
        { }

        public AdventureWorksContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        { }

        public AdventureWorksContext(string nameOrConnectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(nameOrConnectionString, model)
        { }

        public AdventureWorksContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        { }

        public AdventureWorksContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        { }

        public AdventureWorksContext(System.Data.Objects.ObjectContext objectContext, bool dbContextOwnsObjectContext)
            : base(objectContext, dbContextOwnsObjectContext)
        { }


        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.AWBuildVersion> AWBuildVersions { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.DatabaseLog> DatabaseLogs { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ErrorLog> ErrorLogs { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Department> Departments { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Employee> Employees { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Contact> Contacts { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Address> Address { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Shift> Shifts { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.EmployeePayHistory> EmployeePayHistories { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.JobCandidate> JobCandidates { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.StateProvince> StateProvinces { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.AddressType> AddressTypes { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ContactType> ContactTypes { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.CountryRegion> CountryRegions { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.SalesTerritory> SalesTerritories { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.BillOfMaterials> BillOfMaterials { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Product> Products { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.UnitMeasure> UnitMeasures { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Culture> Cultures { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Document> Documents { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Illustration> Illustrations { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Location> Locations { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductModel> ProductModels { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductSubcategory> ProductSubcategories { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductCategory> ProductCategories { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductCostHistory> ProductCostHistories { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductDescription> ProductDescriptions { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductInventory> ProductInventories { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductListPriceHistory> ProductListPriceHistories { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductPhoto> ProductPhotos { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductReview> ProductReviews { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ScrapReason> ScrapReasons { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.TransactionHistory> TransactionHistories { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.TransactionHistoryArchive> TransactionHistoryArchives { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.WorkOrder> WorkOrders { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.WorkOrderRouting> WorkOrderRoutings { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductVendor> ProductVendors { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Vendor> Vendors { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ShipMethod> ShipMethods { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.VendorAddress> VendorAddresses { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.VendorContact> VendorContacts { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.CreditCard> CreditCards { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Currency> Currencies { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.CurrencyRate> CurrencyRates { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Customer> Customers { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.CustomerAddress> CustomerAddresses { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Individual> Individuals { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.SalesOrderDetail> SalesOrderDetails { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.SalesOrderHeader> SalesOrderHeaders { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.SpecialOfferProduct> SpecialOfferProducts { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.SalesPerson> SalesPeople { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.SalesReason> SalesReasons { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.SalesTaxRate> SalesTaxRates { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.SalesTerritoryHistory> SalesTerritoryHistories { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ShoppingCartItem> ShoppingCartItems { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.SpecialOffer> SpecialOffers { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Store> Stores { get; set; }
        public System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.StoreContact> StoreContacts { get; set; }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.AWBuildVersionMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.DatabaseLogMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.ErrorLogMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.DepartmentMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.EmployeeMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.ContactMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.AddressMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.EmployeeDepartmentHistoryMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.ShiftMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.EmployeePayHistoryMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.JobCandidateMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.StateProvinceMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.AddressTypeMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.ContactTypeMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.CountryRegionMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.SalesTerritoryMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.BillOfMaterialsMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.ProductMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.UnitMeasureMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.CultureMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.DocumentMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.IllustrationMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.LocationMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.ProductModelMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.ProductSubcategoryMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.ProductCategoryMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.ProductCostHistoryMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.ProductDescriptionMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.ProductInventoryMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.ProductListPriceHistoryMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.ProductModelProductDescriptionCultureMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.ProductPhotoMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.ProductReviewMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.ScrapReasonMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.TransactionHistoryMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.TransactionHistoryArchiveMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.WorkOrderMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.WorkOrderRoutingMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.ProductVendorMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.VendorMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.PurchaseOrderDetailMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.PurchaseOrderHeaderMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.ShipMethodMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.VendorAddressMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.VendorContactMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.CreditCardMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.CurrencyMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.CurrencyRateMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.CustomerMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.CustomerAddressMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.IndividualMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.SalesOrderDetailMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.SalesOrderHeaderMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.SpecialOfferProductMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.SalesPersonMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.SalesReasonMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.SalesPersonQuotaHistoryMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.SalesTaxRateMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.SalesTerritoryHistoryMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.ShoppingCartItemMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.SpecialOfferMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.StoreMap());
            modelBuilder.Configurations.Add(new AdventureWorks.Data.Mapping.StoreContactMap());

            InitializeMapping(modelBuilder);
        }

        System.Data.Entity.IDbSet<TEntity> IDbContext.Set<TEntity>()
        {
            return base.Set<TEntity>();
        }
    }
}