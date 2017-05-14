namespace QLNhaKho
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHangHoa")]
    public partial class ChiTietHangHoa
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mahh { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int makho { get; set; }

        public int? soluongton { get; set; }

        public virtual Kho Kho { get; set; }

        public virtual HangHoa HangHoa { get; set; }
    }
}
