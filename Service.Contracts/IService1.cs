using System.ServiceModel;
using Data.Contracts;

namespace Service.Contracts
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
        // TODO: Add your service operations here
    }
}
