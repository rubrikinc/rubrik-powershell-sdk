// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class MssqlDatabaseSnapshotsQuery {
      /// <summary>
      /// MssqlDatabaseSnapshotsQuery.Request 
      /// <para>Required variables:<br/> { fid=(any) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = MssqlDatabaseSnapshotsDocument,
          OperationName = "MssqlDatabaseSnapshots",
          Variables = variables
        };
      }

      
      public static string MssqlDatabaseSnapshotsDocument = @"
        query MssqlDatabaseSnapshots($fid: UUID!) {
          mssqlDatabase(fid: $fid) {
            ...MssqlDatabaseSnapshotsFragment
          }
        }
        fragment MssqlDatabaseSnapshotsFragment on MssqlDatabase {
          cdmSnapshots {
            edges {
              node {
                id
                expirationDate
                expiryHint
                workloadId
                isCorrupted
                indexingAttempts
                isIndexed
                isUnindexable
                isOnDemandSnapshot
                workloadType
                clusterUuid
                cdmId
                cdmVersion
                retentionInfo
                isDownloadedSnapshot
                subObjs {
                  subObj {
                    volumeGroupSubObj {
                      mountPointsOpt
                      capacityInBytes
                      fileSystemType
                      fileSizeInBytes
                      volumeId
                    }
                  }
                }
                isExpired
                slaDomain {
                  id
                  name
                }
                date
                latestUserNote {
                  time
                  userName
                  objectId
                  userNote
                }
              }
            }
          }
        }";
      
    }
}
