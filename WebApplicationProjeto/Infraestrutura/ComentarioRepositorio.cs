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

        public List<Comentario> GetAllByPostId(int post_id)
        {
            
                var resultado = _context.Comentario
                    .Where(comentario => comentario.post_id == post_id)
                    .ToList();

     

            return resultado;
        }
    }
}
