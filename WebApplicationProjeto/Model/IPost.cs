namespace WebApplicationProjeto.Model
{
    public interface IPost
    {
        void Add(Post post);

        List<Post> GetAll();
    }
}
