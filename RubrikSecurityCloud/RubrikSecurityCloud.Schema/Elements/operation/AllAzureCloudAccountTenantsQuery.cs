// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class AllAzureCloudAccountTenantsQuery {
      /// <summary>
      /// AllAzureCloudAccountTenantsQuery.Request 
      /// <para>Required variables:<br/> { cloud_account_features=(CloudAccountFeature) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = AllAzureCloudAccountTenantsDocument,
          OperationName = "AllAzureCloudAccountTenants",
          Variables = variables
        };
      }

      
      public static string AllAzureCloudAccountTenantsDocument = @"
        query AllAzureCloudAccountTenants($cloud_account_features: CloudAccountFeature!) {
          allAzureCloudAccountTenants(
            feature: $cloud_account_features
            includeSubscriptionDetails: true
          ) {
            ...AllAzureCloudAccountTenantsFragment
          }
        }
        fragment AllAzureCloudAccountTenantsFragment on AzureCloudAccountTenant {
          azureCloudAccountTenantRubrikId
          domainName
          subscriptionCount
          subscriptions {
            id
            nativeId
            name
            featureDetail {
              status
              feature
              regions
            }
          }
        }";
      
    }
}
