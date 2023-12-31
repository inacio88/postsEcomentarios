﻿using Microsoft.AspNetCore.Mvc;
using WebApplicationProjeto.Model;
using WebApplicationProjeto.ViewModel;

namespace WebApplicationProjeto.Controllers
{
    [ApiController]
    [Route("api/comentario")]
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
            var comentario = new Comentario(comentarioView.post_id, comentarioView.texto, comentarioView.usuario_id);
            _comentarioRepositorio.Add(comentario);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            var comentarios = _comentarioRepositorio.GetAll();
            return Ok(comentarios);
        }

        [HttpGet("{post_id}")]
        public IActionResult GetAllByPostId([FromRoute] int post_id)
        {
            var comentarios = _comentarioRepositorio.GetAllByPostId(post_id);
            return Ok(comentarios);
        }
    }
}
