// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class VsphereVmsWithSortQuery {
      /// <summary>
      /// VsphereVmsWithSortQuery.Request 
      /// <para>Required variables:<br/> { first=(int), filter=(Filter[]) }</para>
      /// <para>Optional variables:<br/> { after=(string), sortBy=(HierarchySortByField), sortOrder=(SortOrder) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = VsphereVmsWithSortDocument,
          OperationName = "VsphereVmsWithSort",
          Variables = variables
        };
      }

      
      public static string VsphereVmsWithSortDocument = @"
        query VsphereVmsWithSort($first: Int!, $after: String, $filter: [Filter!]!, $sortBy: HierarchySortByField, $sortOrder: SortOrder) {
          vSphereVmNewConnection(
            filter: $filter
            first: $first
            after: $after
            sortBy: $sortBy
            sortOrder: $sortOrder
          ) {
            ...VsphereVmConnectionFragment3
          }
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
        }
        fragment HierarchyObjectTypeFragment on HierarchyObject {
          objectType
        }
        fragment VsphereVmConnectionFragment3 on VsphereVmConnection {
          edges {
            node {
              id
              ...VSphereNameColumnFragment
              ...CdmClusterColumnFragment
              ...EffectiveSlaColumnFragment
              ...VSphereSlaAssignmentColumnFragment
              isRelic
              authorizedOperations
              primaryClusterLocation {
                id
                name
              }
              logicalPath {
                fid
                name
                objectType
              }
              snapshotDistribution {
                id
                onDemandCount
                retrievedCount
                scheduledCount
                totalCount
              }
              reportWorkload {
                id
                archiveStorage
                physicalBytes
              }
              vmwareToolsInstalled
              agentStatus {
                agentStatus
                disconnectReason
              }
            }
          }
          pageInfo {
            startCursor
            endCursor
            hasNextPage
            hasPreviousPage
          }
        }
        fragment VSphereNameColumnFragment on HierarchyObject {
          id
          name
          ...HierarchyObjectTypeFragment
        }
        fragment CdmClusterColumnFragment on CdmHierarchyObject {
          replicatedObjectCount
          cluster {
            id
            name
            version
            status
          }
        }
        fragment VSphereSlaAssignmentColumnFragment on HierarchyObject {
          effectiveSlaSourceObject {
            fid
            name
            objectType
          }
          ...SlaAssignmentColumnFragment
        }
        fragment SlaAssignmentColumnFragment on HierarchyObject {
          slaAssignment
        }";
      
    }
}
