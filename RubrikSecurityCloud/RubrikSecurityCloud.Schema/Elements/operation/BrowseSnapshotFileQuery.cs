// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class BrowseSnapshotFileQuery {
      /// <summary>
      /// BrowseSnapshotFileQuery.Request 
      /// <para>Required variables:<br/> { path=(string), snapshotFid=(any) }</para>
      /// <para>Optional variables:<br/> { after=(string), first=(int), searchPrefix=(string) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = BrowseSnapshotFileDocument,
          OperationName = "BrowseSnapshotFile",
          Variables = variables
        };
      }

      
      public static string BrowseSnapshotFileDocument = @"
        query BrowseSnapshotFile($after: String, $first: Int, $path: String!, $searchPrefix: String, $snapshotFid: UUID!) {
          browseSnapshotFileConnection(
            path: $path
            searchPrefix: $searchPrefix
            snapshotFid: $snapshotFid
            first: $first
            after: $after
          ) {
            ...SnapshotFileConnectionFragment1
          }
        }
        fragment SnapshotFileConnectionFragment1 on SnapshotFileConnection {
          edges {
            node {
              absolutePath
              displayPath
              path
              filename
              fileMode
              size
              lastModified
            }
          }
          pageInfo {
            endCursor
            hasNextPage
            hasPreviousPage
          }
        }";
      
    }
}
