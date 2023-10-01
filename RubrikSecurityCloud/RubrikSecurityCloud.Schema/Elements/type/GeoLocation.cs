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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "GeoLocation";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? Address
        // GraphQL -> address: String! (scalar)
        if (this.Address != null) {
            if (conf.Flat) {
                s += conf.Prefix + "address\n" ;
            } else {
                s += ind + "address\n" ;
            }
        }
        //      C# -> System.Single? Latitude
        // GraphQL -> latitude: Float! (scalar)
        if (this.Latitude != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latitude\n" ;
            } else {
                s += ind + "latitude\n" ;
            }
        }
        //      C# -> System.Single? Longitude
        // GraphQL -> longitude: Float! (scalar)
        if (this.Longitude != null) {
            if (conf.Flat) {
                s += conf.Prefix + "longitude\n" ;
            } else {
                s += ind + "longitude\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Address
        // GraphQL -> address: String! (scalar)
        if (ec.Includes("address",true))
        {
            if(this.Address == null) {

                this.Address = "FETCH";

            } else {


            }
        }
        else if (this.Address != null && ec.Excludes("address",true))
        {
            this.Address = null;
        }
        //      C# -> System.Single? Latitude
        // GraphQL -> latitude: Float! (scalar)
        if (ec.Includes("latitude",true))
        {
            if(this.Latitude == null) {

                this.Latitude = new System.Single();

            } else {


            }
        }
        else if (this.Latitude != null && ec.Excludes("latitude",true))
        {
            this.Latitude = null;
        }
        //      C# -> System.Single? Longitude
        // GraphQL -> longitude: Float! (scalar)
        if (ec.Includes("longitude",true))
        {
            if(this.Longitude == null) {

                this.Longitude = new System.Single();

            } else {


            }
        }
        else if (this.Longitude != null && ec.Excludes("longitude",true))
        {
            this.Longitude = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<GeoLocation> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GeoLocation> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GeoLocation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GeoLocation> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types