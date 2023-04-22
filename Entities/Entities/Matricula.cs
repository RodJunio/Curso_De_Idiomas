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
    [Table("MATRICULA")]
    public class Matricula : IdentityUser
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        
        [ForeignKey("ID_ALUNO")]
        public Aluno Id_Aluno { get; set; }

        [ForeignKey("ID_TURMA")]        
        public Turma IdTurma { get; set; }

        [Column("DATA_MATRICULA")]
        public DateTime DataMatricula { get; set; }
    }
}
