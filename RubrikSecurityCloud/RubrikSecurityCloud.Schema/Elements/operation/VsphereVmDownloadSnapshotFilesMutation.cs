// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class VsphereVmDownloadSnapshotFilesMutation {
      /// <summary>
      /// VsphereVmDownloadSnapshotFilesMutation.Request 
      /// <para>Required variables:<br/> { input=(VsphereVmDownloadSnapshotFilesInput) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = VsphereVmDownloadSnapshotFilesDocument,
          OperationName = "VsphereVmDownloadSnapshotFiles",
          Variables = variables
        };
      }

      
      public static string VsphereVmDownloadSnapshotFilesDocument = @"
        mutation VsphereVmDownloadSnapshotFiles($input: VsphereVmDownloadSnapshotFilesInput!) {
          vsphereVmDownloadSnapshotFiles(input: $input) {
            ...AsyncRequestStatusFragment2
          }
        }
        fragment AsyncRequestStatusFragment2 on AsyncRequestStatus {
          id
          status
          progress
          nodeId
          error {
            message
          }
          links {
            href
            rel
          }
          endTime
          startTime
        }";
      
    }
}
