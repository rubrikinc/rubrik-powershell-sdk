// HyperVliveMount.cs
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
    #region HyperVliveMount
    public class HyperVliveMount: IFragment
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsVmReady
        // GraphQL -> isVmReady: Boolean! (scalar)
        [JsonProperty("isVmReady")]
        public System.Boolean? IsVmReady { get; set; }

        //      C# -> System.String? MountSpec
        // GraphQL -> mountSpec: String! (scalar)
        [JsonProperty("mountSpec")]
        public System.String? MountSpec { get; set; }

        //      C# -> DateTime? MountTime
        // GraphQL -> mountTime: DateTime (scalar)
        [JsonProperty("mountTime")]
        public DateTime? MountTime { get; set; }

        //      C# -> System.String? MountedVmFid
        // GraphQL -> mountedVmFid: UUID! (scalar)
        [JsonProperty("mountedVmFid")]
        public System.String? MountedVmFid { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? ServerFid
        // GraphQL -> serverFid: UUID! (scalar)
        [JsonProperty("serverFid")]
        public System.String? ServerFid { get; set; }

        //      C# -> System.String? ServerName
        // GraphQL -> serverName: String! (scalar)
        [JsonProperty("serverName")]
        public System.String? ServerName { get; set; }

        //      C# -> System.String? SourceVm
        // GraphQL -> sourceVm: String! (scalar)
        [JsonProperty("sourceVm")]
        public System.String? SourceVm { get; set; }

        //      C# -> System.String? SourceVmFid
        // GraphQL -> sourceVmFid: UUID! (scalar)
        [JsonProperty("sourceVmFid")]
        public System.String? SourceVmFid { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot (type)
        [JsonProperty("sourceSnapshot")]
        public CdmSnapshot? SourceSnapshot { get; set; }

        //      C# -> HypervMountedVmStatusType? MountedVmStatus
        // GraphQL -> mountedVmStatus: HypervMountedVmStatusType! (enum)
        [JsonProperty("mountedVmStatus")]
        public HypervMountedVmStatusType? MountedVmStatus { get; set; }

        #endregion

    #region methods

    public HyperVliveMount Set(
        System.String? Id = null,
        System.Boolean? IsVmReady = null,
        System.String? MountSpec = null,
        DateTime? MountTime = null,
        System.String? MountedVmFid = null,
        System.String? Name = null,
        System.String? ServerFid = null,
        System.String? ServerName = null,
        System.String? SourceVm = null,
        System.String? SourceVmFid = null,
        Cluster? Cluster = null,
        CdmSnapshot? SourceSnapshot = null,
        HypervMountedVmStatusType? MountedVmStatus = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsVmReady != null ) {
            this.IsVmReady = IsVmReady;
        }
        if ( MountSpec != null ) {
            this.MountSpec = MountSpec;
        }
        if ( MountTime != null ) {
            this.MountTime = MountTime;
        }
        if ( MountedVmFid != null ) {
            this.MountedVmFid = MountedVmFid;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ServerFid != null ) {
            this.ServerFid = ServerFid;
        }
        if ( ServerName != null ) {
            this.ServerName = ServerName;
        }
        if ( SourceVm != null ) {
            this.SourceVm = SourceVm;
        }
        if ( SourceVmFid != null ) {
            this.SourceVmFid = SourceVmFid;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( SourceSnapshot != null ) {
            this.SourceSnapshot = SourceSnapshot;
        }
        if ( MountedVmStatus != null ) {
            this.MountedVmStatus = MountedVmStatus;
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
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsVmReady
            // GraphQL -> isVmReady: Boolean! (scalar)
            if (this.IsVmReady != null)
            {
                 s += ind + "isVmReady\n";

            }
            //      C# -> System.String? MountSpec
            // GraphQL -> mountSpec: String! (scalar)
            if (this.MountSpec != null)
            {
                 s += ind + "mountSpec\n";

            }
            //      C# -> DateTime? MountTime
            // GraphQL -> mountTime: DateTime (scalar)
            if (this.MountTime != null)
            {
                 s += ind + "mountTime\n";

            }
            //      C# -> System.String? MountedVmFid
            // GraphQL -> mountedVmFid: UUID! (scalar)
            if (this.MountedVmFid != null)
            {
                 s += ind + "mountedVmFid\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? ServerFid
            // GraphQL -> serverFid: UUID! (scalar)
            if (this.ServerFid != null)
            {
                 s += ind + "serverFid\n";

            }
            //      C# -> System.String? ServerName
            // GraphQL -> serverName: String! (scalar)
            if (this.ServerName != null)
            {
                 s += ind + "serverName\n";

            }
            //      C# -> System.String? SourceVm
            // GraphQL -> sourceVm: String! (scalar)
            if (this.SourceVm != null)
            {
                 s += ind + "sourceVm\n";

            }
            //      C# -> System.String? SourceVmFid
            // GraphQL -> sourceVmFid: UUID! (scalar)
            if (this.SourceVmFid != null)
            {
                 s += ind + "sourceVmFid\n";

            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster != null)
            {
                 s += ind + "cluster\n";

                 s += ind + "{\n" + 
                 this.Cluster.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CdmSnapshot? SourceSnapshot
            // GraphQL -> sourceSnapshot: CdmSnapshot (type)
            if (this.SourceSnapshot != null)
            {
                 s += ind + "sourceSnapshot\n";

                 s += ind + "{\n" + 
                 this.SourceSnapshot.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> HypervMountedVmStatusType? MountedVmStatus
            // GraphQL -> mountedVmStatus: HypervMountedVmStatusType! (enum)
            if (this.MountedVmStatus != null)
            {
                 s += ind + "mountedVmStatus\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsVmReady
            // GraphQL -> isVmReady: Boolean! (scalar)
            if (this.IsVmReady == null && Exploration.Includes(parent + ".isVmReady$"))
            {
                this.IsVmReady = new System.Boolean();
            }
            //      C# -> System.String? MountSpec
            // GraphQL -> mountSpec: String! (scalar)
            if (this.MountSpec == null && Exploration.Includes(parent + ".mountSpec$"))
            {
                this.MountSpec = new System.String("FETCH");
            }
            //      C# -> DateTime? MountTime
            // GraphQL -> mountTime: DateTime (scalar)
            if (this.MountTime == null && Exploration.Includes(parent + ".mountTime$"))
            {
                this.MountTime = new DateTime();
            }
            //      C# -> System.String? MountedVmFid
            // GraphQL -> mountedVmFid: UUID! (scalar)
            if (this.MountedVmFid == null && Exploration.Includes(parent + ".mountedVmFid$"))
            {
                this.MountedVmFid = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? ServerFid
            // GraphQL -> serverFid: UUID! (scalar)
            if (this.ServerFid == null && Exploration.Includes(parent + ".serverFid$"))
            {
                this.ServerFid = new System.String("FETCH");
            }
            //      C# -> System.String? ServerName
            // GraphQL -> serverName: String! (scalar)
            if (this.ServerName == null && Exploration.Includes(parent + ".serverName$"))
            {
                this.ServerName = new System.String("FETCH");
            }
            //      C# -> System.String? SourceVm
            // GraphQL -> sourceVm: String! (scalar)
            if (this.SourceVm == null && Exploration.Includes(parent + ".sourceVm$"))
            {
                this.SourceVm = new System.String("FETCH");
            }
            //      C# -> System.String? SourceVmFid
            // GraphQL -> sourceVmFid: UUID! (scalar)
            if (this.SourceVmFid == null && Exploration.Includes(parent + ".sourceVmFid$"))
            {
                this.SourceVmFid = new System.String("FETCH");
            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
            {
                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFragment(parent + ".cluster");
            }
            //      C# -> CdmSnapshot? SourceSnapshot
            // GraphQL -> sourceSnapshot: CdmSnapshot (type)
            if (this.SourceSnapshot == null && Exploration.Includes(parent + ".sourceSnapshot"))
            {
                this.SourceSnapshot = new CdmSnapshot();
                this.SourceSnapshot.ApplyExploratoryFragment(parent + ".sourceSnapshot");
            }
            //      C# -> HypervMountedVmStatusType? MountedVmStatus
            // GraphQL -> mountedVmStatus: HypervMountedVmStatusType! (enum)
            if (this.MountedVmStatus == null && Exploration.Includes(parent + ".mountedVmStatus$"))
            {
                this.MountedVmStatus = new HypervMountedVmStatusType();
            }
        }


    #endregion

    } // class HyperVliveMount
    #endregion

    public static class ListHyperVliveMountExtensions
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
            this List<HyperVliveMount> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<HyperVliveMount> list, 
            String parent = "")
        {
            var item = new HyperVliveMount();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types