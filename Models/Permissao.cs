using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutenticacaoEfCookie.Models
{
    public class Permissao
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPermissao { get; set; }

        [Required]
        [StringLength(40,MinimumLength=5)]
        public string Nome { get; set; }
        
        public ICollection<UsuarioPermissao> UsuarioPermissoes { get; set; }
    }

    
}