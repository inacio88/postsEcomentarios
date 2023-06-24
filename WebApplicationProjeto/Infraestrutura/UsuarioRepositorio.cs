using WebApplicationProjeto.Model;

namespace WebApplicationProjeto.Infraestrutura
{
    public class UsuarioRepositorio : IUsuaio
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public int Add(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            _context.SaveChanges();

            int id = usuario.usuario_id;
            return id;
        }

        public List<Usuario> GetAll()
        {
            return _context.Usuario.ToList();
        }
    }
}
