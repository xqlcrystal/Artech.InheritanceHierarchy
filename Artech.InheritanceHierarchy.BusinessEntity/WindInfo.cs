using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
namespace Artech.InheritanceHierarchy.BusinessEntity
{
    [DataContract]
    [KnownType(typeof(WindDirection))]
    public class WindInfo
    {
        private WindDirection _direction;

        [DataMember]
        public WindDirection Direction
        {
            get { return _direction; }
            set { _direction = value; }
        }
        private string _speed;

        [DataMember]
        public string Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public WindInfo(WindDirection direction,string speed)
        {
            this._direction = direction;
            this._speed = speed;
        }

        public override string ToString()
        {
            return string.Format("Direction:{0},Speed:{1}",this._direction,this._speed);
        }
    }

    public enum WindDirection
    {
        East,
        South,
        West,
        North,
        Northeast,
        SouthEast,
        Northwest,
        Southwest
        
    }
}
