using System;

using R5T.B0000;


namespace R5T.B0002.X0001
{
    public static class Instances
    {
        public static IRegularExpressionOperator RegularExpressionOperator { get; } = B0000.RegularExpressionOperator.Instance;
        public static IRegularExpressionPattern RegularExpressionPattern { get; } = B0000.RegularExpressionPattern.Instance;
        public static INamespaceName NamespaceName { get; } = B0002.NamespaceName.Instance;
        public static INamespaceNameTokenOperator NamespaceNameTokenOperator { get; } = B0002.NamespaceNameTokenOperator.Instance;
    }
}
