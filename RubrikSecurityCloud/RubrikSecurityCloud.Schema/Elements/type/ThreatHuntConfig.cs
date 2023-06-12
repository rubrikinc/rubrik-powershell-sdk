// ThreatHuntConfig.cs
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
    #region ThreatHuntConfig
    public class ThreatHuntConfig: BaseType
    {
        #region members

        //      C# -> List<CdmHierarchySnappableNew>? Objects
        // GraphQL -> objects: [CdmHierarchySnappableNew!]! (interface)
        [JsonProperty("objects")]
        public List<CdmHierarchySnappableNew>? Objects { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Int32? MaxMatchesPerSnapshot
        // GraphQL -> maxMatchesPerSnapshot: Int (scalar)
        [JsonProperty("maxMatchesPerSnapshot")]
        public System.Int32? MaxMatchesPerSnapshot { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Notes
        // GraphQL -> notes: String! (scalar)
        [JsonProperty("notes")]
        public System.String? Notes { get; set; }

        //      C# -> System.Boolean? ShouldTrustFilesystemTimeInfo
        // GraphQL -> shouldTrustFilesystemTimeInfo: Boolean! (scalar)
        [JsonProperty("shouldTrustFilesystemTimeInfo")]
        public System.Boolean? ShouldTrustFilesystemTimeInfo { get; set; }

        //      C# -> MalwareScanFileCriteria? FileScanCriteria
        // GraphQL -> fileScanCriteria: MalwareScanFileCriteria (type)
        [JsonProperty("fileScanCriteria")]
        public MalwareScanFileCriteria? FileScanCriteria { get; set; }

        //      C# -> List<IndicatorOfCompromise>? IndicatorsOfCompromise
        // GraphQL -> indicatorsOfCompromise: [IndicatorOfCompromise!]! (type)
        [JsonProperty("indicatorsOfCompromise")]
        public List<IndicatorOfCompromise>? IndicatorsOfCompromise { get; set; }

        //      C# -> RequestedMatchDetails? RequestedMatchDetails
        // GraphQL -> requestedMatchDetails: RequestedMatchDetails (type)
        [JsonProperty("requestedMatchDetails")]
        public RequestedMatchDetails? RequestedMatchDetails { get; set; }

        //      C# -> MalwareScanSnapshotLimit? SnapshotScanLimit
        // GraphQL -> snapshotScanLimit: MalwareScanSnapshotLimit (type)
        [JsonProperty("snapshotScanLimit")]
        public MalwareScanSnapshotLimit? SnapshotScanLimit { get; set; }


        #endregion

    #region methods

    public ThreatHuntConfig Set(
        List<CdmHierarchySnappableNew>? Objects = null,
        System.String? ClusterUuid = null,
        System.Int32? MaxMatchesPerSnapshot = null,
        System.String? Name = null,
        System.String? Notes = null,
        System.Boolean? ShouldTrustFilesystemTimeInfo = null,
        MalwareScanFileCriteria? FileScanCriteria = null,
        List<IndicatorOfCompromise>? IndicatorsOfCompromise = null,
        RequestedMatchDetails? RequestedMatchDetails = null,
        MalwareScanSnapshotLimit? SnapshotScanLimit = null
    ) 
    {
        if ( Objects != null ) {
            this.Objects = Objects;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( MaxMatchesPerSnapshot != null ) {
            this.MaxMatchesPerSnapshot = MaxMatchesPerSnapshot;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Notes != null ) {
            this.Notes = Notes;
        }
        if ( ShouldTrustFilesystemTimeInfo != null ) {
            this.ShouldTrustFilesystemTimeInfo = ShouldTrustFilesystemTimeInfo;
        }
        if ( FileScanCriteria != null ) {
            this.FileScanCriteria = FileScanCriteria;
        }
        if ( IndicatorsOfCompromise != null ) {
            this.IndicatorsOfCompromise = IndicatorsOfCompromise;
        }
        if ( RequestedMatchDetails != null ) {
            this.RequestedMatchDetails = RequestedMatchDetails;
        }
        if ( SnapshotScanLimit != null ) {
            this.SnapshotScanLimit = SnapshotScanLimit;
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
        //      C# -> List<CdmHierarchySnappableNew>? Objects
        // GraphQL -> objects: [CdmHierarchySnappableNew!]! (interface)
        if (this.Objects != null) {
                var fspec = this.Objects.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "objects {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> System.Int32? MaxMatchesPerSnapshot
        // GraphQL -> maxMatchesPerSnapshot: Int (scalar)
        if (this.MaxMatchesPerSnapshot != null) {
            s += ind + "maxMatchesPerSnapshot\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? Notes
        // GraphQL -> notes: String! (scalar)
        if (this.Notes != null) {
            s += ind + "notes\n" ;
        }
        //      C# -> System.Boolean? ShouldTrustFilesystemTimeInfo
        // GraphQL -> shouldTrustFilesystemTimeInfo: Boolean! (scalar)
        if (this.ShouldTrustFilesystemTimeInfo != null) {
            s += ind + "shouldTrustFilesystemTimeInfo\n" ;
        }
        //      C# -> MalwareScanFileCriteria? FileScanCriteria
        // GraphQL -> fileScanCriteria: MalwareScanFileCriteria (type)
        if (this.FileScanCriteria != null) {
            var fspec = this.FileScanCriteria.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "fileScanCriteria {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<IndicatorOfCompromise>? IndicatorsOfCompromise
        // GraphQL -> indicatorsOfCompromise: [IndicatorOfCompromise!]! (type)
        if (this.IndicatorsOfCompromise != null) {
            var fspec = this.IndicatorsOfCompromise.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "indicatorsOfCompromise {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> RequestedMatchDetails? RequestedMatchDetails
        // GraphQL -> requestedMatchDetails: RequestedMatchDetails (type)
        if (this.RequestedMatchDetails != null) {
            var fspec = this.RequestedMatchDetails.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "requestedMatchDetails {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> MalwareScanSnapshotLimit? SnapshotScanLimit
        // GraphQL -> snapshotScanLimit: MalwareScanSnapshotLimit (type)
        if (this.SnapshotScanLimit != null) {
            var fspec = this.SnapshotScanLimit.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotScanLimit {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<CdmHierarchySnappableNew>? Objects
        // GraphQL -> objects: [CdmHierarchySnappableNew!]! (interface)
        if (this.Objects == null && Exploration.Includes(parent + ".objects"))
        {
            this.Objects = new List<CdmHierarchySnappableNew>();
            this.Objects.ApplyExploratoryFieldSpec(parent + ".objects");
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> System.Int32? MaxMatchesPerSnapshot
        // GraphQL -> maxMatchesPerSnapshot: Int (scalar)
        if (this.MaxMatchesPerSnapshot == null && Exploration.Includes(parent + ".maxMatchesPerSnapshot", true))
        {
            this.MaxMatchesPerSnapshot = Int32.MinValue;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? Notes
        // GraphQL -> notes: String! (scalar)
        if (this.Notes == null && Exploration.Includes(parent + ".notes", true))
        {
            this.Notes = "FETCH";
        }
        //      C# -> System.Boolean? ShouldTrustFilesystemTimeInfo
        // GraphQL -> shouldTrustFilesystemTimeInfo: Boolean! (scalar)
        if (this.ShouldTrustFilesystemTimeInfo == null && Exploration.Includes(parent + ".shouldTrustFilesystemTimeInfo", true))
        {
            this.ShouldTrustFilesystemTimeInfo = true;
        }
        //      C# -> MalwareScanFileCriteria? FileScanCriteria
        // GraphQL -> fileScanCriteria: MalwareScanFileCriteria (type)
        if (this.FileScanCriteria == null && Exploration.Includes(parent + ".fileScanCriteria"))
        {
            this.FileScanCriteria = new MalwareScanFileCriteria();
            this.FileScanCriteria.ApplyExploratoryFieldSpec(parent + ".fileScanCriteria");
        }
        //      C# -> List<IndicatorOfCompromise>? IndicatorsOfCompromise
        // GraphQL -> indicatorsOfCompromise: [IndicatorOfCompromise!]! (type)
        if (this.IndicatorsOfCompromise == null && Exploration.Includes(parent + ".indicatorsOfCompromise"))
        {
            this.IndicatorsOfCompromise = new List<IndicatorOfCompromise>();
            this.IndicatorsOfCompromise.ApplyExploratoryFieldSpec(parent + ".indicatorsOfCompromise");
        }
        //      C# -> RequestedMatchDetails? RequestedMatchDetails
        // GraphQL -> requestedMatchDetails: RequestedMatchDetails (type)
        if (this.RequestedMatchDetails == null && Exploration.Includes(parent + ".requestedMatchDetails"))
        {
            this.RequestedMatchDetails = new RequestedMatchDetails();
            this.RequestedMatchDetails.ApplyExploratoryFieldSpec(parent + ".requestedMatchDetails");
        }
        //      C# -> MalwareScanSnapshotLimit? SnapshotScanLimit
        // GraphQL -> snapshotScanLimit: MalwareScanSnapshotLimit (type)
        if (this.SnapshotScanLimit == null && Exploration.Includes(parent + ".snapshotScanLimit"))
        {
            this.SnapshotScanLimit = new MalwareScanSnapshotLimit();
            this.SnapshotScanLimit.ApplyExploratoryFieldSpec(parent + ".snapshotScanLimit");
        }
    }


    #endregion

    } // class ThreatHuntConfig
    
    #endregion

    public static class ListThreatHuntConfigExtensions
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
            this List<ThreatHuntConfig> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ThreatHuntConfig> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatHuntConfig());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types