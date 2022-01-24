using FluentValidation;
using Manager.Domain.Entities;

namespace Manager.Domain.Validators{
    public class UserValidator : AbstractValidator<User>{
   
    public UserValidator()
    {
      RuleFor(x => x)
      .NotEmpty()
      .WithMessage("A entidade não pode ser vazia.")

      .NotNull()
      .WithMessage("A entidade não pode ser nula.");

      RuleFor(x => x.Name)
      .NotEmpty()
      .WithMessage("A nome não pode ser vazio.")

      .NotNull()
      .WithMessage("A nome não pode ser nulo.")

      .MinimumLength(3).WithMessage("O nome deve ter no minimo 3 caracteres ")
      .MaximumLength(80).WithMessage("O nome deve ter no maximo 80 caracteres ");

   RuleFor(x => x.Password)
      .NotEmpty()
      .WithMessage("A senha não pode ser vazia.")

      .NotNull()
      .WithMessage("A senha não pode ser nula.")

      .MinimumLength(6).WithMessage("O nome deve ter no minimo 6 caracteres ")
      .MaximumLength(30).WithMessage("O nome deve ter no maximo 30 caracteres ");


      RuleFor(x => x.Email)
      .NotEmpty()
      .WithMessage("A nome email pode ser vazio.")

      .NotNull()
      .WithMessage("A nome email pode ser nulo.")

      .MinimumLength(10).WithMessage("O email deve ter no minimo 3 caracteres ")
      .MaximumLength(180).WithMessage("O email deve ter no maximo 80 caracteres ")

      .Matches(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$")
      .WithMessage("O email informado não é valido ");
    }
    }
}