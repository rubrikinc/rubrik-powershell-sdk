// Mutation.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region Mutation
    public class Mutation
    {
        #region members
        //      C# -> CloudAccount? CreateAwsAccount
        // GraphQL -> createAwsAccount: CloudAccount! (interface)
        public static string CreateAwsAccount(
            ref CloudAccount? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<CloudAccount>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (CloudAccount?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create CloudAccount? composite object");
                }
            }
            return "createAwsAccount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Target? CreateAwsReaderTarget
        // GraphQL -> createAwsReaderTarget: Target! (interface)
        public static string CreateAwsReaderTarget(
            ref Target? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return "createAwsReaderTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Target? CreateAwsTarget
        // GraphQL -> createAwsTarget: Target! (interface)
        public static string CreateAwsTarget(
            ref Target? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return "createAwsTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CloudAccount? CreateAzureAccount
        // GraphQL -> createAzureAccount: CloudAccount! (interface)
        public static string CreateAzureAccount(
            ref CloudAccount? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<CloudAccount>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (CloudAccount?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create CloudAccount? composite object");
                }
            }
            return "createAzureAccount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Target? CreateAzureReaderTarget
        // GraphQL -> createAzureReaderTarget: Target! (interface)
        public static string CreateAzureReaderTarget(
            ref Target? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return "createAzureReaderTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Target? CreateAzureTarget
        // GraphQL -> createAzureTarget: Target! (interface)
        public static string CreateAzureTarget(
            ref Target? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return "createAzureTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Target? CreateGcpReaderTarget
        // GraphQL -> createGcpReaderTarget: Target! (interface)
        public static string CreateGcpReaderTarget(
            ref Target? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return "createGcpReaderTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Target? CreateGcpTarget
        // GraphQL -> createGcpTarget: Target! (interface)
        public static string CreateGcpTarget(
            ref Target? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return "createGcpTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Target? CreateGlacierReaderTarget
        // GraphQL -> createGlacierReaderTarget: Target! (interface)
        public static string CreateGlacierReaderTarget(
            ref Target? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return "createGlacierReaderTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Target? CreateNfsReaderTarget
        // GraphQL -> createNfsReaderTarget: Target! (interface)
        public static string CreateNfsReaderTarget(
            ref Target? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return "createNfsReaderTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Target? CreateNfsTarget
        // GraphQL -> createNfsTarget: Target! (interface)
        public static string CreateNfsTarget(
            ref Target? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return "createNfsTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Target? CreateRcsReaderTarget
        // GraphQL -> createRcsReaderTarget: Target! (interface)
        public static string CreateRcsReaderTarget(
            ref Target? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return "createRcsReaderTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Target? CreateRcsTarget
        // GraphQL -> createRcsTarget: Target! (interface)
        public static string CreateRcsTarget(
            ref Target? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return "createRcsTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> List<Target>? CreateRcvLocationsFromTemplate
        // GraphQL -> createRcvLocationsFromTemplate: [Target!]! (interface)
        public static string CreateRcvLocationsFromTemplate(
            ref List<Target>? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new List<Target>();
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createRcvLocationsFromTemplate" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Target? CreateS3CompatibleReaderTarget
        // GraphQL -> createS3CompatibleReaderTarget: Target! (interface)
        public static string CreateS3CompatibleReaderTarget(
            ref Target? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return "createS3CompatibleReaderTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Target? CreateS3CompatibleTarget
        // GraphQL -> createS3CompatibleTarget: Target! (interface)
        public static string CreateS3CompatibleTarget(
            ref Target? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return "createS3CompatibleTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Target? CreateTapeReaderTarget
        // GraphQL -> createTapeReaderTarget: Target! (interface)
        public static string CreateTapeReaderTarget(
            ref Target? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return "createTapeReaderTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Target? CreateTapeTarget
        // GraphQL -> createTapeTarget: Target! (interface)
        public static string CreateTapeTarget(
            ref Target? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return "createTapeTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CloudAccount? UpdateAwsAccount
        // GraphQL -> updateAwsAccount: CloudAccount! (interface)
        public static string UpdateAwsAccount(
            ref CloudAccount? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<CloudAccount>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (CloudAccount?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create CloudAccount? composite object");
                }
            }
            return "updateAwsAccount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Target? UpdateAwsTarget
        // GraphQL -> updateAwsTarget: Target! (interface)
        public static string UpdateAwsTarget(
            ref Target? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return "updateAwsTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CloudAccount? UpdateAzureAccount
        // GraphQL -> updateAzureAccount: CloudAccount! (interface)
        public static string UpdateAzureAccount(
            ref CloudAccount? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<CloudAccount>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (CloudAccount?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create CloudAccount? composite object");
                }
            }
            return "updateAzureAccount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Target? UpdateAzureTarget
        // GraphQL -> updateAzureTarget: Target! (interface)
        public static string UpdateAzureTarget(
            ref Target? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return "updateAzureTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Target? UpdateGcpTarget
        // GraphQL -> updateGcpTarget: Target! (interface)
        public static string UpdateGcpTarget(
            ref Target? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return "updateGcpTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Target? UpdateGlacierTarget
        // GraphQL -> updateGlacierTarget: Target! (interface)
        public static string UpdateGlacierTarget(
            ref Target? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return "updateGlacierTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Target? UpdateNfsTarget
        // GraphQL -> updateNfsTarget: Target! (interface)
        public static string UpdateNfsTarget(
            ref Target? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return "updateNfsTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Target? UpdateRcvTarget
        // GraphQL -> updateRcvTarget: Target! (interface)
        public static string UpdateRcvTarget(
            ref Target? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return "updateRcvTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Target? UpdateS3CompatibleTarget
        // GraphQL -> updateS3CompatibleTarget: Target! (interface)
        public static string UpdateS3CompatibleTarget(
            ref Target? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return "updateS3CompatibleTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Target? UpdateTapeTarget
        // GraphQL -> updateTapeTarget: Target! (interface)
        public static string UpdateTapeTarget(
            ref Target? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec(new ExplorationContext());
                fieldSpec = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return "updateTapeTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> System.Boolean? AddInventoryWorkloads
        // GraphQL -> addInventoryWorkloads: Boolean! (scalar)
        public static string AddInventoryWorkloads(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "addInventoryWorkloads" + args + "\n";
        }

        //      C# -> System.String? AddPolicyObjects
        // GraphQL -> addPolicyObjects: String! (scalar)
        public static string AddPolicyObjects(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\npolicyIds: $policyIds\nobjectIds: $objectIds\nobjectRootIds: $objectRootIds\nclusterIds: $clusterIds\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "addPolicyObjects" + args + "\n";
        }

        //      C# -> System.Boolean? AddRoleAssignments
        // GraphQL -> addRoleAssignments: Boolean! (scalar)
        public static string AddRoleAssignments(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\nuserIds: $userIds\ngroupIds: $groupIds\nroleIds: $roleIds\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "addRoleAssignments" + args + "\n";
        }

        //      C# -> System.String? ArchiveCrawl
        // GraphQL -> archiveCrawl: String! (scalar)
        public static string ArchiveCrawl(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ncrawlId: $crawlId\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "archiveCrawl" + args + "\n";
        }

        //      C# -> System.Boolean? BatchDeassignRoleFromUserGroups
        // GraphQL -> batchDeassignRoleFromUserGroups: Boolean! (scalar)
        public static string BatchDeassignRoleFromUserGroups(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\nuserGroupToRoles: $userGroupToRoles\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "batchDeassignRoleFromUserGroups" + args + "\n";
        }

        //      C# -> System.Boolean? CancelActivitySeries
        // GraphQL -> cancelActivitySeries: Boolean! (scalar)
        public static string CancelActivitySeries(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "cancelActivitySeries" + args + "\n";
        }

        //      C# -> System.String? CancelThreatHunt
        // GraphQL -> cancelThreatHunt: Void (scalar)
        public static string CancelThreatHunt(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "cancelThreatHunt" + args + "\n";
        }

        //      C# -> System.Boolean? ChangePassword
        // GraphQL -> changePassword: Boolean! (scalar)
        public static string ChangePassword(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "changePassword" + args + "\n";
        }

        //      C# -> System.String? CreateReplicationPair
        // GraphQL -> createReplicationPair: Void (scalar)
        public static string CreateReplicationPair(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "createReplicationPair" + args + "\n";
        }

        //      C# -> System.String? CreateRole
        // GraphQL -> createRole: UUID! (scalar)
        public static string CreateRole(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\nname: $name\ndescription: $description\npermissions: $permissions\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "createRole" + args + "\n";
        }

        //      C# -> System.String? CreateUser
        // GraphQL -> createUser: String! (scalar)
        public static string CreateUser(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\nemail: $email\nroleIds: $roleIds\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "createUser" + args + "\n";
        }

        //      C# -> System.String? CreateUserWithPassword
        // GraphQL -> createUserWithPassword: String! (scalar)
        public static string CreateUserWithPassword(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "createUserWithPassword" + args + "\n";
        }

        //      C# -> System.String? DeactivateCustomAnalyzer
        // GraphQL -> deactivateCustomAnalyzer: String! (scalar)
        public static string DeactivateCustomAnalyzer(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\nanalyzerId: $analyzerId\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "deactivateCustomAnalyzer" + args + "\n";
        }

        //      C# -> List<System.String>? DeactivatePolicy
        // GraphQL -> deactivatePolicy: [String!]! (scalar)
        public static string DeactivatePolicy(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "\n(\npolicyId: $policyId\nrunAsync: $runAsync\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return "deactivatePolicy" + args + "\n";
        }

        //      C# -> System.String? DeleteAllOracleDatabaseSnapshots
        // GraphQL -> deleteAllOracleDatabaseSnapshots: Void (scalar)
        public static string DeleteAllOracleDatabaseSnapshots(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "deleteAllOracleDatabaseSnapshots" + args + "\n";
        }

        //      C# -> System.String? DeleteAwsComputeSetting
        // GraphQL -> deleteAwsComputeSetting: Void (scalar)
        public static string DeleteAwsComputeSetting(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "deleteAwsComputeSetting" + args + "\n";
        }

        //      C# -> System.Boolean? DeleteCertificate
        // GraphQL -> deleteCertificate: Boolean! (scalar)
        public static string DeleteCertificate(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ncertificateId: $certificateId\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "deleteCertificate" + args + "\n";
        }

        //      C# -> System.String? DeleteCloudNativeLabelRule
        // GraphQL -> deleteCloudNativeLabelRule: Void (scalar)
        public static string DeleteCloudNativeLabelRule(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "deleteCloudNativeLabelRule" + args + "\n";
        }

        //      C# -> System.String? DeleteCloudNativeTagRule
        // GraphQL -> deleteCloudNativeTagRule: Void (scalar)
        public static string DeleteCloudNativeTagRule(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "deleteCloudNativeTagRule" + args + "\n";
        }

        //      C# -> System.Boolean? DeleteCloudWorkloadSnapshot
        // GraphQL -> deleteCloudWorkloadSnapshot: Boolean! (scalar)
        public static string DeleteCloudWorkloadSnapshot(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "deleteCloudWorkloadSnapshot" + args + "\n";
        }

        //      C# -> System.String? DeleteCsr
        // GraphQL -> deleteCsr: Void (scalar)
        public static string DeleteCsr(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "deleteCsr" + args + "\n";
        }

        //      C# -> System.String? DeleteCustomReport
        // GraphQL -> deleteCustomReport: Void (scalar)
        public static string DeleteCustomReport(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "deleteCustomReport" + args + "\n";
        }

        //      C# -> System.String? DeleteEventDigest
        // GraphQL -> deleteEventDigest: Void (scalar)
        public static string DeleteEventDigest(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "deleteEventDigest" + args + "\n";
        }

        //      C# -> System.Boolean? DeleteGuestCredentialById
        // GraphQL -> deleteGuestCredentialById: Boolean! (scalar)
        public static string DeleteGuestCredentialById(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "deleteGuestCredentialById" + args + "\n";
        }

        //      C# -> System.String? DeleteIntegration
        // GraphQL -> deleteIntegration: Void (scalar)
        public static string DeleteIntegration(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "deleteIntegration" + args + "\n";
        }

        //      C# -> System.String? DeleteIntegrations
        // GraphQL -> deleteIntegrations: Void (scalar)
        public static string DeleteIntegrations(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "deleteIntegrations" + args + "\n";
        }

        //      C# -> System.Boolean? DeleteLdapPrincipals
        // GraphQL -> deleteLdapPrincipals: Boolean! (scalar)
        public static string DeleteLdapPrincipals(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\nprincipalIds: $principalIds\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "deleteLdapPrincipals" + args + "\n";
        }

        //      C# -> System.Boolean? DeleteOrg
        // GraphQL -> deleteOrg: Boolean! (scalar)
        public static string DeleteOrg(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "deleteOrg" + args + "\n";
        }

        //      C# -> System.String? DeleteReplicationPair
        // GraphQL -> deleteReplicationPair: Void (scalar)
        public static string DeleteReplicationPair(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "deleteReplicationPair" + args + "\n";
        }

        //      C# -> System.Boolean? DeleteRole
        // GraphQL -> deleteRole: Boolean! (scalar)
        public static string DeleteRole(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\nroleId: $roleId\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "deleteRole" + args + "\n";
        }

        //      C# -> System.String? DeleteScheduledReport
        // GraphQL -> deleteScheduledReport: Void (scalar)
        public static string DeleteScheduledReport(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "deleteScheduledReport" + args + "\n";
        }

        //      C# -> System.Boolean? DeleteServiceAccountsFromAccount
        // GraphQL -> deleteServiceAccountsFromAccount: Boolean! (scalar)
        public static string DeleteServiceAccountsFromAccount(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "deleteServiceAccountsFromAccount" + args + "\n";
        }

        //      C# -> System.String? DeleteSmbDomain
        // GraphQL -> deleteSmbDomain: Void (scalar)
        public static string DeleteSmbDomain(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "deleteSmbDomain" + args + "\n";
        }

        //      C# -> System.String? DeleteSyslogExportRule
        // GraphQL -> deleteSyslogExportRule: Void (scalar)
        public static string DeleteSyslogExportRule(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "deleteSyslogExportRule" + args + "\n";
        }

        //      C# -> System.String? DeleteTarget
        // GraphQL -> deleteTarget: Void (scalar)
        public static string DeleteTarget(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "deleteTarget" + args + "\n";
        }

        //      C# -> System.String? DeleteTargetMapping
        // GraphQL -> deleteTargetMapping: Void (scalar)
        public static string DeleteTargetMapping(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "deleteTargetMapping" + args + "\n";
        }

        //      C# -> System.Boolean? DeleteTotpConfig
        // GraphQL -> deleteTotpConfig: Boolean! (scalar)
        public static string DeleteTotpConfig(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\nuserId: $userId\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "deleteTotpConfig" + args + "\n";
        }

        //      C# -> System.Boolean? DeleteTotpConfigs
        // GraphQL -> deleteTotpConfigs: Boolean! (scalar)
        public static string DeleteTotpConfigs(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "deleteTotpConfigs" + args + "\n";
        }

        //      C# -> System.Boolean? DeleteUsersFromAccount
        // GraphQL -> deleteUsersFromAccount: Boolean! (scalar)
        public static string DeleteUsersFromAccount(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\nids: $ids\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "deleteUsersFromAccount" + args + "\n";
        }

        //      C# -> System.String? DeleteWebhook
        // GraphQL -> deleteWebhook: Void (scalar)
        public static string DeleteWebhook(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "deleteWebhook" + args + "\n";
        }

        //      C# -> System.String? DisableSupportUserAccess
        // GraphQL -> disableSupportUserAccess: Void (scalar)
        public static string DisableSupportUserAccess(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "disableSupportUserAccess" + args + "\n";
        }

        //      C# -> System.String? EnableSupportUserAccess
        // GraphQL -> enableSupportUserAccess: Void (scalar)
        public static string EnableSupportUserAccess(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "enableSupportUserAccess" + args + "\n";
        }

        //      C# -> System.String? EnableThreatMonitoring
        // GraphQL -> enableThreatMonitoring: Void (scalar)
        public static string EnableThreatMonitoring(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "enableThreatMonitoring" + args + "\n";
        }

        //      C# -> System.String? ExcludeAwsNativeEbsVolumesFromSnapshot
        // GraphQL -> excludeAwsNativeEbsVolumesFromSnapshot: Void (scalar)
        public static string ExcludeAwsNativeEbsVolumesFromSnapshot(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "excludeAwsNativeEbsVolumesFromSnapshot" + args + "\n";
        }

        //      C# -> System.String? ExcludeAzureNativeManagedDisksFromSnapshot
        // GraphQL -> excludeAzureNativeManagedDisksFromSnapshot: Void (scalar)
        public static string ExcludeAzureNativeManagedDisksFromSnapshot(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "excludeAzureNativeManagedDisksFromSnapshot" + args + "\n";
        }

        //      C# -> System.String? ExcludeSharepointObjectsFromProtection
        // GraphQL -> excludeSharepointObjectsFromProtection: Void (scalar)
        public static string ExcludeSharepointObjectsFromProtection(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "excludeSharepointObjectsFromProtection" + args + "\n";
        }

        //      C# -> System.Boolean? GcpCloudAccountAddManualAuthProject
        // GraphQL -> gcpCloudAccountAddManualAuthProject: Boolean! (scalar)
        public static string GcpCloudAccountAddManualAuthProject(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "gcpCloudAccountAddManualAuthProject" + args + "\n";
        }

        //      C# -> System.String? GcpNativeExcludeDisksFromInstanceSnapshot
        // GraphQL -> gcpNativeExcludeDisksFromInstanceSnapshot: Void (scalar)
        public static string GcpNativeExcludeDisksFromInstanceSnapshot(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "gcpNativeExcludeDisksFromInstanceSnapshot" + args + "\n";
        }

        //      C# -> System.Boolean? GcpSetDefaultServiceAccountJwtConfig
        // GraphQL -> gcpSetDefaultServiceAccountJwtConfig: Boolean! (scalar)
        public static string GcpSetDefaultServiceAccountJwtConfig(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "gcpSetDefaultServiceAccountJwtConfig" + args + "\n";
        }

        //      C# -> System.String? HideRevealNasNamespaces
        // GraphQL -> hideRevealNasNamespaces: Void (scalar)
        public static string HideRevealNasNamespaces(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "hideRevealNasNamespaces" + args + "\n";
        }

        //      C# -> System.Boolean? InviteSsoGroup
        // GraphQL -> inviteSsoGroup: Boolean! (scalar)
        public static string InviteSsoGroup(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "inviteSsoGroup" + args + "\n";
        }

        //      C# -> System.String? JoinSmbDomain
        // GraphQL -> joinSmbDomain: Void (scalar)
        public static string JoinSmbDomain(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "joinSmbDomain" + args + "\n";
        }

        //      C# -> System.String? LockUsersByAdmin
        // GraphQL -> lockUsersByAdmin: Void (scalar)
        public static string LockUsersByAdmin(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "lockUsersByAdmin" + args + "\n";
        }

        //      C# -> System.String? MutateRole
        // GraphQL -> mutateRole: UUID! (scalar)
        public static string MutateRole(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\nroleId: $roleId\nname: $name\ndescription: $description\npermissions: $permissions\nprotectableClusters: $protectableClusters\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "mutateRole" + args + "\n";
        }

        //      C# -> System.Boolean? PatchAwsAuthenticationServerBasedCloudAccount
        // GraphQL -> patchAwsAuthenticationServerBasedCloudAccount: Boolean! (scalar)
        public static string PatchAwsAuthenticationServerBasedCloudAccount(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "patchAwsAuthenticationServerBasedCloudAccount" + args + "\n";
        }

        //      C# -> System.Boolean? PatchAwsIamUserBasedCloudAccount
        // GraphQL -> patchAwsIamUserBasedCloudAccount: Boolean! (scalar)
        public static string PatchAwsIamUserBasedCloudAccount(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "patchAwsIamUserBasedCloudAccount" + args + "\n";
        }

        //      C# -> System.String? PromoteReaderTarget
        // GraphQL -> promoteReaderTarget: Void (scalar)
        public static string PromoteReaderTarget(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "promoteReaderTarget" + args + "\n";
        }

        //      C# -> System.String? RefreshReaderTarget
        // GraphQL -> refreshReaderTarget: Void (scalar)
        public static string RefreshReaderTarget(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "refreshReaderTarget" + args + "\n";
        }

        //      C# -> System.Boolean? RemoveCdmCluster
        // GraphQL -> removeCdmCluster: Boolean! (scalar)
        public static string RemoveCdmCluster(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\nclusterUUID: $clusterUUID\nisForce: $isForce\nexpireInDays: $expireInDays\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "removeCdmCluster" + args + "\n";
        }

        //      C# -> System.Boolean? RemoveInventoryWorkloads
        // GraphQL -> removeInventoryWorkloads: Boolean! (scalar)
        public static string RemoveInventoryWorkloads(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "removeInventoryWorkloads" + args + "\n";
        }

        //      C# -> System.Boolean? RemoveLdapIntegration
        // GraphQL -> removeLdapIntegration: Boolean! (scalar)
        public static string RemoveLdapIntegration(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\nid: $id\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "removeLdapIntegration" + args + "\n";
        }

        //      C# -> List<System.String>? RemovePolicyObjects
        // GraphQL -> removePolicyObjects: [String!]! (scalar)
        public static string RemovePolicyObjects(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "\n(\npolicyIds: $policyIds\nobjectIds: $objectIds\nobjectRootIds: $objectRootIds\nclusterIds: $clusterIds\nrunAsync: $runAsync\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return "removePolicyObjects" + args + "\n";
        }

        //      C# -> System.String? RemovePrivateEndpointConnection
        // GraphQL -> removePrivateEndpointConnection: Void (scalar)
        public static string RemovePrivateEndpointConnection(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "removePrivateEndpointConnection" + args + "\n";
        }

        //      C# -> System.String? ResetAllOrgUsersPasswords
        // GraphQL -> resetAllOrgUsersPasswords: Void (scalar)
        public static string ResetAllOrgUsersPasswords(
            ref System.String? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "resetAllOrgUsersPasswords" + args + "\n";
        }

        //      C# -> System.String? ResetUsersPasswordsWithUserIds
        // GraphQL -> resetUsersPasswordsWithUserIds: Void (scalar)
        public static string ResetUsersPasswordsWithUserIds(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "resetUsersPasswordsWithUserIds" + args + "\n";
        }

        //      C# -> System.String? RevokeAllOrgRoles
        // GraphQL -> revokeAllOrgRoles: Void (scalar)
        public static string RevokeAllOrgRoles(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "revokeAllOrgRoles" + args + "\n";
        }

        //      C# -> System.Boolean? SetAzureCloudAccountCustomerAppCredentials
        // GraphQL -> setAzureCloudAccountCustomerAppCredentials: Boolean! (scalar)
        public static string SetAzureCloudAccountCustomerAppCredentials(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "setAzureCloudAccountCustomerAppCredentials" + args + "\n";
        }

        //      C# -> System.String? SetCustomerTags
        // GraphQL -> setCustomerTags: Void (scalar)
        public static string SetCustomerTags(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "setCustomerTags" + args + "\n";
        }

        //      C# -> System.Boolean? SetIpWhitelistEnabled
        // GraphQL -> setIpWhitelistEnabled: Boolean! (scalar)
        public static string SetIpWhitelistEnabled(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\nenabled: $enabled\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "setIpWhitelistEnabled" + args + "\n";
        }

        //      C# -> System.Boolean? SetLdapMfaSetting
        // GraphQL -> setLdapMfaSetting: Boolean! (scalar)
        public static string SetLdapMfaSetting(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "setLdapMfaSetting" + args + "\n";
        }

        //      C# -> System.Boolean? SetMfaSetting
        // GraphQL -> setMfaSetting: Boolean! (scalar)
        public static string SetMfaSetting(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "setMfaSetting" + args + "\n";
        }

        //      C# -> System.String? SetPasswordComplexityPolicy
        // GraphQL -> setPasswordComplexityPolicy: Void (scalar)
        public static string SetPasswordComplexityPolicy(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "setPasswordComplexityPolicy" + args + "\n";
        }

        //      C# -> System.String? SetSsoCertificate
        // GraphQL -> setSsoCertificate: Void (scalar)
        public static string SetSsoCertificate(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "setSsoCertificate" + args + "\n";
        }

        //      C# -> System.Boolean? SetTotpConfig
        // GraphQL -> setTotpConfig: Boolean! (scalar)
        public static string SetTotpConfig(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "setTotpConfig" + args + "\n";
        }

        //      C# -> System.Boolean? SetUserLevelTotpEnforcement
        // GraphQL -> setUserLevelTotpEnforcement: Boolean! (scalar)
        public static string SetUserLevelTotpEnforcement(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "setUserLevelTotpEnforcement" + args + "\n";
        }

        //      C# -> System.String? StopJobInstanceFromEventSeries
        // GraphQL -> stopJobInstanceFromEventSeries: Void (scalar)
        public static string StopJobInstanceFromEventSeries(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "stopJobInstanceFromEventSeries" + args + "\n";
        }

        //      C# -> System.String? UnlockUsersByAdmin
        // GraphQL -> unlockUsersByAdmin: Void (scalar)
        public static string UnlockUsersByAdmin(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "unlockUsersByAdmin" + args + "\n";
        }

        //      C# -> System.String? UnmapAzurePersistentStorageSubscription
        // GraphQL -> unmapAzurePersistentStorageSubscription: Void (scalar)
        public static string UnmapAzurePersistentStorageSubscription(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "unmapAzurePersistentStorageSubscription" + args + "\n";
        }

        //      C# -> System.String? UnmountDisk
        // GraphQL -> unmountDisk: Void (scalar)
        public static string UnmountDisk(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "unmountDisk" + args + "\n";
        }

        //      C# -> System.Boolean? UpdateAccountOwner
        // GraphQL -> updateAccountOwner: Boolean! (scalar)
        public static string UpdateAccountOwner(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\nuserId: $userId\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "updateAccountOwner" + args + "\n";
        }

        //      C# -> System.String? UpdateAuthDomainUsersHiddenStatus
        // GraphQL -> updateAuthDomainUsersHiddenStatus: Void (scalar)
        public static string UpdateAuthDomainUsersHiddenStatus(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "updateAuthDomainUsersHiddenStatus" + args + "\n";
        }

        //      C# -> System.String? UpdateAwsCloudAccount
        // GraphQL -> updateAwsCloudAccount: Void (scalar)
        public static string UpdateAwsCloudAccount(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "updateAwsCloudAccount" + args + "\n";
        }

        //      C# -> System.Boolean? UpdateCertificate
        // GraphQL -> updateCertificate: Boolean! (scalar)
        public static string UpdateCertificate(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ncertificateId: $certificateId\nname: $name\ndescription: $description\ncertificate: $certificate\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "updateCertificate" + args + "\n";
        }

        //      C# -> System.String? UpdateCloudNativeLabelRule
        // GraphQL -> updateCloudNativeLabelRule: Void (scalar)
        public static string UpdateCloudNativeLabelRule(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "updateCloudNativeLabelRule" + args + "\n";
        }

        //      C# -> System.String? UpdateCloudNativeTagRule
        // GraphQL -> updateCloudNativeTagRule: Void (scalar)
        public static string UpdateCloudNativeTagRule(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "updateCloudNativeTagRule" + args + "\n";
        }

        //      C# -> System.String? UpdateConfiguredGroup
        // GraphQL -> updateConfiguredGroup: Void (scalar)
        public static string UpdateConfiguredGroup(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "updateConfiguredGroup" + args + "\n";
        }

        //      C# -> System.String? UpdateCustomerAppPermissionForAzureSql
        // GraphQL -> updateCustomerAppPermissionForAzureSql: Void (scalar)
        public static string UpdateCustomerAppPermissionForAzureSql(
            ref System.String? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "updateCustomerAppPermissionForAzureSql" + args + "\n";
        }

        //      C# -> System.String? UpdateIntegration
        // GraphQL -> updateIntegration: Void (scalar)
        public static string UpdateIntegration(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "updateIntegration" + args + "\n";
        }

        //      C# -> System.String? UpdateIntegrations
        // GraphQL -> updateIntegrations: Void (scalar)
        public static string UpdateIntegrations(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "updateIntegrations" + args + "\n";
        }

        //      C# -> System.Boolean? UpdateIpWhitelist
        // GraphQL -> updateIpWhitelist: Boolean! (scalar)
        public static string UpdateIpWhitelist(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\nwhitelistMode: $whitelistMode\nipCidrs: $ipCidrs\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "updateIpWhitelist" + args + "\n";
        }

        //      C# -> System.String? UpdateLdapIntegration
        // GraphQL -> updateLdapIntegration: String! (scalar)
        public static string UpdateLdapIntegration(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\nid: $id\nname: $name\nbindUserName: $bindUserName\nbindUserPassword: $bindUserPassword\nbaseDn: $baseDn\ntrustedCerts: $trustedCerts\ndynamicDnsName: $dynamicDnsName\nldapServers: $ldapServers\nuserSearchFilter: $userSearchFilter\nuserNameAttr: $userNameAttr\ngroupMembershipAttr: $groupMembershipAttr\ngroupSearchFilter: $groupSearchFilter\ngroupMemberAttr: $groupMemberAttr\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "updateLdapIntegration" + args + "\n";
        }

        //      C# -> System.String? UpdateNasShares
        // GraphQL -> updateNasShares: Void (scalar)
        public static string UpdateNasShares(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "updateNasShares" + args + "\n";
        }

        //      C# -> System.String? UpdateNutanixVm
        // GraphQL -> updateNutanixVm: Void (scalar)
        public static string UpdateNutanixVm(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "updateNutanixVm" + args + "\n";
        }

        //      C# -> System.String? UpdateO365AppPermissions
        // GraphQL -> updateO365AppPermissions: Void (scalar)
        public static string UpdateO365AppPermissions(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "updateO365AppPermissions" + args + "\n";
        }

        //      C# -> System.String? UpdateOrgSecurityPolicy
        // GraphQL -> updateOrgSecurityPolicy: Void (scalar)
        public static string UpdateOrgSecurityPolicy(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "updateOrgSecurityPolicy" + args + "\n";
        }

        //      C# -> System.String? UpdateReplicationTarget
        // GraphQL -> updateReplicationTarget: Void (scalar)
        public static string UpdateReplicationTarget(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "updateReplicationTarget" + args + "\n";
        }

        //      C# -> System.Boolean? UpdateRole
        // GraphQL -> updateRole: Boolean! (scalar)
        public static string UpdateRole(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\nroleId: $roleId\nname: $name\ndescription: $description\npermissions: $permissions\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "updateRole" + args + "\n";
        }

        //      C# -> System.Boolean? UpdateRoleAssignments
        // GraphQL -> updateRoleAssignments: Boolean! (scalar)
        public static string UpdateRoleAssignments(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\nuserIds: $userIds\ngroupIds: $groupIds\nroleIds: $roleIds\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "updateRoleAssignments" + args + "\n";
        }

        //      C# -> System.String? UpdateSupportUserAccess
        // GraphQL -> updateSupportUserAccess: Void (scalar)
        public static string UpdateSupportUserAccess(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "updateSupportUserAccess" + args + "\n";
        }

        //      C# -> System.String? UpdateWhitelistedAnalyzers
        // GraphQL -> updateWhitelistedAnalyzers: String! (scalar)
        public static string UpdateWhitelistedAnalyzers(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\nstdPath: $stdPath\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nanalyzerIds: $analyzerIds\nrunAsync: $runAsync\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "updateWhitelistedAnalyzers" + args + "\n";
        }

        //      C# -> System.Boolean? UpgradeAwsCloudAccountFeaturesWithoutCft
        // GraphQL -> upgradeAwsCloudAccountFeaturesWithoutCft: Boolean! (scalar)
        public static string UpgradeAwsCloudAccountFeaturesWithoutCft(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "upgradeAwsCloudAccountFeaturesWithoutCft" + args + "\n";
        }

        //      C# -> System.Boolean? UpgradeAwsIamUserBasedCloudAccountPermissions
        // GraphQL -> upgradeAwsIamUserBasedCloudAccountPermissions: Boolean! (scalar)
        public static string UpgradeAwsIamUserBasedCloudAccountPermissions(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "upgradeAwsIamUserBasedCloudAccountPermissions" + args + "\n";
        }

        //      C# -> System.String? UpgradeCdmManagedTarget
        // GraphQL -> upgradeCdmManagedTarget: Void (scalar)
        public static string UpgradeCdmManagedTarget(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "upgradeCdmManagedTarget" + args + "\n";
        }

        //      C# -> System.String? UpgradeToRsc
        // GraphQL -> upgradeToRsc: Void (scalar)
        public static string UpgradeToRsc(
            ref System.String? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "upgradeToRsc" + args + "\n";
        }

        //      C# -> System.String? VsphereVmDeleteSnapshot
        // GraphQL -> vsphereVmDeleteSnapshot: Void (scalar)
        public static string VsphereVmDeleteSnapshot(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return "vsphereVmDeleteSnapshot" + args + "\n";
        }

        //      C# -> System.Boolean? WarmSearchCache
        // GraphQL -> warmSearchCache: Boolean! (scalar)
        public static string WarmSearchCache(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return "warmSearchCache" + args + "\n";
        }

        //      C# -> RequestStatus? AddAdGroupsToHierarchy
        // GraphQL -> addAdGroupsToHierarchy: RequestStatus! (type)
        public static string AddAdGroupsToHierarchy(
            ref RequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "addAdGroupsToHierarchy" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AddAndJoinSmbDomainReply? AddAndJoinSmbDomain
        // GraphQL -> addAndJoinSmbDomain: AddAndJoinSmbDomainReply! (type)
        public static string AddAndJoinSmbDomain(
            ref AddAndJoinSmbDomainReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AddAndJoinSmbDomainReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "addAndJoinSmbDomain" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AddAwsAuthenticationServerBasedCloudAccountReply? AddAwsAuthenticationServerBasedCloudAccount
        // GraphQL -> addAwsAuthenticationServerBasedCloudAccount: AddAwsAuthenticationServerBasedCloudAccountReply! (type)
        public static string AddAwsAuthenticationServerBasedCloudAccount(
            ref AddAwsAuthenticationServerBasedCloudAccountReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AddAwsAuthenticationServerBasedCloudAccountReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "addAwsAuthenticationServerBasedCloudAccount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AddAwsIamUserBasedCloudAccountReply? AddAwsIamUserBasedCloudAccount
        // GraphQL -> addAwsIamUserBasedCloudAccount: AddAwsIamUserBasedCloudAccountReply! (type)
        public static string AddAwsIamUserBasedCloudAccount(
            ref AddAwsIamUserBasedCloudAccountReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AddAwsIamUserBasedCloudAccountReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "addAwsIamUserBasedCloudAccount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AddAzureCloudAccountReply? AddAzureCloudAccount
        // GraphQL -> addAzureCloudAccount: AddAzureCloudAccountReply! (type)
        public static string AddAzureCloudAccount(
            ref AddAzureCloudAccountReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AddAzureCloudAccountReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "addAzureCloudAccount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AddAzureCloudAccountExocomputeConfigurationsReply? AddAzureCloudAccountExocomputeConfigurations
        // GraphQL -> addAzureCloudAccountExocomputeConfigurations: AddAzureCloudAccountExocomputeConfigurationsReply! (type)
        public static string AddAzureCloudAccountExocomputeConfigurations(
            ref AddAzureCloudAccountExocomputeConfigurationsReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AddAzureCloudAccountExocomputeConfigurationsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "addAzureCloudAccountExocomputeConfigurations" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AddAzureCloudAccountWithoutOauthReply? AddAzureCloudAccountWithoutOauth
        // GraphQL -> addAzureCloudAccountWithoutOauth: AddAzureCloudAccountWithoutOauthReply! (type)
        public static string AddAzureCloudAccountWithoutOauth(
            ref AddAzureCloudAccountWithoutOauthReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AddAzureCloudAccountWithoutOauthReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "addAzureCloudAccountWithoutOauth" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AddCloudNativeSqlServerBackupCredentialsReply? AddCloudNativeSqlServerBackupCredentials
        // GraphQL -> addCloudNativeSqlServerBackupCredentials: AddCloudNativeSqlServerBackupCredentialsReply! (type)
        public static string AddCloudNativeSqlServerBackupCredentials(
            ref AddCloudNativeSqlServerBackupCredentialsReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AddCloudNativeSqlServerBackupCredentialsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "addCloudNativeSqlServerBackupCredentials" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AddClusterCertificateReply? AddClusterCertificate
        // GraphQL -> addClusterCertificate: AddClusterCertificateReply! (type)
        public static string AddClusterCertificate(
            ref AddClusterCertificateReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AddClusterCertificateReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "addClusterCertificate" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AddClusterNodesReply? AddClusterNodes
        // GraphQL -> addClusterNodes: AddClusterNodesReply! (type)
        public static string AddClusterNodes(
            ref AddClusterNodesReply? fieldSpec
        )
        {
            string args = "\n(\nAddClusterNodesInput: $AddClusterNodesInput\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AddClusterNodesReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "addClusterNodes" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AddConfiguredGroupToHierarchyReply? AddConfiguredGroupToHierarchy
        // GraphQL -> addConfiguredGroupToHierarchy: AddConfiguredGroupToHierarchyReply! (type)
        public static string AddConfiguredGroupToHierarchy(
            ref AddConfiguredGroupToHierarchyReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AddConfiguredGroupToHierarchyReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "addConfiguredGroupToHierarchy" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AddDb2InstanceReply? AddDb2Instance
        // GraphQL -> addDb2Instance: AddDb2InstanceReply! (type)
        public static string AddDb2Instance(
            ref AddDb2InstanceReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AddDb2InstanceReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "addDb2Instance" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AddManagedVolumeReply? AddManagedVolume
        // GraphQL -> addManagedVolume: AddManagedVolumeReply! (type)
        public static string AddManagedVolume(
            ref AddManagedVolumeReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AddManagedVolumeReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "addManagedVolume" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AddMongoSourceReply? AddMongoSource
        // GraphQL -> addMongoSource: AddMongoSourceReply! (type)
        public static string AddMongoSource(
            ref AddMongoSourceReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AddMongoSourceReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "addMongoSource" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> MosaicAsyncResponse? AddMosaicStore
        // GraphQL -> addMosaicStore: MosaicAsyncResponse! (type)
        public static string AddMosaicStore(
            ref MosaicAsyncResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new MosaicAsyncResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "addMosaicStore" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CcProvisionJobReply? AddNodesToCloudCluster
        // GraphQL -> addNodesToCloudCluster: CcProvisionJobReply! (type)
        public static string AddNodesToCloudCluster(
            ref CcProvisionJobReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CcProvisionJobReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "addNodesToCloudCluster" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AddO365OrgResponse? AddO365Org
        // GraphQL -> addO365Org: AddO365OrgResponse! (type)
        public static string AddO365Org(
            ref AddO365OrgResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AddO365OrgResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "addO365Org" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AddSapHanaSystemReply? AddSapHanaSystem
        // GraphQL -> addSapHanaSystem: AddSapHanaSystemReply! (type)
        public static string AddSapHanaSystem(
            ref AddSapHanaSystemReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AddSapHanaSystemReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "addSapHanaSystem" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AddStorageArraysReply? AddStorageArrays
        // GraphQL -> addStorageArrays: AddStorageArraysReply! (type)
        public static string AddStorageArrays(
            ref AddStorageArraysReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AddStorageArraysReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "addStorageArrays" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AddSyslogExportRuleReply? AddSyslogExportRule
        // GraphQL -> addSyslogExportRule: AddSyslogExportRuleReply! (type)
        public static string AddSyslogExportRule(
            ref AddSyslogExportRuleReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AddSyslogExportRuleReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "addSyslogExportRule" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ResponseSuccess? AddVlan
        // GraphQL -> addVlan: ResponseSuccess! (type)
        public static string AddVlan(
            ref ResponseSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ResponseSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "addVlan" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AddVmAppConsistentSpecsReply? AddVmAppConsistentSpecs
        // GraphQL -> addVmAppConsistentSpecs: AddVmAppConsistentSpecsReply! (type)
        public static string AddVmAppConsistentSpecs(
            ref AddVmAppConsistentSpecsReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AddVmAppConsistentSpecsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "addVmAppConsistentSpecs" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ArchiveK8sClusterReply? ArchiveK8sCluster
        // GraphQL -> archiveK8sCluster: ArchiveK8sClusterReply! (type)
        public static string ArchiveK8sCluster(
            ref ArchiveK8sClusterReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ArchiveK8sClusterReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "archiveK8sCluster" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ResponseSuccess? AssignMssqlSlaDomainProperties
        // GraphQL -> assignMssqlSlaDomainProperties: ResponseSuccess! (type)
        public static string AssignMssqlSlaDomainProperties(
            ref ResponseSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ResponseSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "assignMssqlSlaDomainProperties" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AssignMssqlSlaDomainPropertiesAsyncReply? AssignMssqlSlaDomainPropertiesAsync
        // GraphQL -> assignMssqlSlaDomainPropertiesAsync: AssignMssqlSlaDomainPropertiesAsyncReply! (type)
        public static string AssignMssqlSlaDomainPropertiesAsync(
            ref AssignMssqlSlaDomainPropertiesAsyncReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AssignMssqlSlaDomainPropertiesAsyncReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "assignMssqlSlaDomainPropertiesAsync" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> SlaAssignResult? AssignProtection
        // GraphQL -> assignProtection: SlaAssignResult! (type)
        public static string AssignProtection(
            ref SlaAssignResult? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new SlaAssignResult() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "assignProtection" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> SlaAssignResult? AssignRetentionSlaToSnappables
        // GraphQL -> assignRetentionSLAToSnappables: SlaAssignResult! (type)
        public static string AssignRetentionSlaToSnappables(
            ref SlaAssignResult? fieldSpec
        )
        {
            string args = "\n(\nglobalSlaOptionalFid: $globalSlaOptionalFid\nglobalSlaAssignType: $globalSlaAssignType\nobjectIds: $objectIds\napplicableSnappableType: $applicableSnappableType\nshouldApplyToNonPolicySnapshots: $shouldApplyToNonPolicySnapshots\nuserNote: $userNote\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new SlaAssignResult() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "assignRetentionSLAToSnappables" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> SlaAssignResult? AssignRetentionSlaToSnapshots
        // GraphQL -> assignRetentionSLAToSnapshots: SlaAssignResult! (type)
        public static string AssignRetentionSlaToSnapshots(
            ref SlaAssignResult? fieldSpec
        )
        {
            string args = "\n(\nglobalSlaOptionalFid: $globalSlaOptionalFid\nglobalSlaAssignType: $globalSlaAssignType\nsnapshotFids: $snapshotFids\nuserNote: $userNote\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new SlaAssignResult() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "assignRetentionSLAToSnapshots" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> SlaAssignResult? AssignSla
        // GraphQL -> assignSla: SlaAssignResult! (type)
        public static string AssignSla(
            ref SlaAssignResult? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new SlaAssignResult() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "assignSla" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? AssignSlaToMongoDbCollection
        // GraphQL -> assignSlaToMongoDbCollection: AsyncRequestStatus! (type)
        public static string AssignSlaToMongoDbCollection(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "assignSlaToMongoDbCollection" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> List<SlaAssignResult>? AssignSlasForSnappableHierarchies
        // GraphQL -> assignSlasForSnappableHierarchies: [SlaAssignResult!]! (type)
        public static string AssignSlasForSnappableHierarchies(
            ref List<SlaAssignResult>? fieldSpec
        )
        {
            string args = "\n(\nglobalSlaOptionalFid: $globalSlaOptionalFid\nglobalSlaAssignType: $globalSlaAssignType\nobjectIds: $objectIds\napplicableSnappableTypes: $applicableSnappableTypes\nshouldApplyToExistingSnapshots: $shouldApplyToExistingSnapshots\nshouldApplyToNonPolicySnapshots: $shouldApplyToNonPolicySnapshots\nglobalExistingSnapshotRetention: $globalExistingSnapshotRetention\nuserNote: $userNote\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new List<SlaAssignResult>() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "assignSlasForSnappableHierarchies" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestStatus? AzureOauthConsentComplete
        // GraphQL -> azureOauthConsentComplete: RequestStatus! (type)
        public static string AzureOauthConsentComplete(
            ref RequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "azureOauthConsentComplete" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AzureOauthConsentKickoffReply? AzureOauthConsentKickoff
        // GraphQL -> azureOauthConsentKickoff: AzureOauthConsentKickoffReply! (type)
        public static string AzureOauthConsentKickoff(
            ref AzureOauthConsentKickoffReply? fieldSpec
        )
        {
            string args = "";
           if (fieldSpec == null)
            {
                fieldSpec = new AzureOauthConsentKickoffReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "azureOauthConsentKickoff" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> List<CreateOnDemandJobReply>? BackupM365Mailbox
        // GraphQL -> backupM365Mailbox: [CreateOnDemandJobReply!]! (type)
        public static string BackupM365Mailbox(
            ref List<CreateOnDemandJobReply>? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new List<CreateOnDemandJobReply>() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "backupM365Mailbox" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> List<CreateOnDemandJobReply>? BackupM365Onedrive
        // GraphQL -> backupM365Onedrive: [CreateOnDemandJobReply!]! (type)
        public static string BackupM365Onedrive(
            ref List<CreateOnDemandJobReply>? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new List<CreateOnDemandJobReply>() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "backupM365Onedrive" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> List<CreateOnDemandJobReply>? BackupM365SharepointDrive
        // GraphQL -> backupM365SharepointDrive: [CreateOnDemandJobReply!]! (type)
        public static string BackupM365SharepointDrive(
            ref List<CreateOnDemandJobReply>? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new List<CreateOnDemandJobReply>() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "backupM365SharepointDrive" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> List<CreateOnDemandJobReply>? BackupM365Team
        // GraphQL -> backupM365Team: [CreateOnDemandJobReply!]! (type)
        public static string BackupM365Team(
            ref List<CreateOnDemandJobReply>? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new List<CreateOnDemandJobReply>() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "backupM365Team" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchAsyncJobStatus? BackupO365Mailbox
        // GraphQL -> backupO365Mailbox: BatchAsyncJobStatus! (type)
        public static string BackupO365Mailbox(
            ref BatchAsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\nmailboxIds: $mailboxIds\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchAsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "backupO365Mailbox" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchAsyncJobStatus? BackupO365Onedrive
        // GraphQL -> backupO365Onedrive: BatchAsyncJobStatus! (type)
        public static string BackupO365Onedrive(
            ref BatchAsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchAsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "backupO365Onedrive" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateOnDemandJobReply? BackupO365SharePointSite
        // GraphQL -> backupO365SharePointSite: CreateOnDemandJobReply! (type)
        public static string BackupO365SharePointSite(
            ref CreateOnDemandJobReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateOnDemandJobReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "backupO365SharePointSite" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchAsyncJobStatus? BackupO365SharepointDrive
        // GraphQL -> backupO365SharepointDrive: BatchAsyncJobStatus! (type)
        public static string BackupO365SharepointDrive(
            ref BatchAsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchAsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "backupO365SharepointDrive" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateOnDemandJobReply? BackupO365SharepointList
        // GraphQL -> backupO365SharepointList: CreateOnDemandJobReply! (type)
        public static string BackupO365SharepointList(
            ref CreateOnDemandJobReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateOnDemandJobReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "backupO365SharepointList" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchAsyncJobStatus? BackupO365Team
        // GraphQL -> backupO365Team: BatchAsyncJobStatus! (type)
        public static string BackupO365Team(
            ref BatchAsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchAsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "backupO365Team" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchExportHypervVmReply? BatchExportHypervVm
        // GraphQL -> batchExportHypervVm: BatchExportHypervVmReply! (type)
        public static string BatchExportHypervVm(
            ref BatchExportHypervVmReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchExportHypervVmReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "batchExportHypervVm" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchExportNutanixVmReply? BatchExportNutanixVm
        // GraphQL -> batchExportNutanixVm: BatchExportNutanixVmReply! (type)
        public static string BatchExportNutanixVm(
            ref BatchExportNutanixVmReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchExportNutanixVmReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "batchExportNutanixVm" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchInstantRecoverHypervVmReply? BatchInstantRecoverHypervVm
        // GraphQL -> batchInstantRecoverHypervVm: BatchInstantRecoverHypervVmReply! (type)
        public static string BatchInstantRecoverHypervVm(
            ref BatchInstantRecoverHypervVmReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchInstantRecoverHypervVmReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "batchInstantRecoverHypervVm" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchMountHypervVmReply? BatchMountHypervVm
        // GraphQL -> batchMountHypervVm: BatchMountHypervVmReply! (type)
        public static string BatchMountHypervVm(
            ref BatchMountHypervVmReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchMountHypervVmReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "batchMountHypervVm" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchMountNutanixVmReply? BatchMountNutanixVm
        // GraphQL -> batchMountNutanixVm: BatchMountNutanixVmReply! (type)
        public static string BatchMountNutanixVm(
            ref BatchMountNutanixVmReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchMountNutanixVmReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "batchMountNutanixVm" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchOnDemandBackupHypervVmReply? BatchOnDemandBackupHypervVm
        // GraphQL -> batchOnDemandBackupHypervVm: BatchOnDemandBackupHypervVmReply! (type)
        public static string BatchOnDemandBackupHypervVm(
            ref BatchOnDemandBackupHypervVmReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchOnDemandBackupHypervVmReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "batchOnDemandBackupHypervVm" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchQuarantineSnapshotReply? BatchQuarantineSnapshot
        // GraphQL -> batchQuarantineSnapshot: BatchQuarantineSnapshotReply! (type)
        public static string BatchQuarantineSnapshot(
            ref BatchQuarantineSnapshotReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchQuarantineSnapshotReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "batchQuarantineSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchReleaseFromQuarantineSnapshotReply? BatchReleaseFromQuarantineSnapshot
        // GraphQL -> batchReleaseFromQuarantineSnapshot: BatchReleaseFromQuarantineSnapshotReply! (type)
        public static string BatchReleaseFromQuarantineSnapshot(
            ref BatchReleaseFromQuarantineSnapshotReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchReleaseFromQuarantineSnapshotReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "batchReleaseFromQuarantineSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BeginManagedVolumeSnapshotReply? BeginManagedVolumeSnapshot
        // GraphQL -> beginManagedVolumeSnapshot: BeginManagedVolumeSnapshotReply! (type)
        public static string BeginManagedVolumeSnapshot(
            ref BeginManagedVolumeSnapshotReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BeginManagedVolumeSnapshotReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "beginManagedVolumeSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BrowseMssqlDatabaseSnapshotReply? BrowseMssqlDatabaseSnapshot
        // GraphQL -> browseMssqlDatabaseSnapshot: BrowseMssqlDatabaseSnapshotReply! (type)
        public static string BrowseMssqlDatabaseSnapshot(
            ref BrowseMssqlDatabaseSnapshotReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BrowseMssqlDatabaseSnapshotReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "browseMssqlDatabaseSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BulkCreateFilesetTemplatesReply? BulkCreateFilesetTemplates
        // GraphQL -> bulkCreateFilesetTemplates: BulkCreateFilesetTemplatesReply! (type)
        public static string BulkCreateFilesetTemplates(
            ref BulkCreateFilesetTemplatesReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BulkCreateFilesetTemplatesReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "bulkCreateFilesetTemplates" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BulkCreateFilesetsReply? BulkCreateFilesets
        // GraphQL -> bulkCreateFilesets: BulkCreateFilesetsReply! (type)
        public static string BulkCreateFilesets(
            ref BulkCreateFilesetsReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BulkCreateFilesetsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "bulkCreateFilesets" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BulkCreateNasFilesetsReply? BulkCreateNasFilesets
        // GraphQL -> bulkCreateNasFilesets: BulkCreateNasFilesetsReply! (type)
        public static string BulkCreateNasFilesets(
            ref BulkCreateNasFilesetsReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BulkCreateNasFilesetsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "bulkCreateNasFilesets" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? BulkCreateOnDemandMssqlBackup
        // GraphQL -> bulkCreateOnDemandMssqlBackup: AsyncRequestStatus! (type)
        public static string BulkCreateOnDemandMssqlBackup(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "bulkCreateOnDemandMssqlBackup" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BulkDeleteAwsCloudAccountWithoutCftReply? BulkDeleteAwsCloudAccountWithoutCft
        // GraphQL -> bulkDeleteAwsCloudAccountWithoutCft: BulkDeleteAwsCloudAccountWithoutCftReply! (type)
        public static string BulkDeleteAwsCloudAccountWithoutCft(
            ref BulkDeleteAwsCloudAccountWithoutCftReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BulkDeleteAwsCloudAccountWithoutCftReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "bulkDeleteAwsCloudAccountWithoutCft" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> MosaicAsyncResponse? BulkDeleteCassandraSources
        // GraphQL -> bulkDeleteCassandraSources: MosaicAsyncResponse! (type)
        public static string BulkDeleteCassandraSources(
            ref MosaicAsyncResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new MosaicAsyncResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "bulkDeleteCassandraSources" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ResponseSuccess? BulkDeleteFailoverCluster
        // GraphQL -> bulkDeleteFailoverCluster: ResponseSuccess! (type)
        public static string BulkDeleteFailoverCluster(
            ref ResponseSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ResponseSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "bulkDeleteFailoverCluster" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ResponseSuccess? BulkDeleteFailoverClusterApp
        // GraphQL -> bulkDeleteFailoverClusterApp: ResponseSuccess! (type)
        public static string BulkDeleteFailoverClusterApp(
            ref ResponseSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ResponseSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "bulkDeleteFailoverClusterApp" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ResponseSuccess? BulkDeleteFileset
        // GraphQL -> bulkDeleteFileset: ResponseSuccess! (type)
        public static string BulkDeleteFileset(
            ref ResponseSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ResponseSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "bulkDeleteFileset" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ResponseSuccess? BulkDeleteFilesetTemplate
        // GraphQL -> bulkDeleteFilesetTemplate: ResponseSuccess! (type)
        public static string BulkDeleteFilesetTemplate(
            ref ResponseSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ResponseSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "bulkDeleteFilesetTemplate" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ResponseSuccess? BulkDeleteHost
        // GraphQL -> bulkDeleteHost: ResponseSuccess! (type)
        public static string BulkDeleteHost(
            ref ResponseSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ResponseSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "bulkDeleteHost" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> MosaicAsyncResponse? BulkDeleteMongodbSources
        // GraphQL -> bulkDeleteMongodbSources: MosaicAsyncResponse! (type)
        public static string BulkDeleteMongodbSources(
            ref MosaicAsyncResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new MosaicAsyncResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "bulkDeleteMongodbSources" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchAsyncRequestStatus? BulkDeleteNasSystems
        // GraphQL -> bulkDeleteNasSystems: BatchAsyncRequestStatus! (type)
        public static string BulkDeleteNasSystems(
            ref BatchAsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchAsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "bulkDeleteNasSystems" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BulkOnDemandSnapshotNutanixVmReply? BulkOnDemandSnapshotNutanixVm
        // GraphQL -> bulkOnDemandSnapshotNutanixVm: BulkOnDemandSnapshotNutanixVmReply! (type)
        public static string BulkOnDemandSnapshotNutanixVm(
            ref BulkOnDemandSnapshotNutanixVmReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BulkOnDemandSnapshotNutanixVmReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "bulkOnDemandSnapshotNutanixVm" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BulkRefreshHostsReply? BulkRefreshHosts
        // GraphQL -> bulkRefreshHosts: BulkRefreshHostsReply! (type)
        public static string BulkRefreshHosts(
            ref BulkRefreshHostsReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BulkRefreshHostsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "bulkRefreshHosts" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BulkRegisterHostReply? BulkRegisterHost
        // GraphQL -> bulkRegisterHost: BulkRegisterHostReply! (type)
        public static string BulkRegisterHost(
            ref BulkRegisterHostReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BulkRegisterHostReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "bulkRegisterHost" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? BulkTierExistingSnapshots
        // GraphQL -> bulkTierExistingSnapshots: AsyncRequestStatus! (type)
        public static string BulkTierExistingSnapshots(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "bulkTierExistingSnapshots" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> V1BulkUpdateExchangeDagResponse? BulkUpdateExchangeDag
        // GraphQL -> bulkUpdateExchangeDag: V1BulkUpdateExchangeDagResponse! (type)
        public static string BulkUpdateExchangeDag(
            ref V1BulkUpdateExchangeDagResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new V1BulkUpdateExchangeDagResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "bulkUpdateExchangeDag" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BulkUpdateFilesetTemplateReply? BulkUpdateFilesetTemplate
        // GraphQL -> bulkUpdateFilesetTemplate: BulkUpdateFilesetTemplateReply! (type)
        public static string BulkUpdateFilesetTemplate(
            ref BulkUpdateFilesetTemplateReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BulkUpdateFilesetTemplateReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "bulkUpdateFilesetTemplate" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BulkUpdateHostReply? BulkUpdateHost
        // GraphQL -> bulkUpdateHost: BulkUpdateHostReply! (type)
        public static string BulkUpdateHost(
            ref BulkUpdateHostReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BulkUpdateHostReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "bulkUpdateHost" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BulkUpdateMssqlDbsReply? BulkUpdateMssqlDbs
        // GraphQL -> bulkUpdateMssqlDbs: BulkUpdateMssqlDbsReply! (type)
        public static string BulkUpdateMssqlDbs(
            ref BulkUpdateMssqlDbsReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BulkUpdateMssqlDbsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "bulkUpdateMssqlDbs" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BulkUpdateOracleDatabasesReply? BulkUpdateOracleDatabases
        // GraphQL -> bulkUpdateOracleDatabases: BulkUpdateOracleDatabasesReply! (type)
        public static string BulkUpdateOracleDatabases(
            ref BulkUpdateOracleDatabasesReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BulkUpdateOracleDatabasesReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "bulkUpdateOracleDatabases" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BulkUpdateOracleHostsReply? BulkUpdateOracleHosts
        // GraphQL -> bulkUpdateOracleHosts: BulkUpdateOracleHostsReply! (type)
        public static string BulkUpdateOracleHosts(
            ref BulkUpdateOracleHostsReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BulkUpdateOracleHostsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "bulkUpdateOracleHosts" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BulkUpdateOracleRacsReply? BulkUpdateOracleRacs
        // GraphQL -> bulkUpdateOracleRacs: BulkUpdateOracleRacsReply! (type)
        public static string BulkUpdateOracleRacs(
            ref BulkUpdateOracleRacsReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BulkUpdateOracleRacsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "bulkUpdateOracleRacs" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CancelJobReply? CancelDownloadPackage
        // GraphQL -> cancelDownloadPackage: CancelJobReply! (type)
        public static string CancelDownloadPackage(
            ref CancelJobReply? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CancelJobReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "cancelDownloadPackage" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CancelJobReply? CancelScheduledUpgrade
        // GraphQL -> cancelScheduledUpgrade: CancelJobReply! (type)
        public static string CancelScheduledUpgrade(
            ref CancelJobReply? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CancelJobReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "cancelScheduledUpgrade" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestStatus? CancelTaskchain
        // GraphQL -> cancelTaskchain: RequestStatus! (type)
        public static string CancelTaskchain(
            ref RequestStatus? fieldSpec
        )
        {
            string args = "\n(\ntaskchainId: $taskchainId\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "cancelTaskchain" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ChangeVfdOnHostReply? ChangeVfdOnHost
        // GraphQL -> changeVfdOnHost: ChangeVfdOnHostReply! (type)
        public static string ChangeVfdOnHost(
            ref ChangeVfdOnHostReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ChangeVfdOnHostReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "changeVfdOnHost" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ClearCloudNativeSqlServerBackupCredentialsReply? ClearCloudNativeSqlServerBackupCredentials
        // GraphQL -> clearCloudNativeSqlServerBackupCredentials: ClearCloudNativeSqlServerBackupCredentialsReply! (type)
        public static string ClearCloudNativeSqlServerBackupCredentials(
            ref ClearCloudNativeSqlServerBackupCredentialsReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ClearCloudNativeSqlServerBackupCredentialsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "clearCloudNativeSqlServerBackupCredentials" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CloudNativeCheckRbaConnectivityReply? CloudNativeCheckRbaConnectivity
        // GraphQL -> cloudNativeCheckRbaConnectivity: CloudNativeCheckRbaConnectivityReply! (type)
        public static string CloudNativeCheckRbaConnectivity(
            ref CloudNativeCheckRbaConnectivityReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CloudNativeCheckRbaConnectivityReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "cloudNativeCheckRbaConnectivity" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> DownloadFilesReply? CloudNativeDownloadFiles
        // GraphQL -> cloudNativeDownloadFiles: DownloadFilesReply! (type)
        public static string CloudNativeDownloadFiles(
            ref DownloadFilesReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new DownloadFilesReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "cloudNativeDownloadFiles" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CompleteAzureCloudAccountOauthReply? CompleteAzureCloudAccountOauth
        // GraphQL -> completeAzureCloudAccountOauth: CompleteAzureCloudAccountOauthReply! (type)
        public static string CompleteAzureCloudAccountOauth(
            ref CompleteAzureCloudAccountOauthReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CompleteAzureCloudAccountOauthReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "completeAzureCloudAccountOauth" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? ConfigureSapHanaRestore
        // GraphQL -> configureSapHanaRestore: AsyncRequestStatus! (type)
        public static string ConfigureSapHanaRestore(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "configureSapHanaRestore" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> TargetMapping? CreateAutomaticAwsTargetMapping
        // GraphQL -> createAutomaticAwsTargetMapping: TargetMapping! (type)
        public static string CreateAutomaticAwsTargetMapping(
            ref TargetMapping? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new TargetMapping() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createAutomaticAwsTargetMapping" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> TargetMapping? CreateAutomaticAzureTargetMapping
        // GraphQL -> createAutomaticAzureTargetMapping: TargetMapping! (type)
        public static string CreateAutomaticAzureTargetMapping(
            ref TargetMapping? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new TargetMapping() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createAutomaticAzureTargetMapping" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> TargetMapping? CreateAutomaticRcsTargetMapping
        // GraphQL -> createAutomaticRcsTargetMapping: TargetMapping! (type)
        public static string CreateAutomaticRcsTargetMapping(
            ref TargetMapping? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new TargetMapping() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createAutomaticRcsTargetMapping" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CcProvisionJobReply? CreateAwsCluster
        // GraphQL -> createAwsCluster: CcProvisionJobReply! (type)
        public static string CreateAwsCluster(
            ref CcProvisionJobReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CcProvisionJobReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createAwsCluster" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AwsComputeSettings? CreateAwsComputeSetting
        // GraphQL -> createAwsComputeSetting: AwsComputeSettings! (type)
        public static string CreateAwsComputeSetting(
            ref AwsComputeSettings? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AwsComputeSettings() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createAwsComputeSetting" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateAwsExocomputeConfigsReply? CreateAwsExocomputeConfigs
        // GraphQL -> createAwsExocomputeConfigs: CreateAwsExocomputeConfigsReply! (type)
        public static string CreateAwsExocomputeConfigs(
            ref CreateAwsExocomputeConfigsReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateAwsExocomputeConfigsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createAwsExocomputeConfigs" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CcProvisionJobReply? CreateAzureCluster
        // GraphQL -> createAzureCluster: CcProvisionJobReply! (type)
        public static string CreateAzureCluster(
            ref CcProvisionJobReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CcProvisionJobReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createAzureCluster" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateAzureSaasAppAadReply? CreateAzureSaasAppAad
        // GraphQL -> createAzureSaasAppAad: CreateAzureSaasAppAadReply! (type)
        public static string CreateAzureSaasAppAad(
            ref CreateAzureSaasAppAadReply? fieldSpec
        )
        {
            string args = "";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateAzureSaasAppAadReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createAzureSaasAppAad" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> MosaicAsyncResponse? CreateCassandraSource
        // GraphQL -> createCassandraSource: MosaicAsyncResponse! (type)
        public static string CreateCassandraSource(
            ref MosaicAsyncResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new MosaicAsyncResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createCassandraSource" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateCloudNativeAwsStorageSettingReply? CreateCloudNativeAwsStorageSetting
        // GraphQL -> createCloudNativeAwsStorageSetting: CreateCloudNativeAwsStorageSettingReply! (type)
        public static string CreateCloudNativeAwsStorageSetting(
            ref CreateCloudNativeAwsStorageSettingReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateCloudNativeAwsStorageSettingReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createCloudNativeAwsStorageSetting" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateCloudNativeAzureStorageSettingReply? CreateCloudNativeAzureStorageSetting
        // GraphQL -> createCloudNativeAzureStorageSetting: CreateCloudNativeAzureStorageSettingReply! (type)
        public static string CreateCloudNativeAzureStorageSetting(
            ref CreateCloudNativeAzureStorageSettingReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateCloudNativeAzureStorageSettingReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createCloudNativeAzureStorageSetting" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateCloudNativeLabelRuleReply? CreateCloudNativeLabelRule
        // GraphQL -> createCloudNativeLabelRule: CreateCloudNativeLabelRuleReply! (type)
        public static string CreateCloudNativeLabelRule(
            ref CreateCloudNativeLabelRuleReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateCloudNativeLabelRuleReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createCloudNativeLabelRule" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateCloudNativeRcvAzureStorageSettingReply? CreateCloudNativeRcvAzureStorageSetting
        // GraphQL -> createCloudNativeRcvAzureStorageSetting: CreateCloudNativeRcvAzureStorageSettingReply! (type)
        public static string CreateCloudNativeRcvAzureStorageSetting(
            ref CreateCloudNativeRcvAzureStorageSettingReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateCloudNativeRcvAzureStorageSettingReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createCloudNativeRcvAzureStorageSetting" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateCloudNativeTagRuleReply? CreateCloudNativeTagRule
        // GraphQL -> createCloudNativeTagRule: CreateCloudNativeTagRuleReply! (type)
        public static string CreateCloudNativeTagRule(
            ref CreateCloudNativeTagRuleReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateCloudNativeTagRuleReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createCloudNativeTagRule" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Analyzer? CreateCustomAnalyzer
        // GraphQL -> createCustomAnalyzer: Analyzer! (type)
        public static string CreateCustomAnalyzer(
            ref Analyzer? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new Analyzer() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createCustomAnalyzer" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateCustomReportReply? CreateCustomReport
        // GraphQL -> createCustomReport: CreateCustomReportReply! (type)
        public static string CreateCustomReport(
            ref CreateCustomReportReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\nreportRoom: $reportRoom\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateCustomReportReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createCustomReport" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? CreateDownloadSnapshotForVolumeGroup
        // GraphQL -> createDownloadSnapshotForVolumeGroup: AsyncRequestStatus! (type)
        public static string CreateDownloadSnapshotForVolumeGroup(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createDownloadSnapshotForVolumeGroup" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? CreateExchangeMount
        // GraphQL -> createExchangeMount: AsyncRequestStatus! (type)
        public static string CreateExchangeMount(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createExchangeMount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateFailoverClusterReply? CreateFailoverCluster
        // GraphQL -> createFailoverCluster: CreateFailoverClusterReply! (type)
        public static string CreateFailoverCluster(
            ref CreateFailoverClusterReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateFailoverClusterReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createFailoverCluster" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateFailoverClusterAppReply? CreateFailoverClusterApp
        // GraphQL -> createFailoverClusterApp: CreateFailoverClusterAppReply! (type)
        public static string CreateFailoverClusterApp(
            ref CreateFailoverClusterAppReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateFailoverClusterAppReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createFailoverClusterApp" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? CreateFilesetSnapshot
        // GraphQL -> createFilesetSnapshot: AsyncRequestStatus! (type)
        public static string CreateFilesetSnapshot(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createFilesetSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> GlobalSlaReply? CreateGlobalSla
        // GraphQL -> createGlobalSla: GlobalSlaReply! (type)
        public static string CreateGlobalSla(
            ref GlobalSlaReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new GlobalSlaReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createGlobalSla" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateGuestCredentialReply? CreateGuestCredential
        // GraphQL -> createGuestCredential: CreateGuestCredentialReply! (type)
        public static string CreateGuestCredential(
            ref CreateGuestCredentialReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateGuestCredentialReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createGuestCredential" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? CreateHypervVirtualMachineSnapshotMount
        // GraphQL -> createHypervVirtualMachineSnapshotMount: AsyncRequestStatus! (type)
        public static string CreateHypervVirtualMachineSnapshotMount(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createHypervVirtualMachineSnapshotMount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateIntegrationReply? CreateIntegration
        // GraphQL -> createIntegration: CreateIntegrationReply! (type)
        public static string CreateIntegration(
            ref CreateIntegrationReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateIntegrationReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createIntegration" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateIntegrationsReply? CreateIntegrations
        // GraphQL -> createIntegrations: CreateIntegrationsReply! (type)
        public static string CreateIntegrations(
            ref CreateIntegrationsReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateIntegrationsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createIntegrations" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateK8sAgentManifestReply? CreateK8sAgentManifest
        // GraphQL -> createK8sAgentManifest: CreateK8sAgentManifestReply! (type)
        public static string CreateK8sAgentManifest(
            ref CreateK8sAgentManifestReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateK8sAgentManifestReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createK8sAgentManifest" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateK8sClusterReply? CreateK8sCluster
        // GraphQL -> createK8sCluster: CreateK8sClusterReply! (type)
        public static string CreateK8sCluster(
            ref CreateK8sClusterReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateK8sClusterReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createK8sCluster" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> List<CreateOnDemandJobReply>? CreateK8sNamespaceSnapshots
        // GraphQL -> createK8sNamespaceSnapshots: [CreateOnDemandJobReply!]! (type)
        public static string CreateK8sNamespaceSnapshots(
            ref List<CreateOnDemandJobReply>? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new List<CreateOnDemandJobReply>() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createK8sNamespaceSnapshots" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> TargetMapping? CreateManualTargetMapping
        // GraphQL -> createManualTargetMapping: TargetMapping! (type)
        public static string CreateManualTargetMapping(
            ref TargetMapping? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new TargetMapping() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createManualTargetMapping" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> MosaicAsyncResponse? CreateMongodbSource
        // GraphQL -> createMongodbSource: MosaicAsyncResponse! (type)
        public static string CreateMongodbSource(
            ref MosaicAsyncResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new MosaicAsyncResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createMongodbSource" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? CreateMssqlLiveMount
        // GraphQL -> createMssqlLiveMount: AsyncRequestStatus! (type)
        public static string CreateMssqlLiveMount(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createMssqlLiveMount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? CreateMssqlLogShippingConfiguration
        // GraphQL -> createMssqlLogShippingConfiguration: AsyncRequestStatus! (type)
        public static string CreateMssqlLogShippingConfiguration(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createMssqlLogShippingConfiguration" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? CreateNutanixCluster
        // GraphQL -> createNutanixCluster: AsyncRequestStatus! (type)
        public static string CreateNutanixCluster(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createNutanixCluster" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchAsyncRequestStatus? CreateNutanixPrismCentral
        // GraphQL -> createNutanixPrismCentral: BatchAsyncRequestStatus! (type)
        public static string CreateNutanixPrismCentral(
            ref BatchAsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchAsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createNutanixPrismCentral" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestStatus? CreateO365AppComplete
        // GraphQL -> createO365AppComplete: RequestStatus! (type)
        public static string CreateO365AppComplete(
            ref RequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createO365AppComplete" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateO365AppKickoffResp? CreateO365AppKickoff
        // GraphQL -> createO365AppKickoff: CreateO365AppKickoffResp! (type)
        public static string CreateO365AppKickoff(
            ref CreateO365AppKickoffResp? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateO365AppKickoffResp() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createO365AppKickoff" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandDb2Backup
        // GraphQL -> createOnDemandDb2Backup: AsyncRequestStatus! (type)
        public static string CreateOnDemandDb2Backup(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createOnDemandDb2Backup" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandExchangeBackup
        // GraphQL -> createOnDemandExchangeBackup: AsyncRequestStatus! (type)
        public static string CreateOnDemandExchangeBackup(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createOnDemandExchangeBackup" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandMssqlBackup
        // GraphQL -> createOnDemandMssqlBackup: AsyncRequestStatus! (type)
        public static string CreateOnDemandMssqlBackup(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createOnDemandMssqlBackup" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandNutanixBackup
        // GraphQL -> createOnDemandNutanixBackup: AsyncRequestStatus! (type)
        public static string CreateOnDemandNutanixBackup(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createOnDemandNutanixBackup" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandSapHanaBackup
        // GraphQL -> createOnDemandSapHanaBackup: AsyncRequestStatus! (type)
        public static string CreateOnDemandSapHanaBackup(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createOnDemandSapHanaBackup" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandVolumeGroupBackup
        // GraphQL -> createOnDemandVolumeGroupBackup: AsyncRequestStatus! (type)
        public static string CreateOnDemandVolumeGroupBackup(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createOnDemandVolumeGroupBackup" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? CreateOraclePdbRestore
        // GraphQL -> createOraclePdbRestore: AsyncRequestStatus! (type)
        public static string CreateOraclePdbRestore(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createOraclePdbRestore" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateOrgReply? CreateOrg
        // GraphQL -> createOrg: CreateOrgReply! (type)
        public static string CreateOrg(
            ref CreateOrgReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateOrgReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createOrg" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateOrgSwitchSessionReply? CreateOrgSwitchSession
        // GraphQL -> createOrgSwitchSession: CreateOrgSwitchSessionReply! (type)
        public static string CreateOrgSwitchSession(
            ref CreateOrgSwitchSessionReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateOrgSwitchSessionReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createOrgSwitchSession" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ClassificationPolicyDetail? CreatePolicy
        // GraphQL -> createPolicy: ClassificationPolicyDetail! (type)
        public static string CreatePolicy(
            ref ClassificationPolicyDetail? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ClassificationPolicyDetail() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createPolicy" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateRcvPrivateEndpointApprovalRequestReply? CreateRcvPrivateEndpointApprovalRequest
        // GraphQL -> createRcvPrivateEndpointApprovalRequest: CreateRcvPrivateEndpointApprovalRequestReply! (type)
        public static string CreateRcvPrivateEndpointApprovalRequest(
            ref CreateRcvPrivateEndpointApprovalRequestReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateRcvPrivateEndpointApprovalRequestReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createRcvPrivateEndpointApprovalRequest" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? CreateSapHanaSystemRefresh
        // GraphQL -> createSapHanaSystemRefresh: AsyncRequestStatus! (type)
        public static string CreateSapHanaSystemRefresh(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createSapHanaSystemRefresh" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateScheduledReportReply? CreateScheduledReport
        // GraphQL -> createScheduledReport: CreateScheduledReportReply! (type)
        public static string CreateScheduledReport(
            ref CreateScheduledReportReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateScheduledReportReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createScheduledReport" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateServiceAccountReply? CreateServiceAccount
        // GraphQL -> createServiceAccount: CreateServiceAccountReply! (type)
        public static string CreateServiceAccount(
            ref CreateServiceAccountReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateServiceAccountReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createServiceAccount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateVappsInstantRecoveryReply? CreateVappsInstantRecovery
        // GraphQL -> createVappsInstantRecovery: CreateVappsInstantRecoveryReply! (type)
        public static string CreateVappsInstantRecovery(
            ref CreateVappsInstantRecoveryReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateVappsInstantRecoveryReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createVappsInstantRecovery" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateVsphereAdvancedTagReply? CreateVsphereAdvancedTag
        // GraphQL -> createVsphereAdvancedTag: CreateVsphereAdvancedTagReply! (type)
        public static string CreateVsphereAdvancedTag(
            ref CreateVsphereAdvancedTagReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateVsphereAdvancedTagReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createVsphereAdvancedTag" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateVsphereVcenterReply? CreateVsphereVcenter
        // GraphQL -> createVsphereVcenter: CreateVsphereVcenterReply! (type)
        public static string CreateVsphereVcenter(
            ref CreateVsphereVcenterReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateVsphereVcenterReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createVsphereVcenter" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateWebhookReply? CreateWebhook
        // GraphQL -> createWebhook: CreateWebhookReply! (type)
        public static string CreateWebhook(
            ref CreateWebhookReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateWebhookReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "createWebhook" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestStatus? DeleteAdGroupsFromHierarchy
        // GraphQL -> deleteAdGroupsFromHierarchy: RequestStatus! (type)
        public static string DeleteAdGroupsFromHierarchy(
            ref RequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteAdGroupsFromHierarchy" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CcProvisionJobReply? DeleteAwsCluster
        // GraphQL -> deleteAwsCluster: CcProvisionJobReply! (type)
        public static string DeleteAwsCluster(
            ref CcProvisionJobReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CcProvisionJobReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteAwsCluster" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> DeleteAwsExocomputeConfigsReply? DeleteAwsExocomputeConfigs
        // GraphQL -> deleteAwsExocomputeConfigs: DeleteAwsExocomputeConfigsReply! (type)
        public static string DeleteAwsExocomputeConfigs(
            ref DeleteAwsExocomputeConfigsReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new DeleteAwsExocomputeConfigsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteAwsExocomputeConfigs" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> DeleteAzureCloudAccountReply? DeleteAzureCloudAccount
        // GraphQL -> deleteAzureCloudAccount: DeleteAzureCloudAccountReply! (type)
        public static string DeleteAzureCloudAccount(
            ref DeleteAzureCloudAccountReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new DeleteAzureCloudAccountReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteAzureCloudAccount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> DeleteAzureCloudAccountExocomputeConfigurationsReply? DeleteAzureCloudAccountExocomputeConfigurations
        // GraphQL -> deleteAzureCloudAccountExocomputeConfigurations: DeleteAzureCloudAccountExocomputeConfigurationsReply! (type)
        public static string DeleteAzureCloudAccountExocomputeConfigurations(
            ref DeleteAzureCloudAccountExocomputeConfigurationsReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new DeleteAzureCloudAccountExocomputeConfigurationsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteAzureCloudAccountExocomputeConfigurations" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> DeleteAzureCloudAccountWithoutOauthReply? DeleteAzureCloudAccountWithoutOauth
        // GraphQL -> deleteAzureCloudAccountWithoutOauth: DeleteAzureCloudAccountWithoutOauthReply! (type)
        public static string DeleteAzureCloudAccountWithoutOauth(
            ref DeleteAzureCloudAccountWithoutOauthReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new DeleteAzureCloudAccountWithoutOauthReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteAzureCloudAccountWithoutOauth" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CcProvisionJobReply? DeleteAzureCluster
        // GraphQL -> deleteAzureCluster: CcProvisionJobReply! (type)
        public static string DeleteAzureCluster(
            ref CcProvisionJobReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CcProvisionJobReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteAzureCluster" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> MosaicAsyncResponse? DeleteCassandraSource
        // GraphQL -> deleteCassandraSource: MosaicAsyncResponse! (type)
        public static string DeleteCassandraSource(
            ref MosaicAsyncResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new MosaicAsyncResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteCassandraSource" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DeleteDb2Database
        // GraphQL -> deleteDb2Database: AsyncRequestStatus! (type)
        public static string DeleteDb2Database(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteDb2Database" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DeleteDb2Instance
        // GraphQL -> deleteDb2Instance: AsyncRequestStatus! (type)
        public static string DeleteDb2Instance(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteDb2Instance" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DeleteExchangeSnapshotMount
        // GraphQL -> deleteExchangeSnapshotMount: AsyncRequestStatus! (type)
        public static string DeleteExchangeSnapshotMount(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteExchangeSnapshotMount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ResponseSuccess? DeleteFailoverCluster
        // GraphQL -> deleteFailoverCluster: ResponseSuccess! (type)
        public static string DeleteFailoverCluster(
            ref ResponseSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ResponseSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteFailoverCluster" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ResponseSuccess? DeleteFailoverClusterApp
        // GraphQL -> deleteFailoverClusterApp: ResponseSuccess! (type)
        public static string DeleteFailoverClusterApp(
            ref ResponseSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ResponseSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteFailoverClusterApp" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ResponseSuccess? DeleteFilesetSnapshots
        // GraphQL -> deleteFilesetSnapshots: ResponseSuccess! (type)
        public static string DeleteFilesetSnapshots(
            ref ResponseSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ResponseSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteFilesetSnapshots" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestSuccess? DeleteHypervVirtualMachineSnapshot
        // GraphQL -> deleteHypervVirtualMachineSnapshot: RequestSuccess! (type)
        public static string DeleteHypervVirtualMachineSnapshot(
            ref RequestSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteHypervVirtualMachineSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DeleteHypervVirtualMachineSnapshotMount
        // GraphQL -> deleteHypervVirtualMachineSnapshotMount: AsyncRequestStatus! (type)
        public static string DeleteHypervVirtualMachineSnapshotMount(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteHypervVirtualMachineSnapshotMount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DeleteLogShipping
        // GraphQL -> deleteLogShipping: AsyncRequestStatus! (type)
        public static string DeleteLogShipping(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteLogShipping" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> DeleteManagedVolumeReply? DeleteManagedVolume
        // GraphQL -> deleteManagedVolume: DeleteManagedVolumeReply! (type)
        public static string DeleteManagedVolume(
            ref DeleteManagedVolumeReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new DeleteManagedVolumeReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteManagedVolume" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DeleteManagedVolumeSnapshotExport
        // GraphQL -> deleteManagedVolumeSnapshotExport: AsyncRequestStatus! (type)
        public static string DeleteManagedVolumeSnapshotExport(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteManagedVolumeSnapshotExport" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DeleteMongoSource
        // GraphQL -> deleteMongoSource: AsyncRequestStatus! (type)
        public static string DeleteMongoSource(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteMongoSource" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> MosaicAsyncResponse? DeleteMongodbSource
        // GraphQL -> deleteMongodbSource: MosaicAsyncResponse! (type)
        public static string DeleteMongodbSource(
            ref MosaicAsyncResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new MosaicAsyncResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteMongodbSource" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> MosaicAsyncResponse? DeleteMosaicStore
        // GraphQL -> deleteMosaicStore: MosaicAsyncResponse! (type)
        public static string DeleteMosaicStore(
            ref MosaicAsyncResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new MosaicAsyncResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteMosaicStore" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ResponseSuccess? DeleteMssqlDbSnapshots
        // GraphQL -> deleteMssqlDbSnapshots: ResponseSuccess! (type)
        public static string DeleteMssqlDbSnapshots(
            ref ResponseSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ResponseSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteMssqlDbSnapshots" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DeleteMssqlLiveMount
        // GraphQL -> deleteMssqlLiveMount: AsyncRequestStatus! (type)
        public static string DeleteMssqlLiveMount(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteMssqlLiveMount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DeleteNasSystem
        // GraphQL -> deleteNasSystem: AsyncRequestStatus! (type)
        public static string DeleteNasSystem(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteNasSystem" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DeleteNutanixCluster
        // GraphQL -> deleteNutanixCluster: AsyncRequestStatus! (type)
        public static string DeleteNutanixCluster(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteNutanixCluster" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DeleteNutanixMountV1
        // GraphQL -> deleteNutanixMountV1: AsyncRequestStatus! (type)
        public static string DeleteNutanixMountV1(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteNutanixMountV1" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchAsyncRequestStatus? DeleteNutanixPrismCentral
        // GraphQL -> deleteNutanixPrismCentral: BatchAsyncRequestStatus! (type)
        public static string DeleteNutanixPrismCentral(
            ref BatchAsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchAsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteNutanixPrismCentral" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestSuccess? DeleteNutanixSnapshot
        // GraphQL -> deleteNutanixSnapshot: RequestSuccess! (type)
        public static string DeleteNutanixSnapshot(
            ref RequestSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteNutanixSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestSuccess? DeleteNutanixSnapshots
        // GraphQL -> deleteNutanixSnapshots: RequestSuccess! (type)
        public static string DeleteNutanixSnapshots(
            ref RequestSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteNutanixSnapshots" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestStatus? DeleteO365AzureApp
        // GraphQL -> deleteO365AzureApp: RequestStatus! (type)
        public static string DeleteO365AzureApp(
            ref RequestStatus? fieldSpec
        )
        {
            string args = "\n(\no365AppClientId: $o365AppClientId\no365AppType: $o365AppType\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteO365AzureApp" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateOnDemandJobReply? DeleteO365Org
        // GraphQL -> deleteO365Org: CreateOnDemandJobReply! (type)
        public static string DeleteO365Org(
            ref CreateOnDemandJobReply? fieldSpec
        )
        {
            string args = "\n(\norgId: $orgId\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateOnDemandJobReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteO365Org" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestStatus? DeleteO365ServiceAccount
        // GraphQL -> deleteO365ServiceAccount: RequestStatus! (type)
        public static string DeleteO365ServiceAccount(
            ref RequestStatus? fieldSpec
        )
        {
            string args = "\n(\norgId: $orgId\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteO365ServiceAccount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DeleteOracleMount
        // GraphQL -> deleteOracleMount: AsyncRequestStatus! (type)
        public static string DeleteOracleMount(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteOracleMount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ResponseSuccess? DeleteSapHanaDbSnapshot
        // GraphQL -> deleteSapHanaDbSnapshot: ResponseSuccess! (type)
        public static string DeleteSapHanaDbSnapshot(
            ref ResponseSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ResponseSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteSapHanaDbSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DeleteSapHanaSystem
        // GraphQL -> deleteSapHanaSystem: AsyncRequestStatus! (type)
        public static string DeleteSapHanaSystem(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteSapHanaSystem" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> DeleteStorageArraysReply? DeleteStorageArrays
        // GraphQL -> deleteStorageArrays: DeleteStorageArraysReply! (type)
        public static string DeleteStorageArrays(
            ref DeleteStorageArraysReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new DeleteStorageArraysReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteStorageArrays" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DeleteVolumeGroupMount
        // GraphQL -> deleteVolumeGroupMount: AsyncRequestStatus! (type)
        public static string DeleteVolumeGroupMount(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteVolumeGroupMount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestSuccess? DeleteVsphereAdvancedTag
        // GraphQL -> deleteVsphereAdvancedTag: RequestSuccess! (type)
        public static string DeleteVsphereAdvancedTag(
            ref RequestSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteVsphereAdvancedTag" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DeleteVsphereLiveMount
        // GraphQL -> deleteVsphereLiveMount: AsyncRequestStatus! (type)
        public static string DeleteVsphereLiveMount(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "deleteVsphereLiveMount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ResponseSuccess? DisableReplicationPause
        // GraphQL -> disableReplicationPause: ResponseSuccess! (type)
        public static string DisableReplicationPause(
            ref ResponseSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ResponseSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "disableReplicationPause" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> DisableTargetReply? DisableTarget
        // GraphQL -> disableTarget: DisableTargetReply! (type)
        public static string DisableTarget(
            ref DisableTargetReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new DisableTargetReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "disableTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DiscoverDb2Instance
        // GraphQL -> discoverDb2Instance: AsyncRequestStatus! (type)
        public static string DiscoverDb2Instance(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "discoverDb2Instance" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DiscoverMongoSource
        // GraphQL -> discoverMongoSource: AsyncRequestStatus! (type)
        public static string DiscoverMongoSource(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "discoverMongoSource" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncDownloadReply? DownloadAuditLogCsvAsync
        // GraphQL -> downloadAuditLogCsvAsync: AsyncDownloadReply! (type)
        public static string DownloadAuditLogCsvAsync(
            ref AsyncDownloadReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncDownloadReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadAuditLogCsvAsync" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DownloadDb2Snapshot
        // GraphQL -> downloadDb2Snapshot: AsyncRequestStatus! (type)
        public static string DownloadDb2Snapshot(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadDb2Snapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DownloadDb2SnapshotsForPointInTimeRecovery
        // GraphQL -> downloadDb2SnapshotsForPointInTimeRecovery: AsyncRequestStatus! (type)
        public static string DownloadDb2SnapshotsForPointInTimeRecovery(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadDb2SnapshotsForPointInTimeRecovery" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DownloadExchangeSnapshot
        // GraphQL -> downloadExchangeSnapshot: AsyncRequestStatus! (type)
        public static string DownloadExchangeSnapshot(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadExchangeSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DownloadFilesNutanixSnapshot
        // GraphQL -> downloadFilesNutanixSnapshot: AsyncRequestStatus! (type)
        public static string DownloadFilesNutanixSnapshot(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadFilesNutanixSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DownloadFilesetSnapshot
        // GraphQL -> downloadFilesetSnapshot: AsyncRequestStatus! (type)
        public static string DownloadFilesetSnapshot(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadFilesetSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DownloadFilesetSnapshotFromLocation
        // GraphQL -> downloadFilesetSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string DownloadFilesetSnapshotFromLocation(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadFilesetSnapshotFromLocation" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DownloadHypervSnapshotFromLocation
        // GraphQL -> downloadHypervSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string DownloadHypervSnapshotFromLocation(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadHypervSnapshotFromLocation" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DownloadHypervVirtualMachineSnapshot
        // GraphQL -> downloadHypervVirtualMachineSnapshot: AsyncRequestStatus! (type)
        public static string DownloadHypervVirtualMachineSnapshot(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadHypervVirtualMachineSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DownloadHypervVirtualMachineSnapshotFiles
        // GraphQL -> downloadHypervVirtualMachineSnapshotFiles: AsyncRequestStatus! (type)
        public static string DownloadHypervVirtualMachineSnapshotFiles(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadHypervVirtualMachineSnapshotFiles" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DownloadManagedVolumeFiles
        // GraphQL -> downloadManagedVolumeFiles: AsyncRequestStatus! (type)
        public static string DownloadManagedVolumeFiles(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadManagedVolumeFiles" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DownloadManagedVolumeFromLocation
        // GraphQL -> downloadManagedVolumeFromLocation: AsyncRequestStatus! (type)
        public static string DownloadManagedVolumeFromLocation(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadManagedVolumeFromLocation" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DownloadMssqlDatabaseBackupFiles
        // GraphQL -> downloadMssqlDatabaseBackupFiles: AsyncRequestStatus! (type)
        public static string DownloadMssqlDatabaseBackupFiles(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadMssqlDatabaseBackupFiles" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DownloadMssqlDatabaseFilesFromArchivalLocation
        // GraphQL -> downloadMssqlDatabaseFilesFromArchivalLocation: AsyncRequestStatus! (type)
        public static string DownloadMssqlDatabaseFilesFromArchivalLocation(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadMssqlDatabaseFilesFromArchivalLocation" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DownloadNutanixSnapshot
        // GraphQL -> downloadNutanixSnapshot: AsyncRequestStatus! (type)
        public static string DownloadNutanixSnapshot(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadNutanixSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DownloadNutanixVmFromLocation
        // GraphQL -> downloadNutanixVmFromLocation: AsyncRequestStatus! (type)
        public static string DownloadNutanixVmFromLocation(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadNutanixVmFromLocation" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> DownloadCsvReply? DownloadObjectFilesCsv
        // GraphQL -> downloadObjectFilesCsv: DownloadCsvReply! (type)
        public static string DownloadObjectFilesCsv(
            ref DownloadCsvReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new DownloadCsvReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadObjectFilesCsv" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> DownloadCsvReply? DownloadObjectsListCsv
        // GraphQL -> downloadObjectsListCsv: DownloadCsvReply! (type)
        public static string DownloadObjectsListCsv(
            ref DownloadCsvReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new DownloadCsvReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadObjectsListCsv" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DownloadOracleDatabaseSnapshot
        // GraphQL -> downloadOracleDatabaseSnapshot: AsyncRequestStatus! (type)
        public static string DownloadOracleDatabaseSnapshot(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadOracleDatabaseSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncDownloadReply? DownloadReportCsvAsync
        // GraphQL -> downloadReportCsvAsync: AsyncDownloadReply! (type)
        public static string DownloadReportCsvAsync(
            ref AsyncDownloadReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncDownloadReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadReportCsvAsync" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncDownloadReply? DownloadReportPdfAsync
        // GraphQL -> downloadReportPdfAsync: AsyncDownloadReply! (type)
        public static string DownloadReportPdfAsync(
            ref AsyncDownloadReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncDownloadReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadReportPdfAsync" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> DownloadResultsCsvReply? DownloadResultsCsv
        // GraphQL -> downloadResultsCsv: DownloadResultsCsvReply! (type)
        public static string DownloadResultsCsv(
            ref DownloadResultsCsvReply? fieldSpec
        )
        {
            string args = "\n(\ncrawlId: $crawlId\ndownloadFilter: $downloadFilter\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new DownloadResultsCsvReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadResultsCsv" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DownloadSapHanaSnapshot
        // GraphQL -> downloadSapHanaSnapshot: AsyncRequestStatus! (type)
        public static string DownloadSapHanaSnapshot(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadSapHanaSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DownloadSapHanaSnapshotFromLocation
        // GraphQL -> downloadSapHanaSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string DownloadSapHanaSnapshotFromLocation(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadSapHanaSnapshotFromLocation" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DownloadSapHanaSnapshotsForPointInTimeRecovery
        // GraphQL -> downloadSapHanaSnapshotsForPointInTimeRecovery: AsyncRequestStatus! (type)
        public static string DownloadSapHanaSnapshotsForPointInTimeRecovery(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadSapHanaSnapshotsForPointInTimeRecovery" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> DownloadCsvReply? DownloadSnapshotResultsCsv
        // GraphQL -> downloadSnapshotResultsCsv: DownloadCsvReply! (type)
        public static string DownloadSnapshotResultsCsv(
            ref DownloadCsvReply? fieldSpec
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\ndownloadFilter: $downloadFilter\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new DownloadCsvReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadSnapshotResultsCsv" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> DownloadThreatHuntCsvReply? DownloadThreatHuntCsv
        // GraphQL -> downloadThreatHuntCsv: DownloadThreatHuntCsvReply! (type)
        public static string DownloadThreatHuntCsv(
            ref DownloadThreatHuntCsvReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new DownloadThreatHuntCsvReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadThreatHuntCsv" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> DownloadCsvReply? DownloadUserActivityCsv
        // GraphQL -> downloadUserActivityCsv: DownloadCsvReply! (type)
        public static string DownloadUserActivityCsv(
            ref DownloadCsvReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new DownloadCsvReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadUserActivityCsv" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> DownloadCsvReply? DownloadUserFileActivityCsv
        // GraphQL -> downloadUserFileActivityCsv: DownloadCsvReply! (type)
        public static string DownloadUserFileActivityCsv(
            ref DownloadCsvReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new DownloadCsvReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadUserFileActivityCsv" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DownloadVolumeGroupSnapshotFiles
        // GraphQL -> downloadVolumeGroupSnapshotFiles: AsyncRequestStatus! (type)
        public static string DownloadVolumeGroupSnapshotFiles(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadVolumeGroupSnapshotFiles" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DownloadVolumeGroupSnapshotFromLocation
        // GraphQL -> downloadVolumeGroupSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string DownloadVolumeGroupSnapshotFromLocation(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadVolumeGroupSnapshotFromLocation" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? DownloadVsphereVirtualMachineFiles
        // GraphQL -> downloadVsphereVirtualMachineFiles: AsyncRequestStatus! (type)
        public static string DownloadVsphereVirtualMachineFiles(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "downloadVsphereVirtualMachineFiles" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> EnableAutomaticFmdUploadReply? EnableAutomaticFmdUpload
        // GraphQL -> enableAutomaticFmdUpload: EnableAutomaticFmdUploadReply! (type)
        public static string EnableAutomaticFmdUpload(
            ref EnableAutomaticFmdUploadReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new EnableAutomaticFmdUploadReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "enableAutomaticFmdUpload" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> EnableDisableAppConsistencyReply? EnableDisableAppConsistency
        // GraphQL -> enableDisableAppConsistency: EnableDisableAppConsistencyReply! (type)
        public static string EnableDisableAppConsistency(
            ref EnableDisableAppConsistencyReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new EnableDisableAppConsistencyReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "enableDisableAppConsistency" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestStatus? EnableO365SharePoint
        // GraphQL -> enableO365SharePoint: RequestStatus! (type)
        public static string EnableO365SharePoint(
            ref RequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "enableO365SharePoint" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestStatus? EnableO365Teams
        // GraphQL -> enableO365Teams: RequestStatus! (type)
        public static string EnableO365Teams(
            ref RequestStatus? fieldSpec
        )
        {
            string args = "\n(\nexocomputeClusterId: $exocomputeClusterId\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "enableO365Teams" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ResponseSuccess? EnableReplicationPause
        // GraphQL -> enableReplicationPause: ResponseSuccess! (type)
        public static string EnableReplicationPause(
            ref ResponseSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ResponseSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "enableReplicationPause" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> EnableTargetReply? EnableTarget
        // GraphQL -> enableTarget: EnableTargetReply! (type)
        public static string EnableTarget(
            ref EnableTargetReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new EnableTargetReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "enableTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> EndManagedVolumeSnapshotReply? EndManagedVolumeSnapshot
        // GraphQL -> endManagedVolumeSnapshot: EndManagedVolumeSnapshotReply! (type)
        public static string EndManagedVolumeSnapshot(
            ref EndManagedVolumeSnapshotReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new EndManagedVolumeSnapshotReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "endManagedVolumeSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestSuccess? ExcludeVmDisks
        // GraphQL -> excludeVmDisks: RequestSuccess! (type)
        public static string ExcludeVmDisks(
            ref RequestSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "excludeVmDisks" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? ExpireDownloadedDb2Snapshots
        // GraphQL -> expireDownloadedDb2Snapshots: AsyncRequestStatus! (type)
        public static string ExpireDownloadedDb2Snapshots(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "expireDownloadedDb2Snapshots" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? ExpireDownloadedSapHanaSnapshots
        // GraphQL -> expireDownloadedSapHanaSnapshots: AsyncRequestStatus! (type)
        public static string ExpireDownloadedSapHanaSnapshots(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "expireDownloadedSapHanaSnapshots" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? ExportHypervVirtualMachine
        // GraphQL -> exportHypervVirtualMachine: AsyncRequestStatus! (type)
        public static string ExportHypervVirtualMachine(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "exportHypervVirtualMachine" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateOnDemandJobReply? ExportK8sNamespace
        // GraphQL -> exportK8sNamespace: CreateOnDemandJobReply! (type)
        public static string ExportK8sNamespace(
            ref CreateOnDemandJobReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateOnDemandJobReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "exportK8sNamespace" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? ExportManagedVolumeSnapshot
        // GraphQL -> exportManagedVolumeSnapshot: AsyncRequestStatus! (type)
        public static string ExportManagedVolumeSnapshot(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "exportManagedVolumeSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? ExportMssqlDatabase
        // GraphQL -> exportMssqlDatabase: AsyncRequestStatus! (type)
        public static string ExportMssqlDatabase(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "exportMssqlDatabase" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? ExportNutanixSnapshot
        // GraphQL -> exportNutanixSnapshot: AsyncRequestStatus! (type)
        public static string ExportNutanixSnapshot(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "exportNutanixSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateOnDemandJobReply? ExportO365Mailbox
        // GraphQL -> exportO365Mailbox: CreateOnDemandJobReply! (type)
        public static string ExportO365Mailbox(
            ref CreateOnDemandJobReply? fieldSpec
        )
        {
            string args = "\n(\nexportConfig: $exportConfig\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateOnDemandJobReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "exportO365Mailbox" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? ExportOracleDatabase
        // GraphQL -> exportOracleDatabase: AsyncRequestStatus! (type)
        public static string ExportOracleDatabase(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "exportOracleDatabase" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? ExportOracleTablespace
        // GraphQL -> exportOracleTablespace: AsyncRequestStatus! (type)
        public static string ExportOracleTablespace(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "exportOracleTablespace" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? ExportSlaManagedVolumeSnapshot
        // GraphQL -> exportSlaManagedVolumeSnapshot: AsyncRequestStatus! (type)
        public static string ExportSlaManagedVolumeSnapshot(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "exportSlaManagedVolumeSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? FilesetDownloadSnapshotFiles
        // GraphQL -> filesetDownloadSnapshotFiles: AsyncRequestStatus! (type)
        public static string FilesetDownloadSnapshotFiles(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "filesetDownloadSnapshotFiles" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? FilesetExportSnapshotFiles
        // GraphQL -> filesetExportSnapshotFiles: AsyncRequestStatus! (type)
        public static string FilesetExportSnapshotFiles(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "filesetExportSnapshotFiles" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? FilesetRecoverFiles
        // GraphQL -> filesetRecoverFiles: AsyncRequestStatus! (type)
        public static string FilesetRecoverFiles(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "filesetRecoverFiles" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> FinalizeAwsCloudAccountDeletionReply? FinalizeAwsCloudAccountDeletion
        // GraphQL -> finalizeAwsCloudAccountDeletion: FinalizeAwsCloudAccountDeletionReply! (type)
        public static string FinalizeAwsCloudAccountDeletion(
            ref FinalizeAwsCloudAccountDeletionReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new FinalizeAwsCloudAccountDeletionReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "finalizeAwsCloudAccountDeletion" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> FinalizeAwsCloudAccountProtectionReply? FinalizeAwsCloudAccountProtection
        // GraphQL -> finalizeAwsCloudAccountProtection: FinalizeAwsCloudAccountProtectionReply! (type)
        public static string FinalizeAwsCloudAccountProtection(
            ref FinalizeAwsCloudAccountProtectionReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new FinalizeAwsCloudAccountProtectionReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "finalizeAwsCloudAccountProtection" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> GcpCloudAccountAddProjectsReply? GcpCloudAccountAddProjects
        // GraphQL -> gcpCloudAccountAddProjects: GcpCloudAccountAddProjectsReply! (type)
        public static string GcpCloudAccountAddProjects(
            ref GcpCloudAccountAddProjectsReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new GcpCloudAccountAddProjectsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "gcpCloudAccountAddProjects" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> GcpCloudAccountDeleteProjectsReply? GcpCloudAccountDeleteProjects
        // GraphQL -> gcpCloudAccountDeleteProjects: GcpCloudAccountDeleteProjectsReply! (type)
        public static string GcpCloudAccountDeleteProjects(
            ref GcpCloudAccountDeleteProjectsReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new GcpCloudAccountDeleteProjectsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "gcpCloudAccountDeleteProjects" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> GcpCloudAccountOauthCompleteReply? GcpCloudAccountOauthComplete
        // GraphQL -> gcpCloudAccountOauthComplete: GcpCloudAccountOauthCompleteReply! (type)
        public static string GcpCloudAccountOauthComplete(
            ref GcpCloudAccountOauthCompleteReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new GcpCloudAccountOauthCompleteReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "gcpCloudAccountOauthComplete" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> GcpCloudAccountOauthInitiateReply? GcpCloudAccountOauthInitiate
        // GraphQL -> gcpCloudAccountOauthInitiate: GcpCloudAccountOauthInitiateReply! (type)
        public static string GcpCloudAccountOauthInitiate(
            ref GcpCloudAccountOauthInitiateReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new GcpCloudAccountOauthInitiateReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "gcpCloudAccountOauthInitiate" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> GcpCloudAccountUpgradeProjectsReply? GcpCloudAccountUpgradeProjects
        // GraphQL -> gcpCloudAccountUpgradeProjects: GcpCloudAccountUpgradeProjectsReply! (type)
        public static string GcpCloudAccountUpgradeProjects(
            ref GcpCloudAccountUpgradeProjectsReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new GcpCloudAccountUpgradeProjectsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "gcpCloudAccountUpgradeProjects" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncJobStatus? GcpNativeDisableProject
        // GraphQL -> gcpNativeDisableProject: AsyncJobStatus! (type)
        public static string GcpNativeDisableProject(
            ref AsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "gcpNativeDisableProject" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncJobStatus? GcpNativeExportDisk
        // GraphQL -> gcpNativeExportDisk: AsyncJobStatus! (type)
        public static string GcpNativeExportDisk(
            ref AsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "gcpNativeExportDisk" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncJobStatus? GcpNativeExportGceInstance
        // GraphQL -> gcpNativeExportGceInstance: AsyncJobStatus! (type)
        public static string GcpNativeExportGceInstance(
            ref AsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "gcpNativeExportGceInstance" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchAsyncJobStatus? GcpNativeRefreshProjects
        // GraphQL -> gcpNativeRefreshProjects: BatchAsyncJobStatus! (type)
        public static string GcpNativeRefreshProjects(
            ref BatchAsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchAsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "gcpNativeRefreshProjects" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncJobStatus? GcpNativeRestoreGceInstance
        // GraphQL -> gcpNativeRestoreGceInstance: AsyncJobStatus! (type)
        public static string GcpNativeRestoreGceInstance(
            ref AsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "gcpNativeRestoreGceInstance" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ClusterRegistrationToken? GenerateClusterRegistrationToken
        // GraphQL -> generateClusterRegistrationToken: ClusterRegistrationToken! (type)
        public static string GenerateClusterRegistrationToken(
            ref ClusterRegistrationToken? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ClusterRegistrationToken() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "generateClusterRegistrationToken" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> GenerateConfigProtectionRestoreFormReply? GenerateConfigProtectionRestoreForm
        // GraphQL -> generateConfigProtectionRestoreForm: GenerateConfigProtectionRestoreFormReply! (type)
        public static string GenerateConfigProtectionRestoreForm(
            ref GenerateConfigProtectionRestoreFormReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new GenerateConfigProtectionRestoreFormReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "generateConfigProtectionRestoreForm" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Csr? GenerateCsr
        // GraphQL -> generateCsr: Csr! (type)
        public static string GenerateCsr(
            ref Csr? fieldSpec
        )
        {
            string args = "\n(\nname: $name\nhostnames: $hostnames\norganization: $organization\norganizationUnit: $organizationUnit\ncountry: $country\nstate: $state\ncity: $city\nemail: $email\nsurname: $surname\nuserId: $userId\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new Csr() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "generateCsr" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? GenerateSupportBundle
        // GraphQL -> generateSupportBundle: AsyncRequestStatus! (type)
        public static string GenerateSupportBundle(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "generateSupportBundle" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> GenerateTotpSecretReply? GenerateTotpSecret
        // GraphQL -> generateTotpSecret: GenerateTotpSecretReply! (type)
        public static string GenerateTotpSecret(
            ref GenerateTotpSecretReply? fieldSpec
        )
        {
            string args = "\n(\nuserId: $userId\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new GenerateTotpSecretReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "generateTotpSecret" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UserDownloadUrl? GetDownloadUrl
        // GraphQL -> getDownloadUrl: UserDownloadUrl! (type)
        public static string GetDownloadUrl(
            ref UserDownloadUrl? fieldSpec
        )
        {
            string args = "\n(\ndownloadId: $downloadId\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UserDownloadUrl() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "getDownloadUrl" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> GetHealthMonitorPolicyStatusReply? GetHealthMonitorPolicyStatus
        // GraphQL -> getHealthMonitorPolicyStatus: GetHealthMonitorPolicyStatusReply! (type)
        public static string GetHealthMonitorPolicyStatus(
            ref GetHealthMonitorPolicyStatusReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new GetHealthMonitorPolicyStatusReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "getHealthMonitorPolicyStatus" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> GetPendingSlaAssignmentsReply? GetPendingSlaAssignments
        // GraphQL -> getPendingSlaAssignments: GetPendingSlaAssignmentsReply! (type)
        public static string GetPendingSlaAssignments(
            ref GetPendingSlaAssignmentsReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new GetPendingSlaAssignmentsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "getPendingSlaAssignments" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ResponseSuccess? HideRevealNasShares
        // GraphQL -> hideRevealNasShares: ResponseSuccess! (type)
        public static string HideRevealNasShares(
            ref ResponseSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ResponseSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "hideRevealNasShares" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestSuccess? HypervDeleteAllSnapshots
        // GraphQL -> hypervDeleteAllSnapshots: RequestSuccess! (type)
        public static string HypervDeleteAllSnapshots(
            ref RequestSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "hypervDeleteAllSnapshots" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? HypervOnDemandSnapshot
        // GraphQL -> hypervOnDemandSnapshot: AsyncRequestStatus! (type)
        public static string HypervOnDemandSnapshot(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "hypervOnDemandSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ResponseSuccess? HypervScvmmDelete
        // GraphQL -> hypervScvmmDelete: ResponseSuccess! (type)
        public static string HypervScvmmDelete(
            ref ResponseSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ResponseSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "hypervScvmmDelete" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> HypervScvmmUpdateReply? HypervScvmmUpdate
        // GraphQL -> hypervScvmmUpdate: HypervScvmmUpdateReply! (type)
        public static string HypervScvmmUpdate(
            ref HypervScvmmUpdateReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new HypervScvmmUpdateReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "hypervScvmmUpdate" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestStatus? InsertCustomerO365App
        // GraphQL -> insertCustomerO365App: RequestStatus! (type)
        public static string InsertCustomerO365App(
            ref RequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "insertCustomerO365App" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestSuccess? InstallIoFilter
        // GraphQL -> installIoFilter: RequestSuccess! (type)
        public static string InstallIoFilter(
            ref RequestSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "installIoFilter" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? InstantRecoverHypervVirtualMachineSnapshot
        // GraphQL -> instantRecoverHypervVirtualMachineSnapshot: AsyncRequestStatus! (type)
        public static string InstantRecoverHypervVirtualMachineSnapshot(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "instantRecoverHypervVirtualMachineSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? InstantRecoverOracleSnapshot
        // GraphQL -> instantRecoverOracleSnapshot: AsyncRequestStatus! (type)
        public static string InstantRecoverOracleSnapshot(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "instantRecoverOracleSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ListCidrsForComputeSettingReply? ListCidrsForComputeSetting
        // GraphQL -> listCidrsForComputeSetting: ListCidrsForComputeSettingReply! (type)
        public static string ListCidrsForComputeSetting(
            ref ListCidrsForComputeSettingReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ListCidrsForComputeSettingReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "listCidrsForComputeSetting" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> SupportPortalLogoutReply? LogoutFromRubrikSupportPortal
        // GraphQL -> logoutFromRubrikSupportPortal: SupportPortalLogoutReply! (type)
        public static string LogoutFromRubrikSupportPortal(
            ref SupportPortalLogoutReply? fieldSpec
        )
        {
            string args = "";
           if (fieldSpec == null)
            {
                fieldSpec = new SupportPortalLogoutReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "logoutFromRubrikSupportPortal" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> MapAzureCloudAccountExocomputeSubscriptionReply? MapAzureCloudAccountExocomputeSubscription
        // GraphQL -> mapAzureCloudAccountExocomputeSubscription: MapAzureCloudAccountExocomputeSubscriptionReply! (type)
        public static string MapAzureCloudAccountExocomputeSubscription(
            ref MapAzureCloudAccountExocomputeSubscriptionReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new MapAzureCloudAccountExocomputeSubscriptionReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "mapAzureCloudAccountExocomputeSubscription" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> MapAzureCloudAccountToPersistentStorageLocationReply? MapAzureCloudAccountToPersistentStorageLocation
        // GraphQL -> mapAzureCloudAccountToPersistentStorageLocation: MapAzureCloudAccountToPersistentStorageLocationReply! (type)
        public static string MapAzureCloudAccountToPersistentStorageLocation(
            ref MapAzureCloudAccountToPersistentStorageLocationReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new MapAzureCloudAccountToPersistentStorageLocationReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "mapAzureCloudAccountToPersistentStorageLocation" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> MapCloudAccountExocomputeAccountReply? MapCloudAccountExocomputeAccount
        // GraphQL -> mapCloudAccountExocomputeAccount: MapCloudAccountExocomputeAccountReply! (type)
        public static string MapCloudAccountExocomputeAccount(
            ref MapCloudAccountExocomputeAccountReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new MapCloudAccountExocomputeAccountReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "mapCloudAccountExocomputeAccount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? MigrateNutanixMountV1
        // GraphQL -> migrateNutanixMountV1: AsyncRequestStatus! (type)
        public static string MigrateNutanixMountV1(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "migrateNutanixMountV1" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ModifyIpmiReply? ModifyIpmi
        // GraphQL -> modifyIpmi: ModifyIpmiReply! (type)
        public static string ModifyIpmi(
            ref ModifyIpmiReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ModifyIpmiReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "modifyIpmi" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> MountDiskReply? MountDisk
        // GraphQL -> mountDisk: MountDiskReply! (type)
        public static string MountDisk(
            ref MountDiskReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new MountDiskReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "mountDisk" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? MountNutanixSnapshotV1
        // GraphQL -> mountNutanixSnapshotV1: AsyncRequestStatus! (type)
        public static string MountNutanixSnapshotV1(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "mountNutanixSnapshotV1" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? MountOracleDatabase
        // GraphQL -> mountOracleDatabase: AsyncRequestStatus! (type)
        public static string MountOracleDatabase(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "mountOracleDatabase" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> NotificationForGetLicenseReply? NotificationForGetLicense
        // GraphQL -> notificationForGetLicense: NotificationForGetLicenseReply! (type)
        public static string NotificationForGetLicense(
            ref NotificationForGetLicenseReply? fieldSpec
        )
        {
            string args = "";
           if (fieldSpec == null)
            {
                fieldSpec = new NotificationForGetLicenseReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "notificationForGetLicense" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> O365OauthConsentCompleteReply? O365OauthConsentComplete
        // GraphQL -> o365OauthConsentComplete: O365OauthConsentCompleteReply! (type)
        public static string O365OauthConsentComplete(
            ref O365OauthConsentCompleteReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new O365OauthConsentCompleteReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "o365OauthConsentComplete" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> O365OauthConsentKickoffReply? O365OauthConsentKickoff
        // GraphQL -> o365OauthConsentKickoff: O365OauthConsentKickoffReply! (type)
        public static string O365OauthConsentKickoff(
            ref O365OauthConsentKickoffReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new O365OauthConsentKickoffReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "o365OauthConsentKickoff" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> O365PdlGroupsReply? O365PdlGroups
        // GraphQL -> o365PdlGroups: O365PdlGroupsReply! (type)
        public static string O365PdlGroups(
            ref O365PdlGroupsReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new O365PdlGroupsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "o365PdlGroups" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> O365SaasSetupKickoffReply? O365SaaSsetupKickoff
        // GraphQL -> o365SaaSSetupKickoff: O365SaasSetupKickoffReply! (type)
        public static string O365SaaSsetupKickoff(
            ref O365SaasSetupKickoffReply? fieldSpec
        )
        {
            string args = "";
           if (fieldSpec == null)
            {
                fieldSpec = new O365SaasSetupKickoffReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "o365SaaSSetupKickoff" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AddO365OrgResponse? O365SaasSetupComplete
        // GraphQL -> o365SaasSetupComplete: AddO365OrgResponse! (type)
        public static string O365SaasSetupComplete(
            ref AddO365OrgResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AddO365OrgResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "o365SaasSetupComplete" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> O365SetupKickoffResp? O365SetupKickoff
        // GraphQL -> o365SetupKickoff: O365SetupKickoffResp! (type)
        public static string O365SetupKickoff(
            ref O365SetupKickoffResp? fieldSpec
        )
        {
            string args = "";
           if (fieldSpec == null)
            {
                fieldSpec = new O365SetupKickoffResp() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "o365SetupKickoff" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> PatchDb2DatabaseReply? PatchDb2Database
        // GraphQL -> patchDb2Database: PatchDb2DatabaseReply! (type)
        public static string PatchDb2Database(
            ref PatchDb2DatabaseReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new PatchDb2DatabaseReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "patchDb2Database" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> PatchDb2InstanceReply? PatchDb2Instance
        // GraphQL -> patchDb2Instance: PatchDb2InstanceReply! (type)
        public static string PatchDb2Instance(
            ref PatchDb2InstanceReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new PatchDb2InstanceReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "patchDb2Instance" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? PatchMongoSource
        // GraphQL -> patchMongoSource: AsyncRequestStatus! (type)
        public static string PatchMongoSource(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "patchMongoSource" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> PatchNutanixMountV1Reply? PatchNutanixMountV1
        // GraphQL -> patchNutanixMountV1: PatchNutanixMountV1Reply! (type)
        public static string PatchNutanixMountV1(
            ref PatchNutanixMountV1Reply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new PatchNutanixMountV1Reply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "patchNutanixMountV1" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> PatchSapHanaSystemReply? PatchSapHanaSystem
        // GraphQL -> patchSapHanaSystem: PatchSapHanaSystemReply! (type)
        public static string PatchSapHanaSystem(
            ref PatchSapHanaSystemReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new PatchSapHanaSystemReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "patchSapHanaSystem" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> PauseSlaReply? PauseSla
        // GraphQL -> pauseSla: PauseSlaReply! (type)
        public static string PauseSla(
            ref PauseSlaReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new PauseSlaReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "pauseSla" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> PauseTargetReply? PauseTarget
        // GraphQL -> pauseTarget: PauseTargetReply! (type)
        public static string PauseTarget(
            ref PauseTargetReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new PauseTargetReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "pauseTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> PrepareAwsCloudAccountDeletionReply? PrepareAwsCloudAccountDeletion
        // GraphQL -> prepareAwsCloudAccountDeletion: PrepareAwsCloudAccountDeletionReply! (type)
        public static string PrepareAwsCloudAccountDeletion(
            ref PrepareAwsCloudAccountDeletionReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new PrepareAwsCloudAccountDeletionReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "prepareAwsCloudAccountDeletion" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> PrepareFeatureUpdateForAwsCloudAccountReply? PrepareFeatureUpdateForAwsCloudAccount
        // GraphQL -> prepareFeatureUpdateForAwsCloudAccount: PrepareFeatureUpdateForAwsCloudAccountReply! (type)
        public static string PrepareFeatureUpdateForAwsCloudAccount(
            ref PrepareFeatureUpdateForAwsCloudAccountReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new PrepareFeatureUpdateForAwsCloudAccountReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "prepareFeatureUpdateForAwsCloudAccount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> PutSmbConfigurationReply? PutSmbConfiguration
        // GraphQL -> putSmbConfiguration: PutSmbConfigurationReply! (type)
        public static string PutSmbConfiguration(
            ref PutSmbConfigurationReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new PutSmbConfigurationReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "putSmbConfiguration" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> MosaicAsyncResponse? RecoverCassandraSource
        // GraphQL -> recoverCassandraSource: MosaicAsyncResponse! (type)
        public static string RecoverCassandraSource(
            ref MosaicAsyncResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new MosaicAsyncResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "recoverCassandraSource" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CcProvisionJobReply? RecoverCloudCluster
        // GraphQL -> recoverCloudCluster: CcProvisionJobReply! (type)
        public static string RecoverCloudCluster(
            ref CcProvisionJobReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CcProvisionJobReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "recoverCloudCluster" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? RecoverCloudDirectMultiPaths
        // GraphQL -> recoverCloudDirectMultiPaths: AsyncRequestStatus! (type)
        public static string RecoverCloudDirectMultiPaths(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "recoverCloudDirectMultiPaths" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? RecoverCloudDirectPath
        // GraphQL -> recoverCloudDirectPath: AsyncRequestStatus! (type)
        public static string RecoverCloudDirectPath(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "recoverCloudDirectPath" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? RecoverMongoSource
        // GraphQL -> recoverMongoSource: AsyncRequestStatus! (type)
        public static string RecoverMongoSource(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "recoverMongoSource" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> MosaicAsyncResponse? RecoverMongodbSource
        // GraphQL -> recoverMongodbSource: MosaicAsyncResponse! (type)
        public static string RecoverMongodbSource(
            ref MosaicAsyncResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new MosaicAsyncResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "recoverMongodbSource" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? RefreshDb2Database
        // GraphQL -> refreshDb2Database: AsyncRequestStatus! (type)
        public static string RefreshDb2Database(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "refreshDb2Database" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> GlobalManagerConnectivity? RefreshGlobalManagerConnectivityStatus
        // GraphQL -> refreshGlobalManagerConnectivityStatus: GlobalManagerConnectivity! (type)
        public static string RefreshGlobalManagerConnectivityStatus(
            ref GlobalManagerConnectivity? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new GlobalManagerConnectivity() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "refreshGlobalManagerConnectivityStatus" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RefreshHostReply? RefreshHost
        // GraphQL -> refreshHost: RefreshHostReply! (type)
        public static string RefreshHost(
            ref RefreshHostReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RefreshHostReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "refreshHost" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? RefreshHypervScvmm
        // GraphQL -> refreshHypervScvmm: AsyncRequestStatus! (type)
        public static string RefreshHypervScvmm(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "refreshHypervScvmm" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? RefreshHypervServer
        // GraphQL -> refreshHypervServer: AsyncRequestStatus! (type)
        public static string RefreshHypervServer(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "refreshHypervServer" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateOnDemandJobReply? RefreshK8sCluster
        // GraphQL -> refreshK8sCluster: CreateOnDemandJobReply! (type)
        public static string RefreshK8sCluster(
            ref CreateOnDemandJobReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateOnDemandJobReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "refreshK8sCluster" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RefreshNasSystemsReply? RefreshNasSystems
        // GraphQL -> refreshNasSystems: RefreshNasSystemsReply! (type)
        public static string RefreshNasSystems(
            ref RefreshNasSystemsReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RefreshNasSystemsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "refreshNasSystems" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? RefreshNutanixCluster
        // GraphQL -> refreshNutanixCluster: AsyncRequestStatus! (type)
        public static string RefreshNutanixCluster(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "refreshNutanixCluster" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchAsyncRequestStatus? RefreshNutanixPrismCentral
        // GraphQL -> refreshNutanixPrismCentral: BatchAsyncRequestStatus! (type)
        public static string RefreshNutanixPrismCentral(
            ref BatchAsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchAsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "refreshNutanixPrismCentral" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateOnDemandJobReply? RefreshO365Org
        // GraphQL -> refreshO365Org: CreateOnDemandJobReply! (type)
        public static string RefreshO365Org(
            ref CreateOnDemandJobReply? fieldSpec
        )
        {
            string args = "\n(\norgId: $orgId\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateOnDemandJobReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "refreshO365Org" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? RefreshOracleDatabase
        // GraphQL -> refreshOracleDatabase: AsyncRequestStatus! (type)
        public static string RefreshOracleDatabase(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "refreshOracleDatabase" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RefreshStorageArraysReply? RefreshStorageArrays
        // GraphQL -> refreshStorageArrays: RefreshStorageArraysReply! (type)
        public static string RefreshStorageArrays(
            ref RefreshStorageArraysReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RefreshStorageArraysReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "refreshStorageArrays" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? RefreshVsphereVcenter
        // GraphQL -> refreshVsphereVcenter: AsyncRequestStatus! (type)
        public static string RefreshVsphereVcenter(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "refreshVsphereVcenter" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestSuccess? RegisterAgentHypervVirtualMachine
        // GraphQL -> registerAgentHypervVirtualMachine: RequestSuccess! (type)
        public static string RegisterAgentHypervVirtualMachine(
            ref RequestSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "registerAgentHypervVirtualMachine" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestSuccess? RegisterAgentNutanixVm
        // GraphQL -> registerAgentNutanixVm: RequestSuccess! (type)
        public static string RegisterAgentNutanixVm(
            ref RequestSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "registerAgentNutanixVm" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RegisterAwsFeatureArtifactsReply? RegisterAwsFeatureArtifacts
        // GraphQL -> registerAwsFeatureArtifacts: RegisterAwsFeatureArtifactsReply! (type)
        public static string RegisterAwsFeatureArtifacts(
            ref RegisterAwsFeatureArtifactsReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RegisterAwsFeatureArtifactsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "registerAwsFeatureArtifacts" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RegisterCloudClusterReply? RegisterCloudCluster
        // GraphQL -> registerCloudCluster: RegisterCloudClusterReply! (type)
        public static string RegisterCloudCluster(
            ref RegisterCloudClusterReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RegisterCloudClusterReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "registerCloudCluster" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? RegisterHypervScvmm
        // GraphQL -> registerHypervScvmm: AsyncRequestStatus! (type)
        public static string RegisterHypervScvmm(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "registerHypervScvmm" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RegisterNasSystemReply? RegisterNasSystem
        // GraphQL -> registerNasSystem: RegisterNasSystemReply! (type)
        public static string RegisterNasSystem(
            ref RegisterNasSystemReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RegisterNasSystemReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "registerNasSystem" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CcProvisionJobReply? RemoveCloudClusterNodes
        // GraphQL -> removeCloudClusterNodes: CcProvisionJobReply! (type)
        public static string RemoveCloudClusterNodes(
            ref CcProvisionJobReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CcProvisionJobReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "removeCloudClusterNodes" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CcProvisionJobReply? RemoveClusterNodes
        // GraphQL -> removeClusterNodes: CcProvisionJobReply! (type)
        public static string RemoveClusterNodes(
            ref CcProvisionJobReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CcProvisionJobReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "removeClusterNodes" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ResponseSuccess? RemoveDisk
        // GraphQL -> removeDisk: ResponseSuccess! (type)
        public static string RemoveDisk(
            ref ResponseSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ResponseSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "removeDisk" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RemoveNodeForReplacementReply? RemoveNodeForReplacement
        // GraphQL -> removeNodeForReplacement: RemoveNodeForReplacementReply! (type)
        public static string RemoveNodeForReplacement(
            ref RemoveNodeForReplacementReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RemoveNodeForReplacementReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "removeNodeForReplacement" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ResponseSuccess? RemoveProxyConfig
        // GraphQL -> removeProxyConfig: ResponseSuccess! (type)
        public static string RemoveProxyConfig(
            ref ResponseSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ResponseSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "removeProxyConfig" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RemoveVlansReply? RemoveVlans
        // GraphQL -> removeVlans: RemoveVlansReply! (type)
        public static string RemoveVlans(
            ref RemoveVlansReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RemoveVlansReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "removeVlans" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ReplaceClusterNodeReply? ReplaceClusterNode
        // GraphQL -> replaceClusterNode: ReplaceClusterNodeReply! (type)
        public static string ReplaceClusterNode(
            ref ReplaceClusterNodeReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ReplaceClusterNodeReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "replaceClusterNode" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? ReseedLogShippingSecondary
        // GraphQL -> reseedLogShippingSecondary: AsyncRequestStatus! (type)
        public static string ReseedLogShippingSecondary(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "reseedLogShippingSecondary" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ResponseSuccess? ResizeDisk
        // GraphQL -> resizeDisk: ResponseSuccess! (type)
        public static string ResizeDisk(
            ref ResponseSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ResponseSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "resizeDisk" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? ResizeManagedVolume
        // GraphQL -> resizeManagedVolume: AsyncRequestStatus! (type)
        public static string ResizeManagedVolume(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "resizeManagedVolume" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestSuccess? ResolveVolumeGroupsConflict
        // GraphQL -> resolveVolumeGroupsConflict: RequestSuccess! (type)
        public static string ResolveVolumeGroupsConflict(
            ref RequestSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "resolveVolumeGroupsConflict" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? RestoreFilesNutanixSnapshot
        // GraphQL -> restoreFilesNutanixSnapshot: AsyncRequestStatus! (type)
        public static string RestoreFilesNutanixSnapshot(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "restoreFilesNutanixSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? RestoreHypervVirtualMachineSnapshotFiles
        // GraphQL -> restoreHypervVirtualMachineSnapshotFiles: AsyncRequestStatus! (type)
        public static string RestoreHypervVirtualMachineSnapshotFiles(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "restoreHypervVirtualMachineSnapshotFiles" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateOnDemandJobReply? RestoreK8sNamespace
        // GraphQL -> restoreK8sNamespace: CreateOnDemandJobReply! (type)
        public static string RestoreK8sNamespace(
            ref CreateOnDemandJobReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateOnDemandJobReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "restoreK8sNamespace" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? RestoreMssqlDatabase
        // GraphQL -> restoreMssqlDatabase: AsyncRequestStatus! (type)
        public static string RestoreMssqlDatabase(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "restoreMssqlDatabase" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateOnDemandJobReply? RestoreO365Mailbox
        // GraphQL -> restoreO365Mailbox: CreateOnDemandJobReply! (type)
        public static string RestoreO365Mailbox(
            ref CreateOnDemandJobReply? fieldSpec
        )
        {
            string args = "\n(\nrestoreConfig: $restoreConfig\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateOnDemandJobReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "restoreO365Mailbox" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateOnDemandJobReply? RestoreO365Snappable
        // GraphQL -> restoreO365Snappable: CreateOnDemandJobReply! (type)
        public static string RestoreO365Snappable(
            ref CreateOnDemandJobReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateOnDemandJobReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "restoreO365Snappable" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateOnDemandJobReply? RestoreO365TeamsConversations
        // GraphQL -> restoreO365TeamsConversations: CreateOnDemandJobReply! (type)
        public static string RestoreO365TeamsConversations(
            ref CreateOnDemandJobReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateOnDemandJobReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "restoreO365TeamsConversations" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> CreateOnDemandJobReply? RestoreO365TeamsFiles
        // GraphQL -> restoreO365TeamsFiles: CreateOnDemandJobReply! (type)
        public static string RestoreO365TeamsFiles(
            ref CreateOnDemandJobReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new CreateOnDemandJobReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "restoreO365TeamsFiles" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? RestoreOracleLogs
        // GraphQL -> restoreOracleLogs: AsyncRequestStatus! (type)
        public static string RestoreOracleLogs(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "restoreOracleLogs" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? RestoreVolumeGroupSnapshotFiles
        // GraphQL -> restoreVolumeGroupSnapshotFiles: AsyncRequestStatus! (type)
        public static string RestoreVolumeGroupSnapshotFiles(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "restoreVolumeGroupSnapshotFiles" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ResumeTargetReply? ResumeTarget
        // GraphQL -> resumeTarget: ResumeTargetReply! (type)
        public static string ResumeTarget(
            ref ResumeTargetReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ResumeTargetReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "resumeTarget" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? RetryAddMongoSource
        // GraphQL -> retryAddMongoSource: AsyncRequestStatus! (type)
        public static string RetryAddMongoSource(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "retryAddMongoSource" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RetryBackupResp? RetryBackup
        // GraphQL -> retryBackup: RetryBackupResp! (type)
        public static string RetryBackup(
            ref RetryBackupResp? fieldSpec
        )
        {
            string args = "\n(\nbackupObjects: $backupObjects\nbackupRunConfig: $backupRunConfig\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RetryBackupResp() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "retryBackup" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> DownloadPackageReply? RetryDownloadPackageJob
        // GraphQL -> retryDownloadPackageJob: DownloadPackageReply! (type)
        public static string RetryDownloadPackageJob(
            ref DownloadPackageReply? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new DownloadPackageReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "retryDownloadPackageJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RotateServiceAccountSecretReply? RotateServiceAccountSecret
        // GraphQL -> rotateServiceAccountSecret: RotateServiceAccountSecretReply! (type)
        public static string RotateServiceAccountSecret(
            ref RotateServiceAccountSecretReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RotateServiceAccountSecretReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "rotateServiceAccountSecret" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RunCustomAnalyzerReply? RunCustomAnalyzer
        // GraphQL -> runCustomAnalyzer: RunCustomAnalyzerReply! (type)
        public static string RunCustomAnalyzer(
            ref RunCustomAnalyzerReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RunCustomAnalyzerReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "runCustomAnalyzer" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> List<UpgradeJobReplyWithUuid>? ScheduleUpgradeBatchJob
        // GraphQL -> scheduleUpgradeBatchJob: [UpgradeJobReplyWithUuid!]! (type)
        public static string ScheduleUpgradeBatchJob(
            ref List<UpgradeJobReplyWithUuid>? fieldSpec
        )
        {
            string args = "\n(\nlistClusterUuid: $listClusterUuid\nmode: $mode\naction: $action\nversion: $version\nscheduleAt: $scheduleAt\ncontext_tag: $context_tag\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new List<UpgradeJobReplyWithUuid>() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "scheduleUpgradeBatchJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> SeedEnabledPoliciesReply? SeedEnabledPolicies
        // GraphQL -> seedEnabledPolicies: SeedEnabledPoliciesReply! (type)
        public static string SeedEnabledPolicies(
            ref SeedEnabledPoliciesReply? fieldSpec
        )
        {
            string args = "";
           if (fieldSpec == null)
            {
                fieldSpec = new SeedEnabledPoliciesReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "seedEnabledPolicies" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> SeedInitialPoliciesReply? SeedInitialPolicies
        // GraphQL -> seedInitialPolicies: SeedInitialPoliciesReply! (type)
        public static string SeedInitialPolicies(
            ref SeedInitialPoliciesReply? fieldSpec
        )
        {
            string args = "";
           if (fieldSpec == null)
            {
                fieldSpec = new SeedInitialPoliciesReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "seedInitialPolicies" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> SendPdfReportReply? SendPdfReport
        // GraphQL -> sendPdfReport: SendPdfReportReply! (type)
        public static string SendPdfReport(
            ref SendPdfReportReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new SendPdfReportReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "sendPdfReport" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncDownloadReply? SendScheduledReportAsync
        // GraphQL -> sendScheduledReportAsync: AsyncDownloadReply! (type)
        public static string SendScheduledReportAsync(
            ref AsyncDownloadReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncDownloadReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "sendScheduledReportAsync" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> SetAnalyzerRisksReply? SetAnalyzerRisks
        // GraphQL -> setAnalyzerRisks: SetAnalyzerRisksReply! (type)
        public static string SetAnalyzerRisks(
            ref SetAnalyzerRisksReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new SetAnalyzerRisksReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "setAnalyzerRisks" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> SetDatastoreFreespaceThresholdsReply? SetDatastoreFreespaceThresholds
        // GraphQL -> setDatastoreFreespaceThresholds: SetDatastoreFreespaceThresholdsReply! (type)
        public static string SetDatastoreFreespaceThresholds(
            ref SetDatastoreFreespaceThresholdsReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new SetDatastoreFreespaceThresholdsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "setDatastoreFreespaceThresholds" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestStatus? SetO365ServiceAccount
        // GraphQL -> setO365ServiceAccount: RequestStatus! (type)
        public static string SetO365ServiceAccount(
            ref RequestStatus? fieldSpec
        )
        {
            string args = "\n(\nusername: $username\nappPassword: $appPassword\norgId: $orgId\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "setO365ServiceAccount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> SetUpgradeTypeReply? SetUpgradeType
        // GraphQL -> setUpgradeType: SetUpgradeTypeReply! (type)
        public static string SetUpgradeType(
            ref SetUpgradeTypeReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new SetUpgradeTypeReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "setUpgradeType" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? SetWebSignedCertificate
        // GraphQL -> setWebSignedCertificate: AsyncRequestStatus! (type)
        public static string SetWebSignedCertificate(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "setWebSignedCertificate" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> SetWorkloadAlertSettingReply? SetWorkloadAlertSetting
        // GraphQL -> setWorkloadAlertSetting: SetWorkloadAlertSettingReply! (type)
        public static string SetWorkloadAlertSetting(
            ref SetWorkloadAlertSettingReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new SetWorkloadAlertSettingReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "setWorkloadAlertSetting" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> SetupAzureO365ExocomputeResp? SetupAzureO365Exocompute
        // GraphQL -> setupAzureO365Exocompute: SetupAzureO365ExocomputeResp! (type)
        public static string SetupAzureO365Exocompute(
            ref SetupAzureO365ExocomputeResp? fieldSpec
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nexocomputeConfig: $exocomputeConfig\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new SetupAzureO365ExocomputeResp() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "setupAzureO365Exocompute" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchAsyncJobStatus? SetupCloudNativeSqlServerBackup
        // GraphQL -> setupCloudNativeSqlServerBackup: BatchAsyncJobStatus! (type)
        public static string SetupCloudNativeSqlServerBackup(
            ref BatchAsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchAsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "setupCloudNativeSqlServerBackup" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> DiskInfo? SetupDisk
        // GraphQL -> setupDisk: DiskInfo! (type)
        public static string SetupDisk(
            ref DiskInfo? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new DiskInfo() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "setupDisk" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncJobStatus? StartAwsExocomputeDisableJob
        // GraphQL -> startAwsExocomputeDisableJob: AsyncJobStatus! (type)
        public static string StartAwsExocomputeDisableJob(
            ref AsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startAwsExocomputeDisableJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncJobStatus? StartAwsNativeAccountDisableJob
        // GraphQL -> startAwsNativeAccountDisableJob: AsyncJobStatus! (type)
        public static string StartAwsNativeAccountDisableJob(
            ref AsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startAwsNativeAccountDisableJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchAsyncJobStatus? StartAwsNativeEc2InstanceSnapshotsJob
        // GraphQL -> startAwsNativeEc2InstanceSnapshotsJob: BatchAsyncJobStatus! (type)
        public static string StartAwsNativeEc2InstanceSnapshotsJob(
            ref BatchAsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchAsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startAwsNativeEc2InstanceSnapshotsJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchAsyncJobStatus? StartAwsNativeRdsInstanceSnapshotsJob
        // GraphQL -> startAwsNativeRdsInstanceSnapshotsJob: BatchAsyncJobStatus! (type)
        public static string StartAwsNativeRdsInstanceSnapshotsJob(
            ref BatchAsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchAsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startAwsNativeRdsInstanceSnapshotsJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> StartAzureCloudAccountOauthReply? StartAzureCloudAccountOauth
        // GraphQL -> startAzureCloudAccountOauth: StartAzureCloudAccountOauthReply! (type)
        public static string StartAzureCloudAccountOauth(
            ref StartAzureCloudAccountOauthReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new StartAzureCloudAccountOauthReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startAzureCloudAccountOauth" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchAsyncJobStatus? StartCloudNativeSnapshotsIndexJob
        // GraphQL -> startCloudNativeSnapshotsIndexJob: BatchAsyncJobStatus! (type)
        public static string StartCloudNativeSnapshotsIndexJob(
            ref BatchAsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchAsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startCloudNativeSnapshotsIndexJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> StartClusterReportMigrationJobReply? StartClusterReportMigrationJob
        // GraphQL -> startClusterReportMigrationJob: StartClusterReportMigrationJobReply! (type)
        public static string StartClusterReportMigrationJob(
            ref StartClusterReportMigrationJobReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new StartClusterReportMigrationJobReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startClusterReportMigrationJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> StartCrawlReply? StartCrawl
        // GraphQL -> startCrawl: StartCrawlReply! (type)
        public static string StartCrawl(
            ref StartCrawlReply? fieldSpec
        )
        {
            string args = "\n(\nname: $name\nresources: $resources\nanalyzerGroups: $analyzerGroups\nextWhiteList: $extWhiteList\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new StartCrawlReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startCrawl" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchAsyncJobStatus? StartCreateAwsNativeEbsVolumeSnapshotsJob
        // GraphQL -> startCreateAwsNativeEbsVolumeSnapshotsJob: BatchAsyncJobStatus! (type)
        public static string StartCreateAwsNativeEbsVolumeSnapshotsJob(
            ref BatchAsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchAsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startCreateAwsNativeEbsVolumeSnapshotsJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchAsyncJobStatus? StartCreateAzureNativeManagedDiskSnapshotsJob
        // GraphQL -> startCreateAzureNativeManagedDiskSnapshotsJob: BatchAsyncJobStatus! (type)
        public static string StartCreateAzureNativeManagedDiskSnapshotsJob(
            ref BatchAsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchAsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startCreateAzureNativeManagedDiskSnapshotsJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchAsyncJobStatus? StartCreateAzureNativeVirtualMachineSnapshotsJob
        // GraphQL -> startCreateAzureNativeVirtualMachineSnapshotsJob: BatchAsyncJobStatus! (type)
        public static string StartCreateAzureNativeVirtualMachineSnapshotsJob(
            ref BatchAsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchAsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startCreateAzureNativeVirtualMachineSnapshotsJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchAsyncJobStatus? StartDisableAzureCloudAccountJob
        // GraphQL -> startDisableAzureCloudAccountJob: BatchAsyncJobStatus! (type)
        public static string StartDisableAzureCloudAccountJob(
            ref BatchAsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchAsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startDisableAzureCloudAccountJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncJobStatus? StartDisableAzureNativeSubscriptionProtectionJob
        // GraphQL -> startDisableAzureNativeSubscriptionProtectionJob: AsyncJobStatus! (type)
        public static string StartDisableAzureNativeSubscriptionProtectionJob(
            ref AsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startDisableAzureNativeSubscriptionProtectionJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> List<DownloadPackageReplyWithUuid>? StartDownloadPackageBatchJob
        // GraphQL -> startDownloadPackageBatchJob: [DownloadPackageReplyWithUuid!]! (type)
        public static string StartDownloadPackageBatchJob(
            ref List<DownloadPackageReplyWithUuid>? fieldSpec
        )
        {
            string args = "\n(\nlistClusterUuid: $listClusterUuid\ndownloadVersion: $downloadVersion\npackageUrl: $packageUrl\nmd5checksum: $md5checksum\nsize: $size\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new List<DownloadPackageReplyWithUuid>() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startDownloadPackageBatchJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncJobStatus? StartEc2InstanceSnapshotExportJob
        // GraphQL -> startEc2InstanceSnapshotExportJob: AsyncJobStatus! (type)
        public static string StartEc2InstanceSnapshotExportJob(
            ref AsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startEc2InstanceSnapshotExportJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncJobStatus? StartExportAwsNativeEbsVolumeSnapshotJob
        // GraphQL -> startExportAwsNativeEbsVolumeSnapshotJob: AsyncJobStatus! (type)
        public static string StartExportAwsNativeEbsVolumeSnapshotJob(
            ref AsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startExportAwsNativeEbsVolumeSnapshotJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncJobStatus? StartExportAzureNativeManagedDiskJob
        // GraphQL -> startExportAzureNativeManagedDiskJob: AsyncJobStatus! (type)
        public static string StartExportAzureNativeManagedDiskJob(
            ref AsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startExportAzureNativeManagedDiskJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncJobStatus? StartExportAzureNativeVirtualMachineJob
        // GraphQL -> startExportAzureNativeVirtualMachineJob: AsyncJobStatus! (type)
        public static string StartExportAzureNativeVirtualMachineJob(
            ref AsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startExportAzureNativeVirtualMachineJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncJobStatus? StartExportAzureSqlDatabaseDbJob
        // GraphQL -> startExportAzureSqlDatabaseDbJob: AsyncJobStatus! (type)
        public static string StartExportAzureSqlDatabaseDbJob(
            ref AsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startExportAzureSqlDatabaseDbJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncJobStatus? StartExportAzureSqlManagedInstanceDbJob
        // GraphQL -> startExportAzureSqlManagedInstanceDbJob: AsyncJobStatus! (type)
        public static string StartExportAzureSqlManagedInstanceDbJob(
            ref AsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startExportAzureSqlManagedInstanceDbJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncJobStatus? StartExportRdsInstanceJob
        // GraphQL -> startExportRdsInstanceJob: AsyncJobStatus! (type)
        public static string StartExportRdsInstanceJob(
            ref AsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startExportRdsInstanceJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> PrechecksJobReply? StartPeriodicUpgradePrechecksOnDemandJob
        // GraphQL -> startPeriodicUpgradePrechecksOnDemandJob: PrechecksJobReply! (type)
        public static string StartPeriodicUpgradePrechecksOnDemandJob(
            ref PrechecksJobReply? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new PrechecksJobReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startPeriodicUpgradePrechecksOnDemandJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncJobStatus? StartRecoverS3SnapshotJob
        // GraphQL -> startRecoverS3SnapshotJob: AsyncJobStatus! (type)
        public static string StartRecoverS3SnapshotJob(
            ref AsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startRecoverS3SnapshotJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchAsyncJobStatus? StartRefreshAwsNativeAccountsJob
        // GraphQL -> startRefreshAwsNativeAccountsJob: BatchAsyncJobStatus! (type)
        public static string StartRefreshAwsNativeAccountsJob(
            ref BatchAsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchAsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startRefreshAwsNativeAccountsJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchAsyncJobStatus? StartRefreshAzureNativeSubscriptionsJob
        // GraphQL -> startRefreshAzureNativeSubscriptionsJob: BatchAsyncJobStatus! (type)
        public static string StartRefreshAzureNativeSubscriptionsJob(
            ref BatchAsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchAsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startRefreshAzureNativeSubscriptionsJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncJobStatus? StartRestoreAwsNativeEc2InstanceSnapshotJob
        // GraphQL -> startRestoreAwsNativeEc2InstanceSnapshotJob: AsyncJobStatus! (type)
        public static string StartRestoreAwsNativeEc2InstanceSnapshotJob(
            ref AsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startRestoreAwsNativeEc2InstanceSnapshotJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncJobStatus? StartRestoreAzureNativeVirtualMachineJob
        // GraphQL -> startRestoreAzureNativeVirtualMachineJob: AsyncJobStatus! (type)
        public static string StartRestoreAzureNativeVirtualMachineJob(
            ref AsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startRestoreAzureNativeVirtualMachineJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> StartThreatHuntReply? StartThreatHunt
        // GraphQL -> startThreatHunt: StartThreatHuntReply! (type)
        public static string StartThreatHunt(
            ref StartThreatHuntReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new StartThreatHuntReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startThreatHunt" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> List<UpgradeJobReplyWithUuid>? StartUpgradeBatchJob
        // GraphQL -> startUpgradeBatchJob: [UpgradeJobReplyWithUuid!]! (type)
        public static string StartUpgradeBatchJob(
            ref List<UpgradeJobReplyWithUuid>? fieldSpec
        )
        {
            string args = "\n(\nlistClusterUuid: $listClusterUuid\nmode: $mode\naction: $action\nversion: $version\ncontext_tag: $context_tag\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new List<UpgradeJobReplyWithUuid>() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startUpgradeBatchJob" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? StartVolumeGroupMount
        // GraphQL -> startVolumeGroupMount: AsyncRequestStatus! (type)
        public static string StartVolumeGroupMount(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "startVolumeGroupMount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> StopJobInstanceReply? StopJobInstance
        // GraphQL -> stopJobInstance: StopJobInstanceReply! (type)
        public static string StopJobInstance(
            ref StopJobInstanceReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new StopJobInstanceReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "stopJobInstance" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> SupportPortalLoginReply? SupportPortalLogin
        // GraphQL -> supportPortalLogin: SupportPortalLoginReply! (type)
        public static string SupportPortalLogin(
            ref SupportPortalLoginReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new SupportPortalLoginReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "supportPortalLogin" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? TakeManagedVolumeOnDemandSnapshot
        // GraphQL -> takeManagedVolumeOnDemandSnapshot: AsyncRequestStatus! (type)
        public static string TakeManagedVolumeOnDemandSnapshot(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "takeManagedVolumeOnDemandSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? TakeMssqlLogBackup
        // GraphQL -> takeMssqlLogBackup: AsyncRequestStatus! (type)
        public static string TakeMssqlLogBackup(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "takeMssqlLogBackup" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? TakeOnDemandOracleDatabaseSnapshot
        // GraphQL -> takeOnDemandOracleDatabaseSnapshot: AsyncRequestStatus! (type)
        public static string TakeOnDemandOracleDatabaseSnapshot(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "takeOnDemandOracleDatabaseSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? TakeOnDemandOracleLogSnapshot
        // GraphQL -> takeOnDemandOracleLogSnapshot: AsyncRequestStatus! (type)
        public static string TakeOnDemandOracleLogSnapshot(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "takeOnDemandOracleLogSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> TakeOnDemandSnapshotReply? TakeOnDemandSnapshot
        // GraphQL -> takeOnDemandSnapshot: TakeOnDemandSnapshotReply! (type)
        public static string TakeOnDemandSnapshot(
            ref TakeOnDemandSnapshotReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new TakeOnDemandSnapshotReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "takeOnDemandSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> TestExistingWebhookReply? TestExistingWebhook
        // GraphQL -> testExistingWebhook: TestExistingWebhookReply! (type)
        public static string TestExistingWebhook(
            ref TestExistingWebhookReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new TestExistingWebhookReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "testExistingWebhook" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> TestSyslogExportRuleReply? TestSyslogExportRule
        // GraphQL -> testSyslogExportRule: TestSyslogExportRuleReply! (type)
        public static string TestSyslogExportRule(
            ref TestSyslogExportRuleReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new TestSyslogExportRuleReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "testSyslogExportRule" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> TestWebhookReply? TestWebhook
        // GraphQL -> testWebhook: TestWebhookReply! (type)
        public static string TestWebhook(
            ref TestWebhookReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new TestWebhookReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "testWebhook" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? TriggerCloudComputeConnectivityCheck
        // GraphQL -> triggerCloudComputeConnectivityCheck: AsyncRequestStatus! (type)
        public static string TriggerCloudComputeConnectivityCheck(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "triggerCloudComputeConnectivityCheck" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> TriggerExocomputeHealthCheckReply? TriggerExocomputeHealthCheck
        // GraphQL -> triggerExocomputeHealthCheck: TriggerExocomputeHealthCheckReply! (type)
        public static string TriggerExocomputeHealthCheck(
            ref TriggerExocomputeHealthCheckReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new TriggerExocomputeHealthCheckReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "triggerExocomputeHealthCheck" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> TriggerRansomwareDetectionReply? TriggerRansomwareDetection
        // GraphQL -> triggerRansomwareDetection: TriggerRansomwareDetectionReply! (type)
        public static string TriggerRansomwareDetection(
            ref TriggerRansomwareDetectionReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new TriggerRansomwareDetectionReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "triggerRansomwareDetection" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? UnconfigureSapHanaRestore
        // GraphQL -> unconfigureSapHanaRestore: AsyncRequestStatus! (type)
        public static string UnconfigureSapHanaRestore(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "unconfigureSapHanaRestore" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestSuccess? UninstallIoFilter
        // GraphQL -> uninstallIoFilter: RequestSuccess! (type)
        public static string UninstallIoFilter(
            ref RequestSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "uninstallIoFilter" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UnmapAzureCloudAccountExocomputeSubscriptionReply? UnmapAzureCloudAccountExocomputeSubscription
        // GraphQL -> unmapAzureCloudAccountExocomputeSubscription: UnmapAzureCloudAccountExocomputeSubscriptionReply! (type)
        public static string UnmapAzureCloudAccountExocomputeSubscription(
            ref UnmapAzureCloudAccountExocomputeSubscriptionReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UnmapAzureCloudAccountExocomputeSubscriptionReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "unmapAzureCloudAccountExocomputeSubscription" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UnmapCloudAccountExocomputeAccountReply? UnmapCloudAccountExocomputeAccount
        // GraphQL -> unmapCloudAccountExocomputeAccount: UnmapCloudAccountExocomputeAccountReply! (type)
        public static string UnmapCloudAccountExocomputeAccount(
            ref UnmapCloudAccountExocomputeAccountReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UnmapCloudAccountExocomputeAccountReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "unmapCloudAccountExocomputeAccount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateAutoEnablePolicyClusterConfigReply? UpdateAutoEnablePolicyClusterConfig
        // GraphQL -> updateAutoEnablePolicyClusterConfig: UpdateAutoEnablePolicyClusterConfigReply! (type)
        public static string UpdateAutoEnablePolicyClusterConfig(
            ref UpdateAutoEnablePolicyClusterConfigReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateAutoEnablePolicyClusterConfigReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateAutoEnablePolicyClusterConfig" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> TargetMapping? UpdateAutomaticAwsTargetMapping
        // GraphQL -> updateAutomaticAwsTargetMapping: TargetMapping! (type)
        public static string UpdateAutomaticAwsTargetMapping(
            ref TargetMapping? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new TargetMapping() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateAutomaticAwsTargetMapping" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> TargetMapping? UpdateAutomaticAzureTargetMapping
        // GraphQL -> updateAutomaticAzureTargetMapping: TargetMapping! (type)
        public static string UpdateAutomaticAzureTargetMapping(
            ref TargetMapping? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new TargetMapping() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateAutomaticAzureTargetMapping" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateAwsCloudAccountFeatureReply? UpdateAwsCloudAccountFeature
        // GraphQL -> updateAwsCloudAccountFeature: UpdateAwsCloudAccountFeatureReply! (type)
        public static string UpdateAwsCloudAccountFeature(
            ref UpdateAwsCloudAccountFeatureReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateAwsCloudAccountFeatureReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateAwsCloudAccountFeature" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AwsComputeSettings? UpdateAwsComputeSetting
        // GraphQL -> updateAwsComputeSetting: AwsComputeSettings! (type)
        public static string UpdateAwsComputeSetting(
            ref AwsComputeSettings? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AwsComputeSettings() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateAwsComputeSetting" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateAwsExocomputeConfigsReply? UpdateAwsExocomputeConfigs
        // GraphQL -> updateAwsExocomputeConfigs: UpdateAwsExocomputeConfigsReply! (type)
        public static string UpdateAwsExocomputeConfigs(
            ref UpdateAwsExocomputeConfigsReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateAwsExocomputeConfigsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateAwsExocomputeConfigs" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateAzureCloudAccountReply? UpdateAzureCloudAccount
        // GraphQL -> updateAzureCloudAccount: UpdateAzureCloudAccountReply! (type)
        public static string UpdateAzureCloudAccount(
            ref UpdateAzureCloudAccountReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateAzureCloudAccountReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateAzureCloudAccount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateBadDiskLedStatusReply? UpdateBadDiskLedStatus
        // GraphQL -> updateBadDiskLedStatus: UpdateBadDiskLedStatusReply! (type)
        public static string UpdateBadDiskLedStatus(
            ref UpdateBadDiskLedStatusReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateBadDiskLedStatusReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateBadDiskLedStatus" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> MosaicAsyncResponse? UpdateCassandraSource
        // GraphQL -> updateCassandraSource: MosaicAsyncResponse! (type)
        public static string UpdateCassandraSource(
            ref MosaicAsyncResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new MosaicAsyncResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateCassandraSource" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateCertificateHostReply? UpdateCertificateHost
        // GraphQL -> updateCertificateHost: UpdateCertificateHostReply! (type)
        public static string UpdateCertificateHost(
            ref UpdateCertificateHostReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateCertificateHostReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateCertificateHost" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateCloudNativeAwsStorageSettingReply? UpdateCloudNativeAwsStorageSetting
        // GraphQL -> updateCloudNativeAwsStorageSetting: UpdateCloudNativeAwsStorageSettingReply! (type)
        public static string UpdateCloudNativeAwsStorageSetting(
            ref UpdateCloudNativeAwsStorageSettingReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateCloudNativeAwsStorageSettingReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateCloudNativeAwsStorageSetting" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateCloudNativeAzureStorageSettingReply? UpdateCloudNativeAzureStorageSetting
        // GraphQL -> updateCloudNativeAzureStorageSetting: UpdateCloudNativeAzureStorageSettingReply! (type)
        public static string UpdateCloudNativeAzureStorageSetting(
            ref UpdateCloudNativeAzureStorageSettingReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateCloudNativeAzureStorageSettingReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateCloudNativeAzureStorageSetting" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateCloudNativeIndexingStatusReply? UpdateCloudNativeIndexingStatus
        // GraphQL -> updateCloudNativeIndexingStatus: UpdateCloudNativeIndexingStatusReply! (type)
        public static string UpdateCloudNativeIndexingStatus(
            ref UpdateCloudNativeIndexingStatusReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateCloudNativeIndexingStatusReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateCloudNativeIndexingStatus" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateCloudNativeRcvAzureStorageSettingReply? UpdateCloudNativeRcvAzureStorageSetting
        // GraphQL -> updateCloudNativeRcvAzureStorageSetting: UpdateCloudNativeRcvAzureStorageSettingReply! (type)
        public static string UpdateCloudNativeRcvAzureStorageSetting(
            ref UpdateCloudNativeRcvAzureStorageSettingReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateCloudNativeRcvAzureStorageSettingReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateCloudNativeRcvAzureStorageSetting" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateClusterDefaultAddressReply? UpdateClusterDefaultAddress
        // GraphQL -> updateClusterDefaultAddress: UpdateClusterDefaultAddressReply! (type)
        public static string UpdateClusterDefaultAddress(
            ref UpdateClusterDefaultAddressReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateClusterDefaultAddressReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateClusterDefaultAddress" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Cluster? UpdateClusterLocation
        // GraphQL -> updateClusterLocation: Cluster! (type)
        public static string UpdateClusterLocation(
            ref Cluster? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nclusterLocation: $clusterLocation\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new Cluster() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateClusterLocation" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ResponseSuccess? UpdateClusterNtpServers
        // GraphQL -> updateClusterNtpServers: ResponseSuccess! (type)
        public static string UpdateClusterNtpServers(
            ref ResponseSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ResponseSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateClusterNtpServers" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateClusterSettingsReply? UpdateClusterSettings
        // GraphQL -> updateClusterSettings: UpdateClusterSettingsReply! (type)
        public static string UpdateClusterSettings(
            ref UpdateClusterSettingsReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateClusterSettingsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateClusterSettings" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Analyzer? UpdateCustomAnalyzer
        // GraphQL -> updateCustomAnalyzer: Analyzer! (type)
        public static string UpdateCustomAnalyzer(
            ref Analyzer? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new Analyzer() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateCustomAnalyzer" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateCustomReportReply? UpdateCustomReport
        // GraphQL -> updateCustomReport: UpdateCustomReportReply! (type)
        public static string UpdateCustomReport(
            ref UpdateCustomReportReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateCustomReportReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateCustomReport" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> DbLogReportProperties? UpdateDatabaseLogReportingPropertiesForCluster
        // GraphQL -> updateDatabaseLogReportingPropertiesForCluster: DbLogReportProperties! (type)
        public static string UpdateDatabaseLogReportingPropertiesForCluster(
            ref DbLogReportProperties? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new DbLogReportProperties() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateDatabaseLogReportingPropertiesForCluster" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ResponseSuccess? UpdateDnsServersAndSearchDomains
        // GraphQL -> updateDnsServersAndSearchDomains: ResponseSuccess! (type)
        public static string UpdateDnsServersAndSearchDomains(
            ref ResponseSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ResponseSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateDnsServersAndSearchDomains" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateEventDigestReply? UpdateEventDigest
        // GraphQL -> updateEventDigest: UpdateEventDigestReply! (type)
        public static string UpdateEventDigest(
            ref UpdateEventDigestReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateEventDigestReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateEventDigest" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateFailoverClusterReply? UpdateFailoverCluster
        // GraphQL -> updateFailoverCluster: UpdateFailoverClusterReply! (type)
        public static string UpdateFailoverCluster(
            ref UpdateFailoverClusterReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateFailoverClusterReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateFailoverCluster" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateFailoverClusterAppReply? UpdateFailoverClusterApp
        // GraphQL -> updateFailoverClusterApp: UpdateFailoverClusterAppReply! (type)
        public static string UpdateFailoverClusterApp(
            ref UpdateFailoverClusterAppReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateFailoverClusterAppReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateFailoverClusterApp" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateFloatingIpsReply? UpdateFloatingIps
        // GraphQL -> updateFloatingIps: UpdateFloatingIpsReply! (type)
        public static string UpdateFloatingIps(
            ref UpdateFloatingIpsReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateFloatingIpsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateFloatingIps" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> GlobalSlaReply? UpdateGlobalSla
        // GraphQL -> updateGlobalSla: GlobalSlaReply! (type)
        public static string UpdateGlobalSla(
            ref GlobalSlaReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new GlobalSlaReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateGlobalSla" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateGuestCredentialReply? UpdateGuestCredential
        // GraphQL -> updateGuestCredential: UpdateGuestCredentialReply! (type)
        public static string UpdateGuestCredential(
            ref UpdateGuestCredentialReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateGuestCredentialReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateGuestCredential" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateHealthMonitorPolicyStatusReply? UpdateHealthMonitorPolicyStatus
        // GraphQL -> updateHealthMonitorPolicyStatus: UpdateHealthMonitorPolicyStatusReply! (type)
        public static string UpdateHealthMonitorPolicyStatus(
            ref UpdateHealthMonitorPolicyStatusReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateHealthMonitorPolicyStatusReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateHealthMonitorPolicyStatus" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateHypervVirtualMachineReply? UpdateHypervVirtualMachine
        // GraphQL -> updateHypervVirtualMachine: UpdateHypervVirtualMachineReply! (type)
        public static string UpdateHypervVirtualMachine(
            ref UpdateHypervVirtualMachineReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateHypervVirtualMachineReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateHypervVirtualMachine" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateHypervVirtualMachineSnapshotMountReply? UpdateHypervVirtualMachineSnapshotMount
        // GraphQL -> updateHypervVirtualMachineSnapshotMount: UpdateHypervVirtualMachineSnapshotMountReply! (type)
        public static string UpdateHypervVirtualMachineSnapshotMount(
            ref UpdateHypervVirtualMachineSnapshotMountReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateHypervVirtualMachineSnapshotMountReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateHypervVirtualMachineSnapshotMount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateInsightStateReply? UpdateInsightState
        // GraphQL -> updateInsightState: UpdateInsightStateReply! (type)
        public static string UpdateInsightState(
            ref UpdateInsightStateReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateInsightStateReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateInsightState" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> LambdaSettings? UpdateLambdaSettings
        // GraphQL -> updateLambdaSettings: LambdaSettings! (type)
        public static string UpdateLambdaSettings(
            ref LambdaSettings? fieldSpec
        )
        {
            string args = "\n(\nanomalyThreshold: $anomalyThreshold\nransomwareThreshold: $ransomwareThreshold\nisAnomalyAlertEnabled: $isAnomalyAlertEnabled\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new LambdaSettings() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateLambdaSettings" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateLockoutConfigReply? UpdateLockoutConfig
        // GraphQL -> updateLockoutConfig: UpdateLockoutConfigReply! (type)
        public static string UpdateLockoutConfig(
            ref UpdateLockoutConfigReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateLockoutConfigReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateLockoutConfig" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateManagedVolumeReply? UpdateManagedVolume
        // GraphQL -> updateManagedVolume: UpdateManagedVolumeReply! (type)
        public static string UpdateManagedVolume(
            ref UpdateManagedVolumeReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateManagedVolumeReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateManagedVolume" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> TargetMapping? UpdateManualTargetMapping
        // GraphQL -> updateManualTargetMapping: TargetMapping! (type)
        public static string UpdateManualTargetMapping(
            ref TargetMapping? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new TargetMapping() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateManualTargetMapping" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> MosaicAsyncResponse? UpdateMongodbSource
        // GraphQL -> updateMongodbSource: MosaicAsyncResponse! (type)
        public static string UpdateMongodbSource(
            ref MosaicAsyncResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new MosaicAsyncResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateMongodbSource" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> MosaicAsyncResponse? UpdateMosaicStore
        // GraphQL -> updateMosaicStore: MosaicAsyncResponse! (type)
        public static string UpdateMosaicStore(
            ref MosaicAsyncResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new MosaicAsyncResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateMosaicStore" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateMssqlDefaultPropertiesReply? UpdateMssqlDefaultProperties
        // GraphQL -> updateMssqlDefaultProperties: UpdateMssqlDefaultPropertiesReply! (type)
        public static string UpdateMssqlDefaultProperties(
            ref UpdateMssqlDefaultPropertiesReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateMssqlDefaultPropertiesReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateMssqlDefaultProperties" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateMssqlLogShippingConfigurationReply? UpdateMssqlLogShippingConfiguration
        // GraphQL -> updateMssqlLogShippingConfiguration: UpdateMssqlLogShippingConfigurationReply! (type)
        public static string UpdateMssqlLogShippingConfiguration(
            ref UpdateMssqlLogShippingConfigurationReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateMssqlLogShippingConfigurationReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateMssqlLogShippingConfiguration" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateNasSystemReply? UpdateNasSystem
        // GraphQL -> updateNasSystem: UpdateNasSystemReply! (type)
        public static string UpdateNasSystem(
            ref UpdateNasSystemReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateNasSystemReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateNasSystem" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateNetworkThrottleReply? UpdateNetworkThrottle
        // GraphQL -> updateNetworkThrottle: UpdateNetworkThrottleReply! (type)
        public static string UpdateNetworkThrottle(
            ref UpdateNetworkThrottleReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateNetworkThrottleReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateNetworkThrottle" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateNutanixClusterReply? UpdateNutanixCluster
        // GraphQL -> updateNutanixCluster: UpdateNutanixClusterReply! (type)
        public static string UpdateNutanixCluster(
            ref UpdateNutanixClusterReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateNutanixClusterReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateNutanixCluster" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateNutanixPrismCentralReply? UpdateNutanixPrismCentral
        // GraphQL -> updateNutanixPrismCentral: UpdateNutanixPrismCentralReply! (type)
        public static string UpdateNutanixPrismCentral(
            ref UpdateNutanixPrismCentralReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateNutanixPrismCentralReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateNutanixPrismCentral" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateO365AppAuthStatusReply? UpdateO365AppAuthStatus
        // GraphQL -> updateO365AppAuthStatus: UpdateO365AppAuthStatusReply! (type)
        public static string UpdateO365AppAuthStatus(
            ref UpdateO365AppAuthStatusReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateO365AppAuthStatusReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateO365AppAuthStatus" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateO365OrgCustomNameReply? UpdateO365OrgCustomName
        // GraphQL -> updateO365OrgCustomName: UpdateO365OrgCustomNameReply! (type)
        public static string UpdateO365OrgCustomName(
            ref UpdateO365OrgCustomNameReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateO365OrgCustomNameReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateO365OrgCustomName" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> OracleDbDetail? UpdateOracleDataGuardGroup
        // GraphQL -> updateOracleDataGuardGroup: OracleDbDetail! (type)
        public static string UpdateOracleDataGuardGroup(
            ref OracleDbDetail? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new OracleDbDetail() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateOracleDataGuardGroup" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateOrgReply? UpdateOrg
        // GraphQL -> updateOrg: UpdateOrgReply! (type)
        public static string UpdateOrg(
            ref UpdateOrgReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateOrgReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateOrg" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ClassificationPolicyDetail? UpdatePolicy
        // GraphQL -> updatePolicy: ClassificationPolicyDetail! (type)
        public static string UpdatePolicy(
            ref ClassificationPolicyDetail? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ClassificationPolicyDetail() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updatePolicy" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> Cluster? UpdatePreviewerClusterConfig
        // GraphQL -> updatePreviewerClusterConfig: Cluster! (type)
        public static string UpdatePreviewerClusterConfig(
            ref Cluster? fieldSpec
        )
        {
            string args = "\n(\npreviewerClusterConfig: $previewerClusterConfig\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new Cluster() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updatePreviewerClusterConfig" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateProxyConfigReply? UpdateProxyConfig
        // GraphQL -> updateProxyConfig: UpdateProxyConfigReply! (type)
        public static string UpdateProxyConfig(
            ref UpdateProxyConfigReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateProxyConfigReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateProxyConfig" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> TargetMapping? UpdateRcsAutomaticTargetMapping
        // GraphQL -> updateRcsAutomaticTargetMapping: TargetMapping! (type)
        public static string UpdateRcsAutomaticTargetMapping(
            ref TargetMapping? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new TargetMapping() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateRcsAutomaticTargetMapping" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateScheduledReportReply? UpdateScheduledReport
        // GraphQL -> updateScheduledReport: UpdateScheduledReportReply! (type)
        public static string UpdateScheduledReport(
            ref UpdateScheduledReportReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateScheduledReportReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateScheduledReport" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateServiceAccountReply? UpdateServiceAccount
        // GraphQL -> updateServiceAccount: UpdateServiceAccountReply! (type)
        public static string UpdateServiceAccount(
            ref UpdateServiceAccountReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateServiceAccountReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateServiceAccount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateSnmpConfigReply? UpdateSnmpConfig
        // GraphQL -> updateSnmpConfig: UpdateSnmpConfigReply! (type)
        public static string UpdateSnmpConfig(
            ref UpdateSnmpConfigReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateSnmpConfigReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateSnmpConfig" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateStorageArraysReply? UpdateStorageArrays
        // GraphQL -> updateStorageArrays: UpdateStorageArraysReply! (type)
        public static string UpdateStorageArrays(
            ref UpdateStorageArraysReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateStorageArraysReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateStorageArrays" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateSyslogExportRuleReply? UpdateSyslogExportRule
        // GraphQL -> updateSyslogExportRule: UpdateSyslogExportRuleReply! (type)
        public static string UpdateSyslogExportRule(
            ref UpdateSyslogExportRuleReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateSyslogExportRuleReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateSyslogExportRule" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateTunnelStatusReply? UpdateTunnelStatus
        // GraphQL -> updateTunnelStatus: UpdateTunnelStatusReply! (type)
        public static string UpdateTunnelStatus(
            ref UpdateTunnelStatusReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateTunnelStatusReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateTunnelStatus" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateVcenterReply? UpdateVcenter
        // GraphQL -> updateVcenter: UpdateVcenterReply! (type)
        public static string UpdateVcenter(
            ref UpdateVcenterReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateVcenterReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateVcenter" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestSuccess? UpdateVcenterHotAddBandwidth
        // GraphQL -> updateVcenterHotAddBandwidth: RequestSuccess! (type)
        public static string UpdateVcenterHotAddBandwidth(
            ref RequestSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateVcenterHotAddBandwidth" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestSuccess? UpdateVcenterHotAddNetwork
        // GraphQL -> updateVcenterHotAddNetwork: RequestSuccess! (type)
        public static string UpdateVcenterHotAddNetwork(
            ref RequestSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateVcenterHotAddNetwork" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateVolumeGroupReply? UpdateVolumeGroup
        // GraphQL -> updateVolumeGroup: UpdateVolumeGroupReply! (type)
        public static string UpdateVolumeGroup(
            ref UpdateVolumeGroupReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateVolumeGroupReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateVolumeGroup" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateVsphereAdvancedTagReply? UpdateVsphereAdvancedTag
        // GraphQL -> updateVsphereAdvancedTag: UpdateVsphereAdvancedTagReply! (type)
        public static string UpdateVsphereAdvancedTag(
            ref UpdateVsphereAdvancedTagReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateVsphereAdvancedTagReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateVsphereAdvancedTag" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestSuccess? UpdateVsphereVm
        // GraphQL -> updateVsphereVm: RequestSuccess! (type)
        public static string UpdateVsphereVm(
            ref RequestSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateVsphereVm" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpdateWebhookReply? UpdateWebhook
        // GraphQL -> updateWebhook: UpdateWebhookReply! (type)
        public static string UpdateWebhook(
            ref UpdateWebhookReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpdateWebhookReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "updateWebhook" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpgradeAzureCloudAccountReply? UpgradeAzureCloudAccount
        // GraphQL -> upgradeAzureCloudAccount: UpgradeAzureCloudAccountReply! (type)
        public static string UpgradeAzureCloudAccount(
            ref UpgradeAzureCloudAccountReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpgradeAzureCloudAccountReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "upgradeAzureCloudAccount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpgradeAzureCloudAccountPermissionsWithoutOauthReply? UpgradeAzureCloudAccountPermissionsWithoutOauth
        // GraphQL -> upgradeAzureCloudAccountPermissionsWithoutOauth: UpgradeAzureCloudAccountPermissionsWithoutOauthReply! (type)
        public static string UpgradeAzureCloudAccountPermissionsWithoutOauth(
            ref UpgradeAzureCloudAccountPermissionsWithoutOauthReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpgradeAzureCloudAccountPermissionsWithoutOauthReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "upgradeAzureCloudAccountPermissionsWithoutOauth" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> UpgradeGcpCloudAccountPermissionsWithoutOauthReply? UpgradeGcpCloudAccountPermissionsWithoutOauth
        // GraphQL -> upgradeGcpCloudAccountPermissionsWithoutOauth: UpgradeGcpCloudAccountPermissionsWithoutOauthReply! (type)
        public static string UpgradeGcpCloudAccountPermissionsWithoutOauth(
            ref UpgradeGcpCloudAccountPermissionsWithoutOauthReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new UpgradeGcpCloudAccountPermissionsWithoutOauthReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "upgradeGcpCloudAccountPermissionsWithoutOauth" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestSuccess? UpgradeIoFilter
        // GraphQL -> upgradeIoFilter: RequestSuccess! (type)
        public static string UpgradeIoFilter(
            ref RequestSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "upgradeIoFilter" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncJobStatus? UploadDatabaseSnapshotToBlobstore
        // GraphQL -> uploadDatabaseSnapshotToBlobstore: AsyncJobStatus! (type)
        public static string UploadDatabaseSnapshotToBlobstore(
            ref AsyncJobStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "uploadDatabaseSnapshotToBlobstore" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ValidateAndCreateAwsCloudAccountReply? ValidateAndCreateAwsCloudAccount
        // GraphQL -> validateAndCreateAwsCloudAccount: ValidateAndCreateAwsCloudAccountReply! (type)
        public static string ValidateAndCreateAwsCloudAccount(
            ref ValidateAndCreateAwsCloudAccountReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ValidateAndCreateAwsCloudAccountReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "validateAndCreateAwsCloudAccount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ValidateAndSaveCustomerKmsInfoReply? ValidateAndSaveCustomerKmsInfo
        // GraphQL -> validateAndSaveCustomerKmsInfo: ValidateAndSaveCustomerKmsInfoReply! (type)
        public static string ValidateAndSaveCustomerKmsInfo(
            ref ValidateAndSaveCustomerKmsInfoReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ValidateAndSaveCustomerKmsInfoReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "validateAndSaveCustomerKmsInfo" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> ValidateOracleAcoFileReply? ValidateOracleAcoFile
        // GraphQL -> validateOracleAcoFile: ValidateOracleAcoFileReply! (type)
        public static string ValidateOracleAcoFile(
            ref ValidateOracleAcoFileReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new ValidateOracleAcoFileReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "validateOracleAcoFile" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? ValidateOracleDatabaseBackups
        // GraphQL -> validateOracleDatabaseBackups: AsyncRequestStatus! (type)
        public static string ValidateOracleDatabaseBackups(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "validateOracleDatabaseBackups" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? VmwareDownloadSnapshotFromLocation
        // GraphQL -> vmwareDownloadSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string VmwareDownloadSnapshotFromLocation(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vmwareDownloadSnapshotFromLocation" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchAsyncRequestStatus? VsphereBulkOnDemandSnapshot
        // GraphQL -> vsphereBulkOnDemandSnapshot: BatchAsyncRequestStatus! (type)
        public static string VsphereBulkOnDemandSnapshot(
            ref BatchAsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchAsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vsphereBulkOnDemandSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? VsphereDeleteVcenter
        // GraphQL -> vsphereDeleteVcenter: AsyncRequestStatus! (type)
        public static string VsphereDeleteVcenter(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vsphereDeleteVcenter" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestSuccess? VsphereExcludeVmDisks
        // GraphQL -> vsphereExcludeVmDisks: RequestSuccess! (type)
        public static string VsphereExcludeVmDisks(
            ref RequestSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vsphereExcludeVmDisks" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? VsphereExportSnapshotToStandaloneHostV2
        // GraphQL -> vsphereExportSnapshotToStandaloneHostV2: AsyncRequestStatus! (type)
        public static string VsphereExportSnapshotToStandaloneHostV2(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vsphereExportSnapshotToStandaloneHostV2" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? VsphereOnDemandSnapshot
        // GraphQL -> vsphereOnDemandSnapshot: AsyncRequestStatus! (type)
        public static string VsphereOnDemandSnapshot(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vsphereOnDemandSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchAsyncRequestStatus? VsphereVmBatchExport
        // GraphQL -> vsphereVmBatchExport: BatchAsyncRequestStatus! (type)
        public static string VsphereVmBatchExport(
            ref BatchAsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchAsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vsphereVmBatchExport" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchAsyncRequestStatus? VsphereVmBatchExportV3
        // GraphQL -> vsphereVmBatchExportV3: BatchAsyncRequestStatus! (type)
        public static string VsphereVmBatchExportV3(
            ref BatchAsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchAsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vsphereVmBatchExportV3" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchAsyncRequestStatus? VsphereVmBatchInPlaceRecovery
        // GraphQL -> vsphereVmBatchInPlaceRecovery: BatchAsyncRequestStatus! (type)
        public static string VsphereVmBatchInPlaceRecovery(
            ref BatchAsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchAsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vsphereVmBatchInPlaceRecovery" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? VsphereVmDownloadSnapshot
        // GraphQL -> vsphereVmDownloadSnapshot: AsyncRequestStatus! (type)
        public static string VsphereVmDownloadSnapshot(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vsphereVmDownloadSnapshot" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? VsphereVmDownloadSnapshotFiles
        // GraphQL -> vsphereVmDownloadSnapshotFiles: AsyncRequestStatus! (type)
        public static string VsphereVmDownloadSnapshotFiles(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vsphereVmDownloadSnapshotFiles" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? VsphereVmExportSnapshotV2
        // GraphQL -> vsphereVmExportSnapshotV2: AsyncRequestStatus! (type)
        public static string VsphereVmExportSnapshotV2(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vsphereVmExportSnapshotV2" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? VsphereVmExportSnapshotV3
        // GraphQL -> vsphereVmExportSnapshotV3: AsyncRequestStatus! (type)
        public static string VsphereVmExportSnapshotV3(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vsphereVmExportSnapshotV3" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? VsphereVmExportSnapshotWithDownloadFromCloud
        // GraphQL -> vsphereVmExportSnapshotWithDownloadFromCloud: AsyncRequestStatus! (type)
        public static string VsphereVmExportSnapshotWithDownloadFromCloud(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vsphereVmExportSnapshotWithDownloadFromCloud" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchAsyncRequestStatus? VsphereVmInitiateBatchInstantRecovery
        // GraphQL -> vsphereVmInitiateBatchInstantRecovery: BatchAsyncRequestStatus! (type)
        public static string VsphereVmInitiateBatchInstantRecovery(
            ref BatchAsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchAsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vsphereVmInitiateBatchInstantRecovery" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> BatchAsyncRequestStatus? VsphereVmInitiateBatchLiveMountV2
        // GraphQL -> vsphereVmInitiateBatchLiveMountV2: BatchAsyncRequestStatus! (type)
        public static string VsphereVmInitiateBatchLiveMountV2(
            ref BatchAsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new BatchAsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vsphereVmInitiateBatchLiveMountV2" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? VsphereVmInitiateDiskMount
        // GraphQL -> vsphereVmInitiateDiskMount: AsyncRequestStatus! (type)
        public static string VsphereVmInitiateDiskMount(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vsphereVmInitiateDiskMount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? VsphereVmInitiateInPlaceRecovery
        // GraphQL -> vsphereVmInitiateInPlaceRecovery: AsyncRequestStatus! (type)
        public static string VsphereVmInitiateInPlaceRecovery(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vsphereVmInitiateInPlaceRecovery" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? VsphereVmInitiateInstantRecoveryV2
        // GraphQL -> vsphereVmInitiateInstantRecoveryV2: AsyncRequestStatus! (type)
        public static string VsphereVmInitiateInstantRecoveryV2(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vsphereVmInitiateInstantRecoveryV2" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? VsphereVmInitiateLiveMountV2
        // GraphQL -> vsphereVmInitiateLiveMountV2: AsyncRequestStatus! (type)
        public static string VsphereVmInitiateLiveMountV2(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vsphereVmInitiateLiveMountV2" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> VsphereVmListEsxiDatastoresReply? VsphereVmListEsxiDatastores
        // GraphQL -> vsphereVmListEsxiDatastores: VsphereVmListEsxiDatastoresReply! (type)
        public static string VsphereVmListEsxiDatastores(
            ref VsphereVmListEsxiDatastoresReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new VsphereVmListEsxiDatastoresReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vsphereVmListEsxiDatastores" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? VsphereVmMountRelocate
        // GraphQL -> vsphereVmMountRelocate: AsyncRequestStatus! (type)
        public static string VsphereVmMountRelocate(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vsphereVmMountRelocate" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? VsphereVmMountRelocateV2
        // GraphQL -> vsphereVmMountRelocateV2: AsyncRequestStatus! (type)
        public static string VsphereVmMountRelocateV2(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vsphereVmMountRelocateV2" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> VsphereVmPowerOnOffLiveMountReply? VsphereVmPowerOnOffLiveMount
        // GraphQL -> vsphereVmPowerOnOffLiveMount: VsphereVmPowerOnOffLiveMountReply! (type)
        public static string VsphereVmPowerOnOffLiveMount(
            ref VsphereVmPowerOnOffLiveMountReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new VsphereVmPowerOnOffLiveMountReply() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vsphereVmPowerOnOffLiveMount" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> VsphereAsyncRequestStatus? VsphereVmRecoverFiles
        // GraphQL -> vsphereVmRecoverFiles: VsphereAsyncRequestStatus! (type)
        public static string VsphereVmRecoverFiles(
            ref VsphereAsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new VsphereAsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vsphereVmRecoverFiles" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> AsyncRequestStatus? VsphereVmRecoverFilesNew
        // GraphQL -> vsphereVmRecoverFilesNew: AsyncRequestStatus! (type)
        public static string VsphereVmRecoverFilesNew(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vsphereVmRecoverFilesNew" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        //      C# -> RequestSuccess? VsphereVmRegisterAgent
        // GraphQL -> vsphereVmRegisterAgent: RequestSuccess! (type)
        public static string VsphereVmRegisterAgent(
            ref RequestSuccess? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (fieldSpec == null)
            {
                fieldSpec = new RequestSuccess() ;
                fieldSpec.ApplyExploratoryFieldSpec(new ExplorationContext());
            }
            return "vsphereVmRegisterAgent" + args + "{\n" +
                    fieldSpec.AsFieldSpec(1) +
                    "}\n";
        }

        #endregion

    } // class Mutation
    #endregion
}