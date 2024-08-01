// SonarChartParams.cs
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
    #region SonarChartParams
    public class SonarChartParams: BaseType
    {
        #region members

        //      C# -> System.String? Label
        // GraphQL -> label: String! (scalar)
        [JsonProperty("label")]
        public System.String? Label { get; set; }

        //      C# -> List<SonarChartDataPoint>? DataPoints
        // GraphQL -> dataPoints: [SonarChartDataPoint!]! (type)
        [JsonProperty("dataPoints")]
        public List<SonarChartDataPoint>? DataPoints { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SonarChartParams";
    }

    public SonarChartParams Set(
        System.String? Label = null,
        List<SonarChartDataPoint>? DataPoints = null
    ) 
    {
        if ( Label != null ) {
            this.Label = Label;
        }
        if ( DataPoints != null ) {
            this.DataPoints = DataPoints;
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
        //      C# -> System.String? Label
        // GraphQL -> label: String! (scalar)
        if (this.Label != null) {
            if (conf.Flat) {
                s += conf.Prefix + "label\n" ;
            } else {
                s += ind + "label\n" ;
            }
        }
        //      C# -> List<SonarChartDataPoint>? DataPoints
        // GraphQL -> dataPoints: [SonarChartDataPoint!]! (type)
        if (this.DataPoints != null) {
            var fspec = this.DataPoints.AsFieldSpec(conf.Child("dataPoints"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dataPoints" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Label
        // GraphQL -> label: String! (scalar)
        if (ec.Includes("label",true))
        {
            if(this.Label == null) {

                this.Label = "FETCH";

            } else {


            }
        }
        else if (this.Label != null && ec.Excludes("label",true))
        {
            this.Label = null;
        }
        //      C# -> List<SonarChartDataPoint>? DataPoints
        // GraphQL -> dataPoints: [SonarChartDataPoint!]! (type)
        if (ec.Includes("dataPoints",false))
        {
            if(this.DataPoints == null) {

                this.DataPoints = new List<SonarChartDataPoint>();
                this.DataPoints.ApplyExploratoryFieldSpec(ec.NewChild("dataPoints"));

            } else {

                this.DataPoints.ApplyExploratoryFieldSpec(ec.NewChild("dataPoints"));

            }
        }
        else if (this.DataPoints != null && ec.Excludes("dataPoints",false))
        {
            this.DataPoints = null;
        }
    }


    #endregion

    } // class SonarChartParams
    
    #endregion

    public static class ListSonarChartParamsExtensions
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
            this List<SonarChartParams> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SonarChartParams> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SonarChartParams> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SonarChartParams());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SonarChartParams> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types