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

        //      C# -> System.Int64? LiveMountId
        // GraphQL -> liveMountId: Long! (scalar)
        [JsonProperty("liveMountId")]
        public System.Int64? LiveMountId { get; set; }

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
        System.Int64? LiveMountId = null,
        DateTime? MountTime = null,
        System.Int32? MountedDisksCount = null,
        DateTime? SnapshotTime = null,
        SpecificMountDetails? SpecificMountDetails = null
    ) 
    {
        if ( MountStatus != null ) {
            this.MountStatus = MountStatus;
        }
        if ( LiveMountId != null ) {
            this.LiveMountId = LiveMountId;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> MountStatusEnum? MountStatus
        // GraphQL -> mountStatus: MountStatusEnum! (enum)
        if (this.MountStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountStatus\n" ;
            } else {
                s += ind + "mountStatus\n" ;
            }
        }
        //      C# -> System.Int64? LiveMountId
        // GraphQL -> liveMountId: Long! (scalar)
        if (this.LiveMountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "liveMountId\n" ;
            } else {
                s += ind + "liveMountId\n" ;
            }
        }
        //      C# -> DateTime? MountTime
        // GraphQL -> mountTime: DateTime (scalar)
        if (this.MountTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountTime\n" ;
            } else {
                s += ind + "mountTime\n" ;
            }
        }
        //      C# -> System.Int32? MountedDisksCount
        // GraphQL -> mountedDisksCount: Int! (scalar)
        if (this.MountedDisksCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountedDisksCount\n" ;
            } else {
                s += ind + "mountedDisksCount\n" ;
            }
        }
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (this.SnapshotTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotTime\n" ;
            } else {
                s += ind + "snapshotTime\n" ;
            }
        }
        //      C# -> SpecificMountDetails? SpecificMountDetails
        // GraphQL -> specificMountDetails: SpecificMountDetails! (type)
        if (this.SpecificMountDetails != null) {
            var fspec = this.SpecificMountDetails.AsFieldSpec(conf.Child("specificMountDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "specificMountDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> MountStatusEnum? MountStatus
        // GraphQL -> mountStatus: MountStatusEnum! (enum)
        if (ec.Includes("mountStatus",true))
        {
            if(this.MountStatus == null) {

                this.MountStatus = new MountStatusEnum();

            } else {


            }
        }
        else if (this.MountStatus != null && ec.Excludes("mountStatus",true))
        {
            this.MountStatus = null;
        }
        //      C# -> System.Int64? LiveMountId
        // GraphQL -> liveMountId: Long! (scalar)
        if (ec.Includes("liveMountId",true))
        {
            if(this.LiveMountId == null) {

                this.LiveMountId = new System.Int64();

            } else {


            }
        }
        else if (this.LiveMountId != null && ec.Excludes("liveMountId",true))
        {
            this.LiveMountId = null;
        }
        //      C# -> DateTime? MountTime
        // GraphQL -> mountTime: DateTime (scalar)
        if (ec.Includes("mountTime",true))
        {
            if(this.MountTime == null) {

                this.MountTime = new DateTime();

            } else {


            }
        }
        else if (this.MountTime != null && ec.Excludes("mountTime",true))
        {
            this.MountTime = null;
        }
        //      C# -> System.Int32? MountedDisksCount
        // GraphQL -> mountedDisksCount: Int! (scalar)
        if (ec.Includes("mountedDisksCount",true))
        {
            if(this.MountedDisksCount == null) {

                this.MountedDisksCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.MountedDisksCount != null && ec.Excludes("mountedDisksCount",true))
        {
            this.MountedDisksCount = null;
        }
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (ec.Includes("snapshotTime",true))
        {
            if(this.SnapshotTime == null) {

                this.SnapshotTime = new DateTime();

            } else {


            }
        }
        else if (this.SnapshotTime != null && ec.Excludes("snapshotTime",true))
        {
            this.SnapshotTime = null;
        }
        //      C# -> SpecificMountDetails? SpecificMountDetails
        // GraphQL -> specificMountDetails: SpecificMountDetails! (type)
        if (ec.Includes("specificMountDetails",false))
        {
            if(this.SpecificMountDetails == null) {

                this.SpecificMountDetails = new SpecificMountDetails();
                this.SpecificMountDetails.ApplyExploratoryFieldSpec(ec.NewChild("specificMountDetails"));

            } else {

                this.SpecificMountDetails.ApplyExploratoryFieldSpec(ec.NewChild("specificMountDetails"));

            }
        }
        else if (this.SpecificMountDetails != null && ec.Excludes("specificMountDetails",false))
        {
            this.SpecificMountDetails = null;
        }
    }


    #endregion

    } // class LiveMountDetails
    
    #endregion

    public static class ListLiveMountDetailsExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<LiveMountDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<LiveMountDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<LiveMountDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types