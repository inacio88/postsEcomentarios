using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationProjeto.Model
{
    [Table("usuario")]
    public class Usuario
    {
        [Key]
        public int usuario_id { get; set; }
        public string nome { get; set; }
        public string email { get; set;}

        public Usuario(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }
    }
}
