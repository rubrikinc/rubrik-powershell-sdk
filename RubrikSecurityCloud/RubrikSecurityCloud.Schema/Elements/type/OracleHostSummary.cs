// OracleHostSummary.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:33.
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
    #region OracleHostSummary
    public class OracleHostSummary: IFragment
    {
        #region members
        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
        [JsonProperty("hasLogConfigFromSla")]
        public System.Boolean? HasLogConfigFromSla { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumDbs
        // GraphQL -> numDbs: Int! (scalar)
        [JsonProperty("numDbs")]
        public System.Int32? NumDbs { get; set; }

        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        [JsonProperty("primaryClusterId")]
        public System.String? PrimaryClusterId { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> List<ManagedHierarchyObjectAncestor>? InfraPath
        // GraphQL -> infraPath: [ManagedHierarchyObjectAncestor!]! (type)
        [JsonProperty("infraPath")]
        public List<ManagedHierarchyObjectAncestor>? InfraPath { get; set; }

        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        [JsonProperty("slaAssignable")]
        public SlaAssignable? SlaAssignable { get; set; }

        #endregion

    #region methods

    public OracleHostSummary Set(
        System.Boolean? HasLogConfigFromSla = null,
        System.String? HostId = null,
        System.String? Id = null,
        System.String? Name = null,
        System.Int32? NumDbs = null,
        System.String? PrimaryClusterId = null,
        System.String? Status = null,
        List<ManagedHierarchyObjectAncestor>? InfraPath = null,
        SlaAssignable? SlaAssignable = null
    ) 
    {
        if ( HasLogConfigFromSla != null ) {
            this.HasLogConfigFromSla = HasLogConfigFromSla;
        }
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumDbs != null ) {
            this.NumDbs = NumDbs;
        }
        if ( PrimaryClusterId != null ) {
            this.PrimaryClusterId = PrimaryClusterId;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( InfraPath != null ) {
            this.InfraPath = InfraPath;
        }
        if ( SlaAssignable != null ) {
            this.SlaAssignable = SlaAssignable;
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
            //      C# -> System.Boolean? HasLogConfigFromSla
            // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
            if (this.HasLogConfigFromSla != null)
            {
                 s += ind + "hasLogConfigFromSla\n";

            }
            //      C# -> System.String? HostId
            // GraphQL -> hostId: String (scalar)
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
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.Int32? NumDbs
            // GraphQL -> numDbs: Int! (scalar)
            if (this.NumDbs != null)
            {
                 s += ind + "numDbs\n";

            }
            //      C# -> System.String? PrimaryClusterId
            // GraphQL -> primaryClusterId: String! (scalar)
            if (this.PrimaryClusterId != null)
            {
                 s += ind + "primaryClusterId\n";

            }
            //      C# -> System.String? Status
            // GraphQL -> status: String! (scalar)
            if (this.Status != null)
            {
                 s += ind + "status\n";

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
            //      C# -> SlaAssignable? SlaAssignable
            // GraphQL -> slaAssignable: SlaAssignable (type)
            if (this.SlaAssignable != null)
            {
                 s += ind + "slaAssignable\n";

                 s += ind + "{\n" + 
                 this.SlaAssignable.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? HasLogConfigFromSla
            // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
            if (this.HasLogConfigFromSla == null && Exploration.Includes(parent + ".hasLogConfigFromSla$"))
            {
                this.HasLogConfigFromSla = new System.Boolean();
            }
            //      C# -> System.String? HostId
            // GraphQL -> hostId: String (scalar)
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
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.Int32? NumDbs
            // GraphQL -> numDbs: Int! (scalar)
            if (this.NumDbs == null && Exploration.Includes(parent + ".numDbs$"))
            {
                this.NumDbs = new System.Int32();
            }
            //      C# -> System.String? PrimaryClusterId
            // GraphQL -> primaryClusterId: String! (scalar)
            if (this.PrimaryClusterId == null && Exploration.Includes(parent + ".primaryClusterId$"))
            {
                this.PrimaryClusterId = new System.String("FETCH");
            }
            //      C# -> System.String? Status
            // GraphQL -> status: String! (scalar)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new System.String("FETCH");
            }
            //      C# -> List<ManagedHierarchyObjectAncestor>? InfraPath
            // GraphQL -> infraPath: [ManagedHierarchyObjectAncestor!]! (type)
            if (this.InfraPath == null && Exploration.Includes(parent + ".infraPath"))
            {
                this.InfraPath = new List<ManagedHierarchyObjectAncestor>();
                this.InfraPath.ApplyExploratoryFragment(parent + ".infraPath");
            }
            //      C# -> SlaAssignable? SlaAssignable
            // GraphQL -> slaAssignable: SlaAssignable (type)
            if (this.SlaAssignable == null && Exploration.Includes(parent + ".slaAssignable"))
            {
                this.SlaAssignable = new SlaAssignable();
                this.SlaAssignable.ApplyExploratoryFragment(parent + ".slaAssignable");
            }
        }


    #endregion

    } // class OracleHostSummary
    #endregion

    public static class ListOracleHostSummaryExtensions
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
            this List<OracleHostSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<OracleHostSummary> list, 
            String parent = "")
        {
            var item = new OracleHostSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types