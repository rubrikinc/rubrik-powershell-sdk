// StartTimeAttributes.cs
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
    #region StartTimeAttributes
    public class StartTimeAttributes: BaseType
    {
        #region members

        //      C# -> System.Int32? Hour
        // GraphQL -> hour: Int! (scalar)
        [JsonProperty("hour")]
        public System.Int32? Hour { get; set; }

        //      C# -> System.Int32? Minute
        // GraphQL -> minute: Int! (scalar)
        [JsonProperty("minute")]
        public System.Int32? Minute { get; set; }

        //      C# -> DayOfWeekOpt? DayOfWeek
        // GraphQL -> dayOfWeek: DayOfWeekOpt (type)
        [JsonProperty("dayOfWeek")]
        public DayOfWeekOpt? DayOfWeek { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "StartTimeAttributes";
    }

    public StartTimeAttributes Set(
        System.Int32? Hour = null,
        System.Int32? Minute = null,
        DayOfWeekOpt? DayOfWeek = null
    ) 
    {
        if ( Hour != null ) {
            this.Hour = Hour;
        }
        if ( Minute != null ) {
            this.Minute = Minute;
        }
        if ( DayOfWeek != null ) {
            this.DayOfWeek = DayOfWeek;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int32? Hour
        // GraphQL -> hour: Int! (scalar)
        if (this.Hour != null) {
            s += ind + "hour\n" ;
        }
        //      C# -> System.Int32? Minute
        // GraphQL -> minute: Int! (scalar)
        if (this.Minute != null) {
            s += ind + "minute\n" ;
        }
        //      C# -> DayOfWeekOpt? DayOfWeek
        // GraphQL -> dayOfWeek: DayOfWeekOpt (type)
        if (this.DayOfWeek != null) {
            var fspec = this.DayOfWeek.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "dayOfWeek {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? Hour
        // GraphQL -> hour: Int! (scalar)
        if (this.Hour == null && ec.Includes("hour",true))
        {
            this.Hour = Int32.MinValue;
        }
        //      C# -> System.Int32? Minute
        // GraphQL -> minute: Int! (scalar)
        if (this.Minute == null && ec.Includes("minute",true))
        {
            this.Minute = Int32.MinValue;
        }
        //      C# -> DayOfWeekOpt? DayOfWeek
        // GraphQL -> dayOfWeek: DayOfWeekOpt (type)
        if (this.DayOfWeek == null && ec.Includes("dayOfWeek",false))
        {
            this.DayOfWeek = new DayOfWeekOpt();
            this.DayOfWeek.ApplyExploratoryFieldSpec(ec.NewChild("dayOfWeek"));
        }
    }


    #endregion

    } // class StartTimeAttributes
    
    #endregion

    public static class ListStartTimeAttributesExtensions
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
            this List<StartTimeAttributes> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<StartTimeAttributes> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new StartTimeAttributes());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<StartTimeAttributes> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types