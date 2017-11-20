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
            //MAGIC
            //MGY005
            //MGY006


            //GRAFFITI
            //GRF0002
            //GRF0044
            //GRF0049
            //GRF0006

            //3M - 3M MANUFACTURERA VENEZUELA, C.A.
            //3M001
            //3M008
            //3M007
            //3M006
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
        public decimal? GetResultSemestral(DateTime? fechaInicio, DateTime? fechaFin, string CodProd)
        {
            decimal? total = default(decimal);
            int Unidades = 0;
            var result = (from SAEPRD in db.SAEPRD
                          join SAPROD in db.SAPROD on SAEPRD.CodProd equals SAPROD.CodProd
                          where SAEPRD.Fecha >= fechaInicio && SAEPRD.Fecha <= fechaFin && SAEPRD.CodProd == CodProd
                          select new
                          {
                              CntVentas = SAEPRD.CntVentas,
                              Precio3 = SAPROD.Precio3,
                              CantidadInicial = SAEPRD.CntInicial,
                              CantidadFinal =  SAEPRD.ExFinal
                          }).ToList();

            foreach (var item in result)
            {
                decimal? sub = item.CntVentas * item.Precio3;
                total = total + sub;
                Unidades = Unidades + Convert.ToInt32(item.CntVentas);
            }
            //total = result.CntVentas * result.Precio3;
            ResultSemestral resultSemestral = new ResultSemestral();

            resultSemestral.total = total;
            resultSemestral.Unidades = Unidades;

            return Unidades;
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
        public List<ClientesDuplicados> clienteDuplicadoMes(string codigo, DateTime? fechaInicio, DateTime? fechaFin) {
            List<ClientesDuplicados> lista = new List<ClientesDuplicados>();

            string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["Saint"].ToString();

            using (System.Data.SqlClient.SqlConnection cn = new System.Data.SqlClient.SqlConnection(conexion))
            {
                cn.Open();

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("getCliente", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@fechaFin", fechaFin);
                cmd.Parameters.AddWithValue("@CodItem", codigo);
                System.Data.SqlClient.SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Zentrix.Helper.ClientesDuplicados
                    {
                        decripcion = dr["Descrip"].ToString(),
                        cantidad = dr["cantidad"].ToString(),
                    });
                }

            }

            return lista;
        }
        public int? CantidadCliente(string codigoItem, DateTime? fechaInicio, DateTime? fechaFin)
        {
            /*
             	SELECT SAFACT.Descrip, count(*) as cantidad
	            from SAITEMFAC 
	            inner join SAFACT on SAFACT.NumeroD = SAITEMFAC.NumeroD --descrip 1 FechaE Cantidad CodItem
	            where SAITEMFAC.CodItem=@CodItem and  SAITEMFAC.FechaE between @fechaInicio and @fechaFin
	            GROUP BY SAFACT.Descrip
	            HAVING count(*) > 1
             */
            var result = (from SAITEMFAC in db.SAITEMFAC
                          join SAFACT in db.SAFACT on SAITEMFAC.NumeroD equals SAFACT.NumeroD
                          where SAITEMFAC.FechaE >= fechaInicio && SAITEMFAC.FechaE <= fechaFin && SAITEMFAC.CodItem == codigoItem
                          select new
                          {
                              Descrip = SAFACT.Descrip
                          }).Count();
            return result;
        }
        public List<EstadisticaVendedores> VendedoresEstadistica(string codigoItem, DateTime? fechaInicio, DateTime? fechaFin)
        {
            List<EstadisticaVendedores> lista = new List<EstadisticaVendedores>();
            string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["Saint"].ToString();
            using (System.Data.SqlClient.SqlConnection cn = new System.Data.SqlClient.SqlConnection(conexion))
            {
                cn.Open();

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("getVendedor", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandTimeout = 600;
                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@fechaFin", fechaFin);
                cmd.Parameters.AddWithValue("@CodItem", codigoItem);
                System.Data.SqlClient.SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Zentrix.Helper.EstadisticaVendedores
                    {
                        Usuario = dr["CodUsua"].ToString(),
                        cantidad = dr["cantidad"].ToString(),
                    });
                }

            }

            return lista;
        }
        public int? NumeroVentasxVendedor(string codigoItem, DateTime? fechaInicio, DateTime? fechaFin) {
            /*
             	SELECT SAFACT.CodUsua, SAITEMFAC.CodItem,SAITEMFAC.FechaE
	            from SAITEMFAC
	            inner join SAFACT on SAFACT.NumeroD = SAITEMFAC.NumeroD --descrip 1 FechaE Cantidad CodItem
	            where SAITEMFAC.CodItem='3M001' and  SAITEMFAC.FechaE between '2016-01-01' and '2016-07-01'
             */
            var result = (from SAITEMFAC in db.SAITEMFAC
                          join SAFACT in db.SAFACT on SAITEMFAC.NumeroD equals SAFACT.NumeroD
                          where SAITEMFAC.FechaE >= fechaInicio && SAITEMFAC.FechaE <= fechaFin && SAITEMFAC.CodItem == codigoItem
                          select new
                          {
                              Usuario = SAFACT.CodUsua
                          }).Count();
            return result;
        }
    }
    public class ResultSemestral
    {
        public decimal? total { get; set; }
        public decimal Unidades { get; set; }
    }
}