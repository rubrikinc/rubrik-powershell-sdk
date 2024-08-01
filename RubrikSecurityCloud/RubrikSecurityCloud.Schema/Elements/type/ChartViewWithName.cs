// ChartViewWithName.cs
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
    #region ChartViewWithName
    public class ChartViewWithName: BaseType
    {
        #region members

        //      C# -> ChartViewType? ChartViewType
        // GraphQL -> chartViewType: ChartViewType! (enum)
        [JsonProperty("chartViewType")]
        public ChartViewType? ChartViewType { get; set; }

        //      C# -> System.String? ChartName
        // GraphQL -> chartName: String! (scalar)
        [JsonProperty("chartName")]
        public System.String? ChartName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ChartViewWithName";
    }

    public ChartViewWithName Set(
        ChartViewType? ChartViewType = null,
        System.String? ChartName = null
    ) 
    {
        if ( ChartViewType != null ) {
            this.ChartViewType = ChartViewType;
        }
        if ( ChartName != null ) {
            this.ChartName = ChartName;
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
        //      C# -> ChartViewType? ChartViewType
        // GraphQL -> chartViewType: ChartViewType! (enum)
        if (this.ChartViewType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "chartViewType\n" ;
            } else {
                s += ind + "chartViewType\n" ;
            }
        }
        //      C# -> System.String? ChartName
        // GraphQL -> chartName: String! (scalar)
        if (this.ChartName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "chartName\n" ;
            } else {
                s += ind + "chartName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ChartViewType? ChartViewType
        // GraphQL -> chartViewType: ChartViewType! (enum)
        if (ec.Includes("chartViewType",true))
        {
            if(this.ChartViewType == null) {

                this.ChartViewType = new ChartViewType();

            } else {


            }
        }
        else if (this.ChartViewType != null && ec.Excludes("chartViewType",true))
        {
            this.ChartViewType = null;
        }
        //      C# -> System.String? ChartName
        // GraphQL -> chartName: String! (scalar)
        if (ec.Includes("chartName",true))
        {
            if(this.ChartName == null) {

                this.ChartName = "FETCH";

            } else {


            }
        }
        else if (this.ChartName != null && ec.Excludes("chartName",true))
        {
            this.ChartName = null;
        }
    }


    #endregion

    } // class ChartViewWithName
    
    #endregion

    public static class ListChartViewWithNameExtensions
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
            this List<ChartViewWithName> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ChartViewWithName> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ChartViewWithName> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ChartViewWithName());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ChartViewWithName> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types