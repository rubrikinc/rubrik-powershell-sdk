// Invoke-RscMutateAzureO365.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using Rubrik.SecurityCloud.Types;
using Rubrik.SecurityCloud.NetSDK.Client;
using Rubrik.SecurityCloud.PowerShell.Private;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using RubrikSecurityCloud.Schema.Utils;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscMutateAzureO365",
        DefaultParameterSetName = "setupExocompute")
    ]
    public class Invoke_RscMutateAzureO365 : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // setupExocompute parameter set
        //
        // GraphQL operation: setupAzureO365Exocompute(tenantId: String!, subscriptionId: UUID!, exocomputeConfig: AzureO365ExocomputeConfig!):SetupAzureO365ExocomputeResp!
        //
        [Parameter(
            ParameterSetName = "setupExocompute",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Sets up Exocompute for an O365 subscription.
                GraphQL operation: setupAzureO365Exocompute(tenantId: String!, subscriptionId: UUID!, exocomputeConfig: AzureO365ExocomputeConfig!):SetupAzureO365ExocomputeResp!
                ",
            Position = 0
        )]
        public SwitchParameter setupExocompute { get; set; }

        [Parameter(
            ParameterSetName = "setupExocompute",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument tenantId: String!
                "
        )]
        public System.String? TenantId { get; set; }
        [Parameter(
            ParameterSetName = "setupExocompute",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument subscriptionId: UUID!
                "
        )]
        public System.String? SubscriptionId { get; set; }
        [Parameter(
            ParameterSetName = "setupExocompute",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument exocomputeConfig: AzureO365ExocomputeConfig!
                "
        )]
        public AzureO365ExocomputeConfig? ExocomputeConfig { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "setupExocompute":
                        this.ProcessRecord_setupExocompute();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                this._logger.Flush();
                var error = new ErrorRecord(
                    ex,
                    "Invoke-RscMutateAzureO365",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // setupAzureO365Exocompute.
        protected void ProcessRecord_setupExocompute()
        {
            this._logger.name += " -setupExocompute";
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
            SetupAzureO365ExocomputeResp? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (SetupAzureO365ExocomputeResp)psObject.BaseObject;
                } else {
                    fields = (SetupAzureO365ExocomputeResp)this.Field;
                }
            }
            string document = Mutation.SetupAzureO365Exocompute(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.SetupAzureO365Exocompute");
            var parameters = "($tenantId: String!,$subscriptionId: UUID!,$exocomputeConfig: AzureO365ExocomputeConfig!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationSetupAzureO365Exocompute" + parameters + "{" + document + "}",
                OperationName = "MutationSetupAzureO365Exocompute",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "SetupAzureO365ExocomputeResp", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscMutateAzureO365
}