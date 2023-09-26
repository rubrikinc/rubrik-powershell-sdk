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

    public override string GetGqlTypeName() {
        return "UnidirectionalReplicationSpec";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> RetentionUnit? RetentionUnit
        // GraphQL -> retentionUnit: RetentionUnit! (enum)
        if (this.RetentionUnit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "retentionUnit\n" ;
            } else {
                s += ind + "retentionUnit\n" ;
            }
        }
        //      C# -> System.String? ReplicationTargetId
        // GraphQL -> replicationTargetId: String! (scalar)
        if (this.ReplicationTargetId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "replicationTargetId\n" ;
            } else {
                s += ind + "replicationTargetId\n" ;
            }
        }
        //      C# -> System.String? ReplicationTargetName
        // GraphQL -> replicationTargetName: String! (scalar)
        if (this.ReplicationTargetName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "replicationTargetName\n" ;
            } else {
                s += ind + "replicationTargetName\n" ;
            }
        }
        //      C# -> System.Int32? Retention
        // GraphQL -> retention: Int! (scalar)
        if (this.Retention != null) {
            if (conf.Flat) {
                s += conf.Prefix + "retention\n" ;
            } else {
                s += ind + "retention\n" ;
            }
        }
        //      C# -> Cluster? TargetCluster
        // GraphQL -> targetCluster: Cluster (type)
        if (this.TargetCluster != null) {
            var fspec = this.TargetCluster.AsFieldSpec(conf.Child("targetCluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetCluster {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RetentionUnit? RetentionUnit
        // GraphQL -> retentionUnit: RetentionUnit! (enum)
        if (ec.Includes("retentionUnit",true))
        {
            if(this.RetentionUnit == null) {

                this.RetentionUnit = new RetentionUnit();

            } else {


            }
        }
        else if (this.RetentionUnit != null && ec.Excludes("retentionUnit",true))
        {
            this.RetentionUnit = null;
        }
        //      C# -> System.String? ReplicationTargetId
        // GraphQL -> replicationTargetId: String! (scalar)
        if (ec.Includes("replicationTargetId",true))
        {
            if(this.ReplicationTargetId == null) {

                this.ReplicationTargetId = "FETCH";

            } else {


            }
        }
        else if (this.ReplicationTargetId != null && ec.Excludes("replicationTargetId",true))
        {
            this.ReplicationTargetId = null;
        }
        //      C# -> System.String? ReplicationTargetName
        // GraphQL -> replicationTargetName: String! (scalar)
        if (ec.Includes("replicationTargetName",true))
        {
            if(this.ReplicationTargetName == null) {

                this.ReplicationTargetName = "FETCH";

            } else {


            }
        }
        else if (this.ReplicationTargetName != null && ec.Excludes("replicationTargetName",true))
        {
            this.ReplicationTargetName = null;
        }
        //      C# -> System.Int32? Retention
        // GraphQL -> retention: Int! (scalar)
        if (ec.Includes("retention",true))
        {
            if(this.Retention == null) {

                this.Retention = Int32.MinValue;

            } else {


            }
        }
        else if (this.Retention != null && ec.Excludes("retention",true))
        {
            this.Retention = null;
        }
        //      C# -> Cluster? TargetCluster
        // GraphQL -> targetCluster: Cluster (type)
        if (ec.Includes("targetCluster",false))
        {
            if(this.TargetCluster == null) {

                this.TargetCluster = new Cluster();
                this.TargetCluster.ApplyExploratoryFieldSpec(ec.NewChild("targetCluster"));

            } else {

                this.TargetCluster.ApplyExploratoryFieldSpec(ec.NewChild("targetCluster"));

            }
        }
        else if (this.TargetCluster != null && ec.Excludes("targetCluster",false))
        {
            this.TargetCluster = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UnidirectionalReplicationSpec> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UnidirectionalReplicationSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UnidirectionalReplicationSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types