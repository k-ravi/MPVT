namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StackHolderInformation")]
    public partial class StackHolderInformation
    {
        [Key]
        public int StackHolderID { get; set; }

        [StringLength(50)]
        public string StackHolderName { get; set; }

        public string Desc { get; set; }

        [StringLength(50)]
        public string ContactPersonName { get; set; }

        public int? CompanyTypeID { get; set; }

        public int OfficeAddressID { get; set; }

        public int? SiteAddressID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public int? UpdateBy { get; set; }

        public virtual AddressInformation AddressInformation { get; set; }

        public virtual AddressInformation AddressInformation1 { get; set; }

        public virtual StackHolderInformationType StackHolderInformationType { get; set; }
    }
}
