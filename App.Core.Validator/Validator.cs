using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using PostSharp.Aspects;

namespace App.Core.Validator
{
    public class Validator : OnMethodBoundaryAspect
    {
        public Type Type { get; }

        public Validator(Type type)
        {
            Type = type;
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            //TODO:İmplementasyonu tamamalnacak.
           var validator= Activator.CreateInstance(Type);
           
            
            base.OnEntry(args);
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
