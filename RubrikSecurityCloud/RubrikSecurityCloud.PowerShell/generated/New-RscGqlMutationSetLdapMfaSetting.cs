// New-RscGqlMutationSetLdapMfaSetting.cs
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
    /// Create new GraphQL Mutation setLdapMfaSetting
    /// setLdapMfaSetting(input: SetLdapMfaSettingInput!): Boolean!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationSetLdapMfaSetting")
    ]
    public class New_RscGqlMutationSetLdapMfaSetting : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("setLdapMfaSetting");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation setLdapMfaSetting
        /// setLdapMfaSetting(input: SetLdapMfaSettingInput!): Boolean!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_setLdapMfaSetting();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_setLdapMfaSetting()
        {
            this._logger.name += " -setLdapMfaSetting";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetLdapMfaSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetLdapMfaSetting",
                "($input: SetLdapMfaSettingInput!)",
                "System.Boolean",
                Mutation.SetLdapMfaSetting_ObjectFieldSpec,
                Mutation.SetLdapMfaSettingFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	ldapId = <System.String>
	# OPTIONAL
	isTotpEnforced = <System.Boolean>
}"
            );
        }

    } // class New-RscGqlMutationSetLdapMfaSetting
}