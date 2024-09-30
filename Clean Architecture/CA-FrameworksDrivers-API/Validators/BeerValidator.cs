using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CA_InterfaceAdapters_Mappers.Dtos.Requests;
using FluentValidation;

namespace CA_FrameworksDrivers_API.Validators
{
    public class BeerValidator : AbstractValidator<BeerRequestDTO>
    {
        public BeerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.Style).NotEmpty().WithMessage("Style is required");
            RuleFor(x => x.Alcohol).GreaterThan(0).WithMessage("Alcohol must be greater than 0");
        }
    }
}