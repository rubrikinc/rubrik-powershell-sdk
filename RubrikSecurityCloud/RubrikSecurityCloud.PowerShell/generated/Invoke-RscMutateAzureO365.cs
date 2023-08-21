// Invoke-RscMutateAzureO365.cs
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
    /// AzureO365 mutations
    /// </summary>
    /// <description>
    /// Invoke-RscMutateAzureO365 is a master cmdlet for AzureO365 work that can invoke any of the following subcommands: SetupExocompute.
    /// </description>
    /// <example>
    /// <code>Invoke-RscMutateAzureO365 -SetupExocompute [-Arg ..] [-Field ..]</code>
    /// </example>
    [Cmdlet(
        "Invoke",
        "RscMutateAzureO365",
        DefaultParameterSetName = "SetupExocompute")
    ]
    public class Invoke_RscMutateAzureO365 : RscPSCmdlet
    {
        
        /// <summary>
        /// SetupExocompute parameter set
        ///
        /// [GraphQL: setupAzureO365Exocompute]
        /// </summary>
        [Parameter(
            ParameterSetName = "SetupExocompute",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Sets up Exocompute for an O365 subscription.
[GraphQL: setupAzureO365Exocompute]",
            Position = 0
        )]
        public SwitchParameter SetupExocompute { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "SetupExocompute":
                        this.ProcessRecord_SetupExocompute();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }
#pragma warning restore 1591

        // This parameter set invokes a single graphql operation:
        // setupAzureO365Exocompute.
        internal void ProcessRecord_SetupExocompute()
        {
            this._logger.name += " -SetupExocompute";
            // Invoke graphql operation setupAzureO365Exocompute
            InvokeMutationSetupAzureO365Exocompute();
        }


        // Invoke GraphQL Mutation:
        // setupAzureO365Exocompute(tenantId: String!, subscriptionId: UUID!, exocomputeConfig: AzureO365ExocomputeConfig!): SetupAzureO365ExocomputeResp!
        internal void InvokeMutationSetupAzureO365Exocompute()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("exocomputeConfig", "AzureO365ExocomputeConfig!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetupAzureO365Exocompute",
                "($tenantId: String!,$subscriptionId: UUID!,$exocomputeConfig: AzureO365ExocomputeConfig!)",
                "SetupAzureO365ExocomputeResp"
                );
            SetupAzureO365ExocomputeResp? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (SetupAzureO365ExocomputeResp)this.Field;
            }
            string fieldSpecDoc = Mutation.SetupAzureO365Exocompute(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }


    } // class Invoke_RscMutateAzureO365
}