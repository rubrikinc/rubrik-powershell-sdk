// PerLocationCloudStorageTier.cs
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
    #region PerLocationCloudStorageTier
    public class PerLocationCloudStorageTier: BaseType
    {
        #region members

        //      C# -> SnapshotCloudStorageTier? CloudStorageTier
        // GraphQL -> cloudStorageTier: SnapshotCloudStorageTier! (enum)
        [JsonProperty("cloudStorageTier")]
        public SnapshotCloudStorageTier? CloudStorageTier { get; set; }

        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        [JsonProperty("locationId")]
        public System.String? LocationId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PerLocationCloudStorageTier";
    }

    public PerLocationCloudStorageTier Set(
        SnapshotCloudStorageTier? CloudStorageTier = null,
        System.String? LocationId = null
    ) 
    {
        if ( CloudStorageTier != null ) {
            this.CloudStorageTier = CloudStorageTier;
        }
        if ( LocationId != null ) {
            this.LocationId = LocationId;
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
        //      C# -> SnapshotCloudStorageTier? CloudStorageTier
        // GraphQL -> cloudStorageTier: SnapshotCloudStorageTier! (enum)
        if (this.CloudStorageTier != null) {
            s += ind + "cloudStorageTier\n" ;
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (this.LocationId != null) {
            s += ind + "locationId\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SnapshotCloudStorageTier? CloudStorageTier
        // GraphQL -> cloudStorageTier: SnapshotCloudStorageTier! (enum)
        if (this.CloudStorageTier == null && ec.Includes("cloudStorageTier",true))
        {
            this.CloudStorageTier = new SnapshotCloudStorageTier();
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (this.LocationId == null && ec.Includes("locationId",true))
        {
            this.LocationId = "FETCH";
        }
    }


    #endregion

    } // class PerLocationCloudStorageTier
    
    #endregion

    public static class ListPerLocationCloudStorageTierExtensions
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
            this List<PerLocationCloudStorageTier> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PerLocationCloudStorageTier> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PerLocationCloudStorageTier());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<PerLocationCloudStorageTier> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types