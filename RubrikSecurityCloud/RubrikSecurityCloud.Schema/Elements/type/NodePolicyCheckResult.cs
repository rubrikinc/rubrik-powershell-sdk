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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (this.NodeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodeId\n" ;
            } else {
                s += ind + "nodeId\n" ;
            }
        }
        //      C# -> List<PolicyCheckResult>? CheckResults
        // GraphQL -> checkResults: [PolicyCheckResult!]! (type)
        if (this.CheckResults != null) {
            var fspec = this.CheckResults.AsFieldSpec(conf.Child("checkResults"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "checkResults {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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
        //      C# -> List<PolicyCheckResult>? CheckResults
        // GraphQL -> checkResults: [PolicyCheckResult!]! (type)
        if (ec.Includes("checkResults",false))
        {
            if(this.CheckResults == null) {

                this.CheckResults = new List<PolicyCheckResult>();
                this.CheckResults.ApplyExploratoryFieldSpec(ec.NewChild("checkResults"));

            } else {

                this.CheckResults.ApplyExploratoryFieldSpec(ec.NewChild("checkResults"));

            }
        }
        else if (this.CheckResults != null && ec.Excludes("checkResults",false))
        {
            this.CheckResults = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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

        public static void SelectForRetrieval(this List<NodePolicyCheckResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types