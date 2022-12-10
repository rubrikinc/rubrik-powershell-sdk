// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class RefreshK8sClusterMutation {
      /// <summary>
      /// RefreshK8sClusterMutation.Request 
      /// <para>Required variables:<br/> { input=(RefreshK8sClusterInput) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = RefreshK8sClusterDocument,
          OperationName = "RefreshK8sCluster",
          Variables = variables
        };
      }

      
      public static string RefreshK8sClusterDocument = @"
        mutation RefreshK8sCluster($input: RefreshK8sClusterInput!) {
          refreshK8sCluster(input: $input) {
            ...RefreshK8sClusterFragment
          }
        }
        fragment RefreshK8sClusterFragment on CreateOnDemandJobReply {
          taskchainId
          jobId
        }";
      
    }
}
