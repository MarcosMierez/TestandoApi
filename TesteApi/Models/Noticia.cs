using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteApi.Models
{
    public class Noticia
    {
        public Noticia()
        {
            Id = Guid.NewGuid().ToString("N");

        }
        public string Id { get; set; }
        public string ColunaId { get; set; }
        public string CorpoNoticia { get; set; }
    }
}