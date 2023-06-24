using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationProjeto.Model
{
    [Table("post")]
    public class Post
    {
        [Key]
        public int post_id { get; set; }
        public int usuario_id { get; set; }
        public string texto { get; set; }
        public Post(int usuario_id, string texto)
        {
            this.usuario_id = usuario_id;
            this.texto = texto;
        }
    }
}
