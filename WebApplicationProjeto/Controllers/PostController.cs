using Microsoft.AspNetCore.Mvc;
using WebApplicationProjeto.Model;
using WebApplicationProjeto.ViewModel;

namespace WebApplicationProjeto.Controllers
{
    [ApiController]
    [Route("api/post")]
    public class PostController : ControllerBase
    {
        private readonly IPost _postRepositorio;
        
        public PostController(IPost postRepositorio)
        {
            _postRepositorio = postRepositorio;
        }
        


        [HttpPost]
        public IActionResult Add(PostViewModel postView)
        {
            var post = new Post(postView.usuario_id, postView.texto);
            var id = _postRepositorio.Add(post);
            return Ok(id);
        }
        
        [HttpGet]
        public IActionResult GetAll()
        {
            var posts = _postRepositorio.GetAll();
            return Ok(posts);
        }
        
    }
}
