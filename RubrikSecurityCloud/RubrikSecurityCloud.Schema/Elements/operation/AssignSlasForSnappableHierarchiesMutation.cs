// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class AssignSlasForSnappableHierarchiesMutation {
      /// <summary>
      /// AssignSlasForSnappableHierarchiesMutation.Request 
      /// <para>Required variables:<br/> { objectIds=(any[]) }</para>
      /// <para>Optional variables:<br/> { slaId=(any), globalSlaAssignType=(SlaAssignTypeEnum), existing_snapshot_retention=(GlobalExistingSnapshotRetention), shouldApplyToExistingSnapshots=(bool) }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = AssignSlasForSnappableHierarchiesDocument,
          OperationName = "AssignSlasForSnappableHierarchies",
          Variables = variables
        };
      }

      
      public static string AssignSlasForSnappableHierarchiesDocument = @"
        mutation AssignSlasForSnappableHierarchies($slaId: UUID, $globalSlaAssignType: SlaAssignTypeEnum = protectWithSlaId, $objectIds: [UUID!]!, $existing_snapshot_retention: GlobalExistingSnapshotRetention, $shouldApplyToExistingSnapshots: Boolean = false) {
          assignSlasForSnappableHierarchies(
            globalSlaOptionalFid: $slaId
            globalSlaAssignType: $globalSlaAssignType
            objectIds: $objectIds
            shouldApplyToExistingSnapshots: $shouldApplyToExistingSnapshots
            globalExistingSnapshotRetention: $existing_snapshot_retention
          ) {
            ...AssignSlasForSnappableHierarchiesFragment
          }
        }
        fragment AssignSlasForSnappableHierarchiesFragment on SlaAssignResult {
          success
        }";
      
    }
}
