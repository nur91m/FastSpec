using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecUI.Models
{
    public class Parameter
    {
        private int _id;
        private string _name;
        private DisplayUnitType _unitType;

        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        public DisplayUnitType UnitType
        {
            get { return _unitType; }
            private set { _unitType = value; }
        }
        public ParameterType ParameterType {get;}

    }


    public enum ParameterType
    {
        Instance,
        ElementType,
        Formula
    }
}
