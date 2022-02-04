using System;

namespace Kk.XLiteFilters
{
    [AttributeUsage(AttributeTargets.Field)]
    public class WorldNameAttribute : Attribute
    {
        public readonly string worldName;

        public WorldNameAttribute(string worldName)
        {
            this.worldName = worldName;
        }
    }
}