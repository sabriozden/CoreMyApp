using System;
using PostSharp.Aspects;
using PostSharp.Serialization;
using System.Transactions;

namespace App.Core.Aspect
{
    [Serializable]
    public class TransactionScopeAspect : OnMethodBoundaryAspect
    {
        private readonly TransactionScopeOption _option;
        private readonly IsolationLevel _isolationLevel;

        public TransactionScopeAspect()
        {
            _option = TransactionScopeOption.Required;
            _isolationLevel = IsolationLevel.ReadUncommitted;
        }

        public TransactionScopeAspect(TransactionScopeOption option,
            IsolationLevel isolationLevel = IsolationLevel.ReadUncommitted)
        {
            _option = option;
            _isolationLevel = isolationLevel;
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            args.MethodExecutionTag = new TransactionScope(_option,
                new TransactionOptions { IsolationLevel = _isolationLevel });
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            ((TransactionScope)args.MethodExecutionTag).Dispose();
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            ((TransactionScope)args.MethodExecutionTag).Complete();
        }

        public override void OnException(MethodExecutionArgs args)
        {
            ((TransactionScope)args.MethodExecutionTag).Dispose();
        }
    }
}