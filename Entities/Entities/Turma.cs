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
    [Table("TURMA")]
    public class Turma : IdentityUser
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Required]
        [Column("NOME")]
        public string NomeTurma { get; set; }

        [Column("QUANTIDADE_DE_ALUNOS")]
        public int QuantidadeDeAlunos { get; set; }

        [Column("DATA_INICIO")]
        public DateTime DataInicio { get; set; }

        [Column("DATA_FIM")]
        public DateTime DataFim { get; set; }

        [Column("QUANTIDADE_MAXIMA_ALUNOS")]
        public bool QuantidadeMaximaAlunos { get; set; }  
    }
}
