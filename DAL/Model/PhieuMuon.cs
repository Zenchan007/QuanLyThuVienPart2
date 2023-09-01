//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhieuMuon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuMuon()
        {
            this.HoaDons = new HashSet<HoaDon>();
            this.PhieuMuon_Sachs = new HashSet<PhieuMuon_Sachs>();
        }
    
        public int ID { get; set; }
        public int ID_DocGia { get; set; }
        public Nullable<System.DateTime> NgayMuon { get; set; }
        public Nullable<System.DateTime> NgayHenTra { get; set; }
        public int ID_TrangThai { set; get; }
        public Nullable<int> ID_NhanVien { get; set; }
        public string GhiChu { get; set; }
        public Nullable<double> TienCoc { get; set; }
        public Nullable<System.DateTime> NgayTra { get; set; }
    
        public virtual DocGia DocGia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuMuon_Sachs> PhieuMuon_Sachs { get; set; }
        public virtual TrangThai_PhieuMuon TrangThai_PhieuMuon { get; set; }
    }
}
