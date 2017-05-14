namespace QLNhaKho
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HangHoa")]
    public partial class HangHoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HangHoa()
        {
            ChiTietHangHoas = new HashSet<ChiTietHangHoa>();
            PhieuNhaps = new HashSet<PhieuNhap>();
            PhieuXuats = new HashSet<PhieuXuat>();
        }

        [Key]
        public int mahh { get; set; }

        [StringLength(50)]
        public string tenhh { get; set; }

        [StringLength(50)]
        public string tinhtrang { get; set; }

        public DateTime? hansd { set; get; }

        public DateTime? ngaysx { set; get; }

        [StringLength(50)]
        public string nhasx { set; get; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHangHoa> ChiTietHangHoas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuXuat> PhieuXuats { get; set; }
    }
}
