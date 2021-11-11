using FluentValidation;
using Program.Entities;

namespace Program.Validations
{
	public class AdministradorValidator : AbstractValidator<Administrador>
	{
		public AdministradorValidator()
		{
			RuleFor(a => a.Nome)
				.NotEmpty().WithMessage("O nome deve ser informado.")
				.Length(3, 50).WithMessage("O nome deve conter entre 3 e 50 caracteres.")
				.Matches("^[0-9 a-zA-ZáàâãéèêíïóôõöúçñÁÀÂÃÉÈÊÍÏÓÔÕÖÚÇÑ]+$").WithMessage("O nome contém caracteres inválidos.");

			RuleFor(a => a.Cpf)
				.NotEmpty().WithMessage("O CPF deve ser informado.")
				.Length(11).WithMessage("O CPF deve conter exatamente 11 caracteres.")
				.Must(ValidarCpf).WithMessage("CPF inválido.");

			RuleFor(a => a.Senha)
				.NotEmpty().WithMessage("A senha deve ser informada.")
				.Length(6, 16).WithMessage("A senha deve conter entre 6 e 16 caracteres.");
		}

		public static bool ValidarCpf(string cpf)
		{
			int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			string tempCpf;
			string digito;
			int soma;
			int resto;
			cpf = cpf.Trim();
			cpf = cpf.Replace(".", "").Replace("-", "");
			if (cpf.Length != 11)
				return false;
			tempCpf = cpf.Substring(0, 9);
			soma = 0;

			for (int i = 0; i < 9; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = resto.ToString();
			tempCpf = tempCpf + digito;
			soma = 0;
			for (int i = 0; i < 10; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = digito + resto.ToString();
			return cpf.EndsWith(digito);
		}
	}
}
