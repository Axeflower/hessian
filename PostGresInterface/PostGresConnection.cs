using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HessianFramework;

namespace PostGresInterface
{
    public class PostGresConnection : IDataBase
    {
        public T ExecuteRPC<T>(string rpcName)
        {
            throw new NotImplementedException();
        }

        public T ExecuteRPC<T>(string rpcName, IDictionary<string, object> inputparameters)
        {
            throw new NotImplementedException();
        }

        public void ExecuteRPC(string rpcName, IDictionary<string, object> inputparameters)
        {
            throw new NotImplementedException();
        }

        public Task<T> ExecuteRPCAsync<T>(string rpcName)
        {
            throw new NotImplementedException();
        }

        public Task<T> ExecuteRPCASync<T>(string rpcName, IDictionary<string, object> inputparameters)
        {
            throw new NotImplementedException();
        }

        public Task ExecuteRPCAsync(string rpcName, IDictionary<string, object> inputparameters)
        {
            throw new NotImplementedException();
        }
    }
}
