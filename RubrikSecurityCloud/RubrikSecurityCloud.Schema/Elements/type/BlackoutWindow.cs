// BlackoutWindow.cs
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
    #region BlackoutWindow
    public class BlackoutWindow: BaseType
    {
        #region members

        //      C# -> System.String? EndTime
        // GraphQL -> endTime: String (scalar)
        [JsonProperty("endTime")]
        public System.String? EndTime { get; set; }

        //      C# -> System.String? StartTime
        // GraphQL -> startTime: String! (scalar)
        [JsonProperty("startTime")]
        public System.String? StartTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BlackoutWindow";
    }

    public BlackoutWindow Set(
        System.String? EndTime = null,
        System.String? StartTime = null
    ) 
    {
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
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
        //      C# -> System.String? EndTime
        // GraphQL -> endTime: String (scalar)
        if (this.EndTime != null) {
            s += ind + "endTime\n" ;
        }
        //      C# -> System.String? StartTime
        // GraphQL -> startTime: String! (scalar)
        if (this.StartTime != null) {
            s += ind + "startTime\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? EndTime
        // GraphQL -> endTime: String (scalar)
        if (this.EndTime == null && Exploration.Includes(parent + ".endTime", true))
        {
            this.EndTime = "FETCH";
        }
        //      C# -> System.String? StartTime
        // GraphQL -> startTime: String! (scalar)
        if (this.StartTime == null && Exploration.Includes(parent + ".startTime", true))
        {
            this.StartTime = "FETCH";
        }
    }


    #endregion

    } // class BlackoutWindow
    
    #endregion

    public static class ListBlackoutWindowExtensions
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
            this List<BlackoutWindow> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BlackoutWindow> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new BlackoutWindow());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types