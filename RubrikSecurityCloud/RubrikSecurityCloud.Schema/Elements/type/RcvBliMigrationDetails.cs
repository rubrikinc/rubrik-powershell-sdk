// RcvBliMigrationDetails.cs
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
    #region RcvBliMigrationDetails
    public class RcvBliMigrationDetails: BaseType
    {
        #region members

        //      C# -> BliMigrationStatus? BliMigrationStatus
        // GraphQL -> bliMigrationStatus: BliMigrationStatus! (enum)
        [JsonProperty("bliMigrationStatus")]
        public BliMigrationStatus? BliMigrationStatus { get; set; }

        //      C# -> MigrationUnavailabilityReason? BliMigrationUnavailabilityReason
        // GraphQL -> bliMigrationUnavailabilityReason: MigrationUnavailabilityReason! (enum)
        [JsonProperty("bliMigrationUnavailabilityReason")]
        public MigrationUnavailabilityReason? BliMigrationUnavailabilityReason { get; set; }

        //      C# -> ArchivalLocationStatus? LocationStatus
        // GraphQL -> locationStatus: ArchivalLocationStatus! (enum)
        [JsonProperty("locationStatus")]
        public ArchivalLocationStatus? LocationStatus { get; set; }

        //      C# -> RcvTier? Tier
        // GraphQL -> tier: RcvTier! (enum)
        [JsonProperty("tier")]
        public RcvTier? Tier { get; set; }

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        [JsonProperty("locationId")]
        public System.String? LocationId { get; set; }

        //      C# -> System.String? LocationName
        // GraphQL -> locationName: String! (scalar)
        [JsonProperty("locationName")]
        public System.String? LocationName { get; set; }

        //      C# -> System.String? MigrationStatus
        // GraphQL -> migrationStatus: String! (scalar)
        [JsonProperty("migrationStatus")]
        public System.String? MigrationStatus { get; set; }

        //      C# -> System.String? MigrationUnavailabilityReason
        // GraphQL -> migrationUnavailabilityReason: String! (scalar)
        [JsonProperty("migrationUnavailabilityReason")]
        public System.String? MigrationUnavailabilityReason { get; set; }

        //      C# -> System.Int64? StorageConsumedBytes
        // GraphQL -> storageConsumedBytes: Long! (scalar)
        [JsonProperty("storageConsumedBytes")]
        public System.Int64? StorageConsumedBytes { get; set; }

        //      C# -> RcvRegion? RcvRegion
        // GraphQL -> rcvRegion: RcvRegion (type)
        [JsonProperty("rcvRegion")]
        public RcvRegion? RcvRegion { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RcvBliMigrationDetails";
    }

    public RcvBliMigrationDetails Set(
        BliMigrationStatus? BliMigrationStatus = null,
        MigrationUnavailabilityReason? BliMigrationUnavailabilityReason = null,
        ArchivalLocationStatus? LocationStatus = null,
        RcvTier? Tier = null,
        System.String? ClusterName = null,
        System.String? LocationId = null,
        System.String? LocationName = null,
        System.String? MigrationStatus = null,
        System.String? MigrationUnavailabilityReason = null,
        System.Int64? StorageConsumedBytes = null,
        RcvRegion? RcvRegion = null
    ) 
    {
        if ( BliMigrationStatus != null ) {
            this.BliMigrationStatus = BliMigrationStatus;
        }
        if ( BliMigrationUnavailabilityReason != null ) {
            this.BliMigrationUnavailabilityReason = BliMigrationUnavailabilityReason;
        }
        if ( LocationStatus != null ) {
            this.LocationStatus = LocationStatus;
        }
        if ( Tier != null ) {
            this.Tier = Tier;
        }
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( LocationId != null ) {
            this.LocationId = LocationId;
        }
        if ( LocationName != null ) {
            this.LocationName = LocationName;
        }
        if ( MigrationStatus != null ) {
            this.MigrationStatus = MigrationStatus;
        }
        if ( MigrationUnavailabilityReason != null ) {
            this.MigrationUnavailabilityReason = MigrationUnavailabilityReason;
        }
        if ( StorageConsumedBytes != null ) {
            this.StorageConsumedBytes = StorageConsumedBytes;
        }
        if ( RcvRegion != null ) {
            this.RcvRegion = RcvRegion;
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
        //      C# -> BliMigrationStatus? BliMigrationStatus
        // GraphQL -> bliMigrationStatus: BliMigrationStatus! (enum)
        if (this.BliMigrationStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bliMigrationStatus\n" ;
            } else {
                s += ind + "bliMigrationStatus\n" ;
            }
        }
        //      C# -> MigrationUnavailabilityReason? BliMigrationUnavailabilityReason
        // GraphQL -> bliMigrationUnavailabilityReason: MigrationUnavailabilityReason! (enum)
        if (this.BliMigrationUnavailabilityReason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bliMigrationUnavailabilityReason\n" ;
            } else {
                s += ind + "bliMigrationUnavailabilityReason\n" ;
            }
        }
        //      C# -> ArchivalLocationStatus? LocationStatus
        // GraphQL -> locationStatus: ArchivalLocationStatus! (enum)
        if (this.LocationStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationStatus\n" ;
            } else {
                s += ind + "locationStatus\n" ;
            }
        }
        //      C# -> RcvTier? Tier
        // GraphQL -> tier: RcvTier! (enum)
        if (this.Tier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tier\n" ;
            } else {
                s += ind + "tier\n" ;
            }
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterName\n" ;
            } else {
                s += ind + "clusterName\n" ;
            }
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (this.LocationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationId\n" ;
            } else {
                s += ind + "locationId\n" ;
            }
        }
        //      C# -> System.String? LocationName
        // GraphQL -> locationName: String! (scalar)
        if (this.LocationName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationName\n" ;
            } else {
                s += ind + "locationName\n" ;
            }
        }
        //      C# -> System.String? MigrationStatus
        // GraphQL -> migrationStatus: String! (scalar)
        if (this.MigrationStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "migrationStatus\n" ;
            } else {
                s += ind + "migrationStatus\n" ;
            }
        }
        //      C# -> System.String? MigrationUnavailabilityReason
        // GraphQL -> migrationUnavailabilityReason: String! (scalar)
        if (this.MigrationUnavailabilityReason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "migrationUnavailabilityReason\n" ;
            } else {
                s += ind + "migrationUnavailabilityReason\n" ;
            }
        }
        //      C# -> System.Int64? StorageConsumedBytes
        // GraphQL -> storageConsumedBytes: Long! (scalar)
        if (this.StorageConsumedBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageConsumedBytes\n" ;
            } else {
                s += ind + "storageConsumedBytes\n" ;
            }
        }
        //      C# -> RcvRegion? RcvRegion
        // GraphQL -> rcvRegion: RcvRegion (type)
        if (this.RcvRegion != null) {
            var fspec = this.RcvRegion.AsFieldSpec(conf.Child("rcvRegion"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "rcvRegion" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> BliMigrationStatus? BliMigrationStatus
        // GraphQL -> bliMigrationStatus: BliMigrationStatus! (enum)
        if (ec.Includes("bliMigrationStatus",true))
        {
            if(this.BliMigrationStatus == null) {

                this.BliMigrationStatus = new BliMigrationStatus();

            } else {


            }
        }
        else if (this.BliMigrationStatus != null && ec.Excludes("bliMigrationStatus",true))
        {
            this.BliMigrationStatus = null;
        }
        //      C# -> MigrationUnavailabilityReason? BliMigrationUnavailabilityReason
        // GraphQL -> bliMigrationUnavailabilityReason: MigrationUnavailabilityReason! (enum)
        if (ec.Includes("bliMigrationUnavailabilityReason",true))
        {
            if(this.BliMigrationUnavailabilityReason == null) {

                this.BliMigrationUnavailabilityReason = new MigrationUnavailabilityReason();

            } else {


            }
        }
        else if (this.BliMigrationUnavailabilityReason != null && ec.Excludes("bliMigrationUnavailabilityReason",true))
        {
            this.BliMigrationUnavailabilityReason = null;
        }
        //      C# -> ArchivalLocationStatus? LocationStatus
        // GraphQL -> locationStatus: ArchivalLocationStatus! (enum)
        if (ec.Includes("locationStatus",true))
        {
            if(this.LocationStatus == null) {

                this.LocationStatus = new ArchivalLocationStatus();

            } else {


            }
        }
        else if (this.LocationStatus != null && ec.Excludes("locationStatus",true))
        {
            this.LocationStatus = null;
        }
        //      C# -> RcvTier? Tier
        // GraphQL -> tier: RcvTier! (enum)
        if (ec.Includes("tier",true))
        {
            if(this.Tier == null) {

                this.Tier = new RcvTier();

            } else {


            }
        }
        else if (this.Tier != null && ec.Excludes("tier",true))
        {
            this.Tier = null;
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (ec.Includes("clusterName",true))
        {
            if(this.ClusterName == null) {

                this.ClusterName = "FETCH";

            } else {


            }
        }
        else if (this.ClusterName != null && ec.Excludes("clusterName",true))
        {
            this.ClusterName = null;
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (ec.Includes("locationId",true))
        {
            if(this.LocationId == null) {

                this.LocationId = "FETCH";

            } else {


            }
        }
        else if (this.LocationId != null && ec.Excludes("locationId",true))
        {
            this.LocationId = null;
        }
        //      C# -> System.String? LocationName
        // GraphQL -> locationName: String! (scalar)
        if (ec.Includes("locationName",true))
        {
            if(this.LocationName == null) {

                this.LocationName = "FETCH";

            } else {


            }
        }
        else if (this.LocationName != null && ec.Excludes("locationName",true))
        {
            this.LocationName = null;
        }
        //      C# -> System.String? MigrationStatus
        // GraphQL -> migrationStatus: String! (scalar)
        if (ec.Includes("migrationStatus",true))
        {
            if(this.MigrationStatus == null) {

                this.MigrationStatus = "FETCH";

            } else {


            }
        }
        else if (this.MigrationStatus != null && ec.Excludes("migrationStatus",true))
        {
            this.MigrationStatus = null;
        }
        //      C# -> System.String? MigrationUnavailabilityReason
        // GraphQL -> migrationUnavailabilityReason: String! (scalar)
        if (ec.Includes("migrationUnavailabilityReason",true))
        {
            if(this.MigrationUnavailabilityReason == null) {

                this.MigrationUnavailabilityReason = "FETCH";

            } else {


            }
        }
        else if (this.MigrationUnavailabilityReason != null && ec.Excludes("migrationUnavailabilityReason",true))
        {
            this.MigrationUnavailabilityReason = null;
        }
        //      C# -> System.Int64? StorageConsumedBytes
        // GraphQL -> storageConsumedBytes: Long! (scalar)
        if (ec.Includes("storageConsumedBytes",true))
        {
            if(this.StorageConsumedBytes == null) {

                this.StorageConsumedBytes = new System.Int64();

            } else {


            }
        }
        else if (this.StorageConsumedBytes != null && ec.Excludes("storageConsumedBytes",true))
        {
            this.StorageConsumedBytes = null;
        }
        //      C# -> RcvRegion? RcvRegion
        // GraphQL -> rcvRegion: RcvRegion (type)
        if (ec.Includes("rcvRegion",false))
        {
            if(this.RcvRegion == null) {

                this.RcvRegion = new RcvRegion();
                this.RcvRegion.ApplyExploratoryFieldSpec(ec.NewChild("rcvRegion"));

            } else {

                this.RcvRegion.ApplyExploratoryFieldSpec(ec.NewChild("rcvRegion"));

            }
        }
        else if (this.RcvRegion != null && ec.Excludes("rcvRegion",false))
        {
            this.RcvRegion = null;
        }
    }


    #endregion

    } // class RcvBliMigrationDetails
    
    #endregion

    public static class ListRcvBliMigrationDetailsExtensions
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
            this List<RcvBliMigrationDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RcvBliMigrationDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RcvBliMigrationDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RcvBliMigrationDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RcvBliMigrationDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types