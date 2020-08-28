using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class ChucVu_BUL
    {
        private ChucVu_DAL chucVu_DAL = new ChucVu_DAL();
        public DataTable getAllChucVu()
        {
            return chucVu_DAL.getAllChucVu();
        }
    }
}
