// ListStoredDiskLocationsReply.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region ListStoredDiskLocationsReply
    public class ListStoredDiskLocationsReply: BaseType
    {
        #region members

        //      C# -> List<System.String>? Regions
        // GraphQL -> regions: [String!]! (scalar)
        [JsonProperty("regions")]
        public List<System.String>? Regions { get; set; }

        //      C# -> List<System.String>? Zones
        // GraphQL -> zones: [String!]! (scalar)
        [JsonProperty("zones")]
        public List<System.String>? Zones { get; set; }


        #endregion

    #region methods

    public ListStoredDiskLocationsReply Set(
        List<System.String>? Regions = null,
        List<System.String>? Zones = null
    ) 
    {
        if ( Regions != null ) {
            this.Regions = Regions;
        }
        if ( Zones != null ) {
            this.Zones = Zones;
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
        //      C# -> List<System.String>? Regions
        // GraphQL -> regions: [String!]! (scalar)
        if (this.Regions != null) {
            s += ind + "regions\n" ;
        }
        //      C# -> List<System.String>? Zones
        // GraphQL -> zones: [String!]! (scalar)
        if (this.Zones != null) {
            s += ind + "zones\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? Regions
        // GraphQL -> regions: [String!]! (scalar)
        if (this.Regions == null && Exploration.Includes(parent + ".regions", true))
        {
            this.Regions = new List<System.String>();
        }
        //      C# -> List<System.String>? Zones
        // GraphQL -> zones: [String!]! (scalar)
        if (this.Zones == null && Exploration.Includes(parent + ".zones", true))
        {
            this.Zones = new List<System.String>();
        }
    }


    #endregion

    } // class ListStoredDiskLocationsReply
    
    #endregion

    public static class ListListStoredDiskLocationsReplyExtensions
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
            this List<ListStoredDiskLocationsReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ListStoredDiskLocationsReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ListStoredDiskLocationsReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types