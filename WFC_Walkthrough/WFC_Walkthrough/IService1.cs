using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WFC_Walkthrough
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(string value);

        [OperationContract]
        void MutateCompositeType(ref CompositeType composite);

        [OperationContract]
        string Get(string request);

        // TODO: Add your service operations here

        //[OperationContract]
        //SomeOtherClass GetSome();
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WFC_Walkthrough.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [DataContract]
    public class SomeOtherClass
    {
        int intValue = 1;
        string stringValue = "2";
        bool boolValue = true;

        //public SomeOtherClass(int i, string s, bool b)
        //{
        //    intValue = i;
        //    stringValue = s;
        //    boolValue = b;
        //}

        [DataMember]
        public string Stuff
        {
            get
            {
                return String.Format("{0}, {1}, {2}", intValue, stringValue, boolValue);
            }
        }
    }

    [DataContract]
    public static class StaticClass
    {
        static bool status = false;
        static Guid guid = new Guid();
        public static string Flip()
        {
            string ret;
            if (status)
            {
                ret = "Off"; ;
            }
            else
            {
                ret = "ON";
            }
            status = !status;
            return ret;
        }

        public static Guid GetId()
        {
            return guid;
        }


    }
}
