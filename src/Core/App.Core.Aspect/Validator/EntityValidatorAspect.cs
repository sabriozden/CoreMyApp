using FluentValidation;
using FluentValidation.Results;
using PostSharp.Aspects;
using System;

namespace App.Core.Aspect.Validator
{
    public sealed class EntityValidatorAspect : OnMethodBoundaryAspect
    {
        public Type Type { get; }

        public EntityValidatorAspect(Type type)
        {
            Type = type;
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            //TODO:İmplementasyonu tamamalnacak.
            var validator = (IValidator)Activator.CreateInstance(Type);
            var t = args.Arguments.GetArgument(0);
            var c = t.GetType() == Type;

            ValidationResult validationResult = validator.Validate(t);

        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            base.OnSuccess(args);
        }

        public override void OnException(MethodExecutionArgs args)
        {
            base.OnException(args);
        }
    }
}