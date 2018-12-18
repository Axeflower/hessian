using System;
using System.Collections.Generic;
using System.Text;

namespace HessianFramework
{
    public class AssetHandler
    {
        private IDataBase DataBase { get; set; }
        public AssetHandler(IDataBase db)
        {
            DataBase = db;
        }

    }
}
