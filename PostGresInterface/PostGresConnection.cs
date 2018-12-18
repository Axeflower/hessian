using System;
using HessianFramework;

namespace PostGresInterface
{
    public class PostGresConnection : IDataBase
    {
        public T ExecuteRPC<T>()
        {
            throw new NotImplementedException();
        }

        public void ExecuteRPC()
        {
            throw new NotImplementedException();
        }

        public T ExecuteRPC<T>(object inputparameters)
        {
            throw new NotImplementedException();
        }

        public void ExecuteRPC(object inputparameters)
        {
            throw new NotImplementedException();
        }
    }
}
