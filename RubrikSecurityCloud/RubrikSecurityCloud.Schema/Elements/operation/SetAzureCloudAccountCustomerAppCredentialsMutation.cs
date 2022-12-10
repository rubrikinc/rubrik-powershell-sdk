// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class SetAzureCloudAccountCustomerAppCredentialsMutation {
      /// <summary>
      /// SetAzureCloudAccountCustomerAppCredentialsMutation.Request 
      /// <para>Required variables:<br/> { azure_cloud_type=(AzureCloudType), azure_app_id=(string), azure_app_secret_key=(string), should_replace=(bool) }</para>
      /// <para>Optional variables:<br/> { azure_app_name=(string), azure_app_tenant_id=(string), azure_tenant_domain_name=(string) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = SetAzureCloudAccountCustomerAppCredentialsDocument,
          OperationName = "SetAzureCloudAccountCustomerAppCredentials",
          Variables = variables
        };
      }

      
      public static string SetAzureCloudAccountCustomerAppCredentialsDocument = @"
        mutation SetAzureCloudAccountCustomerAppCredentials($azure_cloud_type: AzureCloudType!, $azure_app_id: String!, $azure_app_name: String, $azure_app_secret_key: String!, $azure_app_tenant_id: String, $azure_tenant_domain_name: String, $should_replace: Boolean!) {
          setAzureCloudAccountCustomerAppCredentials(
            input: {appId: $azure_app_id, appSecretKey: $azure_app_secret_key, appTenantId: $azure_app_tenant_id, appName: $azure_app_name, tenantDomainName: $azure_tenant_domain_name, azureCloudType: $azure_cloud_type, shouldReplace: $should_replace}
          )
        }
        ";
      
    }
}
