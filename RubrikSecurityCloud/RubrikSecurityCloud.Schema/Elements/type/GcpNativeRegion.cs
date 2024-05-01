// GcpNativeRegion.cs
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
    #region GcpNativeRegion
    public class GcpNativeRegion: BaseType
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<System.String>? Zones
        // GraphQL -> zones: [String!]! (scalar)
        [JsonProperty("zones")]
        public List<System.String>? Zones { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpNativeRegion";
    }

    public GcpNativeRegion Set(
        System.String? Name = null,
        List<System.String>? Zones = null
    ) 
    {
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Zones != null ) {
            this.Zones = Zones;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> List<System.String>? Zones
        // GraphQL -> zones: [String!]! (scalar)
        if (this.Zones != null) {
            if (conf.Flat) {
                s += conf.Prefix + "zones\n" ;
            } else {
                s += ind + "zones\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> List<System.String>? Zones
        // GraphQL -> zones: [String!]! (scalar)
        if (ec.Includes("zones",true))
        {
            if(this.Zones == null) {

                this.Zones = new List<System.String>();

            } else {


            }
        }
        else if (this.Zones != null && ec.Excludes("zones",true))
        {
            this.Zones = null;
        }
    }


    #endregion

    } // class GcpNativeRegion
    
    #endregion

    public static class ListGcpNativeRegionExtensions
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
            this List<GcpNativeRegion> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GcpNativeRegion> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GcpNativeRegion> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpNativeRegion());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GcpNativeRegion> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types