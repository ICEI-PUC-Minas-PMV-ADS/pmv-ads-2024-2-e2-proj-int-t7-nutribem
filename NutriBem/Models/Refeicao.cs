using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NutriBem.Models
{
    [Table("Refeicoes")]
    public class Refeicao
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório informar o tipo de refeição")]
        [Display(Name ="Tipo de refeição")]
        public int Tipo { get; set; }

        [Required(ErrorMessage ="Obrigatório informar o horário da refeição")]
        [Display(Name ="Horário da Refeição")]
        public TimeOnly Hora { get; set; }

        public int PlanoAlimentarId { get; set; }

        [ForeignKey("PlanoAlimentarId")]
        public PlanoAlimentar PlanoAlimentar { get; set; }

        public int ReceitaId { get; set; }

        [ForeignKey("ReceitaId")]
        public Receita Receita { get; set; }


    }
}
