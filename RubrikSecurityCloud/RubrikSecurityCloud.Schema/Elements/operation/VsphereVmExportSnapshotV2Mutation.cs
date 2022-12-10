// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class VsphereVmExportSnapshotV2Mutation {
      /// <summary>
      /// VsphereVmExportSnapshotV2Mutation.Request 
      /// <para>Required variables:<br/> { input=(VsphereVmExportSnapshotV2Input) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = VsphereVmExportSnapshotV2Document,
          OperationName = "VsphereVmExportSnapshotV2",
          Variables = variables
        };
      }

      
      public static string VsphereVmExportSnapshotV2Document = @"
        mutation VsphereVmExportSnapshotV2($input: VsphereVmExportSnapshotV2Input!) {
          vsphereVmExportSnapshotV2(input: $input) {
            ...AsyncRequestStatusFragment3
          }
        }
        fragment AsyncRequestStatusFragment3 on AsyncRequestStatus {
          id
        }";
      
    }
}
