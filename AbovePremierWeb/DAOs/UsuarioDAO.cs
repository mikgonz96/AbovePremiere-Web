using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using AbovePremierWeb.Models;
using AbovePremierWeb;

namespace AbovePremierWeb.DAOs
{
    public class UsuarioDAO
    {
        /*public static List<Usuario> listaUsuarios = new List<Usuario>();

        public static void generarUsuarios()
        {
            listaUsuarios.Add(new Usuario("Homero", "123"));
            listaUsuarios.Add(new Usuario("Mik", "456"));
            listaUsuarios.Add(new Usuario("Profe", "789"));
            listaUsuarios.Add(new Usuario("Josu", "1112"));

        }

        public static bool verificarUsuario(string mail, string pass)
        {
            var usuario = listaUsuarios.Find(datosUsuario => datosUsuario.mail == mail && datosUsuario.pass == pass);

            if (usuario != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/

        public static UsuarioDAO instance;

        public static UsuarioDAO getInstance()
        {
            if (instance == null)
            {
                UsuarioDAO.instance = new UsuarioDAO();
            }

            return instance;

        }

        public void agregarUsuario(Usuario usuario)
        {

            var queryBuilder = DBConn.getInstance().getQueryBuilder();

            queryBuilder.setQuery("INSERT INTO Usuarios (mail,pass) VALUES (@mail,@pass)");
            queryBuilder.addParam("@mail", usuario.mail);
            queryBuilder.addParam("@pass", usuario.pass);

            DBConn.getInstance().abm(queryBuilder);

        }

        public bool verificarUsuario(Usuario usuario)
        {
            var queryBuilder = DBConn.getInstance().getQueryBuilder();

            queryBuilder.setQuery("SELECT * FROM Usuarios WHERE mail=@mail AND pass=@pass");
            queryBuilder.addParam("@mail", usuario.mail);
            queryBuilder.addParam("@pass", usuario.pass);

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

        /*public Usuario getUsuarioByMail(string mail)
        {
            var queryBuilder = DBConn.getInstance().getQueryBuilder();

            queryBuilder.setQuery("SELECT * FROM usuarios WHERE mail=@mail");
            queryBuilder.addParam("@mail", mail);

            var dataReader = DBConn.getInstance().select(queryBuilder);
            Usuario user = null;

            while (dataReader.Read())
            {
                user = new Usuario(dataReader.GetString(0), dataReader.GetString(1));
            }

            return user;
        }*/
    }
}
