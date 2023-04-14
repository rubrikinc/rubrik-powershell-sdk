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

namespace Rubrik.SecurityCloud.Types
{
    #region GeoLocation
    public class GeoLocation: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? Address
            // GraphQL -> address: String! (scalar)
            if (this.Address != null)
            {
                 s += ind + "address\n";

            }
            //      C# -> System.Single? Latitude
            // GraphQL -> latitude: Float! (scalar)
            if (this.Latitude != null)
            {
                 s += ind + "latitude\n";

            }
            //      C# -> System.Single? Longitude
            // GraphQL -> longitude: Float! (scalar)
            if (this.Longitude != null)
            {
                 s += ind + "longitude\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Address
            // GraphQL -> address: String! (scalar)
            if (this.Address == null && Exploration.Includes(parent + ".address$"))
            {
                this.Address = new System.String("FETCH");
            }
            //      C# -> System.Single? Latitude
            // GraphQL -> latitude: Float! (scalar)
            if (this.Latitude == null && Exploration.Includes(parent + ".latitude$"))
            {
                this.Latitude = new System.Single();
            }
            //      C# -> System.Single? Longitude
            // GraphQL -> longitude: Float! (scalar)
            if (this.Longitude == null && Exploration.Includes(parent + ".longitude$"))
            {
                this.Longitude = new System.Single();
            }
        }


    #endregion

    } // class GeoLocation
    #endregion

    public static class ListGeoLocationExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<GeoLocation> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GeoLocation> list, 
            String parent = "")
        {
            var item = new GeoLocation();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types