// VmwareHostSummary.cs
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
    #region VmwareHostSummary
    public class VmwareHostSummary: IFragment
    {
        #region members
        //      C# -> System.String? ComputeClusterId
        // GraphQL -> computeClusterId: String (scalar)
        [JsonProperty("computeClusterId")]
        public System.String? ComputeClusterId { get; set; }

        //      C# -> System.String? DatacenterId
        // GraphQL -> datacenterId: String (scalar)
        [JsonProperty("datacenterId")]
        public System.String? DatacenterId { get; set; }

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

        //      C# -> System.String? EsxiVersion
        // GraphQL -> esxiVersion: String (scalar)
        [JsonProperty("esxiVersion")]
        public System.String? EsxiVersion { get; set; }

        //      C# -> System.Boolean? IsInVmc
        // GraphQL -> isInVmc: Boolean (scalar)
        [JsonProperty("isInVmc")]
        public System.Boolean? IsInVmc { get; set; }

        //      C# -> List<DataStoreSummary>? Datastores
        // GraphQL -> datastores: [DataStoreSummary!]! (type)
        [JsonProperty("datastores")]
        public List<DataStoreSummary>? Datastores { get; set; }

        //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
        // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
        [JsonProperty("effectiveSlaHolder")]
        public EffectiveSlaHolder? EffectiveSlaHolder { get; set; }

        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        [JsonProperty("slaAssignable")]
        public SlaAssignable? SlaAssignable { get; set; }

        //      C# -> HostFilterStatus? IoFilterStatus
        // GraphQL -> ioFilterStatus: HostFilterStatus (enum)
        [JsonProperty("ioFilterStatus")]
        public HostFilterStatus? IoFilterStatus { get; set; }

        //      C# -> HostUiFilterStatus? IoFilterUiStatus
        // GraphQL -> ioFilterUiStatus: HostUiFilterStatus (enum)
        [JsonProperty("ioFilterUiStatus")]
        public HostUiFilterStatus? IoFilterUiStatus { get; set; }

        #endregion

    #region methods

    public VmwareHostSummary Set(
        System.String? ComputeClusterId = null,
        System.String? DatacenterId = null,
        System.String? EffectiveSlaDomainId = null,
        System.String? EffectiveSlaDomainName = null,
        System.String? EffectiveSlaDomainPolarisManagedId = null,
        System.String? EffectiveSlaSourceObjectId = null,
        System.String? EffectiveSlaSourceObjectName = null,
        System.String? EsxiVersion = null,
        System.Boolean? IsInVmc = null,
        List<DataStoreSummary>? Datastores = null,
        EffectiveSlaHolder? EffectiveSlaHolder = null,
        SlaAssignable? SlaAssignable = null,
        HostFilterStatus? IoFilterStatus = null,
        HostUiFilterStatus? IoFilterUiStatus = null
    ) 
    {
        if ( ComputeClusterId != null ) {
            this.ComputeClusterId = ComputeClusterId;
        }
        if ( DatacenterId != null ) {
            this.DatacenterId = DatacenterId;
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
        if ( EsxiVersion != null ) {
            this.EsxiVersion = EsxiVersion;
        }
        if ( IsInVmc != null ) {
            this.IsInVmc = IsInVmc;
        }
        if ( Datastores != null ) {
            this.Datastores = Datastores;
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
        if ( IoFilterUiStatus != null ) {
            this.IoFilterUiStatus = IoFilterUiStatus;
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
            //      C# -> System.String? ComputeClusterId
            // GraphQL -> computeClusterId: String (scalar)
            if (this.ComputeClusterId != null)
            {
                 s += ind + "computeClusterId\n";

            }
            //      C# -> System.String? DatacenterId
            // GraphQL -> datacenterId: String (scalar)
            if (this.DatacenterId != null)
            {
                 s += ind + "datacenterId\n";

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
            //      C# -> System.String? EsxiVersion
            // GraphQL -> esxiVersion: String (scalar)
            if (this.EsxiVersion != null)
            {
                 s += ind + "esxiVersion\n";

            }
            //      C# -> System.Boolean? IsInVmc
            // GraphQL -> isInVmc: Boolean (scalar)
            if (this.IsInVmc != null)
            {
                 s += ind + "isInVmc\n";

            }
            //      C# -> List<DataStoreSummary>? Datastores
            // GraphQL -> datastores: [DataStoreSummary!]! (type)
            if (this.Datastores != null)
            {
                 s += ind + "datastores\n";

                 s += ind + "{\n" + 
                 this.Datastores.AsFragment(indent+1) + 
                 ind + "}\n";
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
            //      C# -> HostFilterStatus? IoFilterStatus
            // GraphQL -> ioFilterStatus: HostFilterStatus (enum)
            if (this.IoFilterStatus != null)
            {
                 s += ind + "ioFilterStatus\n";

            }
            //      C# -> HostUiFilterStatus? IoFilterUiStatus
            // GraphQL -> ioFilterUiStatus: HostUiFilterStatus (enum)
            if (this.IoFilterUiStatus != null)
            {
                 s += ind + "ioFilterUiStatus\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ComputeClusterId
            // GraphQL -> computeClusterId: String (scalar)
            if (this.ComputeClusterId == null && Exploration.Includes(parent + ".computeClusterId$"))
            {
                this.ComputeClusterId = new System.String("FETCH");
            }
            //      C# -> System.String? DatacenterId
            // GraphQL -> datacenterId: String (scalar)
            if (this.DatacenterId == null && Exploration.Includes(parent + ".datacenterId$"))
            {
                this.DatacenterId = new System.String("FETCH");
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
            //      C# -> System.String? EsxiVersion
            // GraphQL -> esxiVersion: String (scalar)
            if (this.EsxiVersion == null && Exploration.Includes(parent + ".esxiVersion$"))
            {
                this.EsxiVersion = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsInVmc
            // GraphQL -> isInVmc: Boolean (scalar)
            if (this.IsInVmc == null && Exploration.Includes(parent + ".isInVmc$"))
            {
                this.IsInVmc = new System.Boolean();
            }
            //      C# -> List<DataStoreSummary>? Datastores
            // GraphQL -> datastores: [DataStoreSummary!]! (type)
            if (this.Datastores == null && Exploration.Includes(parent + ".datastores"))
            {
                this.Datastores = new List<DataStoreSummary>();
                this.Datastores.ApplyExploratoryFragment(parent + ".datastores");
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
            //      C# -> HostFilterStatus? IoFilterStatus
            // GraphQL -> ioFilterStatus: HostFilterStatus (enum)
            if (this.IoFilterStatus == null && Exploration.Includes(parent + ".ioFilterStatus$"))
            {
                this.IoFilterStatus = new HostFilterStatus();
            }
            //      C# -> HostUiFilterStatus? IoFilterUiStatus
            // GraphQL -> ioFilterUiStatus: HostUiFilterStatus (enum)
            if (this.IoFilterUiStatus == null && Exploration.Includes(parent + ".ioFilterUiStatus$"))
            {
                this.IoFilterUiStatus = new HostUiFilterStatus();
            }
        }


    #endregion

    } // class VmwareHostSummary
    #endregion

    public static class ListVmwareHostSummaryExtensions
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
            this List<VmwareHostSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VmwareHostSummary> list, 
            String parent = "")
        {
            var item = new VmwareHostSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types