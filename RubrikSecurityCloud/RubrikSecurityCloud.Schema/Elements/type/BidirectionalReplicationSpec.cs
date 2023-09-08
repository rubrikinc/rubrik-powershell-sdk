// BidirectionalReplicationSpec.cs
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
    #region BidirectionalReplicationSpec
    public class BidirectionalReplicationSpec: BaseType
    {
        #region members

        //      C# -> UnidirectionalReplicationSpec? ReplicationSpec1
        // GraphQL -> replicationSpec1: UnidirectionalReplicationSpec (type)
        [JsonProperty("replicationSpec1")]
        public UnidirectionalReplicationSpec? ReplicationSpec1 { get; set; }

        //      C# -> UnidirectionalReplicationSpec? ReplicationSpec2
        // GraphQL -> replicationSpec2: UnidirectionalReplicationSpec (type)
        [JsonProperty("replicationSpec2")]
        public UnidirectionalReplicationSpec? ReplicationSpec2 { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BidirectionalReplicationSpec";
    }

    public BidirectionalReplicationSpec Set(
        UnidirectionalReplicationSpec? ReplicationSpec1 = null,
        UnidirectionalReplicationSpec? ReplicationSpec2 = null
    ) 
    {
        if ( ReplicationSpec1 != null ) {
            this.ReplicationSpec1 = ReplicationSpec1;
        }
        if ( ReplicationSpec2 != null ) {
            this.ReplicationSpec2 = ReplicationSpec2;
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
        //      C# -> UnidirectionalReplicationSpec? ReplicationSpec1
        // GraphQL -> replicationSpec1: UnidirectionalReplicationSpec (type)
        if (this.ReplicationSpec1 != null) {
            var fspec = this.ReplicationSpec1.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "replicationSpec1 {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> UnidirectionalReplicationSpec? ReplicationSpec2
        // GraphQL -> replicationSpec2: UnidirectionalReplicationSpec (type)
        if (this.ReplicationSpec2 != null) {
            var fspec = this.ReplicationSpec2.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "replicationSpec2 {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> UnidirectionalReplicationSpec? ReplicationSpec1
        // GraphQL -> replicationSpec1: UnidirectionalReplicationSpec (type)
        if (this.ReplicationSpec1 == null && ec.Includes("replicationSpec1",false))
        {
            this.ReplicationSpec1 = new UnidirectionalReplicationSpec();
            this.ReplicationSpec1.ApplyExploratoryFieldSpec(ec.NewChild("replicationSpec1"));
        }
        //      C# -> UnidirectionalReplicationSpec? ReplicationSpec2
        // GraphQL -> replicationSpec2: UnidirectionalReplicationSpec (type)
        if (this.ReplicationSpec2 == null && ec.Includes("replicationSpec2",false))
        {
            this.ReplicationSpec2 = new UnidirectionalReplicationSpec();
            this.ReplicationSpec2.ApplyExploratoryFieldSpec(ec.NewChild("replicationSpec2"));
        }
    }


    #endregion

    } // class BidirectionalReplicationSpec
    
    #endregion

    public static class ListBidirectionalReplicationSpecExtensions
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
            this List<BidirectionalReplicationSpec> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BidirectionalReplicationSpec> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BidirectionalReplicationSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<BidirectionalReplicationSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types