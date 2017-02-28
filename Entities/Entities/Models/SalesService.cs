namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SalesService
    {
        public int SalesServiceID { get; set; }

        public int? SalesOderID { get; set; }

        [StringLength(50)]
        public string Desc { get; set; }

        public int? VisitedByEmp { get; set; }

        [Column(TypeName = "money")]
        public decimal? ServiceCost { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public int? UpdateBy { get; set; }
    }
}
