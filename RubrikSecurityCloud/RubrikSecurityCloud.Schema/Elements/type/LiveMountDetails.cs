// LiveMountDetails.cs
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
    #region LiveMountDetails
    public class LiveMountDetails: BaseType
    {
        #region members

        //      C# -> MountStatusEnum? MountStatus
        // GraphQL -> mountStatus: MountStatusEnum! (enum)
        [JsonProperty("mountStatus")]
        public MountStatusEnum? MountStatus { get; set; }

        //      C# -> DateTime? MountTime
        // GraphQL -> mountTime: DateTime (scalar)
        [JsonProperty("mountTime")]
        public DateTime? MountTime { get; set; }

        //      C# -> System.Int32? MountedDisksCount
        // GraphQL -> mountedDisksCount: Int! (scalar)
        [JsonProperty("mountedDisksCount")]
        public System.Int32? MountedDisksCount { get; set; }

        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        [JsonProperty("snapshotTime")]
        public DateTime? SnapshotTime { get; set; }

        //      C# -> SpecificMountDetails? SpecificMountDetails
        // GraphQL -> specificMountDetails: SpecificMountDetails! (type)
        [JsonProperty("specificMountDetails")]
        public SpecificMountDetails? SpecificMountDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LiveMountDetails";
    }

    public LiveMountDetails Set(
        MountStatusEnum? MountStatus = null,
        DateTime? MountTime = null,
        System.Int32? MountedDisksCount = null,
        DateTime? SnapshotTime = null,
        SpecificMountDetails? SpecificMountDetails = null
    ) 
    {
        if ( MountStatus != null ) {
            this.MountStatus = MountStatus;
        }
        if ( MountTime != null ) {
            this.MountTime = MountTime;
        }
        if ( MountedDisksCount != null ) {
            this.MountedDisksCount = MountedDisksCount;
        }
        if ( SnapshotTime != null ) {
            this.SnapshotTime = SnapshotTime;
        }
        if ( SpecificMountDetails != null ) {
            this.SpecificMountDetails = SpecificMountDetails;
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
        //      C# -> MountStatusEnum? MountStatus
        // GraphQL -> mountStatus: MountStatusEnum! (enum)
        if (this.MountStatus != null) {
            s += ind + "mountStatus\n" ;
        }
        //      C# -> DateTime? MountTime
        // GraphQL -> mountTime: DateTime (scalar)
        if (this.MountTime != null) {
            s += ind + "mountTime\n" ;
        }
        //      C# -> System.Int32? MountedDisksCount
        // GraphQL -> mountedDisksCount: Int! (scalar)
        if (this.MountedDisksCount != null) {
            s += ind + "mountedDisksCount\n" ;
        }
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (this.SnapshotTime != null) {
            s += ind + "snapshotTime\n" ;
        }
        //      C# -> SpecificMountDetails? SpecificMountDetails
        // GraphQL -> specificMountDetails: SpecificMountDetails! (type)
        if (this.SpecificMountDetails != null) {
            var fspec = this.SpecificMountDetails.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "specificMountDetails {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> MountStatusEnum? MountStatus
        // GraphQL -> mountStatus: MountStatusEnum! (enum)
        if (this.MountStatus == null && ec.Includes("mountStatus",true))
        {
            this.MountStatus = new MountStatusEnum();
        }
        //      C# -> DateTime? MountTime
        // GraphQL -> mountTime: DateTime (scalar)
        if (this.MountTime == null && ec.Includes("mountTime",true))
        {
            this.MountTime = new DateTime();
        }
        //      C# -> System.Int32? MountedDisksCount
        // GraphQL -> mountedDisksCount: Int! (scalar)
        if (this.MountedDisksCount == null && ec.Includes("mountedDisksCount",true))
        {
            this.MountedDisksCount = Int32.MinValue;
        }
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (this.SnapshotTime == null && ec.Includes("snapshotTime",true))
        {
            this.SnapshotTime = new DateTime();
        }
        //      C# -> SpecificMountDetails? SpecificMountDetails
        // GraphQL -> specificMountDetails: SpecificMountDetails! (type)
        if (this.SpecificMountDetails == null && ec.Includes("specificMountDetails",false))
        {
            this.SpecificMountDetails = new SpecificMountDetails();
            this.SpecificMountDetails.ApplyExploratoryFieldSpec(ec.NewChild("specificMountDetails"));
        }
    }


    #endregion

    } // class LiveMountDetails
    
    #endregion

    public static class ListLiveMountDetailsExtensions
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
            this List<LiveMountDetails> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<LiveMountDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LiveMountDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<LiveMountDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types