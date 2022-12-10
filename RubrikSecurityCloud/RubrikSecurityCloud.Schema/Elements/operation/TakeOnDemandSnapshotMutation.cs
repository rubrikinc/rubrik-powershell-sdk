// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class TakeOnDemandSnapshotMutation {
      /// <summary>
      /// TakeOnDemandSnapshotMutation.Request 
      /// <para>Required variables:<br/> { retentionSlaId=(string), snappableIds=(any[]) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = TakeOnDemandSnapshotDocument,
          OperationName = "TakeOnDemandSnapshot",
          Variables = variables
        };
      }

      
      public static string TakeOnDemandSnapshotDocument = @"
        mutation TakeOnDemandSnapshot($retentionSlaId: String!, $snappableIds: [UUID!]!) {
          takeOnDemandSnapshot(
            input: {slaId: $retentionSlaId, workloadIds: $snappableIds}
          ) {
            ...TakeOnDemandSnapshot
          }
        }
        fragment TakeOnDemandSnapshot on TakeOnDemandSnapshotReply {
          errors {
            error
          }
        }";
      
    }
}
