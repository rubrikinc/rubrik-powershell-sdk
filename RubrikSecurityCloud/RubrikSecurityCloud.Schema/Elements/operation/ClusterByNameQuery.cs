// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class ClusterByNameQuery {
      /// <summary>
      /// ClusterByNameQuery.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { clusterNames=(string[]), after=(string) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = ClusterByNameDocument,
          OperationName = "ClusterByName",
          Variables = variables
        };
      }

      
      public static string ClusterByNameDocument = @"
        query ClusterByName($clusterNames: [String!], $after: String) {
          clusterConnection(first: 20, filter: {name: $clusterNames}, after: $after) {
            ...ClusterConnectionFragment_IdName
          }
        }
        fragment ClusterConnectionFragment_IdName on ClusterConnection {
          edges {
            node {
              id
              name
            }
          }
          pageInfo {
            ...PageInfoFragment_All
          }
        }
        fragment PageInfoFragment_All on PageInfo {
          startCursor
          endCursor
          hasNextPage
          hasPreviousPage
        }";
      
    }
}
