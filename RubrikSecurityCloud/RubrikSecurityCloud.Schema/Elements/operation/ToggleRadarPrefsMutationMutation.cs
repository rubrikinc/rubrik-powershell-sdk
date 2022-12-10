// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class ToggleRadarPrefsMutationMutation {
      /// <summary>
      /// ToggleRadarPrefsMutationMutation.Request 
      /// <para>Required variables:<br/> { input=(EnableAutomaticFmdUploadInput) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = ToggleRadarPrefsMutationDocument,
          OperationName = "ToggleRadarPrefsMutation",
          Variables = variables
        };
      }

      
      public static string ToggleRadarPrefsMutationDocument = @"
        mutation ToggleRadarPrefsMutation($input: EnableAutomaticFmdUploadInput!) {
          enableAutomaticFmdUpload(input: $input) {
            ...EnableAutomaticFmdUploadFragment
          }
        }
        fragment EnableAutomaticFmdUploadFragment on EnableAutomaticFmdUploadReply {
          clusterId
          enabled
        }";
      
    }
}
