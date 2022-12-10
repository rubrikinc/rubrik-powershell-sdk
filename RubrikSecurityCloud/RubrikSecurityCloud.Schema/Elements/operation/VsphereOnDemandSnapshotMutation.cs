// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class VsphereOnDemandSnapshotMutation {
      /// <summary>
      /// VsphereOnDemandSnapshotMutation.Request 
      /// <para>Required variables:<br/> { input=(VsphereOnDemandSnapshotInput) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = VsphereOnDemandSnapshotDocument,
          OperationName = "VsphereOnDemandSnapshot",
          Variables = variables
        };
      }

      
      public static string VsphereOnDemandSnapshotDocument = @"
        mutation VsphereOnDemandSnapshot($input: VsphereOnDemandSnapshotInput!) {
          vsphereOnDemandSnapshot(input: $input) {
            ...AsyncRequestStatusFragment1
          }
        }
        fragment AsyncRequestStatusFragment1 on AsyncRequestStatus {
          id
          status
        }";
      
    }
}
