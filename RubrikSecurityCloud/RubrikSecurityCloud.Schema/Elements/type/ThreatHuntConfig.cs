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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region ThreatHuntConfig
    public class ThreatHuntConfig: BaseType
    {
        #region members

        //      C# -> List<CdmHierarchySnappableNew>? Objects
        // GraphQL -> objects: [CdmHierarchySnappableNew!]! (interface)
        [JsonProperty("objects")]
        public RscInterface<CdmHierarchySnappableNew> Objects { get; set; }

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

    public override string GetGqlTypeName() {
        return "ThreatHuntConfig";
    }

    public ThreatHuntConfig Set(
        RscInterface<CdmHierarchySnappableNew> Objects = null,
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<CdmHierarchySnappableNew>? Objects
        // GraphQL -> objects: [CdmHierarchySnappableNew!]! (interface)
        if (this.Objects != null) {
            var fspec = this.Objects.AsFieldSpec(conf.Child("objects"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objects" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> System.Int32? MaxMatchesPerSnapshot
        // GraphQL -> maxMatchesPerSnapshot: Int (scalar)
        if (this.MaxMatchesPerSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "maxMatchesPerSnapshot\n" ;
            } else {
                s += ind + "maxMatchesPerSnapshot\n" ;
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
        //      C# -> System.String? Notes
        // GraphQL -> notes: String! (scalar)
        if (this.Notes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "notes\n" ;
            } else {
                s += ind + "notes\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldTrustFilesystemTimeInfo
        // GraphQL -> shouldTrustFilesystemTimeInfo: Boolean! (scalar)
        if (this.ShouldTrustFilesystemTimeInfo != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldTrustFilesystemTimeInfo\n" ;
            } else {
                s += ind + "shouldTrustFilesystemTimeInfo\n" ;
            }
        }
        //      C# -> MalwareScanFileCriteria? FileScanCriteria
        // GraphQL -> fileScanCriteria: MalwareScanFileCriteria (type)
        if (this.FileScanCriteria != null) {
            var fspec = this.FileScanCriteria.AsFieldSpec(conf.Child("fileScanCriteria"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "fileScanCriteria" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<IndicatorOfCompromise>? IndicatorsOfCompromise
        // GraphQL -> indicatorsOfCompromise: [IndicatorOfCompromise!]! (type)
        if (this.IndicatorsOfCompromise != null) {
            var fspec = this.IndicatorsOfCompromise.AsFieldSpec(conf.Child("indicatorsOfCompromise"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "indicatorsOfCompromise" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RequestedMatchDetails? RequestedMatchDetails
        // GraphQL -> requestedMatchDetails: RequestedMatchDetails (type)
        if (this.RequestedMatchDetails != null) {
            var fspec = this.RequestedMatchDetails.AsFieldSpec(conf.Child("requestedMatchDetails"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "requestedMatchDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MalwareScanSnapshotLimit? SnapshotScanLimit
        // GraphQL -> snapshotScanLimit: MalwareScanSnapshotLimit (type)
        if (this.SnapshotScanLimit != null) {
            var fspec = this.SnapshotScanLimit.AsFieldSpec(conf.Child("snapshotScanLimit"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotScanLimit" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<CdmHierarchySnappableNew>? Objects
        // GraphQL -> objects: [CdmHierarchySnappableNew!]! (interface)
        if (ec.Includes("objects",false))
        {
            if(this.Objects == null) {

                this.Objects = new RscInterface<CdmHierarchySnappableNew>();
                this.Objects.ApplyExploratoryFieldSpec(ec.NewChild("objects"));

            } else {

                this.Objects.ApplyExploratoryFieldSpec(ec.NewChild("objects"));

            }
        }
        else if (this.Objects != null && ec.Excludes("objects",false))
        {
            this.Objects = null;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
        }
        //      C# -> System.Int32? MaxMatchesPerSnapshot
        // GraphQL -> maxMatchesPerSnapshot: Int (scalar)
        if (ec.Includes("maxMatchesPerSnapshot",true))
        {
            if(this.MaxMatchesPerSnapshot == null) {

                this.MaxMatchesPerSnapshot = Int32.MinValue;

            } else {


            }
        }
        else if (this.MaxMatchesPerSnapshot != null && ec.Excludes("maxMatchesPerSnapshot",true))
        {
            this.MaxMatchesPerSnapshot = null;
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
        //      C# -> System.String? Notes
        // GraphQL -> notes: String! (scalar)
        if (ec.Includes("notes",true))
        {
            if(this.Notes == null) {

                this.Notes = "FETCH";

            } else {


            }
        }
        else if (this.Notes != null && ec.Excludes("notes",true))
        {
            this.Notes = null;
        }
        //      C# -> System.Boolean? ShouldTrustFilesystemTimeInfo
        // GraphQL -> shouldTrustFilesystemTimeInfo: Boolean! (scalar)
        if (ec.Includes("shouldTrustFilesystemTimeInfo",true))
        {
            if(this.ShouldTrustFilesystemTimeInfo == null) {

                this.ShouldTrustFilesystemTimeInfo = true;

            } else {


            }
        }
        else if (this.ShouldTrustFilesystemTimeInfo != null && ec.Excludes("shouldTrustFilesystemTimeInfo",true))
        {
            this.ShouldTrustFilesystemTimeInfo = null;
        }
        //      C# -> MalwareScanFileCriteria? FileScanCriteria
        // GraphQL -> fileScanCriteria: MalwareScanFileCriteria (type)
        if (ec.Includes("fileScanCriteria",false))
        {
            if(this.FileScanCriteria == null) {

                this.FileScanCriteria = new MalwareScanFileCriteria();
                this.FileScanCriteria.ApplyExploratoryFieldSpec(ec.NewChild("fileScanCriteria"));

            } else {

                this.FileScanCriteria.ApplyExploratoryFieldSpec(ec.NewChild("fileScanCriteria"));

            }
        }
        else if (this.FileScanCriteria != null && ec.Excludes("fileScanCriteria",false))
        {
            this.FileScanCriteria = null;
        }
        //      C# -> List<IndicatorOfCompromise>? IndicatorsOfCompromise
        // GraphQL -> indicatorsOfCompromise: [IndicatorOfCompromise!]! (type)
        if (ec.Includes("indicatorsOfCompromise",false))
        {
            if(this.IndicatorsOfCompromise == null) {

                this.IndicatorsOfCompromise = new List<IndicatorOfCompromise>();
                this.IndicatorsOfCompromise.ApplyExploratoryFieldSpec(ec.NewChild("indicatorsOfCompromise"));

            } else {

                this.IndicatorsOfCompromise.ApplyExploratoryFieldSpec(ec.NewChild("indicatorsOfCompromise"));

            }
        }
        else if (this.IndicatorsOfCompromise != null && ec.Excludes("indicatorsOfCompromise",false))
        {
            this.IndicatorsOfCompromise = null;
        }
        //      C# -> RequestedMatchDetails? RequestedMatchDetails
        // GraphQL -> requestedMatchDetails: RequestedMatchDetails (type)
        if (ec.Includes("requestedMatchDetails",false))
        {
            if(this.RequestedMatchDetails == null) {

                this.RequestedMatchDetails = new RequestedMatchDetails();
                this.RequestedMatchDetails.ApplyExploratoryFieldSpec(ec.NewChild("requestedMatchDetails"));

            } else {

                this.RequestedMatchDetails.ApplyExploratoryFieldSpec(ec.NewChild("requestedMatchDetails"));

            }
        }
        else if (this.RequestedMatchDetails != null && ec.Excludes("requestedMatchDetails",false))
        {
            this.RequestedMatchDetails = null;
        }
        //      C# -> MalwareScanSnapshotLimit? SnapshotScanLimit
        // GraphQL -> snapshotScanLimit: MalwareScanSnapshotLimit (type)
        if (ec.Includes("snapshotScanLimit",false))
        {
            if(this.SnapshotScanLimit == null) {

                this.SnapshotScanLimit = new MalwareScanSnapshotLimit();
                this.SnapshotScanLimit.ApplyExploratoryFieldSpec(ec.NewChild("snapshotScanLimit"));

            } else {

                this.SnapshotScanLimit.ApplyExploratoryFieldSpec(ec.NewChild("snapshotScanLimit"));

            }
        }
        else if (this.SnapshotScanLimit != null && ec.Excludes("snapshotScanLimit",false))
        {
            this.SnapshotScanLimit = null;
        }
    }


    #endregion

    } // class ThreatHuntConfig
    
    #endregion

    public static class ListThreatHuntConfigExtensions
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
            this List<ThreatHuntConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ThreatHuntConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ThreatHuntConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatHuntConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatHuntConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types