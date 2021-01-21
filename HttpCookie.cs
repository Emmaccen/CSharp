using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    class HttpCookie
    {
        private readonly Dictionary<String, DateTime> _dictionary = new Dictionary<String, DateTime>();

            public DateTime this[string key]
        {
            get
            {
                return _dictionary[key];
            }
            set
            {
                _dictionary[key] = value;
            }
        }
    }
}
