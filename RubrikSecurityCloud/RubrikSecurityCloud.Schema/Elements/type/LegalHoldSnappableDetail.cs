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

namespace Rubrik.SecurityCloud.Types
{
    #region LegalHoldSnappableDetail
    public class LegalHoldSnappableDetail: IFragment
    {
        #region members
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

        //      C# -> ManagedObjectType? SnappableType
        // GraphQL -> snappableType: ManagedObjectType! (enum)
        [JsonProperty("snappableType")]
        public ManagedObjectType? SnappableType { get; set; }

        #endregion

    #region methods

    public LegalHoldSnappableDetail Set(
        System.String? Id = null,
        System.String? Name = null,
        System.Int32? SnapshotCount = null,
        List<LocationPathPoint>? PhysicalLocation = null,
        List<LegalHoldSnapshotDetail>? SnapshotDetails = null,
        ManagedObjectType? SnappableType = null
    ) 
    {
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
        if ( SnappableType != null ) {
            this.SnappableType = SnappableType;
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
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.Int32? SnapshotCount
            // GraphQL -> snapshotCount: Int! (scalar)
            if (this.SnapshotCount != null)
            {
                 s += ind + "snapshotCount\n";

            }
            //      C# -> List<LocationPathPoint>? PhysicalLocation
            // GraphQL -> physicalLocation: [LocationPathPoint!]! (type)
            if (this.PhysicalLocation != null)
            {
                 s += ind + "physicalLocation\n";

                 s += ind + "{\n" + 
                 this.PhysicalLocation.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<LegalHoldSnapshotDetail>? SnapshotDetails
            // GraphQL -> snapshotDetails: [LegalHoldSnapshotDetail!]! (type)
            if (this.SnapshotDetails != null)
            {
                 s += ind + "snapshotDetails\n";

                 s += ind + "{\n" + 
                 this.SnapshotDetails.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ManagedObjectType? SnappableType
            // GraphQL -> snappableType: ManagedObjectType! (enum)
            if (this.SnappableType != null)
            {
                 s += ind + "snappableType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.Int32? SnapshotCount
            // GraphQL -> snapshotCount: Int! (scalar)
            if (this.SnapshotCount == null && Exploration.Includes(parent + ".snapshotCount$"))
            {
                this.SnapshotCount = new System.Int32();
            }
            //      C# -> List<LocationPathPoint>? PhysicalLocation
            // GraphQL -> physicalLocation: [LocationPathPoint!]! (type)
            if (this.PhysicalLocation == null && Exploration.Includes(parent + ".physicalLocation"))
            {
                this.PhysicalLocation = new List<LocationPathPoint>();
                this.PhysicalLocation.ApplyExploratoryFragment(parent + ".physicalLocation");
            }
            //      C# -> List<LegalHoldSnapshotDetail>? SnapshotDetails
            // GraphQL -> snapshotDetails: [LegalHoldSnapshotDetail!]! (type)
            if (this.SnapshotDetails == null && Exploration.Includes(parent + ".snapshotDetails"))
            {
                this.SnapshotDetails = new List<LegalHoldSnapshotDetail>();
                this.SnapshotDetails.ApplyExploratoryFragment(parent + ".snapshotDetails");
            }
            //      C# -> ManagedObjectType? SnappableType
            // GraphQL -> snappableType: ManagedObjectType! (enum)
            if (this.SnappableType == null && Exploration.Includes(parent + ".snappableType$"))
            {
                this.SnappableType = new ManagedObjectType();
            }
        }


    #endregion

    } // class LegalHoldSnappableDetail
    #endregion

    public static class ListLegalHoldSnappableDetailExtensions
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
            this List<LegalHoldSnappableDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<LegalHoldSnappableDetail> list, 
            String parent = "")
        {
            var item = new LegalHoldSnappableDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types