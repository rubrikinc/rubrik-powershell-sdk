// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class VsphereVmsQuery {
      /// <summary>
      /// VsphereVmsQuery.Request 
      /// <para>Required variables:<br/> { filter=(Filter[]) }</para>
      /// <para>Optional variables:<br/> { first=(int), after=(string) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = VsphereVmsDocument,
          OperationName = "VsphereVms",
          Variables = variables
        };
      }

      
      public static string VsphereVmsDocument = @"
        query VsphereVms($first: Int, $after: String, $filter: [Filter!]!) {
          vSphereVmNewConnection(first: $first, filter: $filter, after: $after) {
            ...VsphereVmConnectionFragment2
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
        fragment VsphereVmConnectionFragment2 on VsphereVmConnection {
          edges {
            cursor
            node {
              isRelic
              authorizedOperations
              replicatedObjectCount
              id
              name
              cluster {
                id
                name
                version
                status
              }
              primaryClusterLocation {
                id
                name
              }
              objectType
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
              slaAssignment
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
                __typename
              }
              vmwareToolsInstalled
              agentStatus {
                agentStatus
                disconnectReason
                __typename
              }
            }
          }
          pageInfo {
            startCursor
            endCursor
            hasNextPage
            hasPreviousPage
          }
        }";
      
    }
}
