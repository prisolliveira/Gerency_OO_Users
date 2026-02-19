namespace GerencyOOUsers.Models
{
    public interface IUsuarios
    {
        IEnumerable<Usuario> ListarUsuarios()
        {
            return new List<Usuario>(); 
        }

    }
}
