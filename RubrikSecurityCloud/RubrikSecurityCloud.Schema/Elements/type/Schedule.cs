// Schedule.cs
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
    #region Schedule
    public class Schedule: BaseType
    {
        #region members

        //      C# -> ScheduleInfo? Info
        // GraphQL -> info: ScheduleInfo (type)
        [JsonProperty("info")]
        public ScheduleInfo? Info { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Schedule";
    }

    public Schedule Set(
        ScheduleInfo? Info = null
    ) 
    {
        if ( Info != null ) {
            this.Info = Info;
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
        //      C# -> ScheduleInfo? Info
        // GraphQL -> info: ScheduleInfo (type)
        if (this.Info != null) {
            var fspec = this.Info.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "info {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ScheduleInfo? Info
        // GraphQL -> info: ScheduleInfo (type)
        if (this.Info == null && Exploration.Includes(parent + ".info"))
        {
            this.Info = new ScheduleInfo();
            this.Info.ApplyExploratoryFieldSpec(parent + ".info");
        }
    }


    #endregion

    } // class Schedule
    
    #endregion

    public static class ListScheduleExtensions
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
            this List<Schedule> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Schedule> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Schedule());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types