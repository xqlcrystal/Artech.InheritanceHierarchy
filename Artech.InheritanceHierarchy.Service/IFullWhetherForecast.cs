﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Artech.InheritanceHierarchy.BusinessEntity;
namespace Artech.InheritanceHierarchy.Service
{
    [ServiceContract]
    public interface IFullWhetherForecast:ISimpleWhetherForecast
    {
        [OperationContract]
        WindInfo GetWindInfo(string postalcode);
    }
}
