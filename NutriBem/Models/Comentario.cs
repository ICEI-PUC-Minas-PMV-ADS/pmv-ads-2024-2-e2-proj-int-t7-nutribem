using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NutriBem.Models
{
    [Table("Comentarios")]
    public class Comentario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataHora { get; set; }
        public string Conteudo { get; set; }
    }
}
