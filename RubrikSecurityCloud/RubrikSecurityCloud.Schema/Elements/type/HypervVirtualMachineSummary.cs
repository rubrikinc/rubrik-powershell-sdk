// HypervVirtualMachineSummary.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:37.
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
    #region HypervVirtualMachineSummary
    public class HypervVirtualMachineSummary: IFragment
    {
        #region members
        //      C# -> System.Boolean? ForceFull
        // GraphQL -> forceFull: Boolean (scalar)
        [JsonProperty("forceFull")]
        public System.Boolean? ForceFull { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> CdmAgentStatus? AgentStatus
        // GraphQL -> agentStatus: CdmAgentStatus (type)
        [JsonProperty("agentStatus")]
        public CdmAgentStatus? AgentStatus { get; set; }

        //      C# -> CloudInstantiationSpec? CloudInstantiationSpec
        // GraphQL -> cloudInstantiationSpec: CloudInstantiationSpec (type)
        [JsonProperty("cloudInstantiationSpec")]
        public CloudInstantiationSpec? CloudInstantiationSpec { get; set; }

        //      C# -> List<ManagedHierarchyObjectAncestor>? InfraPath
        // GraphQL -> infraPath: [ManagedHierarchyObjectAncestor!]! (type)
        [JsonProperty("infraPath")]
        public List<ManagedHierarchyObjectAncestor>? InfraPath { get; set; }

        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        [JsonProperty("pendingSlaDomain")]
        public ManagedObjectPendingSlaInfo? PendingSlaDomain { get; set; }

        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        [JsonProperty("snappable")]
        public CdmWorkload? Snappable { get; set; }

        #endregion

    #region methods

    public HypervVirtualMachineSummary Set(
        System.Boolean? ForceFull = null,
        System.String? HostId = null,
        System.String? Id = null,
        System.Boolean? IsRelic = null,
        System.String? Name = null,
        CdmAgentStatus? AgentStatus = null,
        CloudInstantiationSpec? CloudInstantiationSpec = null,
        List<ManagedHierarchyObjectAncestor>? InfraPath = null,
        ManagedObjectPendingSlaInfo? PendingSlaDomain = null,
        CdmWorkload? Snappable = null
    ) 
    {
        if ( ForceFull != null ) {
            this.ForceFull = ForceFull;
        }
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( AgentStatus != null ) {
            this.AgentStatus = AgentStatus;
        }
        if ( CloudInstantiationSpec != null ) {
            this.CloudInstantiationSpec = CloudInstantiationSpec;
        }
        if ( InfraPath != null ) {
            this.InfraPath = InfraPath;
        }
        if ( PendingSlaDomain != null ) {
            this.PendingSlaDomain = PendingSlaDomain;
        }
        if ( Snappable != null ) {
            this.Snappable = Snappable;
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
            //      C# -> System.Boolean? ForceFull
            // GraphQL -> forceFull: Boolean (scalar)
            if (this.ForceFull != null)
            {
                 s += ind + "forceFull\n";

            }
            //      C# -> System.String? HostId
            // GraphQL -> hostId: String! (scalar)
            if (this.HostId != null)
            {
                 s += ind + "hostId\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsRelic
            // GraphQL -> isRelic: Boolean! (scalar)
            if (this.IsRelic != null)
            {
                 s += ind + "isRelic\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> CdmAgentStatus? AgentStatus
            // GraphQL -> agentStatus: CdmAgentStatus (type)
            if (this.AgentStatus != null)
            {
                 s += ind + "agentStatus\n";

                 s += ind + "{\n" + 
                 this.AgentStatus.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CloudInstantiationSpec? CloudInstantiationSpec
            // GraphQL -> cloudInstantiationSpec: CloudInstantiationSpec (type)
            if (this.CloudInstantiationSpec != null)
            {
                 s += ind + "cloudInstantiationSpec\n";

                 s += ind + "{\n" + 
                 this.CloudInstantiationSpec.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ManagedHierarchyObjectAncestor>? InfraPath
            // GraphQL -> infraPath: [ManagedHierarchyObjectAncestor!]! (type)
            if (this.InfraPath != null)
            {
                 s += ind + "infraPath\n";

                 s += ind + "{\n" + 
                 this.InfraPath.AsFragment(indent+1) + 
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
            //      C# -> CdmWorkload? Snappable
            // GraphQL -> snappable: CdmWorkload (type)
            if (this.Snappable != null)
            {
                 s += ind + "snappable\n";

                 s += ind + "{\n" + 
                 this.Snappable.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? ForceFull
            // GraphQL -> forceFull: Boolean (scalar)
            if (this.ForceFull == null && Exploration.Includes(parent + ".forceFull$"))
            {
                this.ForceFull = new System.Boolean();
            }
            //      C# -> System.String? HostId
            // GraphQL -> hostId: String! (scalar)
            if (this.HostId == null && Exploration.Includes(parent + ".hostId$"))
            {
                this.HostId = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsRelic
            // GraphQL -> isRelic: Boolean! (scalar)
            if (this.IsRelic == null && Exploration.Includes(parent + ".isRelic$"))
            {
                this.IsRelic = new System.Boolean();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> CdmAgentStatus? AgentStatus
            // GraphQL -> agentStatus: CdmAgentStatus (type)
            if (this.AgentStatus == null && Exploration.Includes(parent + ".agentStatus"))
            {
                this.AgentStatus = new CdmAgentStatus();
                this.AgentStatus.ApplyExploratoryFragment(parent + ".agentStatus");
            }
            //      C# -> CloudInstantiationSpec? CloudInstantiationSpec
            // GraphQL -> cloudInstantiationSpec: CloudInstantiationSpec (type)
            if (this.CloudInstantiationSpec == null && Exploration.Includes(parent + ".cloudInstantiationSpec"))
            {
                this.CloudInstantiationSpec = new CloudInstantiationSpec();
                this.CloudInstantiationSpec.ApplyExploratoryFragment(parent + ".cloudInstantiationSpec");
            }
            //      C# -> List<ManagedHierarchyObjectAncestor>? InfraPath
            // GraphQL -> infraPath: [ManagedHierarchyObjectAncestor!]! (type)
            if (this.InfraPath == null && Exploration.Includes(parent + ".infraPath"))
            {
                this.InfraPath = new List<ManagedHierarchyObjectAncestor>();
                this.InfraPath.ApplyExploratoryFragment(parent + ".infraPath");
            }
            //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
            // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
            if (this.PendingSlaDomain == null && Exploration.Includes(parent + ".pendingSlaDomain"))
            {
                this.PendingSlaDomain = new ManagedObjectPendingSlaInfo();
                this.PendingSlaDomain.ApplyExploratoryFragment(parent + ".pendingSlaDomain");
            }
            //      C# -> CdmWorkload? Snappable
            // GraphQL -> snappable: CdmWorkload (type)
            if (this.Snappable == null && Exploration.Includes(parent + ".snappable"))
            {
                this.Snappable = new CdmWorkload();
                this.Snappable.ApplyExploratoryFragment(parent + ".snappable");
            }
        }


    #endregion

    } // class HypervVirtualMachineSummary
    #endregion

    public static class ListHypervVirtualMachineSummaryExtensions
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
            this List<HypervVirtualMachineSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<HypervVirtualMachineSummary> list, 
            String parent = "")
        {
            var item = new HypervVirtualMachineSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types