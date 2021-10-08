using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AspNetAspxCRUD
{
    public class Pessoa
    {
        public int id;
        public string nome;
        public int idade;
        public int altura;

        public bool gravarPessoa()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirconexao();
            SqlTransaction tran = null;

            SqlCommand cmd = new SqlCommand();
            tran = cn.BeginTransaction();

            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into pessoas values (@nome, @idade, @altura)";
            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@idade", SqlDbType.Int);
            cmd.Parameters.Add("@altura", SqlDbType.Int);
            cmd.Parameters[0].Value = nome;
            cmd.Parameters[1].Value = idade;
            cmd.Parameters[2].Value = altura;

            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception e)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.fecharconexao();
            }
        }

        public bool excluirPessoa()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirconexao();
            SqlTransaction tran = null;

            SqlCommand cmd = new SqlCommand();
            tran = cn.BeginTransaction();

            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from pessoas where id = @id";
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters[0].Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception e)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.fecharconexao();
            }
        }

        public bool alterarPessoa()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirconexao();
            SqlTransaction tran = null;

            SqlCommand cmd = new SqlCommand();
            tran = cn.BeginTransaction();

            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update pessoas set nome = @nome, idade = @idade, altura = @altura where id = @id";
            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@idade", SqlDbType.Int);
            cmd.Parameters.Add("@altura", SqlDbType.Int);
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters[0].Value = nome;
            cmd.Parameters[1].Value = idade;
            cmd.Parameters[2].Value = altura;
            cmd.Parameters[3].Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception e)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.fecharconexao();
            }
        }

        public Pessoa retornaPessoa(int id)
        {
            Banco bd = new Banco();

            try
            {
                SqlConnection cn = bd.abrirconexao();
                SqlDataReader rdr = null;

                SqlCommand sqlComm = new SqlCommand("select * from pessoas", cn);
                
                rdr = sqlComm.ExecuteReader();

                while (rdr.Read())
                {
                    if(rdr.GetInt32(0) == id)
                    {
                        id = 1;
                        nome = rdr.GetString(1);
                        idade = rdr.GetInt32(2);
                        altura = rdr.GetInt32(3);

                        return this;
                    }
                }

                return null;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                bd.fecharconexao();
            }
        }
    }
}