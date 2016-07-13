using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Artech.InheritanceHierarchy.BusinessEntity;
namespace Artech.InheritanceHierarchy.Client
{

    [ServiceContract]
    public interface ISimpleWhetherForecast
    {
        [OperationContract]
        BasicWhetherInfo GetBasicWhetherInfo(string postalcode);
    }

}
