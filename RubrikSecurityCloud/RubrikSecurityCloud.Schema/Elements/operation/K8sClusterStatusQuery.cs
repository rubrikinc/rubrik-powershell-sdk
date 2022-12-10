// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class K8sClusterStatusQuery {
      /// <summary>
      /// K8sClusterStatusQuery.Request 
      /// <para>Required variables:<br/> { kupr_cluster_id=(any) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = K8sClusterStatusDocument,
          OperationName = "K8sClusterStatus",
          Variables = variables
        };
      }

      
      public static string K8sClusterStatusDocument = @"
        query K8sClusterStatus($kupr_cluster_id: UUID!) {
          k8sCluster(fid: $kupr_cluster_id) {
            ...K8sClusterStatusFragment
          }
        }
        fragment K8sClusterStatusFragment on K8sCluster {
          status
          slaAssignment
        }";
      
    }
}
