using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Imposto.Core.Domain;

namespace Imposto.Core.Data
{
    public class Repository
    {
        private static SqlConnection GetConn() { return new SqlConnection(ConfigurationManager.ConnectionStrings["StringDeConexao"].ConnectionString); }

        public static int GravarNotaFiscal(Domain.NotaFiscal notaFiscal)
        {
            using (var _sqlCon = GetConn())
            using (var sqlCmd = new SqlCommand("dbo.P_NOTA_FISCAL", _sqlCon))
            {
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddRange(new[]{
                    new SqlParameter("@pId", notaFiscal.Id) { Direction = ParameterDirection.InputOutput },
                    new SqlParameter("@pNumeroNotaFiscal", notaFiscal.NumeroNotaFiscal),
                    new SqlParameter("@pSerie", notaFiscal.Serie),
                    new SqlParameter("@pNomeCliente", notaFiscal.NomeCliente),
                    new SqlParameter("@pEstadoDestino", notaFiscal.EstadoDestino),
                    new SqlParameter("@pEstadoOrigem", notaFiscal.EstadoOrigem)
                });
                _sqlCon.Open();
                sqlCmd.ExecuteScalar();
                return Convert.ToInt32(sqlCmd.Parameters["@pId"].Value);
            }
        }

        public static void GravarNotaFiscalItem(Domain.NotaFiscalItem item)
        {
            using (var _sqlCon = GetConn())
            using (var sqlCmd = new SqlCommand("dbo.P_NOTA_FISCAL_ITEM", _sqlCon))
            {
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddRange(new[]{
                    new SqlParameter("@pId", item.Id),
                    new SqlParameter("@pIdNotaFiscal", item.IdNotaFiscal),
                    new SqlParameter("@pCfop", item.Cfop),
                    new SqlParameter("@pTipoIcms", item.TipoIcms),
                    new SqlParameter("@pBaseIcms", item.BaseIcms),
                    new SqlParameter("@pAliquotaIcms", item.AliquotaIcms),
                    new SqlParameter("@pValorIcms", item.ValorIcms),
                    new SqlParameter("@pBaseIpi", item.BaseIpi),
                    new SqlParameter("@pAliquotaIpi", item.AliquotaIpi),
                    new SqlParameter("@pValorIpi", item.ValorIpi),
                    new SqlParameter("@pNomeProduto", item.NomeProduto),
                    new SqlParameter("@pCodigoProduto", item.CodigoProduto),
                    new SqlParameter("@pDesconto", item.Desconto),
                    new SqlParameter("@pValorItemPedido", item.ValorItemPedido),
                    new SqlParameter("@pBrinde", item.Brinde                    
                    )
                });
                _sqlCon.Open();
                sqlCmd.ExecuteNonQuery();
            }
        }

        public static Domain.TratamentoFiscal ObterTratamentoFiscal(string ufOrigem, string ufDestino, bool brinde)
        {
            var tratFiscal = new Domain.TratamentoFiscal();
            using (var con = GetConn())
            using (var sqlCmd = new SqlCommand(@"SELECT [Id]
                                                      ,[EstadoOrigem]
                                                      ,[EstadoDestino]
                                                      ,[Cfop]
                                                      ,[TipoIcms]
                                                      ,[AliquotaIcms]
                                                      ,[AliquotaIpi]
                                                      ,[ReducaoBaseIcms]
                                                      ,[Brinde]
                                                      ,[Desconto]
                                                      ,[DataAlteracao]
                                                  FROM [dbo].[TratamentoFiscal]
                                                WHERE estadoOrigem = @estadoOrigem and estadoDestino = @estadoDestino and brinde = @brinde", con))
            {
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@estadoOrigem", ufOrigem);
                sqlCmd.Parameters.AddWithValue("@estadoDestino", ufDestino);
                sqlCmd.Parameters.AddWithValue("@brinde", brinde);

                con.Open();
                var sqlDR = sqlCmd.ExecuteReader();
                if (sqlDR.HasRows)
                {
                    while (sqlDR.Read())
                    {
                        tratFiscal.Id = Convert.ToInt32(sqlDR["Id"]);
                        tratFiscal.EstadoOrigem = sqlDR["EstadoOrigem"].ToString();
                        tratFiscal.EstadoDestino = sqlDR["EstadoDestino"].ToString();
                        tratFiscal.Cfop = sqlDR["Cfop"].ToString();
                        tratFiscal.TipoIcms = sqlDR["TipoIcms"].ToString();
                        tratFiscal.AliquotaIcms = Convert.ToDouble(sqlDR["AliquotaIcms"]);
                        tratFiscal.AliquotaIpi = Convert.ToDouble(sqlDR["AliquotaIpi"]);
                        tratFiscal.ReducaoBaseIcms = Convert.ToInt32(sqlDR["ReducaoBaseIcms"]);
                        tratFiscal.Brinde = Convert.ToBoolean(sqlDR["Brinde"]);
                        tratFiscal.Desconto = Convert.ToDouble(sqlDR["Desconto"]);
                        tratFiscal.DataAlteracao = Convert.ToDateTime(sqlDR["DataAlteracao"]);
                    }                    
                }                
            }
            return tratFiscal;
        }

        public static DataTable ObterNotaFiscal(int numeroNotaFiscal, string cliente, int opcao)
        {
            DataTable dt = new DataTable();
            string sql = @"SELECT[Id]
                            ,[NumeroNotaFiscal]
                            ,[Serie]
                            ,[NomeCliente]
                            ,[EstadoDestino]
                            ,[EstadoOrigem]
                        FROM[dbo].[NotaFiscal] ";
            if (opcao == 1)
                sql += @"WHERE NumeroNotaFiscal = @NumeroNotaFiscal and NomeCliente = @NomeCliente";
            else if (opcao == 2)
                sql += @"WHERE NumeroNotaFiscal = @NumeroNotaFiscal";
            else if (opcao == 3)
                sql += @"WHERE NomeCliente = @NomeCliente";
            
            using (var con = GetConn())
            using (var sqlCmd = new SqlCommand(sql, con))
            {
                sqlCmd.CommandType = CommandType.Text;
                if (opcao == 1)
                {
                    sqlCmd.Parameters.AddWithValue("@NumeroNotaFiscal", numeroNotaFiscal);
                    sqlCmd.Parameters.AddWithValue("@NomeCliente", cliente);
                }
                else if (opcao == 2)
                    sqlCmd.Parameters.AddWithValue("@NumeroNotaFiscal", numeroNotaFiscal);
                else if (opcao == 3)
                    sqlCmd.Parameters.AddWithValue("@NomeCliente", cliente);

                con.Open();
                var sqlDR = sqlCmd.ExecuteReader();
                if (sqlDR.HasRows)
                {
                    sqlDR.Read();                    
                    dt.Load(sqlDR);                   
                }
                return dt;                
            }               
        }

        public static List<PedidoItem> ObterNotaFiscalItens(int numeroNotaFiscal)
        {
            List<PedidoItem> listItens = new List<PedidoItem>();
            string sql = @"SELECT NomeProduto
                            ,CodigoProduto
                            ,ValorItemPedido
                            ,Brinde	                        
                        FROM dbo.NotaFiscalItem 
                        WHERE IdNotaFiscal = @IdNotaFiscal";
            
            using (var con = GetConn())
            using (var sqlCmd = new SqlCommand(sql, con))
            {
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@IdNotaFiscal", numeroNotaFiscal);
               
                con.Open();
                var sqlDR = sqlCmd.ExecuteReader();
                if (sqlDR.HasRows)
                {
                    while (sqlDR.Read())
                    {
                        PedidoItem item = new PedidoItem();
                        item.NomeProduto = sqlDR["NomeProduto"].ToString();
                        item.CodigoProduto = sqlDR["CodigoProduto"].ToString();
                        item.ValorItemPedido = Convert.ToDouble(sqlDR["ValorItemPedido"]);
                        item.Brinde = (bool)sqlDR["Brinde"];
                        listItens.Add(item);
                    }
                }
                return listItens;
            }
        }

        public static List<Domain.TratamentoFiscal> CarregarTratamentosFiscais(string ufOrigem, string ufDestino, int opcao)
        {
            List<TratamentoFiscal> listTratFiscal = new List<TratamentoFiscal>();
            string sql = @"SELECT [Id]
                                ,[EstadoOrigem]
                                ,[EstadoDestino]
                                ,[Cfop]
                                ,[TipoIcms]
                                ,[AliquotaIcms]
                                ,[AliquotaIpi]
                                ,[ReducaoBaseIcms]
                                ,[Brinde]
                                ,[Desconto]
                                ,[DataAlteracao]
                            FROM [dbo].[TratamentoFiscal] ";
            if (opcao == 1)
                sql += @"WHERE EstadoOrigem = @EstadoOrigem and EstadoDestino = @EstadoDestino";
            else if (opcao == 2)
                sql += @"WHERE EstadoOrigem = @EstadoOrigem";
            else if (opcao == 3)
                sql += @"WHERE EstadoDestino = @EstadoDestino";

            using (var con = GetConn())
            using (var sqlCmd = new SqlCommand(sql, con))                
            {
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@estadoOrigem", ufOrigem);
                sqlCmd.Parameters.AddWithValue("@estadoDestino", ufDestino);                

                con.Open();
                var sqlDR = sqlCmd.ExecuteReader();
                if (sqlDR.HasRows)
                {
                    while (sqlDR.Read())
                    {
                        TratamentoFiscal tratFiscal = new TratamentoFiscal();
                        tratFiscal.Id = Convert.ToInt32(sqlDR["Id"]);
                        tratFiscal.EstadoOrigem = sqlDR["EstadoOrigem"].ToString();
                        tratFiscal.EstadoDestino = sqlDR["EstadoDestino"].ToString();
                        tratFiscal.Cfop = sqlDR["Cfop"].ToString();
                        tratFiscal.TipoIcms = sqlDR["TipoIcms"].ToString();
                        tratFiscal.AliquotaIcms = Convert.ToDouble(sqlDR["AliquotaIcms"]);
                        tratFiscal.AliquotaIpi = Convert.ToDouble(sqlDR["AliquotaIpi"]);
                        tratFiscal.ReducaoBaseIcms = Convert.ToInt32(sqlDR["ReducaoBaseIcms"]);
                        tratFiscal.Brinde = Convert.ToBoolean(sqlDR["Brinde"]);
                        tratFiscal.Desconto = Convert.ToDouble(sqlDR["Desconto"]);
                        tratFiscal.DataAlteracao = Convert.ToDateTime(sqlDR["DataAlteracao"]);
                        listTratFiscal.Add(tratFiscal);
                    }
                }
            }
            return listTratFiscal;
        }

        public static int GravarTratamentoFiscal(Domain.TratamentoFiscal tratFiscal)
        {
            using (var _sqlCon = GetConn())
            using (var sqlCmd = new SqlCommand("dbo.P_TRATAMENTO_FISCAL", _sqlCon))
            {
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddRange(new[]{
                    new SqlParameter("@pId", tratFiscal.Id) { Direction = ParameterDirection.InputOutput },
                    new SqlParameter("@pEstadoOrigem", tratFiscal.EstadoOrigem),
                    new SqlParameter("@pEstadoDestino", tratFiscal.EstadoDestino),
                    new SqlParameter("@pCfop", tratFiscal.Cfop),
                    new SqlParameter("@pBrinde", tratFiscal.Brinde),
                    new SqlParameter("@pTipoIcms", tratFiscal.TipoIcms),
                    new SqlParameter("@pAliquotaIcms", tratFiscal.AliquotaIcms),
                    new SqlParameter("@pAliquotaIpi", tratFiscal.AliquotaIpi),
                    new SqlParameter("@pReducaoBaseIcms", tratFiscal.ReducaoBaseIcms),
                    new SqlParameter("@pDesconto", tratFiscal.Desconto)                    
                });             
                _sqlCon.Open();
                sqlCmd.ExecuteScalar();
                return Convert.ToInt32(sqlCmd.Parameters["@pId"].Value);
            }
        }
    }
}
