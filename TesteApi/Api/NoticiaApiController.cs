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
        private readonly NoticiaCRUD _ntc= new NoticiaCRUD();
        public IEnumerable<Noticia> Get()
        {
            return _ntc.ListarNoticias();
        }
        [HttpPost]
        public HttpResponseMessage Post(Noticia noticia)
        {
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
            _ntc.Save(noticia);
            return Request.CreateResponse(HttpStatusCode.Created, noticia);
        }

        [Route("api/detalhe/{noticiaId}")]
        [HttpGet]
        public Noticia Get(string noticiaId)
        {
            if (noticiaId!=null)
            {
                return _ntc.GetById(noticiaId);
            }
            return new Noticia();
        }
    }
}
