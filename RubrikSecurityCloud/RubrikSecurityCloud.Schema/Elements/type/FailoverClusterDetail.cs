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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
                    s += ind + "failoverClusterSummary" + " " + "{\n" + fspec + ind + "}\n" ;
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<FailoverClusterDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FailoverClusterDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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