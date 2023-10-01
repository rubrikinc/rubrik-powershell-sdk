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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<BlackoutWindow>? GlobalBlackoutWindows
        // GraphQL -> globalBlackoutWindows: [BlackoutWindow!]! (type)
        if (this.GlobalBlackoutWindows != null) {
            var fspec = this.GlobalBlackoutWindows.AsFieldSpec(conf.Child("globalBlackoutWindows"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "globalBlackoutWindows {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<BlackoutWindow>? SnappableBlackoutWindows
        // GraphQL -> snappableBlackoutWindows: [BlackoutWindow!]! (type)
        if (this.SnappableBlackoutWindows != null) {
            var fspec = this.SnappableBlackoutWindows.AsFieldSpec(conf.Child("snappableBlackoutWindows"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snappableBlackoutWindows {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<BlackoutWindow>? GlobalBlackoutWindows
        // GraphQL -> globalBlackoutWindows: [BlackoutWindow!]! (type)
        if (ec.Includes("globalBlackoutWindows",false))
        {
            if(this.GlobalBlackoutWindows == null) {

                this.GlobalBlackoutWindows = new List<BlackoutWindow>();
                this.GlobalBlackoutWindows.ApplyExploratoryFieldSpec(ec.NewChild("globalBlackoutWindows"));

            } else {

                this.GlobalBlackoutWindows.ApplyExploratoryFieldSpec(ec.NewChild("globalBlackoutWindows"));

            }
        }
        else if (this.GlobalBlackoutWindows != null && ec.Excludes("globalBlackoutWindows",false))
        {
            this.GlobalBlackoutWindows = null;
        }
        //      C# -> List<BlackoutWindow>? SnappableBlackoutWindows
        // GraphQL -> snappableBlackoutWindows: [BlackoutWindow!]! (type)
        if (ec.Includes("snappableBlackoutWindows",false))
        {
            if(this.SnappableBlackoutWindows == null) {

                this.SnappableBlackoutWindows = new List<BlackoutWindow>();
                this.SnappableBlackoutWindows.ApplyExploratoryFieldSpec(ec.NewChild("snappableBlackoutWindows"));

            } else {

                this.SnappableBlackoutWindows.ApplyExploratoryFieldSpec(ec.NewChild("snappableBlackoutWindows"));

            }
        }
        else if (this.SnappableBlackoutWindows != null && ec.Excludes("snappableBlackoutWindows",false))
        {
            this.SnappableBlackoutWindows = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<BlackoutWindows> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BlackoutWindows> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BlackoutWindows());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BlackoutWindows> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types