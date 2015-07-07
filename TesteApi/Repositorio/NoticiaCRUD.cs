using System;
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
            ctx.SqlBd.Query("insert into noticia (colunaid,corponoticia) values(@id,@notice)",
                new { id = entidade.ColunaId, notice =entidade.CorpoNoticia });
        }

        public IEnumerable<Noticia> ListarNoticias()
        {
            return ctx.SqlBd.Query<Noticia>("select colunaid,corponoticia from noticia").ToList();
        } 


    }
}