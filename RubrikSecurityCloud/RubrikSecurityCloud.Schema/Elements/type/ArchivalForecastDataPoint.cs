// ArchivalForecastDataPoint.cs
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
    #region ArchivalForecastDataPoint
    public class ArchivalForecastDataPoint: BaseType
    {
        #region members

        //      C# -> System.String? Timestamp
        // GraphQL -> timestamp: String! (scalar)
        [JsonProperty("timestamp")]
        public System.String? Timestamp { get; set; }

        //      C# -> System.Single? Value
        // GraphQL -> value: Float! (scalar)
        [JsonProperty("value")]
        public System.Single? Value { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ArchivalForecastDataPoint";
    }

    public ArchivalForecastDataPoint Set(
        System.String? Timestamp = null,
        System.Single? Value = null
    ) 
    {
        if ( Timestamp != null ) {
            this.Timestamp = Timestamp;
        }
        if ( Value != null ) {
            this.Value = Value;
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
        //      C# -> System.String? Timestamp
        // GraphQL -> timestamp: String! (scalar)
        if (this.Timestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "timestamp\n" ;
            } else {
                s += ind + "timestamp\n" ;
            }
        }
        //      C# -> System.Single? Value
        // GraphQL -> value: Float! (scalar)
        if (this.Value != null) {
            if (conf.Flat) {
                s += conf.Prefix + "value\n" ;
            } else {
                s += ind + "value\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Timestamp
        // GraphQL -> timestamp: String! (scalar)
        if (ec.Includes("timestamp",true))
        {
            if(this.Timestamp == null) {

                this.Timestamp = "FETCH";

            } else {


            }
        }
        else if (this.Timestamp != null && ec.Excludes("timestamp",true))
        {
            this.Timestamp = null;
        }
        //      C# -> System.Single? Value
        // GraphQL -> value: Float! (scalar)
        if (ec.Includes("value",true))
        {
            if(this.Value == null) {

                this.Value = new System.Single();

            } else {


            }
        }
        else if (this.Value != null && ec.Excludes("value",true))
        {
            this.Value = null;
        }
    }


    #endregion

    } // class ArchivalForecastDataPoint
    
    #endregion

    public static class ListArchivalForecastDataPointExtensions
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
            this List<ArchivalForecastDataPoint> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ArchivalForecastDataPoint> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ArchivalForecastDataPoint> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchivalForecastDataPoint());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ArchivalForecastDataPoint> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types