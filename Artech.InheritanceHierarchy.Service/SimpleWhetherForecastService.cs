using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Artech.InheritanceHierarchy.BusinessEntity;


namespace Artech.InheritanceHierarchy.Service
{
    public class SimpleWhetherForecastService:ISimpleWhetherForecast
    {
        public BasicWhetherInfo GetBasicWhetherInfo(string postalcode)
        {
            BasicWhetherInfo info = new BasicWhetherInfo(WhetherConditions.OverCost, 23);
            return info;
        }
    }
}
