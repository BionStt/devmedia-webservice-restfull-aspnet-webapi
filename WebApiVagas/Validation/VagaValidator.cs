using FluentValidation;
using WebApiVagas.Models.Entities;

namespace WebApiVagas.Validation
{
    public class VagaValidator : AbstractValidator<Vaga>
    {
        public VagaValidator()
        {
            RuleFor(v => v.Titulo)
                .NotEmpty().WithMessage("O título da vaga não pode ser vazio.")
                .MinimumLength(10).WithMessage("O título da vaga deve ter pelo menos 10 caracteres.")
                .MaximumLength(100).WithMessage("O título da vaga deve ter até 100 caracteres.");

            RuleFor(v => v.Descricao)
                .NotEmpty().WithMessage("A descrição da vaga não pode ser vazia.")
                .MinimumLength(10).WithMessage("A descrição da vaga deve ter pelo menos 10 caracteres.")
                .MaximumLength(200).WithMessage("A descrição da vaga deve ter até 200 caracteres.");

            RuleFor(v => v.Empresa)
                .NotEmpty().WithMessage("O nome da empresa não pode ser vazio.")
                .MinimumLength(3).WithMessage("O nome da empresa deve ter pelo menos 3 caracteres.")
                .MaximumLength(100).WithMessage("O nome da empresa ter até 50 caracteres.");

            RuleFor(v => v.SalarioInicial)
                .GreaterThan(0).WithMessage("O salário inicial deve ser maior que zero.")
                .LessThan(v => v.SalarioMaximo).WithMessage("O salário inicial deve ser menor que o salário máximo.");

            RuleFor(v => v.SalarioMaximo)
                .GreaterThan(0).WithMessage("O salário máximo deve ser maior que zero.");

            RuleFor(v => v.Requisitos)
                .NotEmpty().WithMessage("Os requisitos da vaga não podem ficar em branco.")
                .MinimumLength(2).WithMessage("Os requisitos da vaga devem ter pelo menos 10 caracteres.")
                .MaximumLength(200).WithMessage("Os requisitos da vaga devem ter até 200 caracteres.");

            RuleFor(v => v.EstadoTrabalho)
                .Matches("(AC|AL|AP|AM|BA|CE|DF|ES|GO|MA|MT|MS|MG|PA|PB|PR|PE|PI|RJ|RN|RS|RO|RR|SC|SP|SE|TO)").WithMessage("O estado de trabalho da vaga é inválido (deve ser a sigla da UF).");

            RuleFor(v => v.CidadeTrabalho)
                .NotEmpty().WithMessage("A cidade de trabalho da vaga não pode ficar em branco.")
                .MinimumLength(2).WithMessage("A cidade de trabalho da vaga deve ter pelo menos 2 caracteres.")
                .MaximumLength(200).WithMessage("A cidade de trabalho da vaga deve ter até 100 caracteres.");

            RuleFor(v => v.EmailContato)
                .NotEmpty().WithMessage("O email para contato não pode ficar em branco.")
                .EmailAddress().WithMessage("Informe um email válido para contato.")
                .MaximumLength(50).WithMessage("O email para contato deve ter até 50 caracteres.");
        }
    }
}