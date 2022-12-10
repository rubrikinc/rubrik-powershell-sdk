// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class VsphereVmSnapshotQuery {
      /// <summary>
      /// VsphereVmSnapshotQuery.Request 
      /// <para>Required variables:<br/> { id=(any), snapshotGroupBy=(CdmSnapshotGroupByEnum), missedSnapshotGroupBy=(MissedSnapshotGroupByTime), timeRange=(TimeRangeInput), timezoneOffset=(double), clusterConnected=(bool) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = VsphereVmSnapshotDocument,
          OperationName = "VsphereVmSnapshot",
          Variables = variables
        };
      }

      
      public static string VsphereVmSnapshotDocument = @"
        query VsphereVmSnapshot($id: UUID!, $snapshotGroupBy: CdmSnapshotGroupByEnum!, $missedSnapshotGroupBy: MissedSnapshotGroupByTime!, $timeRange: TimeRangeInput!, $timezoneOffset: Float!, $clusterConnected: Boolean!) {
          vSphereVmNew(fid: $id) {
            ...VsphereVmFragment4
          }
        }
        fragment VsphereVmFragment4 on VsphereVm {
          id
          missedSnapshotGroupByConnection(
            groupBy: $missedSnapshotGroupBy
            filter: {timeRange: $timeRange}
            timezoneOffset: $timezoneOffset
          ) @include(if: $clusterConnected) {
            nodes {
              groupByInfo {
                ... on TimeRangeWithUnit {
                  unit
                  start
                  end
                }
              }
              missedSnapshotConnection {
                count
                nodes {
                  date
                }
              }
            }
          }
          snapshotGroupByConnection(
            groupBy: $snapshotGroupBy
            filter: {timeRange: $timeRange}
            timezoneOffset: $timezoneOffset
          ) {
            nodes {
              groupByInfo {
                ... on TimeRangeWithUnit {
                  unit
                  start
                  end
                }
              }
              snapshotConnection {
                count
                nodes {
                  id
                  isIndexed
                  isUnindexable
                }
              }
            }
          }
        }";
      
    }
}
