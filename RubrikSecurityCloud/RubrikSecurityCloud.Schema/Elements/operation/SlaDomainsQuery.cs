// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class SlaDomainsQuery {
      /// <summary>
      /// SlaDomainsQuery.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { after=(string), first=(int), filter=(GlobalSlaFilterInput[]), sortBy=(SlaQuerySortByField), sortOrder=(SortOrder), shouldShowProtectedObjectCount=(bool) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = SlaDomainsDocument,
          OperationName = "SlaDomains",
          Variables = variables
        };
      }

      
      public static string SlaDomainsDocument = @"
        query SlaDomains($after: String, $first: Int, $filter: [GlobalSlaFilterInput!], $sortBy: SlaQuerySortByField, $sortOrder: SortOrder, $shouldShowProtectedObjectCount: Boolean) {
          slaDomains(
            after: $after
            first: $first
            filter: $filter
            sortBy: $sortBy
            sortOrder: $sortOrder
            shouldShowProtectedObjectCount: $shouldShowProtectedObjectCount
          ) {
            ...SlaDomainFragment
          }
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
        }";
      
    }
}
