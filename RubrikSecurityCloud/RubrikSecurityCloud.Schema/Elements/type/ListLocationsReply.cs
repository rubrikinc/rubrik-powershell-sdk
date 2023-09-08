// ListLocationsReply.cs
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
    #region ListLocationsReply
    public class ListLocationsReply: BaseType
    {
        #region members

        //      C# -> List<System.String>? Locations
        // GraphQL -> locations: [String!]! (scalar)
        [JsonProperty("locations")]
        public List<System.String>? Locations { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ListLocationsReply";
    }

    public ListLocationsReply Set(
        List<System.String>? Locations = null
    ) 
    {
        if ( Locations != null ) {
            this.Locations = Locations;
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
        //      C# -> List<System.String>? Locations
        // GraphQL -> locations: [String!]! (scalar)
        if (this.Locations != null) {
            s += ind + "locations\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? Locations
        // GraphQL -> locations: [String!]! (scalar)
        if (this.Locations == null && ec.Includes("locations",true))
        {
            this.Locations = new List<System.String>();
        }
    }


    #endregion

    } // class ListLocationsReply
    
    #endregion

    public static class ListListLocationsReplyExtensions
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
            this List<ListLocationsReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ListLocationsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ListLocationsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ListLocationsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types