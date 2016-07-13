using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Artech.InheritanceHierarchy.BusinessEntity;
namespace Artech.InheritanceHierarchy.Service
{
    public class FullWhetherForecastService:SimpleWhetherForecastService,IFullWhetherForecast
    {
        public BusinessEntity.WindInfo GetWindInfo(string postalcode)
        {
            WindInfo info = new WindInfo(WindDirection.Northwest, "12km/h");
            return info;
        }
    }
}
