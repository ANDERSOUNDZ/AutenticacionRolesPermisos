namespace AutenticacionRolesyPermisos.Models
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }

        //Roles de usuario
        public string[] Roles { get; set; }
    }




}
