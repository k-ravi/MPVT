namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SalesOrderVisit
    {
        [Key]
        public int VisitID { get; set; }

        public int? OrderID { get; set; }

        public int? VisitedEmployeeID { get; set; }

        [StringLength(50)]
        public string Remarks { get; set; }

        [StringLength(10)]
        public string Objective { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public int? UpdateBy { get; set; }

        public virtual SalesOrder SalesOrder { get; set; }
    }
}
