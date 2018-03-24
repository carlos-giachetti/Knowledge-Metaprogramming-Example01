using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;


namespace Knowledge.Metaprogramming.Example01
{
    public class Log
    {
        private List<string> result;

 
        public Log()
        {
            result = new List<string>();
        }


        public Log Reset()
        {
            result.Clear();
            return this;
        }


        public Log Add(object obj)
        {
            if (obj == null)
                return this;

            // Gets metadata describing the object's class
            Type classMetaData = obj.GetType();

            // Adds a blank row between log blocks (each 'block' describes an object)
            if(count > 0)
                result.Add(String.Empty);

            // Reports the name of the class
            result.Add(classMetaData.Name);

            // Reports the type/name/value of each property of that object
            foreach (PropertyInfo property in classMetaData.GetProperties())
            {
                result.Add(String.Format("  {0} {1} = {2}",
                                            property.PropertyType.Name,
                                                property.Name,
                                                      property.GetValue(obj).ToString()
                                        )
                          );
            }

            return this;
        }


        private int count
        {
            get { return result.Count;  }
        }


        public List<string> GetResult()
        {
            return result;
        }


        override public string ToString()
        {
            StringBuilder buffer = new StringBuilder();

            foreach (string row in result)
            {
                buffer.AppendLine(row);
            }

            return  buffer.ToString();
        }
    }
}
