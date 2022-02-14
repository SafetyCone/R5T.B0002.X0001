using System;
using System.Collections.Generic;
using System.Linq;

using R5T.B0002;

using Glossary = R5T.B0002.X0001.Glossary;

using Instances = R5T.B0002.X0001.Instances;


namespace System
{
    public static partial class INamespaceNameTokenOperatorExtensions
    {
        /// <summary>
        /// <inheritdoc cref="Glossary.RepositoryNamespaceNameToken" path="/definition"/>
        /// </summary>
        public static string GetRepositoryNamespaceNameToken(this INamespaceNameTokenOperator _,
            IEnumerable<string> namespaceNameTokens)
        {
            var output = namespaceNameTokens.Second();
            return output;
        }

        public static bool IsNumbered(this INamespaceNameTokenOperator _,
            string namespaceNameToken)
        {
            var output = Instances.RegularExpressionOperator.IsMatch(
                namespaceNameToken,
                Instances.RegularExpressionPattern.NumberedNamespaceName());

            return output;
        }
    }
}
