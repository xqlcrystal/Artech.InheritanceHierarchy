using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Artech.InheritanceHierarchy.Client
{
    public class FullWhetherForecastClient:SimpleWhetherForecastClient,IFullWhetherForecast
    {
        public BusinessEntity.WindInfo GetWindInfo(string postalcode)
        {
            return this.Channel.GetWindInfo(postalcode);
        }
    }
}
