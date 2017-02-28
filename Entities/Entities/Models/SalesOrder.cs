namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesOrder")]
    public partial class SalesOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalesOrder()
        {
            SalesOrderVisits = new HashSet<SalesOrderVisit>();
        }

        public int SalesOrderID { get; set; }

        public int? ProductID { get; set; }

        public int? CustomerID { get; set; }

        public int? DelarID { get; set; }

        public DateTime? SelingDate { get; set; }

        public int? Quantity { get; set; }

        public DateTime? WarrantyDuration { get; set; }

        [Column(TypeName = "money")]
        public decimal? SellingPrice { get; set; }

        public int? EmployeeID { get; set; }

        public int? OrderStatusID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public int? UpdateBy { get; set; }

        public virtual EmployeeInformation EmployeeInformation { get; set; }

        public virtual ProductInformation ProductInformation { get; set; }

        public virtual SalesOrderStatu SalesOrderStatu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderVisit> SalesOrderVisits { get; set; }
    }
}
