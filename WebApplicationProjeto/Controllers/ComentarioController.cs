using Microsoft.AspNetCore.Mvc;
using WebApplicationProjeto.Model;
using WebApplicationProjeto.ViewModel;

namespace WebApplicationProjeto.Controllers
{
    [ApiController]
    [Route("api/comentaio")]
    public class ComentarioController : Controller
    {
        private readonly IComentario _comentarioRepositorio;
        public ComentarioController(IComentario comentarioRepositorio)
        {
            _comentarioRepositorio = comentarioRepositorio;
        }

        [HttpPost]
        public IActionResult Add(ComentarioViewModel comentarioView)
        {
            var comentario = new Comentario(comentarioView.post_id, comentarioView.texto);
            _comentarioRepositorio.Add(comentario);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            var comentarios = _comentarioRepositorio.GetAll();
            return Ok(comentarios);
        }
    }
}
