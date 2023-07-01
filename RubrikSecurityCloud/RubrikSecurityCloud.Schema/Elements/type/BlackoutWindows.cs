// BlackoutWindows.cs
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
    #region BlackoutWindows
    public class BlackoutWindows: BaseType
    {
        #region members

        //      C# -> List<BlackoutWindow>? GlobalBlackoutWindows
        // GraphQL -> globalBlackoutWindows: [BlackoutWindow!]! (type)
        [JsonProperty("globalBlackoutWindows")]
        public List<BlackoutWindow>? GlobalBlackoutWindows { get; set; }

        //      C# -> List<BlackoutWindow>? SnappableBlackoutWindows
        // GraphQL -> snappableBlackoutWindows: [BlackoutWindow!]! (type)
        [JsonProperty("snappableBlackoutWindows")]
        public List<BlackoutWindow>? SnappableBlackoutWindows { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BlackoutWindows";
    }

    public BlackoutWindows Set(
        List<BlackoutWindow>? GlobalBlackoutWindows = null,
        List<BlackoutWindow>? SnappableBlackoutWindows = null
    ) 
    {
        if ( GlobalBlackoutWindows != null ) {
            this.GlobalBlackoutWindows = GlobalBlackoutWindows;
        }
        if ( SnappableBlackoutWindows != null ) {
            this.SnappableBlackoutWindows = SnappableBlackoutWindows;
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
        //      C# -> List<BlackoutWindow>? GlobalBlackoutWindows
        // GraphQL -> globalBlackoutWindows: [BlackoutWindow!]! (type)
        if (this.GlobalBlackoutWindows != null) {
            var fspec = this.GlobalBlackoutWindows.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "globalBlackoutWindows {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<BlackoutWindow>? SnappableBlackoutWindows
        // GraphQL -> snappableBlackoutWindows: [BlackoutWindow!]! (type)
        if (this.SnappableBlackoutWindows != null) {
            var fspec = this.SnappableBlackoutWindows.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snappableBlackoutWindows {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<BlackoutWindow>? GlobalBlackoutWindows
        // GraphQL -> globalBlackoutWindows: [BlackoutWindow!]! (type)
        if (this.GlobalBlackoutWindows == null && Exploration.Includes(parent + ".globalBlackoutWindows"))
        {
            this.GlobalBlackoutWindows = new List<BlackoutWindow>();
            this.GlobalBlackoutWindows.ApplyExploratoryFieldSpec(parent + ".globalBlackoutWindows");
        }
        //      C# -> List<BlackoutWindow>? SnappableBlackoutWindows
        // GraphQL -> snappableBlackoutWindows: [BlackoutWindow!]! (type)
        if (this.SnappableBlackoutWindows == null && Exploration.Includes(parent + ".snappableBlackoutWindows"))
        {
            this.SnappableBlackoutWindows = new List<BlackoutWindow>();
            this.SnappableBlackoutWindows.ApplyExploratoryFieldSpec(parent + ".snappableBlackoutWindows");
        }
    }


    #endregion

    } // class BlackoutWindows
    
    #endregion

    public static class ListBlackoutWindowsExtensions
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
            this List<BlackoutWindows> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BlackoutWindows> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new BlackoutWindows());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types