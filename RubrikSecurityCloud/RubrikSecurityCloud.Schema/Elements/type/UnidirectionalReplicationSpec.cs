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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region UnidirectionalReplicationSpec
    public class UnidirectionalReplicationSpec: BaseType
    {
        #region members

        //      C# -> RetentionUnit? RetentionUnit
        // GraphQL -> retentionUnit: RetentionUnit! (enum)
        [JsonProperty("retentionUnit")]
        public RetentionUnit? RetentionUnit { get; set; }

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


        #endregion

    #region methods

    public UnidirectionalReplicationSpec Set(
        RetentionUnit? RetentionUnit = null,
        System.String? ReplicationTargetId = null,
        System.String? ReplicationTargetName = null,
        System.Int32? Retention = null,
        Cluster? TargetCluster = null
    ) 
    {
        if ( RetentionUnit != null ) {
            this.RetentionUnit = RetentionUnit;
        }
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> RetentionUnit? RetentionUnit
        // GraphQL -> retentionUnit: RetentionUnit! (enum)
        if (this.RetentionUnit != null) {
            s += ind + "retentionUnit\n" ;
        }
        //      C# -> System.String? ReplicationTargetId
        // GraphQL -> replicationTargetId: String! (scalar)
        if (this.ReplicationTargetId != null) {
            s += ind + "replicationTargetId\n" ;
        }
        //      C# -> System.String? ReplicationTargetName
        // GraphQL -> replicationTargetName: String! (scalar)
        if (this.ReplicationTargetName != null) {
            s += ind + "replicationTargetName\n" ;
        }
        //      C# -> System.Int32? Retention
        // GraphQL -> retention: Int! (scalar)
        if (this.Retention != null) {
            s += ind + "retention\n" ;
        }
        //      C# -> Cluster? TargetCluster
        // GraphQL -> targetCluster: Cluster (type)
        if (this.TargetCluster != null) {
            var fspec = this.TargetCluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "targetCluster {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> RetentionUnit? RetentionUnit
        // GraphQL -> retentionUnit: RetentionUnit! (enum)
        if (this.RetentionUnit == null && Exploration.Includes(parent + ".retentionUnit", true))
        {
            this.RetentionUnit = new RetentionUnit();
        }
        //      C# -> System.String? ReplicationTargetId
        // GraphQL -> replicationTargetId: String! (scalar)
        if (this.ReplicationTargetId == null && Exploration.Includes(parent + ".replicationTargetId", true))
        {
            this.ReplicationTargetId = "FETCH";
        }
        //      C# -> System.String? ReplicationTargetName
        // GraphQL -> replicationTargetName: String! (scalar)
        if (this.ReplicationTargetName == null && Exploration.Includes(parent + ".replicationTargetName", true))
        {
            this.ReplicationTargetName = "FETCH";
        }
        //      C# -> System.Int32? Retention
        // GraphQL -> retention: Int! (scalar)
        if (this.Retention == null && Exploration.Includes(parent + ".retention", true))
        {
            this.Retention = Int32.MinValue;
        }
        //      C# -> Cluster? TargetCluster
        // GraphQL -> targetCluster: Cluster (type)
        if (this.TargetCluster == null && Exploration.Includes(parent + ".targetCluster"))
        {
            this.TargetCluster = new Cluster();
            this.TargetCluster.ApplyExploratoryFieldSpec(parent + ".targetCluster");
        }
    }


    #endregion

    } // class UnidirectionalReplicationSpec
    
    #endregion

    public static class ListUnidirectionalReplicationSpecExtensions
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
            this List<UnidirectionalReplicationSpec> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UnidirectionalReplicationSpec> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UnidirectionalReplicationSpec());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types