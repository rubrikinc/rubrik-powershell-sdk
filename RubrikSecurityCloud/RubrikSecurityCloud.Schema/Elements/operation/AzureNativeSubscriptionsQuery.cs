// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class AzureNativeSubscriptionsQuery {
      /// <summary>
      /// AzureNativeSubscriptionsQuery.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { filter=(string) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = AzureNativeSubscriptionsDocument,
          OperationName = "AzureNativeSubscriptions",
          Variables = variables
        };
      }

      
      public static string AzureNativeSubscriptionsDocument = @"
        query AzureNativeSubscriptions($filter: String = """") {
          azureNativeSubscriptions(
            subscriptionFilters: {nameSubstringFilter: {nameSubstring: $filter}}
          ) {
            ...AzureNativeSubscriptionsFragment
          }
        }
        fragment AzureNativeSubscriptionsFragment on AzureNativeSubscriptionConnection {
          edges {
            node {
              id: id
              name: name
              sla_assignment: slaAssignment
              native_id: azureSubscriptionNativeId
              tenant_id: tenantId
              configured_sla_domain_name: configuredSlaDomain {
                name
              }
              configured_sla_domain_id: configuredSlaDomain {
                id
              }
              effective_sla_domain_name: effectiveSlaDomain {
                name
              }
              effective_sla_domain_id: effectiveSlaDomain {
                id
              }
            }
          }
        }";
      
    }
}
