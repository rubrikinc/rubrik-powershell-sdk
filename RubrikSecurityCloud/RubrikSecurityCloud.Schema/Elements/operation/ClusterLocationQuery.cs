// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class ClusterLocationQuery {
      /// <summary>
      /// ClusterLocationQuery.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { filter=(ClusterFilterInput) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = ClusterLocationDocument,
          OperationName = "ClusterLocation",
          Variables = variables
        };
      }

      
      public static string ClusterLocationDocument = @"
        query ClusterLocation($filter: ClusterFilterInput) {
          clusterConnection(filter: $filter) {
            ...ClusterConnectionFragment_Location
          }
        }
        fragment ClusterConnectionFragment_Location on ClusterConnection {
          nodes {
            id
            name
            geoLocation {
              address
            }
          }
        }";
      
    }
}
