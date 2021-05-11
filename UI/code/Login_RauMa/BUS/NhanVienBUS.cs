﻿using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAO _NhanVienDAO = new NhanVienDAO();

        public List<NhanVienDTO> LayDSNhanVien()
        {
            return _NhanVienDAO.LayDSNhanVien();
        }

        public bool KiemTraNhanVien(string ID_NV)
        {
            return _NhanVienDAO.KiemTraNhanVien(ID_NV);
        }
        public bool ThemNV(NhanVienDTO nv)
        {
            return _NhanVienDAO.ThemNV(nv);
        }

        public bool CapNhatNV(NhanVienDTO nv)
        {
            return _NhanVienDAO.CapNhatNV(nv);
        }
    }
}
