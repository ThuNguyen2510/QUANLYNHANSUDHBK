﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAL
{
 public class NguoiDung_DAL
    {
        public DataHelper dh { get; set; }
        //string str = "Data Source=DESKTOP-JTU3RKR;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
        //string str = @"Data Source=THUY\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
        string  str= "Data Source=DESKTOP-56I34NJ;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
        public NguoiDung_DAL()
        {
            dh = new DataHelper(str);
        }
        public DataTable LayNguoidung()
        {
            string query = "Select * from NguoiDung";
            return dh.GetTable(query);
        }

    }
}
