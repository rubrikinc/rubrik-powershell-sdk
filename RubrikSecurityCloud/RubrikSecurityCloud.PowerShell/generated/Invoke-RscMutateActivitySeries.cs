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
    /// <summary>
    /// Activity series mutations
    /// </summary>
    /// <description>
    /// Invoke-RscMutateActivitySeries is a master cmdlet for ActivitySeries work that can invoke any of the following subcommands: Cancel.
    /// </description>
    /// <example>
    /// <code>Invoke-RscMutateActivitySeries -Cancel [-Arg ..] [-Field ..]</code>
    /// </example>
    [Cmdlet(
        "Invoke",
        "RscMutateActivitySeries",
        DefaultParameterSetName = "Cancel")
    ]
    public class Invoke_RscMutateActivitySeries : RscPSCmdlet
    {
        
        /// <summary>
        /// Cancel parameter set
        ///
        /// [GraphQL: cancelActivitySeries]
        /// </summary>
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


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
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
#pragma warning restore 1591

        // This parameter set invokes a single graphql operation:
        // cancelActivitySeries.
        internal void ProcessRecord_Cancel()
        {
            this._logger.name += " -Cancel";
            // Invoke graphql operation cancelActivitySeries
            InvokeMutationCancelActivitySeries();
        }


        // Invoke GraphQL Mutation:
        // cancelActivitySeries(input: CancelActivitySeriesInput!): Boolean!
        internal void InvokeMutationCancelActivitySeries()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CancelActivitySeriesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCancelActivitySeries",
                "($input: CancelActivitySeriesInput!)",
                "System.Boolean"
                );
            System.Boolean? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (System.Boolean)this.Field;
            }
            string fieldSpecDoc = Mutation.CancelActivitySeries(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }


    } // class Invoke_RscMutateActivitySeries
}