using AbovePremierWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace AbovePremierWeb.DAOs
{
    public class KeyDAO
    {
        public static KeyDAO instance;

        public static KeyDAO getInstance()
        {
            if (instance == null)
            {
                KeyDAO.instance = new KeyDAO();
            }

            return instance;

        }

        private void agregarKey(String key)
        {

            var queryBuilder = DBConn.getInstance().getQueryBuilder();

            queryBuilder.setQuery("INSERT INTO ValKeys (valkey) VALUES (@valkey)");
            queryBuilder.addParam("@valkey", key);

            DBConn.getInstance().abm(queryBuilder);

        }

        public bool verificarKey(String key)
        {
            var queryBuilder = DBConn.getInstance().getQueryBuilder();

            queryBuilder.setQuery("SELECT * FROM ValKeys WHERE valkey=@valkey");
            queryBuilder.addParam("@valkey", key);

            var dataReader = DBConn.getInstance().select(queryBuilder);

            if (dataReader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<String> listaKeys = new List<String>();

        public void generarKeys()
        {
            //Esta Key es para usarla de prueba rápida de registro de usuario
            var keyPrueba= "ABCD-EFGH-0123-4567-8901";

            if (!verificarKey(keyPrueba)){
                agregarKey(keyPrueba);
            }
            

            String caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            String caracteres2 = "0123456789";



            for (int j = 0; j < 10; j++)
            {
                StringBuilder res = new StringBuilder();
                Random rnd = new Random();
                String aux = "";

                for (int i = 0; i < 2; i++)
                {

                    for (int k = 0; k < 4; k++)
                    {
                        res.Append(caracteres[rnd.Next(caracteres.Length)]);
                        aux = res.ToString();
                        

                    }

                    Console.WriteLine("Termine 1 vuelta");
                }
                for (int i = 0; i < 3; i++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        res.Append(caracteres2[rnd.Next(caracteres2.Length)]);
                        aux = res.ToString();
                        
                    }
                    
                }
                aux = Regex.Replace(aux, ".{4}", "$0-");
                aux = aux.TrimEnd('-');
                agregarKey(aux);
                
            }

        }

        public void borrarKey(String key)
        {
            var queryBuilder = DBConn.getInstance().getQueryBuilder();

            queryBuilder.setQuery("DELETE FROM ValKeys WHERE valkey=@valkey");
            queryBuilder.addParam("@valkey", key);

            DBConn.getInstance().abm(queryBuilder);
        }

        /*public void mostrarKeys()
        {
            foreach (var item in listaKeys)
            {
                Console.WriteLine("//" + item + "//\n");
            }
        }*/
    }
}