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
        public List<ClientesDuplicados> clienteDuplicadoMes(string codigo,string periodo) {
            List<ClientesDuplicados> lista = new List<ClientesDuplicados>();

            string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["Saint"].ToString();

            using (System.Data.SqlClient.SqlConnection cn = new System.Data.SqlClient.SqlConnection(conexion))
            {
                cn.Open();

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("getCliente", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Periodo", periodo);
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
    }
}