﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using TesteApi.Models;

namespace TesteApi.Repositorio
{
    public class NoticiaCRUD
    {
        private readonly Contexto ctx=new Contexto();
        public void Save(Noticia entidade)
        {
            ctx.SqlBd.Query("insert into noticia (id,colunaid,corponoticia) values(@id,@colunaid,@notice)",
                new {id=entidade.Id, colunaid = entidade.ColunaId, notice =entidade.CorpoNoticia });
        }
        public IEnumerable<Noticia> ListarNoticias()
        {
            return ctx.SqlBd.Query<Noticia>("select id,colunaid,corponoticia from noticia").ToList();
        }

        public Noticia GetById(string id)
        {
           return ctx.SqlBd.Query<Noticia>("select id,colunaid,corponoticia from noticia where id = @noticiaid", new {noticiaid = id}).FirstOrDefault();
        }

        public void Update(Noticia entidade)
        {
            ctx.SqlBd.Query("update noticia set corponoticia = @cn , colunaId = @cId where id = @id", new
            {
                id = entidade.Id,
                cn = entidade.CorpoNoticia,
                cId =  entidade.ColunaId
            });
        }


        public void Remove(string id)
        {
            ctx.SqlBd.Query("delete  from noticia where id = @noticiaId", new {noticiaId = id});
        }
    }
}