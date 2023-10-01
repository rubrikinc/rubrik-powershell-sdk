// DhrcScoreContext.cs
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
    #region DhrcScoreContext
    public class DhrcScoreContext: BaseType
    {
        #region members

        //      C# -> List<DhrcScoreMetric>? Metrics
        // GraphQL -> metrics: [DhrcScoreMetric!]! (type)
        [JsonProperty("metrics")]
        public List<DhrcScoreMetric>? Metrics { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DhrcScoreContext";
    }

    public DhrcScoreContext Set(
        List<DhrcScoreMetric>? Metrics = null
    ) 
    {
        if ( Metrics != null ) {
            this.Metrics = Metrics;
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
        //      C# -> List<DhrcScoreMetric>? Metrics
        // GraphQL -> metrics: [DhrcScoreMetric!]! (type)
        if (this.Metrics != null) {
            var fspec = this.Metrics.AsFieldSpec(conf.Child("metrics"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "metrics {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<DhrcScoreMetric>? Metrics
        // GraphQL -> metrics: [DhrcScoreMetric!]! (type)
        if (ec.Includes("metrics",false))
        {
            if(this.Metrics == null) {

                this.Metrics = new List<DhrcScoreMetric>();
                this.Metrics.ApplyExploratoryFieldSpec(ec.NewChild("metrics"));

            } else {

                this.Metrics.ApplyExploratoryFieldSpec(ec.NewChild("metrics"));

            }
        }
        else if (this.Metrics != null && ec.Excludes("metrics",false))
        {
            this.Metrics = null;
        }
    }


    #endregion

    } // class DhrcScoreContext
    
    #endregion

    public static class ListDhrcScoreContextExtensions
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
            this List<DhrcScoreContext> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<DhrcScoreContext> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DhrcScoreContext> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DhrcScoreContext());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DhrcScoreContext> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types