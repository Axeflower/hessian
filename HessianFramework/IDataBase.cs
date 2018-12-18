using System;
using System.Collections.Generic;
using System.Text;

namespace HessianFramework
{
    public interface IDataBase
    {
        T ExecuteRPC<T>();
        void ExecuteRPC();
        T ExecuteRPC<T>(object inputparameters);
        void ExecuteRPC(object inputparameters);

    }
}
