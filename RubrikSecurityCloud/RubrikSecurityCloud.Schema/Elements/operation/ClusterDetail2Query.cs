// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class ClusterDetail2Query {
      /// <summary>
      /// ClusterDetail2Query.Request 
      /// <para>Required variables:<br/> { id=(any) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = ClusterDetail2Document,
          OperationName = "ClusterDetail2",
          Variables = variables
        };
      }

      
      public static string ClusterDetail2Document = @"
        query ClusterDetail2($id: UUID!) {
          clusterConnection(filter: {id: [$id]}) {
            nodes {
              snappableConnection(filter: {cluster: {id: [$id]}}) {
                aggregation {
                  archiveStorage
                  replicaStorage
                }
              }
              estimatedRunway
              ...ClusterStateFragment2
              ...ClusterGlobalManagerFragment2
              ...ClusterAuthorizedOperationsFragment2
              ...ClusterCardSummaryFragment2
            }
          }
        }
        fragment ClusterCardSummaryFragment2 on Cluster {
          systemStatus
          systemStatusAffectedNodes {
            id
            __typename
          }
          clusterNodeConnection {
            count
          }
        }
        fragment ClusterStateFragment2 on Cluster {
          state {
            connectedState
            clusterRemovalState
          }
        }
        fragment ClusterGlobalManagerFragment2 on Cluster {
          passesConnectivityCheck
          globalManagerConnectivityStatus {
            urls {
              url
              isReachable
            }
          }
          connectivityLastUpdated
        }
        fragment ClusterAuthorizedOperationsFragment2 on Cluster {
          authorizedOperations {
            id
            operations
          }
        }";
      
    }
}
