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
        public static string CreateAwsAccount_TypedFieldSpec(CloudAccount fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createAwsAccount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateAwsAccount_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateAwsAccount((CloudAccount)fieldSpecObj);
        }
        public static string CreateAwsAccount(CloudAccount fieldSpec)
        {
            return CreateAwsAccount_TypedFieldSpec(fieldSpec);
        }
        public static string CreateAwsAccount(object fieldSpecObj)
        {
            return CreateAwsAccount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateAwsAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<CloudAccount>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Target? CreateAwsReaderTarget
        // GraphQL -> createAwsReaderTarget: Target! (interface)
        public static string CreateAwsReaderTarget_TypedFieldSpec(Target fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createAwsReaderTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateAwsReaderTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateAwsReaderTarget((Target)fieldSpecObj);
        }
        public static string CreateAwsReaderTarget(Target fieldSpec)
        {
            return CreateAwsReaderTarget_TypedFieldSpec(fieldSpec);
        }
        public static string CreateAwsReaderTarget(object fieldSpecObj)
        {
            return CreateAwsReaderTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateAwsReaderTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Target? CreateAwsTarget
        // GraphQL -> createAwsTarget: Target! (interface)
        public static string CreateAwsTarget_TypedFieldSpec(Target fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createAwsTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateAwsTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateAwsTarget((Target)fieldSpecObj);
        }
        public static string CreateAwsTarget(Target fieldSpec)
        {
            return CreateAwsTarget_TypedFieldSpec(fieldSpec);
        }
        public static string CreateAwsTarget(object fieldSpecObj)
        {
            return CreateAwsTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateAwsTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CloudAccount? CreateAzureAccount
        // GraphQL -> createAzureAccount: CloudAccount! (interface)
        public static string CreateAzureAccount_TypedFieldSpec(CloudAccount fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createAzureAccount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateAzureAccount_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateAzureAccount((CloudAccount)fieldSpecObj);
        }
        public static string CreateAzureAccount(CloudAccount fieldSpec)
        {
            return CreateAzureAccount_TypedFieldSpec(fieldSpec);
        }
        public static string CreateAzureAccount(object fieldSpecObj)
        {
            return CreateAzureAccount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateAzureAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<CloudAccount>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Target? CreateAzureReaderTarget
        // GraphQL -> createAzureReaderTarget: Target! (interface)
        public static string CreateAzureReaderTarget_TypedFieldSpec(Target fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createAzureReaderTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateAzureReaderTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateAzureReaderTarget((Target)fieldSpecObj);
        }
        public static string CreateAzureReaderTarget(Target fieldSpec)
        {
            return CreateAzureReaderTarget_TypedFieldSpec(fieldSpec);
        }
        public static string CreateAzureReaderTarget(object fieldSpecObj)
        {
            return CreateAzureReaderTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateAzureReaderTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Target? CreateAzureTarget
        // GraphQL -> createAzureTarget: Target! (interface)
        public static string CreateAzureTarget_TypedFieldSpec(Target fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createAzureTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateAzureTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateAzureTarget((Target)fieldSpecObj);
        }
        public static string CreateAzureTarget(Target fieldSpec)
        {
            return CreateAzureTarget_TypedFieldSpec(fieldSpec);
        }
        public static string CreateAzureTarget(object fieldSpecObj)
        {
            return CreateAzureTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateAzureTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Target? CreateGcpReaderTarget
        // GraphQL -> createGcpReaderTarget: Target! (interface)
        public static string CreateGcpReaderTarget_TypedFieldSpec(Target fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createGcpReaderTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateGcpReaderTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateGcpReaderTarget((Target)fieldSpecObj);
        }
        public static string CreateGcpReaderTarget(Target fieldSpec)
        {
            return CreateGcpReaderTarget_TypedFieldSpec(fieldSpec);
        }
        public static string CreateGcpReaderTarget(object fieldSpecObj)
        {
            return CreateGcpReaderTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateGcpReaderTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Target? CreateGcpTarget
        // GraphQL -> createGcpTarget: Target! (interface)
        public static string CreateGcpTarget_TypedFieldSpec(Target fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createGcpTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateGcpTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateGcpTarget((Target)fieldSpecObj);
        }
        public static string CreateGcpTarget(Target fieldSpec)
        {
            return CreateGcpTarget_TypedFieldSpec(fieldSpec);
        }
        public static string CreateGcpTarget(object fieldSpecObj)
        {
            return CreateGcpTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateGcpTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Target? CreateGlacierReaderTarget
        // GraphQL -> createGlacierReaderTarget: Target! (interface)
        public static string CreateGlacierReaderTarget_TypedFieldSpec(Target fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createGlacierReaderTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateGlacierReaderTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateGlacierReaderTarget((Target)fieldSpecObj);
        }
        public static string CreateGlacierReaderTarget(Target fieldSpec)
        {
            return CreateGlacierReaderTarget_TypedFieldSpec(fieldSpec);
        }
        public static string CreateGlacierReaderTarget(object fieldSpecObj)
        {
            return CreateGlacierReaderTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateGlacierReaderTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Target? CreateNfsReaderTarget
        // GraphQL -> createNfsReaderTarget: Target! (interface)
        public static string CreateNfsReaderTarget_TypedFieldSpec(Target fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createNfsReaderTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateNfsReaderTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateNfsReaderTarget((Target)fieldSpecObj);
        }
        public static string CreateNfsReaderTarget(Target fieldSpec)
        {
            return CreateNfsReaderTarget_TypedFieldSpec(fieldSpec);
        }
        public static string CreateNfsReaderTarget(object fieldSpecObj)
        {
            return CreateNfsReaderTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateNfsReaderTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Target? CreateNfsTarget
        // GraphQL -> createNfsTarget: Target! (interface)
        public static string CreateNfsTarget_TypedFieldSpec(Target fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createNfsTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateNfsTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateNfsTarget((Target)fieldSpecObj);
        }
        public static string CreateNfsTarget(Target fieldSpec)
        {
            return CreateNfsTarget_TypedFieldSpec(fieldSpec);
        }
        public static string CreateNfsTarget(object fieldSpecObj)
        {
            return CreateNfsTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateNfsTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Target? CreateRcsReaderTarget
        // GraphQL -> createRcsReaderTarget: Target! (interface)
        public static string CreateRcsReaderTarget_TypedFieldSpec(Target fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createRcsReaderTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateRcsReaderTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateRcsReaderTarget((Target)fieldSpecObj);
        }
        public static string CreateRcsReaderTarget(Target fieldSpec)
        {
            return CreateRcsReaderTarget_TypedFieldSpec(fieldSpec);
        }
        public static string CreateRcsReaderTarget(object fieldSpecObj)
        {
            return CreateRcsReaderTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateRcsReaderTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Target? CreateRcsTarget
        // GraphQL -> createRcsTarget: Target! (interface)
        public static string CreateRcsTarget_TypedFieldSpec(Target fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createRcsTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateRcsTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateRcsTarget((Target)fieldSpecObj);
        }
        public static string CreateRcsTarget(Target fieldSpec)
        {
            return CreateRcsTarget_TypedFieldSpec(fieldSpec);
        }
        public static string CreateRcsTarget(object fieldSpecObj)
        {
            return CreateRcsTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateRcsTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<Target>? CreateRcvLocationsFromTemplate
        // GraphQL -> createRcvLocationsFromTemplate: [Target!]! (interface)
        public static string CreateRcvLocationsFromTemplate_TypedFieldSpec(List<Target> fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createRcvLocationsFromTemplate" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateRcvLocationsFromTemplate_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateRcvLocationsFromTemplate((List<Target>)fieldSpecObj);
        }
        public static string CreateRcvLocationsFromTemplate(List<Target> fieldSpec)
        {
            return CreateRcvLocationsFromTemplate_TypedFieldSpec(fieldSpec);
        }
        public static string CreateRcvLocationsFromTemplate(object fieldSpecObj)
        {
            return CreateRcvLocationsFromTemplate_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateRcvLocationsFromTemplateFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Target? CreateS3CompatibleReaderTarget
        // GraphQL -> createS3CompatibleReaderTarget: Target! (interface)
        public static string CreateS3CompatibleReaderTarget_TypedFieldSpec(Target fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createS3CompatibleReaderTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateS3CompatibleReaderTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateS3CompatibleReaderTarget((Target)fieldSpecObj);
        }
        public static string CreateS3CompatibleReaderTarget(Target fieldSpec)
        {
            return CreateS3CompatibleReaderTarget_TypedFieldSpec(fieldSpec);
        }
        public static string CreateS3CompatibleReaderTarget(object fieldSpecObj)
        {
            return CreateS3CompatibleReaderTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateS3CompatibleReaderTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Target? CreateS3CompatibleTarget
        // GraphQL -> createS3CompatibleTarget: Target! (interface)
        public static string CreateS3CompatibleTarget_TypedFieldSpec(Target fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createS3CompatibleTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateS3CompatibleTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateS3CompatibleTarget((Target)fieldSpecObj);
        }
        public static string CreateS3CompatibleTarget(Target fieldSpec)
        {
            return CreateS3CompatibleTarget_TypedFieldSpec(fieldSpec);
        }
        public static string CreateS3CompatibleTarget(object fieldSpecObj)
        {
            return CreateS3CompatibleTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateS3CompatibleTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Target? CreateTapeReaderTarget
        // GraphQL -> createTapeReaderTarget: Target! (interface)
        public static string CreateTapeReaderTarget_TypedFieldSpec(Target fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createTapeReaderTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateTapeReaderTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateTapeReaderTarget((Target)fieldSpecObj);
        }
        public static string CreateTapeReaderTarget(Target fieldSpec)
        {
            return CreateTapeReaderTarget_TypedFieldSpec(fieldSpec);
        }
        public static string CreateTapeReaderTarget(object fieldSpecObj)
        {
            return CreateTapeReaderTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateTapeReaderTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Target? CreateTapeTarget
        // GraphQL -> createTapeTarget: Target! (interface)
        public static string CreateTapeTarget_TypedFieldSpec(Target fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createTapeTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateTapeTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateTapeTarget((Target)fieldSpecObj);
        }
        public static string CreateTapeTarget(Target fieldSpec)
        {
            return CreateTapeTarget_TypedFieldSpec(fieldSpec);
        }
        public static string CreateTapeTarget(object fieldSpecObj)
        {
            return CreateTapeTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateTapeTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CloudAccount? UpdateAwsAccount
        // GraphQL -> updateAwsAccount: CloudAccount! (interface)
        public static string UpdateAwsAccount_TypedFieldSpec(CloudAccount fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateAwsAccount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateAwsAccount_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateAwsAccount((CloudAccount)fieldSpecObj);
        }
        public static string UpdateAwsAccount(CloudAccount fieldSpec)
        {
            return UpdateAwsAccount_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateAwsAccount(object fieldSpecObj)
        {
            return UpdateAwsAccount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateAwsAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<CloudAccount>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Target? UpdateAwsTarget
        // GraphQL -> updateAwsTarget: Target! (interface)
        public static string UpdateAwsTarget_TypedFieldSpec(Target fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateAwsTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateAwsTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateAwsTarget((Target)fieldSpecObj);
        }
        public static string UpdateAwsTarget(Target fieldSpec)
        {
            return UpdateAwsTarget_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateAwsTarget(object fieldSpecObj)
        {
            return UpdateAwsTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateAwsTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CloudAccount? UpdateAzureAccount
        // GraphQL -> updateAzureAccount: CloudAccount! (interface)
        public static string UpdateAzureAccount_TypedFieldSpec(CloudAccount fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateAzureAccount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateAzureAccount_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateAzureAccount((CloudAccount)fieldSpecObj);
        }
        public static string UpdateAzureAccount(CloudAccount fieldSpec)
        {
            return UpdateAzureAccount_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateAzureAccount(object fieldSpecObj)
        {
            return UpdateAzureAccount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateAzureAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<CloudAccount>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Target? UpdateAzureTarget
        // GraphQL -> updateAzureTarget: Target! (interface)
        public static string UpdateAzureTarget_TypedFieldSpec(Target fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateAzureTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateAzureTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateAzureTarget((Target)fieldSpecObj);
        }
        public static string UpdateAzureTarget(Target fieldSpec)
        {
            return UpdateAzureTarget_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateAzureTarget(object fieldSpecObj)
        {
            return UpdateAzureTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateAzureTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Target? UpdateGcpTarget
        // GraphQL -> updateGcpTarget: Target! (interface)
        public static string UpdateGcpTarget_TypedFieldSpec(Target fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateGcpTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateGcpTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateGcpTarget((Target)fieldSpecObj);
        }
        public static string UpdateGcpTarget(Target fieldSpec)
        {
            return UpdateGcpTarget_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateGcpTarget(object fieldSpecObj)
        {
            return UpdateGcpTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateGcpTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Target? UpdateGlacierTarget
        // GraphQL -> updateGlacierTarget: Target! (interface)
        public static string UpdateGlacierTarget_TypedFieldSpec(Target fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateGlacierTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateGlacierTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateGlacierTarget((Target)fieldSpecObj);
        }
        public static string UpdateGlacierTarget(Target fieldSpec)
        {
            return UpdateGlacierTarget_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateGlacierTarget(object fieldSpecObj)
        {
            return UpdateGlacierTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateGlacierTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Target? UpdateNfsTarget
        // GraphQL -> updateNfsTarget: Target! (interface)
        public static string UpdateNfsTarget_TypedFieldSpec(Target fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateNfsTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateNfsTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateNfsTarget((Target)fieldSpecObj);
        }
        public static string UpdateNfsTarget(Target fieldSpec)
        {
            return UpdateNfsTarget_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateNfsTarget(object fieldSpecObj)
        {
            return UpdateNfsTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateNfsTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Target? UpdateRcvTarget
        // GraphQL -> updateRcvTarget: Target! (interface)
        public static string UpdateRcvTarget_TypedFieldSpec(Target fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateRcvTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateRcvTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateRcvTarget((Target)fieldSpecObj);
        }
        public static string UpdateRcvTarget(Target fieldSpec)
        {
            return UpdateRcvTarget_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateRcvTarget(object fieldSpecObj)
        {
            return UpdateRcvTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateRcvTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Target? UpdateS3CompatibleTarget
        // GraphQL -> updateS3CompatibleTarget: Target! (interface)
        public static string UpdateS3CompatibleTarget_TypedFieldSpec(Target fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateS3CompatibleTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateS3CompatibleTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateS3CompatibleTarget((Target)fieldSpecObj);
        }
        public static string UpdateS3CompatibleTarget(Target fieldSpec)
        {
            return UpdateS3CompatibleTarget_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateS3CompatibleTarget(object fieldSpecObj)
        {
            return UpdateS3CompatibleTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateS3CompatibleTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Target? UpdateTapeTarget
        // GraphQL -> updateTapeTarget: Target! (interface)
        public static string UpdateTapeTarget_TypedFieldSpec(Target fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateTapeTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateTapeTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateTapeTarget((Target)fieldSpecObj);
        }
        public static string UpdateTapeTarget(Target fieldSpec)
        {
            return UpdateTapeTarget_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateTapeTarget(object fieldSpecObj)
        {
            return UpdateTapeTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateTapeTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> System.Boolean? AddInventoryWorkloads
        // GraphQL -> addInventoryWorkloads: Boolean! (scalar)
        public static string AddInventoryWorkloads_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "addInventoryWorkloads" + args + "\n";
        }
        public static string AddInventoryWorkloads_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddInventoryWorkloads((System.Boolean)fieldSpecObj);
        }
        public static string AddInventoryWorkloads(System.Boolean fieldSpec)
        {
            return AddInventoryWorkloads_TypedFieldSpec(fieldSpec);
        }
        public static string AddInventoryWorkloads(object fieldSpecObj)
        {
            return AddInventoryWorkloads_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddInventoryWorkloadsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? AddPolicyObjects
        // GraphQL -> addPolicyObjects: String! (scalar)
        public static string AddPolicyObjects_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\npolicyIds: $policyIds\nobjectIds: $objectIds\nobjectRootIds: $objectRootIds\nclusterIds: $clusterIds\n)";
            return "addPolicyObjects" + args + "\n";
        }
        public static string AddPolicyObjects_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddPolicyObjects((System.String)fieldSpecObj);
        }
        public static string AddPolicyObjects(System.String fieldSpec)
        {
            return AddPolicyObjects_TypedFieldSpec(fieldSpec);
        }
        public static string AddPolicyObjects(object fieldSpecObj)
        {
            return AddPolicyObjects_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddPolicyObjectsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? AddRoleAssignments
        // GraphQL -> addRoleAssignments: Boolean! (scalar)
        public static string AddRoleAssignments_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\nuserIds: $userIds\ngroupIds: $groupIds\nroleIds: $roleIds\n)";
            return "addRoleAssignments" + args + "\n";
        }
        public static string AddRoleAssignments_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddRoleAssignments((System.Boolean)fieldSpecObj);
        }
        public static string AddRoleAssignments(System.Boolean fieldSpec)
        {
            return AddRoleAssignments_TypedFieldSpec(fieldSpec);
        }
        public static string AddRoleAssignments(object fieldSpecObj)
        {
            return AddRoleAssignments_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddRoleAssignmentsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? ArchiveCrawl
        // GraphQL -> archiveCrawl: String! (scalar)
        public static string ArchiveCrawl_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ncrawlId: $crawlId\n)";
            return "archiveCrawl" + args + "\n";
        }
        public static string ArchiveCrawl_ObjectFieldSpec(object fieldSpecObj)
        {
            return ArchiveCrawl((System.String)fieldSpecObj);
        }
        public static string ArchiveCrawl(System.String fieldSpec)
        {
            return ArchiveCrawl_TypedFieldSpec(fieldSpec);
        }
        public static string ArchiveCrawl(object fieldSpecObj)
        {
            return ArchiveCrawl_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ArchiveCrawlFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? BatchDeassignRoleFromUserGroups
        // GraphQL -> batchDeassignRoleFromUserGroups: Boolean! (scalar)
        public static string BatchDeassignRoleFromUserGroups_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\nuserGroupToRoles: $userGroupToRoles\n)";
            return "batchDeassignRoleFromUserGroups" + args + "\n";
        }
        public static string BatchDeassignRoleFromUserGroups_ObjectFieldSpec(object fieldSpecObj)
        {
            return BatchDeassignRoleFromUserGroups((System.Boolean)fieldSpecObj);
        }
        public static string BatchDeassignRoleFromUserGroups(System.Boolean fieldSpec)
        {
            return BatchDeassignRoleFromUserGroups_TypedFieldSpec(fieldSpec);
        }
        public static string BatchDeassignRoleFromUserGroups(object fieldSpecObj)
        {
            return BatchDeassignRoleFromUserGroups_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BatchDeassignRoleFromUserGroupsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? BulkUpdateRansomwareInvestigationStatus
        // GraphQL -> bulkUpdateRansomwareInvestigationStatus: Void (scalar)
        public static string BulkUpdateRansomwareInvestigationStatus_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkUpdateRansomwareInvestigationStatus" + args + "\n";
        }
        public static string BulkUpdateRansomwareInvestigationStatus_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkUpdateRansomwareInvestigationStatus((System.String)fieldSpecObj);
        }
        public static string BulkUpdateRansomwareInvestigationStatus(System.String fieldSpec)
        {
            return BulkUpdateRansomwareInvestigationStatus_TypedFieldSpec(fieldSpec);
        }
        public static string BulkUpdateRansomwareInvestigationStatus(object fieldSpecObj)
        {
            return BulkUpdateRansomwareInvestigationStatus_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkUpdateRansomwareInvestigationStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? CancelActivitySeries
        // GraphQL -> cancelActivitySeries: Boolean! (scalar)
        public static string CancelActivitySeries_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "cancelActivitySeries" + args + "\n";
        }
        public static string CancelActivitySeries_ObjectFieldSpec(object fieldSpecObj)
        {
            return CancelActivitySeries((System.Boolean)fieldSpecObj);
        }
        public static string CancelActivitySeries(System.Boolean fieldSpec)
        {
            return CancelActivitySeries_TypedFieldSpec(fieldSpec);
        }
        public static string CancelActivitySeries(object fieldSpecObj)
        {
            return CancelActivitySeries_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CancelActivitySeriesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? CancelThreatHunt
        // GraphQL -> cancelThreatHunt: Void (scalar)
        public static string CancelThreatHunt_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "cancelThreatHunt" + args + "\n";
        }
        public static string CancelThreatHunt_ObjectFieldSpec(object fieldSpecObj)
        {
            return CancelThreatHunt((System.String)fieldSpecObj);
        }
        public static string CancelThreatHunt(System.String fieldSpec)
        {
            return CancelThreatHunt_TypedFieldSpec(fieldSpec);
        }
        public static string CancelThreatHunt(object fieldSpecObj)
        {
            return CancelThreatHunt_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CancelThreatHuntFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? ChangePassword
        // GraphQL -> changePassword: Boolean! (scalar)
        public static string ChangePassword_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "changePassword" + args + "\n";
        }
        public static string ChangePassword_ObjectFieldSpec(object fieldSpecObj)
        {
            return ChangePassword((System.Boolean)fieldSpecObj);
        }
        public static string ChangePassword(System.Boolean fieldSpec)
        {
            return ChangePassword_TypedFieldSpec(fieldSpec);
        }
        public static string ChangePassword(object fieldSpecObj)
        {
            return ChangePassword_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ChangePasswordFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? CompleteAzureAdAppUpdate
        // GraphQL -> completeAzureAdAppUpdate: Void (scalar)
        public static string CompleteAzureAdAppUpdate_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "completeAzureAdAppUpdate" + args + "\n";
        }
        public static string CompleteAzureAdAppUpdate_ObjectFieldSpec(object fieldSpecObj)
        {
            return CompleteAzureAdAppUpdate((System.String)fieldSpecObj);
        }
        public static string CompleteAzureAdAppUpdate(System.String fieldSpec)
        {
            return CompleteAzureAdAppUpdate_TypedFieldSpec(fieldSpec);
        }
        public static string CompleteAzureAdAppUpdate(object fieldSpecObj)
        {
            return CompleteAzureAdAppUpdate_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CompleteAzureAdAppUpdateFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? CreateCrossAccountPair
        // GraphQL -> createCrossAccountPair: Void (scalar)
        public static string CreateCrossAccountPair_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createCrossAccountPair" + args + "\n";
        }
        public static string CreateCrossAccountPair_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateCrossAccountPair((System.String)fieldSpecObj);
        }
        public static string CreateCrossAccountPair(System.String fieldSpec)
        {
            return CreateCrossAccountPair_TypedFieldSpec(fieldSpec);
        }
        public static string CreateCrossAccountPair(object fieldSpecObj)
        {
            return CreateCrossAccountPair_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateCrossAccountPairFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? CreateEventDigestBatch
        // GraphQL -> createEventDigestBatch: Void (scalar)
        public static string CreateEventDigestBatch_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createEventDigestBatch" + args + "\n";
        }
        public static string CreateEventDigestBatch_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateEventDigestBatch((System.String)fieldSpecObj);
        }
        public static string CreateEventDigestBatch(System.String fieldSpec)
        {
            return CreateEventDigestBatch_TypedFieldSpec(fieldSpec);
        }
        public static string CreateEventDigestBatch(object fieldSpecObj)
        {
            return CreateEventDigestBatch_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateEventDigestBatchFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? CreateReplicationPair
        // GraphQL -> createReplicationPair: Void (scalar)
        public static string CreateReplicationPair_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createReplicationPair" + args + "\n";
        }
        public static string CreateReplicationPair_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateReplicationPair((System.String)fieldSpecObj);
        }
        public static string CreateReplicationPair(System.String fieldSpec)
        {
            return CreateReplicationPair_TypedFieldSpec(fieldSpec);
        }
        public static string CreateReplicationPair(object fieldSpecObj)
        {
            return CreateReplicationPair_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateReplicationPairFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? CreateRole
        // GraphQL -> createRole: UUID! (scalar)
        public static string CreateRole_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\nname: $name\ndescription: $description\npermissions: $permissions\n)";
            return "createRole" + args + "\n";
        }
        public static string CreateRole_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateRole((System.String)fieldSpecObj);
        }
        public static string CreateRole(System.String fieldSpec)
        {
            return CreateRole_TypedFieldSpec(fieldSpec);
        }
        public static string CreateRole(object fieldSpecObj)
        {
            return CreateRole_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateRoleFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? CreateUser
        // GraphQL -> createUser: String! (scalar)
        public static string CreateUser_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\nemail: $email\nroleIds: $roleIds\n)";
            return "createUser" + args + "\n";
        }
        public static string CreateUser_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateUser((System.String)fieldSpecObj);
        }
        public static string CreateUser(System.String fieldSpec)
        {
            return CreateUser_TypedFieldSpec(fieldSpec);
        }
        public static string CreateUser(object fieldSpecObj)
        {
            return CreateUser_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateUserFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? CreateUserWithPassword
        // GraphQL -> createUserWithPassword: String! (scalar)
        public static string CreateUserWithPassword_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createUserWithPassword" + args + "\n";
        }
        public static string CreateUserWithPassword_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateUserWithPassword((System.String)fieldSpecObj);
        }
        public static string CreateUserWithPassword(System.String fieldSpec)
        {
            return CreateUserWithPassword_TypedFieldSpec(fieldSpec);
        }
        public static string CreateUserWithPassword(object fieldSpecObj)
        {
            return CreateUserWithPassword_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateUserWithPasswordFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeactivateCustomAnalyzer
        // GraphQL -> deactivateCustomAnalyzer: String! (scalar)
        public static string DeactivateCustomAnalyzer_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\nanalyzerId: $analyzerId\n)";
            return "deactivateCustomAnalyzer" + args + "\n";
        }
        public static string DeactivateCustomAnalyzer_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeactivateCustomAnalyzer((System.String)fieldSpecObj);
        }
        public static string DeactivateCustomAnalyzer(System.String fieldSpec)
        {
            return DeactivateCustomAnalyzer_TypedFieldSpec(fieldSpec);
        }
        public static string DeactivateCustomAnalyzer(object fieldSpecObj)
        {
            return DeactivateCustomAnalyzer_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeactivateCustomAnalyzerFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> List<System.String>? DeactivatePolicy
        // GraphQL -> deactivatePolicy: [String!]! (scalar)
        public static string DeactivatePolicy_TypedFieldSpec(List<System.String> fieldSpec)
        {
            string args = "\n(\npolicyId: $policyId\nrunAsync: $runAsync\n)";
            return "deactivatePolicy" + args + "\n";
        }
        public static string DeactivatePolicy_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeactivatePolicy((List<System.String>)fieldSpecObj);
        }
        public static string DeactivatePolicy(List<System.String> fieldSpec)
        {
            return DeactivatePolicy_TypedFieldSpec(fieldSpec);
        }
        public static string DeactivatePolicy(object fieldSpecObj)
        {
            return DeactivatePolicy_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeactivatePolicyFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> System.String? DeleteAllOracleDatabaseSnapshots
        // GraphQL -> deleteAllOracleDatabaseSnapshots: Void (scalar)
        public static string DeleteAllOracleDatabaseSnapshots_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteAllOracleDatabaseSnapshots" + args + "\n";
        }
        public static string DeleteAllOracleDatabaseSnapshots_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteAllOracleDatabaseSnapshots((System.String)fieldSpecObj);
        }
        public static string DeleteAllOracleDatabaseSnapshots(System.String fieldSpec)
        {
            return DeleteAllOracleDatabaseSnapshots_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteAllOracleDatabaseSnapshots(object fieldSpecObj)
        {
            return DeleteAllOracleDatabaseSnapshots_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteAllOracleDatabaseSnapshotsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeleteAwsComputeSetting
        // GraphQL -> deleteAwsComputeSetting: Void (scalar)
        public static string DeleteAwsComputeSetting_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteAwsComputeSetting" + args + "\n";
        }
        public static string DeleteAwsComputeSetting_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteAwsComputeSetting((System.String)fieldSpecObj);
        }
        public static string DeleteAwsComputeSetting(System.String fieldSpec)
        {
            return DeleteAwsComputeSetting_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteAwsComputeSetting(object fieldSpecObj)
        {
            return DeleteAwsComputeSetting_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteAwsComputeSettingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? DeleteCertificate
        // GraphQL -> deleteCertificate: Boolean! (scalar)
        public static string DeleteCertificate_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\ncertificateId: $certificateId\n)";
            return "deleteCertificate" + args + "\n";
        }
        public static string DeleteCertificate_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteCertificate((System.Boolean)fieldSpecObj);
        }
        public static string DeleteCertificate(System.Boolean fieldSpec)
        {
            return DeleteCertificate_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteCertificate(object fieldSpecObj)
        {
            return DeleteCertificate_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteCertificateFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? DeleteCloudNativeLabelRule
        // GraphQL -> deleteCloudNativeLabelRule: Void (scalar)
        public static string DeleteCloudNativeLabelRule_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteCloudNativeLabelRule" + args + "\n";
        }
        public static string DeleteCloudNativeLabelRule_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteCloudNativeLabelRule((System.String)fieldSpecObj);
        }
        public static string DeleteCloudNativeLabelRule(System.String fieldSpec)
        {
            return DeleteCloudNativeLabelRule_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteCloudNativeLabelRule(object fieldSpecObj)
        {
            return DeleteCloudNativeLabelRule_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteCloudNativeLabelRuleFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeleteCloudNativeTagRule
        // GraphQL -> deleteCloudNativeTagRule: Void (scalar)
        public static string DeleteCloudNativeTagRule_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteCloudNativeTagRule" + args + "\n";
        }
        public static string DeleteCloudNativeTagRule_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteCloudNativeTagRule((System.String)fieldSpecObj);
        }
        public static string DeleteCloudNativeTagRule(System.String fieldSpec)
        {
            return DeleteCloudNativeTagRule_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteCloudNativeTagRule(object fieldSpecObj)
        {
            return DeleteCloudNativeTagRule_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteCloudNativeTagRuleFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? DeleteCloudWorkloadSnapshot
        // GraphQL -> deleteCloudWorkloadSnapshot: Boolean! (scalar)
        public static string DeleteCloudWorkloadSnapshot_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteCloudWorkloadSnapshot" + args + "\n";
        }
        public static string DeleteCloudWorkloadSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteCloudWorkloadSnapshot((System.Boolean)fieldSpecObj);
        }
        public static string DeleteCloudWorkloadSnapshot(System.Boolean fieldSpec)
        {
            return DeleteCloudWorkloadSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteCloudWorkloadSnapshot(object fieldSpecObj)
        {
            return DeleteCloudWorkloadSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteCloudWorkloadSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? DeleteCrossAccountPair
        // GraphQL -> deleteCrossAccountPair: Void (scalar)
        public static string DeleteCrossAccountPair_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteCrossAccountPair" + args + "\n";
        }
        public static string DeleteCrossAccountPair_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteCrossAccountPair((System.String)fieldSpecObj);
        }
        public static string DeleteCrossAccountPair(System.String fieldSpec)
        {
            return DeleteCrossAccountPair_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteCrossAccountPair(object fieldSpecObj)
        {
            return DeleteCrossAccountPair_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteCrossAccountPairFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeleteCsr
        // GraphQL -> deleteCsr: Void (scalar)
        public static string DeleteCsr_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteCsr" + args + "\n";
        }
        public static string DeleteCsr_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteCsr((System.String)fieldSpecObj);
        }
        public static string DeleteCsr(System.String fieldSpec)
        {
            return DeleteCsr_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteCsr(object fieldSpecObj)
        {
            return DeleteCsr_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteCsrFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeleteCustomReport
        // GraphQL -> deleteCustomReport: Void (scalar)
        public static string DeleteCustomReport_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteCustomReport" + args + "\n";
        }
        public static string DeleteCustomReport_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteCustomReport((System.String)fieldSpecObj);
        }
        public static string DeleteCustomReport(System.String fieldSpec)
        {
            return DeleteCustomReport_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteCustomReport(object fieldSpecObj)
        {
            return DeleteCustomReport_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteCustomReportFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeleteDistributionListDigestBatch
        // GraphQL -> deleteDistributionListDigestBatch: Void (scalar)
        public static string DeleteDistributionListDigestBatch_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteDistributionListDigestBatch" + args + "\n";
        }
        public static string DeleteDistributionListDigestBatch_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteDistributionListDigestBatch((System.String)fieldSpecObj);
        }
        public static string DeleteDistributionListDigestBatch(System.String fieldSpec)
        {
            return DeleteDistributionListDigestBatch_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteDistributionListDigestBatch(object fieldSpecObj)
        {
            return DeleteDistributionListDigestBatch_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteDistributionListDigestBatchFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeleteEventDigest
        // GraphQL -> deleteEventDigest: Void (scalar)
        public static string DeleteEventDigest_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteEventDigest" + args + "\n";
        }
        public static string DeleteEventDigest_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteEventDigest((System.String)fieldSpecObj);
        }
        public static string DeleteEventDigest(System.String fieldSpec)
        {
            return DeleteEventDigest_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteEventDigest(object fieldSpecObj)
        {
            return DeleteEventDigest_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteEventDigestFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? DeleteGuestCredentialById
        // GraphQL -> deleteGuestCredentialById: Boolean! (scalar)
        public static string DeleteGuestCredentialById_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteGuestCredentialById" + args + "\n";
        }
        public static string DeleteGuestCredentialById_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteGuestCredentialById((System.Boolean)fieldSpecObj);
        }
        public static string DeleteGuestCredentialById(System.Boolean fieldSpec)
        {
            return DeleteGuestCredentialById_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteGuestCredentialById(object fieldSpecObj)
        {
            return DeleteGuestCredentialById_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteGuestCredentialByIdFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? DeleteIntegration
        // GraphQL -> deleteIntegration: Void (scalar)
        public static string DeleteIntegration_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteIntegration" + args + "\n";
        }
        public static string DeleteIntegration_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteIntegration((System.String)fieldSpecObj);
        }
        public static string DeleteIntegration(System.String fieldSpec)
        {
            return DeleteIntegration_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteIntegration(object fieldSpecObj)
        {
            return DeleteIntegration_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteIntegrationFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeleteIntegrations
        // GraphQL -> deleteIntegrations: Void (scalar)
        public static string DeleteIntegrations_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteIntegrations" + args + "\n";
        }
        public static string DeleteIntegrations_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteIntegrations((System.String)fieldSpecObj);
        }
        public static string DeleteIntegrations(System.String fieldSpec)
        {
            return DeleteIntegrations_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteIntegrations(object fieldSpecObj)
        {
            return DeleteIntegrations_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteIntegrationsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? DeleteLdapPrincipals
        // GraphQL -> deleteLdapPrincipals: Boolean! (scalar)
        public static string DeleteLdapPrincipals_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\nprincipalIds: $principalIds\n)";
            return "deleteLdapPrincipals" + args + "\n";
        }
        public static string DeleteLdapPrincipals_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteLdapPrincipals((System.Boolean)fieldSpecObj);
        }
        public static string DeleteLdapPrincipals(System.Boolean fieldSpec)
        {
            return DeleteLdapPrincipals_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteLdapPrincipals(object fieldSpecObj)
        {
            return DeleteLdapPrincipals_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteLdapPrincipalsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? DeleteOrg
        // GraphQL -> deleteOrg: Boolean! (scalar)
        public static string DeleteOrg_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteOrg" + args + "\n";
        }
        public static string DeleteOrg_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteOrg((System.Boolean)fieldSpecObj);
        }
        public static string DeleteOrg(System.Boolean fieldSpec)
        {
            return DeleteOrg_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteOrg(object fieldSpecObj)
        {
            return DeleteOrg_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteOrgFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? DeleteReplicationPair
        // GraphQL -> deleteReplicationPair: Void (scalar)
        public static string DeleteReplicationPair_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteReplicationPair" + args + "\n";
        }
        public static string DeleteReplicationPair_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteReplicationPair((System.String)fieldSpecObj);
        }
        public static string DeleteReplicationPair(System.String fieldSpec)
        {
            return DeleteReplicationPair_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteReplicationPair(object fieldSpecObj)
        {
            return DeleteReplicationPair_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteReplicationPairFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? DeleteRole
        // GraphQL -> deleteRole: Boolean! (scalar)
        public static string DeleteRole_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\nroleId: $roleId\n)";
            return "deleteRole" + args + "\n";
        }
        public static string DeleteRole_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteRole((System.Boolean)fieldSpecObj);
        }
        public static string DeleteRole(System.Boolean fieldSpec)
        {
            return DeleteRole_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteRole(object fieldSpecObj)
        {
            return DeleteRole_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteRoleFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? DeleteScheduledReport
        // GraphQL -> deleteScheduledReport: Void (scalar)
        public static string DeleteScheduledReport_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteScheduledReport" + args + "\n";
        }
        public static string DeleteScheduledReport_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteScheduledReport((System.String)fieldSpecObj);
        }
        public static string DeleteScheduledReport(System.String fieldSpec)
        {
            return DeleteScheduledReport_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteScheduledReport(object fieldSpecObj)
        {
            return DeleteScheduledReport_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteScheduledReportFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? DeleteServiceAccountsFromAccount
        // GraphQL -> deleteServiceAccountsFromAccount: Boolean! (scalar)
        public static string DeleteServiceAccountsFromAccount_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteServiceAccountsFromAccount" + args + "\n";
        }
        public static string DeleteServiceAccountsFromAccount_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteServiceAccountsFromAccount((System.Boolean)fieldSpecObj);
        }
        public static string DeleteServiceAccountsFromAccount(System.Boolean fieldSpec)
        {
            return DeleteServiceAccountsFromAccount_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteServiceAccountsFromAccount(object fieldSpecObj)
        {
            return DeleteServiceAccountsFromAccount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteServiceAccountsFromAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? DeleteSmbDomain
        // GraphQL -> deleteSmbDomain: Void (scalar)
        public static string DeleteSmbDomain_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteSmbDomain" + args + "\n";
        }
        public static string DeleteSmbDomain_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteSmbDomain((System.String)fieldSpecObj);
        }
        public static string DeleteSmbDomain(System.String fieldSpec)
        {
            return DeleteSmbDomain_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteSmbDomain(object fieldSpecObj)
        {
            return DeleteSmbDomain_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteSmbDomainFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeleteSyslogExportRule
        // GraphQL -> deleteSyslogExportRule: Void (scalar)
        public static string DeleteSyslogExportRule_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteSyslogExportRule" + args + "\n";
        }
        public static string DeleteSyslogExportRule_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteSyslogExportRule((System.String)fieldSpecObj);
        }
        public static string DeleteSyslogExportRule(System.String fieldSpec)
        {
            return DeleteSyslogExportRule_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteSyslogExportRule(object fieldSpecObj)
        {
            return DeleteSyslogExportRule_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteSyslogExportRuleFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeleteTarget
        // GraphQL -> deleteTarget: Void (scalar)
        public static string DeleteTarget_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteTarget" + args + "\n";
        }
        public static string DeleteTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteTarget((System.String)fieldSpecObj);
        }
        public static string DeleteTarget(System.String fieldSpec)
        {
            return DeleteTarget_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteTarget(object fieldSpecObj)
        {
            return DeleteTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeleteTargetMapping
        // GraphQL -> deleteTargetMapping: Void (scalar)
        public static string DeleteTargetMapping_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteTargetMapping" + args + "\n";
        }
        public static string DeleteTargetMapping_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteTargetMapping((System.String)fieldSpecObj);
        }
        public static string DeleteTargetMapping(System.String fieldSpec)
        {
            return DeleteTargetMapping_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteTargetMapping(object fieldSpecObj)
        {
            return DeleteTargetMapping_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteTargetMappingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? DeleteTotpConfig
        // GraphQL -> deleteTotpConfig: Boolean! (scalar)
        public static string DeleteTotpConfig_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\nuserId: $userId\n)";
            return "deleteTotpConfig" + args + "\n";
        }
        public static string DeleteTotpConfig_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteTotpConfig((System.Boolean)fieldSpecObj);
        }
        public static string DeleteTotpConfig(System.Boolean fieldSpec)
        {
            return DeleteTotpConfig_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteTotpConfig(object fieldSpecObj)
        {
            return DeleteTotpConfig_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteTotpConfigFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? DeleteTotpConfigs
        // GraphQL -> deleteTotpConfigs: Boolean! (scalar)
        public static string DeleteTotpConfigs_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteTotpConfigs" + args + "\n";
        }
        public static string DeleteTotpConfigs_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteTotpConfigs((System.Boolean)fieldSpecObj);
        }
        public static string DeleteTotpConfigs(System.Boolean fieldSpec)
        {
            return DeleteTotpConfigs_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteTotpConfigs(object fieldSpecObj)
        {
            return DeleteTotpConfigs_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteTotpConfigsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? DeleteUsersFromAccount
        // GraphQL -> deleteUsersFromAccount: Boolean! (scalar)
        public static string DeleteUsersFromAccount_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\nids: $ids\n)";
            return "deleteUsersFromAccount" + args + "\n";
        }
        public static string DeleteUsersFromAccount_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteUsersFromAccount((System.Boolean)fieldSpecObj);
        }
        public static string DeleteUsersFromAccount(System.Boolean fieldSpec)
        {
            return DeleteUsersFromAccount_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteUsersFromAccount(object fieldSpecObj)
        {
            return DeleteUsersFromAccount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteUsersFromAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? DeleteWebhook
        // GraphQL -> deleteWebhook: Void (scalar)
        public static string DeleteWebhook_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteWebhook" + args + "\n";
        }
        public static string DeleteWebhook_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteWebhook((System.String)fieldSpecObj);
        }
        public static string DeleteWebhook(System.String fieldSpec)
        {
            return DeleteWebhook_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteWebhook(object fieldSpecObj)
        {
            return DeleteWebhook_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteWebhookFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DisableSupportUserAccess
        // GraphQL -> disableSupportUserAccess: Void (scalar)
        public static string DisableSupportUserAccess_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "disableSupportUserAccess" + args + "\n";
        }
        public static string DisableSupportUserAccess_ObjectFieldSpec(object fieldSpecObj)
        {
            return DisableSupportUserAccess((System.String)fieldSpecObj);
        }
        public static string DisableSupportUserAccess(System.String fieldSpec)
        {
            return DisableSupportUserAccess_TypedFieldSpec(fieldSpec);
        }
        public static string DisableSupportUserAccess(object fieldSpecObj)
        {
            return DisableSupportUserAccess_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DisableSupportUserAccessFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DisconnectAwsExocomputeCluster
        // GraphQL -> disconnectAwsExocomputeCluster: Void (scalar)
        public static string DisconnectAwsExocomputeCluster_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "disconnectAwsExocomputeCluster" + args + "\n";
        }
        public static string DisconnectAwsExocomputeCluster_ObjectFieldSpec(object fieldSpecObj)
        {
            return DisconnectAwsExocomputeCluster((System.String)fieldSpecObj);
        }
        public static string DisconnectAwsExocomputeCluster(System.String fieldSpec)
        {
            return DisconnectAwsExocomputeCluster_TypedFieldSpec(fieldSpec);
        }
        public static string DisconnectAwsExocomputeCluster(object fieldSpecObj)
        {
            return DisconnectAwsExocomputeCluster_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DisconnectAwsExocomputeClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? EnableSupportUserAccess
        // GraphQL -> enableSupportUserAccess: Void (scalar)
        public static string EnableSupportUserAccess_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "enableSupportUserAccess" + args + "\n";
        }
        public static string EnableSupportUserAccess_ObjectFieldSpec(object fieldSpecObj)
        {
            return EnableSupportUserAccess((System.String)fieldSpecObj);
        }
        public static string EnableSupportUserAccess(System.String fieldSpec)
        {
            return EnableSupportUserAccess_TypedFieldSpec(fieldSpec);
        }
        public static string EnableSupportUserAccess(object fieldSpecObj)
        {
            return EnableSupportUserAccess_ObjectFieldSpec(fieldSpecObj);
        }
        public static object EnableSupportUserAccessFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? EnableThreatMonitoring
        // GraphQL -> enableThreatMonitoring: Void (scalar)
        public static string EnableThreatMonitoring_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "enableThreatMonitoring" + args + "\n";
        }
        public static string EnableThreatMonitoring_ObjectFieldSpec(object fieldSpecObj)
        {
            return EnableThreatMonitoring((System.String)fieldSpecObj);
        }
        public static string EnableThreatMonitoring(System.String fieldSpec)
        {
            return EnableThreatMonitoring_TypedFieldSpec(fieldSpec);
        }
        public static string EnableThreatMonitoring(object fieldSpecObj)
        {
            return EnableThreatMonitoring_ObjectFieldSpec(fieldSpecObj);
        }
        public static object EnableThreatMonitoringFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? ExcludeAwsNativeEbsVolumesFromSnapshot
        // GraphQL -> excludeAwsNativeEbsVolumesFromSnapshot: Void (scalar)
        public static string ExcludeAwsNativeEbsVolumesFromSnapshot_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "excludeAwsNativeEbsVolumesFromSnapshot" + args + "\n";
        }
        public static string ExcludeAwsNativeEbsVolumesFromSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return ExcludeAwsNativeEbsVolumesFromSnapshot((System.String)fieldSpecObj);
        }
        public static string ExcludeAwsNativeEbsVolumesFromSnapshot(System.String fieldSpec)
        {
            return ExcludeAwsNativeEbsVolumesFromSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string ExcludeAwsNativeEbsVolumesFromSnapshot(object fieldSpecObj)
        {
            return ExcludeAwsNativeEbsVolumesFromSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ExcludeAwsNativeEbsVolumesFromSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? ExcludeAzureNativeManagedDisksFromSnapshot
        // GraphQL -> excludeAzureNativeManagedDisksFromSnapshot: Void (scalar)
        public static string ExcludeAzureNativeManagedDisksFromSnapshot_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "excludeAzureNativeManagedDisksFromSnapshot" + args + "\n";
        }
        public static string ExcludeAzureNativeManagedDisksFromSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return ExcludeAzureNativeManagedDisksFromSnapshot((System.String)fieldSpecObj);
        }
        public static string ExcludeAzureNativeManagedDisksFromSnapshot(System.String fieldSpec)
        {
            return ExcludeAzureNativeManagedDisksFromSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string ExcludeAzureNativeManagedDisksFromSnapshot(object fieldSpecObj)
        {
            return ExcludeAzureNativeManagedDisksFromSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ExcludeAzureNativeManagedDisksFromSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? ExcludeSharepointObjectsFromProtection
        // GraphQL -> excludeSharepointObjectsFromProtection: Void (scalar)
        public static string ExcludeSharepointObjectsFromProtection_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "excludeSharepointObjectsFromProtection" + args + "\n";
        }
        public static string ExcludeSharepointObjectsFromProtection_ObjectFieldSpec(object fieldSpecObj)
        {
            return ExcludeSharepointObjectsFromProtection((System.String)fieldSpecObj);
        }
        public static string ExcludeSharepointObjectsFromProtection(System.String fieldSpec)
        {
            return ExcludeSharepointObjectsFromProtection_TypedFieldSpec(fieldSpec);
        }
        public static string ExcludeSharepointObjectsFromProtection(object fieldSpecObj)
        {
            return ExcludeSharepointObjectsFromProtection_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ExcludeSharepointObjectsFromProtectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? GcpCloudAccountAddManualAuthProject
        // GraphQL -> gcpCloudAccountAddManualAuthProject: Boolean! (scalar)
        public static string GcpCloudAccountAddManualAuthProject_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "gcpCloudAccountAddManualAuthProject" + args + "\n";
        }
        public static string GcpCloudAccountAddManualAuthProject_ObjectFieldSpec(object fieldSpecObj)
        {
            return GcpCloudAccountAddManualAuthProject((System.Boolean)fieldSpecObj);
        }
        public static string GcpCloudAccountAddManualAuthProject(System.Boolean fieldSpec)
        {
            return GcpCloudAccountAddManualAuthProject_TypedFieldSpec(fieldSpec);
        }
        public static string GcpCloudAccountAddManualAuthProject(object fieldSpecObj)
        {
            return GcpCloudAccountAddManualAuthProject_ObjectFieldSpec(fieldSpecObj);
        }
        public static object GcpCloudAccountAddManualAuthProjectFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? GcpNativeExcludeDisksFromInstanceSnapshot
        // GraphQL -> gcpNativeExcludeDisksFromInstanceSnapshot: Void (scalar)
        public static string GcpNativeExcludeDisksFromInstanceSnapshot_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "gcpNativeExcludeDisksFromInstanceSnapshot" + args + "\n";
        }
        public static string GcpNativeExcludeDisksFromInstanceSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return GcpNativeExcludeDisksFromInstanceSnapshot((System.String)fieldSpecObj);
        }
        public static string GcpNativeExcludeDisksFromInstanceSnapshot(System.String fieldSpec)
        {
            return GcpNativeExcludeDisksFromInstanceSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string GcpNativeExcludeDisksFromInstanceSnapshot(object fieldSpecObj)
        {
            return GcpNativeExcludeDisksFromInstanceSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object GcpNativeExcludeDisksFromInstanceSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? GcpSetDefaultServiceAccountJwtConfig
        // GraphQL -> gcpSetDefaultServiceAccountJwtConfig: Boolean! (scalar)
        public static string GcpSetDefaultServiceAccountJwtConfig_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "gcpSetDefaultServiceAccountJwtConfig" + args + "\n";
        }
        public static string GcpSetDefaultServiceAccountJwtConfig_ObjectFieldSpec(object fieldSpecObj)
        {
            return GcpSetDefaultServiceAccountJwtConfig((System.Boolean)fieldSpecObj);
        }
        public static string GcpSetDefaultServiceAccountJwtConfig(System.Boolean fieldSpec)
        {
            return GcpSetDefaultServiceAccountJwtConfig_TypedFieldSpec(fieldSpec);
        }
        public static string GcpSetDefaultServiceAccountJwtConfig(object fieldSpecObj)
        {
            return GcpSetDefaultServiceAccountJwtConfig_ObjectFieldSpec(fieldSpecObj);
        }
        public static object GcpSetDefaultServiceAccountJwtConfigFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? HideRevealNasNamespaces
        // GraphQL -> hideRevealNasNamespaces: Void (scalar)
        public static string HideRevealNasNamespaces_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "hideRevealNasNamespaces" + args + "\n";
        }
        public static string HideRevealNasNamespaces_ObjectFieldSpec(object fieldSpecObj)
        {
            return HideRevealNasNamespaces((System.String)fieldSpecObj);
        }
        public static string HideRevealNasNamespaces(System.String fieldSpec)
        {
            return HideRevealNasNamespaces_TypedFieldSpec(fieldSpec);
        }
        public static string HideRevealNasNamespaces(object fieldSpecObj)
        {
            return HideRevealNasNamespaces_ObjectFieldSpec(fieldSpecObj);
        }
        public static object HideRevealNasNamespacesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? InviteSsoGroup
        // GraphQL -> inviteSsoGroup: Boolean! (scalar)
        public static string InviteSsoGroup_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "inviteSsoGroup" + args + "\n";
        }
        public static string InviteSsoGroup_ObjectFieldSpec(object fieldSpecObj)
        {
            return InviteSsoGroup((System.Boolean)fieldSpecObj);
        }
        public static string InviteSsoGroup(System.Boolean fieldSpec)
        {
            return InviteSsoGroup_TypedFieldSpec(fieldSpec);
        }
        public static string InviteSsoGroup(object fieldSpecObj)
        {
            return InviteSsoGroup_ObjectFieldSpec(fieldSpecObj);
        }
        public static object InviteSsoGroupFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? JoinSmbDomain
        // GraphQL -> joinSmbDomain: Void (scalar)
        public static string JoinSmbDomain_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "joinSmbDomain" + args + "\n";
        }
        public static string JoinSmbDomain_ObjectFieldSpec(object fieldSpecObj)
        {
            return JoinSmbDomain((System.String)fieldSpecObj);
        }
        public static string JoinSmbDomain(System.String fieldSpec)
        {
            return JoinSmbDomain_TypedFieldSpec(fieldSpec);
        }
        public static string JoinSmbDomain(object fieldSpecObj)
        {
            return JoinSmbDomain_ObjectFieldSpec(fieldSpecObj);
        }
        public static object JoinSmbDomainFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? LockUsersByAdmin
        // GraphQL -> lockUsersByAdmin: Void (scalar)
        public static string LockUsersByAdmin_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "lockUsersByAdmin" + args + "\n";
        }
        public static string LockUsersByAdmin_ObjectFieldSpec(object fieldSpecObj)
        {
            return LockUsersByAdmin((System.String)fieldSpecObj);
        }
        public static string LockUsersByAdmin(System.String fieldSpec)
        {
            return LockUsersByAdmin_TypedFieldSpec(fieldSpec);
        }
        public static string LockUsersByAdmin(object fieldSpecObj)
        {
            return LockUsersByAdmin_ObjectFieldSpec(fieldSpecObj);
        }
        public static object LockUsersByAdminFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? ModifyActiveDirectoryLiveMount
        // GraphQL -> modifyActiveDirectoryLiveMount: Void (scalar)
        public static string ModifyActiveDirectoryLiveMount_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "modifyActiveDirectoryLiveMount" + args + "\n";
        }
        public static string ModifyActiveDirectoryLiveMount_ObjectFieldSpec(object fieldSpecObj)
        {
            return ModifyActiveDirectoryLiveMount((System.String)fieldSpecObj);
        }
        public static string ModifyActiveDirectoryLiveMount(System.String fieldSpec)
        {
            return ModifyActiveDirectoryLiveMount_TypedFieldSpec(fieldSpec);
        }
        public static string ModifyActiveDirectoryLiveMount(object fieldSpecObj)
        {
            return ModifyActiveDirectoryLiveMount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ModifyActiveDirectoryLiveMountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? ModifyEventDigestBatch
        // GraphQL -> modifyEventDigestBatch: Void (scalar)
        public static string ModifyEventDigestBatch_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "modifyEventDigestBatch" + args + "\n";
        }
        public static string ModifyEventDigestBatch_ObjectFieldSpec(object fieldSpecObj)
        {
            return ModifyEventDigestBatch((System.String)fieldSpecObj);
        }
        public static string ModifyEventDigestBatch(System.String fieldSpec)
        {
            return ModifyEventDigestBatch_TypedFieldSpec(fieldSpec);
        }
        public static string ModifyEventDigestBatch(object fieldSpecObj)
        {
            return ModifyEventDigestBatch_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ModifyEventDigestBatchFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? MutateRole
        // GraphQL -> mutateRole: UUID! (scalar)
        public static string MutateRole_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\nroleId: $roleId\nname: $name\ndescription: $description\npermissions: $permissions\nprotectableClusters: $protectableClusters\n)";
            return "mutateRole" + args + "\n";
        }
        public static string MutateRole_ObjectFieldSpec(object fieldSpecObj)
        {
            return MutateRole((System.String)fieldSpecObj);
        }
        public static string MutateRole(System.String fieldSpec)
        {
            return MutateRole_TypedFieldSpec(fieldSpec);
        }
        public static string MutateRole(object fieldSpecObj)
        {
            return MutateRole_ObjectFieldSpec(fieldSpecObj);
        }
        public static object MutateRoleFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? PatchAwsAuthenticationServerBasedCloudAccount
        // GraphQL -> patchAwsAuthenticationServerBasedCloudAccount: Boolean! (scalar)
        public static string PatchAwsAuthenticationServerBasedCloudAccount_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "patchAwsAuthenticationServerBasedCloudAccount" + args + "\n";
        }
        public static string PatchAwsAuthenticationServerBasedCloudAccount_ObjectFieldSpec(object fieldSpecObj)
        {
            return PatchAwsAuthenticationServerBasedCloudAccount((System.Boolean)fieldSpecObj);
        }
        public static string PatchAwsAuthenticationServerBasedCloudAccount(System.Boolean fieldSpec)
        {
            return PatchAwsAuthenticationServerBasedCloudAccount_TypedFieldSpec(fieldSpec);
        }
        public static string PatchAwsAuthenticationServerBasedCloudAccount(object fieldSpecObj)
        {
            return PatchAwsAuthenticationServerBasedCloudAccount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object PatchAwsAuthenticationServerBasedCloudAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? PatchAwsIamUserBasedCloudAccount
        // GraphQL -> patchAwsIamUserBasedCloudAccount: Boolean! (scalar)
        public static string PatchAwsIamUserBasedCloudAccount_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "patchAwsIamUserBasedCloudAccount" + args + "\n";
        }
        public static string PatchAwsIamUserBasedCloudAccount_ObjectFieldSpec(object fieldSpecObj)
        {
            return PatchAwsIamUserBasedCloudAccount((System.Boolean)fieldSpecObj);
        }
        public static string PatchAwsIamUserBasedCloudAccount(System.Boolean fieldSpec)
        {
            return PatchAwsIamUserBasedCloudAccount_TypedFieldSpec(fieldSpec);
        }
        public static string PatchAwsIamUserBasedCloudAccount(object fieldSpecObj)
        {
            return PatchAwsIamUserBasedCloudAccount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object PatchAwsIamUserBasedCloudAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? PromoteReaderTarget
        // GraphQL -> promoteReaderTarget: Void (scalar)
        public static string PromoteReaderTarget_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "promoteReaderTarget" + args + "\n";
        }
        public static string PromoteReaderTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return PromoteReaderTarget((System.String)fieldSpecObj);
        }
        public static string PromoteReaderTarget(System.String fieldSpec)
        {
            return PromoteReaderTarget_TypedFieldSpec(fieldSpec);
        }
        public static string PromoteReaderTarget(object fieldSpecObj)
        {
            return PromoteReaderTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object PromoteReaderTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? RefreshReaderTarget
        // GraphQL -> refreshReaderTarget: Void (scalar)
        public static string RefreshReaderTarget_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "refreshReaderTarget" + args + "\n";
        }
        public static string RefreshReaderTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return RefreshReaderTarget((System.String)fieldSpecObj);
        }
        public static string RefreshReaderTarget(System.String fieldSpec)
        {
            return RefreshReaderTarget_TypedFieldSpec(fieldSpec);
        }
        public static string RefreshReaderTarget(object fieldSpecObj)
        {
            return RefreshReaderTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RefreshReaderTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? RemoveCdmCluster
        // GraphQL -> removeCdmCluster: Boolean! (scalar)
        public static string RemoveCdmCluster_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\nclusterUUID: $clusterUUID\nisForce: $isForce\nexpireInDays: $expireInDays\n)";
            return "removeCdmCluster" + args + "\n";
        }
        public static string RemoveCdmCluster_ObjectFieldSpec(object fieldSpecObj)
        {
            return RemoveCdmCluster((System.Boolean)fieldSpecObj);
        }
        public static string RemoveCdmCluster(System.Boolean fieldSpec)
        {
            return RemoveCdmCluster_TypedFieldSpec(fieldSpec);
        }
        public static string RemoveCdmCluster(object fieldSpecObj)
        {
            return RemoveCdmCluster_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RemoveCdmClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? RemoveInventoryWorkloads
        // GraphQL -> removeInventoryWorkloads: Boolean! (scalar)
        public static string RemoveInventoryWorkloads_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "removeInventoryWorkloads" + args + "\n";
        }
        public static string RemoveInventoryWorkloads_ObjectFieldSpec(object fieldSpecObj)
        {
            return RemoveInventoryWorkloads((System.Boolean)fieldSpecObj);
        }
        public static string RemoveInventoryWorkloads(System.Boolean fieldSpec)
        {
            return RemoveInventoryWorkloads_TypedFieldSpec(fieldSpec);
        }
        public static string RemoveInventoryWorkloads(object fieldSpecObj)
        {
            return RemoveInventoryWorkloads_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RemoveInventoryWorkloadsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? RemoveLdapIntegration
        // GraphQL -> removeLdapIntegration: Boolean! (scalar)
        public static string RemoveLdapIntegration_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\nid: $id\n)";
            return "removeLdapIntegration" + args + "\n";
        }
        public static string RemoveLdapIntegration_ObjectFieldSpec(object fieldSpecObj)
        {
            return RemoveLdapIntegration((System.Boolean)fieldSpecObj);
        }
        public static string RemoveLdapIntegration(System.Boolean fieldSpec)
        {
            return RemoveLdapIntegration_TypedFieldSpec(fieldSpec);
        }
        public static string RemoveLdapIntegration(object fieldSpecObj)
        {
            return RemoveLdapIntegration_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RemoveLdapIntegrationFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> List<System.String>? RemovePolicyObjects
        // GraphQL -> removePolicyObjects: [String!]! (scalar)
        public static string RemovePolicyObjects_TypedFieldSpec(List<System.String> fieldSpec)
        {
            string args = "\n(\npolicyIds: $policyIds\nobjectIds: $objectIds\nobjectRootIds: $objectRootIds\nclusterIds: $clusterIds\nrunAsync: $runAsync\n)";
            return "removePolicyObjects" + args + "\n";
        }
        public static string RemovePolicyObjects_ObjectFieldSpec(object fieldSpecObj)
        {
            return RemovePolicyObjects((List<System.String>)fieldSpecObj);
        }
        public static string RemovePolicyObjects(List<System.String> fieldSpec)
        {
            return RemovePolicyObjects_TypedFieldSpec(fieldSpec);
        }
        public static string RemovePolicyObjects(object fieldSpecObj)
        {
            return RemovePolicyObjects_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RemovePolicyObjectsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> System.String? RemovePrivateEndpointConnection
        // GraphQL -> removePrivateEndpointConnection: Void (scalar)
        public static string RemovePrivateEndpointConnection_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "removePrivateEndpointConnection" + args + "\n";
        }
        public static string RemovePrivateEndpointConnection_ObjectFieldSpec(object fieldSpecObj)
        {
            return RemovePrivateEndpointConnection((System.String)fieldSpecObj);
        }
        public static string RemovePrivateEndpointConnection(System.String fieldSpec)
        {
            return RemovePrivateEndpointConnection_TypedFieldSpec(fieldSpec);
        }
        public static string RemovePrivateEndpointConnection(object fieldSpecObj)
        {
            return RemovePrivateEndpointConnection_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RemovePrivateEndpointConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? ResetAllOrgUsersPasswords
        // GraphQL -> resetAllOrgUsersPasswords: Void (scalar)
        public static string ResetAllOrgUsersPasswords_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "";
            return "resetAllOrgUsersPasswords" + args + "\n";
        }
        public static string ResetAllOrgUsersPasswords_ObjectFieldSpec(object fieldSpecObj)
        {
            return ResetAllOrgUsersPasswords((System.String)fieldSpecObj);
        }
        public static string ResetAllOrgUsersPasswords(System.String fieldSpec)
        {
            return ResetAllOrgUsersPasswords_TypedFieldSpec(fieldSpec);
        }
        public static string ResetAllOrgUsersPasswords(object fieldSpecObj)
        {
            return ResetAllOrgUsersPasswords_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ResetAllOrgUsersPasswordsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? ResetUsersPasswordsWithUserIds
        // GraphQL -> resetUsersPasswordsWithUserIds: Void (scalar)
        public static string ResetUsersPasswordsWithUserIds_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "resetUsersPasswordsWithUserIds" + args + "\n";
        }
        public static string ResetUsersPasswordsWithUserIds_ObjectFieldSpec(object fieldSpecObj)
        {
            return ResetUsersPasswordsWithUserIds((System.String)fieldSpecObj);
        }
        public static string ResetUsersPasswordsWithUserIds(System.String fieldSpec)
        {
            return ResetUsersPasswordsWithUserIds_TypedFieldSpec(fieldSpec);
        }
        public static string ResetUsersPasswordsWithUserIds(object fieldSpecObj)
        {
            return ResetUsersPasswordsWithUserIds_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ResetUsersPasswordsWithUserIdsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? ResolveAnomaly
        // GraphQL -> resolveAnomaly: Void (scalar)
        public static string ResolveAnomaly_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "resolveAnomaly" + args + "\n";
        }
        public static string ResolveAnomaly_ObjectFieldSpec(object fieldSpecObj)
        {
            return ResolveAnomaly((System.String)fieldSpecObj);
        }
        public static string ResolveAnomaly(System.String fieldSpec)
        {
            return ResolveAnomaly_TypedFieldSpec(fieldSpec);
        }
        public static string ResolveAnomaly(object fieldSpecObj)
        {
            return ResolveAnomaly_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ResolveAnomalyFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? RevokeAllOrgRoles
        // GraphQL -> revokeAllOrgRoles: Void (scalar)
        public static string RevokeAllOrgRoles_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "revokeAllOrgRoles" + args + "\n";
        }
        public static string RevokeAllOrgRoles_ObjectFieldSpec(object fieldSpecObj)
        {
            return RevokeAllOrgRoles((System.String)fieldSpecObj);
        }
        public static string RevokeAllOrgRoles(System.String fieldSpec)
        {
            return RevokeAllOrgRoles_TypedFieldSpec(fieldSpec);
        }
        public static string RevokeAllOrgRoles(object fieldSpecObj)
        {
            return RevokeAllOrgRoles_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RevokeAllOrgRolesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? SetAzureCloudAccountCustomerAppCredentials
        // GraphQL -> setAzureCloudAccountCustomerAppCredentials: Boolean! (scalar)
        public static string SetAzureCloudAccountCustomerAppCredentials_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "setAzureCloudAccountCustomerAppCredentials" + args + "\n";
        }
        public static string SetAzureCloudAccountCustomerAppCredentials_ObjectFieldSpec(object fieldSpecObj)
        {
            return SetAzureCloudAccountCustomerAppCredentials((System.Boolean)fieldSpecObj);
        }
        public static string SetAzureCloudAccountCustomerAppCredentials(System.Boolean fieldSpec)
        {
            return SetAzureCloudAccountCustomerAppCredentials_TypedFieldSpec(fieldSpec);
        }
        public static string SetAzureCloudAccountCustomerAppCredentials(object fieldSpecObj)
        {
            return SetAzureCloudAccountCustomerAppCredentials_ObjectFieldSpec(fieldSpecObj);
        }
        public static object SetAzureCloudAccountCustomerAppCredentialsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? SetBundleApprovalStatus
        // GraphQL -> setBundleApprovalStatus: Void (scalar)
        public static string SetBundleApprovalStatus_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "setBundleApprovalStatus" + args + "\n";
        }
        public static string SetBundleApprovalStatus_ObjectFieldSpec(object fieldSpecObj)
        {
            return SetBundleApprovalStatus((System.String)fieldSpecObj);
        }
        public static string SetBundleApprovalStatus(System.String fieldSpec)
        {
            return SetBundleApprovalStatus_TypedFieldSpec(fieldSpec);
        }
        public static string SetBundleApprovalStatus(object fieldSpecObj)
        {
            return SetBundleApprovalStatus_ObjectFieldSpec(fieldSpecObj);
        }
        public static object SetBundleApprovalStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? SetCustomerTags
        // GraphQL -> setCustomerTags: Void (scalar)
        public static string SetCustomerTags_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "setCustomerTags" + args + "\n";
        }
        public static string SetCustomerTags_ObjectFieldSpec(object fieldSpecObj)
        {
            return SetCustomerTags((System.String)fieldSpecObj);
        }
        public static string SetCustomerTags(System.String fieldSpec)
        {
            return SetCustomerTags_TypedFieldSpec(fieldSpec);
        }
        public static string SetCustomerTags(object fieldSpecObj)
        {
            return SetCustomerTags_ObjectFieldSpec(fieldSpecObj);
        }
        public static object SetCustomerTagsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? SetIpWhitelistEnabled
        // GraphQL -> setIpWhitelistEnabled: Boolean! (scalar)
        public static string SetIpWhitelistEnabled_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\nenabled: $enabled\n)";
            return "setIpWhitelistEnabled" + args + "\n";
        }
        public static string SetIpWhitelistEnabled_ObjectFieldSpec(object fieldSpecObj)
        {
            return SetIpWhitelistEnabled((System.Boolean)fieldSpecObj);
        }
        public static string SetIpWhitelistEnabled(System.Boolean fieldSpec)
        {
            return SetIpWhitelistEnabled_TypedFieldSpec(fieldSpec);
        }
        public static string SetIpWhitelistEnabled(object fieldSpecObj)
        {
            return SetIpWhitelistEnabled_ObjectFieldSpec(fieldSpecObj);
        }
        public static object SetIpWhitelistEnabledFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? SetLdapMfaSetting
        // GraphQL -> setLdapMfaSetting: Boolean! (scalar)
        public static string SetLdapMfaSetting_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "setLdapMfaSetting" + args + "\n";
        }
        public static string SetLdapMfaSetting_ObjectFieldSpec(object fieldSpecObj)
        {
            return SetLdapMfaSetting((System.Boolean)fieldSpecObj);
        }
        public static string SetLdapMfaSetting(System.Boolean fieldSpec)
        {
            return SetLdapMfaSetting_TypedFieldSpec(fieldSpec);
        }
        public static string SetLdapMfaSetting(object fieldSpecObj)
        {
            return SetLdapMfaSetting_ObjectFieldSpec(fieldSpecObj);
        }
        public static object SetLdapMfaSettingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? SetMfaSetting
        // GraphQL -> setMfaSetting: Boolean! (scalar)
        public static string SetMfaSetting_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "setMfaSetting" + args + "\n";
        }
        public static string SetMfaSetting_ObjectFieldSpec(object fieldSpecObj)
        {
            return SetMfaSetting((System.Boolean)fieldSpecObj);
        }
        public static string SetMfaSetting(System.Boolean fieldSpec)
        {
            return SetMfaSetting_TypedFieldSpec(fieldSpec);
        }
        public static string SetMfaSetting(object fieldSpecObj)
        {
            return SetMfaSetting_ObjectFieldSpec(fieldSpecObj);
        }
        public static object SetMfaSettingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? SetPasswordComplexityPolicy
        // GraphQL -> setPasswordComplexityPolicy: Void (scalar)
        public static string SetPasswordComplexityPolicy_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "setPasswordComplexityPolicy" + args + "\n";
        }
        public static string SetPasswordComplexityPolicy_ObjectFieldSpec(object fieldSpecObj)
        {
            return SetPasswordComplexityPolicy((System.String)fieldSpecObj);
        }
        public static string SetPasswordComplexityPolicy(System.String fieldSpec)
        {
            return SetPasswordComplexityPolicy_TypedFieldSpec(fieldSpec);
        }
        public static string SetPasswordComplexityPolicy(object fieldSpecObj)
        {
            return SetPasswordComplexityPolicy_ObjectFieldSpec(fieldSpecObj);
        }
        public static object SetPasswordComplexityPolicyFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? SetPrivateContainerRegistry
        // GraphQL -> setPrivateContainerRegistry: Void (scalar)
        public static string SetPrivateContainerRegistry_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "setPrivateContainerRegistry" + args + "\n";
        }
        public static string SetPrivateContainerRegistry_ObjectFieldSpec(object fieldSpecObj)
        {
            return SetPrivateContainerRegistry((System.String)fieldSpecObj);
        }
        public static string SetPrivateContainerRegistry(System.String fieldSpec)
        {
            return SetPrivateContainerRegistry_TypedFieldSpec(fieldSpec);
        }
        public static string SetPrivateContainerRegistry(object fieldSpecObj)
        {
            return SetPrivateContainerRegistry_ObjectFieldSpec(fieldSpecObj);
        }
        public static object SetPrivateContainerRegistryFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? SetSsoCertificate
        // GraphQL -> setSsoCertificate: Void (scalar)
        public static string SetSsoCertificate_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "setSsoCertificate" + args + "\n";
        }
        public static string SetSsoCertificate_ObjectFieldSpec(object fieldSpecObj)
        {
            return SetSsoCertificate((System.String)fieldSpecObj);
        }
        public static string SetSsoCertificate(System.String fieldSpec)
        {
            return SetSsoCertificate_TypedFieldSpec(fieldSpec);
        }
        public static string SetSsoCertificate(object fieldSpecObj)
        {
            return SetSsoCertificate_ObjectFieldSpec(fieldSpecObj);
        }
        public static object SetSsoCertificateFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? SetTotpConfig
        // GraphQL -> setTotpConfig: Boolean! (scalar)
        public static string SetTotpConfig_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "setTotpConfig" + args + "\n";
        }
        public static string SetTotpConfig_ObjectFieldSpec(object fieldSpecObj)
        {
            return SetTotpConfig((System.Boolean)fieldSpecObj);
        }
        public static string SetTotpConfig(System.Boolean fieldSpec)
        {
            return SetTotpConfig_TypedFieldSpec(fieldSpec);
        }
        public static string SetTotpConfig(object fieldSpecObj)
        {
            return SetTotpConfig_ObjectFieldSpec(fieldSpecObj);
        }
        public static object SetTotpConfigFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? SetUserLevelTotpEnforcement
        // GraphQL -> setUserLevelTotpEnforcement: Boolean! (scalar)
        public static string SetUserLevelTotpEnforcement_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "setUserLevelTotpEnforcement" + args + "\n";
        }
        public static string SetUserLevelTotpEnforcement_ObjectFieldSpec(object fieldSpecObj)
        {
            return SetUserLevelTotpEnforcement((System.Boolean)fieldSpecObj);
        }
        public static string SetUserLevelTotpEnforcement(System.Boolean fieldSpec)
        {
            return SetUserLevelTotpEnforcement_TypedFieldSpec(fieldSpec);
        }
        public static string SetUserLevelTotpEnforcement(object fieldSpecObj)
        {
            return SetUserLevelTotpEnforcement_ObjectFieldSpec(fieldSpecObj);
        }
        public static object SetUserLevelTotpEnforcementFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? StopJobInstanceFromEventSeries
        // GraphQL -> stopJobInstanceFromEventSeries: Void (scalar)
        public static string StopJobInstanceFromEventSeries_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "stopJobInstanceFromEventSeries" + args + "\n";
        }
        public static string StopJobInstanceFromEventSeries_ObjectFieldSpec(object fieldSpecObj)
        {
            return StopJobInstanceFromEventSeries((System.String)fieldSpecObj);
        }
        public static string StopJobInstanceFromEventSeries(System.String fieldSpec)
        {
            return StopJobInstanceFromEventSeries_TypedFieldSpec(fieldSpec);
        }
        public static string StopJobInstanceFromEventSeries(object fieldSpecObj)
        {
            return StopJobInstanceFromEventSeries_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StopJobInstanceFromEventSeriesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UnlockUsersByAdmin
        // GraphQL -> unlockUsersByAdmin: Void (scalar)
        public static string UnlockUsersByAdmin_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "unlockUsersByAdmin" + args + "\n";
        }
        public static string UnlockUsersByAdmin_ObjectFieldSpec(object fieldSpecObj)
        {
            return UnlockUsersByAdmin((System.String)fieldSpecObj);
        }
        public static string UnlockUsersByAdmin(System.String fieldSpec)
        {
            return UnlockUsersByAdmin_TypedFieldSpec(fieldSpec);
        }
        public static string UnlockUsersByAdmin(object fieldSpecObj)
        {
            return UnlockUsersByAdmin_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UnlockUsersByAdminFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UnmapAzurePersistentStorageSubscription
        // GraphQL -> unmapAzurePersistentStorageSubscription: Void (scalar)
        public static string UnmapAzurePersistentStorageSubscription_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "unmapAzurePersistentStorageSubscription" + args + "\n";
        }
        public static string UnmapAzurePersistentStorageSubscription_ObjectFieldSpec(object fieldSpecObj)
        {
            return UnmapAzurePersistentStorageSubscription((System.String)fieldSpecObj);
        }
        public static string UnmapAzurePersistentStorageSubscription(System.String fieldSpec)
        {
            return UnmapAzurePersistentStorageSubscription_TypedFieldSpec(fieldSpec);
        }
        public static string UnmapAzurePersistentStorageSubscription(object fieldSpecObj)
        {
            return UnmapAzurePersistentStorageSubscription_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UnmapAzurePersistentStorageSubscriptionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UnmountDisk
        // GraphQL -> unmountDisk: Void (scalar)
        public static string UnmountDisk_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "unmountDisk" + args + "\n";
        }
        public static string UnmountDisk_ObjectFieldSpec(object fieldSpecObj)
        {
            return UnmountDisk((System.String)fieldSpecObj);
        }
        public static string UnmountDisk(System.String fieldSpec)
        {
            return UnmountDisk_TypedFieldSpec(fieldSpec);
        }
        public static string UnmountDisk(object fieldSpecObj)
        {
            return UnmountDisk_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UnmountDiskFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? UpdateAccountOwner
        // GraphQL -> updateAccountOwner: Boolean! (scalar)
        public static string UpdateAccountOwner_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\nuserId: $userId\n)";
            return "updateAccountOwner" + args + "\n";
        }
        public static string UpdateAccountOwner_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateAccountOwner((System.Boolean)fieldSpecObj);
        }
        public static string UpdateAccountOwner(System.Boolean fieldSpec)
        {
            return UpdateAccountOwner_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateAccountOwner(object fieldSpecObj)
        {
            return UpdateAccountOwner_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateAccountOwnerFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? UpdateAuthDomainUsersHiddenStatus
        // GraphQL -> updateAuthDomainUsersHiddenStatus: Void (scalar)
        public static string UpdateAuthDomainUsersHiddenStatus_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateAuthDomainUsersHiddenStatus" + args + "\n";
        }
        public static string UpdateAuthDomainUsersHiddenStatus_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateAuthDomainUsersHiddenStatus((System.String)fieldSpecObj);
        }
        public static string UpdateAuthDomainUsersHiddenStatus(System.String fieldSpec)
        {
            return UpdateAuthDomainUsersHiddenStatus_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateAuthDomainUsersHiddenStatus(object fieldSpecObj)
        {
            return UpdateAuthDomainUsersHiddenStatus_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateAuthDomainUsersHiddenStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateAwsCloudAccount
        // GraphQL -> updateAwsCloudAccount: Void (scalar)
        public static string UpdateAwsCloudAccount_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateAwsCloudAccount" + args + "\n";
        }
        public static string UpdateAwsCloudAccount_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateAwsCloudAccount((System.String)fieldSpecObj);
        }
        public static string UpdateAwsCloudAccount(System.String fieldSpec)
        {
            return UpdateAwsCloudAccount_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateAwsCloudAccount(object fieldSpecObj)
        {
            return UpdateAwsCloudAccount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateAwsCloudAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? UpdateCertificate
        // GraphQL -> updateCertificate: Boolean! (scalar)
        public static string UpdateCertificate_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\ncertificateId: $certificateId\nname: $name\ndescription: $description\ncertificate: $certificate\n)";
            return "updateCertificate" + args + "\n";
        }
        public static string UpdateCertificate_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateCertificate((System.Boolean)fieldSpecObj);
        }
        public static string UpdateCertificate(System.Boolean fieldSpec)
        {
            return UpdateCertificate_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateCertificate(object fieldSpecObj)
        {
            return UpdateCertificate_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateCertificateFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? UpdateCloudNativeLabelRule
        // GraphQL -> updateCloudNativeLabelRule: Void (scalar)
        public static string UpdateCloudNativeLabelRule_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateCloudNativeLabelRule" + args + "\n";
        }
        public static string UpdateCloudNativeLabelRule_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateCloudNativeLabelRule((System.String)fieldSpecObj);
        }
        public static string UpdateCloudNativeLabelRule(System.String fieldSpec)
        {
            return UpdateCloudNativeLabelRule_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateCloudNativeLabelRule(object fieldSpecObj)
        {
            return UpdateCloudNativeLabelRule_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateCloudNativeLabelRuleFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateCloudNativeTagRule
        // GraphQL -> updateCloudNativeTagRule: Void (scalar)
        public static string UpdateCloudNativeTagRule_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateCloudNativeTagRule" + args + "\n";
        }
        public static string UpdateCloudNativeTagRule_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateCloudNativeTagRule((System.String)fieldSpecObj);
        }
        public static string UpdateCloudNativeTagRule(System.String fieldSpec)
        {
            return UpdateCloudNativeTagRule_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateCloudNativeTagRule(object fieldSpecObj)
        {
            return UpdateCloudNativeTagRule_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateCloudNativeTagRuleFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateConfiguredGroup
        // GraphQL -> updateConfiguredGroup: Void (scalar)
        public static string UpdateConfiguredGroup_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateConfiguredGroup" + args + "\n";
        }
        public static string UpdateConfiguredGroup_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateConfiguredGroup((System.String)fieldSpecObj);
        }
        public static string UpdateConfiguredGroup(System.String fieldSpec)
        {
            return UpdateConfiguredGroup_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateConfiguredGroup(object fieldSpecObj)
        {
            return UpdateConfiguredGroup_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateConfiguredGroupFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateCustomerAppPermissionForAzureSql
        // GraphQL -> updateCustomerAppPermissionForAzureSql: Void (scalar)
        public static string UpdateCustomerAppPermissionForAzureSql_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "";
            return "updateCustomerAppPermissionForAzureSql" + args + "\n";
        }
        public static string UpdateCustomerAppPermissionForAzureSql_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateCustomerAppPermissionForAzureSql((System.String)fieldSpecObj);
        }
        public static string UpdateCustomerAppPermissionForAzureSql(System.String fieldSpec)
        {
            return UpdateCustomerAppPermissionForAzureSql_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateCustomerAppPermissionForAzureSql(object fieldSpecObj)
        {
            return UpdateCustomerAppPermissionForAzureSql_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateCustomerAppPermissionForAzureSqlFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateIntegration
        // GraphQL -> updateIntegration: Void (scalar)
        public static string UpdateIntegration_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateIntegration" + args + "\n";
        }
        public static string UpdateIntegration_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateIntegration((System.String)fieldSpecObj);
        }
        public static string UpdateIntegration(System.String fieldSpec)
        {
            return UpdateIntegration_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateIntegration(object fieldSpecObj)
        {
            return UpdateIntegration_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateIntegrationFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateIntegrations
        // GraphQL -> updateIntegrations: Void (scalar)
        public static string UpdateIntegrations_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateIntegrations" + args + "\n";
        }
        public static string UpdateIntegrations_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateIntegrations((System.String)fieldSpecObj);
        }
        public static string UpdateIntegrations(System.String fieldSpec)
        {
            return UpdateIntegrations_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateIntegrations(object fieldSpecObj)
        {
            return UpdateIntegrations_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateIntegrationsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? UpdateIpWhitelist
        // GraphQL -> updateIpWhitelist: Boolean! (scalar)
        public static string UpdateIpWhitelist_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\nwhitelistMode: $whitelistMode\nipCidrs: $ipCidrs\n)";
            return "updateIpWhitelist" + args + "\n";
        }
        public static string UpdateIpWhitelist_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateIpWhitelist((System.Boolean)fieldSpecObj);
        }
        public static string UpdateIpWhitelist(System.Boolean fieldSpec)
        {
            return UpdateIpWhitelist_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateIpWhitelist(object fieldSpecObj)
        {
            return UpdateIpWhitelist_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateIpWhitelistFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? UpdateLdapIntegration
        // GraphQL -> updateLdapIntegration: String! (scalar)
        public static string UpdateLdapIntegration_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\nid: $id\nname: $name\nbindUserName: $bindUserName\nbindUserPassword: $bindUserPassword\nbaseDn: $baseDn\ntrustedCerts: $trustedCerts\ndynamicDnsName: $dynamicDnsName\nldapServers: $ldapServers\nuserSearchFilter: $userSearchFilter\nuserNameAttr: $userNameAttr\ngroupMembershipAttr: $groupMembershipAttr\ngroupSearchFilter: $groupSearchFilter\ngroupMemberAttr: $groupMemberAttr\n)";
            return "updateLdapIntegration" + args + "\n";
        }
        public static string UpdateLdapIntegration_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateLdapIntegration((System.String)fieldSpecObj);
        }
        public static string UpdateLdapIntegration(System.String fieldSpec)
        {
            return UpdateLdapIntegration_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateLdapIntegration(object fieldSpecObj)
        {
            return UpdateLdapIntegration_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateLdapIntegrationFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateNasShares
        // GraphQL -> updateNasShares: Void (scalar)
        public static string UpdateNasShares_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateNasShares" + args + "\n";
        }
        public static string UpdateNasShares_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateNasShares((System.String)fieldSpecObj);
        }
        public static string UpdateNasShares(System.String fieldSpec)
        {
            return UpdateNasShares_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateNasShares(object fieldSpecObj)
        {
            return UpdateNasShares_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateNasSharesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateNutanixVm
        // GraphQL -> updateNutanixVm: Void (scalar)
        public static string UpdateNutanixVm_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateNutanixVm" + args + "\n";
        }
        public static string UpdateNutanixVm_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateNutanixVm((System.String)fieldSpecObj);
        }
        public static string UpdateNutanixVm(System.String fieldSpec)
        {
            return UpdateNutanixVm_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateNutanixVm(object fieldSpecObj)
        {
            return UpdateNutanixVm_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateNutanixVmFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateO365AppPermissions
        // GraphQL -> updateO365AppPermissions: Void (scalar)
        public static string UpdateO365AppPermissions_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateO365AppPermissions" + args + "\n";
        }
        public static string UpdateO365AppPermissions_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateO365AppPermissions((System.String)fieldSpecObj);
        }
        public static string UpdateO365AppPermissions(System.String fieldSpec)
        {
            return UpdateO365AppPermissions_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateO365AppPermissions(object fieldSpecObj)
        {
            return UpdateO365AppPermissions_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateO365AppPermissionsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateOrgSecurityPolicy
        // GraphQL -> updateOrgSecurityPolicy: Void (scalar)
        public static string UpdateOrgSecurityPolicy_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateOrgSecurityPolicy" + args + "\n";
        }
        public static string UpdateOrgSecurityPolicy_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateOrgSecurityPolicy((System.String)fieldSpecObj);
        }
        public static string UpdateOrgSecurityPolicy(System.String fieldSpec)
        {
            return UpdateOrgSecurityPolicy_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateOrgSecurityPolicy(object fieldSpecObj)
        {
            return UpdateOrgSecurityPolicy_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateOrgSecurityPolicyFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateReplicationTarget
        // GraphQL -> updateReplicationTarget: Void (scalar)
        public static string UpdateReplicationTarget_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateReplicationTarget" + args + "\n";
        }
        public static string UpdateReplicationTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateReplicationTarget((System.String)fieldSpecObj);
        }
        public static string UpdateReplicationTarget(System.String fieldSpec)
        {
            return UpdateReplicationTarget_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateReplicationTarget(object fieldSpecObj)
        {
            return UpdateReplicationTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateReplicationTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? UpdateRole
        // GraphQL -> updateRole: Boolean! (scalar)
        public static string UpdateRole_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\nroleId: $roleId\nname: $name\ndescription: $description\npermissions: $permissions\n)";
            return "updateRole" + args + "\n";
        }
        public static string UpdateRole_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateRole((System.Boolean)fieldSpecObj);
        }
        public static string UpdateRole(System.Boolean fieldSpec)
        {
            return UpdateRole_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateRole(object fieldSpecObj)
        {
            return UpdateRole_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateRoleFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? UpdateRoleAssignments
        // GraphQL -> updateRoleAssignments: Boolean! (scalar)
        public static string UpdateRoleAssignments_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\nuserIds: $userIds\ngroupIds: $groupIds\nroleIds: $roleIds\n)";
            return "updateRoleAssignments" + args + "\n";
        }
        public static string UpdateRoleAssignments_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateRoleAssignments((System.Boolean)fieldSpecObj);
        }
        public static string UpdateRoleAssignments(System.Boolean fieldSpec)
        {
            return UpdateRoleAssignments_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateRoleAssignments(object fieldSpecObj)
        {
            return UpdateRoleAssignments_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateRoleAssignmentsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? UpdateSupportUserAccess
        // GraphQL -> updateSupportUserAccess: Void (scalar)
        public static string UpdateSupportUserAccess_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateSupportUserAccess" + args + "\n";
        }
        public static string UpdateSupportUserAccess_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateSupportUserAccess((System.String)fieldSpecObj);
        }
        public static string UpdateSupportUserAccess(System.String fieldSpec)
        {
            return UpdateSupportUserAccess_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateSupportUserAccess(object fieldSpecObj)
        {
            return UpdateSupportUserAccess_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateSupportUserAccessFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpdateWhitelistedAnalyzers
        // GraphQL -> updateWhitelistedAnalyzers: String! (scalar)
        public static string UpdateWhitelistedAnalyzers_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\nstdPath: $stdPath\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nanalyzerIds: $analyzerIds\nrunAsync: $runAsync\n)";
            return "updateWhitelistedAnalyzers" + args + "\n";
        }
        public static string UpdateWhitelistedAnalyzers_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateWhitelistedAnalyzers((System.String)fieldSpecObj);
        }
        public static string UpdateWhitelistedAnalyzers(System.String fieldSpec)
        {
            return UpdateWhitelistedAnalyzers_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateWhitelistedAnalyzers(object fieldSpecObj)
        {
            return UpdateWhitelistedAnalyzers_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateWhitelistedAnalyzersFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? UpgradeAwsCloudAccountFeaturesWithoutCft
        // GraphQL -> upgradeAwsCloudAccountFeaturesWithoutCft: Boolean! (scalar)
        public static string UpgradeAwsCloudAccountFeaturesWithoutCft_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "upgradeAwsCloudAccountFeaturesWithoutCft" + args + "\n";
        }
        public static string UpgradeAwsCloudAccountFeaturesWithoutCft_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpgradeAwsCloudAccountFeaturesWithoutCft((System.Boolean)fieldSpecObj);
        }
        public static string UpgradeAwsCloudAccountFeaturesWithoutCft(System.Boolean fieldSpec)
        {
            return UpgradeAwsCloudAccountFeaturesWithoutCft_TypedFieldSpec(fieldSpec);
        }
        public static string UpgradeAwsCloudAccountFeaturesWithoutCft(object fieldSpecObj)
        {
            return UpgradeAwsCloudAccountFeaturesWithoutCft_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpgradeAwsCloudAccountFeaturesWithoutCftFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? UpgradeAwsIamUserBasedCloudAccountPermissions
        // GraphQL -> upgradeAwsIamUserBasedCloudAccountPermissions: Boolean! (scalar)
        public static string UpgradeAwsIamUserBasedCloudAccountPermissions_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "upgradeAwsIamUserBasedCloudAccountPermissions" + args + "\n";
        }
        public static string UpgradeAwsIamUserBasedCloudAccountPermissions_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpgradeAwsIamUserBasedCloudAccountPermissions((System.Boolean)fieldSpecObj);
        }
        public static string UpgradeAwsIamUserBasedCloudAccountPermissions(System.Boolean fieldSpec)
        {
            return UpgradeAwsIamUserBasedCloudAccountPermissions_TypedFieldSpec(fieldSpec);
        }
        public static string UpgradeAwsIamUserBasedCloudAccountPermissions(object fieldSpecObj)
        {
            return UpgradeAwsIamUserBasedCloudAccountPermissions_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpgradeAwsIamUserBasedCloudAccountPermissionsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? UpgradeCdmManagedTarget
        // GraphQL -> upgradeCdmManagedTarget: Void (scalar)
        public static string UpgradeCdmManagedTarget_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "upgradeCdmManagedTarget" + args + "\n";
        }
        public static string UpgradeCdmManagedTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpgradeCdmManagedTarget((System.String)fieldSpecObj);
        }
        public static string UpgradeCdmManagedTarget(System.String fieldSpec)
        {
            return UpgradeCdmManagedTarget_TypedFieldSpec(fieldSpec);
        }
        public static string UpgradeCdmManagedTarget(object fieldSpecObj)
        {
            return UpgradeCdmManagedTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpgradeCdmManagedTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? UpgradeToRsc
        // GraphQL -> upgradeToRsc: Void (scalar)
        public static string UpgradeToRsc_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "";
            return "upgradeToRsc" + args + "\n";
        }
        public static string UpgradeToRsc_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpgradeToRsc((System.String)fieldSpecObj);
        }
        public static string UpgradeToRsc(System.String fieldSpec)
        {
            return UpgradeToRsc_TypedFieldSpec(fieldSpec);
        }
        public static string UpgradeToRsc(object fieldSpecObj)
        {
            return UpgradeToRsc_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpgradeToRscFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? VsphereVmDeleteSnapshot
        // GraphQL -> vsphereVmDeleteSnapshot: Void (scalar)
        public static string VsphereVmDeleteSnapshot_TypedFieldSpec(System.String fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmDeleteSnapshot" + args + "\n";
        }
        public static string VsphereVmDeleteSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereVmDeleteSnapshot((System.String)fieldSpecObj);
        }
        public static string VsphereVmDeleteSnapshot(System.String fieldSpec)
        {
            return VsphereVmDeleteSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereVmDeleteSnapshot(object fieldSpecObj)
        {
            return VsphereVmDeleteSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereVmDeleteSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? WarmSearchCache
        // GraphQL -> warmSearchCache: Boolean! (scalar)
        public static string WarmSearchCache_TypedFieldSpec(System.Boolean fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "warmSearchCache" + args + "\n";
        }
        public static string WarmSearchCache_ObjectFieldSpec(object fieldSpecObj)
        {
            return WarmSearchCache((System.Boolean)fieldSpecObj);
        }
        public static string WarmSearchCache(System.Boolean fieldSpec)
        {
            return WarmSearchCache_TypedFieldSpec(fieldSpec);
        }
        public static string WarmSearchCache(object fieldSpecObj)
        {
            return WarmSearchCache_ObjectFieldSpec(fieldSpecObj);
        }
        public static object WarmSearchCacheFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> RequestStatus? AddAdGroupsToHierarchy
        // GraphQL -> addAdGroupsToHierarchy: RequestStatus! (type)
        public static string AddAdGroupsToHierarchy_TypedFieldSpec(RequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "addAdGroupsToHierarchy" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AddAdGroupsToHierarchy_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddAdGroupsToHierarchy((RequestStatus)fieldSpecObj);
        }
        public static string AddAdGroupsToHierarchy(RequestStatus fieldSpec)
        {
            return AddAdGroupsToHierarchy_TypedFieldSpec(fieldSpec);
        }
        public static string AddAdGroupsToHierarchy(object fieldSpecObj)
        {
            return AddAdGroupsToHierarchy_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddAdGroupsToHierarchyFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddAndJoinSmbDomainReply? AddAndJoinSmbDomain
        // GraphQL -> addAndJoinSmbDomain: AddAndJoinSmbDomainReply! (type)
        public static string AddAndJoinSmbDomain_TypedFieldSpec(AddAndJoinSmbDomainReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "addAndJoinSmbDomain" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AddAndJoinSmbDomain_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddAndJoinSmbDomain((AddAndJoinSmbDomainReply)fieldSpecObj);
        }
        public static string AddAndJoinSmbDomain(AddAndJoinSmbDomainReply fieldSpec)
        {
            return AddAndJoinSmbDomain_TypedFieldSpec(fieldSpec);
        }
        public static string AddAndJoinSmbDomain(object fieldSpecObj)
        {
            return AddAndJoinSmbDomain_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddAndJoinSmbDomainFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AddAndJoinSmbDomainReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddAwsAuthenticationServerBasedCloudAccountReply? AddAwsAuthenticationServerBasedCloudAccount
        // GraphQL -> addAwsAuthenticationServerBasedCloudAccount: AddAwsAuthenticationServerBasedCloudAccountReply! (type)
        public static string AddAwsAuthenticationServerBasedCloudAccount_TypedFieldSpec(AddAwsAuthenticationServerBasedCloudAccountReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "addAwsAuthenticationServerBasedCloudAccount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AddAwsAuthenticationServerBasedCloudAccount_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddAwsAuthenticationServerBasedCloudAccount((AddAwsAuthenticationServerBasedCloudAccountReply)fieldSpecObj);
        }
        public static string AddAwsAuthenticationServerBasedCloudAccount(AddAwsAuthenticationServerBasedCloudAccountReply fieldSpec)
        {
            return AddAwsAuthenticationServerBasedCloudAccount_TypedFieldSpec(fieldSpec);
        }
        public static string AddAwsAuthenticationServerBasedCloudAccount(object fieldSpecObj)
        {
            return AddAwsAuthenticationServerBasedCloudAccount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddAwsAuthenticationServerBasedCloudAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AddAwsAuthenticationServerBasedCloudAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddAwsIamUserBasedCloudAccountReply? AddAwsIamUserBasedCloudAccount
        // GraphQL -> addAwsIamUserBasedCloudAccount: AddAwsIamUserBasedCloudAccountReply! (type)
        public static string AddAwsIamUserBasedCloudAccount_TypedFieldSpec(AddAwsIamUserBasedCloudAccountReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "addAwsIamUserBasedCloudAccount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AddAwsIamUserBasedCloudAccount_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddAwsIamUserBasedCloudAccount((AddAwsIamUserBasedCloudAccountReply)fieldSpecObj);
        }
        public static string AddAwsIamUserBasedCloudAccount(AddAwsIamUserBasedCloudAccountReply fieldSpec)
        {
            return AddAwsIamUserBasedCloudAccount_TypedFieldSpec(fieldSpec);
        }
        public static string AddAwsIamUserBasedCloudAccount(object fieldSpecObj)
        {
            return AddAwsIamUserBasedCloudAccount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddAwsIamUserBasedCloudAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AddAwsIamUserBasedCloudAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddAzureCloudAccountReply? AddAzureCloudAccount
        // GraphQL -> addAzureCloudAccount: AddAzureCloudAccountReply! (type)
        public static string AddAzureCloudAccount_TypedFieldSpec(AddAzureCloudAccountReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "addAzureCloudAccount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AddAzureCloudAccount_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddAzureCloudAccount((AddAzureCloudAccountReply)fieldSpecObj);
        }
        public static string AddAzureCloudAccount(AddAzureCloudAccountReply fieldSpec)
        {
            return AddAzureCloudAccount_TypedFieldSpec(fieldSpec);
        }
        public static string AddAzureCloudAccount(object fieldSpecObj)
        {
            return AddAzureCloudAccount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddAzureCloudAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AddAzureCloudAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddAzureCloudAccountExocomputeConfigurationsReply? AddAzureCloudAccountExocomputeConfigurations
        // GraphQL -> addAzureCloudAccountExocomputeConfigurations: AddAzureCloudAccountExocomputeConfigurationsReply! (type)
        public static string AddAzureCloudAccountExocomputeConfigurations_TypedFieldSpec(AddAzureCloudAccountExocomputeConfigurationsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "addAzureCloudAccountExocomputeConfigurations" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AddAzureCloudAccountExocomputeConfigurations_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddAzureCloudAccountExocomputeConfigurations((AddAzureCloudAccountExocomputeConfigurationsReply)fieldSpecObj);
        }
        public static string AddAzureCloudAccountExocomputeConfigurations(AddAzureCloudAccountExocomputeConfigurationsReply fieldSpec)
        {
            return AddAzureCloudAccountExocomputeConfigurations_TypedFieldSpec(fieldSpec);
        }
        public static string AddAzureCloudAccountExocomputeConfigurations(object fieldSpecObj)
        {
            return AddAzureCloudAccountExocomputeConfigurations_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddAzureCloudAccountExocomputeConfigurationsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AddAzureCloudAccountExocomputeConfigurationsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddAzureCloudAccountWithoutOauthReply? AddAzureCloudAccountWithoutOauth
        // GraphQL -> addAzureCloudAccountWithoutOauth: AddAzureCloudAccountWithoutOauthReply! (type)
        public static string AddAzureCloudAccountWithoutOauth_TypedFieldSpec(AddAzureCloudAccountWithoutOauthReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "addAzureCloudAccountWithoutOauth" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AddAzureCloudAccountWithoutOauth_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddAzureCloudAccountWithoutOauth((AddAzureCloudAccountWithoutOauthReply)fieldSpecObj);
        }
        public static string AddAzureCloudAccountWithoutOauth(AddAzureCloudAccountWithoutOauthReply fieldSpec)
        {
            return AddAzureCloudAccountWithoutOauth_TypedFieldSpec(fieldSpec);
        }
        public static string AddAzureCloudAccountWithoutOauth(object fieldSpecObj)
        {
            return AddAzureCloudAccountWithoutOauth_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddAzureCloudAccountWithoutOauthFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AddAzureCloudAccountWithoutOauthReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddCloudNativeSqlServerBackupCredentialsReply? AddCloudNativeSqlServerBackupCredentials
        // GraphQL -> addCloudNativeSqlServerBackupCredentials: AddCloudNativeSqlServerBackupCredentialsReply! (type)
        public static string AddCloudNativeSqlServerBackupCredentials_TypedFieldSpec(AddCloudNativeSqlServerBackupCredentialsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "addCloudNativeSqlServerBackupCredentials" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AddCloudNativeSqlServerBackupCredentials_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddCloudNativeSqlServerBackupCredentials((AddCloudNativeSqlServerBackupCredentialsReply)fieldSpecObj);
        }
        public static string AddCloudNativeSqlServerBackupCredentials(AddCloudNativeSqlServerBackupCredentialsReply fieldSpec)
        {
            return AddCloudNativeSqlServerBackupCredentials_TypedFieldSpec(fieldSpec);
        }
        public static string AddCloudNativeSqlServerBackupCredentials(object fieldSpecObj)
        {
            return AddCloudNativeSqlServerBackupCredentials_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddCloudNativeSqlServerBackupCredentialsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AddCloudNativeSqlServerBackupCredentialsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddClusterCertificateReply? AddClusterCertificate
        // GraphQL -> addClusterCertificate: AddClusterCertificateReply! (type)
        public static string AddClusterCertificate_TypedFieldSpec(AddClusterCertificateReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "addClusterCertificate" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AddClusterCertificate_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddClusterCertificate((AddClusterCertificateReply)fieldSpecObj);
        }
        public static string AddClusterCertificate(AddClusterCertificateReply fieldSpec)
        {
            return AddClusterCertificate_TypedFieldSpec(fieldSpec);
        }
        public static string AddClusterCertificate(object fieldSpecObj)
        {
            return AddClusterCertificate_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddClusterCertificateFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AddClusterCertificateReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddClusterNodesReply? AddClusterNodes
        // GraphQL -> addClusterNodes: AddClusterNodesReply! (type)
        public static string AddClusterNodes_TypedFieldSpec(AddClusterNodesReply fieldSpec)
        {
            string args = "\n(\nAddClusterNodesInput: $AddClusterNodesInput\n)";
            return "addClusterNodes" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AddClusterNodes_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddClusterNodes((AddClusterNodesReply)fieldSpecObj);
        }
        public static string AddClusterNodes(AddClusterNodesReply fieldSpec)
        {
            return AddClusterNodes_TypedFieldSpec(fieldSpec);
        }
        public static string AddClusterNodes(object fieldSpecObj)
        {
            return AddClusterNodes_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddClusterNodesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AddClusterNodesReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddConfiguredGroupToHierarchyReply? AddConfiguredGroupToHierarchy
        // GraphQL -> addConfiguredGroupToHierarchy: AddConfiguredGroupToHierarchyReply! (type)
        public static string AddConfiguredGroupToHierarchy_TypedFieldSpec(AddConfiguredGroupToHierarchyReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "addConfiguredGroupToHierarchy" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AddConfiguredGroupToHierarchy_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddConfiguredGroupToHierarchy((AddConfiguredGroupToHierarchyReply)fieldSpecObj);
        }
        public static string AddConfiguredGroupToHierarchy(AddConfiguredGroupToHierarchyReply fieldSpec)
        {
            return AddConfiguredGroupToHierarchy_TypedFieldSpec(fieldSpec);
        }
        public static string AddConfiguredGroupToHierarchy(object fieldSpecObj)
        {
            return AddConfiguredGroupToHierarchy_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddConfiguredGroupToHierarchyFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AddConfiguredGroupToHierarchyReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddCrossAccountServiceConsumerReply? AddCrossAccountServiceConsumer
        // GraphQL -> addCrossAccountServiceConsumer: AddCrossAccountServiceConsumerReply! (type)
        public static string AddCrossAccountServiceConsumer_TypedFieldSpec(AddCrossAccountServiceConsumerReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "addCrossAccountServiceConsumer" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AddCrossAccountServiceConsumer_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddCrossAccountServiceConsumer((AddCrossAccountServiceConsumerReply)fieldSpecObj);
        }
        public static string AddCrossAccountServiceConsumer(AddCrossAccountServiceConsumerReply fieldSpec)
        {
            return AddCrossAccountServiceConsumer_TypedFieldSpec(fieldSpec);
        }
        public static string AddCrossAccountServiceConsumer(object fieldSpecObj)
        {
            return AddCrossAccountServiceConsumer_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddCrossAccountServiceConsumerFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AddCrossAccountServiceConsumerReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddDb2InstanceReply? AddDb2Instance
        // GraphQL -> addDb2Instance: AddDb2InstanceReply! (type)
        public static string AddDb2Instance_TypedFieldSpec(AddDb2InstanceReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "addDb2Instance" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AddDb2Instance_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddDb2Instance((AddDb2InstanceReply)fieldSpecObj);
        }
        public static string AddDb2Instance(AddDb2InstanceReply fieldSpec)
        {
            return AddDb2Instance_TypedFieldSpec(fieldSpec);
        }
        public static string AddDb2Instance(object fieldSpecObj)
        {
            return AddDb2Instance_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddDb2InstanceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AddDb2InstanceReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddGlobalCertificateReply? AddGlobalCertificate
        // GraphQL -> addGlobalCertificate: AddGlobalCertificateReply! (type)
        public static string AddGlobalCertificate_TypedFieldSpec(AddGlobalCertificateReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "addGlobalCertificate" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AddGlobalCertificate_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddGlobalCertificate((AddGlobalCertificateReply)fieldSpecObj);
        }
        public static string AddGlobalCertificate(AddGlobalCertificateReply fieldSpec)
        {
            return AddGlobalCertificate_TypedFieldSpec(fieldSpec);
        }
        public static string AddGlobalCertificate(object fieldSpecObj)
        {
            return AddGlobalCertificate_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddGlobalCertificateFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AddGlobalCertificateReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> K8sClusterSummary? AddK8sCluster
        // GraphQL -> addK8sCluster: K8sClusterSummary! (type)
        public static string AddK8sCluster_TypedFieldSpec(K8sClusterSummary fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "addK8sCluster" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AddK8sCluster_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddK8sCluster((K8sClusterSummary)fieldSpecObj);
        }
        public static string AddK8sCluster(K8sClusterSummary fieldSpec)
        {
            return AddK8sCluster_TypedFieldSpec(fieldSpec);
        }
        public static string AddK8sCluster(object fieldSpecObj)
        {
            return AddK8sCluster_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddK8sClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new K8sClusterSummary() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> K8sProtectionSetSummary? AddK8sProtectionSet
        // GraphQL -> addK8sProtectionSet: K8sProtectionSetSummary! (type)
        public static string AddK8sProtectionSet_TypedFieldSpec(K8sProtectionSetSummary fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "addK8sProtectionSet" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AddK8sProtectionSet_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddK8sProtectionSet((K8sProtectionSetSummary)fieldSpecObj);
        }
        public static string AddK8sProtectionSet(K8sProtectionSetSummary fieldSpec)
        {
            return AddK8sProtectionSet_TypedFieldSpec(fieldSpec);
        }
        public static string AddK8sProtectionSet(object fieldSpecObj)
        {
            return AddK8sProtectionSet_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddK8sProtectionSetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new K8sProtectionSetSummary() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddManagedVolumeReply? AddManagedVolume
        // GraphQL -> addManagedVolume: AddManagedVolumeReply! (type)
        public static string AddManagedVolume_TypedFieldSpec(AddManagedVolumeReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "addManagedVolume" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AddManagedVolume_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddManagedVolume((AddManagedVolumeReply)fieldSpecObj);
        }
        public static string AddManagedVolume(AddManagedVolumeReply fieldSpec)
        {
            return AddManagedVolume_TypedFieldSpec(fieldSpec);
        }
        public static string AddManagedVolume(object fieldSpecObj)
        {
            return AddManagedVolume_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddManagedVolumeFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AddManagedVolumeReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddMongoSourceReply? AddMongoSource
        // GraphQL -> addMongoSource: AddMongoSourceReply! (type)
        public static string AddMongoSource_TypedFieldSpec(AddMongoSourceReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "addMongoSource" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AddMongoSource_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddMongoSource((AddMongoSourceReply)fieldSpecObj);
        }
        public static string AddMongoSource(AddMongoSourceReply fieldSpec)
        {
            return AddMongoSource_TypedFieldSpec(fieldSpec);
        }
        public static string AddMongoSource(object fieldSpecObj)
        {
            return AddMongoSource_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddMongoSourceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AddMongoSourceReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicAsyncResponse? AddMosaicStore
        // GraphQL -> addMosaicStore: MosaicAsyncResponse! (type)
        public static string AddMosaicStore_TypedFieldSpec(MosaicAsyncResponse fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "addMosaicStore" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AddMosaicStore_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddMosaicStore((MosaicAsyncResponse)fieldSpecObj);
        }
        public static string AddMosaicStore(MosaicAsyncResponse fieldSpec)
        {
            return AddMosaicStore_TypedFieldSpec(fieldSpec);
        }
        public static string AddMosaicStore(object fieldSpecObj)
        {
            return AddMosaicStore_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddMosaicStoreFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MosaicAsyncResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CcProvisionJobReply? AddNodesToCloudCluster
        // GraphQL -> addNodesToCloudCluster: CcProvisionJobReply! (type)
        public static string AddNodesToCloudCluster_TypedFieldSpec(CcProvisionJobReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "addNodesToCloudCluster" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AddNodesToCloudCluster_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddNodesToCloudCluster((CcProvisionJobReply)fieldSpecObj);
        }
        public static string AddNodesToCloudCluster(CcProvisionJobReply fieldSpec)
        {
            return AddNodesToCloudCluster_TypedFieldSpec(fieldSpec);
        }
        public static string AddNodesToCloudCluster(object fieldSpecObj)
        {
            return AddNodesToCloudCluster_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddNodesToCloudClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CcProvisionJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddO365OrgResponse? AddO365Org
        // GraphQL -> addO365Org: AddO365OrgResponse! (type)
        public static string AddO365Org_TypedFieldSpec(AddO365OrgResponse fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "addO365Org" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AddO365Org_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddO365Org((AddO365OrgResponse)fieldSpecObj);
        }
        public static string AddO365Org(AddO365OrgResponse fieldSpec)
        {
            return AddO365Org_TypedFieldSpec(fieldSpec);
        }
        public static string AddO365Org(object fieldSpecObj)
        {
            return AddO365Org_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddO365OrgFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AddO365OrgResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddSapHanaSystemReply? AddSapHanaSystem
        // GraphQL -> addSapHanaSystem: AddSapHanaSystemReply! (type)
        public static string AddSapHanaSystem_TypedFieldSpec(AddSapHanaSystemReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "addSapHanaSystem" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AddSapHanaSystem_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddSapHanaSystem((AddSapHanaSystemReply)fieldSpecObj);
        }
        public static string AddSapHanaSystem(AddSapHanaSystemReply fieldSpec)
        {
            return AddSapHanaSystem_TypedFieldSpec(fieldSpec);
        }
        public static string AddSapHanaSystem(object fieldSpecObj)
        {
            return AddSapHanaSystem_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddSapHanaSystemFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AddSapHanaSystemReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddStorageArraysReply? AddStorageArrays
        // GraphQL -> addStorageArrays: AddStorageArraysReply! (type)
        public static string AddStorageArrays_TypedFieldSpec(AddStorageArraysReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "addStorageArrays" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AddStorageArrays_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddStorageArrays((AddStorageArraysReply)fieldSpecObj);
        }
        public static string AddStorageArrays(AddStorageArraysReply fieldSpec)
        {
            return AddStorageArrays_TypedFieldSpec(fieldSpec);
        }
        public static string AddStorageArrays(object fieldSpecObj)
        {
            return AddStorageArrays_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddStorageArraysFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AddStorageArraysReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddSyslogExportRuleReply? AddSyslogExportRule
        // GraphQL -> addSyslogExportRule: AddSyslogExportRuleReply! (type)
        public static string AddSyslogExportRule_TypedFieldSpec(AddSyslogExportRuleReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "addSyslogExportRule" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AddSyslogExportRule_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddSyslogExportRule((AddSyslogExportRuleReply)fieldSpecObj);
        }
        public static string AddSyslogExportRule(AddSyslogExportRuleReply fieldSpec)
        {
            return AddSyslogExportRule_TypedFieldSpec(fieldSpec);
        }
        public static string AddSyslogExportRule(object fieldSpecObj)
        {
            return AddSyslogExportRule_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddSyslogExportRuleFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AddSyslogExportRuleReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? AddVlan
        // GraphQL -> addVlan: ResponseSuccess! (type)
        public static string AddVlan_TypedFieldSpec(ResponseSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "addVlan" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AddVlan_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddVlan((ResponseSuccess)fieldSpecObj);
        }
        public static string AddVlan(ResponseSuccess fieldSpec)
        {
            return AddVlan_TypedFieldSpec(fieldSpec);
        }
        public static string AddVlan(object fieldSpecObj)
        {
            return AddVlan_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddVlanFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddVmAppConsistentSpecsReply? AddVmAppConsistentSpecs
        // GraphQL -> addVmAppConsistentSpecs: AddVmAppConsistentSpecsReply! (type)
        public static string AddVmAppConsistentSpecs_TypedFieldSpec(AddVmAppConsistentSpecsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "addVmAppConsistentSpecs" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AddVmAppConsistentSpecs_ObjectFieldSpec(object fieldSpecObj)
        {
            return AddVmAppConsistentSpecs((AddVmAppConsistentSpecsReply)fieldSpecObj);
        }
        public static string AddVmAppConsistentSpecs(AddVmAppConsistentSpecsReply fieldSpec)
        {
            return AddVmAppConsistentSpecs_TypedFieldSpec(fieldSpec);
        }
        public static string AddVmAppConsistentSpecs(object fieldSpecObj)
        {
            return AddVmAppConsistentSpecs_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AddVmAppConsistentSpecsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AddVmAppConsistentSpecsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ApproveRcvPrivateEndpointReply? ApproveRcvPrivateEndpoint
        // GraphQL -> approveRcvPrivateEndpoint: ApproveRcvPrivateEndpointReply! (type)
        public static string ApproveRcvPrivateEndpoint_TypedFieldSpec(ApproveRcvPrivateEndpointReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "approveRcvPrivateEndpoint" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ApproveRcvPrivateEndpoint_ObjectFieldSpec(object fieldSpecObj)
        {
            return ApproveRcvPrivateEndpoint((ApproveRcvPrivateEndpointReply)fieldSpecObj);
        }
        public static string ApproveRcvPrivateEndpoint(ApproveRcvPrivateEndpointReply fieldSpec)
        {
            return ApproveRcvPrivateEndpoint_TypedFieldSpec(fieldSpec);
        }
        public static string ApproveRcvPrivateEndpoint(object fieldSpecObj)
        {
            return ApproveRcvPrivateEndpoint_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ApproveRcvPrivateEndpointFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ApproveRcvPrivateEndpointReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ArchiveK8sClusterReply? ArchiveK8sCluster
        // GraphQL -> archiveK8sCluster: ArchiveK8sClusterReply! (type)
        public static string ArchiveK8sCluster_TypedFieldSpec(ArchiveK8sClusterReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "archiveK8sCluster" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ArchiveK8sCluster_ObjectFieldSpec(object fieldSpecObj)
        {
            return ArchiveK8sCluster((ArchiveK8sClusterReply)fieldSpecObj);
        }
        public static string ArchiveK8sCluster(ArchiveK8sClusterReply fieldSpec)
        {
            return ArchiveK8sCluster_TypedFieldSpec(fieldSpec);
        }
        public static string ArchiveK8sCluster(object fieldSpecObj)
        {
            return ArchiveK8sCluster_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ArchiveK8sClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ArchiveK8sClusterReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? AssignMssqlSlaDomainProperties
        // GraphQL -> assignMssqlSlaDomainProperties: ResponseSuccess! (type)
        public static string AssignMssqlSlaDomainProperties_TypedFieldSpec(ResponseSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "assignMssqlSlaDomainProperties" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AssignMssqlSlaDomainProperties_ObjectFieldSpec(object fieldSpecObj)
        {
            return AssignMssqlSlaDomainProperties((ResponseSuccess)fieldSpecObj);
        }
        public static string AssignMssqlSlaDomainProperties(ResponseSuccess fieldSpec)
        {
            return AssignMssqlSlaDomainProperties_TypedFieldSpec(fieldSpec);
        }
        public static string AssignMssqlSlaDomainProperties(object fieldSpecObj)
        {
            return AssignMssqlSlaDomainProperties_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AssignMssqlSlaDomainPropertiesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AssignMssqlSlaDomainPropertiesAsyncReply? AssignMssqlSlaDomainPropertiesAsync
        // GraphQL -> assignMssqlSlaDomainPropertiesAsync: AssignMssqlSlaDomainPropertiesAsyncReply! (type)
        public static string AssignMssqlSlaDomainPropertiesAsync_TypedFieldSpec(AssignMssqlSlaDomainPropertiesAsyncReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "assignMssqlSlaDomainPropertiesAsync" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AssignMssqlSlaDomainPropertiesAsync_ObjectFieldSpec(object fieldSpecObj)
        {
            return AssignMssqlSlaDomainPropertiesAsync((AssignMssqlSlaDomainPropertiesAsyncReply)fieldSpecObj);
        }
        public static string AssignMssqlSlaDomainPropertiesAsync(AssignMssqlSlaDomainPropertiesAsyncReply fieldSpec)
        {
            return AssignMssqlSlaDomainPropertiesAsync_TypedFieldSpec(fieldSpec);
        }
        public static string AssignMssqlSlaDomainPropertiesAsync(object fieldSpecObj)
        {
            return AssignMssqlSlaDomainPropertiesAsync_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AssignMssqlSlaDomainPropertiesAsyncFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AssignMssqlSlaDomainPropertiesAsyncReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SlaAssignResult? AssignProtection
        // GraphQL -> assignProtection: SlaAssignResult! (type)
        public static string AssignProtection_TypedFieldSpec(SlaAssignResult fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "assignProtection" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AssignProtection_ObjectFieldSpec(object fieldSpecObj)
        {
            return AssignProtection((SlaAssignResult)fieldSpecObj);
        }
        public static string AssignProtection(SlaAssignResult fieldSpec)
        {
            return AssignProtection_TypedFieldSpec(fieldSpec);
        }
        public static string AssignProtection(object fieldSpecObj)
        {
            return AssignProtection_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AssignProtectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SlaAssignResult() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SlaAssignResult? AssignRetentionSlaToSnappables
        // GraphQL -> assignRetentionSLAToSnappables: SlaAssignResult! (type)
        public static string AssignRetentionSlaToSnappables_TypedFieldSpec(SlaAssignResult fieldSpec)
        {
            string args = "\n(\nglobalSlaOptionalFid: $globalSlaOptionalFid\nglobalSlaAssignType: $globalSlaAssignType\nobjectIds: $objectIds\napplicableSnappableType: $applicableSnappableType\nshouldApplyToNonPolicySnapshots: $shouldApplyToNonPolicySnapshots\nuserNote: $userNote\n)";
            return "assignRetentionSLAToSnappables" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AssignRetentionSlaToSnappables_ObjectFieldSpec(object fieldSpecObj)
        {
            return AssignRetentionSlaToSnappables((SlaAssignResult)fieldSpecObj);
        }
        public static string AssignRetentionSlaToSnappables(SlaAssignResult fieldSpec)
        {
            return AssignRetentionSlaToSnappables_TypedFieldSpec(fieldSpec);
        }
        public static string AssignRetentionSlaToSnappables(object fieldSpecObj)
        {
            return AssignRetentionSlaToSnappables_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AssignRetentionSlaToSnappablesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SlaAssignResult() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SlaAssignResult? AssignRetentionSlaToSnapshots
        // GraphQL -> assignRetentionSLAToSnapshots: SlaAssignResult! (type)
        public static string AssignRetentionSlaToSnapshots_TypedFieldSpec(SlaAssignResult fieldSpec)
        {
            string args = "\n(\nglobalSlaOptionalFid: $globalSlaOptionalFid\nglobalSlaAssignType: $globalSlaAssignType\nsnapshotFids: $snapshotFids\nuserNote: $userNote\n)";
            return "assignRetentionSLAToSnapshots" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AssignRetentionSlaToSnapshots_ObjectFieldSpec(object fieldSpecObj)
        {
            return AssignRetentionSlaToSnapshots((SlaAssignResult)fieldSpecObj);
        }
        public static string AssignRetentionSlaToSnapshots(SlaAssignResult fieldSpec)
        {
            return AssignRetentionSlaToSnapshots_TypedFieldSpec(fieldSpec);
        }
        public static string AssignRetentionSlaToSnapshots(object fieldSpecObj)
        {
            return AssignRetentionSlaToSnapshots_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AssignRetentionSlaToSnapshotsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SlaAssignResult() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SlaAssignResult? AssignSla
        // GraphQL -> assignSla: SlaAssignResult! (type)
        public static string AssignSla_TypedFieldSpec(SlaAssignResult fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "assignSla" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AssignSla_ObjectFieldSpec(object fieldSpecObj)
        {
            return AssignSla((SlaAssignResult)fieldSpecObj);
        }
        public static string AssignSla(SlaAssignResult fieldSpec)
        {
            return AssignSla_TypedFieldSpec(fieldSpec);
        }
        public static string AssignSla(object fieldSpecObj)
        {
            return AssignSla_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AssignSlaFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SlaAssignResult() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? AssignSlaToMongoDbCollection
        // GraphQL -> assignSlaToMongoDbCollection: AsyncRequestStatus! (type)
        public static string AssignSlaToMongoDbCollection_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "assignSlaToMongoDbCollection" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AssignSlaToMongoDbCollection_ObjectFieldSpec(object fieldSpecObj)
        {
            return AssignSlaToMongoDbCollection((AsyncRequestStatus)fieldSpecObj);
        }
        public static string AssignSlaToMongoDbCollection(AsyncRequestStatus fieldSpec)
        {
            return AssignSlaToMongoDbCollection_TypedFieldSpec(fieldSpec);
        }
        public static string AssignSlaToMongoDbCollection(object fieldSpecObj)
        {
            return AssignSlaToMongoDbCollection_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AssignSlaToMongoDbCollectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<SlaAssignResult>? AssignSlasForSnappableHierarchies
        // GraphQL -> assignSlasForSnappableHierarchies: [SlaAssignResult!]! (type)
        public static string AssignSlasForSnappableHierarchies_TypedFieldSpec(List<SlaAssignResult> fieldSpec)
        {
            string args = "\n(\nglobalSlaOptionalFid: $globalSlaOptionalFid\nglobalSlaAssignType: $globalSlaAssignType\nobjectIds: $objectIds\napplicableSnappableTypes: $applicableSnappableTypes\nshouldApplyToExistingSnapshots: $shouldApplyToExistingSnapshots\nshouldApplyToNonPolicySnapshots: $shouldApplyToNonPolicySnapshots\nglobalExistingSnapshotRetention: $globalExistingSnapshotRetention\nuserNote: $userNote\n)";
            return "assignSlasForSnappableHierarchies" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AssignSlasForSnappableHierarchies_ObjectFieldSpec(object fieldSpecObj)
        {
            return AssignSlasForSnappableHierarchies((List<SlaAssignResult>)fieldSpecObj);
        }
        public static string AssignSlasForSnappableHierarchies(List<SlaAssignResult> fieldSpec)
        {
            return AssignSlasForSnappableHierarchies_TypedFieldSpec(fieldSpec);
        }
        public static string AssignSlasForSnappableHierarchies(object fieldSpecObj)
        {
            return AssignSlasForSnappableHierarchies_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AssignSlasForSnappableHierarchiesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<SlaAssignResult>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsExocomputeClusterConnectReply? AwsExocomputeClusterConnect
        // GraphQL -> awsExocomputeClusterConnect: AwsExocomputeClusterConnectReply! (type)
        public static string AwsExocomputeClusterConnect_TypedFieldSpec(AwsExocomputeClusterConnectReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "awsExocomputeClusterConnect" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AwsExocomputeClusterConnect_ObjectFieldSpec(object fieldSpecObj)
        {
            return AwsExocomputeClusterConnect((AwsExocomputeClusterConnectReply)fieldSpecObj);
        }
        public static string AwsExocomputeClusterConnect(AwsExocomputeClusterConnectReply fieldSpec)
        {
            return AwsExocomputeClusterConnect_TypedFieldSpec(fieldSpec);
        }
        public static string AwsExocomputeClusterConnect(object fieldSpecObj)
        {
            return AwsExocomputeClusterConnect_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AwsExocomputeClusterConnectFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AwsExocomputeClusterConnectReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestStatus? AzureOauthConsentComplete
        // GraphQL -> azureOauthConsentComplete: RequestStatus! (type)
        public static string AzureOauthConsentComplete_TypedFieldSpec(RequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "azureOauthConsentComplete" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AzureOauthConsentComplete_ObjectFieldSpec(object fieldSpecObj)
        {
            return AzureOauthConsentComplete((RequestStatus)fieldSpecObj);
        }
        public static string AzureOauthConsentComplete(RequestStatus fieldSpec)
        {
            return AzureOauthConsentComplete_TypedFieldSpec(fieldSpec);
        }
        public static string AzureOauthConsentComplete(object fieldSpecObj)
        {
            return AzureOauthConsentComplete_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AzureOauthConsentCompleteFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureOauthConsentKickoffReply? AzureOauthConsentKickoff
        // GraphQL -> azureOauthConsentKickoff: AzureOauthConsentKickoffReply! (type)
        public static string AzureOauthConsentKickoff_TypedFieldSpec(AzureOauthConsentKickoffReply fieldSpec)
        {
            string args = "";
            return "azureOauthConsentKickoff" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string AzureOauthConsentKickoff_ObjectFieldSpec(object fieldSpecObj)
        {
            return AzureOauthConsentKickoff((AzureOauthConsentKickoffReply)fieldSpecObj);
        }
        public static string AzureOauthConsentKickoff(AzureOauthConsentKickoffReply fieldSpec)
        {
            return AzureOauthConsentKickoff_TypedFieldSpec(fieldSpec);
        }
        public static string AzureOauthConsentKickoff(object fieldSpecObj)
        {
            return AzureOauthConsentKickoff_ObjectFieldSpec(fieldSpecObj);
        }
        public static object AzureOauthConsentKickoffFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureOauthConsentKickoffReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<CreateOnDemandJobReply>? BackupAzureAdDirectory
        // GraphQL -> backupAzureAdDirectory: [CreateOnDemandJobReply!]! (type)
        public static string BackupAzureAdDirectory_TypedFieldSpec(List<CreateOnDemandJobReply> fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "backupAzureAdDirectory" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BackupAzureAdDirectory_ObjectFieldSpec(object fieldSpecObj)
        {
            return BackupAzureAdDirectory((List<CreateOnDemandJobReply>)fieldSpecObj);
        }
        public static string BackupAzureAdDirectory(List<CreateOnDemandJobReply> fieldSpec)
        {
            return BackupAzureAdDirectory_TypedFieldSpec(fieldSpec);
        }
        public static string BackupAzureAdDirectory(object fieldSpecObj)
        {
            return BackupAzureAdDirectory_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BackupAzureAdDirectoryFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<CreateOnDemandJobReply>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<CreateOnDemandJobReply>? BackupM365Mailbox
        // GraphQL -> backupM365Mailbox: [CreateOnDemandJobReply!]! (type)
        public static string BackupM365Mailbox_TypedFieldSpec(List<CreateOnDemandJobReply> fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "backupM365Mailbox" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BackupM365Mailbox_ObjectFieldSpec(object fieldSpecObj)
        {
            return BackupM365Mailbox((List<CreateOnDemandJobReply>)fieldSpecObj);
        }
        public static string BackupM365Mailbox(List<CreateOnDemandJobReply> fieldSpec)
        {
            return BackupM365Mailbox_TypedFieldSpec(fieldSpec);
        }
        public static string BackupM365Mailbox(object fieldSpecObj)
        {
            return BackupM365Mailbox_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BackupM365MailboxFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<CreateOnDemandJobReply>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<CreateOnDemandJobReply>? BackupM365Onedrive
        // GraphQL -> backupM365Onedrive: [CreateOnDemandJobReply!]! (type)
        public static string BackupM365Onedrive_TypedFieldSpec(List<CreateOnDemandJobReply> fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "backupM365Onedrive" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BackupM365Onedrive_ObjectFieldSpec(object fieldSpecObj)
        {
            return BackupM365Onedrive((List<CreateOnDemandJobReply>)fieldSpecObj);
        }
        public static string BackupM365Onedrive(List<CreateOnDemandJobReply> fieldSpec)
        {
            return BackupM365Onedrive_TypedFieldSpec(fieldSpec);
        }
        public static string BackupM365Onedrive(object fieldSpecObj)
        {
            return BackupM365Onedrive_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BackupM365OnedriveFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<CreateOnDemandJobReply>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<CreateOnDemandJobReply>? BackupM365SharepointDrive
        // GraphQL -> backupM365SharepointDrive: [CreateOnDemandJobReply!]! (type)
        public static string BackupM365SharepointDrive_TypedFieldSpec(List<CreateOnDemandJobReply> fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "backupM365SharepointDrive" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BackupM365SharepointDrive_ObjectFieldSpec(object fieldSpecObj)
        {
            return BackupM365SharepointDrive((List<CreateOnDemandJobReply>)fieldSpecObj);
        }
        public static string BackupM365SharepointDrive(List<CreateOnDemandJobReply> fieldSpec)
        {
            return BackupM365SharepointDrive_TypedFieldSpec(fieldSpec);
        }
        public static string BackupM365SharepointDrive(object fieldSpecObj)
        {
            return BackupM365SharepointDrive_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BackupM365SharepointDriveFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<CreateOnDemandJobReply>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<CreateOnDemandJobReply>? BackupM365Team
        // GraphQL -> backupM365Team: [CreateOnDemandJobReply!]! (type)
        public static string BackupM365Team_TypedFieldSpec(List<CreateOnDemandJobReply> fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "backupM365Team" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BackupM365Team_ObjectFieldSpec(object fieldSpecObj)
        {
            return BackupM365Team((List<CreateOnDemandJobReply>)fieldSpecObj);
        }
        public static string BackupM365Team(List<CreateOnDemandJobReply> fieldSpec)
        {
            return BackupM365Team_TypedFieldSpec(fieldSpec);
        }
        public static string BackupM365Team(object fieldSpecObj)
        {
            return BackupM365Team_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BackupM365TeamFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<CreateOnDemandJobReply>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? BackupO365Mailbox
        // GraphQL -> backupO365Mailbox: BatchAsyncJobStatus! (type)
        public static string BackupO365Mailbox_TypedFieldSpec(BatchAsyncJobStatus fieldSpec)
        {
            string args = "\n(\nmailboxIds: $mailboxIds\n)";
            return "backupO365Mailbox" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BackupO365Mailbox_ObjectFieldSpec(object fieldSpecObj)
        {
            return BackupO365Mailbox((BatchAsyncJobStatus)fieldSpecObj);
        }
        public static string BackupO365Mailbox(BatchAsyncJobStatus fieldSpec)
        {
            return BackupO365Mailbox_TypedFieldSpec(fieldSpec);
        }
        public static string BackupO365Mailbox(object fieldSpecObj)
        {
            return BackupO365Mailbox_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BackupO365MailboxFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? BackupO365Onedrive
        // GraphQL -> backupO365Onedrive: BatchAsyncJobStatus! (type)
        public static string BackupO365Onedrive_TypedFieldSpec(BatchAsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "backupO365Onedrive" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BackupO365Onedrive_ObjectFieldSpec(object fieldSpecObj)
        {
            return BackupO365Onedrive((BatchAsyncJobStatus)fieldSpecObj);
        }
        public static string BackupO365Onedrive(BatchAsyncJobStatus fieldSpec)
        {
            return BackupO365Onedrive_TypedFieldSpec(fieldSpec);
        }
        public static string BackupO365Onedrive(object fieldSpecObj)
        {
            return BackupO365Onedrive_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BackupO365OnedriveFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? BackupO365SharePointSite
        // GraphQL -> backupO365SharePointSite: CreateOnDemandJobReply! (type)
        public static string BackupO365SharePointSite_TypedFieldSpec(CreateOnDemandJobReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "backupO365SharePointSite" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BackupO365SharePointSite_ObjectFieldSpec(object fieldSpecObj)
        {
            return BackupO365SharePointSite((CreateOnDemandJobReply)fieldSpecObj);
        }
        public static string BackupO365SharePointSite(CreateOnDemandJobReply fieldSpec)
        {
            return BackupO365SharePointSite_TypedFieldSpec(fieldSpec);
        }
        public static string BackupO365SharePointSite(object fieldSpecObj)
        {
            return BackupO365SharePointSite_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BackupO365SharePointSiteFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? BackupO365SharepointDrive
        // GraphQL -> backupO365SharepointDrive: BatchAsyncJobStatus! (type)
        public static string BackupO365SharepointDrive_TypedFieldSpec(BatchAsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "backupO365SharepointDrive" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BackupO365SharepointDrive_ObjectFieldSpec(object fieldSpecObj)
        {
            return BackupO365SharepointDrive((BatchAsyncJobStatus)fieldSpecObj);
        }
        public static string BackupO365SharepointDrive(BatchAsyncJobStatus fieldSpec)
        {
            return BackupO365SharepointDrive_TypedFieldSpec(fieldSpec);
        }
        public static string BackupO365SharepointDrive(object fieldSpecObj)
        {
            return BackupO365SharepointDrive_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BackupO365SharepointDriveFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? BackupO365SharepointList
        // GraphQL -> backupO365SharepointList: CreateOnDemandJobReply! (type)
        public static string BackupO365SharepointList_TypedFieldSpec(CreateOnDemandJobReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "backupO365SharepointList" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BackupO365SharepointList_ObjectFieldSpec(object fieldSpecObj)
        {
            return BackupO365SharepointList((CreateOnDemandJobReply)fieldSpecObj);
        }
        public static string BackupO365SharepointList(CreateOnDemandJobReply fieldSpec)
        {
            return BackupO365SharepointList_TypedFieldSpec(fieldSpec);
        }
        public static string BackupO365SharepointList(object fieldSpecObj)
        {
            return BackupO365SharepointList_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BackupO365SharepointListFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? BackupO365Team
        // GraphQL -> backupO365Team: BatchAsyncJobStatus! (type)
        public static string BackupO365Team_TypedFieldSpec(BatchAsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "backupO365Team" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BackupO365Team_ObjectFieldSpec(object fieldSpecObj)
        {
            return BackupO365Team((BatchAsyncJobStatus)fieldSpecObj);
        }
        public static string BackupO365Team(BatchAsyncJobStatus fieldSpec)
        {
            return BackupO365Team_TypedFieldSpec(fieldSpec);
        }
        public static string BackupO365Team(object fieldSpecObj)
        {
            return BackupO365Team_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BackupO365TeamFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchExportHypervVmReply? BatchExportHypervVm
        // GraphQL -> batchExportHypervVm: BatchExportHypervVmReply! (type)
        public static string BatchExportHypervVm_TypedFieldSpec(BatchExportHypervVmReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "batchExportHypervVm" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BatchExportHypervVm_ObjectFieldSpec(object fieldSpecObj)
        {
            return BatchExportHypervVm((BatchExportHypervVmReply)fieldSpecObj);
        }
        public static string BatchExportHypervVm(BatchExportHypervVmReply fieldSpec)
        {
            return BatchExportHypervVm_TypedFieldSpec(fieldSpec);
        }
        public static string BatchExportHypervVm(object fieldSpecObj)
        {
            return BatchExportHypervVm_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BatchExportHypervVmFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchExportHypervVmReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchExportNutanixVmReply? BatchExportNutanixVm
        // GraphQL -> batchExportNutanixVm: BatchExportNutanixVmReply! (type)
        public static string BatchExportNutanixVm_TypedFieldSpec(BatchExportNutanixVmReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "batchExportNutanixVm" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BatchExportNutanixVm_ObjectFieldSpec(object fieldSpecObj)
        {
            return BatchExportNutanixVm((BatchExportNutanixVmReply)fieldSpecObj);
        }
        public static string BatchExportNutanixVm(BatchExportNutanixVmReply fieldSpec)
        {
            return BatchExportNutanixVm_TypedFieldSpec(fieldSpec);
        }
        public static string BatchExportNutanixVm(object fieldSpecObj)
        {
            return BatchExportNutanixVm_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BatchExportNutanixVmFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchExportNutanixVmReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchInstantRecoverHypervVmReply? BatchInstantRecoverHypervVm
        // GraphQL -> batchInstantRecoverHypervVm: BatchInstantRecoverHypervVmReply! (type)
        public static string BatchInstantRecoverHypervVm_TypedFieldSpec(BatchInstantRecoverHypervVmReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "batchInstantRecoverHypervVm" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BatchInstantRecoverHypervVm_ObjectFieldSpec(object fieldSpecObj)
        {
            return BatchInstantRecoverHypervVm((BatchInstantRecoverHypervVmReply)fieldSpecObj);
        }
        public static string BatchInstantRecoverHypervVm(BatchInstantRecoverHypervVmReply fieldSpec)
        {
            return BatchInstantRecoverHypervVm_TypedFieldSpec(fieldSpec);
        }
        public static string BatchInstantRecoverHypervVm(object fieldSpecObj)
        {
            return BatchInstantRecoverHypervVm_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BatchInstantRecoverHypervVmFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchInstantRecoverHypervVmReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchMountHypervVmReply? BatchMountHypervVm
        // GraphQL -> batchMountHypervVm: BatchMountHypervVmReply! (type)
        public static string BatchMountHypervVm_TypedFieldSpec(BatchMountHypervVmReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "batchMountHypervVm" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BatchMountHypervVm_ObjectFieldSpec(object fieldSpecObj)
        {
            return BatchMountHypervVm((BatchMountHypervVmReply)fieldSpecObj);
        }
        public static string BatchMountHypervVm(BatchMountHypervVmReply fieldSpec)
        {
            return BatchMountHypervVm_TypedFieldSpec(fieldSpec);
        }
        public static string BatchMountHypervVm(object fieldSpecObj)
        {
            return BatchMountHypervVm_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BatchMountHypervVmFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchMountHypervVmReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchMountNutanixVmReply? BatchMountNutanixVm
        // GraphQL -> batchMountNutanixVm: BatchMountNutanixVmReply! (type)
        public static string BatchMountNutanixVm_TypedFieldSpec(BatchMountNutanixVmReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "batchMountNutanixVm" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BatchMountNutanixVm_ObjectFieldSpec(object fieldSpecObj)
        {
            return BatchMountNutanixVm((BatchMountNutanixVmReply)fieldSpecObj);
        }
        public static string BatchMountNutanixVm(BatchMountNutanixVmReply fieldSpec)
        {
            return BatchMountNutanixVm_TypedFieldSpec(fieldSpec);
        }
        public static string BatchMountNutanixVm(object fieldSpecObj)
        {
            return BatchMountNutanixVm_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BatchMountNutanixVmFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchMountNutanixVmReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchOnDemandBackupHypervVmReply? BatchOnDemandBackupHypervVm
        // GraphQL -> batchOnDemandBackupHypervVm: BatchOnDemandBackupHypervVmReply! (type)
        public static string BatchOnDemandBackupHypervVm_TypedFieldSpec(BatchOnDemandBackupHypervVmReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "batchOnDemandBackupHypervVm" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BatchOnDemandBackupHypervVm_ObjectFieldSpec(object fieldSpecObj)
        {
            return BatchOnDemandBackupHypervVm((BatchOnDemandBackupHypervVmReply)fieldSpecObj);
        }
        public static string BatchOnDemandBackupHypervVm(BatchOnDemandBackupHypervVmReply fieldSpec)
        {
            return BatchOnDemandBackupHypervVm_TypedFieldSpec(fieldSpec);
        }
        public static string BatchOnDemandBackupHypervVm(object fieldSpecObj)
        {
            return BatchOnDemandBackupHypervVm_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BatchOnDemandBackupHypervVmFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchOnDemandBackupHypervVmReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchQuarantineSnapshotReply? BatchQuarantineSnapshot
        // GraphQL -> batchQuarantineSnapshot: BatchQuarantineSnapshotReply! (type)
        public static string BatchQuarantineSnapshot_TypedFieldSpec(BatchQuarantineSnapshotReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "batchQuarantineSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BatchQuarantineSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return BatchQuarantineSnapshot((BatchQuarantineSnapshotReply)fieldSpecObj);
        }
        public static string BatchQuarantineSnapshot(BatchQuarantineSnapshotReply fieldSpec)
        {
            return BatchQuarantineSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string BatchQuarantineSnapshot(object fieldSpecObj)
        {
            return BatchQuarantineSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BatchQuarantineSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchQuarantineSnapshotReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchReleaseFromQuarantineSnapshotReply? BatchReleaseFromQuarantineSnapshot
        // GraphQL -> batchReleaseFromQuarantineSnapshot: BatchReleaseFromQuarantineSnapshotReply! (type)
        public static string BatchReleaseFromQuarantineSnapshot_TypedFieldSpec(BatchReleaseFromQuarantineSnapshotReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "batchReleaseFromQuarantineSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BatchReleaseFromQuarantineSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return BatchReleaseFromQuarantineSnapshot((BatchReleaseFromQuarantineSnapshotReply)fieldSpecObj);
        }
        public static string BatchReleaseFromQuarantineSnapshot(BatchReleaseFromQuarantineSnapshotReply fieldSpec)
        {
            return BatchReleaseFromQuarantineSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string BatchReleaseFromQuarantineSnapshot(object fieldSpecObj)
        {
            return BatchReleaseFromQuarantineSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BatchReleaseFromQuarantineSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchReleaseFromQuarantineSnapshotReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BeginManagedVolumeSnapshotReply? BeginManagedVolumeSnapshot
        // GraphQL -> beginManagedVolumeSnapshot: BeginManagedVolumeSnapshotReply! (type)
        public static string BeginManagedVolumeSnapshot_TypedFieldSpec(BeginManagedVolumeSnapshotReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "beginManagedVolumeSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BeginManagedVolumeSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return BeginManagedVolumeSnapshot((BeginManagedVolumeSnapshotReply)fieldSpecObj);
        }
        public static string BeginManagedVolumeSnapshot(BeginManagedVolumeSnapshotReply fieldSpec)
        {
            return BeginManagedVolumeSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string BeginManagedVolumeSnapshot(object fieldSpecObj)
        {
            return BeginManagedVolumeSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BeginManagedVolumeSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BeginManagedVolumeSnapshotReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BrowseMssqlDatabaseSnapshotReply? BrowseMssqlDatabaseSnapshot
        // GraphQL -> browseMssqlDatabaseSnapshot: BrowseMssqlDatabaseSnapshotReply! (type)
        public static string BrowseMssqlDatabaseSnapshot_TypedFieldSpec(BrowseMssqlDatabaseSnapshotReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "browseMssqlDatabaseSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BrowseMssqlDatabaseSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return BrowseMssqlDatabaseSnapshot((BrowseMssqlDatabaseSnapshotReply)fieldSpecObj);
        }
        public static string BrowseMssqlDatabaseSnapshot(BrowseMssqlDatabaseSnapshotReply fieldSpec)
        {
            return BrowseMssqlDatabaseSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string BrowseMssqlDatabaseSnapshot(object fieldSpecObj)
        {
            return BrowseMssqlDatabaseSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BrowseMssqlDatabaseSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BrowseMssqlDatabaseSnapshotReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkCreateFilesetTemplatesReply? BulkCreateFilesetTemplates
        // GraphQL -> bulkCreateFilesetTemplates: BulkCreateFilesetTemplatesReply! (type)
        public static string BulkCreateFilesetTemplates_TypedFieldSpec(BulkCreateFilesetTemplatesReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkCreateFilesetTemplates" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkCreateFilesetTemplates_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkCreateFilesetTemplates((BulkCreateFilesetTemplatesReply)fieldSpecObj);
        }
        public static string BulkCreateFilesetTemplates(BulkCreateFilesetTemplatesReply fieldSpec)
        {
            return BulkCreateFilesetTemplates_TypedFieldSpec(fieldSpec);
        }
        public static string BulkCreateFilesetTemplates(object fieldSpecObj)
        {
            return BulkCreateFilesetTemplates_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkCreateFilesetTemplatesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BulkCreateFilesetTemplatesReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkCreateFilesetsReply? BulkCreateFilesets
        // GraphQL -> bulkCreateFilesets: BulkCreateFilesetsReply! (type)
        public static string BulkCreateFilesets_TypedFieldSpec(BulkCreateFilesetsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkCreateFilesets" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkCreateFilesets_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkCreateFilesets((BulkCreateFilesetsReply)fieldSpecObj);
        }
        public static string BulkCreateFilesets(BulkCreateFilesetsReply fieldSpec)
        {
            return BulkCreateFilesets_TypedFieldSpec(fieldSpec);
        }
        public static string BulkCreateFilesets(object fieldSpecObj)
        {
            return BulkCreateFilesets_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkCreateFilesetsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BulkCreateFilesetsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkCreateNasFilesetsReply? BulkCreateNasFilesets
        // GraphQL -> bulkCreateNasFilesets: BulkCreateNasFilesetsReply! (type)
        public static string BulkCreateNasFilesets_TypedFieldSpec(BulkCreateNasFilesetsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkCreateNasFilesets" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkCreateNasFilesets_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkCreateNasFilesets((BulkCreateNasFilesetsReply)fieldSpecObj);
        }
        public static string BulkCreateNasFilesets(BulkCreateNasFilesetsReply fieldSpec)
        {
            return BulkCreateNasFilesets_TypedFieldSpec(fieldSpec);
        }
        public static string BulkCreateNasFilesets(object fieldSpecObj)
        {
            return BulkCreateNasFilesets_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkCreateNasFilesetsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BulkCreateNasFilesetsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? BulkCreateOnDemandMssqlBackup
        // GraphQL -> bulkCreateOnDemandMssqlBackup: AsyncRequestStatus! (type)
        public static string BulkCreateOnDemandMssqlBackup_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkCreateOnDemandMssqlBackup" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkCreateOnDemandMssqlBackup_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkCreateOnDemandMssqlBackup((AsyncRequestStatus)fieldSpecObj);
        }
        public static string BulkCreateOnDemandMssqlBackup(AsyncRequestStatus fieldSpec)
        {
            return BulkCreateOnDemandMssqlBackup_TypedFieldSpec(fieldSpec);
        }
        public static string BulkCreateOnDemandMssqlBackup(object fieldSpecObj)
        {
            return BulkCreateOnDemandMssqlBackup_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkCreateOnDemandMssqlBackupFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkDeleteAwsCloudAccountWithoutCftReply? BulkDeleteAwsCloudAccountWithoutCft
        // GraphQL -> bulkDeleteAwsCloudAccountWithoutCft: BulkDeleteAwsCloudAccountWithoutCftReply! (type)
        public static string BulkDeleteAwsCloudAccountWithoutCft_TypedFieldSpec(BulkDeleteAwsCloudAccountWithoutCftReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkDeleteAwsCloudAccountWithoutCft" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkDeleteAwsCloudAccountWithoutCft_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkDeleteAwsCloudAccountWithoutCft((BulkDeleteAwsCloudAccountWithoutCftReply)fieldSpecObj);
        }
        public static string BulkDeleteAwsCloudAccountWithoutCft(BulkDeleteAwsCloudAccountWithoutCftReply fieldSpec)
        {
            return BulkDeleteAwsCloudAccountWithoutCft_TypedFieldSpec(fieldSpec);
        }
        public static string BulkDeleteAwsCloudAccountWithoutCft(object fieldSpecObj)
        {
            return BulkDeleteAwsCloudAccountWithoutCft_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkDeleteAwsCloudAccountWithoutCftFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BulkDeleteAwsCloudAccountWithoutCftReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicAsyncResponse? BulkDeleteCassandraSources
        // GraphQL -> bulkDeleteCassandraSources: MosaicAsyncResponse! (type)
        public static string BulkDeleteCassandraSources_TypedFieldSpec(MosaicAsyncResponse fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkDeleteCassandraSources" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkDeleteCassandraSources_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkDeleteCassandraSources((MosaicAsyncResponse)fieldSpecObj);
        }
        public static string BulkDeleteCassandraSources(MosaicAsyncResponse fieldSpec)
        {
            return BulkDeleteCassandraSources_TypedFieldSpec(fieldSpec);
        }
        public static string BulkDeleteCassandraSources(object fieldSpecObj)
        {
            return BulkDeleteCassandraSources_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkDeleteCassandraSourcesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MosaicAsyncResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? BulkDeleteFailoverCluster
        // GraphQL -> bulkDeleteFailoverCluster: ResponseSuccess! (type)
        public static string BulkDeleteFailoverCluster_TypedFieldSpec(ResponseSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkDeleteFailoverCluster" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkDeleteFailoverCluster_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkDeleteFailoverCluster((ResponseSuccess)fieldSpecObj);
        }
        public static string BulkDeleteFailoverCluster(ResponseSuccess fieldSpec)
        {
            return BulkDeleteFailoverCluster_TypedFieldSpec(fieldSpec);
        }
        public static string BulkDeleteFailoverCluster(object fieldSpecObj)
        {
            return BulkDeleteFailoverCluster_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkDeleteFailoverClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? BulkDeleteFailoverClusterApp
        // GraphQL -> bulkDeleteFailoverClusterApp: ResponseSuccess! (type)
        public static string BulkDeleteFailoverClusterApp_TypedFieldSpec(ResponseSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkDeleteFailoverClusterApp" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkDeleteFailoverClusterApp_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkDeleteFailoverClusterApp((ResponseSuccess)fieldSpecObj);
        }
        public static string BulkDeleteFailoverClusterApp(ResponseSuccess fieldSpec)
        {
            return BulkDeleteFailoverClusterApp_TypedFieldSpec(fieldSpec);
        }
        public static string BulkDeleteFailoverClusterApp(object fieldSpecObj)
        {
            return BulkDeleteFailoverClusterApp_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkDeleteFailoverClusterAppFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? BulkDeleteFileset
        // GraphQL -> bulkDeleteFileset: ResponseSuccess! (type)
        public static string BulkDeleteFileset_TypedFieldSpec(ResponseSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkDeleteFileset" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkDeleteFileset_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkDeleteFileset((ResponseSuccess)fieldSpecObj);
        }
        public static string BulkDeleteFileset(ResponseSuccess fieldSpec)
        {
            return BulkDeleteFileset_TypedFieldSpec(fieldSpec);
        }
        public static string BulkDeleteFileset(object fieldSpecObj)
        {
            return BulkDeleteFileset_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkDeleteFilesetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? BulkDeleteFilesetTemplate
        // GraphQL -> bulkDeleteFilesetTemplate: ResponseSuccess! (type)
        public static string BulkDeleteFilesetTemplate_TypedFieldSpec(ResponseSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkDeleteFilesetTemplate" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkDeleteFilesetTemplate_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkDeleteFilesetTemplate((ResponseSuccess)fieldSpecObj);
        }
        public static string BulkDeleteFilesetTemplate(ResponseSuccess fieldSpec)
        {
            return BulkDeleteFilesetTemplate_TypedFieldSpec(fieldSpec);
        }
        public static string BulkDeleteFilesetTemplate(object fieldSpecObj)
        {
            return BulkDeleteFilesetTemplate_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkDeleteFilesetTemplateFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? BulkDeleteHost
        // GraphQL -> bulkDeleteHost: ResponseSuccess! (type)
        public static string BulkDeleteHost_TypedFieldSpec(ResponseSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkDeleteHost" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkDeleteHost_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkDeleteHost((ResponseSuccess)fieldSpecObj);
        }
        public static string BulkDeleteHost(ResponseSuccess fieldSpec)
        {
            return BulkDeleteHost_TypedFieldSpec(fieldSpec);
        }
        public static string BulkDeleteHost(object fieldSpecObj)
        {
            return BulkDeleteHost_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkDeleteHostFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicAsyncResponse? BulkDeleteMongodbSources
        // GraphQL -> bulkDeleteMongodbSources: MosaicAsyncResponse! (type)
        public static string BulkDeleteMongodbSources_TypedFieldSpec(MosaicAsyncResponse fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkDeleteMongodbSources" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkDeleteMongodbSources_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkDeleteMongodbSources((MosaicAsyncResponse)fieldSpecObj);
        }
        public static string BulkDeleteMongodbSources(MosaicAsyncResponse fieldSpec)
        {
            return BulkDeleteMongodbSources_TypedFieldSpec(fieldSpec);
        }
        public static string BulkDeleteMongodbSources(object fieldSpecObj)
        {
            return BulkDeleteMongodbSources_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkDeleteMongodbSourcesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MosaicAsyncResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncRequestStatus? BulkDeleteNasSystems
        // GraphQL -> bulkDeleteNasSystems: BatchAsyncRequestStatus! (type)
        public static string BulkDeleteNasSystems_TypedFieldSpec(BatchAsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkDeleteNasSystems" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkDeleteNasSystems_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkDeleteNasSystems((BatchAsyncRequestStatus)fieldSpecObj);
        }
        public static string BulkDeleteNasSystems(BatchAsyncRequestStatus fieldSpec)
        {
            return BulkDeleteNasSystems_TypedFieldSpec(fieldSpec);
        }
        public static string BulkDeleteNasSystems(object fieldSpecObj)
        {
            return BulkDeleteNasSystems_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkDeleteNasSystemsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchAsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkOnDemandSnapshotNutanixVmReply? BulkOnDemandSnapshotNutanixVm
        // GraphQL -> bulkOnDemandSnapshotNutanixVm: BulkOnDemandSnapshotNutanixVmReply! (type)
        public static string BulkOnDemandSnapshotNutanixVm_TypedFieldSpec(BulkOnDemandSnapshotNutanixVmReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkOnDemandSnapshotNutanixVm" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkOnDemandSnapshotNutanixVm_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkOnDemandSnapshotNutanixVm((BulkOnDemandSnapshotNutanixVmReply)fieldSpecObj);
        }
        public static string BulkOnDemandSnapshotNutanixVm(BulkOnDemandSnapshotNutanixVmReply fieldSpec)
        {
            return BulkOnDemandSnapshotNutanixVm_TypedFieldSpec(fieldSpec);
        }
        public static string BulkOnDemandSnapshotNutanixVm(object fieldSpecObj)
        {
            return BulkOnDemandSnapshotNutanixVm_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkOnDemandSnapshotNutanixVmFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BulkOnDemandSnapshotNutanixVmReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkRefreshHostsReply? BulkRefreshHosts
        // GraphQL -> bulkRefreshHosts: BulkRefreshHostsReply! (type)
        public static string BulkRefreshHosts_TypedFieldSpec(BulkRefreshHostsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkRefreshHosts" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkRefreshHosts_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkRefreshHosts((BulkRefreshHostsReply)fieldSpecObj);
        }
        public static string BulkRefreshHosts(BulkRefreshHostsReply fieldSpec)
        {
            return BulkRefreshHosts_TypedFieldSpec(fieldSpec);
        }
        public static string BulkRefreshHosts(object fieldSpecObj)
        {
            return BulkRefreshHosts_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkRefreshHostsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BulkRefreshHostsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkRegisterHostReply? BulkRegisterHost
        // GraphQL -> bulkRegisterHost: BulkRegisterHostReply! (type)
        public static string BulkRegisterHost_TypedFieldSpec(BulkRegisterHostReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkRegisterHost" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkRegisterHost_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkRegisterHost((BulkRegisterHostReply)fieldSpecObj);
        }
        public static string BulkRegisterHost(BulkRegisterHostReply fieldSpec)
        {
            return BulkRegisterHost_TypedFieldSpec(fieldSpec);
        }
        public static string BulkRegisterHost(object fieldSpecObj)
        {
            return BulkRegisterHost_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkRegisterHostFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BulkRegisterHostReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkRegisterHostAsyncReply? BulkRegisterHostAsync
        // GraphQL -> bulkRegisterHostAsync: BulkRegisterHostAsyncReply! (type)
        public static string BulkRegisterHostAsync_TypedFieldSpec(BulkRegisterHostAsyncReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkRegisterHostAsync" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkRegisterHostAsync_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkRegisterHostAsync((BulkRegisterHostAsyncReply)fieldSpecObj);
        }
        public static string BulkRegisterHostAsync(BulkRegisterHostAsyncReply fieldSpec)
        {
            return BulkRegisterHostAsync_TypedFieldSpec(fieldSpec);
        }
        public static string BulkRegisterHostAsync(object fieldSpecObj)
        {
            return BulkRegisterHostAsync_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkRegisterHostAsyncFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BulkRegisterHostAsyncReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? BulkTierExistingSnapshots
        // GraphQL -> bulkTierExistingSnapshots: AsyncRequestStatus! (type)
        public static string BulkTierExistingSnapshots_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkTierExistingSnapshots" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkTierExistingSnapshots_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkTierExistingSnapshots((AsyncRequestStatus)fieldSpecObj);
        }
        public static string BulkTierExistingSnapshots(AsyncRequestStatus fieldSpec)
        {
            return BulkTierExistingSnapshots_TypedFieldSpec(fieldSpec);
        }
        public static string BulkTierExistingSnapshots(object fieldSpecObj)
        {
            return BulkTierExistingSnapshots_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkTierExistingSnapshotsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> V1BulkUpdateExchangeDagResponse? BulkUpdateExchangeDag
        // GraphQL -> bulkUpdateExchangeDag: V1BulkUpdateExchangeDagResponse! (type)
        public static string BulkUpdateExchangeDag_TypedFieldSpec(V1BulkUpdateExchangeDagResponse fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkUpdateExchangeDag" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkUpdateExchangeDag_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkUpdateExchangeDag((V1BulkUpdateExchangeDagResponse)fieldSpecObj);
        }
        public static string BulkUpdateExchangeDag(V1BulkUpdateExchangeDagResponse fieldSpec)
        {
            return BulkUpdateExchangeDag_TypedFieldSpec(fieldSpec);
        }
        public static string BulkUpdateExchangeDag(object fieldSpecObj)
        {
            return BulkUpdateExchangeDag_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkUpdateExchangeDagFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new V1BulkUpdateExchangeDagResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkUpdateFilesetTemplateReply? BulkUpdateFilesetTemplate
        // GraphQL -> bulkUpdateFilesetTemplate: BulkUpdateFilesetTemplateReply! (type)
        public static string BulkUpdateFilesetTemplate_TypedFieldSpec(BulkUpdateFilesetTemplateReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkUpdateFilesetTemplate" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkUpdateFilesetTemplate_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkUpdateFilesetTemplate((BulkUpdateFilesetTemplateReply)fieldSpecObj);
        }
        public static string BulkUpdateFilesetTemplate(BulkUpdateFilesetTemplateReply fieldSpec)
        {
            return BulkUpdateFilesetTemplate_TypedFieldSpec(fieldSpec);
        }
        public static string BulkUpdateFilesetTemplate(object fieldSpecObj)
        {
            return BulkUpdateFilesetTemplate_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkUpdateFilesetTemplateFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BulkUpdateFilesetTemplateReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkUpdateHostReply? BulkUpdateHost
        // GraphQL -> bulkUpdateHost: BulkUpdateHostReply! (type)
        public static string BulkUpdateHost_TypedFieldSpec(BulkUpdateHostReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkUpdateHost" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkUpdateHost_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkUpdateHost((BulkUpdateHostReply)fieldSpecObj);
        }
        public static string BulkUpdateHost(BulkUpdateHostReply fieldSpec)
        {
            return BulkUpdateHost_TypedFieldSpec(fieldSpec);
        }
        public static string BulkUpdateHost(object fieldSpecObj)
        {
            return BulkUpdateHost_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkUpdateHostFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BulkUpdateHostReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkUpdateMssqlAvailabilityGroupReply? BulkUpdateMssqlAvailabilityGroup
        // GraphQL -> bulkUpdateMssqlAvailabilityGroup: BulkUpdateMssqlAvailabilityGroupReply! (type)
        public static string BulkUpdateMssqlAvailabilityGroup_TypedFieldSpec(BulkUpdateMssqlAvailabilityGroupReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkUpdateMssqlAvailabilityGroup" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkUpdateMssqlAvailabilityGroup_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkUpdateMssqlAvailabilityGroup((BulkUpdateMssqlAvailabilityGroupReply)fieldSpecObj);
        }
        public static string BulkUpdateMssqlAvailabilityGroup(BulkUpdateMssqlAvailabilityGroupReply fieldSpec)
        {
            return BulkUpdateMssqlAvailabilityGroup_TypedFieldSpec(fieldSpec);
        }
        public static string BulkUpdateMssqlAvailabilityGroup(object fieldSpecObj)
        {
            return BulkUpdateMssqlAvailabilityGroup_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkUpdateMssqlAvailabilityGroupFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BulkUpdateMssqlAvailabilityGroupReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkUpdateMssqlDbsReply? BulkUpdateMssqlDbs
        // GraphQL -> bulkUpdateMssqlDbs: BulkUpdateMssqlDbsReply! (type)
        public static string BulkUpdateMssqlDbs_TypedFieldSpec(BulkUpdateMssqlDbsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkUpdateMssqlDbs" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkUpdateMssqlDbs_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkUpdateMssqlDbs((BulkUpdateMssqlDbsReply)fieldSpecObj);
        }
        public static string BulkUpdateMssqlDbs(BulkUpdateMssqlDbsReply fieldSpec)
        {
            return BulkUpdateMssqlDbs_TypedFieldSpec(fieldSpec);
        }
        public static string BulkUpdateMssqlDbs(object fieldSpecObj)
        {
            return BulkUpdateMssqlDbs_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkUpdateMssqlDbsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BulkUpdateMssqlDbsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkUpdateMssqlInstanceReply? BulkUpdateMssqlInstance
        // GraphQL -> bulkUpdateMssqlInstance: BulkUpdateMssqlInstanceReply! (type)
        public static string BulkUpdateMssqlInstance_TypedFieldSpec(BulkUpdateMssqlInstanceReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkUpdateMssqlInstance" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkUpdateMssqlInstance_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkUpdateMssqlInstance((BulkUpdateMssqlInstanceReply)fieldSpecObj);
        }
        public static string BulkUpdateMssqlInstance(BulkUpdateMssqlInstanceReply fieldSpec)
        {
            return BulkUpdateMssqlInstance_TypedFieldSpec(fieldSpec);
        }
        public static string BulkUpdateMssqlInstance(object fieldSpecObj)
        {
            return BulkUpdateMssqlInstance_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkUpdateMssqlInstanceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BulkUpdateMssqlInstanceReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkUpdateMssqlPropertiesOnHostReply? BulkUpdateMssqlPropertiesOnHost
        // GraphQL -> bulkUpdateMssqlPropertiesOnHost: BulkUpdateMssqlPropertiesOnHostReply! (type)
        public static string BulkUpdateMssqlPropertiesOnHost_TypedFieldSpec(BulkUpdateMssqlPropertiesOnHostReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkUpdateMssqlPropertiesOnHost" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkUpdateMssqlPropertiesOnHost_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkUpdateMssqlPropertiesOnHost((BulkUpdateMssqlPropertiesOnHostReply)fieldSpecObj);
        }
        public static string BulkUpdateMssqlPropertiesOnHost(BulkUpdateMssqlPropertiesOnHostReply fieldSpec)
        {
            return BulkUpdateMssqlPropertiesOnHost_TypedFieldSpec(fieldSpec);
        }
        public static string BulkUpdateMssqlPropertiesOnHost(object fieldSpecObj)
        {
            return BulkUpdateMssqlPropertiesOnHost_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkUpdateMssqlPropertiesOnHostFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BulkUpdateMssqlPropertiesOnHostReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkUpdateMssqlPropertiesOnWindowsClusterReply? BulkUpdateMssqlPropertiesOnWindowsCluster
        // GraphQL -> bulkUpdateMssqlPropertiesOnWindowsCluster: BulkUpdateMssqlPropertiesOnWindowsClusterReply! (type)
        public static string BulkUpdateMssqlPropertiesOnWindowsCluster_TypedFieldSpec(BulkUpdateMssqlPropertiesOnWindowsClusterReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkUpdateMssqlPropertiesOnWindowsCluster" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkUpdateMssqlPropertiesOnWindowsCluster_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkUpdateMssqlPropertiesOnWindowsCluster((BulkUpdateMssqlPropertiesOnWindowsClusterReply)fieldSpecObj);
        }
        public static string BulkUpdateMssqlPropertiesOnWindowsCluster(BulkUpdateMssqlPropertiesOnWindowsClusterReply fieldSpec)
        {
            return BulkUpdateMssqlPropertiesOnWindowsCluster_TypedFieldSpec(fieldSpec);
        }
        public static string BulkUpdateMssqlPropertiesOnWindowsCluster(object fieldSpecObj)
        {
            return BulkUpdateMssqlPropertiesOnWindowsCluster_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkUpdateMssqlPropertiesOnWindowsClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BulkUpdateMssqlPropertiesOnWindowsClusterReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkUpdateOracleDatabasesReply? BulkUpdateOracleDatabases
        // GraphQL -> bulkUpdateOracleDatabases: BulkUpdateOracleDatabasesReply! (type)
        public static string BulkUpdateOracleDatabases_TypedFieldSpec(BulkUpdateOracleDatabasesReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkUpdateOracleDatabases" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkUpdateOracleDatabases_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkUpdateOracleDatabases((BulkUpdateOracleDatabasesReply)fieldSpecObj);
        }
        public static string BulkUpdateOracleDatabases(BulkUpdateOracleDatabasesReply fieldSpec)
        {
            return BulkUpdateOracleDatabases_TypedFieldSpec(fieldSpec);
        }
        public static string BulkUpdateOracleDatabases(object fieldSpecObj)
        {
            return BulkUpdateOracleDatabases_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkUpdateOracleDatabasesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BulkUpdateOracleDatabasesReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkUpdateOracleHostsReply? BulkUpdateOracleHosts
        // GraphQL -> bulkUpdateOracleHosts: BulkUpdateOracleHostsReply! (type)
        public static string BulkUpdateOracleHosts_TypedFieldSpec(BulkUpdateOracleHostsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkUpdateOracleHosts" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkUpdateOracleHosts_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkUpdateOracleHosts((BulkUpdateOracleHostsReply)fieldSpecObj);
        }
        public static string BulkUpdateOracleHosts(BulkUpdateOracleHostsReply fieldSpec)
        {
            return BulkUpdateOracleHosts_TypedFieldSpec(fieldSpec);
        }
        public static string BulkUpdateOracleHosts(object fieldSpecObj)
        {
            return BulkUpdateOracleHosts_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkUpdateOracleHostsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BulkUpdateOracleHostsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BulkUpdateOracleRacsReply? BulkUpdateOracleRacs
        // GraphQL -> bulkUpdateOracleRacs: BulkUpdateOracleRacsReply! (type)
        public static string BulkUpdateOracleRacs_TypedFieldSpec(BulkUpdateOracleRacsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "bulkUpdateOracleRacs" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string BulkUpdateOracleRacs_ObjectFieldSpec(object fieldSpecObj)
        {
            return BulkUpdateOracleRacs((BulkUpdateOracleRacsReply)fieldSpecObj);
        }
        public static string BulkUpdateOracleRacs(BulkUpdateOracleRacsReply fieldSpec)
        {
            return BulkUpdateOracleRacs_TypedFieldSpec(fieldSpec);
        }
        public static string BulkUpdateOracleRacs(object fieldSpecObj)
        {
            return BulkUpdateOracleRacs_ObjectFieldSpec(fieldSpecObj);
        }
        public static object BulkUpdateOracleRacsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BulkUpdateOracleRacsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CancelJobReply? CancelDownloadPackage
        // GraphQL -> cancelDownloadPackage: CancelJobReply! (type)
        public static string CancelDownloadPackage_TypedFieldSpec(CancelJobReply fieldSpec)
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            return "cancelDownloadPackage" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CancelDownloadPackage_ObjectFieldSpec(object fieldSpecObj)
        {
            return CancelDownloadPackage((CancelJobReply)fieldSpecObj);
        }
        public static string CancelDownloadPackage(CancelJobReply fieldSpec)
        {
            return CancelDownloadPackage_TypedFieldSpec(fieldSpec);
        }
        public static string CancelDownloadPackage(object fieldSpecObj)
        {
            return CancelDownloadPackage_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CancelDownloadPackageFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CancelJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CancelJobReply? CancelScheduledUpgrade
        // GraphQL -> cancelScheduledUpgrade: CancelJobReply! (type)
        public static string CancelScheduledUpgrade_TypedFieldSpec(CancelJobReply fieldSpec)
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            return "cancelScheduledUpgrade" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CancelScheduledUpgrade_ObjectFieldSpec(object fieldSpecObj)
        {
            return CancelScheduledUpgrade((CancelJobReply)fieldSpecObj);
        }
        public static string CancelScheduledUpgrade(CancelJobReply fieldSpec)
        {
            return CancelScheduledUpgrade_TypedFieldSpec(fieldSpec);
        }
        public static string CancelScheduledUpgrade(object fieldSpecObj)
        {
            return CancelScheduledUpgrade_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CancelScheduledUpgradeFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CancelJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestStatus? CancelTaskchain
        // GraphQL -> cancelTaskchain: RequestStatus! (type)
        public static string CancelTaskchain_TypedFieldSpec(RequestStatus fieldSpec)
        {
            string args = "\n(\ntaskchainId: $taskchainId\n)";
            return "cancelTaskchain" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CancelTaskchain_ObjectFieldSpec(object fieldSpecObj)
        {
            return CancelTaskchain((RequestStatus)fieldSpecObj);
        }
        public static string CancelTaskchain(RequestStatus fieldSpec)
        {
            return CancelTaskchain_TypedFieldSpec(fieldSpec);
        }
        public static string CancelTaskchain(object fieldSpecObj)
        {
            return CancelTaskchain_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CancelTaskchainFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ChangeVfdOnHostReply? ChangeVfdOnHost
        // GraphQL -> changeVfdOnHost: ChangeVfdOnHostReply! (type)
        public static string ChangeVfdOnHost_TypedFieldSpec(ChangeVfdOnHostReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "changeVfdOnHost" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ChangeVfdOnHost_ObjectFieldSpec(object fieldSpecObj)
        {
            return ChangeVfdOnHost((ChangeVfdOnHostReply)fieldSpecObj);
        }
        public static string ChangeVfdOnHost(ChangeVfdOnHostReply fieldSpec)
        {
            return ChangeVfdOnHost_TypedFieldSpec(fieldSpec);
        }
        public static string ChangeVfdOnHost(object fieldSpecObj)
        {
            return ChangeVfdOnHost_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ChangeVfdOnHostFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ChangeVfdOnHostReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ClearCloudNativeSqlServerBackupCredentialsReply? ClearCloudNativeSqlServerBackupCredentials
        // GraphQL -> clearCloudNativeSqlServerBackupCredentials: ClearCloudNativeSqlServerBackupCredentialsReply! (type)
        public static string ClearCloudNativeSqlServerBackupCredentials_TypedFieldSpec(ClearCloudNativeSqlServerBackupCredentialsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "clearCloudNativeSqlServerBackupCredentials" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ClearCloudNativeSqlServerBackupCredentials_ObjectFieldSpec(object fieldSpecObj)
        {
            return ClearCloudNativeSqlServerBackupCredentials((ClearCloudNativeSqlServerBackupCredentialsReply)fieldSpecObj);
        }
        public static string ClearCloudNativeSqlServerBackupCredentials(ClearCloudNativeSqlServerBackupCredentialsReply fieldSpec)
        {
            return ClearCloudNativeSqlServerBackupCredentials_TypedFieldSpec(fieldSpec);
        }
        public static string ClearCloudNativeSqlServerBackupCredentials(object fieldSpecObj)
        {
            return ClearCloudNativeSqlServerBackupCredentials_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ClearCloudNativeSqlServerBackupCredentialsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ClearCloudNativeSqlServerBackupCredentialsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CloudNativeCheckRbaConnectivityReply? CloudNativeCheckRbaConnectivity
        // GraphQL -> cloudNativeCheckRbaConnectivity: CloudNativeCheckRbaConnectivityReply! (type)
        public static string CloudNativeCheckRbaConnectivity_TypedFieldSpec(CloudNativeCheckRbaConnectivityReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "cloudNativeCheckRbaConnectivity" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CloudNativeCheckRbaConnectivity_ObjectFieldSpec(object fieldSpecObj)
        {
            return CloudNativeCheckRbaConnectivity((CloudNativeCheckRbaConnectivityReply)fieldSpecObj);
        }
        public static string CloudNativeCheckRbaConnectivity(CloudNativeCheckRbaConnectivityReply fieldSpec)
        {
            return CloudNativeCheckRbaConnectivity_TypedFieldSpec(fieldSpec);
        }
        public static string CloudNativeCheckRbaConnectivity(object fieldSpecObj)
        {
            return CloudNativeCheckRbaConnectivity_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CloudNativeCheckRbaConnectivityFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CloudNativeCheckRbaConnectivityReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DownloadFilesReply? CloudNativeDownloadFiles
        // GraphQL -> cloudNativeDownloadFiles: DownloadFilesReply! (type)
        public static string CloudNativeDownloadFiles_TypedFieldSpec(DownloadFilesReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "cloudNativeDownloadFiles" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CloudNativeDownloadFiles_ObjectFieldSpec(object fieldSpecObj)
        {
            return CloudNativeDownloadFiles((DownloadFilesReply)fieldSpecObj);
        }
        public static string CloudNativeDownloadFiles(DownloadFilesReply fieldSpec)
        {
            return CloudNativeDownloadFiles_TypedFieldSpec(fieldSpec);
        }
        public static string CloudNativeDownloadFiles(object fieldSpecObj)
        {
            return CloudNativeDownloadFiles_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CloudNativeDownloadFilesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DownloadFilesReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CompleteAzureAdAppSetupReply? CompleteAzureAdAppSetup
        // GraphQL -> completeAzureAdAppSetup: CompleteAzureAdAppSetupReply! (type)
        public static string CompleteAzureAdAppSetup_TypedFieldSpec(CompleteAzureAdAppSetupReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "completeAzureAdAppSetup" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CompleteAzureAdAppSetup_ObjectFieldSpec(object fieldSpecObj)
        {
            return CompleteAzureAdAppSetup((CompleteAzureAdAppSetupReply)fieldSpecObj);
        }
        public static string CompleteAzureAdAppSetup(CompleteAzureAdAppSetupReply fieldSpec)
        {
            return CompleteAzureAdAppSetup_TypedFieldSpec(fieldSpec);
        }
        public static string CompleteAzureAdAppSetup(object fieldSpecObj)
        {
            return CompleteAzureAdAppSetup_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CompleteAzureAdAppSetupFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CompleteAzureAdAppSetupReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CompleteAzureCloudAccountOauthReply? CompleteAzureCloudAccountOauth
        // GraphQL -> completeAzureCloudAccountOauth: CompleteAzureCloudAccountOauthReply! (type)
        public static string CompleteAzureCloudAccountOauth_TypedFieldSpec(CompleteAzureCloudAccountOauthReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "completeAzureCloudAccountOauth" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CompleteAzureCloudAccountOauth_ObjectFieldSpec(object fieldSpecObj)
        {
            return CompleteAzureCloudAccountOauth((CompleteAzureCloudAccountOauthReply)fieldSpecObj);
        }
        public static string CompleteAzureCloudAccountOauth(CompleteAzureCloudAccountOauthReply fieldSpec)
        {
            return CompleteAzureCloudAccountOauth_TypedFieldSpec(fieldSpec);
        }
        public static string CompleteAzureCloudAccountOauth(object fieldSpecObj)
        {
            return CompleteAzureCloudAccountOauth_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CompleteAzureCloudAccountOauthFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CompleteAzureCloudAccountOauthReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Db2ConfigureRestoreResponse? ConfigureDb2Restore
        // GraphQL -> configureDb2Restore: Db2ConfigureRestoreResponse! (type)
        public static string ConfigureDb2Restore_TypedFieldSpec(Db2ConfigureRestoreResponse fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "configureDb2Restore" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ConfigureDb2Restore_ObjectFieldSpec(object fieldSpecObj)
        {
            return ConfigureDb2Restore((Db2ConfigureRestoreResponse)fieldSpecObj);
        }
        public static string ConfigureDb2Restore(Db2ConfigureRestoreResponse fieldSpec)
        {
            return ConfigureDb2Restore_TypedFieldSpec(fieldSpec);
        }
        public static string ConfigureDb2Restore(object fieldSpecObj)
        {
            return ConfigureDb2Restore_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ConfigureDb2RestoreFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new Db2ConfigureRestoreResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ConfigureSapHanaRestore
        // GraphQL -> configureSapHanaRestore: AsyncRequestStatus! (type)
        public static string ConfigureSapHanaRestore_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "configureSapHanaRestore" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ConfigureSapHanaRestore_ObjectFieldSpec(object fieldSpecObj)
        {
            return ConfigureSapHanaRestore((AsyncRequestStatus)fieldSpecObj);
        }
        public static string ConfigureSapHanaRestore(AsyncRequestStatus fieldSpec)
        {
            return ConfigureSapHanaRestore_TypedFieldSpec(fieldSpec);
        }
        public static string ConfigureSapHanaRestore(object fieldSpecObj)
        {
            return ConfigureSapHanaRestore_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ConfigureSapHanaRestoreFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateActiveDirectoryLiveMount
        // GraphQL -> createActiveDirectoryLiveMount: AsyncRequestStatus! (type)
        public static string CreateActiveDirectoryLiveMount_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createActiveDirectoryLiveMount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateActiveDirectoryLiveMount_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateActiveDirectoryLiveMount((AsyncRequestStatus)fieldSpecObj);
        }
        public static string CreateActiveDirectoryLiveMount(AsyncRequestStatus fieldSpec)
        {
            return CreateActiveDirectoryLiveMount_TypedFieldSpec(fieldSpec);
        }
        public static string CreateActiveDirectoryLiveMount(object fieldSpecObj)
        {
            return CreateActiveDirectoryLiveMount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateActiveDirectoryLiveMountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateActiveDirectoryUnmount
        // GraphQL -> createActiveDirectoryUnmount: AsyncRequestStatus! (type)
        public static string CreateActiveDirectoryUnmount_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createActiveDirectoryUnmount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateActiveDirectoryUnmount_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateActiveDirectoryUnmount((AsyncRequestStatus)fieldSpecObj);
        }
        public static string CreateActiveDirectoryUnmount(AsyncRequestStatus fieldSpec)
        {
            return CreateActiveDirectoryUnmount_TypedFieldSpec(fieldSpec);
        }
        public static string CreateActiveDirectoryUnmount(object fieldSpecObj)
        {
            return CreateActiveDirectoryUnmount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateActiveDirectoryUnmountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TargetMapping? CreateAutomaticAwsTargetMapping
        // GraphQL -> createAutomaticAwsTargetMapping: TargetMapping! (type)
        public static string CreateAutomaticAwsTargetMapping_TypedFieldSpec(TargetMapping fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createAutomaticAwsTargetMapping" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateAutomaticAwsTargetMapping_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateAutomaticAwsTargetMapping((TargetMapping)fieldSpecObj);
        }
        public static string CreateAutomaticAwsTargetMapping(TargetMapping fieldSpec)
        {
            return CreateAutomaticAwsTargetMapping_TypedFieldSpec(fieldSpec);
        }
        public static string CreateAutomaticAwsTargetMapping(object fieldSpecObj)
        {
            return CreateAutomaticAwsTargetMapping_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateAutomaticAwsTargetMappingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new TargetMapping() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TargetMapping? CreateAutomaticAzureTargetMapping
        // GraphQL -> createAutomaticAzureTargetMapping: TargetMapping! (type)
        public static string CreateAutomaticAzureTargetMapping_TypedFieldSpec(TargetMapping fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createAutomaticAzureTargetMapping" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateAutomaticAzureTargetMapping_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateAutomaticAzureTargetMapping((TargetMapping)fieldSpecObj);
        }
        public static string CreateAutomaticAzureTargetMapping(TargetMapping fieldSpec)
        {
            return CreateAutomaticAzureTargetMapping_TypedFieldSpec(fieldSpec);
        }
        public static string CreateAutomaticAzureTargetMapping(object fieldSpecObj)
        {
            return CreateAutomaticAzureTargetMapping_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateAutomaticAzureTargetMappingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new TargetMapping() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TargetMapping? CreateAutomaticRcsTargetMapping
        // GraphQL -> createAutomaticRcsTargetMapping: TargetMapping! (type)
        public static string CreateAutomaticRcsTargetMapping_TypedFieldSpec(TargetMapping fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createAutomaticRcsTargetMapping" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateAutomaticRcsTargetMapping_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateAutomaticRcsTargetMapping((TargetMapping)fieldSpecObj);
        }
        public static string CreateAutomaticRcsTargetMapping(TargetMapping fieldSpec)
        {
            return CreateAutomaticRcsTargetMapping_TypedFieldSpec(fieldSpec);
        }
        public static string CreateAutomaticRcsTargetMapping(object fieldSpecObj)
        {
            return CreateAutomaticRcsTargetMapping_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateAutomaticRcsTargetMappingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new TargetMapping() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CcProvisionJobReply? CreateAwsCluster
        // GraphQL -> createAwsCluster: CcProvisionJobReply! (type)
        public static string CreateAwsCluster_TypedFieldSpec(CcProvisionJobReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createAwsCluster" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateAwsCluster_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateAwsCluster((CcProvisionJobReply)fieldSpecObj);
        }
        public static string CreateAwsCluster(CcProvisionJobReply fieldSpec)
        {
            return CreateAwsCluster_TypedFieldSpec(fieldSpec);
        }
        public static string CreateAwsCluster(object fieldSpecObj)
        {
            return CreateAwsCluster_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateAwsClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CcProvisionJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsComputeSettings? CreateAwsComputeSetting
        // GraphQL -> createAwsComputeSetting: AwsComputeSettings! (type)
        public static string CreateAwsComputeSetting_TypedFieldSpec(AwsComputeSettings fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createAwsComputeSetting" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateAwsComputeSetting_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateAwsComputeSetting((AwsComputeSettings)fieldSpecObj);
        }
        public static string CreateAwsComputeSetting(AwsComputeSettings fieldSpec)
        {
            return CreateAwsComputeSetting_TypedFieldSpec(fieldSpec);
        }
        public static string CreateAwsComputeSetting(object fieldSpecObj)
        {
            return CreateAwsComputeSetting_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateAwsComputeSettingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AwsComputeSettings() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateAwsExocomputeConfigsReply? CreateAwsExocomputeConfigs
        // GraphQL -> createAwsExocomputeConfigs: CreateAwsExocomputeConfigsReply! (type)
        public static string CreateAwsExocomputeConfigs_TypedFieldSpec(CreateAwsExocomputeConfigsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createAwsExocomputeConfigs" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateAwsExocomputeConfigs_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateAwsExocomputeConfigs((CreateAwsExocomputeConfigsReply)fieldSpecObj);
        }
        public static string CreateAwsExocomputeConfigs(CreateAwsExocomputeConfigsReply fieldSpec)
        {
            return CreateAwsExocomputeConfigs_TypedFieldSpec(fieldSpec);
        }
        public static string CreateAwsExocomputeConfigs(object fieldSpecObj)
        {
            return CreateAwsExocomputeConfigs_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateAwsExocomputeConfigsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateAwsExocomputeConfigsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CcProvisionJobReply? CreateAzureCluster
        // GraphQL -> createAzureCluster: CcProvisionJobReply! (type)
        public static string CreateAzureCluster_TypedFieldSpec(CcProvisionJobReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createAzureCluster" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateAzureCluster_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateAzureCluster((CcProvisionJobReply)fieldSpecObj);
        }
        public static string CreateAzureCluster(CcProvisionJobReply fieldSpec)
        {
            return CreateAzureCluster_TypedFieldSpec(fieldSpec);
        }
        public static string CreateAzureCluster(object fieldSpecObj)
        {
            return CreateAzureCluster_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateAzureClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CcProvisionJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateAzureSaasAppAadReply? CreateAzureSaasAppAad
        // GraphQL -> createAzureSaasAppAad: CreateAzureSaasAppAadReply! (type)
        public static string CreateAzureSaasAppAad_TypedFieldSpec(CreateAzureSaasAppAadReply fieldSpec)
        {
            string args = "";
            return "createAzureSaasAppAad" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateAzureSaasAppAad_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateAzureSaasAppAad((CreateAzureSaasAppAadReply)fieldSpecObj);
        }
        public static string CreateAzureSaasAppAad(CreateAzureSaasAppAadReply fieldSpec)
        {
            return CreateAzureSaasAppAad_TypedFieldSpec(fieldSpec);
        }
        public static string CreateAzureSaasAppAad(object fieldSpecObj)
        {
            return CreateAzureSaasAppAad_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateAzureSaasAppAadFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateAzureSaasAppAadReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicAsyncResponse? CreateCassandraSource
        // GraphQL -> createCassandraSource: MosaicAsyncResponse! (type)
        public static string CreateCassandraSource_TypedFieldSpec(MosaicAsyncResponse fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createCassandraSource" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateCassandraSource_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateCassandraSource((MosaicAsyncResponse)fieldSpecObj);
        }
        public static string CreateCassandraSource(MosaicAsyncResponse fieldSpec)
        {
            return CreateCassandraSource_TypedFieldSpec(fieldSpec);
        }
        public static string CreateCassandraSource(object fieldSpecObj)
        {
            return CreateCassandraSource_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateCassandraSourceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MosaicAsyncResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateCloudNativeAwsStorageSettingReply? CreateCloudNativeAwsStorageSetting
        // GraphQL -> createCloudNativeAwsStorageSetting: CreateCloudNativeAwsStorageSettingReply! (type)
        public static string CreateCloudNativeAwsStorageSetting_TypedFieldSpec(CreateCloudNativeAwsStorageSettingReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createCloudNativeAwsStorageSetting" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateCloudNativeAwsStorageSetting_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateCloudNativeAwsStorageSetting((CreateCloudNativeAwsStorageSettingReply)fieldSpecObj);
        }
        public static string CreateCloudNativeAwsStorageSetting(CreateCloudNativeAwsStorageSettingReply fieldSpec)
        {
            return CreateCloudNativeAwsStorageSetting_TypedFieldSpec(fieldSpec);
        }
        public static string CreateCloudNativeAwsStorageSetting(object fieldSpecObj)
        {
            return CreateCloudNativeAwsStorageSetting_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateCloudNativeAwsStorageSettingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateCloudNativeAwsStorageSettingReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateCloudNativeAzureStorageSettingReply? CreateCloudNativeAzureStorageSetting
        // GraphQL -> createCloudNativeAzureStorageSetting: CreateCloudNativeAzureStorageSettingReply! (type)
        public static string CreateCloudNativeAzureStorageSetting_TypedFieldSpec(CreateCloudNativeAzureStorageSettingReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createCloudNativeAzureStorageSetting" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateCloudNativeAzureStorageSetting_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateCloudNativeAzureStorageSetting((CreateCloudNativeAzureStorageSettingReply)fieldSpecObj);
        }
        public static string CreateCloudNativeAzureStorageSetting(CreateCloudNativeAzureStorageSettingReply fieldSpec)
        {
            return CreateCloudNativeAzureStorageSetting_TypedFieldSpec(fieldSpec);
        }
        public static string CreateCloudNativeAzureStorageSetting(object fieldSpecObj)
        {
            return CreateCloudNativeAzureStorageSetting_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateCloudNativeAzureStorageSettingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateCloudNativeAzureStorageSettingReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateCloudNativeLabelRuleReply? CreateCloudNativeLabelRule
        // GraphQL -> createCloudNativeLabelRule: CreateCloudNativeLabelRuleReply! (type)
        public static string CreateCloudNativeLabelRule_TypedFieldSpec(CreateCloudNativeLabelRuleReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createCloudNativeLabelRule" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateCloudNativeLabelRule_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateCloudNativeLabelRule((CreateCloudNativeLabelRuleReply)fieldSpecObj);
        }
        public static string CreateCloudNativeLabelRule(CreateCloudNativeLabelRuleReply fieldSpec)
        {
            return CreateCloudNativeLabelRule_TypedFieldSpec(fieldSpec);
        }
        public static string CreateCloudNativeLabelRule(object fieldSpecObj)
        {
            return CreateCloudNativeLabelRule_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateCloudNativeLabelRuleFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateCloudNativeLabelRuleReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateCloudNativeRcvAzureStorageSettingReply? CreateCloudNativeRcvAzureStorageSetting
        // GraphQL -> createCloudNativeRcvAzureStorageSetting: CreateCloudNativeRcvAzureStorageSettingReply! (type)
        public static string CreateCloudNativeRcvAzureStorageSetting_TypedFieldSpec(CreateCloudNativeRcvAzureStorageSettingReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createCloudNativeRcvAzureStorageSetting" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateCloudNativeRcvAzureStorageSetting_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateCloudNativeRcvAzureStorageSetting((CreateCloudNativeRcvAzureStorageSettingReply)fieldSpecObj);
        }
        public static string CreateCloudNativeRcvAzureStorageSetting(CreateCloudNativeRcvAzureStorageSettingReply fieldSpec)
        {
            return CreateCloudNativeRcvAzureStorageSetting_TypedFieldSpec(fieldSpec);
        }
        public static string CreateCloudNativeRcvAzureStorageSetting(object fieldSpecObj)
        {
            return CreateCloudNativeRcvAzureStorageSetting_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateCloudNativeRcvAzureStorageSettingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateCloudNativeRcvAzureStorageSettingReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateCloudNativeTagRuleReply? CreateCloudNativeTagRule
        // GraphQL -> createCloudNativeTagRule: CreateCloudNativeTagRuleReply! (type)
        public static string CreateCloudNativeTagRule_TypedFieldSpec(CreateCloudNativeTagRuleReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createCloudNativeTagRule" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateCloudNativeTagRule_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateCloudNativeTagRule((CreateCloudNativeTagRuleReply)fieldSpecObj);
        }
        public static string CreateCloudNativeTagRule(CreateCloudNativeTagRuleReply fieldSpec)
        {
            return CreateCloudNativeTagRule_TypedFieldSpec(fieldSpec);
        }
        public static string CreateCloudNativeTagRule(object fieldSpecObj)
        {
            return CreateCloudNativeTagRule_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateCloudNativeTagRuleFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateCloudNativeTagRuleReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateCrossAccountRegOauthPayloadReply? CreateCrossAccountRegOauthPayload
        // GraphQL -> createCrossAccountRegOauthPayload: CreateCrossAccountRegOauthPayloadReply! (type)
        public static string CreateCrossAccountRegOauthPayload_TypedFieldSpec(CreateCrossAccountRegOauthPayloadReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createCrossAccountRegOauthPayload" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateCrossAccountRegOauthPayload_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateCrossAccountRegOauthPayload((CreateCrossAccountRegOauthPayloadReply)fieldSpecObj);
        }
        public static string CreateCrossAccountRegOauthPayload(CreateCrossAccountRegOauthPayloadReply fieldSpec)
        {
            return CreateCrossAccountRegOauthPayload_TypedFieldSpec(fieldSpec);
        }
        public static string CreateCrossAccountRegOauthPayload(object fieldSpecObj)
        {
            return CreateCrossAccountRegOauthPayload_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateCrossAccountRegOauthPayloadFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateCrossAccountRegOauthPayloadReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Analyzer? CreateCustomAnalyzer
        // GraphQL -> createCustomAnalyzer: Analyzer! (type)
        public static string CreateCustomAnalyzer_TypedFieldSpec(Analyzer fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createCustomAnalyzer" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateCustomAnalyzer_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateCustomAnalyzer((Analyzer)fieldSpecObj);
        }
        public static string CreateCustomAnalyzer(Analyzer fieldSpec)
        {
            return CreateCustomAnalyzer_TypedFieldSpec(fieldSpec);
        }
        public static string CreateCustomAnalyzer(object fieldSpecObj)
        {
            return CreateCustomAnalyzer_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateCustomAnalyzerFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new Analyzer() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateCustomReportReply? CreateCustomReport
        // GraphQL -> createCustomReport: CreateCustomReportReply! (type)
        public static string CreateCustomReport_TypedFieldSpec(CreateCustomReportReply fieldSpec)
        {
            string args = "\n(\ninput: $input\nreportRoom: $reportRoom\n)";
            return "createCustomReport" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateCustomReport_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateCustomReport((CreateCustomReportReply)fieldSpecObj);
        }
        public static string CreateCustomReport(CreateCustomReportReply fieldSpec)
        {
            return CreateCustomReport_TypedFieldSpec(fieldSpec);
        }
        public static string CreateCustomReport(object fieldSpecObj)
        {
            return CreateCustomReport_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateCustomReportFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateCustomReportReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateDomainControllerSnapshot
        // GraphQL -> createDomainControllerSnapshot: AsyncRequestStatus! (type)
        public static string CreateDomainControllerSnapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createDomainControllerSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateDomainControllerSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateDomainControllerSnapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string CreateDomainControllerSnapshot(AsyncRequestStatus fieldSpec)
        {
            return CreateDomainControllerSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string CreateDomainControllerSnapshot(object fieldSpecObj)
        {
            return CreateDomainControllerSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateDomainControllerSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateDownloadSnapshotForVolumeGroup
        // GraphQL -> createDownloadSnapshotForVolumeGroup: AsyncRequestStatus! (type)
        public static string CreateDownloadSnapshotForVolumeGroup_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createDownloadSnapshotForVolumeGroup" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateDownloadSnapshotForVolumeGroup_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateDownloadSnapshotForVolumeGroup((AsyncRequestStatus)fieldSpecObj);
        }
        public static string CreateDownloadSnapshotForVolumeGroup(AsyncRequestStatus fieldSpec)
        {
            return CreateDownloadSnapshotForVolumeGroup_TypedFieldSpec(fieldSpec);
        }
        public static string CreateDownloadSnapshotForVolumeGroup(object fieldSpecObj)
        {
            return CreateDownloadSnapshotForVolumeGroup_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateDownloadSnapshotForVolumeGroupFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateExchangeMount
        // GraphQL -> createExchangeMount: AsyncRequestStatus! (type)
        public static string CreateExchangeMount_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createExchangeMount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateExchangeMount_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateExchangeMount((AsyncRequestStatus)fieldSpecObj);
        }
        public static string CreateExchangeMount(AsyncRequestStatus fieldSpec)
        {
            return CreateExchangeMount_TypedFieldSpec(fieldSpec);
        }
        public static string CreateExchangeMount(object fieldSpecObj)
        {
            return CreateExchangeMount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateExchangeMountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateFailoverClusterReply? CreateFailoverCluster
        // GraphQL -> createFailoverCluster: CreateFailoverClusterReply! (type)
        public static string CreateFailoverCluster_TypedFieldSpec(CreateFailoverClusterReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createFailoverCluster" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateFailoverCluster_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateFailoverCluster((CreateFailoverClusterReply)fieldSpecObj);
        }
        public static string CreateFailoverCluster(CreateFailoverClusterReply fieldSpec)
        {
            return CreateFailoverCluster_TypedFieldSpec(fieldSpec);
        }
        public static string CreateFailoverCluster(object fieldSpecObj)
        {
            return CreateFailoverCluster_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateFailoverClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateFailoverClusterReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateFailoverClusterAppReply? CreateFailoverClusterApp
        // GraphQL -> createFailoverClusterApp: CreateFailoverClusterAppReply! (type)
        public static string CreateFailoverClusterApp_TypedFieldSpec(CreateFailoverClusterAppReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createFailoverClusterApp" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateFailoverClusterApp_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateFailoverClusterApp((CreateFailoverClusterAppReply)fieldSpecObj);
        }
        public static string CreateFailoverClusterApp(CreateFailoverClusterAppReply fieldSpec)
        {
            return CreateFailoverClusterApp_TypedFieldSpec(fieldSpec);
        }
        public static string CreateFailoverClusterApp(object fieldSpecObj)
        {
            return CreateFailoverClusterApp_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateFailoverClusterAppFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateFailoverClusterAppReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateFilesetSnapshot
        // GraphQL -> createFilesetSnapshot: AsyncRequestStatus! (type)
        public static string CreateFilesetSnapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createFilesetSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateFilesetSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateFilesetSnapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string CreateFilesetSnapshot(AsyncRequestStatus fieldSpec)
        {
            return CreateFilesetSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string CreateFilesetSnapshot(object fieldSpecObj)
        {
            return CreateFilesetSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateFilesetSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GlobalSlaReply? CreateGlobalSla
        // GraphQL -> createGlobalSla: GlobalSlaReply! (type)
        public static string CreateGlobalSla_TypedFieldSpec(GlobalSlaReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createGlobalSla" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateGlobalSla_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateGlobalSla((GlobalSlaReply)fieldSpecObj);
        }
        public static string CreateGlobalSla(GlobalSlaReply fieldSpec)
        {
            return CreateGlobalSla_TypedFieldSpec(fieldSpec);
        }
        public static string CreateGlobalSla(object fieldSpecObj)
        {
            return CreateGlobalSla_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateGlobalSlaFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GlobalSlaReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateGuestCredentialReply? CreateGuestCredential
        // GraphQL -> createGuestCredential: CreateGuestCredentialReply! (type)
        public static string CreateGuestCredential_TypedFieldSpec(CreateGuestCredentialReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createGuestCredential" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateGuestCredential_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateGuestCredential((CreateGuestCredentialReply)fieldSpecObj);
        }
        public static string CreateGuestCredential(CreateGuestCredentialReply fieldSpec)
        {
            return CreateGuestCredential_TypedFieldSpec(fieldSpec);
        }
        public static string CreateGuestCredential(object fieldSpecObj)
        {
            return CreateGuestCredential_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateGuestCredentialFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateGuestCredentialReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateHypervVirtualMachineSnapshotDiskMount
        // GraphQL -> createHypervVirtualMachineSnapshotDiskMount: AsyncRequestStatus! (type)
        public static string CreateHypervVirtualMachineSnapshotDiskMount_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createHypervVirtualMachineSnapshotDiskMount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateHypervVirtualMachineSnapshotDiskMount_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateHypervVirtualMachineSnapshotDiskMount((AsyncRequestStatus)fieldSpecObj);
        }
        public static string CreateHypervVirtualMachineSnapshotDiskMount(AsyncRequestStatus fieldSpec)
        {
            return CreateHypervVirtualMachineSnapshotDiskMount_TypedFieldSpec(fieldSpec);
        }
        public static string CreateHypervVirtualMachineSnapshotDiskMount(object fieldSpecObj)
        {
            return CreateHypervVirtualMachineSnapshotDiskMount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateHypervVirtualMachineSnapshotDiskMountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateHypervVirtualMachineSnapshotMount
        // GraphQL -> createHypervVirtualMachineSnapshotMount: AsyncRequestStatus! (type)
        public static string CreateHypervVirtualMachineSnapshotMount_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createHypervVirtualMachineSnapshotMount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateHypervVirtualMachineSnapshotMount_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateHypervVirtualMachineSnapshotMount((AsyncRequestStatus)fieldSpecObj);
        }
        public static string CreateHypervVirtualMachineSnapshotMount(AsyncRequestStatus fieldSpec)
        {
            return CreateHypervVirtualMachineSnapshotMount_TypedFieldSpec(fieldSpec);
        }
        public static string CreateHypervVirtualMachineSnapshotMount(object fieldSpecObj)
        {
            return CreateHypervVirtualMachineSnapshotMount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateHypervVirtualMachineSnapshotMountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateIntegrationReply? CreateIntegration
        // GraphQL -> createIntegration: CreateIntegrationReply! (type)
        public static string CreateIntegration_TypedFieldSpec(CreateIntegrationReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createIntegration" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateIntegration_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateIntegration((CreateIntegrationReply)fieldSpecObj);
        }
        public static string CreateIntegration(CreateIntegrationReply fieldSpec)
        {
            return CreateIntegration_TypedFieldSpec(fieldSpec);
        }
        public static string CreateIntegration(object fieldSpecObj)
        {
            return CreateIntegration_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateIntegrationFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateIntegrationReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateIntegrationsReply? CreateIntegrations
        // GraphQL -> createIntegrations: CreateIntegrationsReply! (type)
        public static string CreateIntegrations_TypedFieldSpec(CreateIntegrationsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createIntegrations" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateIntegrations_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateIntegrations((CreateIntegrationsReply)fieldSpecObj);
        }
        public static string CreateIntegrations(CreateIntegrationsReply fieldSpec)
        {
            return CreateIntegrations_TypedFieldSpec(fieldSpec);
        }
        public static string CreateIntegrations(object fieldSpecObj)
        {
            return CreateIntegrations_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateIntegrationsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateIntegrationsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateK8sAgentManifestReply? CreateK8sAgentManifest
        // GraphQL -> createK8sAgentManifest: CreateK8sAgentManifestReply! (type)
        public static string CreateK8sAgentManifest_TypedFieldSpec(CreateK8sAgentManifestReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createK8sAgentManifest" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateK8sAgentManifest_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateK8sAgentManifest((CreateK8sAgentManifestReply)fieldSpecObj);
        }
        public static string CreateK8sAgentManifest(CreateK8sAgentManifestReply fieldSpec)
        {
            return CreateK8sAgentManifest_TypedFieldSpec(fieldSpec);
        }
        public static string CreateK8sAgentManifest(object fieldSpecObj)
        {
            return CreateK8sAgentManifest_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateK8sAgentManifestFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateK8sAgentManifestReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateK8sClusterReply? CreateK8sCluster
        // GraphQL -> createK8sCluster: CreateK8sClusterReply! (type)
        public static string CreateK8sCluster_TypedFieldSpec(CreateK8sClusterReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createK8sCluster" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateK8sCluster_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateK8sCluster((CreateK8sClusterReply)fieldSpecObj);
        }
        public static string CreateK8sCluster(CreateK8sClusterReply fieldSpec)
        {
            return CreateK8sCluster_TypedFieldSpec(fieldSpec);
        }
        public static string CreateK8sCluster(object fieldSpecObj)
        {
            return CreateK8sCluster_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateK8sClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateK8sClusterReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<CreateOnDemandJobReply>? CreateK8sNamespaceSnapshots
        // GraphQL -> createK8sNamespaceSnapshots: [CreateOnDemandJobReply!]! (type)
        public static string CreateK8sNamespaceSnapshots_TypedFieldSpec(List<CreateOnDemandJobReply> fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createK8sNamespaceSnapshots" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateK8sNamespaceSnapshots_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateK8sNamespaceSnapshots((List<CreateOnDemandJobReply>)fieldSpecObj);
        }
        public static string CreateK8sNamespaceSnapshots(List<CreateOnDemandJobReply> fieldSpec)
        {
            return CreateK8sNamespaceSnapshots_TypedFieldSpec(fieldSpec);
        }
        public static string CreateK8sNamespaceSnapshots(object fieldSpecObj)
        {
            return CreateK8sNamespaceSnapshots_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateK8sNamespaceSnapshotsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<CreateOnDemandJobReply>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateK8sProtectionSetSnapshot
        // GraphQL -> createK8sProtectionSetSnapshot: AsyncRequestStatus! (type)
        public static string CreateK8sProtectionSetSnapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createK8sProtectionSetSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateK8sProtectionSetSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateK8sProtectionSetSnapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string CreateK8sProtectionSetSnapshot(AsyncRequestStatus fieldSpec)
        {
            return CreateK8sProtectionSetSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string CreateK8sProtectionSetSnapshot(object fieldSpecObj)
        {
            return CreateK8sProtectionSetSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateK8sProtectionSetSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateLegalHoldReply? CreateLegalHold
        // GraphQL -> createLegalHold: CreateLegalHoldReply! (type)
        public static string CreateLegalHold_TypedFieldSpec(CreateLegalHoldReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createLegalHold" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateLegalHold_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateLegalHold((CreateLegalHoldReply)fieldSpecObj);
        }
        public static string CreateLegalHold(CreateLegalHoldReply fieldSpec)
        {
            return CreateLegalHold_TypedFieldSpec(fieldSpec);
        }
        public static string CreateLegalHold(object fieldSpecObj)
        {
            return CreateLegalHold_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateLegalHoldFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateLegalHoldReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TargetMapping? CreateManualTargetMapping
        // GraphQL -> createManualTargetMapping: TargetMapping! (type)
        public static string CreateManualTargetMapping_TypedFieldSpec(TargetMapping fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createManualTargetMapping" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateManualTargetMapping_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateManualTargetMapping((TargetMapping)fieldSpecObj);
        }
        public static string CreateManualTargetMapping(TargetMapping fieldSpec)
        {
            return CreateManualTargetMapping_TypedFieldSpec(fieldSpec);
        }
        public static string CreateManualTargetMapping(object fieldSpecObj)
        {
            return CreateManualTargetMapping_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateManualTargetMappingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new TargetMapping() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicAsyncResponse? CreateMongodbSource
        // GraphQL -> createMongodbSource: MosaicAsyncResponse! (type)
        public static string CreateMongodbSource_TypedFieldSpec(MosaicAsyncResponse fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createMongodbSource" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateMongodbSource_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateMongodbSource((MosaicAsyncResponse)fieldSpecObj);
        }
        public static string CreateMongodbSource(MosaicAsyncResponse fieldSpec)
        {
            return CreateMongodbSource_TypedFieldSpec(fieldSpec);
        }
        public static string CreateMongodbSource(object fieldSpecObj)
        {
            return CreateMongodbSource_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateMongodbSourceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MosaicAsyncResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateMssqlLiveMount
        // GraphQL -> createMssqlLiveMount: AsyncRequestStatus! (type)
        public static string CreateMssqlLiveMount_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createMssqlLiveMount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateMssqlLiveMount_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateMssqlLiveMount((AsyncRequestStatus)fieldSpecObj);
        }
        public static string CreateMssqlLiveMount(AsyncRequestStatus fieldSpec)
        {
            return CreateMssqlLiveMount_TypedFieldSpec(fieldSpec);
        }
        public static string CreateMssqlLiveMount(object fieldSpecObj)
        {
            return CreateMssqlLiveMount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateMssqlLiveMountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateMssqlLogShippingConfiguration
        // GraphQL -> createMssqlLogShippingConfiguration: AsyncRequestStatus! (type)
        public static string CreateMssqlLogShippingConfiguration_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createMssqlLogShippingConfiguration" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateMssqlLogShippingConfiguration_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateMssqlLogShippingConfiguration((AsyncRequestStatus)fieldSpecObj);
        }
        public static string CreateMssqlLogShippingConfiguration(AsyncRequestStatus fieldSpec)
        {
            return CreateMssqlLogShippingConfiguration_TypedFieldSpec(fieldSpec);
        }
        public static string CreateMssqlLogShippingConfiguration(object fieldSpecObj)
        {
            return CreateMssqlLogShippingConfiguration_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateMssqlLogShippingConfigurationFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateNutanixCluster
        // GraphQL -> createNutanixCluster: AsyncRequestStatus! (type)
        public static string CreateNutanixCluster_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createNutanixCluster" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateNutanixCluster_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateNutanixCluster((AsyncRequestStatus)fieldSpecObj);
        }
        public static string CreateNutanixCluster(AsyncRequestStatus fieldSpec)
        {
            return CreateNutanixCluster_TypedFieldSpec(fieldSpec);
        }
        public static string CreateNutanixCluster(object fieldSpecObj)
        {
            return CreateNutanixCluster_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateNutanixClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncRequestStatus? CreateNutanixPrismCentral
        // GraphQL -> createNutanixPrismCentral: BatchAsyncRequestStatus! (type)
        public static string CreateNutanixPrismCentral_TypedFieldSpec(BatchAsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createNutanixPrismCentral" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateNutanixPrismCentral_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateNutanixPrismCentral((BatchAsyncRequestStatus)fieldSpecObj);
        }
        public static string CreateNutanixPrismCentral(BatchAsyncRequestStatus fieldSpec)
        {
            return CreateNutanixPrismCentral_TypedFieldSpec(fieldSpec);
        }
        public static string CreateNutanixPrismCentral(object fieldSpecObj)
        {
            return CreateNutanixPrismCentral_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateNutanixPrismCentralFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchAsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestStatus? CreateO365AppComplete
        // GraphQL -> createO365AppComplete: RequestStatus! (type)
        public static string CreateO365AppComplete_TypedFieldSpec(RequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createO365AppComplete" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateO365AppComplete_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateO365AppComplete((RequestStatus)fieldSpecObj);
        }
        public static string CreateO365AppComplete(RequestStatus fieldSpec)
        {
            return CreateO365AppComplete_TypedFieldSpec(fieldSpec);
        }
        public static string CreateO365AppComplete(object fieldSpecObj)
        {
            return CreateO365AppComplete_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateO365AppCompleteFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateO365AppKickoffResp? CreateO365AppKickoff
        // GraphQL -> createO365AppKickoff: CreateO365AppKickoffResp! (type)
        public static string CreateO365AppKickoff_TypedFieldSpec(CreateO365AppKickoffResp fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createO365AppKickoff" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateO365AppKickoff_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateO365AppKickoff((CreateO365AppKickoffResp)fieldSpecObj);
        }
        public static string CreateO365AppKickoff(CreateO365AppKickoffResp fieldSpec)
        {
            return CreateO365AppKickoff_TypedFieldSpec(fieldSpec);
        }
        public static string CreateO365AppKickoff(object fieldSpecObj)
        {
            return CreateO365AppKickoff_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateO365AppKickoffFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateO365AppKickoffResp() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandDb2Backup
        // GraphQL -> createOnDemandDb2Backup: AsyncRequestStatus! (type)
        public static string CreateOnDemandDb2Backup_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createOnDemandDb2Backup" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateOnDemandDb2Backup_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateOnDemandDb2Backup((AsyncRequestStatus)fieldSpecObj);
        }
        public static string CreateOnDemandDb2Backup(AsyncRequestStatus fieldSpec)
        {
            return CreateOnDemandDb2Backup_TypedFieldSpec(fieldSpec);
        }
        public static string CreateOnDemandDb2Backup(object fieldSpecObj)
        {
            return CreateOnDemandDb2Backup_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateOnDemandDb2BackupFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandExchangeBackup
        // GraphQL -> createOnDemandExchangeBackup: AsyncRequestStatus! (type)
        public static string CreateOnDemandExchangeBackup_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createOnDemandExchangeBackup" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateOnDemandExchangeBackup_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateOnDemandExchangeBackup((AsyncRequestStatus)fieldSpecObj);
        }
        public static string CreateOnDemandExchangeBackup(AsyncRequestStatus fieldSpec)
        {
            return CreateOnDemandExchangeBackup_TypedFieldSpec(fieldSpec);
        }
        public static string CreateOnDemandExchangeBackup(object fieldSpecObj)
        {
            return CreateOnDemandExchangeBackup_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateOnDemandExchangeBackupFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandMssqlBackup
        // GraphQL -> createOnDemandMssqlBackup: AsyncRequestStatus! (type)
        public static string CreateOnDemandMssqlBackup_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createOnDemandMssqlBackup" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateOnDemandMssqlBackup_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateOnDemandMssqlBackup((AsyncRequestStatus)fieldSpecObj);
        }
        public static string CreateOnDemandMssqlBackup(AsyncRequestStatus fieldSpec)
        {
            return CreateOnDemandMssqlBackup_TypedFieldSpec(fieldSpec);
        }
        public static string CreateOnDemandMssqlBackup(object fieldSpecObj)
        {
            return CreateOnDemandMssqlBackup_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateOnDemandMssqlBackupFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandNutanixBackup
        // GraphQL -> createOnDemandNutanixBackup: AsyncRequestStatus! (type)
        public static string CreateOnDemandNutanixBackup_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createOnDemandNutanixBackup" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateOnDemandNutanixBackup_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateOnDemandNutanixBackup((AsyncRequestStatus)fieldSpecObj);
        }
        public static string CreateOnDemandNutanixBackup(AsyncRequestStatus fieldSpec)
        {
            return CreateOnDemandNutanixBackup_TypedFieldSpec(fieldSpec);
        }
        public static string CreateOnDemandNutanixBackup(object fieldSpecObj)
        {
            return CreateOnDemandNutanixBackup_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateOnDemandNutanixBackupFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandSapHanaBackup
        // GraphQL -> createOnDemandSapHanaBackup: AsyncRequestStatus! (type)
        public static string CreateOnDemandSapHanaBackup_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createOnDemandSapHanaBackup" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateOnDemandSapHanaBackup_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateOnDemandSapHanaBackup((AsyncRequestStatus)fieldSpecObj);
        }
        public static string CreateOnDemandSapHanaBackup(AsyncRequestStatus fieldSpec)
        {
            return CreateOnDemandSapHanaBackup_TypedFieldSpec(fieldSpec);
        }
        public static string CreateOnDemandSapHanaBackup(object fieldSpecObj)
        {
            return CreateOnDemandSapHanaBackup_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateOnDemandSapHanaBackupFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandSapHanaStorageSnapshot
        // GraphQL -> createOnDemandSapHanaStorageSnapshot: AsyncRequestStatus! (type)
        public static string CreateOnDemandSapHanaStorageSnapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createOnDemandSapHanaStorageSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateOnDemandSapHanaStorageSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateOnDemandSapHanaStorageSnapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string CreateOnDemandSapHanaStorageSnapshot(AsyncRequestStatus fieldSpec)
        {
            return CreateOnDemandSapHanaStorageSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string CreateOnDemandSapHanaStorageSnapshot(object fieldSpecObj)
        {
            return CreateOnDemandSapHanaStorageSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateOnDemandSapHanaStorageSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateOnDemandVolumeGroupBackup
        // GraphQL -> createOnDemandVolumeGroupBackup: AsyncRequestStatus! (type)
        public static string CreateOnDemandVolumeGroupBackup_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createOnDemandVolumeGroupBackup" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateOnDemandVolumeGroupBackup_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateOnDemandVolumeGroupBackup((AsyncRequestStatus)fieldSpecObj);
        }
        public static string CreateOnDemandVolumeGroupBackup(AsyncRequestStatus fieldSpec)
        {
            return CreateOnDemandVolumeGroupBackup_TypedFieldSpec(fieldSpec);
        }
        public static string CreateOnDemandVolumeGroupBackup(object fieldSpecObj)
        {
            return CreateOnDemandVolumeGroupBackup_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateOnDemandVolumeGroupBackupFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateOraclePdbRestore
        // GraphQL -> createOraclePdbRestore: AsyncRequestStatus! (type)
        public static string CreateOraclePdbRestore_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createOraclePdbRestore" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateOraclePdbRestore_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateOraclePdbRestore((AsyncRequestStatus)fieldSpecObj);
        }
        public static string CreateOraclePdbRestore(AsyncRequestStatus fieldSpec)
        {
            return CreateOraclePdbRestore_TypedFieldSpec(fieldSpec);
        }
        public static string CreateOraclePdbRestore(object fieldSpecObj)
        {
            return CreateOraclePdbRestore_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateOraclePdbRestoreFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOrgReply? CreateOrg
        // GraphQL -> createOrg: CreateOrgReply! (type)
        public static string CreateOrg_TypedFieldSpec(CreateOrgReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createOrg" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateOrg_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateOrg((CreateOrgReply)fieldSpecObj);
        }
        public static string CreateOrg(CreateOrgReply fieldSpec)
        {
            return CreateOrg_TypedFieldSpec(fieldSpec);
        }
        public static string CreateOrg(object fieldSpecObj)
        {
            return CreateOrg_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateOrgFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateOrgReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOrgSwitchSessionReply? CreateOrgSwitchSession
        // GraphQL -> createOrgSwitchSession: CreateOrgSwitchSessionReply! (type)
        public static string CreateOrgSwitchSession_TypedFieldSpec(CreateOrgSwitchSessionReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createOrgSwitchSession" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateOrgSwitchSession_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateOrgSwitchSession((CreateOrgSwitchSessionReply)fieldSpecObj);
        }
        public static string CreateOrgSwitchSession(CreateOrgSwitchSessionReply fieldSpec)
        {
            return CreateOrgSwitchSession_TypedFieldSpec(fieldSpec);
        }
        public static string CreateOrgSwitchSession(object fieldSpecObj)
        {
            return CreateOrgSwitchSession_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateOrgSwitchSessionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateOrgSwitchSessionReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ClassificationPolicyDetail? CreatePolicy
        // GraphQL -> createPolicy: ClassificationPolicyDetail! (type)
        public static string CreatePolicy_TypedFieldSpec(ClassificationPolicyDetail fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createPolicy" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreatePolicy_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreatePolicy((ClassificationPolicyDetail)fieldSpecObj);
        }
        public static string CreatePolicy(ClassificationPolicyDetail fieldSpec)
        {
            return CreatePolicy_TypedFieldSpec(fieldSpec);
        }
        public static string CreatePolicy(object fieldSpecObj)
        {
            return CreatePolicy_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreatePolicyFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ClassificationPolicyDetail() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateRcvPrivateEndpointApprovalRequestReply? CreateRcvPrivateEndpointApprovalRequest
        // GraphQL -> createRcvPrivateEndpointApprovalRequest: CreateRcvPrivateEndpointApprovalRequestReply! (type)
        public static string CreateRcvPrivateEndpointApprovalRequest_TypedFieldSpec(CreateRcvPrivateEndpointApprovalRequestReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createRcvPrivateEndpointApprovalRequest" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateRcvPrivateEndpointApprovalRequest_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateRcvPrivateEndpointApprovalRequest((CreateRcvPrivateEndpointApprovalRequestReply)fieldSpecObj);
        }
        public static string CreateRcvPrivateEndpointApprovalRequest(CreateRcvPrivateEndpointApprovalRequestReply fieldSpec)
        {
            return CreateRcvPrivateEndpointApprovalRequest_TypedFieldSpec(fieldSpec);
        }
        public static string CreateRcvPrivateEndpointApprovalRequest(object fieldSpecObj)
        {
            return CreateRcvPrivateEndpointApprovalRequest_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateRcvPrivateEndpointApprovalRequestFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateRcvPrivateEndpointApprovalRequestReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CreateSapHanaSystemRefresh
        // GraphQL -> createSapHanaSystemRefresh: AsyncRequestStatus! (type)
        public static string CreateSapHanaSystemRefresh_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createSapHanaSystemRefresh" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateSapHanaSystemRefresh_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateSapHanaSystemRefresh((AsyncRequestStatus)fieldSpecObj);
        }
        public static string CreateSapHanaSystemRefresh(AsyncRequestStatus fieldSpec)
        {
            return CreateSapHanaSystemRefresh_TypedFieldSpec(fieldSpec);
        }
        public static string CreateSapHanaSystemRefresh(object fieldSpecObj)
        {
            return CreateSapHanaSystemRefresh_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateSapHanaSystemRefreshFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateScheduledReportReply? CreateScheduledReport
        // GraphQL -> createScheduledReport: CreateScheduledReportReply! (type)
        public static string CreateScheduledReport_TypedFieldSpec(CreateScheduledReportReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createScheduledReport" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateScheduledReport_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateScheduledReport((CreateScheduledReportReply)fieldSpecObj);
        }
        public static string CreateScheduledReport(CreateScheduledReportReply fieldSpec)
        {
            return CreateScheduledReport_TypedFieldSpec(fieldSpec);
        }
        public static string CreateScheduledReport(object fieldSpecObj)
        {
            return CreateScheduledReport_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateScheduledReportFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateScheduledReportReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateServiceAccountReply? CreateServiceAccount
        // GraphQL -> createServiceAccount: CreateServiceAccountReply! (type)
        public static string CreateServiceAccount_TypedFieldSpec(CreateServiceAccountReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createServiceAccount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateServiceAccount_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateServiceAccount((CreateServiceAccountReply)fieldSpecObj);
        }
        public static string CreateServiceAccount(CreateServiceAccountReply fieldSpec)
        {
            return CreateServiceAccount_TypedFieldSpec(fieldSpec);
        }
        public static string CreateServiceAccount(object fieldSpecObj)
        {
            return CreateServiceAccount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateServiceAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateServiceAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateVappsInstantRecoveryReply? CreateVappsInstantRecovery
        // GraphQL -> createVappsInstantRecovery: CreateVappsInstantRecoveryReply! (type)
        public static string CreateVappsInstantRecovery_TypedFieldSpec(CreateVappsInstantRecoveryReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createVappsInstantRecovery" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateVappsInstantRecovery_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateVappsInstantRecovery((CreateVappsInstantRecoveryReply)fieldSpecObj);
        }
        public static string CreateVappsInstantRecovery(CreateVappsInstantRecoveryReply fieldSpec)
        {
            return CreateVappsInstantRecovery_TypedFieldSpec(fieldSpec);
        }
        public static string CreateVappsInstantRecovery(object fieldSpecObj)
        {
            return CreateVappsInstantRecovery_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateVappsInstantRecoveryFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateVappsInstantRecoveryReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateVsphereAdvancedTagReply? CreateVsphereAdvancedTag
        // GraphQL -> createVsphereAdvancedTag: CreateVsphereAdvancedTagReply! (type)
        public static string CreateVsphereAdvancedTag_TypedFieldSpec(CreateVsphereAdvancedTagReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createVsphereAdvancedTag" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateVsphereAdvancedTag_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateVsphereAdvancedTag((CreateVsphereAdvancedTagReply)fieldSpecObj);
        }
        public static string CreateVsphereAdvancedTag(CreateVsphereAdvancedTagReply fieldSpec)
        {
            return CreateVsphereAdvancedTag_TypedFieldSpec(fieldSpec);
        }
        public static string CreateVsphereAdvancedTag(object fieldSpecObj)
        {
            return CreateVsphereAdvancedTag_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateVsphereAdvancedTagFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateVsphereAdvancedTagReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateVsphereVcenterReply? CreateVsphereVcenter
        // GraphQL -> createVsphereVcenter: CreateVsphereVcenterReply! (type)
        public static string CreateVsphereVcenter_TypedFieldSpec(CreateVsphereVcenterReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createVsphereVcenter" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateVsphereVcenter_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateVsphereVcenter((CreateVsphereVcenterReply)fieldSpecObj);
        }
        public static string CreateVsphereVcenter(CreateVsphereVcenterReply fieldSpec)
        {
            return CreateVsphereVcenter_TypedFieldSpec(fieldSpec);
        }
        public static string CreateVsphereVcenter(object fieldSpecObj)
        {
            return CreateVsphereVcenter_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateVsphereVcenterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateVsphereVcenterReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateWebhookReply? CreateWebhook
        // GraphQL -> createWebhook: CreateWebhookReply! (type)
        public static string CreateWebhook_TypedFieldSpec(CreateWebhookReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "createWebhook" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string CreateWebhook_ObjectFieldSpec(object fieldSpecObj)
        {
            return CreateWebhook((CreateWebhookReply)fieldSpecObj);
        }
        public static string CreateWebhook(CreateWebhookReply fieldSpec)
        {
            return CreateWebhook_TypedFieldSpec(fieldSpec);
        }
        public static string CreateWebhook(object fieldSpecObj)
        {
            return CreateWebhook_ObjectFieldSpec(fieldSpecObj);
        }
        public static object CreateWebhookFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateWebhookReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestStatus? DeleteAdGroupsFromHierarchy
        // GraphQL -> deleteAdGroupsFromHierarchy: RequestStatus! (type)
        public static string DeleteAdGroupsFromHierarchy_TypedFieldSpec(RequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteAdGroupsFromHierarchy" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteAdGroupsFromHierarchy_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteAdGroupsFromHierarchy((RequestStatus)fieldSpecObj);
        }
        public static string DeleteAdGroupsFromHierarchy(RequestStatus fieldSpec)
        {
            return DeleteAdGroupsFromHierarchy_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteAdGroupsFromHierarchy(object fieldSpecObj)
        {
            return DeleteAdGroupsFromHierarchy_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteAdGroupsFromHierarchyFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DeleteAwsExocomputeConfigsReply? DeleteAwsExocomputeConfigs
        // GraphQL -> deleteAwsExocomputeConfigs: DeleteAwsExocomputeConfigsReply! (type)
        public static string DeleteAwsExocomputeConfigs_TypedFieldSpec(DeleteAwsExocomputeConfigsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteAwsExocomputeConfigs" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteAwsExocomputeConfigs_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteAwsExocomputeConfigs((DeleteAwsExocomputeConfigsReply)fieldSpecObj);
        }
        public static string DeleteAwsExocomputeConfigs(DeleteAwsExocomputeConfigsReply fieldSpec)
        {
            return DeleteAwsExocomputeConfigs_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteAwsExocomputeConfigs(object fieldSpecObj)
        {
            return DeleteAwsExocomputeConfigs_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteAwsExocomputeConfigsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DeleteAwsExocomputeConfigsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? DeleteAzureAdDirectory
        // GraphQL -> deleteAzureAdDirectory: CreateOnDemandJobReply! (type)
        public static string DeleteAzureAdDirectory_TypedFieldSpec(CreateOnDemandJobReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteAzureAdDirectory" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteAzureAdDirectory_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteAzureAdDirectory((CreateOnDemandJobReply)fieldSpecObj);
        }
        public static string DeleteAzureAdDirectory(CreateOnDemandJobReply fieldSpec)
        {
            return DeleteAzureAdDirectory_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteAzureAdDirectory(object fieldSpecObj)
        {
            return DeleteAzureAdDirectory_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteAzureAdDirectoryFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DeleteAzureCloudAccountReply? DeleteAzureCloudAccount
        // GraphQL -> deleteAzureCloudAccount: DeleteAzureCloudAccountReply! (type)
        public static string DeleteAzureCloudAccount_TypedFieldSpec(DeleteAzureCloudAccountReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteAzureCloudAccount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteAzureCloudAccount_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteAzureCloudAccount((DeleteAzureCloudAccountReply)fieldSpecObj);
        }
        public static string DeleteAzureCloudAccount(DeleteAzureCloudAccountReply fieldSpec)
        {
            return DeleteAzureCloudAccount_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteAzureCloudAccount(object fieldSpecObj)
        {
            return DeleteAzureCloudAccount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteAzureCloudAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DeleteAzureCloudAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DeleteAzureCloudAccountExocomputeConfigurationsReply? DeleteAzureCloudAccountExocomputeConfigurations
        // GraphQL -> deleteAzureCloudAccountExocomputeConfigurations: DeleteAzureCloudAccountExocomputeConfigurationsReply! (type)
        public static string DeleteAzureCloudAccountExocomputeConfigurations_TypedFieldSpec(DeleteAzureCloudAccountExocomputeConfigurationsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteAzureCloudAccountExocomputeConfigurations" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteAzureCloudAccountExocomputeConfigurations_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteAzureCloudAccountExocomputeConfigurations((DeleteAzureCloudAccountExocomputeConfigurationsReply)fieldSpecObj);
        }
        public static string DeleteAzureCloudAccountExocomputeConfigurations(DeleteAzureCloudAccountExocomputeConfigurationsReply fieldSpec)
        {
            return DeleteAzureCloudAccountExocomputeConfigurations_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteAzureCloudAccountExocomputeConfigurations(object fieldSpecObj)
        {
            return DeleteAzureCloudAccountExocomputeConfigurations_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteAzureCloudAccountExocomputeConfigurationsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DeleteAzureCloudAccountExocomputeConfigurationsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DeleteAzureCloudAccountWithoutOauthReply? DeleteAzureCloudAccountWithoutOauth
        // GraphQL -> deleteAzureCloudAccountWithoutOauth: DeleteAzureCloudAccountWithoutOauthReply! (type)
        public static string DeleteAzureCloudAccountWithoutOauth_TypedFieldSpec(DeleteAzureCloudAccountWithoutOauthReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteAzureCloudAccountWithoutOauth" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteAzureCloudAccountWithoutOauth_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteAzureCloudAccountWithoutOauth((DeleteAzureCloudAccountWithoutOauthReply)fieldSpecObj);
        }
        public static string DeleteAzureCloudAccountWithoutOauth(DeleteAzureCloudAccountWithoutOauthReply fieldSpec)
        {
            return DeleteAzureCloudAccountWithoutOauth_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteAzureCloudAccountWithoutOauth(object fieldSpecObj)
        {
            return DeleteAzureCloudAccountWithoutOauth_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteAzureCloudAccountWithoutOauthFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DeleteAzureCloudAccountWithoutOauthReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicAsyncResponse? DeleteCassandraSource
        // GraphQL -> deleteCassandraSource: MosaicAsyncResponse! (type)
        public static string DeleteCassandraSource_TypedFieldSpec(MosaicAsyncResponse fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteCassandraSource" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteCassandraSource_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteCassandraSource((MosaicAsyncResponse)fieldSpecObj);
        }
        public static string DeleteCassandraSource(MosaicAsyncResponse fieldSpec)
        {
            return DeleteCassandraSource_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteCassandraSource(object fieldSpecObj)
        {
            return DeleteCassandraSource_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteCassandraSourceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MosaicAsyncResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteDb2Database
        // GraphQL -> deleteDb2Database: AsyncRequestStatus! (type)
        public static string DeleteDb2Database_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteDb2Database" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteDb2Database_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteDb2Database((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DeleteDb2Database(AsyncRequestStatus fieldSpec)
        {
            return DeleteDb2Database_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteDb2Database(object fieldSpecObj)
        {
            return DeleteDb2Database_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteDb2DatabaseFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteDb2Instance
        // GraphQL -> deleteDb2Instance: AsyncRequestStatus! (type)
        public static string DeleteDb2Instance_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteDb2Instance" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteDb2Instance_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteDb2Instance((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DeleteDb2Instance(AsyncRequestStatus fieldSpec)
        {
            return DeleteDb2Instance_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteDb2Instance(object fieldSpecObj)
        {
            return DeleteDb2Instance_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteDb2InstanceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteExchangeSnapshotMount
        // GraphQL -> deleteExchangeSnapshotMount: AsyncRequestStatus! (type)
        public static string DeleteExchangeSnapshotMount_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteExchangeSnapshotMount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteExchangeSnapshotMount_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteExchangeSnapshotMount((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DeleteExchangeSnapshotMount(AsyncRequestStatus fieldSpec)
        {
            return DeleteExchangeSnapshotMount_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteExchangeSnapshotMount(object fieldSpecObj)
        {
            return DeleteExchangeSnapshotMount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteExchangeSnapshotMountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? DeleteFailoverCluster
        // GraphQL -> deleteFailoverCluster: ResponseSuccess! (type)
        public static string DeleteFailoverCluster_TypedFieldSpec(ResponseSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteFailoverCluster" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteFailoverCluster_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteFailoverCluster((ResponseSuccess)fieldSpecObj);
        }
        public static string DeleteFailoverCluster(ResponseSuccess fieldSpec)
        {
            return DeleteFailoverCluster_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteFailoverCluster(object fieldSpecObj)
        {
            return DeleteFailoverCluster_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteFailoverClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? DeleteFailoverClusterApp
        // GraphQL -> deleteFailoverClusterApp: ResponseSuccess! (type)
        public static string DeleteFailoverClusterApp_TypedFieldSpec(ResponseSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteFailoverClusterApp" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteFailoverClusterApp_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteFailoverClusterApp((ResponseSuccess)fieldSpecObj);
        }
        public static string DeleteFailoverClusterApp(ResponseSuccess fieldSpec)
        {
            return DeleteFailoverClusterApp_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteFailoverClusterApp(object fieldSpecObj)
        {
            return DeleteFailoverClusterApp_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteFailoverClusterAppFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? DeleteFilesetSnapshots
        // GraphQL -> deleteFilesetSnapshots: ResponseSuccess! (type)
        public static string DeleteFilesetSnapshots_TypedFieldSpec(ResponseSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteFilesetSnapshots" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteFilesetSnapshots_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteFilesetSnapshots((ResponseSuccess)fieldSpecObj);
        }
        public static string DeleteFilesetSnapshots(ResponseSuccess fieldSpec)
        {
            return DeleteFilesetSnapshots_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteFilesetSnapshots(object fieldSpecObj)
        {
            return DeleteFilesetSnapshots_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteFilesetSnapshotsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DeleteGlobalCertificateReply? DeleteGlobalCertificate
        // GraphQL -> deleteGlobalCertificate: DeleteGlobalCertificateReply! (type)
        public static string DeleteGlobalCertificate_TypedFieldSpec(DeleteGlobalCertificateReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteGlobalCertificate" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteGlobalCertificate_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteGlobalCertificate((DeleteGlobalCertificateReply)fieldSpecObj);
        }
        public static string DeleteGlobalCertificate(DeleteGlobalCertificateReply fieldSpec)
        {
            return DeleteGlobalCertificate_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteGlobalCertificate(object fieldSpecObj)
        {
            return DeleteGlobalCertificate_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteGlobalCertificateFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DeleteGlobalCertificateReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SlaResult? DeleteGlobalSla
        // GraphQL -> deleteGlobalSla: SlaResult! (type)
        public static string DeleteGlobalSla_TypedFieldSpec(SlaResult fieldSpec)
        {
            string args = "\n(\nid: $id\nuserNote: $userNote\n)";
            return "deleteGlobalSla" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteGlobalSla_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteGlobalSla((SlaResult)fieldSpecObj);
        }
        public static string DeleteGlobalSla(SlaResult fieldSpec)
        {
            return DeleteGlobalSla_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteGlobalSla(object fieldSpecObj)
        {
            return DeleteGlobalSla_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteGlobalSlaFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SlaResult() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? DeleteHypervVirtualMachineSnapshot
        // GraphQL -> deleteHypervVirtualMachineSnapshot: RequestSuccess! (type)
        public static string DeleteHypervVirtualMachineSnapshot_TypedFieldSpec(RequestSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteHypervVirtualMachineSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteHypervVirtualMachineSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteHypervVirtualMachineSnapshot((RequestSuccess)fieldSpecObj);
        }
        public static string DeleteHypervVirtualMachineSnapshot(RequestSuccess fieldSpec)
        {
            return DeleteHypervVirtualMachineSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteHypervVirtualMachineSnapshot(object fieldSpecObj)
        {
            return DeleteHypervVirtualMachineSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteHypervVirtualMachineSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteHypervVirtualMachineSnapshotMount
        // GraphQL -> deleteHypervVirtualMachineSnapshotMount: AsyncRequestStatus! (type)
        public static string DeleteHypervVirtualMachineSnapshotMount_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteHypervVirtualMachineSnapshotMount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteHypervVirtualMachineSnapshotMount_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteHypervVirtualMachineSnapshotMount((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DeleteHypervVirtualMachineSnapshotMount(AsyncRequestStatus fieldSpec)
        {
            return DeleteHypervVirtualMachineSnapshotMount_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteHypervVirtualMachineSnapshotMount(object fieldSpecObj)
        {
            return DeleteHypervVirtualMachineSnapshotMount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteHypervVirtualMachineSnapshotMountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteK8sCluster
        // GraphQL -> deleteK8sCluster: AsyncRequestStatus! (type)
        public static string DeleteK8sCluster_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteK8sCluster" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteK8sCluster_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteK8sCluster((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DeleteK8sCluster(AsyncRequestStatus fieldSpec)
        {
            return DeleteK8sCluster_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteK8sCluster(object fieldSpecObj)
        {
            return DeleteK8sCluster_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteK8sClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? DeleteK8sProtectionSet
        // GraphQL -> deleteK8sProtectionSet: ResponseSuccess! (type)
        public static string DeleteK8sProtectionSet_TypedFieldSpec(ResponseSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteK8sProtectionSet" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteK8sProtectionSet_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteK8sProtectionSet((ResponseSuccess)fieldSpecObj);
        }
        public static string DeleteK8sProtectionSet(ResponseSuccess fieldSpec)
        {
            return DeleteK8sProtectionSet_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteK8sProtectionSet(object fieldSpecObj)
        {
            return DeleteK8sProtectionSet_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteK8sProtectionSetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteLogShipping
        // GraphQL -> deleteLogShipping: AsyncRequestStatus! (type)
        public static string DeleteLogShipping_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteLogShipping" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteLogShipping_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteLogShipping((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DeleteLogShipping(AsyncRequestStatus fieldSpec)
        {
            return DeleteLogShipping_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteLogShipping(object fieldSpecObj)
        {
            return DeleteLogShipping_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteLogShippingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DeleteManagedVolumeReply? DeleteManagedVolume
        // GraphQL -> deleteManagedVolume: DeleteManagedVolumeReply! (type)
        public static string DeleteManagedVolume_TypedFieldSpec(DeleteManagedVolumeReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteManagedVolume" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteManagedVolume_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteManagedVolume((DeleteManagedVolumeReply)fieldSpecObj);
        }
        public static string DeleteManagedVolume(DeleteManagedVolumeReply fieldSpec)
        {
            return DeleteManagedVolume_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteManagedVolume(object fieldSpecObj)
        {
            return DeleteManagedVolume_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteManagedVolumeFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DeleteManagedVolumeReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteManagedVolumeSnapshotExport
        // GraphQL -> deleteManagedVolumeSnapshotExport: AsyncRequestStatus! (type)
        public static string DeleteManagedVolumeSnapshotExport_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteManagedVolumeSnapshotExport" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteManagedVolumeSnapshotExport_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteManagedVolumeSnapshotExport((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DeleteManagedVolumeSnapshotExport(AsyncRequestStatus fieldSpec)
        {
            return DeleteManagedVolumeSnapshotExport_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteManagedVolumeSnapshotExport(object fieldSpecObj)
        {
            return DeleteManagedVolumeSnapshotExport_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteManagedVolumeSnapshotExportFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteMongoSource
        // GraphQL -> deleteMongoSource: AsyncRequestStatus! (type)
        public static string DeleteMongoSource_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteMongoSource" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteMongoSource_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteMongoSource((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DeleteMongoSource(AsyncRequestStatus fieldSpec)
        {
            return DeleteMongoSource_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteMongoSource(object fieldSpecObj)
        {
            return DeleteMongoSource_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteMongoSourceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicAsyncResponse? DeleteMongodbSource
        // GraphQL -> deleteMongodbSource: MosaicAsyncResponse! (type)
        public static string DeleteMongodbSource_TypedFieldSpec(MosaicAsyncResponse fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteMongodbSource" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteMongodbSource_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteMongodbSource((MosaicAsyncResponse)fieldSpecObj);
        }
        public static string DeleteMongodbSource(MosaicAsyncResponse fieldSpec)
        {
            return DeleteMongodbSource_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteMongodbSource(object fieldSpecObj)
        {
            return DeleteMongodbSource_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteMongodbSourceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MosaicAsyncResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicAsyncResponse? DeleteMosaicStore
        // GraphQL -> deleteMosaicStore: MosaicAsyncResponse! (type)
        public static string DeleteMosaicStore_TypedFieldSpec(MosaicAsyncResponse fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteMosaicStore" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteMosaicStore_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteMosaicStore((MosaicAsyncResponse)fieldSpecObj);
        }
        public static string DeleteMosaicStore(MosaicAsyncResponse fieldSpec)
        {
            return DeleteMosaicStore_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteMosaicStore(object fieldSpecObj)
        {
            return DeleteMosaicStore_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteMosaicStoreFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MosaicAsyncResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? DeleteMssqlDbSnapshots
        // GraphQL -> deleteMssqlDbSnapshots: ResponseSuccess! (type)
        public static string DeleteMssqlDbSnapshots_TypedFieldSpec(ResponseSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteMssqlDbSnapshots" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteMssqlDbSnapshots_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteMssqlDbSnapshots((ResponseSuccess)fieldSpecObj);
        }
        public static string DeleteMssqlDbSnapshots(ResponseSuccess fieldSpec)
        {
            return DeleteMssqlDbSnapshots_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteMssqlDbSnapshots(object fieldSpecObj)
        {
            return DeleteMssqlDbSnapshots_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteMssqlDbSnapshotsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteMssqlLiveMount
        // GraphQL -> deleteMssqlLiveMount: AsyncRequestStatus! (type)
        public static string DeleteMssqlLiveMount_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteMssqlLiveMount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteMssqlLiveMount_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteMssqlLiveMount((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DeleteMssqlLiveMount(AsyncRequestStatus fieldSpec)
        {
            return DeleteMssqlLiveMount_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteMssqlLiveMount(object fieldSpecObj)
        {
            return DeleteMssqlLiveMount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteMssqlLiveMountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteNasSystem
        // GraphQL -> deleteNasSystem: AsyncRequestStatus! (type)
        public static string DeleteNasSystem_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteNasSystem" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteNasSystem_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteNasSystem((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DeleteNasSystem(AsyncRequestStatus fieldSpec)
        {
            return DeleteNasSystem_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteNasSystem(object fieldSpecObj)
        {
            return DeleteNasSystem_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteNasSystemFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteNutanixCluster
        // GraphQL -> deleteNutanixCluster: AsyncRequestStatus! (type)
        public static string DeleteNutanixCluster_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteNutanixCluster" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteNutanixCluster_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteNutanixCluster((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DeleteNutanixCluster(AsyncRequestStatus fieldSpec)
        {
            return DeleteNutanixCluster_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteNutanixCluster(object fieldSpecObj)
        {
            return DeleteNutanixCluster_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteNutanixClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteNutanixMountV1
        // GraphQL -> deleteNutanixMountV1: AsyncRequestStatus! (type)
        public static string DeleteNutanixMountV1_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteNutanixMountV1" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteNutanixMountV1_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteNutanixMountV1((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DeleteNutanixMountV1(AsyncRequestStatus fieldSpec)
        {
            return DeleteNutanixMountV1_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteNutanixMountV1(object fieldSpecObj)
        {
            return DeleteNutanixMountV1_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteNutanixMountV1FieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncRequestStatus? DeleteNutanixPrismCentral
        // GraphQL -> deleteNutanixPrismCentral: BatchAsyncRequestStatus! (type)
        public static string DeleteNutanixPrismCentral_TypedFieldSpec(BatchAsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteNutanixPrismCentral" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteNutanixPrismCentral_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteNutanixPrismCentral((BatchAsyncRequestStatus)fieldSpecObj);
        }
        public static string DeleteNutanixPrismCentral(BatchAsyncRequestStatus fieldSpec)
        {
            return DeleteNutanixPrismCentral_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteNutanixPrismCentral(object fieldSpecObj)
        {
            return DeleteNutanixPrismCentral_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteNutanixPrismCentralFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchAsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? DeleteNutanixSnapshot
        // GraphQL -> deleteNutanixSnapshot: RequestSuccess! (type)
        public static string DeleteNutanixSnapshot_TypedFieldSpec(RequestSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteNutanixSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteNutanixSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteNutanixSnapshot((RequestSuccess)fieldSpecObj);
        }
        public static string DeleteNutanixSnapshot(RequestSuccess fieldSpec)
        {
            return DeleteNutanixSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteNutanixSnapshot(object fieldSpecObj)
        {
            return DeleteNutanixSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteNutanixSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? DeleteNutanixSnapshots
        // GraphQL -> deleteNutanixSnapshots: RequestSuccess! (type)
        public static string DeleteNutanixSnapshots_TypedFieldSpec(RequestSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteNutanixSnapshots" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteNutanixSnapshots_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteNutanixSnapshots((RequestSuccess)fieldSpecObj);
        }
        public static string DeleteNutanixSnapshots(RequestSuccess fieldSpec)
        {
            return DeleteNutanixSnapshots_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteNutanixSnapshots(object fieldSpecObj)
        {
            return DeleteNutanixSnapshots_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteNutanixSnapshotsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestStatus? DeleteO365AzureApp
        // GraphQL -> deleteO365AzureApp: RequestStatus! (type)
        public static string DeleteO365AzureApp_TypedFieldSpec(RequestStatus fieldSpec)
        {
            string args = "\n(\no365AppClientId: $o365AppClientId\no365AppType: $o365AppType\n)";
            return "deleteO365AzureApp" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteO365AzureApp_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteO365AzureApp((RequestStatus)fieldSpecObj);
        }
        public static string DeleteO365AzureApp(RequestStatus fieldSpec)
        {
            return DeleteO365AzureApp_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteO365AzureApp(object fieldSpecObj)
        {
            return DeleteO365AzureApp_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteO365AzureAppFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? DeleteO365Org
        // GraphQL -> deleteO365Org: CreateOnDemandJobReply! (type)
        public static string DeleteO365Org_TypedFieldSpec(CreateOnDemandJobReply fieldSpec)
        {
            string args = "\n(\norgId: $orgId\n)";
            return "deleteO365Org" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteO365Org_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteO365Org((CreateOnDemandJobReply)fieldSpecObj);
        }
        public static string DeleteO365Org(CreateOnDemandJobReply fieldSpec)
        {
            return DeleteO365Org_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteO365Org(object fieldSpecObj)
        {
            return DeleteO365Org_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteO365OrgFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestStatus? DeleteO365ServiceAccount
        // GraphQL -> deleteO365ServiceAccount: RequestStatus! (type)
        public static string DeleteO365ServiceAccount_TypedFieldSpec(RequestStatus fieldSpec)
        {
            string args = "\n(\norgId: $orgId\n)";
            return "deleteO365ServiceAccount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteO365ServiceAccount_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteO365ServiceAccount((RequestStatus)fieldSpecObj);
        }
        public static string DeleteO365ServiceAccount(RequestStatus fieldSpec)
        {
            return DeleteO365ServiceAccount_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteO365ServiceAccount(object fieldSpecObj)
        {
            return DeleteO365ServiceAccount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteO365ServiceAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteOracleMount
        // GraphQL -> deleteOracleMount: AsyncRequestStatus! (type)
        public static string DeleteOracleMount_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteOracleMount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteOracleMount_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteOracleMount((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DeleteOracleMount(AsyncRequestStatus fieldSpec)
        {
            return DeleteOracleMount_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteOracleMount(object fieldSpecObj)
        {
            return DeleteOracleMount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteOracleMountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? DeleteSapHanaDbSnapshot
        // GraphQL -> deleteSapHanaDbSnapshot: ResponseSuccess! (type)
        public static string DeleteSapHanaDbSnapshot_TypedFieldSpec(ResponseSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteSapHanaDbSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteSapHanaDbSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteSapHanaDbSnapshot((ResponseSuccess)fieldSpecObj);
        }
        public static string DeleteSapHanaDbSnapshot(ResponseSuccess fieldSpec)
        {
            return DeleteSapHanaDbSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteSapHanaDbSnapshot(object fieldSpecObj)
        {
            return DeleteSapHanaDbSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteSapHanaDbSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteSapHanaSystem
        // GraphQL -> deleteSapHanaSystem: AsyncRequestStatus! (type)
        public static string DeleteSapHanaSystem_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteSapHanaSystem" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteSapHanaSystem_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteSapHanaSystem((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DeleteSapHanaSystem(AsyncRequestStatus fieldSpec)
        {
            return DeleteSapHanaSystem_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteSapHanaSystem(object fieldSpecObj)
        {
            return DeleteSapHanaSystem_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteSapHanaSystemFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? DeleteSnapshotsOfUnmanagedObjects
        // GraphQL -> deleteSnapshotsOfUnmanagedObjects: RequestSuccess! (type)
        public static string DeleteSnapshotsOfUnmanagedObjects_TypedFieldSpec(RequestSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteSnapshotsOfUnmanagedObjects" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteSnapshotsOfUnmanagedObjects_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteSnapshotsOfUnmanagedObjects((RequestSuccess)fieldSpecObj);
        }
        public static string DeleteSnapshotsOfUnmanagedObjects(RequestSuccess fieldSpec)
        {
            return DeleteSnapshotsOfUnmanagedObjects_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteSnapshotsOfUnmanagedObjects(object fieldSpecObj)
        {
            return DeleteSnapshotsOfUnmanagedObjects_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteSnapshotsOfUnmanagedObjectsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DeleteStorageArraysReply? DeleteStorageArrays
        // GraphQL -> deleteStorageArrays: DeleteStorageArraysReply! (type)
        public static string DeleteStorageArrays_TypedFieldSpec(DeleteStorageArraysReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteStorageArrays" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteStorageArrays_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteStorageArrays((DeleteStorageArraysReply)fieldSpecObj);
        }
        public static string DeleteStorageArrays(DeleteStorageArraysReply fieldSpec)
        {
            return DeleteStorageArrays_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteStorageArrays(object fieldSpecObj)
        {
            return DeleteStorageArrays_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteStorageArraysFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DeleteStorageArraysReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? DeleteUnmanagedSnapshots
        // GraphQL -> deleteUnmanagedSnapshots: RequestSuccess! (type)
        public static string DeleteUnmanagedSnapshots_TypedFieldSpec(RequestSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteUnmanagedSnapshots" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteUnmanagedSnapshots_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteUnmanagedSnapshots((RequestSuccess)fieldSpecObj);
        }
        public static string DeleteUnmanagedSnapshots(RequestSuccess fieldSpec)
        {
            return DeleteUnmanagedSnapshots_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteUnmanagedSnapshots(object fieldSpecObj)
        {
            return DeleteUnmanagedSnapshots_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteUnmanagedSnapshotsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteVolumeGroupMount
        // GraphQL -> deleteVolumeGroupMount: AsyncRequestStatus! (type)
        public static string DeleteVolumeGroupMount_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteVolumeGroupMount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteVolumeGroupMount_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteVolumeGroupMount((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DeleteVolumeGroupMount(AsyncRequestStatus fieldSpec)
        {
            return DeleteVolumeGroupMount_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteVolumeGroupMount(object fieldSpecObj)
        {
            return DeleteVolumeGroupMount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteVolumeGroupMountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? DeleteVsphereAdvancedTag
        // GraphQL -> deleteVsphereAdvancedTag: RequestSuccess! (type)
        public static string DeleteVsphereAdvancedTag_TypedFieldSpec(RequestSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteVsphereAdvancedTag" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteVsphereAdvancedTag_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteVsphereAdvancedTag((RequestSuccess)fieldSpecObj);
        }
        public static string DeleteVsphereAdvancedTag(RequestSuccess fieldSpec)
        {
            return DeleteVsphereAdvancedTag_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteVsphereAdvancedTag(object fieldSpecObj)
        {
            return DeleteVsphereAdvancedTag_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteVsphereAdvancedTagFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DeleteVsphereLiveMount
        // GraphQL -> deleteVsphereLiveMount: AsyncRequestStatus! (type)
        public static string DeleteVsphereLiveMount_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "deleteVsphereLiveMount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DeleteVsphereLiveMount_ObjectFieldSpec(object fieldSpecObj)
        {
            return DeleteVsphereLiveMount((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DeleteVsphereLiveMount(AsyncRequestStatus fieldSpec)
        {
            return DeleteVsphereLiveMount_TypedFieldSpec(fieldSpec);
        }
        public static string DeleteVsphereLiveMount(object fieldSpecObj)
        {
            return DeleteVsphereLiveMount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DeleteVsphereLiveMountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? DisableReplicationPause
        // GraphQL -> disableReplicationPause: ResponseSuccess! (type)
        public static string DisableReplicationPause_TypedFieldSpec(ResponseSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "disableReplicationPause" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DisableReplicationPause_ObjectFieldSpec(object fieldSpecObj)
        {
            return DisableReplicationPause((ResponseSuccess)fieldSpecObj);
        }
        public static string DisableReplicationPause(ResponseSuccess fieldSpec)
        {
            return DisableReplicationPause_TypedFieldSpec(fieldSpec);
        }
        public static string DisableReplicationPause(object fieldSpecObj)
        {
            return DisableReplicationPause_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DisableReplicationPauseFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DisableTargetReply? DisableTarget
        // GraphQL -> disableTarget: DisableTargetReply! (type)
        public static string DisableTarget_TypedFieldSpec(DisableTargetReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "disableTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DisableTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return DisableTarget((DisableTargetReply)fieldSpecObj);
        }
        public static string DisableTarget(DisableTargetReply fieldSpec)
        {
            return DisableTarget_TypedFieldSpec(fieldSpec);
        }
        public static string DisableTarget(object fieldSpecObj)
        {
            return DisableTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DisableTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DisableTargetReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DiscoverDb2Instance
        // GraphQL -> discoverDb2Instance: AsyncRequestStatus! (type)
        public static string DiscoverDb2Instance_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "discoverDb2Instance" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DiscoverDb2Instance_ObjectFieldSpec(object fieldSpecObj)
        {
            return DiscoverDb2Instance((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DiscoverDb2Instance(AsyncRequestStatus fieldSpec)
        {
            return DiscoverDb2Instance_TypedFieldSpec(fieldSpec);
        }
        public static string DiscoverDb2Instance(object fieldSpecObj)
        {
            return DiscoverDb2Instance_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DiscoverDb2InstanceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DiscoverMongoSource
        // GraphQL -> discoverMongoSource: AsyncRequestStatus! (type)
        public static string DiscoverMongoSource_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "discoverMongoSource" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DiscoverMongoSource_ObjectFieldSpec(object fieldSpecObj)
        {
            return DiscoverMongoSource((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DiscoverMongoSource(AsyncRequestStatus fieldSpec)
        {
            return DiscoverMongoSource_TypedFieldSpec(fieldSpec);
        }
        public static string DiscoverMongoSource(object fieldSpecObj)
        {
            return DiscoverMongoSource_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DiscoverMongoSourceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DissolveLegalHoldReply? DissolveLegalHold
        // GraphQL -> dissolveLegalHold: DissolveLegalHoldReply! (type)
        public static string DissolveLegalHold_TypedFieldSpec(DissolveLegalHoldReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "dissolveLegalHold" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DissolveLegalHold_ObjectFieldSpec(object fieldSpecObj)
        {
            return DissolveLegalHold((DissolveLegalHoldReply)fieldSpecObj);
        }
        public static string DissolveLegalHold(DissolveLegalHoldReply fieldSpec)
        {
            return DissolveLegalHold_TypedFieldSpec(fieldSpec);
        }
        public static string DissolveLegalHold(object fieldSpecObj)
        {
            return DissolveLegalHold_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DissolveLegalHoldFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DissolveLegalHoldReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadActiveDirectorySnapshotFromLocation
        // GraphQL -> downloadActiveDirectorySnapshotFromLocation: AsyncRequestStatus! (type)
        public static string DownloadActiveDirectorySnapshotFromLocation_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadActiveDirectorySnapshotFromLocation" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadActiveDirectorySnapshotFromLocation_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadActiveDirectorySnapshotFromLocation((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DownloadActiveDirectorySnapshotFromLocation(AsyncRequestStatus fieldSpec)
        {
            return DownloadActiveDirectorySnapshotFromLocation_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadActiveDirectorySnapshotFromLocation(object fieldSpecObj)
        {
            return DownloadActiveDirectorySnapshotFromLocation_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadActiveDirectorySnapshotFromLocationFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncDownloadReply? DownloadAuditLogCsvAsync
        // GraphQL -> downloadAuditLogCsvAsync: AsyncDownloadReply! (type)
        public static string DownloadAuditLogCsvAsync_TypedFieldSpec(AsyncDownloadReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadAuditLogCsvAsync" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadAuditLogCsvAsync_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadAuditLogCsvAsync((AsyncDownloadReply)fieldSpecObj);
        }
        public static string DownloadAuditLogCsvAsync(AsyncDownloadReply fieldSpec)
        {
            return DownloadAuditLogCsvAsync_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadAuditLogCsvAsync(object fieldSpecObj)
        {
            return DownloadAuditLogCsvAsync_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadAuditLogCsvAsyncFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncDownloadReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadDb2Snapshot
        // GraphQL -> downloadDb2Snapshot: AsyncRequestStatus! (type)
        public static string DownloadDb2Snapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadDb2Snapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadDb2Snapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadDb2Snapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DownloadDb2Snapshot(AsyncRequestStatus fieldSpec)
        {
            return DownloadDb2Snapshot_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadDb2Snapshot(object fieldSpecObj)
        {
            return DownloadDb2Snapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadDb2SnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadDb2SnapshotsForPointInTimeRecovery
        // GraphQL -> downloadDb2SnapshotsForPointInTimeRecovery: AsyncRequestStatus! (type)
        public static string DownloadDb2SnapshotsForPointInTimeRecovery_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadDb2SnapshotsForPointInTimeRecovery" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadDb2SnapshotsForPointInTimeRecovery_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadDb2SnapshotsForPointInTimeRecovery((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DownloadDb2SnapshotsForPointInTimeRecovery(AsyncRequestStatus fieldSpec)
        {
            return DownloadDb2SnapshotsForPointInTimeRecovery_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadDb2SnapshotsForPointInTimeRecovery(object fieldSpecObj)
        {
            return DownloadDb2SnapshotsForPointInTimeRecovery_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadDb2SnapshotsForPointInTimeRecoveryFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadExchangeSnapshot
        // GraphQL -> downloadExchangeSnapshot: AsyncRequestStatus! (type)
        public static string DownloadExchangeSnapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadExchangeSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadExchangeSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadExchangeSnapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DownloadExchangeSnapshot(AsyncRequestStatus fieldSpec)
        {
            return DownloadExchangeSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadExchangeSnapshot(object fieldSpecObj)
        {
            return DownloadExchangeSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadExchangeSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadFilesNutanixSnapshot
        // GraphQL -> downloadFilesNutanixSnapshot: AsyncRequestStatus! (type)
        public static string DownloadFilesNutanixSnapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadFilesNutanixSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadFilesNutanixSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadFilesNutanixSnapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DownloadFilesNutanixSnapshot(AsyncRequestStatus fieldSpec)
        {
            return DownloadFilesNutanixSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadFilesNutanixSnapshot(object fieldSpecObj)
        {
            return DownloadFilesNutanixSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadFilesNutanixSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadFilesetSnapshot
        // GraphQL -> downloadFilesetSnapshot: AsyncRequestStatus! (type)
        public static string DownloadFilesetSnapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadFilesetSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadFilesetSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadFilesetSnapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DownloadFilesetSnapshot(AsyncRequestStatus fieldSpec)
        {
            return DownloadFilesetSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadFilesetSnapshot(object fieldSpecObj)
        {
            return DownloadFilesetSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadFilesetSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadFilesetSnapshotFromLocation
        // GraphQL -> downloadFilesetSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string DownloadFilesetSnapshotFromLocation_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadFilesetSnapshotFromLocation" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadFilesetSnapshotFromLocation_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadFilesetSnapshotFromLocation((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DownloadFilesetSnapshotFromLocation(AsyncRequestStatus fieldSpec)
        {
            return DownloadFilesetSnapshotFromLocation_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadFilesetSnapshotFromLocation(object fieldSpecObj)
        {
            return DownloadFilesetSnapshotFromLocation_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadFilesetSnapshotFromLocationFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadHypervSnapshotFromLocation
        // GraphQL -> downloadHypervSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string DownloadHypervSnapshotFromLocation_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadHypervSnapshotFromLocation" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadHypervSnapshotFromLocation_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadHypervSnapshotFromLocation((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DownloadHypervSnapshotFromLocation(AsyncRequestStatus fieldSpec)
        {
            return DownloadHypervSnapshotFromLocation_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadHypervSnapshotFromLocation(object fieldSpecObj)
        {
            return DownloadHypervSnapshotFromLocation_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadHypervSnapshotFromLocationFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadHypervVirtualMachineLevelFiles
        // GraphQL -> downloadHypervVirtualMachineLevelFiles: AsyncRequestStatus! (type)
        public static string DownloadHypervVirtualMachineLevelFiles_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadHypervVirtualMachineLevelFiles" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadHypervVirtualMachineLevelFiles_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadHypervVirtualMachineLevelFiles((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DownloadHypervVirtualMachineLevelFiles(AsyncRequestStatus fieldSpec)
        {
            return DownloadHypervVirtualMachineLevelFiles_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadHypervVirtualMachineLevelFiles(object fieldSpecObj)
        {
            return DownloadHypervVirtualMachineLevelFiles_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadHypervVirtualMachineLevelFilesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadHypervVirtualMachineSnapshot
        // GraphQL -> downloadHypervVirtualMachineSnapshot: AsyncRequestStatus! (type)
        public static string DownloadHypervVirtualMachineSnapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadHypervVirtualMachineSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadHypervVirtualMachineSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadHypervVirtualMachineSnapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DownloadHypervVirtualMachineSnapshot(AsyncRequestStatus fieldSpec)
        {
            return DownloadHypervVirtualMachineSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadHypervVirtualMachineSnapshot(object fieldSpecObj)
        {
            return DownloadHypervVirtualMachineSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadHypervVirtualMachineSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadHypervVirtualMachineSnapshotFiles
        // GraphQL -> downloadHypervVirtualMachineSnapshotFiles: AsyncRequestStatus! (type)
        public static string DownloadHypervVirtualMachineSnapshotFiles_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadHypervVirtualMachineSnapshotFiles" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadHypervVirtualMachineSnapshotFiles_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadHypervVirtualMachineSnapshotFiles((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DownloadHypervVirtualMachineSnapshotFiles(AsyncRequestStatus fieldSpec)
        {
            return DownloadHypervVirtualMachineSnapshotFiles_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadHypervVirtualMachineSnapshotFiles(object fieldSpecObj)
        {
            return DownloadHypervVirtualMachineSnapshotFiles_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadHypervVirtualMachineSnapshotFilesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadManagedVolumeFiles
        // GraphQL -> downloadManagedVolumeFiles: AsyncRequestStatus! (type)
        public static string DownloadManagedVolumeFiles_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadManagedVolumeFiles" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadManagedVolumeFiles_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadManagedVolumeFiles((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DownloadManagedVolumeFiles(AsyncRequestStatus fieldSpec)
        {
            return DownloadManagedVolumeFiles_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadManagedVolumeFiles(object fieldSpecObj)
        {
            return DownloadManagedVolumeFiles_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadManagedVolumeFilesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadManagedVolumeFromLocation
        // GraphQL -> downloadManagedVolumeFromLocation: AsyncRequestStatus! (type)
        public static string DownloadManagedVolumeFromLocation_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadManagedVolumeFromLocation" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadManagedVolumeFromLocation_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadManagedVolumeFromLocation((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DownloadManagedVolumeFromLocation(AsyncRequestStatus fieldSpec)
        {
            return DownloadManagedVolumeFromLocation_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadManagedVolumeFromLocation(object fieldSpecObj)
        {
            return DownloadManagedVolumeFromLocation_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadManagedVolumeFromLocationFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadMssqlDatabaseBackupFiles
        // GraphQL -> downloadMssqlDatabaseBackupFiles: AsyncRequestStatus! (type)
        public static string DownloadMssqlDatabaseBackupFiles_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadMssqlDatabaseBackupFiles" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadMssqlDatabaseBackupFiles_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadMssqlDatabaseBackupFiles((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DownloadMssqlDatabaseBackupFiles(AsyncRequestStatus fieldSpec)
        {
            return DownloadMssqlDatabaseBackupFiles_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadMssqlDatabaseBackupFiles(object fieldSpecObj)
        {
            return DownloadMssqlDatabaseBackupFiles_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadMssqlDatabaseBackupFilesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadMssqlDatabaseFilesFromArchivalLocation
        // GraphQL -> downloadMssqlDatabaseFilesFromArchivalLocation: AsyncRequestStatus! (type)
        public static string DownloadMssqlDatabaseFilesFromArchivalLocation_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadMssqlDatabaseFilesFromArchivalLocation" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadMssqlDatabaseFilesFromArchivalLocation_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadMssqlDatabaseFilesFromArchivalLocation((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DownloadMssqlDatabaseFilesFromArchivalLocation(AsyncRequestStatus fieldSpec)
        {
            return DownloadMssqlDatabaseFilesFromArchivalLocation_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadMssqlDatabaseFilesFromArchivalLocation(object fieldSpecObj)
        {
            return DownloadMssqlDatabaseFilesFromArchivalLocation_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadMssqlDatabaseFilesFromArchivalLocationFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadNutanixSnapshot
        // GraphQL -> downloadNutanixSnapshot: AsyncRequestStatus! (type)
        public static string DownloadNutanixSnapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadNutanixSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadNutanixSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadNutanixSnapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DownloadNutanixSnapshot(AsyncRequestStatus fieldSpec)
        {
            return DownloadNutanixSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadNutanixSnapshot(object fieldSpecObj)
        {
            return DownloadNutanixSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadNutanixSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadNutanixVmFromLocation
        // GraphQL -> downloadNutanixVmFromLocation: AsyncRequestStatus! (type)
        public static string DownloadNutanixVmFromLocation_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadNutanixVmFromLocation" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadNutanixVmFromLocation_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadNutanixVmFromLocation((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DownloadNutanixVmFromLocation(AsyncRequestStatus fieldSpec)
        {
            return DownloadNutanixVmFromLocation_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadNutanixVmFromLocation(object fieldSpecObj)
        {
            return DownloadNutanixVmFromLocation_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadNutanixVmFromLocationFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DownloadCsvReply? DownloadObjectFilesCsv
        // GraphQL -> downloadObjectFilesCsv: DownloadCsvReply! (type)
        public static string DownloadObjectFilesCsv_TypedFieldSpec(DownloadCsvReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadObjectFilesCsv" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadObjectFilesCsv_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadObjectFilesCsv((DownloadCsvReply)fieldSpecObj);
        }
        public static string DownloadObjectFilesCsv(DownloadCsvReply fieldSpec)
        {
            return DownloadObjectFilesCsv_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadObjectFilesCsv(object fieldSpecObj)
        {
            return DownloadObjectFilesCsv_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadObjectFilesCsvFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DownloadCsvReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DownloadCsvReply? DownloadObjectsListCsv
        // GraphQL -> downloadObjectsListCsv: DownloadCsvReply! (type)
        public static string DownloadObjectsListCsv_TypedFieldSpec(DownloadCsvReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadObjectsListCsv" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadObjectsListCsv_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadObjectsListCsv((DownloadCsvReply)fieldSpecObj);
        }
        public static string DownloadObjectsListCsv(DownloadCsvReply fieldSpec)
        {
            return DownloadObjectsListCsv_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadObjectsListCsv(object fieldSpecObj)
        {
            return DownloadObjectsListCsv_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadObjectsListCsvFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DownloadCsvReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadOracleDatabaseSnapshot
        // GraphQL -> downloadOracleDatabaseSnapshot: AsyncRequestStatus! (type)
        public static string DownloadOracleDatabaseSnapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadOracleDatabaseSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadOracleDatabaseSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadOracleDatabaseSnapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DownloadOracleDatabaseSnapshot(AsyncRequestStatus fieldSpec)
        {
            return DownloadOracleDatabaseSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadOracleDatabaseSnapshot(object fieldSpecObj)
        {
            return DownloadOracleDatabaseSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadOracleDatabaseSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncDownloadReply? DownloadReportCsvAsync
        // GraphQL -> downloadReportCsvAsync: AsyncDownloadReply! (type)
        public static string DownloadReportCsvAsync_TypedFieldSpec(AsyncDownloadReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadReportCsvAsync" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadReportCsvAsync_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadReportCsvAsync((AsyncDownloadReply)fieldSpecObj);
        }
        public static string DownloadReportCsvAsync(AsyncDownloadReply fieldSpec)
        {
            return DownloadReportCsvAsync_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadReportCsvAsync(object fieldSpecObj)
        {
            return DownloadReportCsvAsync_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadReportCsvAsyncFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncDownloadReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncDownloadReply? DownloadReportPdfAsync
        // GraphQL -> downloadReportPdfAsync: AsyncDownloadReply! (type)
        public static string DownloadReportPdfAsync_TypedFieldSpec(AsyncDownloadReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadReportPdfAsync" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadReportPdfAsync_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadReportPdfAsync((AsyncDownloadReply)fieldSpecObj);
        }
        public static string DownloadReportPdfAsync(AsyncDownloadReply fieldSpec)
        {
            return DownloadReportPdfAsync_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadReportPdfAsync(object fieldSpecObj)
        {
            return DownloadReportPdfAsync_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadReportPdfAsyncFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncDownloadReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DownloadResultsCsvReply? DownloadResultsCsv
        // GraphQL -> downloadResultsCsv: DownloadResultsCsvReply! (type)
        public static string DownloadResultsCsv_TypedFieldSpec(DownloadResultsCsvReply fieldSpec)
        {
            string args = "\n(\ncrawlId: $crawlId\ndownloadFilter: $downloadFilter\n)";
            return "downloadResultsCsv" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadResultsCsv_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadResultsCsv((DownloadResultsCsvReply)fieldSpecObj);
        }
        public static string DownloadResultsCsv(DownloadResultsCsvReply fieldSpec)
        {
            return DownloadResultsCsv_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadResultsCsv(object fieldSpecObj)
        {
            return DownloadResultsCsv_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadResultsCsvFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DownloadResultsCsvReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadSapHanaSnapshot
        // GraphQL -> downloadSapHanaSnapshot: AsyncRequestStatus! (type)
        public static string DownloadSapHanaSnapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadSapHanaSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadSapHanaSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadSapHanaSnapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DownloadSapHanaSnapshot(AsyncRequestStatus fieldSpec)
        {
            return DownloadSapHanaSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadSapHanaSnapshot(object fieldSpecObj)
        {
            return DownloadSapHanaSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadSapHanaSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadSapHanaSnapshotFromLocation
        // GraphQL -> downloadSapHanaSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string DownloadSapHanaSnapshotFromLocation_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadSapHanaSnapshotFromLocation" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadSapHanaSnapshotFromLocation_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadSapHanaSnapshotFromLocation((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DownloadSapHanaSnapshotFromLocation(AsyncRequestStatus fieldSpec)
        {
            return DownloadSapHanaSnapshotFromLocation_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadSapHanaSnapshotFromLocation(object fieldSpecObj)
        {
            return DownloadSapHanaSnapshotFromLocation_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadSapHanaSnapshotFromLocationFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadSapHanaSnapshotsForPointInTimeRecovery
        // GraphQL -> downloadSapHanaSnapshotsForPointInTimeRecovery: AsyncRequestStatus! (type)
        public static string DownloadSapHanaSnapshotsForPointInTimeRecovery_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadSapHanaSnapshotsForPointInTimeRecovery" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadSapHanaSnapshotsForPointInTimeRecovery_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadSapHanaSnapshotsForPointInTimeRecovery((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DownloadSapHanaSnapshotsForPointInTimeRecovery(AsyncRequestStatus fieldSpec)
        {
            return DownloadSapHanaSnapshotsForPointInTimeRecovery_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadSapHanaSnapshotsForPointInTimeRecovery(object fieldSpecObj)
        {
            return DownloadSapHanaSnapshotsForPointInTimeRecovery_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadSapHanaSnapshotsForPointInTimeRecoveryFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DownloadCsvReply? DownloadSnapshotResultsCsv
        // GraphQL -> downloadSnapshotResultsCsv: DownloadCsvReply! (type)
        public static string DownloadSnapshotResultsCsv_TypedFieldSpec(DownloadCsvReply fieldSpec)
        {
            string args = "\n(\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\ndownloadFilter: $downloadFilter\n)";
            return "downloadSnapshotResultsCsv" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadSnapshotResultsCsv_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadSnapshotResultsCsv((DownloadCsvReply)fieldSpecObj);
        }
        public static string DownloadSnapshotResultsCsv(DownloadCsvReply fieldSpec)
        {
            return DownloadSnapshotResultsCsv_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadSnapshotResultsCsv(object fieldSpecObj)
        {
            return DownloadSnapshotResultsCsv_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadSnapshotResultsCsvFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DownloadCsvReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DownloadThreatHuntCsvReply? DownloadThreatHuntCsv
        // GraphQL -> downloadThreatHuntCsv: DownloadThreatHuntCsvReply! (type)
        public static string DownloadThreatHuntCsv_TypedFieldSpec(DownloadThreatHuntCsvReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadThreatHuntCsv" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadThreatHuntCsv_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadThreatHuntCsv((DownloadThreatHuntCsvReply)fieldSpecObj);
        }
        public static string DownloadThreatHuntCsv(DownloadThreatHuntCsvReply fieldSpec)
        {
            return DownloadThreatHuntCsv_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadThreatHuntCsv(object fieldSpecObj)
        {
            return DownloadThreatHuntCsv_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadThreatHuntCsvFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DownloadThreatHuntCsvReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DownloadCsvReply? DownloadUserActivityCsv
        // GraphQL -> downloadUserActivityCsv: DownloadCsvReply! (type)
        public static string DownloadUserActivityCsv_TypedFieldSpec(DownloadCsvReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadUserActivityCsv" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadUserActivityCsv_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadUserActivityCsv((DownloadCsvReply)fieldSpecObj);
        }
        public static string DownloadUserActivityCsv(DownloadCsvReply fieldSpec)
        {
            return DownloadUserActivityCsv_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadUserActivityCsv(object fieldSpecObj)
        {
            return DownloadUserActivityCsv_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadUserActivityCsvFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DownloadCsvReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DownloadCsvReply? DownloadUserFileActivityCsv
        // GraphQL -> downloadUserFileActivityCsv: DownloadCsvReply! (type)
        public static string DownloadUserFileActivityCsv_TypedFieldSpec(DownloadCsvReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadUserFileActivityCsv" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadUserFileActivityCsv_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadUserFileActivityCsv((DownloadCsvReply)fieldSpecObj);
        }
        public static string DownloadUserFileActivityCsv(DownloadCsvReply fieldSpec)
        {
            return DownloadUserFileActivityCsv_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadUserFileActivityCsv(object fieldSpecObj)
        {
            return DownloadUserFileActivityCsv_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadUserFileActivityCsvFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DownloadCsvReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadVolumeGroupSnapshotFiles
        // GraphQL -> downloadVolumeGroupSnapshotFiles: AsyncRequestStatus! (type)
        public static string DownloadVolumeGroupSnapshotFiles_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadVolumeGroupSnapshotFiles" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadVolumeGroupSnapshotFiles_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadVolumeGroupSnapshotFiles((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DownloadVolumeGroupSnapshotFiles(AsyncRequestStatus fieldSpec)
        {
            return DownloadVolumeGroupSnapshotFiles_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadVolumeGroupSnapshotFiles(object fieldSpecObj)
        {
            return DownloadVolumeGroupSnapshotFiles_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadVolumeGroupSnapshotFilesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadVolumeGroupSnapshotFromLocation
        // GraphQL -> downloadVolumeGroupSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string DownloadVolumeGroupSnapshotFromLocation_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadVolumeGroupSnapshotFromLocation" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadVolumeGroupSnapshotFromLocation_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadVolumeGroupSnapshotFromLocation((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DownloadVolumeGroupSnapshotFromLocation(AsyncRequestStatus fieldSpec)
        {
            return DownloadVolumeGroupSnapshotFromLocation_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadVolumeGroupSnapshotFromLocation(object fieldSpecObj)
        {
            return DownloadVolumeGroupSnapshotFromLocation_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadVolumeGroupSnapshotFromLocationFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? DownloadVsphereVirtualMachineFiles
        // GraphQL -> downloadVsphereVirtualMachineFiles: AsyncRequestStatus! (type)
        public static string DownloadVsphereVirtualMachineFiles_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "downloadVsphereVirtualMachineFiles" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string DownloadVsphereVirtualMachineFiles_ObjectFieldSpec(object fieldSpecObj)
        {
            return DownloadVsphereVirtualMachineFiles((AsyncRequestStatus)fieldSpecObj);
        }
        public static string DownloadVsphereVirtualMachineFiles(AsyncRequestStatus fieldSpec)
        {
            return DownloadVsphereVirtualMachineFiles_TypedFieldSpec(fieldSpec);
        }
        public static string DownloadVsphereVirtualMachineFiles(object fieldSpecObj)
        {
            return DownloadVsphereVirtualMachineFiles_ObjectFieldSpec(fieldSpecObj);
        }
        public static object DownloadVsphereVirtualMachineFilesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> EnableAutomaticFmdUploadReply? EnableAutomaticFmdUpload
        // GraphQL -> enableAutomaticFmdUpload: EnableAutomaticFmdUploadReply! (type)
        public static string EnableAutomaticFmdUpload_TypedFieldSpec(EnableAutomaticFmdUploadReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "enableAutomaticFmdUpload" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string EnableAutomaticFmdUpload_ObjectFieldSpec(object fieldSpecObj)
        {
            return EnableAutomaticFmdUpload((EnableAutomaticFmdUploadReply)fieldSpecObj);
        }
        public static string EnableAutomaticFmdUpload(EnableAutomaticFmdUploadReply fieldSpec)
        {
            return EnableAutomaticFmdUpload_TypedFieldSpec(fieldSpec);
        }
        public static string EnableAutomaticFmdUpload(object fieldSpecObj)
        {
            return EnableAutomaticFmdUpload_ObjectFieldSpec(fieldSpecObj);
        }
        public static object EnableAutomaticFmdUploadFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new EnableAutomaticFmdUploadReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> EnableDisableAppConsistencyReply? EnableDisableAppConsistency
        // GraphQL -> enableDisableAppConsistency: EnableDisableAppConsistencyReply! (type)
        public static string EnableDisableAppConsistency_TypedFieldSpec(EnableDisableAppConsistencyReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "enableDisableAppConsistency" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string EnableDisableAppConsistency_ObjectFieldSpec(object fieldSpecObj)
        {
            return EnableDisableAppConsistency((EnableDisableAppConsistencyReply)fieldSpecObj);
        }
        public static string EnableDisableAppConsistency(EnableDisableAppConsistencyReply fieldSpec)
        {
            return EnableDisableAppConsistency_TypedFieldSpec(fieldSpec);
        }
        public static string EnableDisableAppConsistency(object fieldSpecObj)
        {
            return EnableDisableAppConsistency_ObjectFieldSpec(fieldSpecObj);
        }
        public static object EnableDisableAppConsistencyFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new EnableDisableAppConsistencyReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestStatus? EnableO365SharePoint
        // GraphQL -> enableO365SharePoint: RequestStatus! (type)
        public static string EnableO365SharePoint_TypedFieldSpec(RequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "enableO365SharePoint" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string EnableO365SharePoint_ObjectFieldSpec(object fieldSpecObj)
        {
            return EnableO365SharePoint((RequestStatus)fieldSpecObj);
        }
        public static string EnableO365SharePoint(RequestStatus fieldSpec)
        {
            return EnableO365SharePoint_TypedFieldSpec(fieldSpec);
        }
        public static string EnableO365SharePoint(object fieldSpecObj)
        {
            return EnableO365SharePoint_ObjectFieldSpec(fieldSpecObj);
        }
        public static object EnableO365SharePointFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestStatus? EnableO365Teams
        // GraphQL -> enableO365Teams: RequestStatus! (type)
        public static string EnableO365Teams_TypedFieldSpec(RequestStatus fieldSpec)
        {
            string args = "\n(\nexocomputeClusterId: $exocomputeClusterId\n)";
            return "enableO365Teams" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string EnableO365Teams_ObjectFieldSpec(object fieldSpecObj)
        {
            return EnableO365Teams((RequestStatus)fieldSpecObj);
        }
        public static string EnableO365Teams(RequestStatus fieldSpec)
        {
            return EnableO365Teams_TypedFieldSpec(fieldSpec);
        }
        public static string EnableO365Teams(object fieldSpecObj)
        {
            return EnableO365Teams_ObjectFieldSpec(fieldSpecObj);
        }
        public static object EnableO365TeamsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? EnableReplicationPause
        // GraphQL -> enableReplicationPause: ResponseSuccess! (type)
        public static string EnableReplicationPause_TypedFieldSpec(ResponseSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "enableReplicationPause" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string EnableReplicationPause_ObjectFieldSpec(object fieldSpecObj)
        {
            return EnableReplicationPause((ResponseSuccess)fieldSpecObj);
        }
        public static string EnableReplicationPause(ResponseSuccess fieldSpec)
        {
            return EnableReplicationPause_TypedFieldSpec(fieldSpec);
        }
        public static string EnableReplicationPause(object fieldSpecObj)
        {
            return EnableReplicationPause_ObjectFieldSpec(fieldSpecObj);
        }
        public static object EnableReplicationPauseFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> EnableTargetReply? EnableTarget
        // GraphQL -> enableTarget: EnableTargetReply! (type)
        public static string EnableTarget_TypedFieldSpec(EnableTargetReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "enableTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string EnableTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return EnableTarget((EnableTargetReply)fieldSpecObj);
        }
        public static string EnableTarget(EnableTargetReply fieldSpec)
        {
            return EnableTarget_TypedFieldSpec(fieldSpec);
        }
        public static string EnableTarget(object fieldSpecObj)
        {
            return EnableTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object EnableTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new EnableTargetReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> EndManagedVolumeSnapshotReply? EndManagedVolumeSnapshot
        // GraphQL -> endManagedVolumeSnapshot: EndManagedVolumeSnapshotReply! (type)
        public static string EndManagedVolumeSnapshot_TypedFieldSpec(EndManagedVolumeSnapshotReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "endManagedVolumeSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string EndManagedVolumeSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return EndManagedVolumeSnapshot((EndManagedVolumeSnapshotReply)fieldSpecObj);
        }
        public static string EndManagedVolumeSnapshot(EndManagedVolumeSnapshotReply fieldSpec)
        {
            return EndManagedVolumeSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string EndManagedVolumeSnapshot(object fieldSpecObj)
        {
            return EndManagedVolumeSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object EndManagedVolumeSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new EndManagedVolumeSnapshotReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? ExcludeVmDisks
        // GraphQL -> excludeVmDisks: RequestSuccess! (type)
        public static string ExcludeVmDisks_TypedFieldSpec(RequestSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "excludeVmDisks" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ExcludeVmDisks_ObjectFieldSpec(object fieldSpecObj)
        {
            return ExcludeVmDisks((RequestSuccess)fieldSpecObj);
        }
        public static string ExcludeVmDisks(RequestSuccess fieldSpec)
        {
            return ExcludeVmDisks_TypedFieldSpec(fieldSpec);
        }
        public static string ExcludeVmDisks(object fieldSpecObj)
        {
            return ExcludeVmDisks_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ExcludeVmDisksFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ExpireDownloadedDb2Snapshots
        // GraphQL -> expireDownloadedDb2Snapshots: AsyncRequestStatus! (type)
        public static string ExpireDownloadedDb2Snapshots_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "expireDownloadedDb2Snapshots" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ExpireDownloadedDb2Snapshots_ObjectFieldSpec(object fieldSpecObj)
        {
            return ExpireDownloadedDb2Snapshots((AsyncRequestStatus)fieldSpecObj);
        }
        public static string ExpireDownloadedDb2Snapshots(AsyncRequestStatus fieldSpec)
        {
            return ExpireDownloadedDb2Snapshots_TypedFieldSpec(fieldSpec);
        }
        public static string ExpireDownloadedDb2Snapshots(object fieldSpecObj)
        {
            return ExpireDownloadedDb2Snapshots_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ExpireDownloadedDb2SnapshotsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ExpireDownloadedSapHanaSnapshots
        // GraphQL -> expireDownloadedSapHanaSnapshots: AsyncRequestStatus! (type)
        public static string ExpireDownloadedSapHanaSnapshots_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "expireDownloadedSapHanaSnapshots" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ExpireDownloadedSapHanaSnapshots_ObjectFieldSpec(object fieldSpecObj)
        {
            return ExpireDownloadedSapHanaSnapshots((AsyncRequestStatus)fieldSpecObj);
        }
        public static string ExpireDownloadedSapHanaSnapshots(AsyncRequestStatus fieldSpec)
        {
            return ExpireDownloadedSapHanaSnapshots_TypedFieldSpec(fieldSpec);
        }
        public static string ExpireDownloadedSapHanaSnapshots(object fieldSpecObj)
        {
            return ExpireDownloadedSapHanaSnapshots_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ExpireDownloadedSapHanaSnapshotsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ExpireSnoozedDirectoriesReply? ExpireSnoozedDirectories
        // GraphQL -> expireSnoozedDirectories: ExpireSnoozedDirectoriesReply! (type)
        public static string ExpireSnoozedDirectories_TypedFieldSpec(ExpireSnoozedDirectoriesReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "expireSnoozedDirectories" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ExpireSnoozedDirectories_ObjectFieldSpec(object fieldSpecObj)
        {
            return ExpireSnoozedDirectories((ExpireSnoozedDirectoriesReply)fieldSpecObj);
        }
        public static string ExpireSnoozedDirectories(ExpireSnoozedDirectoriesReply fieldSpec)
        {
            return ExpireSnoozedDirectories_TypedFieldSpec(fieldSpec);
        }
        public static string ExpireSnoozedDirectories(object fieldSpecObj)
        {
            return ExpireSnoozedDirectories_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ExpireSnoozedDirectoriesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ExpireSnoozedDirectoriesReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ExportHypervVirtualMachine
        // GraphQL -> exportHypervVirtualMachine: AsyncRequestStatus! (type)
        public static string ExportHypervVirtualMachine_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "exportHypervVirtualMachine" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ExportHypervVirtualMachine_ObjectFieldSpec(object fieldSpecObj)
        {
            return ExportHypervVirtualMachine((AsyncRequestStatus)fieldSpecObj);
        }
        public static string ExportHypervVirtualMachine(AsyncRequestStatus fieldSpec)
        {
            return ExportHypervVirtualMachine_TypedFieldSpec(fieldSpec);
        }
        public static string ExportHypervVirtualMachine(object fieldSpecObj)
        {
            return ExportHypervVirtualMachine_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ExportHypervVirtualMachineFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? ExportK8sNamespace
        // GraphQL -> exportK8sNamespace: CreateOnDemandJobReply! (type)
        public static string ExportK8sNamespace_TypedFieldSpec(CreateOnDemandJobReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "exportK8sNamespace" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ExportK8sNamespace_ObjectFieldSpec(object fieldSpecObj)
        {
            return ExportK8sNamespace((CreateOnDemandJobReply)fieldSpecObj);
        }
        public static string ExportK8sNamespace(CreateOnDemandJobReply fieldSpec)
        {
            return ExportK8sNamespace_TypedFieldSpec(fieldSpec);
        }
        public static string ExportK8sNamespace(object fieldSpecObj)
        {
            return ExportK8sNamespace_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ExportK8sNamespaceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ExportK8sProtectionSetSnapshot
        // GraphQL -> exportK8sProtectionSetSnapshot: AsyncRequestStatus! (type)
        public static string ExportK8sProtectionSetSnapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "exportK8sProtectionSetSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ExportK8sProtectionSetSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return ExportK8sProtectionSetSnapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string ExportK8sProtectionSetSnapshot(AsyncRequestStatus fieldSpec)
        {
            return ExportK8sProtectionSetSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string ExportK8sProtectionSetSnapshot(object fieldSpecObj)
        {
            return ExportK8sProtectionSetSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ExportK8sProtectionSetSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ExportManagedVolumeSnapshot
        // GraphQL -> exportManagedVolumeSnapshot: AsyncRequestStatus! (type)
        public static string ExportManagedVolumeSnapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "exportManagedVolumeSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ExportManagedVolumeSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return ExportManagedVolumeSnapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string ExportManagedVolumeSnapshot(AsyncRequestStatus fieldSpec)
        {
            return ExportManagedVolumeSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string ExportManagedVolumeSnapshot(object fieldSpecObj)
        {
            return ExportManagedVolumeSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ExportManagedVolumeSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ExportMssqlDatabase
        // GraphQL -> exportMssqlDatabase: AsyncRequestStatus! (type)
        public static string ExportMssqlDatabase_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "exportMssqlDatabase" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ExportMssqlDatabase_ObjectFieldSpec(object fieldSpecObj)
        {
            return ExportMssqlDatabase((AsyncRequestStatus)fieldSpecObj);
        }
        public static string ExportMssqlDatabase(AsyncRequestStatus fieldSpec)
        {
            return ExportMssqlDatabase_TypedFieldSpec(fieldSpec);
        }
        public static string ExportMssqlDatabase(object fieldSpecObj)
        {
            return ExportMssqlDatabase_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ExportMssqlDatabaseFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ExportNutanixSnapshot
        // GraphQL -> exportNutanixSnapshot: AsyncRequestStatus! (type)
        public static string ExportNutanixSnapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "exportNutanixSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ExportNutanixSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return ExportNutanixSnapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string ExportNutanixSnapshot(AsyncRequestStatus fieldSpec)
        {
            return ExportNutanixSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string ExportNutanixSnapshot(object fieldSpecObj)
        {
            return ExportNutanixSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ExportNutanixSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? ExportO365Mailbox
        // GraphQL -> exportO365Mailbox: CreateOnDemandJobReply! (type)
        public static string ExportO365Mailbox_TypedFieldSpec(CreateOnDemandJobReply fieldSpec)
        {
            string args = "\n(\nexportConfig: $exportConfig\n)";
            return "exportO365Mailbox" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ExportO365Mailbox_ObjectFieldSpec(object fieldSpecObj)
        {
            return ExportO365Mailbox((CreateOnDemandJobReply)fieldSpecObj);
        }
        public static string ExportO365Mailbox(CreateOnDemandJobReply fieldSpec)
        {
            return ExportO365Mailbox_TypedFieldSpec(fieldSpec);
        }
        public static string ExportO365Mailbox(object fieldSpecObj)
        {
            return ExportO365Mailbox_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ExportO365MailboxFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ExportOracleDatabase
        // GraphQL -> exportOracleDatabase: AsyncRequestStatus! (type)
        public static string ExportOracleDatabase_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "exportOracleDatabase" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ExportOracleDatabase_ObjectFieldSpec(object fieldSpecObj)
        {
            return ExportOracleDatabase((AsyncRequestStatus)fieldSpecObj);
        }
        public static string ExportOracleDatabase(AsyncRequestStatus fieldSpec)
        {
            return ExportOracleDatabase_TypedFieldSpec(fieldSpec);
        }
        public static string ExportOracleDatabase(object fieldSpecObj)
        {
            return ExportOracleDatabase_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ExportOracleDatabaseFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ExportOracleTablespace
        // GraphQL -> exportOracleTablespace: AsyncRequestStatus! (type)
        public static string ExportOracleTablespace_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "exportOracleTablespace" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ExportOracleTablespace_ObjectFieldSpec(object fieldSpecObj)
        {
            return ExportOracleTablespace((AsyncRequestStatus)fieldSpecObj);
        }
        public static string ExportOracleTablespace(AsyncRequestStatus fieldSpec)
        {
            return ExportOracleTablespace_TypedFieldSpec(fieldSpec);
        }
        public static string ExportOracleTablespace(object fieldSpecObj)
        {
            return ExportOracleTablespace_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ExportOracleTablespaceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ExportSlaManagedVolumeSnapshot
        // GraphQL -> exportSlaManagedVolumeSnapshot: AsyncRequestStatus! (type)
        public static string ExportSlaManagedVolumeSnapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "exportSlaManagedVolumeSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ExportSlaManagedVolumeSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return ExportSlaManagedVolumeSnapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string ExportSlaManagedVolumeSnapshot(AsyncRequestStatus fieldSpec)
        {
            return ExportSlaManagedVolumeSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string ExportSlaManagedVolumeSnapshot(object fieldSpecObj)
        {
            return ExportSlaManagedVolumeSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ExportSlaManagedVolumeSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? FilesetDownloadSnapshotFiles
        // GraphQL -> filesetDownloadSnapshotFiles: AsyncRequestStatus! (type)
        public static string FilesetDownloadSnapshotFiles_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "filesetDownloadSnapshotFiles" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string FilesetDownloadSnapshotFiles_ObjectFieldSpec(object fieldSpecObj)
        {
            return FilesetDownloadSnapshotFiles((AsyncRequestStatus)fieldSpecObj);
        }
        public static string FilesetDownloadSnapshotFiles(AsyncRequestStatus fieldSpec)
        {
            return FilesetDownloadSnapshotFiles_TypedFieldSpec(fieldSpec);
        }
        public static string FilesetDownloadSnapshotFiles(object fieldSpecObj)
        {
            return FilesetDownloadSnapshotFiles_ObjectFieldSpec(fieldSpecObj);
        }
        public static object FilesetDownloadSnapshotFilesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? FilesetExportSnapshotFiles
        // GraphQL -> filesetExportSnapshotFiles: AsyncRequestStatus! (type)
        public static string FilesetExportSnapshotFiles_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "filesetExportSnapshotFiles" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string FilesetExportSnapshotFiles_ObjectFieldSpec(object fieldSpecObj)
        {
            return FilesetExportSnapshotFiles((AsyncRequestStatus)fieldSpecObj);
        }
        public static string FilesetExportSnapshotFiles(AsyncRequestStatus fieldSpec)
        {
            return FilesetExportSnapshotFiles_TypedFieldSpec(fieldSpec);
        }
        public static string FilesetExportSnapshotFiles(object fieldSpecObj)
        {
            return FilesetExportSnapshotFiles_ObjectFieldSpec(fieldSpecObj);
        }
        public static object FilesetExportSnapshotFilesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? FilesetRecoverFiles
        // GraphQL -> filesetRecoverFiles: AsyncRequestStatus! (type)
        public static string FilesetRecoverFiles_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "filesetRecoverFiles" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string FilesetRecoverFiles_ObjectFieldSpec(object fieldSpecObj)
        {
            return FilesetRecoverFiles((AsyncRequestStatus)fieldSpecObj);
        }
        public static string FilesetRecoverFiles(AsyncRequestStatus fieldSpec)
        {
            return FilesetRecoverFiles_TypedFieldSpec(fieldSpec);
        }
        public static string FilesetRecoverFiles(object fieldSpecObj)
        {
            return FilesetRecoverFiles_ObjectFieldSpec(fieldSpecObj);
        }
        public static object FilesetRecoverFilesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> FinalizeAwsCloudAccountDeletionReply? FinalizeAwsCloudAccountDeletion
        // GraphQL -> finalizeAwsCloudAccountDeletion: FinalizeAwsCloudAccountDeletionReply! (type)
        public static string FinalizeAwsCloudAccountDeletion_TypedFieldSpec(FinalizeAwsCloudAccountDeletionReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "finalizeAwsCloudAccountDeletion" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string FinalizeAwsCloudAccountDeletion_ObjectFieldSpec(object fieldSpecObj)
        {
            return FinalizeAwsCloudAccountDeletion((FinalizeAwsCloudAccountDeletionReply)fieldSpecObj);
        }
        public static string FinalizeAwsCloudAccountDeletion(FinalizeAwsCloudAccountDeletionReply fieldSpec)
        {
            return FinalizeAwsCloudAccountDeletion_TypedFieldSpec(fieldSpec);
        }
        public static string FinalizeAwsCloudAccountDeletion(object fieldSpecObj)
        {
            return FinalizeAwsCloudAccountDeletion_ObjectFieldSpec(fieldSpecObj);
        }
        public static object FinalizeAwsCloudAccountDeletionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new FinalizeAwsCloudAccountDeletionReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> FinalizeAwsCloudAccountProtectionReply? FinalizeAwsCloudAccountProtection
        // GraphQL -> finalizeAwsCloudAccountProtection: FinalizeAwsCloudAccountProtectionReply! (type)
        public static string FinalizeAwsCloudAccountProtection_TypedFieldSpec(FinalizeAwsCloudAccountProtectionReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "finalizeAwsCloudAccountProtection" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string FinalizeAwsCloudAccountProtection_ObjectFieldSpec(object fieldSpecObj)
        {
            return FinalizeAwsCloudAccountProtection((FinalizeAwsCloudAccountProtectionReply)fieldSpecObj);
        }
        public static string FinalizeAwsCloudAccountProtection(FinalizeAwsCloudAccountProtectionReply fieldSpec)
        {
            return FinalizeAwsCloudAccountProtection_TypedFieldSpec(fieldSpec);
        }
        public static string FinalizeAwsCloudAccountProtection(object fieldSpecObj)
        {
            return FinalizeAwsCloudAccountProtection_ObjectFieldSpec(fieldSpecObj);
        }
        public static object FinalizeAwsCloudAccountProtectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new FinalizeAwsCloudAccountProtectionReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GcpCloudAccountAddProjectsReply? GcpCloudAccountAddProjects
        // GraphQL -> gcpCloudAccountAddProjects: GcpCloudAccountAddProjectsReply! (type)
        public static string GcpCloudAccountAddProjects_TypedFieldSpec(GcpCloudAccountAddProjectsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "gcpCloudAccountAddProjects" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string GcpCloudAccountAddProjects_ObjectFieldSpec(object fieldSpecObj)
        {
            return GcpCloudAccountAddProjects((GcpCloudAccountAddProjectsReply)fieldSpecObj);
        }
        public static string GcpCloudAccountAddProjects(GcpCloudAccountAddProjectsReply fieldSpec)
        {
            return GcpCloudAccountAddProjects_TypedFieldSpec(fieldSpec);
        }
        public static string GcpCloudAccountAddProjects(object fieldSpecObj)
        {
            return GcpCloudAccountAddProjects_ObjectFieldSpec(fieldSpecObj);
        }
        public static object GcpCloudAccountAddProjectsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GcpCloudAccountAddProjectsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GcpCloudAccountDeleteProjectsReply? GcpCloudAccountDeleteProjects
        // GraphQL -> gcpCloudAccountDeleteProjects: GcpCloudAccountDeleteProjectsReply! (type)
        public static string GcpCloudAccountDeleteProjects_TypedFieldSpec(GcpCloudAccountDeleteProjectsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "gcpCloudAccountDeleteProjects" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string GcpCloudAccountDeleteProjects_ObjectFieldSpec(object fieldSpecObj)
        {
            return GcpCloudAccountDeleteProjects((GcpCloudAccountDeleteProjectsReply)fieldSpecObj);
        }
        public static string GcpCloudAccountDeleteProjects(GcpCloudAccountDeleteProjectsReply fieldSpec)
        {
            return GcpCloudAccountDeleteProjects_TypedFieldSpec(fieldSpec);
        }
        public static string GcpCloudAccountDeleteProjects(object fieldSpecObj)
        {
            return GcpCloudAccountDeleteProjects_ObjectFieldSpec(fieldSpecObj);
        }
        public static object GcpCloudAccountDeleteProjectsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GcpCloudAccountDeleteProjectsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GcpCloudAccountOauthCompleteReply? GcpCloudAccountOauthComplete
        // GraphQL -> gcpCloudAccountOauthComplete: GcpCloudAccountOauthCompleteReply! (type)
        public static string GcpCloudAccountOauthComplete_TypedFieldSpec(GcpCloudAccountOauthCompleteReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "gcpCloudAccountOauthComplete" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string GcpCloudAccountOauthComplete_ObjectFieldSpec(object fieldSpecObj)
        {
            return GcpCloudAccountOauthComplete((GcpCloudAccountOauthCompleteReply)fieldSpecObj);
        }
        public static string GcpCloudAccountOauthComplete(GcpCloudAccountOauthCompleteReply fieldSpec)
        {
            return GcpCloudAccountOauthComplete_TypedFieldSpec(fieldSpec);
        }
        public static string GcpCloudAccountOauthComplete(object fieldSpecObj)
        {
            return GcpCloudAccountOauthComplete_ObjectFieldSpec(fieldSpecObj);
        }
        public static object GcpCloudAccountOauthCompleteFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GcpCloudAccountOauthCompleteReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GcpCloudAccountOauthInitiateReply? GcpCloudAccountOauthInitiate
        // GraphQL -> gcpCloudAccountOauthInitiate: GcpCloudAccountOauthInitiateReply! (type)
        public static string GcpCloudAccountOauthInitiate_TypedFieldSpec(GcpCloudAccountOauthInitiateReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "gcpCloudAccountOauthInitiate" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string GcpCloudAccountOauthInitiate_ObjectFieldSpec(object fieldSpecObj)
        {
            return GcpCloudAccountOauthInitiate((GcpCloudAccountOauthInitiateReply)fieldSpecObj);
        }
        public static string GcpCloudAccountOauthInitiate(GcpCloudAccountOauthInitiateReply fieldSpec)
        {
            return GcpCloudAccountOauthInitiate_TypedFieldSpec(fieldSpec);
        }
        public static string GcpCloudAccountOauthInitiate(object fieldSpecObj)
        {
            return GcpCloudAccountOauthInitiate_ObjectFieldSpec(fieldSpecObj);
        }
        public static object GcpCloudAccountOauthInitiateFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GcpCloudAccountOauthInitiateReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GcpCloudAccountUpgradeProjectsReply? GcpCloudAccountUpgradeProjects
        // GraphQL -> gcpCloudAccountUpgradeProjects: GcpCloudAccountUpgradeProjectsReply! (type)
        public static string GcpCloudAccountUpgradeProjects_TypedFieldSpec(GcpCloudAccountUpgradeProjectsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "gcpCloudAccountUpgradeProjects" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string GcpCloudAccountUpgradeProjects_ObjectFieldSpec(object fieldSpecObj)
        {
            return GcpCloudAccountUpgradeProjects((GcpCloudAccountUpgradeProjectsReply)fieldSpecObj);
        }
        public static string GcpCloudAccountUpgradeProjects(GcpCloudAccountUpgradeProjectsReply fieldSpec)
        {
            return GcpCloudAccountUpgradeProjects_TypedFieldSpec(fieldSpec);
        }
        public static string GcpCloudAccountUpgradeProjects(object fieldSpecObj)
        {
            return GcpCloudAccountUpgradeProjects_ObjectFieldSpec(fieldSpecObj);
        }
        public static object GcpCloudAccountUpgradeProjectsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GcpCloudAccountUpgradeProjectsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? GcpNativeDisableProject
        // GraphQL -> gcpNativeDisableProject: AsyncJobStatus! (type)
        public static string GcpNativeDisableProject_TypedFieldSpec(AsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "gcpNativeDisableProject" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string GcpNativeDisableProject_ObjectFieldSpec(object fieldSpecObj)
        {
            return GcpNativeDisableProject((AsyncJobStatus)fieldSpecObj);
        }
        public static string GcpNativeDisableProject(AsyncJobStatus fieldSpec)
        {
            return GcpNativeDisableProject_TypedFieldSpec(fieldSpec);
        }
        public static string GcpNativeDisableProject(object fieldSpecObj)
        {
            return GcpNativeDisableProject_ObjectFieldSpec(fieldSpecObj);
        }
        public static object GcpNativeDisableProjectFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? GcpNativeExportDisk
        // GraphQL -> gcpNativeExportDisk: AsyncJobStatus! (type)
        public static string GcpNativeExportDisk_TypedFieldSpec(AsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "gcpNativeExportDisk" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string GcpNativeExportDisk_ObjectFieldSpec(object fieldSpecObj)
        {
            return GcpNativeExportDisk((AsyncJobStatus)fieldSpecObj);
        }
        public static string GcpNativeExportDisk(AsyncJobStatus fieldSpec)
        {
            return GcpNativeExportDisk_TypedFieldSpec(fieldSpec);
        }
        public static string GcpNativeExportDisk(object fieldSpecObj)
        {
            return GcpNativeExportDisk_ObjectFieldSpec(fieldSpecObj);
        }
        public static object GcpNativeExportDiskFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? GcpNativeExportGceInstance
        // GraphQL -> gcpNativeExportGceInstance: AsyncJobStatus! (type)
        public static string GcpNativeExportGceInstance_TypedFieldSpec(AsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "gcpNativeExportGceInstance" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string GcpNativeExportGceInstance_ObjectFieldSpec(object fieldSpecObj)
        {
            return GcpNativeExportGceInstance((AsyncJobStatus)fieldSpecObj);
        }
        public static string GcpNativeExportGceInstance(AsyncJobStatus fieldSpec)
        {
            return GcpNativeExportGceInstance_TypedFieldSpec(fieldSpec);
        }
        public static string GcpNativeExportGceInstance(object fieldSpecObj)
        {
            return GcpNativeExportGceInstance_ObjectFieldSpec(fieldSpecObj);
        }
        public static object GcpNativeExportGceInstanceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? GcpNativeRefreshProjects
        // GraphQL -> gcpNativeRefreshProjects: BatchAsyncJobStatus! (type)
        public static string GcpNativeRefreshProjects_TypedFieldSpec(BatchAsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "gcpNativeRefreshProjects" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string GcpNativeRefreshProjects_ObjectFieldSpec(object fieldSpecObj)
        {
            return GcpNativeRefreshProjects((BatchAsyncJobStatus)fieldSpecObj);
        }
        public static string GcpNativeRefreshProjects(BatchAsyncJobStatus fieldSpec)
        {
            return GcpNativeRefreshProjects_TypedFieldSpec(fieldSpec);
        }
        public static string GcpNativeRefreshProjects(object fieldSpecObj)
        {
            return GcpNativeRefreshProjects_ObjectFieldSpec(fieldSpecObj);
        }
        public static object GcpNativeRefreshProjectsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? GcpNativeRestoreGceInstance
        // GraphQL -> gcpNativeRestoreGceInstance: AsyncJobStatus! (type)
        public static string GcpNativeRestoreGceInstance_TypedFieldSpec(AsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "gcpNativeRestoreGceInstance" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string GcpNativeRestoreGceInstance_ObjectFieldSpec(object fieldSpecObj)
        {
            return GcpNativeRestoreGceInstance((AsyncJobStatus)fieldSpecObj);
        }
        public static string GcpNativeRestoreGceInstance(AsyncJobStatus fieldSpec)
        {
            return GcpNativeRestoreGceInstance_TypedFieldSpec(fieldSpec);
        }
        public static string GcpNativeRestoreGceInstance(object fieldSpecObj)
        {
            return GcpNativeRestoreGceInstance_ObjectFieldSpec(fieldSpecObj);
        }
        public static object GcpNativeRestoreGceInstanceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ClusterRegistrationToken? GenerateClusterRegistrationToken
        // GraphQL -> generateClusterRegistrationToken: ClusterRegistrationToken! (type)
        public static string GenerateClusterRegistrationToken_TypedFieldSpec(ClusterRegistrationToken fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "generateClusterRegistrationToken" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string GenerateClusterRegistrationToken_ObjectFieldSpec(object fieldSpecObj)
        {
            return GenerateClusterRegistrationToken((ClusterRegistrationToken)fieldSpecObj);
        }
        public static string GenerateClusterRegistrationToken(ClusterRegistrationToken fieldSpec)
        {
            return GenerateClusterRegistrationToken_TypedFieldSpec(fieldSpec);
        }
        public static string GenerateClusterRegistrationToken(object fieldSpecObj)
        {
            return GenerateClusterRegistrationToken_ObjectFieldSpec(fieldSpecObj);
        }
        public static object GenerateClusterRegistrationTokenFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ClusterRegistrationToken() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GenerateConfigProtectionRestoreFormReply? GenerateConfigProtectionRestoreForm
        // GraphQL -> generateConfigProtectionRestoreForm: GenerateConfigProtectionRestoreFormReply! (type)
        public static string GenerateConfigProtectionRestoreForm_TypedFieldSpec(GenerateConfigProtectionRestoreFormReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "generateConfigProtectionRestoreForm" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string GenerateConfigProtectionRestoreForm_ObjectFieldSpec(object fieldSpecObj)
        {
            return GenerateConfigProtectionRestoreForm((GenerateConfigProtectionRestoreFormReply)fieldSpecObj);
        }
        public static string GenerateConfigProtectionRestoreForm(GenerateConfigProtectionRestoreFormReply fieldSpec)
        {
            return GenerateConfigProtectionRestoreForm_TypedFieldSpec(fieldSpec);
        }
        public static string GenerateConfigProtectionRestoreForm(object fieldSpecObj)
        {
            return GenerateConfigProtectionRestoreForm_ObjectFieldSpec(fieldSpecObj);
        }
        public static object GenerateConfigProtectionRestoreFormFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GenerateConfigProtectionRestoreFormReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Csr? GenerateCsr
        // GraphQL -> generateCsr: Csr! (type)
        public static string GenerateCsr_TypedFieldSpec(Csr fieldSpec)
        {
            string args = "\n(\nname: $name\nhostnames: $hostnames\norganization: $organization\norganizationUnit: $organizationUnit\ncountry: $country\nstate: $state\ncity: $city\nemail: $email\nsurname: $surname\nuserId: $userId\n)";
            return "generateCsr" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string GenerateCsr_ObjectFieldSpec(object fieldSpecObj)
        {
            return GenerateCsr((Csr)fieldSpecObj);
        }
        public static string GenerateCsr(Csr fieldSpec)
        {
            return GenerateCsr_TypedFieldSpec(fieldSpec);
        }
        public static string GenerateCsr(object fieldSpecObj)
        {
            return GenerateCsr_ObjectFieldSpec(fieldSpecObj);
        }
        public static object GenerateCsrFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new Csr() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? GenerateSupportBundle
        // GraphQL -> generateSupportBundle: AsyncRequestStatus! (type)
        public static string GenerateSupportBundle_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "generateSupportBundle" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string GenerateSupportBundle_ObjectFieldSpec(object fieldSpecObj)
        {
            return GenerateSupportBundle((AsyncRequestStatus)fieldSpecObj);
        }
        public static string GenerateSupportBundle(AsyncRequestStatus fieldSpec)
        {
            return GenerateSupportBundle_TypedFieldSpec(fieldSpec);
        }
        public static string GenerateSupportBundle(object fieldSpecObj)
        {
            return GenerateSupportBundle_ObjectFieldSpec(fieldSpecObj);
        }
        public static object GenerateSupportBundleFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GenerateTotpSecretReply? GenerateTotpSecret
        // GraphQL -> generateTotpSecret: GenerateTotpSecretReply! (type)
        public static string GenerateTotpSecret_TypedFieldSpec(GenerateTotpSecretReply fieldSpec)
        {
            string args = "\n(\nuserId: $userId\n)";
            return "generateTotpSecret" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string GenerateTotpSecret_ObjectFieldSpec(object fieldSpecObj)
        {
            return GenerateTotpSecret((GenerateTotpSecretReply)fieldSpecObj);
        }
        public static string GenerateTotpSecret(GenerateTotpSecretReply fieldSpec)
        {
            return GenerateTotpSecret_TypedFieldSpec(fieldSpec);
        }
        public static string GenerateTotpSecret(object fieldSpecObj)
        {
            return GenerateTotpSecret_ObjectFieldSpec(fieldSpecObj);
        }
        public static object GenerateTotpSecretFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GenerateTotpSecretReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UserDownloadUrl? GetDownloadUrl
        // GraphQL -> getDownloadUrl: UserDownloadUrl! (type)
        public static string GetDownloadUrl_TypedFieldSpec(UserDownloadUrl fieldSpec)
        {
            string args = "\n(\ndownloadId: $downloadId\n)";
            return "getDownloadUrl" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string GetDownloadUrl_ObjectFieldSpec(object fieldSpecObj)
        {
            return GetDownloadUrl((UserDownloadUrl)fieldSpecObj);
        }
        public static string GetDownloadUrl(UserDownloadUrl fieldSpec)
        {
            return GetDownloadUrl_TypedFieldSpec(fieldSpec);
        }
        public static string GetDownloadUrl(object fieldSpecObj)
        {
            return GetDownloadUrl_ObjectFieldSpec(fieldSpecObj);
        }
        public static object GetDownloadUrlFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UserDownloadUrl() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetHealthMonitorPolicyStatusReply? GetHealthMonitorPolicyStatus
        // GraphQL -> getHealthMonitorPolicyStatus: GetHealthMonitorPolicyStatusReply! (type)
        public static string GetHealthMonitorPolicyStatus_TypedFieldSpec(GetHealthMonitorPolicyStatusReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "getHealthMonitorPolicyStatus" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string GetHealthMonitorPolicyStatus_ObjectFieldSpec(object fieldSpecObj)
        {
            return GetHealthMonitorPolicyStatus((GetHealthMonitorPolicyStatusReply)fieldSpecObj);
        }
        public static string GetHealthMonitorPolicyStatus(GetHealthMonitorPolicyStatusReply fieldSpec)
        {
            return GetHealthMonitorPolicyStatus_TypedFieldSpec(fieldSpec);
        }
        public static string GetHealthMonitorPolicyStatus(object fieldSpecObj)
        {
            return GetHealthMonitorPolicyStatus_ObjectFieldSpec(fieldSpecObj);
        }
        public static object GetHealthMonitorPolicyStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetHealthMonitorPolicyStatusReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetPendingSlaAssignmentsReply? GetPendingSlaAssignments
        // GraphQL -> getPendingSlaAssignments: GetPendingSlaAssignmentsReply! (type)
        public static string GetPendingSlaAssignments_TypedFieldSpec(GetPendingSlaAssignmentsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "getPendingSlaAssignments" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string GetPendingSlaAssignments_ObjectFieldSpec(object fieldSpecObj)
        {
            return GetPendingSlaAssignments((GetPendingSlaAssignmentsReply)fieldSpecObj);
        }
        public static string GetPendingSlaAssignments(GetPendingSlaAssignmentsReply fieldSpec)
        {
            return GetPendingSlaAssignments_TypedFieldSpec(fieldSpec);
        }
        public static string GetPendingSlaAssignments(object fieldSpecObj)
        {
            return GetPendingSlaAssignments_ObjectFieldSpec(fieldSpecObj);
        }
        public static object GetPendingSlaAssignmentsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetPendingSlaAssignmentsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? HideRevealNasShares
        // GraphQL -> hideRevealNasShares: ResponseSuccess! (type)
        public static string HideRevealNasShares_TypedFieldSpec(ResponseSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "hideRevealNasShares" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string HideRevealNasShares_ObjectFieldSpec(object fieldSpecObj)
        {
            return HideRevealNasShares((ResponseSuccess)fieldSpecObj);
        }
        public static string HideRevealNasShares(ResponseSuccess fieldSpec)
        {
            return HideRevealNasShares_TypedFieldSpec(fieldSpec);
        }
        public static string HideRevealNasShares(object fieldSpecObj)
        {
            return HideRevealNasShares_ObjectFieldSpec(fieldSpecObj);
        }
        public static object HideRevealNasSharesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? HypervDeleteAllSnapshots
        // GraphQL -> hypervDeleteAllSnapshots: RequestSuccess! (type)
        public static string HypervDeleteAllSnapshots_TypedFieldSpec(RequestSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "hypervDeleteAllSnapshots" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string HypervDeleteAllSnapshots_ObjectFieldSpec(object fieldSpecObj)
        {
            return HypervDeleteAllSnapshots((RequestSuccess)fieldSpecObj);
        }
        public static string HypervDeleteAllSnapshots(RequestSuccess fieldSpec)
        {
            return HypervDeleteAllSnapshots_TypedFieldSpec(fieldSpec);
        }
        public static string HypervDeleteAllSnapshots(object fieldSpecObj)
        {
            return HypervDeleteAllSnapshots_ObjectFieldSpec(fieldSpecObj);
        }
        public static object HypervDeleteAllSnapshotsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? HypervOnDemandSnapshot
        // GraphQL -> hypervOnDemandSnapshot: AsyncRequestStatus! (type)
        public static string HypervOnDemandSnapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "hypervOnDemandSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string HypervOnDemandSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return HypervOnDemandSnapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string HypervOnDemandSnapshot(AsyncRequestStatus fieldSpec)
        {
            return HypervOnDemandSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string HypervOnDemandSnapshot(object fieldSpecObj)
        {
            return HypervOnDemandSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object HypervOnDemandSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? HypervScvmmDelete
        // GraphQL -> hypervScvmmDelete: ResponseSuccess! (type)
        public static string HypervScvmmDelete_TypedFieldSpec(ResponseSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "hypervScvmmDelete" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string HypervScvmmDelete_ObjectFieldSpec(object fieldSpecObj)
        {
            return HypervScvmmDelete((ResponseSuccess)fieldSpecObj);
        }
        public static string HypervScvmmDelete(ResponseSuccess fieldSpec)
        {
            return HypervScvmmDelete_TypedFieldSpec(fieldSpec);
        }
        public static string HypervScvmmDelete(object fieldSpecObj)
        {
            return HypervScvmmDelete_ObjectFieldSpec(fieldSpecObj);
        }
        public static object HypervScvmmDeleteFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HypervScvmmUpdateReply? HypervScvmmUpdate
        // GraphQL -> hypervScvmmUpdate: HypervScvmmUpdateReply! (type)
        public static string HypervScvmmUpdate_TypedFieldSpec(HypervScvmmUpdateReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "hypervScvmmUpdate" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string HypervScvmmUpdate_ObjectFieldSpec(object fieldSpecObj)
        {
            return HypervScvmmUpdate((HypervScvmmUpdateReply)fieldSpecObj);
        }
        public static string HypervScvmmUpdate(HypervScvmmUpdateReply fieldSpec)
        {
            return HypervScvmmUpdate_TypedFieldSpec(fieldSpec);
        }
        public static string HypervScvmmUpdate(object fieldSpecObj)
        {
            return HypervScvmmUpdate_ObjectFieldSpec(fieldSpecObj);
        }
        public static object HypervScvmmUpdateFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new HypervScvmmUpdateReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? InplaceExportHypervVirtualMachine
        // GraphQL -> inplaceExportHypervVirtualMachine: AsyncRequestStatus! (type)
        public static string InplaceExportHypervVirtualMachine_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "inplaceExportHypervVirtualMachine" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string InplaceExportHypervVirtualMachine_ObjectFieldSpec(object fieldSpecObj)
        {
            return InplaceExportHypervVirtualMachine((AsyncRequestStatus)fieldSpecObj);
        }
        public static string InplaceExportHypervVirtualMachine(AsyncRequestStatus fieldSpec)
        {
            return InplaceExportHypervVirtualMachine_TypedFieldSpec(fieldSpec);
        }
        public static string InplaceExportHypervVirtualMachine(object fieldSpecObj)
        {
            return InplaceExportHypervVirtualMachine_ObjectFieldSpec(fieldSpecObj);
        }
        public static object InplaceExportHypervVirtualMachineFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestStatus? InsertCustomerO365App
        // GraphQL -> insertCustomerO365App: RequestStatus! (type)
        public static string InsertCustomerO365App_TypedFieldSpec(RequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "insertCustomerO365App" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string InsertCustomerO365App_ObjectFieldSpec(object fieldSpecObj)
        {
            return InsertCustomerO365App((RequestStatus)fieldSpecObj);
        }
        public static string InsertCustomerO365App(RequestStatus fieldSpec)
        {
            return InsertCustomerO365App_TypedFieldSpec(fieldSpec);
        }
        public static string InsertCustomerO365App(object fieldSpecObj)
        {
            return InsertCustomerO365App_ObjectFieldSpec(fieldSpecObj);
        }
        public static object InsertCustomerO365AppFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? InstallIoFilter
        // GraphQL -> installIoFilter: RequestSuccess! (type)
        public static string InstallIoFilter_TypedFieldSpec(RequestSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "installIoFilter" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string InstallIoFilter_ObjectFieldSpec(object fieldSpecObj)
        {
            return InstallIoFilter((RequestSuccess)fieldSpecObj);
        }
        public static string InstallIoFilter(RequestSuccess fieldSpec)
        {
            return InstallIoFilter_TypedFieldSpec(fieldSpec);
        }
        public static string InstallIoFilter(object fieldSpecObj)
        {
            return InstallIoFilter_ObjectFieldSpec(fieldSpecObj);
        }
        public static object InstallIoFilterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? InstantRecoverHypervVirtualMachineSnapshot
        // GraphQL -> instantRecoverHypervVirtualMachineSnapshot: AsyncRequestStatus! (type)
        public static string InstantRecoverHypervVirtualMachineSnapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "instantRecoverHypervVirtualMachineSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string InstantRecoverHypervVirtualMachineSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return InstantRecoverHypervVirtualMachineSnapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string InstantRecoverHypervVirtualMachineSnapshot(AsyncRequestStatus fieldSpec)
        {
            return InstantRecoverHypervVirtualMachineSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string InstantRecoverHypervVirtualMachineSnapshot(object fieldSpecObj)
        {
            return InstantRecoverHypervVirtualMachineSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object InstantRecoverHypervVirtualMachineSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? InstantRecoverOracleSnapshot
        // GraphQL -> instantRecoverOracleSnapshot: AsyncRequestStatus! (type)
        public static string InstantRecoverOracleSnapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "instantRecoverOracleSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string InstantRecoverOracleSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return InstantRecoverOracleSnapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string InstantRecoverOracleSnapshot(AsyncRequestStatus fieldSpec)
        {
            return InstantRecoverOracleSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string InstantRecoverOracleSnapshot(object fieldSpecObj)
        {
            return InstantRecoverOracleSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object InstantRecoverOracleSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ListCidrsForComputeSettingReply? ListCidrsForComputeSetting
        // GraphQL -> listCidrsForComputeSetting: ListCidrsForComputeSettingReply! (type)
        public static string ListCidrsForComputeSetting_TypedFieldSpec(ListCidrsForComputeSettingReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "listCidrsForComputeSetting" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ListCidrsForComputeSetting_ObjectFieldSpec(object fieldSpecObj)
        {
            return ListCidrsForComputeSetting((ListCidrsForComputeSettingReply)fieldSpecObj);
        }
        public static string ListCidrsForComputeSetting(ListCidrsForComputeSettingReply fieldSpec)
        {
            return ListCidrsForComputeSetting_TypedFieldSpec(fieldSpec);
        }
        public static string ListCidrsForComputeSetting(object fieldSpecObj)
        {
            return ListCidrsForComputeSetting_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ListCidrsForComputeSettingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ListCidrsForComputeSettingReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SupportPortalLogoutReply? LogoutFromRubrikSupportPortal
        // GraphQL -> logoutFromRubrikSupportPortal: SupportPortalLogoutReply! (type)
        public static string LogoutFromRubrikSupportPortal_TypedFieldSpec(SupportPortalLogoutReply fieldSpec)
        {
            string args = "";
            return "logoutFromRubrikSupportPortal" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string LogoutFromRubrikSupportPortal_ObjectFieldSpec(object fieldSpecObj)
        {
            return LogoutFromRubrikSupportPortal((SupportPortalLogoutReply)fieldSpecObj);
        }
        public static string LogoutFromRubrikSupportPortal(SupportPortalLogoutReply fieldSpec)
        {
            return LogoutFromRubrikSupportPortal_TypedFieldSpec(fieldSpec);
        }
        public static string LogoutFromRubrikSupportPortal(object fieldSpecObj)
        {
            return LogoutFromRubrikSupportPortal_ObjectFieldSpec(fieldSpecObj);
        }
        public static object LogoutFromRubrikSupportPortalFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SupportPortalLogoutReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? MakePrimary
        // GraphQL -> makePrimary: AsyncRequestStatus! (type)
        public static string MakePrimary_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "makePrimary" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string MakePrimary_ObjectFieldSpec(object fieldSpecObj)
        {
            return MakePrimary((AsyncRequestStatus)fieldSpecObj);
        }
        public static string MakePrimary(AsyncRequestStatus fieldSpec)
        {
            return MakePrimary_TypedFieldSpec(fieldSpec);
        }
        public static string MakePrimary(object fieldSpecObj)
        {
            return MakePrimary_ObjectFieldSpec(fieldSpecObj);
        }
        public static object MakePrimaryFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MapAzureCloudAccountExocomputeSubscriptionReply? MapAzureCloudAccountExocomputeSubscription
        // GraphQL -> mapAzureCloudAccountExocomputeSubscription: MapAzureCloudAccountExocomputeSubscriptionReply! (type)
        public static string MapAzureCloudAccountExocomputeSubscription_TypedFieldSpec(MapAzureCloudAccountExocomputeSubscriptionReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "mapAzureCloudAccountExocomputeSubscription" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string MapAzureCloudAccountExocomputeSubscription_ObjectFieldSpec(object fieldSpecObj)
        {
            return MapAzureCloudAccountExocomputeSubscription((MapAzureCloudAccountExocomputeSubscriptionReply)fieldSpecObj);
        }
        public static string MapAzureCloudAccountExocomputeSubscription(MapAzureCloudAccountExocomputeSubscriptionReply fieldSpec)
        {
            return MapAzureCloudAccountExocomputeSubscription_TypedFieldSpec(fieldSpec);
        }
        public static string MapAzureCloudAccountExocomputeSubscription(object fieldSpecObj)
        {
            return MapAzureCloudAccountExocomputeSubscription_ObjectFieldSpec(fieldSpecObj);
        }
        public static object MapAzureCloudAccountExocomputeSubscriptionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MapAzureCloudAccountExocomputeSubscriptionReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MapAzureCloudAccountToPersistentStorageLocationReply? MapAzureCloudAccountToPersistentStorageLocation
        // GraphQL -> mapAzureCloudAccountToPersistentStorageLocation: MapAzureCloudAccountToPersistentStorageLocationReply! (type)
        public static string MapAzureCloudAccountToPersistentStorageLocation_TypedFieldSpec(MapAzureCloudAccountToPersistentStorageLocationReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "mapAzureCloudAccountToPersistentStorageLocation" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string MapAzureCloudAccountToPersistentStorageLocation_ObjectFieldSpec(object fieldSpecObj)
        {
            return MapAzureCloudAccountToPersistentStorageLocation((MapAzureCloudAccountToPersistentStorageLocationReply)fieldSpecObj);
        }
        public static string MapAzureCloudAccountToPersistentStorageLocation(MapAzureCloudAccountToPersistentStorageLocationReply fieldSpec)
        {
            return MapAzureCloudAccountToPersistentStorageLocation_TypedFieldSpec(fieldSpec);
        }
        public static string MapAzureCloudAccountToPersistentStorageLocation(object fieldSpecObj)
        {
            return MapAzureCloudAccountToPersistentStorageLocation_ObjectFieldSpec(fieldSpecObj);
        }
        public static object MapAzureCloudAccountToPersistentStorageLocationFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MapAzureCloudAccountToPersistentStorageLocationReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MapCloudAccountExocomputeAccountReply? MapCloudAccountExocomputeAccount
        // GraphQL -> mapCloudAccountExocomputeAccount: MapCloudAccountExocomputeAccountReply! (type)
        public static string MapCloudAccountExocomputeAccount_TypedFieldSpec(MapCloudAccountExocomputeAccountReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "mapCloudAccountExocomputeAccount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string MapCloudAccountExocomputeAccount_ObjectFieldSpec(object fieldSpecObj)
        {
            return MapCloudAccountExocomputeAccount((MapCloudAccountExocomputeAccountReply)fieldSpecObj);
        }
        public static string MapCloudAccountExocomputeAccount(MapCloudAccountExocomputeAccountReply fieldSpec)
        {
            return MapCloudAccountExocomputeAccount_TypedFieldSpec(fieldSpec);
        }
        public static string MapCloudAccountExocomputeAccount(object fieldSpecObj)
        {
            return MapCloudAccountExocomputeAccount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object MapCloudAccountExocomputeAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MapCloudAccountExocomputeAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MarkAgentSecondaryCertificateReply? MarkAgentSecondaryCertificate
        // GraphQL -> markAgentSecondaryCertificate: MarkAgentSecondaryCertificateReply! (type)
        public static string MarkAgentSecondaryCertificate_TypedFieldSpec(MarkAgentSecondaryCertificateReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "markAgentSecondaryCertificate" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string MarkAgentSecondaryCertificate_ObjectFieldSpec(object fieldSpecObj)
        {
            return MarkAgentSecondaryCertificate((MarkAgentSecondaryCertificateReply)fieldSpecObj);
        }
        public static string MarkAgentSecondaryCertificate(MarkAgentSecondaryCertificateReply fieldSpec)
        {
            return MarkAgentSecondaryCertificate_TypedFieldSpec(fieldSpec);
        }
        public static string MarkAgentSecondaryCertificate(object fieldSpecObj)
        {
            return MarkAgentSecondaryCertificate_ObjectFieldSpec(fieldSpecObj);
        }
        public static object MarkAgentSecondaryCertificateFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MarkAgentSecondaryCertificateReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? MigrateNutanixMountV1
        // GraphQL -> migrateNutanixMountV1: AsyncRequestStatus! (type)
        public static string MigrateNutanixMountV1_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "migrateNutanixMountV1" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string MigrateNutanixMountV1_ObjectFieldSpec(object fieldSpecObj)
        {
            return MigrateNutanixMountV1((AsyncRequestStatus)fieldSpecObj);
        }
        public static string MigrateNutanixMountV1(AsyncRequestStatus fieldSpec)
        {
            return MigrateNutanixMountV1_TypedFieldSpec(fieldSpec);
        }
        public static string MigrateNutanixMountV1(object fieldSpecObj)
        {
            return MigrateNutanixMountV1_ObjectFieldSpec(fieldSpecObj);
        }
        public static object MigrateNutanixMountV1FieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ModifyIpmiReply? ModifyIpmi
        // GraphQL -> modifyIpmi: ModifyIpmiReply! (type)
        public static string ModifyIpmi_TypedFieldSpec(ModifyIpmiReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "modifyIpmi" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ModifyIpmi_ObjectFieldSpec(object fieldSpecObj)
        {
            return ModifyIpmi((ModifyIpmiReply)fieldSpecObj);
        }
        public static string ModifyIpmi(ModifyIpmiReply fieldSpec)
        {
            return ModifyIpmi_TypedFieldSpec(fieldSpec);
        }
        public static string ModifyIpmi(object fieldSpecObj)
        {
            return ModifyIpmi_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ModifyIpmiFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ModifyIpmiReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MountDiskReply? MountDisk
        // GraphQL -> mountDisk: MountDiskReply! (type)
        public static string MountDisk_TypedFieldSpec(MountDiskReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "mountDisk" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string MountDisk_ObjectFieldSpec(object fieldSpecObj)
        {
            return MountDisk((MountDiskReply)fieldSpecObj);
        }
        public static string MountDisk(MountDiskReply fieldSpec)
        {
            return MountDisk_TypedFieldSpec(fieldSpec);
        }
        public static string MountDisk(object fieldSpecObj)
        {
            return MountDisk_ObjectFieldSpec(fieldSpecObj);
        }
        public static object MountDiskFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MountDiskReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? MountNutanixSnapshotV1
        // GraphQL -> mountNutanixSnapshotV1: AsyncRequestStatus! (type)
        public static string MountNutanixSnapshotV1_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "mountNutanixSnapshotV1" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string MountNutanixSnapshotV1_ObjectFieldSpec(object fieldSpecObj)
        {
            return MountNutanixSnapshotV1((AsyncRequestStatus)fieldSpecObj);
        }
        public static string MountNutanixSnapshotV1(AsyncRequestStatus fieldSpec)
        {
            return MountNutanixSnapshotV1_TypedFieldSpec(fieldSpec);
        }
        public static string MountNutanixSnapshotV1(object fieldSpecObj)
        {
            return MountNutanixSnapshotV1_ObjectFieldSpec(fieldSpecObj);
        }
        public static object MountNutanixSnapshotV1FieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? MountOracleDatabase
        // GraphQL -> mountOracleDatabase: AsyncRequestStatus! (type)
        public static string MountOracleDatabase_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "mountOracleDatabase" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string MountOracleDatabase_ObjectFieldSpec(object fieldSpecObj)
        {
            return MountOracleDatabase((AsyncRequestStatus)fieldSpecObj);
        }
        public static string MountOracleDatabase(AsyncRequestStatus fieldSpec)
        {
            return MountOracleDatabase_TypedFieldSpec(fieldSpec);
        }
        public static string MountOracleDatabase(object fieldSpecObj)
        {
            return MountOracleDatabase_ObjectFieldSpec(fieldSpecObj);
        }
        public static object MountOracleDatabaseFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NotificationForGetLicenseReply? NotificationForGetLicense
        // GraphQL -> notificationForGetLicense: NotificationForGetLicenseReply! (type)
        public static string NotificationForGetLicense_TypedFieldSpec(NotificationForGetLicenseReply fieldSpec)
        {
            string args = "";
            return "notificationForGetLicense" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string NotificationForGetLicense_ObjectFieldSpec(object fieldSpecObj)
        {
            return NotificationForGetLicense((NotificationForGetLicenseReply)fieldSpecObj);
        }
        public static string NotificationForGetLicense(NotificationForGetLicenseReply fieldSpec)
        {
            return NotificationForGetLicense_TypedFieldSpec(fieldSpec);
        }
        public static string NotificationForGetLicense(object fieldSpecObj)
        {
            return NotificationForGetLicense_ObjectFieldSpec(fieldSpecObj);
        }
        public static object NotificationForGetLicenseFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NotificationForGetLicenseReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365OauthConsentCompleteReply? O365OauthConsentComplete
        // GraphQL -> o365OauthConsentComplete: O365OauthConsentCompleteReply! (type)
        public static string O365OauthConsentComplete_TypedFieldSpec(O365OauthConsentCompleteReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "o365OauthConsentComplete" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string O365OauthConsentComplete_ObjectFieldSpec(object fieldSpecObj)
        {
            return O365OauthConsentComplete((O365OauthConsentCompleteReply)fieldSpecObj);
        }
        public static string O365OauthConsentComplete(O365OauthConsentCompleteReply fieldSpec)
        {
            return O365OauthConsentComplete_TypedFieldSpec(fieldSpec);
        }
        public static string O365OauthConsentComplete(object fieldSpecObj)
        {
            return O365OauthConsentComplete_ObjectFieldSpec(fieldSpecObj);
        }
        public static object O365OauthConsentCompleteFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365OauthConsentCompleteReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365OauthConsentKickoffReply? O365OauthConsentKickoff
        // GraphQL -> o365OauthConsentKickoff: O365OauthConsentKickoffReply! (type)
        public static string O365OauthConsentKickoff_TypedFieldSpec(O365OauthConsentKickoffReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "o365OauthConsentKickoff" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string O365OauthConsentKickoff_ObjectFieldSpec(object fieldSpecObj)
        {
            return O365OauthConsentKickoff((O365OauthConsentKickoffReply)fieldSpecObj);
        }
        public static string O365OauthConsentKickoff(O365OauthConsentKickoffReply fieldSpec)
        {
            return O365OauthConsentKickoff_TypedFieldSpec(fieldSpec);
        }
        public static string O365OauthConsentKickoff(object fieldSpecObj)
        {
            return O365OauthConsentKickoff_ObjectFieldSpec(fieldSpecObj);
        }
        public static object O365OauthConsentKickoffFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365OauthConsentKickoffReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365PdlGroupsReply? O365PdlGroups
        // GraphQL -> o365PdlGroups: O365PdlGroupsReply! (type)
        public static string O365PdlGroups_TypedFieldSpec(O365PdlGroupsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "o365PdlGroups" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string O365PdlGroups_ObjectFieldSpec(object fieldSpecObj)
        {
            return O365PdlGroups((O365PdlGroupsReply)fieldSpecObj);
        }
        public static string O365PdlGroups(O365PdlGroupsReply fieldSpec)
        {
            return O365PdlGroups_TypedFieldSpec(fieldSpec);
        }
        public static string O365PdlGroups(object fieldSpecObj)
        {
            return O365PdlGroups_ObjectFieldSpec(fieldSpecObj);
        }
        public static object O365PdlGroupsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365PdlGroupsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365SaasSetupKickoffReply? O365SaaSsetupKickoff
        // GraphQL -> o365SaaSSetupKickoff: O365SaasSetupKickoffReply! (type)
        public static string O365SaaSsetupKickoff_TypedFieldSpec(O365SaasSetupKickoffReply fieldSpec)
        {
            string args = "";
            return "o365SaaSSetupKickoff" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string O365SaaSsetupKickoff_ObjectFieldSpec(object fieldSpecObj)
        {
            return O365SaaSsetupKickoff((O365SaasSetupKickoffReply)fieldSpecObj);
        }
        public static string O365SaaSsetupKickoff(O365SaasSetupKickoffReply fieldSpec)
        {
            return O365SaaSsetupKickoff_TypedFieldSpec(fieldSpec);
        }
        public static string O365SaaSsetupKickoff(object fieldSpecObj)
        {
            return O365SaaSsetupKickoff_ObjectFieldSpec(fieldSpecObj);
        }
        public static object O365SaaSsetupKickoffFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365SaasSetupKickoffReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AddO365OrgResponse? O365SaasSetupComplete
        // GraphQL -> o365SaasSetupComplete: AddO365OrgResponse! (type)
        public static string O365SaasSetupComplete_TypedFieldSpec(AddO365OrgResponse fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "o365SaasSetupComplete" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string O365SaasSetupComplete_ObjectFieldSpec(object fieldSpecObj)
        {
            return O365SaasSetupComplete((AddO365OrgResponse)fieldSpecObj);
        }
        public static string O365SaasSetupComplete(AddO365OrgResponse fieldSpec)
        {
            return O365SaasSetupComplete_TypedFieldSpec(fieldSpec);
        }
        public static string O365SaasSetupComplete(object fieldSpecObj)
        {
            return O365SaasSetupComplete_ObjectFieldSpec(fieldSpecObj);
        }
        public static object O365SaasSetupCompleteFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AddO365OrgResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365SetupKickoffResp? O365SetupKickoff
        // GraphQL -> o365SetupKickoff: O365SetupKickoffResp! (type)
        public static string O365SetupKickoff_TypedFieldSpec(O365SetupKickoffResp fieldSpec)
        {
            string args = "";
            return "o365SetupKickoff" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string O365SetupKickoff_ObjectFieldSpec(object fieldSpecObj)
        {
            return O365SetupKickoff((O365SetupKickoffResp)fieldSpecObj);
        }
        public static string O365SetupKickoff(O365SetupKickoffResp fieldSpec)
        {
            return O365SetupKickoff_TypedFieldSpec(fieldSpec);
        }
        public static string O365SetupKickoff(object fieldSpecObj)
        {
            return O365SetupKickoff_ObjectFieldSpec(fieldSpecObj);
        }
        public static object O365SetupKickoffFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365SetupKickoffResp() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PatchDb2DatabaseReply? PatchDb2Database
        // GraphQL -> patchDb2Database: PatchDb2DatabaseReply! (type)
        public static string PatchDb2Database_TypedFieldSpec(PatchDb2DatabaseReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "patchDb2Database" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string PatchDb2Database_ObjectFieldSpec(object fieldSpecObj)
        {
            return PatchDb2Database((PatchDb2DatabaseReply)fieldSpecObj);
        }
        public static string PatchDb2Database(PatchDb2DatabaseReply fieldSpec)
        {
            return PatchDb2Database_TypedFieldSpec(fieldSpec);
        }
        public static string PatchDb2Database(object fieldSpecObj)
        {
            return PatchDb2Database_ObjectFieldSpec(fieldSpecObj);
        }
        public static object PatchDb2DatabaseFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new PatchDb2DatabaseReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PatchDb2InstanceReply? PatchDb2Instance
        // GraphQL -> patchDb2Instance: PatchDb2InstanceReply! (type)
        public static string PatchDb2Instance_TypedFieldSpec(PatchDb2InstanceReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "patchDb2Instance" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string PatchDb2Instance_ObjectFieldSpec(object fieldSpecObj)
        {
            return PatchDb2Instance((PatchDb2InstanceReply)fieldSpecObj);
        }
        public static string PatchDb2Instance(PatchDb2InstanceReply fieldSpec)
        {
            return PatchDb2Instance_TypedFieldSpec(fieldSpec);
        }
        public static string PatchDb2Instance(object fieldSpecObj)
        {
            return PatchDb2Instance_ObjectFieldSpec(fieldSpecObj);
        }
        public static object PatchDb2InstanceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new PatchDb2InstanceReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? PatchMongoSource
        // GraphQL -> patchMongoSource: AsyncRequestStatus! (type)
        public static string PatchMongoSource_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "patchMongoSource" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string PatchMongoSource_ObjectFieldSpec(object fieldSpecObj)
        {
            return PatchMongoSource((AsyncRequestStatus)fieldSpecObj);
        }
        public static string PatchMongoSource(AsyncRequestStatus fieldSpec)
        {
            return PatchMongoSource_TypedFieldSpec(fieldSpec);
        }
        public static string PatchMongoSource(object fieldSpecObj)
        {
            return PatchMongoSource_ObjectFieldSpec(fieldSpecObj);
        }
        public static object PatchMongoSourceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PatchNutanixMountV1Reply? PatchNutanixMountV1
        // GraphQL -> patchNutanixMountV1: PatchNutanixMountV1Reply! (type)
        public static string PatchNutanixMountV1_TypedFieldSpec(PatchNutanixMountV1Reply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "patchNutanixMountV1" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string PatchNutanixMountV1_ObjectFieldSpec(object fieldSpecObj)
        {
            return PatchNutanixMountV1((PatchNutanixMountV1Reply)fieldSpecObj);
        }
        public static string PatchNutanixMountV1(PatchNutanixMountV1Reply fieldSpec)
        {
            return PatchNutanixMountV1_TypedFieldSpec(fieldSpec);
        }
        public static string PatchNutanixMountV1(object fieldSpecObj)
        {
            return PatchNutanixMountV1_ObjectFieldSpec(fieldSpecObj);
        }
        public static object PatchNutanixMountV1FieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new PatchNutanixMountV1Reply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PatchSapHanaSystemReply? PatchSapHanaSystem
        // GraphQL -> patchSapHanaSystem: PatchSapHanaSystemReply! (type)
        public static string PatchSapHanaSystem_TypedFieldSpec(PatchSapHanaSystemReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "patchSapHanaSystem" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string PatchSapHanaSystem_ObjectFieldSpec(object fieldSpecObj)
        {
            return PatchSapHanaSystem((PatchSapHanaSystemReply)fieldSpecObj);
        }
        public static string PatchSapHanaSystem(PatchSapHanaSystemReply fieldSpec)
        {
            return PatchSapHanaSystem_TypedFieldSpec(fieldSpec);
        }
        public static string PatchSapHanaSystem(object fieldSpecObj)
        {
            return PatchSapHanaSystem_ObjectFieldSpec(fieldSpecObj);
        }
        public static object PatchSapHanaSystemFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new PatchSapHanaSystemReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PauseSlaReply? PauseSla
        // GraphQL -> pauseSla: PauseSlaReply! (type)
        public static string PauseSla_TypedFieldSpec(PauseSlaReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "pauseSla" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string PauseSla_ObjectFieldSpec(object fieldSpecObj)
        {
            return PauseSla((PauseSlaReply)fieldSpecObj);
        }
        public static string PauseSla(PauseSlaReply fieldSpec)
        {
            return PauseSla_TypedFieldSpec(fieldSpec);
        }
        public static string PauseSla(object fieldSpecObj)
        {
            return PauseSla_ObjectFieldSpec(fieldSpecObj);
        }
        public static object PauseSlaFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new PauseSlaReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PauseTargetReply? PauseTarget
        // GraphQL -> pauseTarget: PauseTargetReply! (type)
        public static string PauseTarget_TypedFieldSpec(PauseTargetReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "pauseTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string PauseTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return PauseTarget((PauseTargetReply)fieldSpecObj);
        }
        public static string PauseTarget(PauseTargetReply fieldSpec)
        {
            return PauseTarget_TypedFieldSpec(fieldSpec);
        }
        public static string PauseTarget(object fieldSpecObj)
        {
            return PauseTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object PauseTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new PauseTargetReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PrepareAwsCloudAccountDeletionReply? PrepareAwsCloudAccountDeletion
        // GraphQL -> prepareAwsCloudAccountDeletion: PrepareAwsCloudAccountDeletionReply! (type)
        public static string PrepareAwsCloudAccountDeletion_TypedFieldSpec(PrepareAwsCloudAccountDeletionReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "prepareAwsCloudAccountDeletion" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string PrepareAwsCloudAccountDeletion_ObjectFieldSpec(object fieldSpecObj)
        {
            return PrepareAwsCloudAccountDeletion((PrepareAwsCloudAccountDeletionReply)fieldSpecObj);
        }
        public static string PrepareAwsCloudAccountDeletion(PrepareAwsCloudAccountDeletionReply fieldSpec)
        {
            return PrepareAwsCloudAccountDeletion_TypedFieldSpec(fieldSpec);
        }
        public static string PrepareAwsCloudAccountDeletion(object fieldSpecObj)
        {
            return PrepareAwsCloudAccountDeletion_ObjectFieldSpec(fieldSpecObj);
        }
        public static object PrepareAwsCloudAccountDeletionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new PrepareAwsCloudAccountDeletionReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PrepareFeatureUpdateForAwsCloudAccountReply? PrepareFeatureUpdateForAwsCloudAccount
        // GraphQL -> prepareFeatureUpdateForAwsCloudAccount: PrepareFeatureUpdateForAwsCloudAccountReply! (type)
        public static string PrepareFeatureUpdateForAwsCloudAccount_TypedFieldSpec(PrepareFeatureUpdateForAwsCloudAccountReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "prepareFeatureUpdateForAwsCloudAccount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string PrepareFeatureUpdateForAwsCloudAccount_ObjectFieldSpec(object fieldSpecObj)
        {
            return PrepareFeatureUpdateForAwsCloudAccount((PrepareFeatureUpdateForAwsCloudAccountReply)fieldSpecObj);
        }
        public static string PrepareFeatureUpdateForAwsCloudAccount(PrepareFeatureUpdateForAwsCloudAccountReply fieldSpec)
        {
            return PrepareFeatureUpdateForAwsCloudAccount_TypedFieldSpec(fieldSpec);
        }
        public static string PrepareFeatureUpdateForAwsCloudAccount(object fieldSpecObj)
        {
            return PrepareFeatureUpdateForAwsCloudAccount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object PrepareFeatureUpdateForAwsCloudAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new PrepareFeatureUpdateForAwsCloudAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PutSmbConfigurationReply? PutSmbConfiguration
        // GraphQL -> putSmbConfiguration: PutSmbConfigurationReply! (type)
        public static string PutSmbConfiguration_TypedFieldSpec(PutSmbConfigurationReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "putSmbConfiguration" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string PutSmbConfiguration_ObjectFieldSpec(object fieldSpecObj)
        {
            return PutSmbConfiguration((PutSmbConfigurationReply)fieldSpecObj);
        }
        public static string PutSmbConfiguration(PutSmbConfigurationReply fieldSpec)
        {
            return PutSmbConfiguration_TypedFieldSpec(fieldSpec);
        }
        public static string PutSmbConfiguration(object fieldSpecObj)
        {
            return PutSmbConfiguration_ObjectFieldSpec(fieldSpecObj);
        }
        public static object PutSmbConfigurationFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new PutSmbConfigurationReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicAsyncResponse? RecoverCassandraSource
        // GraphQL -> recoverCassandraSource: MosaicAsyncResponse! (type)
        public static string RecoverCassandraSource_TypedFieldSpec(MosaicAsyncResponse fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "recoverCassandraSource" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RecoverCassandraSource_ObjectFieldSpec(object fieldSpecObj)
        {
            return RecoverCassandraSource((MosaicAsyncResponse)fieldSpecObj);
        }
        public static string RecoverCassandraSource(MosaicAsyncResponse fieldSpec)
        {
            return RecoverCassandraSource_TypedFieldSpec(fieldSpec);
        }
        public static string RecoverCassandraSource(object fieldSpecObj)
        {
            return RecoverCassandraSource_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RecoverCassandraSourceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MosaicAsyncResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CcProvisionJobReply? RecoverCloudCluster
        // GraphQL -> recoverCloudCluster: CcProvisionJobReply! (type)
        public static string RecoverCloudCluster_TypedFieldSpec(CcProvisionJobReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "recoverCloudCluster" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RecoverCloudCluster_ObjectFieldSpec(object fieldSpecObj)
        {
            return RecoverCloudCluster((CcProvisionJobReply)fieldSpecObj);
        }
        public static string RecoverCloudCluster(CcProvisionJobReply fieldSpec)
        {
            return RecoverCloudCluster_TypedFieldSpec(fieldSpec);
        }
        public static string RecoverCloudCluster(object fieldSpecObj)
        {
            return RecoverCloudCluster_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RecoverCloudClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CcProvisionJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RecoverCloudDirectMultiPaths
        // GraphQL -> recoverCloudDirectMultiPaths: AsyncRequestStatus! (type)
        public static string RecoverCloudDirectMultiPaths_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "recoverCloudDirectMultiPaths" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RecoverCloudDirectMultiPaths_ObjectFieldSpec(object fieldSpecObj)
        {
            return RecoverCloudDirectMultiPaths((AsyncRequestStatus)fieldSpecObj);
        }
        public static string RecoverCloudDirectMultiPaths(AsyncRequestStatus fieldSpec)
        {
            return RecoverCloudDirectMultiPaths_TypedFieldSpec(fieldSpec);
        }
        public static string RecoverCloudDirectMultiPaths(object fieldSpecObj)
        {
            return RecoverCloudDirectMultiPaths_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RecoverCloudDirectMultiPathsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RecoverCloudDirectPath
        // GraphQL -> recoverCloudDirectPath: AsyncRequestStatus! (type)
        public static string RecoverCloudDirectPath_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "recoverCloudDirectPath" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RecoverCloudDirectPath_ObjectFieldSpec(object fieldSpecObj)
        {
            return RecoverCloudDirectPath((AsyncRequestStatus)fieldSpecObj);
        }
        public static string RecoverCloudDirectPath(AsyncRequestStatus fieldSpec)
        {
            return RecoverCloudDirectPath_TypedFieldSpec(fieldSpec);
        }
        public static string RecoverCloudDirectPath(object fieldSpecObj)
        {
            return RecoverCloudDirectPath_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RecoverCloudDirectPathFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RecoverMongoSource
        // GraphQL -> recoverMongoSource: AsyncRequestStatus! (type)
        public static string RecoverMongoSource_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "recoverMongoSource" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RecoverMongoSource_ObjectFieldSpec(object fieldSpecObj)
        {
            return RecoverMongoSource((AsyncRequestStatus)fieldSpecObj);
        }
        public static string RecoverMongoSource(AsyncRequestStatus fieldSpec)
        {
            return RecoverMongoSource_TypedFieldSpec(fieldSpec);
        }
        public static string RecoverMongoSource(object fieldSpecObj)
        {
            return RecoverMongoSource_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RecoverMongoSourceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicAsyncResponse? RecoverMongodbSource
        // GraphQL -> recoverMongodbSource: MosaicAsyncResponse! (type)
        public static string RecoverMongodbSource_TypedFieldSpec(MosaicAsyncResponse fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "recoverMongodbSource" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RecoverMongodbSource_ObjectFieldSpec(object fieldSpecObj)
        {
            return RecoverMongodbSource((MosaicAsyncResponse)fieldSpecObj);
        }
        public static string RecoverMongodbSource(MosaicAsyncResponse fieldSpec)
        {
            return RecoverMongodbSource_TypedFieldSpec(fieldSpec);
        }
        public static string RecoverMongodbSource(object fieldSpecObj)
        {
            return RecoverMongodbSource_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RecoverMongodbSourceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MosaicAsyncResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RefreshDb2Database
        // GraphQL -> refreshDb2Database: AsyncRequestStatus! (type)
        public static string RefreshDb2Database_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "refreshDb2Database" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RefreshDb2Database_ObjectFieldSpec(object fieldSpecObj)
        {
            return RefreshDb2Database((AsyncRequestStatus)fieldSpecObj);
        }
        public static string RefreshDb2Database(AsyncRequestStatus fieldSpec)
        {
            return RefreshDb2Database_TypedFieldSpec(fieldSpec);
        }
        public static string RefreshDb2Database(object fieldSpecObj)
        {
            return RefreshDb2Database_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RefreshDb2DatabaseFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RefreshDomain
        // GraphQL -> refreshDomain: AsyncRequestStatus! (type)
        public static string RefreshDomain_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "refreshDomain" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RefreshDomain_ObjectFieldSpec(object fieldSpecObj)
        {
            return RefreshDomain((AsyncRequestStatus)fieldSpecObj);
        }
        public static string RefreshDomain(AsyncRequestStatus fieldSpec)
        {
            return RefreshDomain_TypedFieldSpec(fieldSpec);
        }
        public static string RefreshDomain(object fieldSpecObj)
        {
            return RefreshDomain_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RefreshDomainFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GlobalManagerConnectivity? RefreshGlobalManagerConnectivityStatus
        // GraphQL -> refreshGlobalManagerConnectivityStatus: GlobalManagerConnectivity! (type)
        public static string RefreshGlobalManagerConnectivityStatus_TypedFieldSpec(GlobalManagerConnectivity fieldSpec)
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            return "refreshGlobalManagerConnectivityStatus" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RefreshGlobalManagerConnectivityStatus_ObjectFieldSpec(object fieldSpecObj)
        {
            return RefreshGlobalManagerConnectivityStatus((GlobalManagerConnectivity)fieldSpecObj);
        }
        public static string RefreshGlobalManagerConnectivityStatus(GlobalManagerConnectivity fieldSpec)
        {
            return RefreshGlobalManagerConnectivityStatus_TypedFieldSpec(fieldSpec);
        }
        public static string RefreshGlobalManagerConnectivityStatus(object fieldSpecObj)
        {
            return RefreshGlobalManagerConnectivityStatus_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RefreshGlobalManagerConnectivityStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GlobalManagerConnectivity() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RefreshHostReply? RefreshHost
        // GraphQL -> refreshHost: RefreshHostReply! (type)
        public static string RefreshHost_TypedFieldSpec(RefreshHostReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "refreshHost" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RefreshHost_ObjectFieldSpec(object fieldSpecObj)
        {
            return RefreshHost((RefreshHostReply)fieldSpecObj);
        }
        public static string RefreshHost(RefreshHostReply fieldSpec)
        {
            return RefreshHost_TypedFieldSpec(fieldSpec);
        }
        public static string RefreshHost(object fieldSpecObj)
        {
            return RefreshHost_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RefreshHostFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RefreshHostReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RefreshHypervScvmm
        // GraphQL -> refreshHypervScvmm: AsyncRequestStatus! (type)
        public static string RefreshHypervScvmm_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "refreshHypervScvmm" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RefreshHypervScvmm_ObjectFieldSpec(object fieldSpecObj)
        {
            return RefreshHypervScvmm((AsyncRequestStatus)fieldSpecObj);
        }
        public static string RefreshHypervScvmm(AsyncRequestStatus fieldSpec)
        {
            return RefreshHypervScvmm_TypedFieldSpec(fieldSpec);
        }
        public static string RefreshHypervScvmm(object fieldSpecObj)
        {
            return RefreshHypervScvmm_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RefreshHypervScvmmFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RefreshHypervServer
        // GraphQL -> refreshHypervServer: AsyncRequestStatus! (type)
        public static string RefreshHypervServer_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "refreshHypervServer" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RefreshHypervServer_ObjectFieldSpec(object fieldSpecObj)
        {
            return RefreshHypervServer((AsyncRequestStatus)fieldSpecObj);
        }
        public static string RefreshHypervServer(AsyncRequestStatus fieldSpec)
        {
            return RefreshHypervServer_TypedFieldSpec(fieldSpec);
        }
        public static string RefreshHypervServer(object fieldSpecObj)
        {
            return RefreshHypervServer_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RefreshHypervServerFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? RefreshK8sCluster
        // GraphQL -> refreshK8sCluster: CreateOnDemandJobReply! (type)
        public static string RefreshK8sCluster_TypedFieldSpec(CreateOnDemandJobReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "refreshK8sCluster" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RefreshK8sCluster_ObjectFieldSpec(object fieldSpecObj)
        {
            return RefreshK8sCluster((CreateOnDemandJobReply)fieldSpecObj);
        }
        public static string RefreshK8sCluster(CreateOnDemandJobReply fieldSpec)
        {
            return RefreshK8sCluster_TypedFieldSpec(fieldSpec);
        }
        public static string RefreshK8sCluster(object fieldSpecObj)
        {
            return RefreshK8sCluster_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RefreshK8sClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RefreshK8sV2Cluster
        // GraphQL -> refreshK8sV2Cluster: AsyncRequestStatus! (type)
        public static string RefreshK8sV2Cluster_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "refreshK8sV2Cluster" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RefreshK8sV2Cluster_ObjectFieldSpec(object fieldSpecObj)
        {
            return RefreshK8sV2Cluster((AsyncRequestStatus)fieldSpecObj);
        }
        public static string RefreshK8sV2Cluster(AsyncRequestStatus fieldSpec)
        {
            return RefreshK8sV2Cluster_TypedFieldSpec(fieldSpec);
        }
        public static string RefreshK8sV2Cluster(object fieldSpecObj)
        {
            return RefreshK8sV2Cluster_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RefreshK8sV2ClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RefreshNasSystemsReply? RefreshNasSystems
        // GraphQL -> refreshNasSystems: RefreshNasSystemsReply! (type)
        public static string RefreshNasSystems_TypedFieldSpec(RefreshNasSystemsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "refreshNasSystems" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RefreshNasSystems_ObjectFieldSpec(object fieldSpecObj)
        {
            return RefreshNasSystems((RefreshNasSystemsReply)fieldSpecObj);
        }
        public static string RefreshNasSystems(RefreshNasSystemsReply fieldSpec)
        {
            return RefreshNasSystems_TypedFieldSpec(fieldSpec);
        }
        public static string RefreshNasSystems(object fieldSpecObj)
        {
            return RefreshNasSystems_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RefreshNasSystemsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RefreshNasSystemsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RefreshNutanixCluster
        // GraphQL -> refreshNutanixCluster: AsyncRequestStatus! (type)
        public static string RefreshNutanixCluster_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "refreshNutanixCluster" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RefreshNutanixCluster_ObjectFieldSpec(object fieldSpecObj)
        {
            return RefreshNutanixCluster((AsyncRequestStatus)fieldSpecObj);
        }
        public static string RefreshNutanixCluster(AsyncRequestStatus fieldSpec)
        {
            return RefreshNutanixCluster_TypedFieldSpec(fieldSpec);
        }
        public static string RefreshNutanixCluster(object fieldSpecObj)
        {
            return RefreshNutanixCluster_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RefreshNutanixClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncRequestStatus? RefreshNutanixPrismCentral
        // GraphQL -> refreshNutanixPrismCentral: BatchAsyncRequestStatus! (type)
        public static string RefreshNutanixPrismCentral_TypedFieldSpec(BatchAsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "refreshNutanixPrismCentral" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RefreshNutanixPrismCentral_ObjectFieldSpec(object fieldSpecObj)
        {
            return RefreshNutanixPrismCentral((BatchAsyncRequestStatus)fieldSpecObj);
        }
        public static string RefreshNutanixPrismCentral(BatchAsyncRequestStatus fieldSpec)
        {
            return RefreshNutanixPrismCentral_TypedFieldSpec(fieldSpec);
        }
        public static string RefreshNutanixPrismCentral(object fieldSpecObj)
        {
            return RefreshNutanixPrismCentral_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RefreshNutanixPrismCentralFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchAsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? RefreshO365Org
        // GraphQL -> refreshO365Org: CreateOnDemandJobReply! (type)
        public static string RefreshO365Org_TypedFieldSpec(CreateOnDemandJobReply fieldSpec)
        {
            string args = "\n(\norgId: $orgId\n)";
            return "refreshO365Org" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RefreshO365Org_ObjectFieldSpec(object fieldSpecObj)
        {
            return RefreshO365Org((CreateOnDemandJobReply)fieldSpecObj);
        }
        public static string RefreshO365Org(CreateOnDemandJobReply fieldSpec)
        {
            return RefreshO365Org_TypedFieldSpec(fieldSpec);
        }
        public static string RefreshO365Org(object fieldSpecObj)
        {
            return RefreshO365Org_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RefreshO365OrgFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RefreshOracleDatabase
        // GraphQL -> refreshOracleDatabase: AsyncRequestStatus! (type)
        public static string RefreshOracleDatabase_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "refreshOracleDatabase" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RefreshOracleDatabase_ObjectFieldSpec(object fieldSpecObj)
        {
            return RefreshOracleDatabase((AsyncRequestStatus)fieldSpecObj);
        }
        public static string RefreshOracleDatabase(AsyncRequestStatus fieldSpec)
        {
            return RefreshOracleDatabase_TypedFieldSpec(fieldSpec);
        }
        public static string RefreshOracleDatabase(object fieldSpecObj)
        {
            return RefreshOracleDatabase_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RefreshOracleDatabaseFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RefreshStorageArraysReply? RefreshStorageArrays
        // GraphQL -> refreshStorageArrays: RefreshStorageArraysReply! (type)
        public static string RefreshStorageArrays_TypedFieldSpec(RefreshStorageArraysReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "refreshStorageArrays" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RefreshStorageArrays_ObjectFieldSpec(object fieldSpecObj)
        {
            return RefreshStorageArrays((RefreshStorageArraysReply)fieldSpecObj);
        }
        public static string RefreshStorageArrays(RefreshStorageArraysReply fieldSpec)
        {
            return RefreshStorageArrays_TypedFieldSpec(fieldSpec);
        }
        public static string RefreshStorageArrays(object fieldSpecObj)
        {
            return RefreshStorageArrays_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RefreshStorageArraysFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RefreshStorageArraysReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RefreshVsphereVcenter
        // GraphQL -> refreshVsphereVcenter: AsyncRequestStatus! (type)
        public static string RefreshVsphereVcenter_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "refreshVsphereVcenter" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RefreshVsphereVcenter_ObjectFieldSpec(object fieldSpecObj)
        {
            return RefreshVsphereVcenter((AsyncRequestStatus)fieldSpecObj);
        }
        public static string RefreshVsphereVcenter(AsyncRequestStatus fieldSpec)
        {
            return RefreshVsphereVcenter_TypedFieldSpec(fieldSpec);
        }
        public static string RefreshVsphereVcenter(object fieldSpecObj)
        {
            return RefreshVsphereVcenter_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RefreshVsphereVcenterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? RegisterAgentHypervVirtualMachine
        // GraphQL -> registerAgentHypervVirtualMachine: RequestSuccess! (type)
        public static string RegisterAgentHypervVirtualMachine_TypedFieldSpec(RequestSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "registerAgentHypervVirtualMachine" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RegisterAgentHypervVirtualMachine_ObjectFieldSpec(object fieldSpecObj)
        {
            return RegisterAgentHypervVirtualMachine((RequestSuccess)fieldSpecObj);
        }
        public static string RegisterAgentHypervVirtualMachine(RequestSuccess fieldSpec)
        {
            return RegisterAgentHypervVirtualMachine_TypedFieldSpec(fieldSpec);
        }
        public static string RegisterAgentHypervVirtualMachine(object fieldSpecObj)
        {
            return RegisterAgentHypervVirtualMachine_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RegisterAgentHypervVirtualMachineFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? RegisterAgentNutanixVm
        // GraphQL -> registerAgentNutanixVm: RequestSuccess! (type)
        public static string RegisterAgentNutanixVm_TypedFieldSpec(RequestSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "registerAgentNutanixVm" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RegisterAgentNutanixVm_ObjectFieldSpec(object fieldSpecObj)
        {
            return RegisterAgentNutanixVm((RequestSuccess)fieldSpecObj);
        }
        public static string RegisterAgentNutanixVm(RequestSuccess fieldSpec)
        {
            return RegisterAgentNutanixVm_TypedFieldSpec(fieldSpec);
        }
        public static string RegisterAgentNutanixVm(object fieldSpecObj)
        {
            return RegisterAgentNutanixVm_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RegisterAgentNutanixVmFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RegisterAwsFeatureArtifactsReply? RegisterAwsFeatureArtifacts
        // GraphQL -> registerAwsFeatureArtifacts: RegisterAwsFeatureArtifactsReply! (type)
        public static string RegisterAwsFeatureArtifacts_TypedFieldSpec(RegisterAwsFeatureArtifactsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "registerAwsFeatureArtifacts" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RegisterAwsFeatureArtifacts_ObjectFieldSpec(object fieldSpecObj)
        {
            return RegisterAwsFeatureArtifacts((RegisterAwsFeatureArtifactsReply)fieldSpecObj);
        }
        public static string RegisterAwsFeatureArtifacts(RegisterAwsFeatureArtifactsReply fieldSpec)
        {
            return RegisterAwsFeatureArtifacts_TypedFieldSpec(fieldSpec);
        }
        public static string RegisterAwsFeatureArtifacts(object fieldSpecObj)
        {
            return RegisterAwsFeatureArtifacts_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RegisterAwsFeatureArtifactsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RegisterAwsFeatureArtifactsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RegisterCloudClusterReply? RegisterCloudCluster
        // GraphQL -> registerCloudCluster: RegisterCloudClusterReply! (type)
        public static string RegisterCloudCluster_TypedFieldSpec(RegisterCloudClusterReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "registerCloudCluster" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RegisterCloudCluster_ObjectFieldSpec(object fieldSpecObj)
        {
            return RegisterCloudCluster((RegisterCloudClusterReply)fieldSpecObj);
        }
        public static string RegisterCloudCluster(RegisterCloudClusterReply fieldSpec)
        {
            return RegisterCloudCluster_TypedFieldSpec(fieldSpec);
        }
        public static string RegisterCloudCluster(object fieldSpecObj)
        {
            return RegisterCloudCluster_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RegisterCloudClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RegisterCloudClusterReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RegisterHypervScvmm
        // GraphQL -> registerHypervScvmm: AsyncRequestStatus! (type)
        public static string RegisterHypervScvmm_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "registerHypervScvmm" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RegisterHypervScvmm_ObjectFieldSpec(object fieldSpecObj)
        {
            return RegisterHypervScvmm((AsyncRequestStatus)fieldSpecObj);
        }
        public static string RegisterHypervScvmm(AsyncRequestStatus fieldSpec)
        {
            return RegisterHypervScvmm_TypedFieldSpec(fieldSpec);
        }
        public static string RegisterHypervScvmm(object fieldSpecObj)
        {
            return RegisterHypervScvmm_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RegisterHypervScvmmFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RegisterNasSystemReply? RegisterNasSystem
        // GraphQL -> registerNasSystem: RegisterNasSystemReply! (type)
        public static string RegisterNasSystem_TypedFieldSpec(RegisterNasSystemReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "registerNasSystem" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RegisterNasSystem_ObjectFieldSpec(object fieldSpecObj)
        {
            return RegisterNasSystem((RegisterNasSystemReply)fieldSpecObj);
        }
        public static string RegisterNasSystem(RegisterNasSystemReply fieldSpec)
        {
            return RegisterNasSystem_TypedFieldSpec(fieldSpec);
        }
        public static string RegisterNasSystem(object fieldSpecObj)
        {
            return RegisterNasSystem_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RegisterNasSystemFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RegisterNasSystemReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CcProvisionJobReply? RemoveClusterNodes
        // GraphQL -> removeClusterNodes: CcProvisionJobReply! (type)
        public static string RemoveClusterNodes_TypedFieldSpec(CcProvisionJobReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "removeClusterNodes" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RemoveClusterNodes_ObjectFieldSpec(object fieldSpecObj)
        {
            return RemoveClusterNodes((CcProvisionJobReply)fieldSpecObj);
        }
        public static string RemoveClusterNodes(CcProvisionJobReply fieldSpec)
        {
            return RemoveClusterNodes_TypedFieldSpec(fieldSpec);
        }
        public static string RemoveClusterNodes(object fieldSpecObj)
        {
            return RemoveClusterNodes_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RemoveClusterNodesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CcProvisionJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? RemoveDisk
        // GraphQL -> removeDisk: ResponseSuccess! (type)
        public static string RemoveDisk_TypedFieldSpec(ResponseSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "removeDisk" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RemoveDisk_ObjectFieldSpec(object fieldSpecObj)
        {
            return RemoveDisk((ResponseSuccess)fieldSpecObj);
        }
        public static string RemoveDisk(ResponseSuccess fieldSpec)
        {
            return RemoveDisk_TypedFieldSpec(fieldSpec);
        }
        public static string RemoveDisk(object fieldSpecObj)
        {
            return RemoveDisk_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RemoveDiskFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? RemoveProxyConfig
        // GraphQL -> removeProxyConfig: ResponseSuccess! (type)
        public static string RemoveProxyConfig_TypedFieldSpec(ResponseSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "removeProxyConfig" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RemoveProxyConfig_ObjectFieldSpec(object fieldSpecObj)
        {
            return RemoveProxyConfig((ResponseSuccess)fieldSpecObj);
        }
        public static string RemoveProxyConfig(ResponseSuccess fieldSpec)
        {
            return RemoveProxyConfig_TypedFieldSpec(fieldSpec);
        }
        public static string RemoveProxyConfig(object fieldSpecObj)
        {
            return RemoveProxyConfig_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RemoveProxyConfigFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RemoveVlansReply? RemoveVlans
        // GraphQL -> removeVlans: RemoveVlansReply! (type)
        public static string RemoveVlans_TypedFieldSpec(RemoveVlansReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "removeVlans" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RemoveVlans_ObjectFieldSpec(object fieldSpecObj)
        {
            return RemoveVlans((RemoveVlansReply)fieldSpecObj);
        }
        public static string RemoveVlans(RemoveVlansReply fieldSpec)
        {
            return RemoveVlans_TypedFieldSpec(fieldSpec);
        }
        public static string RemoveVlans(object fieldSpecObj)
        {
            return RemoveVlans_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RemoveVlansFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RemoveVlansReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ReseedLogShippingSecondary
        // GraphQL -> reseedLogShippingSecondary: AsyncRequestStatus! (type)
        public static string ReseedLogShippingSecondary_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "reseedLogShippingSecondary" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ReseedLogShippingSecondary_ObjectFieldSpec(object fieldSpecObj)
        {
            return ReseedLogShippingSecondary((AsyncRequestStatus)fieldSpecObj);
        }
        public static string ReseedLogShippingSecondary(AsyncRequestStatus fieldSpec)
        {
            return ReseedLogShippingSecondary_TypedFieldSpec(fieldSpec);
        }
        public static string ReseedLogShippingSecondary(object fieldSpecObj)
        {
            return ReseedLogShippingSecondary_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ReseedLogShippingSecondaryFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? ResizeDisk
        // GraphQL -> resizeDisk: ResponseSuccess! (type)
        public static string ResizeDisk_TypedFieldSpec(ResponseSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "resizeDisk" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ResizeDisk_ObjectFieldSpec(object fieldSpecObj)
        {
            return ResizeDisk((ResponseSuccess)fieldSpecObj);
        }
        public static string ResizeDisk(ResponseSuccess fieldSpec)
        {
            return ResizeDisk_TypedFieldSpec(fieldSpec);
        }
        public static string ResizeDisk(object fieldSpecObj)
        {
            return ResizeDisk_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ResizeDiskFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ResizeManagedVolume
        // GraphQL -> resizeManagedVolume: AsyncRequestStatus! (type)
        public static string ResizeManagedVolume_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "resizeManagedVolume" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ResizeManagedVolume_ObjectFieldSpec(object fieldSpecObj)
        {
            return ResizeManagedVolume((AsyncRequestStatus)fieldSpecObj);
        }
        public static string ResizeManagedVolume(AsyncRequestStatus fieldSpec)
        {
            return ResizeManagedVolume_TypedFieldSpec(fieldSpec);
        }
        public static string ResizeManagedVolume(object fieldSpecObj)
        {
            return ResizeManagedVolume_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ResizeManagedVolumeFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? ResolveVolumeGroupsConflict
        // GraphQL -> resolveVolumeGroupsConflict: RequestSuccess! (type)
        public static string ResolveVolumeGroupsConflict_TypedFieldSpec(RequestSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "resolveVolumeGroupsConflict" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ResolveVolumeGroupsConflict_ObjectFieldSpec(object fieldSpecObj)
        {
            return ResolveVolumeGroupsConflict((RequestSuccess)fieldSpecObj);
        }
        public static string ResolveVolumeGroupsConflict(RequestSuccess fieldSpec)
        {
            return ResolveVolumeGroupsConflict_TypedFieldSpec(fieldSpec);
        }
        public static string ResolveVolumeGroupsConflict(object fieldSpecObj)
        {
            return ResolveVolumeGroupsConflict_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ResolveVolumeGroupsConflictFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RestoreActiveDirectoryObjects
        // GraphQL -> restoreActiveDirectoryObjects: AsyncRequestStatus! (type)
        public static string RestoreActiveDirectoryObjects_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "restoreActiveDirectoryObjects" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RestoreActiveDirectoryObjects_ObjectFieldSpec(object fieldSpecObj)
        {
            return RestoreActiveDirectoryObjects((AsyncRequestStatus)fieldSpecObj);
        }
        public static string RestoreActiveDirectoryObjects(AsyncRequestStatus fieldSpec)
        {
            return RestoreActiveDirectoryObjects_TypedFieldSpec(fieldSpec);
        }
        public static string RestoreActiveDirectoryObjects(object fieldSpecObj)
        {
            return RestoreActiveDirectoryObjects_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RestoreActiveDirectoryObjectsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RestoreAzureAdObjectsWithPasswordsReply? RestoreAzureAdObjectsWithPasswords
        // GraphQL -> restoreAzureAdObjectsWithPasswords: RestoreAzureAdObjectsWithPasswordsReply! (type)
        public static string RestoreAzureAdObjectsWithPasswords_TypedFieldSpec(RestoreAzureAdObjectsWithPasswordsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "restoreAzureAdObjectsWithPasswords" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RestoreAzureAdObjectsWithPasswords_ObjectFieldSpec(object fieldSpecObj)
        {
            return RestoreAzureAdObjectsWithPasswords((RestoreAzureAdObjectsWithPasswordsReply)fieldSpecObj);
        }
        public static string RestoreAzureAdObjectsWithPasswords(RestoreAzureAdObjectsWithPasswordsReply fieldSpec)
        {
            return RestoreAzureAdObjectsWithPasswords_TypedFieldSpec(fieldSpec);
        }
        public static string RestoreAzureAdObjectsWithPasswords(object fieldSpecObj)
        {
            return RestoreAzureAdObjectsWithPasswords_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RestoreAzureAdObjectsWithPasswordsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RestoreAzureAdObjectsWithPasswordsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RestoreDomainControllerSnapshot
        // GraphQL -> restoreDomainControllerSnapshot: AsyncRequestStatus! (type)
        public static string RestoreDomainControllerSnapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "restoreDomainControllerSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RestoreDomainControllerSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return RestoreDomainControllerSnapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string RestoreDomainControllerSnapshot(AsyncRequestStatus fieldSpec)
        {
            return RestoreDomainControllerSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string RestoreDomainControllerSnapshot(object fieldSpecObj)
        {
            return RestoreDomainControllerSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RestoreDomainControllerSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RestoreFilesNutanixSnapshot
        // GraphQL -> restoreFilesNutanixSnapshot: AsyncRequestStatus! (type)
        public static string RestoreFilesNutanixSnapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "restoreFilesNutanixSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RestoreFilesNutanixSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return RestoreFilesNutanixSnapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string RestoreFilesNutanixSnapshot(AsyncRequestStatus fieldSpec)
        {
            return RestoreFilesNutanixSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string RestoreFilesNutanixSnapshot(object fieldSpecObj)
        {
            return RestoreFilesNutanixSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RestoreFilesNutanixSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RestoreHypervVirtualMachineSnapshotFiles
        // GraphQL -> restoreHypervVirtualMachineSnapshotFiles: AsyncRequestStatus! (type)
        public static string RestoreHypervVirtualMachineSnapshotFiles_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "restoreHypervVirtualMachineSnapshotFiles" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RestoreHypervVirtualMachineSnapshotFiles_ObjectFieldSpec(object fieldSpecObj)
        {
            return RestoreHypervVirtualMachineSnapshotFiles((AsyncRequestStatus)fieldSpecObj);
        }
        public static string RestoreHypervVirtualMachineSnapshotFiles(AsyncRequestStatus fieldSpec)
        {
            return RestoreHypervVirtualMachineSnapshotFiles_TypedFieldSpec(fieldSpec);
        }
        public static string RestoreHypervVirtualMachineSnapshotFiles(object fieldSpecObj)
        {
            return RestoreHypervVirtualMachineSnapshotFiles_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RestoreHypervVirtualMachineSnapshotFilesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? RestoreK8sNamespace
        // GraphQL -> restoreK8sNamespace: CreateOnDemandJobReply! (type)
        public static string RestoreK8sNamespace_TypedFieldSpec(CreateOnDemandJobReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "restoreK8sNamespace" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RestoreK8sNamespace_ObjectFieldSpec(object fieldSpecObj)
        {
            return RestoreK8sNamespace((CreateOnDemandJobReply)fieldSpecObj);
        }
        public static string RestoreK8sNamespace(CreateOnDemandJobReply fieldSpec)
        {
            return RestoreK8sNamespace_TypedFieldSpec(fieldSpec);
        }
        public static string RestoreK8sNamespace(object fieldSpecObj)
        {
            return RestoreK8sNamespace_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RestoreK8sNamespaceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RestoreK8sProtectionSetSnapshot
        // GraphQL -> restoreK8sProtectionSetSnapshot: AsyncRequestStatus! (type)
        public static string RestoreK8sProtectionSetSnapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "restoreK8sProtectionSetSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RestoreK8sProtectionSetSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return RestoreK8sProtectionSetSnapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string RestoreK8sProtectionSetSnapshot(AsyncRequestStatus fieldSpec)
        {
            return RestoreK8sProtectionSetSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string RestoreK8sProtectionSetSnapshot(object fieldSpecObj)
        {
            return RestoreK8sProtectionSetSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RestoreK8sProtectionSetSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RestoreMssqlDatabase
        // GraphQL -> restoreMssqlDatabase: AsyncRequestStatus! (type)
        public static string RestoreMssqlDatabase_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "restoreMssqlDatabase" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RestoreMssqlDatabase_ObjectFieldSpec(object fieldSpecObj)
        {
            return RestoreMssqlDatabase((AsyncRequestStatus)fieldSpecObj);
        }
        public static string RestoreMssqlDatabase(AsyncRequestStatus fieldSpec)
        {
            return RestoreMssqlDatabase_TypedFieldSpec(fieldSpec);
        }
        public static string RestoreMssqlDatabase(object fieldSpecObj)
        {
            return RestoreMssqlDatabase_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RestoreMssqlDatabaseFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? RestoreO365Mailbox
        // GraphQL -> restoreO365Mailbox: CreateOnDemandJobReply! (type)
        public static string RestoreO365Mailbox_TypedFieldSpec(CreateOnDemandJobReply fieldSpec)
        {
            string args = "\n(\nrestoreConfig: $restoreConfig\n)";
            return "restoreO365Mailbox" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RestoreO365Mailbox_ObjectFieldSpec(object fieldSpecObj)
        {
            return RestoreO365Mailbox((CreateOnDemandJobReply)fieldSpecObj);
        }
        public static string RestoreO365Mailbox(CreateOnDemandJobReply fieldSpec)
        {
            return RestoreO365Mailbox_TypedFieldSpec(fieldSpec);
        }
        public static string RestoreO365Mailbox(object fieldSpecObj)
        {
            return RestoreO365Mailbox_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RestoreO365MailboxFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? RestoreO365Snappable
        // GraphQL -> restoreO365Snappable: CreateOnDemandJobReply! (type)
        public static string RestoreO365Snappable_TypedFieldSpec(CreateOnDemandJobReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "restoreO365Snappable" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RestoreO365Snappable_ObjectFieldSpec(object fieldSpecObj)
        {
            return RestoreO365Snappable((CreateOnDemandJobReply)fieldSpecObj);
        }
        public static string RestoreO365Snappable(CreateOnDemandJobReply fieldSpec)
        {
            return RestoreO365Snappable_TypedFieldSpec(fieldSpec);
        }
        public static string RestoreO365Snappable(object fieldSpecObj)
        {
            return RestoreO365Snappable_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RestoreO365SnappableFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? RestoreO365TeamsConversations
        // GraphQL -> restoreO365TeamsConversations: CreateOnDemandJobReply! (type)
        public static string RestoreO365TeamsConversations_TypedFieldSpec(CreateOnDemandJobReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "restoreO365TeamsConversations" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RestoreO365TeamsConversations_ObjectFieldSpec(object fieldSpecObj)
        {
            return RestoreO365TeamsConversations((CreateOnDemandJobReply)fieldSpecObj);
        }
        public static string RestoreO365TeamsConversations(CreateOnDemandJobReply fieldSpec)
        {
            return RestoreO365TeamsConversations_TypedFieldSpec(fieldSpec);
        }
        public static string RestoreO365TeamsConversations(object fieldSpecObj)
        {
            return RestoreO365TeamsConversations_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RestoreO365TeamsConversationsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CreateOnDemandJobReply? RestoreO365TeamsFiles
        // GraphQL -> restoreO365TeamsFiles: CreateOnDemandJobReply! (type)
        public static string RestoreO365TeamsFiles_TypedFieldSpec(CreateOnDemandJobReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "restoreO365TeamsFiles" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RestoreO365TeamsFiles_ObjectFieldSpec(object fieldSpecObj)
        {
            return RestoreO365TeamsFiles((CreateOnDemandJobReply)fieldSpecObj);
        }
        public static string RestoreO365TeamsFiles(CreateOnDemandJobReply fieldSpec)
        {
            return RestoreO365TeamsFiles_TypedFieldSpec(fieldSpec);
        }
        public static string RestoreO365TeamsFiles(object fieldSpecObj)
        {
            return RestoreO365TeamsFiles_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RestoreO365TeamsFilesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CreateOnDemandJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RestoreOracleLogs
        // GraphQL -> restoreOracleLogs: AsyncRequestStatus! (type)
        public static string RestoreOracleLogs_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "restoreOracleLogs" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RestoreOracleLogs_ObjectFieldSpec(object fieldSpecObj)
        {
            return RestoreOracleLogs((AsyncRequestStatus)fieldSpecObj);
        }
        public static string RestoreOracleLogs(AsyncRequestStatus fieldSpec)
        {
            return RestoreOracleLogs_TypedFieldSpec(fieldSpec);
        }
        public static string RestoreOracleLogs(object fieldSpecObj)
        {
            return RestoreOracleLogs_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RestoreOracleLogsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RestoreSapHanaSystemStorage
        // GraphQL -> restoreSapHanaSystemStorage: AsyncRequestStatus! (type)
        public static string RestoreSapHanaSystemStorage_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "restoreSapHanaSystemStorage" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RestoreSapHanaSystemStorage_ObjectFieldSpec(object fieldSpecObj)
        {
            return RestoreSapHanaSystemStorage((AsyncRequestStatus)fieldSpecObj);
        }
        public static string RestoreSapHanaSystemStorage(AsyncRequestStatus fieldSpec)
        {
            return RestoreSapHanaSystemStorage_TypedFieldSpec(fieldSpec);
        }
        public static string RestoreSapHanaSystemStorage(object fieldSpecObj)
        {
            return RestoreSapHanaSystemStorage_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RestoreSapHanaSystemStorageFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RestoreVolumeGroupSnapshotFiles
        // GraphQL -> restoreVolumeGroupSnapshotFiles: AsyncRequestStatus! (type)
        public static string RestoreVolumeGroupSnapshotFiles_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "restoreVolumeGroupSnapshotFiles" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RestoreVolumeGroupSnapshotFiles_ObjectFieldSpec(object fieldSpecObj)
        {
            return RestoreVolumeGroupSnapshotFiles((AsyncRequestStatus)fieldSpecObj);
        }
        public static string RestoreVolumeGroupSnapshotFiles(AsyncRequestStatus fieldSpec)
        {
            return RestoreVolumeGroupSnapshotFiles_TypedFieldSpec(fieldSpec);
        }
        public static string RestoreVolumeGroupSnapshotFiles(object fieldSpecObj)
        {
            return RestoreVolumeGroupSnapshotFiles_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RestoreVolumeGroupSnapshotFilesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResumeTargetReply? ResumeTarget
        // GraphQL -> resumeTarget: ResumeTargetReply! (type)
        public static string ResumeTarget_TypedFieldSpec(ResumeTargetReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "resumeTarget" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ResumeTarget_ObjectFieldSpec(object fieldSpecObj)
        {
            return ResumeTarget((ResumeTargetReply)fieldSpecObj);
        }
        public static string ResumeTarget(ResumeTargetReply fieldSpec)
        {
            return ResumeTarget_TypedFieldSpec(fieldSpec);
        }
        public static string ResumeTarget(object fieldSpecObj)
        {
            return ResumeTarget_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ResumeTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResumeTargetReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? RetryAddMongoSource
        // GraphQL -> retryAddMongoSource: AsyncRequestStatus! (type)
        public static string RetryAddMongoSource_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "retryAddMongoSource" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RetryAddMongoSource_ObjectFieldSpec(object fieldSpecObj)
        {
            return RetryAddMongoSource((AsyncRequestStatus)fieldSpecObj);
        }
        public static string RetryAddMongoSource(AsyncRequestStatus fieldSpec)
        {
            return RetryAddMongoSource_TypedFieldSpec(fieldSpec);
        }
        public static string RetryAddMongoSource(object fieldSpecObj)
        {
            return RetryAddMongoSource_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RetryAddMongoSourceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RetryBackupResp? RetryBackup
        // GraphQL -> retryBackup: RetryBackupResp! (type)
        public static string RetryBackup_TypedFieldSpec(RetryBackupResp fieldSpec)
        {
            string args = "\n(\nbackupObjects: $backupObjects\nbackupRunConfig: $backupRunConfig\n)";
            return "retryBackup" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RetryBackup_ObjectFieldSpec(object fieldSpecObj)
        {
            return RetryBackup((RetryBackupResp)fieldSpecObj);
        }
        public static string RetryBackup(RetryBackupResp fieldSpec)
        {
            return RetryBackup_TypedFieldSpec(fieldSpec);
        }
        public static string RetryBackup(object fieldSpecObj)
        {
            return RetryBackup_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RetryBackupFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RetryBackupResp() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DownloadPackageReply? RetryDownloadPackageJob
        // GraphQL -> retryDownloadPackageJob: DownloadPackageReply! (type)
        public static string RetryDownloadPackageJob_TypedFieldSpec(DownloadPackageReply fieldSpec)
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            return "retryDownloadPackageJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RetryDownloadPackageJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return RetryDownloadPackageJob((DownloadPackageReply)fieldSpecObj);
        }
        public static string RetryDownloadPackageJob(DownloadPackageReply fieldSpec)
        {
            return RetryDownloadPackageJob_TypedFieldSpec(fieldSpec);
        }
        public static string RetryDownloadPackageJob(object fieldSpecObj)
        {
            return RetryDownloadPackageJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RetryDownloadPackageJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DownloadPackageReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RotateServiceAccountSecretReply? RotateServiceAccountSecret
        // GraphQL -> rotateServiceAccountSecret: RotateServiceAccountSecretReply! (type)
        public static string RotateServiceAccountSecret_TypedFieldSpec(RotateServiceAccountSecretReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "rotateServiceAccountSecret" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RotateServiceAccountSecret_ObjectFieldSpec(object fieldSpecObj)
        {
            return RotateServiceAccountSecret((RotateServiceAccountSecretReply)fieldSpecObj);
        }
        public static string RotateServiceAccountSecret(RotateServiceAccountSecretReply fieldSpec)
        {
            return RotateServiceAccountSecret_TypedFieldSpec(fieldSpec);
        }
        public static string RotateServiceAccountSecret(object fieldSpecObj)
        {
            return RotateServiceAccountSecret_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RotateServiceAccountSecretFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RotateServiceAccountSecretReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RunCustomAnalyzerReply? RunCustomAnalyzer
        // GraphQL -> runCustomAnalyzer: RunCustomAnalyzerReply! (type)
        public static string RunCustomAnalyzer_TypedFieldSpec(RunCustomAnalyzerReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "runCustomAnalyzer" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string RunCustomAnalyzer_ObjectFieldSpec(object fieldSpecObj)
        {
            return RunCustomAnalyzer((RunCustomAnalyzerReply)fieldSpecObj);
        }
        public static string RunCustomAnalyzer(RunCustomAnalyzerReply fieldSpec)
        {
            return RunCustomAnalyzer_TypedFieldSpec(fieldSpec);
        }
        public static string RunCustomAnalyzer(object fieldSpecObj)
        {
            return RunCustomAnalyzer_ObjectFieldSpec(fieldSpecObj);
        }
        public static object RunCustomAnalyzerFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RunCustomAnalyzerReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<UpgradeJobReplyWithUuid>? ScheduleUpgradeBatchJob
        // GraphQL -> scheduleUpgradeBatchJob: [UpgradeJobReplyWithUuid!]! (type)
        public static string ScheduleUpgradeBatchJob_TypedFieldSpec(List<UpgradeJobReplyWithUuid> fieldSpec)
        {
            string args = "\n(\nlistClusterUuid: $listClusterUuid\nmode: $mode\naction: $action\nversion: $version\nscheduleAt: $scheduleAt\ncontext_tag: $context_tag\n)";
            return "scheduleUpgradeBatchJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ScheduleUpgradeBatchJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return ScheduleUpgradeBatchJob((List<UpgradeJobReplyWithUuid>)fieldSpecObj);
        }
        public static string ScheduleUpgradeBatchJob(List<UpgradeJobReplyWithUuid> fieldSpec)
        {
            return ScheduleUpgradeBatchJob_TypedFieldSpec(fieldSpec);
        }
        public static string ScheduleUpgradeBatchJob(object fieldSpecObj)
        {
            return ScheduleUpgradeBatchJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ScheduleUpgradeBatchJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<UpgradeJobReplyWithUuid>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SeedEnabledPoliciesReply? SeedEnabledPolicies
        // GraphQL -> seedEnabledPolicies: SeedEnabledPoliciesReply! (type)
        public static string SeedEnabledPolicies_TypedFieldSpec(SeedEnabledPoliciesReply fieldSpec)
        {
            string args = "";
            return "seedEnabledPolicies" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string SeedEnabledPolicies_ObjectFieldSpec(object fieldSpecObj)
        {
            return SeedEnabledPolicies((SeedEnabledPoliciesReply)fieldSpecObj);
        }
        public static string SeedEnabledPolicies(SeedEnabledPoliciesReply fieldSpec)
        {
            return SeedEnabledPolicies_TypedFieldSpec(fieldSpec);
        }
        public static string SeedEnabledPolicies(object fieldSpecObj)
        {
            return SeedEnabledPolicies_ObjectFieldSpec(fieldSpecObj);
        }
        public static object SeedEnabledPoliciesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SeedEnabledPoliciesReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SeedInitialPoliciesReply? SeedInitialPolicies
        // GraphQL -> seedInitialPolicies: SeedInitialPoliciesReply! (type)
        public static string SeedInitialPolicies_TypedFieldSpec(SeedInitialPoliciesReply fieldSpec)
        {
            string args = "";
            return "seedInitialPolicies" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string SeedInitialPolicies_ObjectFieldSpec(object fieldSpecObj)
        {
            return SeedInitialPolicies((SeedInitialPoliciesReply)fieldSpecObj);
        }
        public static string SeedInitialPolicies(SeedInitialPoliciesReply fieldSpec)
        {
            return SeedInitialPolicies_TypedFieldSpec(fieldSpec);
        }
        public static string SeedInitialPolicies(object fieldSpecObj)
        {
            return SeedInitialPolicies_ObjectFieldSpec(fieldSpecObj);
        }
        public static object SeedInitialPoliciesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SeedInitialPoliciesReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SendPdfReportReply? SendPdfReport
        // GraphQL -> sendPdfReport: SendPdfReportReply! (type)
        public static string SendPdfReport_TypedFieldSpec(SendPdfReportReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "sendPdfReport" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string SendPdfReport_ObjectFieldSpec(object fieldSpecObj)
        {
            return SendPdfReport((SendPdfReportReply)fieldSpecObj);
        }
        public static string SendPdfReport(SendPdfReportReply fieldSpec)
        {
            return SendPdfReport_TypedFieldSpec(fieldSpec);
        }
        public static string SendPdfReport(object fieldSpecObj)
        {
            return SendPdfReport_ObjectFieldSpec(fieldSpecObj);
        }
        public static object SendPdfReportFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SendPdfReportReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncDownloadReply? SendScheduledReportAsync
        // GraphQL -> sendScheduledReportAsync: AsyncDownloadReply! (type)
        public static string SendScheduledReportAsync_TypedFieldSpec(AsyncDownloadReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "sendScheduledReportAsync" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string SendScheduledReportAsync_ObjectFieldSpec(object fieldSpecObj)
        {
            return SendScheduledReportAsync((AsyncDownloadReply)fieldSpecObj);
        }
        public static string SendScheduledReportAsync(AsyncDownloadReply fieldSpec)
        {
            return SendScheduledReportAsync_TypedFieldSpec(fieldSpec);
        }
        public static string SendScheduledReportAsync(object fieldSpecObj)
        {
            return SendScheduledReportAsync_ObjectFieldSpec(fieldSpecObj);
        }
        public static object SendScheduledReportAsyncFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncDownloadReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SetAnalyzerRisksReply? SetAnalyzerRisks
        // GraphQL -> setAnalyzerRisks: SetAnalyzerRisksReply! (type)
        public static string SetAnalyzerRisks_TypedFieldSpec(SetAnalyzerRisksReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "setAnalyzerRisks" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string SetAnalyzerRisks_ObjectFieldSpec(object fieldSpecObj)
        {
            return SetAnalyzerRisks((SetAnalyzerRisksReply)fieldSpecObj);
        }
        public static string SetAnalyzerRisks(SetAnalyzerRisksReply fieldSpec)
        {
            return SetAnalyzerRisks_TypedFieldSpec(fieldSpec);
        }
        public static string SetAnalyzerRisks(object fieldSpecObj)
        {
            return SetAnalyzerRisks_ObjectFieldSpec(fieldSpecObj);
        }
        public static object SetAnalyzerRisksFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SetAnalyzerRisksReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SetDatastoreFreespaceThresholdsReply? SetDatastoreFreespaceThresholds
        // GraphQL -> setDatastoreFreespaceThresholds: SetDatastoreFreespaceThresholdsReply! (type)
        public static string SetDatastoreFreespaceThresholds_TypedFieldSpec(SetDatastoreFreespaceThresholdsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "setDatastoreFreespaceThresholds" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string SetDatastoreFreespaceThresholds_ObjectFieldSpec(object fieldSpecObj)
        {
            return SetDatastoreFreespaceThresholds((SetDatastoreFreespaceThresholdsReply)fieldSpecObj);
        }
        public static string SetDatastoreFreespaceThresholds(SetDatastoreFreespaceThresholdsReply fieldSpec)
        {
            return SetDatastoreFreespaceThresholds_TypedFieldSpec(fieldSpec);
        }
        public static string SetDatastoreFreespaceThresholds(object fieldSpecObj)
        {
            return SetDatastoreFreespaceThresholds_ObjectFieldSpec(fieldSpecObj);
        }
        public static object SetDatastoreFreespaceThresholdsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SetDatastoreFreespaceThresholdsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestStatus? SetO365ServiceAccount
        // GraphQL -> setO365ServiceAccount: RequestStatus! (type)
        public static string SetO365ServiceAccount_TypedFieldSpec(RequestStatus fieldSpec)
        {
            string args = "\n(\nusername: $username\nappPassword: $appPassword\norgId: $orgId\n)";
            return "setO365ServiceAccount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string SetO365ServiceAccount_ObjectFieldSpec(object fieldSpecObj)
        {
            return SetO365ServiceAccount((RequestStatus)fieldSpecObj);
        }
        public static string SetO365ServiceAccount(RequestStatus fieldSpec)
        {
            return SetO365ServiceAccount_TypedFieldSpec(fieldSpec);
        }
        public static string SetO365ServiceAccount(object fieldSpecObj)
        {
            return SetO365ServiceAccount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object SetO365ServiceAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SetUpgradeTypeReply? SetUpgradeType
        // GraphQL -> setUpgradeType: SetUpgradeTypeReply! (type)
        public static string SetUpgradeType_TypedFieldSpec(SetUpgradeTypeReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "setUpgradeType" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string SetUpgradeType_ObjectFieldSpec(object fieldSpecObj)
        {
            return SetUpgradeType((SetUpgradeTypeReply)fieldSpecObj);
        }
        public static string SetUpgradeType(SetUpgradeTypeReply fieldSpec)
        {
            return SetUpgradeType_TypedFieldSpec(fieldSpec);
        }
        public static string SetUpgradeType(object fieldSpecObj)
        {
            return SetUpgradeType_ObjectFieldSpec(fieldSpecObj);
        }
        public static object SetUpgradeTypeFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SetUpgradeTypeReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? SetWebSignedCertificate
        // GraphQL -> setWebSignedCertificate: AsyncRequestStatus! (type)
        public static string SetWebSignedCertificate_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "setWebSignedCertificate" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string SetWebSignedCertificate_ObjectFieldSpec(object fieldSpecObj)
        {
            return SetWebSignedCertificate((AsyncRequestStatus)fieldSpecObj);
        }
        public static string SetWebSignedCertificate(AsyncRequestStatus fieldSpec)
        {
            return SetWebSignedCertificate_TypedFieldSpec(fieldSpec);
        }
        public static string SetWebSignedCertificate(object fieldSpecObj)
        {
            return SetWebSignedCertificate_ObjectFieldSpec(fieldSpecObj);
        }
        public static object SetWebSignedCertificateFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SetWorkloadAlertSettingReply? SetWorkloadAlertSetting
        // GraphQL -> setWorkloadAlertSetting: SetWorkloadAlertSettingReply! (type)
        public static string SetWorkloadAlertSetting_TypedFieldSpec(SetWorkloadAlertSettingReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "setWorkloadAlertSetting" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string SetWorkloadAlertSetting_ObjectFieldSpec(object fieldSpecObj)
        {
            return SetWorkloadAlertSetting((SetWorkloadAlertSettingReply)fieldSpecObj);
        }
        public static string SetWorkloadAlertSetting(SetWorkloadAlertSettingReply fieldSpec)
        {
            return SetWorkloadAlertSetting_TypedFieldSpec(fieldSpec);
        }
        public static string SetWorkloadAlertSetting(object fieldSpecObj)
        {
            return SetWorkloadAlertSetting_ObjectFieldSpec(fieldSpecObj);
        }
        public static object SetWorkloadAlertSettingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SetWorkloadAlertSettingReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SetupAzureO365ExocomputeResp? SetupAzureO365Exocompute
        // GraphQL -> setupAzureO365Exocompute: SetupAzureO365ExocomputeResp! (type)
        public static string SetupAzureO365Exocompute_TypedFieldSpec(SetupAzureO365ExocomputeResp fieldSpec)
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nexocomputeConfig: $exocomputeConfig\n)";
            return "setupAzureO365Exocompute" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string SetupAzureO365Exocompute_ObjectFieldSpec(object fieldSpecObj)
        {
            return SetupAzureO365Exocompute((SetupAzureO365ExocomputeResp)fieldSpecObj);
        }
        public static string SetupAzureO365Exocompute(SetupAzureO365ExocomputeResp fieldSpec)
        {
            return SetupAzureO365Exocompute_TypedFieldSpec(fieldSpec);
        }
        public static string SetupAzureO365Exocompute(object fieldSpecObj)
        {
            return SetupAzureO365Exocompute_ObjectFieldSpec(fieldSpecObj);
        }
        public static object SetupAzureO365ExocomputeFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SetupAzureO365ExocomputeResp() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? SetupCloudNativeSqlServerBackup
        // GraphQL -> setupCloudNativeSqlServerBackup: BatchAsyncJobStatus! (type)
        public static string SetupCloudNativeSqlServerBackup_TypedFieldSpec(BatchAsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "setupCloudNativeSqlServerBackup" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string SetupCloudNativeSqlServerBackup_ObjectFieldSpec(object fieldSpecObj)
        {
            return SetupCloudNativeSqlServerBackup((BatchAsyncJobStatus)fieldSpecObj);
        }
        public static string SetupCloudNativeSqlServerBackup(BatchAsyncJobStatus fieldSpec)
        {
            return SetupCloudNativeSqlServerBackup_TypedFieldSpec(fieldSpec);
        }
        public static string SetupCloudNativeSqlServerBackup(object fieldSpecObj)
        {
            return SetupCloudNativeSqlServerBackup_ObjectFieldSpec(fieldSpecObj);
        }
        public static object SetupCloudNativeSqlServerBackupFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DiskInfo? SetupDisk
        // GraphQL -> setupDisk: DiskInfo! (type)
        public static string SetupDisk_TypedFieldSpec(DiskInfo fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "setupDisk" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string SetupDisk_ObjectFieldSpec(object fieldSpecObj)
        {
            return SetupDisk((DiskInfo)fieldSpecObj);
        }
        public static string SetupDisk(DiskInfo fieldSpec)
        {
            return SetupDisk_TypedFieldSpec(fieldSpec);
        }
        public static string SetupDisk(object fieldSpecObj)
        {
            return SetupDisk_ObjectFieldSpec(fieldSpecObj);
        }
        public static object SetupDiskFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DiskInfo() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? StartAwsExocomputeDisableJob
        // GraphQL -> startAwsExocomputeDisableJob: AsyncJobStatus! (type)
        public static string StartAwsExocomputeDisableJob_TypedFieldSpec(AsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startAwsExocomputeDisableJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartAwsExocomputeDisableJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartAwsExocomputeDisableJob((AsyncJobStatus)fieldSpecObj);
        }
        public static string StartAwsExocomputeDisableJob(AsyncJobStatus fieldSpec)
        {
            return StartAwsExocomputeDisableJob_TypedFieldSpec(fieldSpec);
        }
        public static string StartAwsExocomputeDisableJob(object fieldSpecObj)
        {
            return StartAwsExocomputeDisableJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartAwsExocomputeDisableJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? StartAwsNativeAccountDisableJob
        // GraphQL -> startAwsNativeAccountDisableJob: AsyncJobStatus! (type)
        public static string StartAwsNativeAccountDisableJob_TypedFieldSpec(AsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startAwsNativeAccountDisableJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartAwsNativeAccountDisableJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartAwsNativeAccountDisableJob((AsyncJobStatus)fieldSpecObj);
        }
        public static string StartAwsNativeAccountDisableJob(AsyncJobStatus fieldSpec)
        {
            return StartAwsNativeAccountDisableJob_TypedFieldSpec(fieldSpec);
        }
        public static string StartAwsNativeAccountDisableJob(object fieldSpecObj)
        {
            return StartAwsNativeAccountDisableJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartAwsNativeAccountDisableJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? StartAwsNativeEc2InstanceSnapshotsJob
        // GraphQL -> startAwsNativeEc2InstanceSnapshotsJob: BatchAsyncJobStatus! (type)
        public static string StartAwsNativeEc2InstanceSnapshotsJob_TypedFieldSpec(BatchAsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startAwsNativeEc2InstanceSnapshotsJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartAwsNativeEc2InstanceSnapshotsJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartAwsNativeEc2InstanceSnapshotsJob((BatchAsyncJobStatus)fieldSpecObj);
        }
        public static string StartAwsNativeEc2InstanceSnapshotsJob(BatchAsyncJobStatus fieldSpec)
        {
            return StartAwsNativeEc2InstanceSnapshotsJob_TypedFieldSpec(fieldSpec);
        }
        public static string StartAwsNativeEc2InstanceSnapshotsJob(object fieldSpecObj)
        {
            return StartAwsNativeEc2InstanceSnapshotsJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartAwsNativeEc2InstanceSnapshotsJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? StartAwsNativeRdsInstanceSnapshotsJob
        // GraphQL -> startAwsNativeRdsInstanceSnapshotsJob: BatchAsyncJobStatus! (type)
        public static string StartAwsNativeRdsInstanceSnapshotsJob_TypedFieldSpec(BatchAsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startAwsNativeRdsInstanceSnapshotsJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartAwsNativeRdsInstanceSnapshotsJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartAwsNativeRdsInstanceSnapshotsJob((BatchAsyncJobStatus)fieldSpecObj);
        }
        public static string StartAwsNativeRdsInstanceSnapshotsJob(BatchAsyncJobStatus fieldSpec)
        {
            return StartAwsNativeRdsInstanceSnapshotsJob_TypedFieldSpec(fieldSpec);
        }
        public static string StartAwsNativeRdsInstanceSnapshotsJob(object fieldSpecObj)
        {
            return StartAwsNativeRdsInstanceSnapshotsJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartAwsNativeRdsInstanceSnapshotsJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> StartAzureAdAppSetupReply? StartAzureAdAppSetup
        // GraphQL -> startAzureAdAppSetup: StartAzureAdAppSetupReply! (type)
        public static string StartAzureAdAppSetup_TypedFieldSpec(StartAzureAdAppSetupReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startAzureAdAppSetup" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartAzureAdAppSetup_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartAzureAdAppSetup((StartAzureAdAppSetupReply)fieldSpecObj);
        }
        public static string StartAzureAdAppSetup(StartAzureAdAppSetupReply fieldSpec)
        {
            return StartAzureAdAppSetup_TypedFieldSpec(fieldSpec);
        }
        public static string StartAzureAdAppSetup(object fieldSpecObj)
        {
            return StartAzureAdAppSetup_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartAzureAdAppSetupFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new StartAzureAdAppSetupReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> StartAzureAdAppUpdateReply? StartAzureAdAppUpdate
        // GraphQL -> startAzureAdAppUpdate: StartAzureAdAppUpdateReply! (type)
        public static string StartAzureAdAppUpdate_TypedFieldSpec(StartAzureAdAppUpdateReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startAzureAdAppUpdate" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartAzureAdAppUpdate_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartAzureAdAppUpdate((StartAzureAdAppUpdateReply)fieldSpecObj);
        }
        public static string StartAzureAdAppUpdate(StartAzureAdAppUpdateReply fieldSpec)
        {
            return StartAzureAdAppUpdate_TypedFieldSpec(fieldSpec);
        }
        public static string StartAzureAdAppUpdate(object fieldSpecObj)
        {
            return StartAzureAdAppUpdate_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartAzureAdAppUpdateFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new StartAzureAdAppUpdateReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> StartAzureCloudAccountOauthReply? StartAzureCloudAccountOauth
        // GraphQL -> startAzureCloudAccountOauth: StartAzureCloudAccountOauthReply! (type)
        public static string StartAzureCloudAccountOauth_TypedFieldSpec(StartAzureCloudAccountOauthReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startAzureCloudAccountOauth" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartAzureCloudAccountOauth_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartAzureCloudAccountOauth((StartAzureCloudAccountOauthReply)fieldSpecObj);
        }
        public static string StartAzureCloudAccountOauth(StartAzureCloudAccountOauthReply fieldSpec)
        {
            return StartAzureCloudAccountOauth_TypedFieldSpec(fieldSpec);
        }
        public static string StartAzureCloudAccountOauth(object fieldSpecObj)
        {
            return StartAzureCloudAccountOauth_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartAzureCloudAccountOauthFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new StartAzureCloudAccountOauthReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? StartCloudNativeSnapshotsIndexJob
        // GraphQL -> startCloudNativeSnapshotsIndexJob: BatchAsyncJobStatus! (type)
        public static string StartCloudNativeSnapshotsIndexJob_TypedFieldSpec(BatchAsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startCloudNativeSnapshotsIndexJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartCloudNativeSnapshotsIndexJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartCloudNativeSnapshotsIndexJob((BatchAsyncJobStatus)fieldSpecObj);
        }
        public static string StartCloudNativeSnapshotsIndexJob(BatchAsyncJobStatus fieldSpec)
        {
            return StartCloudNativeSnapshotsIndexJob_TypedFieldSpec(fieldSpec);
        }
        public static string StartCloudNativeSnapshotsIndexJob(object fieldSpecObj)
        {
            return StartCloudNativeSnapshotsIndexJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartCloudNativeSnapshotsIndexJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> StartClusterReportMigrationJobReply? StartClusterReportMigrationJob
        // GraphQL -> startClusterReportMigrationJob: StartClusterReportMigrationJobReply! (type)
        public static string StartClusterReportMigrationJob_TypedFieldSpec(StartClusterReportMigrationJobReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startClusterReportMigrationJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartClusterReportMigrationJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartClusterReportMigrationJob((StartClusterReportMigrationJobReply)fieldSpecObj);
        }
        public static string StartClusterReportMigrationJob(StartClusterReportMigrationJobReply fieldSpec)
        {
            return StartClusterReportMigrationJob_TypedFieldSpec(fieldSpec);
        }
        public static string StartClusterReportMigrationJob(object fieldSpecObj)
        {
            return StartClusterReportMigrationJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartClusterReportMigrationJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new StartClusterReportMigrationJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> StartCrawlReply? StartCrawl
        // GraphQL -> startCrawl: StartCrawlReply! (type)
        public static string StartCrawl_TypedFieldSpec(StartCrawlReply fieldSpec)
        {
            string args = "\n(\nname: $name\nresources: $resources\nanalyzerGroups: $analyzerGroups\nextWhiteList: $extWhiteList\n)";
            return "startCrawl" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartCrawl_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartCrawl((StartCrawlReply)fieldSpecObj);
        }
        public static string StartCrawl(StartCrawlReply fieldSpec)
        {
            return StartCrawl_TypedFieldSpec(fieldSpec);
        }
        public static string StartCrawl(object fieldSpecObj)
        {
            return StartCrawl_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartCrawlFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new StartCrawlReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? StartCreateAwsNativeEbsVolumeSnapshotsJob
        // GraphQL -> startCreateAwsNativeEbsVolumeSnapshotsJob: BatchAsyncJobStatus! (type)
        public static string StartCreateAwsNativeEbsVolumeSnapshotsJob_TypedFieldSpec(BatchAsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startCreateAwsNativeEbsVolumeSnapshotsJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartCreateAwsNativeEbsVolumeSnapshotsJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartCreateAwsNativeEbsVolumeSnapshotsJob((BatchAsyncJobStatus)fieldSpecObj);
        }
        public static string StartCreateAwsNativeEbsVolumeSnapshotsJob(BatchAsyncJobStatus fieldSpec)
        {
            return StartCreateAwsNativeEbsVolumeSnapshotsJob_TypedFieldSpec(fieldSpec);
        }
        public static string StartCreateAwsNativeEbsVolumeSnapshotsJob(object fieldSpecObj)
        {
            return StartCreateAwsNativeEbsVolumeSnapshotsJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartCreateAwsNativeEbsVolumeSnapshotsJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? StartCreateAzureNativeManagedDiskSnapshotsJob
        // GraphQL -> startCreateAzureNativeManagedDiskSnapshotsJob: BatchAsyncJobStatus! (type)
        public static string StartCreateAzureNativeManagedDiskSnapshotsJob_TypedFieldSpec(BatchAsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startCreateAzureNativeManagedDiskSnapshotsJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartCreateAzureNativeManagedDiskSnapshotsJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartCreateAzureNativeManagedDiskSnapshotsJob((BatchAsyncJobStatus)fieldSpecObj);
        }
        public static string StartCreateAzureNativeManagedDiskSnapshotsJob(BatchAsyncJobStatus fieldSpec)
        {
            return StartCreateAzureNativeManagedDiskSnapshotsJob_TypedFieldSpec(fieldSpec);
        }
        public static string StartCreateAzureNativeManagedDiskSnapshotsJob(object fieldSpecObj)
        {
            return StartCreateAzureNativeManagedDiskSnapshotsJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartCreateAzureNativeManagedDiskSnapshotsJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? StartCreateAzureNativeVirtualMachineSnapshotsJob
        // GraphQL -> startCreateAzureNativeVirtualMachineSnapshotsJob: BatchAsyncJobStatus! (type)
        public static string StartCreateAzureNativeVirtualMachineSnapshotsJob_TypedFieldSpec(BatchAsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startCreateAzureNativeVirtualMachineSnapshotsJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartCreateAzureNativeVirtualMachineSnapshotsJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartCreateAzureNativeVirtualMachineSnapshotsJob((BatchAsyncJobStatus)fieldSpecObj);
        }
        public static string StartCreateAzureNativeVirtualMachineSnapshotsJob(BatchAsyncJobStatus fieldSpec)
        {
            return StartCreateAzureNativeVirtualMachineSnapshotsJob_TypedFieldSpec(fieldSpec);
        }
        public static string StartCreateAzureNativeVirtualMachineSnapshotsJob(object fieldSpecObj)
        {
            return StartCreateAzureNativeVirtualMachineSnapshotsJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartCreateAzureNativeVirtualMachineSnapshotsJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? StartDisableAzureCloudAccountJob
        // GraphQL -> startDisableAzureCloudAccountJob: BatchAsyncJobStatus! (type)
        public static string StartDisableAzureCloudAccountJob_TypedFieldSpec(BatchAsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startDisableAzureCloudAccountJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartDisableAzureCloudAccountJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartDisableAzureCloudAccountJob((BatchAsyncJobStatus)fieldSpecObj);
        }
        public static string StartDisableAzureCloudAccountJob(BatchAsyncJobStatus fieldSpec)
        {
            return StartDisableAzureCloudAccountJob_TypedFieldSpec(fieldSpec);
        }
        public static string StartDisableAzureCloudAccountJob(object fieldSpecObj)
        {
            return StartDisableAzureCloudAccountJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartDisableAzureCloudAccountJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? StartDisableAzureNativeSubscriptionProtectionJob
        // GraphQL -> startDisableAzureNativeSubscriptionProtectionJob: AsyncJobStatus! (type)
        public static string StartDisableAzureNativeSubscriptionProtectionJob_TypedFieldSpec(AsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startDisableAzureNativeSubscriptionProtectionJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartDisableAzureNativeSubscriptionProtectionJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartDisableAzureNativeSubscriptionProtectionJob((AsyncJobStatus)fieldSpecObj);
        }
        public static string StartDisableAzureNativeSubscriptionProtectionJob(AsyncJobStatus fieldSpec)
        {
            return StartDisableAzureNativeSubscriptionProtectionJob_TypedFieldSpec(fieldSpec);
        }
        public static string StartDisableAzureNativeSubscriptionProtectionJob(object fieldSpecObj)
        {
            return StartDisableAzureNativeSubscriptionProtectionJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartDisableAzureNativeSubscriptionProtectionJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<DownloadPackageReplyWithUuid>? StartDownloadPackageBatchJob
        // GraphQL -> startDownloadPackageBatchJob: [DownloadPackageReplyWithUuid!]! (type)
        public static string StartDownloadPackageBatchJob_TypedFieldSpec(List<DownloadPackageReplyWithUuid> fieldSpec)
        {
            string args = "\n(\nlistClusterUuid: $listClusterUuid\ndownloadVersion: $downloadVersion\npackageUrl: $packageUrl\nmd5checksum: $md5checksum\nsize: $size\n)";
            return "startDownloadPackageBatchJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartDownloadPackageBatchJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartDownloadPackageBatchJob((List<DownloadPackageReplyWithUuid>)fieldSpecObj);
        }
        public static string StartDownloadPackageBatchJob(List<DownloadPackageReplyWithUuid> fieldSpec)
        {
            return StartDownloadPackageBatchJob_TypedFieldSpec(fieldSpec);
        }
        public static string StartDownloadPackageBatchJob(object fieldSpecObj)
        {
            return StartDownloadPackageBatchJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartDownloadPackageBatchJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<DownloadPackageReplyWithUuid>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? StartEc2InstanceSnapshotExportJob
        // GraphQL -> startEc2InstanceSnapshotExportJob: AsyncJobStatus! (type)
        public static string StartEc2InstanceSnapshotExportJob_TypedFieldSpec(AsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startEc2InstanceSnapshotExportJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartEc2InstanceSnapshotExportJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartEc2InstanceSnapshotExportJob((AsyncJobStatus)fieldSpecObj);
        }
        public static string StartEc2InstanceSnapshotExportJob(AsyncJobStatus fieldSpec)
        {
            return StartEc2InstanceSnapshotExportJob_TypedFieldSpec(fieldSpec);
        }
        public static string StartEc2InstanceSnapshotExportJob(object fieldSpecObj)
        {
            return StartEc2InstanceSnapshotExportJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartEc2InstanceSnapshotExportJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? StartExportAwsNativeEbsVolumeSnapshotJob
        // GraphQL -> startExportAwsNativeEbsVolumeSnapshotJob: AsyncJobStatus! (type)
        public static string StartExportAwsNativeEbsVolumeSnapshotJob_TypedFieldSpec(AsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startExportAwsNativeEbsVolumeSnapshotJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartExportAwsNativeEbsVolumeSnapshotJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartExportAwsNativeEbsVolumeSnapshotJob((AsyncJobStatus)fieldSpecObj);
        }
        public static string StartExportAwsNativeEbsVolumeSnapshotJob(AsyncJobStatus fieldSpec)
        {
            return StartExportAwsNativeEbsVolumeSnapshotJob_TypedFieldSpec(fieldSpec);
        }
        public static string StartExportAwsNativeEbsVolumeSnapshotJob(object fieldSpecObj)
        {
            return StartExportAwsNativeEbsVolumeSnapshotJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartExportAwsNativeEbsVolumeSnapshotJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? StartExportAzureNativeManagedDiskJob
        // GraphQL -> startExportAzureNativeManagedDiskJob: AsyncJobStatus! (type)
        public static string StartExportAzureNativeManagedDiskJob_TypedFieldSpec(AsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startExportAzureNativeManagedDiskJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartExportAzureNativeManagedDiskJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartExportAzureNativeManagedDiskJob((AsyncJobStatus)fieldSpecObj);
        }
        public static string StartExportAzureNativeManagedDiskJob(AsyncJobStatus fieldSpec)
        {
            return StartExportAzureNativeManagedDiskJob_TypedFieldSpec(fieldSpec);
        }
        public static string StartExportAzureNativeManagedDiskJob(object fieldSpecObj)
        {
            return StartExportAzureNativeManagedDiskJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartExportAzureNativeManagedDiskJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? StartExportAzureNativeVirtualMachineJob
        // GraphQL -> startExportAzureNativeVirtualMachineJob: AsyncJobStatus! (type)
        public static string StartExportAzureNativeVirtualMachineJob_TypedFieldSpec(AsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startExportAzureNativeVirtualMachineJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartExportAzureNativeVirtualMachineJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartExportAzureNativeVirtualMachineJob((AsyncJobStatus)fieldSpecObj);
        }
        public static string StartExportAzureNativeVirtualMachineJob(AsyncJobStatus fieldSpec)
        {
            return StartExportAzureNativeVirtualMachineJob_TypedFieldSpec(fieldSpec);
        }
        public static string StartExportAzureNativeVirtualMachineJob(object fieldSpecObj)
        {
            return StartExportAzureNativeVirtualMachineJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartExportAzureNativeVirtualMachineJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? StartExportAzureSqlDatabaseDbJob
        // GraphQL -> startExportAzureSqlDatabaseDbJob: AsyncJobStatus! (type)
        public static string StartExportAzureSqlDatabaseDbJob_TypedFieldSpec(AsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startExportAzureSqlDatabaseDbJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartExportAzureSqlDatabaseDbJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartExportAzureSqlDatabaseDbJob((AsyncJobStatus)fieldSpecObj);
        }
        public static string StartExportAzureSqlDatabaseDbJob(AsyncJobStatus fieldSpec)
        {
            return StartExportAzureSqlDatabaseDbJob_TypedFieldSpec(fieldSpec);
        }
        public static string StartExportAzureSqlDatabaseDbJob(object fieldSpecObj)
        {
            return StartExportAzureSqlDatabaseDbJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartExportAzureSqlDatabaseDbJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? StartExportAzureSqlManagedInstanceDbJob
        // GraphQL -> startExportAzureSqlManagedInstanceDbJob: AsyncJobStatus! (type)
        public static string StartExportAzureSqlManagedInstanceDbJob_TypedFieldSpec(AsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startExportAzureSqlManagedInstanceDbJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartExportAzureSqlManagedInstanceDbJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartExportAzureSqlManagedInstanceDbJob((AsyncJobStatus)fieldSpecObj);
        }
        public static string StartExportAzureSqlManagedInstanceDbJob(AsyncJobStatus fieldSpec)
        {
            return StartExportAzureSqlManagedInstanceDbJob_TypedFieldSpec(fieldSpec);
        }
        public static string StartExportAzureSqlManagedInstanceDbJob(object fieldSpecObj)
        {
            return StartExportAzureSqlManagedInstanceDbJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartExportAzureSqlManagedInstanceDbJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? StartExportRdsInstanceJob
        // GraphQL -> startExportRdsInstanceJob: AsyncJobStatus! (type)
        public static string StartExportRdsInstanceJob_TypedFieldSpec(AsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startExportRdsInstanceJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartExportRdsInstanceJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartExportRdsInstanceJob((AsyncJobStatus)fieldSpecObj);
        }
        public static string StartExportRdsInstanceJob(AsyncJobStatus fieldSpec)
        {
            return StartExportRdsInstanceJob_TypedFieldSpec(fieldSpec);
        }
        public static string StartExportRdsInstanceJob(object fieldSpecObj)
        {
            return StartExportRdsInstanceJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartExportRdsInstanceJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PrechecksJobReply? StartPeriodicUpgradePrechecksOnDemandJob
        // GraphQL -> startPeriodicUpgradePrechecksOnDemandJob: PrechecksJobReply! (type)
        public static string StartPeriodicUpgradePrechecksOnDemandJob_TypedFieldSpec(PrechecksJobReply fieldSpec)
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            return "startPeriodicUpgradePrechecksOnDemandJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartPeriodicUpgradePrechecksOnDemandJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartPeriodicUpgradePrechecksOnDemandJob((PrechecksJobReply)fieldSpecObj);
        }
        public static string StartPeriodicUpgradePrechecksOnDemandJob(PrechecksJobReply fieldSpec)
        {
            return StartPeriodicUpgradePrechecksOnDemandJob_TypedFieldSpec(fieldSpec);
        }
        public static string StartPeriodicUpgradePrechecksOnDemandJob(object fieldSpecObj)
        {
            return StartPeriodicUpgradePrechecksOnDemandJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartPeriodicUpgradePrechecksOnDemandJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new PrechecksJobReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? StartRecoverS3SnapshotJob
        // GraphQL -> startRecoverS3SnapshotJob: AsyncJobStatus! (type)
        public static string StartRecoverS3SnapshotJob_TypedFieldSpec(AsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startRecoverS3SnapshotJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartRecoverS3SnapshotJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartRecoverS3SnapshotJob((AsyncJobStatus)fieldSpecObj);
        }
        public static string StartRecoverS3SnapshotJob(AsyncJobStatus fieldSpec)
        {
            return StartRecoverS3SnapshotJob_TypedFieldSpec(fieldSpec);
        }
        public static string StartRecoverS3SnapshotJob(object fieldSpecObj)
        {
            return StartRecoverS3SnapshotJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartRecoverS3SnapshotJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? StartRefreshAwsNativeAccountsJob
        // GraphQL -> startRefreshAwsNativeAccountsJob: BatchAsyncJobStatus! (type)
        public static string StartRefreshAwsNativeAccountsJob_TypedFieldSpec(BatchAsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startRefreshAwsNativeAccountsJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartRefreshAwsNativeAccountsJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartRefreshAwsNativeAccountsJob((BatchAsyncJobStatus)fieldSpecObj);
        }
        public static string StartRefreshAwsNativeAccountsJob(BatchAsyncJobStatus fieldSpec)
        {
            return StartRefreshAwsNativeAccountsJob_TypedFieldSpec(fieldSpec);
        }
        public static string StartRefreshAwsNativeAccountsJob(object fieldSpecObj)
        {
            return StartRefreshAwsNativeAccountsJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartRefreshAwsNativeAccountsJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncJobStatus? StartRefreshAzureNativeSubscriptionsJob
        // GraphQL -> startRefreshAzureNativeSubscriptionsJob: BatchAsyncJobStatus! (type)
        public static string StartRefreshAzureNativeSubscriptionsJob_TypedFieldSpec(BatchAsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startRefreshAzureNativeSubscriptionsJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartRefreshAzureNativeSubscriptionsJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartRefreshAzureNativeSubscriptionsJob((BatchAsyncJobStatus)fieldSpecObj);
        }
        public static string StartRefreshAzureNativeSubscriptionsJob(BatchAsyncJobStatus fieldSpec)
        {
            return StartRefreshAzureNativeSubscriptionsJob_TypedFieldSpec(fieldSpec);
        }
        public static string StartRefreshAzureNativeSubscriptionsJob(object fieldSpecObj)
        {
            return StartRefreshAzureNativeSubscriptionsJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartRefreshAzureNativeSubscriptionsJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchAsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? StartRestoreAwsNativeEc2InstanceSnapshotJob
        // GraphQL -> startRestoreAwsNativeEc2InstanceSnapshotJob: AsyncJobStatus! (type)
        public static string StartRestoreAwsNativeEc2InstanceSnapshotJob_TypedFieldSpec(AsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startRestoreAwsNativeEc2InstanceSnapshotJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartRestoreAwsNativeEc2InstanceSnapshotJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartRestoreAwsNativeEc2InstanceSnapshotJob((AsyncJobStatus)fieldSpecObj);
        }
        public static string StartRestoreAwsNativeEc2InstanceSnapshotJob(AsyncJobStatus fieldSpec)
        {
            return StartRestoreAwsNativeEc2InstanceSnapshotJob_TypedFieldSpec(fieldSpec);
        }
        public static string StartRestoreAwsNativeEc2InstanceSnapshotJob(object fieldSpecObj)
        {
            return StartRestoreAwsNativeEc2InstanceSnapshotJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartRestoreAwsNativeEc2InstanceSnapshotJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? StartRestoreAzureNativeVirtualMachineJob
        // GraphQL -> startRestoreAzureNativeVirtualMachineJob: AsyncJobStatus! (type)
        public static string StartRestoreAzureNativeVirtualMachineJob_TypedFieldSpec(AsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startRestoreAzureNativeVirtualMachineJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartRestoreAzureNativeVirtualMachineJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartRestoreAzureNativeVirtualMachineJob((AsyncJobStatus)fieldSpecObj);
        }
        public static string StartRestoreAzureNativeVirtualMachineJob(AsyncJobStatus fieldSpec)
        {
            return StartRestoreAzureNativeVirtualMachineJob_TypedFieldSpec(fieldSpec);
        }
        public static string StartRestoreAzureNativeVirtualMachineJob(object fieldSpecObj)
        {
            return StartRestoreAzureNativeVirtualMachineJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartRestoreAzureNativeVirtualMachineJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> StartThreatHuntReply? StartThreatHunt
        // GraphQL -> startThreatHunt: StartThreatHuntReply! (type)
        public static string StartThreatHunt_TypedFieldSpec(StartThreatHuntReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startThreatHunt" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartThreatHunt_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartThreatHunt((StartThreatHuntReply)fieldSpecObj);
        }
        public static string StartThreatHunt(StartThreatHuntReply fieldSpec)
        {
            return StartThreatHunt_TypedFieldSpec(fieldSpec);
        }
        public static string StartThreatHunt(object fieldSpecObj)
        {
            return StartThreatHunt_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartThreatHuntFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new StartThreatHuntReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<UpgradeJobReplyWithUuid>? StartUpgradeBatchJob
        // GraphQL -> startUpgradeBatchJob: [UpgradeJobReplyWithUuid!]! (type)
        public static string StartUpgradeBatchJob_TypedFieldSpec(List<UpgradeJobReplyWithUuid> fieldSpec)
        {
            string args = "\n(\nlistClusterUuid: $listClusterUuid\nmode: $mode\naction: $action\nversion: $version\ncontext_tag: $context_tag\n)";
            return "startUpgradeBatchJob" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartUpgradeBatchJob_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartUpgradeBatchJob((List<UpgradeJobReplyWithUuid>)fieldSpecObj);
        }
        public static string StartUpgradeBatchJob(List<UpgradeJobReplyWithUuid> fieldSpec)
        {
            return StartUpgradeBatchJob_TypedFieldSpec(fieldSpec);
        }
        public static string StartUpgradeBatchJob(object fieldSpecObj)
        {
            return StartUpgradeBatchJob_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartUpgradeBatchJobFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<UpgradeJobReplyWithUuid>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? StartVolumeGroupMount
        // GraphQL -> startVolumeGroupMount: AsyncRequestStatus! (type)
        public static string StartVolumeGroupMount_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "startVolumeGroupMount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StartVolumeGroupMount_ObjectFieldSpec(object fieldSpecObj)
        {
            return StartVolumeGroupMount((AsyncRequestStatus)fieldSpecObj);
        }
        public static string StartVolumeGroupMount(AsyncRequestStatus fieldSpec)
        {
            return StartVolumeGroupMount_TypedFieldSpec(fieldSpec);
        }
        public static string StartVolumeGroupMount(object fieldSpecObj)
        {
            return StartVolumeGroupMount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StartVolumeGroupMountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> StopJobInstanceReply? StopJobInstance
        // GraphQL -> stopJobInstance: StopJobInstanceReply! (type)
        public static string StopJobInstance_TypedFieldSpec(StopJobInstanceReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "stopJobInstance" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string StopJobInstance_ObjectFieldSpec(object fieldSpecObj)
        {
            return StopJobInstance((StopJobInstanceReply)fieldSpecObj);
        }
        public static string StopJobInstance(StopJobInstanceReply fieldSpec)
        {
            return StopJobInstance_TypedFieldSpec(fieldSpec);
        }
        public static string StopJobInstance(object fieldSpecObj)
        {
            return StopJobInstance_ObjectFieldSpec(fieldSpecObj);
        }
        public static object StopJobInstanceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new StopJobInstanceReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SupportPortalLoginReply? SupportPortalLogin
        // GraphQL -> supportPortalLogin: SupportPortalLoginReply! (type)
        public static string SupportPortalLogin_TypedFieldSpec(SupportPortalLoginReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "supportPortalLogin" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string SupportPortalLogin_ObjectFieldSpec(object fieldSpecObj)
        {
            return SupportPortalLogin((SupportPortalLoginReply)fieldSpecObj);
        }
        public static string SupportPortalLogin(SupportPortalLoginReply fieldSpec)
        {
            return SupportPortalLogin_TypedFieldSpec(fieldSpec);
        }
        public static string SupportPortalLogin(object fieldSpecObj)
        {
            return SupportPortalLogin_ObjectFieldSpec(fieldSpecObj);
        }
        public static object SupportPortalLoginFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SupportPortalLoginReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SwitchProductToOnboardingModeReply? SwitchProductToOnboardingMode
        // GraphQL -> switchProductToOnboardingMode: SwitchProductToOnboardingModeReply! (type)
        public static string SwitchProductToOnboardingMode_TypedFieldSpec(SwitchProductToOnboardingModeReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "switchProductToOnboardingMode" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string SwitchProductToOnboardingMode_ObjectFieldSpec(object fieldSpecObj)
        {
            return SwitchProductToOnboardingMode((SwitchProductToOnboardingModeReply)fieldSpecObj);
        }
        public static string SwitchProductToOnboardingMode(SwitchProductToOnboardingModeReply fieldSpec)
        {
            return SwitchProductToOnboardingMode_TypedFieldSpec(fieldSpec);
        }
        public static string SwitchProductToOnboardingMode(object fieldSpecObj)
        {
            return SwitchProductToOnboardingMode_ObjectFieldSpec(fieldSpecObj);
        }
        public static object SwitchProductToOnboardingModeFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SwitchProductToOnboardingModeReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? TakeManagedVolumeOnDemandSnapshot
        // GraphQL -> takeManagedVolumeOnDemandSnapshot: AsyncRequestStatus! (type)
        public static string TakeManagedVolumeOnDemandSnapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "takeManagedVolumeOnDemandSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string TakeManagedVolumeOnDemandSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return TakeManagedVolumeOnDemandSnapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string TakeManagedVolumeOnDemandSnapshot(AsyncRequestStatus fieldSpec)
        {
            return TakeManagedVolumeOnDemandSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string TakeManagedVolumeOnDemandSnapshot(object fieldSpecObj)
        {
            return TakeManagedVolumeOnDemandSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object TakeManagedVolumeOnDemandSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? TakeMssqlLogBackup
        // GraphQL -> takeMssqlLogBackup: AsyncRequestStatus! (type)
        public static string TakeMssqlLogBackup_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "takeMssqlLogBackup" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string TakeMssqlLogBackup_ObjectFieldSpec(object fieldSpecObj)
        {
            return TakeMssqlLogBackup((AsyncRequestStatus)fieldSpecObj);
        }
        public static string TakeMssqlLogBackup(AsyncRequestStatus fieldSpec)
        {
            return TakeMssqlLogBackup_TypedFieldSpec(fieldSpec);
        }
        public static string TakeMssqlLogBackup(object fieldSpecObj)
        {
            return TakeMssqlLogBackup_ObjectFieldSpec(fieldSpecObj);
        }
        public static object TakeMssqlLogBackupFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? TakeOnDemandOracleDatabaseSnapshot
        // GraphQL -> takeOnDemandOracleDatabaseSnapshot: AsyncRequestStatus! (type)
        public static string TakeOnDemandOracleDatabaseSnapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "takeOnDemandOracleDatabaseSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string TakeOnDemandOracleDatabaseSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return TakeOnDemandOracleDatabaseSnapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string TakeOnDemandOracleDatabaseSnapshot(AsyncRequestStatus fieldSpec)
        {
            return TakeOnDemandOracleDatabaseSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string TakeOnDemandOracleDatabaseSnapshot(object fieldSpecObj)
        {
            return TakeOnDemandOracleDatabaseSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object TakeOnDemandOracleDatabaseSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? TakeOnDemandOracleLogSnapshot
        // GraphQL -> takeOnDemandOracleLogSnapshot: AsyncRequestStatus! (type)
        public static string TakeOnDemandOracleLogSnapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "takeOnDemandOracleLogSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string TakeOnDemandOracleLogSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return TakeOnDemandOracleLogSnapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string TakeOnDemandOracleLogSnapshot(AsyncRequestStatus fieldSpec)
        {
            return TakeOnDemandOracleLogSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string TakeOnDemandOracleLogSnapshot(object fieldSpecObj)
        {
            return TakeOnDemandOracleLogSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object TakeOnDemandOracleLogSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TakeOnDemandSnapshotReply? TakeOnDemandSnapshot
        // GraphQL -> takeOnDemandSnapshot: TakeOnDemandSnapshotReply! (type)
        public static string TakeOnDemandSnapshot_TypedFieldSpec(TakeOnDemandSnapshotReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "takeOnDemandSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string TakeOnDemandSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return TakeOnDemandSnapshot((TakeOnDemandSnapshotReply)fieldSpecObj);
        }
        public static string TakeOnDemandSnapshot(TakeOnDemandSnapshotReply fieldSpec)
        {
            return TakeOnDemandSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string TakeOnDemandSnapshot(object fieldSpecObj)
        {
            return TakeOnDemandSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object TakeOnDemandSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new TakeOnDemandSnapshotReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TestExistingWebhookReply? TestExistingWebhook
        // GraphQL -> testExistingWebhook: TestExistingWebhookReply! (type)
        public static string TestExistingWebhook_TypedFieldSpec(TestExistingWebhookReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "testExistingWebhook" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string TestExistingWebhook_ObjectFieldSpec(object fieldSpecObj)
        {
            return TestExistingWebhook((TestExistingWebhookReply)fieldSpecObj);
        }
        public static string TestExistingWebhook(TestExistingWebhookReply fieldSpec)
        {
            return TestExistingWebhook_TypedFieldSpec(fieldSpec);
        }
        public static string TestExistingWebhook(object fieldSpecObj)
        {
            return TestExistingWebhook_ObjectFieldSpec(fieldSpecObj);
        }
        public static object TestExistingWebhookFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new TestExistingWebhookReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TestSyslogExportRuleReply? TestSyslogExportRule
        // GraphQL -> testSyslogExportRule: TestSyslogExportRuleReply! (type)
        public static string TestSyslogExportRule_TypedFieldSpec(TestSyslogExportRuleReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "testSyslogExportRule" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string TestSyslogExportRule_ObjectFieldSpec(object fieldSpecObj)
        {
            return TestSyslogExportRule((TestSyslogExportRuleReply)fieldSpecObj);
        }
        public static string TestSyslogExportRule(TestSyslogExportRuleReply fieldSpec)
        {
            return TestSyslogExportRule_TypedFieldSpec(fieldSpec);
        }
        public static string TestSyslogExportRule(object fieldSpecObj)
        {
            return TestSyslogExportRule_ObjectFieldSpec(fieldSpecObj);
        }
        public static object TestSyslogExportRuleFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new TestSyslogExportRuleReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TestWebhookReply? TestWebhook
        // GraphQL -> testWebhook: TestWebhookReply! (type)
        public static string TestWebhook_TypedFieldSpec(TestWebhookReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "testWebhook" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string TestWebhook_ObjectFieldSpec(object fieldSpecObj)
        {
            return TestWebhook((TestWebhookReply)fieldSpecObj);
        }
        public static string TestWebhook(TestWebhookReply fieldSpec)
        {
            return TestWebhook_TypedFieldSpec(fieldSpec);
        }
        public static string TestWebhook(object fieldSpecObj)
        {
            return TestWebhook_ObjectFieldSpec(fieldSpecObj);
        }
        public static object TestWebhookFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new TestWebhookReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? TriggerCloudComputeConnectivityCheck
        // GraphQL -> triggerCloudComputeConnectivityCheck: AsyncRequestStatus! (type)
        public static string TriggerCloudComputeConnectivityCheck_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "triggerCloudComputeConnectivityCheck" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string TriggerCloudComputeConnectivityCheck_ObjectFieldSpec(object fieldSpecObj)
        {
            return TriggerCloudComputeConnectivityCheck((AsyncRequestStatus)fieldSpecObj);
        }
        public static string TriggerCloudComputeConnectivityCheck(AsyncRequestStatus fieldSpec)
        {
            return TriggerCloudComputeConnectivityCheck_TypedFieldSpec(fieldSpec);
        }
        public static string TriggerCloudComputeConnectivityCheck(object fieldSpecObj)
        {
            return TriggerCloudComputeConnectivityCheck_ObjectFieldSpec(fieldSpecObj);
        }
        public static object TriggerCloudComputeConnectivityCheckFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TriggerExocomputeHealthCheckReply? TriggerExocomputeHealthCheck
        // GraphQL -> triggerExocomputeHealthCheck: TriggerExocomputeHealthCheckReply! (type)
        public static string TriggerExocomputeHealthCheck_TypedFieldSpec(TriggerExocomputeHealthCheckReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "triggerExocomputeHealthCheck" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string TriggerExocomputeHealthCheck_ObjectFieldSpec(object fieldSpecObj)
        {
            return TriggerExocomputeHealthCheck((TriggerExocomputeHealthCheckReply)fieldSpecObj);
        }
        public static string TriggerExocomputeHealthCheck(TriggerExocomputeHealthCheckReply fieldSpec)
        {
            return TriggerExocomputeHealthCheck_TypedFieldSpec(fieldSpec);
        }
        public static string TriggerExocomputeHealthCheck(object fieldSpecObj)
        {
            return TriggerExocomputeHealthCheck_ObjectFieldSpec(fieldSpecObj);
        }
        public static object TriggerExocomputeHealthCheckFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new TriggerExocomputeHealthCheckReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TriggerRansomwareDetectionReply? TriggerRansomwareDetection
        // GraphQL -> triggerRansomwareDetection: TriggerRansomwareDetectionReply! (type)
        public static string TriggerRansomwareDetection_TypedFieldSpec(TriggerRansomwareDetectionReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "triggerRansomwareDetection" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string TriggerRansomwareDetection_ObjectFieldSpec(object fieldSpecObj)
        {
            return TriggerRansomwareDetection((TriggerRansomwareDetectionReply)fieldSpecObj);
        }
        public static string TriggerRansomwareDetection(TriggerRansomwareDetectionReply fieldSpec)
        {
            return TriggerRansomwareDetection_TypedFieldSpec(fieldSpec);
        }
        public static string TriggerRansomwareDetection(object fieldSpecObj)
        {
            return TriggerRansomwareDetection_ObjectFieldSpec(fieldSpecObj);
        }
        public static object TriggerRansomwareDetectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new TriggerRansomwareDetectionReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? UnconfigureSapHanaRestore
        // GraphQL -> unconfigureSapHanaRestore: AsyncRequestStatus! (type)
        public static string UnconfigureSapHanaRestore_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "unconfigureSapHanaRestore" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UnconfigureSapHanaRestore_ObjectFieldSpec(object fieldSpecObj)
        {
            return UnconfigureSapHanaRestore((AsyncRequestStatus)fieldSpecObj);
        }
        public static string UnconfigureSapHanaRestore(AsyncRequestStatus fieldSpec)
        {
            return UnconfigureSapHanaRestore_TypedFieldSpec(fieldSpec);
        }
        public static string UnconfigureSapHanaRestore(object fieldSpecObj)
        {
            return UnconfigureSapHanaRestore_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UnconfigureSapHanaRestoreFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? UninstallIoFilter
        // GraphQL -> uninstallIoFilter: RequestSuccess! (type)
        public static string UninstallIoFilter_TypedFieldSpec(RequestSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "uninstallIoFilter" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UninstallIoFilter_ObjectFieldSpec(object fieldSpecObj)
        {
            return UninstallIoFilter((RequestSuccess)fieldSpecObj);
        }
        public static string UninstallIoFilter(RequestSuccess fieldSpec)
        {
            return UninstallIoFilter_TypedFieldSpec(fieldSpec);
        }
        public static string UninstallIoFilter(object fieldSpecObj)
        {
            return UninstallIoFilter_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UninstallIoFilterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UnmapAzureCloudAccountExocomputeSubscriptionReply? UnmapAzureCloudAccountExocomputeSubscription
        // GraphQL -> unmapAzureCloudAccountExocomputeSubscription: UnmapAzureCloudAccountExocomputeSubscriptionReply! (type)
        public static string UnmapAzureCloudAccountExocomputeSubscription_TypedFieldSpec(UnmapAzureCloudAccountExocomputeSubscriptionReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "unmapAzureCloudAccountExocomputeSubscription" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UnmapAzureCloudAccountExocomputeSubscription_ObjectFieldSpec(object fieldSpecObj)
        {
            return UnmapAzureCloudAccountExocomputeSubscription((UnmapAzureCloudAccountExocomputeSubscriptionReply)fieldSpecObj);
        }
        public static string UnmapAzureCloudAccountExocomputeSubscription(UnmapAzureCloudAccountExocomputeSubscriptionReply fieldSpec)
        {
            return UnmapAzureCloudAccountExocomputeSubscription_TypedFieldSpec(fieldSpec);
        }
        public static string UnmapAzureCloudAccountExocomputeSubscription(object fieldSpecObj)
        {
            return UnmapAzureCloudAccountExocomputeSubscription_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UnmapAzureCloudAccountExocomputeSubscriptionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UnmapAzureCloudAccountExocomputeSubscriptionReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UnmapCloudAccountExocomputeAccountReply? UnmapCloudAccountExocomputeAccount
        // GraphQL -> unmapCloudAccountExocomputeAccount: UnmapCloudAccountExocomputeAccountReply! (type)
        public static string UnmapCloudAccountExocomputeAccount_TypedFieldSpec(UnmapCloudAccountExocomputeAccountReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "unmapCloudAccountExocomputeAccount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UnmapCloudAccountExocomputeAccount_ObjectFieldSpec(object fieldSpecObj)
        {
            return UnmapCloudAccountExocomputeAccount((UnmapCloudAccountExocomputeAccountReply)fieldSpecObj);
        }
        public static string UnmapCloudAccountExocomputeAccount(UnmapCloudAccountExocomputeAccountReply fieldSpec)
        {
            return UnmapCloudAccountExocomputeAccount_TypedFieldSpec(fieldSpec);
        }
        public static string UnmapCloudAccountExocomputeAccount(object fieldSpecObj)
        {
            return UnmapCloudAccountExocomputeAccount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UnmapCloudAccountExocomputeAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UnmapCloudAccountExocomputeAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AgentDeploymentSettings? UpdateAgentDeploymentSetting
        // GraphQL -> updateAgentDeploymentSetting: AgentDeploymentSettings! (type)
        public static string UpdateAgentDeploymentSetting_TypedFieldSpec(AgentDeploymentSettings fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateAgentDeploymentSetting" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateAgentDeploymentSetting_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateAgentDeploymentSetting((AgentDeploymentSettings)fieldSpecObj);
        }
        public static string UpdateAgentDeploymentSetting(AgentDeploymentSettings fieldSpec)
        {
            return UpdateAgentDeploymentSetting_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateAgentDeploymentSetting(object fieldSpecObj)
        {
            return UpdateAgentDeploymentSetting_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateAgentDeploymentSettingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AgentDeploymentSettings() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateAutoEnablePolicyClusterConfigReply? UpdateAutoEnablePolicyClusterConfig
        // GraphQL -> updateAutoEnablePolicyClusterConfig: UpdateAutoEnablePolicyClusterConfigReply! (type)
        public static string UpdateAutoEnablePolicyClusterConfig_TypedFieldSpec(UpdateAutoEnablePolicyClusterConfigReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateAutoEnablePolicyClusterConfig" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateAutoEnablePolicyClusterConfig_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateAutoEnablePolicyClusterConfig((UpdateAutoEnablePolicyClusterConfigReply)fieldSpecObj);
        }
        public static string UpdateAutoEnablePolicyClusterConfig(UpdateAutoEnablePolicyClusterConfigReply fieldSpec)
        {
            return UpdateAutoEnablePolicyClusterConfig_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateAutoEnablePolicyClusterConfig(object fieldSpecObj)
        {
            return UpdateAutoEnablePolicyClusterConfig_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateAutoEnablePolicyClusterConfigFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateAutoEnablePolicyClusterConfigReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TargetMapping? UpdateAutomaticAwsTargetMapping
        // GraphQL -> updateAutomaticAwsTargetMapping: TargetMapping! (type)
        public static string UpdateAutomaticAwsTargetMapping_TypedFieldSpec(TargetMapping fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateAutomaticAwsTargetMapping" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateAutomaticAwsTargetMapping_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateAutomaticAwsTargetMapping((TargetMapping)fieldSpecObj);
        }
        public static string UpdateAutomaticAwsTargetMapping(TargetMapping fieldSpec)
        {
            return UpdateAutomaticAwsTargetMapping_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateAutomaticAwsTargetMapping(object fieldSpecObj)
        {
            return UpdateAutomaticAwsTargetMapping_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateAutomaticAwsTargetMappingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new TargetMapping() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TargetMapping? UpdateAutomaticAzureTargetMapping
        // GraphQL -> updateAutomaticAzureTargetMapping: TargetMapping! (type)
        public static string UpdateAutomaticAzureTargetMapping_TypedFieldSpec(TargetMapping fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateAutomaticAzureTargetMapping" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateAutomaticAzureTargetMapping_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateAutomaticAzureTargetMapping((TargetMapping)fieldSpecObj);
        }
        public static string UpdateAutomaticAzureTargetMapping(TargetMapping fieldSpec)
        {
            return UpdateAutomaticAzureTargetMapping_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateAutomaticAzureTargetMapping(object fieldSpecObj)
        {
            return UpdateAutomaticAzureTargetMapping_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateAutomaticAzureTargetMappingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new TargetMapping() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateAwsCloudAccountFeatureReply? UpdateAwsCloudAccountFeature
        // GraphQL -> updateAwsCloudAccountFeature: UpdateAwsCloudAccountFeatureReply! (type)
        public static string UpdateAwsCloudAccountFeature_TypedFieldSpec(UpdateAwsCloudAccountFeatureReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateAwsCloudAccountFeature" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateAwsCloudAccountFeature_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateAwsCloudAccountFeature((UpdateAwsCloudAccountFeatureReply)fieldSpecObj);
        }
        public static string UpdateAwsCloudAccountFeature(UpdateAwsCloudAccountFeatureReply fieldSpec)
        {
            return UpdateAwsCloudAccountFeature_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateAwsCloudAccountFeature(object fieldSpecObj)
        {
            return UpdateAwsCloudAccountFeature_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateAwsCloudAccountFeatureFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateAwsCloudAccountFeatureReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsComputeSettings? UpdateAwsComputeSetting
        // GraphQL -> updateAwsComputeSetting: AwsComputeSettings! (type)
        public static string UpdateAwsComputeSetting_TypedFieldSpec(AwsComputeSettings fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateAwsComputeSetting" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateAwsComputeSetting_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateAwsComputeSetting((AwsComputeSettings)fieldSpecObj);
        }
        public static string UpdateAwsComputeSetting(AwsComputeSettings fieldSpec)
        {
            return UpdateAwsComputeSetting_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateAwsComputeSetting(object fieldSpecObj)
        {
            return UpdateAwsComputeSetting_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateAwsComputeSettingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AwsComputeSettings() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateAwsExocomputeConfigsReply? UpdateAwsExocomputeConfigs
        // GraphQL -> updateAwsExocomputeConfigs: UpdateAwsExocomputeConfigsReply! (type)
        public static string UpdateAwsExocomputeConfigs_TypedFieldSpec(UpdateAwsExocomputeConfigsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateAwsExocomputeConfigs" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateAwsExocomputeConfigs_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateAwsExocomputeConfigs((UpdateAwsExocomputeConfigsReply)fieldSpecObj);
        }
        public static string UpdateAwsExocomputeConfigs(UpdateAwsExocomputeConfigsReply fieldSpec)
        {
            return UpdateAwsExocomputeConfigs_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateAwsExocomputeConfigs(object fieldSpecObj)
        {
            return UpdateAwsExocomputeConfigs_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateAwsExocomputeConfigsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateAwsExocomputeConfigsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateAzureCloudAccountReply? UpdateAzureCloudAccount
        // GraphQL -> updateAzureCloudAccount: UpdateAzureCloudAccountReply! (type)
        public static string UpdateAzureCloudAccount_TypedFieldSpec(UpdateAzureCloudAccountReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateAzureCloudAccount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateAzureCloudAccount_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateAzureCloudAccount((UpdateAzureCloudAccountReply)fieldSpecObj);
        }
        public static string UpdateAzureCloudAccount(UpdateAzureCloudAccountReply fieldSpec)
        {
            return UpdateAzureCloudAccount_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateAzureCloudAccount(object fieldSpecObj)
        {
            return UpdateAzureCloudAccount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateAzureCloudAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateAzureCloudAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateBadDiskLedStatusReply? UpdateBadDiskLedStatus
        // GraphQL -> updateBadDiskLedStatus: UpdateBadDiskLedStatusReply! (type)
        public static string UpdateBadDiskLedStatus_TypedFieldSpec(UpdateBadDiskLedStatusReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateBadDiskLedStatus" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateBadDiskLedStatus_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateBadDiskLedStatus((UpdateBadDiskLedStatusReply)fieldSpecObj);
        }
        public static string UpdateBadDiskLedStatus(UpdateBadDiskLedStatusReply fieldSpec)
        {
            return UpdateBadDiskLedStatus_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateBadDiskLedStatus(object fieldSpecObj)
        {
            return UpdateBadDiskLedStatus_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateBadDiskLedStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateBadDiskLedStatusReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicAsyncResponse? UpdateCassandraSource
        // GraphQL -> updateCassandraSource: MosaicAsyncResponse! (type)
        public static string UpdateCassandraSource_TypedFieldSpec(MosaicAsyncResponse fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateCassandraSource" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateCassandraSource_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateCassandraSource((MosaicAsyncResponse)fieldSpecObj);
        }
        public static string UpdateCassandraSource(MosaicAsyncResponse fieldSpec)
        {
            return UpdateCassandraSource_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateCassandraSource(object fieldSpecObj)
        {
            return UpdateCassandraSource_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateCassandraSourceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MosaicAsyncResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateCertificateHostReply? UpdateCertificateHost
        // GraphQL -> updateCertificateHost: UpdateCertificateHostReply! (type)
        public static string UpdateCertificateHost_TypedFieldSpec(UpdateCertificateHostReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateCertificateHost" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateCertificateHost_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateCertificateHost((UpdateCertificateHostReply)fieldSpecObj);
        }
        public static string UpdateCertificateHost(UpdateCertificateHostReply fieldSpec)
        {
            return UpdateCertificateHost_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateCertificateHost(object fieldSpecObj)
        {
            return UpdateCertificateHost_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateCertificateHostFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateCertificateHostReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateCloudNativeAwsStorageSettingReply? UpdateCloudNativeAwsStorageSetting
        // GraphQL -> updateCloudNativeAwsStorageSetting: UpdateCloudNativeAwsStorageSettingReply! (type)
        public static string UpdateCloudNativeAwsStorageSetting_TypedFieldSpec(UpdateCloudNativeAwsStorageSettingReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateCloudNativeAwsStorageSetting" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateCloudNativeAwsStorageSetting_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateCloudNativeAwsStorageSetting((UpdateCloudNativeAwsStorageSettingReply)fieldSpecObj);
        }
        public static string UpdateCloudNativeAwsStorageSetting(UpdateCloudNativeAwsStorageSettingReply fieldSpec)
        {
            return UpdateCloudNativeAwsStorageSetting_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateCloudNativeAwsStorageSetting(object fieldSpecObj)
        {
            return UpdateCloudNativeAwsStorageSetting_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateCloudNativeAwsStorageSettingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateCloudNativeAwsStorageSettingReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateCloudNativeAzureStorageSettingReply? UpdateCloudNativeAzureStorageSetting
        // GraphQL -> updateCloudNativeAzureStorageSetting: UpdateCloudNativeAzureStorageSettingReply! (type)
        public static string UpdateCloudNativeAzureStorageSetting_TypedFieldSpec(UpdateCloudNativeAzureStorageSettingReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateCloudNativeAzureStorageSetting" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateCloudNativeAzureStorageSetting_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateCloudNativeAzureStorageSetting((UpdateCloudNativeAzureStorageSettingReply)fieldSpecObj);
        }
        public static string UpdateCloudNativeAzureStorageSetting(UpdateCloudNativeAzureStorageSettingReply fieldSpec)
        {
            return UpdateCloudNativeAzureStorageSetting_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateCloudNativeAzureStorageSetting(object fieldSpecObj)
        {
            return UpdateCloudNativeAzureStorageSetting_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateCloudNativeAzureStorageSettingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateCloudNativeAzureStorageSettingReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateCloudNativeIndexingStatusReply? UpdateCloudNativeIndexingStatus
        // GraphQL -> updateCloudNativeIndexingStatus: UpdateCloudNativeIndexingStatusReply! (type)
        public static string UpdateCloudNativeIndexingStatus_TypedFieldSpec(UpdateCloudNativeIndexingStatusReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateCloudNativeIndexingStatus" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateCloudNativeIndexingStatus_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateCloudNativeIndexingStatus((UpdateCloudNativeIndexingStatusReply)fieldSpecObj);
        }
        public static string UpdateCloudNativeIndexingStatus(UpdateCloudNativeIndexingStatusReply fieldSpec)
        {
            return UpdateCloudNativeIndexingStatus_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateCloudNativeIndexingStatus(object fieldSpecObj)
        {
            return UpdateCloudNativeIndexingStatus_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateCloudNativeIndexingStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateCloudNativeIndexingStatusReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateCloudNativeRcvAzureStorageSettingReply? UpdateCloudNativeRcvAzureStorageSetting
        // GraphQL -> updateCloudNativeRcvAzureStorageSetting: UpdateCloudNativeRcvAzureStorageSettingReply! (type)
        public static string UpdateCloudNativeRcvAzureStorageSetting_TypedFieldSpec(UpdateCloudNativeRcvAzureStorageSettingReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateCloudNativeRcvAzureStorageSetting" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateCloudNativeRcvAzureStorageSetting_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateCloudNativeRcvAzureStorageSetting((UpdateCloudNativeRcvAzureStorageSettingReply)fieldSpecObj);
        }
        public static string UpdateCloudNativeRcvAzureStorageSetting(UpdateCloudNativeRcvAzureStorageSettingReply fieldSpec)
        {
            return UpdateCloudNativeRcvAzureStorageSetting_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateCloudNativeRcvAzureStorageSetting(object fieldSpecObj)
        {
            return UpdateCloudNativeRcvAzureStorageSetting_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateCloudNativeRcvAzureStorageSettingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateCloudNativeRcvAzureStorageSettingReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateClusterDefaultAddressReply? UpdateClusterDefaultAddress
        // GraphQL -> updateClusterDefaultAddress: UpdateClusterDefaultAddressReply! (type)
        public static string UpdateClusterDefaultAddress_TypedFieldSpec(UpdateClusterDefaultAddressReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateClusterDefaultAddress" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateClusterDefaultAddress_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateClusterDefaultAddress((UpdateClusterDefaultAddressReply)fieldSpecObj);
        }
        public static string UpdateClusterDefaultAddress(UpdateClusterDefaultAddressReply fieldSpec)
        {
            return UpdateClusterDefaultAddress_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateClusterDefaultAddress(object fieldSpecObj)
        {
            return UpdateClusterDefaultAddress_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateClusterDefaultAddressFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateClusterDefaultAddressReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Cluster? UpdateClusterLocation
        // GraphQL -> updateClusterLocation: Cluster! (type)
        public static string UpdateClusterLocation_TypedFieldSpec(Cluster fieldSpec)
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nclusterLocation: $clusterLocation\n)";
            return "updateClusterLocation" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateClusterLocation_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateClusterLocation((Cluster)fieldSpecObj);
        }
        public static string UpdateClusterLocation(Cluster fieldSpec)
        {
            return UpdateClusterLocation_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateClusterLocation(object fieldSpecObj)
        {
            return UpdateClusterLocation_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateClusterLocationFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new Cluster() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? UpdateClusterNtpServers
        // GraphQL -> updateClusterNtpServers: ResponseSuccess! (type)
        public static string UpdateClusterNtpServers_TypedFieldSpec(ResponseSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateClusterNtpServers" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateClusterNtpServers_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateClusterNtpServers((ResponseSuccess)fieldSpecObj);
        }
        public static string UpdateClusterNtpServers(ResponseSuccess fieldSpec)
        {
            return UpdateClusterNtpServers_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateClusterNtpServers(object fieldSpecObj)
        {
            return UpdateClusterNtpServers_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateClusterNtpServersFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateClusterPauseStatusReply? UpdateClusterPauseStatus
        // GraphQL -> updateClusterPauseStatus: UpdateClusterPauseStatusReply! (type)
        public static string UpdateClusterPauseStatus_TypedFieldSpec(UpdateClusterPauseStatusReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateClusterPauseStatus" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateClusterPauseStatus_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateClusterPauseStatus((UpdateClusterPauseStatusReply)fieldSpecObj);
        }
        public static string UpdateClusterPauseStatus(UpdateClusterPauseStatusReply fieldSpec)
        {
            return UpdateClusterPauseStatus_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateClusterPauseStatus(object fieldSpecObj)
        {
            return UpdateClusterPauseStatus_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateClusterPauseStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateClusterPauseStatusReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateClusterSettingsReply? UpdateClusterSettings
        // GraphQL -> updateClusterSettings: UpdateClusterSettingsReply! (type)
        public static string UpdateClusterSettings_TypedFieldSpec(UpdateClusterSettingsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateClusterSettings" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateClusterSettings_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateClusterSettings((UpdateClusterSettingsReply)fieldSpecObj);
        }
        public static string UpdateClusterSettings(UpdateClusterSettingsReply fieldSpec)
        {
            return UpdateClusterSettings_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateClusterSettings(object fieldSpecObj)
        {
            return UpdateClusterSettings_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateClusterSettingsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateClusterSettingsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Analyzer? UpdateCustomAnalyzer
        // GraphQL -> updateCustomAnalyzer: Analyzer! (type)
        public static string UpdateCustomAnalyzer_TypedFieldSpec(Analyzer fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateCustomAnalyzer" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateCustomAnalyzer_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateCustomAnalyzer((Analyzer)fieldSpecObj);
        }
        public static string UpdateCustomAnalyzer(Analyzer fieldSpec)
        {
            return UpdateCustomAnalyzer_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateCustomAnalyzer(object fieldSpecObj)
        {
            return UpdateCustomAnalyzer_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateCustomAnalyzerFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new Analyzer() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateCustomReportReply? UpdateCustomReport
        // GraphQL -> updateCustomReport: UpdateCustomReportReply! (type)
        public static string UpdateCustomReport_TypedFieldSpec(UpdateCustomReportReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateCustomReport" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateCustomReport_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateCustomReport((UpdateCustomReportReply)fieldSpecObj);
        }
        public static string UpdateCustomReport(UpdateCustomReportReply fieldSpec)
        {
            return UpdateCustomReport_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateCustomReport(object fieldSpecObj)
        {
            return UpdateCustomReport_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateCustomReportFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateCustomReportReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateCustomerAppPermissionsReply? UpdateCustomerAppPermissions
        // GraphQL -> updateCustomerAppPermissions: UpdateCustomerAppPermissionsReply! (type)
        public static string UpdateCustomerAppPermissions_TypedFieldSpec(UpdateCustomerAppPermissionsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateCustomerAppPermissions" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateCustomerAppPermissions_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateCustomerAppPermissions((UpdateCustomerAppPermissionsReply)fieldSpecObj);
        }
        public static string UpdateCustomerAppPermissions(UpdateCustomerAppPermissionsReply fieldSpec)
        {
            return UpdateCustomerAppPermissions_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateCustomerAppPermissions(object fieldSpecObj)
        {
            return UpdateCustomerAppPermissions_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateCustomerAppPermissionsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateCustomerAppPermissionsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DbLogReportProperties? UpdateDatabaseLogReportingPropertiesForCluster
        // GraphQL -> updateDatabaseLogReportingPropertiesForCluster: DbLogReportProperties! (type)
        public static string UpdateDatabaseLogReportingPropertiesForCluster_TypedFieldSpec(DbLogReportProperties fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateDatabaseLogReportingPropertiesForCluster" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateDatabaseLogReportingPropertiesForCluster_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateDatabaseLogReportingPropertiesForCluster((DbLogReportProperties)fieldSpecObj);
        }
        public static string UpdateDatabaseLogReportingPropertiesForCluster(DbLogReportProperties fieldSpec)
        {
            return UpdateDatabaseLogReportingPropertiesForCluster_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateDatabaseLogReportingPropertiesForCluster(object fieldSpecObj)
        {
            return UpdateDatabaseLogReportingPropertiesForCluster_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateDatabaseLogReportingPropertiesForClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DbLogReportProperties() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateDistributionListDigestReply? UpdateDistributionListDigest
        // GraphQL -> updateDistributionListDigest: UpdateDistributionListDigestReply! (type)
        public static string UpdateDistributionListDigest_TypedFieldSpec(UpdateDistributionListDigestReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateDistributionListDigest" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateDistributionListDigest_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateDistributionListDigest((UpdateDistributionListDigestReply)fieldSpecObj);
        }
        public static string UpdateDistributionListDigest(UpdateDistributionListDigestReply fieldSpec)
        {
            return UpdateDistributionListDigest_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateDistributionListDigest(object fieldSpecObj)
        {
            return UpdateDistributionListDigest_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateDistributionListDigestFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateDistributionListDigestReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? UpdateDnsServersAndSearchDomains
        // GraphQL -> updateDnsServersAndSearchDomains: ResponseSuccess! (type)
        public static string UpdateDnsServersAndSearchDomains_TypedFieldSpec(ResponseSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateDnsServersAndSearchDomains" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateDnsServersAndSearchDomains_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateDnsServersAndSearchDomains((ResponseSuccess)fieldSpecObj);
        }
        public static string UpdateDnsServersAndSearchDomains(ResponseSuccess fieldSpec)
        {
            return UpdateDnsServersAndSearchDomains_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateDnsServersAndSearchDomains(object fieldSpecObj)
        {
            return UpdateDnsServersAndSearchDomains_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateDnsServersAndSearchDomainsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateEventDigestReply? UpdateEventDigest
        // GraphQL -> updateEventDigest: UpdateEventDigestReply! (type)
        public static string UpdateEventDigest_TypedFieldSpec(UpdateEventDigestReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateEventDigest" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateEventDigest_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateEventDigest((UpdateEventDigestReply)fieldSpecObj);
        }
        public static string UpdateEventDigest(UpdateEventDigestReply fieldSpec)
        {
            return UpdateEventDigest_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateEventDigest(object fieldSpecObj)
        {
            return UpdateEventDigest_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateEventDigestFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateEventDigestReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateFailoverClusterReply? UpdateFailoverCluster
        // GraphQL -> updateFailoverCluster: UpdateFailoverClusterReply! (type)
        public static string UpdateFailoverCluster_TypedFieldSpec(UpdateFailoverClusterReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateFailoverCluster" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateFailoverCluster_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateFailoverCluster((UpdateFailoverClusterReply)fieldSpecObj);
        }
        public static string UpdateFailoverCluster(UpdateFailoverClusterReply fieldSpec)
        {
            return UpdateFailoverCluster_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateFailoverCluster(object fieldSpecObj)
        {
            return UpdateFailoverCluster_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateFailoverClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateFailoverClusterReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateFailoverClusterAppReply? UpdateFailoverClusterApp
        // GraphQL -> updateFailoverClusterApp: UpdateFailoverClusterAppReply! (type)
        public static string UpdateFailoverClusterApp_TypedFieldSpec(UpdateFailoverClusterAppReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateFailoverClusterApp" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateFailoverClusterApp_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateFailoverClusterApp((UpdateFailoverClusterAppReply)fieldSpecObj);
        }
        public static string UpdateFailoverClusterApp(UpdateFailoverClusterAppReply fieldSpec)
        {
            return UpdateFailoverClusterApp_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateFailoverClusterApp(object fieldSpecObj)
        {
            return UpdateFailoverClusterApp_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateFailoverClusterAppFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateFailoverClusterAppReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateFloatingIpsReply? UpdateFloatingIps
        // GraphQL -> updateFloatingIps: UpdateFloatingIpsReply! (type)
        public static string UpdateFloatingIps_TypedFieldSpec(UpdateFloatingIpsReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateFloatingIps" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateFloatingIps_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateFloatingIps((UpdateFloatingIpsReply)fieldSpecObj);
        }
        public static string UpdateFloatingIps(UpdateFloatingIpsReply fieldSpec)
        {
            return UpdateFloatingIps_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateFloatingIps(object fieldSpecObj)
        {
            return UpdateFloatingIps_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateFloatingIpsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateFloatingIpsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateGlobalCertificateReply? UpdateGlobalCertificate
        // GraphQL -> updateGlobalCertificate: UpdateGlobalCertificateReply! (type)
        public static string UpdateGlobalCertificate_TypedFieldSpec(UpdateGlobalCertificateReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateGlobalCertificate" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateGlobalCertificate_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateGlobalCertificate((UpdateGlobalCertificateReply)fieldSpecObj);
        }
        public static string UpdateGlobalCertificate(UpdateGlobalCertificateReply fieldSpec)
        {
            return UpdateGlobalCertificate_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateGlobalCertificate(object fieldSpecObj)
        {
            return UpdateGlobalCertificate_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateGlobalCertificateFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateGlobalCertificateReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GlobalSlaReply? UpdateGlobalSla
        // GraphQL -> updateGlobalSla: GlobalSlaReply! (type)
        public static string UpdateGlobalSla_TypedFieldSpec(GlobalSlaReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateGlobalSla" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateGlobalSla_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateGlobalSla((GlobalSlaReply)fieldSpecObj);
        }
        public static string UpdateGlobalSla(GlobalSlaReply fieldSpec)
        {
            return UpdateGlobalSla_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateGlobalSla(object fieldSpecObj)
        {
            return UpdateGlobalSla_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateGlobalSlaFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GlobalSlaReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateGuestCredentialReply? UpdateGuestCredential
        // GraphQL -> updateGuestCredential: UpdateGuestCredentialReply! (type)
        public static string UpdateGuestCredential_TypedFieldSpec(UpdateGuestCredentialReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateGuestCredential" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateGuestCredential_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateGuestCredential((UpdateGuestCredentialReply)fieldSpecObj);
        }
        public static string UpdateGuestCredential(UpdateGuestCredentialReply fieldSpec)
        {
            return UpdateGuestCredential_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateGuestCredential(object fieldSpecObj)
        {
            return UpdateGuestCredential_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateGuestCredentialFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateGuestCredentialReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateHealthMonitorPolicyStatusReply? UpdateHealthMonitorPolicyStatus
        // GraphQL -> updateHealthMonitorPolicyStatus: UpdateHealthMonitorPolicyStatusReply! (type)
        public static string UpdateHealthMonitorPolicyStatus_TypedFieldSpec(UpdateHealthMonitorPolicyStatusReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateHealthMonitorPolicyStatus" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateHealthMonitorPolicyStatus_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateHealthMonitorPolicyStatus((UpdateHealthMonitorPolicyStatusReply)fieldSpecObj);
        }
        public static string UpdateHealthMonitorPolicyStatus(UpdateHealthMonitorPolicyStatusReply fieldSpec)
        {
            return UpdateHealthMonitorPolicyStatus_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateHealthMonitorPolicyStatus(object fieldSpecObj)
        {
            return UpdateHealthMonitorPolicyStatus_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateHealthMonitorPolicyStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateHealthMonitorPolicyStatusReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateHypervVirtualMachineReply? UpdateHypervVirtualMachine
        // GraphQL -> updateHypervVirtualMachine: UpdateHypervVirtualMachineReply! (type)
        public static string UpdateHypervVirtualMachine_TypedFieldSpec(UpdateHypervVirtualMachineReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateHypervVirtualMachine" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateHypervVirtualMachine_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateHypervVirtualMachine((UpdateHypervVirtualMachineReply)fieldSpecObj);
        }
        public static string UpdateHypervVirtualMachine(UpdateHypervVirtualMachineReply fieldSpec)
        {
            return UpdateHypervVirtualMachine_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateHypervVirtualMachine(object fieldSpecObj)
        {
            return UpdateHypervVirtualMachine_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateHypervVirtualMachineFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateHypervVirtualMachineReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateHypervVirtualMachineSnapshotMountReply? UpdateHypervVirtualMachineSnapshotMount
        // GraphQL -> updateHypervVirtualMachineSnapshotMount: UpdateHypervVirtualMachineSnapshotMountReply! (type)
        public static string UpdateHypervVirtualMachineSnapshotMount_TypedFieldSpec(UpdateHypervVirtualMachineSnapshotMountReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateHypervVirtualMachineSnapshotMount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateHypervVirtualMachineSnapshotMount_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateHypervVirtualMachineSnapshotMount((UpdateHypervVirtualMachineSnapshotMountReply)fieldSpecObj);
        }
        public static string UpdateHypervVirtualMachineSnapshotMount(UpdateHypervVirtualMachineSnapshotMountReply fieldSpec)
        {
            return UpdateHypervVirtualMachineSnapshotMount_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateHypervVirtualMachineSnapshotMount(object fieldSpecObj)
        {
            return UpdateHypervVirtualMachineSnapshotMount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateHypervVirtualMachineSnapshotMountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateHypervVirtualMachineSnapshotMountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateInsightStateReply? UpdateInsightState
        // GraphQL -> updateInsightState: UpdateInsightStateReply! (type)
        public static string UpdateInsightState_TypedFieldSpec(UpdateInsightStateReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateInsightState" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateInsightState_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateInsightState((UpdateInsightStateReply)fieldSpecObj);
        }
        public static string UpdateInsightState(UpdateInsightStateReply fieldSpec)
        {
            return UpdateInsightState_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateInsightState(object fieldSpecObj)
        {
            return UpdateInsightState_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateInsightStateFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateInsightStateReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? UpdateK8sCluster
        // GraphQL -> updateK8sCluster: ResponseSuccess! (type)
        public static string UpdateK8sCluster_TypedFieldSpec(ResponseSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateK8sCluster" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateK8sCluster_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateK8sCluster((ResponseSuccess)fieldSpecObj);
        }
        public static string UpdateK8sCluster(ResponseSuccess fieldSpec)
        {
            return UpdateK8sCluster_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateK8sCluster(object fieldSpecObj)
        {
            return UpdateK8sCluster_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateK8sClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? UpdateK8sProtectionSet
        // GraphQL -> updateK8sProtectionSet: ResponseSuccess! (type)
        public static string UpdateK8sProtectionSet_TypedFieldSpec(ResponseSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateK8sProtectionSet" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateK8sProtectionSet_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateK8sProtectionSet((ResponseSuccess)fieldSpecObj);
        }
        public static string UpdateK8sProtectionSet(ResponseSuccess fieldSpec)
        {
            return UpdateK8sProtectionSet_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateK8sProtectionSet(object fieldSpecObj)
        {
            return UpdateK8sProtectionSet_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateK8sProtectionSetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> LambdaSettings? UpdateLambdaSettings
        // GraphQL -> updateLambdaSettings: LambdaSettings! (type)
        public static string UpdateLambdaSettings_TypedFieldSpec(LambdaSettings fieldSpec)
        {
            string args = "\n(\nanomalyThreshold: $anomalyThreshold\nransomwareThreshold: $ransomwareThreshold\nisAnomalyAlertEnabled: $isAnomalyAlertEnabled\n)";
            return "updateLambdaSettings" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateLambdaSettings_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateLambdaSettings((LambdaSettings)fieldSpecObj);
        }
        public static string UpdateLambdaSettings(LambdaSettings fieldSpec)
        {
            return UpdateLambdaSettings_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateLambdaSettings(object fieldSpecObj)
        {
            return UpdateLambdaSettings_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateLambdaSettingsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new LambdaSettings() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateLockoutConfigReply? UpdateLockoutConfig
        // GraphQL -> updateLockoutConfig: UpdateLockoutConfigReply! (type)
        public static string UpdateLockoutConfig_TypedFieldSpec(UpdateLockoutConfigReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateLockoutConfig" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateLockoutConfig_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateLockoutConfig((UpdateLockoutConfigReply)fieldSpecObj);
        }
        public static string UpdateLockoutConfig(UpdateLockoutConfigReply fieldSpec)
        {
            return UpdateLockoutConfig_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateLockoutConfig(object fieldSpecObj)
        {
            return UpdateLockoutConfig_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateLockoutConfigFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateLockoutConfigReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateManagedIdentitiesReply? UpdateManagedIdentities
        // GraphQL -> updateManagedIdentities: UpdateManagedIdentitiesReply! (type)
        public static string UpdateManagedIdentities_TypedFieldSpec(UpdateManagedIdentitiesReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateManagedIdentities" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateManagedIdentities_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateManagedIdentities((UpdateManagedIdentitiesReply)fieldSpecObj);
        }
        public static string UpdateManagedIdentities(UpdateManagedIdentitiesReply fieldSpec)
        {
            return UpdateManagedIdentities_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateManagedIdentities(object fieldSpecObj)
        {
            return UpdateManagedIdentities_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateManagedIdentitiesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateManagedIdentitiesReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateManagedVolumeReply? UpdateManagedVolume
        // GraphQL -> updateManagedVolume: UpdateManagedVolumeReply! (type)
        public static string UpdateManagedVolume_TypedFieldSpec(UpdateManagedVolumeReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateManagedVolume" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateManagedVolume_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateManagedVolume((UpdateManagedVolumeReply)fieldSpecObj);
        }
        public static string UpdateManagedVolume(UpdateManagedVolumeReply fieldSpec)
        {
            return UpdateManagedVolume_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateManagedVolume(object fieldSpecObj)
        {
            return UpdateManagedVolume_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateManagedVolumeFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateManagedVolumeReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TargetMapping? UpdateManualTargetMapping
        // GraphQL -> updateManualTargetMapping: TargetMapping! (type)
        public static string UpdateManualTargetMapping_TypedFieldSpec(TargetMapping fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateManualTargetMapping" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateManualTargetMapping_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateManualTargetMapping((TargetMapping)fieldSpecObj);
        }
        public static string UpdateManualTargetMapping(TargetMapping fieldSpec)
        {
            return UpdateManualTargetMapping_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateManualTargetMapping(object fieldSpecObj)
        {
            return UpdateManualTargetMapping_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateManualTargetMappingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new TargetMapping() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicAsyncResponse? UpdateMongodbSource
        // GraphQL -> updateMongodbSource: MosaicAsyncResponse! (type)
        public static string UpdateMongodbSource_TypedFieldSpec(MosaicAsyncResponse fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateMongodbSource" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateMongodbSource_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateMongodbSource((MosaicAsyncResponse)fieldSpecObj);
        }
        public static string UpdateMongodbSource(MosaicAsyncResponse fieldSpec)
        {
            return UpdateMongodbSource_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateMongodbSource(object fieldSpecObj)
        {
            return UpdateMongodbSource_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateMongodbSourceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MosaicAsyncResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicAsyncResponse? UpdateMosaicStore
        // GraphQL -> updateMosaicStore: MosaicAsyncResponse! (type)
        public static string UpdateMosaicStore_TypedFieldSpec(MosaicAsyncResponse fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateMosaicStore" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateMosaicStore_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateMosaicStore((MosaicAsyncResponse)fieldSpecObj);
        }
        public static string UpdateMosaicStore(MosaicAsyncResponse fieldSpec)
        {
            return UpdateMosaicStore_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateMosaicStore(object fieldSpecObj)
        {
            return UpdateMosaicStore_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateMosaicStoreFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MosaicAsyncResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateMssqlDefaultPropertiesReply? UpdateMssqlDefaultProperties
        // GraphQL -> updateMssqlDefaultProperties: UpdateMssqlDefaultPropertiesReply! (type)
        public static string UpdateMssqlDefaultProperties_TypedFieldSpec(UpdateMssqlDefaultPropertiesReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateMssqlDefaultProperties" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateMssqlDefaultProperties_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateMssqlDefaultProperties((UpdateMssqlDefaultPropertiesReply)fieldSpecObj);
        }
        public static string UpdateMssqlDefaultProperties(UpdateMssqlDefaultPropertiesReply fieldSpec)
        {
            return UpdateMssqlDefaultProperties_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateMssqlDefaultProperties(object fieldSpecObj)
        {
            return UpdateMssqlDefaultProperties_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateMssqlDefaultPropertiesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateMssqlDefaultPropertiesReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateMssqlLogShippingConfigurationReply? UpdateMssqlLogShippingConfiguration
        // GraphQL -> updateMssqlLogShippingConfiguration: UpdateMssqlLogShippingConfigurationReply! (type)
        public static string UpdateMssqlLogShippingConfiguration_TypedFieldSpec(UpdateMssqlLogShippingConfigurationReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateMssqlLogShippingConfiguration" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateMssqlLogShippingConfiguration_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateMssqlLogShippingConfiguration((UpdateMssqlLogShippingConfigurationReply)fieldSpecObj);
        }
        public static string UpdateMssqlLogShippingConfiguration(UpdateMssqlLogShippingConfigurationReply fieldSpec)
        {
            return UpdateMssqlLogShippingConfiguration_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateMssqlLogShippingConfiguration(object fieldSpecObj)
        {
            return UpdateMssqlLogShippingConfiguration_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateMssqlLogShippingConfigurationFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateMssqlLogShippingConfigurationReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateNasSystemReply? UpdateNasSystem
        // GraphQL -> updateNasSystem: UpdateNasSystemReply! (type)
        public static string UpdateNasSystem_TypedFieldSpec(UpdateNasSystemReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateNasSystem" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateNasSystem_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateNasSystem((UpdateNasSystemReply)fieldSpecObj);
        }
        public static string UpdateNasSystem(UpdateNasSystemReply fieldSpec)
        {
            return UpdateNasSystem_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateNasSystem(object fieldSpecObj)
        {
            return UpdateNasSystem_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateNasSystemFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateNasSystemReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateNetworkThrottleReply? UpdateNetworkThrottle
        // GraphQL -> updateNetworkThrottle: UpdateNetworkThrottleReply! (type)
        public static string UpdateNetworkThrottle_TypedFieldSpec(UpdateNetworkThrottleReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateNetworkThrottle" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateNetworkThrottle_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateNetworkThrottle((UpdateNetworkThrottleReply)fieldSpecObj);
        }
        public static string UpdateNetworkThrottle(UpdateNetworkThrottleReply fieldSpec)
        {
            return UpdateNetworkThrottle_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateNetworkThrottle(object fieldSpecObj)
        {
            return UpdateNetworkThrottle_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateNetworkThrottleFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateNetworkThrottleReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateNutanixClusterReply? UpdateNutanixCluster
        // GraphQL -> updateNutanixCluster: UpdateNutanixClusterReply! (type)
        public static string UpdateNutanixCluster_TypedFieldSpec(UpdateNutanixClusterReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateNutanixCluster" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateNutanixCluster_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateNutanixCluster((UpdateNutanixClusterReply)fieldSpecObj);
        }
        public static string UpdateNutanixCluster(UpdateNutanixClusterReply fieldSpec)
        {
            return UpdateNutanixCluster_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateNutanixCluster(object fieldSpecObj)
        {
            return UpdateNutanixCluster_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateNutanixClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateNutanixClusterReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateNutanixPrismCentralReply? UpdateNutanixPrismCentral
        // GraphQL -> updateNutanixPrismCentral: UpdateNutanixPrismCentralReply! (type)
        public static string UpdateNutanixPrismCentral_TypedFieldSpec(UpdateNutanixPrismCentralReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateNutanixPrismCentral" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateNutanixPrismCentral_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateNutanixPrismCentral((UpdateNutanixPrismCentralReply)fieldSpecObj);
        }
        public static string UpdateNutanixPrismCentral(UpdateNutanixPrismCentralReply fieldSpec)
        {
            return UpdateNutanixPrismCentral_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateNutanixPrismCentral(object fieldSpecObj)
        {
            return UpdateNutanixPrismCentral_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateNutanixPrismCentralFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateNutanixPrismCentralReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateO365AppAuthStatusReply? UpdateO365AppAuthStatus
        // GraphQL -> updateO365AppAuthStatus: UpdateO365AppAuthStatusReply! (type)
        public static string UpdateO365AppAuthStatus_TypedFieldSpec(UpdateO365AppAuthStatusReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateO365AppAuthStatus" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateO365AppAuthStatus_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateO365AppAuthStatus((UpdateO365AppAuthStatusReply)fieldSpecObj);
        }
        public static string UpdateO365AppAuthStatus(UpdateO365AppAuthStatusReply fieldSpec)
        {
            return UpdateO365AppAuthStatus_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateO365AppAuthStatus(object fieldSpecObj)
        {
            return UpdateO365AppAuthStatus_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateO365AppAuthStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateO365AppAuthStatusReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateO365OrgCustomNameReply? UpdateO365OrgCustomName
        // GraphQL -> updateO365OrgCustomName: UpdateO365OrgCustomNameReply! (type)
        public static string UpdateO365OrgCustomName_TypedFieldSpec(UpdateO365OrgCustomNameReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateO365OrgCustomName" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateO365OrgCustomName_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateO365OrgCustomName((UpdateO365OrgCustomNameReply)fieldSpecObj);
        }
        public static string UpdateO365OrgCustomName(UpdateO365OrgCustomNameReply fieldSpec)
        {
            return UpdateO365OrgCustomName_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateO365OrgCustomName(object fieldSpecObj)
        {
            return UpdateO365OrgCustomName_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateO365OrgCustomNameFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateO365OrgCustomNameReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> OracleDbDetail? UpdateOracleDataGuardGroup
        // GraphQL -> updateOracleDataGuardGroup: OracleDbDetail! (type)
        public static string UpdateOracleDataGuardGroup_TypedFieldSpec(OracleDbDetail fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateOracleDataGuardGroup" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateOracleDataGuardGroup_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateOracleDataGuardGroup((OracleDbDetail)fieldSpecObj);
        }
        public static string UpdateOracleDataGuardGroup(OracleDbDetail fieldSpec)
        {
            return UpdateOracleDataGuardGroup_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateOracleDataGuardGroup(object fieldSpecObj)
        {
            return UpdateOracleDataGuardGroup_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateOracleDataGuardGroupFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new OracleDbDetail() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateOrgReply? UpdateOrg
        // GraphQL -> updateOrg: UpdateOrgReply! (type)
        public static string UpdateOrg_TypedFieldSpec(UpdateOrgReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateOrg" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateOrg_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateOrg((UpdateOrgReply)fieldSpecObj);
        }
        public static string UpdateOrg(UpdateOrgReply fieldSpec)
        {
            return UpdateOrg_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateOrg(object fieldSpecObj)
        {
            return UpdateOrg_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateOrgFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateOrgReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ClassificationPolicyDetail? UpdatePolicy
        // GraphQL -> updatePolicy: ClassificationPolicyDetail! (type)
        public static string UpdatePolicy_TypedFieldSpec(ClassificationPolicyDetail fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updatePolicy" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdatePolicy_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdatePolicy((ClassificationPolicyDetail)fieldSpecObj);
        }
        public static string UpdatePolicy(ClassificationPolicyDetail fieldSpec)
        {
            return UpdatePolicy_TypedFieldSpec(fieldSpec);
        }
        public static string UpdatePolicy(object fieldSpecObj)
        {
            return UpdatePolicy_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdatePolicyFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ClassificationPolicyDetail() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Cluster? UpdatePreviewerClusterConfig
        // GraphQL -> updatePreviewerClusterConfig: Cluster! (type)
        public static string UpdatePreviewerClusterConfig_TypedFieldSpec(Cluster fieldSpec)
        {
            string args = "\n(\npreviewerClusterConfig: $previewerClusterConfig\n)";
            return "updatePreviewerClusterConfig" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdatePreviewerClusterConfig_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdatePreviewerClusterConfig((Cluster)fieldSpecObj);
        }
        public static string UpdatePreviewerClusterConfig(Cluster fieldSpec)
        {
            return UpdatePreviewerClusterConfig_TypedFieldSpec(fieldSpec);
        }
        public static string UpdatePreviewerClusterConfig(object fieldSpecObj)
        {
            return UpdatePreviewerClusterConfig_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdatePreviewerClusterConfigFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new Cluster() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateProxyConfigReply? UpdateProxyConfig
        // GraphQL -> updateProxyConfig: UpdateProxyConfigReply! (type)
        public static string UpdateProxyConfig_TypedFieldSpec(UpdateProxyConfigReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateProxyConfig" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateProxyConfig_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateProxyConfig((UpdateProxyConfigReply)fieldSpecObj);
        }
        public static string UpdateProxyConfig(UpdateProxyConfigReply fieldSpec)
        {
            return UpdateProxyConfig_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateProxyConfig(object fieldSpecObj)
        {
            return UpdateProxyConfig_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateProxyConfigFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateProxyConfigReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TargetMapping? UpdateRcsAutomaticTargetMapping
        // GraphQL -> updateRcsAutomaticTargetMapping: TargetMapping! (type)
        public static string UpdateRcsAutomaticTargetMapping_TypedFieldSpec(TargetMapping fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateRcsAutomaticTargetMapping" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateRcsAutomaticTargetMapping_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateRcsAutomaticTargetMapping((TargetMapping)fieldSpecObj);
        }
        public static string UpdateRcsAutomaticTargetMapping(TargetMapping fieldSpec)
        {
            return UpdateRcsAutomaticTargetMapping_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateRcsAutomaticTargetMapping(object fieldSpecObj)
        {
            return UpdateRcsAutomaticTargetMapping_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateRcsAutomaticTargetMappingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new TargetMapping() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResponseSuccess? UpdateReplicationNetworkThrottleBypass
        // GraphQL -> updateReplicationNetworkThrottleBypass: ResponseSuccess! (type)
        public static string UpdateReplicationNetworkThrottleBypass_TypedFieldSpec(ResponseSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateReplicationNetworkThrottleBypass" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateReplicationNetworkThrottleBypass_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateReplicationNetworkThrottleBypass((ResponseSuccess)fieldSpecObj);
        }
        public static string UpdateReplicationNetworkThrottleBypass(ResponseSuccess fieldSpec)
        {
            return UpdateReplicationNetworkThrottleBypass_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateReplicationNetworkThrottleBypass(object fieldSpecObj)
        {
            return UpdateReplicationNetworkThrottleBypass_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateReplicationNetworkThrottleBypassFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResponseSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateScheduledReportReply? UpdateScheduledReport
        // GraphQL -> updateScheduledReport: UpdateScheduledReportReply! (type)
        public static string UpdateScheduledReport_TypedFieldSpec(UpdateScheduledReportReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateScheduledReport" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateScheduledReport_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateScheduledReport((UpdateScheduledReportReply)fieldSpecObj);
        }
        public static string UpdateScheduledReport(UpdateScheduledReportReply fieldSpec)
        {
            return UpdateScheduledReport_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateScheduledReport(object fieldSpecObj)
        {
            return UpdateScheduledReport_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateScheduledReportFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateScheduledReportReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateServiceAccountReply? UpdateServiceAccount
        // GraphQL -> updateServiceAccount: UpdateServiceAccountReply! (type)
        public static string UpdateServiceAccount_TypedFieldSpec(UpdateServiceAccountReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateServiceAccount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateServiceAccount_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateServiceAccount((UpdateServiceAccountReply)fieldSpecObj);
        }
        public static string UpdateServiceAccount(UpdateServiceAccountReply fieldSpec)
        {
            return UpdateServiceAccount_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateServiceAccount(object fieldSpecObj)
        {
            return UpdateServiceAccount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateServiceAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateServiceAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateSnmpConfigReply? UpdateSnmpConfig
        // GraphQL -> updateSnmpConfig: UpdateSnmpConfigReply! (type)
        public static string UpdateSnmpConfig_TypedFieldSpec(UpdateSnmpConfigReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateSnmpConfig" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateSnmpConfig_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateSnmpConfig((UpdateSnmpConfigReply)fieldSpecObj);
        }
        public static string UpdateSnmpConfig(UpdateSnmpConfigReply fieldSpec)
        {
            return UpdateSnmpConfig_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateSnmpConfig(object fieldSpecObj)
        {
            return UpdateSnmpConfig_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateSnmpConfigFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateSnmpConfigReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateStorageArraysReply? UpdateStorageArrays
        // GraphQL -> updateStorageArrays: UpdateStorageArraysReply! (type)
        public static string UpdateStorageArrays_TypedFieldSpec(UpdateStorageArraysReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateStorageArrays" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateStorageArrays_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateStorageArrays((UpdateStorageArraysReply)fieldSpecObj);
        }
        public static string UpdateStorageArrays(UpdateStorageArraysReply fieldSpec)
        {
            return UpdateStorageArrays_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateStorageArrays(object fieldSpecObj)
        {
            return UpdateStorageArrays_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateStorageArraysFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateStorageArraysReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateSyslogExportRuleReply? UpdateSyslogExportRule
        // GraphQL -> updateSyslogExportRule: UpdateSyslogExportRuleReply! (type)
        public static string UpdateSyslogExportRule_TypedFieldSpec(UpdateSyslogExportRuleReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateSyslogExportRule" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateSyslogExportRule_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateSyslogExportRule((UpdateSyslogExportRuleReply)fieldSpecObj);
        }
        public static string UpdateSyslogExportRule(UpdateSyslogExportRuleReply fieldSpec)
        {
            return UpdateSyslogExportRule_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateSyslogExportRule(object fieldSpecObj)
        {
            return UpdateSyslogExportRule_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateSyslogExportRuleFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateSyslogExportRuleReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateTunnelStatusReply? UpdateTunnelStatus
        // GraphQL -> updateTunnelStatus: UpdateTunnelStatusReply! (type)
        public static string UpdateTunnelStatus_TypedFieldSpec(UpdateTunnelStatusReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateTunnelStatus" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateTunnelStatus_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateTunnelStatus((UpdateTunnelStatusReply)fieldSpecObj);
        }
        public static string UpdateTunnelStatus(UpdateTunnelStatusReply fieldSpec)
        {
            return UpdateTunnelStatus_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateTunnelStatus(object fieldSpecObj)
        {
            return UpdateTunnelStatus_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateTunnelStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateTunnelStatusReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateVcenterReply? UpdateVcenter
        // GraphQL -> updateVcenter: UpdateVcenterReply! (type)
        public static string UpdateVcenter_TypedFieldSpec(UpdateVcenterReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateVcenter" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateVcenter_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateVcenter((UpdateVcenterReply)fieldSpecObj);
        }
        public static string UpdateVcenter(UpdateVcenterReply fieldSpec)
        {
            return UpdateVcenter_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateVcenter(object fieldSpecObj)
        {
            return UpdateVcenter_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateVcenterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateVcenterReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? UpdateVcenterHotAddBandwidth
        // GraphQL -> updateVcenterHotAddBandwidth: RequestSuccess! (type)
        public static string UpdateVcenterHotAddBandwidth_TypedFieldSpec(RequestSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateVcenterHotAddBandwidth" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateVcenterHotAddBandwidth_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateVcenterHotAddBandwidth((RequestSuccess)fieldSpecObj);
        }
        public static string UpdateVcenterHotAddBandwidth(RequestSuccess fieldSpec)
        {
            return UpdateVcenterHotAddBandwidth_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateVcenterHotAddBandwidth(object fieldSpecObj)
        {
            return UpdateVcenterHotAddBandwidth_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateVcenterHotAddBandwidthFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? UpdateVcenterHotAddNetwork
        // GraphQL -> updateVcenterHotAddNetwork: RequestSuccess! (type)
        public static string UpdateVcenterHotAddNetwork_TypedFieldSpec(RequestSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateVcenterHotAddNetwork" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateVcenterHotAddNetwork_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateVcenterHotAddNetwork((RequestSuccess)fieldSpecObj);
        }
        public static string UpdateVcenterHotAddNetwork(RequestSuccess fieldSpec)
        {
            return UpdateVcenterHotAddNetwork_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateVcenterHotAddNetwork(object fieldSpecObj)
        {
            return UpdateVcenterHotAddNetwork_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateVcenterHotAddNetworkFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateVolumeGroupReply? UpdateVolumeGroup
        // GraphQL -> updateVolumeGroup: UpdateVolumeGroupReply! (type)
        public static string UpdateVolumeGroup_TypedFieldSpec(UpdateVolumeGroupReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateVolumeGroup" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateVolumeGroup_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateVolumeGroup((UpdateVolumeGroupReply)fieldSpecObj);
        }
        public static string UpdateVolumeGroup(UpdateVolumeGroupReply fieldSpec)
        {
            return UpdateVolumeGroup_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateVolumeGroup(object fieldSpecObj)
        {
            return UpdateVolumeGroup_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateVolumeGroupFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateVolumeGroupReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateVsphereAdvancedTagReply? UpdateVsphereAdvancedTag
        // GraphQL -> updateVsphereAdvancedTag: UpdateVsphereAdvancedTagReply! (type)
        public static string UpdateVsphereAdvancedTag_TypedFieldSpec(UpdateVsphereAdvancedTagReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateVsphereAdvancedTag" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateVsphereAdvancedTag_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateVsphereAdvancedTag((UpdateVsphereAdvancedTagReply)fieldSpecObj);
        }
        public static string UpdateVsphereAdvancedTag(UpdateVsphereAdvancedTagReply fieldSpec)
        {
            return UpdateVsphereAdvancedTag_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateVsphereAdvancedTag(object fieldSpecObj)
        {
            return UpdateVsphereAdvancedTag_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateVsphereAdvancedTagFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateVsphereAdvancedTagReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? UpdateVsphereVm
        // GraphQL -> updateVsphereVm: RequestSuccess! (type)
        public static string UpdateVsphereVm_TypedFieldSpec(RequestSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateVsphereVm" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateVsphereVm_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateVsphereVm((RequestSuccess)fieldSpecObj);
        }
        public static string UpdateVsphereVm(RequestSuccess fieldSpec)
        {
            return UpdateVsphereVm_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateVsphereVm(object fieldSpecObj)
        {
            return UpdateVsphereVm_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateVsphereVmFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateWebhookReply? UpdateWebhook
        // GraphQL -> updateWebhook: UpdateWebhookReply! (type)
        public static string UpdateWebhook_TypedFieldSpec(UpdateWebhookReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "updateWebhook" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpdateWebhook_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpdateWebhook((UpdateWebhookReply)fieldSpecObj);
        }
        public static string UpdateWebhook(UpdateWebhookReply fieldSpec)
        {
            return UpdateWebhook_TypedFieldSpec(fieldSpec);
        }
        public static string UpdateWebhook(object fieldSpecObj)
        {
            return UpdateWebhook_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpdateWebhookFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateWebhookReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpgradeAzureCloudAccountReply? UpgradeAzureCloudAccount
        // GraphQL -> upgradeAzureCloudAccount: UpgradeAzureCloudAccountReply! (type)
        public static string UpgradeAzureCloudAccount_TypedFieldSpec(UpgradeAzureCloudAccountReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "upgradeAzureCloudAccount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpgradeAzureCloudAccount_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpgradeAzureCloudAccount((UpgradeAzureCloudAccountReply)fieldSpecObj);
        }
        public static string UpgradeAzureCloudAccount(UpgradeAzureCloudAccountReply fieldSpec)
        {
            return UpgradeAzureCloudAccount_TypedFieldSpec(fieldSpec);
        }
        public static string UpgradeAzureCloudAccount(object fieldSpecObj)
        {
            return UpgradeAzureCloudAccount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpgradeAzureCloudAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpgradeAzureCloudAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpgradeAzureCloudAccountPermissionsWithoutOauthReply? UpgradeAzureCloudAccountPermissionsWithoutOauth
        // GraphQL -> upgradeAzureCloudAccountPermissionsWithoutOauth: UpgradeAzureCloudAccountPermissionsWithoutOauthReply! (type)
        public static string UpgradeAzureCloudAccountPermissionsWithoutOauth_TypedFieldSpec(UpgradeAzureCloudAccountPermissionsWithoutOauthReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "upgradeAzureCloudAccountPermissionsWithoutOauth" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpgradeAzureCloudAccountPermissionsWithoutOauth_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpgradeAzureCloudAccountPermissionsWithoutOauth((UpgradeAzureCloudAccountPermissionsWithoutOauthReply)fieldSpecObj);
        }
        public static string UpgradeAzureCloudAccountPermissionsWithoutOauth(UpgradeAzureCloudAccountPermissionsWithoutOauthReply fieldSpec)
        {
            return UpgradeAzureCloudAccountPermissionsWithoutOauth_TypedFieldSpec(fieldSpec);
        }
        public static string UpgradeAzureCloudAccountPermissionsWithoutOauth(object fieldSpecObj)
        {
            return UpgradeAzureCloudAccountPermissionsWithoutOauth_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpgradeAzureCloudAccountPermissionsWithoutOauthFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpgradeAzureCloudAccountPermissionsWithoutOauthReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpgradeGcpCloudAccountPermissionsWithoutOauthReply? UpgradeGcpCloudAccountPermissionsWithoutOauth
        // GraphQL -> upgradeGcpCloudAccountPermissionsWithoutOauth: UpgradeGcpCloudAccountPermissionsWithoutOauthReply! (type)
        public static string UpgradeGcpCloudAccountPermissionsWithoutOauth_TypedFieldSpec(UpgradeGcpCloudAccountPermissionsWithoutOauthReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "upgradeGcpCloudAccountPermissionsWithoutOauth" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpgradeGcpCloudAccountPermissionsWithoutOauth_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpgradeGcpCloudAccountPermissionsWithoutOauth((UpgradeGcpCloudAccountPermissionsWithoutOauthReply)fieldSpecObj);
        }
        public static string UpgradeGcpCloudAccountPermissionsWithoutOauth(UpgradeGcpCloudAccountPermissionsWithoutOauthReply fieldSpec)
        {
            return UpgradeGcpCloudAccountPermissionsWithoutOauth_TypedFieldSpec(fieldSpec);
        }
        public static string UpgradeGcpCloudAccountPermissionsWithoutOauth(object fieldSpecObj)
        {
            return UpgradeGcpCloudAccountPermissionsWithoutOauth_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpgradeGcpCloudAccountPermissionsWithoutOauthFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpgradeGcpCloudAccountPermissionsWithoutOauthReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? UpgradeIoFilter
        // GraphQL -> upgradeIoFilter: RequestSuccess! (type)
        public static string UpgradeIoFilter_TypedFieldSpec(RequestSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "upgradeIoFilter" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpgradeIoFilter_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpgradeIoFilter((RequestSuccess)fieldSpecObj);
        }
        public static string UpgradeIoFilter(RequestSuccess fieldSpec)
        {
            return UpgradeIoFilter_TypedFieldSpec(fieldSpec);
        }
        public static string UpgradeIoFilter(object fieldSpecObj)
        {
            return UpgradeIoFilter_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpgradeIoFilterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpgradeSlasReply? UpgradeSlas
        // GraphQL -> upgradeSlas: UpgradeSlasReply! (type)
        public static string UpgradeSlas_TypedFieldSpec(UpgradeSlasReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "upgradeSlas" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UpgradeSlas_ObjectFieldSpec(object fieldSpecObj)
        {
            return UpgradeSlas((UpgradeSlasReply)fieldSpecObj);
        }
        public static string UpgradeSlas(UpgradeSlasReply fieldSpec)
        {
            return UpgradeSlas_TypedFieldSpec(fieldSpec);
        }
        public static string UpgradeSlas(object fieldSpecObj)
        {
            return UpgradeSlas_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UpgradeSlasFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpgradeSlasReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncJobStatus? UploadDatabaseSnapshotToBlobstore
        // GraphQL -> uploadDatabaseSnapshotToBlobstore: AsyncJobStatus! (type)
        public static string UploadDatabaseSnapshotToBlobstore_TypedFieldSpec(AsyncJobStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "uploadDatabaseSnapshotToBlobstore" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string UploadDatabaseSnapshotToBlobstore_ObjectFieldSpec(object fieldSpecObj)
        {
            return UploadDatabaseSnapshotToBlobstore((AsyncJobStatus)fieldSpecObj);
        }
        public static string UploadDatabaseSnapshotToBlobstore(AsyncJobStatus fieldSpec)
        {
            return UploadDatabaseSnapshotToBlobstore_TypedFieldSpec(fieldSpec);
        }
        public static string UploadDatabaseSnapshotToBlobstore(object fieldSpecObj)
        {
            return UploadDatabaseSnapshotToBlobstore_ObjectFieldSpec(fieldSpecObj);
        }
        public static object UploadDatabaseSnapshotToBlobstoreFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ValidateAndCreateAwsCloudAccountReply? ValidateAndCreateAwsCloudAccount
        // GraphQL -> validateAndCreateAwsCloudAccount: ValidateAndCreateAwsCloudAccountReply! (type)
        public static string ValidateAndCreateAwsCloudAccount_TypedFieldSpec(ValidateAndCreateAwsCloudAccountReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "validateAndCreateAwsCloudAccount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ValidateAndCreateAwsCloudAccount_ObjectFieldSpec(object fieldSpecObj)
        {
            return ValidateAndCreateAwsCloudAccount((ValidateAndCreateAwsCloudAccountReply)fieldSpecObj);
        }
        public static string ValidateAndCreateAwsCloudAccount(ValidateAndCreateAwsCloudAccountReply fieldSpec)
        {
            return ValidateAndCreateAwsCloudAccount_TypedFieldSpec(fieldSpec);
        }
        public static string ValidateAndCreateAwsCloudAccount(object fieldSpecObj)
        {
            return ValidateAndCreateAwsCloudAccount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ValidateAndCreateAwsCloudAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ValidateAndCreateAwsCloudAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ValidateAndSaveCustomerKmsInfoReply? ValidateAndSaveCustomerKmsInfo
        // GraphQL -> validateAndSaveCustomerKmsInfo: ValidateAndSaveCustomerKmsInfoReply! (type)
        public static string ValidateAndSaveCustomerKmsInfo_TypedFieldSpec(ValidateAndSaveCustomerKmsInfoReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "validateAndSaveCustomerKmsInfo" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ValidateAndSaveCustomerKmsInfo_ObjectFieldSpec(object fieldSpecObj)
        {
            return ValidateAndSaveCustomerKmsInfo((ValidateAndSaveCustomerKmsInfoReply)fieldSpecObj);
        }
        public static string ValidateAndSaveCustomerKmsInfo(ValidateAndSaveCustomerKmsInfoReply fieldSpec)
        {
            return ValidateAndSaveCustomerKmsInfo_TypedFieldSpec(fieldSpec);
        }
        public static string ValidateAndSaveCustomerKmsInfo(object fieldSpecObj)
        {
            return ValidateAndSaveCustomerKmsInfo_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ValidateAndSaveCustomerKmsInfoFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ValidateAndSaveCustomerKmsInfoReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ValidateOracleAcoFileReply? ValidateOracleAcoFile
        // GraphQL -> validateOracleAcoFile: ValidateOracleAcoFileReply! (type)
        public static string ValidateOracleAcoFile_TypedFieldSpec(ValidateOracleAcoFileReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "validateOracleAcoFile" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ValidateOracleAcoFile_ObjectFieldSpec(object fieldSpecObj)
        {
            return ValidateOracleAcoFile((ValidateOracleAcoFileReply)fieldSpecObj);
        }
        public static string ValidateOracleAcoFile(ValidateOracleAcoFileReply fieldSpec)
        {
            return ValidateOracleAcoFile_TypedFieldSpec(fieldSpec);
        }
        public static string ValidateOracleAcoFile(object fieldSpecObj)
        {
            return ValidateOracleAcoFile_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ValidateOracleAcoFileFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ValidateOracleAcoFileReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? ValidateOracleDatabaseBackups
        // GraphQL -> validateOracleDatabaseBackups: AsyncRequestStatus! (type)
        public static string ValidateOracleDatabaseBackups_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "validateOracleDatabaseBackups" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string ValidateOracleDatabaseBackups_ObjectFieldSpec(object fieldSpecObj)
        {
            return ValidateOracleDatabaseBackups((AsyncRequestStatus)fieldSpecObj);
        }
        public static string ValidateOracleDatabaseBackups(AsyncRequestStatus fieldSpec)
        {
            return ValidateOracleDatabaseBackups_TypedFieldSpec(fieldSpec);
        }
        public static string ValidateOracleDatabaseBackups(object fieldSpecObj)
        {
            return ValidateOracleDatabaseBackups_ObjectFieldSpec(fieldSpecObj);
        }
        public static object ValidateOracleDatabaseBackupsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VmwareDownloadSnapshotFromLocation
        // GraphQL -> vmwareDownloadSnapshotFromLocation: AsyncRequestStatus! (type)
        public static string VmwareDownloadSnapshotFromLocation_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vmwareDownloadSnapshotFromLocation" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VmwareDownloadSnapshotFromLocation_ObjectFieldSpec(object fieldSpecObj)
        {
            return VmwareDownloadSnapshotFromLocation((AsyncRequestStatus)fieldSpecObj);
        }
        public static string VmwareDownloadSnapshotFromLocation(AsyncRequestStatus fieldSpec)
        {
            return VmwareDownloadSnapshotFromLocation_TypedFieldSpec(fieldSpec);
        }
        public static string VmwareDownloadSnapshotFromLocation(object fieldSpecObj)
        {
            return VmwareDownloadSnapshotFromLocation_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VmwareDownloadSnapshotFromLocationFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncRequestStatus? VsphereBulkOnDemandSnapshot
        // GraphQL -> vsphereBulkOnDemandSnapshot: BatchAsyncRequestStatus! (type)
        public static string VsphereBulkOnDemandSnapshot_TypedFieldSpec(BatchAsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereBulkOnDemandSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VsphereBulkOnDemandSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereBulkOnDemandSnapshot((BatchAsyncRequestStatus)fieldSpecObj);
        }
        public static string VsphereBulkOnDemandSnapshot(BatchAsyncRequestStatus fieldSpec)
        {
            return VsphereBulkOnDemandSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereBulkOnDemandSnapshot(object fieldSpecObj)
        {
            return VsphereBulkOnDemandSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereBulkOnDemandSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchAsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereDeleteVcenter
        // GraphQL -> vsphereDeleteVcenter: AsyncRequestStatus! (type)
        public static string VsphereDeleteVcenter_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereDeleteVcenter" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VsphereDeleteVcenter_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereDeleteVcenter((AsyncRequestStatus)fieldSpecObj);
        }
        public static string VsphereDeleteVcenter(AsyncRequestStatus fieldSpec)
        {
            return VsphereDeleteVcenter_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereDeleteVcenter(object fieldSpecObj)
        {
            return VsphereDeleteVcenter_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereDeleteVcenterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? VsphereExcludeVmDisks
        // GraphQL -> vsphereExcludeVmDisks: RequestSuccess! (type)
        public static string VsphereExcludeVmDisks_TypedFieldSpec(RequestSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereExcludeVmDisks" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VsphereExcludeVmDisks_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereExcludeVmDisks((RequestSuccess)fieldSpecObj);
        }
        public static string VsphereExcludeVmDisks(RequestSuccess fieldSpec)
        {
            return VsphereExcludeVmDisks_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereExcludeVmDisks(object fieldSpecObj)
        {
            return VsphereExcludeVmDisks_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereExcludeVmDisksFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereExportSnapshotToStandaloneHostV2
        // GraphQL -> vsphereExportSnapshotToStandaloneHostV2: AsyncRequestStatus! (type)
        public static string VsphereExportSnapshotToStandaloneHostV2_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereExportSnapshotToStandaloneHostV2" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VsphereExportSnapshotToStandaloneHostV2_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereExportSnapshotToStandaloneHostV2((AsyncRequestStatus)fieldSpecObj);
        }
        public static string VsphereExportSnapshotToStandaloneHostV2(AsyncRequestStatus fieldSpec)
        {
            return VsphereExportSnapshotToStandaloneHostV2_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereExportSnapshotToStandaloneHostV2(object fieldSpecObj)
        {
            return VsphereExportSnapshotToStandaloneHostV2_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereExportSnapshotToStandaloneHostV2FieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereOnDemandSnapshot
        // GraphQL -> vsphereOnDemandSnapshot: AsyncRequestStatus! (type)
        public static string VsphereOnDemandSnapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereOnDemandSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VsphereOnDemandSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereOnDemandSnapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string VsphereOnDemandSnapshot(AsyncRequestStatus fieldSpec)
        {
            return VsphereOnDemandSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereOnDemandSnapshot(object fieldSpecObj)
        {
            return VsphereOnDemandSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereOnDemandSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncRequestStatus? VsphereVmBatchExport
        // GraphQL -> vsphereVmBatchExport: BatchAsyncRequestStatus! (type)
        public static string VsphereVmBatchExport_TypedFieldSpec(BatchAsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmBatchExport" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VsphereVmBatchExport_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereVmBatchExport((BatchAsyncRequestStatus)fieldSpecObj);
        }
        public static string VsphereVmBatchExport(BatchAsyncRequestStatus fieldSpec)
        {
            return VsphereVmBatchExport_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereVmBatchExport(object fieldSpecObj)
        {
            return VsphereVmBatchExport_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereVmBatchExportFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchAsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncRequestStatus? VsphereVmBatchExportV3
        // GraphQL -> vsphereVmBatchExportV3: BatchAsyncRequestStatus! (type)
        public static string VsphereVmBatchExportV3_TypedFieldSpec(BatchAsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmBatchExportV3" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VsphereVmBatchExportV3_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereVmBatchExportV3((BatchAsyncRequestStatus)fieldSpecObj);
        }
        public static string VsphereVmBatchExportV3(BatchAsyncRequestStatus fieldSpec)
        {
            return VsphereVmBatchExportV3_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereVmBatchExportV3(object fieldSpecObj)
        {
            return VsphereVmBatchExportV3_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereVmBatchExportV3FieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchAsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncRequestStatus? VsphereVmBatchInPlaceRecovery
        // GraphQL -> vsphereVmBatchInPlaceRecovery: BatchAsyncRequestStatus! (type)
        public static string VsphereVmBatchInPlaceRecovery_TypedFieldSpec(BatchAsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmBatchInPlaceRecovery" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VsphereVmBatchInPlaceRecovery_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereVmBatchInPlaceRecovery((BatchAsyncRequestStatus)fieldSpecObj);
        }
        public static string VsphereVmBatchInPlaceRecovery(BatchAsyncRequestStatus fieldSpec)
        {
            return VsphereVmBatchInPlaceRecovery_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereVmBatchInPlaceRecovery(object fieldSpecObj)
        {
            return VsphereVmBatchInPlaceRecovery_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereVmBatchInPlaceRecoveryFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchAsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereVmDownloadSnapshot
        // GraphQL -> vsphereVmDownloadSnapshot: AsyncRequestStatus! (type)
        public static string VsphereVmDownloadSnapshot_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmDownloadSnapshot" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VsphereVmDownloadSnapshot_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereVmDownloadSnapshot((AsyncRequestStatus)fieldSpecObj);
        }
        public static string VsphereVmDownloadSnapshot(AsyncRequestStatus fieldSpec)
        {
            return VsphereVmDownloadSnapshot_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereVmDownloadSnapshot(object fieldSpecObj)
        {
            return VsphereVmDownloadSnapshot_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereVmDownloadSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereVmDownloadSnapshotFiles
        // GraphQL -> vsphereVmDownloadSnapshotFiles: AsyncRequestStatus! (type)
        public static string VsphereVmDownloadSnapshotFiles_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmDownloadSnapshotFiles" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VsphereVmDownloadSnapshotFiles_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereVmDownloadSnapshotFiles((AsyncRequestStatus)fieldSpecObj);
        }
        public static string VsphereVmDownloadSnapshotFiles(AsyncRequestStatus fieldSpec)
        {
            return VsphereVmDownloadSnapshotFiles_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereVmDownloadSnapshotFiles(object fieldSpecObj)
        {
            return VsphereVmDownloadSnapshotFiles_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereVmDownloadSnapshotFilesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereVmExportSnapshotV2
        // GraphQL -> vsphereVmExportSnapshotV2: AsyncRequestStatus! (type)
        public static string VsphereVmExportSnapshotV2_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmExportSnapshotV2" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VsphereVmExportSnapshotV2_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereVmExportSnapshotV2((AsyncRequestStatus)fieldSpecObj);
        }
        public static string VsphereVmExportSnapshotV2(AsyncRequestStatus fieldSpec)
        {
            return VsphereVmExportSnapshotV2_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereVmExportSnapshotV2(object fieldSpecObj)
        {
            return VsphereVmExportSnapshotV2_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereVmExportSnapshotV2FieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereVmExportSnapshotV3
        // GraphQL -> vsphereVmExportSnapshotV3: AsyncRequestStatus! (type)
        public static string VsphereVmExportSnapshotV3_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmExportSnapshotV3" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VsphereVmExportSnapshotV3_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereVmExportSnapshotV3((AsyncRequestStatus)fieldSpecObj);
        }
        public static string VsphereVmExportSnapshotV3(AsyncRequestStatus fieldSpec)
        {
            return VsphereVmExportSnapshotV3_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereVmExportSnapshotV3(object fieldSpecObj)
        {
            return VsphereVmExportSnapshotV3_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereVmExportSnapshotV3FieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereVmExportSnapshotWithDownloadFromCloud
        // GraphQL -> vsphereVmExportSnapshotWithDownloadFromCloud: AsyncRequestStatus! (type)
        public static string VsphereVmExportSnapshotWithDownloadFromCloud_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmExportSnapshotWithDownloadFromCloud" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VsphereVmExportSnapshotWithDownloadFromCloud_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereVmExportSnapshotWithDownloadFromCloud((AsyncRequestStatus)fieldSpecObj);
        }
        public static string VsphereVmExportSnapshotWithDownloadFromCloud(AsyncRequestStatus fieldSpec)
        {
            return VsphereVmExportSnapshotWithDownloadFromCloud_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereVmExportSnapshotWithDownloadFromCloud(object fieldSpecObj)
        {
            return VsphereVmExportSnapshotWithDownloadFromCloud_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereVmExportSnapshotWithDownloadFromCloudFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncRequestStatus? VsphereVmInitiateBatchInstantRecovery
        // GraphQL -> vsphereVmInitiateBatchInstantRecovery: BatchAsyncRequestStatus! (type)
        public static string VsphereVmInitiateBatchInstantRecovery_TypedFieldSpec(BatchAsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmInitiateBatchInstantRecovery" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VsphereVmInitiateBatchInstantRecovery_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereVmInitiateBatchInstantRecovery((BatchAsyncRequestStatus)fieldSpecObj);
        }
        public static string VsphereVmInitiateBatchInstantRecovery(BatchAsyncRequestStatus fieldSpec)
        {
            return VsphereVmInitiateBatchInstantRecovery_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereVmInitiateBatchInstantRecovery(object fieldSpecObj)
        {
            return VsphereVmInitiateBatchInstantRecovery_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereVmInitiateBatchInstantRecoveryFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchAsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchAsyncRequestStatus? VsphereVmInitiateBatchLiveMountV2
        // GraphQL -> vsphereVmInitiateBatchLiveMountV2: BatchAsyncRequestStatus! (type)
        public static string VsphereVmInitiateBatchLiveMountV2_TypedFieldSpec(BatchAsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmInitiateBatchLiveMountV2" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VsphereVmInitiateBatchLiveMountV2_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereVmInitiateBatchLiveMountV2((BatchAsyncRequestStatus)fieldSpecObj);
        }
        public static string VsphereVmInitiateBatchLiveMountV2(BatchAsyncRequestStatus fieldSpec)
        {
            return VsphereVmInitiateBatchLiveMountV2_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereVmInitiateBatchLiveMountV2(object fieldSpecObj)
        {
            return VsphereVmInitiateBatchLiveMountV2_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereVmInitiateBatchLiveMountV2FieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchAsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereVmInitiateDiskMount
        // GraphQL -> vsphereVmInitiateDiskMount: AsyncRequestStatus! (type)
        public static string VsphereVmInitiateDiskMount_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmInitiateDiskMount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VsphereVmInitiateDiskMount_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereVmInitiateDiskMount((AsyncRequestStatus)fieldSpecObj);
        }
        public static string VsphereVmInitiateDiskMount(AsyncRequestStatus fieldSpec)
        {
            return VsphereVmInitiateDiskMount_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereVmInitiateDiskMount(object fieldSpecObj)
        {
            return VsphereVmInitiateDiskMount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereVmInitiateDiskMountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereVmInitiateInPlaceRecovery
        // GraphQL -> vsphereVmInitiateInPlaceRecovery: AsyncRequestStatus! (type)
        public static string VsphereVmInitiateInPlaceRecovery_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmInitiateInPlaceRecovery" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VsphereVmInitiateInPlaceRecovery_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereVmInitiateInPlaceRecovery((AsyncRequestStatus)fieldSpecObj);
        }
        public static string VsphereVmInitiateInPlaceRecovery(AsyncRequestStatus fieldSpec)
        {
            return VsphereVmInitiateInPlaceRecovery_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereVmInitiateInPlaceRecovery(object fieldSpecObj)
        {
            return VsphereVmInitiateInPlaceRecovery_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereVmInitiateInPlaceRecoveryFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereVmInitiateInstantRecoveryV2
        // GraphQL -> vsphereVmInitiateInstantRecoveryV2: AsyncRequestStatus! (type)
        public static string VsphereVmInitiateInstantRecoveryV2_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmInitiateInstantRecoveryV2" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VsphereVmInitiateInstantRecoveryV2_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereVmInitiateInstantRecoveryV2((AsyncRequestStatus)fieldSpecObj);
        }
        public static string VsphereVmInitiateInstantRecoveryV2(AsyncRequestStatus fieldSpec)
        {
            return VsphereVmInitiateInstantRecoveryV2_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereVmInitiateInstantRecoveryV2(object fieldSpecObj)
        {
            return VsphereVmInitiateInstantRecoveryV2_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereVmInitiateInstantRecoveryV2FieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereVmInitiateLiveMountV2
        // GraphQL -> vsphereVmInitiateLiveMountV2: AsyncRequestStatus! (type)
        public static string VsphereVmInitiateLiveMountV2_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmInitiateLiveMountV2" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VsphereVmInitiateLiveMountV2_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereVmInitiateLiveMountV2((AsyncRequestStatus)fieldSpecObj);
        }
        public static string VsphereVmInitiateLiveMountV2(AsyncRequestStatus fieldSpec)
        {
            return VsphereVmInitiateLiveMountV2_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereVmInitiateLiveMountV2(object fieldSpecObj)
        {
            return VsphereVmInitiateLiveMountV2_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereVmInitiateLiveMountV2FieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereVmListEsxiDatastoresReply? VsphereVmListEsxiDatastores
        // GraphQL -> vsphereVmListEsxiDatastores: VsphereVmListEsxiDatastoresReply! (type)
        public static string VsphereVmListEsxiDatastores_TypedFieldSpec(VsphereVmListEsxiDatastoresReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmListEsxiDatastores" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VsphereVmListEsxiDatastores_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereVmListEsxiDatastores((VsphereVmListEsxiDatastoresReply)fieldSpecObj);
        }
        public static string VsphereVmListEsxiDatastores(VsphereVmListEsxiDatastoresReply fieldSpec)
        {
            return VsphereVmListEsxiDatastores_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereVmListEsxiDatastores(object fieldSpecObj)
        {
            return VsphereVmListEsxiDatastores_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereVmListEsxiDatastoresFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VsphereVmListEsxiDatastoresReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereVmMountRelocate
        // GraphQL -> vsphereVmMountRelocate: AsyncRequestStatus! (type)
        public static string VsphereVmMountRelocate_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmMountRelocate" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VsphereVmMountRelocate_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereVmMountRelocate((AsyncRequestStatus)fieldSpecObj);
        }
        public static string VsphereVmMountRelocate(AsyncRequestStatus fieldSpec)
        {
            return VsphereVmMountRelocate_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereVmMountRelocate(object fieldSpecObj)
        {
            return VsphereVmMountRelocate_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereVmMountRelocateFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereVmMountRelocateV2
        // GraphQL -> vsphereVmMountRelocateV2: AsyncRequestStatus! (type)
        public static string VsphereVmMountRelocateV2_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmMountRelocateV2" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VsphereVmMountRelocateV2_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereVmMountRelocateV2((AsyncRequestStatus)fieldSpecObj);
        }
        public static string VsphereVmMountRelocateV2(AsyncRequestStatus fieldSpec)
        {
            return VsphereVmMountRelocateV2_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereVmMountRelocateV2(object fieldSpecObj)
        {
            return VsphereVmMountRelocateV2_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereVmMountRelocateV2FieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereVmPowerOnOffLiveMountReply? VsphereVmPowerOnOffLiveMount
        // GraphQL -> vsphereVmPowerOnOffLiveMount: VsphereVmPowerOnOffLiveMountReply! (type)
        public static string VsphereVmPowerOnOffLiveMount_TypedFieldSpec(VsphereVmPowerOnOffLiveMountReply fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmPowerOnOffLiveMount" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VsphereVmPowerOnOffLiveMount_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereVmPowerOnOffLiveMount((VsphereVmPowerOnOffLiveMountReply)fieldSpecObj);
        }
        public static string VsphereVmPowerOnOffLiveMount(VsphereVmPowerOnOffLiveMountReply fieldSpec)
        {
            return VsphereVmPowerOnOffLiveMount_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereVmPowerOnOffLiveMount(object fieldSpecObj)
        {
            return VsphereVmPowerOnOffLiveMount_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereVmPowerOnOffLiveMountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VsphereVmPowerOnOffLiveMountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereAsyncRequestStatus? VsphereVmRecoverFiles
        // GraphQL -> vsphereVmRecoverFiles: VsphereAsyncRequestStatus! (type)
        public static string VsphereVmRecoverFiles_TypedFieldSpec(VsphereAsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmRecoverFiles" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VsphereVmRecoverFiles_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereVmRecoverFiles((VsphereAsyncRequestStatus)fieldSpecObj);
        }
        public static string VsphereVmRecoverFiles(VsphereAsyncRequestStatus fieldSpec)
        {
            return VsphereVmRecoverFiles_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereVmRecoverFiles(object fieldSpecObj)
        {
            return VsphereVmRecoverFiles_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereVmRecoverFilesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VsphereAsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereVmRecoverFilesNew
        // GraphQL -> vsphereVmRecoverFilesNew: AsyncRequestStatus! (type)
        public static string VsphereVmRecoverFilesNew_TypedFieldSpec(AsyncRequestStatus fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmRecoverFilesNew" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VsphereVmRecoverFilesNew_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereVmRecoverFilesNew((AsyncRequestStatus)fieldSpecObj);
        }
        public static string VsphereVmRecoverFilesNew(AsyncRequestStatus fieldSpec)
        {
            return VsphereVmRecoverFilesNew_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereVmRecoverFilesNew(object fieldSpecObj)
        {
            return VsphereVmRecoverFilesNew_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereVmRecoverFilesNewFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RequestSuccess? VsphereVmRegisterAgent
        // GraphQL -> vsphereVmRegisterAgent: RequestSuccess! (type)
        public static string VsphereVmRegisterAgent_TypedFieldSpec(RequestSuccess fieldSpec)
        {
            string args = "\n(\ninput: $input\n)";
            return "vsphereVmRegisterAgent" + args + "\n{\n" +
                    fieldSpec.AsFieldSpec() +
                    "}\n";
        }
        public static string VsphereVmRegisterAgent_ObjectFieldSpec(object fieldSpecObj)
        {
            return VsphereVmRegisterAgent((RequestSuccess)fieldSpecObj);
        }
        public static string VsphereVmRegisterAgent(RequestSuccess fieldSpec)
        {
            return VsphereVmRegisterAgent_TypedFieldSpec(fieldSpec);
        }
        public static string VsphereVmRegisterAgent(object fieldSpecObj)
        {
            return VsphereVmRegisterAgent_ObjectFieldSpec(fieldSpecObj);
        }
        public static object VsphereVmRegisterAgentFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RequestSuccess() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        #endregion

    } // class Mutation
    #endregion
}