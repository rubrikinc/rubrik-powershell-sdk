// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class K8sNamespacesQuery {
      /// <summary>
      /// K8sNamespacesQuery.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { filter=(Filter[]) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = K8sNamespacesDocument,
          OperationName = "K8sNamespaces",
          Variables = variables
        };
      }

      
      public static string K8sNamespacesDocument = @"
        query K8sNamespaces($filter: [Filter!]) {
          k8sNamespaces(filter: $filter) {
            edges {
              node {
                id
                k8sClusterId
                namespaceName
                isRelic
                configuredSlaDomain {
                  id
                  name
                  version
                }
                effectiveSlaDomain {
                  id
                  name
                  version
                }
              }
            }
            pageInfo {
              endCursor
              hasNextPage
            }
          }
        }
        ";
      
    }
}
