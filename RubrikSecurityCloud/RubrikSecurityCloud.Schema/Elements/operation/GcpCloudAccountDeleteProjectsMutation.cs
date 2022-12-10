// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class GcpCloudAccountDeleteProjectsMutation {
      /// <summary>
      /// GcpCloudAccountDeleteProjectsMutation.Request 
      /// <para>Required variables:<br/> { native_protection_ids=(any[]), shared_vpc_host_project_ids=(any[]), cloud_account_project_ids=(any[]) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = GcpCloudAccountDeleteProjectsDocument,
          OperationName = "GcpCloudAccountDeleteProjects",
          Variables = variables
        };
      }

      
      public static string GcpCloudAccountDeleteProjectsDocument = @"
        mutation GcpCloudAccountDeleteProjects($native_protection_ids: [UUID!]!, $shared_vpc_host_project_ids: [UUID!]!, $cloud_account_project_ids: [UUID!]!) {
          gcpCloudAccountDeleteProjects(
            input: {nativeProtectionProjectIds: $native_protection_ids, sharedVpcHostProjectIds: $shared_vpc_host_project_ids, cloudAccountsProjectIds: $cloud_account_project_ids, skipResourceDeletion: true}
          ) {
            ...GcpCloudAccountDeleteProjectsFragment
          }
        }
        fragment GcpCloudAccountDeleteProjectsFragment on GcpCloudAccountDeleteProjectsReply {
          gcpProjectDeleteStatuses {
            projectUuid
            success
            error
          }
        }";
      
    }
}
