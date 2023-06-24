using WebApplicationProjeto.Model;

namespace WebApplicationProjeto.Infraestrutura
{
    public class ComentarioRepositorio : IComentario
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void Add(Comentario comentario)
        {
            _context.Comentario.Add(comentario);
            _context.SaveChanges();
        }

        public List<Comentario> GetAll()
        {
            return _context.Comentario.ToList();
        }
    }
}
