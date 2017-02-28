namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductAccessory
    {
        public int ProductAccessoryID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? ProductID { get; set; }

        public string Desc { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public int? UpdateBy { get; set; }

        public virtual ProductInformation ProductInformation { get; set; }
    }
}
