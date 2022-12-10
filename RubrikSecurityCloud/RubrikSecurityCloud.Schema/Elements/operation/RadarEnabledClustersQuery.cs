// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class RadarEnabledClustersQuery {
      /// <summary>
      /// RadarEnabledClustersQuery.Request 
      /// </summary>
      public static GraphQLRequest Request() {
        return new GraphQLRequest {
          Query = RadarEnabledClustersDocument,
          OperationName = "RadarEnabledClusters"
        };
      }

      
      public static string RadarEnabledClustersDocument = @"
        query RadarEnabledClusters {
          radarClusterConnection {
            ...ClusterConnectionFragment_RadarEnabledClusters
          }
        }
        fragment ClusterConnectionFragment_RadarEnabledClusters on ClusterConnection {
          nodes {
            lambdaConfig {
              clusterId
              enableAutomaticFmdUpload
            }
            name
          }
        }";
      
    }
}
