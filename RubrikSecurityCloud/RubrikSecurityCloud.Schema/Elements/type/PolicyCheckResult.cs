// PolicyCheckResult.cs
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
    #region PolicyCheckResult
    public class PolicyCheckResult: BaseType
    {
        #region members

        //      C# -> System.String? CheckOutput
        // GraphQL -> checkOutput: String (scalar)
        [JsonProperty("checkOutput")]
        public System.String? CheckOutput { get; set; }

        //      C# -> System.Boolean? IsCheckPassed
        // GraphQL -> isCheckPassed: Boolean! (scalar)
        [JsonProperty("isCheckPassed")]
        public System.Boolean? IsCheckPassed { get; set; }

        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        [JsonProperty("nodeId")]
        public System.String? NodeId { get; set; }

        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        [JsonProperty("policyId")]
        public System.String? PolicyId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PolicyCheckResult";
    }

    public PolicyCheckResult Set(
        System.String? CheckOutput = null,
        System.Boolean? IsCheckPassed = null,
        System.String? NodeId = null,
        System.String? PolicyId = null
    ) 
    {
        if ( CheckOutput != null ) {
            this.CheckOutput = CheckOutput;
        }
        if ( IsCheckPassed != null ) {
            this.IsCheckPassed = IsCheckPassed;
        }
        if ( NodeId != null ) {
            this.NodeId = NodeId;
        }
        if ( PolicyId != null ) {
            this.PolicyId = PolicyId;
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
        //      C# -> System.String? CheckOutput
        // GraphQL -> checkOutput: String (scalar)
        if (this.CheckOutput != null) {
            s += ind + "checkOutput\n" ;
        }
        //      C# -> System.Boolean? IsCheckPassed
        // GraphQL -> isCheckPassed: Boolean! (scalar)
        if (this.IsCheckPassed != null) {
            s += ind + "isCheckPassed\n" ;
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (this.NodeId != null) {
            s += ind + "nodeId\n" ;
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        if (this.PolicyId != null) {
            s += ind + "policyId\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CheckOutput
        // GraphQL -> checkOutput: String (scalar)
        if (this.CheckOutput == null && ec.Includes("checkOutput",true))
        {
            this.CheckOutput = "FETCH";
        }
        //      C# -> System.Boolean? IsCheckPassed
        // GraphQL -> isCheckPassed: Boolean! (scalar)
        if (this.IsCheckPassed == null && ec.Includes("isCheckPassed",true))
        {
            this.IsCheckPassed = true;
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (this.NodeId == null && ec.Includes("nodeId",true))
        {
            this.NodeId = "FETCH";
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        if (this.PolicyId == null && ec.Includes("policyId",true))
        {
            this.PolicyId = "FETCH";
        }
    }


    #endregion

    } // class PolicyCheckResult
    
    #endregion

    public static class ListPolicyCheckResultExtensions
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
            this List<PolicyCheckResult> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PolicyCheckResult> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PolicyCheckResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PolicyCheckResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types