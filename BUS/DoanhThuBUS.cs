﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class DoanhThuBUS
    {
        DoanhThuDAL dal = new DoanhThuDAL();
        public List<DoanhThuDTO> GetDoanhThuDTOs()
        {
            return dal.getThongTin();
        }
    }
}
