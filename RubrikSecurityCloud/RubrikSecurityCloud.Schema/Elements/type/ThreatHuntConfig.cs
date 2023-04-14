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

namespace Rubrik.SecurityCloud.Types
{
    #region ThreatHuntConfig
    public class ThreatHuntConfig: IFragment
    {
        #region members
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

        //      C# -> List<CdmHierarchySnappableNew>? Objects
        // GraphQL -> objects: [CdmHierarchySnappableNew!]! (interface)
        [JsonProperty("objects")]
        public List<CdmHierarchySnappableNew>? Objects { get; set; }

        #endregion

    #region methods

    public ThreatHuntConfig Set(
        System.String? ClusterUuid = null,
        System.Int32? MaxMatchesPerSnapshot = null,
        System.String? Name = null,
        System.String? Notes = null,
        System.Boolean? ShouldTrustFilesystemTimeInfo = null,
        MalwareScanFileCriteria? FileScanCriteria = null,
        List<IndicatorOfCompromise>? IndicatorsOfCompromise = null,
        RequestedMatchDetails? RequestedMatchDetails = null,
        MalwareScanSnapshotLimit? SnapshotScanLimit = null,
        List<CdmHierarchySnappableNew>? Objects = null
    ) 
    {
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
        if ( Objects != null ) {
            this.Objects = Objects;
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
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: String! (scalar)
            if (this.ClusterUuid != null)
            {
                 s += ind + "clusterUuid\n";

            }
            //      C# -> System.Int32? MaxMatchesPerSnapshot
            // GraphQL -> maxMatchesPerSnapshot: Int (scalar)
            if (this.MaxMatchesPerSnapshot != null)
            {
                 s += ind + "maxMatchesPerSnapshot\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? Notes
            // GraphQL -> notes: String! (scalar)
            if (this.Notes != null)
            {
                 s += ind + "notes\n";

            }
            //      C# -> System.Boolean? ShouldTrustFilesystemTimeInfo
            // GraphQL -> shouldTrustFilesystemTimeInfo: Boolean! (scalar)
            if (this.ShouldTrustFilesystemTimeInfo != null)
            {
                 s += ind + "shouldTrustFilesystemTimeInfo\n";

            }
            //      C# -> MalwareScanFileCriteria? FileScanCriteria
            // GraphQL -> fileScanCriteria: MalwareScanFileCriteria (type)
            if (this.FileScanCriteria != null)
            {
                 s += ind + "fileScanCriteria\n";

                 s += ind + "{\n" + 
                 this.FileScanCriteria.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<IndicatorOfCompromise>? IndicatorsOfCompromise
            // GraphQL -> indicatorsOfCompromise: [IndicatorOfCompromise!]! (type)
            if (this.IndicatorsOfCompromise != null)
            {
                 s += ind + "indicatorsOfCompromise\n";

                 s += ind + "{\n" + 
                 this.IndicatorsOfCompromise.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> RequestedMatchDetails? RequestedMatchDetails
            // GraphQL -> requestedMatchDetails: RequestedMatchDetails (type)
            if (this.RequestedMatchDetails != null)
            {
                 s += ind + "requestedMatchDetails\n";

                 s += ind + "{\n" + 
                 this.RequestedMatchDetails.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> MalwareScanSnapshotLimit? SnapshotScanLimit
            // GraphQL -> snapshotScanLimit: MalwareScanSnapshotLimit (type)
            if (this.SnapshotScanLimit != null)
            {
                 s += ind + "snapshotScanLimit\n";

                 s += ind + "{\n" + 
                 this.SnapshotScanLimit.AsFragment(indent+1) + 
                 ind + "}\n";
            }
                        //      C# -> List<CdmHierarchySnappableNew>? Objects
            // GraphQL -> objects: [CdmHierarchySnappableNew!]! (interface)
            if (this.Objects != null)
            {
                s += ind + "objects\n";
                s += ind + "{\n";

                s += this.Objects.AsFragment(indent+1) +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: String! (scalar)
            if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid$"))
            {
                this.ClusterUuid = new System.String("FETCH");
            }
            //      C# -> System.Int32? MaxMatchesPerSnapshot
            // GraphQL -> maxMatchesPerSnapshot: Int (scalar)
            if (this.MaxMatchesPerSnapshot == null && Exploration.Includes(parent + ".maxMatchesPerSnapshot$"))
            {
                this.MaxMatchesPerSnapshot = new System.Int32();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? Notes
            // GraphQL -> notes: String! (scalar)
            if (this.Notes == null && Exploration.Includes(parent + ".notes$"))
            {
                this.Notes = new System.String("FETCH");
            }
            //      C# -> System.Boolean? ShouldTrustFilesystemTimeInfo
            // GraphQL -> shouldTrustFilesystemTimeInfo: Boolean! (scalar)
            if (this.ShouldTrustFilesystemTimeInfo == null && Exploration.Includes(parent + ".shouldTrustFilesystemTimeInfo$"))
            {
                this.ShouldTrustFilesystemTimeInfo = new System.Boolean();
            }
            //      C# -> MalwareScanFileCriteria? FileScanCriteria
            // GraphQL -> fileScanCriteria: MalwareScanFileCriteria (type)
            if (this.FileScanCriteria == null && Exploration.Includes(parent + ".fileScanCriteria"))
            {
                this.FileScanCriteria = new MalwareScanFileCriteria();
                this.FileScanCriteria.ApplyExploratoryFragment(parent + ".fileScanCriteria");
            }
            //      C# -> List<IndicatorOfCompromise>? IndicatorsOfCompromise
            // GraphQL -> indicatorsOfCompromise: [IndicatorOfCompromise!]! (type)
            if (this.IndicatorsOfCompromise == null && Exploration.Includes(parent + ".indicatorsOfCompromise"))
            {
                this.IndicatorsOfCompromise = new List<IndicatorOfCompromise>();
                this.IndicatorsOfCompromise.ApplyExploratoryFragment(parent + ".indicatorsOfCompromise");
            }
            //      C# -> RequestedMatchDetails? RequestedMatchDetails
            // GraphQL -> requestedMatchDetails: RequestedMatchDetails (type)
            if (this.RequestedMatchDetails == null && Exploration.Includes(parent + ".requestedMatchDetails"))
            {
                this.RequestedMatchDetails = new RequestedMatchDetails();
                this.RequestedMatchDetails.ApplyExploratoryFragment(parent + ".requestedMatchDetails");
            }
            //      C# -> MalwareScanSnapshotLimit? SnapshotScanLimit
            // GraphQL -> snapshotScanLimit: MalwareScanSnapshotLimit (type)
            if (this.SnapshotScanLimit == null && Exploration.Includes(parent + ".snapshotScanLimit"))
            {
                this.SnapshotScanLimit = new MalwareScanSnapshotLimit();
                this.SnapshotScanLimit.ApplyExploratoryFragment(parent + ".snapshotScanLimit");
            }
            //      C# -> List<CdmHierarchySnappableNew>? Objects
            // GraphQL -> objects: [CdmHierarchySnappableNew!]! (interface)
            if (this.Objects == null && Exploration.Includes(parent + ".objects"))
            {
                this.Objects = new List<CdmHierarchySnappableNew>();
                this.Objects.ApplyExploratoryFragment(parent + ".objects");
            }
        }


    #endregion

    } // class ThreatHuntConfig
    #endregion

    public static class ListThreatHuntConfigExtensions
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
            this List<ThreatHuntConfig> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ThreatHuntConfig> list, 
            String parent = "")
        {
            var item = new ThreatHuntConfig();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types