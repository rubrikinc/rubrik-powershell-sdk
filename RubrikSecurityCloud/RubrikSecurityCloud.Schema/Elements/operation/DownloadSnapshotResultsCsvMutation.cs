// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class DownloadSnapshotResultsCsvMutation {
      /// <summary>
      /// DownloadSnapshotResultsCsvMutation.Request 
      /// <para>Required variables:<br/> { snappableFid=(string), snapshotFid=(string) }</para>
      /// <para>Optional variables:<br/> { filters=(DownloadResultsCsvFiltersInput) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = DownloadSnapshotResultsCsvDocument,
          OperationName = "DownloadSnapshotResultsCsv",
          Variables = variables
        };
      }

      
      public static string DownloadSnapshotResultsCsvDocument = @"
        mutation DownloadSnapshotResultsCsv($filters: DownloadResultsCsvFiltersInput, $snappableFid: String!, $snapshotFid: String!) {
          downloadSnapshotResultsCsv(
            snappableFid: $snappableFid
            snapshotFid: $snapshotFid
            downloadFilter: $filters
          ) {
            ...DownloadSnapshotResultsCsvFragment
          }
        }
        fragment DownloadSnapshotResultsCsvFragment on DownloadCsvReply {
          isSuccessful
        }";
      
    }
}
