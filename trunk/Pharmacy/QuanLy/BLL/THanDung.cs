using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pharmacy.QuanLy.BLL
{
    class THanDung
    {
        DLL.DataAccess cn = new DLL.DataAccess();
        public DataTable GetHanDung()
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("usp_SelectHanDung");
            return data;

        }
        public DataTable GetSL()
        {
            DataTable data = new DataTable();
            data = cn.GetDataByStoredProcedure("usp_SelectCanhBaoSL");
            return data;

        }
    }
}
