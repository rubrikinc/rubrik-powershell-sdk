// FailoverClusterDetail.cs
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
    #region FailoverClusterDetail
    public class FailoverClusterDetail: BaseType
    {
        #region members

        //      C# -> System.Int32? NumApps
        // GraphQL -> numApps: Int! (scalar)
        [JsonProperty("numApps")]
        public System.Int32? NumApps { get; set; }

        //      C# -> System.Int32? NumNodes
        // GraphQL -> numNodes: Int! (scalar)
        [JsonProperty("numNodes")]
        public System.Int32? NumNodes { get; set; }

        //      C# -> FailoverClusterSummary? FailoverClusterSummary
        // GraphQL -> failoverClusterSummary: FailoverClusterSummary (type)
        [JsonProperty("failoverClusterSummary")]
        public FailoverClusterSummary? FailoverClusterSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FailoverClusterDetail";
    }

    public FailoverClusterDetail Set(
        System.Int32? NumApps = null,
        System.Int32? NumNodes = null,
        FailoverClusterSummary? FailoverClusterSummary = null
    ) 
    {
        if ( NumApps != null ) {
            this.NumApps = NumApps;
        }
        if ( NumNodes != null ) {
            this.NumNodes = NumNodes;
        }
        if ( FailoverClusterSummary != null ) {
            this.FailoverClusterSummary = FailoverClusterSummary;
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
        //      C# -> System.Int32? NumApps
        // GraphQL -> numApps: Int! (scalar)
        if (this.NumApps != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numApps\n" ;
            } else {
                s += ind + "numApps\n" ;
            }
        }
        //      C# -> System.Int32? NumNodes
        // GraphQL -> numNodes: Int! (scalar)
        if (this.NumNodes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numNodes\n" ;
            } else {
                s += ind + "numNodes\n" ;
            }
        }
        //      C# -> FailoverClusterSummary? FailoverClusterSummary
        // GraphQL -> failoverClusterSummary: FailoverClusterSummary (type)
        if (this.FailoverClusterSummary != null) {
            var fspec = this.FailoverClusterSummary.AsFieldSpec(conf.Child("failoverClusterSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "failoverClusterSummary {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? NumApps
        // GraphQL -> numApps: Int! (scalar)
        if (ec.Includes("numApps",true))
        {
            if(this.NumApps == null) {

                this.NumApps = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumApps != null && ec.Excludes("numApps",true))
        {
            this.NumApps = null;
        }
        //      C# -> System.Int32? NumNodes
        // GraphQL -> numNodes: Int! (scalar)
        if (ec.Includes("numNodes",true))
        {
            if(this.NumNodes == null) {

                this.NumNodes = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumNodes != null && ec.Excludes("numNodes",true))
        {
            this.NumNodes = null;
        }
        //      C# -> FailoverClusterSummary? FailoverClusterSummary
        // GraphQL -> failoverClusterSummary: FailoverClusterSummary (type)
        if (ec.Includes("failoverClusterSummary",false))
        {
            if(this.FailoverClusterSummary == null) {

                this.FailoverClusterSummary = new FailoverClusterSummary();
                this.FailoverClusterSummary.ApplyExploratoryFieldSpec(ec.NewChild("failoverClusterSummary"));

            } else {

                this.FailoverClusterSummary.ApplyExploratoryFieldSpec(ec.NewChild("failoverClusterSummary"));

            }
        }
        else if (this.FailoverClusterSummary != null && ec.Excludes("failoverClusterSummary",false))
        {
            this.FailoverClusterSummary = null;
        }
    }


    #endregion

    } // class FailoverClusterDetail
    
    #endregion

    public static class ListFailoverClusterDetailExtensions
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
            this List<FailoverClusterDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FailoverClusterDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverClusterDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FailoverClusterDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types