﻿using System;
using DAO;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietHoaDonBUS
    {
        ChiTietHoaDonDAO hd = new ChiTietHoaDonDAO();
        ChiTietHoaDonDTO cthd = new ChiTietHoaDonDTO();
        public List<ChiTietHoaDonDTO> LayDSSP()
        {
            return hd.layDSSP();
        }
        public List<ChiTietHoaDonDTO> LayGia(string masp)
        {
            return hd.LayGia(masp);
        }
    }
}