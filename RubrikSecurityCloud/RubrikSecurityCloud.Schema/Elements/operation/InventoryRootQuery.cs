// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class InventoryRootQuery {
      /// <summary>
      /// InventoryRootQuery.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { first=(int), after=(string), typeFilter=(HierarchyObjectTypeEnum[]), filter=(Filter[]), sortBy=(HierarchySortByField), sortOrder=(SortOrder) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = InventoryRootDocument,
          OperationName = "InventoryRoot",
          Variables = variables
        };
      }

      
      public static string InventoryRootDocument = @"
        query InventoryRoot($first: Int, $after: String, $typeFilter: [HierarchyObjectTypeEnum!], $filter: [Filter!], $sortBy: HierarchySortByField, $sortOrder: SortOrder) {
          inventoryRoot {
            descendantConnection(
              first: $first
              after: $after
              typeFilter: $typeFilter
              filter: $filter
              sortBy: $sortBy
              sortOrder: $sortOrder
            ) {
              edges {
                node {
                  id
                  ... on WindowsFileset {
                    isPassThrough
                  }
                  ... on ShareFileset {
                    isPassThrough
                  }
                  ... on LinuxFileset {
                    isPassThrough
                  }
                  ...EffectiveSlaColumnFragment
                  ...HierarchyObjectClusterColumnFragment
                  ...HierarchyObjectLocationColumnFragment
                  ...HierarchyObjectNameColumnFragment
                  ...HierarchyObjectTypeFragment
                }
              }
              pageInfo {
                endCursor
                hasNextPage
                hasPreviousPage
              }
            }
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
        fragment HierarchyObjectClusterColumnFragment on HierarchyObject {
          ...CdmClusterLabelFragment
        }
        fragment CdmClusterLabelFragment on CdmHierarchyObject {
          cluster {
            id
            name
          }
          primaryClusterLocation {
            id
          }
        }
        fragment HierarchyObjectLocationColumnFragment on HierarchyObject {
          logicalPath {
            name
            objectType
          }
          physicalPath {
            name
            objectType
          }
        }
        fragment HierarchyObjectNameColumnFragment on HierarchyObject {
          name
        }
        fragment HierarchyObjectTypeFragment on HierarchyObject {
          objectType
        }";
      
    }
}
