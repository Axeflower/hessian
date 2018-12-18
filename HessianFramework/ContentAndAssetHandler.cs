using System;
using System.Collections.Generic;
using System.Text;

namespace HessianFramework
{
    public class ContentAndAssetHandler
    {
        private IDataBase DataBase { get; set; }
        public ContentAndAssetHandler(IDataBase db)
        {
            DataBase = db;
        }
        public void SaveAsset<T>(Asset<T> asset)
        {
            if(asset.AssetID is null)
            {
                asset.AssetID = Guid.NewGuid();
                asset.CreationTime = DateTime.UtcNow;
            }
            else
            {
                asset.ModifyTime = DateTime.UtcNow;
            }

            var dbInput = new Dictionary<string, object>();
            dbInput.Add(nameof(asset.AssetID), asset.AssetID);

            DataBase.ExecuteRPC("UpsertAsset", dbInput);
        }
        private Dictionary<string, object> CreateDBInputForAsset<T>(Asset<T> asset)
        {
            var dbInput = new Dictionary<string, object>();
            dbInput.Add(nameof(asset.AssetID), asset.AssetID);
            dbInput.Add(nameof(asset.CreationTime), asset.AssetID);
        }

    }
}
