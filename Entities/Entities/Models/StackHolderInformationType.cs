namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StackHolderInformationType")]
    public partial class StackHolderInformationType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StackHolderInformationType()
        {
            StackHolderInformations = new HashSet<StackHolderInformation>();
        }

        public int StackHolderInformationTypeID { get; set; }

        [StringLength(50)]
        public string StackHolderTypeName { get; set; }

        public string Desc { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public int? UpdateBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StackHolderInformation> StackHolderInformations { get; set; }
    }
}
