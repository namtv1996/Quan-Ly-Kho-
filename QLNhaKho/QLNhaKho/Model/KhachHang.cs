namespace QLNhaKho
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

        [StringLength(20), MinLength(2)]
        public string gioitinh { set; get; }

        [DataType(DataType.DateTime)]
        public DateTime? ngaysinh { set; get; }

        [StringLength(100)]
        public string diachi { get; set; }

        [StringLength(20)]
        public string sdt { set; get; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuXuat> PhieuXuats { get; set; }
    }
}
