// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class GcpNativeDisableProjectMutation {
      /// <summary>
      /// GcpNativeDisableProjectMutation.Request 
      /// <para>Required variables:<br/> { rubrik_project_id=(any), delete_snapshots=(bool) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = GcpNativeDisableProjectDocument,
          OperationName = "GcpNativeDisableProject",
          Variables = variables
        };
      }

      
      public static string GcpNativeDisableProjectDocument = @"
        mutation GcpNativeDisableProject($rubrik_project_id: UUID!, $delete_snapshots: Boolean!) {
          gcpNativeDisableProject(
            input: {projectId: $rubrik_project_id, shouldDeleteNativeSnapshots: $delete_snapshots}
          ) {
            ...GcpNativeDisableProjectFragment
          }
        }
        fragment GcpNativeDisableProjectFragment on AsyncJobStatus {
          jobId
        }";
      
    }
}
