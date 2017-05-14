namespace QLNhaKho
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuXuat")]
    public partial class PhieuXuat
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int makh { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mahh { get; set; }

        public int? soluong { get; set; }

        public DateTime? ngayxuat { get; set; }

        public DateTime? ngaynhan { get; set; }

        public int? danhan { get; set; }

        [StringLength(100)]
        public string ghichu { get; set; }

        public virtual HangHoa HangHoa { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
