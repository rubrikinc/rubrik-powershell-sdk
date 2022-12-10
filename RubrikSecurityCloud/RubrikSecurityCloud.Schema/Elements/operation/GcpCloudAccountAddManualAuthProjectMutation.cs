// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class GcpCloudAccountAddManualAuthProjectMutation {
      /// <summary>
      /// GcpCloudAccountAddManualAuthProjectMutation.Request 
      /// <para>Required variables:<br/> { gcp_native_project_id=(string), gcp_native_project_name=(string), gcp_native_project_number=(any) }</para>
      /// <para>Optional variables:<br/> { organization_name=(string), service_account_auth_key=(string) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = GcpCloudAccountAddManualAuthProjectDocument,
          OperationName = "GcpCloudAccountAddManualAuthProject",
          Variables = variables
        };
      }

      
      public static string GcpCloudAccountAddManualAuthProjectDocument = @"
        mutation GcpCloudAccountAddManualAuthProject($gcp_native_project_id: String!, $gcp_native_project_name: String!, $gcp_native_project_number: Long!, $organization_name: String, $service_account_auth_key: String) {
          gcpCloudAccountAddManualAuthProject(
            input: {gcpNativeProjectId: $gcp_native_project_id, gcpProjectName: $gcp_native_project_name, gcpProjectNumber: $gcp_native_project_number, organizationName: $organization_name, serviceAccountJwtConfig: $service_account_auth_key, features: [CLOUD_NATIVE_PROTECTION]}
          )
        }
        ";
      
    }
}
