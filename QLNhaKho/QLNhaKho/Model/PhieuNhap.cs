namespace QLNhaKho
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuNhap")]
    public partial class PhieuNhap
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mancc { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mahh { get; set; }

        public DateTime? ngaynhap { get; set; }

        public int? soluong { get; set; }

        [StringLength(100)]
        public string ghichu { get; set; }

        public virtual HangHoa HangHoa { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}
