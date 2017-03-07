using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationPrevinindoSql_Injection.Formularios
{
    public partial class Colaboradores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                //Crio a variável que irá armazenar a string de conexão
                string strConn = "Data Source=TOM-PC;Initial Catalog=VETORH;Persist Security Info=True;User ID=sa;Password=sabbath123";

                //Crio a conexão por meio do using, que me garante que após o uso, a conexão será fechada
                using (SqlConnection objConn = new SqlConnection(strConn))
                {
                    //Passo a instrução SQL por meio do SqlCommand e concateno
                    //meu Where com o que o usuário digitar no TextBox
                    SqlCommand objCmd = new SqlCommand("SELECT Numcad, NomFun FROM r034fun WHERE " +
                                                                               "NUMCAD = @NUMCAD", objConn);
                    //Uso o método AddWithValue, que recebe meu parâmetro @Codigo e meu TextBox
                    objCmd.Parameters.AddWithValue("@NUMCAD", txtConsultar.Text);

                    //Instancio o DataTable passando como parâmetro o SqlCommand
                    SqlDataAdapter objDtAdapter = new SqlDataAdapter(objCmd);

                    //Instancio o DataSet
                    DataSet ds = new DataSet();

                    //Uso o método Fill do DataAdapter, passando como parâmetro o DataSet e minha Tabela
                    objDtAdapter.Fill(ds);

                    //Uso o método DataSource de meu GridView, que receberá meu DataSet e chamo o DataBind
                    GdVResultado.DataSource = ds;
                    GdVResultado.DataBind();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}