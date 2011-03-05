using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Glyde.ServiceModel.Examples
{
    class StringManipulatorService : IStringManipulator
    {
        public string Add(string s1, string s2)
        {
            return s1 + s2;
        }

        public string Delete(string s1, string s2)
        {
            return s1.Replace(s2, string.Empty);
        }

        public string Replace(string s1, string s2, string s3)
        {
            return s1.Replace(s2, s3);
        }
    }
}
