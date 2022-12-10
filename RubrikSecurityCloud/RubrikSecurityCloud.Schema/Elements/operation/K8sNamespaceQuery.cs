// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class K8sNamespaceQuery {
      /// <summary>
      /// K8sNamespaceQuery.Request 
      /// <para>Required variables:<br/> { polaris_id=(any) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = K8sNamespaceDocument,
          OperationName = "K8sNamespace",
          Variables = variables
        };
      }

      
      public static string K8sNamespaceDocument = @"
        query K8sNamespace($polaris_id: UUID!) {
          k8sNamespace(fid: $polaris_id) {
            ...K8sNamespaceFragment
          }
        }
        fragment K8sNamespaceFragment on K8sNamespace {
          k8sClusterId
          namespaceName
          clusterScoped
          apiVersion
          resourceVersion
          isRelic
          numWorkloads
          numPvcs
          authorizedOperations
          id
          name
          objectType
          slaAssignment
          effectiveSlaDomain {
            name
            id
          }
          slaPauseStatus
          effectiveRetentionSlaDomain {
            id
            name
          }
          configuredSlaDomain {
            id
            name
          }
          effectiveSlaSourceObject {
            fid
            name
            objectType
          }
          logicalPath {
            fid
            name
            objectType
          }
          physicalPath {
            fid
            name
            objectType
          }
          numWorkloadDescendants
          newestSnapshot {
            id
            date
          }
          oldestSnapshot {
            id
            date
          }
          onDemandSnapshotCount
          newestIndexedSnapshot {
            id
            date
          }
        }";
      
    }
}
