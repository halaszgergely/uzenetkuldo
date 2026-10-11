using System.Collections.Generic;
using System.ServiceModel;
using uzenetkuldo.Models;

namespace uzenetkuldo
{

    [ServiceContract]
    public interface IUzenetService
    {

        [OperationContract]
        List<Uzenet> GetAllUzenet();

        [OperationContract]
        string CreateUzenet(Uzenet uzenet);

        [OperationContract]
        string UpdateUzenet(Uzenet uzenet);

        [OperationContract]
        string DeleteUzenet(int id);

    }



}
