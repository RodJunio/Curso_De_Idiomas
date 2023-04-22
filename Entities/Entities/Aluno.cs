using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("ALUNO")]
    public class Aluno : IdentityUser
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Required]
        [Column("NOME")]
        public string NameAluno { get; set; }

        [Required]
        [Column("CPF")]
        public string Cpf { get; set; }

        [Required]
        [Column("EMAIL")]
        public string Email { get; set; 

        [Column("MATRICULA")]
        public int Matricula { get; set; }
        [Column("DATA_DE_CADASTRO")]
        public DateTime DataDeCadastro { get; set; }
        [Column("QUANTIDADE_DE_CURSOS")]
        public int QuantidadeDeCursos { get; set; }

    }
}
