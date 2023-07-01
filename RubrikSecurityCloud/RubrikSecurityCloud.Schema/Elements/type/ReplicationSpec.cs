// ReplicationSpec.cs
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
    #region ReplicationSpec
    public class ReplicationSpec: BaseType
    {
        #region members

        //      C# -> ReplicationType? ReplicationType
        // GraphQL -> replicationType: ReplicationType! (enum)
        [JsonProperty("replicationType")]
        public ReplicationType? ReplicationType { get; set; }

        //      C# -> SpecificReplicationSpec? SpecificReplicationSpec
        // GraphQL -> specificReplicationSpec: SpecificReplicationSpec (type)
        [JsonProperty("specificReplicationSpec")]
        public SpecificReplicationSpec? SpecificReplicationSpec { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ReplicationSpec";
    }

    public ReplicationSpec Set(
        ReplicationType? ReplicationType = null,
        SpecificReplicationSpec? SpecificReplicationSpec = null
    ) 
    {
        if ( ReplicationType != null ) {
            this.ReplicationType = ReplicationType;
        }
        if ( SpecificReplicationSpec != null ) {
            this.SpecificReplicationSpec = SpecificReplicationSpec;
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
        //      C# -> ReplicationType? ReplicationType
        // GraphQL -> replicationType: ReplicationType! (enum)
        if (this.ReplicationType != null) {
            s += ind + "replicationType\n" ;
        }
        //      C# -> SpecificReplicationSpec? SpecificReplicationSpec
        // GraphQL -> specificReplicationSpec: SpecificReplicationSpec (type)
        if (this.SpecificReplicationSpec != null) {
            var fspec = this.SpecificReplicationSpec.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "specificReplicationSpec {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ReplicationType? ReplicationType
        // GraphQL -> replicationType: ReplicationType! (enum)
        if (this.ReplicationType == null && Exploration.Includes(parent + ".replicationType", true))
        {
            this.ReplicationType = new ReplicationType();
        }
        //      C# -> SpecificReplicationSpec? SpecificReplicationSpec
        // GraphQL -> specificReplicationSpec: SpecificReplicationSpec (type)
        if (this.SpecificReplicationSpec == null && Exploration.Includes(parent + ".specificReplicationSpec"))
        {
            this.SpecificReplicationSpec = new SpecificReplicationSpec();
            this.SpecificReplicationSpec.ApplyExploratoryFieldSpec(parent + ".specificReplicationSpec");
        }
    }


    #endregion

    } // class ReplicationSpec
    
    #endregion

    public static class ListReplicationSpecExtensions
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
            this List<ReplicationSpec> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ReplicationSpec> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ReplicationSpec());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types