// ElasticStorageConfig.cs
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
    #region ElasticStorageConfig
    public class ElasticStorageConfig: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsImmutable
        // GraphQL -> isImmutable: Boolean! (scalar)
        [JsonProperty("isImmutable")]
        public System.Boolean? IsImmutable { get; set; }

        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        [JsonProperty("locationId")]
        public System.String? LocationId { get; set; }

        //      C# -> System.String? LocationName
        // GraphQL -> locationName: String! (scalar)
        [JsonProperty("locationName")]
        public System.String? LocationName { get; set; }


        #endregion

    #region methods

    public ElasticStorageConfig Set(
        System.Boolean? IsImmutable = null,
        System.String? LocationId = null,
        System.String? LocationName = null
    ) 
    {
        if ( IsImmutable != null ) {
            this.IsImmutable = IsImmutable;
        }
        if ( LocationId != null ) {
            this.LocationId = LocationId;
        }
        if ( LocationName != null ) {
            this.LocationName = LocationName;
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
        //      C# -> System.Boolean? IsImmutable
        // GraphQL -> isImmutable: Boolean! (scalar)
        if (this.IsImmutable != null) {
            s += ind + "isImmutable\n" ;
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (this.LocationId != null) {
            s += ind + "locationId\n" ;
        }
        //      C# -> System.String? LocationName
        // GraphQL -> locationName: String! (scalar)
        if (this.LocationName != null) {
            s += ind + "locationName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsImmutable
        // GraphQL -> isImmutable: Boolean! (scalar)
        if (this.IsImmutable == null && Exploration.Includes(parent + ".isImmutable", true))
        {
            this.IsImmutable = true;
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (this.LocationId == null && Exploration.Includes(parent + ".locationId", true))
        {
            this.LocationId = "FETCH";
        }
        //      C# -> System.String? LocationName
        // GraphQL -> locationName: String! (scalar)
        if (this.LocationName == null && Exploration.Includes(parent + ".locationName", true))
        {
            this.LocationName = "FETCH";
        }
    }


    #endregion

    } // class ElasticStorageConfig
    
    #endregion

    public static class ListElasticStorageConfigExtensions
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
            this List<ElasticStorageConfig> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ElasticStorageConfig> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ElasticStorageConfig());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types