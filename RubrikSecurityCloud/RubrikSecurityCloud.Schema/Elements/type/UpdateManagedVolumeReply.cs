// UpdateManagedVolumeReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:29.
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
    #region UpdateManagedVolumeReply
    public class UpdateManagedVolumeReply: IFragment
    {
        #region members
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

        #endregion

    #region methods

    public UpdateManagedVolumeReply Set(
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
        CdmWorkload? Snappable = null,
        ManagedVolumeApplicationTag? ApplicationTag = null,
        CdmManagedVolumeType? MvType = null,
        ManagedVolumeShareType? ShareType = null,
        ManagedVolumeState? State = null
    ) 
    {
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
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> List<System.String>? HostPatterns
            // GraphQL -> hostPatterns: [String!]! (scalar)
            if (this.HostPatterns != null)
            {
                 s += ind + "hostPatterns\n";

            }
            //      C# -> System.Boolean? IsDeleted
            // GraphQL -> isDeleted: Boolean! (scalar)
            if (this.IsDeleted != null)
            {
                 s += ind + "isDeleted\n";

            }
            //      C# -> System.Boolean? IsRelic
            // GraphQL -> isRelic: Boolean! (scalar)
            if (this.IsRelic != null)
            {
                 s += ind + "isRelic\n";

            }
            //      C# -> System.Boolean? IsWritable
            // GraphQL -> isWritable: Boolean! (scalar)
            if (this.IsWritable != null)
            {
                 s += ind + "isWritable\n";

            }
            //      C# -> System.Int32? NumChannels
            // GraphQL -> numChannels: Int! (scalar)
            if (this.NumChannels != null)
            {
                 s += ind + "numChannels\n";

            }
            //      C# -> System.Int32? PendingSnapshotCount
            // GraphQL -> pendingSnapshotCount: Int! (scalar)
            if (this.PendingSnapshotCount != null)
            {
                 s += ind + "pendingSnapshotCount\n";

            }
            //      C# -> System.String? SmbDomainName
            // GraphQL -> smbDomainName: String (scalar)
            if (this.SmbDomainName != null)
            {
                 s += ind + "smbDomainName\n";

            }
            //      C# -> List<System.String>? SmbValidIps
            // GraphQL -> smbValidIps: [String!]! (scalar)
            if (this.SmbValidIps != null)
            {
                 s += ind + "smbValidIps\n";

            }
            //      C# -> List<System.String>? SmbValidUsers
            // GraphQL -> smbValidUsers: [String!]! (scalar)
            if (this.SmbValidUsers != null)
            {
                 s += ind + "smbValidUsers\n";

            }
            //      C# -> System.Int32? SnapshotCount
            // GraphQL -> snapshotCount: Int! (scalar)
            if (this.SnapshotCount != null)
            {
                 s += ind + "snapshotCount\n";

            }
            //      C# -> System.String? Subnet
            // GraphQL -> subnet: String (scalar)
            if (this.Subnet != null)
            {
                 s += ind + "subnet\n";

            }
            //      C# -> System.Int64? UsedSize
            // GraphQL -> usedSize: Long! (scalar)
            if (this.UsedSize != null)
            {
                 s += ind + "usedSize\n";

            }
            //      C# -> System.Int64? VolumeSize
            // GraphQL -> volumeSize: Long! (scalar)
            if (this.VolumeSize != null)
            {
                 s += ind + "volumeSize\n";

            }
            //      C# -> List<Link>? Links
            // GraphQL -> links: [Link!]! (type)
            if (this.Links != null)
            {
                 s += ind + "links\n";

                 s += ind + "{\n" + 
                 this.Links.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ManagedVolumeExport? MainExport
            // GraphQL -> mainExport: ManagedVolumeExport (type)
            if (this.MainExport != null)
            {
                 s += ind + "mainExport\n";

                 s += ind + "{\n" + 
                 this.MainExport.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
            // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
            if (this.PendingSlaDomain != null)
            {
                 s += ind + "pendingSlaDomain\n";

                 s += ind + "{\n" + 
                 this.PendingSlaDomain.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SlaManagedVolumeDetail? SlaManagedVolumeDetails
            // GraphQL -> slaManagedVolumeDetails: SlaManagedVolumeDetail (type)
            if (this.SlaManagedVolumeDetails != null)
            {
                 s += ind + "slaManagedVolumeDetails\n";

                 s += ind + "{\n" + 
                 this.SlaManagedVolumeDetails.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CdmWorkload? Snappable
            // GraphQL -> snappable: CdmWorkload (type)
            if (this.Snappable != null)
            {
                 s += ind + "snappable\n";

                 s += ind + "{\n" + 
                 this.Snappable.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ManagedVolumeApplicationTag? ApplicationTag
            // GraphQL -> applicationTag: ManagedVolumeApplicationTag (enum)
            if (this.ApplicationTag != null)
            {
                 s += ind + "applicationTag\n";

            }
            //      C# -> CdmManagedVolumeType? MvType
            // GraphQL -> mvType: CdmManagedVolumeType (enum)
            if (this.MvType != null)
            {
                 s += ind + "mvType\n";

            }
            //      C# -> ManagedVolumeShareType? ShareType
            // GraphQL -> shareType: ManagedVolumeShareType! (enum)
            if (this.ShareType != null)
            {
                 s += ind + "shareType\n";

            }
            //      C# -> ManagedVolumeState? State
            // GraphQL -> state: ManagedVolumeState! (enum)
            if (this.State != null)
            {
                 s += ind + "state\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? HostPatterns
            // GraphQL -> hostPatterns: [String!]! (scalar)
            if (this.HostPatterns == null && Exploration.Includes(parent + ".hostPatterns$"))
            {
                this.HostPatterns = new List<System.String>();
            }
            //      C# -> System.Boolean? IsDeleted
            // GraphQL -> isDeleted: Boolean! (scalar)
            if (this.IsDeleted == null && Exploration.Includes(parent + ".isDeleted$"))
            {
                this.IsDeleted = new System.Boolean();
            }
            //      C# -> System.Boolean? IsRelic
            // GraphQL -> isRelic: Boolean! (scalar)
            if (this.IsRelic == null && Exploration.Includes(parent + ".isRelic$"))
            {
                this.IsRelic = new System.Boolean();
            }
            //      C# -> System.Boolean? IsWritable
            // GraphQL -> isWritable: Boolean! (scalar)
            if (this.IsWritable == null && Exploration.Includes(parent + ".isWritable$"))
            {
                this.IsWritable = new System.Boolean();
            }
            //      C# -> System.Int32? NumChannels
            // GraphQL -> numChannels: Int! (scalar)
            if (this.NumChannels == null && Exploration.Includes(parent + ".numChannels$"))
            {
                this.NumChannels = new System.Int32();
            }
            //      C# -> System.Int32? PendingSnapshotCount
            // GraphQL -> pendingSnapshotCount: Int! (scalar)
            if (this.PendingSnapshotCount == null && Exploration.Includes(parent + ".pendingSnapshotCount$"))
            {
                this.PendingSnapshotCount = new System.Int32();
            }
            //      C# -> System.String? SmbDomainName
            // GraphQL -> smbDomainName: String (scalar)
            if (this.SmbDomainName == null && Exploration.Includes(parent + ".smbDomainName$"))
            {
                this.SmbDomainName = new System.String("FETCH");
            }
            //      C# -> List<System.String>? SmbValidIps
            // GraphQL -> smbValidIps: [String!]! (scalar)
            if (this.SmbValidIps == null && Exploration.Includes(parent + ".smbValidIps$"))
            {
                this.SmbValidIps = new List<System.String>();
            }
            //      C# -> List<System.String>? SmbValidUsers
            // GraphQL -> smbValidUsers: [String!]! (scalar)
            if (this.SmbValidUsers == null && Exploration.Includes(parent + ".smbValidUsers$"))
            {
                this.SmbValidUsers = new List<System.String>();
            }
            //      C# -> System.Int32? SnapshotCount
            // GraphQL -> snapshotCount: Int! (scalar)
            if (this.SnapshotCount == null && Exploration.Includes(parent + ".snapshotCount$"))
            {
                this.SnapshotCount = new System.Int32();
            }
            //      C# -> System.String? Subnet
            // GraphQL -> subnet: String (scalar)
            if (this.Subnet == null && Exploration.Includes(parent + ".subnet$"))
            {
                this.Subnet = new System.String("FETCH");
            }
            //      C# -> System.Int64? UsedSize
            // GraphQL -> usedSize: Long! (scalar)
            if (this.UsedSize == null && Exploration.Includes(parent + ".usedSize$"))
            {
                this.UsedSize = new System.Int64();
            }
            //      C# -> System.Int64? VolumeSize
            // GraphQL -> volumeSize: Long! (scalar)
            if (this.VolumeSize == null && Exploration.Includes(parent + ".volumeSize$"))
            {
                this.VolumeSize = new System.Int64();
            }
            //      C# -> List<Link>? Links
            // GraphQL -> links: [Link!]! (type)
            if (this.Links == null && Exploration.Includes(parent + ".links"))
            {
                this.Links = new List<Link>();
                this.Links.ApplyExploratoryFragment(parent + ".links");
            }
            //      C# -> ManagedVolumeExport? MainExport
            // GraphQL -> mainExport: ManagedVolumeExport (type)
            if (this.MainExport == null && Exploration.Includes(parent + ".mainExport"))
            {
                this.MainExport = new ManagedVolumeExport();
                this.MainExport.ApplyExploratoryFragment(parent + ".mainExport");
            }
            //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
            // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
            if (this.PendingSlaDomain == null && Exploration.Includes(parent + ".pendingSlaDomain"))
            {
                this.PendingSlaDomain = new ManagedObjectPendingSlaInfo();
                this.PendingSlaDomain.ApplyExploratoryFragment(parent + ".pendingSlaDomain");
            }
            //      C# -> SlaManagedVolumeDetail? SlaManagedVolumeDetails
            // GraphQL -> slaManagedVolumeDetails: SlaManagedVolumeDetail (type)
            if (this.SlaManagedVolumeDetails == null && Exploration.Includes(parent + ".slaManagedVolumeDetails"))
            {
                this.SlaManagedVolumeDetails = new SlaManagedVolumeDetail();
                this.SlaManagedVolumeDetails.ApplyExploratoryFragment(parent + ".slaManagedVolumeDetails");
            }
            //      C# -> CdmWorkload? Snappable
            // GraphQL -> snappable: CdmWorkload (type)
            if (this.Snappable == null && Exploration.Includes(parent + ".snappable"))
            {
                this.Snappable = new CdmWorkload();
                this.Snappable.ApplyExploratoryFragment(parent + ".snappable");
            }
            //      C# -> ManagedVolumeApplicationTag? ApplicationTag
            // GraphQL -> applicationTag: ManagedVolumeApplicationTag (enum)
            if (this.ApplicationTag == null && Exploration.Includes(parent + ".applicationTag$"))
            {
                this.ApplicationTag = new ManagedVolumeApplicationTag();
            }
            //      C# -> CdmManagedVolumeType? MvType
            // GraphQL -> mvType: CdmManagedVolumeType (enum)
            if (this.MvType == null && Exploration.Includes(parent + ".mvType$"))
            {
                this.MvType = new CdmManagedVolumeType();
            }
            //      C# -> ManagedVolumeShareType? ShareType
            // GraphQL -> shareType: ManagedVolumeShareType! (enum)
            if (this.ShareType == null && Exploration.Includes(parent + ".shareType$"))
            {
                this.ShareType = new ManagedVolumeShareType();
            }
            //      C# -> ManagedVolumeState? State
            // GraphQL -> state: ManagedVolumeState! (enum)
            if (this.State == null && Exploration.Includes(parent + ".state$"))
            {
                this.State = new ManagedVolumeState();
            }
        }


    #endregion

    } // class UpdateManagedVolumeReply
    #endregion

    public static class ListUpdateManagedVolumeReplyExtensions
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
            this List<UpdateManagedVolumeReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<UpdateManagedVolumeReply> list, 
            String parent = "")
        {
            var item = new UpdateManagedVolumeReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types