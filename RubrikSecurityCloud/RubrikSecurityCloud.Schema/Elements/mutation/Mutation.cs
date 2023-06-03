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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region Mutation
    public class Mutation
    {
        #region members
        //      C# -> CloudAccount? CreateAwsAccount
        // GraphQL -> createAwsAccount: CloudAccount! (interface)
        public static string CreateAwsAccount(
            ref CloudAccount? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<CloudAccount>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (CloudAccount?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create CloudAccount? composite object");
                }
            }
            return new string(
                "createAwsAccount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Target? CreateAwsReaderTarget
        // GraphQL -> createAwsReaderTarget: Target! (interface)
        public static string CreateAwsReaderTarget(
            ref Target? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return new string(
                "createAwsReaderTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Target? CreateAwsTarget
        // GraphQL -> createAwsTarget: Target! (interface)
        public static string CreateAwsTarget(
            ref Target? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return new string(
                "createAwsTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CloudAccount? CreateAzureAccount
        // GraphQL -> createAzureAccount: CloudAccount! (interface)
        public static string CreateAzureAccount(
            ref CloudAccount? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<CloudAccount>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (CloudAccount?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create CloudAccount? composite object");
                }
            }
            return new string(
                "createAzureAccount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Target? CreateAzureReaderTarget
        // GraphQL -> createAzureReaderTarget: Target! (interface)
        public static string CreateAzureReaderTarget(
            ref Target? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return new string(
                "createAzureReaderTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Target? CreateAzureTarget
        // GraphQL -> createAzureTarget: Target! (interface)
        public static string CreateAzureTarget(
            ref Target? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return new string(
                "createAzureTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BlueprintNew? CreateBlueprint
        // GraphQL -> createBlueprint: BlueprintNew! (interface)
        public static string CreateBlueprint(
            ref BlueprintNew? cmdletReply
        )
        {
            string args = "\n(\nname: $name\nchildren: $children\nsourceLocationId: $sourceLocationId\nsourceLocationType: $sourceLocationType\ntargetLocationType: $targetLocationType\ntargetLocationId: $targetLocationId\nstatus: $status\nenableHydration: $enableHydration\ntimeoutBetweenPriorityGroups: $timeoutBetweenPriorityGroups\nblueprintRecoveryType: $blueprintRecoveryType\nisBlueprintVisible: $isBlueprintVisible\n)";
           if (cmdletReply == null)
            {
                var list = new List<BlueprintNew>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (BlueprintNew?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create BlueprintNew? composite object");
                }
            }
            return new string(
                "createBlueprint" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Target? CreateGcpReaderTarget
        // GraphQL -> createGcpReaderTarget: Target! (interface)
        public static string CreateGcpReaderTarget(
            ref Target? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return new string(
                "createGcpReaderTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Target? CreateGcpTarget
        // GraphQL -> createGcpTarget: Target! (interface)
        public static string CreateGcpTarget(
            ref Target? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return new string(
                "createGcpTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Target? CreateGlacierReaderTarget
        // GraphQL -> createGlacierReaderTarget: Target! (interface)
        public static string CreateGlacierReaderTarget(
            ref Target? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return new string(
                "createGlacierReaderTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Target? CreateNfsReaderTarget
        // GraphQL -> createNfsReaderTarget: Target! (interface)
        public static string CreateNfsReaderTarget(
            ref Target? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return new string(
                "createNfsReaderTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Target? CreateNfsTarget
        // GraphQL -> createNfsTarget: Target! (interface)
        public static string CreateNfsTarget(
            ref Target? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return new string(
                "createNfsTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Target? CreateRcsReaderTarget
        // GraphQL -> createRcsReaderTarget: Target! (interface)
        public static string CreateRcsReaderTarget(
            ref Target? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return new string(
                "createRcsReaderTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Target? CreateRcsTarget
        // GraphQL -> createRcsTarget: Target! (interface)
        public static string CreateRcsTarget(
            ref Target? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return new string(
                "createRcsTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<Target>? CreateRcvLocationsFromTemplate
        // GraphQL -> createRcvLocationsFromTemplate: [Target!]! (interface)
        public static string CreateRcvLocationsFromTemplate(
            ref List<Target>? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new List<Target>();
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createRcvLocationsFromTemplate" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Target? CreateS3CompatibleReaderTarget
        // GraphQL -> createS3CompatibleReaderTarget: Target! (interface)
        public static string CreateS3CompatibleReaderTarget(
            ref Target? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return new string(
                "createS3CompatibleReaderTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Target? CreateS3CompatibleTarget
        // GraphQL -> createS3CompatibleTarget: Target! (interface)
        public static string CreateS3CompatibleTarget(
            ref Target? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return new string(
                "createS3CompatibleTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Target? CreateTapeReaderTarget
        // GraphQL -> createTapeReaderTarget: Target! (interface)
        public static string CreateTapeReaderTarget(
            ref Target? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return new string(
                "createTapeReaderTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Target? CreateTapeTarget
        // GraphQL -> createTapeTarget: Target! (interface)
        public static string CreateTapeTarget(
            ref Target? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return new string(
                "createTapeTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CloudAccount? UpdateAwsAccount
        // GraphQL -> updateAwsAccount: CloudAccount! (interface)
        public static string UpdateAwsAccount(
            ref CloudAccount? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<CloudAccount>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (CloudAccount?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create CloudAccount? composite object");
                }
            }
            return new string(
                "updateAwsAccount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Target? UpdateAwsTarget
        // GraphQL -> updateAwsTarget: Target! (interface)
        public static string UpdateAwsTarget(
            ref Target? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return new string(
                "updateAwsTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CloudAccount? UpdateAzureAccount
        // GraphQL -> updateAzureAccount: CloudAccount! (interface)
        public static string UpdateAzureAccount(
            ref CloudAccount? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<CloudAccount>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (CloudAccount?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create CloudAccount? composite object");
                }
            }
            return new string(
                "updateAzureAccount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Target? UpdateAzureTarget
        // GraphQL -> updateAzureTarget: Target! (interface)
        public static string UpdateAzureTarget(
            ref Target? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return new string(
                "updateAzureTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BlueprintNew? UpdateBlueprint
        // GraphQL -> updateBlueprint: BlueprintNew! (interface)
        public static string UpdateBlueprint(
            ref BlueprintNew? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\nname: $name\nchildren: $children\nsourceLocationId: $sourceLocationId\nsourceLocationType: $sourceLocationType\ntargetLocationType: $targetLocationType\ntargetLocationId: $targetLocationId\nstatus: $status\nversion: $version\nenableHydration: $enableHydration\ntimeoutBetweenPriorityGroups: $timeoutBetweenPriorityGroups\nblueprintRecoveryType: $blueprintRecoveryType\nisBlueprintVisible: $isBlueprintVisible\n)";
           if (cmdletReply == null)
            {
                var list = new List<BlueprintNew>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (BlueprintNew?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create BlueprintNew? composite object");
                }
            }
            return new string(
                "updateBlueprint" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Target? UpdateGcpTarget
        // GraphQL -> updateGcpTarget: Target! (interface)
        public static string UpdateGcpTarget(
            ref Target? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return new string(
                "updateGcpTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Target? UpdateGlacierTarget
        // GraphQL -> updateGlacierTarget: Target! (interface)
        public static string UpdateGlacierTarget(
            ref Target? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return new string(
                "updateGlacierTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Target? UpdateNfsTarget
        // GraphQL -> updateNfsTarget: Target! (interface)
        public static string UpdateNfsTarget(
            ref Target? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return new string(
                "updateNfsTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Target? UpdateRcvTarget
        // GraphQL -> updateRcvTarget: Target! (interface)
        public static string UpdateRcvTarget(
            ref Target? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return new string(
                "updateRcvTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Target? UpdateS3CompatibleTarget
        // GraphQL -> updateS3CompatibleTarget: Target! (interface)
        public static string UpdateS3CompatibleTarget(
            ref Target? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return new string(
                "updateS3CompatibleTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Target? UpdateTapeTarget
        // GraphQL -> updateTapeTarget: Target! (interface)
        public static string UpdateTapeTarget(
            ref Target? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return new string(
                "updateTapeTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> System.Int64? AddCertificate
        // GraphQL -> addCertificate: Long! (scalar)
        public static string AddCertificate(
            ref System.Int64? cmdletReply
        )
        {
            string args = "\n(\nname: $name\ndescription: $description\ncsrId: $csrId\nprivateKey: $privateKey\ncertificate: $certificate\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("addCertificate" + args + "\n");
        }

        //      C# -> System.Boolean? AddInventoryWorkloads
        // GraphQL -> addInventoryWorkloads: Boolean! (scalar)
        public static string AddInventoryWorkloads(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("addInventoryWorkloads" + args + "\n");
        }

        //      C# -> System.String? AddPolicyObjects
        // GraphQL -> addPolicyObjects: String! (scalar)
        public static string AddPolicyObjects(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\npolicyIds: $policyIds\nobjectIds: $objectIds\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("addPolicyObjects" + args + "\n");
        }

        //      C# -> System.Boolean? AddRoleAssignments
        // GraphQL -> addRoleAssignments: Boolean! (scalar)
        public static string AddRoleAssignments(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nuserIds: $userIds\ngroupIds: $groupIds\nroleIds: $roleIds\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("addRoleAssignments" + args + "\n");
        }

        //      C# -> System.Boolean? AddSyslogConfiguration
        // GraphQL -> addSyslogConfiguration: Boolean! (scalar)
        public static string AddSyslogConfiguration(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nhostName: $hostName\nport: $port\nnetworkProtocolType: $networkProtocolType\nuseTLS: $useTLS\nsyslogFacility: $syslogFacility\nsyslogSeverity: $syslogSeverity\ntrustedCerts: $trustedCerts\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("addSyslogConfiguration" + args + "\n");
        }

        //      C# -> System.String? ApproveTprRequest
        // GraphQL -> approveTprRequest: Void (scalar)
        public static string ApproveTprRequest(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("approveTprRequest" + args + "\n");
        }

        //      C# -> System.String? ArchiveCrawl
        // GraphQL -> archiveCrawl: String! (scalar)
        public static string ArchiveCrawl(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ncrawlId: $crawlId\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("archiveCrawl" + args + "\n");
        }

        //      C# -> System.Boolean? BatchDeassignRoleFromUserGroups
        // GraphQL -> batchDeassignRoleFromUserGroups: Boolean! (scalar)
        public static string BatchDeassignRoleFromUserGroups(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nuserGroupToRoles: $userGroupToRoles\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("batchDeassignRoleFromUserGroups" + args + "\n");
        }

        //      C# -> System.String? BulkCancelFailovers
        // GraphQL -> bulkCancelFailovers: Void (scalar)
        public static string BulkCancelFailovers(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ncancelFailoversConfig: $cancelFailoversConfig\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("bulkCancelFailovers" + args + "\n");
        }

        //      C# -> System.Boolean? CancelActivitySeries
        // GraphQL -> cancelActivitySeries: Boolean! (scalar)
        public static string CancelActivitySeries(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("cancelActivitySeries" + args + "\n");
        }

        //      C# -> System.String? CancelThreatHunt
        // GraphQL -> cancelThreatHunt: Void (scalar)
        public static string CancelThreatHunt(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("cancelThreatHunt" + args + "\n");
        }

        //      C# -> System.Boolean? ChangePassword
        // GraphQL -> changePassword: Boolean! (scalar)
        public static string ChangePassword(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("changePassword" + args + "\n");
        }

        //      C# -> System.Boolean? ConfigureDns
        // GraphQL -> configureDns: Boolean! (scalar)
        public static string ConfigureDns(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ndnsAddresses: $dnsAddresses\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("configureDns" + args + "\n");
        }

        //      C# -> System.Boolean? ConfigureNtp
        // GraphQL -> configureNtp: Boolean! (scalar)
        public static string ConfigureNtp(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nntpAddresses: $ntpAddresses\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("configureNtp" + args + "\n");
        }

        //      C# -> System.String? CreateReplicationPair
        // GraphQL -> createReplicationPair: Void (scalar)
        public static string CreateReplicationPair(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("createReplicationPair" + args + "\n");
        }

        //      C# -> System.Int32? CreateReport
        // GraphQL -> createReport: Int! (scalar)
        public static string CreateReport(
            ref System.Int32? cmdletReply
        )
        {
            string args = "\n(\nreportConfig: $reportConfig\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("createReport" + args + "\n");
        }

        //      C# -> System.String? CreateRole
        // GraphQL -> createRole: UUID! (scalar)
        public static string CreateRole(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\nname: $name\ndescription: $description\npermissions: $permissions\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("createRole" + args + "\n");
        }

        //      C# -> System.String? CreateUser
        // GraphQL -> createUser: String! (scalar)
        public static string CreateUser(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\nemail: $email\nroleIds: $roleIds\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("createUser" + args + "\n");
        }

        //      C# -> System.String? CreateUserWithPassword
        // GraphQL -> createUserWithPassword: String! (scalar)
        public static string CreateUserWithPassword(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("createUserWithPassword" + args + "\n");
        }

        //      C# -> System.String? DeactivateCustomAnalyzer
        // GraphQL -> deactivateCustomAnalyzer: String! (scalar)
        public static string DeactivateCustomAnalyzer(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\nanalyzerId: $analyzerId\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deactivateCustomAnalyzer" + args + "\n");
        }

        //      C# -> List<System.String>? DeactivatePolicy
        // GraphQL -> deactivatePolicy: [String!]! (scalar)
        public static string DeactivatePolicy(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "\n(\npolicyId: $policyId\nrunAsync: $runAsync\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deactivatePolicy" + args + "\n");
        }

        //      C# -> System.Boolean? DeleteAccountSettingValue
        // GraphQL -> deleteAccountSettingValue: Boolean! (scalar)
        public static string DeleteAccountSettingValue(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\naspName: $aspName\naspComponent: $aspComponent\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteAccountSettingValue" + args + "\n");
        }

        //      C# -> System.String? DeleteAllOracleDatabaseSnapshots
        // GraphQL -> deleteAllOracleDatabaseSnapshots: Void (scalar)
        public static string DeleteAllOracleDatabaseSnapshots(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteAllOracleDatabaseSnapshots" + args + "\n");
        }

        //      C# -> System.String? DeleteAwsComputeSetting
        // GraphQL -> deleteAwsComputeSetting: Void (scalar)
        public static string DeleteAwsComputeSetting(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteAwsComputeSetting" + args + "\n");
        }

        //      C# -> System.Boolean? DeleteBlueprint
        // GraphQL -> deleteBlueprint: Boolean! (scalar)
        public static string DeleteBlueprint(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteBlueprint" + args + "\n");
        }

        //      C# -> System.Boolean? DeleteBlueprints
        // GraphQL -> deleteBlueprints: Boolean! (scalar)
        public static string DeleteBlueprints(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteBlueprints" + args + "\n");
        }

        //      C# -> System.Boolean? DeleteCertificate
        // GraphQL -> deleteCertificate: Boolean! (scalar)
        public static string DeleteCertificate(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ncertificateId: $certificateId\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteCertificate" + args + "\n");
        }

        //      C# -> System.String? DeleteCloudNativeLabelRule
        // GraphQL -> deleteCloudNativeLabelRule: Void (scalar)
        public static string DeleteCloudNativeLabelRule(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteCloudNativeLabelRule" + args + "\n");
        }

        //      C# -> System.String? DeleteCloudNativeTagRule
        // GraphQL -> deleteCloudNativeTagRule: Void (scalar)
        public static string DeleteCloudNativeTagRule(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteCloudNativeTagRule" + args + "\n");
        }

        //      C# -> System.String? DeleteCsr
        // GraphQL -> deleteCsr: Void (scalar)
        public static string DeleteCsr(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteCsr" + args + "\n");
        }

        //      C# -> System.String? DeleteCustomReport
        // GraphQL -> deleteCustomReport: Void (scalar)
        public static string DeleteCustomReport(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteCustomReport" + args + "\n");
        }

        //      C# -> System.String? DeleteEventDigest
        // GraphQL -> deleteEventDigest: Void (scalar)
        public static string DeleteEventDigest(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteEventDigest" + args + "\n");
        }

        //      C# -> System.Boolean? DeleteGuestCredentialById
        // GraphQL -> deleteGuestCredentialById: Boolean! (scalar)
        public static string DeleteGuestCredentialById(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteGuestCredentialById" + args + "\n");
        }

        //      C# -> System.Boolean? DeleteLdapPrincipals
        // GraphQL -> deleteLdapPrincipals: Boolean! (scalar)
        public static string DeleteLdapPrincipals(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nprincipalIds: $principalIds\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteLdapPrincipals" + args + "\n");
        }

        //      C# -> System.Boolean? DeleteOrg
        // GraphQL -> deleteOrg: Boolean! (scalar)
        public static string DeleteOrg(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteOrg" + args + "\n");
        }

        //      C# -> System.String? DeleteOrgNetwork
        // GraphQL -> deleteOrgNetwork: Void (scalar)
        public static string DeleteOrgNetwork(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteOrgNetwork" + args + "\n");
        }

        //      C# -> System.Boolean? DeletePolarisSnapshot
        // GraphQL -> deletePolarisSnapshot: Boolean! (scalar)
        public static string DeletePolarisSnapshot(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nsnapshotFid: $snapshotFid\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deletePolarisSnapshot" + args + "\n");
        }

        //      C# -> System.String? DeleteReplicationPair
        // GraphQL -> deleteReplicationPair: Void (scalar)
        public static string DeleteReplicationPair(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteReplicationPair" + args + "\n");
        }

        //      C# -> System.Boolean? DeleteReport
        // GraphQL -> deleteReport: Boolean! (scalar)
        public static string DeleteReport(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nreportID: $reportID\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteReport" + args + "\n");
        }

        //      C# -> System.Boolean? DeleteRole
        // GraphQL -> deleteRole: Boolean! (scalar)
        public static string DeleteRole(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nroleId: $roleId\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteRole" + args + "\n");
        }

        //      C# -> System.String? DeleteScheduledReport
        // GraphQL -> deleteScheduledReport: Void (scalar)
        public static string DeleteScheduledReport(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteScheduledReport" + args + "\n");
        }

        //      C# -> System.Boolean? DeleteServiceAccountsFromAccount
        // GraphQL -> deleteServiceAccountsFromAccount: Boolean! (scalar)
        public static string DeleteServiceAccountsFromAccount(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteServiceAccountsFromAccount" + args + "\n");
        }

        //      C# -> System.String? DeleteSmbDomain
        // GraphQL -> deleteSmbDomain: Void (scalar)
        public static string DeleteSmbDomain(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteSmbDomain" + args + "\n");
        }

        //      C# -> System.Boolean? DeleteSmtpConfiguration
        // GraphQL -> deleteSmtpConfiguration: Boolean! (scalar)
        public static string DeleteSmtpConfiguration(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteSmtpConfiguration" + args + "\n");
        }

        //      C# -> System.Boolean? DeleteSyslogConfiguration
        // GraphQL -> deleteSyslogConfiguration: Boolean! (scalar)
        public static string DeleteSyslogConfiguration(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nids: $ids\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteSyslogConfiguration" + args + "\n");
        }

        //      C# -> System.String? DeleteSyslogExportRule
        // GraphQL -> deleteSyslogExportRule: Void (scalar)
        public static string DeleteSyslogExportRule(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteSyslogExportRule" + args + "\n");
        }

        //      C# -> System.String? DeleteTarget
        // GraphQL -> deleteTarget: Void (scalar)
        public static string DeleteTarget(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteTarget" + args + "\n");
        }

        //      C# -> System.String? DeleteTargetMapping
        // GraphQL -> deleteTargetMapping: Void (scalar)
        public static string DeleteTargetMapping(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteTargetMapping" + args + "\n");
        }

        //      C# -> System.Boolean? DeleteTotpConfig
        // GraphQL -> deleteTotpConfig: Boolean! (scalar)
        public static string DeleteTotpConfig(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nuserId: $userId\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteTotpConfig" + args + "\n");
        }

        //      C# -> System.Boolean? DeleteTotpConfigs
        // GraphQL -> deleteTotpConfigs: Boolean! (scalar)
        public static string DeleteTotpConfigs(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteTotpConfigs" + args + "\n");
        }

        //      C# -> System.Boolean? DeleteUsersFromAccount
        // GraphQL -> deleteUsersFromAccount: Boolean! (scalar)
        public static string DeleteUsersFromAccount(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nids: $ids\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteUsersFromAccount" + args + "\n");
        }

        //      C# -> System.String? DeleteWebhook
        // GraphQL -> deleteWebhook: Void (scalar)
        public static string DeleteWebhook(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deleteWebhook" + args + "\n");
        }

        //      C# -> System.String? DenyTprRequests
        // GraphQL -> denyTprRequests: Void (scalar)
        public static string DenyTprRequests(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("denyTprRequests" + args + "\n");
        }

        //      C# -> System.String? DisableSupportUserAccess
        // GraphQL -> disableSupportUserAccess: Void (scalar)
        public static string DisableSupportUserAccess(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("disableSupportUserAccess" + args + "\n");
        }

        //      C# -> System.Boolean? DisableTprOrg
        // GraphQL -> disableTprOrg: Boolean! (scalar)
        public static string DisableTprOrg(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("disableTprOrg" + args + "\n");
        }

        //      C# -> System.String? EnableSupportUserAccess
        // GraphQL -> enableSupportUserAccess: Void (scalar)
        public static string EnableSupportUserAccess(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("enableSupportUserAccess" + args + "\n");
        }

        //      C# -> System.String? EnableThreatMonitoring
        // GraphQL -> enableThreatMonitoring: Void (scalar)
        public static string EnableThreatMonitoring(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("enableThreatMonitoring" + args + "\n");
        }

        //      C# -> System.Boolean? EnableTprOrg
        // GraphQL -> enableTprOrg: Boolean! (scalar)
        public static string EnableTprOrg(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("enableTprOrg" + args + "\n");
        }

        //      C# -> System.String? ExcludeAwsNativeEbsVolumesFromSnapshot
        // GraphQL -> excludeAwsNativeEbsVolumesFromSnapshot: Void (scalar)
        public static string ExcludeAwsNativeEbsVolumesFromSnapshot(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("excludeAwsNativeEbsVolumesFromSnapshot" + args + "\n");
        }

        //      C# -> System.String? ExcludeAzureNativeManagedDisksFromSnapshot
        // GraphQL -> excludeAzureNativeManagedDisksFromSnapshot: Void (scalar)
        public static string ExcludeAzureNativeManagedDisksFromSnapshot(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("excludeAzureNativeManagedDisksFromSnapshot" + args + "\n");
        }

        //      C# -> System.String? ExcludeSharepointObjectsFromProtection
        // GraphQL -> excludeSharepointObjectsFromProtection: Void (scalar)
        public static string ExcludeSharepointObjectsFromProtection(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("excludeSharepointObjectsFromProtection" + args + "\n");
        }

        //      C# -> System.Boolean? GcpCloudAccountAddManualAuthProject
        // GraphQL -> gcpCloudAccountAddManualAuthProject: Boolean! (scalar)
        public static string GcpCloudAccountAddManualAuthProject(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("gcpCloudAccountAddManualAuthProject" + args + "\n");
        }

        //      C# -> System.String? GcpNativeExcludeDisksFromInstanceSnapshot
        // GraphQL -> gcpNativeExcludeDisksFromInstanceSnapshot: Void (scalar)
        public static string GcpNativeExcludeDisksFromInstanceSnapshot(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("gcpNativeExcludeDisksFromInstanceSnapshot" + args + "\n");
        }

        //      C# -> System.Boolean? GcpSetDefaultServiceAccountJwtConfig
        // GraphQL -> gcpSetDefaultServiceAccountJwtConfig: Boolean! (scalar)
        public static string GcpSetDefaultServiceAccountJwtConfig(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("gcpSetDefaultServiceAccountJwtConfig" + args + "\n");
        }

        //      C# -> System.String? HideRevealNasNamespaces
        // GraphQL -> hideRevealNasNamespaces: Void (scalar)
        public static string HideRevealNasNamespaces(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("hideRevealNasNamespaces" + args + "\n");
        }

        //      C# -> System.Boolean? InviteSsoGroup
        // GraphQL -> inviteSsoGroup: Boolean! (scalar)
        public static string InviteSsoGroup(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("inviteSsoGroup" + args + "\n");
        }

        //      C# -> System.String? JoinSmbDomain
        // GraphQL -> joinSmbDomain: Void (scalar)
        public static string JoinSmbDomain(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("joinSmbDomain" + args + "\n");
        }

        //      C# -> System.Boolean? LockIsolatedRecovery
        // GraphQL -> lockIsolatedRecovery: Boolean! (scalar)
        public static string LockIsolatedRecovery(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("lockIsolatedRecovery" + args + "\n");
        }

        //      C# -> System.String? LockUsersByAdmin
        // GraphQL -> lockUsersByAdmin: Void (scalar)
        public static string LockUsersByAdmin(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("lockUsersByAdmin" + args + "\n");
        }

        //      C# -> System.String? MutateRole
        // GraphQL -> mutateRole: UUID! (scalar)
        public static string MutateRole(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\nroleId: $roleId\nname: $name\ndescription: $description\npermissions: $permissions\nprotectableClusters: $protectableClusters\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("mutateRole" + args + "\n");
        }

        //      C# -> System.Boolean? PatchAwsAuthenticationServerBasedCloudAccount
        // GraphQL -> patchAwsAuthenticationServerBasedCloudAccount: Boolean! (scalar)
        public static string PatchAwsAuthenticationServerBasedCloudAccount(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("patchAwsAuthenticationServerBasedCloudAccount" + args + "\n");
        }

        //      C# -> System.Boolean? PatchAwsIamUserBasedCloudAccount
        // GraphQL -> patchAwsIamUserBasedCloudAccount: Boolean! (scalar)
        public static string PatchAwsIamUserBasedCloudAccount(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("patchAwsIamUserBasedCloudAccount" + args + "\n");
        }

        //      C# -> System.String? PromoteReaderTarget
        // GraphQL -> promoteReaderTarget: Void (scalar)
        public static string PromoteReaderTarget(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("promoteReaderTarget" + args + "\n");
        }

        //      C# -> System.String? RefreshReaderTarget
        // GraphQL -> refreshReaderTarget: Void (scalar)
        public static string RefreshReaderTarget(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("refreshReaderTarget" + args + "\n");
        }

        //      C# -> System.Boolean? RemoveCdmCluster
        // GraphQL -> removeCdmCluster: Boolean! (scalar)
        public static string RemoveCdmCluster(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nclusterUUID: $clusterUUID\nisForce: $isForce\nexpireInDays: $expireInDays\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("removeCdmCluster" + args + "\n");
        }

        //      C# -> System.Boolean? RemoveInventoryWorkloads
        // GraphQL -> removeInventoryWorkloads: Boolean! (scalar)
        public static string RemoveInventoryWorkloads(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("removeInventoryWorkloads" + args + "\n");
        }

        //      C# -> System.Boolean? RemoveLdapIntegration
        // GraphQL -> removeLdapIntegration: Boolean! (scalar)
        public static string RemoveLdapIntegration(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nid: $id\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("removeLdapIntegration" + args + "\n");
        }

        //      C# -> List<System.String>? RemovePolicyObjects
        // GraphQL -> removePolicyObjects: [String!]! (scalar)
        public static string RemovePolicyObjects(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "\n(\npolicyIds: $policyIds\nobjectIds: $objectIds\nrunAsync: $runAsync\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("removePolicyObjects" + args + "\n");
        }

        //      C# -> System.String? RemovePrivateEndpointConnection
        // GraphQL -> removePrivateEndpointConnection: Void (scalar)
        public static string RemovePrivateEndpointConnection(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("removePrivateEndpointConnection" + args + "\n");
        }

        //      C# -> System.String? RevokeAllOrgRoles
        // GraphQL -> revokeAllOrgRoles: Void (scalar)
        public static string RevokeAllOrgRoles(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("revokeAllOrgRoles" + args + "\n");
        }

        //      C# -> System.String? SendPactsafeEvent
        // GraphQL -> sendPactsafeEvent: Void (scalar)
        public static string SendPactsafeEvent(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("sendPactsafeEvent" + args + "\n");
        }

        //      C# -> System.Boolean? SendScheduledReport
        // GraphQL -> sendScheduledReport: Boolean! (scalar)
        public static string SendScheduledReport(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("sendScheduledReport" + args + "\n");
        }

        //      C# -> System.Boolean? SendTestSmtpEmail
        // GraphQL -> sendTestSmtpEmail: Boolean! (scalar)
        public static string SendTestSmtpEmail(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nuseExisting: $useExisting\nrecipient: $recipient\nhostName: $hostName\nport: $port\nuserName: $userName\npassword: $password\ndefaultFromEmail: $defaultFromEmail\nsecurityType: $securityType\ntrustedCerts: $trustedCerts\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("sendTestSmtpEmail" + args + "\n");
        }

        //      C# -> System.Boolean? SendTestSyslog
        // GraphQL -> sendTestSyslog: Boolean! (scalar)
        public static string SendTestSyslog(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nconfig: $config\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("sendTestSyslog" + args + "\n");
        }

        //      C# -> System.Boolean? SetAzureCloudAccountCustomerAppCredentials
        // GraphQL -> setAzureCloudAccountCustomerAppCredentials: Boolean! (scalar)
        public static string SetAzureCloudAccountCustomerAppCredentials(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("setAzureCloudAccountCustomerAppCredentials" + args + "\n");
        }

        //      C# -> System.Boolean? SetFederatedLoginStatus
        // GraphQL -> setFederatedLoginStatus: Boolean! (scalar)
        public static string SetFederatedLoginStatus(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nfederatedLoginStatusArg: $federatedLoginStatusArg\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("setFederatedLoginStatus" + args + "\n");
        }

        //      C# -> System.Boolean? SetIpWhitelistEnabled
        // GraphQL -> setIpWhitelistEnabled: Boolean! (scalar)
        public static string SetIpWhitelistEnabled(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nenabled: $enabled\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("setIpWhitelistEnabled" + args + "\n");
        }

        //      C# -> System.Boolean? SetLdapMfaSetting
        // GraphQL -> setLdapMfaSetting: Boolean! (scalar)
        public static string SetLdapMfaSetting(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("setLdapMfaSetting" + args + "\n");
        }

        //      C# -> System.Boolean? SetMfaSetting
        // GraphQL -> setMfaSetting: Boolean! (scalar)
        public static string SetMfaSetting(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("setMfaSetting" + args + "\n");
        }

        //      C# -> System.String? SetPasswordComplexityPolicy
        // GraphQL -> setPasswordComplexityPolicy: Void (scalar)
        public static string SetPasswordComplexityPolicy(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("setPasswordComplexityPolicy" + args + "\n");
        }

        //      C# -> System.String? SetRansomwareInvestigationEnabled
        // GraphQL -> setRansomwareInvestigationEnabled: Void (scalar)
        public static string SetRansomwareInvestigationEnabled(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("setRansomwareInvestigationEnabled" + args + "\n");
        }

        //      C# -> System.Boolean? SetSmtpConfiguration
        // GraphQL -> setSmtpConfiguration: Boolean! (scalar)
        public static string SetSmtpConfiguration(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nhostName: $hostName\nport: $port\nuserName: $userName\npassword: $password\ndefaultFromEmail: $defaultFromEmail\nsecurityType: $securityType\ntrustedCerts: $trustedCerts\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("setSmtpConfiguration" + args + "\n");
        }

        //      C# -> System.String? SetSsoCertificate
        // GraphQL -> setSsoCertificate: Void (scalar)
        public static string SetSsoCertificate(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("setSsoCertificate" + args + "\n");
        }

        //      C# -> System.Boolean? SetTotpConfig
        // GraphQL -> setTotpConfig: Boolean! (scalar)
        public static string SetTotpConfig(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("setTotpConfig" + args + "\n");
        }

        //      C# -> System.Boolean? SetUserLevelTotpEnforcement
        // GraphQL -> setUserLevelTotpEnforcement: Boolean! (scalar)
        public static string SetUserLevelTotpEnforcement(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("setUserLevelTotpEnforcement" + args + "\n");
        }

        //      C# -> System.Boolean? SetWwwTlsCert
        // GraphQL -> setWwwTlsCert: Boolean! (scalar)
        public static string SetWwwTlsCert(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("setWwwTlsCert" + args + "\n");
        }

        //      C# -> System.String? SnoozeEula
        // GraphQL -> snoozeEula: Void (scalar)
        public static string SnoozeEula(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("snoozeEula" + args + "\n");
        }

        //      C# -> System.String? StopJobInstanceFromEventSeries
        // GraphQL -> stopJobInstanceFromEventSeries: Void (scalar)
        public static string StopJobInstanceFromEventSeries(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("stopJobInstanceFromEventSeries" + args + "\n");
        }

        //      C# -> System.Boolean? SubmitTprRequest
        // GraphQL -> submitTprRequest: Boolean! (scalar)
        public static string SubmitTprRequest(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("submitTprRequest" + args + "\n");
        }

        //      C# -> System.String? SyncRotateClusterEncryptionKey
        // GraphQL -> syncRotateClusterEncryptionKey: String! (scalar)
        public static string SyncRotateClusterEncryptionKey(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("syncRotateClusterEncryptionKey" + args + "\n");
        }

        //      C# -> System.Boolean? ToggleFeatureEnabled
        // GraphQL -> toggleFeatureEnabled: Boolean! (scalar)
        public static string ToggleFeatureEnabled(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nfeatureName: $featureName\nenableFeature: $enableFeature\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("toggleFeatureEnabled" + args + "\n");
        }

        //      C# -> System.Boolean? ToggleVmwareManagementEnabled
        // GraphQL -> toggleVMwareManagementEnabled: Boolean! (scalar)
        public static string ToggleVmwareManagementEnabled(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nenableVmwareManagement: $enableVmwareManagement\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("toggleVMwareManagementEnabled" + args + "\n");
        }

        //      C# -> System.String? UnlockUsersByAdmin
        // GraphQL -> unlockUsersByAdmin: Void (scalar)
        public static string UnlockUsersByAdmin(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("unlockUsersByAdmin" + args + "\n");
        }

        //      C# -> System.Boolean? UpdateAccountOwner
        // GraphQL -> updateAccountOwner: Boolean! (scalar)
        public static string UpdateAccountOwner(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nuserId: $userId\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateAccountOwner" + args + "\n");
        }

        //      C# -> System.String? UpdateAuthDomainUsersHiddenStatus
        // GraphQL -> updateAuthDomainUsersHiddenStatus: Void (scalar)
        public static string UpdateAuthDomainUsersHiddenStatus(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateAuthDomainUsersHiddenStatus" + args + "\n");
        }

        //      C# -> System.String? UpdateAwsCloudAccount
        // GraphQL -> updateAwsCloudAccount: Void (scalar)
        public static string UpdateAwsCloudAccount(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateAwsCloudAccount" + args + "\n");
        }

        //      C# -> System.Boolean? UpdateCertificate
        // GraphQL -> updateCertificate: Boolean! (scalar)
        public static string UpdateCertificate(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ncertificateId: $certificateId\nname: $name\ndescription: $description\ncertificate: $certificate\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateCertificate" + args + "\n");
        }

        //      C# -> System.Boolean? UpdateClassificationBannerEnabled
        // GraphQL -> updateClassificationBannerEnabled: Boolean! (scalar)
        public static string UpdateClassificationBannerEnabled(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateClassificationBannerEnabled" + args + "\n");
        }

        //      C# -> System.Boolean? UpdateClassificationBannerSettings
        // GraphQL -> updateClassificationBannerSettings: Boolean! (scalar)
        public static string UpdateClassificationBannerSettings(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nclassificationBannerSettingsArg: $classificationBannerSettingsArg\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateClassificationBannerSettings" + args + "\n");
        }

        //      C# -> System.Boolean? UpdateClassificationLoginEnabled
        // GraphQL -> updateClassificationLoginEnabled: Boolean! (scalar)
        public static string UpdateClassificationLoginEnabled(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateClassificationLoginEnabled" + args + "\n");
        }

        //      C# -> System.Boolean? UpdateClassificationLoginSettings
        // GraphQL -> updateClassificationLoginSettings: Boolean! (scalar)
        public static string UpdateClassificationLoginSettings(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nclassificationLoginSettingsArg: $classificationLoginSettingsArg\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateClassificationLoginSettings" + args + "\n");
        }

        //      C# -> System.String? UpdateCloudNativeLabelRule
        // GraphQL -> updateCloudNativeLabelRule: Void (scalar)
        public static string UpdateCloudNativeLabelRule(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateCloudNativeLabelRule" + args + "\n");
        }

        //      C# -> System.String? UpdateCloudNativeTagRule
        // GraphQL -> updateCloudNativeTagRule: Void (scalar)
        public static string UpdateCloudNativeTagRule(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateCloudNativeTagRule" + args + "\n");
        }

        //      C# -> System.String? UpdateConfiguredGroup
        // GraphQL -> updateConfiguredGroup: Void (scalar)
        public static string UpdateConfiguredGroup(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateConfiguredGroup" + args + "\n");
        }

        //      C# -> System.String? UpdateCustomerAppPermissionForAzureSql
        // GraphQL -> updateCustomerAppPermissionForAzureSql: Void (scalar)
        public static string UpdateCustomerAppPermissionForAzureSql(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateCustomerAppPermissionForAzureSql" + args + "\n");
        }

        //      C# -> System.Boolean? UpdateEulaAccepted
        // GraphQL -> updateEulaAccepted: Boolean! (scalar)
        public static string UpdateEulaAccepted(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateEulaAccepted" + args + "\n");
        }

        //      C# -> System.Boolean? UpdateIpWhitelist
        // GraphQL -> updateIpWhitelist: Boolean! (scalar)
        public static string UpdateIpWhitelist(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nwhitelistMode: $whitelistMode\nipCidrs: $ipCidrs\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateIpWhitelist" + args + "\n");
        }

        //      C# -> System.String? UpdateLdapIntegration
        // GraphQL -> updateLdapIntegration: String! (scalar)
        public static string UpdateLdapIntegration(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\nid: $id\nname: $name\nbindUserName: $bindUserName\nbindUserPassword: $bindUserPassword\nbaseDn: $baseDn\ntrustedCerts: $trustedCerts\ndynamicDnsName: $dynamicDnsName\nldapServers: $ldapServers\nuserSearchFilter: $userSearchFilter\nuserNameAttr: $userNameAttr\ngroupMembershipAttr: $groupMembershipAttr\ngroupSearchFilter: $groupSearchFilter\ngroupMemberAttr: $groupMemberAttr\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateLdapIntegration" + args + "\n");
        }

        //      C# -> System.String? UpdateNasShares
        // GraphQL -> updateNasShares: Void (scalar)
        public static string UpdateNasShares(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateNasShares" + args + "\n");
        }

        //      C# -> System.String? UpdateNutanixVm
        // GraphQL -> updateNutanixVm: Void (scalar)
        public static string UpdateNutanixVm(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateNutanixVm" + args + "\n");
        }

        //      C# -> System.String? UpdateO365AppPermissions
        // GraphQL -> updateO365AppPermissions: Void (scalar)
        public static string UpdateO365AppPermissions(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateO365AppPermissions" + args + "\n");
        }

        //      C# -> System.String? UpdateOrgSecurityPolicy
        // GraphQL -> updateOrgSecurityPolicy: Void (scalar)
        public static string UpdateOrgSecurityPolicy(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateOrgSecurityPolicy" + args + "\n");
        }

        //      C# -> System.String? UpdatePolarisReport
        // GraphQL -> updatePolarisReport: Void (scalar)
        public static string UpdatePolarisReport(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updatePolarisReport" + args + "\n");
        }

        //      C# -> System.String? UpdateReplicationTarget
        // GraphQL -> updateReplicationTarget: Void (scalar)
        public static string UpdateReplicationTarget(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateReplicationTarget" + args + "\n");
        }

        //      C# -> System.Boolean? UpdateReport
        // GraphQL -> updateReport: Boolean! (scalar)
        public static string UpdateReport(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nreportID: $reportID\nreportConfig: $reportConfig\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateReport" + args + "\n");
        }

        //      C# -> System.Boolean? UpdateRole
        // GraphQL -> updateRole: Boolean! (scalar)
        public static string UpdateRole(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nroleId: $roleId\nname: $name\ndescription: $description\npermissions: $permissions\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateRole" + args + "\n");
        }

        //      C# -> System.Boolean? UpdateRoleAssignments
        // GraphQL -> updateRoleAssignments: Boolean! (scalar)
        public static string UpdateRoleAssignments(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nuserIds: $userIds\ngroupIds: $groupIds\nroleIds: $roleIds\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateRoleAssignments" + args + "\n");
        }

        //      C# -> System.String? UpdateSupportUserAccess
        // GraphQL -> updateSupportUserAccess: Void (scalar)
        public static string UpdateSupportUserAccess(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateSupportUserAccess" + args + "\n");
        }

        //      C# -> System.Boolean? UpdateTprConfiguration
        // GraphQL -> updateTprConfiguration: Boolean! (scalar)
        public static string UpdateTprConfiguration(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateTprConfiguration" + args + "\n");
        }

        //      C# -> System.String? UpdateVcdVapp
        // GraphQL -> updateVcdVapp: Void (scalar)
        public static string UpdateVcdVapp(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateVcdVapp" + args + "\n");
        }

        //      C# -> System.String? UpdateWhitelistedAnalyzers
        // GraphQL -> updateWhitelistedAnalyzers: String! (scalar)
        public static string UpdateWhitelistedAnalyzers(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\nstdPath: $stdPath\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nanalyzerIds: $analyzerIds\nrunAsync: $runAsync\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("updateWhitelistedAnalyzers" + args + "\n");
        }

        //      C# -> System.Boolean? UpgradeAwsCloudAccountFeaturesWithoutCft
        // GraphQL -> upgradeAwsCloudAccountFeaturesWithoutCft: Boolean! (scalar)
        public static string UpgradeAwsCloudAccountFeaturesWithoutCft(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("upgradeAwsCloudAccountFeaturesWithoutCft" + args + "\n");
        }

        //      C# -> System.Boolean? UpgradeAwsIamUserBasedCloudAccountPermissions
        // GraphQL -> upgradeAwsIamUserBasedCloudAccountPermissions: Boolean! (scalar)
        public static string UpgradeAwsIamUserBasedCloudAccountPermissions(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("upgradeAwsIamUserBasedCloudAccountPermissions" + args + "\n");
        }

        //      C# -> System.String? UpgradeCdmManagedTarget
        // GraphQL -> upgradeCdmManagedTarget: Void (scalar)
        public static string UpgradeCdmManagedTarget(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("upgradeCdmManagedTarget" + args + "\n");
        }

        //      C# -> System.String? UpgradeToRsc
        // GraphQL -> upgradeToRsc: Void (scalar)
        public static string UpgradeToRsc(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("upgradeToRsc" + args + "\n");
        }

        //      C# -> System.String? VsphereVmDeleteSnapshot
        // GraphQL -> vsphereVmDeleteSnapshot: Void (scalar)
        public static string VsphereVmDeleteSnapshot(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("vsphereVmDeleteSnapshot" + args + "\n");
        }

        //      C# -> System.Boolean? WarmCloudNativeIndexCache
        // GraphQL -> warmCloudNativeIndexCache: Boolean! (scalar)
        public static string WarmCloudNativeIndexCache(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nworkloadId: $workloadId\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("warmCloudNativeIndexCache" + args + "\n");
        }

        //      C# -> System.Boolean? WarmSearchCache
        // GraphQL -> warmSearchCache: Boolean! (scalar)
        public static string WarmSearchCache(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("warmSearchCache" + args + "\n");
        }

        //      C# -> RequestStatus? AddAdGroupsToHierarchy
        // GraphQL -> addAdGroupsToHierarchy: RequestStatus! (type)
        public static string AddAdGroupsToHierarchy(
            ref RequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "addAdGroupsToHierarchy" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AddAndJoinSmbDomainReply? AddAndJoinSmbDomain
        // GraphQL -> addAndJoinSmbDomain: AddAndJoinSmbDomainReply! (type)
        public static string AddAndJoinSmbDomain(
            ref AddAndJoinSmbDomainReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AddAndJoinSmbDomainReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "addAndJoinSmbDomain" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AddAwsAuthenticationServerBasedCloudAccountReply? AddAwsAuthenticationServerBasedCloudAccount
        // GraphQL -> addAwsAuthenticationServerBasedCloudAccount: AddAwsAuthenticationServerBasedCloudAccountReply! (type)
        public static string AddAwsAuthenticationServerBasedCloudAccount(
            ref AddAwsAuthenticationServerBasedCloudAccountReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AddAwsAuthenticationServerBasedCloudAccountReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "addAwsAuthenticationServerBasedCloudAccount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AddAwsIamUserBasedCloudAccountReply? AddAwsIamUserBasedCloudAccount
        // GraphQL -> addAwsIamUserBasedCloudAccount: AddAwsIamUserBasedCloudAccountReply! (type)
        public static string AddAwsIamUserBasedCloudAccount(
            ref AddAwsIamUserBasedCloudAccountReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AddAwsIamUserBasedCloudAccountReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "addAwsIamUserBasedCloudAccount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AddAzureCloudAccountReply? AddAzureCloudAccount
        // GraphQL -> addAzureCloudAccount: AddAzureCloudAccountReply! (type)
        public static string AddAzureCloudAccount(
            ref AddAzureCloudAccountReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AddAzureCloudAccountReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "addAzureCloudAccount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AddAzureCloudAccountExocomputeConfigurationsReply? AddAzureCloudAccountExocomputeConfigurations
        // GraphQL -> addAzureCloudAccountExocomputeConfigurations: AddAzureCloudAccountExocomputeConfigurationsReply! (type)
        public static string AddAzureCloudAccountExocomputeConfigurations(
            ref AddAzureCloudAccountExocomputeConfigurationsReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AddAzureCloudAccountExocomputeConfigurationsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "addAzureCloudAccountExocomputeConfigurations" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AddAzureCloudAccountWithoutOauthReply? AddAzureCloudAccountWithoutOauth
        // GraphQL -> addAzureCloudAccountWithoutOauth: AddAzureCloudAccountWithoutOauthReply! (type)
        public static string AddAzureCloudAccountWithoutOauth(
            ref AddAzureCloudAccountWithoutOauthReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AddAzureCloudAccountWithoutOauthReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "addAzureCloudAccountWithoutOauth" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AddCloudNativeSqlServerBackupCredentialsReply? AddCloudNativeSqlServerBackupCredentials
        // GraphQL -> addCloudNativeSqlServerBackupCredentials: AddCloudNativeSqlServerBackupCredentialsReply! (type)
        public static string AddCloudNativeSqlServerBackupCredentials(
            ref AddCloudNativeSqlServerBackupCredentialsReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AddCloudNativeSqlServerBackupCredentialsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "addCloudNativeSqlServerBackupCredentials" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AddClusterCertificateReply? AddClusterCertificate
        // GraphQL -> addClusterCertificate: AddClusterCertificateReply! (type)
        public static string AddClusterCertificate(
            ref AddClusterCertificateReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AddClusterCertificateReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "addClusterCertificate" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AddClusterNodesReply? AddClusterNodes
        // GraphQL -> addClusterNodes: AddClusterNodesReply! (type)
        public static string AddClusterNodes(
            ref AddClusterNodesReply? cmdletReply
        )
        {
            string args = "\n(\nAddClusterNodesInput: $AddClusterNodesInput\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AddClusterNodesReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "addClusterNodes" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AddConfiguredGroupToHierarchyReply? AddConfiguredGroupToHierarchy
        // GraphQL -> addConfiguredGroupToHierarchy: AddConfiguredGroupToHierarchyReply! (type)
        public static string AddConfiguredGroupToHierarchy(
            ref AddConfiguredGroupToHierarchyReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AddConfiguredGroupToHierarchyReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "addConfiguredGroupToHierarchy" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AddDb2InstanceReply? AddDb2Instance
        // GraphQL -> addDb2Instance: AddDb2InstanceReply! (type)
        public static string AddDb2Instance(
            ref AddDb2InstanceReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AddDb2InstanceReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "addDb2Instance" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AddGlobalCertificateReply? AddGlobalCertificate
        // GraphQL -> addGlobalCertificate: AddGlobalCertificateReply! (type)
        public static string AddGlobalCertificate(
            ref AddGlobalCertificateReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AddGlobalCertificateReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "addGlobalCertificate" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AddManagedVolumeReply? AddManagedVolume
        // GraphQL -> addManagedVolume: AddManagedVolumeReply! (type)
        public static string AddManagedVolume(
            ref AddManagedVolumeReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AddManagedVolumeReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "addManagedVolume" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AddMongoSourceReply? AddMongoSource
        // GraphQL -> addMongoSource: AddMongoSourceReply! (type)
        public static string AddMongoSource(
            ref AddMongoSourceReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AddMongoSourceReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "addMongoSource" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MosaicAsyncResponse? AddMosaicStore
        // GraphQL -> addMosaicStore: MosaicAsyncResponse! (type)
        public static string AddMosaicStore(
            ref MosaicAsyncResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new MosaicAsyncResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "addMosaicStore" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CcProvisionJobReply? AddNodesToCloudCluster
        // GraphQL -> addNodesToCloudCluster: CcProvisionJobReply! (type)
        public static string AddNodesToCloudCluster(
            ref CcProvisionJobReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CcProvisionJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "addNodesToCloudCluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AddO365OrgResponse? AddO365Org
        // GraphQL -> addO365Org: AddO365OrgResponse! (type)
        public static string AddO365Org(
            ref AddO365OrgResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AddO365OrgResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "addO365Org" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AddSapHanaSystemReply? AddSapHanaSystem
        // GraphQL -> addSapHanaSystem: AddSapHanaSystemReply! (type)
        public static string AddSapHanaSystem(
            ref AddSapHanaSystemReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AddSapHanaSystemReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "addSapHanaSystem" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AddStorageArraysReply? AddStorageArrays
        // GraphQL -> addStorageArrays: AddStorageArraysReply! (type)
        public static string AddStorageArrays(
            ref AddStorageArraysReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AddStorageArraysReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "addStorageArrays" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AddSyslogExportRuleReply? AddSyslogExportRule
        // GraphQL -> addSyslogExportRule: AddSyslogExportRuleReply! (type)
        public static string AddSyslogExportRule(
            ref AddSyslogExportRuleReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AddSyslogExportRuleReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "addSyslogExportRule" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AddVcdInstancesReply? AddVcdInstances
        // GraphQL -> addVcdInstances: AddVcdInstancesReply! (type)
        public static string AddVcdInstances(
            ref AddVcdInstancesReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AddVcdInstancesReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "addVcdInstances" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? AddVlan
        // GraphQL -> addVlan: ResponseSuccess! (type)
        public static string AddVlan(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "addVlan" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AddVmAppConsistentSpecsReply? AddVmAppConsistentSpecs
        // GraphQL -> addVmAppConsistentSpecs: AddVmAppConsistentSpecsReply! (type)
        public static string AddVmAppConsistentSpecs(
            ref AddVmAppConsistentSpecsReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AddVmAppConsistentSpecsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "addVmAppConsistentSpecs" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ArchiveK8sClusterReply? ArchiveK8sCluster
        // GraphQL -> archiveK8sCluster: ArchiveK8sClusterReply! (type)
        public static string ArchiveK8sCluster(
            ref ArchiveK8sClusterReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ArchiveK8sClusterReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "archiveK8sCluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? AssignMssqlSlaDomainProperties
        // GraphQL -> assignMssqlSlaDomainProperties: ResponseSuccess! (type)
        public static string AssignMssqlSlaDomainProperties(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "assignMssqlSlaDomainProperties" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AssignMssqlSlaDomainPropertiesAsyncReply? AssignMssqlSlaDomainPropertiesAsync
        // GraphQL -> assignMssqlSlaDomainPropertiesAsync: AssignMssqlSlaDomainPropertiesAsyncReply! (type)
        public static string AssignMssqlSlaDomainPropertiesAsync(
            ref AssignMssqlSlaDomainPropertiesAsyncReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AssignMssqlSlaDomainPropertiesAsyncReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "assignMssqlSlaDomainPropertiesAsync" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SlaAssignResult? AssignProtection
        // GraphQL -> assignProtection: SlaAssignResult! (type)
        public static string AssignProtection(
            ref SlaAssignResult? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new SlaAssignResult() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "assignProtection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SlaAssignResult? AssignRetentionSlaToSnappables
        // GraphQL -> assignRetentionSLAToSnappables: SlaAssignResult! (type)
        public static string AssignRetentionSlaToSnappables(
            ref SlaAssignResult? cmdletReply
        )
        {
            string args = "\n(\nglobalSlaOptionalFid: $globalSlaOptionalFid\nglobalSlaAssignType: $globalSlaAssignType\nobjectIds: $objectIds\napplicableSnappableType: $applicableSnappableType\nshouldApplyToNonPolicySnapshots: $shouldApplyToNonPolicySnapshots\nuserNote: $userNote\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new SlaAssignResult() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "assignRetentionSLAToSnappables" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SlaAssignResult? AssignRetentionSlaToSnapshots
        // GraphQL -> assignRetentionSLAToSnapshots: SlaAssignResult! (type)
        public static string AssignRetentionSlaToSnapshots(
            ref SlaAssignResult? cmdletReply
        )
        {
            string args = "\n(\nglobalSlaOptionalFid: $globalSlaOptionalFid\nglobalSlaAssignType: $globalSlaAssignType\nsnapshotFids: $snapshotFids\nuserNote: $userNote\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new SlaAssignResult() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "assignRetentionSLAToSnapshots" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SlaAssignResult? AssignSla
        // GraphQL -> assignSla: SlaAssignResult! (type)
        public static string AssignSla(
            ref SlaAssignResult? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new SlaAssignResult() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "assignSla" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? AssignSlaToMongoDbCollection
        // GraphQL -> assignSlaToMongoDbCollection: AsyncRequestStatus! (type)
        public static string AssignSlaToMongoDbCollection(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "assignSlaToMongoDbCollection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<SlaAssignResult>? AssignSlasForSnappableHierarchies
        // GraphQL -> assignSlasForSnappableHierarchies: [SlaAssignResult!]! (type)
        public static string AssignSlasForSnappableHierarchies(
            ref List<SlaAssignResult>? cmdletReply
        )
        {
            string args = "\n(\nglobalSlaOptionalFid: $globalSlaOptionalFid\nglobalSlaAssignType: $globalSlaAssignType\nobjectIds: $objectIds\napplicableSnappableTypes: $applicableSnappableTypes\nshouldApplyToExistingSnapshots: $shouldApplyToExistingSnapshots\nshouldApplyToNonPolicySnapshots: $shouldApplyToNonPolicySnapshots\nglobalExistingSnapshotRetention: $globalExistingSnapshotRetention\nuserNote: $userNote\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new List<SlaAssignResult>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "assignSlasForSnappableHierarchies" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsCloudAccountCreateResponse? AwsCloudAccountInitiate
        // GraphQL -> awsCloudAccountInitiate: AwsCloudAccountCreateResponse! (type)
        public static string AwsCloudAccountInitiate(
            ref AwsCloudAccountCreateResponse? cmdletReply
        )
        {
            string args = "\n(\nawsCloudAccountInitiateArg: $awsCloudAccountInitiateArg\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AwsCloudAccountCreateResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsCloudAccountInitiate" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsCloudAccountUpdateFeatureResponse? AwsCloudAccountUpdateFeature
        // GraphQL -> awsCloudAccountUpdateFeature: AwsCloudAccountUpdateFeatureResponse! (type)
        public static string AwsCloudAccountUpdateFeature(
            ref AwsCloudAccountUpdateFeatureResponse? cmdletReply
        )
        {
            string args = "\n(\ncloudAccountUuid: $cloudAccountUuid\nfeatures: $features\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AwsCloudAccountUpdateFeatureResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsCloudAccountUpdateFeature" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsCloudAccountValidateResponse? AwsCloudAccountValidate
        // GraphQL -> awsCloudAccountValidate: AwsCloudAccountValidateResponse! (type)
        public static string AwsCloudAccountValidate(
            ref AwsCloudAccountValidateResponse? cmdletReply
        )
        {
            string args = "\n(\nawsCloudAccountValidateArg: $awsCloudAccountValidateArg\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AwsCloudAccountValidateResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsCloudAccountValidate" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeProtectionAccountAddResponse? AwsNativeProtectionAccountAdd
        // GraphQL -> awsNativeProtectionAccountAdd: AwsNativeProtectionAccountAddResponse! (type)
        public static string AwsNativeProtectionAccountAdd(
            ref AwsNativeProtectionAccountAddResponse? cmdletReply
        )
        {
            string args = "\n(\nawsNativeProtectionAccountAddArg: $awsNativeProtectionAccountAddArg\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AwsNativeProtectionAccountAddResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeProtectionAccountAdd" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestStatus? AzureOauthConsentComplete
        // GraphQL -> azureOauthConsentComplete: RequestStatus! (type)
        public static string AzureOauthConsentComplete(
            ref RequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureOauthConsentComplete" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureOauthConsentKickoffReply? AzureOauthConsentKickoff
        // GraphQL -> azureOauthConsentKickoff: AzureOauthConsentKickoffReply! (type)
        public static string AzureOauthConsentKickoff(
            ref AzureOauthConsentKickoffReply? cmdletReply
        )
        {
            string args = "";
           if (cmdletReply == null)
            {
                cmdletReply = new AzureOauthConsentKickoffReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureOauthConsentKickoff" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CreateOnDemandJobReply>? BackupAzureAdDirectory
        // GraphQL -> backupAzureAdDirectory: [CreateOnDemandJobReply!]! (type)
        public static string BackupAzureAdDirectory(
            ref List<CreateOnDemandJobReply>? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new List<CreateOnDemandJobReply>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "backupAzureAdDirectory" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CreateOnDemandJobReply>? BackupM365Mailbox
        // GraphQL -> backupM365Mailbox: [CreateOnDemandJobReply!]! (type)
        public static string BackupM365Mailbox(
            ref List<CreateOnDemandJobReply>? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new List<CreateOnDemandJobReply>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "backupM365Mailbox" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CreateOnDemandJobReply>? BackupM365Onedrive
        // GraphQL -> backupM365Onedrive: [CreateOnDemandJobReply!]! (type)
        public static string BackupM365Onedrive(
            ref List<CreateOnDemandJobReply>? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new List<CreateOnDemandJobReply>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "backupM365Onedrive" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CreateOnDemandJobReply>? BackupM365SharepointDrive
        // GraphQL -> backupM365SharepointDrive: [CreateOnDemandJobReply!]! (type)
        public static string BackupM365SharepointDrive(
            ref List<CreateOnDemandJobReply>? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new List<CreateOnDemandJobReply>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "backupM365SharepointDrive" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CreateOnDemandJobReply>? BackupM365Team
        // GraphQL -> backupM365Team: [CreateOnDemandJobReply!]! (type)
        public static string BackupM365Team(
            ref List<CreateOnDemandJobReply>? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new List<CreateOnDemandJobReply>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "backupM365Team" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncJobStatus? BackupO365Mailbox
        // GraphQL -> backupO365Mailbox: BatchAsyncJobStatus! (type)
        public static string BackupO365Mailbox(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\nmailboxIds: $mailboxIds\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "backupO365Mailbox" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncJobStatus? BackupO365Onedrive
        // GraphQL -> backupO365Onedrive: BatchAsyncJobStatus! (type)
        public static string BackupO365Onedrive(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "backupO365Onedrive" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? BackupO365SharePointSite
        // GraphQL -> backupO365SharePointSite: CreateOnDemandJobReply! (type)
        public static string BackupO365SharePointSite(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "backupO365SharePointSite" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncJobStatus? BackupO365SharepointDrive
        // GraphQL -> backupO365SharepointDrive: BatchAsyncJobStatus! (type)
        public static string BackupO365SharepointDrive(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "backupO365SharepointDrive" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? BackupO365SharepointList
        // GraphQL -> backupO365SharepointList: CreateOnDemandJobReply! (type)
        public static string BackupO365SharepointList(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "backupO365SharepointList" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncJobStatus? BackupO365Team
        // GraphQL -> backupO365Team: BatchAsyncJobStatus! (type)
        public static string BackupO365Team(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "backupO365Team" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchExportHypervVmReply? BatchExportHypervVm
        // GraphQL -> batchExportHypervVm: BatchExportHypervVmReply! (type)
        public static string BatchExportHypervVm(
            ref BatchExportHypervVmReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchExportHypervVmReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "batchExportHypervVm" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchExportNutanixVmReply? BatchExportNutanixVm
        // GraphQL -> batchExportNutanixVm: BatchExportNutanixVmReply! (type)
        public static string BatchExportNutanixVm(
            ref BatchExportNutanixVmReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchExportNutanixVmReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "batchExportNutanixVm" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchInstantRecoverHypervVmReply? BatchInstantRecoverHypervVm
        // GraphQL -> batchInstantRecoverHypervVm: BatchInstantRecoverHypervVmReply! (type)
        public static string BatchInstantRecoverHypervVm(
            ref BatchInstantRecoverHypervVmReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchInstantRecoverHypervVmReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "batchInstantRecoverHypervVm" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchMountHypervVmReply? BatchMountHypervVm
        // GraphQL -> batchMountHypervVm: BatchMountHypervVmReply! (type)
        public static string BatchMountHypervVm(
            ref BatchMountHypervVmReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchMountHypervVmReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "batchMountHypervVm" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchMountNutanixVmReply? BatchMountNutanixVm
        // GraphQL -> batchMountNutanixVm: BatchMountNutanixVmReply! (type)
        public static string BatchMountNutanixVm(
            ref BatchMountNutanixVmReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchMountNutanixVmReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "batchMountNutanixVm" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchOnDemandBackupHypervVmReply? BatchOnDemandBackupHypervVm
        // GraphQL -> batchOnDemandBackupHypervVm: BatchOnDemandBackupHypervVmReply! (type)
        public static string BatchOnDemandBackupHypervVm(
            ref BatchOnDemandBackupHypervVmReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchOnDemandBackupHypervVmReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "batchOnDemandBackupHypervVm" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchQuarantineSnapshotReply? BatchQuarantineSnapshot
        // GraphQL -> batchQuarantineSnapshot: BatchQuarantineSnapshotReply! (type)
        public static string BatchQuarantineSnapshot(
            ref BatchQuarantineSnapshotReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchQuarantineSnapshotReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "batchQuarantineSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchReleaseFromQuarantineSnapshotReply? BatchReleaseFromQuarantineSnapshot
        // GraphQL -> batchReleaseFromQuarantineSnapshot: BatchReleaseFromQuarantineSnapshotReply! (type)
        public static string BatchReleaseFromQuarantineSnapshot(
            ref BatchReleaseFromQuarantineSnapshotReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchReleaseFromQuarantineSnapshotReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "batchReleaseFromQuarantineSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BeginManagedVolumeSnapshotReply? BeginManagedVolumeSnapshot
        // GraphQL -> beginManagedVolumeSnapshot: BeginManagedVolumeSnapshotReply! (type)
        public static string BeginManagedVolumeSnapshot(
            ref BeginManagedVolumeSnapshotReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BeginManagedVolumeSnapshotReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "beginManagedVolumeSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? BlueprintFailoverReportGenerate
        // GraphQL -> blueprintFailoverReportGenerate: CreateOnDemandJobReply! (type)
        public static string BlueprintFailoverReportGenerate(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "\n(\nfailoverReportGeneratorJobConfig: $failoverReportGeneratorJobConfig\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "blueprintFailoverReportGenerate" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BrowseMssqlDatabaseSnapshotReply? BrowseMssqlDatabaseSnapshot
        // GraphQL -> browseMssqlDatabaseSnapshot: BrowseMssqlDatabaseSnapshotReply! (type)
        public static string BrowseMssqlDatabaseSnapshot(
            ref BrowseMssqlDatabaseSnapshotReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BrowseMssqlDatabaseSnapshotReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "browseMssqlDatabaseSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BulkAddKmipServerReply? BulkAddKmipServer
        // GraphQL -> bulkAddKmipServer: BulkAddKmipServerReply! (type)
        public static string BulkAddKmipServer(
            ref BulkAddKmipServerReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BulkAddKmipServerReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkAddKmipServer" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BulkCreateFilesetTemplatesReply? BulkCreateFilesetTemplates
        // GraphQL -> bulkCreateFilesetTemplates: BulkCreateFilesetTemplatesReply! (type)
        public static string BulkCreateFilesetTemplates(
            ref BulkCreateFilesetTemplatesReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BulkCreateFilesetTemplatesReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkCreateFilesetTemplates" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BulkCreateFilesetsReply? BulkCreateFilesets
        // GraphQL -> bulkCreateFilesets: BulkCreateFilesetsReply! (type)
        public static string BulkCreateFilesets(
            ref BulkCreateFilesetsReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BulkCreateFilesetsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkCreateFilesets" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BulkCreateNasFilesetsReply? BulkCreateNasFilesets
        // GraphQL -> bulkCreateNasFilesets: BulkCreateNasFilesetsReply! (type)
        public static string BulkCreateNasFilesets(
            ref BulkCreateNasFilesetsReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BulkCreateNasFilesetsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkCreateNasFilesets" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? BulkCreateOnDemandMssqlBackup
        // GraphQL -> bulkCreateOnDemandMssqlBackup: AsyncRequestStatus! (type)
        public static string BulkCreateOnDemandMssqlBackup(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkCreateOnDemandMssqlBackup" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MosaicAsyncResponse? BulkDeleteCassandraSources
        // GraphQL -> bulkDeleteCassandraSources: MosaicAsyncResponse! (type)
        public static string BulkDeleteCassandraSources(
            ref MosaicAsyncResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new MosaicAsyncResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkDeleteCassandraSources" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? BulkDeleteFailoverCluster
        // GraphQL -> bulkDeleteFailoverCluster: ResponseSuccess! (type)
        public static string BulkDeleteFailoverCluster(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkDeleteFailoverCluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? BulkDeleteFailoverClusterApp
        // GraphQL -> bulkDeleteFailoverClusterApp: ResponseSuccess! (type)
        public static string BulkDeleteFailoverClusterApp(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkDeleteFailoverClusterApp" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? BulkDeleteFileset
        // GraphQL -> bulkDeleteFileset: ResponseSuccess! (type)
        public static string BulkDeleteFileset(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkDeleteFileset" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? BulkDeleteFilesetTemplate
        // GraphQL -> bulkDeleteFilesetTemplate: ResponseSuccess! (type)
        public static string BulkDeleteFilesetTemplate(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkDeleteFilesetTemplate" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? BulkDeleteHost
        // GraphQL -> bulkDeleteHost: ResponseSuccess! (type)
        public static string BulkDeleteHost(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkDeleteHost" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MosaicAsyncResponse? BulkDeleteMongodbSources
        // GraphQL -> bulkDeleteMongodbSources: MosaicAsyncResponse! (type)
        public static string BulkDeleteMongodbSources(
            ref MosaicAsyncResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new MosaicAsyncResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkDeleteMongodbSources" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncRequestStatus? BulkDeleteNasSystems
        // GraphQL -> bulkDeleteNasSystems: BatchAsyncRequestStatus! (type)
        public static string BulkDeleteNasSystems(
            ref BatchAsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkDeleteNasSystems" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BulkOnDemandSnapshotNutanixVmReply? BulkOnDemandSnapshotNutanixVm
        // GraphQL -> bulkOnDemandSnapshotNutanixVm: BulkOnDemandSnapshotNutanixVmReply! (type)
        public static string BulkOnDemandSnapshotNutanixVm(
            ref BulkOnDemandSnapshotNutanixVmReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BulkOnDemandSnapshotNutanixVmReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkOnDemandSnapshotNutanixVm" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BulkRefreshHostsReply? BulkRefreshHosts
        // GraphQL -> bulkRefreshHosts: BulkRefreshHostsReply! (type)
        public static string BulkRefreshHosts(
            ref BulkRefreshHostsReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BulkRefreshHostsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkRefreshHosts" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BulkRegisterHostReply? BulkRegisterHost
        // GraphQL -> bulkRegisterHost: BulkRegisterHostReply! (type)
        public static string BulkRegisterHost(
            ref BulkRegisterHostReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BulkRegisterHostReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkRegisterHost" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BulkRotateClusterEncryptionKeyReply? BulkRotateClusterEncryptionKey
        // GraphQL -> bulkRotateClusterEncryptionKey: BulkRotateClusterEncryptionKeyReply! (type)
        public static string BulkRotateClusterEncryptionKey(
            ref BulkRotateClusterEncryptionKeyReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BulkRotateClusterEncryptionKeyReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkRotateClusterEncryptionKey" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> V1BulkUpdateExchangeDagResponse? BulkUpdateExchangeDag
        // GraphQL -> bulkUpdateExchangeDag: V1BulkUpdateExchangeDagResponse! (type)
        public static string BulkUpdateExchangeDag(
            ref V1BulkUpdateExchangeDagResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new V1BulkUpdateExchangeDagResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkUpdateExchangeDag" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BulkUpdateFilesetTemplateReply? BulkUpdateFilesetTemplate
        // GraphQL -> bulkUpdateFilesetTemplate: BulkUpdateFilesetTemplateReply! (type)
        public static string BulkUpdateFilesetTemplate(
            ref BulkUpdateFilesetTemplateReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BulkUpdateFilesetTemplateReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkUpdateFilesetTemplate" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BulkUpdateHostReply? BulkUpdateHost
        // GraphQL -> bulkUpdateHost: BulkUpdateHostReply! (type)
        public static string BulkUpdateHost(
            ref BulkUpdateHostReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BulkUpdateHostReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkUpdateHost" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BulkUpdateMssqlDbsReply? BulkUpdateMssqlDbs
        // GraphQL -> bulkUpdateMssqlDbs: BulkUpdateMssqlDbsReply! (type)
        public static string BulkUpdateMssqlDbs(
            ref BulkUpdateMssqlDbsReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BulkUpdateMssqlDbsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkUpdateMssqlDbs" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BulkUpdateOracleDatabasesReply? BulkUpdateOracleDatabases
        // GraphQL -> bulkUpdateOracleDatabases: BulkUpdateOracleDatabasesReply! (type)
        public static string BulkUpdateOracleDatabases(
            ref BulkUpdateOracleDatabasesReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BulkUpdateOracleDatabasesReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkUpdateOracleDatabases" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BulkUpdateOracleHostsReply? BulkUpdateOracleHosts
        // GraphQL -> bulkUpdateOracleHosts: BulkUpdateOracleHostsReply! (type)
        public static string BulkUpdateOracleHosts(
            ref BulkUpdateOracleHostsReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BulkUpdateOracleHostsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkUpdateOracleHosts" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BulkUpdateOracleRacsReply? BulkUpdateOracleRacs
        // GraphQL -> bulkUpdateOracleRacs: BulkUpdateOracleRacsReply! (type)
        public static string BulkUpdateOracleRacs(
            ref BulkUpdateOracleRacsReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BulkUpdateOracleRacsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkUpdateOracleRacs" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BulkUpdateSnapMirrorCloudReply? BulkUpdateSnapMirrorCloud
        // GraphQL -> bulkUpdateSnapMirrorCloud: BulkUpdateSnapMirrorCloudReply! (type)
        public static string BulkUpdateSnapMirrorCloud(
            ref BulkUpdateSnapMirrorCloudReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BulkUpdateSnapMirrorCloudReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkUpdateSnapMirrorCloud" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Result? CancelBlueprintFailover
        // GraphQL -> cancelBlueprintFailover: Result! (type)
        public static string CancelBlueprintFailover(
            ref Result? cmdletReply
        )
        {
            string args = "\n(\ntaskchainId: $taskchainId\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new Result() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cancelBlueprintFailover" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CancelBulkRecoveryReply? CancelBulkRecovery
        // GraphQL -> cancelBulkRecovery: CancelBulkRecoveryReply! (type)
        public static string CancelBulkRecovery(
            ref CancelBulkRecoveryReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CancelBulkRecoveryReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cancelBulkRecovery" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CancelJobReply? CancelDownloadPackage
        // GraphQL -> cancelDownloadPackage: CancelJobReply! (type)
        public static string CancelDownloadPackage(
            ref CancelJobReply? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CancelJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cancelDownloadPackage" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CancelJobReply? CancelScheduledUpgrade
        // GraphQL -> cancelScheduledUpgrade: CancelJobReply! (type)
        public static string CancelScheduledUpgrade(
            ref CancelJobReply? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CancelJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cancelScheduledUpgrade" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestStatus? CancelTaskchain
        // GraphQL -> cancelTaskchain: RequestStatus! (type)
        public static string CancelTaskchain(
            ref RequestStatus? cmdletReply
        )
        {
            string args = "\n(\ntaskchainId: $taskchainId\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cancelTaskchain" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ChangeVfdOnHostReply? ChangeVfdOnHost
        // GraphQL -> changeVfdOnHost: ChangeVfdOnHostReply! (type)
        public static string ChangeVfdOnHost(
            ref ChangeVfdOnHostReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ChangeVfdOnHostReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "changeVfdOnHost" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? CleanupBlueprintFailover
        // GraphQL -> cleanupBlueprintFailover: CreateOnDemandJobReply! (type)
        public static string CleanupBlueprintFailover(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "\n(\ncleanupJobconfig: $cleanupJobconfig\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cleanupBlueprintFailover" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CreateOnDemandJobReply>? CleanupIsolatedRecoveries
        // GraphQL -> cleanupIsolatedRecoveries: [CreateOnDemandJobReply!]! (type)
        public static string CleanupIsolatedRecoveries(
            ref List<CreateOnDemandJobReply>? cmdletReply
        )
        {
            string args = "\n(\ncleanupIsolatedRecoveriesJobInputConfig: $cleanupIsolatedRecoveriesJobInputConfig\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new List<CreateOnDemandJobReply>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cleanupIsolatedRecoveries" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? CleanupIsolatedRecovery
        // GraphQL -> cleanupIsolatedRecovery: CreateOnDemandJobReply! (type)
        public static string CleanupIsolatedRecovery(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "\n(\ncleanupIsolatedRecoveryJobconfig: $cleanupIsolatedRecoveryJobconfig\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cleanupIsolatedRecovery" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClearCloudNativeSqlServerBackupCredentialsReply? ClearCloudNativeSqlServerBackupCredentials
        // GraphQL -> clearCloudNativeSqlServerBackupCredentials: ClearCloudNativeSqlServerBackupCredentialsReply! (type)
        public static string ClearCloudNativeSqlServerBackupCredentials(
            ref ClearCloudNativeSqlServerBackupCredentialsReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ClearCloudNativeSqlServerBackupCredentialsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clearCloudNativeSqlServerBackupCredentials" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CloudNativeCheckRbaConnectivityReply? CloudNativeCheckRbaConnectivity
        // GraphQL -> cloudNativeCheckRbaConnectivity: CloudNativeCheckRbaConnectivityReply! (type)
        public static string CloudNativeCheckRbaConnectivity(
            ref CloudNativeCheckRbaConnectivityReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CloudNativeCheckRbaConnectivityReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudNativeCheckRbaConnectivity" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DownloadFilesReply? CloudNativeDownloadFiles
        // GraphQL -> cloudNativeDownloadFiles: DownloadFilesReply! (type)
        public static string CloudNativeDownloadFiles(
            ref DownloadFilesReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DownloadFilesReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudNativeDownloadFiles" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CompleteAzureAdAppSetupReply? CompleteAzureAdAppSetup
        // GraphQL -> completeAzureAdAppSetup: CompleteAzureAdAppSetupReply! (type)
        public static string CompleteAzureAdAppSetup(
            ref CompleteAzureAdAppSetupReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CompleteAzureAdAppSetupReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "completeAzureAdAppSetup" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CompleteAzureCloudAccountOauthReply? CompleteAzureCloudAccountOauth
        // GraphQL -> completeAzureCloudAccountOauth: CompleteAzureCloudAccountOauthReply! (type)
        public static string CompleteAzureCloudAccountOauth(
            ref CompleteAzureCloudAccountOauthReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CompleteAzureCloudAccountOauthReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "completeAzureCloudAccountOauth" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ConfigureSapHanaRestore
        // GraphQL -> configureSapHanaRestore: AsyncRequestStatus! (type)
        public static string ConfigureSapHanaRestore(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "configureSapHanaRestore" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TargetMapping? CreateAutomaticAwsTargetMapping
        // GraphQL -> createAutomaticAwsTargetMapping: TargetMapping! (type)
        public static string CreateAutomaticAwsTargetMapping(
            ref TargetMapping? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new TargetMapping() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createAutomaticAwsTargetMapping" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TargetMapping? CreateAutomaticAzureTargetMapping
        // GraphQL -> createAutomaticAzureTargetMapping: TargetMapping! (type)
        public static string CreateAutomaticAzureTargetMapping(
            ref TargetMapping? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new TargetMapping() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createAutomaticAzureTargetMapping" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TargetMapping? CreateAutomaticRcsTargetMapping
        // GraphQL -> createAutomaticRcsTargetMapping: TargetMapping! (type)
        public static string CreateAutomaticRcsTargetMapping(
            ref TargetMapping? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new TargetMapping() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createAutomaticRcsTargetMapping" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CcProvisionJobReply? CreateAwsCluster
        // GraphQL -> createAwsCluster: CcProvisionJobReply! (type)
        public static string CreateAwsCluster(
            ref CcProvisionJobReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CcProvisionJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createAwsCluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsComputeSettings? CreateAwsComputeSetting
        // GraphQL -> createAwsComputeSetting: AwsComputeSettings! (type)
        public static string CreateAwsComputeSetting(
            ref AwsComputeSettings? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AwsComputeSettings() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createAwsComputeSetting" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateAwsExocomputeConfigsReply? CreateAwsExocomputeConfigs
        // GraphQL -> createAwsExocomputeConfigs: CreateAwsExocomputeConfigsReply! (type)
        public static string CreateAwsExocomputeConfigs(
            ref CreateAwsExocomputeConfigsReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateAwsExocomputeConfigsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createAwsExocomputeConfigs" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CcProvisionJobReply? CreateAzureCluster
        // GraphQL -> createAzureCluster: CcProvisionJobReply! (type)
        public static string CreateAzureCluster(
            ref CcProvisionJobReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CcProvisionJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createAzureCluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateAzureSaasAppAadReply? CreateAzureSaasAppAad
        // GraphQL -> createAzureSaasAppAad: CreateAzureSaasAppAadReply! (type)
        public static string CreateAzureSaasAppAad(
            ref CreateAzureSaasAppAadReply? cmdletReply
        )
        {
            string args = "";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateAzureSaasAppAadReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createAzureSaasAppAad" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<BlueprintRecoverySpec>? CreateBlueprintRecoverySpec
        // GraphQL -> createBlueprintRecoverySpec: [BlueprintRecoverySpec!]! (type)
        public static string CreateBlueprintRecoverySpec(
            ref List<BlueprintRecoverySpec>? cmdletReply
        )
        {
            string args = "\n(\nblueprintId: $blueprintId\nspecType: $specType\nrecoveryConfigs: $recoveryConfigs\nisDefaultRecoverySpec: $isDefaultRecoverySpec\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new List<BlueprintRecoverySpec>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createBlueprintRecoverySpec" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MosaicAsyncResponse? CreateCassandraSource
        // GraphQL -> createCassandraSource: MosaicAsyncResponse! (type)
        public static string CreateCassandraSource(
            ref MosaicAsyncResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new MosaicAsyncResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createCassandraSource" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateCloudNativeAwsStorageSettingReply? CreateCloudNativeAwsStorageSetting
        // GraphQL -> createCloudNativeAwsStorageSetting: CreateCloudNativeAwsStorageSettingReply! (type)
        public static string CreateCloudNativeAwsStorageSetting(
            ref CreateCloudNativeAwsStorageSettingReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateCloudNativeAwsStorageSettingReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createCloudNativeAwsStorageSetting" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateCloudNativeAzureStorageSettingReply? CreateCloudNativeAzureStorageSetting
        // GraphQL -> createCloudNativeAzureStorageSetting: CreateCloudNativeAzureStorageSettingReply! (type)
        public static string CreateCloudNativeAzureStorageSetting(
            ref CreateCloudNativeAzureStorageSettingReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateCloudNativeAzureStorageSettingReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createCloudNativeAzureStorageSetting" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateCloudNativeLabelRuleReply? CreateCloudNativeLabelRule
        // GraphQL -> createCloudNativeLabelRule: CreateCloudNativeLabelRuleReply! (type)
        public static string CreateCloudNativeLabelRule(
            ref CreateCloudNativeLabelRuleReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateCloudNativeLabelRuleReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createCloudNativeLabelRule" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateCloudNativeRcvAzureStorageSettingReply? CreateCloudNativeRcvAzureStorageSetting
        // GraphQL -> createCloudNativeRcvAzureStorageSetting: CreateCloudNativeRcvAzureStorageSettingReply! (type)
        public static string CreateCloudNativeRcvAzureStorageSetting(
            ref CreateCloudNativeRcvAzureStorageSettingReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateCloudNativeRcvAzureStorageSettingReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createCloudNativeRcvAzureStorageSetting" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateCloudNativeTagRuleReply? CreateCloudNativeTagRule
        // GraphQL -> createCloudNativeTagRule: CreateCloudNativeTagRuleReply! (type)
        public static string CreateCloudNativeTagRule(
            ref CreateCloudNativeTagRuleReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateCloudNativeTagRuleReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createCloudNativeTagRule" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncJobStatus? CreateConfigProtectionBackup
        // GraphQL -> createConfigProtectionBackup: BatchAsyncJobStatus! (type)
        public static string CreateConfigProtectionBackup(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createConfigProtectionBackup" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? CreateConfigProtectionSetup
        // GraphQL -> createConfigProtectionSetup: AsyncJobStatus! (type)
        public static string CreateConfigProtectionSetup(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createConfigProtectionSetup" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Analyzer? CreateCustomAnalyzer
        // GraphQL -> createCustomAnalyzer: Analyzer! (type)
        public static string CreateCustomAnalyzer(
            ref Analyzer? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new Analyzer() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createCustomAnalyzer" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateCustomReportReply? CreateCustomReport
        // GraphQL -> createCustomReport: CreateCustomReportReply! (type)
        public static string CreateCustomReport(
            ref CreateCustomReportReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateCustomReportReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createCustomReport" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateDomainControllerSnapshot
        // GraphQL -> createDomainControllerSnapshot: AsyncRequestStatus! (type)
        public static string CreateDomainControllerSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createDomainControllerSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateDownloadSnapshotForVolumeGroup
        // GraphQL -> createDownloadSnapshotForVolumeGroup: AsyncRequestStatus! (type)
        public static string CreateDownloadSnapshotForVolumeGroup(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createDownloadSnapshotForVolumeGroup" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateExchangeMount
        // GraphQL -> createExchangeMount: AsyncRequestStatus! (type)
        public static string CreateExchangeMount(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createExchangeMount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateFailoverClusterReply? CreateFailoverCluster
        // GraphQL -> createFailoverCluster: CreateFailoverClusterReply! (type)
        public static string CreateFailoverCluster(
            ref CreateFailoverClusterReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateFailoverClusterReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createFailoverCluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateFailoverClusterAppReply? CreateFailoverClusterApp
        // GraphQL -> createFailoverClusterApp: CreateFailoverClusterAppReply! (type)
        public static string CreateFailoverClusterApp(
            ref CreateFailoverClusterAppReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateFailoverClusterAppReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createFailoverClusterApp" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateFilesetSnapshot
        // GraphQL -> createFilesetSnapshot: AsyncRequestStatus! (type)
        public static string CreateFilesetSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createFilesetSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GlobalSlaReply? CreateGlobalSla
        // GraphQL -> createGlobalSla: GlobalSlaReply! (type)
        public static string CreateGlobalSla(
            ref GlobalSlaReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new GlobalSlaReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createGlobalSla" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateGuestCredentialReply? CreateGuestCredential
        // GraphQL -> createGuestCredential: CreateGuestCredentialReply! (type)
        public static string CreateGuestCredential(
            ref CreateGuestCredentialReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateGuestCredentialReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createGuestCredential" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateHypervVirtualMachineSnapshotMount
        // GraphQL -> createHypervVirtualMachineSnapshotMount: AsyncRequestStatus! (type)
        public static string CreateHypervVirtualMachineSnapshotMount(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createHypervVirtualMachineSnapshotMount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateK8sAgentManifestReply? CreateK8sAgentManifest
        // GraphQL -> createK8sAgentManifest: CreateK8sAgentManifestReply! (type)
        public static string CreateK8sAgentManifest(
            ref CreateK8sAgentManifestReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateK8sAgentManifestReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createK8sAgentManifest" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateK8sClusterReply? CreateK8sCluster
        // GraphQL -> createK8sCluster: CreateK8sClusterReply! (type)
        public static string CreateK8sCluster(
            ref CreateK8sClusterReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateK8sClusterReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createK8sCluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CreateOnDemandJobReply>? CreateK8sNamespaceSnapshots
        // GraphQL -> createK8sNamespaceSnapshots: [CreateOnDemandJobReply!]! (type)
        public static string CreateK8sNamespaceSnapshots(
            ref List<CreateOnDemandJobReply>? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new List<CreateOnDemandJobReply>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createK8sNamespaceSnapshots" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateLegalHoldReply? CreateLegalHold
        // GraphQL -> createLegalHold: CreateLegalHoldReply! (type)
        public static string CreateLegalHold(
            ref CreateLegalHoldReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateLegalHoldReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createLegalHold" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TargetMapping? CreateManualTargetMapping
        // GraphQL -> createManualTargetMapping: TargetMapping! (type)
        public static string CreateManualTargetMapping(
            ref TargetMapping? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new TargetMapping() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createManualTargetMapping" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MosaicAsyncResponse? CreateMongodbSource
        // GraphQL -> createMongodbSource: MosaicAsyncResponse! (type)
        public static string CreateMongodbSource(
            ref MosaicAsyncResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new MosaicAsyncResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createMongodbSource" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateMssqlLiveMount
        // GraphQL -> createMssqlLiveMount: AsyncRequestStatus! (type)
        public static string CreateMssqlLiveMount(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createMssqlLiveMount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateMssqlLogShippingConfiguration
        // GraphQL -> createMssqlLogShippingConfiguration: AsyncRequestStatus! (type)
        public static string CreateMssqlLogShippingConfiguration(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createMssqlLogShippingConfiguration" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateNutanixCluster
        // GraphQL -> createNutanixCluster: AsyncRequestStatus! (type)
        public static string CreateNutanixCluster(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createNutanixCluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncRequestStatus? CreateNutanixPrismCentral
        // GraphQL -> createNutanixPrismCentral: BatchAsyncRequestStatus! (type)
        public static string CreateNutanixPrismCentral(
            ref BatchAsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createNutanixPrismCentral" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestStatus? CreateO365AppComplete
        // GraphQL -> createO365AppComplete: RequestStatus! (type)
        public static string CreateO365AppComplete(
            ref RequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createO365AppComplete" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateO365AppKickoffResp? CreateO365AppKickoff
        // GraphQL -> createO365AppKickoff: CreateO365AppKickoffResp! (type)
        public static string CreateO365AppKickoff(
            ref CreateO365AppKickoffResp? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateO365AppKickoffResp() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createO365AppKickoff" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandDb2Backup
        // GraphQL -> createOnDemandDb2Backup: AsyncRequestStatus! (type)
        public static string CreateOnDemandDb2Backup(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createOnDemandDb2Backup" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandExchangeBackup
        // GraphQL -> createOnDemandExchangeBackup: AsyncRequestStatus! (type)
        public static string CreateOnDemandExchangeBackup(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createOnDemandExchangeBackup" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandMssqlBackup
        // GraphQL -> createOnDemandMssqlBackup: AsyncRequestStatus! (type)
        public static string CreateOnDemandMssqlBackup(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createOnDemandMssqlBackup" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandNutanixBackup
        // GraphQL -> createOnDemandNutanixBackup: AsyncRequestStatus! (type)
        public static string CreateOnDemandNutanixBackup(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createOnDemandNutanixBackup" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandSapHanaBackup
        // GraphQL -> createOnDemandSapHanaBackup: AsyncRequestStatus! (type)
        public static string CreateOnDemandSapHanaBackup(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createOnDemandSapHanaBackup" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandVolumeGroupBackup
        // GraphQL -> createOnDemandVolumeGroupBackup: AsyncRequestStatus! (type)
        public static string CreateOnDemandVolumeGroupBackup(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createOnDemandVolumeGroupBackup" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateOrUpdateManagedVolumeLogExport
        // GraphQL -> createOrUpdateManagedVolumeLogExport: AsyncRequestStatus! (type)
        public static string CreateOrUpdateManagedVolumeLogExport(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createOrUpdateManagedVolumeLogExport" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateOraclePdbRestore
        // GraphQL -> createOraclePdbRestore: AsyncRequestStatus! (type)
        public static string CreateOraclePdbRestore(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createOraclePdbRestore" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateOrgReply? CreateOrg
        // GraphQL -> createOrg: CreateOrgReply! (type)
        public static string CreateOrg(
            ref CreateOrgReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateOrgReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createOrg" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateOrgNetworkReply? CreateOrgNetwork
        // GraphQL -> createOrgNetwork: CreateOrgNetworkReply! (type)
        public static string CreateOrgNetwork(
            ref CreateOrgNetworkReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateOrgNetworkReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createOrgNetwork" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateOrgSwitchSessionReply? CreateOrgSwitchSession
        // GraphQL -> createOrgSwitchSession: CreateOrgSwitchSessionReply! (type)
        public static string CreateOrgSwitchSession(
            ref CreateOrgSwitchSessionReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateOrgSwitchSessionReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createOrgSwitchSession" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreatePolarisReportReply? CreatePolarisReport
        // GraphQL -> createPolarisReport: CreatePolarisReportReply! (type)
        public static string CreatePolarisReport(
            ref CreatePolarisReportReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreatePolarisReportReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createPolarisReport" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClassificationPolicyDetail? CreatePolicy
        // GraphQL -> createPolicy: ClassificationPolicyDetail! (type)
        public static string CreatePolicy(
            ref ClassificationPolicyDetail? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ClassificationPolicyDetail() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createPolicy" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateRcvPrivateEndpointApprovalRequestReply? CreateRcvPrivateEndpointApprovalRequest
        // GraphQL -> createRcvPrivateEndpointApprovalRequest: CreateRcvPrivateEndpointApprovalRequestReply! (type)
        public static string CreateRcvPrivateEndpointApprovalRequest(
            ref CreateRcvPrivateEndpointApprovalRequestReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateRcvPrivateEndpointApprovalRequestReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createRcvPrivateEndpointApprovalRequest" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateSapHanaSystemRefresh
        // GraphQL -> createSapHanaSystemRefresh: AsyncRequestStatus! (type)
        public static string CreateSapHanaSystemRefresh(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createSapHanaSystemRefresh" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateScheduledReportReply? CreateScheduledReport
        // GraphQL -> createScheduledReport: CreateScheduledReportReply! (type)
        public static string CreateScheduledReport(
            ref CreateScheduledReportReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateScheduledReportReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createScheduledReport" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateServiceAccountReply? CreateServiceAccount
        // GraphQL -> createServiceAccount: CreateServiceAccountReply! (type)
        public static string CreateServiceAccount(
            ref CreateServiceAccountReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateServiceAccountReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createServiceAccount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateSnapMirrorCloudReply? CreateSnapMirrorCloud
        // GraphQL -> createSnapMirrorCloud: CreateSnapMirrorCloudReply! (type)
        public static string CreateSnapMirrorCloud(
            ref CreateSnapMirrorCloudReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateSnapMirrorCloudReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createSnapMirrorCloud" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateSnapMirrorCloudRelationshipReply? CreateSnapMirrorCloudRelationship
        // GraphQL -> createSnapMirrorCloudRelationship: CreateSnapMirrorCloudRelationshipReply! (type)
        public static string CreateSnapMirrorCloudRelationship(
            ref CreateSnapMirrorCloudRelationshipReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateSnapMirrorCloudRelationshipReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createSnapMirrorCloudRelationship" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateSnapMirrorCloudRestoreJob
        // GraphQL -> createSnapMirrorCloudRestoreJob: AsyncRequestStatus! (type)
        public static string CreateSnapMirrorCloudRestoreJob(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createSnapMirrorCloudRestoreJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateSnapMirrorCloudSnapshot
        // GraphQL -> createSnapMirrorCloudSnapshot: AsyncRequestStatus! (type)
        public static string CreateSnapMirrorCloudSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createSnapMirrorCloudSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateSupportCaseReply? CreateSupportCase
        // GraphQL -> createSupportCase: CreateSupportCaseReply! (type)
        public static string CreateSupportCase(
            ref CreateSupportCaseReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateSupportCaseReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createSupportCase" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AsyncRequestStatus>? CreateVappExport
        // GraphQL -> createVappExport: [AsyncRequestStatus!]! (type)
        public static string CreateVappExport(
            ref List<AsyncRequestStatus>? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new List<AsyncRequestStatus>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createVappExport" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateVappSnapshotsReply? CreateVappSnapshots
        // GraphQL -> createVappSnapshots: CreateVappSnapshotsReply! (type)
        public static string CreateVappSnapshots(
            ref CreateVappSnapshotsReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateVappSnapshotsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createVappSnapshots" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CreateVappTemplateSnapshotExport
        // GraphQL -> createVappTemplateSnapshotExport: AsyncRequestStatus! (type)
        public static string CreateVappTemplateSnapshotExport(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createVappTemplateSnapshotExport" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateVappsInstantRecoveryReply? CreateVappsInstantRecovery
        // GraphQL -> createVappsInstantRecovery: CreateVappsInstantRecoveryReply! (type)
        public static string CreateVappsInstantRecovery(
            ref CreateVappsInstantRecoveryReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateVappsInstantRecoveryReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createVappsInstantRecovery" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateVsphereAdvancedTagReply? CreateVsphereAdvancedTag
        // GraphQL -> createVsphereAdvancedTag: CreateVsphereAdvancedTagReply! (type)
        public static string CreateVsphereAdvancedTag(
            ref CreateVsphereAdvancedTagReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateVsphereAdvancedTagReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createVsphereAdvancedTag" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateVsphereVcenterReply? CreateVsphereVcenter
        // GraphQL -> createVsphereVcenter: CreateVsphereVcenterReply! (type)
        public static string CreateVsphereVcenter(
            ref CreateVsphereVcenterReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateVsphereVcenterReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createVsphereVcenter" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateWebhookReply? CreateWebhook
        // GraphQL -> createWebhook: CreateWebhookReply! (type)
        public static string CreateWebhook(
            ref CreateWebhookReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateWebhookReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "createWebhook" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestStatus? DeleteAdGroupsFromHierarchy
        // GraphQL -> deleteAdGroupsFromHierarchy: RequestStatus! (type)
        public static string DeleteAdGroupsFromHierarchy(
            ref RequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteAdGroupsFromHierarchy" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? DeleteAllSnapMirrorCloudSnapshots
        // GraphQL -> deleteAllSnapMirrorCloudSnapshots: ResponseSuccess! (type)
        public static string DeleteAllSnapMirrorCloudSnapshots(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteAllSnapMirrorCloudSnapshots" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DeleteAwsCloudAccountWithoutCftReply? DeleteAwsCloudAccountWithoutCft
        // GraphQL -> deleteAwsCloudAccountWithoutCft: DeleteAwsCloudAccountWithoutCftReply! (type)
        public static string DeleteAwsCloudAccountWithoutCft(
            ref DeleteAwsCloudAccountWithoutCftReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DeleteAwsCloudAccountWithoutCftReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteAwsCloudAccountWithoutCft" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CcProvisionJobReply? DeleteAwsCluster
        // GraphQL -> deleteAwsCluster: CcProvisionJobReply! (type)
        public static string DeleteAwsCluster(
            ref CcProvisionJobReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CcProvisionJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteAwsCluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DeleteAwsExocomputeConfigsReply? DeleteAwsExocomputeConfigs
        // GraphQL -> deleteAwsExocomputeConfigs: DeleteAwsExocomputeConfigsReply! (type)
        public static string DeleteAwsExocomputeConfigs(
            ref DeleteAwsExocomputeConfigsReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DeleteAwsExocomputeConfigsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteAwsExocomputeConfigs" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DeleteAwsIamUserBasedCloudAccountReply? DeleteAwsIamUserBasedCloudAccount
        // GraphQL -> deleteAwsIamUserBasedCloudAccount: DeleteAwsIamUserBasedCloudAccountReply! (type)
        public static string DeleteAwsIamUserBasedCloudAccount(
            ref DeleteAwsIamUserBasedCloudAccountReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DeleteAwsIamUserBasedCloudAccountReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteAwsIamUserBasedCloudAccount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? DeleteAzureAdDirectory
        // GraphQL -> deleteAzureAdDirectory: CreateOnDemandJobReply! (type)
        public static string DeleteAzureAdDirectory(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "\n(\nworkloadFid: $workloadFid\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteAzureAdDirectory" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DeleteAzureCloudAccountReply? DeleteAzureCloudAccount
        // GraphQL -> deleteAzureCloudAccount: DeleteAzureCloudAccountReply! (type)
        public static string DeleteAzureCloudAccount(
            ref DeleteAzureCloudAccountReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DeleteAzureCloudAccountReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteAzureCloudAccount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DeleteAzureCloudAccountExocomputeConfigurationsReply? DeleteAzureCloudAccountExocomputeConfigurations
        // GraphQL -> deleteAzureCloudAccountExocomputeConfigurations: DeleteAzureCloudAccountExocomputeConfigurationsReply! (type)
        public static string DeleteAzureCloudAccountExocomputeConfigurations(
            ref DeleteAzureCloudAccountExocomputeConfigurationsReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DeleteAzureCloudAccountExocomputeConfigurationsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteAzureCloudAccountExocomputeConfigurations" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DeleteAzureCloudAccountWithoutOauthReply? DeleteAzureCloudAccountWithoutOauth
        // GraphQL -> deleteAzureCloudAccountWithoutOauth: DeleteAzureCloudAccountWithoutOauthReply! (type)
        public static string DeleteAzureCloudAccountWithoutOauth(
            ref DeleteAzureCloudAccountWithoutOauthReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DeleteAzureCloudAccountWithoutOauthReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteAzureCloudAccountWithoutOauth" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CcProvisionJobReply? DeleteAzureCluster
        // GraphQL -> deleteAzureCluster: CcProvisionJobReply! (type)
        public static string DeleteAzureCluster(
            ref CcProvisionJobReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CcProvisionJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteAzureCluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MosaicAsyncResponse? DeleteCassandraSource
        // GraphQL -> deleteCassandraSource: MosaicAsyncResponse! (type)
        public static string DeleteCassandraSource(
            ref MosaicAsyncResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new MosaicAsyncResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteCassandraSource" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteDb2Database
        // GraphQL -> deleteDb2Database: AsyncRequestStatus! (type)
        public static string DeleteDb2Database(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteDb2Database" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteDb2Instance
        // GraphQL -> deleteDb2Instance: AsyncRequestStatus! (type)
        public static string DeleteDb2Instance(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteDb2Instance" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteExchangeSnapshotMount
        // GraphQL -> deleteExchangeSnapshotMount: AsyncRequestStatus! (type)
        public static string DeleteExchangeSnapshotMount(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteExchangeSnapshotMount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DeleteFailedClusterOperationJobDataReply? DeleteFailedClusterOperationJobData
        // GraphQL -> deleteFailedClusterOperationJobData: DeleteFailedClusterOperationJobDataReply! (type)
        public static string DeleteFailedClusterOperationJobData(
            ref DeleteFailedClusterOperationJobDataReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DeleteFailedClusterOperationJobDataReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteFailedClusterOperationJobData" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? DeleteFailoverCluster
        // GraphQL -> deleteFailoverCluster: ResponseSuccess! (type)
        public static string DeleteFailoverCluster(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteFailoverCluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? DeleteFailoverClusterApp
        // GraphQL -> deleteFailoverClusterApp: ResponseSuccess! (type)
        public static string DeleteFailoverClusterApp(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteFailoverClusterApp" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? DeleteFilesetSnapshots
        // GraphQL -> deleteFilesetSnapshots: ResponseSuccess! (type)
        public static string DeleteFilesetSnapshots(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteFilesetSnapshots" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DeleteGlobalCertificateReply? DeleteGlobalCertificate
        // GraphQL -> deleteGlobalCertificate: DeleteGlobalCertificateReply! (type)
        public static string DeleteGlobalCertificate(
            ref DeleteGlobalCertificateReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DeleteGlobalCertificateReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteGlobalCertificate" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SlaResult? DeleteGlobalSla
        // GraphQL -> deleteGlobalSla: SlaResult! (type)
        public static string DeleteGlobalSla(
            ref SlaResult? cmdletReply
        )
        {
            string args = "\n(\nid: $id\nuserNote: $userNote\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new SlaResult() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteGlobalSla" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? DeleteHypervVirtualMachineSnapshot
        // GraphQL -> deleteHypervVirtualMachineSnapshot: RequestSuccess! (type)
        public static string DeleteHypervVirtualMachineSnapshot(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteHypervVirtualMachineSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteHypervVirtualMachineSnapshotMount
        // GraphQL -> deleteHypervVirtualMachineSnapshotMount: AsyncRequestStatus! (type)
        public static string DeleteHypervVirtualMachineSnapshotMount(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteHypervVirtualMachineSnapshotMount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> IdentityProvider? DeleteIdentityProvider
        // GraphQL -> deleteIdentityProvider: IdentityProvider! (type)
        public static string DeleteIdentityProvider(
            ref IdentityProvider? cmdletReply
        )
        {
            string args = "";
           if (cmdletReply == null)
            {
                cmdletReply = new IdentityProvider() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteIdentityProvider" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DeleteKmipServerReply? DeleteKmipServer
        // GraphQL -> deleteKmipServer: DeleteKmipServerReply! (type)
        public static string DeleteKmipServer(
            ref DeleteKmipServerReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DeleteKmipServerReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteKmipServer" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteLogShipping
        // GraphQL -> deleteLogShipping: AsyncRequestStatus! (type)
        public static string DeleteLogShipping(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteLogShipping" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DeleteManagedVolumeReply? DeleteManagedVolume
        // GraphQL -> deleteManagedVolume: DeleteManagedVolumeReply! (type)
        public static string DeleteManagedVolume(
            ref DeleteManagedVolumeReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DeleteManagedVolumeReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteManagedVolume" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteManagedVolumeSnapshotExport
        // GraphQL -> deleteManagedVolumeSnapshotExport: AsyncRequestStatus! (type)
        public static string DeleteManagedVolumeSnapshotExport(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteManagedVolumeSnapshotExport" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteMongoSource
        // GraphQL -> deleteMongoSource: AsyncRequestStatus! (type)
        public static string DeleteMongoSource(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteMongoSource" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MosaicAsyncResponse? DeleteMongodbSource
        // GraphQL -> deleteMongodbSource: MosaicAsyncResponse! (type)
        public static string DeleteMongodbSource(
            ref MosaicAsyncResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new MosaicAsyncResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteMongodbSource" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MosaicAsyncResponse? DeleteMosaicStore
        // GraphQL -> deleteMosaicStore: MosaicAsyncResponse! (type)
        public static string DeleteMosaicStore(
            ref MosaicAsyncResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new MosaicAsyncResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteMosaicStore" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? DeleteMssqlDbSnapshots
        // GraphQL -> deleteMssqlDbSnapshots: ResponseSuccess! (type)
        public static string DeleteMssqlDbSnapshots(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteMssqlDbSnapshots" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteMssqlLiveMount
        // GraphQL -> deleteMssqlLiveMount: AsyncRequestStatus! (type)
        public static string DeleteMssqlLiveMount(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteMssqlLiveMount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteNasSystem
        // GraphQL -> deleteNasSystem: AsyncRequestStatus! (type)
        public static string DeleteNasSystem(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteNasSystem" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteNutanixCluster
        // GraphQL -> deleteNutanixCluster: AsyncRequestStatus! (type)
        public static string DeleteNutanixCluster(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteNutanixCluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteNutanixMountV1
        // GraphQL -> deleteNutanixMountV1: AsyncRequestStatus! (type)
        public static string DeleteNutanixMountV1(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteNutanixMountV1" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncRequestStatus? DeleteNutanixPrismCentral
        // GraphQL -> deleteNutanixPrismCentral: BatchAsyncRequestStatus! (type)
        public static string DeleteNutanixPrismCentral(
            ref BatchAsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteNutanixPrismCentral" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? DeleteNutanixSnapshot
        // GraphQL -> deleteNutanixSnapshot: RequestSuccess! (type)
        public static string DeleteNutanixSnapshot(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteNutanixSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? DeleteNutanixSnapshots
        // GraphQL -> deleteNutanixSnapshots: RequestSuccess! (type)
        public static string DeleteNutanixSnapshots(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteNutanixSnapshots" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestStatus? DeleteO365AzureApp
        // GraphQL -> deleteO365AzureApp: RequestStatus! (type)
        public static string DeleteO365AzureApp(
            ref RequestStatus? cmdletReply
        )
        {
            string args = "\n(\no365AppClientId: $o365AppClientId\no365AppType: $o365AppType\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteO365AzureApp" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? DeleteO365Org
        // GraphQL -> deleteO365Org: CreateOnDemandJobReply! (type)
        public static string DeleteO365Org(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "\n(\norgId: $orgId\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteO365Org" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestStatus? DeleteO365ServiceAccount
        // GraphQL -> deleteO365ServiceAccount: RequestStatus! (type)
        public static string DeleteO365ServiceAccount(
            ref RequestStatus? cmdletReply
        )
        {
            string args = "\n(\norgId: $orgId\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteO365ServiceAccount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteOracleMount
        // GraphQL -> deleteOracleMount: AsyncRequestStatus! (type)
        public static string DeleteOracleMount(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteOracleMount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DeleteBlueprintRecoverySpecReply? DeleteRecoverySpec
        // GraphQL -> deleteRecoverySpec: DeleteBlueprintRecoverySpecReply! (type)
        public static string DeleteRecoverySpec(
            ref DeleteBlueprintRecoverySpecReply? cmdletReply
        )
        {
            string args = "\n(\nblueprintId: $blueprintId\nexcludePlanTypes: $excludePlanTypes\nfailoverId: $failoverId\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DeleteBlueprintRecoverySpecReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteRecoverySpec" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? DeleteSapHanaDbSnapshot
        // GraphQL -> deleteSapHanaDbSnapshot: ResponseSuccess! (type)
        public static string DeleteSapHanaDbSnapshot(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteSapHanaDbSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteSapHanaSystem
        // GraphQL -> deleteSapHanaSystem: AsyncRequestStatus! (type)
        public static string DeleteSapHanaSystem(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteSapHanaSystem" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? DeleteSnapMirrorCloud
        // GraphQL -> deleteSnapMirrorCloud: ResponseSuccess! (type)
        public static string DeleteSnapMirrorCloud(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteSnapMirrorCloud" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? DeleteSnapMirrorCloudRelationship
        // GraphQL -> deleteSnapMirrorCloudRelationship: ResponseSuccess! (type)
        public static string DeleteSnapMirrorCloudRelationship(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteSnapMirrorCloudRelationship" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? DeleteSnapMirrorCloudSnapshot
        // GraphQL -> deleteSnapMirrorCloudSnapshot: ResponseSuccess! (type)
        public static string DeleteSnapMirrorCloudSnapshot(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteSnapMirrorCloudSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? DeleteSnapshotsOfUnmanagedObjects
        // GraphQL -> deleteSnapshotsOfUnmanagedObjects: RequestSuccess! (type)
        public static string DeleteSnapshotsOfUnmanagedObjects(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "\n(\nobjectIds: $objectIds\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteSnapshotsOfUnmanagedObjects" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DeleteStorageArraysReply? DeleteStorageArrays
        // GraphQL -> deleteStorageArrays: DeleteStorageArraysReply! (type)
        public static string DeleteStorageArrays(
            ref DeleteStorageArraysReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DeleteStorageArraysReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteStorageArrays" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? DeleteUnmanagedSnapshots
        // GraphQL -> deleteUnmanagedSnapshots: RequestSuccess! (type)
        public static string DeleteUnmanagedSnapshots(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "\n(\nsnapshotIds: $snapshotIds\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteUnmanagedSnapshots" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DeleteVappSnapshotsReply? DeleteVappSnapshots
        // GraphQL -> deleteVappSnapshots: DeleteVappSnapshotsReply! (type)
        public static string DeleteVappSnapshots(
            ref DeleteVappSnapshotsReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DeleteVappSnapshotsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteVappSnapshots" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DeleteVcdInstancesReply? DeleteVcdInstances
        // GraphQL -> deleteVcdInstances: DeleteVcdInstancesReply! (type)
        public static string DeleteVcdInstances(
            ref DeleteVcdInstancesReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DeleteVcdInstancesReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteVcdInstances" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteVolumeGroupMount
        // GraphQL -> deleteVolumeGroupMount: AsyncRequestStatus! (type)
        public static string DeleteVolumeGroupMount(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteVolumeGroupMount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? DeleteVsphereAdvancedTag
        // GraphQL -> deleteVsphereAdvancedTag: RequestSuccess! (type)
        public static string DeleteVsphereAdvancedTag(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteVsphereAdvancedTag" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DeleteVsphereLiveMount
        // GraphQL -> deleteVsphereLiveMount: AsyncRequestStatus! (type)
        public static string DeleteVsphereLiveMount(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "deleteVsphereLiveMount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? DisableReplicationPause
        // GraphQL -> disableReplicationPause: ResponseSuccess! (type)
        public static string DisableReplicationPause(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "disableReplicationPause" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DisableTargetReply? DisableTarget
        // GraphQL -> disableTarget: DisableTargetReply! (type)
        public static string DisableTarget(
            ref DisableTargetReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DisableTargetReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "disableTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DiscoverDb2Instance
        // GraphQL -> discoverDb2Instance: AsyncRequestStatus! (type)
        public static string DiscoverDb2Instance(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "discoverDb2Instance" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DiscoverMongoSource
        // GraphQL -> discoverMongoSource: AsyncRequestStatus! (type)
        public static string DiscoverMongoSource(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "discoverMongoSource" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DissolveLegalHoldReply? DissolveLegalHold
        // GraphQL -> dissolveLegalHold: DissolveLegalHoldReply! (type)
        public static string DissolveLegalHold(
            ref DissolveLegalHoldReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DissolveLegalHoldReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "dissolveLegalHold" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadDb2Snapshot
        // GraphQL -> downloadDb2Snapshot: AsyncRequestStatus! (type)
        public static string DownloadDb2Snapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadDb2Snapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadDb2SnapshotsForPointInTimeRecovery
        // GraphQL -> downloadDb2SnapshotsForPointInTimeRecovery: AsyncRequestStatus! (type)
        public static string DownloadDb2SnapshotsForPointInTimeRecovery(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadDb2SnapshotsForPointInTimeRecovery" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadExchangeSnapshot
        // GraphQL -> downloadExchangeSnapshot: AsyncRequestStatus! (type)
        public static string DownloadExchangeSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadExchangeSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncDownloadReply? DownloadFile
        // GraphQL -> downloadFile: AsyncDownloadReply! (type)
        public static string DownloadFile(
            ref AsyncDownloadReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncDownloadReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadFile" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadFilesNutanixSnapshot
        // GraphQL -> downloadFilesNutanixSnapshot: AsyncRequestStatus! (type)
        public static string DownloadFilesNutanixSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadFilesNutanixSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadFilesetSnapshot
        // GraphQL -> downloadFilesetSnapshot: AsyncRequestStatus! (type)
        public static string DownloadFilesetSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadFilesetSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadFilesetSnapshotFromLocation
        // GraphQL -> downloadFilesetSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string DownloadFilesetSnapshotFromLocation(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadFilesetSnapshotFromLocation" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadHypervSnapshotFromLocation
        // GraphQL -> downloadHypervSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string DownloadHypervSnapshotFromLocation(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadHypervSnapshotFromLocation" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadHypervVirtualMachineSnapshot
        // GraphQL -> downloadHypervVirtualMachineSnapshot: AsyncRequestStatus! (type)
        public static string DownloadHypervVirtualMachineSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadHypervVirtualMachineSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadHypervVirtualMachineSnapshotFiles
        // GraphQL -> downloadHypervVirtualMachineSnapshotFiles: AsyncRequestStatus! (type)
        public static string DownloadHypervVirtualMachineSnapshotFiles(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadHypervVirtualMachineSnapshotFiles" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadManagedVolumeFiles
        // GraphQL -> downloadManagedVolumeFiles: AsyncRequestStatus! (type)
        public static string DownloadManagedVolumeFiles(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadManagedVolumeFiles" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadMssqlDatabaseBackupFiles
        // GraphQL -> downloadMssqlDatabaseBackupFiles: AsyncRequestStatus! (type)
        public static string DownloadMssqlDatabaseBackupFiles(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadMssqlDatabaseBackupFiles" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadMssqlDatabaseFilesFromArchivalLocation
        // GraphQL -> downloadMssqlDatabaseFilesFromArchivalLocation: AsyncRequestStatus! (type)
        public static string DownloadMssqlDatabaseFilesFromArchivalLocation(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadMssqlDatabaseFilesFromArchivalLocation" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadNutanixSnapshot
        // GraphQL -> downloadNutanixSnapshot: AsyncRequestStatus! (type)
        public static string DownloadNutanixSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadNutanixSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadNutanixVmFromLocation
        // GraphQL -> downloadNutanixVmFromLocation: AsyncRequestStatus! (type)
        public static string DownloadNutanixVmFromLocation(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadNutanixVmFromLocation" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DownloadCsvReply? DownloadObjectFilesCsv
        // GraphQL -> downloadObjectFilesCsv: DownloadCsvReply! (type)
        public static string DownloadObjectFilesCsv(
            ref DownloadCsvReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DownloadCsvReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadObjectFilesCsv" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DownloadCsvReply? DownloadObjectsListCsv
        // GraphQL -> downloadObjectsListCsv: DownloadCsvReply! (type)
        public static string DownloadObjectsListCsv(
            ref DownloadCsvReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DownloadCsvReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadObjectsListCsv" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadOracleDatabaseSnapshot
        // GraphQL -> downloadOracleDatabaseSnapshot: AsyncRequestStatus! (type)
        public static string DownloadOracleDatabaseSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadOracleDatabaseSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncDownloadReply? DownloadReportCsvAsync
        // GraphQL -> downloadReportCsvAsync: AsyncDownloadReply! (type)
        public static string DownloadReportCsvAsync(
            ref AsyncDownloadReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncDownloadReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadReportCsvAsync" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncDownloadReply? DownloadReportPdfAsync
        // GraphQL -> downloadReportPdfAsync: AsyncDownloadReply! (type)
        public static string DownloadReportPdfAsync(
            ref AsyncDownloadReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncDownloadReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadReportPdfAsync" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DownloadResultsCsvReply? DownloadResultsCsv
        // GraphQL -> downloadResultsCsv: DownloadResultsCsvReply! (type)
        public static string DownloadResultsCsv(
            ref DownloadResultsCsvReply? cmdletReply
        )
        {
            string args = "\n(\ncrawlId: $crawlId\ndownloadFilter: $downloadFilter\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DownloadResultsCsvReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadResultsCsv" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadSapHanaSnapshot
        // GraphQL -> downloadSapHanaSnapshot: AsyncRequestStatus! (type)
        public static string DownloadSapHanaSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadSapHanaSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadSapHanaSnapshotFromLocation
        // GraphQL -> downloadSapHanaSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string DownloadSapHanaSnapshotFromLocation(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadSapHanaSnapshotFromLocation" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadSapHanaSnapshotsForPointInTimeRecovery
        // GraphQL -> downloadSapHanaSnapshotsForPointInTimeRecovery: AsyncRequestStatus! (type)
        public static string DownloadSapHanaSnapshotsForPointInTimeRecovery(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadSapHanaSnapshotsForPointInTimeRecovery" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DownloadCsvReply? DownloadSnapshotResultsCsv
        // GraphQL -> downloadSnapshotResultsCsv: DownloadCsvReply! (type)
        public static string DownloadSnapshotResultsCsv(
            ref DownloadCsvReply? cmdletReply
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\ndownloadFilter: $downloadFilter\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DownloadCsvReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadSnapshotResultsCsv" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DownloadThreatHuntCsvReply? DownloadThreatHuntCsv
        // GraphQL -> downloadThreatHuntCsv: DownloadThreatHuntCsvReply! (type)
        public static string DownloadThreatHuntCsv(
            ref DownloadThreatHuntCsvReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DownloadThreatHuntCsvReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadThreatHuntCsv" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DownloadCsvReply? DownloadUserActivityCsv
        // GraphQL -> downloadUserActivityCsv: DownloadCsvReply! (type)
        public static string DownloadUserActivityCsv(
            ref DownloadCsvReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DownloadCsvReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadUserActivityCsv" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DownloadCsvReply? DownloadUserFileActivityCsv
        // GraphQL -> downloadUserFileActivityCsv: DownloadCsvReply! (type)
        public static string DownloadUserFileActivityCsv(
            ref DownloadCsvReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DownloadCsvReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadUserFileActivityCsv" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadVcdVappSnapshotFromLocation
        // GraphQL -> downloadVcdVappSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string DownloadVcdVappSnapshotFromLocation(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadVcdVappSnapshotFromLocation" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadVolumeGroupSnapshotFiles
        // GraphQL -> downloadVolumeGroupSnapshotFiles: AsyncRequestStatus! (type)
        public static string DownloadVolumeGroupSnapshotFiles(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadVolumeGroupSnapshotFiles" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadVolumeGroupSnapshotFromLocation
        // GraphQL -> downloadVolumeGroupSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string DownloadVolumeGroupSnapshotFromLocation(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadVolumeGroupSnapshotFromLocation" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? DownloadVsphereVirtualMachineFiles
        // GraphQL -> downloadVsphereVirtualMachineFiles: AsyncRequestStatus! (type)
        public static string DownloadVsphereVirtualMachineFiles(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadVsphereVirtualMachineFiles" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GlobalSlaReply? EditGlobalSla
        // GraphQL -> editGlobalSla: GlobalSlaReply! (type)
        public static string EditGlobalSla(
            ref GlobalSlaReply? cmdletReply
        )
        {
            string args = "\n(\nglobalSlaEditRequest: $globalSlaEditRequest\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new GlobalSlaReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "editGlobalSla" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> EnableAutomaticFmdUploadReply? EnableAutomaticFmdUpload
        // GraphQL -> enableAutomaticFmdUpload: EnableAutomaticFmdUploadReply! (type)
        public static string EnableAutomaticFmdUpload(
            ref EnableAutomaticFmdUploadReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new EnableAutomaticFmdUploadReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "enableAutomaticFmdUpload" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> EnableDisableAppConsistencyReply? EnableDisableAppConsistency
        // GraphQL -> enableDisableAppConsistency: EnableDisableAppConsistencyReply! (type)
        public static string EnableDisableAppConsistency(
            ref EnableDisableAppConsistencyReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new EnableDisableAppConsistencyReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "enableDisableAppConsistency" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> EnableLambdaForSnappableReply? EnableLambdaForWorkload
        // GraphQL -> enableLambdaForWorkload: EnableLambdaForSnappableReply! (type)
        public static string EnableLambdaForWorkload(
            ref EnableLambdaForSnappableReply? cmdletReply
        )
        {
            string args = "\n(\nsnappableId: $snappableId\nenableDiffFmd: $enableDiffFmd\nenableFullFmd: $enableFullFmd\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new EnableLambdaForSnappableReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "enableLambdaForWorkload" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestStatus? EnableO365SharePoint
        // GraphQL -> enableO365SharePoint: RequestStatus! (type)
        public static string EnableO365SharePoint(
            ref RequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "enableO365SharePoint" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestStatus? EnableO365Teams
        // GraphQL -> enableO365Teams: RequestStatus! (type)
        public static string EnableO365Teams(
            ref RequestStatus? cmdletReply
        )
        {
            string args = "\n(\nexocomputeClusterId: $exocomputeClusterId\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "enableO365Teams" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? EnableReplicationPause
        // GraphQL -> enableReplicationPause: ResponseSuccess! (type)
        public static string EnableReplicationPause(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "enableReplicationPause" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> EnableTargetReply? EnableTarget
        // GraphQL -> enableTarget: EnableTargetReply! (type)
        public static string EnableTarget(
            ref EnableTargetReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new EnableTargetReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "enableTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> EndManagedVolumeSnapshotReply? EndManagedVolumeSnapshot
        // GraphQL -> endManagedVolumeSnapshot: EndManagedVolumeSnapshotReply! (type)
        public static string EndManagedVolumeSnapshot(
            ref EndManagedVolumeSnapshotReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new EndManagedVolumeSnapshotReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "endManagedVolumeSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ExpireDownloadedDb2Snapshots
        // GraphQL -> expireDownloadedDb2Snapshots: AsyncRequestStatus! (type)
        public static string ExpireDownloadedDb2Snapshots(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "expireDownloadedDb2Snapshots" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ExpireDownloadedSapHanaSnapshots
        // GraphQL -> expireDownloadedSapHanaSnapshots: AsyncRequestStatus! (type)
        public static string ExpireDownloadedSapHanaSnapshots(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "expireDownloadedSapHanaSnapshots" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ExportHypervVirtualMachine
        // GraphQL -> exportHypervVirtualMachine: AsyncRequestStatus! (type)
        public static string ExportHypervVirtualMachine(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "exportHypervVirtualMachine" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? ExportK8sNamespace
        // GraphQL -> exportK8sNamespace: CreateOnDemandJobReply! (type)
        public static string ExportK8sNamespace(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "exportK8sNamespace" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ExportManagedVolumeSnapshot
        // GraphQL -> exportManagedVolumeSnapshot: AsyncRequestStatus! (type)
        public static string ExportManagedVolumeSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "exportManagedVolumeSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ExportMssqlDatabase
        // GraphQL -> exportMssqlDatabase: AsyncRequestStatus! (type)
        public static string ExportMssqlDatabase(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "exportMssqlDatabase" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ExportNutanixSnapshot
        // GraphQL -> exportNutanixSnapshot: AsyncRequestStatus! (type)
        public static string ExportNutanixSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "exportNutanixSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? ExportO365Mailbox
        // GraphQL -> exportO365Mailbox: CreateOnDemandJobReply! (type)
        public static string ExportO365Mailbox(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "\n(\nexportConfig: $exportConfig\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "exportO365Mailbox" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ExportOracleDatabase
        // GraphQL -> exportOracleDatabase: AsyncRequestStatus! (type)
        public static string ExportOracleDatabase(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "exportOracleDatabase" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ExportOracleTablespace
        // GraphQL -> exportOracleTablespace: AsyncRequestStatus! (type)
        public static string ExportOracleTablespace(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "exportOracleTablespace" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ExportSlaManagedVolumeSnapshot
        // GraphQL -> exportSlaManagedVolumeSnapshot: AsyncRequestStatus! (type)
        public static string ExportSlaManagedVolumeSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "exportSlaManagedVolumeSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ExtendRscAutoUpgradeDateReply? ExtendRscAutoUpgradeDate
        // GraphQL -> extendRscAutoUpgradeDate: ExtendRscAutoUpgradeDateReply! (type)
        public static string ExtendRscAutoUpgradeDate(
            ref ExtendRscAutoUpgradeDateReply? cmdletReply
        )
        {
            string args = "";
           if (cmdletReply == null)
            {
                cmdletReply = new ExtendRscAutoUpgradeDateReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "extendRscAutoUpgradeDate" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? FilesetDownloadSnapshotFiles
        // GraphQL -> filesetDownloadSnapshotFiles: AsyncRequestStatus! (type)
        public static string FilesetDownloadSnapshotFiles(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "filesetDownloadSnapshotFiles" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? FilesetExportSnapshotFiles
        // GraphQL -> filesetExportSnapshotFiles: AsyncRequestStatus! (type)
        public static string FilesetExportSnapshotFiles(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "filesetExportSnapshotFiles" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? FilesetRecoverFiles
        // GraphQL -> filesetRecoverFiles: AsyncRequestStatus! (type)
        public static string FilesetRecoverFiles(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "filesetRecoverFiles" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FinalizeAwsCloudAccountDeletionReply? FinalizeAwsCloudAccountDeletion
        // GraphQL -> finalizeAwsCloudAccountDeletion: FinalizeAwsCloudAccountDeletionReply! (type)
        public static string FinalizeAwsCloudAccountDeletion(
            ref FinalizeAwsCloudAccountDeletionReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new FinalizeAwsCloudAccountDeletionReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "finalizeAwsCloudAccountDeletion" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FinalizeAwsCloudAccountProtectionReply? FinalizeAwsCloudAccountProtection
        // GraphQL -> finalizeAwsCloudAccountProtection: FinalizeAwsCloudAccountProtectionReply! (type)
        public static string FinalizeAwsCloudAccountProtection(
            ref FinalizeAwsCloudAccountProtectionReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new FinalizeAwsCloudAccountProtectionReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "finalizeAwsCloudAccountProtection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GcpCloudAccountAddProjectsReply? GcpCloudAccountAddProjects
        // GraphQL -> gcpCloudAccountAddProjects: GcpCloudAccountAddProjectsReply! (type)
        public static string GcpCloudAccountAddProjects(
            ref GcpCloudAccountAddProjectsReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new GcpCloudAccountAddProjectsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "gcpCloudAccountAddProjects" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GcpCloudAccountDeleteProjectsReply? GcpCloudAccountDeleteProjects
        // GraphQL -> gcpCloudAccountDeleteProjects: GcpCloudAccountDeleteProjectsReply! (type)
        public static string GcpCloudAccountDeleteProjects(
            ref GcpCloudAccountDeleteProjectsReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new GcpCloudAccountDeleteProjectsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "gcpCloudAccountDeleteProjects" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GcpCloudAccountOauthCompleteReply? GcpCloudAccountOauthComplete
        // GraphQL -> gcpCloudAccountOauthComplete: GcpCloudAccountOauthCompleteReply! (type)
        public static string GcpCloudAccountOauthComplete(
            ref GcpCloudAccountOauthCompleteReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new GcpCloudAccountOauthCompleteReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "gcpCloudAccountOauthComplete" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GcpCloudAccountOauthInitiateReply? GcpCloudAccountOauthInitiate
        // GraphQL -> gcpCloudAccountOauthInitiate: GcpCloudAccountOauthInitiateReply! (type)
        public static string GcpCloudAccountOauthInitiate(
            ref GcpCloudAccountOauthInitiateReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new GcpCloudAccountOauthInitiateReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "gcpCloudAccountOauthInitiate" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GcpCloudAccountUpgradeProjectsReply? GcpCloudAccountUpgradeProjects
        // GraphQL -> gcpCloudAccountUpgradeProjects: GcpCloudAccountUpgradeProjectsReply! (type)
        public static string GcpCloudAccountUpgradeProjects(
            ref GcpCloudAccountUpgradeProjectsReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new GcpCloudAccountUpgradeProjectsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "gcpCloudAccountUpgradeProjects" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? GcpNativeDisableProject
        // GraphQL -> gcpNativeDisableProject: AsyncJobStatus! (type)
        public static string GcpNativeDisableProject(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "gcpNativeDisableProject" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? GcpNativeExportDisk
        // GraphQL -> gcpNativeExportDisk: AsyncJobStatus! (type)
        public static string GcpNativeExportDisk(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "gcpNativeExportDisk" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? GcpNativeExportGceInstance
        // GraphQL -> gcpNativeExportGceInstance: AsyncJobStatus! (type)
        public static string GcpNativeExportGceInstance(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "gcpNativeExportGceInstance" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncJobStatus? GcpNativeRefreshProjects
        // GraphQL -> gcpNativeRefreshProjects: BatchAsyncJobStatus! (type)
        public static string GcpNativeRefreshProjects(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "gcpNativeRefreshProjects" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? GcpNativeRestoreGceInstance
        // GraphQL -> gcpNativeRestoreGceInstance: AsyncJobStatus! (type)
        public static string GcpNativeRestoreGceInstance(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "gcpNativeRestoreGceInstance" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterRegistrationToken? GenerateClusterRegistrationToken
        // GraphQL -> generateClusterRegistrationToken: ClusterRegistrationToken! (type)
        public static string GenerateClusterRegistrationToken(
            ref ClusterRegistrationToken? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ClusterRegistrationToken() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "generateClusterRegistrationToken" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GenerateConfigProtectionRestoreFormReply? GenerateConfigProtectionRestoreForm
        // GraphQL -> generateConfigProtectionRestoreForm: GenerateConfigProtectionRestoreFormReply! (type)
        public static string GenerateConfigProtectionRestoreForm(
            ref GenerateConfigProtectionRestoreFormReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new GenerateConfigProtectionRestoreFormReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "generateConfigProtectionRestoreForm" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Csr? GenerateCsr
        // GraphQL -> generateCsr: Csr! (type)
        public static string GenerateCsr(
            ref Csr? cmdletReply
        )
        {
            string args = "\n(\nname: $name\nhostnames: $hostnames\norganization: $organization\norganizationUnit: $organizationUnit\ncountry: $country\nstate: $state\ncity: $city\nemail: $email\nsurname: $surname\nuserId: $userId\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new Csr() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "generateCsr" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? GenerateSupportBundle
        // GraphQL -> generateSupportBundle: AsyncRequestStatus! (type)
        public static string GenerateSupportBundle(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "generateSupportBundle" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GenerateTotpSecretReply? GenerateTotpSecret
        // GraphQL -> generateTotpSecret: GenerateTotpSecretReply! (type)
        public static string GenerateTotpSecret(
            ref GenerateTotpSecretReply? cmdletReply
        )
        {
            string args = "\n(\nuserId: $userId\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new GenerateTotpSecretReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "generateTotpSecret" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UserDownloadUrl? GetDownloadUrl
        // GraphQL -> getDownloadUrl: UserDownloadUrl! (type)
        public static string GetDownloadUrl(
            ref UserDownloadUrl? cmdletReply
        )
        {
            string args = "\n(\ndownloadId: $downloadId\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UserDownloadUrl() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getDownloadUrl" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetHealthMonitorPolicyStatusReply? GetHealthMonitorPolicyStatus
        // GraphQL -> getHealthMonitorPolicyStatus: GetHealthMonitorPolicyStatusReply! (type)
        public static string GetHealthMonitorPolicyStatus(
            ref GetHealthMonitorPolicyStatusReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new GetHealthMonitorPolicyStatusReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getHealthMonitorPolicyStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PendingSlaOperations? GetPendingSlaAssignments
        // GraphQL -> getPendingSlaAssignments: PendingSlaOperations! (type)
        public static string GetPendingSlaAssignments(
            ref PendingSlaOperations? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new PendingSlaOperations() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getPendingSlaAssignments" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? HideRevealNasShares
        // GraphQL -> hideRevealNasShares: ResponseSuccess! (type)
        public static string HideRevealNasShares(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hideRevealNasShares" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? HypervDeleteAllSnapshots
        // GraphQL -> hypervDeleteAllSnapshots: RequestSuccess! (type)
        public static string HypervDeleteAllSnapshots(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervDeleteAllSnapshots" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? HypervOnDemandSnapshot
        // GraphQL -> hypervOnDemandSnapshot: AsyncRequestStatus! (type)
        public static string HypervOnDemandSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervOnDemandSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? HypervScvmmDelete
        // GraphQL -> hypervScvmmDelete: ResponseSuccess! (type)
        public static string HypervScvmmDelete(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervScvmmDelete" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HypervScvmmUpdateReply? HypervScvmmUpdate
        // GraphQL -> hypervScvmmUpdate: HypervScvmmUpdateReply! (type)
        public static string HypervScvmmUpdate(
            ref HypervScvmmUpdateReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new HypervScvmmUpdateReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervScvmmUpdate" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestStatus? InsertCustomerO365App
        // GraphQL -> insertCustomerO365App: RequestStatus! (type)
        public static string InsertCustomerO365App(
            ref RequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "insertCustomerO365App" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? InstallIoFilter
        // GraphQL -> installIoFilter: RequestSuccess! (type)
        public static string InstallIoFilter(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "installIoFilter" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? InstantRecoverHypervVirtualMachineSnapshot
        // GraphQL -> instantRecoverHypervVirtualMachineSnapshot: AsyncRequestStatus! (type)
        public static string InstantRecoverHypervVirtualMachineSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "instantRecoverHypervVirtualMachineSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? InstantRecoverOracleSnapshot
        // GraphQL -> instantRecoverOracleSnapshot: AsyncRequestStatus! (type)
        public static string InstantRecoverOracleSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "instantRecoverOracleSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> KickoffAzureAdAppSetupReply? KickoffAzureAdAppSetup
        // GraphQL -> kickoffAzureAdAppSetup: KickoffAzureAdAppSetupReply! (type)
        public static string KickoffAzureAdAppSetup(
            ref KickoffAzureAdAppSetupReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new KickoffAzureAdAppSetupReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "kickoffAzureAdAppSetup" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ListCidrsForComputeSettingReply? ListCidrsForComputeSetting
        // GraphQL -> listCidrsForComputeSetting: ListCidrsForComputeSettingReply! (type)
        public static string ListCidrsForComputeSetting(
            ref ListCidrsForComputeSettingReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ListCidrsForComputeSettingReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "listCidrsForComputeSetting" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SupportPortalLogoutReply? LogoutFromRubrikSupportPortal
        // GraphQL -> logoutFromRubrikSupportPortal: SupportPortalLogoutReply! (type)
        public static string LogoutFromRubrikSupportPortal(
            ref SupportPortalLogoutReply? cmdletReply
        )
        {
            string args = "";
           if (cmdletReply == null)
            {
                cmdletReply = new SupportPortalLogoutReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "logoutFromRubrikSupportPortal" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MapAzureCloudAccountExocomputeSubscriptionReply? MapAzureCloudAccountExocomputeSubscription
        // GraphQL -> mapAzureCloudAccountExocomputeSubscription: MapAzureCloudAccountExocomputeSubscriptionReply! (type)
        public static string MapAzureCloudAccountExocomputeSubscription(
            ref MapAzureCloudAccountExocomputeSubscriptionReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new MapAzureCloudAccountExocomputeSubscriptionReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mapAzureCloudAccountExocomputeSubscription" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MapAzureCloudAccountToPersistentStorageLocationReply? MapAzureCloudAccountToPersistentStorageLocation
        // GraphQL -> mapAzureCloudAccountToPersistentStorageLocation: MapAzureCloudAccountToPersistentStorageLocationReply! (type)
        public static string MapAzureCloudAccountToPersistentStorageLocation(
            ref MapAzureCloudAccountToPersistentStorageLocationReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new MapAzureCloudAccountToPersistentStorageLocationReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mapAzureCloudAccountToPersistentStorageLocation" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MapCloudAccountExocomputeAccountReply? MapCloudAccountExocomputeAccount
        // GraphQL -> mapCloudAccountExocomputeAccount: MapCloudAccountExocomputeAccountReply! (type)
        public static string MapCloudAccountExocomputeAccount(
            ref MapCloudAccountExocomputeAccountReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new MapCloudAccountExocomputeAccountReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mapCloudAccountExocomputeAccount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MigrateLegacyNasHostFilesetsReply? MigrateLegacyNasHostFilesets
        // GraphQL -> migrateLegacyNasHostFilesets: MigrateLegacyNasHostFilesetsReply! (type)
        public static string MigrateLegacyNasHostFilesets(
            ref MigrateLegacyNasHostFilesetsReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new MigrateLegacyNasHostFilesetsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "migrateLegacyNasHostFilesets" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? MigrateNutanixMountV1
        // GraphQL -> migrateNutanixMountV1: AsyncRequestStatus! (type)
        public static string MigrateNutanixMountV1(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "migrateNutanixMountV1" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ModifyIpmiReply? ModifyIpmi
        // GraphQL -> modifyIpmi: ModifyIpmiReply! (type)
        public static string ModifyIpmi(
            ref ModifyIpmiReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ModifyIpmiReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "modifyIpmi" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? MountNutanixSnapshotV1
        // GraphQL -> mountNutanixSnapshotV1: AsyncRequestStatus! (type)
        public static string MountNutanixSnapshotV1(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mountNutanixSnapshotV1" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? MountOracleDatabase
        // GraphQL -> mountOracleDatabase: AsyncRequestStatus! (type)
        public static string MountOracleDatabase(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mountOracleDatabase" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365OauthConsentCompleteReply? O365OauthConsentComplete
        // GraphQL -> o365OauthConsentComplete: O365OauthConsentCompleteReply! (type)
        public static string O365OauthConsentComplete(
            ref O365OauthConsentCompleteReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new O365OauthConsentCompleteReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365OauthConsentComplete" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365OauthConsentKickoffReply? O365OauthConsentKickoff
        // GraphQL -> o365OauthConsentKickoff: O365OauthConsentKickoffReply! (type)
        public static string O365OauthConsentKickoff(
            ref O365OauthConsentKickoffReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new O365OauthConsentKickoffReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365OauthConsentKickoff" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365PdlGroupsReply? O365PdlGroups
        // GraphQL -> o365PdlGroups: O365PdlGroupsReply! (type)
        public static string O365PdlGroups(
            ref O365PdlGroupsReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new O365PdlGroupsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365PdlGroups" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365SaasSetupKickoffReply? O365SaaSsetupKickoff
        // GraphQL -> o365SaaSSetupKickoff: O365SaasSetupKickoffReply! (type)
        public static string O365SaaSsetupKickoff(
            ref O365SaasSetupKickoffReply? cmdletReply
        )
        {
            string args = "";
           if (cmdletReply == null)
            {
                cmdletReply = new O365SaasSetupKickoffReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365SaaSSetupKickoff" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AddO365OrgResponse? O365SaasSetupComplete
        // GraphQL -> o365SaasSetupComplete: AddO365OrgResponse! (type)
        public static string O365SaasSetupComplete(
            ref AddO365OrgResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AddO365OrgResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365SaasSetupComplete" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365SetupKickoffResp? O365SetupKickoff
        // GraphQL -> o365SetupKickoff: O365SetupKickoffResp! (type)
        public static string O365SetupKickoff(
            ref O365SetupKickoffResp? cmdletReply
        )
        {
            string args = "";
           if (cmdletReply == null)
            {
                cmdletReply = new O365SetupKickoffResp() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365SetupKickoff" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PatchDb2InstanceReply? PatchDb2Instance
        // GraphQL -> patchDb2Instance: PatchDb2InstanceReply! (type)
        public static string PatchDb2Instance(
            ref PatchDb2InstanceReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new PatchDb2InstanceReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "patchDb2Instance" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? PatchMongoSource
        // GraphQL -> patchMongoSource: AsyncRequestStatus! (type)
        public static string PatchMongoSource(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "patchMongoSource" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PatchNutanixMountV1Reply? PatchNutanixMountV1
        // GraphQL -> patchNutanixMountV1: PatchNutanixMountV1Reply! (type)
        public static string PatchNutanixMountV1(
            ref PatchNutanixMountV1Reply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new PatchNutanixMountV1Reply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "patchNutanixMountV1" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PatchSapHanaSystemReply? PatchSapHanaSystem
        // GraphQL -> patchSapHanaSystem: PatchSapHanaSystemReply! (type)
        public static string PatchSapHanaSystem(
            ref PatchSapHanaSystemReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new PatchSapHanaSystemReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "patchSapHanaSystem" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SlaResult? PauseSla
        // GraphQL -> pauseSla: SlaResult! (type)
        public static string PauseSla(
            ref SlaResult? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new SlaResult() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "pauseSla" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PauseTargetReply? PauseTarget
        // GraphQL -> pauseTarget: PauseTargetReply! (type)
        public static string PauseTarget(
            ref PauseTargetReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new PauseTargetReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "pauseTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PrepareAwsCloudAccountDeletionReply? PrepareAwsCloudAccountDeletion
        // GraphQL -> prepareAwsCloudAccountDeletion: PrepareAwsCloudAccountDeletionReply! (type)
        public static string PrepareAwsCloudAccountDeletion(
            ref PrepareAwsCloudAccountDeletionReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new PrepareAwsCloudAccountDeletionReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "prepareAwsCloudAccountDeletion" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PrepareFeatureUpdateForAwsCloudAccountReply? PrepareFeatureUpdateForAwsCloudAccount
        // GraphQL -> prepareFeatureUpdateForAwsCloudAccount: PrepareFeatureUpdateForAwsCloudAccountReply! (type)
        public static string PrepareFeatureUpdateForAwsCloudAccount(
            ref PrepareFeatureUpdateForAwsCloudAccountReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new PrepareFeatureUpdateForAwsCloudAccountReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "prepareFeatureUpdateForAwsCloudAccount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? PromoteRecovery
        // GraphQL -> promoteRecovery: CreateOnDemandJobReply! (type)
        public static string PromoteRecovery(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "promoteRecovery" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PutSmbConfigurationReply? PutSmbConfiguration
        // GraphQL -> putSmbConfiguration: PutSmbConfigurationReply! (type)
        public static string PutSmbConfiguration(
            ref PutSmbConfigurationReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new PutSmbConfigurationReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "putSmbConfiguration" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> QuarantineThreatHuntMatchesReply? QuarantineThreatHuntMatches
        // GraphQL -> quarantineThreatHuntMatches: QuarantineThreatHuntMatchesReply! (type)
        public static string QuarantineThreatHuntMatches(
            ref QuarantineThreatHuntMatchesReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new QuarantineThreatHuntMatchesReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "quarantineThreatHuntMatches" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MosaicAsyncResponse? RecoverCassandraSource
        // GraphQL -> recoverCassandraSource: MosaicAsyncResponse! (type)
        public static string RecoverCassandraSource(
            ref MosaicAsyncResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new MosaicAsyncResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "recoverCassandraSource" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CcProvisionJobReply? RecoverCloudCluster
        // GraphQL -> recoverCloudCluster: CcProvisionJobReply! (type)
        public static string RecoverCloudCluster(
            ref CcProvisionJobReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CcProvisionJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "recoverCloudCluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RecoverCloudDirectPath
        // GraphQL -> recoverCloudDirectPath: AsyncRequestStatus! (type)
        public static string RecoverCloudDirectPath(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "recoverCloudDirectPath" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RecoverMongoSource
        // GraphQL -> recoverMongoSource: AsyncRequestStatus! (type)
        public static string RecoverMongoSource(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "recoverMongoSource" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MosaicAsyncResponse? RecoverMongodbSource
        // GraphQL -> recoverMongodbSource: MosaicAsyncResponse! (type)
        public static string RecoverMongodbSource(
            ref MosaicAsyncResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new MosaicAsyncResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "recoverMongodbSource" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RefreshDb2Database
        // GraphQL -> refreshDb2Database: AsyncRequestStatus! (type)
        public static string RefreshDb2Database(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "refreshDb2Database" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GlobalManagerConnectivity? RefreshGlobalManagerConnectivityStatus
        // GraphQL -> refreshGlobalManagerConnectivityStatus: GlobalManagerConnectivity! (type)
        public static string RefreshGlobalManagerConnectivityStatus(
            ref GlobalManagerConnectivity? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new GlobalManagerConnectivity() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "refreshGlobalManagerConnectivityStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RefreshHostReply? RefreshHost
        // GraphQL -> refreshHost: RefreshHostReply! (type)
        public static string RefreshHost(
            ref RefreshHostReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RefreshHostReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "refreshHost" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RefreshHypervScvmm
        // GraphQL -> refreshHypervScvmm: AsyncRequestStatus! (type)
        public static string RefreshHypervScvmm(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "refreshHypervScvmm" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RefreshHypervServer
        // GraphQL -> refreshHypervServer: AsyncRequestStatus! (type)
        public static string RefreshHypervServer(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "refreshHypervServer" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? RefreshK8sCluster
        // GraphQL -> refreshK8sCluster: CreateOnDemandJobReply! (type)
        public static string RefreshK8sCluster(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "refreshK8sCluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RefreshNasSystemsReply? RefreshNasSystems
        // GraphQL -> refreshNasSystems: RefreshNasSystemsReply! (type)
        public static string RefreshNasSystems(
            ref RefreshNasSystemsReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RefreshNasSystemsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "refreshNasSystems" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RefreshNutanixCluster
        // GraphQL -> refreshNutanixCluster: AsyncRequestStatus! (type)
        public static string RefreshNutanixCluster(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "refreshNutanixCluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncRequestStatus? RefreshNutanixPrismCentral
        // GraphQL -> refreshNutanixPrismCentral: BatchAsyncRequestStatus! (type)
        public static string RefreshNutanixPrismCentral(
            ref BatchAsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "refreshNutanixPrismCentral" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? RefreshO365Org
        // GraphQL -> refreshO365Org: CreateOnDemandJobReply! (type)
        public static string RefreshO365Org(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "\n(\norgId: $orgId\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "refreshO365Org" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RefreshOracleDatabase
        // GraphQL -> refreshOracleDatabase: AsyncRequestStatus! (type)
        public static string RefreshOracleDatabase(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "refreshOracleDatabase" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RefreshStorageArraysReply? RefreshStorageArrays
        // GraphQL -> refreshStorageArrays: RefreshStorageArraysReply! (type)
        public static string RefreshStorageArrays(
            ref RefreshStorageArraysReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RefreshStorageArraysReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "refreshStorageArrays" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RefreshVcdInstancesReply? RefreshVcdInstances
        // GraphQL -> refreshVcdInstances: RefreshVcdInstancesReply! (type)
        public static string RefreshVcdInstances(
            ref RefreshVcdInstancesReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RefreshVcdInstancesReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "refreshVcdInstances" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RefreshVsphereVcenter
        // GraphQL -> refreshVsphereVcenter: AsyncRequestStatus! (type)
        public static string RefreshVsphereVcenter(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "refreshVsphereVcenter" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? RegisterAgentHypervVirtualMachine
        // GraphQL -> registerAgentHypervVirtualMachine: RequestSuccess! (type)
        public static string RegisterAgentHypervVirtualMachine(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "registerAgentHypervVirtualMachine" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? RegisterAgentNutanixVm
        // GraphQL -> registerAgentNutanixVm: RequestSuccess! (type)
        public static string RegisterAgentNutanixVm(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "registerAgentNutanixVm" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RegisterCloudClusterReply? RegisterCloudCluster
        // GraphQL -> registerCloudCluster: RegisterCloudClusterReply! (type)
        public static string RegisterCloudCluster(
            ref RegisterCloudClusterReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RegisterCloudClusterReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "registerCloudCluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RegisterHypervScvmm
        // GraphQL -> registerHypervScvmm: AsyncRequestStatus! (type)
        public static string RegisterHypervScvmm(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "registerHypervScvmm" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RegisterNasSystemReply? RegisterNasSystem
        // GraphQL -> registerNasSystem: RegisterNasSystemReply! (type)
        public static string RegisterNasSystem(
            ref RegisterNasSystemReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RegisterNasSystemReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "registerNasSystem" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ReleaseThreatHuntMatchesFromQuarantineReply? ReleaseThreatHuntMatchesFromQuarantine
        // GraphQL -> releaseThreatHuntMatchesFromQuarantine: ReleaseThreatHuntMatchesFromQuarantineReply! (type)
        public static string ReleaseThreatHuntMatchesFromQuarantine(
            ref ReleaseThreatHuntMatchesFromQuarantineReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ReleaseThreatHuntMatchesFromQuarantineReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "releaseThreatHuntMatchesFromQuarantine" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CcProvisionJobReply? RemoveCloudClusterNodes
        // GraphQL -> removeCloudClusterNodes: CcProvisionJobReply! (type)
        public static string RemoveCloudClusterNodes(
            ref CcProvisionJobReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CcProvisionJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "removeCloudClusterNodes" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CcProvisionJobReply? RemoveClusterNodes
        // GraphQL -> removeClusterNodes: CcProvisionJobReply! (type)
        public static string RemoveClusterNodes(
            ref CcProvisionJobReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CcProvisionJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "removeClusterNodes" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? RemoveDisk
        // GraphQL -> removeDisk: ResponseSuccess! (type)
        public static string RemoveDisk(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "removeDisk" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? RemoveProxyConfig
        // GraphQL -> removeProxyConfig: ResponseSuccess! (type)
        public static string RemoveProxyConfig(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "removeProxyConfig" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RemoveVlansReply? RemoveVlans
        // GraphQL -> removeVlans: RemoveVlansReply! (type)
        public static string RemoveVlans(
            ref RemoveVlansReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RemoveVlansReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "removeVlans" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ReseedLogShippingSecondary
        // GraphQL -> reseedLogShippingSecondary: AsyncRequestStatus! (type)
        public static string ReseedLogShippingSecondary(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "reseedLogShippingSecondary" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? ResizeDisk
        // GraphQL -> resizeDisk: ResponseSuccess! (type)
        public static string ResizeDisk(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "resizeDisk" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ResizeManagedVolume
        // GraphQL -> resizeManagedVolume: AsyncRequestStatus! (type)
        public static string ResizeManagedVolume(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "resizeManagedVolume" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? ResolveVolumeGroupsConflict
        // GraphQL -> resolveVolumeGroupsConflict: RequestSuccess! (type)
        public static string ResolveVolumeGroupsConflict(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "resolveVolumeGroupsConflict" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? RestoreConfigProtectionBackup
        // GraphQL -> restoreConfigProtectionBackup: AsyncJobStatus! (type)
        public static string RestoreConfigProtectionBackup(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "restoreConfigProtectionBackup" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RestoreFilesNutanixSnapshot
        // GraphQL -> restoreFilesNutanixSnapshot: AsyncRequestStatus! (type)
        public static string RestoreFilesNutanixSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "restoreFilesNutanixSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RestoreHypervVirtualMachineSnapshotFiles
        // GraphQL -> restoreHypervVirtualMachineSnapshotFiles: AsyncRequestStatus! (type)
        public static string RestoreHypervVirtualMachineSnapshotFiles(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "restoreHypervVirtualMachineSnapshotFiles" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? RestoreK8sNamespace
        // GraphQL -> restoreK8sNamespace: CreateOnDemandJobReply! (type)
        public static string RestoreK8sNamespace(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "restoreK8sNamespace" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RestoreMssqlDatabase
        // GraphQL -> restoreMssqlDatabase: AsyncRequestStatus! (type)
        public static string RestoreMssqlDatabase(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "restoreMssqlDatabase" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? RestoreO365Mailbox
        // GraphQL -> restoreO365Mailbox: CreateOnDemandJobReply! (type)
        public static string RestoreO365Mailbox(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "\n(\nrestoreConfig: $restoreConfig\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "restoreO365Mailbox" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? RestoreO365Snappable
        // GraphQL -> restoreO365Snappable: CreateOnDemandJobReply! (type)
        public static string RestoreO365Snappable(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "restoreO365Snappable" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? RestoreO365TeamsConversations
        // GraphQL -> restoreO365TeamsConversations: CreateOnDemandJobReply! (type)
        public static string RestoreO365TeamsConversations(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "restoreO365TeamsConversations" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? RestoreO365TeamsFiles
        // GraphQL -> restoreO365TeamsFiles: CreateOnDemandJobReply! (type)
        public static string RestoreO365TeamsFiles(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "restoreO365TeamsFiles" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RestoreOracleLogs
        // GraphQL -> restoreOracleLogs: AsyncRequestStatus! (type)
        public static string RestoreOracleLogs(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "restoreOracleLogs" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RestoreVolumeGroupSnapshotFiles
        // GraphQL -> restoreVolumeGroupSnapshotFiles: AsyncRequestStatus! (type)
        public static string RestoreVolumeGroupSnapshotFiles(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "restoreVolumeGroupSnapshotFiles" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResumeTargetReply? ResumeTarget
        // GraphQL -> resumeTarget: ResumeTargetReply! (type)
        public static string ResumeTarget(
            ref ResumeTargetReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ResumeTargetReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "resumeTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? RetryAddMongoSource
        // GraphQL -> retryAddMongoSource: AsyncRequestStatus! (type)
        public static string RetryAddMongoSource(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "retryAddMongoSource" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RetryBackupResp? RetryBackup
        // GraphQL -> retryBackup: RetryBackupResp! (type)
        public static string RetryBackup(
            ref RetryBackupResp? cmdletReply
        )
        {
            string args = "\n(\nbackupObjects: $backupObjects\nbackupRunConfig: $backupRunConfig\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RetryBackupResp() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "retryBackup" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DownloadPackageReply? RetryDownloadPackageJob
        // GraphQL -> retryDownloadPackageJob: DownloadPackageReply! (type)
        public static string RetryDownloadPackageJob(
            ref DownloadPackageReply? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DownloadPackageReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "retryDownloadPackageJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RotateServiceAccountSecretReply? RotateServiceAccountSecret
        // GraphQL -> rotateServiceAccountSecret: RotateServiceAccountSecretReply! (type)
        public static string RotateServiceAccountSecret(
            ref RotateServiceAccountSecretReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RotateServiceAccountSecretReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "rotateServiceAccountSecret" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RunCustomAnalyzerReply? RunCustomAnalyzer
        // GraphQL -> runCustomAnalyzer: RunCustomAnalyzerReply! (type)
        public static string RunCustomAnalyzer(
            ref RunCustomAnalyzerReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RunCustomAnalyzerReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "runCustomAnalyzer" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<UpgradeJobReplyWithUuid>? ScheduleUpgradeBatchJob
        // GraphQL -> scheduleUpgradeBatchJob: [UpgradeJobReplyWithUuid!]! (type)
        public static string ScheduleUpgradeBatchJob(
            ref List<UpgradeJobReplyWithUuid>? cmdletReply
        )
        {
            string args = "\n(\nlistClusterUuid: $listClusterUuid\nmode: $mode\naction: $action\nversion: $version\nscheduleAt: $scheduleAt\ncontext_tag: $context_tag\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new List<UpgradeJobReplyWithUuid>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "scheduleUpgradeBatchJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SeedEnabledPoliciesReply? SeedEnabledPolicies
        // GraphQL -> seedEnabledPolicies: SeedEnabledPoliciesReply! (type)
        public static string SeedEnabledPolicies(
            ref SeedEnabledPoliciesReply? cmdletReply
        )
        {
            string args = "";
           if (cmdletReply == null)
            {
                cmdletReply = new SeedEnabledPoliciesReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "seedEnabledPolicies" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SeedInitialPoliciesReply? SeedInitialPolicies
        // GraphQL -> seedInitialPolicies: SeedInitialPoliciesReply! (type)
        public static string SeedInitialPolicies(
            ref SeedInitialPoliciesReply? cmdletReply
        )
        {
            string args = "";
           if (cmdletReply == null)
            {
                cmdletReply = new SeedInitialPoliciesReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "seedInitialPolicies" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ReportGenerateReply? SendEmailNow
        // GraphQL -> sendEmailNow: reportGenerateReply! (type)
        public static string SendEmailNow(
            ref ReportGenerateReply? cmdletReply
        )
        {
            string args = "\n(\nreportID: $reportID\nreportConfig: $reportConfig\nrecipients: $recipients\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ReportGenerateReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sendEmailNow" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SendPdfReportReply? SendPdfReport
        // GraphQL -> sendPdfReport: SendPdfReportReply! (type)
        public static string SendPdfReport(
            ref SendPdfReportReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new SendPdfReportReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sendPdfReport" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncDownloadReply? SendScheduledReportAsync
        // GraphQL -> sendScheduledReportAsync: AsyncDownloadReply! (type)
        public static string SendScheduledReportAsync(
            ref AsyncDownloadReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncDownloadReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sendScheduledReportAsync" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AspValue? SetAccountSettingValue
        // GraphQL -> setAccountSettingValue: ASPValue! (type)
        public static string SetAccountSettingValue(
            ref AspValue? cmdletReply
        )
        {
            string args = "\n(\naspName: $aspName\naspComponent: $aspComponent\naspValue: $aspValue\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AspValue() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "setAccountSettingValue" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SetAnalyzerRisksReply? SetAnalyzerRisks
        // GraphQL -> setAnalyzerRisks: SetAnalyzerRisksReply! (type)
        public static string SetAnalyzerRisks(
            ref SetAnalyzerRisksReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new SetAnalyzerRisksReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "setAnalyzerRisks" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SetDatastoreFreespaceThresholdsReply? SetDatastoreFreespaceThresholds
        // GraphQL -> setDatastoreFreespaceThresholds: SetDatastoreFreespaceThresholdsReply! (type)
        public static string SetDatastoreFreespaceThresholds(
            ref SetDatastoreFreespaceThresholdsReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new SetDatastoreFreespaceThresholdsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "setDatastoreFreespaceThresholds" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> IdentityProvider? SetIdentityProvider
        // GraphQL -> setIdentityProvider: IdentityProvider! (type)
        public static string SetIdentityProvider(
            ref IdentityProvider? cmdletReply
        )
        {
            string args = "\n(\nentityId: $entityId\nsignInUrl: $signInUrl\nsigningCertificate: $signingCertificate\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new IdentityProvider() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "setIdentityProvider" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? SetKmipClient
        // GraphQL -> setKmipClient: AsyncRequestStatus! (type)
        public static string SetKmipClient(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "setKmipClient" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestStatus? SetO365ServiceAccount
        // GraphQL -> setO365ServiceAccount: RequestStatus! (type)
        public static string SetO365ServiceAccount(
            ref RequestStatus? cmdletReply
        )
        {
            string args = "\n(\nusername: $username\nappPassword: $appPassword\norgId: $orgId\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "setO365ServiceAccount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SetUpgradeTypeReply? SetUpgradeType
        // GraphQL -> setUpgradeType: SetUpgradeTypeReply! (type)
        public static string SetUpgradeType(
            ref SetUpgradeTypeReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new SetUpgradeTypeReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "setUpgradeType" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SetUserSessionManagementConfigReply? SetUserSessionManagementConfig
        // GraphQL -> setUserSessionManagementConfig: SetUserSessionManagementConfigReply! (type)
        public static string SetUserSessionManagementConfig(
            ref SetUserSessionManagementConfigReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new SetUserSessionManagementConfigReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "setUserSessionManagementConfig" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UserSetting? SetUserSetting
        // GraphQL -> setUserSetting: UserSetting! (type)
        public static string SetUserSetting(
            ref UserSetting? cmdletReply
        )
        {
            string args = "\n(\nuserSetting: $userSetting\nisOrgSpecificSetting: $isOrgSpecificSetting\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UserSetting() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "setUserSetting" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? SetWebSignedCertificate
        // GraphQL -> setWebSignedCertificate: AsyncRequestStatus! (type)
        public static string SetWebSignedCertificate(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "setWebSignedCertificate" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SetWorkloadAlertSettingReply? SetWorkloadAlertSetting
        // GraphQL -> setWorkloadAlertSetting: SetWorkloadAlertSettingReply! (type)
        public static string SetWorkloadAlertSetting(
            ref SetWorkloadAlertSettingReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new SetWorkloadAlertSettingReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "setWorkloadAlertSetting" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SetupAzureO365ExocomputeResp? SetupAzureO365Exocompute
        // GraphQL -> setupAzureO365Exocompute: SetupAzureO365ExocomputeResp! (type)
        public static string SetupAzureO365Exocompute(
            ref SetupAzureO365ExocomputeResp? cmdletReply
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nexocomputeConfig: $exocomputeConfig\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new SetupAzureO365ExocomputeResp() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "setupAzureO365Exocompute" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncJobStatus? SetupCloudNativeSqlServerBackup
        // GraphQL -> setupCloudNativeSqlServerBackup: BatchAsyncJobStatus! (type)
        public static string SetupCloudNativeSqlServerBackup(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "setupCloudNativeSqlServerBackup" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DiskInfo? SetupDisk
        // GraphQL -> setupDisk: DiskInfo! (type)
        public static string SetupDisk(
            ref DiskInfo? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DiskInfo() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "setupDisk" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? StartAwsExocomputeDisableJob
        // GraphQL -> startAwsExocomputeDisableJob: AsyncJobStatus! (type)
        public static string StartAwsExocomputeDisableJob(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startAwsExocomputeDisableJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? StartAwsNativeAccountDisableJob
        // GraphQL -> startAwsNativeAccountDisableJob: AsyncJobStatus! (type)
        public static string StartAwsNativeAccountDisableJob(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startAwsNativeAccountDisableJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncJobStatus? StartAwsNativeEc2InstanceSnapshotsJob
        // GraphQL -> startAwsNativeEc2InstanceSnapshotsJob: BatchAsyncJobStatus! (type)
        public static string StartAwsNativeEc2InstanceSnapshotsJob(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startAwsNativeEc2InstanceSnapshotsJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncJobStatus? StartAwsNativeRdsInstanceSnapshotsJob
        // GraphQL -> startAwsNativeRdsInstanceSnapshotsJob: BatchAsyncJobStatus! (type)
        public static string StartAwsNativeRdsInstanceSnapshotsJob(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startAwsNativeRdsInstanceSnapshotsJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> StartAzureCloudAccountOauthReply? StartAzureCloudAccountOauth
        // GraphQL -> startAzureCloudAccountOauth: StartAzureCloudAccountOauthReply! (type)
        public static string StartAzureCloudAccountOauth(
            ref StartAzureCloudAccountOauthReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new StartAzureCloudAccountOauthReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startAzureCloudAccountOauth" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? StartBlueprintFailover
        // GraphQL -> startBlueprintFailover: CreateOnDemandJobReply! (type)
        public static string StartBlueprintFailover(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "\n(\nfailoverJobConfig: $failoverJobConfig\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startBlueprintFailover" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CreateOnDemandJobReply>? StartBlueprintsFailover
        // GraphQL -> startBlueprintsFailover: [CreateOnDemandJobReply!]! (type)
        public static string StartBlueprintsFailover(
            ref List<CreateOnDemandJobReply>? cmdletReply
        )
        {
            string args = "\n(\nfailoverJobConfigs: $failoverJobConfigs\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new List<CreateOnDemandJobReply>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startBlueprintsFailover" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> StartBulkRecoveryReply? StartBulkRecovery
        // GraphQL -> startBulkRecovery: StartBulkRecoveryReply! (type)
        public static string StartBulkRecovery(
            ref StartBulkRecoveryReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new StartBulkRecoveryReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startBulkRecovery" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncJobStatus? StartCloudNativeSnapshotsIndexJob
        // GraphQL -> startCloudNativeSnapshotsIndexJob: BatchAsyncJobStatus! (type)
        public static string StartCloudNativeSnapshotsIndexJob(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startCloudNativeSnapshotsIndexJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> StartCrawlReply? StartCrawl
        // GraphQL -> startCrawl: StartCrawlReply! (type)
        public static string StartCrawl(
            ref StartCrawlReply? cmdletReply
        )
        {
            string args = "\n(\nname: $name\nresources: $resources\nanalyzerGroups: $analyzerGroups\nextWhiteList: $extWhiteList\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new StartCrawlReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startCrawl" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncJobStatus? StartCreateAwsNativeEbsVolumeSnapshotsJob
        // GraphQL -> startCreateAwsNativeEbsVolumeSnapshotsJob: BatchAsyncJobStatus! (type)
        public static string StartCreateAwsNativeEbsVolumeSnapshotsJob(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startCreateAwsNativeEbsVolumeSnapshotsJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncJobStatus? StartCreateAzureNativeManagedDiskSnapshotsJob
        // GraphQL -> startCreateAzureNativeManagedDiskSnapshotsJob: BatchAsyncJobStatus! (type)
        public static string StartCreateAzureNativeManagedDiskSnapshotsJob(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startCreateAzureNativeManagedDiskSnapshotsJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncJobStatus? StartCreateAzureNativeVirtualMachineSnapshotsJob
        // GraphQL -> startCreateAzureNativeVirtualMachineSnapshotsJob: BatchAsyncJobStatus! (type)
        public static string StartCreateAzureNativeVirtualMachineSnapshotsJob(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startCreateAzureNativeVirtualMachineSnapshotsJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CreateOnDemandJobReply? StartCyberRecovery
        // GraphQL -> startCyberRecovery: CreateOnDemandJobReply! (type)
        public static string StartCyberRecovery(
            ref CreateOnDemandJobReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new CreateOnDemandJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startCyberRecovery" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncJobStatus? StartDisableAzureCloudAccountJob
        // GraphQL -> startDisableAzureCloudAccountJob: BatchAsyncJobStatus! (type)
        public static string StartDisableAzureCloudAccountJob(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startDisableAzureCloudAccountJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? StartDisableAzureNativeSubscriptionProtectionJob
        // GraphQL -> startDisableAzureNativeSubscriptionProtectionJob: AsyncJobStatus! (type)
        public static string StartDisableAzureNativeSubscriptionProtectionJob(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startDisableAzureNativeSubscriptionProtectionJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<DownloadPackageReplyWithUuid>? StartDownloadPackageBatchJob
        // GraphQL -> startDownloadPackageBatchJob: [DownloadPackageReplyWithUuid!]! (type)
        public static string StartDownloadPackageBatchJob(
            ref List<DownloadPackageReplyWithUuid>? cmdletReply
        )
        {
            string args = "\n(\nlistClusterUuid: $listClusterUuid\ndownloadVersion: $downloadVersion\npackageUrl: $packageUrl\nmd5checksum: $md5checksum\nsize: $size\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new List<DownloadPackageReplyWithUuid>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startDownloadPackageBatchJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? StartEc2InstanceSnapshotExportJob
        // GraphQL -> startEc2InstanceSnapshotExportJob: AsyncJobStatus! (type)
        public static string StartEc2InstanceSnapshotExportJob(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startEc2InstanceSnapshotExportJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? StartExportAwsNativeEbsVolumeSnapshotJob
        // GraphQL -> startExportAwsNativeEbsVolumeSnapshotJob: AsyncJobStatus! (type)
        public static string StartExportAwsNativeEbsVolumeSnapshotJob(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startExportAwsNativeEbsVolumeSnapshotJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? StartExportAzureNativeManagedDiskJob
        // GraphQL -> startExportAzureNativeManagedDiskJob: AsyncJobStatus! (type)
        public static string StartExportAzureNativeManagedDiskJob(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startExportAzureNativeManagedDiskJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? StartExportAzureNativeVirtualMachineJob
        // GraphQL -> startExportAzureNativeVirtualMachineJob: AsyncJobStatus! (type)
        public static string StartExportAzureNativeVirtualMachineJob(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startExportAzureNativeVirtualMachineJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? StartExportAzureSqlDatabaseDbJob
        // GraphQL -> startExportAzureSqlDatabaseDbJob: AsyncJobStatus! (type)
        public static string StartExportAzureSqlDatabaseDbJob(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startExportAzureSqlDatabaseDbJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? StartExportAzureSqlManagedInstanceDbJob
        // GraphQL -> startExportAzureSqlManagedInstanceDbJob: AsyncJobStatus! (type)
        public static string StartExportAzureSqlManagedInstanceDbJob(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startExportAzureSqlManagedInstanceDbJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? StartExportRdsInstanceJob
        // GraphQL -> startExportRdsInstanceJob: AsyncJobStatus! (type)
        public static string StartExportRdsInstanceJob(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startExportRdsInstanceJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? StartMalwareDetection
        // GraphQL -> startMalwareDetection: AsyncRequestStatus! (type)
        public static string StartMalwareDetection(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startMalwareDetection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PrechecksJobReply? StartPeriodicUpgradePrechecksOnDemandJob
        // GraphQL -> startPeriodicUpgradePrechecksOnDemandJob: PrechecksJobReply! (type)
        public static string StartPeriodicUpgradePrechecksOnDemandJob(
            ref PrechecksJobReply? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new PrechecksJobReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startPeriodicUpgradePrechecksOnDemandJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? StartRecoverS3SnapshotJob
        // GraphQL -> startRecoverS3SnapshotJob: AsyncJobStatus! (type)
        public static string StartRecoverS3SnapshotJob(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startRecoverS3SnapshotJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncJobStatus? StartRefreshAwsNativeAccountsJob
        // GraphQL -> startRefreshAwsNativeAccountsJob: BatchAsyncJobStatus! (type)
        public static string StartRefreshAwsNativeAccountsJob(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startRefreshAwsNativeAccountsJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncJobStatus? StartRefreshAzureNativeSubscriptionsJob
        // GraphQL -> startRefreshAzureNativeSubscriptionsJob: BatchAsyncJobStatus! (type)
        public static string StartRefreshAzureNativeSubscriptionsJob(
            ref BatchAsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startRefreshAzureNativeSubscriptionsJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? StartRestoreAwsNativeEc2InstanceSnapshotJob
        // GraphQL -> startRestoreAwsNativeEc2InstanceSnapshotJob: AsyncJobStatus! (type)
        public static string StartRestoreAwsNativeEc2InstanceSnapshotJob(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startRestoreAwsNativeEc2InstanceSnapshotJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? StartRestoreAzureNativeVirtualMachineJob
        // GraphQL -> startRestoreAzureNativeVirtualMachineJob: AsyncJobStatus! (type)
        public static string StartRestoreAzureNativeVirtualMachineJob(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startRestoreAzureNativeVirtualMachineJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> StartThreatHuntReply? StartThreatHunt
        // GraphQL -> startThreatHunt: StartThreatHuntReply! (type)
        public static string StartThreatHunt(
            ref StartThreatHuntReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new StartThreatHuntReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startThreatHunt" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<UpgradeJobReplyWithUuid>? StartUpgradeBatchJob
        // GraphQL -> startUpgradeBatchJob: [UpgradeJobReplyWithUuid!]! (type)
        public static string StartUpgradeBatchJob(
            ref List<UpgradeJobReplyWithUuid>? cmdletReply
        )
        {
            string args = "\n(\nlistClusterUuid: $listClusterUuid\nmode: $mode\naction: $action\nversion: $version\ncontext_tag: $context_tag\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new List<UpgradeJobReplyWithUuid>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startUpgradeBatchJob" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? StartVolumeGroupMount
        // GraphQL -> startVolumeGroupMount: AsyncRequestStatus! (type)
        public static string StartVolumeGroupMount(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "startVolumeGroupMount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> StopJobInstanceReply? StopJobInstance
        // GraphQL -> stopJobInstance: StopJobInstanceReply! (type)
        public static string StopJobInstance(
            ref StopJobInstanceReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new StopJobInstanceReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "stopJobInstance" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SupportPortalLoginReply? SupportPortalLogin
        // GraphQL -> supportPortalLogin: SupportPortalLoginReply! (type)
        public static string SupportPortalLogin(
            ref SupportPortalLoginReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new SupportPortalLoginReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "supportPortalLogin" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? TakeManagedVolumeOnDemandSnapshot
        // GraphQL -> takeManagedVolumeOnDemandSnapshot: AsyncRequestStatus! (type)
        public static string TakeManagedVolumeOnDemandSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "takeManagedVolumeOnDemandSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? TakeMssqlLogBackup
        // GraphQL -> takeMssqlLogBackup: AsyncRequestStatus! (type)
        public static string TakeMssqlLogBackup(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "takeMssqlLogBackup" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? TakeOnDemandOracleDatabaseSnapshot
        // GraphQL -> takeOnDemandOracleDatabaseSnapshot: AsyncRequestStatus! (type)
        public static string TakeOnDemandOracleDatabaseSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "takeOnDemandOracleDatabaseSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? TakeOnDemandOracleLogSnapshot
        // GraphQL -> takeOnDemandOracleLogSnapshot: AsyncRequestStatus! (type)
        public static string TakeOnDemandOracleLogSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "takeOnDemandOracleLogSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TakeOnDemandSnapshotReply? TakeOnDemandSnapshot
        // GraphQL -> takeOnDemandSnapshot: TakeOnDemandSnapshotReply! (type)
        public static string TakeOnDemandSnapshot(
            ref TakeOnDemandSnapshotReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new TakeOnDemandSnapshotReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "takeOnDemandSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TestExistingWebhookReply? TestExistingWebhook
        // GraphQL -> testExistingWebhook: TestExistingWebhookReply! (type)
        public static string TestExistingWebhook(
            ref TestExistingWebhookReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new TestExistingWebhookReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "testExistingWebhook" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TestSyslogExportRuleReply? TestSyslogExportRule
        // GraphQL -> testSyslogExportRule: TestSyslogExportRuleReply! (type)
        public static string TestSyslogExportRule(
            ref TestSyslogExportRuleReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new TestSyslogExportRuleReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "testSyslogExportRule" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TestWebhookReply? TestWebhook
        // GraphQL -> testWebhook: TestWebhookReply! (type)
        public static string TestWebhook(
            ref TestWebhookReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new TestWebhookReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "testWebhook" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? TriggerCloudComputeConnectivityCheck
        // GraphQL -> triggerCloudComputeConnectivityCheck: AsyncRequestStatus! (type)
        public static string TriggerCloudComputeConnectivityCheck(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "triggerCloudComputeConnectivityCheck" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TriggerExocomputeHealthCheckReply? TriggerExocomputeHealthCheck
        // GraphQL -> triggerExocomputeHealthCheck: TriggerExocomputeHealthCheckReply! (type)
        public static string TriggerExocomputeHealthCheck(
            ref TriggerExocomputeHealthCheckReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new TriggerExocomputeHealthCheckReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "triggerExocomputeHealthCheck" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TriggerRansomwareDetectionReply? TriggerRansomwareDetection
        // GraphQL -> triggerRansomwareDetection: TriggerRansomwareDetectionReply! (type)
        public static string TriggerRansomwareDetection(
            ref TriggerRansomwareDetectionReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new TriggerRansomwareDetectionReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "triggerRansomwareDetection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? UnconfigureSapHanaRestore
        // GraphQL -> unconfigureSapHanaRestore: AsyncRequestStatus! (type)
        public static string UnconfigureSapHanaRestore(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "unconfigureSapHanaRestore" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? UninstallIoFilter
        // GraphQL -> uninstallIoFilter: RequestSuccess! (type)
        public static string UninstallIoFilter(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "uninstallIoFilter" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UnmapAzureCloudAccountExocomputeSubscriptionReply? UnmapAzureCloudAccountExocomputeSubscription
        // GraphQL -> unmapAzureCloudAccountExocomputeSubscription: UnmapAzureCloudAccountExocomputeSubscriptionReply! (type)
        public static string UnmapAzureCloudAccountExocomputeSubscription(
            ref UnmapAzureCloudAccountExocomputeSubscriptionReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UnmapAzureCloudAccountExocomputeSubscriptionReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "unmapAzureCloudAccountExocomputeSubscription" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UnmapCloudAccountExocomputeAccountReply? UnmapCloudAccountExocomputeAccount
        // GraphQL -> unmapCloudAccountExocomputeAccount: UnmapCloudAccountExocomputeAccountReply! (type)
        public static string UnmapCloudAccountExocomputeAccount(
            ref UnmapCloudAccountExocomputeAccountReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UnmapCloudAccountExocomputeAccountReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "unmapCloudAccountExocomputeAccount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AccountSetting? UpdateAccountSettings
        // GraphQL -> updateAccountSettings: AccountSetting! (type)
        public static string UpdateAccountSettings(
            ref AccountSetting? cmdletReply
        )
        {
            string args = "\n(\nisEulaAccepted: $isEulaAccepted\nisEmailNotificationEnabled: $isEmailNotificationEnabled\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AccountSetting() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateAccountSettings" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateAutoEnablePolicyClusterConfigReply? UpdateAutoEnablePolicyClusterConfig
        // GraphQL -> updateAutoEnablePolicyClusterConfig: UpdateAutoEnablePolicyClusterConfigReply! (type)
        public static string UpdateAutoEnablePolicyClusterConfig(
            ref UpdateAutoEnablePolicyClusterConfigReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateAutoEnablePolicyClusterConfigReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateAutoEnablePolicyClusterConfig" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TargetMapping? UpdateAutomaticAwsTargetMapping
        // GraphQL -> updateAutomaticAwsTargetMapping: TargetMapping! (type)
        public static string UpdateAutomaticAwsTargetMapping(
            ref TargetMapping? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new TargetMapping() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateAutomaticAwsTargetMapping" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TargetMapping? UpdateAutomaticAzureTargetMapping
        // GraphQL -> updateAutomaticAzureTargetMapping: TargetMapping! (type)
        public static string UpdateAutomaticAzureTargetMapping(
            ref TargetMapping? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new TargetMapping() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateAutomaticAzureTargetMapping" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateAwsCloudAccountFeatureReply? UpdateAwsCloudAccountFeature
        // GraphQL -> updateAwsCloudAccountFeature: UpdateAwsCloudAccountFeatureReply! (type)
        public static string UpdateAwsCloudAccountFeature(
            ref UpdateAwsCloudAccountFeatureReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateAwsCloudAccountFeatureReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateAwsCloudAccountFeature" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsComputeSettings? UpdateAwsComputeSetting
        // GraphQL -> updateAwsComputeSetting: AwsComputeSettings! (type)
        public static string UpdateAwsComputeSetting(
            ref AwsComputeSettings? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AwsComputeSettings() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateAwsComputeSetting" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateAwsExocomputeConfigsReply? UpdateAwsExocomputeConfigs
        // GraphQL -> updateAwsExocomputeConfigs: UpdateAwsExocomputeConfigsReply! (type)
        public static string UpdateAwsExocomputeConfigs(
            ref UpdateAwsExocomputeConfigsReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateAwsExocomputeConfigsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateAwsExocomputeConfigs" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateAzureCloudAccountReply? UpdateAzureCloudAccount
        // GraphQL -> updateAzureCloudAccount: UpdateAzureCloudAccountReply! (type)
        public static string UpdateAzureCloudAccount(
            ref UpdateAzureCloudAccountReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateAzureCloudAccountReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateAzureCloudAccount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateBadDiskLedStatusReply? UpdateBadDiskLedStatus
        // GraphQL -> updateBadDiskLedStatus: UpdateBadDiskLedStatusReply! (type)
        public static string UpdateBadDiskLedStatus(
            ref UpdateBadDiskLedStatusReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateBadDiskLedStatusReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateBadDiskLedStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MosaicAsyncResponse? UpdateCassandraSource
        // GraphQL -> updateCassandraSource: MosaicAsyncResponse! (type)
        public static string UpdateCassandraSource(
            ref MosaicAsyncResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new MosaicAsyncResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateCassandraSource" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateCertificateHostReply? UpdateCertificateHost
        // GraphQL -> updateCertificateHost: UpdateCertificateHostReply! (type)
        public static string UpdateCertificateHost(
            ref UpdateCertificateHostReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateCertificateHostReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateCertificateHost" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateCloudNativeAwsStorageSettingReply? UpdateCloudNativeAwsStorageSetting
        // GraphQL -> updateCloudNativeAwsStorageSetting: UpdateCloudNativeAwsStorageSettingReply! (type)
        public static string UpdateCloudNativeAwsStorageSetting(
            ref UpdateCloudNativeAwsStorageSettingReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateCloudNativeAwsStorageSettingReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateCloudNativeAwsStorageSetting" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateCloudNativeAzureStorageSettingReply? UpdateCloudNativeAzureStorageSetting
        // GraphQL -> updateCloudNativeAzureStorageSetting: UpdateCloudNativeAzureStorageSettingReply! (type)
        public static string UpdateCloudNativeAzureStorageSetting(
            ref UpdateCloudNativeAzureStorageSettingReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateCloudNativeAzureStorageSettingReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateCloudNativeAzureStorageSetting" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateCloudNativeIndexingStatusReply? UpdateCloudNativeIndexingStatus
        // GraphQL -> updateCloudNativeIndexingStatus: UpdateCloudNativeIndexingStatusReply! (type)
        public static string UpdateCloudNativeIndexingStatus(
            ref UpdateCloudNativeIndexingStatusReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateCloudNativeIndexingStatusReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateCloudNativeIndexingStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateCloudNativeRcvAzureStorageSettingReply? UpdateCloudNativeRcvAzureStorageSetting
        // GraphQL -> updateCloudNativeRcvAzureStorageSetting: UpdateCloudNativeRcvAzureStorageSettingReply! (type)
        public static string UpdateCloudNativeRcvAzureStorageSetting(
            ref UpdateCloudNativeRcvAzureStorageSettingReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateCloudNativeRcvAzureStorageSettingReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateCloudNativeRcvAzureStorageSetting" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateClusterDefaultAddressReply? UpdateClusterDefaultAddress
        // GraphQL -> updateClusterDefaultAddress: UpdateClusterDefaultAddressReply! (type)
        public static string UpdateClusterDefaultAddress(
            ref UpdateClusterDefaultAddressReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateClusterDefaultAddressReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateClusterDefaultAddress" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Cluster? UpdateClusterLocation
        // GraphQL -> updateClusterLocation: Cluster! (type)
        public static string UpdateClusterLocation(
            ref Cluster? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nclusterLocation: $clusterLocation\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new Cluster() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateClusterLocation" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? UpdateClusterNtpServers
        // GraphQL -> updateClusterNtpServers: ResponseSuccess! (type)
        public static string UpdateClusterNtpServers(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateClusterNtpServers" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateClusterPauseStatusReply? UpdateClusterPauseStatus
        // GraphQL -> updateClusterPauseStatus: UpdateClusterPauseStatusReply! (type)
        public static string UpdateClusterPauseStatus(
            ref UpdateClusterPauseStatusReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateClusterPauseStatusReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateClusterPauseStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateClusterRegisteredModeReply? UpdateClusterRegisteredMode
        // GraphQL -> updateClusterRegisteredMode: UpdateClusterRegisteredModeReply! (type)
        public static string UpdateClusterRegisteredMode(
            ref UpdateClusterRegisteredModeReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateClusterRegisteredModeReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateClusterRegisteredMode" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateClusterSettingsReply? UpdateClusterSettings
        // GraphQL -> updateClusterSettings: UpdateClusterSettingsReply! (type)
        public static string UpdateClusterSettings(
            ref UpdateClusterSettingsReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateClusterSettingsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateClusterSettings" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? UpdateConfigProtectionSetup
        // GraphQL -> updateConfigProtectionSetup: AsyncJobStatus! (type)
        public static string UpdateConfigProtectionSetup(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateConfigProtectionSetup" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Analyzer? UpdateCustomAnalyzer
        // GraphQL -> updateCustomAnalyzer: Analyzer! (type)
        public static string UpdateCustomAnalyzer(
            ref Analyzer? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new Analyzer() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateCustomAnalyzer" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateCustomReportReply? UpdateCustomReport
        // GraphQL -> updateCustomReport: UpdateCustomReportReply! (type)
        public static string UpdateCustomReport(
            ref UpdateCustomReportReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateCustomReportReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateCustomReport" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResponseSuccess? UpdateDnsServersAndSearchDomains
        // GraphQL -> updateDnsServersAndSearchDomains: ResponseSuccess! (type)
        public static string UpdateDnsServersAndSearchDomains(
            ref ResponseSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ResponseSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateDnsServersAndSearchDomains" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateEventDigestReply? UpdateEventDigest
        // GraphQL -> updateEventDigest: UpdateEventDigestReply! (type)
        public static string UpdateEventDigest(
            ref UpdateEventDigestReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateEventDigestReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateEventDigest" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateFailoverClusterReply? UpdateFailoverCluster
        // GraphQL -> updateFailoverCluster: UpdateFailoverClusterReply! (type)
        public static string UpdateFailoverCluster(
            ref UpdateFailoverClusterReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateFailoverClusterReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateFailoverCluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateFailoverClusterAppReply? UpdateFailoverClusterApp
        // GraphQL -> updateFailoverClusterApp: UpdateFailoverClusterAppReply! (type)
        public static string UpdateFailoverClusterApp(
            ref UpdateFailoverClusterAppReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateFailoverClusterAppReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateFailoverClusterApp" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateFloatingIpsReply? UpdateFloatingIps
        // GraphQL -> updateFloatingIps: UpdateFloatingIpsReply! (type)
        public static string UpdateFloatingIps(
            ref UpdateFloatingIpsReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateFloatingIpsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateFloatingIps" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateGlobalCertificateReply? UpdateGlobalCertificate
        // GraphQL -> updateGlobalCertificate: UpdateGlobalCertificateReply! (type)
        public static string UpdateGlobalCertificate(
            ref UpdateGlobalCertificateReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateGlobalCertificateReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateGlobalCertificate" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GlobalSlaReply? UpdateGlobalSla
        // GraphQL -> updateGlobalSla: GlobalSlaReply! (type)
        public static string UpdateGlobalSla(
            ref GlobalSlaReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new GlobalSlaReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateGlobalSla" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateGuestCredentialReply? UpdateGuestCredential
        // GraphQL -> updateGuestCredential: UpdateGuestCredentialReply! (type)
        public static string UpdateGuestCredential(
            ref UpdateGuestCredentialReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateGuestCredentialReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateGuestCredential" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateHealthMonitorPolicyStatusReply? UpdateHealthMonitorPolicyStatus
        // GraphQL -> updateHealthMonitorPolicyStatus: UpdateHealthMonitorPolicyStatusReply! (type)
        public static string UpdateHealthMonitorPolicyStatus(
            ref UpdateHealthMonitorPolicyStatusReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateHealthMonitorPolicyStatusReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateHealthMonitorPolicyStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateHypervVirtualMachineReply? UpdateHypervVirtualMachine
        // GraphQL -> updateHypervVirtualMachine: UpdateHypervVirtualMachineReply! (type)
        public static string UpdateHypervVirtualMachine(
            ref UpdateHypervVirtualMachineReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateHypervVirtualMachineReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateHypervVirtualMachine" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateHypervVirtualMachineSnapshotMountReply? UpdateHypervVirtualMachineSnapshotMount
        // GraphQL -> updateHypervVirtualMachineSnapshotMount: UpdateHypervVirtualMachineSnapshotMountReply! (type)
        public static string UpdateHypervVirtualMachineSnapshotMount(
            ref UpdateHypervVirtualMachineSnapshotMountReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateHypervVirtualMachineSnapshotMountReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateHypervVirtualMachineSnapshotMount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateIdentityProviderReply? UpdateIdentityProvider
        // GraphQL -> updateIdentityProvider: UpdateIdentityProviderReply! (type)
        public static string UpdateIdentityProvider(
            ref UpdateIdentityProviderReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateIdentityProviderReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateIdentityProvider" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateKmipServerReply? UpdateKmipServer
        // GraphQL -> updateKmipServer: UpdateKmipServerReply! (type)
        public static string UpdateKmipServer(
            ref UpdateKmipServerReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateKmipServerReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateKmipServer" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> LambdaSettings? UpdateLambdaSettings
        // GraphQL -> updateLambdaSettings: LambdaSettings! (type)
        public static string UpdateLambdaSettings(
            ref LambdaSettings? cmdletReply
        )
        {
            string args = "\n(\nanomalyThreshold: $anomalyThreshold\nransomwareThreshold: $ransomwareThreshold\nisAnomalyAlertEnabled: $isAnomalyAlertEnabled\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new LambdaSettings() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateLambdaSettings" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateLockoutConfigReply? UpdateLockoutConfig
        // GraphQL -> updateLockoutConfig: UpdateLockoutConfigReply! (type)
        public static string UpdateLockoutConfig(
            ref UpdateLockoutConfigReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateLockoutConfigReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateLockoutConfig" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateManagedVolumeReply? UpdateManagedVolume
        // GraphQL -> updateManagedVolume: UpdateManagedVolumeReply! (type)
        public static string UpdateManagedVolume(
            ref UpdateManagedVolumeReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateManagedVolumeReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateManagedVolume" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TargetMapping? UpdateManualTargetMapping
        // GraphQL -> updateManualTargetMapping: TargetMapping! (type)
        public static string UpdateManualTargetMapping(
            ref TargetMapping? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new TargetMapping() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateManualTargetMapping" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MosaicAsyncResponse? UpdateMongodbSource
        // GraphQL -> updateMongodbSource: MosaicAsyncResponse! (type)
        public static string UpdateMongodbSource(
            ref MosaicAsyncResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new MosaicAsyncResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateMongodbSource" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MosaicAsyncResponse? UpdateMosaicStore
        // GraphQL -> updateMosaicStore: MosaicAsyncResponse! (type)
        public static string UpdateMosaicStore(
            ref MosaicAsyncResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new MosaicAsyncResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateMosaicStore" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateMssqlDefaultPropertiesReply? UpdateMssqlDefaultProperties
        // GraphQL -> updateMssqlDefaultProperties: UpdateMssqlDefaultPropertiesReply! (type)
        public static string UpdateMssqlDefaultProperties(
            ref UpdateMssqlDefaultPropertiesReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateMssqlDefaultPropertiesReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateMssqlDefaultProperties" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateMssqlLogShippingConfigurationReply? UpdateMssqlLogShippingConfiguration
        // GraphQL -> updateMssqlLogShippingConfiguration: UpdateMssqlLogShippingConfigurationReply! (type)
        public static string UpdateMssqlLogShippingConfiguration(
            ref UpdateMssqlLogShippingConfigurationReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateMssqlLogShippingConfigurationReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateMssqlLogShippingConfiguration" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateNasSystemReply? UpdateNasSystem
        // GraphQL -> updateNasSystem: UpdateNasSystemReply! (type)
        public static string UpdateNasSystem(
            ref UpdateNasSystemReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateNasSystemReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateNasSystem" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateNetworkThrottleReply? UpdateNetworkThrottle
        // GraphQL -> updateNetworkThrottle: UpdateNetworkThrottleReply! (type)
        public static string UpdateNetworkThrottle(
            ref UpdateNetworkThrottleReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateNetworkThrottleReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateNetworkThrottle" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateNutanixClusterReply? UpdateNutanixCluster
        // GraphQL -> updateNutanixCluster: UpdateNutanixClusterReply! (type)
        public static string UpdateNutanixCluster(
            ref UpdateNutanixClusterReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateNutanixClusterReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateNutanixCluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateNutanixPrismCentralReply? UpdateNutanixPrismCentral
        // GraphQL -> updateNutanixPrismCentral: UpdateNutanixPrismCentralReply! (type)
        public static string UpdateNutanixPrismCentral(
            ref UpdateNutanixPrismCentralReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateNutanixPrismCentralReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateNutanixPrismCentral" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateO365AppAuthStatusReply? UpdateO365AppAuthStatus
        // GraphQL -> updateO365AppAuthStatus: UpdateO365AppAuthStatusReply! (type)
        public static string UpdateO365AppAuthStatus(
            ref UpdateO365AppAuthStatusReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateO365AppAuthStatusReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateO365AppAuthStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateO365OrgCustomNameReply? UpdateO365OrgCustomName
        // GraphQL -> updateO365OrgCustomName: UpdateO365OrgCustomNameReply! (type)
        public static string UpdateO365OrgCustomName(
            ref UpdateO365OrgCustomNameReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateO365OrgCustomNameReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateO365OrgCustomName" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleDbDetail? UpdateOracleDataGuardGroup
        // GraphQL -> updateOracleDataGuardGroup: OracleDbDetail! (type)
        public static string UpdateOracleDataGuardGroup(
            ref OracleDbDetail? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new OracleDbDetail() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateOracleDataGuardGroup" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateOrgReply? UpdateOrg
        // GraphQL -> updateOrg: UpdateOrgReply! (type)
        public static string UpdateOrg(
            ref UpdateOrgReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateOrgReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateOrg" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdatePactsafeEulaAcceptedReply? UpdatePactsafeEulaAccepted
        // GraphQL -> updatePactsafeEulaAccepted: UpdatePactsafeEulaAcceptedReply! (type)
        public static string UpdatePactsafeEulaAccepted(
            ref UpdatePactsafeEulaAcceptedReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdatePactsafeEulaAcceptedReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updatePactsafeEulaAccepted" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdatePactsafeEulaSeenReply? UpdatePactsafeEulaSeen
        // GraphQL -> updatePactsafeEulaSeen: UpdatePactsafeEulaSeenReply! (type)
        public static string UpdatePactsafeEulaSeen(
            ref UpdatePactsafeEulaSeenReply? cmdletReply
        )
        {
            string args = "";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdatePactsafeEulaSeenReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updatePactsafeEulaSeen" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClassificationPolicyDetail? UpdatePolicy
        // GraphQL -> updatePolicy: ClassificationPolicyDetail! (type)
        public static string UpdatePolicy(
            ref ClassificationPolicyDetail? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ClassificationPolicyDetail() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updatePolicy" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Cluster? UpdatePreviewerClusterConfig
        // GraphQL -> updatePreviewerClusterConfig: Cluster! (type)
        public static string UpdatePreviewerClusterConfig(
            ref Cluster? cmdletReply
        )
        {
            string args = "\n(\npreviewerClusterConfig: $previewerClusterConfig\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new Cluster() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updatePreviewerClusterConfig" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateProxyConfigReply? UpdateProxyConfig
        // GraphQL -> updateProxyConfig: UpdateProxyConfigReply! (type)
        public static string UpdateProxyConfig(
            ref UpdateProxyConfigReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateProxyConfigReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateProxyConfig" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TargetMapping? UpdateRcsAutomaticTargetMapping
        // GraphQL -> updateRcsAutomaticTargetMapping: TargetMapping! (type)
        public static string UpdateRcsAutomaticTargetMapping(
            ref TargetMapping? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new TargetMapping() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateRcsAutomaticTargetMapping" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateScheduledReportReply? UpdateScheduledReport
        // GraphQL -> updateScheduledReport: UpdateScheduledReportReply! (type)
        public static string UpdateScheduledReport(
            ref UpdateScheduledReportReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateScheduledReportReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateScheduledReport" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateServiceAccountReply? UpdateServiceAccount
        // GraphQL -> updateServiceAccount: UpdateServiceAccountReply! (type)
        public static string UpdateServiceAccount(
            ref UpdateServiceAccountReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateServiceAccountReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateServiceAccount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateSnapMirrorCloudReply? UpdateSnapMirrorCloud
        // GraphQL -> updateSnapMirrorCloud: UpdateSnapMirrorCloudReply! (type)
        public static string UpdateSnapMirrorCloud(
            ref UpdateSnapMirrorCloudReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateSnapMirrorCloudReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateSnapMirrorCloud" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateSnmpConfigReply? UpdateSnmpConfig
        // GraphQL -> updateSnmpConfig: UpdateSnmpConfigReply! (type)
        public static string UpdateSnmpConfig(
            ref UpdateSnmpConfigReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateSnmpConfigReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateSnmpConfig" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateStorageArraysReply? UpdateStorageArrays
        // GraphQL -> updateStorageArrays: UpdateStorageArraysReply! (type)
        public static string UpdateStorageArrays(
            ref UpdateStorageArraysReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateStorageArraysReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateStorageArrays" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateSupportCaseReply? UpdateSupportCase
        // GraphQL -> updateSupportCase: UpdateSupportCaseReply! (type)
        public static string UpdateSupportCase(
            ref UpdateSupportCaseReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateSupportCaseReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateSupportCase" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateSyslogExportRuleReply? UpdateSyslogExportRule
        // GraphQL -> updateSyslogExportRule: UpdateSyslogExportRuleReply! (type)
        public static string UpdateSyslogExportRule(
            ref UpdateSyslogExportRuleReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateSyslogExportRuleReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateSyslogExportRule" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateTunnelStatusReply? UpdateTunnelStatus
        // GraphQL -> updateTunnelStatus: UpdateTunnelStatusReply! (type)
        public static string UpdateTunnelStatus(
            ref UpdateTunnelStatusReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateTunnelStatusReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateTunnelStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateVcdInstancesReply? UpdateVcdInstances
        // GraphQL -> updateVcdInstances: UpdateVcdInstancesReply! (type)
        public static string UpdateVcdInstances(
            ref UpdateVcdInstancesReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateVcdInstancesReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateVcdInstances" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateVcenterReply? UpdateVcenter
        // GraphQL -> updateVcenter: UpdateVcenterReply! (type)
        public static string UpdateVcenter(
            ref UpdateVcenterReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateVcenterReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateVcenter" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? UpdateVcenterHotAddBandwidth
        // GraphQL -> updateVcenterHotAddBandwidth: RequestSuccess! (type)
        public static string UpdateVcenterHotAddBandwidth(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateVcenterHotAddBandwidth" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? UpdateVcenterHotAddNetwork
        // GraphQL -> updateVcenterHotAddNetwork: RequestSuccess! (type)
        public static string UpdateVcenterHotAddNetwork(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateVcenterHotAddNetwork" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateVolumeGroupReply? UpdateVolumeGroup
        // GraphQL -> updateVolumeGroup: UpdateVolumeGroupReply! (type)
        public static string UpdateVolumeGroup(
            ref UpdateVolumeGroupReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateVolumeGroupReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateVolumeGroup" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateVsphereAdvancedTagReply? UpdateVsphereAdvancedTag
        // GraphQL -> updateVsphereAdvancedTag: UpdateVsphereAdvancedTagReply! (type)
        public static string UpdateVsphereAdvancedTag(
            ref UpdateVsphereAdvancedTagReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateVsphereAdvancedTagReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateVsphereAdvancedTag" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? UpdateVsphereVm
        // GraphQL -> updateVsphereVm: RequestSuccess! (type)
        public static string UpdateVsphereVm(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateVsphereVm" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateWebhookReply? UpdateWebhook
        // GraphQL -> updateWebhook: UpdateWebhookReply! (type)
        public static string UpdateWebhook(
            ref UpdateWebhookReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpdateWebhookReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "updateWebhook" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpgradeAzureCloudAccountReply? UpgradeAzureCloudAccount
        // GraphQL -> upgradeAzureCloudAccount: UpgradeAzureCloudAccountReply! (type)
        public static string UpgradeAzureCloudAccount(
            ref UpgradeAzureCloudAccountReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpgradeAzureCloudAccountReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "upgradeAzureCloudAccount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpgradeAzureCloudAccountPermissionsWithoutOauthReply? UpgradeAzureCloudAccountPermissionsWithoutOauth
        // GraphQL -> upgradeAzureCloudAccountPermissionsWithoutOauth: UpgradeAzureCloudAccountPermissionsWithoutOauthReply! (type)
        public static string UpgradeAzureCloudAccountPermissionsWithoutOauth(
            ref UpgradeAzureCloudAccountPermissionsWithoutOauthReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpgradeAzureCloudAccountPermissionsWithoutOauthReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "upgradeAzureCloudAccountPermissionsWithoutOauth" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpgradeGcpCloudAccountPermissionsWithoutOauthReply? UpgradeGcpCloudAccountPermissionsWithoutOauth
        // GraphQL -> upgradeGcpCloudAccountPermissionsWithoutOauth: UpgradeGcpCloudAccountPermissionsWithoutOauthReply! (type)
        public static string UpgradeGcpCloudAccountPermissionsWithoutOauth(
            ref UpgradeGcpCloudAccountPermissionsWithoutOauthReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpgradeGcpCloudAccountPermissionsWithoutOauthReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "upgradeGcpCloudAccountPermissionsWithoutOauth" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? UpgradeIoFilter
        // GraphQL -> upgradeIoFilter: RequestSuccess! (type)
        public static string UpgradeIoFilter(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "upgradeIoFilter" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpgradeSlasReply? UpgradeSlas
        // GraphQL -> upgradeSlas: UpgradeSlasReply! (type)
        public static string UpgradeSlas(
            ref UpgradeSlasReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new UpgradeSlasReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "upgradeSlas" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncJobStatus? UploadDatabaseSnapshotToBlobstore
        // GraphQL -> uploadDatabaseSnapshotToBlobstore: AsyncJobStatus! (type)
        public static string UploadDatabaseSnapshotToBlobstore(
            ref AsyncJobStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncJobStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "uploadDatabaseSnapshotToBlobstore" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncRequestStatus? VsphereVmBatchLiveMount
        // GraphQL -> vSphereVMBatchLiveMount: BatchAsyncRequestStatus! (type)
        public static string VsphereVmBatchLiveMount(
            ref BatchAsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nconfig: $config\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereVMBatchLiveMount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ValidateAndCreateAwsCloudAccountReply? ValidateAndCreateAwsCloudAccount
        // GraphQL -> validateAndCreateAwsCloudAccount: ValidateAndCreateAwsCloudAccountReply! (type)
        public static string ValidateAndCreateAwsCloudAccount(
            ref ValidateAndCreateAwsCloudAccountReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ValidateAndCreateAwsCloudAccountReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "validateAndCreateAwsCloudAccount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ValidateAndSaveCustomerKmsInfoReply? ValidateAndSaveCustomerKmsInfo
        // GraphQL -> validateAndSaveCustomerKmsInfo: ValidateAndSaveCustomerKmsInfoReply! (type)
        public static string ValidateAndSaveCustomerKmsInfo(
            ref ValidateAndSaveCustomerKmsInfoReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ValidateAndSaveCustomerKmsInfoReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "validateAndSaveCustomerKmsInfo" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ValidateBlueprintReply? ValidateBlueprint
        // GraphQL -> validateBlueprint: ValidateBlueprintReply! (type)
        public static string ValidateBlueprint(
            ref ValidateBlueprintReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ValidateBlueprintReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "validateBlueprint" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ValidateBlueprintRecoverySpecReply? ValidateBlueprintRecoverySpec
        // GraphQL -> validateBlueprintRecoverySpec: ValidateBlueprintRecoverySpecReply! (type)
        public static string ValidateBlueprintRecoverySpec(
            ref ValidateBlueprintRecoverySpecReply? cmdletReply
        )
        {
            string args = "\n(\nblueprintId: $blueprintId\nvalidateSnapshotRecoverySpec: $validateSnapshotRecoverySpec\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ValidateBlueprintRecoverySpecReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "validateBlueprintRecoverySpec" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ValidateBlueprintsReply? ValidateBlueprints
        // GraphQL -> validateBlueprints: ValidateBlueprintsReply! (type)
        public static string ValidateBlueprints(
            ref ValidateBlueprintsReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ValidateBlueprintsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "validateBlueprints" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ValidateOracleAcoFileReply? ValidateOracleAcoFile
        // GraphQL -> validateOracleAcoFile: ValidateOracleAcoFileReply! (type)
        public static string ValidateOracleAcoFile(
            ref ValidateOracleAcoFileReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new ValidateOracleAcoFileReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "validateOracleAcoFile" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ValidateOracleDatabaseBackups
        // GraphQL -> validateOracleDatabaseBackups: AsyncRequestStatus! (type)
        public static string ValidateOracleDatabaseBackups(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "validateOracleDatabaseBackups" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VmwareDownloadSnapshotFromLocation
        // GraphQL -> vmwareDownloadSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string VmwareDownloadSnapshotFromLocation(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vmwareDownloadSnapshotFromLocation" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereAsyncRequestStatus? VpshereVmRecoveryPointMount
        // GraphQL -> vpshereVMRecoveryPointMount: VsphereAsyncRequestStatus! (type)
        public static string VpshereVmRecoveryPointMount(
            ref VsphereAsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\nsnapshotFid: $snapshotFid\nsnappableFid: $snappableFid\nvmName: $vmName\ndisableNetwork: $disableNetwork\nremoveNetworkDevices: $removeNetworkDevices\npowerOn: $powerOn\nkeepMacAddresses: $keepMacAddresses\nhostID: $hostID\ndatastoreName: $datastoreName\nvlan: $vlan\nunregsiterVm: $unregsiterVm\nshouldRecoverTags: $shouldRecoverTags\nrecoveryPoint: $recoveryPoint\ncreateDatastoreOnly: $createDatastoreOnly\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new VsphereAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vpshereVMRecoveryPointMount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncRequestStatus? VsphereBulkOnDemandSnapshot
        // GraphQL -> vsphereBulkOnDemandSnapshot: BatchAsyncRequestStatus! (type)
        public static string VsphereBulkOnDemandSnapshot(
            ref BatchAsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereBulkOnDemandSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereAsyncRequestStatus? VsphereCreateVcenter
        // GraphQL -> vsphereCreateVCenter: VsphereAsyncRequestStatus! (type)
        public static string VsphereCreateVcenter(
            ref VsphereAsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nhostname: $hostname\nusername: $username\npassword: $password\nconflictResolutionAuthz: $conflictResolutionAuthz\ncaCert: $caCert\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new VsphereAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereCreateVCenter" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereDeleteVcenter
        // GraphQL -> vsphereDeleteVcenter: AsyncRequestStatus! (type)
        public static string VsphereDeleteVcenter(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereDeleteVcenter" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? VsphereEditVcenter
        // GraphQL -> vsphereEditVCenter: RequestSuccess! (type)
        public static string VsphereEditVcenter(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "\n(\nvcenterId: $vcenterId\nhostname: $hostname\nusername: $username\npassword: $password\nconflictResolutionAuthz: $conflictResolutionAuthz\ncaCert: $caCert\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereEditVCenter" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? VsphereExcludeVmDisks
        // GraphQL -> vsphereExcludeVmDisks: RequestSuccess! (type)
        public static string VsphereExcludeVmDisks(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereExcludeVmDisks" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereAsyncRequestStatus? VsphereExportSnapshotToStandaloneHost
        // GraphQL -> vsphereExportSnapshotToStandaloneHost: VsphereAsyncRequestStatus! (type)
        public static string VsphereExportSnapshotToStandaloneHost(
            ref VsphereAsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\nsnapshotFid: $snapshotFid\nvmName: $vmName\ndisableNetwork: $disableNetwork\nremoveNetworkDevices: $removeNetworkDevices\npowerOn: $powerOn\nkeepMacAddresses: $keepMacAddresses\nhostIpAddress: $hostIpAddress\ndatastoreName: $datastoreName\nhostUsername: $hostUsername\nhostPassword: $hostPassword\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new VsphereAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereExportSnapshotToStandaloneHost" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereExportSnapshotToStandaloneHostV2
        // GraphQL -> vsphereExportSnapshotToStandaloneHostV2: AsyncRequestStatus! (type)
        public static string VsphereExportSnapshotToStandaloneHostV2(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereExportSnapshotToStandaloneHostV2" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereOnDemandSnapshot
        // GraphQL -> vsphereOnDemandSnapshot: AsyncRequestStatus! (type)
        public static string VsphereOnDemandSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereOnDemandSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereAsyncRequestStatus? VsphereRefreshVcenter
        // GraphQL -> vsphereRefreshVCenter: VsphereAsyncRequestStatus! (type)
        public static string VsphereRefreshVcenter(
            ref VsphereAsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\nvcenterId: $vcenterId\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new VsphereAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereRefreshVCenter" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereAsyncRequestStatus? VsphereVmDeleteLiveMount
        // GraphQL -> vsphereVMDeleteLiveMount: VsphereAsyncRequestStatus! (type)
        public static string VsphereVmDeleteLiveMount(
            ref VsphereAsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\nlivemountId: $livemountId\nforce: $force\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new VsphereAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVMDeleteLiveMount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereAsyncRequestStatus? VsphereVmExportSnapshot
        // GraphQL -> vsphereVMExportSnapshot: VsphereAsyncRequestStatus! (type)
        public static string VsphereVmExportSnapshot(
            ref VsphereAsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\nsnapshotFid: $snapshotFid\nvmName: $vmName\ndisableNetwork: $disableNetwork\nremoveNetworkDevices: $removeNetworkDevices\npowerOn: $powerOn\nkeepMacAddresses: $keepMacAddresses\nhostID: $hostID\ndatastoreId: $datastoreId\nunregsiterVm: $unregsiterVm\nshouldRecoverTags: $shouldRecoverTags\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new VsphereAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVMExportSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereAsyncRequestStatus? VsphereVmInitiateInstantRecovery
        // GraphQL -> vsphereVMInitiateInstantRecovery: VsphereAsyncRequestStatus! (type)
        public static string VsphereVmInitiateInstantRecovery(
            ref VsphereAsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\nsnapshotFid: $snapshotFid\nvmName: $vmName\ndisableNetwork: $disableNetwork\nremoveNetworkDevices: $removeNetworkDevices\npowerOn: $powerOn\nkeepMacAddresses: $keepMacAddresses\nhostID: $hostID\npreserveMOID: $preserveMOID\nvlan: $vlan\nshouldRecoverTags: $shouldRecoverTags\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new VsphereAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVMInitiateInstantRecovery" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereAsyncRequestStatus? VsphereVmInitiateLiveMount
        // GraphQL -> vsphereVMInitiateLiveMount: VsphereAsyncRequestStatus! (type)
        public static string VsphereVmInitiateLiveMount(
            ref VsphereAsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\nsnapshotFid: $snapshotFid\nvmName: $vmName\ndisableNetwork: $disableNetwork\nremoveNetworkDevices: $removeNetworkDevices\npowerOn: $powerOn\nkeepMacAddresses: $keepMacAddresses\nhostID: $hostID\ndatastoreName: $datastoreName\ncreateDatastoreOnly: $createDatastoreOnly\nvlan: $vlan\nshouldRecoverTags: $shouldRecoverTags\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new VsphereAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVMInitiateLiveMount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DatastoresListResponse? VsphereVmListEsXiDatastores
        // GraphQL -> vsphereVMListESXiDatastores: DatastoresListResponse! (type)
        public static string VsphereVmListEsXiDatastores(
            ref DatastoresListResponse? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nipAddress: $ipAddress\nusername: $username\npassword: $password\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new DatastoresListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVMListESXiDatastores" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? VsphereVmUpdate
        // GraphQL -> vsphereVMUpdate: RequestSuccess! (type)
        public static string VsphereVmUpdate(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\nsnapshotConsistencyMandate: $snapshotConsistencyMandate\npreBackupScript: $preBackupScript\npostBackupScript: $postBackupScript\npostSnapScript: $postSnapScript\nisArrayIntegrationEnabled: $isArrayIntegrationEnabled\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVMUpdate" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncRequestStatus? VsphereVmBatchExport
        // GraphQL -> vsphereVmBatchExport: BatchAsyncRequestStatus! (type)
        public static string VsphereVmBatchExport(
            ref BatchAsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVmBatchExport" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncRequestStatus? VsphereVmBatchExportV3
        // GraphQL -> vsphereVmBatchExportV3: BatchAsyncRequestStatus! (type)
        public static string VsphereVmBatchExportV3(
            ref BatchAsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVmBatchExportV3" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncRequestStatus? VsphereVmBatchInPlaceRecovery
        // GraphQL -> vsphereVmBatchInPlaceRecovery: BatchAsyncRequestStatus! (type)
        public static string VsphereVmBatchInPlaceRecovery(
            ref BatchAsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVmBatchInPlaceRecovery" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereVmDownloadSnapshot
        // GraphQL -> vsphereVmDownloadSnapshot: AsyncRequestStatus! (type)
        public static string VsphereVmDownloadSnapshot(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVmDownloadSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereVmDownloadSnapshotFiles
        // GraphQL -> vsphereVmDownloadSnapshotFiles: AsyncRequestStatus! (type)
        public static string VsphereVmDownloadSnapshotFiles(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVmDownloadSnapshotFiles" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereVmExportSnapshotV2
        // GraphQL -> vsphereVmExportSnapshotV2: AsyncRequestStatus! (type)
        public static string VsphereVmExportSnapshotV2(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVmExportSnapshotV2" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereVmExportSnapshotV3
        // GraphQL -> vsphereVmExportSnapshotV3: AsyncRequestStatus! (type)
        public static string VsphereVmExportSnapshotV3(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVmExportSnapshotV3" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereVmExportSnapshotWithDownloadFromCloud
        // GraphQL -> vsphereVmExportSnapshotWithDownloadFromCloud: AsyncRequestStatus! (type)
        public static string VsphereVmExportSnapshotWithDownloadFromCloud(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVmExportSnapshotWithDownloadFromCloud" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncRequestStatus? VsphereVmInitiateBatchInstantRecovery
        // GraphQL -> vsphereVmInitiateBatchInstantRecovery: BatchAsyncRequestStatus! (type)
        public static string VsphereVmInitiateBatchInstantRecovery(
            ref BatchAsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVmInitiateBatchInstantRecovery" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchAsyncRequestStatus? VsphereVmInitiateBatchLiveMountV2
        // GraphQL -> vsphereVmInitiateBatchLiveMountV2: BatchAsyncRequestStatus! (type)
        public static string VsphereVmInitiateBatchLiveMountV2(
            ref BatchAsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new BatchAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVmInitiateBatchLiveMountV2" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereVmInitiateDiskMount
        // GraphQL -> vsphereVmInitiateDiskMount: AsyncRequestStatus! (type)
        public static string VsphereVmInitiateDiskMount(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVmInitiateDiskMount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereVmInitiateInPlaceRecovery
        // GraphQL -> vsphereVmInitiateInPlaceRecovery: AsyncRequestStatus! (type)
        public static string VsphereVmInitiateInPlaceRecovery(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVmInitiateInPlaceRecovery" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereVmInitiateInstantRecoveryV2
        // GraphQL -> vsphereVmInitiateInstantRecoveryV2: AsyncRequestStatus! (type)
        public static string VsphereVmInitiateInstantRecoveryV2(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVmInitiateInstantRecoveryV2" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereVmInitiateLiveMountV2
        // GraphQL -> vsphereVmInitiateLiveMountV2: AsyncRequestStatus! (type)
        public static string VsphereVmInitiateLiveMountV2(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVmInitiateLiveMountV2" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereVmListEsxiDatastoresReply? VsphereVmListEsxiDatastores
        // GraphQL -> vsphereVmListEsxiDatastores: VsphereVmListEsxiDatastoresReply! (type)
        public static string VsphereVmListEsxiDatastores(
            ref VsphereVmListEsxiDatastoresReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new VsphereVmListEsxiDatastoresReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVmListEsxiDatastores" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereVmMountRelocate
        // GraphQL -> vsphereVmMountRelocate: AsyncRequestStatus! (type)
        public static string VsphereVmMountRelocate(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVmMountRelocate" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereVmMountRelocateV2
        // GraphQL -> vsphereVmMountRelocateV2: AsyncRequestStatus! (type)
        public static string VsphereVmMountRelocateV2(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVmMountRelocateV2" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereVmPowerOnOffLiveMountReply? VsphereVmPowerOnOffLiveMount
        // GraphQL -> vsphereVmPowerOnOffLiveMount: VsphereVmPowerOnOffLiveMountReply! (type)
        public static string VsphereVmPowerOnOffLiveMount(
            ref VsphereVmPowerOnOffLiveMountReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new VsphereVmPowerOnOffLiveMountReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVmPowerOnOffLiveMount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereAsyncRequestStatus? VsphereVmRecoverFiles
        // GraphQL -> vsphereVmRecoverFiles: VsphereAsyncRequestStatus! (type)
        public static string VsphereVmRecoverFiles(
            ref VsphereAsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new VsphereAsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVmRecoverFiles" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereVmRecoverFilesNew
        // GraphQL -> vsphereVmRecoverFilesNew: AsyncRequestStatus! (type)
        public static string VsphereVmRecoverFilesNew(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVmRecoverFilesNew" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RequestSuccess? VsphereVmRegisterAgent
        // GraphQL -> vsphereVmRegisterAgent: RequestSuccess! (type)
        public static string VsphereVmRegisterAgent(
            ref RequestSuccess? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
           if (cmdletReply == null)
            {
                cmdletReply = new RequestSuccess() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVmRegisterAgent" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        #endregion

    } // class Mutation
    #endregion
}