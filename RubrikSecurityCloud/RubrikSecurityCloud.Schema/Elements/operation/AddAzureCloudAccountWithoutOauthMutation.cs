// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class AddAzureCloudAccountWithoutOauthMutation {
      /// <summary>
      /// AddAzureCloudAccountWithoutOauthMutation.Request 
      /// <para>Required variables:<br/> { azure_tenant_domain_name=(string), azure_cloud_type=(AzureCloudType), azure_regions=(AzureCloudAccountRegion[]), feature=(AddAzureCloudAccountFeatureInputWithoutOauth), subscription_name=(string), subscription_id=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = AddAzureCloudAccountWithoutOauthDocument,
          OperationName = "AddAzureCloudAccountWithoutOauth",
          Variables = variables
        };
      }

      
      public static string AddAzureCloudAccountWithoutOauthDocument = @"
        mutation AddAzureCloudAccountWithoutOauth($azure_tenant_domain_name: String!, $azure_cloud_type: AzureCloudType!, $azure_regions: [AzureCloudAccountRegion!]!, $feature: AddAzureCloudAccountFeatureInputWithoutOauth!, $subscription_name: String!, $subscription_id: String!) {
          addAzureCloudAccountWithoutOauth(
            input: {tenantDomainName: $azure_tenant_domain_name, azureCloudType: $azure_cloud_type, subscriptions: {subscription: {name: $subscription_name, nativeId: $subscription_id}, features: [$feature]}, regions: $azure_regions}
          ) {
            ...AddAzureCloudAccountWithoutOauthFragment
          }
        }
        fragment AddAzureCloudAccountWithoutOauthFragment on AddAzureCloudAccountWithoutOauthReply {
          tenantId
          status {
            azureSubscriptionRubrikId
            azureSubscriptionNativeId
            error
          }
        }";
      
    }
}
