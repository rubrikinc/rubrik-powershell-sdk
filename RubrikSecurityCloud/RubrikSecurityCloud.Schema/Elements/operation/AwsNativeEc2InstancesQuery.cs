// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class AwsNativeEc2InstancesQuery {
      /// <summary>
      /// AwsNativeEc2InstancesQuery.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { first=(int), after=(string), filters=(AwsNativeEc2InstanceFilters) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = AwsNativeEc2InstancesDocument,
          OperationName = "AwsNativeEc2Instances",
          Variables = variables
        };
      }

      
      public static string AwsNativeEc2InstancesDocument = @"
        query AwsNativeEc2Instances($first: Int, $after: String, $filters: AwsNativeEc2InstanceFilters) {
          awsNativeEc2Instances(
            first: $first
            after: $after
            ec2InstanceFilters: $filters
          ) {
            ...AwsNativeEc2InstancesFragment
          }
        }
        fragment AwsNativeEc2InstancesFragment on AwsNativeEc2InstanceConnection {
          edges {
            cursor
            node {
              id
              instanceNativeId
              instanceName
              vpcName
              region
              vpcId
              isRelic
              instanceType
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
                  __typename
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
        }";
      
    }
}
