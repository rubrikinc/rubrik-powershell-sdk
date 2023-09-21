// New-RscGqlMutationUpdateCustomerAppPermissionForAzureSql.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Create new GraphQL Mutation updateCustomerAppPermissionForAzureSql
    /// updateCustomerAppPermissionForAzureSql: Void
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationUpdateCustomerAppPermissionForAzureSql")
    ]
    public class New_RscGqlMutationUpdateCustomerAppPermissionForAzureSql : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("updateCustomerAppPermissionForAzureSql");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation updateCustomerAppPermissionForAzureSql
        /// updateCustomerAppPermissionForAzureSql: Void
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_updateCustomerAppPermissionForAzureSql();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_updateCustomerAppPermissionForAzureSql()
        {
            this._logger.name += " -updateCustomerAppPermissionForAzureSql";
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCustomerAppPermissionForAzureSql",
                "",
                "System.String",
                Mutation.UpdateCustomerAppPermissionForAzureSql_ObjectFieldSpec,
                Mutation.UpdateCustomerAppPermissionForAzureSqlFieldSpec,
                @""
            );
        }

    } // class New-RscGqlMutationUpdateCustomerAppPermissionForAzureSql
}