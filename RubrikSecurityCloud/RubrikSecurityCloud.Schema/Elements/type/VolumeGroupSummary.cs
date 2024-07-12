// VolumeGroupSummary.cs
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
    #region VolumeGroupSummary
    public class VolumeGroupSummary: BaseType
    {
        #region members

        //      C# -> HostRbsConnectionStatus? RbsConnectionStatus
        // GraphQL -> rbsConnectionStatus: HostRbsConnectionStatus (enum)
        [JsonProperty("rbsConnectionStatus")]
        public HostRbsConnectionStatus? RbsConnectionStatus { get; set; }

        //      C# -> System.Boolean? ForceFull
        // GraphQL -> forceFull: Boolean (scalar)
        [JsonProperty("forceFull")]
        public System.Boolean? ForceFull { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsPaused
        // GraphQL -> isPaused: Boolean (scalar)
        [JsonProperty("isPaused")]
        public System.Boolean? IsPaused { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Boolean? NeedsMigration
        // GraphQL -> needsMigration: Boolean (scalar)
        [JsonProperty("needsMigration")]
        public System.Boolean? NeedsMigration { get; set; }

        //      C# -> System.String? OperatingSystem
        // GraphQL -> operatingSystem: String (scalar)
        [JsonProperty("operatingSystem")]
        public System.String? OperatingSystem { get; set; }

        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        [JsonProperty("snappable")]
        public CdmWorkload? Snappable { get; set; }

        //      C# -> List<HostVolumeSummary>? Volumes
        // GraphQL -> volumes: [HostVolumeSummary!]! (type)
        [JsonProperty("volumes")]
        public List<HostVolumeSummary>? Volumes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VolumeGroupSummary";
    }

    public VolumeGroupSummary Set(
        HostRbsConnectionStatus? RbsConnectionStatus = null,
        System.Boolean? ForceFull = null,
        System.String? HostId = null,
        System.String? Hostname = null,
        System.String? Id = null,
        System.Boolean? IsPaused = null,
        System.Boolean? IsRelic = null,
        System.String? Name = null,
        System.Boolean? NeedsMigration = null,
        System.String? OperatingSystem = null,
        CdmWorkload? Snappable = null,
        List<HostVolumeSummary>? Volumes = null
    ) 
    {
        if ( RbsConnectionStatus != null ) {
            this.RbsConnectionStatus = RbsConnectionStatus;
        }
        if ( ForceFull != null ) {
            this.ForceFull = ForceFull;
        }
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsPaused != null ) {
            this.IsPaused = IsPaused;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NeedsMigration != null ) {
            this.NeedsMigration = NeedsMigration;
        }
        if ( OperatingSystem != null ) {
            this.OperatingSystem = OperatingSystem;
        }
        if ( Snappable != null ) {
            this.Snappable = Snappable;
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
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> HostRbsConnectionStatus? RbsConnectionStatus
        // GraphQL -> rbsConnectionStatus: HostRbsConnectionStatus (enum)
        if (this.RbsConnectionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rbsConnectionStatus\n" ;
            } else {
                s += ind + "rbsConnectionStatus\n" ;
            }
        }
        //      C# -> System.Boolean? ForceFull
        // GraphQL -> forceFull: Boolean (scalar)
        if (this.ForceFull != null) {
            if (conf.Flat) {
                s += conf.Prefix + "forceFull\n" ;
            } else {
                s += ind + "forceFull\n" ;
            }
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        if (this.HostId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostId\n" ;
            } else {
                s += ind + "hostId\n" ;
            }
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String (scalar)
        if (this.Hostname != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostname\n" ;
            } else {
                s += ind + "hostname\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsPaused
        // GraphQL -> isPaused: Boolean (scalar)
        if (this.IsPaused != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPaused\n" ;
            } else {
                s += ind + "isPaused\n" ;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.Boolean? NeedsMigration
        // GraphQL -> needsMigration: Boolean (scalar)
        if (this.NeedsMigration != null) {
            if (conf.Flat) {
                s += conf.Prefix + "needsMigration\n" ;
            } else {
                s += ind + "needsMigration\n" ;
            }
        }
        //      C# -> System.String? OperatingSystem
        // GraphQL -> operatingSystem: String (scalar)
        if (this.OperatingSystem != null) {
            if (conf.Flat) {
                s += conf.Prefix + "operatingSystem\n" ;
            } else {
                s += ind + "operatingSystem\n" ;
            }
        }
        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        if (this.Snappable != null) {
            var fspec = this.Snappable.AsFieldSpec(conf.Child("snappable"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snappable" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<HostVolumeSummary>? Volumes
        // GraphQL -> volumes: [HostVolumeSummary!]! (type)
        if (this.Volumes != null) {
            var fspec = this.Volumes.AsFieldSpec(conf.Child("volumes"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "volumes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> HostRbsConnectionStatus? RbsConnectionStatus
        // GraphQL -> rbsConnectionStatus: HostRbsConnectionStatus (enum)
        if (ec.Includes("rbsConnectionStatus",true))
        {
            if(this.RbsConnectionStatus == null) {

                this.RbsConnectionStatus = new HostRbsConnectionStatus();

            } else {


            }
        }
        else if (this.RbsConnectionStatus != null && ec.Excludes("rbsConnectionStatus",true))
        {
            this.RbsConnectionStatus = null;
        }
        //      C# -> System.Boolean? ForceFull
        // GraphQL -> forceFull: Boolean (scalar)
        if (ec.Includes("forceFull",true))
        {
            if(this.ForceFull == null) {

                this.ForceFull = true;

            } else {


            }
        }
        else if (this.ForceFull != null && ec.Excludes("forceFull",true))
        {
            this.ForceFull = null;
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        if (ec.Includes("hostId",true))
        {
            if(this.HostId == null) {

                this.HostId = "FETCH";

            } else {


            }
        }
        else if (this.HostId != null && ec.Excludes("hostId",true))
        {
            this.HostId = null;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String (scalar)
        if (ec.Includes("hostname",true))
        {
            if(this.Hostname == null) {

                this.Hostname = "FETCH";

            } else {


            }
        }
        else if (this.Hostname != null && ec.Excludes("hostname",true))
        {
            this.Hostname = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsPaused
        // GraphQL -> isPaused: Boolean (scalar)
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.Boolean? NeedsMigration
        // GraphQL -> needsMigration: Boolean (scalar)
        if (ec.Includes("needsMigration",true))
        {
            if(this.NeedsMigration == null) {

                this.NeedsMigration = true;

            } else {


            }
        }
        else if (this.NeedsMigration != null && ec.Excludes("needsMigration",true))
        {
            this.NeedsMigration = null;
        }
        //      C# -> System.String? OperatingSystem
        // GraphQL -> operatingSystem: String (scalar)
        if (ec.Includes("operatingSystem",true))
        {
            if(this.OperatingSystem == null) {

                this.OperatingSystem = "FETCH";

            } else {


            }
        }
        else if (this.OperatingSystem != null && ec.Excludes("operatingSystem",true))
        {
            this.OperatingSystem = null;
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

    } // class VolumeGroupSummary
    
    #endregion

    public static class ListVolumeGroupSummaryExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<VolumeGroupSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VolumeGroupSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VolumeGroupSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VolumeGroupSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VolumeGroupSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types