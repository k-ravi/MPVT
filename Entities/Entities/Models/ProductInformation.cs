namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductInformation")]
    public partial class ProductInformation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductInformation()
        {
            ProductAccessories = new HashSet<ProductAccessory>();
            ProductInformation1 = new HashSet<ProductInformation>();
            SalesOrders = new HashSet<SalesOrder>();
        }

        [Key]
        public int ProductID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public string Desc { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public int? ProductTypeID { get; set; }

        public int? ProductParentID { get; set; }

        public int? CompanyID { get; set; }

        [StringLength(50)]
        public string SRNumber { get; set; }

        [StringLength(50)]
        public string UnitModel { get; set; }

        public double? WarrantyDuration { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public int? UpdateBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductAccessory> ProductAccessories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductInformation> ProductInformation1 { get; set; }

        public virtual ProductInformation ProductInformation2 { get; set; }

        public virtual ProductType ProductType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
    }
}
