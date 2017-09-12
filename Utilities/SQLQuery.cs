using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bs_Pro14.Utilities
{
    class SQLQuery
    {
        private List<string> fieldsList = new List<string>();
        private List<Object> valuesList = new List<Object>();
        private string Fields, Values, table, action, field, value;

        public SQLQuery(string table, string action)
        {
            if (action != "insert" && action != "delete" && action != "update")
                throw new Exception("Invalid action");
            this.action = action;
            this.table = table;
            this.Fields = "";
            this.Values = "";
        }

        public SQLQuery(string table, string action, string field, string value) : this(table, action)
        {
            this.field = field;
            this.value = value;
        }

        public void AddToQuery(string field, Object value)
        {
            fieldsList.Add(field);
            valuesList.Add("'" + value + "'");
        }

        public void AddToQuery(string field, Object value, string preValue)
        {
            fieldsList.Add(field);
            valuesList.Add(preValue + "'" + value + "'");
        }

        public override string ToString()
        {
            Fields = "";
            Values = "";
            //Create string for insert statment
            if (action == "insert")
            { 
                if (valuesList.Count == fieldsList.Count)
                { 
                    for (int i = 0; i < valuesList.Count; i++)
                    {
                        Values += valuesList[i];
                        Fields += fieldsList[i];
                        if (i != valuesList.Count - 1) { 
                            Values += ", ";
                            Fields += ", ";
                        }
                    }
                }
                return "INSERT INTO " + table + " (" + Fields + ") VALUES (" + Values + ")";
            }
            
            //Create string for update statment
            if (action == "update")
            {
                if (ValuesList.Count == fieldsList.Count)
                {
                    for (int i = 0; i < ValuesList.Count; i++)
                    {
                        Values += fieldsList[i] + " = " + valuesList[i];
                        if (i != valuesList.Count - 1)
                            Values += ", ";
                    }
                }
                return "UPDATE " + table + " SET " + Values + " WHERE " + field + " = '" + value + "'";
            }

            //Create string for delete statment
            if (action == "delete")
            {
                return "DELETE FROM " + table + " WHERE + " + field + " = " + value;
            }

            return "Invalid action";
        }

        public List<string> FieldsList
        {
            get { return fieldsList; }
        }

        public List<Object> ValuesList
        {
            get { return valuesList; }
        }
    }
}
