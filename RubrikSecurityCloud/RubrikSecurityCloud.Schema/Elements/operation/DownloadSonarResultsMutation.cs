// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class DownloadSonarResultsMutation {
      /// <summary>
      /// DownloadSonarResultsMutation.Request 
      /// <para>Required variables:<br/> { downloadId=(any) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = DownloadSonarResultsDocument,
          OperationName = "DownloadSonarResults",
          Variables = variables
        };
      }

      
      public static string DownloadSonarResultsDocument = @"
        mutation DownloadSonarResults($downloadId: Long!) {
          getDownloadUrl(downloadId: $downloadId) {
            ...GetDownloadUrlFragment
          }
        }
        fragment GetDownloadUrlFragment on UserDownloadUrl {
          url
        }";
      
    }
}
