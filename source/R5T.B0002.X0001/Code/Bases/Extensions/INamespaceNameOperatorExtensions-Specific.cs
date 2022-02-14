using System;

using R5T.B0002;

using Instances = R5T.B0002.X0001.Instances;


namespace System
{
    public static partial class INamespaceNameOperatorExtensions
    {
        public static bool IsInLocalData(this INamespaceNameOperator _,
            string namespaceName)
        {
            var output = _.IsInNamespace(
                namespaceName,
                Instances.NamespaceName.LocalData());

            return output;
        }

        public static bool IsInR5T(this INamespaceNameOperator _,
            string namespaceName)
        {
            var output = _.IsInNamespace(
                namespaceName,
                Instances.NamespaceName.R5T());

            return output;
        }
    }
}
