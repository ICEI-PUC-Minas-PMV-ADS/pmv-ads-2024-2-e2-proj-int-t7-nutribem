using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace NutriBem.Models
{
    [Table("PlanosAlimentares")]
    public class PlanoAlimentar
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome.")]

        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome do Paciente.")]

        [Display(Name = "Nome do Paciente")]
        public string Nomepaciente { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Objetivo.")]

        public string Objetivo { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a descrição")]
        public string Descricao { get; set; }
        
        public string Observacao {  get; set; }

        public ICollection<Refeicao> Refeicoes { get; set; }

    }
}
