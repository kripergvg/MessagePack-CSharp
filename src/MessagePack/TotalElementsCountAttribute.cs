using System;
using System.Collections.Generic;
using System.Text;

namespace MessagePack
{
    public class TotalElementsCountAttribute : Attribute
    {
        public TotalElementsCountAttribute(int maxTotalCount)
        {
            MaxTotalCount = maxTotalCount;
        }

        public int MaxTotalCount { get; }
    }
}
