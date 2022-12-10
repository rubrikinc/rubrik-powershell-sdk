// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class AzureNativeVirtualMachinesQuery {
      /// <summary>
      /// AzureNativeVirtualMachinesQuery.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { first=(int), after=(string), last=(int), before=(string), sortBy=(AzureNativeVirtualMachineSortFields), sortOrder=(SortOrder), filters=(AzureNativeVirtualMachineFilters) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = AzureNativeVirtualMachinesDocument,
          OperationName = "AzureNativeVirtualMachines",
          Variables = variables
        };
      }

      
      public static string AzureNativeVirtualMachinesDocument = @"
        query AzureNativeVirtualMachines($first: Int, $after: String, $last: Int, $before: String, $sortBy: AzureNativeVirtualMachineSortFields, $sortOrder: SortOrder, $filters: AzureNativeVirtualMachineFilters) {
          azureNativeVirtualMachines(
            first: $first
            after: $after
            last: $last
            before: $before
            sortBy: $sortBy
            sortOrder: $sortOrder
            virtualMachineFilters: $filters
          ) {
            ...AzureNativeVirtualMachinesFragment
          }
        }
        fragment AzureNativeVirtualMachinesFragment on AzureNativeVirtualMachineConnection {
          nodes {
            region
            sizeType
            vnetName
            isRelic
            tags {
              key
              value
            }
            resourceGroup {
              azureSubscriptionRubrikId
              id
              name
              region
            }
            attachedManagedDisks {
              resourceGroup {
                azureSubscriptionRubrikId
                id
                name
                region
              }
              id
              name
              objectType
              region
              diskSizeGib
              diskIopsReadWrite
              diskMbpsReadWrite
              tags {
                key
                value
              }
            }
            id
            name
            objectType
            slaAssignment
            effectiveSlaDomain {
              id
              name
            }
            configuredSlaDomain {
              id
              name
            }
            effectiveSlaSourceObject {
              fid
              name
              objectType
            }
            logicalPath {
              fid
              name
              objectType
            }
            physicalPath {
              fid
              name
              objectType
            }
            numWorkloadDescendants
          }
          pageInfo {
            startCursor
            endCursor
            hasNextPage
            hasPreviousPage
          }
          count
        }";
      
    }
}
