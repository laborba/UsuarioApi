using System.ComponentModel.DataAnnotations;

namespace UsuariosApi.Data.Dtos;

public class CreateUsuarioDto
{
    [Required]
    public string Username { get; set; }
    [Required]
    public DateTime DataNascimento { get; set; }
    [Required]
    [DataType(DataType.Password)]    //Para explicitar que este campo é de senha (este comando não permite senhas simples (exemplo: "senha")
    public string Password { get; set; }
    [Required]
    [Compare("Password")]            //Para confirmar se a senha foi digitada de forma igual
    public string RePassword { get; set; }
}
