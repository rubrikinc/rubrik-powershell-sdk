// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class K8ClustersQuery {
      /// <summary>
      /// K8ClustersQuery.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { first=(int), after=(string), filter=(Filter[]), sortBy=(HierarchySortByField), sortOrder=(SortOrder) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = K8ClustersDocument,
          OperationName = "K8Clusters",
          Variables = variables
        };
      }

      
      public static string K8ClustersDocument = @"
        query K8Clusters($first: Int, $after: String, $filter: [Filter!], $sortBy: HierarchySortByField, $sortOrder: SortOrder) {
          k8sClusters(
            filter: $filter
            first: $first
            after: $after
            sortBy: $sortBy
            sortOrder: $sortOrder
          ) {
            ...K8ClustersFragment
          }
        }
        fragment K8ClustersFragment on K8sClusterConnection {
          edges {
            node {
              id
              name
              status
              slaAssignment
              lastRefreshTime
            }
          }
        }";
      
    }
}
