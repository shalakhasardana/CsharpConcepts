using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace StringProcessor3
{
    class stringProgessorManager
    {
        List<Type> _stringProcessor;
        public stringProgessorManager()
        {
            _stringProcessor = new List<Type>();
        }

        public int GetSringProcessorSucceedeCounts(string input)
        {
            var instances = from t in Assembly.GetExecutingAssembly().GetTypes()
                            where t.GetInterfaces().Contains(typeof(IStringProcessor))
                                     && t.GetConstructor(Type.EmptyTypes) != null
                            select Activator.CreateInstance(t) as IStringProcessor;

            int count = 0;
            foreach (var instance in instances)
            {
                if (instance.stringProcessor(input))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
