using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MestreMotores
{
    public static class banco
    {
        public static string db =
            "SERVER=localhost;" +
            "USER=root;" +
            "DATABASE=db_mecanica";

        public static MySqlConnection conexao;

        public static void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(db);
                conexao.Open();
            }
            catch
            {
                MessageBox.Show("Erro ao conectar com o banco");
            }
        }
        public static void Desonectar()
        {
            try
            {
                conexao = new MySqlConnection(db);
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao desconectar com o banco");
            }
        }
    }
   


}
