// VolumeGroupSummary.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:40.
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
    #region VolumeGroupSummary
    public class VolumeGroupSummary: IFragment
    {
        #region members
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

        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        [JsonProperty("snappable")]
        public CdmWorkload? Snappable { get; set; }

        #endregion

    #region methods

    public VolumeGroupSummary Set(
        System.Boolean? ForceFull = null,
        System.String? HostId = null,
        System.String? Hostname = null,
        System.String? Id = null,
        System.Boolean? IsRelic = null,
        System.String? Name = null,
        System.Boolean? NeedsMigration = null,
        CdmWorkload? Snappable = null
    ) 
    {
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
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NeedsMigration != null ) {
            this.NeedsMigration = NeedsMigration;
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
            // GraphQL -> hostId: String (scalar)
            if (this.HostId != null)
            {
                 s += ind + "hostId\n";

            }
            //      C# -> System.String? Hostname
            // GraphQL -> hostname: String (scalar)
            if (this.Hostname != null)
            {
                 s += ind + "hostname\n";

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
            //      C# -> System.Boolean? NeedsMigration
            // GraphQL -> needsMigration: Boolean (scalar)
            if (this.NeedsMigration != null)
            {
                 s += ind + "needsMigration\n";

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
            // GraphQL -> hostId: String (scalar)
            if (this.HostId == null && Exploration.Includes(parent + ".hostId$"))
            {
                this.HostId = new System.String("FETCH");
            }
            //      C# -> System.String? Hostname
            // GraphQL -> hostname: String (scalar)
            if (this.Hostname == null && Exploration.Includes(parent + ".hostname$"))
            {
                this.Hostname = new System.String("FETCH");
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
            //      C# -> System.Boolean? NeedsMigration
            // GraphQL -> needsMigration: Boolean (scalar)
            if (this.NeedsMigration == null && Exploration.Includes(parent + ".needsMigration$"))
            {
                this.NeedsMigration = new System.Boolean();
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

    } // class VolumeGroupSummary
    #endregion

    public static class ListVolumeGroupSummaryExtensions
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
            this List<VolumeGroupSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VolumeGroupSummary> list, 
            String parent = "")
        {
            var item = new VolumeGroupSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types