// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class SnapshotsListSingleQueryQuery {
      /// <summary>
      /// SnapshotsListSingleQueryQuery.Request 
      /// <para>Required variables:<br/> { workloadId=(string) }</para>
      /// <para>Optional variables:<br/> { first=(int), after=(string), snapshotFilter=(SnapshotQueryFilterInput[]), sortBy=(SnapshotQuerySortByField), sortOrder=(SortOrder), timeRange=(TimeRangeInput) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = SnapshotsListSingleQueryDocument,
          OperationName = "SnapshotsListSingleQuery",
          Variables = variables
        };
      }

      
      public static string SnapshotsListSingleQueryDocument = @"
        query SnapshotsListSingleQuery($workloadId: String!, $first: Int, $after: String, $snapshotFilter: [SnapshotQueryFilterInput!], $sortBy: SnapshotQuerySortByField, $sortOrder: SortOrder, $timeRange: TimeRangeInput) {
          snapshotOfASnappableConnection(
            workloadId: $workloadId
            first: $first
            after: $after
            snapshotFilter: $snapshotFilter
            sortBy: $sortBy
            sortOrder: $sortOrder
            timeRange: $timeRange
          ) {
            edges {
              cursor
              node {
                ...CdmSnapshotLatestUserNotesFragment
                id
                date
                expirationDate
                isOnDemandSnapshot
                ... on CdmSnapshot {
                  cdmVersion
                  isRetentionLocked
                  isDownloadedSnapshot
                  cluster {
                    id
                    name
                    version
                    status
                    __typename
                  }
                  pendingSnapshotDeletion {
                    id: snapshotFid
                    status
                    __typename
                  }
                  slaDomain {
                    ...EffectiveSlaDomainFragment
                    __typename
                  }
                  pendingSla {
                    ...SLADomainFragment
                    __typename
                  }
                  snapshotRetentionInfo {
                    isCustomRetentionApplied
                    archivalInfos {
                      name
                      isExpirationDateCalculated
                      expirationTime
                      locationId
                      __typename
                    }
                    localInfo {
                      name
                      isExpirationDateCalculated
                      expirationTime
                      __typename
                    }
                    replicationInfos {
                      name
                      isExpirationDateCalculated
                      expirationTime
                      locationId
                      isExpirationInformationUnavailable
                      __typename
                    }
                    __typename
                  }
                  sapHanaAppMetadata {
                    backupId
                    backupPrefix
                    snapshotType
                    files {
                      backupFileSizeInBytes
                      __typename
                    }
                    __typename
                  }
                  legalHoldInfo {
                    shouldHoldInPlace
                    __typename
                  }
                  __typename
                }
                ... on PolarisSnapshot {
                  isDeletedFromSource
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
                        __typename
                      }
                      __typename
                    }
                    ... on GlobalSlaReply {
                      id
                      __typename
                    }
                    __typename
                  }
                  __typename
                }
                __typename
              }
              __typename
            }
            pageInfo {
              endCursor
              hasNextPage
              __typename
            }
            __typename
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
        fragment SLADomainFragment on SlaDomain {
          id
          name
          ... on ClusterSlaDomain {
            fid
            cluster {
              id
              name
              __typename
            }
            __typename
          }
          __typename
        }
        fragment SlaDomainFragment on SlaDomainConnection {
          edges {
            node {
              name
              ... on ClusterSlaDomain {
                id: fid
                protectedObjectCount
                baseFrequency {
                  duration
                  unit
                }
                archivalSpec {
                  archivalLocationName
                }
                replicationSpec {
                  replicationType
                  specificReplicationSpec {
                    unidirectionalSpec {
                      replicationTargetName
                    }
                  }
                }
                replicationSpecsV2 {
                  cluster {
                    id
                    name
                  }
                  awsTarget {
                    accountId
                    accountName
                    region
                  }
                  azureTarget {
                    region
                  }
                  retentionDuration {
                    duration
                    unit
                  }
                  targetMapping {
                    id
                    name
                  }
                }
                localRetentionLimit {
                  duration
                  unit
                }
                snapshotSchedule {
                  minute {
                    basicSchedule {
                      frequency
                      retention
                      retentionUnit
                    }
                  }
                  hourly {
                    basicSchedule {
                      frequency
                      retention
                      retentionUnit
                    }
                  }
                  daily {
                    basicSchedule {
                      frequency
                      retention
                      retentionUnit
                    }
                  }
                  weekly {
                    basicSchedule {
                      frequency
                      retention
                      retentionUnit
                    }
                    dayOfWeek
                  }
                  monthly {
                    basicSchedule {
                      frequency
                      retention
                      retentionUnit
                    }
                    dayOfMonth
                  }
                  quarterly {
                    basicSchedule {
                      frequency
                      retention
                      retentionUnit
                    }
                    dayOfQuarter
                    quarterStartMonth
                  }
                  yearly {
                    basicSchedule {
                      frequency
                      retention
                      retentionUnit
                    }
                    dayOfYear
                    yearStartMonth
                  }
                }
              }
              ... on GlobalSlaReply {
                id
                description
                protectedObjectCount
                baseFrequency {
                  duration
                  unit
                }
                archivalSpecs {
                  storageSetting {
                    id
                    name
                    groupType
                    targetType
                  }
                }
                replicationSpec {
                  replicationType
                  specificReplicationSpec {
                    unidirectionalSpec {
                      replicationTargetName
                    }
                    cloudRegionSpec {
                      replicationTargetRegion
                      cloudProvider
                    }
                    cloudLocationSpec {
                      targetMapping {
                        id
                        name
                      }
                    }
                  }
                }
                replicationSpecsV2 {
                  cluster {
                    id
                    name
                  }
                  awsTarget {
                    accountId
                    accountName
                    region
                  }
                  azureTarget {
                    region
                  }
                  retentionDuration {
                    duration
                    unit
                  }
                  targetMapping {
                    id
                    name
                  }
                }
                localRetentionLimit {
                  duration
                  unit
                }
                snapshotSchedule {
                  minute {
                    basicSchedule {
                      frequency
                      retention
                      retentionUnit
                    }
                  }
                  hourly {
                    basicSchedule {
                      frequency
                      retention
                      retentionUnit
                    }
                  }
                  daily {
                    basicSchedule {
                      frequency
                      retention
                      retentionUnit
                    }
                  }
                  weekly {
                    basicSchedule {
                      frequency
                      retention
                      retentionUnit
                    }
                    dayOfWeek
                  }
                  monthly {
                    basicSchedule {
                      frequency
                      retention
                      retentionUnit
                    }
                    dayOfMonth
                  }
                  quarterly {
                    basicSchedule {
                      frequency
                      retention
                      retentionUnit
                    }
                    dayOfQuarter
                    quarterStartMonth
                  }
                  yearly {
                    basicSchedule {
                      frequency
                      retention
                      retentionUnit
                    }
                    dayOfYear
                    yearStartMonth
                  }
                }
                objectSpecificConfigs {
                  awsRdsConfig {
                    logRetention {
                      duration
                      unit
                    }
                  }
                  sapHanaConfig {
                    incrementalFrequency {
                      duration
                      unit
                    }
                    differentialFrequency {
                      duration
                      unit
                    }
                    logRetention {
                      duration
                      unit
                    }
                  }
                  vmwareVmConfig {
                    logRetentionSeconds
                  }
                }
                objectTypes
              }
            }
          }
          pageInfo {
            endCursor
            hasNextPage
            hasPreviousPage
          }
        }
        fragment CdmSnapshotLatestUserNotesFragment on CdmSnapshot {
          latestUserNote {
            time
            userName
            userNote
            __typename
          }
          __typename
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
        }";
      
    }
}
