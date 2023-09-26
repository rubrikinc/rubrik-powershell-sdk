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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "ListStoredDiskLocationsReply";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<System.String>? Regions
        // GraphQL -> regions: [String!]! (scalar)
        if (this.Regions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "regions\n" ;
            } else {
                s += ind + "regions\n" ;
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
        //      C# -> List<System.String>? Regions
        // GraphQL -> regions: [String!]! (scalar)
        if (ec.Includes("regions",true))
        {
            if(this.Regions == null) {

                this.Regions = new List<System.String>();

            } else {


            }
        }
        else if (this.Regions != null && ec.Excludes("regions",true))
        {
            this.Regions = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ListStoredDiskLocationsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ListStoredDiskLocationsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ListStoredDiskLocationsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types