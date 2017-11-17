using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zentrix.Models.BD;

namespace Zentrix.Helper
{
    public class Helper
    {
        public SAINTPALLEntities db = new SAINTPALLEntities();
        public decimal GetResult()
        {

            var result = (from saed in db.SAEPRD
                          join sprod in db.SAPROD on saed.CodProd equals sprod.CodProd
                          where saed.Periodo== "201502" && sprod.Marca== "3M"
                          select new
                          {
                              TotalMes =  saed.MtoVentas
                          }).ToList();

            decimal total = default(decimal);
            foreach (var item in result)
            {
                total = total + item.TotalMes;
            }
            return total;
        }
    }
}