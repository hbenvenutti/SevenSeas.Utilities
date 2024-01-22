using System.ComponentModel.DataAnnotations;
using SevenSeas.Utilities.ValueTypes.Brazil.Documents;

namespace SevenSeas.Utilities.Validation.Annotations;

public class CpfAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(
        object? value,
        ValidationContext validationContext
    )
    {
        if (value == null)
        {
            return new ValidationResult(Cpf.ErrorMessage);
        }

        var cpf = value.ToString() ?? string.Empty;

        return !Cpf.TryParse(cpf, out _)
            ? new ValidationResult(Cpf.ErrorMessage)
            : ValidationResult.Success;
    }
}
