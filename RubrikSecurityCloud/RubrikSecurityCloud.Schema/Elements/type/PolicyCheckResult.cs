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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? CheckOutput
        // GraphQL -> checkOutput: String (scalar)
        if (this.CheckOutput == null && Exploration.Includes(parent + ".checkOutput", true))
        {
            this.CheckOutput = new System.String("FETCH");
        }
        //      C# -> System.Boolean? IsCheckPassed
        // GraphQL -> isCheckPassed: Boolean! (scalar)
        if (this.IsCheckPassed == null && Exploration.Includes(parent + ".isCheckPassed", true))
        {
            this.IsCheckPassed = true;
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (this.NodeId == null && Exploration.Includes(parent + ".nodeId", true))
        {
            this.NodeId = new System.String("FETCH");
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        if (this.PolicyId == null && Exploration.Includes(parent + ".policyId", true))
        {
            this.PolicyId = new System.String("FETCH");
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
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PolicyCheckResult> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PolicyCheckResult());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types