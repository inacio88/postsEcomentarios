using WebApplicationProjeto.Model;

namespace WebApplicationProjeto.Infraestrutura
{
    public class UsuarioRepositorio : IUsuaio
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public void Add(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            _context.SaveChanges();
            
        }

        public List<Usuario> GetAll()
        {
            return _context.Usuario.ToList();
        }
    }
}
