﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaKho
{
    public static class ExM
    {
        public static bool IsDateTime(this string s)
        {
            var res = DateTime.Now;
            return DateTime.TryParse(s, out res);
        }

        public static bool IsPhoneNumber(this string s)
        {
            var res = 0;
            return int.TryParse(s, out res);
        }

        public static bool IsNumber(this string s)
        {
            var res = 0;
            return int.TryParse(s, out res);
        }
        public static FormMain formMain;
        public static FormCustomer formCustomer;
        public static FormExport formExport;
        public static FormHelp formHelp;
        public static FormImport formImport;
        public static FormLogin formLogin;
        public static FormView formView;
    }
}
