// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class GlobalSearchResultsQuery {
      /// <summary>
      /// GlobalSearchResultsQuery.Request 
      /// <para>Required variables:<br/> { first=(int), filter=(Filter[]) }</para>
      /// <para>Optional variables:<br/> { sortBy=(HierarchySortByField), sortOrder=(SortOrder), after=(string) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = GlobalSearchResultsDocument,
          OperationName = "GlobalSearchResults",
          Variables = variables
        };
      }

      
      public static string GlobalSearchResultsDocument = @"
        query GlobalSearchResults($first: Int!, $filter: [Filter!]!, $sortBy: HierarchySortByField, $sortOrder: SortOrder, $after: String) {
          globalSearchResults(
            first: $first
            filter: $filter
            sortBy: $sortBy
            sortOrder: $sortOrder
            after: $after
          ) {
            ...GlobalSearchResultsFragment
          }
        }
        fragment GlobalSearchResultsFragment on HierarchyObjectConnection {
          edges {
            node {
              id
              name
              objectType
              physicalPath {
                fid
                name
                objectType
              }
              ... on VsphereVm {
                cluster {
                  ...ClusterFragment
                }
                primaryClusterLocation {
                  id
                }
                isRelic
              }
              ... on LinuxFileset {
                cluster {
                  ...ClusterFragment
                }
                primaryClusterLocation {
                  id
                }
                isRelic
              }
              ... on WindowsFileset {
                cluster {
                  ...ClusterFragment
                }
                primaryClusterLocation {
                  id
                }
                isRelic
              }
              ... on PhysicalHost {
                cluster {
                  ...ClusterFragment
                }
                primaryClusterLocation {
                  id
                }
                physicalChildConnection(typeFilter: [LinuxFileset, WindowsFileset]) {
                  count
                  edges {
                    node {
                      id
                      name
                      replicatedObjects {
                        cluster {
                          ...ClusterFragment
                        }
                      }
                    }
                  }
                }
              }
              ... on MssqlDatabase {
                cluster {
                  ...ClusterFragment
                }
                primaryClusterLocation {
                  id
                }
                isRelic
              }
              ... on Blueprint {
                cluster {
                  ...ClusterFragment
                }
                isRelic
              }
              ... on ShareFileset {
                cluster {
                  ...ClusterFragment
                }
                primaryClusterLocation {
                  id
                }
                isRelic
              }
              ... on O365User {
                id
                emailAddress
                isRelic
              }
              ... on AwsNativeEc2Instance {
                id
                awsRegion: region
                isRelic
              }
              ... on AwsNativeEbsVolume {
                id
                awsRegion: region
                isRelic
              }
              ... on AwsNativeRdsInstance {
                id
                awsRegion: region
                isRelic
              }
              ... on AzureNativeVirtualMachine {
                id
                azureRegion: region
                isRelic
              }
              ... on AzureNativeManagedDisk {
                id
                azureRegion: region
                isRelic
              }
              ... on AzureNativeResourceGroup {
                id
                azureRegion: region
              }
              ... on AzureNativeSubscription {
                id
              }
              ... on GcpNativeDisk {
                id
                gcpZone: zone
                gcpRegion: region
                gcpNativeProject {
                  name
                }
              }
              ... on GcpNativeGceInstance {
                id
                gcpZone: zone
                gcpNativeProject {
                  name
                }
              }
              ... on HierarchyObject {
                ...EffectiveSlaColumnFragment
              }
            }
          }
          pageInfo {
            endCursor
            startCursor
            hasNextPage
            hasPreviousPage
          }
        }
        fragment ClusterFragment on Cluster {
          id
          name
        }
        fragment EffectiveSlaColumnFragment on HierarchyObject {
          effectiveSlaDomain {
            id
            name
            ... on GlobalSlaReply {
              description
            }
            ... on ClusterSlaDomain {
              fid
              cluster {
                id
                name
              }
            }
          }
          ...PendingSlaFragment
        }
        fragment PendingSlaFragment on CdmHierarchyObject {
          pendingSla {
            id
            name
          }
        }";
      
    }
}
