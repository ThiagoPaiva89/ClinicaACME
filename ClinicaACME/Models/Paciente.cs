using ClinicaACME.Interface;
using ClinicaACME.Models.Enums;
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
        [Required(ErrorMessage = "O preenchimento do nome é obrigatório")]
        public string Nome { get; set; }

        [Column("Data-Nascimento")]
        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "A data de nascimento é obrigatória")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        [Column("CPF")]
        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O CPF é obrigatório")]
        public string CPF { get; set; }

        [Column("Sexo")]
        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "O campo sexo é de escolha obrigatória")]
        public SexoPaciente Sexo { get; set; }

        [Column("Endereco")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Column("Status_Ativo")]
        [Display(Name = "Ativo")]
        [Required]
        public bool StatusAtivo { get; set; }

        public Paciente()
        {

        }

        public Paciente(int id, string nome, DateTime dataNascimento, string cpf, SexoPaciente sexo, string endereco, bool statusAtivo)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            CPF = cpf;
            Sexo = sexo;
            Endereco = endereco;
            StatusAtivo = statusAtivo;
        }

    }
}
