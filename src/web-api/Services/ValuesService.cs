using System;
using System.Collections.Generic;
using Serilog;

namespace Sample.Services
{
    public class ValuesService
    {
        private readonly List<string> values;

        public ValuesService()
        {
            values = new List<string>
            {
                "value1",
                "value2"
            };
        }

        public void Add(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));

            Log.Information("Adding {value}", value);

            values.Add(value);
        }

        public string[] GetAll()
        {
            Log.Information("Get all values"); ;

            return values.ToArray();
        }

        public void Remove(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));

            Log.Information("Removing {value}", value);

            values.Remove(value);
        }
    }
}
