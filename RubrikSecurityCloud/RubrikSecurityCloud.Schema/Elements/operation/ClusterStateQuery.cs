// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class ClusterStateQuery {
      /// <summary>
      /// ClusterStateQuery.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { filter=(ClusterFilterInput) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = ClusterStateDocument,
          OperationName = "ClusterState",
          Variables = variables
        };
      }

      
      public static string ClusterStateDocument = @"
        query ClusterState($filter: ClusterFilterInput) {
          clusterConnection(filter: $filter) {
            ...ClusterConnectionFragment_State
          }
        }
        fragment ClusterConnectionFragment_State on ClusterConnection {
          nodes {
            id
            name
            state {
              connectedState
            }
          }
        }";
      
    }
}
