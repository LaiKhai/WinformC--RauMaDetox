﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_sanpham
    {

        ql_raumaEntities2 qlrauma = new ql_raumaEntities2();

        public List<DTO_sanpham> LayDSSanpham(string a)
        {
            List<DTO_sanpham> lssanpham = new List<DTO_sanpham>();
            lssanpham = qlrauma.SanPhams.Where(v => v.TrangThai == 1).Where(l => l.MaLoaiSp == a).Select(u => new DTO_sanpham
            {
                Masp = u.MaSp,
                Tensp = u.TenSp,
                MaLoaisp = u.LoaiSP.LoaiSP1,
                Giasp = (int)u.GiaTien,
                Mota = u.MoTa,
                Hinhsp = u.Hinh
            }).ToList();
            return lssanpham;
        }

        public List<DTO_sanpham> lstViewSP()
        {
            List<DTO_sanpham> lssanpham = new List<DTO_sanpham>();
            lssanpham = qlrauma.SanPhams.Where(v => v.TrangThai == 1).Select(u => new DTO_sanpham
            {
                Masp = u.MaSp,
                Tensp = u.TenSp,
                MaLoaisp = u.LoaiSP.LoaiSP1,
                Giasp = (int)u.GiaTien,
                Mota = u.MoTa,
                Hinhsp = u.Hinh
            }).ToList();
            return lssanpham;
        }

        public bool ThemSP(DTO_sanpham sp)
        {
            int temp = qlrauma.THEMSP(sp.Masp, sp.Tensp, sp.MaLoaisp, sp.Giasp, sp.Mota, sp.Hinhsp);
            qlrauma.SaveChanges();
            return true;
        }
        public bool SuaSP(DTO_sanpham sp)
        {

            try
            {
                int temp = qlrauma.SUASP(sp.Masp, sp.Tensp, sp.MaLoaisp, sp.Giasp, sp.Mota, sp.Hinhsp);
                qlrauma.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public string max()
        {
            string a = "RM00";
            a = qlrauma.SanPhams.Max(u => u.MaSp);
            return a;
        }
        public bool xoaSP(DTO_sanpham sp)
        {
            try
            {
                int temp = qlrauma.XOASP(sp.Masp);
                qlrauma.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
