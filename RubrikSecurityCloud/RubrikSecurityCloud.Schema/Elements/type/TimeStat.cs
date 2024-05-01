// TimeStat.cs
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
    #region TimeStat
    public class TimeStat: BaseType
    {
        #region members

        //      C# -> System.Int64? Stat
        // GraphQL -> stat: Long! (scalar)
        [JsonProperty("stat")]
        public System.Int64? Stat { get; set; }

        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime (scalar)
        [JsonProperty("time")]
        public DateTime? Time { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TimeStat";
    }

    public TimeStat Set(
        System.Int64? Stat = null,
        DateTime? Time = null
    ) 
    {
        if ( Stat != null ) {
            this.Stat = Stat;
        }
        if ( Time != null ) {
            this.Time = Time;
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
        //      C# -> System.Int64? Stat
        // GraphQL -> stat: Long! (scalar)
        if (this.Stat != null) {
            if (conf.Flat) {
                s += conf.Prefix + "stat\n" ;
            } else {
                s += ind + "stat\n" ;
            }
        }
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime (scalar)
        if (this.Time != null) {
            if (conf.Flat) {
                s += conf.Prefix + "time\n" ;
            } else {
                s += ind + "time\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? Stat
        // GraphQL -> stat: Long! (scalar)
        if (ec.Includes("stat",true))
        {
            if(this.Stat == null) {

                this.Stat = new System.Int64();

            } else {


            }
        }
        else if (this.Stat != null && ec.Excludes("stat",true))
        {
            this.Stat = null;
        }
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime (scalar)
        if (ec.Includes("time",true))
        {
            if(this.Time == null) {

                this.Time = new DateTime();

            } else {


            }
        }
        else if (this.Time != null && ec.Excludes("time",true))
        {
            this.Time = null;
        }
    }


    #endregion

    } // class TimeStat
    
    #endregion

    public static class ListTimeStatExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<TimeStat> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TimeStat> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TimeStat> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TimeStat());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TimeStat> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types