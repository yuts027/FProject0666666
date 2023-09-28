namespace FProjectCamping.Models.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cart
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string MemberAccount { get; set; }

        public int TotalPrice { get; set; }
    }
}
