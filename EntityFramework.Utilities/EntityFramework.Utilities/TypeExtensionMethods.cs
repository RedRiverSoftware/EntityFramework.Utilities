using System;
using System.Collections.Generic;

namespace EntityFramework.Utilities
{
    public static class TypeExtensionMethods
    {
        public static IEnumerable<Type> GetBaseTypes(this Type type)
        {
            if (type == null)
                yield break;

            for (var nextType = type.BaseType; nextType != null; nextType = nextType.BaseType)
                yield return nextType;

        }
    }
}
