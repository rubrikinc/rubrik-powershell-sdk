// ReplicationToCloudLocationSpec.cs
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
    #region ReplicationToCloudLocationSpec
    public class ReplicationToCloudLocationSpec: BaseType
    {
        #region members

        //      C# -> Duration? RetentionDuration
        // GraphQL -> retentionDuration: Duration (type)
        [JsonProperty("retentionDuration")]
        public Duration? RetentionDuration { get; set; }

        //      C# -> TargetMapping? TargetMapping
        // GraphQL -> targetMapping: TargetMapping (type)
        [JsonProperty("targetMapping")]
        public TargetMapping? TargetMapping { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ReplicationToCloudLocationSpec";
    }

    public ReplicationToCloudLocationSpec Set(
        Duration? RetentionDuration = null,
        TargetMapping? TargetMapping = null
    ) 
    {
        if ( RetentionDuration != null ) {
            this.RetentionDuration = RetentionDuration;
        }
        if ( TargetMapping != null ) {
            this.TargetMapping = TargetMapping;
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
        //      C# -> Duration? RetentionDuration
        // GraphQL -> retentionDuration: Duration (type)
        if (this.RetentionDuration != null) {
            var fspec = this.RetentionDuration.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "retentionDuration {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> TargetMapping? TargetMapping
        // GraphQL -> targetMapping: TargetMapping (type)
        if (this.TargetMapping != null) {
            var fspec = this.TargetMapping.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "targetMapping {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> Duration? RetentionDuration
        // GraphQL -> retentionDuration: Duration (type)
        if (this.RetentionDuration == null && ec.Includes("retentionDuration",false))
        {
            this.RetentionDuration = new Duration();
            this.RetentionDuration.ApplyExploratoryFieldSpec(ec.NewChild("retentionDuration"));
        }
        //      C# -> TargetMapping? TargetMapping
        // GraphQL -> targetMapping: TargetMapping (type)
        if (this.TargetMapping == null && ec.Includes("targetMapping",false))
        {
            this.TargetMapping = new TargetMapping();
            this.TargetMapping.ApplyExploratoryFieldSpec(ec.NewChild("targetMapping"));
        }
    }


    #endregion

    } // class ReplicationToCloudLocationSpec
    
    #endregion

    public static class ListReplicationToCloudLocationSpecExtensions
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
            this List<ReplicationToCloudLocationSpec> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ReplicationToCloudLocationSpec> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReplicationToCloudLocationSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ReplicationToCloudLocationSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types