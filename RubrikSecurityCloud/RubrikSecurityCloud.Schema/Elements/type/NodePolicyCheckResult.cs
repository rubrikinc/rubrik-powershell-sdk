// NodePolicyCheckResult.cs
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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region NodePolicyCheckResult
    public class NodePolicyCheckResult: BaseType
    {
        #region members

        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        [JsonProperty("nodeId")]
        public System.String? NodeId { get; set; }

        //      C# -> List<PolicyCheckResult>? CheckResults
        // GraphQL -> checkResults: [PolicyCheckResult!]! (type)
        [JsonProperty("checkResults")]
        public List<PolicyCheckResult>? CheckResults { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NodePolicyCheckResult";
    }

    public NodePolicyCheckResult Set(
        System.String? NodeId = null,
        List<PolicyCheckResult>? CheckResults = null
    ) 
    {
        if ( NodeId != null ) {
            this.NodeId = NodeId;
        }
        if ( CheckResults != null ) {
            this.CheckResults = CheckResults;
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
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (this.NodeId != null) {
            s += ind + "nodeId\n" ;
        }
        //      C# -> List<PolicyCheckResult>? CheckResults
        // GraphQL -> checkResults: [PolicyCheckResult!]! (type)
        if (this.CheckResults != null) {
            var fspec = this.CheckResults.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "checkResults {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (this.NodeId == null && ec.Includes("nodeId",true))
        {
            this.NodeId = "FETCH";
        }
        //      C# -> List<PolicyCheckResult>? CheckResults
        // GraphQL -> checkResults: [PolicyCheckResult!]! (type)
        if (this.CheckResults == null && ec.Includes("checkResults",false))
        {
            this.CheckResults = new List<PolicyCheckResult>();
            this.CheckResults.ApplyExploratoryFieldSpec(ec.NewChild("checkResults"));
        }
    }


    #endregion

    } // class NodePolicyCheckResult
    
    #endregion

    public static class ListNodePolicyCheckResultExtensions
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
            this List<NodePolicyCheckResult> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NodePolicyCheckResult> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NodePolicyCheckResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<NodePolicyCheckResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types