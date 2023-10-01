// UpdateManagedVolumeReply.cs
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
    #region UpdateManagedVolumeReply
    public class UpdateManagedVolumeReply: BaseType
    {
        #region members

        //      C# -> ManagedVolumeApplicationTag? ApplicationTag
        // GraphQL -> applicationTag: ManagedVolumeApplicationTag (enum)
        [JsonProperty("applicationTag")]
        public ManagedVolumeApplicationTag? ApplicationTag { get; set; }

        //      C# -> CdmManagedVolumeType? MvType
        // GraphQL -> mvType: CdmManagedVolumeType (enum)
        [JsonProperty("mvType")]
        public CdmManagedVolumeType? MvType { get; set; }

        //      C# -> ManagedVolumeShareType? ShareType
        // GraphQL -> shareType: ManagedVolumeShareType! (enum)
        [JsonProperty("shareType")]
        public ManagedVolumeShareType? ShareType { get; set; }

        //      C# -> ManagedVolumeState? State
        // GraphQL -> state: ManagedVolumeState! (enum)
        [JsonProperty("state")]
        public ManagedVolumeState? State { get; set; }

        //      C# -> List<System.String>? HostPatterns
        // GraphQL -> hostPatterns: [String!]! (scalar)
        [JsonProperty("hostPatterns")]
        public List<System.String>? HostPatterns { get; set; }

        //      C# -> System.Boolean? IsDeleted
        // GraphQL -> isDeleted: Boolean! (scalar)
        [JsonProperty("isDeleted")]
        public System.Boolean? IsDeleted { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.Boolean? IsWritable
        // GraphQL -> isWritable: Boolean! (scalar)
        [JsonProperty("isWritable")]
        public System.Boolean? IsWritable { get; set; }

        //      C# -> System.Int32? NumChannels
        // GraphQL -> numChannels: Int! (scalar)
        [JsonProperty("numChannels")]
        public System.Int32? NumChannels { get; set; }

        //      C# -> System.Int32? PendingSnapshotCount
        // GraphQL -> pendingSnapshotCount: Int! (scalar)
        [JsonProperty("pendingSnapshotCount")]
        public System.Int32? PendingSnapshotCount { get; set; }

        //      C# -> System.String? SmbDomainName
        // GraphQL -> smbDomainName: String (scalar)
        [JsonProperty("smbDomainName")]
        public System.String? SmbDomainName { get; set; }

        //      C# -> List<System.String>? SmbValidIps
        // GraphQL -> smbValidIps: [String!]! (scalar)
        [JsonProperty("smbValidIps")]
        public List<System.String>? SmbValidIps { get; set; }

        //      C# -> List<System.String>? SmbValidUsers
        // GraphQL -> smbValidUsers: [String!]! (scalar)
        [JsonProperty("smbValidUsers")]
        public List<System.String>? SmbValidUsers { get; set; }

        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int! (scalar)
        [JsonProperty("snapshotCount")]
        public System.Int32? SnapshotCount { get; set; }

        //      C# -> System.String? Subnet
        // GraphQL -> subnet: String (scalar)
        [JsonProperty("subnet")]
        public System.String? Subnet { get; set; }

        //      C# -> System.Int64? UsedSize
        // GraphQL -> usedSize: Long! (scalar)
        [JsonProperty("usedSize")]
        public System.Int64? UsedSize { get; set; }

        //      C# -> System.Int64? VolumeSize
        // GraphQL -> volumeSize: Long! (scalar)
        [JsonProperty("volumeSize")]
        public System.Int64? VolumeSize { get; set; }

        //      C# -> List<Link>? Links
        // GraphQL -> links: [Link!]! (type)
        [JsonProperty("links")]
        public List<Link>? Links { get; set; }

        //      C# -> ManagedVolumeExport? MainExport
        // GraphQL -> mainExport: ManagedVolumeExport (type)
        [JsonProperty("mainExport")]
        public ManagedVolumeExport? MainExport { get; set; }

        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        [JsonProperty("pendingSlaDomain")]
        public ManagedObjectPendingSlaInfo? PendingSlaDomain { get; set; }

        //      C# -> SlaManagedVolumeDetail? SlaManagedVolumeDetails
        // GraphQL -> slaManagedVolumeDetails: SlaManagedVolumeDetail (type)
        [JsonProperty("slaManagedVolumeDetails")]
        public SlaManagedVolumeDetail? SlaManagedVolumeDetails { get; set; }

        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        [JsonProperty("snappable")]
        public CdmWorkload? Snappable { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateManagedVolumeReply";
    }

    public UpdateManagedVolumeReply Set(
        ManagedVolumeApplicationTag? ApplicationTag = null,
        CdmManagedVolumeType? MvType = null,
        ManagedVolumeShareType? ShareType = null,
        ManagedVolumeState? State = null,
        List<System.String>? HostPatterns = null,
        System.Boolean? IsDeleted = null,
        System.Boolean? IsRelic = null,
        System.Boolean? IsWritable = null,
        System.Int32? NumChannels = null,
        System.Int32? PendingSnapshotCount = null,
        System.String? SmbDomainName = null,
        List<System.String>? SmbValidIps = null,
        List<System.String>? SmbValidUsers = null,
        System.Int32? SnapshotCount = null,
        System.String? Subnet = null,
        System.Int64? UsedSize = null,
        System.Int64? VolumeSize = null,
        List<Link>? Links = null,
        ManagedVolumeExport? MainExport = null,
        ManagedObjectPendingSlaInfo? PendingSlaDomain = null,
        SlaManagedVolumeDetail? SlaManagedVolumeDetails = null,
        CdmWorkload? Snappable = null
    ) 
    {
        if ( ApplicationTag != null ) {
            this.ApplicationTag = ApplicationTag;
        }
        if ( MvType != null ) {
            this.MvType = MvType;
        }
        if ( ShareType != null ) {
            this.ShareType = ShareType;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( HostPatterns != null ) {
            this.HostPatterns = HostPatterns;
        }
        if ( IsDeleted != null ) {
            this.IsDeleted = IsDeleted;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( IsWritable != null ) {
            this.IsWritable = IsWritable;
        }
        if ( NumChannels != null ) {
            this.NumChannels = NumChannels;
        }
        if ( PendingSnapshotCount != null ) {
            this.PendingSnapshotCount = PendingSnapshotCount;
        }
        if ( SmbDomainName != null ) {
            this.SmbDomainName = SmbDomainName;
        }
        if ( SmbValidIps != null ) {
            this.SmbValidIps = SmbValidIps;
        }
        if ( SmbValidUsers != null ) {
            this.SmbValidUsers = SmbValidUsers;
        }
        if ( SnapshotCount != null ) {
            this.SnapshotCount = SnapshotCount;
        }
        if ( Subnet != null ) {
            this.Subnet = Subnet;
        }
        if ( UsedSize != null ) {
            this.UsedSize = UsedSize;
        }
        if ( VolumeSize != null ) {
            this.VolumeSize = VolumeSize;
        }
        if ( Links != null ) {
            this.Links = Links;
        }
        if ( MainExport != null ) {
            this.MainExport = MainExport;
        }
        if ( PendingSlaDomain != null ) {
            this.PendingSlaDomain = PendingSlaDomain;
        }
        if ( SlaManagedVolumeDetails != null ) {
            this.SlaManagedVolumeDetails = SlaManagedVolumeDetails;
        }
        if ( Snappable != null ) {
            this.Snappable = Snappable;
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
        //      C# -> ManagedVolumeApplicationTag? ApplicationTag
        // GraphQL -> applicationTag: ManagedVolumeApplicationTag (enum)
        if (this.ApplicationTag != null) {
            if (conf.Flat) {
                s += conf.Prefix + "applicationTag\n" ;
            } else {
                s += ind + "applicationTag\n" ;
            }
        }
        //      C# -> CdmManagedVolumeType? MvType
        // GraphQL -> mvType: CdmManagedVolumeType (enum)
        if (this.MvType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mvType\n" ;
            } else {
                s += ind + "mvType\n" ;
            }
        }
        //      C# -> ManagedVolumeShareType? ShareType
        // GraphQL -> shareType: ManagedVolumeShareType! (enum)
        if (this.ShareType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shareType\n" ;
            } else {
                s += ind + "shareType\n" ;
            }
        }
        //      C# -> ManagedVolumeState? State
        // GraphQL -> state: ManagedVolumeState! (enum)
        if (this.State != null) {
            if (conf.Flat) {
                s += conf.Prefix + "state\n" ;
            } else {
                s += ind + "state\n" ;
            }
        }
        //      C# -> List<System.String>? HostPatterns
        // GraphQL -> hostPatterns: [String!]! (scalar)
        if (this.HostPatterns != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostPatterns\n" ;
            } else {
                s += ind + "hostPatterns\n" ;
            }
        }
        //      C# -> System.Boolean? IsDeleted
        // GraphQL -> isDeleted: Boolean! (scalar)
        if (this.IsDeleted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDeleted\n" ;
            } else {
                s += ind + "isDeleted\n" ;
            }
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRelic\n" ;
            } else {
                s += ind + "isRelic\n" ;
            }
        }
        //      C# -> System.Boolean? IsWritable
        // GraphQL -> isWritable: Boolean! (scalar)
        if (this.IsWritable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isWritable\n" ;
            } else {
                s += ind + "isWritable\n" ;
            }
        }
        //      C# -> System.Int32? NumChannels
        // GraphQL -> numChannels: Int! (scalar)
        if (this.NumChannels != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numChannels\n" ;
            } else {
                s += ind + "numChannels\n" ;
            }
        }
        //      C# -> System.Int32? PendingSnapshotCount
        // GraphQL -> pendingSnapshotCount: Int! (scalar)
        if (this.PendingSnapshotCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pendingSnapshotCount\n" ;
            } else {
                s += ind + "pendingSnapshotCount\n" ;
            }
        }
        //      C# -> System.String? SmbDomainName
        // GraphQL -> smbDomainName: String (scalar)
        if (this.SmbDomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "smbDomainName\n" ;
            } else {
                s += ind + "smbDomainName\n" ;
            }
        }
        //      C# -> List<System.String>? SmbValidIps
        // GraphQL -> smbValidIps: [String!]! (scalar)
        if (this.SmbValidIps != null) {
            if (conf.Flat) {
                s += conf.Prefix + "smbValidIps\n" ;
            } else {
                s += ind + "smbValidIps\n" ;
            }
        }
        //      C# -> List<System.String>? SmbValidUsers
        // GraphQL -> smbValidUsers: [String!]! (scalar)
        if (this.SmbValidUsers != null) {
            if (conf.Flat) {
                s += conf.Prefix + "smbValidUsers\n" ;
            } else {
                s += ind + "smbValidUsers\n" ;
            }
        }
        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int! (scalar)
        if (this.SnapshotCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotCount\n" ;
            } else {
                s += ind + "snapshotCount\n" ;
            }
        }
        //      C# -> System.String? Subnet
        // GraphQL -> subnet: String (scalar)
        if (this.Subnet != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subnet\n" ;
            } else {
                s += ind + "subnet\n" ;
            }
        }
        //      C# -> System.Int64? UsedSize
        // GraphQL -> usedSize: Long! (scalar)
        if (this.UsedSize != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usedSize\n" ;
            } else {
                s += ind + "usedSize\n" ;
            }
        }
        //      C# -> System.Int64? VolumeSize
        // GraphQL -> volumeSize: Long! (scalar)
        if (this.VolumeSize != null) {
            if (conf.Flat) {
                s += conf.Prefix + "volumeSize\n" ;
            } else {
                s += ind + "volumeSize\n" ;
            }
        }
        //      C# -> List<Link>? Links
        // GraphQL -> links: [Link!]! (type)
        if (this.Links != null) {
            var fspec = this.Links.AsFieldSpec(conf.Child("links"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "links {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ManagedVolumeExport? MainExport
        // GraphQL -> mainExport: ManagedVolumeExport (type)
        if (this.MainExport != null) {
            var fspec = this.MainExport.AsFieldSpec(conf.Child("mainExport"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mainExport {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        if (this.PendingSlaDomain != null) {
            var fspec = this.PendingSlaDomain.AsFieldSpec(conf.Child("pendingSlaDomain"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pendingSlaDomain {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SlaManagedVolumeDetail? SlaManagedVolumeDetails
        // GraphQL -> slaManagedVolumeDetails: SlaManagedVolumeDetail (type)
        if (this.SlaManagedVolumeDetails != null) {
            var fspec = this.SlaManagedVolumeDetails.AsFieldSpec(conf.Child("slaManagedVolumeDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "slaManagedVolumeDetails {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        if (this.Snappable != null) {
            var fspec = this.Snappable.AsFieldSpec(conf.Child("snappable"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snappable {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ManagedVolumeApplicationTag? ApplicationTag
        // GraphQL -> applicationTag: ManagedVolumeApplicationTag (enum)
        if (ec.Includes("applicationTag",true))
        {
            if(this.ApplicationTag == null) {

                this.ApplicationTag = new ManagedVolumeApplicationTag();

            } else {


            }
        }
        else if (this.ApplicationTag != null && ec.Excludes("applicationTag",true))
        {
            this.ApplicationTag = null;
        }
        //      C# -> CdmManagedVolumeType? MvType
        // GraphQL -> mvType: CdmManagedVolumeType (enum)
        if (ec.Includes("mvType",true))
        {
            if(this.MvType == null) {

                this.MvType = new CdmManagedVolumeType();

            } else {


            }
        }
        else if (this.MvType != null && ec.Excludes("mvType",true))
        {
            this.MvType = null;
        }
        //      C# -> ManagedVolumeShareType? ShareType
        // GraphQL -> shareType: ManagedVolumeShareType! (enum)
        if (ec.Includes("shareType",true))
        {
            if(this.ShareType == null) {

                this.ShareType = new ManagedVolumeShareType();

            } else {


            }
        }
        else if (this.ShareType != null && ec.Excludes("shareType",true))
        {
            this.ShareType = null;
        }
        //      C# -> ManagedVolumeState? State
        // GraphQL -> state: ManagedVolumeState! (enum)
        if (ec.Includes("state",true))
        {
            if(this.State == null) {

                this.State = new ManagedVolumeState();

            } else {


            }
        }
        else if (this.State != null && ec.Excludes("state",true))
        {
            this.State = null;
        }
        //      C# -> List<System.String>? HostPatterns
        // GraphQL -> hostPatterns: [String!]! (scalar)
        if (ec.Includes("hostPatterns",true))
        {
            if(this.HostPatterns == null) {

                this.HostPatterns = new List<System.String>();

            } else {


            }
        }
        else if (this.HostPatterns != null && ec.Excludes("hostPatterns",true))
        {
            this.HostPatterns = null;
        }
        //      C# -> System.Boolean? IsDeleted
        // GraphQL -> isDeleted: Boolean! (scalar)
        if (ec.Includes("isDeleted",true))
        {
            if(this.IsDeleted == null) {

                this.IsDeleted = true;

            } else {


            }
        }
        else if (this.IsDeleted != null && ec.Excludes("isDeleted",true))
        {
            this.IsDeleted = null;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (ec.Includes("isRelic",true))
        {
            if(this.IsRelic == null) {

                this.IsRelic = true;

            } else {


            }
        }
        else if (this.IsRelic != null && ec.Excludes("isRelic",true))
        {
            this.IsRelic = null;
        }
        //      C# -> System.Boolean? IsWritable
        // GraphQL -> isWritable: Boolean! (scalar)
        if (ec.Includes("isWritable",true))
        {
            if(this.IsWritable == null) {

                this.IsWritable = true;

            } else {


            }
        }
        else if (this.IsWritable != null && ec.Excludes("isWritable",true))
        {
            this.IsWritable = null;
        }
        //      C# -> System.Int32? NumChannels
        // GraphQL -> numChannels: Int! (scalar)
        if (ec.Includes("numChannels",true))
        {
            if(this.NumChannels == null) {

                this.NumChannels = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumChannels != null && ec.Excludes("numChannels",true))
        {
            this.NumChannels = null;
        }
        //      C# -> System.Int32? PendingSnapshotCount
        // GraphQL -> pendingSnapshotCount: Int! (scalar)
        if (ec.Includes("pendingSnapshotCount",true))
        {
            if(this.PendingSnapshotCount == null) {

                this.PendingSnapshotCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.PendingSnapshotCount != null && ec.Excludes("pendingSnapshotCount",true))
        {
            this.PendingSnapshotCount = null;
        }
        //      C# -> System.String? SmbDomainName
        // GraphQL -> smbDomainName: String (scalar)
        if (ec.Includes("smbDomainName",true))
        {
            if(this.SmbDomainName == null) {

                this.SmbDomainName = "FETCH";

            } else {


            }
        }
        else if (this.SmbDomainName != null && ec.Excludes("smbDomainName",true))
        {
            this.SmbDomainName = null;
        }
        //      C# -> List<System.String>? SmbValidIps
        // GraphQL -> smbValidIps: [String!]! (scalar)
        if (ec.Includes("smbValidIps",true))
        {
            if(this.SmbValidIps == null) {

                this.SmbValidIps = new List<System.String>();

            } else {


            }
        }
        else if (this.SmbValidIps != null && ec.Excludes("smbValidIps",true))
        {
            this.SmbValidIps = null;
        }
        //      C# -> List<System.String>? SmbValidUsers
        // GraphQL -> smbValidUsers: [String!]! (scalar)
        if (ec.Includes("smbValidUsers",true))
        {
            if(this.SmbValidUsers == null) {

                this.SmbValidUsers = new List<System.String>();

            } else {


            }
        }
        else if (this.SmbValidUsers != null && ec.Excludes("smbValidUsers",true))
        {
            this.SmbValidUsers = null;
        }
        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int! (scalar)
        if (ec.Includes("snapshotCount",true))
        {
            if(this.SnapshotCount == null) {

                this.SnapshotCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.SnapshotCount != null && ec.Excludes("snapshotCount",true))
        {
            this.SnapshotCount = null;
        }
        //      C# -> System.String? Subnet
        // GraphQL -> subnet: String (scalar)
        if (ec.Includes("subnet",true))
        {
            if(this.Subnet == null) {

                this.Subnet = "FETCH";

            } else {


            }
        }
        else if (this.Subnet != null && ec.Excludes("subnet",true))
        {
            this.Subnet = null;
        }
        //      C# -> System.Int64? UsedSize
        // GraphQL -> usedSize: Long! (scalar)
        if (ec.Includes("usedSize",true))
        {
            if(this.UsedSize == null) {

                this.UsedSize = new System.Int64();

            } else {


            }
        }
        else if (this.UsedSize != null && ec.Excludes("usedSize",true))
        {
            this.UsedSize = null;
        }
        //      C# -> System.Int64? VolumeSize
        // GraphQL -> volumeSize: Long! (scalar)
        if (ec.Includes("volumeSize",true))
        {
            if(this.VolumeSize == null) {

                this.VolumeSize = new System.Int64();

            } else {


            }
        }
        else if (this.VolumeSize != null && ec.Excludes("volumeSize",true))
        {
            this.VolumeSize = null;
        }
        //      C# -> List<Link>? Links
        // GraphQL -> links: [Link!]! (type)
        if (ec.Includes("links",false))
        {
            if(this.Links == null) {

                this.Links = new List<Link>();
                this.Links.ApplyExploratoryFieldSpec(ec.NewChild("links"));

            } else {

                this.Links.ApplyExploratoryFieldSpec(ec.NewChild("links"));

            }
        }
        else if (this.Links != null && ec.Excludes("links",false))
        {
            this.Links = null;
        }
        //      C# -> ManagedVolumeExport? MainExport
        // GraphQL -> mainExport: ManagedVolumeExport (type)
        if (ec.Includes("mainExport",false))
        {
            if(this.MainExport == null) {

                this.MainExport = new ManagedVolumeExport();
                this.MainExport.ApplyExploratoryFieldSpec(ec.NewChild("mainExport"));

            } else {

                this.MainExport.ApplyExploratoryFieldSpec(ec.NewChild("mainExport"));

            }
        }
        else if (this.MainExport != null && ec.Excludes("mainExport",false))
        {
            this.MainExport = null;
        }
        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        if (ec.Includes("pendingSlaDomain",false))
        {
            if(this.PendingSlaDomain == null) {

                this.PendingSlaDomain = new ManagedObjectPendingSlaInfo();
                this.PendingSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("pendingSlaDomain"));

            } else {

                this.PendingSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("pendingSlaDomain"));

            }
        }
        else if (this.PendingSlaDomain != null && ec.Excludes("pendingSlaDomain",false))
        {
            this.PendingSlaDomain = null;
        }
        //      C# -> SlaManagedVolumeDetail? SlaManagedVolumeDetails
        // GraphQL -> slaManagedVolumeDetails: SlaManagedVolumeDetail (type)
        if (ec.Includes("slaManagedVolumeDetails",false))
        {
            if(this.SlaManagedVolumeDetails == null) {

                this.SlaManagedVolumeDetails = new SlaManagedVolumeDetail();
                this.SlaManagedVolumeDetails.ApplyExploratoryFieldSpec(ec.NewChild("slaManagedVolumeDetails"));

            } else {

                this.SlaManagedVolumeDetails.ApplyExploratoryFieldSpec(ec.NewChild("slaManagedVolumeDetails"));

            }
        }
        else if (this.SlaManagedVolumeDetails != null && ec.Excludes("slaManagedVolumeDetails",false))
        {
            this.SlaManagedVolumeDetails = null;
        }
        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        if (ec.Includes("snappable",false))
        {
            if(this.Snappable == null) {

                this.Snappable = new CdmWorkload();
                this.Snappable.ApplyExploratoryFieldSpec(ec.NewChild("snappable"));

            } else {

                this.Snappable.ApplyExploratoryFieldSpec(ec.NewChild("snappable"));

            }
        }
        else if (this.Snappable != null && ec.Excludes("snappable",false))
        {
            this.Snappable = null;
        }
    }


    #endregion

    } // class UpdateManagedVolumeReply
    
    #endregion

    public static class ListUpdateManagedVolumeReplyExtensions
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
            this List<UpdateManagedVolumeReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<UpdateManagedVolumeReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UpdateManagedVolumeReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateManagedVolumeReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpdateManagedVolumeReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types