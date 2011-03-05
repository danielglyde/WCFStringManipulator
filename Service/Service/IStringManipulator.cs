using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ServiceModel;

namespace Glyde.ServiceModel.Examples
{
    [ServiceContract(Namespace = "http://Glyde.ServiceModel.Examples")]
    public interface IStringManipulator
    {
        [OperationContract]
        string Add(string s1, string s2);
        [OperationContract]
        string Delete(string s1, string s2);
        [OperationContract]
        string Replace(string s1, string s2, string s3);
    }
}
