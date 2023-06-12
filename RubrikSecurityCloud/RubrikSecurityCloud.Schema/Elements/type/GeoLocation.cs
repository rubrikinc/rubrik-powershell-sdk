// GeoLocation.cs
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
    #region GeoLocation
    public class GeoLocation: BaseType
    {
        #region members

        //      C# -> System.String? Address
        // GraphQL -> address: String! (scalar)
        [JsonProperty("address")]
        public System.String? Address { get; set; }

        //      C# -> System.Single? Latitude
        // GraphQL -> latitude: Float! (scalar)
        [JsonProperty("latitude")]
        public System.Single? Latitude { get; set; }

        //      C# -> System.Single? Longitude
        // GraphQL -> longitude: Float! (scalar)
        [JsonProperty("longitude")]
        public System.Single? Longitude { get; set; }


        #endregion

    #region methods

    public GeoLocation Set(
        System.String? Address = null,
        System.Single? Latitude = null,
        System.Single? Longitude = null
    ) 
    {
        if ( Address != null ) {
            this.Address = Address;
        }
        if ( Latitude != null ) {
            this.Latitude = Latitude;
        }
        if ( Longitude != null ) {
            this.Longitude = Longitude;
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
        //      C# -> System.String? Address
        // GraphQL -> address: String! (scalar)
        if (this.Address != null) {
            s += ind + "address\n" ;
        }
        //      C# -> System.Single? Latitude
        // GraphQL -> latitude: Float! (scalar)
        if (this.Latitude != null) {
            s += ind + "latitude\n" ;
        }
        //      C# -> System.Single? Longitude
        // GraphQL -> longitude: Float! (scalar)
        if (this.Longitude != null) {
            s += ind + "longitude\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Address
        // GraphQL -> address: String! (scalar)
        if (this.Address == null && Exploration.Includes(parent + ".address", true))
        {
            this.Address = "FETCH";
        }
        //      C# -> System.Single? Latitude
        // GraphQL -> latitude: Float! (scalar)
        if (this.Latitude == null && Exploration.Includes(parent + ".latitude", true))
        {
            this.Latitude = new System.Single();
        }
        //      C# -> System.Single? Longitude
        // GraphQL -> longitude: Float! (scalar)
        if (this.Longitude == null && Exploration.Includes(parent + ".longitude", true))
        {
            this.Longitude = new System.Single();
        }
    }


    #endregion

    } // class GeoLocation
    
    #endregion

    public static class ListGeoLocationExtensions
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
            this List<GeoLocation> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GeoLocation> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GeoLocation());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types