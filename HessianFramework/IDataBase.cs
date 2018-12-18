using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HessianFramework
{
    public interface IDataBase
    {
        T ExecuteRPC<T>(string rpcName);      
        T ExecuteRPC<T>(string rpcName, IDictionary<string,object> inputparameters);
        void ExecuteRPC(string rpcName, IDictionary<string, object> inputparameters);
        Task<T> ExecuteRPCAsync<T>(string rpcName);       
        Task<T> ExecuteRPCASync<T>(string rpcName, IDictionary<string, object> inputparameters);
        Task ExecuteRPCAsync(string rpcName, IDictionary<string, object> inputparameters);

    }

    public static class ObjectToInputParametersHelper
    {
        public static IDictionary<string, object> GenerateInputParametersFromProperties<T>(this T obj) where T :class
        {
           return RecurseObject(obj, string.Empty);
        }

        private static IDictionary<string, object> RecurseObject(object obj, string prefix)
        {
            var ret = new Dictionary<string,object>();

            foreach (PropertyInfo prop in obj.GetType().GetProperties())
            {

            }

            return ret;
        }
    }
}
