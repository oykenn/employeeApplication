using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeApplication
{
    internal class Employee
    {
        private String _empID;
        private String _fName;
        private String _lName;
        private String _position;

        public Employee(String empID, String fName, String lName, String position) 
        { 
            this._empID = empID;
            this._fName = fName;
            this._lName = lName;
            this._position = position;
        }

        public String[] getFields() 
        { 
            List<String> fields = new List<String>();
            fields.Add(this._empID);
            fields.Add(this._fName);
            fields.Add(this._lName);
            fields.Add(this._position);

            return fields.ToArray();
        }
    }
}
