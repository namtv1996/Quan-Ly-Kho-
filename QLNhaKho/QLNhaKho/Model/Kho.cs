namespace QLNhaKho
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kho")]
    public partial class Kho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kho()
        {
            ChiTietHangHoas = new HashSet<ChiTietHangHoa>();
            Nhansus = new HashSet<Nhansu>();
        }

        [Key]
        public int makho { get; set; }

        [StringLength(50)]
        public string tenkho { get; set; }

        public int? madd { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHangHoa> ChiTietHangHoas { get; set; }

        public virtual DiaDiem DiaDiem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nhansu> Nhansus { get; set; }
    }
}
