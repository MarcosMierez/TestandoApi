using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TesteApi.Models;
using TesteApi.Repositorio;

namespace TesteApi.Api
{
    public class NoticiaApiController : ApiController
    {
        private NoticiaCRUD ntc= new NoticiaCRUD();
        public IEnumerable<Noticia> Get()
        {
            return ntc.ListarNoticias();
        }
        public HttpResponseMessage Post(Noticia noticia)
        {
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
            ntc.Save(noticia);
            return Request.CreateResponse(HttpStatusCode.Created, noticia);
        }
    }
}
