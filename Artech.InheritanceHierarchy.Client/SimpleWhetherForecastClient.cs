using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
namespace Artech.InheritanceHierarchy.Client
{
    public class SimpleWhetherForecastClient:ClientBase<IFullWhetherForecast>,ISimpleWhetherForecast
    {

        public BusinessEntity.BasicWhetherInfo GetBasicWhetherInfo(string postalcode)
        {
            return this.Channel.GetBasicWhetherInfo(postalcode);
        }
    }
}
