// PendingEvaluationResultsReply.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region PendingEvaluationResultsReply
    public class PendingEvaluationResultsReply: BaseType
    {
        #region members

        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        [JsonProperty("count")]
        public System.Int64? Count { get; set; }

        //      C# -> List<PendingEvaluationResults>? PendingEvaluationResults
        // GraphQL -> pendingEvaluationResults: [PendingEvaluationResults!]! (type)
        [JsonProperty("pendingEvaluationResults")]
        public List<PendingEvaluationResults>? PendingEvaluationResults { get; set; }


        #endregion

    #region methods

    public PendingEvaluationResultsReply Set(
        System.Int64? Count = null,
        List<PendingEvaluationResults>? PendingEvaluationResults = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( PendingEvaluationResults != null ) {
            this.PendingEvaluationResults = PendingEvaluationResults;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        if (this.Count != null) {
            s += ind + "count\n" ;
        }
        //      C# -> List<PendingEvaluationResults>? PendingEvaluationResults
        // GraphQL -> pendingEvaluationResults: [PendingEvaluationResults!]! (type)
        if (this.PendingEvaluationResults != null) {
            s += ind + "pendingEvaluationResults {\n" + this.PendingEvaluationResults.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        if (this.Count == null && Exploration.Includes(parent + ".count", true))
        {
            this.Count = new System.Int64();
        }
        //      C# -> List<PendingEvaluationResults>? PendingEvaluationResults
        // GraphQL -> pendingEvaluationResults: [PendingEvaluationResults!]! (type)
        if (this.PendingEvaluationResults == null && Exploration.Includes(parent + ".pendingEvaluationResults"))
        {
            this.PendingEvaluationResults = new List<PendingEvaluationResults>();
            this.PendingEvaluationResults.ApplyExploratoryFieldSpec(parent + ".pendingEvaluationResults");
        }
    }


    #endregion

    } // class PendingEvaluationResultsReply
    
    #endregion

    public static class ListPendingEvaluationResultsReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<PendingEvaluationResultsReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PendingEvaluationResultsReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PendingEvaluationResultsReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types