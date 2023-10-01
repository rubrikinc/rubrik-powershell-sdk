// Duration.cs
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
    #region Duration
    public class Duration: BaseType
    {
        #region members

        //      C# -> RetentionUnit? Unit
        // GraphQL -> unit: RetentionUnit! (enum)
        [JsonProperty("unit")]
        public RetentionUnit? Unit { get; set; }

        //      C# -> System.Int32? DurationField
        // GraphQL -> duration: Int! (scalar)
        [JsonProperty("duration")]
        public System.Int32? DurationField { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Duration";
    }

    public Duration Set(
        RetentionUnit? Unit = null,
        System.Int32? DurationField = null
    ) 
    {
        if ( Unit != null ) {
            this.Unit = Unit;
        }
        if ( DurationField != null ) {
            this.DurationField = DurationField;
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
        //      C# -> RetentionUnit? Unit
        // GraphQL -> unit: RetentionUnit! (enum)
        if (this.Unit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unit\n" ;
            } else {
                s += ind + "unit\n" ;
            }
        }
        //      C# -> System.Int32? DurationField
        // GraphQL -> duration: Int! (scalar)
        if (this.DurationField != null) {
            if (conf.Flat) {
                s += conf.Prefix + "duration\n" ;
            } else {
                s += ind + "duration\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RetentionUnit? Unit
        // GraphQL -> unit: RetentionUnit! (enum)
        if (ec.Includes("unit",true))
        {
            if(this.Unit == null) {

                this.Unit = new RetentionUnit();

            } else {


            }
        }
        else if (this.Unit != null && ec.Excludes("unit",true))
        {
            this.Unit = null;
        }
        //      C# -> System.Int32? DurationField
        // GraphQL -> duration: Int! (scalar)
        if (ec.Includes("duration",true))
        {
            if(this.DurationField == null) {

                this.DurationField = Int32.MinValue;

            } else {


            }
        }
        else if (this.DurationField != null && ec.Excludes("duration",true))
        {
            this.DurationField = null;
        }
    }


    #endregion

    } // class Duration
    
    #endregion

    public static class ListDurationExtensions
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
            this List<Duration> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<Duration> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Duration> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Duration());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Duration> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types