// SnappableGroupBy.cs
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
    #region SnappableGroupBy
    public class SnappableGroupBy: BaseType
    {
        #region members

        //      C# -> SnappableConnection? SnappableConnection
        // GraphQL -> snappableConnection: SnappableConnection! (type)
        [JsonProperty("snappableConnection")]
        public SnappableConnection? SnappableConnection { get; set; }

        //      C# -> List<SnappableGroupBy>? SnappableGroupByField
        // GraphQL -> snappableGroupBy: [SnappableGroupBy!]! (type)
        [JsonProperty("snappableGroupBy")]
        public List<SnappableGroupBy>? SnappableGroupByField { get; set; }

        //      C# -> SnappableGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: SnappableGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public SnappableGroupByInfo? GroupByInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SnappableGroupBy";
    }

    public SnappableGroupBy Set(
        SnappableConnection? SnappableConnection = null,
        List<SnappableGroupBy>? SnappableGroupByField = null,
        SnappableGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( SnappableConnection != null ) {
            this.SnappableConnection = SnappableConnection;
        }
        if ( SnappableGroupByField != null ) {
            this.SnappableGroupByField = SnappableGroupByField;
        }
        if ( GroupByInfo != null ) {
            this.GroupByInfo = GroupByInfo;
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
        //      C# -> SnappableConnection? SnappableConnection
        // GraphQL -> snappableConnection: SnappableConnection! (type)
        if (this.SnappableConnection != null) {
            var fspec = this.SnappableConnection.AsFieldSpec(conf.Child("snappableConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snappableConnection {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<SnappableGroupBy>? SnappableGroupByField
        // GraphQL -> snappableGroupBy: [SnappableGroupBy!]! (type)
        if (this.SnappableGroupByField != null) {
            var fspec = this.SnappableGroupByField.AsFieldSpec(conf.Child("snappableGroupBy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snappableGroupBy {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SnappableGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: SnappableGroupByInfo! (union)
        if (this.GroupByInfo != null) {
            var fspec = this.GroupByInfo.AsFieldSpec(conf.Child("groupByInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "groupByInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SnappableConnection? SnappableConnection
        // GraphQL -> snappableConnection: SnappableConnection! (type)
        if (ec.Includes("snappableConnection",false))
        {
            if(this.SnappableConnection == null) {

                this.SnappableConnection = new SnappableConnection();
                this.SnappableConnection.ApplyExploratoryFieldSpec(ec.NewChild("snappableConnection"));

            } else {

                this.SnappableConnection.ApplyExploratoryFieldSpec(ec.NewChild("snappableConnection"));

            }
        }
        else if (this.SnappableConnection != null && ec.Excludes("snappableConnection",false))
        {
            this.SnappableConnection = null;
        }
        //      C# -> List<SnappableGroupBy>? SnappableGroupByField
        // GraphQL -> snappableGroupBy: [SnappableGroupBy!]! (type)
        if (ec.Includes("snappableGroupBy",false))
        {
            if(this.SnappableGroupByField == null) {

                this.SnappableGroupByField = new List<SnappableGroupBy>();
                this.SnappableGroupByField.ApplyExploratoryFieldSpec(ec.NewChild("snappableGroupBy"));

            } else {

                this.SnappableGroupByField.ApplyExploratoryFieldSpec(ec.NewChild("snappableGroupBy"));

            }
        }
        else if (this.SnappableGroupByField != null && ec.Excludes("snappableGroupBy",false))
        {
            this.SnappableGroupByField = null;
        }
        //      C# -> SnappableGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: SnappableGroupByInfo! (union)
        if (ec.Includes("groupByInfo",false))
        {
            if(this.GroupByInfo == null) {

                var impls = new List<SnappableGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (SnappableGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<SnappableGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (SnappableGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.GroupByInfo != null && ec.Excludes("groupByInfo",false))
        {
            this.GroupByInfo = null;
        }
    }


    #endregion

    } // class SnappableGroupBy
    
    #endregion

    public static class ListSnappableGroupByExtensions
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
            this List<SnappableGroupBy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<SnappableGroupBy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SnappableGroupBy> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SnappableGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SnappableGroupBy> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types