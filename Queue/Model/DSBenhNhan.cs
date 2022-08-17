using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Model
{
    public class DSBenhNhan
    {
        public int Id { get; set; }
        public int CLSYeuCau_Id { get; set; }
        public int SoVaoVien { get; set; }
        public string TenBenhNhan { get; set; }
        public string NoiDungChiTiet { get; set; }
        public string NoiThucHien_Id { get; set; }
        public int SoThuTu { get; set; }
        public int NamYeuCau { get; set; }
        public string TrangThai { get; set; }
        public string TiepNhan_Id { get; set; }
    }
}
