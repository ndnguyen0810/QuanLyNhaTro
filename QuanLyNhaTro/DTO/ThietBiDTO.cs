﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DTO
{
    public class ThietBiDTO
    {
        private string maTB;
        private string tenTB;

        public string MaTB { get => maTB; set => maTB = value; }
        public string TenTB { get => tenTB; set => tenTB = value; }
    }
}
