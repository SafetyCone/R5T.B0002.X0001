using System;
using System.Collections.Generic;
using System.Linq;

using R5T.B0002;

using Glossary = R5T.B0002.X0001.Glossary;

using Instances = R5T.B0002.X0001.Instances;


namespace System
{
    public static partial class INamespaceNameOperatorExtensions
    {
        /// <inheritdoc cref="INamespaceNameTokenOperatorExtensions.GetRepositoryNamespaceNameToken(INamespaceNameTokenOperator, IEnumerable{string})"/>
        public static string GetRepositoryNamespaceNameToken(this INamespaceNameOperator _,
            string namespaceName)
        {
            var namespaceNameTokens = _.Tokenize(namespaceName);

            var output = Instances.NamespaceNameTokenOperator.GetRepositoryNamespaceNameToken(namespaceNameTokens);
            return output;
        }
    }
}
