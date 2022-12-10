// ComputeClusterSummary.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:10.
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
    #region ComputeClusterSummary
    public class ComputeClusterSummary: IFragment
    {
        #region members
        //      C# -> System.String? DatacenterId
        // GraphQL -> datacenterId: String! (scalar)
        [JsonProperty("datacenterId")]
        public System.String? DatacenterId { get; set; }

        //      C# -> System.Boolean? DrsStatus
        // GraphQL -> drsStatus: Boolean (scalar)
        [JsonProperty("drsStatus")]
        public System.Boolean? DrsStatus { get; set; }

        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String (scalar)
        [JsonProperty("effectiveSlaDomainId")]
        public System.String? EffectiveSlaDomainId { get; set; }

        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String (scalar)
        [JsonProperty("effectiveSlaDomainName")]
        public System.String? EffectiveSlaDomainName { get; set; }

        //      C# -> System.String? EffectiveSlaDomainPolarisManagedId
        // GraphQL -> effectiveSlaDomainPolarisManagedId: String (scalar)
        [JsonProperty("effectiveSlaDomainPolarisManagedId")]
        public System.String? EffectiveSlaDomainPolarisManagedId { get; set; }

        //      C# -> System.String? EffectiveSlaSourceObjectId
        // GraphQL -> effectiveSlaSourceObjectId: String (scalar)
        [JsonProperty("effectiveSlaSourceObjectId")]
        public System.String? EffectiveSlaSourceObjectId { get; set; }

        //      C# -> System.String? EffectiveSlaSourceObjectName
        // GraphQL -> effectiveSlaSourceObjectName: String (scalar)
        [JsonProperty("effectiveSlaSourceObjectName")]
        public System.String? EffectiveSlaSourceObjectName { get; set; }

        //      C# -> List<System.String>? HostVersions
        // GraphQL -> hostVersions: [String!]! (scalar)
        [JsonProperty("hostVersions")]
        public List<System.String>? HostVersions { get; set; }

        //      C# -> System.String? LastUsedFqdn
        // GraphQL -> lastUsedFqdn: String (scalar)
        [JsonProperty("lastUsedFqdn")]
        public System.String? LastUsedFqdn { get; set; }

        //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
        // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
        [JsonProperty("effectiveSlaHolder")]
        public EffectiveSlaHolder? EffectiveSlaHolder { get; set; }

        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        [JsonProperty("slaAssignable")]
        public SlaAssignable? SlaAssignable { get; set; }

        //      C# -> IoFilterStatus? IoFilterStatus
        // GraphQL -> ioFilterStatus: IoFilterStatus (enum)
        [JsonProperty("ioFilterStatus")]
        public IoFilterStatus? IoFilterStatus { get; set; }

        #endregion

    #region methods

    public ComputeClusterSummary Set(
        System.String? DatacenterId = null,
        System.Boolean? DrsStatus = null,
        System.String? EffectiveSlaDomainId = null,
        System.String? EffectiveSlaDomainName = null,
        System.String? EffectiveSlaDomainPolarisManagedId = null,
        System.String? EffectiveSlaSourceObjectId = null,
        System.String? EffectiveSlaSourceObjectName = null,
        List<System.String>? HostVersions = null,
        System.String? LastUsedFqdn = null,
        EffectiveSlaHolder? EffectiveSlaHolder = null,
        SlaAssignable? SlaAssignable = null,
        IoFilterStatus? IoFilterStatus = null
    ) 
    {
        if ( DatacenterId != null ) {
            this.DatacenterId = DatacenterId;
        }
        if ( DrsStatus != null ) {
            this.DrsStatus = DrsStatus;
        }
        if ( EffectiveSlaDomainId != null ) {
            this.EffectiveSlaDomainId = EffectiveSlaDomainId;
        }
        if ( EffectiveSlaDomainName != null ) {
            this.EffectiveSlaDomainName = EffectiveSlaDomainName;
        }
        if ( EffectiveSlaDomainPolarisManagedId != null ) {
            this.EffectiveSlaDomainPolarisManagedId = EffectiveSlaDomainPolarisManagedId;
        }
        if ( EffectiveSlaSourceObjectId != null ) {
            this.EffectiveSlaSourceObjectId = EffectiveSlaSourceObjectId;
        }
        if ( EffectiveSlaSourceObjectName != null ) {
            this.EffectiveSlaSourceObjectName = EffectiveSlaSourceObjectName;
        }
        if ( HostVersions != null ) {
            this.HostVersions = HostVersions;
        }
        if ( LastUsedFqdn != null ) {
            this.LastUsedFqdn = LastUsedFqdn;
        }
        if ( EffectiveSlaHolder != null ) {
            this.EffectiveSlaHolder = EffectiveSlaHolder;
        }
        if ( SlaAssignable != null ) {
            this.SlaAssignable = SlaAssignable;
        }
        if ( IoFilterStatus != null ) {
            this.IoFilterStatus = IoFilterStatus;
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
            //      C# -> System.String? DatacenterId
            // GraphQL -> datacenterId: String! (scalar)
            if (this.DatacenterId != null)
            {
                 s += ind + "datacenterId\n";

            }
            //      C# -> System.Boolean? DrsStatus
            // GraphQL -> drsStatus: Boolean (scalar)
            if (this.DrsStatus != null)
            {
                 s += ind + "drsStatus\n";

            }
            //      C# -> System.String? EffectiveSlaDomainId
            // GraphQL -> effectiveSlaDomainId: String (scalar)
            if (this.EffectiveSlaDomainId != null)
            {
                 s += ind + "effectiveSlaDomainId\n";

            }
            //      C# -> System.String? EffectiveSlaDomainName
            // GraphQL -> effectiveSlaDomainName: String (scalar)
            if (this.EffectiveSlaDomainName != null)
            {
                 s += ind + "effectiveSlaDomainName\n";

            }
            //      C# -> System.String? EffectiveSlaDomainPolarisManagedId
            // GraphQL -> effectiveSlaDomainPolarisManagedId: String (scalar)
            if (this.EffectiveSlaDomainPolarisManagedId != null)
            {
                 s += ind + "effectiveSlaDomainPolarisManagedId\n";

            }
            //      C# -> System.String? EffectiveSlaSourceObjectId
            // GraphQL -> effectiveSlaSourceObjectId: String (scalar)
            if (this.EffectiveSlaSourceObjectId != null)
            {
                 s += ind + "effectiveSlaSourceObjectId\n";

            }
            //      C# -> System.String? EffectiveSlaSourceObjectName
            // GraphQL -> effectiveSlaSourceObjectName: String (scalar)
            if (this.EffectiveSlaSourceObjectName != null)
            {
                 s += ind + "effectiveSlaSourceObjectName\n";

            }
            //      C# -> List<System.String>? HostVersions
            // GraphQL -> hostVersions: [String!]! (scalar)
            if (this.HostVersions != null)
            {
                 s += ind + "hostVersions\n";

            }
            //      C# -> System.String? LastUsedFqdn
            // GraphQL -> lastUsedFqdn: String (scalar)
            if (this.LastUsedFqdn != null)
            {
                 s += ind + "lastUsedFqdn\n";

            }
            //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
            // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
            if (this.EffectiveSlaHolder != null)
            {
                 s += ind + "effectiveSlaHolder\n";

                 s += ind + "{\n" + 
                 this.EffectiveSlaHolder.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SlaAssignable? SlaAssignable
            // GraphQL -> slaAssignable: SlaAssignable (type)
            if (this.SlaAssignable != null)
            {
                 s += ind + "slaAssignable\n";

                 s += ind + "{\n" + 
                 this.SlaAssignable.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> IoFilterStatus? IoFilterStatus
            // GraphQL -> ioFilterStatus: IoFilterStatus (enum)
            if (this.IoFilterStatus != null)
            {
                 s += ind + "ioFilterStatus\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? DatacenterId
            // GraphQL -> datacenterId: String! (scalar)
            if (this.DatacenterId == null && Exploration.Includes(parent + ".datacenterId$"))
            {
                this.DatacenterId = new System.String("FETCH");
            }
            //      C# -> System.Boolean? DrsStatus
            // GraphQL -> drsStatus: Boolean (scalar)
            if (this.DrsStatus == null && Exploration.Includes(parent + ".drsStatus$"))
            {
                this.DrsStatus = new System.Boolean();
            }
            //      C# -> System.String? EffectiveSlaDomainId
            // GraphQL -> effectiveSlaDomainId: String (scalar)
            if (this.EffectiveSlaDomainId == null && Exploration.Includes(parent + ".effectiveSlaDomainId$"))
            {
                this.EffectiveSlaDomainId = new System.String("FETCH");
            }
            //      C# -> System.String? EffectiveSlaDomainName
            // GraphQL -> effectiveSlaDomainName: String (scalar)
            if (this.EffectiveSlaDomainName == null && Exploration.Includes(parent + ".effectiveSlaDomainName$"))
            {
                this.EffectiveSlaDomainName = new System.String("FETCH");
            }
            //      C# -> System.String? EffectiveSlaDomainPolarisManagedId
            // GraphQL -> effectiveSlaDomainPolarisManagedId: String (scalar)
            if (this.EffectiveSlaDomainPolarisManagedId == null && Exploration.Includes(parent + ".effectiveSlaDomainPolarisManagedId$"))
            {
                this.EffectiveSlaDomainPolarisManagedId = new System.String("FETCH");
            }
            //      C# -> System.String? EffectiveSlaSourceObjectId
            // GraphQL -> effectiveSlaSourceObjectId: String (scalar)
            if (this.EffectiveSlaSourceObjectId == null && Exploration.Includes(parent + ".effectiveSlaSourceObjectId$"))
            {
                this.EffectiveSlaSourceObjectId = new System.String("FETCH");
            }
            //      C# -> System.String? EffectiveSlaSourceObjectName
            // GraphQL -> effectiveSlaSourceObjectName: String (scalar)
            if (this.EffectiveSlaSourceObjectName == null && Exploration.Includes(parent + ".effectiveSlaSourceObjectName$"))
            {
                this.EffectiveSlaSourceObjectName = new System.String("FETCH");
            }
            //      C# -> List<System.String>? HostVersions
            // GraphQL -> hostVersions: [String!]! (scalar)
            if (this.HostVersions == null && Exploration.Includes(parent + ".hostVersions$"))
            {
                this.HostVersions = new List<System.String>();
            }
            //      C# -> System.String? LastUsedFqdn
            // GraphQL -> lastUsedFqdn: String (scalar)
            if (this.LastUsedFqdn == null && Exploration.Includes(parent + ".lastUsedFqdn$"))
            {
                this.LastUsedFqdn = new System.String("FETCH");
            }
            //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
            // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
            if (this.EffectiveSlaHolder == null && Exploration.Includes(parent + ".effectiveSlaHolder"))
            {
                this.EffectiveSlaHolder = new EffectiveSlaHolder();
                this.EffectiveSlaHolder.ApplyExploratoryFragment(parent + ".effectiveSlaHolder");
            }
            //      C# -> SlaAssignable? SlaAssignable
            // GraphQL -> slaAssignable: SlaAssignable (type)
            if (this.SlaAssignable == null && Exploration.Includes(parent + ".slaAssignable"))
            {
                this.SlaAssignable = new SlaAssignable();
                this.SlaAssignable.ApplyExploratoryFragment(parent + ".slaAssignable");
            }
            //      C# -> IoFilterStatus? IoFilterStatus
            // GraphQL -> ioFilterStatus: IoFilterStatus (enum)
            if (this.IoFilterStatus == null && Exploration.Includes(parent + ".ioFilterStatus$"))
            {
                this.IoFilterStatus = new IoFilterStatus();
            }
        }


    #endregion

    } // class ComputeClusterSummary
    #endregion

    public static class ListComputeClusterSummaryExtensions
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
            this List<ComputeClusterSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ComputeClusterSummary> list, 
            String parent = "")
        {
            var item = new ComputeClusterSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types