using ClinicaACME.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaACME.Models
{
    [Table("Cadastro_Pacientes")]
    public class Paciente : IPaciente
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get ; set ; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        [Required]
        public string Nome { get; set; }

        [Column("Data-Nascimento")]
        [Display(Name = "Data de Nascimento")]
        [Required]
        public DateTime DataNascimento { get; set; }

        [Column("CPF")]
        [Display(Name = "CPF")]
        [Required]
        public string CPF { get; set; }

        [Column("Sexo")]
        [Display(Name = "Sexo")]
        [Required]
        public string Sexo { get; set; }

        [Column("Endereco")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Column("Status_Ativo")]
        [Display(Name = "Ativo")]
        [Required]
        public bool StatusAtivo { get; set; }
    }
}
