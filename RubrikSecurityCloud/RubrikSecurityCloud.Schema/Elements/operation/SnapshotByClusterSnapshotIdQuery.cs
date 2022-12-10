// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class SnapshotByClusterSnapshotIdQuery {
      /// <summary>
      /// SnapshotByClusterSnapshotIdQuery.Request 
      /// <para>Required variables:<br/> { snapshotId=(any) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = SnapshotByClusterSnapshotIdDocument,
          OperationName = "SnapshotByClusterSnapshotId",
          Variables = variables
        };
      }

      
      public static string SnapshotByClusterSnapshotIdDocument = @"
        query SnapshotByClusterSnapshotId($snapshotId: UUID!) {
          snapshot(snapshotFid: $snapshotId) {
            ...CdmSnapshotFragment1
          }
        }
        fragment CdmSnapshotFragment1 on CdmSnapshot {
          id
          snappableId
          expirationDate
          isCorrupted
          isExpired
        }";
      
    }
}
