using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ServerClasses
{
    class Serialize
    {
        public static byte[] BinarySerialize(Object obj)
        {
            byte[] serializedObject;
            MemoryStream ms = new MemoryStream();
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(ms, obj);
            ms.Seek(0, 0);
            serializedObject = ms.ToArray();
            ms.Close();
            return serializedObject;
        }
    }

    class Server
    {
        public static System.Data.DataTable ExecuteQueryOnServer(Dictionary<AllFunctions._IdData, object> input, decimal ooID)
        {
            Customer customer = new Customer();
            input.Add(AllFunctions._IdData.Event_ComputerName, System.Net.Dns.GetHostName());
            input.Add(AllFunctions._IdData.OfficeOperators_Id, ooID);
            input.Add(AllFunctions._IdData.Event_IpAddress, System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName())[0].ToString());
            OutputDatas result = new OutputDatas();
            result = customer.Suit(Serialize.BinarySerialize(input));
            if (result.success)
            {
                return result.ResultTable;
            }
            else
            {
                throw new Exception(result.Message);
            }
        }
    }
}
