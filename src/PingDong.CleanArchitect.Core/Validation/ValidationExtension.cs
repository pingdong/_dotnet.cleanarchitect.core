using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using FluentValidation.Results;

namespace PingDong.CleanArchitect.Core.Validation
{
    public static class ValidationExtension
    {
        public static void Validate<T>(this IEnumerable<IValidator<T>> rules, T entity) 
                                where T : IAggregateRoot
        {
            if (rules == null)
                return;
            
            var rulesList = rules.ToList();
            if (!rulesList.Any())
                return;

            var errors = new List<ValidationFailure>();

            foreach (var rule in rulesList)
            {
                var result = rule.Validate(entity);

                if (!result.IsValid)
                    errors.AddRange(result.Errors);
            }

            if (errors.Any())
                throw new ValidationException("Invalid data", errors);
        }
    }
}
