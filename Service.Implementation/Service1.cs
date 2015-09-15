using System;
using System.ServiceModel;
using Business.Logic;
using Data.Contracts;
using Service.Contracts;

namespace Service.Implementation
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple )]
    public class Service1 : IService1
    {
        private readonly IAction _action;

        public Service1()
        {            
        }
        public Service1(IAction action)
        {
            _action = action;
        }

        public string GetData(int value)
        {
            if (_action == null)
                return "zero";
            try
            {
                return _action.GetData(value);
            }
            catch (Exception ex)
            {
                ProvideFault(ex);
                throw;
            }
        }

        private static void ProvideFault(Exception ex)
        {
            //throw new NotImplementedException();
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException(nameof(composite));
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
