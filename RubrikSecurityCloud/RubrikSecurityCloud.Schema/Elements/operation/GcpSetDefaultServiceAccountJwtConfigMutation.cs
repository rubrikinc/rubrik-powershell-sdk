// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class GcpSetDefaultServiceAccountJwtConfigMutation {
      /// <summary>
      /// GcpSetDefaultServiceAccountJwtConfigMutation.Request 
      /// <para>Required variables:<br/> { jwt_config=(string), name=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = GcpSetDefaultServiceAccountJwtConfigDocument,
          OperationName = "GcpSetDefaultServiceAccountJwtConfig",
          Variables = variables
        };
      }

      
      public static string GcpSetDefaultServiceAccountJwtConfigDocument = @"
        mutation GcpSetDefaultServiceAccountJwtConfig($jwt_config: String!, $name: String!) {
          gcpSetDefaultServiceAccountJwtConfig(
            input: {serviceAccountJwtConfig: $jwt_config, serviceAccountName: $name}
          )
        }
        ";
      
    }
}
