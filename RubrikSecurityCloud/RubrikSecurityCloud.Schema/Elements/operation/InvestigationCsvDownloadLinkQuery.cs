// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class InvestigationCsvDownloadLinkQuery {
      /// <summary>
      /// InvestigationCsvDownloadLinkQuery.Request 
      /// <para>Required variables:<br/> { clusterUuid=(any), workloadId=(string), snapshotId=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = InvestigationCsvDownloadLinkDocument,
          OperationName = "InvestigationCsvDownloadLink",
          Variables = variables
        };
      }

      
      public static string InvestigationCsvDownloadLinkDocument = @"
        query InvestigationCsvDownloadLink($clusterUuid: UUID!, $workloadId: String!, $snapshotId: String!) {
          investigationCsvDownloadLink(
            clusterUuid: $clusterUuid
            workloadId: $workloadId
            snapshotId: $snapshotId
          ) {
            ...DownloadLinkFragment
          }
        }
        fragment DownloadLinkFragment on InvestigationCsvDownloadLinkReply {
          downloadLink
        }";
      
    }
}
