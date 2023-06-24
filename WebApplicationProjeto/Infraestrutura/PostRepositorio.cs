using WebApplicationProjeto.Model;

namespace WebApplicationProjeto.Infraestrutura
{
    public class PostRepositorio : IPost
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void Add(Post post)
        {
            _context.Post.Add(post);
            _context.SaveChanges();
        }

        public List<Post> GetAll()
        {
            return _context.Post.ToList();
        }
    }
}
