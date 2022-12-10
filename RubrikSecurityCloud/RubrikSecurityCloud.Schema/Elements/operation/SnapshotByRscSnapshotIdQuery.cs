// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class SnapshotByRscSnapshotIdQuery {
      /// <summary>
      /// SnapshotByRscSnapshotIdQuery.Request 
      /// <para>Required variables:<br/> { snapshotId=(any) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = SnapshotByRscSnapshotIdDocument,
          OperationName = "SnapshotByRscSnapshotId",
          Variables = variables
        };
      }

      
      public static string SnapshotByRscSnapshotIdDocument = @"
        query SnapshotByRscSnapshotId($snapshotId: UUID!) {
          polarisSnapshot(snapshotFid: $snapshotId) {
            ...PolarisSnapshotFragment1
          }
        }
        fragment PolarisSnapshotFragment1 on PolarisSnapshot {
          id
          snappableId
          expirationDate
          isCorrupted
          isDeletedFromSource
          isExpired
        }";
      
    }
}
