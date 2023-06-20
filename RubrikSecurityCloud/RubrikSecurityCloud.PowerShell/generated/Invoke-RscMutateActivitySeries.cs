// Invoke-RscMutateActivitySeries.cs
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
        "RscMutateActivitySeries",
        DefaultParameterSetName = "Cancel")
    ]
    public class Invoke_RscMutateActivitySeries : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Cancel parameter set
        //
        // [GraphQL: cancelActivitySeries]
        //
        [Parameter(
            ParameterSetName = "Cancel",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Cancel an activity series.
[GraphQL: cancelActivitySeries]",
            Position = 0
        )]
        public SwitchParameter Cancel { get; set; }

        [Parameter(
            ParameterSetName = "Cancel",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Input for canceling an activity series.
GraphQL argument input: CancelActivitySeriesInput!"
        )]
        public CancelActivitySeriesInput? Input { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Cancel":
                        this.ProcessRecord_Cancel();
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
        // cancelActivitySeries.
        protected void ProcessRecord_Cancel()
        {
            this._logger.name += " -Cancel";
            // Invoke graphql operation cancelActivitySeries
            InvokeMutationCancelActivitySeries();
        }


        // Invoke GraphQL Mutation:
        // cancelActivitySeries(input: CancelActivitySeriesInput!): Boolean!
        protected void InvokeMutationCancelActivitySeries()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CancelActivitySeriesInput!"),
            };
            System.Boolean? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Mutation.CancelActivitySeries(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CancelActivitySeries");
            var parameters = "($input: CancelActivitySeriesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCancelActivitySeries" + parameters + "{" + document + "}",
                OperationName = "MutationCancelActivitySeries",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "System.Boolean", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscMutateActivitySeries
}