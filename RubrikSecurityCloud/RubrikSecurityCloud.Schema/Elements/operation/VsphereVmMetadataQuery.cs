// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class VsphereVmMetadataQuery {
      /// <summary>
      /// VsphereVmMetadataQuery.Request 
      /// <para>Required variables:<br/> { id=(any) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = VsphereVmMetadataDocument,
          OperationName = "VsphereVmMetadata",
          Variables = variables
        };
      }

      
      public static string VsphereVmMetadataDocument = @"
        query VsphereVmMetadata($id: UUID!) {
          vSphereVmNew(fid: $id) {
            ...VsphereVmFragment3
          }
        }
        fragment EffectiveSlaDomainFragment on SlaDomain {
          id
          name
          ... on GlobalSlaReply {
            isRetentionLockedSla
            __typename
          }
          ... on ClusterSlaDomain {
            fid
            cluster {
              id
              name
              __typename
            }
            isRetentionLockedSla
            __typename
          }
          __typename
        }
        fragment VsphereVmFragment3 on VsphereVm {
          id
          authorizedOperations
          name
          isRelic
          effectiveSlaDomain {
            ...EffectiveSLADomainFragment
          }
          effectiveSlaSourceObject {
            fid
            name
            objectType
          }
          pendingSla {
            id
            name
          }
          protectionDate
          reportWorkload {
            id
            logicalBytes
            physicalBytes
            archiveStorage
          }
          cluster {
            id
            name
            status
            version
            lastConnectionTime
            defaultAddress
            ...ClusterNodeConnectionFragment
            ...ClusterStateFragment
            ...ClusterGlobalManagerFragment
          }
          primaryClusterLocation {
            id
            name
          }
          arrayIntegrationEnabled
          snapshotConsistencyMandate
          agentStatus {
            agentStatus
          }
          preBackupScript {
            scriptPath
            failureHandling
            timeoutMs
          }
          postBackupScript {
            scriptPath
            failureHandling
            timeoutMs
          }
          postSnapScript {
            scriptPath
            failureHandling
            timeoutMs
          }
          logicalPath {
            fid
            objectType
            name
          }
          physicalPath {
            fid
            objectType
            name
          }
          vsphereTagPath {
            fid
            objectType
            name
          }
          oldestSnapshot {
            id
            date
            isIndexed
          }
          totalSnapshots: snapshotConnection {
            count
          }
          replicatedObjects {
            id
            primaryClusterLocation {
              id
              name
            }
            cluster {
              name
              id
            }
          }
          newestArchivedSnapshot {
            id
            date
            isIndexed
            archivalLocations {
              id
              name
            }
          }
          newestReplicatedSnapshot {
            id
            date
            isIndexed
            replicationLocations {
              id
              name
            }
          }
          newestSnapshot {
            id
            date
            isIndexed
          }
          onDemandSnapshotCount
          vmwareToolsInstalled
          cdmLink
        }
        fragment EffectiveSLADomainFragment on SlaDomain {
          id
          name
          ... on ClusterSlaDomain {
            fid
            cluster {
              id
              name
            }
          }
        }
        fragment ClusterNodeConnectionFragment on Cluster {
          clusterNodeConnection {
            nodes {
              id
              status
              ipAddress
            }
          }
        }
        fragment ClusterStateFragment on Cluster {
          state {
            connectedState
            clusterRemovalState
          }
        }
        fragment ClusterGlobalManagerFragment on Cluster {
          passesConnectivityCheck
          globalManagerConnectivityStatus {
            urls {
              url
              isReachable
            }
          }
          connectivityLastUpdated
        }";
      
    }
}
