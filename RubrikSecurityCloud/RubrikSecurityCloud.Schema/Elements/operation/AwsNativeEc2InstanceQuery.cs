// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class AwsNativeEc2InstanceQuery {
      /// <summary>
      /// AwsNativeEc2InstanceQuery.Request 
      /// <para>Required variables:<br/> { object_id=(any) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = AwsNativeEc2InstanceDocument,
          OperationName = "AwsNativeEc2Instance",
          Variables = variables
        };
      }

      
      public static string AwsNativeEc2InstanceDocument = @"
        query AwsNativeEc2Instance($object_id: UUID!) {
          awsNativeEc2Instance(ec2InstanceRubrikId: $object_id) {
            ...AwsNativeEc2InstanceFragment
          }
        }
        fragment AwsNativeEc2InstanceFragment on AwsNativeEc2Instance {
          id
          instanceNativeId
          instanceName
          isRelic
          isExocomputeConfigured
          isIndexingEnabled
          isMarketplace
          instanceType
          effectiveSlaDomain {
            name
            ... on ClusterSlaDomain {
              fid
              cluster {
                id
                name
                __typename
              }
              __typename
            }
            ... on GlobalSlaReply {
              id
              __typename
            }
            __typename
          }
          authorizedOperations
          availabilityZone
          region
          vpcId
          tags {
            key
            value
            __typename
          }
          awsNativeAccount {
            id
            name
            status
            __typename
          }
          attachmentSpecs {
            awsNativeEbsVolumeId
            isExcludedFromSnapshot
            isRootVolume
            devicePath
            __typename
          }
          attachedEbsVolumes {
            id
            volumeNativeId
            volumeName
            volumeType
            sizeInGiBs
            __typename
          }
          __typename
        }";
      
    }
}
