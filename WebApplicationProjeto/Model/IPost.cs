namespace WebApplicationProjeto.Model
{
    public interface IPost
    {
        int Add(Post post);

        List<Post> GetAll();
    }
}
