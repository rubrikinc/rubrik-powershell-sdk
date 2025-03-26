// UpdateVolumeGroupReply.cs
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
    #region UpdateVolumeGroupReply
    public class UpdateVolumeGroupReply: BaseType
    {
        #region members

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String! (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> System.Boolean? IsPaused
        // GraphQL -> isPaused: Boolean! (scalar)
        [JsonProperty("isPaused")]
        public System.Boolean? IsPaused { get; set; }

        //      C# -> BlackoutWindowResponseInfo? BlackoutWindowResponseInfo
        // GraphQL -> blackoutWindowResponseInfo: BlackoutWindowResponseInfo (type)
        [JsonProperty("blackoutWindowResponseInfo")]
        public BlackoutWindowResponseInfo? BlackoutWindowResponseInfo { get; set; }

        //      C# -> List<HostVolumeSummary>? ExcludedVolumes
        // GraphQL -> excludedVolumes: [HostVolumeSummary!]! (type)
        [JsonProperty("excludedVolumes")]
        public List<HostVolumeSummary>? ExcludedVolumes { get; set; }

        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        [JsonProperty("pendingSlaDomain")]
        public ManagedObjectPendingSlaInfo? PendingSlaDomain { get; set; }

        //      C# -> VolumeGroupSummary? VolumeGroupSummary
        // GraphQL -> volumeGroupSummary: VolumeGroupSummary (type)
        [JsonProperty("volumeGroupSummary")]
        public VolumeGroupSummary? VolumeGroupSummary { get; set; }

        //      C# -> List<HostVolumeSummary>? Volumes
        // GraphQL -> volumes: [HostVolumeSummary!]! (type)
        [JsonProperty("volumes")]
        public List<HostVolumeSummary>? Volumes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateVolumeGroupReply";
    }

    public UpdateVolumeGroupReply Set(
        System.String? ConfiguredSlaDomainId = null,
        System.Boolean? IsPaused = null,
        BlackoutWindowResponseInfo? BlackoutWindowResponseInfo = null,
        List<HostVolumeSummary>? ExcludedVolumes = null,
        ManagedObjectPendingSlaInfo? PendingSlaDomain = null,
        VolumeGroupSummary? VolumeGroupSummary = null,
        List<HostVolumeSummary>? Volumes = null
    ) 
    {
        if ( ConfiguredSlaDomainId != null ) {
            this.ConfiguredSlaDomainId = ConfiguredSlaDomainId;
        }
        if ( IsPaused != null ) {
            this.IsPaused = IsPaused;
        }
        if ( BlackoutWindowResponseInfo != null ) {
            this.BlackoutWindowResponseInfo = BlackoutWindowResponseInfo;
        }
        if ( ExcludedVolumes != null ) {
            this.ExcludedVolumes = ExcludedVolumes;
        }
        if ( PendingSlaDomain != null ) {
            this.PendingSlaDomain = PendingSlaDomain;
        }
        if ( VolumeGroupSummary != null ) {
            this.VolumeGroupSummary = VolumeGroupSummary;
        }
        if ( Volumes != null ) {
            this.Volumes = Volumes;
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
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String! (scalar)
        if (this.ConfiguredSlaDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configuredSlaDomainId\n" ;
            } else {
                s += ind + "configuredSlaDomainId\n" ;
            }
        }
        //      C# -> System.Boolean? IsPaused
        // GraphQL -> isPaused: Boolean! (scalar)
        if (this.IsPaused != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPaused\n" ;
            } else {
                s += ind + "isPaused\n" ;
            }
        }
        //      C# -> BlackoutWindowResponseInfo? BlackoutWindowResponseInfo
        // GraphQL -> blackoutWindowResponseInfo: BlackoutWindowResponseInfo (type)
        if (this.BlackoutWindowResponseInfo != null) {
            var fspec = this.BlackoutWindowResponseInfo.AsFieldSpec(conf.Child("blackoutWindowResponseInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "blackoutWindowResponseInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<HostVolumeSummary>? ExcludedVolumes
        // GraphQL -> excludedVolumes: [HostVolumeSummary!]! (type)
        if (this.ExcludedVolumes != null) {
            var fspec = this.ExcludedVolumes.AsFieldSpec(conf.Child("excludedVolumes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "excludedVolumes" + " " + "{\n" + fspec + ind + "}\n" ;
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
                    s += ind + "pendingSlaDomain" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> VolumeGroupSummary? VolumeGroupSummary
        // GraphQL -> volumeGroupSummary: VolumeGroupSummary (type)
        if (this.VolumeGroupSummary != null) {
            var fspec = this.VolumeGroupSummary.AsFieldSpec(conf.Child("volumeGroupSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "volumeGroupSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<HostVolumeSummary>? Volumes
        // GraphQL -> volumes: [HostVolumeSummary!]! (type)
        if (this.Volumes != null) {
            var fspec = this.Volumes.AsFieldSpec(conf.Child("volumes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "volumes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String! (scalar)
        if (ec.Includes("configuredSlaDomainId",true))
        {
            if(this.ConfiguredSlaDomainId == null) {

                this.ConfiguredSlaDomainId = "FETCH";

            } else {


            }
        }
        else if (this.ConfiguredSlaDomainId != null && ec.Excludes("configuredSlaDomainId",true))
        {
            this.ConfiguredSlaDomainId = null;
        }
        //      C# -> System.Boolean? IsPaused
        // GraphQL -> isPaused: Boolean! (scalar)
        if (ec.Includes("isPaused",true))
        {
            if(this.IsPaused == null) {

                this.IsPaused = true;

            } else {


            }
        }
        else if (this.IsPaused != null && ec.Excludes("isPaused",true))
        {
            this.IsPaused = null;
        }
        //      C# -> BlackoutWindowResponseInfo? BlackoutWindowResponseInfo
        // GraphQL -> blackoutWindowResponseInfo: BlackoutWindowResponseInfo (type)
        if (ec.Includes("blackoutWindowResponseInfo",false))
        {
            if(this.BlackoutWindowResponseInfo == null) {

                this.BlackoutWindowResponseInfo = new BlackoutWindowResponseInfo();
                this.BlackoutWindowResponseInfo.ApplyExploratoryFieldSpec(ec.NewChild("blackoutWindowResponseInfo"));

            } else {

                this.BlackoutWindowResponseInfo.ApplyExploratoryFieldSpec(ec.NewChild("blackoutWindowResponseInfo"));

            }
        }
        else if (this.BlackoutWindowResponseInfo != null && ec.Excludes("blackoutWindowResponseInfo",false))
        {
            this.BlackoutWindowResponseInfo = null;
        }
        //      C# -> List<HostVolumeSummary>? ExcludedVolumes
        // GraphQL -> excludedVolumes: [HostVolumeSummary!]! (type)
        if (ec.Includes("excludedVolumes",false))
        {
            if(this.ExcludedVolumes == null) {

                this.ExcludedVolumes = new List<HostVolumeSummary>();
                this.ExcludedVolumes.ApplyExploratoryFieldSpec(ec.NewChild("excludedVolumes"));

            } else {

                this.ExcludedVolumes.ApplyExploratoryFieldSpec(ec.NewChild("excludedVolumes"));

            }
        }
        else if (this.ExcludedVolumes != null && ec.Excludes("excludedVolumes",false))
        {
            this.ExcludedVolumes = null;
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
        //      C# -> VolumeGroupSummary? VolumeGroupSummary
        // GraphQL -> volumeGroupSummary: VolumeGroupSummary (type)
        if (ec.Includes("volumeGroupSummary",false))
        {
            if(this.VolumeGroupSummary == null) {

                this.VolumeGroupSummary = new VolumeGroupSummary();
                this.VolumeGroupSummary.ApplyExploratoryFieldSpec(ec.NewChild("volumeGroupSummary"));

            } else {

                this.VolumeGroupSummary.ApplyExploratoryFieldSpec(ec.NewChild("volumeGroupSummary"));

            }
        }
        else if (this.VolumeGroupSummary != null && ec.Excludes("volumeGroupSummary",false))
        {
            this.VolumeGroupSummary = null;
        }
        //      C# -> List<HostVolumeSummary>? Volumes
        // GraphQL -> volumes: [HostVolumeSummary!]! (type)
        if (ec.Includes("volumes",false))
        {
            if(this.Volumes == null) {

                this.Volumes = new List<HostVolumeSummary>();
                this.Volumes.ApplyExploratoryFieldSpec(ec.NewChild("volumes"));

            } else {

                this.Volumes.ApplyExploratoryFieldSpec(ec.NewChild("volumes"));

            }
        }
        else if (this.Volumes != null && ec.Excludes("volumes",false))
        {
            this.Volumes = null;
        }
    }


    #endregion

    } // class UpdateVolumeGroupReply
    
    #endregion

    public static class ListUpdateVolumeGroupReplyExtensions
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
            this List<UpdateVolumeGroupReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UpdateVolumeGroupReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UpdateVolumeGroupReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateVolumeGroupReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpdateVolumeGroupReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types