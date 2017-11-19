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
        public decimal? GetResult(string periodo,string CodProd)
        {
            //MONTANA - CORIMON PINTURAS, C.A
            //MNT0536 -	DURAMAX ESMALTE BRILL. LILA PRIMAVERA GL
            //MNT0537 - DURAMAX ESMALTE BRILL. VERDE TILO GL.
            //MNT0050 -	DURAMAX ESMALTE BRILL. BLANCO GAL.
            //MNT0228 - AV - 2000 INTERIOR BLANCO GAL.

            //GRAFFITI - INVERSIONES SIMBI, C.A
            //GRF0003	BARRA SILICON 8 MM X 30 CM P/PISTOLA
            //GRF0007	SILIPEX TUBO NEGRO 70ml
            //GRF0041	BARRA SILICON 8 MM X 20 CM P/PISTOLA
            //GRF0002   BARRA SILICON 11 MM X 15 CM P/ PISTOLA

            //3M - 3M MANUFACTURERA VENEZUELA, C.A.
            //3M016	3M LIJA DE AGUA IMPERIAL 401Q GRANO 2000
            //3M008	LIJA DE AGUA GRANO 280
            //3M022   3M FIBRODISCOS GRANO 36
            //3M021   3M FIBRODISCOS GRANO 24
            var result = (from SAEPRD in db.SAEPRD
                          join SAPROD in db.SAPROD on SAEPRD.CodProd equals SAPROD.CodProd
                          where SAEPRD.Periodo == periodo && SAEPRD.CodProd == CodProd
                          select new
                          {
                              CntVentas = SAEPRD.CntVentas,
                              Precio3 = SAPROD.Precio3,
                          }).SingleOrDefault();

            decimal? total = default(decimal);
            total = result.CntVentas * result.Precio3;
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