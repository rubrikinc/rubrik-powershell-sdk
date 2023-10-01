// RelativeTimeRange.cs
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
    #region RelativeTimeRange
    public class RelativeTimeRange: BaseType
    {
        #region members

        //      C# -> TimeUnitEnum? Unit
        // GraphQL -> unit: TimeUnitEnum! (enum)
        [JsonProperty("unit")]
        public TimeUnitEnum? Unit { get; set; }

        //      C# -> System.Int32? Magnitude
        // GraphQL -> magnitude: Int! (scalar)
        [JsonProperty("magnitude")]
        public System.Int32? Magnitude { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RelativeTimeRange";
    }

    public RelativeTimeRange Set(
        TimeUnitEnum? Unit = null,
        System.Int32? Magnitude = null
    ) 
    {
        if ( Unit != null ) {
            this.Unit = Unit;
        }
        if ( Magnitude != null ) {
            this.Magnitude = Magnitude;
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
        //      C# -> TimeUnitEnum? Unit
        // GraphQL -> unit: TimeUnitEnum! (enum)
        if (this.Unit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unit\n" ;
            } else {
                s += ind + "unit\n" ;
            }
        }
        //      C# -> System.Int32? Magnitude
        // GraphQL -> magnitude: Int! (scalar)
        if (this.Magnitude != null) {
            if (conf.Flat) {
                s += conf.Prefix + "magnitude\n" ;
            } else {
                s += ind + "magnitude\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> TimeUnitEnum? Unit
        // GraphQL -> unit: TimeUnitEnum! (enum)
        if (ec.Includes("unit",true))
        {
            if(this.Unit == null) {

                this.Unit = new TimeUnitEnum();

            } else {


            }
        }
        else if (this.Unit != null && ec.Excludes("unit",true))
        {
            this.Unit = null;
        }
        //      C# -> System.Int32? Magnitude
        // GraphQL -> magnitude: Int! (scalar)
        if (ec.Includes("magnitude",true))
        {
            if(this.Magnitude == null) {

                this.Magnitude = Int32.MinValue;

            } else {


            }
        }
        else if (this.Magnitude != null && ec.Excludes("magnitude",true))
        {
            this.Magnitude = null;
        }
    }


    #endregion

    } // class RelativeTimeRange
    
    #endregion

    public static class ListRelativeTimeRangeExtensions
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
            this List<RelativeTimeRange> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<RelativeTimeRange> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RelativeTimeRange> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RelativeTimeRange());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RelativeTimeRange> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types