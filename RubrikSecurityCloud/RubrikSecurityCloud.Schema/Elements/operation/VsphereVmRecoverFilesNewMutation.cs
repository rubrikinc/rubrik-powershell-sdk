// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class VsphereVmRecoverFilesNewMutation {
      /// <summary>
      /// VsphereVmRecoverFilesNewMutation.Request 
      /// <para>Required variables:<br/> { input=(VsphereVmRecoverFilesNewInput) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = VsphereVmRecoverFilesNewDocument,
          OperationName = "VsphereVmRecoverFilesNew",
          Variables = variables
        };
      }

      
      public static string VsphereVmRecoverFilesNewDocument = @"
        mutation VsphereVmRecoverFilesNew($input: VsphereVmRecoverFilesNewInput!) {
          vsphereVmRecoverFilesNew(input: $input) {
            ...AsyncRequestStatusFragment4
          }
        }
        fragment AsyncRequestStatusFragment4 on AsyncRequestStatus {
          id
        }";
      
    }
}
