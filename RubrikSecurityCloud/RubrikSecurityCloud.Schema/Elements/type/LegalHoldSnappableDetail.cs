// LegalHoldSnappableDetail.cs
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
    #region LegalHoldSnappableDetail
    public class LegalHoldSnappableDetail: BaseType
    {
        #region members

        //      C# -> ManagedObjectType? SnappableType
        // GraphQL -> snappableType: ManagedObjectType! (enum)
        [JsonProperty("snappableType")]
        public ManagedObjectType? SnappableType { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int! (scalar)
        [JsonProperty("snapshotCount")]
        public System.Int32? SnapshotCount { get; set; }

        //      C# -> List<LocationPathPoint>? PhysicalLocation
        // GraphQL -> physicalLocation: [LocationPathPoint!]! (type)
        [JsonProperty("physicalLocation")]
        public List<LocationPathPoint>? PhysicalLocation { get; set; }

        //      C# -> List<LegalHoldSnapshotDetail>? SnapshotDetails
        // GraphQL -> snapshotDetails: [LegalHoldSnapshotDetail!]! (type)
        [JsonProperty("snapshotDetails")]
        public List<LegalHoldSnapshotDetail>? SnapshotDetails { get; set; }


        #endregion

    #region methods

    public LegalHoldSnappableDetail Set(
        ManagedObjectType? SnappableType = null,
        System.String? Id = null,
        System.String? Name = null,
        System.Int32? SnapshotCount = null,
        List<LocationPathPoint>? PhysicalLocation = null,
        List<LegalHoldSnapshotDetail>? SnapshotDetails = null
    ) 
    {
        if ( SnappableType != null ) {
            this.SnappableType = SnappableType;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( SnapshotCount != null ) {
            this.SnapshotCount = SnapshotCount;
        }
        if ( PhysicalLocation != null ) {
            this.PhysicalLocation = PhysicalLocation;
        }
        if ( SnapshotDetails != null ) {
            this.SnapshotDetails = SnapshotDetails;
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
        //      C# -> ManagedObjectType? SnappableType
        // GraphQL -> snappableType: ManagedObjectType! (enum)
        if (this.SnappableType != null) {
            s += ind + "snappableType\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int! (scalar)
        if (this.SnapshotCount != null) {
            s += ind + "snapshotCount\n" ;
        }
        //      C# -> List<LocationPathPoint>? PhysicalLocation
        // GraphQL -> physicalLocation: [LocationPathPoint!]! (type)
        if (this.PhysicalLocation != null) {
            s += ind + "physicalLocation {\n" + this.PhysicalLocation.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<LegalHoldSnapshotDetail>? SnapshotDetails
        // GraphQL -> snapshotDetails: [LegalHoldSnapshotDetail!]! (type)
        if (this.SnapshotDetails != null) {
            s += ind + "snapshotDetails {\n" + this.SnapshotDetails.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ManagedObjectType? SnappableType
        // GraphQL -> snappableType: ManagedObjectType! (enum)
        if (this.SnappableType == null && Exploration.Includes(parent + ".snappableType", true))
        {
            this.SnappableType = new ManagedObjectType();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int! (scalar)
        if (this.SnapshotCount == null && Exploration.Includes(parent + ".snapshotCount", true))
        {
            this.SnapshotCount = Int32.MinValue;
        }
        //      C# -> List<LocationPathPoint>? PhysicalLocation
        // GraphQL -> physicalLocation: [LocationPathPoint!]! (type)
        if (this.PhysicalLocation == null && Exploration.Includes(parent + ".physicalLocation"))
        {
            this.PhysicalLocation = new List<LocationPathPoint>();
            this.PhysicalLocation.ApplyExploratoryFieldSpec(parent + ".physicalLocation");
        }
        //      C# -> List<LegalHoldSnapshotDetail>? SnapshotDetails
        // GraphQL -> snapshotDetails: [LegalHoldSnapshotDetail!]! (type)
        if (this.SnapshotDetails == null && Exploration.Includes(parent + ".snapshotDetails"))
        {
            this.SnapshotDetails = new List<LegalHoldSnapshotDetail>();
            this.SnapshotDetails.ApplyExploratoryFieldSpec(parent + ".snapshotDetails");
        }
    }


    #endregion

    } // class LegalHoldSnappableDetail
    
    #endregion

    public static class ListLegalHoldSnappableDetailExtensions
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
            this List<LegalHoldSnappableDetail> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<LegalHoldSnappableDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new LegalHoldSnappableDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types