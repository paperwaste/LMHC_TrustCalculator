namespace LMHC_TrustCalculator.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ManagementDataContext : DbContext
    {
        // Your context has been configured to use a 'ManagementDataContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ManagmentTrustCalculator.Model.ManagementDataContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ManagementDataContext' 
        // connection string in the application configuration file.
        public ManagementDataContext()
            : base("name=ManagementDataContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Adjustment> Adjustments { get; set; }

        public virtual DbSet<Practice> Practices { get; set; }

        public virtual DbSet<ServiceFee> ServiceFees { get; set; }

        public virtual DbSet<TaxAdjustmentInvoice> Invoices { get; set; }

        public virtual DbSet<InvoicePeriod> InvoicePeriod { get; set; }

    }
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}