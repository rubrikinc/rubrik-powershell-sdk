// New-RscGqlQueryAllAccountOwners.cs
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
    /// Create new GraphQL Query allAccountOwners
    /// allAccountOwners: [User!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAccountOwners")
    ]
    public class New_RscGqlQueryAllAccountOwners : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAccountOwners");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAccountOwners
        /// allAccountOwners: [User!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAccountOwners();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAccountOwners()
        {
            this._logger.name += " -allAccountOwners";
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAccountOwners",
                "",
                "List<User>",
                Query.AllAccountOwners_ObjectFieldSpec,
                Query.AllAccountOwnersFieldSpec,
                @""
            );
        }

    } // class New-RscGqlQueryAllAccountOwners
}