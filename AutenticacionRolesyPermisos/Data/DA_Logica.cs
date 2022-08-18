using AutenticacionRolesyPermisos.Models;

namespace AutenticacionRolesyPermisos.Data
{
    public class DA_Logica
    {
        public List<Usuario> ListaUsuarios  (){

            return new List<Usuario>
            {
                new Usuario { 
                    Nombre = "Anderson",
                    Correo = "admin@mail.com",
                    Clave = "12345",
                    Roles = new string[]{
                    "Administracion"
                    }
                },
                new Usuario {
                    Nombre = "Maria",
                    Correo = "maria@mail.com",
                    Clave = "12345",
                    Roles = new string[]{
                    "Supervisor"
                    }
                },
                new Usuario {
                    Nombre = "Nicolas",
                    Correo = "nicolas@mail.com",
                    Clave = "12345",
                    Roles = new string[]{
                    "Empleado"
                    }
                },
                new Usuario {
                    Nombre = "Brandon",
                    Correo = "brandon@mail.com",
                    Clave = "12345",
                    Roles = new string[]{
                    "Supervisor", "Empleado"
                    }
                }
            };
        }

        public Usuario ValidarUsuario(string _correo, string _clave) {
            return ListaUsuarios().Where(item => item.Correo == _correo && item.Clave==_clave).FirstOrDefault();
        }




    }
}
