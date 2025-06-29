// Mutation.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region Mutation
    public class Mutation
    {
        #region members
        //      C# -> CloudAccount? CreateAwsAccount
        // GraphQL -> createAwsAccount: CloudAccount! (interface)
        public static string CreateAwsAccount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createAwsAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateAwsAccountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<CloudAccount>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (CloudAccount)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create CloudAccount composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> Target? CreateAwsReaderTarget
        // GraphQL -> createAwsReaderTarget: Target! (interface)
        public static string CreateAwsReaderTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createAwsReaderTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateAwsReaderTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<Target>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (Target)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create Target composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> Target? CreateAwsTarget
        // GraphQL -> createAwsTarget: Target! (interface)
        public static string CreateAwsTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createAwsTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateAwsTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<Target>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (Target)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create Target composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> CloudAccount? CreateAzureAccount
        // GraphQL -> createAzureAccount: CloudAccount! (interface)
        public static string CreateAzureAccount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createAzureAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateAzureAccountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<CloudAccount>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (CloudAccount)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create CloudAccount composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> Target? CreateAzureReaderTarget
        // GraphQL -> createAzureReaderTarget: Target! (interface)
        public static string CreateAzureReaderTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createAzureReaderTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateAzureReaderTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<Target>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (Target)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create Target composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> Target? CreateAzureTarget
        // GraphQL -> createAzureTarget: Target! (interface)
        public static string CreateAzureTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createAzureTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateAzureTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<Target>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (Target)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create Target composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> Target? CreateGcpReaderTarget
        // GraphQL -> createGcpReaderTarget: Target! (interface)
        public static string CreateGcpReaderTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createGcpReaderTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateGcpReaderTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<Target>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (Target)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create Target composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> Target? CreateGcpTarget
        // GraphQL -> createGcpTarget: Target! (interface)
        public static string CreateGcpTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createGcpTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateGcpTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<Target>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (Target)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create Target composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> Target? CreateGlacierReaderTarget
        // GraphQL -> createGlacierReaderTarget: Target! (interface)
        public static string CreateGlacierReaderTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createGlacierReaderTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateGlacierReaderTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<Target>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (Target)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create Target composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> Target? CreateNfsReaderTarget
        // GraphQL -> createNfsReaderTarget: Target! (interface)
        public static string CreateNfsReaderTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createNfsReaderTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateNfsReaderTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<Target>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (Target)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create Target composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> Target? CreateNfsTarget
        // GraphQL -> createNfsTarget: Target! (interface)
        public static string CreateNfsTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createNfsTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateNfsTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<Target>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (Target)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create Target composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> Target? CreateRcsReaderTarget
        // GraphQL -> createRcsReaderTarget: Target! (interface)
        public static string CreateRcsReaderTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createRcsReaderTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateRcsReaderTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<Target>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (Target)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create Target composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> Target? CreateRcsTarget
        // GraphQL -> createRcsTarget: Target! (interface)
        public static string CreateRcsTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createRcsTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateRcsTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<Target>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (Target)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create Target composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> List<Target>? CreateRcvLocationsFromTemplate
        // GraphQL -> createRcvLocationsFromTemplate: [Target!]! (interface)
        public static string CreateRcvLocationsFromTemplate(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createRcvLocationsFromTemplate" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateRcvLocationsFromTemplateFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new List<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Target? CreateS3CompatibleReaderTarget
        // GraphQL -> createS3CompatibleReaderTarget: Target! (interface)
        public static string CreateS3CompatibleReaderTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createS3CompatibleReaderTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateS3CompatibleReaderTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<Target>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (Target)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create Target composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> Target? CreateS3CompatibleTarget
        // GraphQL -> createS3CompatibleTarget: Target! (interface)
        public static string CreateS3CompatibleTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createS3CompatibleTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateS3CompatibleTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<Target>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (Target)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create Target composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> Target? CreateTapeReaderTarget
        // GraphQL -> createTapeReaderTarget: Target! (interface)
        public static string CreateTapeReaderTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createTapeReaderTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateTapeReaderTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<Target>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (Target)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create Target composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> Target? CreateTapeTarget
        // GraphQL -> createTapeTarget: Target! (interface)
        public static string CreateTapeTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createTapeTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateTapeTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<Target>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (Target)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create Target composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> CloudAccount? UpdateAwsAccount
        // GraphQL -> updateAwsAccount: CloudAccount! (interface)
        public static string UpdateAwsAccount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateAwsAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateAwsAccountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<CloudAccount>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (CloudAccount)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create CloudAccount composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> Target? UpdateAwsTarget
        // GraphQL -> updateAwsTarget: Target! (interface)
        public static string UpdateAwsTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateAwsTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateAwsTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<Target>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (Target)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create Target composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> CloudAccount? UpdateAzureAccount
        // GraphQL -> updateAzureAccount: CloudAccount! (interface)
        public static string UpdateAzureAccount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateAzureAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateAzureAccountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<CloudAccount>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (CloudAccount)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create CloudAccount composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> Target? UpdateAzureTarget
        // GraphQL -> updateAzureTarget: Target! (interface)
        public static string UpdateAzureTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateAzureTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateAzureTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<Target>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (Target)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create Target composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> Target? UpdateGcpTarget
        // GraphQL -> updateGcpTarget: Target! (interface)
        public static string UpdateGcpTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateGcpTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateGcpTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<Target>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (Target)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create Target composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> Target? UpdateGlacierTarget
        // GraphQL -> updateGlacierTarget: Target! (interface)
        public static string UpdateGlacierTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateGlacierTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateGlacierTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<Target>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (Target)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create Target composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> Target? UpdateNfsTarget
        // GraphQL -> updateNfsTarget: Target! (interface)
        public static string UpdateNfsTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateNfsTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateNfsTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<Target>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (Target)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create Target composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> Target? UpdateRcvTarget
        // GraphQL -> updateRcvTarget: Target! (interface)
        public static string UpdateRcvTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateRcvTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateRcvTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<Target>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (Target)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create Target composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> Target? UpdateS3CompatibleTarget
        // GraphQL -> updateS3CompatibleTarget: Target! (interface)
        public static string UpdateS3CompatibleTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateS3CompatibleTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateS3CompatibleTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<Target>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (Target)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create Target composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> Target? UpdateTapeTarget
        // GraphQL -> updateTapeTarget: Target! (interface)
        public static string UpdateTapeTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateTapeTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateTapeTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var list = new List<Target>();
            list.ApplyExploratoryFieldSpec(ec);
            var fieldSpecObj = (Target)InterfaceHelper.MakeCompositeFromList(list);
            if (fieldSpecObj == null) {
                throw new InvalidOperationException("Could not create Target composite object");
            }
            return fieldSpecObj;
        }

        //      C# -> System.Boolean? AddInventoryWorkloads
        // GraphQL -> addInventoryWorkloads: Boolean! (scalar)
        public static string AddInventoryWorkloads(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addInventoryWorkloads" + args + "\n";
        }
        public static object AddInventoryWorkloadsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? AddPolicyObjects
        // GraphQL -> addPolicyObjects: String! (scalar)
        public static string AddPolicyObjects(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\npolicyIds: $policyIds\nobjectIds: $objectIds\nobjectRootIds: $objectRootIds\nclusterIds: $clusterIds\n)";
            return "addPolicyObjects" + args + "\n";
        }
        public static object AddPolicyObjectsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? AddRoleAssignments
        // GraphQL -> addRoleAssignments: Boolean! (scalar)
        public static string AddRoleAssignments(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nuserIds: $userIds\ngroupIds: $groupIds\nroleIds: $roleIds\n)";
            return "addRoleAssignments" + args + "\n";
        }
        public static object AddRoleAssignmentsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? AirGapStatus
        // GraphQL -> airGapStatus: Void (scalar)
        public static string AirGapStatus(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "airGapStatus" + args + "\n";
        }
        public static object AirGapStatusFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? ApproveTprRequest
        // GraphQL -> approveTprRequest: Void (scalar)
        public static string ApproveTprRequest(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "approveTprRequest" + args + "\n";
        }
        public static object ApproveTprRequestFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? ArchiveCrawl
        // GraphQL -> archiveCrawl: String! (scalar)
        public static string ArchiveCrawl(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ncrawlId: $crawlId\n)";
            return "archiveCrawl" + args + "\n";
        }
        public static object ArchiveCrawlFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? AzureUpdateTenantForSubscription
        // GraphQL -> azureUpdateTenantForSubscription: Void (scalar)
        public static string AzureUpdateTenantForSubscription(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "azureUpdateTenantForSubscription" + args + "\n";
        }
        public static object AzureUpdateTenantForSubscriptionFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? BatchDeassignRoleFromUserGroups
        // GraphQL -> batchDeassignRoleFromUserGroups: Boolean! (scalar)
        public static string BatchDeassignRoleFromUserGroups(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nuserGroupToRoles: $userGroupToRoles\n)";
            return "batchDeassignRoleFromUserGroups" + args + "\n";
        }
        public static object BatchDeassignRoleFromUserGroupsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? BulkDeleteNasShares
        // GraphQL -> bulkDeleteNasShares: Void (scalar)
        public static string BulkDeleteNasShares(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkDeleteNasShares" + args + "\n";
        }
        public static object BulkDeleteNasSharesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? BulkUpdateNasNamespaces
        // GraphQL -> bulkUpdateNasNamespaces: Void (scalar)
        public static string BulkUpdateNasNamespaces(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkUpdateNasNamespaces" + args + "\n";
        }
        public static object BulkUpdateNasNamespacesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? BulkUpdateRansomwareInvestigationStatus
        // GraphQL -> bulkUpdateRansomwareInvestigationStatus: Void (scalar)
        public static string BulkUpdateRansomwareInvestigationStatus(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkUpdateRansomwareInvestigationStatus" + args + "\n";
        }
        public static object BulkUpdateRansomwareInvestigationStatusFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? CancelActivitySeries
        // GraphQL -> cancelActivitySeries: Boolean! (scalar)
        public static string CancelActivitySeries(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "cancelActivitySeries" + args + "\n";
        }
        public static object CancelActivitySeriesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? CancelThreatHunt
        // GraphQL -> cancelThreatHunt: Void (scalar)
        public static string CancelThreatHunt(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "cancelThreatHunt" + args + "\n";
        }
        public static object CancelThreatHuntFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? CancelTprRequest
        // GraphQL -> cancelTprRequest: Void (scalar)
        public static string CancelTprRequest(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "cancelTprRequest" + args + "\n";
        }
        public static object CancelTprRequestFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? ChangeCurrentUserPassword
        // GraphQL -> changeCurrentUserPassword: Void (scalar)
        public static string ChangeCurrentUserPassword(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "changeCurrentUserPassword" + args + "\n";
        }
        public static object ChangeCurrentUserPasswordFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? ChangePassword
        // GraphQL -> changePassword: Boolean! (scalar)
        public static string ChangePassword(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "changePassword" + args + "\n";
        }
        public static object ChangePasswordFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? CompleteAzureAdAppUpdate
        // GraphQL -> completeAzureAdAppUpdate: Void (scalar)
        public static string CompleteAzureAdAppUpdate(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "completeAzureAdAppUpdate" + args + "\n";
        }
        public static object CompleteAzureAdAppUpdateFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? CreateCrossAccountPair
        // GraphQL -> createCrossAccountPair: Void (scalar)
        public static string CreateCrossAccountPair(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createCrossAccountPair" + args + "\n";
        }
        public static object CreateCrossAccountPairFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? CreateDistributionListDigestBatch
        // GraphQL -> createDistributionListDigestBatch: Void (scalar)
        public static string CreateDistributionListDigestBatch(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createDistributionListDigestBatch" + args + "\n";
        }
        public static object CreateDistributionListDigestBatchFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? CreateEventDigestBatch
        // GraphQL -> createEventDigestBatch: Void (scalar)
        public static string CreateEventDigestBatch(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createEventDigestBatch" + args + "\n";
        }
        public static object CreateEventDigestBatchFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? CreateReplicationPair
        // GraphQL -> createReplicationPair: Void (scalar)
        public static string CreateReplicationPair(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createReplicationPair" + args + "\n";
        }
        public static object CreateReplicationPairFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? CreateRole
        // GraphQL -> createRole: UUID! (scalar)
        public static string CreateRole(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nname: $name\ndescription: $description\nisSynced: $isSynced\npermissions: $permissions\n)";
            return "createRole" + args + "\n";
        }
        public static object CreateRoleFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? CreateUser
        // GraphQL -> createUser: String! (scalar)
        public static string CreateUser(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nemail: $email\nroleIds: $roleIds\n)";
            return "createUser" + args + "\n";
        }
        public static object CreateUserFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? CreateUserWithPassword
        // GraphQL -> createUserWithPassword: String! (scalar)
        public static string CreateUserWithPassword(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createUserWithPassword" + args + "\n";
        }
        public static object CreateUserWithPasswordFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeactivateCustomAnalyzer
        // GraphQL -> deactivateCustomAnalyzer: String! (scalar)
        public static string DeactivateCustomAnalyzer(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nanalyzerId: $analyzerId\n)";
            return "deactivateCustomAnalyzer" + args + "\n";
        }
        public static object DeactivateCustomAnalyzerFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> List<System.String>? DeactivatePolicy
        // GraphQL -> deactivatePolicy: [String!]! (scalar)
        public static string DeactivatePolicy(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\npolicyId: $policyId\nrunAsync: $runAsync\n)";
            return "deactivatePolicy" + args + "\n";
        }
        public static object DeactivatePolicyFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> System.String? DeleteAllOracleDatabaseSnapshots
        // GraphQL -> deleteAllOracleDatabaseSnapshots: Void (scalar)
        public static string DeleteAllOracleDatabaseSnapshots(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteAllOracleDatabaseSnapshots" + args + "\n";
        }
        public static object DeleteAllOracleDatabaseSnapshotsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeleteAwsComputeSetting
        // GraphQL -> deleteAwsComputeSetting: Void (scalar)
        public static string DeleteAwsComputeSetting(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteAwsComputeSetting" + args + "\n";
        }
        public static object DeleteAwsComputeSettingFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? DeleteCertificate
        // GraphQL -> deleteCertificate: Boolean! (scalar)
        public static string DeleteCertificate(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ncertificateId: $certificateId\n)";
            return "deleteCertificate" + args + "\n";
        }
        public static object DeleteCertificateFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? DeleteCloudNativeLabelRule
        // GraphQL -> deleteCloudNativeLabelRule: Void (scalar)
        public static string DeleteCloudNativeLabelRule(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteCloudNativeLabelRule" + args + "\n";
        }
        public static object DeleteCloudNativeLabelRuleFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeleteCloudNativeTagRule
        // GraphQL -> deleteCloudNativeTagRule: Void (scalar)
        public static string DeleteCloudNativeTagRule(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteCloudNativeTagRule" + args + "\n";
        }
        public static object DeleteCloudNativeTagRuleFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? DeleteCloudWorkloadSnapshot
        // GraphQL -> deleteCloudWorkloadSnapshot: Boolean! (scalar)
        public static string DeleteCloudWorkloadSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteCloudWorkloadSnapshot" + args + "\n";
        }
        public static object DeleteCloudWorkloadSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? DeleteClusterRoute
        // GraphQL -> deleteClusterRoute: Void (scalar)
        public static string DeleteClusterRoute(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteClusterRoute" + args + "\n";
        }
        public static object DeleteClusterRouteFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeleteCrossAccountPair
        // GraphQL -> deleteCrossAccountPair: Void (scalar)
        public static string DeleteCrossAccountPair(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteCrossAccountPair" + args + "\n";
        }
        public static object DeleteCrossAccountPairFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeleteCsr
        // GraphQL -> deleteCsr: Void (scalar)
        public static string DeleteCsr(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteCsr" + args + "\n";
        }
        public static object DeleteCsrFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeleteCustomReport
        // GraphQL -> deleteCustomReport: Void (scalar)
        public static string DeleteCustomReport(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteCustomReport" + args + "\n";
        }
        public static object DeleteCustomReportFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeleteDistributionListDigestBatch
        // GraphQL -> deleteDistributionListDigestBatch: Void (scalar)
        public static string DeleteDistributionListDigestBatch(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteDistributionListDigestBatch" + args + "\n";
        }
        public static object DeleteDistributionListDigestBatchFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeleteEventDigest
        // GraphQL -> deleteEventDigest: Void (scalar)
        public static string DeleteEventDigest(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteEventDigest" + args + "\n";
        }
        public static object DeleteEventDigestFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? DeleteGuestCredentialById
        // GraphQL -> deleteGuestCredentialById: Boolean! (scalar)
        public static string DeleteGuestCredentialById(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteGuestCredentialById" + args + "\n";
        }
        public static object DeleteGuestCredentialByIdFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? DeleteIdentityProviderById
        // GraphQL -> deleteIdentityProviderById: Void (scalar)
        public static string DeleteIdentityProviderById(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteIdentityProviderById" + args + "\n";
        }
        public static object DeleteIdentityProviderByIdFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeleteIntegration
        // GraphQL -> deleteIntegration: Void (scalar)
        public static string DeleteIntegration(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteIntegration" + args + "\n";
        }
        public static object DeleteIntegrationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeleteIntegrations
        // GraphQL -> deleteIntegrations: Void (scalar)
        public static string DeleteIntegrations(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteIntegrations" + args + "\n";
        }
        public static object DeleteIntegrationsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeleteIntelFeed
        // GraphQL -> deleteIntelFeed: Void (scalar)
        public static string DeleteIntelFeed(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteIntelFeed" + args + "\n";
        }
        public static object DeleteIntelFeedFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? DeleteLdapPrincipals
        // GraphQL -> deleteLdapPrincipals: Boolean! (scalar)
        public static string DeleteLdapPrincipals(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nprincipalIds: $principalIds\n)";
            return "deleteLdapPrincipals" + args + "\n";
        }
        public static object DeleteLdapPrincipalsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? DeleteOrg
        // GraphQL -> deleteOrg: Boolean! (scalar)
        public static string DeleteOrg(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteOrg" + args + "\n";
        }
        public static object DeleteOrgFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? DeleteReplicationPair
        // GraphQL -> deleteReplicationPair: Void (scalar)
        public static string DeleteReplicationPair(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteReplicationPair" + args + "\n";
        }
        public static object DeleteReplicationPairFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? DeleteRole
        // GraphQL -> deleteRole: Boolean! (scalar)
        public static string DeleteRole(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nroleId: $roleId\n)";
            return "deleteRole" + args + "\n";
        }
        public static object DeleteRoleFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? DeleteScheduledReport
        // GraphQL -> deleteScheduledReport: Void (scalar)
        public static string DeleteScheduledReport(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteScheduledReport" + args + "\n";
        }
        public static object DeleteScheduledReportFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? DeleteServiceAccountsFromAccount
        // GraphQL -> deleteServiceAccountsFromAccount: Boolean! (scalar)
        public static string DeleteServiceAccountsFromAccount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteServiceAccountsFromAccount" + args + "\n";
        }
        public static object DeleteServiceAccountsFromAccountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? DeleteSmbDomain
        // GraphQL -> deleteSmbDomain: Void (scalar)
        public static string DeleteSmbDomain(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteSmbDomain" + args + "\n";
        }
        public static object DeleteSmbDomainFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeleteSyslogExportRule
        // GraphQL -> deleteSyslogExportRule: Void (scalar)
        public static string DeleteSyslogExportRule(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteSyslogExportRule" + args + "\n";
        }
        public static object DeleteSyslogExportRuleFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeleteTarget
        // GraphQL -> deleteTarget: Void (scalar)
        public static string DeleteTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteTarget" + args + "\n";
        }
        public static object DeleteTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeleteTargetMapping
        // GraphQL -> deleteTargetMapping: Void (scalar)
        public static string DeleteTargetMapping(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteTargetMapping" + args + "\n";
        }
        public static object DeleteTargetMappingFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? DeleteTotpConfig
        // GraphQL -> deleteTotpConfig: Boolean! (scalar)
        public static string DeleteTotpConfig(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nuserId: $userId\n)";
            return "deleteTotpConfig" + args + "\n";
        }
        public static object DeleteTotpConfigFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? DeleteTotpConfigs
        // GraphQL -> deleteTotpConfigs: Boolean! (scalar)
        public static string DeleteTotpConfigs(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteTotpConfigs" + args + "\n";
        }
        public static object DeleteTotpConfigsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? DeleteTprPolicy
        // GraphQL -> deleteTprPolicy: Void (scalar)
        public static string DeleteTprPolicy(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteTprPolicy" + args + "\n";
        }
        public static object DeleteTprPolicyFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? DeleteUsersFromAccount
        // GraphQL -> deleteUsersFromAccount: Boolean! (scalar)
        public static string DeleteUsersFromAccount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nids: $ids\n)";
            return "deleteUsersFromAccount" + args + "\n";
        }
        public static object DeleteUsersFromAccountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? DeleteWebhook
        // GraphQL -> deleteWebhook: Void (scalar)
        public static string DeleteWebhook(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteWebhook" + args + "\n";
        }
        public static object DeleteWebhookFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeleteWebhookV2
        // GraphQL -> deleteWebhookV2: Void (scalar)
        public static string DeleteWebhookV2(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteWebhookV2" + args + "\n";
        }
        public static object DeleteWebhookV2FieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DenyTprRequests
        // GraphQL -> denyTprRequests: Void (scalar)
        public static string DenyTprRequests(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "denyTprRequests" + args + "\n";
        }
        public static object DenyTprRequestsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeregisterPrivateContainerRegistry
        // GraphQL -> deregisterPrivateContainerRegistry: Void (scalar)
        public static string DeregisterPrivateContainerRegistry(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deregisterPrivateContainerRegistry" + args + "\n";
        }
        public static object DeregisterPrivateContainerRegistryFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DisableSupportUserAccess
        // GraphQL -> disableSupportUserAccess: Void (scalar)
        public static string DisableSupportUserAccess(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "disableSupportUserAccess" + args + "\n";
        }
        public static object DisableSupportUserAccessFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DisableTprOrg
        // GraphQL -> disableTprOrg: Void (scalar)
        public static string DisableTprOrg(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "disableTprOrg" + args + "\n";
        }
        public static object DisableTprOrgFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DisconnectAwsExocomputeCluster
        // GraphQL -> disconnectAwsExocomputeCluster: Void (scalar)
        public static string DisconnectAwsExocomputeCluster(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "disconnectAwsExocomputeCluster" + args + "\n";
        }
        public static object DisconnectAwsExocomputeClusterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DisconnectExocomputeCluster
        // GraphQL -> disconnectExocomputeCluster: Void (scalar)
        public static string DisconnectExocomputeCluster(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "disconnectExocomputeCluster" + args + "\n";
        }
        public static object DisconnectExocomputeClusterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? EnableIntegration
        // GraphQL -> enableIntegration: Void (scalar)
        public static string EnableIntegration(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "enableIntegration" + args + "\n";
        }
        public static object EnableIntegrationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? EnableSupportUserAccess
        // GraphQL -> enableSupportUserAccess: Void (scalar)
        public static string EnableSupportUserAccess(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "enableSupportUserAccess" + args + "\n";
        }
        public static object EnableSupportUserAccessFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? EnableThreatMonitoring
        // GraphQL -> enableThreatMonitoring: Void (scalar)
        public static string EnableThreatMonitoring(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "enableThreatMonitoring" + args + "\n";
        }
        public static object EnableThreatMonitoringFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? EnableTprOrg
        // GraphQL -> enableTprOrg: Void (scalar)
        public static string EnableTprOrg(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "enableTprOrg" + args + "\n";
        }
        public static object EnableTprOrgFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? ExcludeAwsNativeEbsVolumesFromSnapshot
        // GraphQL -> excludeAwsNativeEbsVolumesFromSnapshot: Void (scalar)
        public static string ExcludeAwsNativeEbsVolumesFromSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "excludeAwsNativeEbsVolumesFromSnapshot" + args + "\n";
        }
        public static object ExcludeAwsNativeEbsVolumesFromSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? ExcludeAzureNativeManagedDisksFromSnapshot
        // GraphQL -> excludeAzureNativeManagedDisksFromSnapshot: Void (scalar)
        public static string ExcludeAzureNativeManagedDisksFromSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "excludeAzureNativeManagedDisksFromSnapshot" + args + "\n";
        }
        public static object ExcludeAzureNativeManagedDisksFromSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? ExcludeAzureStorageAccountContainers
        // GraphQL -> excludeAzureStorageAccountContainers: Void (scalar)
        public static string ExcludeAzureStorageAccountContainers(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "excludeAzureStorageAccountContainers" + args + "\n";
        }
        public static object ExcludeAzureStorageAccountContainersFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? ExcludeSharepointObjectsFromProtection
        // GraphQL -> excludeSharepointObjectsFromProtection: Void (scalar)
        public static string ExcludeSharepointObjectsFromProtection(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "excludeSharepointObjectsFromProtection" + args + "\n";
        }
        public static object ExcludeSharepointObjectsFromProtectionFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? ExecuteTprRequests
        // GraphQL -> executeTprRequests: Void (scalar)
        public static string ExecuteTprRequests(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "executeTprRequests" + args + "\n";
        }
        public static object ExecuteTprRequestsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? GcpBulkSetCloudAccountProperties
        // GraphQL -> gcpBulkSetCloudAccountProperties: Boolean! (scalar)
        public static string GcpBulkSetCloudAccountProperties(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "gcpBulkSetCloudAccountProperties" + args + "\n";
        }
        public static object GcpBulkSetCloudAccountPropertiesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? GcpCloudAccountAddManualAuthProject
        // GraphQL -> gcpCloudAccountAddManualAuthProject: Boolean! (scalar)
        public static string GcpCloudAccountAddManualAuthProject(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "gcpCloudAccountAddManualAuthProject" + args + "\n";
        }
        public static object GcpCloudAccountAddManualAuthProjectFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? GcpNativeExcludeDisksFromInstanceSnapshot
        // GraphQL -> gcpNativeExcludeDisksFromInstanceSnapshot: Void (scalar)
        public static string GcpNativeExcludeDisksFromInstanceSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "gcpNativeExcludeDisksFromInstanceSnapshot" + args + "\n";
        }
        public static object GcpNativeExcludeDisksFromInstanceSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? GcpSetDefaultServiceAccountJwtConfig
        // GraphQL -> gcpSetDefaultServiceAccountJwtConfig: Boolean! (scalar)
        public static string GcpSetDefaultServiceAccountJwtConfig(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "gcpSetDefaultServiceAccountJwtConfig" + args + "\n";
        }
        public static object GcpSetDefaultServiceAccountJwtConfigFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? HideRevealNasNamespaces
        // GraphQL -> hideRevealNasNamespaces: Void (scalar)
        public static string HideRevealNasNamespaces(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "hideRevealNasNamespaces" + args + "\n";
        }
        public static object HideRevealNasNamespacesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? InviteSsoGroup
        // GraphQL -> inviteSsoGroup: Boolean! (scalar)
        public static string InviteSsoGroup(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "inviteSsoGroup" + args + "\n";
        }
        public static object InviteSsoGroupFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? JoinSmbDomain
        // GraphQL -> joinSmbDomain: Void (scalar)
        public static string JoinSmbDomain(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "joinSmbDomain" + args + "\n";
        }
        public static object JoinSmbDomainFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? LockUsersByAdmin
        // GraphQL -> lockUsersByAdmin: Void (scalar)
        public static string LockUsersByAdmin(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "lockUsersByAdmin" + args + "\n";
        }
        public static object LockUsersByAdminFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? ModifyActiveDirectoryLiveMount
        // GraphQL -> modifyActiveDirectoryLiveMount: Void (scalar)
        public static string ModifyActiveDirectoryLiveMount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "modifyActiveDirectoryLiveMount" + args + "\n";
        }
        public static object ModifyActiveDirectoryLiveMountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? ModifyDistributionListDigestBatch
        // GraphQL -> modifyDistributionListDigestBatch: Void (scalar)
        public static string ModifyDistributionListDigestBatch(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "modifyDistributionListDigestBatch" + args + "\n";
        }
        public static object ModifyDistributionListDigestBatchFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? ModifyEventDigestBatch
        // GraphQL -> modifyEventDigestBatch: Void (scalar)
        public static string ModifyEventDigestBatch(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "modifyEventDigestBatch" + args + "\n";
        }
        public static object ModifyEventDigestBatchFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? ModifyIdentityProvider
        // GraphQL -> modifyIdentityProvider: Void (scalar)
        public static string ModifyIdentityProvider(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "modifyIdentityProvider" + args + "\n";
        }
        public static object ModifyIdentityProviderFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? MutateRole
        // GraphQL -> mutateRole: UUID! (scalar)
        public static string MutateRole(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nroleId: $roleId\nname: $name\ndescription: $description\npermissions: $permissions\nprotectableClusters: $protectableClusters\nisSynced: $isSynced\n)";
            return "mutateRole" + args + "\n";
        }
        public static object MutateRoleFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? PatchAwsAuthenticationServerBasedCloudAccount
        // GraphQL -> patchAwsAuthenticationServerBasedCloudAccount: Boolean! (scalar)
        public static string PatchAwsAuthenticationServerBasedCloudAccount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "patchAwsAuthenticationServerBasedCloudAccount" + args + "\n";
        }
        public static object PatchAwsAuthenticationServerBasedCloudAccountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? PatchAwsIamUserBasedCloudAccount
        // GraphQL -> patchAwsIamUserBasedCloudAccount: Boolean! (scalar)
        public static string PatchAwsIamUserBasedCloudAccount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "patchAwsIamUserBasedCloudAccount" + args + "\n";
        }
        public static object PatchAwsIamUserBasedCloudAccountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? PromoteReaderTarget
        // GraphQL -> promoteReaderTarget: Void (scalar)
        public static string PromoteReaderTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "promoteReaderTarget" + args + "\n";
        }
        public static object PromoteReaderTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? RefreshReaderTarget
        // GraphQL -> refreshReaderTarget: Void (scalar)
        public static string RefreshReaderTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "refreshReaderTarget" + args + "\n";
        }
        public static object RefreshReaderTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? ReleasePersistentExoclusters
        // GraphQL -> releasePersistentExoclusters: Void (scalar)
        public static string ReleasePersistentExoclusters(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "releasePersistentExoclusters" + args + "\n";
        }
        public static object ReleasePersistentExoclustersFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? RemoveCdmCluster
        // GraphQL -> removeCdmCluster: Boolean! (scalar)
        public static string RemoveCdmCluster(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nclusterUUID: $clusterUUID\nisForce: $isForce\nexpireInDays: $expireInDays\n)";
            return "removeCdmCluster" + args + "\n";
        }
        public static object RemoveCdmClusterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? RemoveInventoryWorkloads
        // GraphQL -> removeInventoryWorkloads: Boolean! (scalar)
        public static string RemoveInventoryWorkloads(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "removeInventoryWorkloads" + args + "\n";
        }
        public static object RemoveInventoryWorkloadsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? RemoveLdapIntegration
        // GraphQL -> removeLdapIntegration: Boolean! (scalar)
        public static string RemoveLdapIntegration(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nid: $id\n)";
            return "removeLdapIntegration" + args + "\n";
        }
        public static object RemoveLdapIntegrationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> List<System.String>? RemovePolicyObjects
        // GraphQL -> removePolicyObjects: [String!]! (scalar)
        public static string RemovePolicyObjects(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\npolicyIds: $policyIds\nobjectIds: $objectIds\nobjectRootIds: $objectRootIds\nclusterIds: $clusterIds\nrunAsync: $runAsync\n)";
            return "removePolicyObjects" + args + "\n";
        }
        public static object RemovePolicyObjectsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> System.String? RemovePrivateEndpointConnection
        // GraphQL -> removePrivateEndpointConnection: Void (scalar)
        public static string RemovePrivateEndpointConnection(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "removePrivateEndpointConnection" + args + "\n";
        }
        public static object RemovePrivateEndpointConnectionFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? ResetAllOrgUsersPasswords
        // GraphQL -> resetAllOrgUsersPasswords: Void (scalar)
        public static string ResetAllOrgUsersPasswords(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "";
            return "resetAllOrgUsersPasswords" + args + "\n";
        }
        public static object ResetAllOrgUsersPasswordsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? ResetUsersPasswordsWithUserIds
        // GraphQL -> resetUsersPasswordsWithUserIds: Void (scalar)
        public static string ResetUsersPasswordsWithUserIds(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "resetUsersPasswordsWithUserIds" + args + "\n";
        }
        public static object ResetUsersPasswordsWithUserIdsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? ResolveAnomaly
        // GraphQL -> resolveAnomaly: Void (scalar)
        public static string ResolveAnomaly(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "resolveAnomaly" + args + "\n";
        }
        public static object ResolveAnomalyFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? RevokeAllOrgRoles
        // GraphQL -> revokeAllOrgRoles: Void (scalar)
        public static string RevokeAllOrgRoles(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "revokeAllOrgRoles" + args + "\n";
        }
        public static object RevokeAllOrgRolesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? SetAzureCloudAccountCustomerAppCredentials
        // GraphQL -> setAzureCloudAccountCustomerAppCredentials: Boolean! (scalar)
        public static string SetAzureCloudAccountCustomerAppCredentials(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "setAzureCloudAccountCustomerAppCredentials" + args + "\n";
        }
        public static object SetAzureCloudAccountCustomerAppCredentialsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? SetBundleApprovalStatus
        // GraphQL -> setBundleApprovalStatus: Void (scalar)
        public static string SetBundleApprovalStatus(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "setBundleApprovalStatus" + args + "\n";
        }
        public static object SetBundleApprovalStatusFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? SetCustomerTags
        // GraphQL -> setCustomerTags: Void (scalar)
        public static string SetCustomerTags(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "setCustomerTags" + args + "\n";
        }
        public static object SetCustomerTagsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? SetIpWhitelistEnabled
        // GraphQL -> setIpWhitelistEnabled: Boolean! (scalar)
        public static string SetIpWhitelistEnabled(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nenabled: $enabled\n)";
            return "setIpWhitelistEnabled" + args + "\n";
        }
        public static object SetIpWhitelistEnabledFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? SetLdapMfaSetting
        // GraphQL -> setLdapMfaSetting: Boolean! (scalar)
        public static string SetLdapMfaSetting(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "setLdapMfaSetting" + args + "\n";
        }
        public static object SetLdapMfaSettingFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? SetMfaSetting
        // GraphQL -> setMfaSetting: Boolean! (scalar)
        public static string SetMfaSetting(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "setMfaSetting" + args + "\n";
        }
        public static object SetMfaSettingFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? SetPasswordComplexityPolicy
        // GraphQL -> setPasswordComplexityPolicy: Void (scalar)
        public static string SetPasswordComplexityPolicy(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "setPasswordComplexityPolicy" + args + "\n";
        }
        public static object SetPasswordComplexityPolicyFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? SetPrivateContainerRegistry
        // GraphQL -> setPrivateContainerRegistry: Void (scalar)
        public static string SetPrivateContainerRegistry(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "setPrivateContainerRegistry" + args + "\n";
        }
        public static object SetPrivateContainerRegistryFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? SetSsoCertificate
        // GraphQL -> setSsoCertificate: Void (scalar)
        public static string SetSsoCertificate(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "setSsoCertificate" + args + "\n";
        }
        public static object SetSsoCertificateFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? SetTotpConfig
        // GraphQL -> setTotpConfig: Boolean! (scalar)
        public static string SetTotpConfig(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "setTotpConfig" + args + "\n";
        }
        public static object SetTotpConfigFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? SetUserLevelTotpEnforcement
        // GraphQL -> setUserLevelTotpEnforcement: Boolean! (scalar)
        public static string SetUserLevelTotpEnforcement(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "setUserLevelTotpEnforcement" + args + "\n";
        }
        public static object SetUserLevelTotpEnforcementFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? StopJobInstanceFromEventSeries
        // GraphQL -> stopJobInstanceFromEventSeries: Void (scalar)
        public static string StopJobInstanceFromEventSeries(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "stopJobInstanceFromEventSeries" + args + "\n";
        }
        public static object StopJobInstanceFromEventSeriesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? SubmitTprRequest
        // GraphQL -> submitTprRequest: Void (scalar)
        public static string SubmitTprRequest(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "submitTprRequest" + args + "\n";
        }
        public static object SubmitTprRequestFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? SwitchProductToOnboardingMode
        // GraphQL -> switchProductToOnboardingMode: Void (scalar)
        public static string SwitchProductToOnboardingMode(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "switchProductToOnboardingMode" + args + "\n";
        }
        public static object SwitchProductToOnboardingModeFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UnlockUsersByAdmin
        // GraphQL -> unlockUsersByAdmin: Void (scalar)
        public static string UnlockUsersByAdmin(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "unlockUsersByAdmin" + args + "\n";
        }
        public static object UnlockUsersByAdminFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UnmapAzurePersistentStorageSubscription
        // GraphQL -> unmapAzurePersistentStorageSubscription: Void (scalar)
        public static string UnmapAzurePersistentStorageSubscription(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "unmapAzurePersistentStorageSubscription" + args + "\n";
        }
        public static object UnmapAzurePersistentStorageSubscriptionFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UnmountDisk
        // GraphQL -> unmountDisk: Void (scalar)
        public static string UnmountDisk(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "unmountDisk" + args + "\n";
        }
        public static object UnmountDiskFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? UpdateAccountOwner
        // GraphQL -> updateAccountOwner: Boolean! (scalar)
        public static string UpdateAccountOwner(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nuserId: $userId\n)";
            return "updateAccountOwner" + args + "\n";
        }
        public static object UpdateAccountOwnerFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? UpdateAdGroup
        // GraphQL -> updateAdGroup: Void (scalar)
        public static string UpdateAdGroup(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateAdGroup" + args + "\n";
        }
        public static object UpdateAdGroupFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateAuthDomainUsersHiddenStatus
        // GraphQL -> updateAuthDomainUsersHiddenStatus: Void (scalar)
        public static string UpdateAuthDomainUsersHiddenStatus(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateAuthDomainUsersHiddenStatus" + args + "\n";
        }
        public static object UpdateAuthDomainUsersHiddenStatusFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateAwsCloudAccount
        // GraphQL -> updateAwsCloudAccount: Void (scalar)
        public static string UpdateAwsCloudAccount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateAwsCloudAccount" + args + "\n";
        }
        public static object UpdateAwsCloudAccountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateAwsIamPair
        // GraphQL -> updateAwsIamPair: Void (scalar)
        public static string UpdateAwsIamPair(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateAwsIamPair" + args + "\n";
        }
        public static object UpdateAwsIamPairFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateBackupTriggerForWorkloads
        // GraphQL -> updateBackupTriggerForWorkloads: Void (scalar)
        public static string UpdateBackupTriggerForWorkloads(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateBackupTriggerForWorkloads" + args + "\n";
        }
        public static object UpdateBackupTriggerForWorkloadsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? UpdateCertificate
        // GraphQL -> updateCertificate: Boolean! (scalar)
        public static string UpdateCertificate(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ncertificateId: $certificateId\nname: $name\ndescription: $description\ncertificate: $certificate\n)";
            return "updateCertificate" + args + "\n";
        }
        public static object UpdateCertificateFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? UpdateCloudNativeLabelRule
        // GraphQL -> updateCloudNativeLabelRule: Void (scalar)
        public static string UpdateCloudNativeLabelRule(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateCloudNativeLabelRule" + args + "\n";
        }
        public static object UpdateCloudNativeLabelRuleFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateCloudNativeRootThreatMonitoringEnablement
        // GraphQL -> updateCloudNativeRootThreatMonitoringEnablement: Void (scalar)
        public static string UpdateCloudNativeRootThreatMonitoringEnablement(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateCloudNativeRootThreatMonitoringEnablement" + args + "\n";
        }
        public static object UpdateCloudNativeRootThreatMonitoringEnablementFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateCloudNativeTagRule
        // GraphQL -> updateCloudNativeTagRule: Void (scalar)
        public static string UpdateCloudNativeTagRule(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateCloudNativeTagRule" + args + "\n";
        }
        public static object UpdateCloudNativeTagRuleFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateConfiguredGroup
        // GraphQL -> updateConfiguredGroup: Void (scalar)
        public static string UpdateConfiguredGroup(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateConfiguredGroup" + args + "\n";
        }
        public static object UpdateConfiguredGroupFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateCustomIntelFeed
        // GraphQL -> updateCustomIntelFeed: Void (scalar)
        public static string UpdateCustomIntelFeed(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateCustomIntelFeed" + args + "\n";
        }
        public static object UpdateCustomIntelFeedFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateCustomerAppPermissionForAzureSql
        // GraphQL -> updateCustomerAppPermissionForAzureSql: Void (scalar)
        public static string UpdateCustomerAppPermissionForAzureSql(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "";
            return "updateCustomerAppPermissionForAzureSql" + args + "\n";
        }
        public static object UpdateCustomerAppPermissionForAzureSqlFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateIntegration
        // GraphQL -> updateIntegration: Void (scalar)
        public static string UpdateIntegration(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateIntegration" + args + "\n";
        }
        public static object UpdateIntegrationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateIntegrations
        // GraphQL -> updateIntegrations: Void (scalar)
        public static string UpdateIntegrations(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateIntegrations" + args + "\n";
        }
        public static object UpdateIntegrationsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateIocStatus
        // GraphQL -> updateIocStatus: Void (scalar)
        public static string UpdateIocStatus(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateIocStatus" + args + "\n";
        }
        public static object UpdateIocStatusFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? UpdateIpWhitelist
        // GraphQL -> updateIpWhitelist: Boolean! (scalar)
        public static string UpdateIpWhitelist(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nwhitelistMode: $whitelistMode\nipCidrs: $ipCidrs\n)";
            return "updateIpWhitelist" + args + "\n";
        }
        public static object UpdateIpWhitelistFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? UpdateLdapIntegration
        // GraphQL -> updateLdapIntegration: String! (scalar)
        public static string UpdateLdapIntegration(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nid: $id\nname: $name\nbindUserName: $bindUserName\nbindUserPassword: $bindUserPassword\nbaseDn: $baseDn\ntrustedCerts: $trustedCerts\ndynamicDnsName: $dynamicDnsName\nldapServers: $ldapServers\nuserSearchFilter: $userSearchFilter\nuserNameAttr: $userNameAttr\ngroupMembershipAttr: $groupMembershipAttr\ngroupSearchFilter: $groupSearchFilter\ngroupMemberAttr: $groupMemberAttr\n)";
            return "updateLdapIntegration" + args + "\n";
        }
        public static object UpdateLdapIntegrationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateNasShares
        // GraphQL -> updateNasShares: Void (scalar)
        public static string UpdateNasShares(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateNasShares" + args + "\n";
        }
        public static object UpdateNasSharesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateO365AppPermissions
        // GraphQL -> updateO365AppPermissions: Void (scalar)
        public static string UpdateO365AppPermissions(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateO365AppPermissions" + args + "\n";
        }
        public static object UpdateO365AppPermissionsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateOrgSecurityPolicy
        // GraphQL -> updateOrgSecurityPolicy: Void (scalar)
        public static string UpdateOrgSecurityPolicy(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateOrgSecurityPolicy" + args + "\n";
        }
        public static object UpdateOrgSecurityPolicyFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateReplicationTarget
        // GraphQL -> updateReplicationTarget: Void (scalar)
        public static string UpdateReplicationTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateReplicationTarget" + args + "\n";
        }
        public static object UpdateReplicationTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? UpdateRole
        // GraphQL -> updateRole: Boolean! (scalar)
        public static string UpdateRole(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nroleId: $roleId\nname: $name\ndescription: $description\nisSynced: $isSynced\npermissions: $permissions\n)";
            return "updateRole" + args + "\n";
        }
        public static object UpdateRoleFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? UpdateRoleAssignments
        // GraphQL -> updateRoleAssignments: Boolean! (scalar)
        public static string UpdateRoleAssignments(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nuserIds: $userIds\ngroupIds: $groupIds\nroleIds: $roleIds\n)";
            return "updateRoleAssignments" + args + "\n";
        }
        public static object UpdateRoleAssignmentsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? UpdateSupportUserAccess
        // GraphQL -> updateSupportUserAccess: Void (scalar)
        public static string UpdateSupportUserAccess(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateSupportUserAccess" + args + "\n";
        }
        public static object UpdateSupportUserAccessFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateTprConfiguration
        // GraphQL -> updateTprConfiguration: Void (scalar)
        public static string UpdateTprConfiguration(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateTprConfiguration" + args + "\n";
        }
        public static object UpdateTprConfigurationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateTprPolicy
        // GraphQL -> updateTprPolicy: Void (scalar)
        public static string UpdateTprPolicy(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateTprPolicy" + args + "\n";
        }
        public static object UpdateTprPolicyFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateVlan
        // GraphQL -> updateVlan: Void (scalar)
        public static string UpdateVlan(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateVlan" + args + "\n";
        }
        public static object UpdateVlanFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateWhitelistedAnalyzers
        // GraphQL -> updateWhitelistedAnalyzers: String! (scalar)
        public static string UpdateWhitelistedAnalyzers(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nstdPath: $stdPath\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nanalyzerIds: $analyzerIds\nrunAsync: $runAsync\n)";
            return "updateWhitelistedAnalyzers" + args + "\n";
        }
        public static object UpdateWhitelistedAnalyzersFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? UpgradeAwsCloudAccountFeaturesWithoutCft
        // GraphQL -> upgradeAwsCloudAccountFeaturesWithoutCft: Boolean! (scalar)
        public static string UpgradeAwsCloudAccountFeaturesWithoutCft(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "upgradeAwsCloudAccountFeaturesWithoutCft" + args + "\n";
        }
        public static object UpgradeAwsCloudAccountFeaturesWithoutCftFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? UpgradeAwsIamUserBasedCloudAccountPermissions
        // GraphQL -> upgradeAwsIamUserBasedCloudAccountPermissions: Boolean! (scalar)
        public static string UpgradeAwsIamUserBasedCloudAccountPermissions(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "upgradeAwsIamUserBasedCloudAccountPermissions" + args + "\n";
        }
        public static object UpgradeAwsIamUserBasedCloudAccountPermissionsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? UpgradeCdmManagedTarget
        // GraphQL -> upgradeCdmManagedTarget: Void (scalar)
        public static string UpgradeCdmManagedTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "upgradeCdmManagedTarget" + args + "\n";
        }
        public static object UpgradeCdmManagedTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpgradeToRsc
        // GraphQL -> upgradeToRsc: Void (scalar)
        public static string UpgradeToRsc(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "";
            return "upgradeToRsc" + args + "\n";
        }
        public static object UpgradeToRscFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? VsphereVmDeleteSnapshot
        // GraphQL -> vsphereVmDeleteSnapshot: Void (scalar)
        public static string VsphereVmDeleteSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmDeleteSnapshot" + args + "\n";
        }
        public static object VsphereVmDeleteSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? VsphereVmUpdateUnmountTime
        // GraphQL -> vsphereVmUpdateUnmountTime: Void (scalar)
        public static string VsphereVmUpdateUnmountTime(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmUpdateUnmountTime" + args + "\n";
        }
        public static object VsphereVmUpdateUnmountTimeFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? WarmSearchCache
        // GraphQL -> warmSearchCache: Boolean! (scalar)
        public static string WarmSearchCache(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "warmSearchCache" + args + "\n";
        }
        public static object WarmSearchCacheFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> RequestStatus? AddAdGroupsToHierarchy
        // GraphQL -> addAdGroupsToHierarchy: RequestStatus! (type)
        public static string AddAdGroupsToHierarchy(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addAdGroupsToHierarchy" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddAdGroupsToHierarchyFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddAndJoinSmbDomainReply? AddAndJoinSmbDomain
        // GraphQL -> addAndJoinSmbDomain: AddAndJoinSmbDomainReply! (type)
        public static string AddAndJoinSmbDomain(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addAndJoinSmbDomain" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddAndJoinSmbDomainFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AddAndJoinSmbDomainReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddAwsAuthenticationServerBasedCloudAccountReply? AddAwsAuthenticationServerBasedCloudAccount
        // GraphQL -> addAwsAuthenticationServerBasedCloudAccount: AddAwsAuthenticationServerBasedCloudAccountReply! (type)
        public static string AddAwsAuthenticationServerBasedCloudAccount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addAwsAuthenticationServerBasedCloudAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddAwsAuthenticationServerBasedCloudAccountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AddAwsAuthenticationServerBasedCloudAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddAwsIamUserBasedCloudAccountReply? AddAwsIamUserBasedCloudAccount
        // GraphQL -> addAwsIamUserBasedCloudAccount: AddAwsIamUserBasedCloudAccountReply! (type)
        public static string AddAwsIamUserBasedCloudAccount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addAwsIamUserBasedCloudAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddAwsIamUserBasedCloudAccountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AddAwsIamUserBasedCloudAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddAzureCloudAccountReply? AddAzureCloudAccount
        // GraphQL -> addAzureCloudAccount: AddAzureCloudAccountReply! (type)
        public static string AddAzureCloudAccount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addAzureCloudAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddAzureCloudAccountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AddAzureCloudAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddAzureCloudAccountExocomputeConfigurationsReply? AddAzureCloudAccountExocomputeConfigurations
        // GraphQL -> addAzureCloudAccountExocomputeConfigurations: AddAzureCloudAccountExocomputeConfigurationsReply! (type)
        public static string AddAzureCloudAccountExocomputeConfigurations(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addAzureCloudAccountExocomputeConfigurations" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddAzureCloudAccountExocomputeConfigurationsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AddAzureCloudAccountExocomputeConfigurationsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddAzureCloudAccountWithoutOauthReply? AddAzureCloudAccountWithoutOauth
        // GraphQL -> addAzureCloudAccountWithoutOauth: AddAzureCloudAccountWithoutOauthReply! (type)
        public static string AddAzureCloudAccountWithoutOauth(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addAzureCloudAccountWithoutOauth" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddAzureCloudAccountWithoutOauthFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AddAzureCloudAccountWithoutOauthReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddCloudNativeSqlServerBackupCredentialsReply? AddCloudNativeSqlServerBackupCredentials
        // GraphQL -> addCloudNativeSqlServerBackupCredentials: AddCloudNativeSqlServerBackupCredentialsReply! (type)
        public static string AddCloudNativeSqlServerBackupCredentials(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addCloudNativeSqlServerBackupCredentials" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddCloudNativeSqlServerBackupCredentialsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AddCloudNativeSqlServerBackupCredentialsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddClusterCertificateReply? AddClusterCertificate
        // GraphQL -> addClusterCertificate: AddClusterCertificateReply! (type)
        public static string AddClusterCertificate(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addClusterCertificate" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddClusterCertificateFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AddClusterCertificateReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddClusterNodesReply? AddClusterNodes
        // GraphQL -> addClusterNodes: AddClusterNodesReply! (type)
        public static string AddClusterNodes(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nAddClusterNodesInput: $AddClusterNodesInput\n)";
            return "addClusterNodes" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddClusterNodesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AddClusterNodesReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddClusterRouteReply? AddClusterRoute
        // GraphQL -> addClusterRoute: AddClusterRouteReply! (type)
        public static string AddClusterRoute(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addClusterRoute" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddClusterRouteFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AddClusterRouteReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddConfiguredGroupToHierarchyReply? AddConfiguredGroupToHierarchy
        // GraphQL -> addConfiguredGroupToHierarchy: AddConfiguredGroupToHierarchyReply! (type)
        public static string AddConfiguredGroupToHierarchy(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addConfiguredGroupToHierarchy" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddConfiguredGroupToHierarchyFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AddConfiguredGroupToHierarchyReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddCrossAccountServiceConsumerReply? AddCrossAccountServiceConsumer
        // GraphQL -> addCrossAccountServiceConsumer: AddCrossAccountServiceConsumerReply! (type)
        public static string AddCrossAccountServiceConsumer(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addCrossAccountServiceConsumer" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddCrossAccountServiceConsumerFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AddCrossAccountServiceConsumerReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddCustomIntelFeedReply? AddCustomIntelFeed
        // GraphQL -> addCustomIntelFeed: AddCustomIntelFeedReply! (type)
        public static string AddCustomIntelFeed(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addCustomIntelFeed" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddCustomIntelFeedFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AddCustomIntelFeedReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddDb2InstanceReply? AddDb2Instance
        // GraphQL -> addDb2Instance: AddDb2InstanceReply! (type)
        public static string AddDb2Instance(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addDb2Instance" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddDb2InstanceFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AddDb2InstanceReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddGlobalCertificateReply? AddGlobalCertificate
        // GraphQL -> addGlobalCertificate: AddGlobalCertificateReply! (type)
        public static string AddGlobalCertificate(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addGlobalCertificate" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddGlobalCertificateFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AddGlobalCertificateReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddIdentityProviderReply? AddIdentityProvider
        // GraphQL -> addIdentityProvider: AddIdentityProviderReply! (type)
        public static string AddIdentityProvider(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addIdentityProvider" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddIdentityProviderFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AddIdentityProviderReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> K8sClusterSummary? AddK8sCluster
        // GraphQL -> addK8sCluster: K8sClusterSummary! (type)
        public static string AddK8sCluster(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addK8sCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddK8sClusterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new K8sClusterSummary() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> K8sProtectionSetSummary? AddK8sProtectionSet
        // GraphQL -> addK8sProtectionSet: K8sProtectionSetSummary! (type)
        public static string AddK8sProtectionSet(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addK8sProtectionSet" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddK8sProtectionSetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new K8sProtectionSetSummary() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddManagedVolumeReply? AddManagedVolume
        // GraphQL -> addManagedVolume: AddManagedVolumeReply! (type)
        public static string AddManagedVolume(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addManagedVolume" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddManagedVolumeFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AddManagedVolumeReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddMongoSourceReply? AddMongoSource
        // GraphQL -> addMongoSource: AddMongoSourceReply! (type)
        public static string AddMongoSource(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addMongoSource" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddMongoSourceFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AddMongoSourceReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicAsyncResponse? AddMosaicStore
        // GraphQL -> addMosaicStore: MosaicAsyncResponse! (type)
        public static string AddMosaicStore(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addMosaicStore" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddMosaicStoreFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new MosaicAsyncResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkRegisterHostAsyncReply? AddMssqlHost
        // GraphQL -> addMssqlHost: BulkRegisterHostAsyncReply! (type)
        public static string AddMssqlHost(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addMssqlHost" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddMssqlHostFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BulkRegisterHostAsyncReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CcProvisionJobReply? AddNodesToCloudCluster
        // GraphQL -> addNodesToCloudCluster: CcProvisionJobReply! (type)
        public static string AddNodesToCloudCluster(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addNodesToCloudCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddNodesToCloudClusterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CcProvisionJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddO365OrgResponse? AddO365Org
        // GraphQL -> addO365Org: AddO365OrgResponse! (type)
        public static string AddO365Org(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addO365Org" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddO365OrgFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AddO365OrgResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddSapHanaSystemReply? AddSapHanaSystem
        // GraphQL -> addSapHanaSystem: AddSapHanaSystemReply! (type)
        public static string AddSapHanaSystem(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addSapHanaSystem" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddSapHanaSystemFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AddSapHanaSystemReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddStorageArraysReply? AddStorageArrays
        // GraphQL -> addStorageArrays: AddStorageArraysReply! (type)
        public static string AddStorageArrays(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addStorageArrays" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddStorageArraysFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AddStorageArraysReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddSyslogExportRuleReply? AddSyslogExportRule
        // GraphQL -> addSyslogExportRule: AddSyslogExportRuleReply! (type)
        public static string AddSyslogExportRule(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addSyslogExportRule" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddSyslogExportRuleFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AddSyslogExportRuleReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? AddVlan
        // GraphQL -> addVlan: ResponseSuccess! (type)
        public static string AddVlan(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addVlan" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddVlanFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddVmAppConsistentSpecsReply? AddVmAppConsistentSpecs
        // GraphQL -> addVmAppConsistentSpecs: AddVmAppConsistentSpecsReply! (type)
        public static string AddVmAppConsistentSpecs(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "addVmAppConsistentSpecs" + args + "\n{\n" + fs + "}\n";
        }
        public static object AddVmAppConsistentSpecsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AddVmAppConsistentSpecsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ApproveRcvPrivateEndpointReply? ApproveRcvPrivateEndpoint
        // GraphQL -> approveRcvPrivateEndpoint: ApproveRcvPrivateEndpointReply! (type)
        public static string ApproveRcvPrivateEndpoint(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "approveRcvPrivateEndpoint" + args + "\n{\n" + fs + "}\n";
        }
        public static object ApproveRcvPrivateEndpointFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ApproveRcvPrivateEndpointReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ArchiveK8sClusterReply? ArchiveK8sCluster
        // GraphQL -> archiveK8sCluster: ArchiveK8sClusterReply! (type)
        public static string ArchiveK8sCluster(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "archiveK8sCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object ArchiveK8sClusterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ArchiveK8sClusterReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? AssignMssqlSlaDomainProperties
        // GraphQL -> assignMssqlSlaDomainProperties: ResponseSuccess! (type)
        public static string AssignMssqlSlaDomainProperties(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "assignMssqlSlaDomainProperties" + args + "\n{\n" + fs + "}\n";
        }
        public static object AssignMssqlSlaDomainPropertiesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AssignMssqlSlaDomainPropertiesAsyncReply? AssignMssqlSlaDomainPropertiesAsync
        // GraphQL -> assignMssqlSlaDomainPropertiesAsync: AssignMssqlSlaDomainPropertiesAsyncReply! (type)
        public static string AssignMssqlSlaDomainPropertiesAsync(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "assignMssqlSlaDomainPropertiesAsync" + args + "\n{\n" + fs + "}\n";
        }
        public static object AssignMssqlSlaDomainPropertiesAsyncFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AssignMssqlSlaDomainPropertiesAsyncReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SlaAssignResult? AssignProtection
        // GraphQL -> assignProtection: SlaAssignResult! (type)
        public static string AssignProtection(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "assignProtection" + args + "\n{\n" + fs + "}\n";
        }
        public static object AssignProtectionFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new SlaAssignResult() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SlaAssignResult? AssignRetentionSlaToSnappables
        // GraphQL -> assignRetentionSLAToSnappables: SlaAssignResult! (type)
        public static string AssignRetentionSlaToSnappables(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nglobalSlaOptionalFid: $globalSlaOptionalFid\nglobalSlaAssignType: $globalSlaAssignType\nobjectIds: $objectIds\napplicableSnappableType: $applicableSnappableType\nshouldApplyToNonPolicySnapshots: $shouldApplyToNonPolicySnapshots\nuserNote: $userNote\n)";
            return "assignRetentionSLAToSnappables" + args + "\n{\n" + fs + "}\n";
        }
        public static object AssignRetentionSlaToSnappablesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new SlaAssignResult() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SlaAssignResult? AssignRetentionSlaToSnapshots
        // GraphQL -> assignRetentionSLAToSnapshots: SlaAssignResult! (type)
        public static string AssignRetentionSlaToSnapshots(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nglobalSlaOptionalFid: $globalSlaOptionalFid\nglobalSlaAssignType: $globalSlaAssignType\nsnapshotFids: $snapshotFids\nuserNote: $userNote\n)";
            return "assignRetentionSLAToSnapshots" + args + "\n{\n" + fs + "}\n";
        }
        public static object AssignRetentionSlaToSnapshotsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new SlaAssignResult() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SlaAssignResult? AssignSla
        // GraphQL -> assignSla: SlaAssignResult! (type)
        public static string AssignSla(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "assignSla" + args + "\n{\n" + fs + "}\n";
        }
        public static object AssignSlaFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new SlaAssignResult() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? AssignSlaToMongoDbCollection
        // GraphQL -> assignSlaToMongoDbCollection: AsyncRequestStatus! (type)
        public static string AssignSlaToMongoDbCollection(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "assignSlaToMongoDbCollection" + args + "\n{\n" + fs + "}\n";
        }
        public static object AssignSlaToMongoDbCollectionFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<SlaAssignResult>? AssignSlasForSnappableHierarchies
        // GraphQL -> assignSlasForSnappableHierarchies: [SlaAssignResult!]! (type)
        public static string AssignSlasForSnappableHierarchies(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nglobalSlaOptionalFid: $globalSlaOptionalFid\nglobalSlaAssignType: $globalSlaAssignType\nobjectIds: $objectIds\napplicableSnappableTypes: $applicableSnappableTypes\nshouldApplyToExistingSnapshots: $shouldApplyToExistingSnapshots\nshouldApplyToNonPolicySnapshots: $shouldApplyToNonPolicySnapshots\nglobalExistingSnapshotRetention: $globalExistingSnapshotRetention\nuserNote: $userNote\n)";
            return "assignSlasForSnappableHierarchies" + args + "\n{\n" + fs + "}\n";
        }
        public static object AssignSlasForSnappableHierarchiesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new List<SlaAssignResult>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsCloudAccountsMigrateInitiateReply? AwsCloudAccountsMigrateInitiate
        // GraphQL -> awsCloudAccountsMigrateInitiate: AwsCloudAccountsMigrateInitiateReply! (type)
        public static string AwsCloudAccountsMigrateInitiate(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "awsCloudAccountsMigrateInitiate" + args + "\n{\n" + fs + "}\n";
        }
        public static object AwsCloudAccountsMigrateInitiateFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AwsCloudAccountsMigrateInitiateReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsExocomputeClusterConnectReply? AwsExocomputeClusterConnect
        // GraphQL -> awsExocomputeClusterConnect: AwsExocomputeClusterConnectReply! (type)
        public static string AwsExocomputeClusterConnect(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "awsExocomputeClusterConnect" + args + "\n{\n" + fs + "}\n";
        }
        public static object AwsExocomputeClusterConnectFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AwsExocomputeClusterConnectReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestStatus? AzureOauthConsentComplete
        // GraphQL -> azureOauthConsentComplete: RequestStatus! (type)
        public static string AzureOauthConsentComplete(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "azureOauthConsentComplete" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureOauthConsentCompleteFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureOauthConsentKickoffReply? AzureOauthConsentKickoff
        // GraphQL -> azureOauthConsentKickoff: AzureOauthConsentKickoffReply! (type)
        public static string AzureOauthConsentKickoff(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "";
            return "azureOauthConsentKickoff" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureOauthConsentKickoffFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AzureOauthConsentKickoffReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<CreateOnDemandJobReply>? BackupAzureAdDirectory
        // GraphQL -> backupAzureAdDirectory: [CreateOnDemandJobReply!]! (type)
        public static string BackupAzureAdDirectory(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "backupAzureAdDirectory" + args + "\n{\n" + fs + "}\n";
        }
        public static object BackupAzureAdDirectoryFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new List<CreateOnDemandJobReply>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<CreateOnDemandJobReply>? BackupM365Mailbox
        // GraphQL -> backupM365Mailbox: [CreateOnDemandJobReply!]! (type)
        public static string BackupM365Mailbox(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "backupM365Mailbox" + args + "\n{\n" + fs + "}\n";
        }
        public static object BackupM365MailboxFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new List<CreateOnDemandJobReply>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<CreateOnDemandJobReply>? BackupM365Onedrive
        // GraphQL -> backupM365Onedrive: [CreateOnDemandJobReply!]! (type)
        public static string BackupM365Onedrive(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "backupM365Onedrive" + args + "\n{\n" + fs + "}\n";
        }
        public static object BackupM365OnedriveFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new List<CreateOnDemandJobReply>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<CreateOnDemandJobReply>? BackupM365SharepointDrive
        // GraphQL -> backupM365SharepointDrive: [CreateOnDemandJobReply!]! (type)
        public static string BackupM365SharepointDrive(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "backupM365SharepointDrive" + args + "\n{\n" + fs + "}\n";
        }
        public static object BackupM365SharepointDriveFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new List<CreateOnDemandJobReply>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<CreateOnDemandJobReply>? BackupM365Team
        // GraphQL -> backupM365Team: [CreateOnDemandJobReply!]! (type)
        public static string BackupM365Team(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "backupM365Team" + args + "\n{\n" + fs + "}\n";
        }
        public static object BackupM365TeamFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new List<CreateOnDemandJobReply>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? BackupO365Mailbox
        // GraphQL -> backupO365Mailbox: BatchAsyncJobStatus! (type)
        public static string BackupO365Mailbox(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nmailboxIds: $mailboxIds\n)";
            return "backupO365Mailbox" + args + "\n{\n" + fs + "}\n";
        }
        public static object BackupO365MailboxFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? BackupO365Onedrive
        // GraphQL -> backupO365Onedrive: BatchAsyncJobStatus! (type)
        public static string BackupO365Onedrive(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "backupO365Onedrive" + args + "\n{\n" + fs + "}\n";
        }
        public static object BackupO365OnedriveFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? BackupO365SharePointSite
        // GraphQL -> backupO365SharePointSite: CreateOnDemandJobReply! (type)
        public static string BackupO365SharePointSite(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "backupO365SharePointSite" + args + "\n{\n" + fs + "}\n";
        }
        public static object BackupO365SharePointSiteFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? BackupO365SharepointDrive
        // GraphQL -> backupO365SharepointDrive: BatchAsyncJobStatus! (type)
        public static string BackupO365SharepointDrive(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "backupO365SharepointDrive" + args + "\n{\n" + fs + "}\n";
        }
        public static object BackupO365SharepointDriveFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? BackupO365SharepointList
        // GraphQL -> backupO365SharepointList: CreateOnDemandJobReply! (type)
        public static string BackupO365SharepointList(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "backupO365SharepointList" + args + "\n{\n" + fs + "}\n";
        }
        public static object BackupO365SharepointListFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? BackupO365Team
        // GraphQL -> backupO365Team: BatchAsyncJobStatus! (type)
        public static string BackupO365Team(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "backupO365Team" + args + "\n{\n" + fs + "}\n";
        }
        public static object BackupO365TeamFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchExportHypervVmReply? BatchExportHypervVm
        // GraphQL -> batchExportHypervVm: BatchExportHypervVmReply! (type)
        public static string BatchExportHypervVm(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "batchExportHypervVm" + args + "\n{\n" + fs + "}\n";
        }
        public static object BatchExportHypervVmFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchExportHypervVmReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchExportNutanixVmReply? BatchExportNutanixVm
        // GraphQL -> batchExportNutanixVm: BatchExportNutanixVmReply! (type)
        public static string BatchExportNutanixVm(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "batchExportNutanixVm" + args + "\n{\n" + fs + "}\n";
        }
        public static object BatchExportNutanixVmFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchExportNutanixVmReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchInstantRecoverHypervVmReply? BatchInstantRecoverHypervVm
        // GraphQL -> batchInstantRecoverHypervVm: BatchInstantRecoverHypervVmReply! (type)
        public static string BatchInstantRecoverHypervVm(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "batchInstantRecoverHypervVm" + args + "\n{\n" + fs + "}\n";
        }
        public static object BatchInstantRecoverHypervVmFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchInstantRecoverHypervVmReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchMountHypervVmReply? BatchMountHypervVm
        // GraphQL -> batchMountHypervVm: BatchMountHypervVmReply! (type)
        public static string BatchMountHypervVm(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "batchMountHypervVm" + args + "\n{\n" + fs + "}\n";
        }
        public static object BatchMountHypervVmFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchMountHypervVmReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchMountNutanixVmReply? BatchMountNutanixVm
        // GraphQL -> batchMountNutanixVm: BatchMountNutanixVmReply! (type)
        public static string BatchMountNutanixVm(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "batchMountNutanixVm" + args + "\n{\n" + fs + "}\n";
        }
        public static object BatchMountNutanixVmFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchMountNutanixVmReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchOnDemandBackupHypervVmReply? BatchOnDemandBackupHypervVm
        // GraphQL -> batchOnDemandBackupHypervVm: BatchOnDemandBackupHypervVmReply! (type)
        public static string BatchOnDemandBackupHypervVm(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "batchOnDemandBackupHypervVm" + args + "\n{\n" + fs + "}\n";
        }
        public static object BatchOnDemandBackupHypervVmFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchOnDemandBackupHypervVmReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchQuarantineSnapshotReply? BatchQuarantineSnapshot
        // GraphQL -> batchQuarantineSnapshot: BatchQuarantineSnapshotReply! (type)
        public static string BatchQuarantineSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "batchQuarantineSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object BatchQuarantineSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchQuarantineSnapshotReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchReleaseFromQuarantineSnapshotReply? BatchReleaseFromQuarantineSnapshot
        // GraphQL -> batchReleaseFromQuarantineSnapshot: BatchReleaseFromQuarantineSnapshotReply! (type)
        public static string BatchReleaseFromQuarantineSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "batchReleaseFromQuarantineSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object BatchReleaseFromQuarantineSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchReleaseFromQuarantineSnapshotReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchTriggerExocomputeHealthCheckReply? BatchTriggerExocomputeHealthCheck
        // GraphQL -> batchTriggerExocomputeHealthCheck: BatchTriggerExocomputeHealthCheckReply! (type)
        public static string BatchTriggerExocomputeHealthCheck(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "batchTriggerExocomputeHealthCheck" + args + "\n{\n" + fs + "}\n";
        }
        public static object BatchTriggerExocomputeHealthCheckFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchTriggerExocomputeHealthCheckReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BeginManagedVolumeSnapshotReply? BeginManagedVolumeSnapshot
        // GraphQL -> beginManagedVolumeSnapshot: BeginManagedVolumeSnapshotReply! (type)
        public static string BeginManagedVolumeSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "beginManagedVolumeSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object BeginManagedVolumeSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BeginManagedVolumeSnapshotReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BrowseMssqlDatabaseSnapshotReply? BrowseMssqlDatabaseSnapshot
        // GraphQL -> browseMssqlDatabaseSnapshot: BrowseMssqlDatabaseSnapshotReply! (type)
        public static string BrowseMssqlDatabaseSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "browseMssqlDatabaseSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object BrowseMssqlDatabaseSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BrowseMssqlDatabaseSnapshotReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkAddNasSharesReply? BulkAddNasShares
        // GraphQL -> bulkAddNasShares: BulkAddNasSharesReply! (type)
        public static string BulkAddNasShares(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkAddNasShares" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkAddNasSharesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BulkAddNasSharesReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkCreateFilesetTemplatesReply? BulkCreateFilesetTemplates
        // GraphQL -> bulkCreateFilesetTemplates: BulkCreateFilesetTemplatesReply! (type)
        public static string BulkCreateFilesetTemplates(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkCreateFilesetTemplates" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkCreateFilesetTemplatesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BulkCreateFilesetTemplatesReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkCreateFilesetsReply? BulkCreateFilesets
        // GraphQL -> bulkCreateFilesets: BulkCreateFilesetsReply! (type)
        public static string BulkCreateFilesets(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkCreateFilesets" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkCreateFilesetsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BulkCreateFilesetsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkCreateNasFilesetsReply? BulkCreateNasFilesets
        // GraphQL -> bulkCreateNasFilesets: BulkCreateNasFilesetsReply! (type)
        public static string BulkCreateNasFilesets(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkCreateNasFilesets" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkCreateNasFilesetsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BulkCreateNasFilesetsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? BulkCreateOnDemandMssqlBackup
        // GraphQL -> bulkCreateOnDemandMssqlBackup: AsyncRequestStatus! (type)
        public static string BulkCreateOnDemandMssqlBackup(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkCreateOnDemandMssqlBackup" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkCreateOnDemandMssqlBackupFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkDeleteAwsCloudAccountWithoutCftReply? BulkDeleteAwsCloudAccountWithoutCft
        // GraphQL -> bulkDeleteAwsCloudAccountWithoutCft: BulkDeleteAwsCloudAccountWithoutCftReply! (type)
        public static string BulkDeleteAwsCloudAccountWithoutCft(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkDeleteAwsCloudAccountWithoutCft" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkDeleteAwsCloudAccountWithoutCftFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BulkDeleteAwsCloudAccountWithoutCftReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicAsyncResponse? BulkDeleteCassandraSources
        // GraphQL -> bulkDeleteCassandraSources: MosaicAsyncResponse! (type)
        public static string BulkDeleteCassandraSources(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkDeleteCassandraSources" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkDeleteCassandraSourcesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new MosaicAsyncResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? BulkDeleteFailoverCluster
        // GraphQL -> bulkDeleteFailoverCluster: ResponseSuccess! (type)
        public static string BulkDeleteFailoverCluster(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkDeleteFailoverCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkDeleteFailoverClusterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? BulkDeleteFailoverClusterApp
        // GraphQL -> bulkDeleteFailoverClusterApp: ResponseSuccess! (type)
        public static string BulkDeleteFailoverClusterApp(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkDeleteFailoverClusterApp" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkDeleteFailoverClusterAppFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? BulkDeleteFileset
        // GraphQL -> bulkDeleteFileset: ResponseSuccess! (type)
        public static string BulkDeleteFileset(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkDeleteFileset" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkDeleteFilesetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? BulkDeleteFilesetTemplate
        // GraphQL -> bulkDeleteFilesetTemplate: ResponseSuccess! (type)
        public static string BulkDeleteFilesetTemplate(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkDeleteFilesetTemplate" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkDeleteFilesetTemplateFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? BulkDeleteHost
        // GraphQL -> bulkDeleteHost: ResponseSuccess! (type)
        public static string BulkDeleteHost(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkDeleteHost" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkDeleteHostFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicAsyncResponse? BulkDeleteMongodbSources
        // GraphQL -> bulkDeleteMongodbSources: MosaicAsyncResponse! (type)
        public static string BulkDeleteMongodbSources(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkDeleteMongodbSources" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkDeleteMongodbSourcesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new MosaicAsyncResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncRequestStatus? BulkDeleteNasSystems
        // GraphQL -> bulkDeleteNasSystems: BatchAsyncRequestStatus! (type)
        public static string BulkDeleteNasSystems(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkDeleteNasSystems" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkDeleteNasSystemsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchAsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? BulkExportMssqlDatabases
        // GraphQL -> bulkExportMssqlDatabases: AsyncRequestStatus! (type)
        public static string BulkExportMssqlDatabases(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkExportMssqlDatabases" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkExportMssqlDatabasesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkOnDemandSnapshotNutanixVmReply? BulkOnDemandSnapshotNutanixVm
        // GraphQL -> bulkOnDemandSnapshotNutanixVm: BulkOnDemandSnapshotNutanixVmReply! (type)
        public static string BulkOnDemandSnapshotNutanixVm(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkOnDemandSnapshotNutanixVm" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkOnDemandSnapshotNutanixVmFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BulkOnDemandSnapshotNutanixVmReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? BulkRecoverSapHanaDatabases
        // GraphQL -> bulkRecoverSapHanaDatabases: AsyncRequestStatus! (type)
        public static string BulkRecoverSapHanaDatabases(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkRecoverSapHanaDatabases" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkRecoverSapHanaDatabasesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkRefreshHostsReply? BulkRefreshHosts
        // GraphQL -> bulkRefreshHosts: BulkRefreshHostsReply! (type)
        public static string BulkRefreshHosts(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkRefreshHosts" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkRefreshHostsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BulkRefreshHostsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkRegisterHostReply? BulkRegisterHost
        // GraphQL -> bulkRegisterHost: BulkRegisterHostReply! (type)
        public static string BulkRegisterHost(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkRegisterHost" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkRegisterHostFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BulkRegisterHostReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkRegisterHostAsyncReply? BulkRegisterHostAsync
        // GraphQL -> bulkRegisterHostAsync: BulkRegisterHostAsyncReply! (type)
        public static string BulkRegisterHostAsync(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkRegisterHostAsync" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkRegisterHostAsyncFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BulkRegisterHostAsyncReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? BulkTierExistingSnapshots
        // GraphQL -> bulkTierExistingSnapshots: AsyncRequestStatus! (type)
        public static string BulkTierExistingSnapshots(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkTierExistingSnapshots" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkTierExistingSnapshotsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> V1BulkUpdateExchangeDagResponse? BulkUpdateExchangeDag
        // GraphQL -> bulkUpdateExchangeDag: V1BulkUpdateExchangeDagResponse! (type)
        public static string BulkUpdateExchangeDag(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkUpdateExchangeDag" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkUpdateExchangeDagFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new V1BulkUpdateExchangeDagResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkUpdateFilesetTemplateReply? BulkUpdateFilesetTemplate
        // GraphQL -> bulkUpdateFilesetTemplate: BulkUpdateFilesetTemplateReply! (type)
        public static string BulkUpdateFilesetTemplate(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkUpdateFilesetTemplate" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkUpdateFilesetTemplateFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BulkUpdateFilesetTemplateReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkUpdateHostReply? BulkUpdateHost
        // GraphQL -> bulkUpdateHost: BulkUpdateHostReply! (type)
        public static string BulkUpdateHost(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkUpdateHost" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkUpdateHostFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BulkUpdateHostReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkUpdateMssqlAvailabilityGroupReply? BulkUpdateMssqlAvailabilityGroup
        // GraphQL -> bulkUpdateMssqlAvailabilityGroup: BulkUpdateMssqlAvailabilityGroupReply! (type)
        public static string BulkUpdateMssqlAvailabilityGroup(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkUpdateMssqlAvailabilityGroup" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkUpdateMssqlAvailabilityGroupFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BulkUpdateMssqlAvailabilityGroupReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkUpdateMssqlDbsReply? BulkUpdateMssqlDbs
        // GraphQL -> bulkUpdateMssqlDbs: BulkUpdateMssqlDbsReply! (type)
        public static string BulkUpdateMssqlDbs(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkUpdateMssqlDbs" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkUpdateMssqlDbsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BulkUpdateMssqlDbsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkUpdateMssqlInstanceReply? BulkUpdateMssqlInstance
        // GraphQL -> bulkUpdateMssqlInstance: BulkUpdateMssqlInstanceReply! (type)
        public static string BulkUpdateMssqlInstance(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkUpdateMssqlInstance" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkUpdateMssqlInstanceFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BulkUpdateMssqlInstanceReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkUpdateMssqlPropertiesOnHostReply? BulkUpdateMssqlPropertiesOnHost
        // GraphQL -> bulkUpdateMssqlPropertiesOnHost: BulkUpdateMssqlPropertiesOnHostReply! (type)
        public static string BulkUpdateMssqlPropertiesOnHost(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkUpdateMssqlPropertiesOnHost" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkUpdateMssqlPropertiesOnHostFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BulkUpdateMssqlPropertiesOnHostReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkUpdateMssqlPropertiesOnWindowsClusterReply? BulkUpdateMssqlPropertiesOnWindowsCluster
        // GraphQL -> bulkUpdateMssqlPropertiesOnWindowsCluster: BulkUpdateMssqlPropertiesOnWindowsClusterReply! (type)
        public static string BulkUpdateMssqlPropertiesOnWindowsCluster(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkUpdateMssqlPropertiesOnWindowsCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkUpdateMssqlPropertiesOnWindowsClusterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BulkUpdateMssqlPropertiesOnWindowsClusterReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkUpdateNasSharesReply? BulkUpdateNasShares
        // GraphQL -> bulkUpdateNasShares: BulkUpdateNasSharesReply! (type)
        public static string BulkUpdateNasShares(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkUpdateNasShares" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkUpdateNasSharesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BulkUpdateNasSharesReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkUpdateOracleDatabasesReply? BulkUpdateOracleDatabases
        // GraphQL -> bulkUpdateOracleDatabases: BulkUpdateOracleDatabasesReply! (type)
        public static string BulkUpdateOracleDatabases(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkUpdateOracleDatabases" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkUpdateOracleDatabasesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BulkUpdateOracleDatabasesReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkUpdateOracleHostsReply? BulkUpdateOracleHosts
        // GraphQL -> bulkUpdateOracleHosts: BulkUpdateOracleHostsReply! (type)
        public static string BulkUpdateOracleHosts(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkUpdateOracleHosts" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkUpdateOracleHostsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BulkUpdateOracleHostsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkUpdateOracleRacsReply? BulkUpdateOracleRacs
        // GraphQL -> bulkUpdateOracleRacs: BulkUpdateOracleRacsReply! (type)
        public static string BulkUpdateOracleRacs(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "bulkUpdateOracleRacs" + args + "\n{\n" + fs + "}\n";
        }
        public static object BulkUpdateOracleRacsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BulkUpdateOracleRacsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CancelJobReply? CancelDownloadPackage
        // GraphQL -> cancelDownloadPackage: CancelJobReply! (type)
        public static string CancelDownloadPackage(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            return "cancelDownloadPackage" + args + "\n{\n" + fs + "}\n";
        }
        public static object CancelDownloadPackageFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CancelJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CancelJobReply? CancelScheduledUpgrade
        // GraphQL -> cancelScheduledUpgrade: CancelJobReply! (type)
        public static string CancelScheduledUpgrade(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            return "cancelScheduledUpgrade" + args + "\n{\n" + fs + "}\n";
        }
        public static object CancelScheduledUpgradeFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CancelJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestStatus? CancelTaskchain
        // GraphQL -> cancelTaskchain: RequestStatus! (type)
        public static string CancelTaskchain(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ntaskchainId: $taskchainId\n)";
            return "cancelTaskchain" + args + "\n{\n" + fs + "}\n";
        }
        public static object CancelTaskchainFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ChangeVfdOnHostReply? ChangeVfdOnHost
        // GraphQL -> changeVfdOnHost: ChangeVfdOnHostReply! (type)
        public static string ChangeVfdOnHost(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "changeVfdOnHost" + args + "\n{\n" + fs + "}\n";
        }
        public static object ChangeVfdOnHostFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ChangeVfdOnHostReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ClearCloudNativeSqlServerBackupCredentialsReply? ClearCloudNativeSqlServerBackupCredentials
        // GraphQL -> clearCloudNativeSqlServerBackupCredentials: ClearCloudNativeSqlServerBackupCredentialsReply! (type)
        public static string ClearCloudNativeSqlServerBackupCredentials(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "clearCloudNativeSqlServerBackupCredentials" + args + "\n{\n" + fs + "}\n";
        }
        public static object ClearCloudNativeSqlServerBackupCredentialsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ClearCloudNativeSqlServerBackupCredentialsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ClearHostRbsNetworkLimitReply? ClearHostRbsNetworkLimit
        // GraphQL -> clearHostRbsNetworkLimit: ClearHostRbsNetworkLimitReply! (type)
        public static string ClearHostRbsNetworkLimit(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "clearHostRbsNetworkLimit" + args + "\n{\n" + fs + "}\n";
        }
        public static object ClearHostRbsNetworkLimitFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ClearHostRbsNetworkLimitReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CloudNativeCheckRbaConnectivityReply? CloudNativeCheckRbaConnectivity
        // GraphQL -> cloudNativeCheckRbaConnectivity: CloudNativeCheckRbaConnectivityReply! (type)
        public static string CloudNativeCheckRbaConnectivity(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "cloudNativeCheckRbaConnectivity" + args + "\n{\n" + fs + "}\n";
        }
        public static object CloudNativeCheckRbaConnectivityFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CloudNativeCheckRbaConnectivityReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DownloadFilesReply? CloudNativeDownloadFiles
        // GraphQL -> cloudNativeDownloadFiles: DownloadFilesReply! (type)
        public static string CloudNativeDownloadFiles(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "cloudNativeDownloadFiles" + args + "\n{\n" + fs + "}\n";
        }
        public static object CloudNativeDownloadFilesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new DownloadFilesReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CompleteAzureAdAppSetupReply? CompleteAzureAdAppSetup
        // GraphQL -> completeAzureAdAppSetup: CompleteAzureAdAppSetupReply! (type)
        public static string CompleteAzureAdAppSetup(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "completeAzureAdAppSetup" + args + "\n{\n" + fs + "}\n";
        }
        public static object CompleteAzureAdAppSetupFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CompleteAzureAdAppSetupReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CompleteAzureCloudAccountOauthReply? CompleteAzureCloudAccountOauth
        // GraphQL -> completeAzureCloudAccountOauth: CompleteAzureCloudAccountOauthReply! (type)
        public static string CompleteAzureCloudAccountOauth(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "completeAzureCloudAccountOauth" + args + "\n{\n" + fs + "}\n";
        }
        public static object CompleteAzureCloudAccountOauthFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CompleteAzureCloudAccountOauthReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CompleteUploadSessionReply? CompleteUploadSession
        // GraphQL -> completeUploadSession: CompleteUploadSessionReply! (type)
        public static string CompleteUploadSession(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "completeUploadSession" + args + "\n{\n" + fs + "}\n";
        }
        public static object CompleteUploadSessionFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CompleteUploadSessionReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Db2ConfigureRestoreResponse? ConfigureDb2Restore
        // GraphQL -> configureDb2Restore: Db2ConfigureRestoreResponse! (type)
        public static string ConfigureDb2Restore(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "configureDb2Restore" + args + "\n{\n" + fs + "}\n";
        }
        public static object ConfigureDb2RestoreFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new Db2ConfigureRestoreResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ConfigureSapHanaRestore
        // GraphQL -> configureSapHanaRestore: AsyncRequestStatus! (type)
        public static string ConfigureSapHanaRestore(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "configureSapHanaRestore" + args + "\n{\n" + fs + "}\n";
        }
        public static object ConfigureSapHanaRestoreFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ConfirmPartUploadReply? ConfirmPartUpload
        // GraphQL -> confirmPartUpload: ConfirmPartUploadReply! (type)
        public static string ConfirmPartUpload(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "confirmPartUpload" + args + "\n{\n" + fs + "}\n";
        }
        public static object ConfirmPartUploadFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ConfirmPartUploadReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateActiveDirectoryLiveMount
        // GraphQL -> createActiveDirectoryLiveMount: AsyncRequestStatus! (type)
        public static string CreateActiveDirectoryLiveMount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createActiveDirectoryLiveMount" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateActiveDirectoryLiveMountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateActiveDirectoryUnmount
        // GraphQL -> createActiveDirectoryUnmount: AsyncRequestStatus! (type)
        public static string CreateActiveDirectoryUnmount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createActiveDirectoryUnmount" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateActiveDirectoryUnmountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TargetMapping? CreateAutomaticAwsTargetMapping
        // GraphQL -> createAutomaticAwsTargetMapping: TargetMapping! (type)
        public static string CreateAutomaticAwsTargetMapping(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createAutomaticAwsTargetMapping" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateAutomaticAwsTargetMappingFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new TargetMapping() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TargetMapping? CreateAutomaticAzureTargetMapping
        // GraphQL -> createAutomaticAzureTargetMapping: TargetMapping! (type)
        public static string CreateAutomaticAzureTargetMapping(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createAutomaticAzureTargetMapping" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateAutomaticAzureTargetMappingFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new TargetMapping() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TargetMapping? CreateAutomaticRcsTargetMapping
        // GraphQL -> createAutomaticRcsTargetMapping: TargetMapping! (type)
        public static string CreateAutomaticRcsTargetMapping(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createAutomaticRcsTargetMapping" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateAutomaticRcsTargetMappingFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new TargetMapping() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CcProvisionJobReply? CreateAwsCluster
        // GraphQL -> createAwsCluster: CcProvisionJobReply! (type)
        public static string CreateAwsCluster(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createAwsCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateAwsClusterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CcProvisionJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsComputeSettings? CreateAwsComputeSetting
        // GraphQL -> createAwsComputeSetting: AwsComputeSettings! (type)
        public static string CreateAwsComputeSetting(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createAwsComputeSetting" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateAwsComputeSettingFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AwsComputeSettings() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateAwsExocomputeConfigsReply? CreateAwsExocomputeConfigs
        // GraphQL -> createAwsExocomputeConfigs: CreateAwsExocomputeConfigsReply! (type)
        public static string CreateAwsExocomputeConfigs(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createAwsExocomputeConfigs" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateAwsExocomputeConfigsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateAwsExocomputeConfigsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CcProvisionJobReply? CreateAzureCluster
        // GraphQL -> createAzureCluster: CcProvisionJobReply! (type)
        public static string CreateAzureCluster(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createAzureCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateAzureClusterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CcProvisionJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateAzureSaasAppAadReply? CreateAzureSaasAppAad
        // GraphQL -> createAzureSaasAppAad: CreateAzureSaasAppAadReply! (type)
        public static string CreateAzureSaasAppAad(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "";
            return "createAzureSaasAppAad" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateAzureSaasAppAadFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateAzureSaasAppAadReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicAsyncResponse? CreateCassandraSource
        // GraphQL -> createCassandraSource: MosaicAsyncResponse! (type)
        public static string CreateCassandraSource(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createCassandraSource" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateCassandraSourceFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new MosaicAsyncResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateCloudNativeAwsStorageSettingReply? CreateCloudNativeAwsStorageSetting
        // GraphQL -> createCloudNativeAwsStorageSetting: CreateCloudNativeAwsStorageSettingReply! (type)
        public static string CreateCloudNativeAwsStorageSetting(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createCloudNativeAwsStorageSetting" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateCloudNativeAwsStorageSettingFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateCloudNativeAwsStorageSettingReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateCloudNativeAzureStorageSettingReply? CreateCloudNativeAzureStorageSetting
        // GraphQL -> createCloudNativeAzureStorageSetting: CreateCloudNativeAzureStorageSettingReply! (type)
        public static string CreateCloudNativeAzureStorageSetting(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createCloudNativeAzureStorageSetting" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateCloudNativeAzureStorageSettingFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateCloudNativeAzureStorageSettingReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateCloudNativeLabelRuleReply? CreateCloudNativeLabelRule
        // GraphQL -> createCloudNativeLabelRule: CreateCloudNativeLabelRuleReply! (type)
        public static string CreateCloudNativeLabelRule(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createCloudNativeLabelRule" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateCloudNativeLabelRuleFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateCloudNativeLabelRuleReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateCloudNativeRcvAzureStorageSettingReply? CreateCloudNativeRcvAzureStorageSetting
        // GraphQL -> createCloudNativeRcvAzureStorageSetting: CreateCloudNativeRcvAzureStorageSettingReply! (type)
        public static string CreateCloudNativeRcvAzureStorageSetting(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createCloudNativeRcvAzureStorageSetting" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateCloudNativeRcvAzureStorageSettingFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateCloudNativeRcvAzureStorageSettingReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateCloudNativeTagRuleReply? CreateCloudNativeTagRule
        // GraphQL -> createCloudNativeTagRule: CreateCloudNativeTagRuleReply! (type)
        public static string CreateCloudNativeTagRule(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createCloudNativeTagRule" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateCloudNativeTagRuleFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateCloudNativeTagRuleReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateCrossAccountRegOauthPayloadReply? CreateCrossAccountRegOauthPayload
        // GraphQL -> createCrossAccountRegOauthPayload: CreateCrossAccountRegOauthPayloadReply! (type)
        public static string CreateCrossAccountRegOauthPayload(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createCrossAccountRegOauthPayload" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateCrossAccountRegOauthPayloadFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateCrossAccountRegOauthPayloadReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Analyzer? CreateCustomAnalyzer
        // GraphQL -> createCustomAnalyzer: Analyzer! (type)
        public static string CreateCustomAnalyzer(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createCustomAnalyzer" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateCustomAnalyzerFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new Analyzer() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateCustomReportReply? CreateCustomReport
        // GraphQL -> createCustomReport: CreateCustomReportReply! (type)
        public static string CreateCustomReport(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\nreportRoom: $reportRoom\n)";
            return "createCustomReport" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateCustomReportFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateCustomReportReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateDomainControllerSnapshot
        // GraphQL -> createDomainControllerSnapshot: AsyncRequestStatus! (type)
        public static string CreateDomainControllerSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createDomainControllerSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateDomainControllerSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateDownloadSnapshotForVolumeGroup
        // GraphQL -> createDownloadSnapshotForVolumeGroup: AsyncRequestStatus! (type)
        public static string CreateDownloadSnapshotForVolumeGroup(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createDownloadSnapshotForVolumeGroup" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateDownloadSnapshotForVolumeGroupFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateExchangeMount
        // GraphQL -> createExchangeMount: AsyncRequestStatus! (type)
        public static string CreateExchangeMount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createExchangeMount" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateExchangeMountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateFailoverClusterReply? CreateFailoverCluster
        // GraphQL -> createFailoverCluster: CreateFailoverClusterReply! (type)
        public static string CreateFailoverCluster(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createFailoverCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateFailoverClusterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateFailoverClusterReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateFailoverClusterAppReply? CreateFailoverClusterApp
        // GraphQL -> createFailoverClusterApp: CreateFailoverClusterAppReply! (type)
        public static string CreateFailoverClusterApp(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createFailoverClusterApp" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateFailoverClusterAppFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateFailoverClusterAppReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateFilesetSnapshot
        // GraphQL -> createFilesetSnapshot: AsyncRequestStatus! (type)
        public static string CreateFilesetSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createFilesetSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateFilesetSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GlobalSlaReply? CreateGlobalSla
        // GraphQL -> createGlobalSla: GlobalSlaReply! (type)
        public static string CreateGlobalSla(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createGlobalSla" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateGlobalSlaFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new GlobalSlaReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateGuestCredentialReply? CreateGuestCredential
        // GraphQL -> createGuestCredential: CreateGuestCredentialReply! (type)
        public static string CreateGuestCredential(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createGuestCredential" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateGuestCredentialFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateGuestCredentialReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateHypervVirtualMachineSnapshotDiskMount
        // GraphQL -> createHypervVirtualMachineSnapshotDiskMount: AsyncRequestStatus! (type)
        public static string CreateHypervVirtualMachineSnapshotDiskMount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createHypervVirtualMachineSnapshotDiskMount" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateHypervVirtualMachineSnapshotDiskMountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateHypervVirtualMachineSnapshotMount
        // GraphQL -> createHypervVirtualMachineSnapshotMount: AsyncRequestStatus! (type)
        public static string CreateHypervVirtualMachineSnapshotMount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createHypervVirtualMachineSnapshotMount" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateHypervVirtualMachineSnapshotMountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateIntegrationReply? CreateIntegration
        // GraphQL -> createIntegration: CreateIntegrationReply! (type)
        public static string CreateIntegration(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createIntegration" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateIntegrationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateIntegrationReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateIntegrationsReply? CreateIntegrations
        // GraphQL -> createIntegrations: CreateIntegrationsReply! (type)
        public static string CreateIntegrations(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createIntegrations" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateIntegrationsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateIntegrationsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateK8sAgentManifestReply? CreateK8sAgentManifest
        // GraphQL -> createK8sAgentManifest: CreateK8sAgentManifestReply! (type)
        public static string CreateK8sAgentManifest(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createK8sAgentManifest" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateK8sAgentManifestFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateK8sAgentManifestReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateK8sClusterReply? CreateK8sCluster
        // GraphQL -> createK8sCluster: CreateK8sClusterReply! (type)
        public static string CreateK8sCluster(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createK8sCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateK8sClusterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateK8sClusterReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<CreateOnDemandJobReply>? CreateK8sNamespaceSnapshots
        // GraphQL -> createK8sNamespaceSnapshots: [CreateOnDemandJobReply!]! (type)
        public static string CreateK8sNamespaceSnapshots(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createK8sNamespaceSnapshots" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateK8sNamespaceSnapshotsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new List<CreateOnDemandJobReply>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateK8sProtectionSetSnapshot
        // GraphQL -> createK8sProtectionSetSnapshot: AsyncRequestStatus! (type)
        public static string CreateK8sProtectionSetSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createK8sProtectionSetSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateK8sProtectionSetSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateLegalHoldReply? CreateLegalHold
        // GraphQL -> createLegalHold: CreateLegalHoldReply! (type)
        public static string CreateLegalHold(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createLegalHold" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateLegalHoldFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateLegalHoldReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TargetMapping? CreateManualTargetMapping
        // GraphQL -> createManualTargetMapping: TargetMapping! (type)
        public static string CreateManualTargetMapping(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createManualTargetMapping" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateManualTargetMappingFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new TargetMapping() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicAsyncResponse? CreateMongodbSource
        // GraphQL -> createMongodbSource: MosaicAsyncResponse! (type)
        public static string CreateMongodbSource(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createMongodbSource" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateMongodbSourceFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new MosaicAsyncResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateMssqlLiveMount
        // GraphQL -> createMssqlLiveMount: AsyncRequestStatus! (type)
        public static string CreateMssqlLiveMount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createMssqlLiveMount" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateMssqlLiveMountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateMssqlLogShippingConfiguration
        // GraphQL -> createMssqlLogShippingConfiguration: AsyncRequestStatus! (type)
        public static string CreateMssqlLogShippingConfiguration(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createMssqlLogShippingConfiguration" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateMssqlLogShippingConfigurationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateNutanixCluster
        // GraphQL -> createNutanixCluster: AsyncRequestStatus! (type)
        public static string CreateNutanixCluster(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createNutanixCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateNutanixClusterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncRequestStatus? CreateNutanixPrismCentral
        // GraphQL -> createNutanixPrismCentral: BatchAsyncRequestStatus! (type)
        public static string CreateNutanixPrismCentral(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createNutanixPrismCentral" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateNutanixPrismCentralFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchAsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestStatus? CreateO365AppComplete
        // GraphQL -> createO365AppComplete: RequestStatus! (type)
        public static string CreateO365AppComplete(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createO365AppComplete" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateO365AppCompleteFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateO365AppKickoffResp? CreateO365AppKickoff
        // GraphQL -> createO365AppKickoff: CreateO365AppKickoffResp! (type)
        public static string CreateO365AppKickoff(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createO365AppKickoff" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateO365AppKickoffFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateO365AppKickoffResp() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandDb2Backup
        // GraphQL -> createOnDemandDb2Backup: AsyncRequestStatus! (type)
        public static string CreateOnDemandDb2Backup(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createOnDemandDb2Backup" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateOnDemandDb2BackupFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandExchangeBackup
        // GraphQL -> createOnDemandExchangeBackup: AsyncRequestStatus! (type)
        public static string CreateOnDemandExchangeBackup(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createOnDemandExchangeBackup" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateOnDemandExchangeBackupFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandMssqlBackup
        // GraphQL -> createOnDemandMssqlBackup: AsyncRequestStatus! (type)
        public static string CreateOnDemandMssqlBackup(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createOnDemandMssqlBackup" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateOnDemandMssqlBackupFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandNutanixBackup
        // GraphQL -> createOnDemandNutanixBackup: AsyncRequestStatus! (type)
        public static string CreateOnDemandNutanixBackup(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createOnDemandNutanixBackup" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateOnDemandNutanixBackupFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandSapHanaBackup
        // GraphQL -> createOnDemandSapHanaBackup: AsyncRequestStatus! (type)
        public static string CreateOnDemandSapHanaBackup(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createOnDemandSapHanaBackup" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateOnDemandSapHanaBackupFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandSapHanaDataBackup
        // GraphQL -> createOnDemandSapHanaDataBackup: AsyncRequestStatus! (type)
        public static string CreateOnDemandSapHanaDataBackup(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createOnDemandSapHanaDataBackup" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateOnDemandSapHanaDataBackupFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandSapHanaStorageSnapshot
        // GraphQL -> createOnDemandSapHanaStorageSnapshot: AsyncRequestStatus! (type)
        public static string CreateOnDemandSapHanaStorageSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createOnDemandSapHanaStorageSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateOnDemandSapHanaStorageSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandVolumeGroupBackup
        // GraphQL -> createOnDemandVolumeGroupBackup: AsyncRequestStatus! (type)
        public static string CreateOnDemandVolumeGroupBackup(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createOnDemandVolumeGroupBackup" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateOnDemandVolumeGroupBackupFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateOraclePdbRestore
        // GraphQL -> createOraclePdbRestore: AsyncRequestStatus! (type)
        public static string CreateOraclePdbRestore(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createOraclePdbRestore" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateOraclePdbRestoreFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOrgReply? CreateOrg
        // GraphQL -> createOrg: CreateOrgReply! (type)
        public static string CreateOrg(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createOrg" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateOrgFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateOrgReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOrgSwitchSessionReply? CreateOrgSwitchSession
        // GraphQL -> createOrgSwitchSession: CreateOrgSwitchSessionReply! (type)
        public static string CreateOrgSwitchSession(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createOrgSwitchSession" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateOrgSwitchSessionFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateOrgSwitchSessionReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ClassificationPolicyDetail? CreatePolicy
        // GraphQL -> createPolicy: ClassificationPolicyDetail! (type)
        public static string CreatePolicy(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createPolicy" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreatePolicyFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ClassificationPolicyDetail() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateRcvPrivateEndpointApprovalRequestReply? CreateRcvPrivateEndpointApprovalRequest
        // GraphQL -> createRcvPrivateEndpointApprovalRequest: CreateRcvPrivateEndpointApprovalRequestReply! (type)
        public static string CreateRcvPrivateEndpointApprovalRequest(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createRcvPrivateEndpointApprovalRequest" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateRcvPrivateEndpointApprovalRequestFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateRcvPrivateEndpointApprovalRequestReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateSapHanaSystemRefresh
        // GraphQL -> createSapHanaSystemRefresh: AsyncRequestStatus! (type)
        public static string CreateSapHanaSystemRefresh(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createSapHanaSystemRefresh" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateSapHanaSystemRefreshFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateScheduledReportReply? CreateScheduledReport
        // GraphQL -> createScheduledReport: CreateScheduledReportReply! (type)
        public static string CreateScheduledReport(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createScheduledReport" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateScheduledReportFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateScheduledReportReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateServiceAccountReply? CreateServiceAccount
        // GraphQL -> createServiceAccount: CreateServiceAccountReply! (type)
        public static string CreateServiceAccount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createServiceAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateServiceAccountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateServiceAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateSsoUsersReply? CreateSsoUsers
        // GraphQL -> createSsoUsers: CreateSsoUsersReply! (type)
        public static string CreateSsoUsers(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createSsoUsers" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateSsoUsersFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateSsoUsersReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateTprPolicyReply? CreateTprPolicy
        // GraphQL -> createTprPolicy: CreateTprPolicyReply! (type)
        public static string CreateTprPolicy(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createTprPolicy" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateTprPolicyFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateTprPolicyReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateVappSnapshotsReply? CreateVappSnapshots
        // GraphQL -> createVappSnapshots: CreateVappSnapshotsReply! (type)
        public static string CreateVappSnapshots(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createVappSnapshots" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateVappSnapshotsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateVappSnapshotsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateVappsInstantRecoveryReply? CreateVappsInstantRecovery
        // GraphQL -> createVappsInstantRecovery: CreateVappsInstantRecoveryReply! (type)
        public static string CreateVappsInstantRecovery(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createVappsInstantRecovery" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateVappsInstantRecoveryFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateVappsInstantRecoveryReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateVsphereAdvancedTagReply? CreateVsphereAdvancedTag
        // GraphQL -> createVsphereAdvancedTag: CreateVsphereAdvancedTagReply! (type)
        public static string CreateVsphereAdvancedTag(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createVsphereAdvancedTag" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateVsphereAdvancedTagFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateVsphereAdvancedTagReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateVsphereVcenterReply? CreateVsphereVcenter
        // GraphQL -> createVsphereVcenter: CreateVsphereVcenterReply! (type)
        public static string CreateVsphereVcenter(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createVsphereVcenter" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateVsphereVcenterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateVsphereVcenterReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateWebhookReply? CreateWebhook
        // GraphQL -> createWebhook: CreateWebhookReply! (type)
        public static string CreateWebhook(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createWebhook" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateWebhookFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateWebhookReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateWebhookV2Reply? CreateWebhookV2
        // GraphQL -> createWebhookV2: CreateWebhookV2Reply! (type)
        public static string CreateWebhookV2(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "createWebhookV2" + args + "\n{\n" + fs + "}\n";
        }
        public static object CreateWebhookV2FieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateWebhookV2Reply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestStatus? DeleteAdGroupsFromHierarchy
        // GraphQL -> deleteAdGroupsFromHierarchy: RequestStatus! (type)
        public static string DeleteAdGroupsFromHierarchy(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteAdGroupsFromHierarchy" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteAdGroupsFromHierarchyFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DeleteAwsExocomputeConfigsReply? DeleteAwsExocomputeConfigs
        // GraphQL -> deleteAwsExocomputeConfigs: DeleteAwsExocomputeConfigsReply! (type)
        public static string DeleteAwsExocomputeConfigs(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteAwsExocomputeConfigs" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteAwsExocomputeConfigsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new DeleteAwsExocomputeConfigsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? DeleteAzureAdDirectory
        // GraphQL -> deleteAzureAdDirectory: CreateOnDemandJobReply! (type)
        public static string DeleteAzureAdDirectory(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteAzureAdDirectory" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteAzureAdDirectoryFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DeleteAzureCloudAccountReply? DeleteAzureCloudAccount
        // GraphQL -> deleteAzureCloudAccount: DeleteAzureCloudAccountReply! (type)
        public static string DeleteAzureCloudAccount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteAzureCloudAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteAzureCloudAccountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new DeleteAzureCloudAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DeleteAzureCloudAccountExocomputeConfigurationsReply? DeleteAzureCloudAccountExocomputeConfigurations
        // GraphQL -> deleteAzureCloudAccountExocomputeConfigurations: DeleteAzureCloudAccountExocomputeConfigurationsReply! (type)
        public static string DeleteAzureCloudAccountExocomputeConfigurations(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteAzureCloudAccountExocomputeConfigurations" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteAzureCloudAccountExocomputeConfigurationsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new DeleteAzureCloudAccountExocomputeConfigurationsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DeleteAzureCloudAccountWithoutOauthReply? DeleteAzureCloudAccountWithoutOauth
        // GraphQL -> deleteAzureCloudAccountWithoutOauth: DeleteAzureCloudAccountWithoutOauthReply! (type)
        public static string DeleteAzureCloudAccountWithoutOauth(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteAzureCloudAccountWithoutOauth" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteAzureCloudAccountWithoutOauthFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new DeleteAzureCloudAccountWithoutOauthReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicAsyncResponse? DeleteCassandraSource
        // GraphQL -> deleteCassandraSource: MosaicAsyncResponse! (type)
        public static string DeleteCassandraSource(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteCassandraSource" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteCassandraSourceFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new MosaicAsyncResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteDb2Database
        // GraphQL -> deleteDb2Database: AsyncRequestStatus! (type)
        public static string DeleteDb2Database(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteDb2Database" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteDb2DatabaseFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteDb2Instance
        // GraphQL -> deleteDb2Instance: AsyncRequestStatus! (type)
        public static string DeleteDb2Instance(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteDb2Instance" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteDb2InstanceFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteExchangeSnapshotMount
        // GraphQL -> deleteExchangeSnapshotMount: AsyncRequestStatus! (type)
        public static string DeleteExchangeSnapshotMount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteExchangeSnapshotMount" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteExchangeSnapshotMountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? DeleteFailoverCluster
        // GraphQL -> deleteFailoverCluster: ResponseSuccess! (type)
        public static string DeleteFailoverCluster(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteFailoverCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteFailoverClusterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? DeleteFailoverClusterApp
        // GraphQL -> deleteFailoverClusterApp: ResponseSuccess! (type)
        public static string DeleteFailoverClusterApp(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteFailoverClusterApp" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteFailoverClusterAppFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? DeleteFilesetSnapshots
        // GraphQL -> deleteFilesetSnapshots: ResponseSuccess! (type)
        public static string DeleteFilesetSnapshots(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteFilesetSnapshots" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteFilesetSnapshotsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DeleteGlobalCertificateReply? DeleteGlobalCertificate
        // GraphQL -> deleteGlobalCertificate: DeleteGlobalCertificateReply! (type)
        public static string DeleteGlobalCertificate(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteGlobalCertificate" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteGlobalCertificateFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new DeleteGlobalCertificateReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SlaResult? DeleteGlobalSla
        // GraphQL -> deleteGlobalSla: SlaResult! (type)
        public static string DeleteGlobalSla(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nid: $id\nuserNote: $userNote\n)";
            return "deleteGlobalSla" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteGlobalSlaFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new SlaResult() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? DeleteHypervVirtualMachineSnapshot
        // GraphQL -> deleteHypervVirtualMachineSnapshot: RequestSuccess! (type)
        public static string DeleteHypervVirtualMachineSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteHypervVirtualMachineSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteHypervVirtualMachineSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteHypervVirtualMachineSnapshotMount
        // GraphQL -> deleteHypervVirtualMachineSnapshotMount: AsyncRequestStatus! (type)
        public static string DeleteHypervVirtualMachineSnapshotMount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteHypervVirtualMachineSnapshotMount" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteHypervVirtualMachineSnapshotMountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteK8sCluster
        // GraphQL -> deleteK8sCluster: AsyncRequestStatus! (type)
        public static string DeleteK8sCluster(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteK8sCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteK8sClusterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? DeleteK8sProtectionSet
        // GraphQL -> deleteK8sProtectionSet: ResponseSuccess! (type)
        public static string DeleteK8sProtectionSet(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteK8sProtectionSet" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteK8sProtectionSetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteLogShipping
        // GraphQL -> deleteLogShipping: AsyncRequestStatus! (type)
        public static string DeleteLogShipping(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteLogShipping" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteLogShippingFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DeleteManagedVolumeReply? DeleteManagedVolume
        // GraphQL -> deleteManagedVolume: DeleteManagedVolumeReply! (type)
        public static string DeleteManagedVolume(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteManagedVolume" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteManagedVolumeFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new DeleteManagedVolumeReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteManagedVolumeSnapshotExport
        // GraphQL -> deleteManagedVolumeSnapshotExport: AsyncRequestStatus! (type)
        public static string DeleteManagedVolumeSnapshotExport(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteManagedVolumeSnapshotExport" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteManagedVolumeSnapshotExportFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteMongoSource
        // GraphQL -> deleteMongoSource: AsyncRequestStatus! (type)
        public static string DeleteMongoSource(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteMongoSource" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteMongoSourceFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicAsyncResponse? DeleteMongodbSource
        // GraphQL -> deleteMongodbSource: MosaicAsyncResponse! (type)
        public static string DeleteMongodbSource(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteMongodbSource" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteMongodbSourceFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new MosaicAsyncResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicAsyncResponse? DeleteMosaicStore
        // GraphQL -> deleteMosaicStore: MosaicAsyncResponse! (type)
        public static string DeleteMosaicStore(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteMosaicStore" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteMosaicStoreFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new MosaicAsyncResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? DeleteMssqlDbSnapshots
        // GraphQL -> deleteMssqlDbSnapshots: ResponseSuccess! (type)
        public static string DeleteMssqlDbSnapshots(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteMssqlDbSnapshots" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteMssqlDbSnapshotsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteMssqlLiveMount
        // GraphQL -> deleteMssqlLiveMount: AsyncRequestStatus! (type)
        public static string DeleteMssqlLiveMount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteMssqlLiveMount" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteMssqlLiveMountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteNasSystem
        // GraphQL -> deleteNasSystem: AsyncRequestStatus! (type)
        public static string DeleteNasSystem(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteNasSystem" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteNasSystemFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteNutanixCluster
        // GraphQL -> deleteNutanixCluster: AsyncRequestStatus! (type)
        public static string DeleteNutanixCluster(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteNutanixCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteNutanixClusterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteNutanixMountV1
        // GraphQL -> deleteNutanixMountV1: AsyncRequestStatus! (type)
        public static string DeleteNutanixMountV1(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteNutanixMountV1" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteNutanixMountV1FieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncRequestStatus? DeleteNutanixPrismCentral
        // GraphQL -> deleteNutanixPrismCentral: BatchAsyncRequestStatus! (type)
        public static string DeleteNutanixPrismCentral(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteNutanixPrismCentral" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteNutanixPrismCentralFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchAsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? DeleteNutanixSnapshot
        // GraphQL -> deleteNutanixSnapshot: RequestSuccess! (type)
        public static string DeleteNutanixSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteNutanixSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteNutanixSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? DeleteNutanixSnapshots
        // GraphQL -> deleteNutanixSnapshots: RequestSuccess! (type)
        public static string DeleteNutanixSnapshots(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteNutanixSnapshots" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteNutanixSnapshotsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestStatus? DeleteO365AzureApp
        // GraphQL -> deleteO365AzureApp: RequestStatus! (type)
        public static string DeleteO365AzureApp(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\no365AppClientId: $o365AppClientId\no365AppType: $o365AppType\n)";
            return "deleteO365AzureApp" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteO365AzureAppFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? DeleteO365Org
        // GraphQL -> deleteO365Org: CreateOnDemandJobReply! (type)
        public static string DeleteO365Org(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\norgId: $orgId\n)";
            return "deleteO365Org" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteO365OrgFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestStatus? DeleteO365ServiceAccount
        // GraphQL -> deleteO365ServiceAccount: RequestStatus! (type)
        public static string DeleteO365ServiceAccount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\norgId: $orgId\n)";
            return "deleteO365ServiceAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteO365ServiceAccountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteOracleMount
        // GraphQL -> deleteOracleMount: AsyncRequestStatus! (type)
        public static string DeleteOracleMount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteOracleMount" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteOracleMountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? DeleteSapHanaDbSnapshot
        // GraphQL -> deleteSapHanaDbSnapshot: ResponseSuccess! (type)
        public static string DeleteSapHanaDbSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteSapHanaDbSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteSapHanaDbSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteSapHanaSystem
        // GraphQL -> deleteSapHanaSystem: AsyncRequestStatus! (type)
        public static string DeleteSapHanaSystem(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteSapHanaSystem" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteSapHanaSystemFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? DeleteSnapshotsOfUnmanagedObjects
        // GraphQL -> deleteSnapshotsOfUnmanagedObjects: RequestSuccess! (type)
        public static string DeleteSnapshotsOfUnmanagedObjects(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteSnapshotsOfUnmanagedObjects" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteSnapshotsOfUnmanagedObjectsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DeleteStorageArraysReply? DeleteStorageArrays
        // GraphQL -> deleteStorageArrays: DeleteStorageArraysReply! (type)
        public static string DeleteStorageArrays(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteStorageArrays" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteStorageArraysFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new DeleteStorageArraysReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DeleteTerminatedClusterOperationJobDataReply? DeleteTerminatedClusterOperationJobData
        // GraphQL -> deleteTerminatedClusterOperationJobData: DeleteTerminatedClusterOperationJobDataReply! (type)
        public static string DeleteTerminatedClusterOperationJobData(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteTerminatedClusterOperationJobData" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteTerminatedClusterOperationJobDataFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new DeleteTerminatedClusterOperationJobDataReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? DeleteUnmanagedSnapshots
        // GraphQL -> deleteUnmanagedSnapshots: RequestSuccess! (type)
        public static string DeleteUnmanagedSnapshots(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteUnmanagedSnapshots" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteUnmanagedSnapshotsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteVolumeGroupMount
        // GraphQL -> deleteVolumeGroupMount: AsyncRequestStatus! (type)
        public static string DeleteVolumeGroupMount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteVolumeGroupMount" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteVolumeGroupMountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? DeleteVsphereAdvancedTag
        // GraphQL -> deleteVsphereAdvancedTag: RequestSuccess! (type)
        public static string DeleteVsphereAdvancedTag(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteVsphereAdvancedTag" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteVsphereAdvancedTagFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteVsphereLiveMount
        // GraphQL -> deleteVsphereLiveMount: AsyncRequestStatus! (type)
        public static string DeleteVsphereLiveMount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "deleteVsphereLiveMount" + args + "\n{\n" + fs + "}\n";
        }
        public static object DeleteVsphereLiveMountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? DisableReplicationPause
        // GraphQL -> disableReplicationPause: ResponseSuccess! (type)
        public static string DisableReplicationPause(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "disableReplicationPause" + args + "\n{\n" + fs + "}\n";
        }
        public static object DisableReplicationPauseFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DisableTargetReply? DisableTarget
        // GraphQL -> disableTarget: DisableTargetReply! (type)
        public static string DisableTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "disableTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object DisableTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new DisableTargetReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DiscoverDb2Instance
        // GraphQL -> discoverDb2Instance: AsyncRequestStatus! (type)
        public static string DiscoverDb2Instance(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "discoverDb2Instance" + args + "\n{\n" + fs + "}\n";
        }
        public static object DiscoverDb2InstanceFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DiscoverMongoSource
        // GraphQL -> discoverMongoSource: AsyncRequestStatus! (type)
        public static string DiscoverMongoSource(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "discoverMongoSource" + args + "\n{\n" + fs + "}\n";
        }
        public static object DiscoverMongoSourceFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DissolveLegalHoldReply? DissolveLegalHold
        // GraphQL -> dissolveLegalHold: DissolveLegalHoldReply! (type)
        public static string DissolveLegalHold(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "dissolveLegalHold" + args + "\n{\n" + fs + "}\n";
        }
        public static object DissolveLegalHoldFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new DissolveLegalHoldReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadActiveDirectorySnapshotFromLocation
        // GraphQL -> downloadActiveDirectorySnapshotFromLocation: AsyncRequestStatus! (type)
        public static string DownloadActiveDirectorySnapshotFromLocation(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadActiveDirectorySnapshotFromLocation" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadActiveDirectorySnapshotFromLocationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncDownloadReply? DownloadAuditLogCsvAsync
        // GraphQL -> downloadAuditLogCsvAsync: AsyncDownloadReply! (type)
        public static string DownloadAuditLogCsvAsync(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadAuditLogCsvAsync" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadAuditLogCsvAsyncFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncDownloadReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DownloadCdmTprConfigAsyncReply? DownloadCdmTprConfigurationAsync
        // GraphQL -> downloadCdmTprConfigurationAsync: DownloadCdmTprConfigAsyncReply! (type)
        public static string DownloadCdmTprConfigurationAsync(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "";
            return "downloadCdmTprConfigurationAsync" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadCdmTprConfigurationAsyncFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new DownloadCdmTprConfigAsyncReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadDb2Snapshot
        // GraphQL -> downloadDb2Snapshot: AsyncRequestStatus! (type)
        public static string DownloadDb2Snapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadDb2Snapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadDb2SnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadDb2SnapshotV2
        // GraphQL -> downloadDb2SnapshotV2: AsyncRequestStatus! (type)
        public static string DownloadDb2SnapshotV2(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadDb2SnapshotV2" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadDb2SnapshotV2FieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadDb2SnapshotsForPointInTimeRecovery
        // GraphQL -> downloadDb2SnapshotsForPointInTimeRecovery: AsyncRequestStatus! (type)
        public static string DownloadDb2SnapshotsForPointInTimeRecovery(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadDb2SnapshotsForPointInTimeRecovery" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadDb2SnapshotsForPointInTimeRecoveryFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadExchangeSnapshot
        // GraphQL -> downloadExchangeSnapshot: AsyncRequestStatus! (type)
        public static string DownloadExchangeSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadExchangeSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadExchangeSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadExchangeSnapshotV2
        // GraphQL -> downloadExchangeSnapshotV2: AsyncRequestStatus! (type)
        public static string DownloadExchangeSnapshotV2(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadExchangeSnapshotV2" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadExchangeSnapshotV2FieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadFilesManagedVolumeSnapshotFromArchivalLocation
        // GraphQL -> downloadFilesManagedVolumeSnapshotFromArchivalLocation: AsyncRequestStatus! (type)
        public static string DownloadFilesManagedVolumeSnapshotFromArchivalLocation(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadFilesManagedVolumeSnapshotFromArchivalLocation" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadFilesManagedVolumeSnapshotFromArchivalLocationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadFilesNutanixSnapshot
        // GraphQL -> downloadFilesNutanixSnapshot: AsyncRequestStatus! (type)
        public static string DownloadFilesNutanixSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadFilesNutanixSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadFilesNutanixSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadFilesNutanixSnapshotFromArchivalLocation
        // GraphQL -> downloadFilesNutanixSnapshotFromArchivalLocation: AsyncRequestStatus! (type)
        public static string DownloadFilesNutanixSnapshotFromArchivalLocation(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadFilesNutanixSnapshotFromArchivalLocation" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadFilesNutanixSnapshotFromArchivalLocationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadFilesetSnapshot
        // GraphQL -> downloadFilesetSnapshot: AsyncRequestStatus! (type)
        public static string DownloadFilesetSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadFilesetSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadFilesetSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadFilesetSnapshotFromLocation
        // GraphQL -> downloadFilesetSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string DownloadFilesetSnapshotFromLocation(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadFilesetSnapshotFromLocation" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadFilesetSnapshotFromLocationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadFromArchiveV2
        // GraphQL -> downloadFromArchiveV2: AsyncRequestStatus! (type)
        public static string DownloadFromArchiveV2(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadFromArchiveV2" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadFromArchiveV2FieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadHypervSnapshotFromLocation
        // GraphQL -> downloadHypervSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string DownloadHypervSnapshotFromLocation(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadHypervSnapshotFromLocation" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadHypervSnapshotFromLocationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadHypervVirtualMachineLevelFiles
        // GraphQL -> downloadHypervVirtualMachineLevelFiles: AsyncRequestStatus! (type)
        public static string DownloadHypervVirtualMachineLevelFiles(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadHypervVirtualMachineLevelFiles" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadHypervVirtualMachineLevelFilesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadHypervVirtualMachineSnapshot
        // GraphQL -> downloadHypervVirtualMachineSnapshot: AsyncRequestStatus! (type)
        public static string DownloadHypervVirtualMachineSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadHypervVirtualMachineSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadHypervVirtualMachineSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadHypervVirtualMachineSnapshotFiles
        // GraphQL -> downloadHypervVirtualMachineSnapshotFiles: AsyncRequestStatus! (type)
        public static string DownloadHypervVirtualMachineSnapshotFiles(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadHypervVirtualMachineSnapshotFiles" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadHypervVirtualMachineSnapshotFilesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadK8sSnapshotFromLocation
        // GraphQL -> downloadK8sSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string DownloadK8sSnapshotFromLocation(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadK8sSnapshotFromLocation" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadK8sSnapshotFromLocationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadManagedVolumeFiles
        // GraphQL -> downloadManagedVolumeFiles: AsyncRequestStatus! (type)
        public static string DownloadManagedVolumeFiles(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadManagedVolumeFiles" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadManagedVolumeFilesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadManagedVolumeFromLocation
        // GraphQL -> downloadManagedVolumeFromLocation: AsyncRequestStatus! (type)
        public static string DownloadManagedVolumeFromLocation(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadManagedVolumeFromLocation" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadManagedVolumeFromLocationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadMssqlDatabaseBackupFiles
        // GraphQL -> downloadMssqlDatabaseBackupFiles: AsyncRequestStatus! (type)
        public static string DownloadMssqlDatabaseBackupFiles(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadMssqlDatabaseBackupFiles" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadMssqlDatabaseBackupFilesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadMssqlDatabaseFilesFromArchivalLocation
        // GraphQL -> downloadMssqlDatabaseFilesFromArchivalLocation: AsyncRequestStatus! (type)
        public static string DownloadMssqlDatabaseFilesFromArchivalLocation(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadMssqlDatabaseFilesFromArchivalLocation" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadMssqlDatabaseFilesFromArchivalLocationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadNutanixSnapshot
        // GraphQL -> downloadNutanixSnapshot: AsyncRequestStatus! (type)
        public static string DownloadNutanixSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadNutanixSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadNutanixSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadNutanixVdisks
        // GraphQL -> downloadNutanixVdisks: AsyncRequestStatus! (type)
        public static string DownloadNutanixVdisks(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadNutanixVdisks" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadNutanixVdisksFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadNutanixVmFromLocation
        // GraphQL -> downloadNutanixVmFromLocation: AsyncRequestStatus! (type)
        public static string DownloadNutanixVmFromLocation(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadNutanixVmFromLocation" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadNutanixVmFromLocationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DownloadCsvReply? DownloadObjectFilesCsv
        // GraphQL -> downloadObjectFilesCsv: DownloadCsvReply! (type)
        public static string DownloadObjectFilesCsv(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadObjectFilesCsv" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadObjectFilesCsvFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new DownloadCsvReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DownloadCsvReply? DownloadObjectsListCsv
        // GraphQL -> downloadObjectsListCsv: DownloadCsvReply! (type)
        public static string DownloadObjectsListCsv(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadObjectsListCsv" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadObjectsListCsvFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new DownloadCsvReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadOracleDatabaseSnapshot
        // GraphQL -> downloadOracleDatabaseSnapshot: AsyncRequestStatus! (type)
        public static string DownloadOracleDatabaseSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadOracleDatabaseSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadOracleDatabaseSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadOracleSnapshotFromLocation
        // GraphQL -> downloadOracleSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string DownloadOracleSnapshotFromLocation(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadOracleSnapshotFromLocation" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadOracleSnapshotFromLocationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadOracleSnapshotFromLocationV2
        // GraphQL -> downloadOracleSnapshotFromLocationV2: AsyncRequestStatus! (type)
        public static string DownloadOracleSnapshotFromLocationV2(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadOracleSnapshotFromLocationV2" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadOracleSnapshotFromLocationV2FieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncDownloadReply? DownloadReportCsvAsync
        // GraphQL -> downloadReportCsvAsync: AsyncDownloadReply! (type)
        public static string DownloadReportCsvAsync(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadReportCsvAsync" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadReportCsvAsyncFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncDownloadReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncDownloadReply? DownloadReportPdfAsync
        // GraphQL -> downloadReportPdfAsync: AsyncDownloadReply! (type)
        public static string DownloadReportPdfAsync(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadReportPdfAsync" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadReportPdfAsyncFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncDownloadReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DownloadResultsCsvReply? DownloadResultsCsv
        // GraphQL -> downloadResultsCsv: DownloadResultsCsvReply! (type)
        public static string DownloadResultsCsv(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ncrawlId: $crawlId\ndownloadFilter: $downloadFilter\n)";
            return "downloadResultsCsv" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadResultsCsvFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new DownloadResultsCsvReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadSapHanaSnapshot
        // GraphQL -> downloadSapHanaSnapshot: AsyncRequestStatus! (type)
        public static string DownloadSapHanaSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadSapHanaSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadSapHanaSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadSapHanaSnapshotFromLocation
        // GraphQL -> downloadSapHanaSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string DownloadSapHanaSnapshotFromLocation(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadSapHanaSnapshotFromLocation" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadSapHanaSnapshotFromLocationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadSapHanaSnapshotsForPointInTimeRecovery
        // GraphQL -> downloadSapHanaSnapshotsForPointInTimeRecovery: AsyncRequestStatus! (type)
        public static string DownloadSapHanaSnapshotsForPointInTimeRecovery(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadSapHanaSnapshotsForPointInTimeRecovery" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadSapHanaSnapshotsForPointInTimeRecoveryFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DownloadCsvReply? DownloadSnapshotResultsCsv
        // GraphQL -> downloadSnapshotResultsCsv: DownloadCsvReply! (type)
        public static string DownloadSnapshotResultsCsv(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\ndownloadFilter: $downloadFilter\n)";
            return "downloadSnapshotResultsCsv" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadSnapshotResultsCsvFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new DownloadCsvReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DownloadThreatHuntCsvReply? DownloadThreatHuntCsv
        // GraphQL -> downloadThreatHuntCsv: DownloadThreatHuntCsvReply! (type)
        public static string DownloadThreatHuntCsv(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadThreatHuntCsv" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadThreatHuntCsvFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new DownloadThreatHuntCsvReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DownloadThreatHuntV2CsvResponse? DownloadThreatHuntV2ResultsCsv
        // GraphQL -> downloadThreatHuntV2ResultsCsv: DownloadThreatHuntV2CsvResponse! (type)
        public static string DownloadThreatHuntV2ResultsCsv(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadThreatHuntV2ResultsCsv" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadThreatHuntV2ResultsCsvFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new DownloadThreatHuntV2CsvResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DownloadCsvReply? DownloadUserActivityCsv
        // GraphQL -> downloadUserActivityCsv: DownloadCsvReply! (type)
        public static string DownloadUserActivityCsv(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadUserActivityCsv" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadUserActivityCsvFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new DownloadCsvReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DownloadCsvReply? DownloadUserFileActivityCsv
        // GraphQL -> downloadUserFileActivityCsv: DownloadCsvReply! (type)
        public static string DownloadUserFileActivityCsv(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadUserFileActivityCsv" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadUserFileActivityCsvFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new DownloadCsvReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadVolumeGroupSnapshotFiles
        // GraphQL -> downloadVolumeGroupSnapshotFiles: AsyncRequestStatus! (type)
        public static string DownloadVolumeGroupSnapshotFiles(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadVolumeGroupSnapshotFiles" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadVolumeGroupSnapshotFilesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadVolumeGroupSnapshotFromLocation
        // GraphQL -> downloadVolumeGroupSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string DownloadVolumeGroupSnapshotFromLocation(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadVolumeGroupSnapshotFromLocation" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadVolumeGroupSnapshotFromLocationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadVsphereVirtualMachineFiles
        // GraphQL -> downloadVsphereVirtualMachineFiles: AsyncRequestStatus! (type)
        public static string DownloadVsphereVirtualMachineFiles(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "downloadVsphereVirtualMachineFiles" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadVsphereVirtualMachineFilesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> EnableAutomaticFmdUploadReply? EnableAutomaticFmdUpload
        // GraphQL -> enableAutomaticFmdUpload: EnableAutomaticFmdUploadReply! (type)
        public static string EnableAutomaticFmdUpload(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "enableAutomaticFmdUpload" + args + "\n{\n" + fs + "}\n";
        }
        public static object EnableAutomaticFmdUploadFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new EnableAutomaticFmdUploadReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> EnableDisableAppConsistencyReply? EnableDisableAppConsistency
        // GraphQL -> enableDisableAppConsistency: EnableDisableAppConsistencyReply! (type)
        public static string EnableDisableAppConsistency(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "enableDisableAppConsistency" + args + "\n{\n" + fs + "}\n";
        }
        public static object EnableDisableAppConsistencyFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new EnableDisableAppConsistencyReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestStatus? EnableO365SharePoint
        // GraphQL -> enableO365SharePoint: RequestStatus! (type)
        public static string EnableO365SharePoint(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "enableO365SharePoint" + args + "\n{\n" + fs + "}\n";
        }
        public static object EnableO365SharePointFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestStatus? EnableO365Teams
        // GraphQL -> enableO365Teams: RequestStatus! (type)
        public static string EnableO365Teams(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nexocomputeClusterId: $exocomputeClusterId\n)";
            return "enableO365Teams" + args + "\n{\n" + fs + "}\n";
        }
        public static object EnableO365TeamsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? EnableReplicationPause
        // GraphQL -> enableReplicationPause: ResponseSuccess! (type)
        public static string EnableReplicationPause(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "enableReplicationPause" + args + "\n{\n" + fs + "}\n";
        }
        public static object EnableReplicationPauseFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> EnableTargetReply? EnableTarget
        // GraphQL -> enableTarget: EnableTargetReply! (type)
        public static string EnableTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "enableTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object EnableTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new EnableTargetReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> EndManagedVolumeSnapshotReply? EndManagedVolumeSnapshot
        // GraphQL -> endManagedVolumeSnapshot: EndManagedVolumeSnapshotReply! (type)
        public static string EndManagedVolumeSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "endManagedVolumeSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object EndManagedVolumeSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new EndManagedVolumeSnapshotReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? ExcludeVmDisks
        // GraphQL -> excludeVmDisks: RequestSuccess! (type)
        public static string ExcludeVmDisks(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "excludeVmDisks" + args + "\n{\n" + fs + "}\n";
        }
        public static object ExcludeVmDisksFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ExocomputeClusterConnectReply? ExocomputeClusterConnect
        // GraphQL -> exocomputeClusterConnect: ExocomputeClusterConnectReply! (type)
        public static string ExocomputeClusterConnect(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "exocomputeClusterConnect" + args + "\n{\n" + fs + "}\n";
        }
        public static object ExocomputeClusterConnectFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ExocomputeClusterConnectReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ExpireDownloadedDb2Snapshots
        // GraphQL -> expireDownloadedDb2Snapshots: AsyncRequestStatus! (type)
        public static string ExpireDownloadedDb2Snapshots(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "expireDownloadedDb2Snapshots" + args + "\n{\n" + fs + "}\n";
        }
        public static object ExpireDownloadedDb2SnapshotsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ExpireDownloadedSapHanaSnapshots
        // GraphQL -> expireDownloadedSapHanaSnapshots: AsyncRequestStatus! (type)
        public static string ExpireDownloadedSapHanaSnapshots(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "expireDownloadedSapHanaSnapshots" + args + "\n{\n" + fs + "}\n";
        }
        public static object ExpireDownloadedSapHanaSnapshotsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ExpireSnoozedDirectoriesReply? ExpireSnoozedDirectories
        // GraphQL -> expireSnoozedDirectories: ExpireSnoozedDirectoriesReply! (type)
        public static string ExpireSnoozedDirectories(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "expireSnoozedDirectories" + args + "\n{\n" + fs + "}\n";
        }
        public static object ExpireSnoozedDirectoriesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ExpireSnoozedDirectoriesReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ExportHypervVirtualMachine
        // GraphQL -> exportHypervVirtualMachine: AsyncRequestStatus! (type)
        public static string ExportHypervVirtualMachine(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "exportHypervVirtualMachine" + args + "\n{\n" + fs + "}\n";
        }
        public static object ExportHypervVirtualMachineFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? ExportK8sNamespace
        // GraphQL -> exportK8sNamespace: CreateOnDemandJobReply! (type)
        public static string ExportK8sNamespace(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "exportK8sNamespace" + args + "\n{\n" + fs + "}\n";
        }
        public static object ExportK8sNamespaceFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ExportK8sProtectionSetSnapshot
        // GraphQL -> exportK8sProtectionSetSnapshot: AsyncRequestStatus! (type)
        public static string ExportK8sProtectionSetSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "exportK8sProtectionSetSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object ExportK8sProtectionSetSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ExportManagedVolumeSnapshot
        // GraphQL -> exportManagedVolumeSnapshot: AsyncRequestStatus! (type)
        public static string ExportManagedVolumeSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "exportManagedVolumeSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object ExportManagedVolumeSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ExportMssqlDatabase
        // GraphQL -> exportMssqlDatabase: AsyncRequestStatus! (type)
        public static string ExportMssqlDatabase(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "exportMssqlDatabase" + args + "\n{\n" + fs + "}\n";
        }
        public static object ExportMssqlDatabaseFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ExportNutanixSnapshot
        // GraphQL -> exportNutanixSnapshot: AsyncRequestStatus! (type)
        public static string ExportNutanixSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "exportNutanixSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object ExportNutanixSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? ExportO365Mailbox
        // GraphQL -> exportO365Mailbox: CreateOnDemandJobReply! (type)
        public static string ExportO365Mailbox(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nexportConfig: $exportConfig\n)";
            return "exportO365Mailbox" + args + "\n{\n" + fs + "}\n";
        }
        public static object ExportO365MailboxFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<CreateOnDemandJobReply>? ExportO365MailboxV2
        // GraphQL -> exportO365MailboxV2: [CreateOnDemandJobReply!]! (type)
        public static string ExportO365MailboxV2(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "exportO365MailboxV2" + args + "\n{\n" + fs + "}\n";
        }
        public static object ExportO365MailboxV2FieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new List<CreateOnDemandJobReply>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ExportOracleDatabase
        // GraphQL -> exportOracleDatabase: AsyncRequestStatus! (type)
        public static string ExportOracleDatabase(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "exportOracleDatabase" + args + "\n{\n" + fs + "}\n";
        }
        public static object ExportOracleDatabaseFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ExportOracleTablespace
        // GraphQL -> exportOracleTablespace: AsyncRequestStatus! (type)
        public static string ExportOracleTablespace(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "exportOracleTablespace" + args + "\n{\n" + fs + "}\n";
        }
        public static object ExportOracleTablespaceFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ExportSlaManagedVolumeSnapshot
        // GraphQL -> exportSlaManagedVolumeSnapshot: AsyncRequestStatus! (type)
        public static string ExportSlaManagedVolumeSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "exportSlaManagedVolumeSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object ExportSlaManagedVolumeSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? FilesetDownloadSnapshotFiles
        // GraphQL -> filesetDownloadSnapshotFiles: AsyncRequestStatus! (type)
        public static string FilesetDownloadSnapshotFiles(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "filesetDownloadSnapshotFiles" + args + "\n{\n" + fs + "}\n";
        }
        public static object FilesetDownloadSnapshotFilesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? FilesetDownloadSnapshotFilesFromArchivalLocation
        // GraphQL -> filesetDownloadSnapshotFilesFromArchivalLocation: AsyncRequestStatus! (type)
        public static string FilesetDownloadSnapshotFilesFromArchivalLocation(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "filesetDownloadSnapshotFilesFromArchivalLocation" + args + "\n{\n" + fs + "}\n";
        }
        public static object FilesetDownloadSnapshotFilesFromArchivalLocationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? FilesetExportSnapshotFiles
        // GraphQL -> filesetExportSnapshotFiles: AsyncRequestStatus! (type)
        public static string FilesetExportSnapshotFiles(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "filesetExportSnapshotFiles" + args + "\n{\n" + fs + "}\n";
        }
        public static object FilesetExportSnapshotFilesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? FilesetRecoverFiles
        // GraphQL -> filesetRecoverFiles: AsyncRequestStatus! (type)
        public static string FilesetRecoverFiles(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "filesetRecoverFiles" + args + "\n{\n" + fs + "}\n";
        }
        public static object FilesetRecoverFilesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? FilesetRecoverFilesFromArchivalLocation
        // GraphQL -> filesetRecoverFilesFromArchivalLocation: AsyncRequestStatus! (type)
        public static string FilesetRecoverFilesFromArchivalLocation(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "filesetRecoverFilesFromArchivalLocation" + args + "\n{\n" + fs + "}\n";
        }
        public static object FilesetRecoverFilesFromArchivalLocationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> FinalizeAwsCloudAccountDeletionReply? FinalizeAwsCloudAccountDeletion
        // GraphQL -> finalizeAwsCloudAccountDeletion: FinalizeAwsCloudAccountDeletionReply! (type)
        public static string FinalizeAwsCloudAccountDeletion(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "finalizeAwsCloudAccountDeletion" + args + "\n{\n" + fs + "}\n";
        }
        public static object FinalizeAwsCloudAccountDeletionFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new FinalizeAwsCloudAccountDeletionReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> FinalizeAwsCloudAccountProtectionReply? FinalizeAwsCloudAccountProtection
        // GraphQL -> finalizeAwsCloudAccountProtection: FinalizeAwsCloudAccountProtectionReply! (type)
        public static string FinalizeAwsCloudAccountProtection(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "finalizeAwsCloudAccountProtection" + args + "\n{\n" + fs + "}\n";
        }
        public static object FinalizeAwsCloudAccountProtectionFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new FinalizeAwsCloudAccountProtectionReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GcpCloudAccountAddProjectsReply? GcpCloudAccountAddProjects
        // GraphQL -> gcpCloudAccountAddProjects: GcpCloudAccountAddProjectsReply! (type)
        public static string GcpCloudAccountAddProjects(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "gcpCloudAccountAddProjects" + args + "\n{\n" + fs + "}\n";
        }
        public static object GcpCloudAccountAddProjectsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new GcpCloudAccountAddProjectsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GcpCloudAccountDeleteProjectsReply? GcpCloudAccountDeleteProjects
        // GraphQL -> gcpCloudAccountDeleteProjects: GcpCloudAccountDeleteProjectsReply! (type)
        public static string GcpCloudAccountDeleteProjects(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "gcpCloudAccountDeleteProjects" + args + "\n{\n" + fs + "}\n";
        }
        public static object GcpCloudAccountDeleteProjectsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new GcpCloudAccountDeleteProjectsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GcpCloudAccountOauthCompleteReply? GcpCloudAccountOauthComplete
        // GraphQL -> gcpCloudAccountOauthComplete: GcpCloudAccountOauthCompleteReply! (type)
        public static string GcpCloudAccountOauthComplete(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "gcpCloudAccountOauthComplete" + args + "\n{\n" + fs + "}\n";
        }
        public static object GcpCloudAccountOauthCompleteFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new GcpCloudAccountOauthCompleteReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GcpCloudAccountOauthInitiateReply? GcpCloudAccountOauthInitiate
        // GraphQL -> gcpCloudAccountOauthInitiate: GcpCloudAccountOauthInitiateReply! (type)
        public static string GcpCloudAccountOauthInitiate(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "gcpCloudAccountOauthInitiate" + args + "\n{\n" + fs + "}\n";
        }
        public static object GcpCloudAccountOauthInitiateFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new GcpCloudAccountOauthInitiateReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GcpCloudAccountUpgradeProjectsReply? GcpCloudAccountUpgradeProjects
        // GraphQL -> gcpCloudAccountUpgradeProjects: GcpCloudAccountUpgradeProjectsReply! (type)
        public static string GcpCloudAccountUpgradeProjects(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "gcpCloudAccountUpgradeProjects" + args + "\n{\n" + fs + "}\n";
        }
        public static object GcpCloudAccountUpgradeProjectsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new GcpCloudAccountUpgradeProjectsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? GcpNativeDisableProject
        // GraphQL -> gcpNativeDisableProject: AsyncJobStatus! (type)
        public static string GcpNativeDisableProject(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "gcpNativeDisableProject" + args + "\n{\n" + fs + "}\n";
        }
        public static object GcpNativeDisableProjectFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? GcpNativeExportDisk
        // GraphQL -> gcpNativeExportDisk: AsyncJobStatus! (type)
        public static string GcpNativeExportDisk(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "gcpNativeExportDisk" + args + "\n{\n" + fs + "}\n";
        }
        public static object GcpNativeExportDiskFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? GcpNativeExportGceInstance
        // GraphQL -> gcpNativeExportGceInstance: AsyncJobStatus! (type)
        public static string GcpNativeExportGceInstance(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "gcpNativeExportGceInstance" + args + "\n{\n" + fs + "}\n";
        }
        public static object GcpNativeExportGceInstanceFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? GcpNativeRefreshProjects
        // GraphQL -> gcpNativeRefreshProjects: BatchAsyncJobStatus! (type)
        public static string GcpNativeRefreshProjects(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "gcpNativeRefreshProjects" + args + "\n{\n" + fs + "}\n";
        }
        public static object GcpNativeRefreshProjectsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? GcpNativeRestoreGceInstance
        // GraphQL -> gcpNativeRestoreGceInstance: AsyncJobStatus! (type)
        public static string GcpNativeRestoreGceInstance(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "gcpNativeRestoreGceInstance" + args + "\n{\n" + fs + "}\n";
        }
        public static object GcpNativeRestoreGceInstanceFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ClusterRegistrationToken? GenerateClusterRegistrationToken
        // GraphQL -> generateClusterRegistrationToken: ClusterRegistrationToken! (type)
        public static string GenerateClusterRegistrationToken(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "generateClusterRegistrationToken" + args + "\n{\n" + fs + "}\n";
        }
        public static object GenerateClusterRegistrationTokenFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ClusterRegistrationToken() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GenerateConfigProtectionRestoreFormReply? GenerateConfigProtectionRestoreForm
        // GraphQL -> generateConfigProtectionRestoreForm: GenerateConfigProtectionRestoreFormReply! (type)
        public static string GenerateConfigProtectionRestoreForm(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "generateConfigProtectionRestoreForm" + args + "\n{\n" + fs + "}\n";
        }
        public static object GenerateConfigProtectionRestoreFormFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new GenerateConfigProtectionRestoreFormReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Csr? GenerateCsr
        // GraphQL -> generateCsr: Csr! (type)
        public static string GenerateCsr(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nname: $name\nhostnames: $hostnames\norganization: $organization\norganizationUnit: $organizationUnit\ncountry: $country\nstate: $state\ncity: $city\nemail: $email\nsurname: $surname\nuserId: $userId\n)";
            return "generateCsr" + args + "\n{\n" + fs + "}\n";
        }
        public static object GenerateCsrFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new Csr() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? GenerateFilesetBackupReport
        // GraphQL -> generateFilesetBackupReport: AsyncRequestStatus! (type)
        public static string GenerateFilesetBackupReport(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "generateFilesetBackupReport" + args + "\n{\n" + fs + "}\n";
        }
        public static object GenerateFilesetBackupReportFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> K8sManifestResponse? GenerateK8sManifest
        // GraphQL -> generateK8sManifest: K8sManifestResponse! (type)
        public static string GenerateK8sManifest(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "generateK8sManifest" + args + "\n{\n" + fs + "}\n";
        }
        public static object GenerateK8sManifestFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new K8sManifestResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GeneratePresignedUrlForDownloadReply? GeneratePresignedUrlForDownload
        // GraphQL -> generatePresignedUrlForDownload: GeneratePresignedUrlForDownloadReply! (type)
        public static string GeneratePresignedUrlForDownload(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "generatePresignedUrlForDownload" + args + "\n{\n" + fs + "}\n";
        }
        public static object GeneratePresignedUrlForDownloadFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new GeneratePresignedUrlForDownloadReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GeneratePresignedUrlForPartUploadReply? GeneratePresignedUrlForPartUpload
        // GraphQL -> generatePresignedUrlForPartUpload: GeneratePresignedUrlForPartUploadReply! (type)
        public static string GeneratePresignedUrlForPartUpload(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "generatePresignedUrlForPartUpload" + args + "\n{\n" + fs + "}\n";
        }
        public static object GeneratePresignedUrlForPartUploadFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new GeneratePresignedUrlForPartUploadReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GeneratePreviewMessageForWebhookTemplateReply? GeneratePreviewMessageForWebhookTemplate
        // GraphQL -> generatePreviewMessageForWebhookTemplate: GeneratePreviewMessageForWebhookTemplateReply! (type)
        public static string GeneratePreviewMessageForWebhookTemplate(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "generatePreviewMessageForWebhookTemplate" + args + "\n{\n" + fs + "}\n";
        }
        public static object GeneratePreviewMessageForWebhookTemplateFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new GeneratePreviewMessageForWebhookTemplateReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? GenerateSupportBundle
        // GraphQL -> generateSupportBundle: AsyncRequestStatus! (type)
        public static string GenerateSupportBundle(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "generateSupportBundle" + args + "\n{\n" + fs + "}\n";
        }
        public static object GenerateSupportBundleFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GenerateTotpSecretReply? GenerateTotpSecret
        // GraphQL -> generateTotpSecret: GenerateTotpSecretReply! (type)
        public static string GenerateTotpSecret(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nuserId: $userId\n)";
            return "generateTotpSecret" + args + "\n{\n" + fs + "}\n";
        }
        public static object GenerateTotpSecretFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new GenerateTotpSecretReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UserDownloadUrl? GetDownloadUrl
        // GraphQL -> getDownloadUrl: UserDownloadUrl! (type)
        public static string GetDownloadUrl(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ndownloadId: $downloadId\n)";
            return "getDownloadUrl" + args + "\n{\n" + fs + "}\n";
        }
        public static object GetDownloadUrlFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UserDownloadUrl() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetHealthMonitorPolicyStatusReply? GetHealthMonitorPolicyStatus
        // GraphQL -> getHealthMonitorPolicyStatus: GetHealthMonitorPolicyStatusReply! (type)
        public static string GetHealthMonitorPolicyStatus(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "getHealthMonitorPolicyStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object GetHealthMonitorPolicyStatusFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new GetHealthMonitorPolicyStatusReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetPendingSlaAssignmentsReply? GetPendingSlaAssignments
        // GraphQL -> getPendingSlaAssignments: GetPendingSlaAssignmentsReply! (type)
        public static string GetPendingSlaAssignments(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "getPendingSlaAssignments" + args + "\n{\n" + fs + "}\n";
        }
        public static object GetPendingSlaAssignmentsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new GetPendingSlaAssignmentsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? HideRevealNasShares
        // GraphQL -> hideRevealNasShares: ResponseSuccess! (type)
        public static string HideRevealNasShares(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "hideRevealNasShares" + args + "\n{\n" + fs + "}\n";
        }
        public static object HideRevealNasSharesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? HypervDeleteAllSnapshots
        // GraphQL -> hypervDeleteAllSnapshots: RequestSuccess! (type)
        public static string HypervDeleteAllSnapshots(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "hypervDeleteAllSnapshots" + args + "\n{\n" + fs + "}\n";
        }
        public static object HypervDeleteAllSnapshotsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? HypervOnDemandSnapshot
        // GraphQL -> hypervOnDemandSnapshot: AsyncRequestStatus! (type)
        public static string HypervOnDemandSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "hypervOnDemandSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object HypervOnDemandSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? HypervScvmmDelete
        // GraphQL -> hypervScvmmDelete: ResponseSuccess! (type)
        public static string HypervScvmmDelete(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "hypervScvmmDelete" + args + "\n{\n" + fs + "}\n";
        }
        public static object HypervScvmmDeleteFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HypervScvmmUpdateReply? HypervScvmmUpdate
        // GraphQL -> hypervScvmmUpdate: HypervScvmmUpdateReply! (type)
        public static string HypervScvmmUpdate(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "hypervScvmmUpdate" + args + "\n{\n" + fs + "}\n";
        }
        public static object HypervScvmmUpdateFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new HypervScvmmUpdateReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> InitializeUploadSessionReply? InitializeUploadSession
        // GraphQL -> initializeUploadSession: InitializeUploadSessionReply! (type)
        public static string InitializeUploadSession(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "initializeUploadSession" + args + "\n{\n" + fs + "}\n";
        }
        public static object InitializeUploadSessionFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new InitializeUploadSessionReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? InplaceExportHypervVirtualMachine
        // GraphQL -> inplaceExportHypervVirtualMachine: AsyncRequestStatus! (type)
        public static string InplaceExportHypervVirtualMachine(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "inplaceExportHypervVirtualMachine" + args + "\n{\n" + fs + "}\n";
        }
        public static object InplaceExportHypervVirtualMachineFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? InplaceExportNutanixSnapshot
        // GraphQL -> inplaceExportNutanixSnapshot: AsyncRequestStatus! (type)
        public static string InplaceExportNutanixSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "inplaceExportNutanixSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object InplaceExportNutanixSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestStatus? InsertCustomerO365App
        // GraphQL -> insertCustomerO365App: RequestStatus! (type)
        public static string InsertCustomerO365App(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "insertCustomerO365App" + args + "\n{\n" + fs + "}\n";
        }
        public static object InsertCustomerO365AppFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? InstallIoFilter
        // GraphQL -> installIoFilter: RequestSuccess! (type)
        public static string InstallIoFilter(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "installIoFilter" + args + "\n{\n" + fs + "}\n";
        }
        public static object InstallIoFilterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? InstantRecoverHypervVirtualMachineSnapshot
        // GraphQL -> instantRecoverHypervVirtualMachineSnapshot: AsyncRequestStatus! (type)
        public static string InstantRecoverHypervVirtualMachineSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "instantRecoverHypervVirtualMachineSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object InstantRecoverHypervVirtualMachineSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? InstantRecoverOracleSnapshot
        // GraphQL -> instantRecoverOracleSnapshot: AsyncRequestStatus! (type)
        public static string InstantRecoverOracleSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "instantRecoverOracleSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object InstantRecoverOracleSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> LinuxRbsBulkInstallReply? LinuxRbsBulkInstall
        // GraphQL -> linuxRbsBulkInstall: LinuxRbsBulkInstallReply! (type)
        public static string LinuxRbsBulkInstall(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "linuxRbsBulkInstall" + args + "\n{\n" + fs + "}\n";
        }
        public static object LinuxRbsBulkInstallFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new LinuxRbsBulkInstallReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ListCidrsForComputeSettingReply? ListCidrsForComputeSetting
        // GraphQL -> listCidrsForComputeSetting: ListCidrsForComputeSettingReply! (type)
        public static string ListCidrsForComputeSetting(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "listCidrsForComputeSetting" + args + "\n{\n" + fs + "}\n";
        }
        public static object ListCidrsForComputeSettingFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ListCidrsForComputeSettingReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SupportPortalLogoutReply? LogoutFromRubrikSupportPortal
        // GraphQL -> logoutFromRubrikSupportPortal: SupportPortalLogoutReply! (type)
        public static string LogoutFromRubrikSupportPortal(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "";
            return "logoutFromRubrikSupportPortal" + args + "\n{\n" + fs + "}\n";
        }
        public static object LogoutFromRubrikSupportPortalFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new SupportPortalLogoutReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? MakePrimary
        // GraphQL -> makePrimary: AsyncRequestStatus! (type)
        public static string MakePrimary(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "makePrimary" + args + "\n{\n" + fs + "}\n";
        }
        public static object MakePrimaryFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? ManageProtectionForLinkedObjects
        // GraphQL -> manageProtectionForLinkedObjects: CreateOnDemandJobReply! (type)
        public static string ManageProtectionForLinkedObjects(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "manageProtectionForLinkedObjects" + args + "\n{\n" + fs + "}\n";
        }
        public static object ManageProtectionForLinkedObjectsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MapAzureCloudAccountExocomputeSubscriptionReply? MapAzureCloudAccountExocomputeSubscription
        // GraphQL -> mapAzureCloudAccountExocomputeSubscription: MapAzureCloudAccountExocomputeSubscriptionReply! (type)
        public static string MapAzureCloudAccountExocomputeSubscription(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "mapAzureCloudAccountExocomputeSubscription" + args + "\n{\n" + fs + "}\n";
        }
        public static object MapAzureCloudAccountExocomputeSubscriptionFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new MapAzureCloudAccountExocomputeSubscriptionReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MapAzureCloudAccountToPersistentStorageLocationReply? MapAzureCloudAccountToPersistentStorageLocation
        // GraphQL -> mapAzureCloudAccountToPersistentStorageLocation: MapAzureCloudAccountToPersistentStorageLocationReply! (type)
        public static string MapAzureCloudAccountToPersistentStorageLocation(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "mapAzureCloudAccountToPersistentStorageLocation" + args + "\n{\n" + fs + "}\n";
        }
        public static object MapAzureCloudAccountToPersistentStorageLocationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new MapAzureCloudAccountToPersistentStorageLocationReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MapCloudAccountExocomputeAccountReply? MapCloudAccountExocomputeAccount
        // GraphQL -> mapCloudAccountExocomputeAccount: MapCloudAccountExocomputeAccountReply! (type)
        public static string MapCloudAccountExocomputeAccount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "mapCloudAccountExocomputeAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object MapCloudAccountExocomputeAccountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new MapCloudAccountExocomputeAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MarkAgentSecondaryCertificateReply? MarkAgentSecondaryCertificate
        // GraphQL -> markAgentSecondaryCertificate: MarkAgentSecondaryCertificateReply! (type)
        public static string MarkAgentSecondaryCertificate(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "markAgentSecondaryCertificate" + args + "\n{\n" + fs + "}\n";
        }
        public static object MarkAgentSecondaryCertificateFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new MarkAgentSecondaryCertificateReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CcProvisionJobReply? MigrateCloudClusterDisks
        // GraphQL -> migrateCloudClusterDisks: CcProvisionJobReply! (type)
        public static string MigrateCloudClusterDisks(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "migrateCloudClusterDisks" + args + "\n{\n" + fs + "}\n";
        }
        public static object MigrateCloudClusterDisksFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CcProvisionJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? MigrateNutanixMountV1
        // GraphQL -> migrateNutanixMountV1: AsyncRequestStatus! (type)
        public static string MigrateNutanixMountV1(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "migrateNutanixMountV1" + args + "\n{\n" + fs + "}\n";
        }
        public static object MigrateNutanixMountV1FieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ModifyIpmiReply? ModifyIpmi
        // GraphQL -> modifyIpmi: ModifyIpmiReply! (type)
        public static string ModifyIpmi(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "modifyIpmi" + args + "\n{\n" + fs + "}\n";
        }
        public static object ModifyIpmiFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ModifyIpmiReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MountDiskReply? MountDisk
        // GraphQL -> mountDisk: MountDiskReply! (type)
        public static string MountDisk(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "mountDisk" + args + "\n{\n" + fs + "}\n";
        }
        public static object MountDiskFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new MountDiskReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? MountNutanixSnapshotV1
        // GraphQL -> mountNutanixSnapshotV1: AsyncRequestStatus! (type)
        public static string MountNutanixSnapshotV1(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "mountNutanixSnapshotV1" + args + "\n{\n" + fs + "}\n";
        }
        public static object MountNutanixSnapshotV1FieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? MountNutanixVdisks
        // GraphQL -> mountNutanixVdisks: AsyncRequestStatus! (type)
        public static string MountNutanixVdisks(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "mountNutanixVdisks" + args + "\n{\n" + fs + "}\n";
        }
        public static object MountNutanixVdisksFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? MountOracleDatabase
        // GraphQL -> mountOracleDatabase: AsyncRequestStatus! (type)
        public static string MountOracleDatabase(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "mountOracleDatabase" + args + "\n{\n" + fs + "}\n";
        }
        public static object MountOracleDatabaseFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NotificationForGetLicenseReply? NotificationForGetLicense
        // GraphQL -> notificationForGetLicense: NotificationForGetLicenseReply! (type)
        public static string NotificationForGetLicense(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "notificationForGetLicense" + args + "\n{\n" + fs + "}\n";
        }
        public static object NotificationForGetLicenseFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new NotificationForGetLicenseReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365OauthConsentCompleteReply? O365OauthConsentComplete
        // GraphQL -> o365OauthConsentComplete: O365OauthConsentCompleteReply! (type)
        public static string O365OauthConsentComplete(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "o365OauthConsentComplete" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365OauthConsentCompleteFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new O365OauthConsentCompleteReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365OauthConsentKickoffReply? O365OauthConsentKickoff
        // GraphQL -> o365OauthConsentKickoff: O365OauthConsentKickoffReply! (type)
        public static string O365OauthConsentKickoff(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "o365OauthConsentKickoff" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365OauthConsentKickoffFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new O365OauthConsentKickoffReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365PdlGroupsReply? O365PdlGroups
        // GraphQL -> o365PdlGroups: O365PdlGroupsReply! (type)
        public static string O365PdlGroups(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "o365PdlGroups" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365PdlGroupsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new O365PdlGroupsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365SaasSetupKickoffReply? O365SaaSsetupKickoff
        // GraphQL -> o365SaaSSetupKickoff: O365SaasSetupKickoffReply! (type)
        public static string O365SaaSsetupKickoff(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "";
            return "o365SaaSSetupKickoff" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365SaaSsetupKickoffFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new O365SaasSetupKickoffReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddO365OrgResponse? O365SaasSetupComplete
        // GraphQL -> o365SaasSetupComplete: AddO365OrgResponse! (type)
        public static string O365SaasSetupComplete(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "o365SaasSetupComplete" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365SaasSetupCompleteFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AddO365OrgResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365SetupKickoffResp? O365SetupKickoff
        // GraphQL -> o365SetupKickoff: O365SetupKickoffResp! (type)
        public static string O365SetupKickoff(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "";
            return "o365SetupKickoff" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365SetupKickoffFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new O365SetupKickoffResp() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PatchDb2DatabaseReply? PatchDb2Database
        // GraphQL -> patchDb2Database: PatchDb2DatabaseReply! (type)
        public static string PatchDb2Database(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "patchDb2Database" + args + "\n{\n" + fs + "}\n";
        }
        public static object PatchDb2DatabaseFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new PatchDb2DatabaseReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PatchDb2InstanceReply? PatchDb2Instance
        // GraphQL -> patchDb2Instance: PatchDb2InstanceReply! (type)
        public static string PatchDb2Instance(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "patchDb2Instance" + args + "\n{\n" + fs + "}\n";
        }
        public static object PatchDb2InstanceFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new PatchDb2InstanceReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? PatchMongoSource
        // GraphQL -> patchMongoSource: AsyncRequestStatus! (type)
        public static string PatchMongoSource(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "patchMongoSource" + args + "\n{\n" + fs + "}\n";
        }
        public static object PatchMongoSourceFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PatchNutanixMountV1Reply? PatchNutanixMountV1
        // GraphQL -> patchNutanixMountV1: PatchNutanixMountV1Reply! (type)
        public static string PatchNutanixMountV1(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "patchNutanixMountV1" + args + "\n{\n" + fs + "}\n";
        }
        public static object PatchNutanixMountV1FieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new PatchNutanixMountV1Reply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PatchSapHanaSystemReply? PatchSapHanaSystem
        // GraphQL -> patchSapHanaSystem: PatchSapHanaSystemReply! (type)
        public static string PatchSapHanaSystem(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "patchSapHanaSystem" + args + "\n{\n" + fs + "}\n";
        }
        public static object PatchSapHanaSystemFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new PatchSapHanaSystemReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PauseSlaReply? PauseSla
        // GraphQL -> pauseSla: PauseSlaReply! (type)
        public static string PauseSla(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "pauseSla" + args + "\n{\n" + fs + "}\n";
        }
        public static object PauseSlaFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new PauseSlaReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PauseTargetReply? PauseTarget
        // GraphQL -> pauseTarget: PauseTargetReply! (type)
        public static string PauseTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "pauseTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object PauseTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new PauseTargetReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PrepareAwsCloudAccountDeletionReply? PrepareAwsCloudAccountDeletion
        // GraphQL -> prepareAwsCloudAccountDeletion: PrepareAwsCloudAccountDeletionReply! (type)
        public static string PrepareAwsCloudAccountDeletion(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "prepareAwsCloudAccountDeletion" + args + "\n{\n" + fs + "}\n";
        }
        public static object PrepareAwsCloudAccountDeletionFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new PrepareAwsCloudAccountDeletionReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PrepareFeatureUpdateForAwsCloudAccountReply? PrepareFeatureUpdateForAwsCloudAccount
        // GraphQL -> prepareFeatureUpdateForAwsCloudAccount: PrepareFeatureUpdateForAwsCloudAccountReply! (type)
        public static string PrepareFeatureUpdateForAwsCloudAccount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "prepareFeatureUpdateForAwsCloudAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object PrepareFeatureUpdateForAwsCloudAccountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new PrepareFeatureUpdateForAwsCloudAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PutSmbConfigurationReply? PutSmbConfiguration
        // GraphQL -> putSmbConfiguration: PutSmbConfigurationReply! (type)
        public static string PutSmbConfiguration(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "putSmbConfiguration" + args + "\n{\n" + fs + "}\n";
        }
        public static object PutSmbConfigurationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new PutSmbConfigurationReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicAsyncResponse? RecoverCassandraSource
        // GraphQL -> recoverCassandraSource: MosaicAsyncResponse! (type)
        public static string RecoverCassandraSource(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "recoverCassandraSource" + args + "\n{\n" + fs + "}\n";
        }
        public static object RecoverCassandraSourceFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new MosaicAsyncResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CcProvisionJobReply? RecoverCloudCluster
        // GraphQL -> recoverCloudCluster: CcProvisionJobReply! (type)
        public static string RecoverCloudCluster(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "recoverCloudCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object RecoverCloudClusterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CcProvisionJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RecoverCloudDirectMultiPaths
        // GraphQL -> recoverCloudDirectMultiPaths: AsyncRequestStatus! (type)
        public static string RecoverCloudDirectMultiPaths(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "recoverCloudDirectMultiPaths" + args + "\n{\n" + fs + "}\n";
        }
        public static object RecoverCloudDirectMultiPathsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RecoverCloudDirectNasShare
        // GraphQL -> recoverCloudDirectNasShare: AsyncRequestStatus! (type)
        public static string RecoverCloudDirectNasShare(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "recoverCloudDirectNasShare" + args + "\n{\n" + fs + "}\n";
        }
        public static object RecoverCloudDirectNasShareFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RecoverCloudDirectPath
        // GraphQL -> recoverCloudDirectPath: AsyncRequestStatus! (type)
        public static string RecoverCloudDirectPath(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "recoverCloudDirectPath" + args + "\n{\n" + fs + "}\n";
        }
        public static object RecoverCloudDirectPathFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RecoverMongoSource
        // GraphQL -> recoverMongoSource: AsyncRequestStatus! (type)
        public static string RecoverMongoSource(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "recoverMongoSource" + args + "\n{\n" + fs + "}\n";
        }
        public static object RecoverMongoSourceFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicAsyncResponse? RecoverMongodbSource
        // GraphQL -> recoverMongodbSource: MosaicAsyncResponse! (type)
        public static string RecoverMongodbSource(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "recoverMongodbSource" + args + "\n{\n" + fs + "}\n";
        }
        public static object RecoverMongodbSourceFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new MosaicAsyncResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RecoverSapHanaDatabaseToFullBackup
        // GraphQL -> recoverSapHanaDatabaseToFullBackup: AsyncRequestStatus! (type)
        public static string RecoverSapHanaDatabaseToFullBackup(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "recoverSapHanaDatabaseToFullBackup" + args + "\n{\n" + fs + "}\n";
        }
        public static object RecoverSapHanaDatabaseToFullBackupFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RecoverSapHanaDatabaseToPointInTime
        // GraphQL -> recoverSapHanaDatabaseToPointInTime: AsyncRequestStatus! (type)
        public static string RecoverSapHanaDatabaseToPointInTime(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "recoverSapHanaDatabaseToPointInTime" + args + "\n{\n" + fs + "}\n";
        }
        public static object RecoverSapHanaDatabaseToPointInTimeFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RefreshDb2Database
        // GraphQL -> refreshDb2Database: AsyncRequestStatus! (type)
        public static string RefreshDb2Database(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "refreshDb2Database" + args + "\n{\n" + fs + "}\n";
        }
        public static object RefreshDb2DatabaseFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RefreshDomain
        // GraphQL -> refreshDomain: AsyncRequestStatus! (type)
        public static string RefreshDomain(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "refreshDomain" + args + "\n{\n" + fs + "}\n";
        }
        public static object RefreshDomainFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GlobalManagerConnectivity? RefreshGlobalManagerConnectivityStatus
        // GraphQL -> refreshGlobalManagerConnectivityStatus: GlobalManagerConnectivity! (type)
        public static string RefreshGlobalManagerConnectivityStatus(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            return "refreshGlobalManagerConnectivityStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object RefreshGlobalManagerConnectivityStatusFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new GlobalManagerConnectivity() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RefreshHostReply? RefreshHost
        // GraphQL -> refreshHost: RefreshHostReply! (type)
        public static string RefreshHost(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "refreshHost" + args + "\n{\n" + fs + "}\n";
        }
        public static object RefreshHostFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RefreshHostReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RefreshHypervScvmm
        // GraphQL -> refreshHypervScvmm: AsyncRequestStatus! (type)
        public static string RefreshHypervScvmm(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "refreshHypervScvmm" + args + "\n{\n" + fs + "}\n";
        }
        public static object RefreshHypervScvmmFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RefreshHypervServer
        // GraphQL -> refreshHypervServer: AsyncRequestStatus! (type)
        public static string RefreshHypervServer(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "refreshHypervServer" + args + "\n{\n" + fs + "}\n";
        }
        public static object RefreshHypervServerFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? RefreshK8sCluster
        // GraphQL -> refreshK8sCluster: CreateOnDemandJobReply! (type)
        public static string RefreshK8sCluster(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "refreshK8sCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object RefreshK8sClusterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RefreshK8sV2Cluster
        // GraphQL -> refreshK8sV2Cluster: AsyncRequestStatus! (type)
        public static string RefreshK8sV2Cluster(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "refreshK8sV2Cluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object RefreshK8sV2ClusterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RefreshNasSystemsReply? RefreshNasSystems
        // GraphQL -> refreshNasSystems: RefreshNasSystemsReply! (type)
        public static string RefreshNasSystems(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "refreshNasSystems" + args + "\n{\n" + fs + "}\n";
        }
        public static object RefreshNasSystemsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RefreshNasSystemsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RefreshNutanixCluster
        // GraphQL -> refreshNutanixCluster: AsyncRequestStatus! (type)
        public static string RefreshNutanixCluster(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "refreshNutanixCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object RefreshNutanixClusterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncRequestStatus? RefreshNutanixPrismCentral
        // GraphQL -> refreshNutanixPrismCentral: BatchAsyncRequestStatus! (type)
        public static string RefreshNutanixPrismCentral(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "refreshNutanixPrismCentral" + args + "\n{\n" + fs + "}\n";
        }
        public static object RefreshNutanixPrismCentralFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchAsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? RefreshO365Org
        // GraphQL -> refreshO365Org: CreateOnDemandJobReply! (type)
        public static string RefreshO365Org(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\norgId: $orgId\n)";
            return "refreshO365Org" + args + "\n{\n" + fs + "}\n";
        }
        public static object RefreshO365OrgFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RefreshOracleDatabase
        // GraphQL -> refreshOracleDatabase: AsyncRequestStatus! (type)
        public static string RefreshOracleDatabase(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "refreshOracleDatabase" + args + "\n{\n" + fs + "}\n";
        }
        public static object RefreshOracleDatabaseFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RefreshStorageArraysReply? RefreshStorageArrays
        // GraphQL -> refreshStorageArrays: RefreshStorageArraysReply! (type)
        public static string RefreshStorageArrays(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "refreshStorageArrays" + args + "\n{\n" + fs + "}\n";
        }
        public static object RefreshStorageArraysFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RefreshStorageArraysReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RefreshVsphereVcenter
        // GraphQL -> refreshVsphereVcenter: AsyncRequestStatus! (type)
        public static string RefreshVsphereVcenter(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "refreshVsphereVcenter" + args + "\n{\n" + fs + "}\n";
        }
        public static object RefreshVsphereVcenterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> K8sManifestResponse? RegenerateK8sManifest
        // GraphQL -> regenerateK8sManifest: K8sManifestResponse! (type)
        public static string RegenerateK8sManifest(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "regenerateK8sManifest" + args + "\n{\n" + fs + "}\n";
        }
        public static object RegenerateK8sManifestFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new K8sManifestResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? RegisterAgentHypervVirtualMachine
        // GraphQL -> registerAgentHypervVirtualMachine: RequestSuccess! (type)
        public static string RegisterAgentHypervVirtualMachine(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "registerAgentHypervVirtualMachine" + args + "\n{\n" + fs + "}\n";
        }
        public static object RegisterAgentHypervVirtualMachineFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? RegisterAgentNutanixVm
        // GraphQL -> registerAgentNutanixVm: RequestSuccess! (type)
        public static string RegisterAgentNutanixVm(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "registerAgentNutanixVm" + args + "\n{\n" + fs + "}\n";
        }
        public static object RegisterAgentNutanixVmFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RegisterAwsFeatureArtifactsReply? RegisterAwsFeatureArtifacts
        // GraphQL -> registerAwsFeatureArtifacts: RegisterAwsFeatureArtifactsReply! (type)
        public static string RegisterAwsFeatureArtifacts(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "registerAwsFeatureArtifacts" + args + "\n{\n" + fs + "}\n";
        }
        public static object RegisterAwsFeatureArtifactsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RegisterAwsFeatureArtifactsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RegisterCloudClusterReply? RegisterCloudCluster
        // GraphQL -> registerCloudCluster: RegisterCloudClusterReply! (type)
        public static string RegisterCloudCluster(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "registerCloudCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object RegisterCloudClusterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RegisterCloudClusterReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RegisterHypervScvmm
        // GraphQL -> registerHypervScvmm: AsyncRequestStatus! (type)
        public static string RegisterHypervScvmm(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "registerHypervScvmm" + args + "\n{\n" + fs + "}\n";
        }
        public static object RegisterHypervScvmmFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RegisterNasSystemReply? RegisterNasSystem
        // GraphQL -> registerNasSystem: RegisterNasSystemReply! (type)
        public static string RegisterNasSystem(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "registerNasSystem" + args + "\n{\n" + fs + "}\n";
        }
        public static object RegisterNasSystemFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RegisterNasSystemReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CcProvisionJobReply? RemoveClusterNodes
        // GraphQL -> removeClusterNodes: CcProvisionJobReply! (type)
        public static string RemoveClusterNodes(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "removeClusterNodes" + args + "\n{\n" + fs + "}\n";
        }
        public static object RemoveClusterNodesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CcProvisionJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? RemoveDisk
        // GraphQL -> removeDisk: ResponseSuccess! (type)
        public static string RemoveDisk(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "removeDisk" + args + "\n{\n" + fs + "}\n";
        }
        public static object RemoveDiskFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RemoveNodeForReplacementReply? RemoveNodeForReplacement
        // GraphQL -> removeNodeForReplacement: RemoveNodeForReplacementReply! (type)
        public static string RemoveNodeForReplacement(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "removeNodeForReplacement" + args + "\n{\n" + fs + "}\n";
        }
        public static object RemoveNodeForReplacementFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RemoveNodeForReplacementReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? RemoveProxyConfig
        // GraphQL -> removeProxyConfig: ResponseSuccess! (type)
        public static string RemoveProxyConfig(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "removeProxyConfig" + args + "\n{\n" + fs + "}\n";
        }
        public static object RemoveProxyConfigFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RemoveUploadRecordReply? RemoveUploadRecord
        // GraphQL -> removeUploadRecord: RemoveUploadRecordReply! (type)
        public static string RemoveUploadRecord(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "removeUploadRecord" + args + "\n{\n" + fs + "}\n";
        }
        public static object RemoveUploadRecordFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RemoveUploadRecordReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RemoveVlansReply? RemoveVlans
        // GraphQL -> removeVlans: RemoveVlansReply! (type)
        public static string RemoveVlans(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "removeVlans" + args + "\n{\n" + fs + "}\n";
        }
        public static object RemoveVlansFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RemoveVlansReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ReplaceClusterNodeReply? ReplaceClusterNode
        // GraphQL -> replaceClusterNode: ReplaceClusterNodeReply! (type)
        public static string ReplaceClusterNode(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "replaceClusterNode" + args + "\n{\n" + fs + "}\n";
        }
        public static object ReplaceClusterNodeFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ReplaceClusterNodeReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestPersistentExoclusterReply? RequestPersistentExocluster
        // GraphQL -> requestPersistentExocluster: RequestPersistentExoclusterReply! (type)
        public static string RequestPersistentExocluster(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "requestPersistentExocluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object RequestPersistentExoclusterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestPersistentExoclusterReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ReseedLogShippingSecondary
        // GraphQL -> reseedLogShippingSecondary: AsyncRequestStatus! (type)
        public static string ReseedLogShippingSecondary(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "reseedLogShippingSecondary" + args + "\n{\n" + fs + "}\n";
        }
        public static object ReseedLogShippingSecondaryFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? ResizeDisk
        // GraphQL -> resizeDisk: ResponseSuccess! (type)
        public static string ResizeDisk(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "resizeDisk" + args + "\n{\n" + fs + "}\n";
        }
        public static object ResizeDiskFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ResizeManagedVolume
        // GraphQL -> resizeManagedVolume: AsyncRequestStatus! (type)
        public static string ResizeManagedVolume(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "resizeManagedVolume" + args + "\n{\n" + fs + "}\n";
        }
        public static object ResizeManagedVolumeFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? ResolveVolumeGroupsConflict
        // GraphQL -> resolveVolumeGroupsConflict: RequestSuccess! (type)
        public static string ResolveVolumeGroupsConflict(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "resolveVolumeGroupsConflict" + args + "\n{\n" + fs + "}\n";
        }
        public static object ResolveVolumeGroupsConflictFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RestoreActiveDirectoryObjects
        // GraphQL -> restoreActiveDirectoryObjects: AsyncRequestStatus! (type)
        public static string RestoreActiveDirectoryObjects(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "restoreActiveDirectoryObjects" + args + "\n{\n" + fs + "}\n";
        }
        public static object RestoreActiveDirectoryObjectsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RestoreAzureAdObjectsWithPasswordsReply? RestoreAzureAdObjectsWithPasswords
        // GraphQL -> restoreAzureAdObjectsWithPasswords: RestoreAzureAdObjectsWithPasswordsReply! (type)
        public static string RestoreAzureAdObjectsWithPasswords(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "restoreAzureAdObjectsWithPasswords" + args + "\n{\n" + fs + "}\n";
        }
        public static object RestoreAzureAdObjectsWithPasswordsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RestoreAzureAdObjectsWithPasswordsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RestoreDomainControllerSnapshot
        // GraphQL -> restoreDomainControllerSnapshot: AsyncRequestStatus! (type)
        public static string RestoreDomainControllerSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "restoreDomainControllerSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object RestoreDomainControllerSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RestoreFilesNutanixSnapshot
        // GraphQL -> restoreFilesNutanixSnapshot: AsyncRequestStatus! (type)
        public static string RestoreFilesNutanixSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "restoreFilesNutanixSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object RestoreFilesNutanixSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RestoreHypervVirtualMachineSnapshotFiles
        // GraphQL -> restoreHypervVirtualMachineSnapshotFiles: AsyncRequestStatus! (type)
        public static string RestoreHypervVirtualMachineSnapshotFiles(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "restoreHypervVirtualMachineSnapshotFiles" + args + "\n{\n" + fs + "}\n";
        }
        public static object RestoreHypervVirtualMachineSnapshotFilesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? RestoreK8sNamespace
        // GraphQL -> restoreK8sNamespace: CreateOnDemandJobReply! (type)
        public static string RestoreK8sNamespace(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "restoreK8sNamespace" + args + "\n{\n" + fs + "}\n";
        }
        public static object RestoreK8sNamespaceFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RestoreK8sProtectionSetSnapshot
        // GraphQL -> restoreK8sProtectionSetSnapshot: AsyncRequestStatus! (type)
        public static string RestoreK8sProtectionSetSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "restoreK8sProtectionSetSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object RestoreK8sProtectionSetSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RestoreMssqlDatabase
        // GraphQL -> restoreMssqlDatabase: AsyncRequestStatus! (type)
        public static string RestoreMssqlDatabase(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "restoreMssqlDatabase" + args + "\n{\n" + fs + "}\n";
        }
        public static object RestoreMssqlDatabaseFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RestoreNutanixVmSnapshotFilesFromArchivalLocation
        // GraphQL -> restoreNutanixVmSnapshotFilesFromArchivalLocation: AsyncRequestStatus! (type)
        public static string RestoreNutanixVmSnapshotFilesFromArchivalLocation(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "restoreNutanixVmSnapshotFilesFromArchivalLocation" + args + "\n{\n" + fs + "}\n";
        }
        public static object RestoreNutanixVmSnapshotFilesFromArchivalLocationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? RestoreO365FullTeams
        // GraphQL -> restoreO365FullTeams: CreateOnDemandJobReply! (type)
        public static string RestoreO365FullTeams(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "restoreO365FullTeams" + args + "\n{\n" + fs + "}\n";
        }
        public static object RestoreO365FullTeamsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? RestoreO365Mailbox
        // GraphQL -> restoreO365Mailbox: CreateOnDemandJobReply! (type)
        public static string RestoreO365Mailbox(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nrestoreConfig: $restoreConfig\n)";
            return "restoreO365Mailbox" + args + "\n{\n" + fs + "}\n";
        }
        public static object RestoreO365MailboxFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<CreateOnDemandJobReply>? RestoreO365MailboxV2
        // GraphQL -> restoreO365MailboxV2: [CreateOnDemandJobReply!]! (type)
        public static string RestoreO365MailboxV2(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "restoreO365MailboxV2" + args + "\n{\n" + fs + "}\n";
        }
        public static object RestoreO365MailboxV2FieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new List<CreateOnDemandJobReply>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? RestoreO365Snappable
        // GraphQL -> restoreO365Snappable: CreateOnDemandJobReply! (type)
        public static string RestoreO365Snappable(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "restoreO365Snappable" + args + "\n{\n" + fs + "}\n";
        }
        public static object RestoreO365SnappableFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? RestoreO365TeamsConversations
        // GraphQL -> restoreO365TeamsConversations: CreateOnDemandJobReply! (type)
        public static string RestoreO365TeamsConversations(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "restoreO365TeamsConversations" + args + "\n{\n" + fs + "}\n";
        }
        public static object RestoreO365TeamsConversationsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? RestoreO365TeamsFiles
        // GraphQL -> restoreO365TeamsFiles: CreateOnDemandJobReply! (type)
        public static string RestoreO365TeamsFiles(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "restoreO365TeamsFiles" + args + "\n{\n" + fs + "}\n";
        }
        public static object RestoreO365TeamsFilesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RestoreOracleLogs
        // GraphQL -> restoreOracleLogs: AsyncRequestStatus! (type)
        public static string RestoreOracleLogs(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "restoreOracleLogs" + args + "\n{\n" + fs + "}\n";
        }
        public static object RestoreOracleLogsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RestoreSapHanaSystemStorage
        // GraphQL -> restoreSapHanaSystemStorage: AsyncRequestStatus! (type)
        public static string RestoreSapHanaSystemStorage(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "restoreSapHanaSystemStorage" + args + "\n{\n" + fs + "}\n";
        }
        public static object RestoreSapHanaSystemStorageFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RestoreVolumeGroupSnapshotFiles
        // GraphQL -> restoreVolumeGroupSnapshotFiles: AsyncRequestStatus! (type)
        public static string RestoreVolumeGroupSnapshotFiles(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "restoreVolumeGroupSnapshotFiles" + args + "\n{\n" + fs + "}\n";
        }
        public static object RestoreVolumeGroupSnapshotFilesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResumeTargetReply? ResumeTarget
        // GraphQL -> resumeTarget: ResumeTargetReply! (type)
        public static string ResumeTarget(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "resumeTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object ResumeTargetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ResumeTargetReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RetryAddMongoSource
        // GraphQL -> retryAddMongoSource: AsyncRequestStatus! (type)
        public static string RetryAddMongoSource(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "retryAddMongoSource" + args + "\n{\n" + fs + "}\n";
        }
        public static object RetryAddMongoSourceFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RetryBackupResp? RetryBackup
        // GraphQL -> retryBackup: RetryBackupResp! (type)
        public static string RetryBackup(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nbackupObjects: $backupObjects\nbackupRunConfig: $backupRunConfig\n)";
            return "retryBackup" + args + "\n{\n" + fs + "}\n";
        }
        public static object RetryBackupFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RetryBackupResp() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DownloadPackageReply? RetryDownloadPackageJob
        // GraphQL -> retryDownloadPackageJob: DownloadPackageReply! (type)
        public static string RetryDownloadPackageJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            return "retryDownloadPackageJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object RetryDownloadPackageJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new DownloadPackageReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RotateServiceAccountSecretReply? RotateServiceAccountSecret
        // GraphQL -> rotateServiceAccountSecret: RotateServiceAccountSecretReply! (type)
        public static string RotateServiceAccountSecret(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "rotateServiceAccountSecret" + args + "\n{\n" + fs + "}\n";
        }
        public static object RotateServiceAccountSecretFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RotateServiceAccountSecretReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RunCustomAnalyzerReply? RunCustomAnalyzer
        // GraphQL -> runCustomAnalyzer: RunCustomAnalyzerReply! (type)
        public static string RunCustomAnalyzer(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "runCustomAnalyzer" + args + "\n{\n" + fs + "}\n";
        }
        public static object RunCustomAnalyzerFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RunCustomAnalyzerReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<UpgradeJobReplyWithUuid>? ScheduleUpgradeBatchJob
        // GraphQL -> scheduleUpgradeBatchJob: [UpgradeJobReplyWithUuid!]! (type)
        public static string ScheduleUpgradeBatchJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nlistClusterUuid: $listClusterUuid\nmode: $mode\naction: $action\nversion: $version\nscheduleAt: $scheduleAt\ncontext_tag: $context_tag\n)";
            return "scheduleUpgradeBatchJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object ScheduleUpgradeBatchJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new List<UpgradeJobReplyWithUuid>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SeedEnabledPoliciesReply? SeedEnabledPolicies
        // GraphQL -> seedEnabledPolicies: SeedEnabledPoliciesReply! (type)
        public static string SeedEnabledPolicies(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "";
            return "seedEnabledPolicies" + args + "\n{\n" + fs + "}\n";
        }
        public static object SeedEnabledPoliciesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new SeedEnabledPoliciesReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SeedInitialPoliciesReply? SeedInitialPolicies
        // GraphQL -> seedInitialPolicies: SeedInitialPoliciesReply! (type)
        public static string SeedInitialPolicies(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "";
            return "seedInitialPolicies" + args + "\n{\n" + fs + "}\n";
        }
        public static object SeedInitialPoliciesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new SeedInitialPoliciesReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SendPdfReportReply? SendPdfReport
        // GraphQL -> sendPdfReport: SendPdfReportReply! (type)
        public static string SendPdfReport(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "sendPdfReport" + args + "\n{\n" + fs + "}\n";
        }
        public static object SendPdfReportFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new SendPdfReportReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncDownloadReply? SendScheduledReportAsync
        // GraphQL -> sendScheduledReportAsync: AsyncDownloadReply! (type)
        public static string SendScheduledReportAsync(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "sendScheduledReportAsync" + args + "\n{\n" + fs + "}\n";
        }
        public static object SendScheduledReportAsyncFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncDownloadReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SendTestMessageToExistingWebhookReply? SendTestMessageToExistingWebhook
        // GraphQL -> sendTestMessageToExistingWebhook: SendTestMessageToExistingWebhookReply! (type)
        public static string SendTestMessageToExistingWebhook(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "sendTestMessageToExistingWebhook" + args + "\n{\n" + fs + "}\n";
        }
        public static object SendTestMessageToExistingWebhookFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new SendTestMessageToExistingWebhookReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SendTestMessageToWebhookReply? SendTestMessageToWebhook
        // GraphQL -> sendTestMessageToWebhook: SendTestMessageToWebhookReply! (type)
        public static string SendTestMessageToWebhook(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "sendTestMessageToWebhook" + args + "\n{\n" + fs + "}\n";
        }
        public static object SendTestMessageToWebhookFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new SendTestMessageToWebhookReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SetAnalyzerRisksReply? SetAnalyzerRisks
        // GraphQL -> setAnalyzerRisks: SetAnalyzerRisksReply! (type)
        public static string SetAnalyzerRisks(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "setAnalyzerRisks" + args + "\n{\n" + fs + "}\n";
        }
        public static object SetAnalyzerRisksFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new SetAnalyzerRisksReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SetDatastoreFreespaceThresholdsReply? SetDatastoreFreespaceThresholds
        // GraphQL -> setDatastoreFreespaceThresholds: SetDatastoreFreespaceThresholdsReply! (type)
        public static string SetDatastoreFreespaceThresholds(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "setDatastoreFreespaceThresholds" + args + "\n{\n" + fs + "}\n";
        }
        public static object SetDatastoreFreespaceThresholdsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new SetDatastoreFreespaceThresholdsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SetHostRbsNetworkLimitReply? SetHostRbsNetworkLimit
        // GraphQL -> setHostRbsNetworkLimit: SetHostRbsNetworkLimitReply! (type)
        public static string SetHostRbsNetworkLimit(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "setHostRbsNetworkLimit" + args + "\n{\n" + fs + "}\n";
        }
        public static object SetHostRbsNetworkLimitFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new SetHostRbsNetworkLimitReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SetMissingClusterStatusReply? SetMissingClusterStatus
        // GraphQL -> setMissingClusterStatus: SetMissingClusterStatusReply! (type)
        public static string SetMissingClusterStatus(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "setMissingClusterStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object SetMissingClusterStatusFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new SetMissingClusterStatusReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestStatus? SetO365ServiceAccount
        // GraphQL -> setO365ServiceAccount: RequestStatus! (type)
        public static string SetO365ServiceAccount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nusername: $username\nappPassword: $appPassword\norgId: $orgId\n)";
            return "setO365ServiceAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object SetO365ServiceAccountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SetUpgradeTypeReply? SetUpgradeType
        // GraphQL -> setUpgradeType: SetUpgradeTypeReply! (type)
        public static string SetUpgradeType(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "setUpgradeType" + args + "\n{\n" + fs + "}\n";
        }
        public static object SetUpgradeTypeFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new SetUpgradeTypeReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SetUserSessionManagementConfigReply? SetUserSessionManagementConfig
        // GraphQL -> setUserSessionManagementConfig: SetUserSessionManagementConfigReply! (type)
        public static string SetUserSessionManagementConfig(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "setUserSessionManagementConfig" + args + "\n{\n" + fs + "}\n";
        }
        public static object SetUserSessionManagementConfigFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new SetUserSessionManagementConfigReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? SetWebSignedCertificate
        // GraphQL -> setWebSignedCertificate: AsyncRequestStatus! (type)
        public static string SetWebSignedCertificate(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "setWebSignedCertificate" + args + "\n{\n" + fs + "}\n";
        }
        public static object SetWebSignedCertificateFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SetWorkloadAlertSettingReply? SetWorkloadAlertSetting
        // GraphQL -> setWorkloadAlertSetting: SetWorkloadAlertSettingReply! (type)
        public static string SetWorkloadAlertSetting(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "setWorkloadAlertSetting" + args + "\n{\n" + fs + "}\n";
        }
        public static object SetWorkloadAlertSettingFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new SetWorkloadAlertSettingReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SetupAzureO365ExocomputeResp? SetupAzureO365Exocompute
        // GraphQL -> setupAzureO365Exocompute: SetupAzureO365ExocomputeResp! (type)
        public static string SetupAzureO365Exocompute(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nexocomputeConfig: $exocomputeConfig\n)";
            return "setupAzureO365Exocompute" + args + "\n{\n" + fs + "}\n";
        }
        public static object SetupAzureO365ExocomputeFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new SetupAzureO365ExocomputeResp() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? SetupCloudNativeSqlServerBackup
        // GraphQL -> setupCloudNativeSqlServerBackup: BatchAsyncJobStatus! (type)
        public static string SetupCloudNativeSqlServerBackup(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "setupCloudNativeSqlServerBackup" + args + "\n{\n" + fs + "}\n";
        }
        public static object SetupCloudNativeSqlServerBackupFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DiskInfo? SetupDisk
        // GraphQL -> setupDisk: DiskInfo! (type)
        public static string SetupDisk(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "setupDisk" + args + "\n{\n" + fs + "}\n";
        }
        public static object SetupDiskFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new DiskInfo() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? StartAwsExocomputeDisableJob
        // GraphQL -> startAwsExocomputeDisableJob: AsyncJobStatus! (type)
        public static string StartAwsExocomputeDisableJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startAwsExocomputeDisableJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartAwsExocomputeDisableJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? StartAwsNativeAccountDisableJob
        // GraphQL -> startAwsNativeAccountDisableJob: AsyncJobStatus! (type)
        public static string StartAwsNativeAccountDisableJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startAwsNativeAccountDisableJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartAwsNativeAccountDisableJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? StartAwsNativeEc2InstanceSnapshotsJob
        // GraphQL -> startAwsNativeEc2InstanceSnapshotsJob: BatchAsyncJobStatus! (type)
        public static string StartAwsNativeEc2InstanceSnapshotsJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startAwsNativeEc2InstanceSnapshotsJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartAwsNativeEc2InstanceSnapshotsJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? StartAwsNativeRdsInstanceSnapshotsJob
        // GraphQL -> startAwsNativeRdsInstanceSnapshotsJob: BatchAsyncJobStatus! (type)
        public static string StartAwsNativeRdsInstanceSnapshotsJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startAwsNativeRdsInstanceSnapshotsJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartAwsNativeRdsInstanceSnapshotsJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> StartAzureAdAppSetupReply? StartAzureAdAppSetup
        // GraphQL -> startAzureAdAppSetup: StartAzureAdAppSetupReply! (type)
        public static string StartAzureAdAppSetup(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startAzureAdAppSetup" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartAzureAdAppSetupFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new StartAzureAdAppSetupReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> StartAzureAdAppUpdateReply? StartAzureAdAppUpdate
        // GraphQL -> startAzureAdAppUpdate: StartAzureAdAppUpdateReply! (type)
        public static string StartAzureAdAppUpdate(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startAzureAdAppUpdate" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartAzureAdAppUpdateFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new StartAzureAdAppUpdateReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> StartAzureCloudAccountOauthReply? StartAzureCloudAccountOauth
        // GraphQL -> startAzureCloudAccountOauth: StartAzureCloudAccountOauthReply! (type)
        public static string StartAzureCloudAccountOauth(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startAzureCloudAccountOauth" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartAzureCloudAccountOauthFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new StartAzureCloudAccountOauthReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> StartBulkThreatHuntReply? StartBulkThreatHunt
        // GraphQL -> startBulkThreatHunt: StartBulkThreatHuntReply! (type)
        public static string StartBulkThreatHunt(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startBulkThreatHunt" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartBulkThreatHuntFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new StartBulkThreatHuntReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? StartCloudNativeSnapshotsIndexJob
        // GraphQL -> startCloudNativeSnapshotsIndexJob: BatchAsyncJobStatus! (type)
        public static string StartCloudNativeSnapshotsIndexJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startCloudNativeSnapshotsIndexJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartCloudNativeSnapshotsIndexJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> StartClusterReportMigrationJobReply? StartClusterReportMigrationJob
        // GraphQL -> startClusterReportMigrationJob: StartClusterReportMigrationJobReply! (type)
        public static string StartClusterReportMigrationJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startClusterReportMigrationJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartClusterReportMigrationJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new StartClusterReportMigrationJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> StartCrawlReply? StartCrawl
        // GraphQL -> startCrawl: StartCrawlReply! (type)
        public static string StartCrawl(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nname: $name\nresources: $resources\nanalyzerGroups: $analyzerGroups\nextWhiteList: $extWhiteList\n)";
            return "startCrawl" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartCrawlFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new StartCrawlReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? StartCreateAwsNativeEbsVolumeSnapshotsJob
        // GraphQL -> startCreateAwsNativeEbsVolumeSnapshotsJob: BatchAsyncJobStatus! (type)
        public static string StartCreateAwsNativeEbsVolumeSnapshotsJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startCreateAwsNativeEbsVolumeSnapshotsJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartCreateAwsNativeEbsVolumeSnapshotsJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? StartCreateAzureNativeManagedDiskSnapshotsJob
        // GraphQL -> startCreateAzureNativeManagedDiskSnapshotsJob: BatchAsyncJobStatus! (type)
        public static string StartCreateAzureNativeManagedDiskSnapshotsJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startCreateAzureNativeManagedDiskSnapshotsJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartCreateAzureNativeManagedDiskSnapshotsJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? StartCreateAzureNativeVirtualMachineSnapshotsJob
        // GraphQL -> startCreateAzureNativeVirtualMachineSnapshotsJob: BatchAsyncJobStatus! (type)
        public static string StartCreateAzureNativeVirtualMachineSnapshotsJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startCreateAzureNativeVirtualMachineSnapshotsJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartCreateAzureNativeVirtualMachineSnapshotsJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? StartDisableAzureCloudAccountJob
        // GraphQL -> startDisableAzureCloudAccountJob: BatchAsyncJobStatus! (type)
        public static string StartDisableAzureCloudAccountJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startDisableAzureCloudAccountJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartDisableAzureCloudAccountJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? StartDisableAzureNativeSubscriptionProtectionJob
        // GraphQL -> startDisableAzureNativeSubscriptionProtectionJob: AsyncJobStatus! (type)
        public static string StartDisableAzureNativeSubscriptionProtectionJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startDisableAzureNativeSubscriptionProtectionJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartDisableAzureNativeSubscriptionProtectionJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<DownloadPackageReplyWithUuid>? StartDownloadPackageBatchJob
        // GraphQL -> startDownloadPackageBatchJob: [DownloadPackageReplyWithUuid!]! (type)
        public static string StartDownloadPackageBatchJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nlistClusterUuid: $listClusterUuid\ndownloadVersion: $downloadVersion\npackageUrl: $packageUrl\nmd5checksum: $md5checksum\nsize: $size\n)";
            return "startDownloadPackageBatchJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartDownloadPackageBatchJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new List<DownloadPackageReplyWithUuid>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? StartEc2InstanceSnapshotExportJob
        // GraphQL -> startEc2InstanceSnapshotExportJob: AsyncJobStatus! (type)
        public static string StartEc2InstanceSnapshotExportJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startEc2InstanceSnapshotExportJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartEc2InstanceSnapshotExportJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? StartExportAwsNativeEbsVolumeSnapshotJob
        // GraphQL -> startExportAwsNativeEbsVolumeSnapshotJob: AsyncJobStatus! (type)
        public static string StartExportAwsNativeEbsVolumeSnapshotJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startExportAwsNativeEbsVolumeSnapshotJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartExportAwsNativeEbsVolumeSnapshotJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? StartExportAzureNativeManagedDiskJob
        // GraphQL -> startExportAzureNativeManagedDiskJob: AsyncJobStatus! (type)
        public static string StartExportAzureNativeManagedDiskJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startExportAzureNativeManagedDiskJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartExportAzureNativeManagedDiskJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? StartExportAzureNativeVirtualMachineJob
        // GraphQL -> startExportAzureNativeVirtualMachineJob: AsyncJobStatus! (type)
        public static string StartExportAzureNativeVirtualMachineJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startExportAzureNativeVirtualMachineJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartExportAzureNativeVirtualMachineJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? StartExportAzureSqlDatabaseDbJob
        // GraphQL -> startExportAzureSqlDatabaseDbJob: AsyncJobStatus! (type)
        public static string StartExportAzureSqlDatabaseDbJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startExportAzureSqlDatabaseDbJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartExportAzureSqlDatabaseDbJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? StartExportAzureSqlManagedInstanceDbJob
        // GraphQL -> startExportAzureSqlManagedInstanceDbJob: AsyncJobStatus! (type)
        public static string StartExportAzureSqlManagedInstanceDbJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startExportAzureSqlManagedInstanceDbJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartExportAzureSqlManagedInstanceDbJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? StartExportRdsInstanceJob
        // GraphQL -> startExportRdsInstanceJob: AsyncJobStatus! (type)
        public static string StartExportRdsInstanceJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startExportRdsInstanceJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartExportRdsInstanceJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PrechecksJobReply? StartPeriodicUpgradePrechecksOnDemandJob
        // GraphQL -> startPeriodicUpgradePrechecksOnDemandJob: PrechecksJobReply! (type)
        public static string StartPeriodicUpgradePrechecksOnDemandJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            return "startPeriodicUpgradePrechecksOnDemandJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartPeriodicUpgradePrechecksOnDemandJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new PrechecksJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? StartRecoverS3SnapshotJob
        // GraphQL -> startRecoverS3SnapshotJob: AsyncJobStatus! (type)
        public static string StartRecoverS3SnapshotJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startRecoverS3SnapshotJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartRecoverS3SnapshotJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? StartRefreshAwsNativeAccountsJob
        // GraphQL -> startRefreshAwsNativeAccountsJob: BatchAsyncJobStatus! (type)
        public static string StartRefreshAwsNativeAccountsJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startRefreshAwsNativeAccountsJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartRefreshAwsNativeAccountsJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? StartRefreshAzureNativeSubscriptionsJob
        // GraphQL -> startRefreshAzureNativeSubscriptionsJob: BatchAsyncJobStatus! (type)
        public static string StartRefreshAzureNativeSubscriptionsJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startRefreshAzureNativeSubscriptionsJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartRefreshAzureNativeSubscriptionsJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? StartRestoreAwsNativeEc2InstanceSnapshotJob
        // GraphQL -> startRestoreAwsNativeEc2InstanceSnapshotJob: AsyncJobStatus! (type)
        public static string StartRestoreAwsNativeEc2InstanceSnapshotJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startRestoreAwsNativeEc2InstanceSnapshotJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartRestoreAwsNativeEc2InstanceSnapshotJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? StartRestoreAzureNativeVirtualMachineJob
        // GraphQL -> startRestoreAzureNativeVirtualMachineJob: AsyncJobStatus! (type)
        public static string StartRestoreAzureNativeVirtualMachineJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startRestoreAzureNativeVirtualMachineJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartRestoreAzureNativeVirtualMachineJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> StartThreatHuntReply? StartThreatHunt
        // GraphQL -> startThreatHunt: StartThreatHuntReply! (type)
        public static string StartThreatHunt(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startThreatHunt" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartThreatHuntFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new StartThreatHuntReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> StartThreatHuntV2Reply? StartThreatHuntV2
        // GraphQL -> startThreatHuntV2: StartThreatHuntV2Reply! (type)
        public static string StartThreatHuntV2(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startThreatHuntV2" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartThreatHuntV2FieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new StartThreatHuntV2Reply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> StartTurboThreatHuntReply? StartTurboThreatHunt
        // GraphQL -> startTurboThreatHunt: StartTurboThreatHuntReply! (type)
        public static string StartTurboThreatHunt(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startTurboThreatHunt" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartTurboThreatHuntFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new StartTurboThreatHuntReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<UpgradeJobReplyWithUuid>? StartUpgradeBatchJob
        // GraphQL -> startUpgradeBatchJob: [UpgradeJobReplyWithUuid!]! (type)
        public static string StartUpgradeBatchJob(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nlistClusterUuid: $listClusterUuid\nmode: $mode\naction: $action\nversion: $version\ncontext_tag: $context_tag\n)";
            return "startUpgradeBatchJob" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartUpgradeBatchJobFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new List<UpgradeJobReplyWithUuid>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? StartVolumeGroupMount
        // GraphQL -> startVolumeGroupMount: AsyncRequestStatus! (type)
        public static string StartVolumeGroupMount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "startVolumeGroupMount" + args + "\n{\n" + fs + "}\n";
        }
        public static object StartVolumeGroupMountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> StopJobInstanceReply? StopJobInstance
        // GraphQL -> stopJobInstance: StopJobInstanceReply! (type)
        public static string StopJobInstance(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "stopJobInstance" + args + "\n{\n" + fs + "}\n";
        }
        public static object StopJobInstanceFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new StopJobInstanceReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SupportPortalLoginReply? SupportPortalLogin
        // GraphQL -> supportPortalLogin: SupportPortalLoginReply! (type)
        public static string SupportPortalLogin(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "supportPortalLogin" + args + "\n{\n" + fs + "}\n";
        }
        public static object SupportPortalLoginFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new SupportPortalLoginReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncRequestStatus? TakeCloudDirectSnapshot
        // GraphQL -> takeCloudDirectSnapshot: BatchAsyncRequestStatus! (type)
        public static string TakeCloudDirectSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "takeCloudDirectSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object TakeCloudDirectSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchAsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? TakeManagedVolumeOnDemandSnapshot
        // GraphQL -> takeManagedVolumeOnDemandSnapshot: AsyncRequestStatus! (type)
        public static string TakeManagedVolumeOnDemandSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "takeManagedVolumeOnDemandSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object TakeManagedVolumeOnDemandSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? TakeMssqlLogBackup
        // GraphQL -> takeMssqlLogBackup: AsyncRequestStatus! (type)
        public static string TakeMssqlLogBackup(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "takeMssqlLogBackup" + args + "\n{\n" + fs + "}\n";
        }
        public static object TakeMssqlLogBackupFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? TakeOnDemandOracleDatabaseSnapshot
        // GraphQL -> takeOnDemandOracleDatabaseSnapshot: AsyncRequestStatus! (type)
        public static string TakeOnDemandOracleDatabaseSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "takeOnDemandOracleDatabaseSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object TakeOnDemandOracleDatabaseSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? TakeOnDemandOracleLogSnapshot
        // GraphQL -> takeOnDemandOracleLogSnapshot: AsyncRequestStatus! (type)
        public static string TakeOnDemandOracleLogSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "takeOnDemandOracleLogSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object TakeOnDemandOracleLogSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TakeOnDemandSnapshotReply? TakeOnDemandSnapshot
        // GraphQL -> takeOnDemandSnapshot: TakeOnDemandSnapshotReply! (type)
        public static string TakeOnDemandSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "takeOnDemandSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object TakeOnDemandSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new TakeOnDemandSnapshotReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TestExistingWebhookReply? TestExistingWebhook
        // GraphQL -> testExistingWebhook: TestExistingWebhookReply! (type)
        public static string TestExistingWebhook(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "testExistingWebhook" + args + "\n{\n" + fs + "}\n";
        }
        public static object TestExistingWebhookFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new TestExistingWebhookReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TestSyslogExportRuleReply? TestSyslogExportRule
        // GraphQL -> testSyslogExportRule: TestSyslogExportRuleReply! (type)
        public static string TestSyslogExportRule(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "testSyslogExportRule" + args + "\n{\n" + fs + "}\n";
        }
        public static object TestSyslogExportRuleFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new TestSyslogExportRuleReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TestWebhookReply? TestWebhook
        // GraphQL -> testWebhook: TestWebhookReply! (type)
        public static string TestWebhook(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "testWebhook" + args + "\n{\n" + fs + "}\n";
        }
        public static object TestWebhookFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new TestWebhookReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? TriggerCloudComputeConnectivityCheck
        // GraphQL -> triggerCloudComputeConnectivityCheck: AsyncRequestStatus! (type)
        public static string TriggerCloudComputeConnectivityCheck(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "triggerCloudComputeConnectivityCheck" + args + "\n{\n" + fs + "}\n";
        }
        public static object TriggerCloudComputeConnectivityCheckFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TriggerExocomputeHealthCheckReply? TriggerExocomputeHealthCheck
        // GraphQL -> triggerExocomputeHealthCheck: TriggerExocomputeHealthCheckReply! (type)
        public static string TriggerExocomputeHealthCheck(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "triggerExocomputeHealthCheck" + args + "\n{\n" + fs + "}\n";
        }
        public static object TriggerExocomputeHealthCheckFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new TriggerExocomputeHealthCheckReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TriggerRansomwareDetectionReply? TriggerRansomwareDetection
        // GraphQL -> triggerRansomwareDetection: TriggerRansomwareDetectionReply! (type)
        public static string TriggerRansomwareDetection(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "triggerRansomwareDetection" + args + "\n{\n" + fs + "}\n";
        }
        public static object TriggerRansomwareDetectionFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new TriggerRansomwareDetectionReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? UnconfigureSapHanaRestore
        // GraphQL -> unconfigureSapHanaRestore: AsyncRequestStatus! (type)
        public static string UnconfigureSapHanaRestore(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "unconfigureSapHanaRestore" + args + "\n{\n" + fs + "}\n";
        }
        public static object UnconfigureSapHanaRestoreFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? UninstallIoFilter
        // GraphQL -> uninstallIoFilter: RequestSuccess! (type)
        public static string UninstallIoFilter(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "uninstallIoFilter" + args + "\n{\n" + fs + "}\n";
        }
        public static object UninstallIoFilterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UnmapAzureCloudAccountExocomputeSubscriptionReply? UnmapAzureCloudAccountExocomputeSubscription
        // GraphQL -> unmapAzureCloudAccountExocomputeSubscription: UnmapAzureCloudAccountExocomputeSubscriptionReply! (type)
        public static string UnmapAzureCloudAccountExocomputeSubscription(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "unmapAzureCloudAccountExocomputeSubscription" + args + "\n{\n" + fs + "}\n";
        }
        public static object UnmapAzureCloudAccountExocomputeSubscriptionFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UnmapAzureCloudAccountExocomputeSubscriptionReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UnmapCloudAccountExocomputeAccountReply? UnmapCloudAccountExocomputeAccount
        // GraphQL -> unmapCloudAccountExocomputeAccount: UnmapCloudAccountExocomputeAccountReply! (type)
        public static string UnmapCloudAccountExocomputeAccount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "unmapCloudAccountExocomputeAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object UnmapCloudAccountExocomputeAccountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UnmapCloudAccountExocomputeAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AgentDeploymentSettings? UpdateAgentDeploymentSetting
        // GraphQL -> updateAgentDeploymentSetting: AgentDeploymentSettings! (type)
        public static string UpdateAgentDeploymentSetting(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateAgentDeploymentSetting" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateAgentDeploymentSettingFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AgentDeploymentSettings() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateAgentDeploymentSettingInBatchReply? UpdateAgentDeploymentSettingInBatch
        // GraphQL -> updateAgentDeploymentSettingInBatch: UpdateAgentDeploymentSettingInBatchReply! (type)
        public static string UpdateAgentDeploymentSettingInBatch(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateAgentDeploymentSettingInBatch" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateAgentDeploymentSettingInBatchFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateAgentDeploymentSettingInBatchReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateAgentDeploymentSettingInBatchNewReply? UpdateAgentDeploymentSettingInBatchNew
        // GraphQL -> updateAgentDeploymentSettingInBatchNew: UpdateAgentDeploymentSettingInBatchNewReply! (type)
        public static string UpdateAgentDeploymentSettingInBatchNew(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateAgentDeploymentSettingInBatchNew" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateAgentDeploymentSettingInBatchNewFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateAgentDeploymentSettingInBatchNewReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateAutoEnablePolicyClusterConfigReply? UpdateAutoEnablePolicyClusterConfig
        // GraphQL -> updateAutoEnablePolicyClusterConfig: UpdateAutoEnablePolicyClusterConfigReply! (type)
        public static string UpdateAutoEnablePolicyClusterConfig(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateAutoEnablePolicyClusterConfig" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateAutoEnablePolicyClusterConfigFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateAutoEnablePolicyClusterConfigReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TargetMapping? UpdateAutomaticAwsTargetMapping
        // GraphQL -> updateAutomaticAwsTargetMapping: TargetMapping! (type)
        public static string UpdateAutomaticAwsTargetMapping(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateAutomaticAwsTargetMapping" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateAutomaticAwsTargetMappingFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new TargetMapping() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TargetMapping? UpdateAutomaticAzureTargetMapping
        // GraphQL -> updateAutomaticAzureTargetMapping: TargetMapping! (type)
        public static string UpdateAutomaticAzureTargetMapping(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateAutomaticAzureTargetMapping" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateAutomaticAzureTargetMappingFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new TargetMapping() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateAwsCloudAccountFeatureReply? UpdateAwsCloudAccountFeature
        // GraphQL -> updateAwsCloudAccountFeature: UpdateAwsCloudAccountFeatureReply! (type)
        public static string UpdateAwsCloudAccountFeature(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateAwsCloudAccountFeature" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateAwsCloudAccountFeatureFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateAwsCloudAccountFeatureReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsComputeSettings? UpdateAwsComputeSetting
        // GraphQL -> updateAwsComputeSetting: AwsComputeSettings! (type)
        public static string UpdateAwsComputeSetting(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateAwsComputeSetting" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateAwsComputeSettingFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AwsComputeSettings() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateAwsExocomputeConfigsReply? UpdateAwsExocomputeConfigs
        // GraphQL -> updateAwsExocomputeConfigs: UpdateAwsExocomputeConfigsReply! (type)
        public static string UpdateAwsExocomputeConfigs(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateAwsExocomputeConfigs" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateAwsExocomputeConfigsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateAwsExocomputeConfigsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateAzureCloudAccountReply? UpdateAzureCloudAccount
        // GraphQL -> updateAzureCloudAccount: UpdateAzureCloudAccountReply! (type)
        public static string UpdateAzureCloudAccount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateAzureCloudAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateAzureCloudAccountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateAzureCloudAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateBackupThrottleSettingReply? UpdateBackupThrottleSetting
        // GraphQL -> updateBackupThrottleSetting: UpdateBackupThrottleSettingReply! (type)
        public static string UpdateBackupThrottleSetting(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateBackupThrottleSetting" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateBackupThrottleSettingFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateBackupThrottleSettingReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateBadDiskLedStatusReply? UpdateBadDiskLedStatus
        // GraphQL -> updateBadDiskLedStatus: UpdateBadDiskLedStatusReply! (type)
        public static string UpdateBadDiskLedStatus(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateBadDiskLedStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateBadDiskLedStatusFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateBadDiskLedStatusReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicAsyncResponse? UpdateCassandraSource
        // GraphQL -> updateCassandraSource: MosaicAsyncResponse! (type)
        public static string UpdateCassandraSource(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateCassandraSource" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateCassandraSourceFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new MosaicAsyncResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateCertificateHostReply? UpdateCertificateHost
        // GraphQL -> updateCertificateHost: UpdateCertificateHostReply! (type)
        public static string UpdateCertificateHost(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateCertificateHost" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateCertificateHostFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateCertificateHostReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateCloudNativeAwsStorageSettingReply? UpdateCloudNativeAwsStorageSetting
        // GraphQL -> updateCloudNativeAwsStorageSetting: UpdateCloudNativeAwsStorageSettingReply! (type)
        public static string UpdateCloudNativeAwsStorageSetting(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateCloudNativeAwsStorageSetting" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateCloudNativeAwsStorageSettingFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateCloudNativeAwsStorageSettingReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateCloudNativeAzureStorageSettingReply? UpdateCloudNativeAzureStorageSetting
        // GraphQL -> updateCloudNativeAzureStorageSetting: UpdateCloudNativeAzureStorageSettingReply! (type)
        public static string UpdateCloudNativeAzureStorageSetting(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateCloudNativeAzureStorageSetting" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateCloudNativeAzureStorageSettingFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateCloudNativeAzureStorageSettingReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateCloudNativeIndexingStatusReply? UpdateCloudNativeIndexingStatus
        // GraphQL -> updateCloudNativeIndexingStatus: UpdateCloudNativeIndexingStatusReply! (type)
        public static string UpdateCloudNativeIndexingStatus(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateCloudNativeIndexingStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateCloudNativeIndexingStatusFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateCloudNativeIndexingStatusReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateCloudNativeRcvAzureStorageSettingReply? UpdateCloudNativeRcvAzureStorageSetting
        // GraphQL -> updateCloudNativeRcvAzureStorageSetting: UpdateCloudNativeRcvAzureStorageSettingReply! (type)
        public static string UpdateCloudNativeRcvAzureStorageSetting(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateCloudNativeRcvAzureStorageSetting" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateCloudNativeRcvAzureStorageSettingFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateCloudNativeRcvAzureStorageSettingReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateClusterDefaultAddressReply? UpdateClusterDefaultAddress
        // GraphQL -> updateClusterDefaultAddress: UpdateClusterDefaultAddressReply! (type)
        public static string UpdateClusterDefaultAddress(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateClusterDefaultAddress" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateClusterDefaultAddressFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateClusterDefaultAddressReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Cluster? UpdateClusterLocation
        // GraphQL -> updateClusterLocation: Cluster! (type)
        public static string UpdateClusterLocation(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nclusterUuid: $clusterUuid\nclusterLocation: $clusterLocation\n)";
            return "updateClusterLocation" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateClusterLocationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new Cluster() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? UpdateClusterNtpServers
        // GraphQL -> updateClusterNtpServers: ResponseSuccess! (type)
        public static string UpdateClusterNtpServers(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateClusterNtpServers" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateClusterNtpServersFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateClusterPauseStatusReply? UpdateClusterPauseStatus
        // GraphQL -> updateClusterPauseStatus: UpdateClusterPauseStatusReply! (type)
        public static string UpdateClusterPauseStatus(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateClusterPauseStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateClusterPauseStatusFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateClusterPauseStatusReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateClusterSettingsReply? UpdateClusterSettings
        // GraphQL -> updateClusterSettings: UpdateClusterSettingsReply! (type)
        public static string UpdateClusterSettings(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateClusterSettings" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateClusterSettingsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateClusterSettingsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Analyzer? UpdateCustomAnalyzer
        // GraphQL -> updateCustomAnalyzer: Analyzer! (type)
        public static string UpdateCustomAnalyzer(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateCustomAnalyzer" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateCustomAnalyzerFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new Analyzer() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateCustomReportReply? UpdateCustomReport
        // GraphQL -> updateCustomReport: UpdateCustomReportReply! (type)
        public static string UpdateCustomReport(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateCustomReport" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateCustomReportFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateCustomReportReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateCustomerAppPermissionsReply? UpdateCustomerAppPermissions
        // GraphQL -> updateCustomerAppPermissions: UpdateCustomerAppPermissionsReply! (type)
        public static string UpdateCustomerAppPermissions(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateCustomerAppPermissions" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateCustomerAppPermissionsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateCustomerAppPermissionsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DbLogReportProperties? UpdateDatabaseLogReportingPropertiesForCluster
        // GraphQL -> updateDatabaseLogReportingPropertiesForCluster: DbLogReportProperties! (type)
        public static string UpdateDatabaseLogReportingPropertiesForCluster(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateDatabaseLogReportingPropertiesForCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateDatabaseLogReportingPropertiesForClusterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new DbLogReportProperties() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateDistributionListDigestReply? UpdateDistributionListDigest
        // GraphQL -> updateDistributionListDigest: UpdateDistributionListDigestReply! (type)
        public static string UpdateDistributionListDigest(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateDistributionListDigest" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateDistributionListDigestFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateDistributionListDigestReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? UpdateDnsServersAndSearchDomains
        // GraphQL -> updateDnsServersAndSearchDomains: ResponseSuccess! (type)
        public static string UpdateDnsServersAndSearchDomains(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateDnsServersAndSearchDomains" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateDnsServersAndSearchDomainsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateEventDigestReply? UpdateEventDigest
        // GraphQL -> updateEventDigest: UpdateEventDigestReply! (type)
        public static string UpdateEventDigest(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateEventDigest" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateEventDigestFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateEventDigestReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateFailoverClusterReply? UpdateFailoverCluster
        // GraphQL -> updateFailoverCluster: UpdateFailoverClusterReply! (type)
        public static string UpdateFailoverCluster(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateFailoverCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateFailoverClusterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateFailoverClusterReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateFailoverClusterAppReply? UpdateFailoverClusterApp
        // GraphQL -> updateFailoverClusterApp: UpdateFailoverClusterAppReply! (type)
        public static string UpdateFailoverClusterApp(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateFailoverClusterApp" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateFailoverClusterAppFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateFailoverClusterAppReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> FilesetDetail? UpdateFileset
        // GraphQL -> updateFileset: FilesetDetail! (type)
        public static string UpdateFileset(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateFileset" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateFilesetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new FilesetDetail() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateFloatingIpsReply? UpdateFloatingIps
        // GraphQL -> updateFloatingIps: UpdateFloatingIpsReply! (type)
        public static string UpdateFloatingIps(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateFloatingIps" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateFloatingIpsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateFloatingIpsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateGlobalCertificateReply? UpdateGlobalCertificate
        // GraphQL -> updateGlobalCertificate: UpdateGlobalCertificateReply! (type)
        public static string UpdateGlobalCertificate(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateGlobalCertificate" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateGlobalCertificateFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateGlobalCertificateReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GlobalSlaReply? UpdateGlobalSla
        // GraphQL -> updateGlobalSla: GlobalSlaReply! (type)
        public static string UpdateGlobalSla(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateGlobalSla" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateGlobalSlaFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new GlobalSlaReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateGuestCredentialReply? UpdateGuestCredential
        // GraphQL -> updateGuestCredential: UpdateGuestCredentialReply! (type)
        public static string UpdateGuestCredential(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateGuestCredential" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateGuestCredentialFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateGuestCredentialReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateHealthMonitorPolicyStatusReply? UpdateHealthMonitorPolicyStatus
        // GraphQL -> updateHealthMonitorPolicyStatus: UpdateHealthMonitorPolicyStatusReply! (type)
        public static string UpdateHealthMonitorPolicyStatus(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateHealthMonitorPolicyStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateHealthMonitorPolicyStatusFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateHealthMonitorPolicyStatusReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateHypervVirtualMachineReply? UpdateHypervVirtualMachine
        // GraphQL -> updateHypervVirtualMachine: UpdateHypervVirtualMachineReply! (type)
        public static string UpdateHypervVirtualMachine(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateHypervVirtualMachine" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateHypervVirtualMachineFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateHypervVirtualMachineReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateHypervVirtualMachineSnapshotMountReply? UpdateHypervVirtualMachineSnapshotMount
        // GraphQL -> updateHypervVirtualMachineSnapshotMount: UpdateHypervVirtualMachineSnapshotMountReply! (type)
        public static string UpdateHypervVirtualMachineSnapshotMount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateHypervVirtualMachineSnapshotMount" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateHypervVirtualMachineSnapshotMountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateHypervVirtualMachineSnapshotMountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateInsightStateReply? UpdateInsightState
        // GraphQL -> updateInsightState: UpdateInsightStateReply! (type)
        public static string UpdateInsightState(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateInsightState" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateInsightStateFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateInsightStateReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? UpdateK8sCluster
        // GraphQL -> updateK8sCluster: ResponseSuccess! (type)
        public static string UpdateK8sCluster(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateK8sCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateK8sClusterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? UpdateK8sProtectionSet
        // GraphQL -> updateK8sProtectionSet: ResponseSuccess! (type)
        public static string UpdateK8sProtectionSet(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateK8sProtectionSet" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateK8sProtectionSetFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> LambdaSettings? UpdateLambdaSettings
        // GraphQL -> updateLambdaSettings: LambdaSettings! (type)
        public static string UpdateLambdaSettings(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\nanomalyThreshold: $anomalyThreshold\nransomwareThreshold: $ransomwareThreshold\nisAnomalyAlertEnabled: $isAnomalyAlertEnabled\n)";
            return "updateLambdaSettings" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateLambdaSettingsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new LambdaSettings() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateLockoutConfigReply? UpdateLockoutConfig
        // GraphQL -> updateLockoutConfig: UpdateLockoutConfigReply! (type)
        public static string UpdateLockoutConfig(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateLockoutConfig" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateLockoutConfigFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateLockoutConfigReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateManagedIdentitiesReply? UpdateManagedIdentities
        // GraphQL -> updateManagedIdentities: UpdateManagedIdentitiesReply! (type)
        public static string UpdateManagedIdentities(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateManagedIdentities" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateManagedIdentitiesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateManagedIdentitiesReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CcProvisionJobReply? UpdateManagedIdentitiesAsync
        // GraphQL -> updateManagedIdentitiesAsync: CcProvisionJobReply! (type)
        public static string UpdateManagedIdentitiesAsync(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateManagedIdentitiesAsync" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateManagedIdentitiesAsyncFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new CcProvisionJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateManagedVolumeReply? UpdateManagedVolume
        // GraphQL -> updateManagedVolume: UpdateManagedVolumeReply! (type)
        public static string UpdateManagedVolume(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateManagedVolume" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateManagedVolumeFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateManagedVolumeReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TargetMapping? UpdateManualTargetMapping
        // GraphQL -> updateManualTargetMapping: TargetMapping! (type)
        public static string UpdateManualTargetMapping(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateManualTargetMapping" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateManualTargetMappingFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new TargetMapping() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicAsyncResponse? UpdateMongodbSource
        // GraphQL -> updateMongodbSource: MosaicAsyncResponse! (type)
        public static string UpdateMongodbSource(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateMongodbSource" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateMongodbSourceFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new MosaicAsyncResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicAsyncResponse? UpdateMosaicStore
        // GraphQL -> updateMosaicStore: MosaicAsyncResponse! (type)
        public static string UpdateMosaicStore(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateMosaicStore" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateMosaicStoreFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new MosaicAsyncResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateMssqlDefaultPropertiesReply? UpdateMssqlDefaultProperties
        // GraphQL -> updateMssqlDefaultProperties: UpdateMssqlDefaultPropertiesReply! (type)
        public static string UpdateMssqlDefaultProperties(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateMssqlDefaultProperties" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateMssqlDefaultPropertiesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateMssqlDefaultPropertiesReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateMssqlLogShippingConfigurationReply? UpdateMssqlLogShippingConfiguration
        // GraphQL -> updateMssqlLogShippingConfiguration: UpdateMssqlLogShippingConfigurationReply! (type)
        public static string UpdateMssqlLogShippingConfiguration(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateMssqlLogShippingConfiguration" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateMssqlLogShippingConfigurationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateMssqlLogShippingConfigurationReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? UpdateMssqlLogShippingConfigurationV1
        // GraphQL -> updateMssqlLogShippingConfigurationV1: AsyncRequestStatus! (type)
        public static string UpdateMssqlLogShippingConfigurationV1(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateMssqlLogShippingConfigurationV1" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateMssqlLogShippingConfigurationV1FieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateNasSystemReply? UpdateNasSystem
        // GraphQL -> updateNasSystem: UpdateNasSystemReply! (type)
        public static string UpdateNasSystem(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateNasSystem" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateNasSystemFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateNasSystemReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateNetworkThrottleReply? UpdateNetworkThrottle
        // GraphQL -> updateNetworkThrottle: UpdateNetworkThrottleReply! (type)
        public static string UpdateNetworkThrottle(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateNetworkThrottle" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateNetworkThrottleFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateNetworkThrottleReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateNutanixClusterReply? UpdateNutanixCluster
        // GraphQL -> updateNutanixCluster: UpdateNutanixClusterReply! (type)
        public static string UpdateNutanixCluster(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateNutanixCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateNutanixClusterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateNutanixClusterReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateNutanixPrismCentralReply? UpdateNutanixPrismCentral
        // GraphQL -> updateNutanixPrismCentral: UpdateNutanixPrismCentralReply! (type)
        public static string UpdateNutanixPrismCentral(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateNutanixPrismCentral" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateNutanixPrismCentralFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateNutanixPrismCentralReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NutanixVmDetail? UpdateNutanixVm
        // GraphQL -> updateNutanixVm: NutanixVmDetail! (type)
        public static string UpdateNutanixVm(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateNutanixVm" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateNutanixVmFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new NutanixVmDetail() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateO365AppAuthStatusReply? UpdateO365AppAuthStatus
        // GraphQL -> updateO365AppAuthStatus: UpdateO365AppAuthStatusReply! (type)
        public static string UpdateO365AppAuthStatus(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateO365AppAuthStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateO365AppAuthStatusFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateO365AppAuthStatusReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateO365OrgCustomNameReply? UpdateO365OrgCustomName
        // GraphQL -> updateO365OrgCustomName: UpdateO365OrgCustomNameReply! (type)
        public static string UpdateO365OrgCustomName(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateO365OrgCustomName" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateO365OrgCustomNameFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateO365OrgCustomNameReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> OracleDbDetail? UpdateOracleDataGuardGroup
        // GraphQL -> updateOracleDataGuardGroup: OracleDbDetail! (type)
        public static string UpdateOracleDataGuardGroup(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateOracleDataGuardGroup" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateOracleDataGuardGroupFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new OracleDbDetail() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateOrgReply? UpdateOrg
        // GraphQL -> updateOrg: UpdateOrgReply! (type)
        public static string UpdateOrg(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateOrg" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateOrgFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateOrgReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ClassificationPolicyDetail? UpdatePolicy
        // GraphQL -> updatePolicy: ClassificationPolicyDetail! (type)
        public static string UpdatePolicy(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updatePolicy" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdatePolicyFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ClassificationPolicyDetail() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Cluster? UpdatePreviewerClusterConfig
        // GraphQL -> updatePreviewerClusterConfig: Cluster! (type)
        public static string UpdatePreviewerClusterConfig(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\npreviewerClusterConfig: $previewerClusterConfig\n)";
            return "updatePreviewerClusterConfig" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdatePreviewerClusterConfigFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new Cluster() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateProxyConfigReply? UpdateProxyConfig
        // GraphQL -> updateProxyConfig: UpdateProxyConfigReply! (type)
        public static string UpdateProxyConfig(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateProxyConfig" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateProxyConfigFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateProxyConfigReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TargetMapping? UpdateRcsAutomaticTargetMapping
        // GraphQL -> updateRcsAutomaticTargetMapping: TargetMapping! (type)
        public static string UpdateRcsAutomaticTargetMapping(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateRcsAutomaticTargetMapping" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateRcsAutomaticTargetMappingFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new TargetMapping() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? UpdateReplicationNetworkThrottleBypass
        // GraphQL -> updateReplicationNetworkThrottleBypass: ResponseSuccess! (type)
        public static string UpdateReplicationNetworkThrottleBypass(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateReplicationNetworkThrottleBypass" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateReplicationNetworkThrottleBypassFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateScheduledReportReply? UpdateScheduledReport
        // GraphQL -> updateScheduledReport: UpdateScheduledReportReply! (type)
        public static string UpdateScheduledReport(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateScheduledReport" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateScheduledReportFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateScheduledReportReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateServiceAccountReply? UpdateServiceAccount
        // GraphQL -> updateServiceAccount: UpdateServiceAccountReply! (type)
        public static string UpdateServiceAccount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateServiceAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateServiceAccountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateServiceAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateSnmpConfigReply? UpdateSnmpConfig
        // GraphQL -> updateSnmpConfig: UpdateSnmpConfigReply! (type)
        public static string UpdateSnmpConfig(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateSnmpConfig" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateSnmpConfigFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateSnmpConfigReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateStorageArraysReply? UpdateStorageArrays
        // GraphQL -> updateStorageArrays: UpdateStorageArraysReply! (type)
        public static string UpdateStorageArrays(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateStorageArrays" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateStorageArraysFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateStorageArraysReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateSyslogExportRuleReply? UpdateSyslogExportRule
        // GraphQL -> updateSyslogExportRule: UpdateSyslogExportRuleReply! (type)
        public static string UpdateSyslogExportRule(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateSyslogExportRule" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateSyslogExportRuleFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateSyslogExportRuleReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateTunnelStatusReply? UpdateTunnelStatus
        // GraphQL -> updateTunnelStatus: UpdateTunnelStatusReply! (type)
        public static string UpdateTunnelStatus(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateTunnelStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateTunnelStatusFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateTunnelStatusReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateVcenterReply? UpdateVcenter
        // GraphQL -> updateVcenter: UpdateVcenterReply! (type)
        public static string UpdateVcenter(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateVcenter" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateVcenterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateVcenterReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? UpdateVcenterHotAddBandwidth
        // GraphQL -> updateVcenterHotAddBandwidth: RequestSuccess! (type)
        public static string UpdateVcenterHotAddBandwidth(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateVcenterHotAddBandwidth" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateVcenterHotAddBandwidthFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? UpdateVcenterHotAddNetwork
        // GraphQL -> updateVcenterHotAddNetwork: RequestSuccess! (type)
        public static string UpdateVcenterHotAddNetwork(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateVcenterHotAddNetwork" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateVcenterHotAddNetworkFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateVcenterV2Reply? UpdateVcenterV2
        // GraphQL -> updateVcenterV2: UpdateVcenterV2Reply! (type)
        public static string UpdateVcenterV2(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateVcenterV2" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateVcenterV2FieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateVcenterV2Reply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateVolumeGroupReply? UpdateVolumeGroup
        // GraphQL -> updateVolumeGroup: UpdateVolumeGroupReply! (type)
        public static string UpdateVolumeGroup(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateVolumeGroup" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateVolumeGroupFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateVolumeGroupReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateVsphereAdvancedTagReply? UpdateVsphereAdvancedTag
        // GraphQL -> updateVsphereAdvancedTag: UpdateVsphereAdvancedTagReply! (type)
        public static string UpdateVsphereAdvancedTag(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateVsphereAdvancedTag" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateVsphereAdvancedTagFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateVsphereAdvancedTagReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? UpdateVsphereVm
        // GraphQL -> updateVsphereVm: RequestSuccess! (type)
        public static string UpdateVsphereVm(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateVsphereVm" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateVsphereVmFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? UpdateVsphereVmNew
        // GraphQL -> updateVsphereVmNew: RequestSuccess! (type)
        public static string UpdateVsphereVmNew(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateVsphereVmNew" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateVsphereVmNewFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateWebhookReply? UpdateWebhook
        // GraphQL -> updateWebhook: UpdateWebhookReply! (type)
        public static string UpdateWebhook(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateWebhook" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateWebhookFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateWebhookReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateWebhookStatusReply? UpdateWebhookStatus
        // GraphQL -> updateWebhookStatus: UpdateWebhookStatusReply! (type)
        public static string UpdateWebhookStatus(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateWebhookStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateWebhookStatusFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateWebhookStatusReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateWebhookV2Reply? UpdateWebhookV2
        // GraphQL -> updateWebhookV2: UpdateWebhookV2Reply! (type)
        public static string UpdateWebhookV2(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "updateWebhookV2" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpdateWebhookV2FieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpdateWebhookV2Reply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpgradeAzureCloudAccountReply? UpgradeAzureCloudAccount
        // GraphQL -> upgradeAzureCloudAccount: UpgradeAzureCloudAccountReply! (type)
        public static string UpgradeAzureCloudAccount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "upgradeAzureCloudAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpgradeAzureCloudAccountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpgradeAzureCloudAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpgradeAzureCloudAccountPermissionsWithoutOauthReply? UpgradeAzureCloudAccountPermissionsWithoutOauth
        // GraphQL -> upgradeAzureCloudAccountPermissionsWithoutOauth: UpgradeAzureCloudAccountPermissionsWithoutOauthReply! (type)
        public static string UpgradeAzureCloudAccountPermissionsWithoutOauth(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "upgradeAzureCloudAccountPermissionsWithoutOauth" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpgradeAzureCloudAccountPermissionsWithoutOauthFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpgradeAzureCloudAccountPermissionsWithoutOauthReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpgradeGcpCloudAccountPermissionsWithoutOauthReply? UpgradeGcpCloudAccountPermissionsWithoutOauth
        // GraphQL -> upgradeGcpCloudAccountPermissionsWithoutOauth: UpgradeGcpCloudAccountPermissionsWithoutOauthReply! (type)
        public static string UpgradeGcpCloudAccountPermissionsWithoutOauth(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "upgradeGcpCloudAccountPermissionsWithoutOauth" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpgradeGcpCloudAccountPermissionsWithoutOauthFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpgradeGcpCloudAccountPermissionsWithoutOauthReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? UpgradeIoFilter
        // GraphQL -> upgradeIoFilter: RequestSuccess! (type)
        public static string UpgradeIoFilter(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "upgradeIoFilter" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpgradeIoFilterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpgradeSlasReply? UpgradeSlas
        // GraphQL -> upgradeSlas: UpgradeSlasReply! (type)
        public static string UpgradeSlas(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "upgradeSlas" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpgradeSlasFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new UpgradeSlasReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? UploadDatabaseSnapshotToBlobstore
        // GraphQL -> uploadDatabaseSnapshotToBlobstore: AsyncJobStatus! (type)
        public static string UploadDatabaseSnapshotToBlobstore(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "uploadDatabaseSnapshotToBlobstore" + args + "\n{\n" + fs + "}\n";
        }
        public static object UploadDatabaseSnapshotToBlobstoreFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ValidateAndCreateAwsCloudAccountReply? ValidateAndCreateAwsCloudAccount
        // GraphQL -> validateAndCreateAwsCloudAccount: ValidateAndCreateAwsCloudAccountReply! (type)
        public static string ValidateAndCreateAwsCloudAccount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "validateAndCreateAwsCloudAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object ValidateAndCreateAwsCloudAccountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ValidateAndCreateAwsCloudAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ValidateAndInitiateAwsOutpostAccountReply? ValidateAndInitiateAwsOutpostAccount
        // GraphQL -> validateAndInitiateAwsOutpostAccount: ValidateAndInitiateAwsOutpostAccountReply! (type)
        public static string ValidateAndInitiateAwsOutpostAccount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "validateAndInitiateAwsOutpostAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object ValidateAndInitiateAwsOutpostAccountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ValidateAndInitiateAwsOutpostAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ValidateAndSaveCustomerKmsInfoReply? ValidateAndSaveCustomerKmsInfo
        // GraphQL -> validateAndSaveCustomerKmsInfo: ValidateAndSaveCustomerKmsInfoReply! (type)
        public static string ValidateAndSaveCustomerKmsInfo(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "validateAndSaveCustomerKmsInfo" + args + "\n{\n" + fs + "}\n";
        }
        public static object ValidateAndSaveCustomerKmsInfoFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ValidateAndSaveCustomerKmsInfoReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ValidateOracleAcoFileReply? ValidateOracleAcoFile
        // GraphQL -> validateOracleAcoFile: ValidateOracleAcoFileReply! (type)
        public static string ValidateOracleAcoFile(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "validateOracleAcoFile" + args + "\n{\n" + fs + "}\n";
        }
        public static object ValidateOracleAcoFileFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new ValidateOracleAcoFileReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ValidateOracleDatabaseBackups
        // GraphQL -> validateOracleDatabaseBackups: AsyncRequestStatus! (type)
        public static string ValidateOracleDatabaseBackups(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "validateOracleDatabaseBackups" + args + "\n{\n" + fs + "}\n";
        }
        public static object ValidateOracleDatabaseBackupsFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VmMakePrimary
        // GraphQL -> vmMakePrimary: AsyncRequestStatus! (type)
        public static string VmMakePrimary(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vmMakePrimary" + args + "\n{\n" + fs + "}\n";
        }
        public static object VmMakePrimaryFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VmwareDownloadSnapshotFromLocation
        // GraphQL -> vmwareDownloadSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string VmwareDownloadSnapshotFromLocation(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vmwareDownloadSnapshotFromLocation" + args + "\n{\n" + fs + "}\n";
        }
        public static object VmwareDownloadSnapshotFromLocationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncRequestStatus? VsphereBulkOnDemandSnapshot
        // GraphQL -> vsphereBulkOnDemandSnapshot: BatchAsyncRequestStatus! (type)
        public static string VsphereBulkOnDemandSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereBulkOnDemandSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereBulkOnDemandSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchAsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereDeleteVcenter
        // GraphQL -> vsphereDeleteVcenter: AsyncRequestStatus! (type)
        public static string VsphereDeleteVcenter(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereDeleteVcenter" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereDeleteVcenterFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? VsphereExcludeVmDisks
        // GraphQL -> vsphereExcludeVmDisks: RequestSuccess! (type)
        public static string VsphereExcludeVmDisks(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereExcludeVmDisks" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereExcludeVmDisksFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereExportSnapshotToStandaloneHostV2
        // GraphQL -> vsphereExportSnapshotToStandaloneHostV2: AsyncRequestStatus! (type)
        public static string VsphereExportSnapshotToStandaloneHostV2(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereExportSnapshotToStandaloneHostV2" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereExportSnapshotToStandaloneHostV2FieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereOnDemandSnapshot
        // GraphQL -> vsphereOnDemandSnapshot: AsyncRequestStatus! (type)
        public static string VsphereOnDemandSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereOnDemandSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereOnDemandSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereSnapshotConsistency
        // GraphQL -> vsphereSnapshotConsistency: AsyncRequestStatus! (type)
        public static string VsphereSnapshotConsistency(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereSnapshotConsistency" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereSnapshotConsistencyFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereSnapshotDownloadFilesFromLocation
        // GraphQL -> vsphereSnapshotDownloadFilesFromLocation: AsyncRequestStatus! (type)
        public static string VsphereSnapshotDownloadFilesFromLocation(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereSnapshotDownloadFilesFromLocation" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereSnapshotDownloadFilesFromLocationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereSnapshotRestoreFilesFromLocation
        // GraphQL -> vsphereSnapshotRestoreFilesFromLocation: AsyncRequestStatus! (type)
        public static string VsphereSnapshotRestoreFilesFromLocation(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereSnapshotRestoreFilesFromLocation" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereSnapshotRestoreFilesFromLocationFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncRequestStatus? VsphereVmBatchExport
        // GraphQL -> vsphereVmBatchExport: BatchAsyncRequestStatus! (type)
        public static string VsphereVmBatchExport(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmBatchExport" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmBatchExportFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchAsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncRequestStatus? VsphereVmBatchExportV3
        // GraphQL -> vsphereVmBatchExportV3: BatchAsyncRequestStatus! (type)
        public static string VsphereVmBatchExportV3(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmBatchExportV3" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmBatchExportV3FieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchAsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncRequestStatus? VsphereVmBatchInPlaceRecovery
        // GraphQL -> vsphereVmBatchInPlaceRecovery: BatchAsyncRequestStatus! (type)
        public static string VsphereVmBatchInPlaceRecovery(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmBatchInPlaceRecovery" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmBatchInPlaceRecoveryFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchAsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereVmDownloadSnapshot
        // GraphQL -> vsphereVmDownloadSnapshot: AsyncRequestStatus! (type)
        public static string VsphereVmDownloadSnapshot(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmDownloadSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmDownloadSnapshotFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereVmDownloadSnapshotFiles
        // GraphQL -> vsphereVmDownloadSnapshotFiles: AsyncRequestStatus! (type)
        public static string VsphereVmDownloadSnapshotFiles(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmDownloadSnapshotFiles" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmDownloadSnapshotFilesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereVmExportSnapshotV2
        // GraphQL -> vsphereVmExportSnapshotV2: AsyncRequestStatus! (type)
        public static string VsphereVmExportSnapshotV2(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmExportSnapshotV2" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmExportSnapshotV2FieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereVmExportSnapshotV3
        // GraphQL -> vsphereVmExportSnapshotV3: AsyncRequestStatus! (type)
        public static string VsphereVmExportSnapshotV3(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmExportSnapshotV3" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmExportSnapshotV3FieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereVmExportSnapshotWithDownloadFromCloud
        // GraphQL -> vsphereVmExportSnapshotWithDownloadFromCloud: AsyncRequestStatus! (type)
        public static string VsphereVmExportSnapshotWithDownloadFromCloud(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmExportSnapshotWithDownloadFromCloud" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmExportSnapshotWithDownloadFromCloudFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncRequestStatus? VsphereVmInitiateBatchInstantRecovery
        // GraphQL -> vsphereVmInitiateBatchInstantRecovery: BatchAsyncRequestStatus! (type)
        public static string VsphereVmInitiateBatchInstantRecovery(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmInitiateBatchInstantRecovery" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmInitiateBatchInstantRecoveryFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchAsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncRequestStatus? VsphereVmInitiateBatchLiveMountV2
        // GraphQL -> vsphereVmInitiateBatchLiveMountV2: BatchAsyncRequestStatus! (type)
        public static string VsphereVmInitiateBatchLiveMountV2(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmInitiateBatchLiveMountV2" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmInitiateBatchLiveMountV2FieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new BatchAsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereVmInitiateDiskMount
        // GraphQL -> vsphereVmInitiateDiskMount: AsyncRequestStatus! (type)
        public static string VsphereVmInitiateDiskMount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmInitiateDiskMount" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmInitiateDiskMountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereVmInitiateInPlaceRecovery
        // GraphQL -> vsphereVmInitiateInPlaceRecovery: AsyncRequestStatus! (type)
        public static string VsphereVmInitiateInPlaceRecovery(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmInitiateInPlaceRecovery" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmInitiateInPlaceRecoveryFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereVmInitiateInstantRecoveryV2
        // GraphQL -> vsphereVmInitiateInstantRecoveryV2: AsyncRequestStatus! (type)
        public static string VsphereVmInitiateInstantRecoveryV2(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmInitiateInstantRecoveryV2" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmInitiateInstantRecoveryV2FieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereVmInitiateLiveMountV2
        // GraphQL -> vsphereVmInitiateLiveMountV2: AsyncRequestStatus! (type)
        public static string VsphereVmInitiateLiveMountV2(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmInitiateLiveMountV2" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmInitiateLiveMountV2FieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereVmListEsxiDatastoresReply? VsphereVmListEsxiDatastores
        // GraphQL -> vsphereVmListEsxiDatastores: VsphereVmListEsxiDatastoresReply! (type)
        public static string VsphereVmListEsxiDatastores(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmListEsxiDatastores" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmListEsxiDatastoresFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new VsphereVmListEsxiDatastoresReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereVmMountRelocate
        // GraphQL -> vsphereVmMountRelocate: AsyncRequestStatus! (type)
        public static string VsphereVmMountRelocate(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmMountRelocate" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmMountRelocateFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereVmMountRelocateV2
        // GraphQL -> vsphereVmMountRelocateV2: AsyncRequestStatus! (type)
        public static string VsphereVmMountRelocateV2(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmMountRelocateV2" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmMountRelocateV2FieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereVmPowerOnOffLiveMountReply? VsphereVmPowerOnOffLiveMount
        // GraphQL -> vsphereVmPowerOnOffLiveMount: VsphereVmPowerOnOffLiveMountReply! (type)
        public static string VsphereVmPowerOnOffLiveMount(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmPowerOnOffLiveMount" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmPowerOnOffLiveMountFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new VsphereVmPowerOnOffLiveMountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereAsyncRequestStatus? VsphereVmRecoverFiles
        // GraphQL -> vsphereVmRecoverFiles: VsphereAsyncRequestStatus! (type)
        public static string VsphereVmRecoverFiles(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmRecoverFiles" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmRecoverFilesFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new VsphereAsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereVmRecoverFilesNew
        // GraphQL -> vsphereVmRecoverFilesNew: AsyncRequestStatus! (type)
        public static string VsphereVmRecoverFilesNew(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmRecoverFilesNew" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmRecoverFilesNewFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? VsphereVmRegisterAgent
        // GraphQL -> vsphereVmRegisterAgent: RequestSuccess! (type)
        public static string VsphereVmRegisterAgent(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmRegisterAgent" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmRegisterAgentFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? VsphereVmRegisterAgentWithOrg
        // GraphQL -> vsphereVmRegisterAgentWithOrg: RequestSuccess! (type)
        public static string VsphereVmRegisterAgentWithOrg(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmRegisterAgentWithOrg" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmRegisterAgentWithOrgFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> WindowsRbsBulkInstallReply? WindowsRbsBulkInstall
        // GraphQL -> windowsRbsBulkInstall: WindowsRbsBulkInstallReply! (type)
        public static string WindowsRbsBulkInstall(object fsObj)
        {
            var fs = ReflectionUtils.GetObjFieldSpec(fsObj);
            string args = "\n(\ninput: $input\n)";
            return "windowsRbsBulkInstall" + args + "\n{\n" + fs + "}\n";
        }
        public static object WindowsRbsBulkInstallFieldSpec(AutofieldContext? ec=null)
        {
            if(ec==null) {
                ec = new AutofieldContext();
            }
            var fieldSpecObj = new WindowsRbsBulkInstallReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        #endregion

    } // class Mutation
    #endregion
}