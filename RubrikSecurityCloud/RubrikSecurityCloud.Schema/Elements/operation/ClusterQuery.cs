// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class ClusterQuery {
      /// <summary>
      /// ClusterQuery.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { first=(int), after=(string), filter=(ClusterFilterInput), sortBy=(ClusterSortByEnum), sortOrder=(SortOrder) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = ClusterDocument,
          OperationName = "Cluster",
          Variables = variables
        };
      }

      
      public static string ClusterDocument = @"
        query Cluster($first: Int, $after: String, $filter: ClusterFilterInput, $sortBy: ClusterSortByEnum, $sortOrder: SortOrder) {
          clusterConnection(
            filter: $filter
            sortBy: $sortBy
            sortOrder: $sortOrder
            first: $first
            after: $after
          ) {
            edges {
              node {
                ...ClusterFragment1
              }
            }
            pageInfo {
              ...PageInfoFragment_All
            }
          }
        }
        fragment ClusterFragment1 on Cluster {
          connectivityLastUpdated
          connectivityLastUpdated
          defaultAddress
          encryptionEnabled
          estimatedRunway
          id
          isHealthy
          lastConnectionTime
          name
          passesConnectivityCheck
          passesConnectivityCheck
          pauseStatus
          productType
          registrationTime
          snapshotCount
          status
          subStatus
          timezone
          type
          version
          ccprovisionInfo {
            marshaledConfig
          }
          cloudInfo {
            region
            vendor
          }
          clusterDiskConnection {
            nodes {
              id
              diskType
            }
          }
          cdmUpgradeInfo {
            clusterStatus {
              message
              status
            }
            downloadedVersion
            overallProgress
            scheduleUpgradeAt
            version
          }
          clusterNodeConnection {
            count
            nodes {
              id
              ipAddress
              status
              brikId
              cpuCores
              ram
              hardwareHealth {
                isHealthy
                message
                policyName
              }
              platformType
            }
          }
          geoLocation {
            ...GeoLocationFragment_All
          }
          globalManagerConnectivityStatus {
            urls {
              isReachable
              url
            }
          }
          lambdaFeatureHistory {
            wasRansomwareInvestigationEverEnabled
            wasSensitiveDataDiscoveryEverEnabled
          }
          metric {
            ...ClusterMetricFragment_All
          }
          replicationSources {
            id
            sourceClusterAddress
            sourceClusterName
            sourceClusterUuid
            totalStorage
          }
          replicationTargets {
            id
            targetClusterAddress
            targetClusterName
            targetClusterUuid
            totalStorage
          }
          rubrikSyncStatus {
            clusterSyncLastSuccessTime
            eventsSyncLastSuccessTime
            jobMonitoringSyncLastSuccessTime
            objectMetadataSyncLastSuccessTime
            reportsSyncLastSuccessTime
            isClusterSyncHealthy
            isJobMonitoringSyncHealthy
            isMetadataSyncHealthy
            isEventsSyncHealthy
            isReportsSyncHealthy
          }
          snappableConnection(filter: {protectionStatus: Protected}) {
            count
          }
          state {
            connectedState
            clusterRemovalState
            clusterRemovalState
            clusterRemovalCreatedAt
            clusterRemovalUpdatedAt
          }
        }
        fragment ClusterMetricFragment_All on ClusterMetric {
          availableCapacity
          usedCapacity
          totalCapacity
          snapshotCapacity
          liveMountCapacity
          miscellaneousCapacity
          ingestedSnapshotStorage
          physicalSnapshotStorage
          ingestedArchivalStorage
          physicalArchivalStorage
          lastUpdateTime
        }
        fragment GeoLocationFragment_All on GeoLocation {
          address
          latitude
          longitude
        }
        fragment PageInfoFragment_All on PageInfo {
          startCursor
          endCursor
          hasNextPage
          hasPreviousPage
        }";
      
    }
}
