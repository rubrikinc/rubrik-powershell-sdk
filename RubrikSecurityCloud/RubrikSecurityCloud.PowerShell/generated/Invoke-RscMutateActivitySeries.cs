// Invoke-RscMutateActivitySeries.cs
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
using Rubrik.SecurityCloud.NetSDK.Library.HelperClasses;
using Rubrik.SecurityCloud.Operations;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscMutateActivitySeries",
        DefaultParameterSetName = "cancel")
    ]
    public class Invoke_RscMutateActivitySeries : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // cancel parameter set
        //
        // GraphQL operation: cancelActivitySeries(input: CancelActivitySeriesInput!):Boolean!
        //
        [Parameter(
            ParameterSetName = "cancel",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: cancelActivitySeries(input: CancelActivitySeriesInput!):Boolean!",
            Position = 0
        )]
        public SwitchParameter cancel { get; set; }

        [Parameter(
            ParameterSetName = "cancel",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument input: CancelActivitySeriesInput!"
        )]
        public CancelActivitySeriesInput? Input { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "cancel":
                        this.ProcessRecord_cancel();
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
                    "Invoke-RscMutateActivitySeries",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // cancelActivitySeries.
        protected void ProcessRecord_cancel()
        {
            this._logger.name += " -cancel";
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Mutation.CancelActivitySeries(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CancelActivitySeries");
            string parameters = "($input: CancelActivitySeriesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCancelActivitySeries" + parameters + "{" + document + "}",
                OperationName = "MutationCancelActivitySeries",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<System.Boolean> task = this._rbkClient.InvokeGenericCallAsync<System.Boolean>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }


    } // class Invoke_RscMutateActivitySeries
}