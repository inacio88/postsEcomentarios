using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationProjeto.Model
{
    [Table("comentario")]
    public class Comentario
    {
        [Key]
        public int comentario_id { get; set; }
        public int post_id { get; set; }
        public int usuario_id { get; set; }

        public string texto { get; set;}

        public Comentario(int post_id, string texto, int usuario_id) 
        {
            this.post_id = post_id;
            this.texto = texto;
            this.usuario_id = usuario_id;
        }
    }
}
