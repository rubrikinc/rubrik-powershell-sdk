// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class CreateK8sClusterMutation {
      /// <summary>
      /// CreateK8sClusterMutation.Request 
      /// <para>Required variables:<br/> { hostList=(string[]), name=(string), rbsPort=(PortRange[]), port=(int), type=(K8sClusterProtoType) }</para>
      /// <para>Optional variables:<br/> { cdmClusterId=(any), userDrivenPortRanges=(PortRange[]), proxyUrl=(string) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = CreateK8sClusterDocument,
          OperationName = "CreateK8sCluster",
          Variables = variables
        };
      }

      
      public static string CreateK8sClusterDocument = @"
        mutation CreateK8sCluster($cdmClusterId: UUID, $hostList: [String!]!, $name: String!, $rbsPort: [PortRange!]!, $userDrivenPortRanges: [PortRange!], $port: Int!, $type: K8sClusterProtoType!, $proxyUrl: String) {
          createK8sCluster(
            input: {cdmClusterId: $cdmClusterId, hostList: $hostList, name: $name, rbsPortRanges: $rbsPort, userDrivenPortRanges: $userDrivenPortRanges, port: $port, type: $type, proxyUrl: $proxyUrl}
          ) {
            ...CreateK8sClusterFragment
          }
        }
        fragment CreateK8sClusterFragment on CreateK8sClusterReply {
          clusterId
          yamlUrl
        }";
      
    }
}
