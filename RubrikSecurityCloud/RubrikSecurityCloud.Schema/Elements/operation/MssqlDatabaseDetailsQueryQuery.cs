// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class MssqlDatabaseDetailsQueryQuery {
      /// <summary>
      /// MssqlDatabaseDetailsQueryQuery.Request 
      /// <para>Required variables:<br/> { fid=(any) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = MssqlDatabaseDetailsQueryDocument,
          OperationName = "MssqlDatabaseDetailsQuery",
          Variables = variables
        };
      }

      
      public static string MssqlDatabaseDetailsQueryDocument = @"
        query MssqlDatabaseDetailsQuery($fid: UUID!) {
          mssqlDatabase(fid: $fid) {
            ...MssqlDatabaseDetailsFragment
          }
        }
        fragment MssqlDatabaseDetailsFragment on MssqlDatabase {
          id
          cdmId
          name
          recoveryModel
          isRelic
          unprotectableReasons
          isLogShippingSecondary
          isOnline
          copyOnly
          isInAvailabilityGroup
          ...ReplicasColumnFragment
          effectiveSlaDomain {
            ...EffectiveSlaDomainFragment
            __typename
          }
          logicalPath {
            name
            objectType
            __typename
          }
          physicalPath {
            name
            objectType
            __typename
          }
          cluster {
            id
            name
            status
            version
            defaultAddress
            ...ClusterNodeConnectionFragment
            ...ClusterStateFragment
            ...ClusterGlobalManagerFragment
            __typename
          }
          primaryClusterLocation {
            id
            __typename
          }
          pendingSla {
            ...SLADomainFragment
            __typename
          }
          cdmSnapshots {
            count
            __typename
          }
          authorizedOperations
          logBackupFrequencyInSeconds
          logBackupRetentionInHours
          hasLogConfigFromSla
          replicatedObjects {
            id
            primaryClusterLocation {
              id
              name
              __typename
            }
            cluster {
              id
              name
              __typename
            }
            __typename
          }
          __typename
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
        fragment ReplicasColumnFragment on MssqlDatabase {
          replicas {
            availabilityInfo {
              role
              __typename
            }
            instance {
              name
              logicalPath {
                name
                __typename
              }
              __typename
            }
            isArchived
            recoveryModel
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
