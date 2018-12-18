using System;

namespace HessianFramework
{
    public class Asset<T> : PartOfHessianStructure
    {
        public Guid? AssetID { get; internal set; }
        public Guid AssetGroupID { get; set; }
        public T AssetData { get; set; }
        public DateTime CreationTime { get; internal set; }
        public DateTime ModifyTime { get; internal set; }
    }
}
