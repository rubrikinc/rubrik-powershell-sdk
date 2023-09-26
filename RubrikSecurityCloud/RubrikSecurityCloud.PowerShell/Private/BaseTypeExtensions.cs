using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using RubrikSecurityCloud;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.Types
{
    // THIS DOESN'T WORK BECAUSE
    // The issue seems to be with how PowerShell resolves extension methods. Unlike C#, PowerShell doesn't naturally recognize C# extension methods as instance methods on the target type. That's why the instance method call [RubrikSecurityCloud.Types.ClusterConnection]::new().Query() fails, but the static method call [RubrikSecurityCloud.Types.BaseTypeExtensions]::Query([RubrikSecurityCloud.Types.ClusterConnection]::new()) succeeds.
    // 
    // public static class BaseTypeExtensions
    // {
    //     public static string Query(this BaseType baseTypeInstance)
    //     {
    //         // e.g. "ClusterConnection"
    //         string returnTypeName = baseTypeInstance.GetGqlTypeName();
    //         Console.WriteLine($"returnTypeName: {returnTypeName}");

    //         // e.g. {"allClusterConnection", "clusterConnection", "clusterWithConfigProtectionInfo", ..}
    //         List<string> rootFieldNames = SchemaMeta.GqlRootFieldLookupByReturnType(returnTypeName);
    //         foreach (string rootFieldName in rootFieldNames)
    //         {
    //             Console.WriteLine($"rootFieldName: {rootFieldName}");
    //             if (Enum.TryParse<SchemaMeta.GqlRootFieldName>(
    //                 rootFieldName,
    //                 out SchemaMeta.GqlRootFieldName validRootFieldName))
    //             {
    //                 // The provided operation is a valid enum member
    //                 RscOp rscOp = SchemaMeta.RscOpLookupByGqlRootField(validRootFieldName);
    //                 Console.WriteLine($"rscOp: {rscOp}");
    //             }
    //             else
    //             {
    //                 Console.WriteLine($"rootFieldName: {rootFieldName} is not a valid enum member");
    //             }
    //         }

    //         using (var powerShell =
    //             System.Management.Automation.PowerShell.Create())
    //         {
    //             powerShell.AddCommand("Get-Module");
    //             var modules = powerShell.Invoke();
    //             // Write to host:
    //             foreach (var module in modules)
    //             {
    //                 Console.WriteLine($"Module: {module}");
    //             }

    //             powerShell.AddCommand("Get-RscCmdlet");
    //             powerShell.AddParameter(
    //                 "ExistingGqlOpName",
    //                 "xyz");

    //             var results = powerShell.Invoke();

    //             string output = string.Join(", ", results);
    //             // example: "New-RscQueryCluster -List"
    //             return output;
    //         }
    //     }
    // }
}