// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class SnapshotDetailQuery {
      /// <summary>
      /// SnapshotDetailQuery.Request 
      /// <para>Required variables:<br/> { workloadId=(string) }</para>
      /// <para>Optional variables:<br/> { first=(int), after=(string), snapshotFilter=(SnapshotQueryFilterInput[]), sortBy=(SnapshotQuerySortByField), sortOrder=(SortOrder), timeRange=(TimeRangeInput) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = SnapshotDetailDocument,
          OperationName = "SnapshotDetail",
          Variables = variables
        };
      }

      
      public static string SnapshotDetailDocument = @"
        query SnapshotDetail($workloadId: String!, $first: Int, $after: String, $snapshotFilter: [SnapshotQueryFilterInput!], $sortBy: SnapshotQuerySortByField, $sortOrder: SortOrder, $timeRange: TimeRangeInput) {
          snapshotOfASnappableConnection(
            workloadId: $workloadId
            first: $first
            after: $after
            snapshotFilter: $snapshotFilter
            sortBy: $sortBy
            sortOrder: $sortOrder
            timeRange: $timeRange
          ) {
            ...SnapshotListFragment
          }
        }
        fragment SnapshotListFragment on GenericSnapshotConnection {
          edges {
            node {
              id
              date
              expirationDate
              isOnDemandSnapshot
              ... on CdmSnapshot {
                cdmVersion
                isDownloadedSnapshot
                cluster {
                  id
                  name
                  version
                  status
                }
                pendingSnapshotDeletion {
                  id: snapshotFid
                  status
                }
                slaDomain {
                  name
                  ... on ClusterSlaDomain {
                    fid
                    cluster {
                      id
                      name
                    }
                  }
                  ... on GlobalSlaReply {
                    id
                  }
                }
                pendingSla {
                  id
                  name
                }
                snapshotRetentionInfo {
                  archivalInfos {
                    name
                    isExpirationDateCalculated
                    expirationTime
                  }
                  localInfo {
                    name
                    isExpirationDateCalculated
                    expirationTime
                  }
                  replicationInfos {
                    name
                    isExpirationDateCalculated
                    expirationTime
                  }
                }
                sapHanaAppMetadata {
                  backupId
                  backupPrefix
                  snapshotType
                  files {
                    backupFileSizeInBytes
                  }
                }
                legalHoldInfo {
                  shouldHoldInPlace
                }
              }
              ... on PolarisSnapshot {
                isDownloadedSnapshot
                isReplica
                isArchivalCopy
                slaDomain {
                  name
                  ... on ClusterSlaDomain {
                    fid
                    cluster {
                      id
                      name
                    }
                  }
                  ... on GlobalSlaReply {
                    id
                  }
                }
              }
            }
          }
          pageInfo {
            endCursor
            hasNextPage
          }
        }";
      
    }
}
