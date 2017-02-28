namespace Entities.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DIGICOMDBContext : DbContext
    {
        public DIGICOMDBContext()
            : base("name=DIGICOMDBContext")
        {
        }

        public virtual DbSet<AddressInformation> AddressInformations { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<EmployeeInformation> EmployeeInformations { get; set; }
        public virtual DbSet<ProductAccessory> ProductAccessories { get; set; }
        public virtual DbSet<ProductInformation> ProductInformations { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SalesOrder> SalesOrders { get; set; }
        public virtual DbSet<SalesOrderStatu> SalesOrderStatus { get; set; }
        public virtual DbSet<SalesOrderVisit> SalesOrderVisits { get; set; }
        public virtual DbSet<SalesService> SalesServices { get; set; }
        public virtual DbSet<StackHolderInformation> StackHolderInformations { get; set; }
        public virtual DbSet<StackHolderInformationType> StackHolderInformationTypes { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddressInformation>()
                .Property(e => e.AddressLine1)
                .IsUnicode(false);

            modelBuilder.Entity<AddressInformation>()
                .Property(e => e.AddressLine2)
                .IsUnicode(false);

            modelBuilder.Entity<AddressInformation>()
                .Property(e => e.LandMark)
                .IsUnicode(false);

            modelBuilder.Entity<AddressInformation>()
                .Property(e => e.MobileNumber)
                .IsUnicode(false);

            modelBuilder.Entity<AddressInformation>()
                .Property(e => e.TelephoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<AddressInformation>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<AddressInformation>()
                .Property(e => e.PInCode)
                .IsUnicode(false);

            modelBuilder.Entity<AddressInformation>()
                .HasMany(e => e.EmployeeInformations)
                .WithOptional(e => e.AddressInformation)
                .HasForeignKey(e => e.CompanyID);

            modelBuilder.Entity<AddressInformation>()
                .HasMany(e => e.StackHolderInformations)
                .WithRequired(e => e.AddressInformation)
                .HasForeignKey(e => e.OfficeAddressID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AddressInformation>()
                .HasMany(e => e.StackHolderInformations1)
                .WithOptional(e => e.AddressInformation1)
                .HasForeignKey(e => e.SiteAddressID);

            modelBuilder.Entity<City>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .Property(e => e.Desc)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.AddressInformations)
                .WithOptional(e => e.City1)
                .HasForeignKey(e => e.City);

            modelBuilder.Entity<Country>()
                .Property(e => e.CountryName)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.Desc)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeInformation>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeInformation>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<ProductAccessory>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ProductAccessory>()
                .Property(e => e.Desc)
                .IsUnicode(false);

            modelBuilder.Entity<ProductInformation>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ProductInformation>()
                .Property(e => e.Desc)
                .IsUnicode(false);

            modelBuilder.Entity<ProductInformation>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProductInformation>()
                .Property(e => e.SRNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ProductInformation>()
                .Property(e => e.UnitModel)
                .IsUnicode(false);

            modelBuilder.Entity<ProductInformation>()
                .HasMany(e => e.ProductInformation1)
                .WithOptional(e => e.ProductInformation2)
                .HasForeignKey(e => e.ProductParentID);

            modelBuilder.Entity<ProductType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ProductType>()
                .Property(e => e.Desc)
                .IsUnicode(false);

            modelBuilder.Entity<ProductType>()
                .HasOptional(e => e.ProductInformation)
                .WithRequired(e => e.ProductType);

            modelBuilder.Entity<Role>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.Desc)
                .IsUnicode(false);

            modelBuilder.Entity<SalesOrder>()
                .Property(e => e.SellingPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrder>()
                .HasMany(e => e.SalesOrderVisits)
                .WithOptional(e => e.SalesOrder)
                .HasForeignKey(e => e.OrderID);

            modelBuilder.Entity<SalesOrderStatu>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SalesOrderStatu>()
                .Property(e => e.Desc)
                .IsUnicode(false);

            modelBuilder.Entity<SalesOrderStatu>()
                .HasMany(e => e.SalesOrders)
                .WithOptional(e => e.SalesOrderStatu)
                .HasForeignKey(e => e.OrderStatusID);

            modelBuilder.Entity<SalesOrderVisit>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<SalesOrderVisit>()
                .Property(e => e.Objective)
                .IsFixedLength();

            modelBuilder.Entity<SalesService>()
                .Property(e => e.Desc)
                .IsUnicode(false);

            modelBuilder.Entity<SalesService>()
                .Property(e => e.ServiceCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<StackHolderInformation>()
                .Property(e => e.StackHolderName)
                .IsUnicode(false);

            modelBuilder.Entity<StackHolderInformation>()
                .Property(e => e.Desc)
                .IsUnicode(false);

            modelBuilder.Entity<StackHolderInformation>()
                .Property(e => e.ContactPersonName)
                .IsUnicode(false);

            modelBuilder.Entity<StackHolderInformationType>()
                .Property(e => e.StackHolderTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<StackHolderInformationType>()
                .Property(e => e.Desc)
                .IsUnicode(false);

            modelBuilder.Entity<StackHolderInformationType>()
                .HasMany(e => e.StackHolderInformations)
                .WithOptional(e => e.StackHolderInformationType)
                .HasForeignKey(e => e.CompanyTypeID);

            modelBuilder.Entity<State>()
                .Property(e => e.StateName)
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .Property(e => e.Desc)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
