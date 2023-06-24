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
        //private readonly IUsuaio _usuarioRepositorio;

        public PostController(IPost postRepositorio)
        {
            _postRepositorio = postRepositorio;
        }
        //public UsuarioController(IUsuaio usuarioRepositorio)
        //{
        //    _usuarioRepositorio = usuarioRepositorio;
        //}


        [HttpPost]
        public IActionResult Add(PostViewModel postView)
        {
            var post = new Post(postView.usuario_id, postView.texto);
            _postRepositorio.Add(post);
            return Ok();
        }
        //[HttpPost]
        //public IActionResult Add(UsuarioViewModel usuarioView)
        //{
        //    var usuario = new Usuario(usuarioView.Nome, usuarioView.Email);
        //    _usuarioRepositorio.Add(usuario);
        //    return Ok();
        //}

        [HttpGet]
        public IActionResult GetAll()
        {
            var posts = _postRepositorio.GetAll();
            return Ok(posts);
        }
        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    var usuarios = _usuarioRepositorio.GetAll();

        //    return Ok(usuarios);
        //}
    }
}
