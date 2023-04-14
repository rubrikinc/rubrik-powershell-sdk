// UnidirectionalReplicationSpec.cs
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
    #region UnidirectionalReplicationSpec
    public class UnidirectionalReplicationSpec: IFragment
    {
        #region members
        //      C# -> System.String? ReplicationTargetId
        // GraphQL -> replicationTargetId: String! (scalar)
        [JsonProperty("replicationTargetId")]
        public System.String? ReplicationTargetId { get; set; }

        //      C# -> System.String? ReplicationTargetName
        // GraphQL -> replicationTargetName: String! (scalar)
        [JsonProperty("replicationTargetName")]
        public System.String? ReplicationTargetName { get; set; }

        //      C# -> System.Int32? Retention
        // GraphQL -> retention: Int! (scalar)
        [JsonProperty("retention")]
        public System.Int32? Retention { get; set; }

        //      C# -> Cluster? TargetCluster
        // GraphQL -> targetCluster: Cluster (type)
        [JsonProperty("targetCluster")]
        public Cluster? TargetCluster { get; set; }

        //      C# -> RetentionUnit? RetentionUnit
        // GraphQL -> retentionUnit: RetentionUnit! (enum)
        [JsonProperty("retentionUnit")]
        public RetentionUnit? RetentionUnit { get; set; }

        #endregion

    #region methods

    public UnidirectionalReplicationSpec Set(
        System.String? ReplicationTargetId = null,
        System.String? ReplicationTargetName = null,
        System.Int32? Retention = null,
        Cluster? TargetCluster = null,
        RetentionUnit? RetentionUnit = null
    ) 
    {
        if ( ReplicationTargetId != null ) {
            this.ReplicationTargetId = ReplicationTargetId;
        }
        if ( ReplicationTargetName != null ) {
            this.ReplicationTargetName = ReplicationTargetName;
        }
        if ( Retention != null ) {
            this.Retention = Retention;
        }
        if ( TargetCluster != null ) {
            this.TargetCluster = TargetCluster;
        }
        if ( RetentionUnit != null ) {
            this.RetentionUnit = RetentionUnit;
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
            //      C# -> System.String? ReplicationTargetId
            // GraphQL -> replicationTargetId: String! (scalar)
            if (this.ReplicationTargetId != null)
            {
                 s += ind + "replicationTargetId\n";

            }
            //      C# -> System.String? ReplicationTargetName
            // GraphQL -> replicationTargetName: String! (scalar)
            if (this.ReplicationTargetName != null)
            {
                 s += ind + "replicationTargetName\n";

            }
            //      C# -> System.Int32? Retention
            // GraphQL -> retention: Int! (scalar)
            if (this.Retention != null)
            {
                 s += ind + "retention\n";

            }
            //      C# -> Cluster? TargetCluster
            // GraphQL -> targetCluster: Cluster (type)
            if (this.TargetCluster != null)
            {
                 s += ind + "targetCluster\n";

                 s += ind + "{\n" + 
                 this.TargetCluster.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> RetentionUnit? RetentionUnit
            // GraphQL -> retentionUnit: RetentionUnit! (enum)
            if (this.RetentionUnit != null)
            {
                 s += ind + "retentionUnit\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ReplicationTargetId
            // GraphQL -> replicationTargetId: String! (scalar)
            if (this.ReplicationTargetId == null && Exploration.Includes(parent + ".replicationTargetId$"))
            {
                this.ReplicationTargetId = new System.String("FETCH");
            }
            //      C# -> System.String? ReplicationTargetName
            // GraphQL -> replicationTargetName: String! (scalar)
            if (this.ReplicationTargetName == null && Exploration.Includes(parent + ".replicationTargetName$"))
            {
                this.ReplicationTargetName = new System.String("FETCH");
            }
            //      C# -> System.Int32? Retention
            // GraphQL -> retention: Int! (scalar)
            if (this.Retention == null && Exploration.Includes(parent + ".retention$"))
            {
                this.Retention = new System.Int32();
            }
            //      C# -> Cluster? TargetCluster
            // GraphQL -> targetCluster: Cluster (type)
            if (this.TargetCluster == null && Exploration.Includes(parent + ".targetCluster"))
            {
                this.TargetCluster = new Cluster();
                this.TargetCluster.ApplyExploratoryFragment(parent + ".targetCluster");
            }
            //      C# -> RetentionUnit? RetentionUnit
            // GraphQL -> retentionUnit: RetentionUnit! (enum)
            if (this.RetentionUnit == null && Exploration.Includes(parent + ".retentionUnit$"))
            {
                this.RetentionUnit = new RetentionUnit();
            }
        }


    #endregion

    } // class UnidirectionalReplicationSpec
    #endregion

    public static class ListUnidirectionalReplicationSpecExtensions
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
            this List<UnidirectionalReplicationSpec> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<UnidirectionalReplicationSpec> list, 
            String parent = "")
        {
            var item = new UnidirectionalReplicationSpec();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types