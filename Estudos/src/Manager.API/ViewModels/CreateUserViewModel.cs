using System.ComponentModel.DataAnnotations;

namespace Manager.API.ViewModels{
    public class CreateUserViewModel{
   [Required(ErrorMessage = "O nome não pode ser vazio.")]
   [MinLength(3, ErrorMessage = "O nome deve ter no minimo 3 caracteres")]
   [MaxLength(80, ErrorMessage = "O nome deve ter no maximo 80 caracteres")]
   public string Name { get; set; }

   [Required(ErrorMessage = "O email não pode ser vazio.")]
   [MinLength(3, ErrorMessage = "O email deve ter no minimo 6 caracteres")]
   [MaxLength(80, ErrorMessage = "O email deve ter no maximo 180 caracteres")]
   [RegularExpression(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$", ErrorMessage = "O email informado não é válido"),]
   public string Email { get; set; }

   [Required(ErrorMessage = "A senha não pode ser vazia.")]
   [MinLength(3, ErrorMessage = "A senha deve ter no minimo 6 caracteres")]
   [MaxLength(80, ErrorMessage = "A senha deve ter no maximo 80 caracteres")]
   public string Password { get;  set; }
   
    
    }
} 