using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zentrix.Models.BD;

namespace Zentrix.Helper
{
    public class Helper
    {
        public SAINTPALLEntities1 db = new SAINTPALLEntities1();
        public decimal GetResult(string periodo)
        {

            var result = (from SAEPRD in db.SAEPRD
                          join SAPROD in db.SAPROD on SAEPRD.CodProd equals SAPROD.CodProd
                          where SAEPRD.Periodo == periodo && SAEPRD.CodProd == "GRF0007"
                          select new
                          {
                              CntVentas = SAEPRD.CntVentas,
                              MtoVentas = SAEPRD.MtoVentas,
                          }).SingleOrDefault();

            decimal total = default(decimal);
            total = result.CntVentas * result.MtoVentas;
            //foreach (var item in result)
            //{
            //    total = total + item.TotalMes;
            //}
            return total;
        }
        public List<object> GetProducto() {
            /*
             SELECT SAEPRD.CntCompra, SAEPRD.CntVentas,
               SAEPRD.MtoCompra, SAEPRD.MtoVentas,SAEPRD.Costo,SAEPRD.CntInicial,SAEPRD.ExFinal,
               SAPROD.CodProd, SAPROD.Descrip,
               SAPROD.Descrip2, SAPROD.Descrip3,
               SAPROD.Marca, SAEPRD.Periodo, SAPROD.Refere
        FROM SAEPRD SAEPRD INNER JOIN SAPROD SAPROD ON
             (SAPROD.CodProd = SAEPRD.CodProd)
        WHERE ( SAPROD.Marca = 'GRAFFITI' )
               AND ( SAEPRD.Periodo = '201608' ) and (SAEPRD.CodProd='GRF0007')
             */
            var result = (from SAEPRD in db.SAEPRD
                          join SAPROD in db.SAPROD on SAEPRD.CodProd equals SAPROD.CodProd
                          where SAEPRD.Periodo == "201608" && SAPROD.Marca == "GRF0007"
                          select new
                          {
                              CntCompra = SAEPRD.CntCompra,
                              CntVentas = SAEPRD.CntVentas,
                              MtoCompra=SAEPRD.MtoCompra,
                              MtoVentas=SAEPRD.MtoVentas,
                              Costo=SAEPRD.Costo,
                              CntInicial=SAEPRD.CntInicial,
                              ExFinal=SAEPRD.ExFinal,
                              CodProd=SAPROD.CodProd,
                              Descrip=SAPROD.Descrip,
                              Marca=SAPROD.Marca,
                              Periodo=SAEPRD.Periodo,
                              Refere=SAPROD.Refere
                          }).ToList();
            List<object> ListObject = new List<object>();
            ListObject.AddRange(result);
            return ListObject;
        }

    }
}