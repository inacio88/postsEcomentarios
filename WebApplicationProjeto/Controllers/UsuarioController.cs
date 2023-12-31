﻿using Microsoft.AspNetCore.Mvc;
using WebApplicationProjeto.Model;
using WebApplicationProjeto.ViewModel;

namespace WebApplicationProjeto.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuaio _usuarioRepositorio;

        public UsuarioController(IUsuaio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpPost]
        public IActionResult Add(UsuarioViewModel usuarioView)
        {
            var usuario = new Usuario(usuarioView.nome, usuarioView.email);
            var id = _usuarioRepositorio.Add(usuario);
            return Ok(id);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var usuarios = _usuarioRepositorio.GetAll();

            return Ok(usuarios);
        }
    }
}
