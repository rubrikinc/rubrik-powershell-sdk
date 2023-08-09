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
    [Cmdlet(
        "Invoke",
        "RscMutateAzureO365",
        DefaultParameterSetName = "SetupExocompute")
    ]
    public class Invoke_RscMutateAzureO365 : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // SetupExocompute parameter set
        //
        // [GraphQL: setupAzureO365Exocompute]
        //
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

        // This parameter set invokes a single graphql operation:
        // setupAzureO365Exocompute.
        protected void ProcessRecord_SetupExocompute()
        {
            this._logger.name += " -SetupExocompute";
            // Invoke graphql operation setupAzureO365Exocompute
            InvokeMutationSetupAzureO365Exocompute();
        }


        // Invoke GraphQL Mutation:
        // setupAzureO365Exocompute(tenantId: String!, subscriptionId: UUID!, exocomputeConfig: AzureO365ExocomputeConfig!): SetupAzureO365ExocomputeResp!
        protected void InvokeMutationSetupAzureO365Exocompute()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("exocomputeConfig", "AzureO365ExocomputeConfig!"),
            };
            SetupAzureO365ExocomputeResp? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (SetupAzureO365ExocomputeResp)psObject.BaseObject;
                } else {
                    fieldSpecObj = (SetupAzureO365ExocomputeResp)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.SetupAzureO365Exocompute(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationSetupAzureO365Exocompute",
                "($tenantId: String!,$subscriptionId: UUID!,$exocomputeConfig: AzureO365ExocomputeConfig!)",
                fieldSpecDoc,
                "SetupAzureO365ExocomputeResp"
            );
        }


    } // class Invoke_RscMutateAzureO365
}