﻿namespace WebApplicationProjeto.Model
{
    public interface IComentario
    {
        void Add(Comentario comentario);

        List<Comentario> GetAll();
    }
}
