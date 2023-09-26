// AnomalyResultGroupedData.cs
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
    #region AnomalyResultGroupedData
    public class AnomalyResultGroupedData: BaseType
    {
        #region members

        //      C# -> List<AnomalyResultGroupedData>? AnomalyResultGroupedDataField
        // GraphQL -> anomalyResultGroupedData: [AnomalyResultGroupedData!]! (type)
        [JsonProperty("anomalyResultGroupedData")]
        public List<AnomalyResultGroupedData>? AnomalyResultGroupedDataField { get; set; }

        //      C# -> AnomalyResultConnection? AnomalyResults
        // GraphQL -> anomalyResults: AnomalyResultConnection! (type)
        [JsonProperty("anomalyResults")]
        public AnomalyResultConnection? AnomalyResults { get; set; }

        //      C# -> AnomalyResultGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: AnomalyResultGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public AnomalyResultGroupByInfo? GroupByInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AnomalyResultGroupedData";
    }

    public AnomalyResultGroupedData Set(
        List<AnomalyResultGroupedData>? AnomalyResultGroupedDataField = null,
        AnomalyResultConnection? AnomalyResults = null,
        AnomalyResultGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( AnomalyResultGroupedDataField != null ) {
            this.AnomalyResultGroupedDataField = AnomalyResultGroupedDataField;
        }
        if ( AnomalyResults != null ) {
            this.AnomalyResults = AnomalyResults;
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
        //      C# -> List<AnomalyResultGroupedData>? AnomalyResultGroupedDataField
        // GraphQL -> anomalyResultGroupedData: [AnomalyResultGroupedData!]! (type)
        if (this.AnomalyResultGroupedDataField != null) {
            var fspec = this.AnomalyResultGroupedDataField.AsFieldSpec(conf.Child("anomalyResultGroupedData"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "anomalyResultGroupedData {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AnomalyResultConnection? AnomalyResults
        // GraphQL -> anomalyResults: AnomalyResultConnection! (type)
        if (this.AnomalyResults != null) {
            var fspec = this.AnomalyResults.AsFieldSpec(conf.Child("anomalyResults"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "anomalyResults {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AnomalyResultGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: AnomalyResultGroupByInfo! (union)
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
        //      C# -> List<AnomalyResultGroupedData>? AnomalyResultGroupedDataField
        // GraphQL -> anomalyResultGroupedData: [AnomalyResultGroupedData!]! (type)
        if (ec.Includes("anomalyResultGroupedData",false))
        {
            if(this.AnomalyResultGroupedDataField == null) {

                this.AnomalyResultGroupedDataField = new List<AnomalyResultGroupedData>();
                this.AnomalyResultGroupedDataField.ApplyExploratoryFieldSpec(ec.NewChild("anomalyResultGroupedData"));

            } else {

                this.AnomalyResultGroupedDataField.ApplyExploratoryFieldSpec(ec.NewChild("anomalyResultGroupedData"));

            }
        }
        else if (this.AnomalyResultGroupedDataField != null && ec.Excludes("anomalyResultGroupedData",false))
        {
            this.AnomalyResultGroupedDataField = null;
        }
        //      C# -> AnomalyResultConnection? AnomalyResults
        // GraphQL -> anomalyResults: AnomalyResultConnection! (type)
        if (ec.Includes("anomalyResults",false))
        {
            if(this.AnomalyResults == null) {

                this.AnomalyResults = new AnomalyResultConnection();
                this.AnomalyResults.ApplyExploratoryFieldSpec(ec.NewChild("anomalyResults"));

            } else {

                this.AnomalyResults.ApplyExploratoryFieldSpec(ec.NewChild("anomalyResults"));

            }
        }
        else if (this.AnomalyResults != null && ec.Excludes("anomalyResults",false))
        {
            this.AnomalyResults = null;
        }
        //      C# -> AnomalyResultGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: AnomalyResultGroupByInfo! (union)
        if (ec.Includes("groupByInfo",false))
        {
            if(this.GroupByInfo == null) {

                var impls = new List<AnomalyResultGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (AnomalyResultGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<AnomalyResultGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (AnomalyResultGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.GroupByInfo != null && ec.Excludes("groupByInfo",false))
        {
            this.GroupByInfo = null;
        }
    }


    #endregion

    } // class AnomalyResultGroupedData
    
    #endregion

    public static class ListAnomalyResultGroupedDataExtensions
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
            this List<AnomalyResultGroupedData> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AnomalyResultGroupedData> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AnomalyResultGroupedData());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AnomalyResultGroupedData> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types