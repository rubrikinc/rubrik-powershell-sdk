// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class VsphereVmAsyncRequestStatusQuery {
      /// <summary>
      /// VsphereVmAsyncRequestStatusQuery.Request 
      /// <para>Required variables:<br/> { clusterUuid=(any), id=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = VsphereVmAsyncRequestStatusDocument,
          OperationName = "VsphereVMAsyncRequestStatus",
          Variables = variables
        };
      }

      
      public static string VsphereVmAsyncRequestStatusDocument = @"
        query VsphereVMAsyncRequestStatus($clusterUuid: UUID!, $id: String!) {
          vSphereVMAsyncRequestStatus(clusterUuid: $clusterUuid, id: $id) {
            id
            nodeId
            status
            progress
            links {
              href
              rel
            }
            error {
              message
            }
          }
        }
        ";
      
    }
}
