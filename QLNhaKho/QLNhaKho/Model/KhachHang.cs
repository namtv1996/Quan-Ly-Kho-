namespace QLNhaKho.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            PhieuXuats = new HashSet<PhieuXuat>();
        }

        [Key]
        public int makh { get; set; }

        [StringLength(50)]
        public string tenkh { get; set; }

        [StringLength(100)]
        public string diachi { get; set; }

        [StringLength(20)]
        public string sdt { get; set; }

        public DateTime? ngaysinh { get; set; }

        [StringLength(20)]
        public string gioitinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuXuat> PhieuXuats { get; set; }
    }
}
