using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Site01.Models
{
    public class Contato
    {
        [Required(ErrorMessage = "O campo 'Nome' é obrigatório!")]
        [MaxLength(50, ErrorMessage ="o campo 'Nome' deve conter no maximo 50 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo 'Email' é obrigatório!")]
        [MaxLength(70, ErrorMessage = "o campo 'Email' deve conter no maximo 70 caracteres")]
        [EmailAddress(ErrorMessage = "O campo 'Email' é Inválido!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo 'Assunto' é obrigatório!")]
        [MaxLength(70, ErrorMessage = "o campo 'Assunto' deve conter no maximo 70 caracteres")]
        public string Assunto { get; set; }
        [Required(ErrorMessage = "O campo 'Mensagem' é obrigatório!")]
        [MaxLength(2000, ErrorMessage = "o campo 'Mensagem' deve conter no maximo 2000 caracteres")]
        public string Mensagem { get; set; }
    }
}
