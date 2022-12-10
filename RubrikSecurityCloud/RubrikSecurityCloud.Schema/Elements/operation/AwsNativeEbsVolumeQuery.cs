// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class AwsNativeEbsVolumeQuery {
      /// <summary>
      /// AwsNativeEbsVolumeQuery.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { first=(int), after=(string), filters=(AwsNativeEbsVolumeFilters) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = AwsNativeEbsVolumeDocument,
          OperationName = "AwsNativeEbsVolume",
          Variables = variables
        };
      }

      
      public static string AwsNativeEbsVolumeDocument = @"
        query AwsNativeEbsVolume($first: Int, $after: String, $filters: AwsNativeEbsVolumeFilters) {
          awsNativeEbsVolumes(first: $first, after: $after, ebsVolumeFilters: $filters) {
            edges {
              node {
                id
                volumeNativeId
                volumeName
                volumeType
                region
                sizeInGiBs
                isRelic
                isExocomputeConfigured
                isIndexingEnabled
                isMarketplace
                tags {
                  key
                  value
                }
                effectiveSlaDomain {
                  name
                  ... on ClusterSlaDomain {
                    fid
                    cluster {
                      id
                      name
                    }
                  }
                  ... on GlobalSlaReply {
                    id
                    name
                  }
                }
                awsNativeAccount {
                  id
                  name
                  status
                }
                slaAssignment
                attachedEc2Instances {
                  id
                  instanceName
                  instanceNativeId
                }
                authorizedOperations
                effectiveSlaSourceObject {
                  fid
                  name
                  objectType
                }
              }
            }
            pageInfo {
              endCursor
              hasNextPage
              hasPreviousPage
            }
          }
        }
        ";
      
    }
}
