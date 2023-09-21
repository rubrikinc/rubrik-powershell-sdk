// New-RscGqlMutationCreateAzureSaasAppAad.cs
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
    /// Create new GraphQL Mutation createAzureSaasAppAad
    /// createAzureSaasAppAad: CreateAzureSaasAppAadReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationCreateAzureSaasAppAad")
    ]
    public class New_RscGqlMutationCreateAzureSaasAppAad : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("createAzureSaasAppAad");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation createAzureSaasAppAad
        /// createAzureSaasAppAad: CreateAzureSaasAppAadReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_createAzureSaasAppAad();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_createAzureSaasAppAad()
        {
            this._logger.name += " -createAzureSaasAppAad";
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAzureSaasAppAad",
                "",
                "CreateAzureSaasAppAadReply",
                Mutation.CreateAzureSaasAppAad_ObjectFieldSpec,
                Mutation.CreateAzureSaasAppAadFieldSpec,
                @""
            );
        }

    } // class New-RscGqlMutationCreateAzureSaasAppAad
}