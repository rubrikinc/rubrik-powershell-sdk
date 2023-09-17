// Invoke-RscGqlMutateInsertCustomerO365App.cs
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
    /// Invoke GraphQL Mutation insertCustomerO365App
    /// insertCustomerO365App(input: InsertCustomerO365AppInput!): RequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateInsertCustomerO365App")
    ]
    public class Invoke_RscGqlMutateInsertCustomerO365App : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("insertCustomerO365App");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation insertCustomerO365App
        /// insertCustomerO365App(input: InsertCustomerO365AppInput!): RequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_insertCustomerO365App();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_insertCustomerO365App()
        {
            this._logger.name += " -insertCustomerO365App";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "InsertCustomerO365AppInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationInsertCustomerO365App",
                "($input: InsertCustomerO365AppInput!)",
                "RequestStatus",
                Mutation.InsertCustomerO365App_ObjectFieldSpec,
                Mutation.InsertCustomerO365AppFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	appType = <System.String>
	# REQUIRED
	appClientId = <System.String>
	# REQUIRED
	appClientSecret = <System.String>
	# REQUIRED
	subscriptionId = <System.String>
	# OPTIONAL
	base64AppCertificate = <System.String>
	# OPTIONAL
	base64AppPrivateKey = <System.String>
}"
            );
        }

    } // class Invoke-RscGqlMutateInsertCustomerO365App
}