using System;
using System.Collections.Generic;
using System.Text;

namespace HessianFramework
{
    public class Content : PartOfHessianStructure
    {
        public Guid ContentID { get; internal set; }
        public List<Asset> Assets { get; set; }

    }
}
