using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
namespace Artech.InheritanceHierarchy.BusinessEntity
{
    [DataContract]
    [KnownType(typeof(WhetherConditions))]
    public class BasicWhetherInfo
    {
        private WhetherConditions _condition;

        [DataMember]
        public WhetherConditions Condition
        {
            get { return _condition; }
            set { _condition = value; }
        }
        private double _temperature;

        [DataMember]
        public double Temperature
        {
            get { return _temperature; }
            set { _temperature = value; }
        }

        public BasicWhetherInfo(WhetherConditions condition,double temperature)
        {
            this._condition = condition;
            this._temperature = temperature;
        }

        public override string ToString()
        {
            return string.Format("Condition:{0},Temperature:{1}", this._condition, this._temperature);
        }
    }

    public enum WhetherConditions
    {
        Clear,
        Cloudy,
        OverCost,
        Rainy
    }
}
