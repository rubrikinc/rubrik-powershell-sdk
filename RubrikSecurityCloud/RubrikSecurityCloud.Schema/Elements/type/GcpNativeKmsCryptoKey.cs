// GcpNativeKmsCryptoKey.cs
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
    #region GcpNativeKmsCryptoKey
    public class GcpNativeKmsCryptoKey: BaseType
    {
        #region members

        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        [JsonProperty("key")]
        public System.String? Key { get; set; }

        //      C# -> System.String? KeyRing
        // GraphQL -> keyRing: String! (scalar)
        [JsonProperty("keyRing")]
        public System.String? KeyRing { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.String? ProjectNativeId
        // GraphQL -> projectNativeId: String! (scalar)
        [JsonProperty("projectNativeId")]
        public System.String? ProjectNativeId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpNativeKmsCryptoKey";
    }

    public GcpNativeKmsCryptoKey Set(
        System.String? Key = null,
        System.String? KeyRing = null,
        System.String? Location = null,
        System.String? ProjectNativeId = null
    ) 
    {
        if ( Key != null ) {
            this.Key = Key;
        }
        if ( KeyRing != null ) {
            this.KeyRing = KeyRing;
        }
        if ( Location != null ) {
            this.Location = Location;
        }
        if ( ProjectNativeId != null ) {
            this.ProjectNativeId = ProjectNativeId;
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
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (this.Key != null) {
            s += ind + "key\n" ;
        }
        //      C# -> System.String? KeyRing
        // GraphQL -> keyRing: String! (scalar)
        if (this.KeyRing != null) {
            s += ind + "keyRing\n" ;
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location != null) {
            s += ind + "location\n" ;
        }
        //      C# -> System.String? ProjectNativeId
        // GraphQL -> projectNativeId: String! (scalar)
        if (this.ProjectNativeId != null) {
            s += ind + "projectNativeId\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (this.Key == null && ec.Includes("key",true))
        {
            this.Key = "FETCH";
        }
        //      C# -> System.String? KeyRing
        // GraphQL -> keyRing: String! (scalar)
        if (this.KeyRing == null && ec.Includes("keyRing",true))
        {
            this.KeyRing = "FETCH";
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location == null && ec.Includes("location",true))
        {
            this.Location = "FETCH";
        }
        //      C# -> System.String? ProjectNativeId
        // GraphQL -> projectNativeId: String! (scalar)
        if (this.ProjectNativeId == null && ec.Includes("projectNativeId",true))
        {
            this.ProjectNativeId = "FETCH";
        }
    }


    #endregion

    } // class GcpNativeKmsCryptoKey
    
    #endregion

    public static class ListGcpNativeKmsCryptoKeyExtensions
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
            this List<GcpNativeKmsCryptoKey> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GcpNativeKmsCryptoKey> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpNativeKmsCryptoKey());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GcpNativeKmsCryptoKey> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types