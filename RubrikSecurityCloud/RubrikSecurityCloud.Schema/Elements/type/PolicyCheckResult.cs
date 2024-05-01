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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? CheckOutput
        // GraphQL -> checkOutput: String (scalar)
        if (this.CheckOutput != null) {
            if (conf.Flat) {
                s += conf.Prefix + "checkOutput\n" ;
            } else {
                s += ind + "checkOutput\n" ;
            }
        }
        //      C# -> System.Boolean? IsCheckPassed
        // GraphQL -> isCheckPassed: Boolean! (scalar)
        if (this.IsCheckPassed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isCheckPassed\n" ;
            } else {
                s += ind + "isCheckPassed\n" ;
            }
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (this.NodeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodeId\n" ;
            } else {
                s += ind + "nodeId\n" ;
            }
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        if (this.PolicyId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyId\n" ;
            } else {
                s += ind + "policyId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CheckOutput
        // GraphQL -> checkOutput: String (scalar)
        if (ec.Includes("checkOutput",true))
        {
            if(this.CheckOutput == null) {

                this.CheckOutput = "FETCH";

            } else {


            }
        }
        else if (this.CheckOutput != null && ec.Excludes("checkOutput",true))
        {
            this.CheckOutput = null;
        }
        //      C# -> System.Boolean? IsCheckPassed
        // GraphQL -> isCheckPassed: Boolean! (scalar)
        if (ec.Includes("isCheckPassed",true))
        {
            if(this.IsCheckPassed == null) {

                this.IsCheckPassed = true;

            } else {


            }
        }
        else if (this.IsCheckPassed != null && ec.Excludes("isCheckPassed",true))
        {
            this.IsCheckPassed = null;
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (ec.Includes("nodeId",true))
        {
            if(this.NodeId == null) {

                this.NodeId = "FETCH";

            } else {


            }
        }
        else if (this.NodeId != null && ec.Excludes("nodeId",true))
        {
            this.NodeId = null;
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        if (ec.Includes("policyId",true))
        {
            if(this.PolicyId == null) {

                this.PolicyId = "FETCH";

            } else {


            }
        }
        else if (this.PolicyId != null && ec.Excludes("policyId",true))
        {
            this.PolicyId = null;
        }
    }


    #endregion

    } // class PolicyCheckResult
    
    #endregion

    public static class ListPolicyCheckResultExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<PolicyCheckResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PolicyCheckResult> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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