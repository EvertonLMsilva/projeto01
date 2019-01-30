using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Site01.Models;

namespace Site01.Models
{
    public class Usuario
    {      
            
        [Required(ErrorMessage = "O campo 'Email' é obrigatório!")]
        [EmailAddress(ErrorMessage = "O campo 'Email' é Inválido!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo 'Senha' é obrigatório!")]
        public string Senha { get; set; }
    }
}
