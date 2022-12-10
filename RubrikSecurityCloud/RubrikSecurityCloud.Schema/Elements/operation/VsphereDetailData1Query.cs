// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class VsphereDetailData1Query {
      /// <summary>
      /// VsphereDetailData1Query.Request 
      /// <para>Required variables:<br/> { fid=(any) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = VsphereDetailData1Document,
          OperationName = "VsphereDetailData1",
          Variables = variables
        };
      }

      
      public static string VsphereDetailData1Document = @"
        query VsphereDetailData1($fid: UUID!) {
          vSphereVmNew(fid: $fid) {
            ...VsphereVmFragment1
          }
        }
        fragment SlaDomainFragment1 on SlaDomain {
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
        fragment VsphereVmFragment1 on VsphereVm {
          id
          authorizedOperations
          name
          isRelic
          effectiveSlaDomain {
            ...SlaDomainFragment1
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
        }";
      
    }
}
