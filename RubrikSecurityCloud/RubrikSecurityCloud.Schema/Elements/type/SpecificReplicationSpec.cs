// SpecificReplicationSpec.cs
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
    #region SpecificReplicationSpec
    public class SpecificReplicationSpec: BaseType
    {
        #region members

        //      C# -> BidirectionalReplicationSpec? BidirectionalSpec
        // GraphQL -> bidirectionalSpec: BidirectionalReplicationSpec (type)
        [JsonProperty("bidirectionalSpec")]
        public BidirectionalReplicationSpec? BidirectionalSpec { get; set; }

        //      C# -> ReplicationToCloudLocationSpec? CloudLocationSpec
        // GraphQL -> cloudLocationSpec: ReplicationToCloudLocationSpec (type)
        [JsonProperty("cloudLocationSpec")]
        public ReplicationToCloudLocationSpec? CloudLocationSpec { get; set; }

        //      C# -> ReplicationToCloudRegionSpec? CloudRegionSpec
        // GraphQL -> cloudRegionSpec: ReplicationToCloudRegionSpec (type)
        [JsonProperty("cloudRegionSpec")]
        public ReplicationToCloudRegionSpec? CloudRegionSpec { get; set; }

        //      C# -> UnidirectionalReplicationSpec? UnidirectionalSpec
        // GraphQL -> unidirectionalSpec: UnidirectionalReplicationSpec (type)
        [JsonProperty("unidirectionalSpec")]
        public UnidirectionalReplicationSpec? UnidirectionalSpec { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SpecificReplicationSpec";
    }

    public SpecificReplicationSpec Set(
        BidirectionalReplicationSpec? BidirectionalSpec = null,
        ReplicationToCloudLocationSpec? CloudLocationSpec = null,
        ReplicationToCloudRegionSpec? CloudRegionSpec = null,
        UnidirectionalReplicationSpec? UnidirectionalSpec = null
    ) 
    {
        if ( BidirectionalSpec != null ) {
            this.BidirectionalSpec = BidirectionalSpec;
        }
        if ( CloudLocationSpec != null ) {
            this.CloudLocationSpec = CloudLocationSpec;
        }
        if ( CloudRegionSpec != null ) {
            this.CloudRegionSpec = CloudRegionSpec;
        }
        if ( UnidirectionalSpec != null ) {
            this.UnidirectionalSpec = UnidirectionalSpec;
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
        //      C# -> BidirectionalReplicationSpec? BidirectionalSpec
        // GraphQL -> bidirectionalSpec: BidirectionalReplicationSpec (type)
        if (this.BidirectionalSpec != null) {
            var fspec = this.BidirectionalSpec.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "bidirectionalSpec {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ReplicationToCloudLocationSpec? CloudLocationSpec
        // GraphQL -> cloudLocationSpec: ReplicationToCloudLocationSpec (type)
        if (this.CloudLocationSpec != null) {
            var fspec = this.CloudLocationSpec.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cloudLocationSpec {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ReplicationToCloudRegionSpec? CloudRegionSpec
        // GraphQL -> cloudRegionSpec: ReplicationToCloudRegionSpec (type)
        if (this.CloudRegionSpec != null) {
            var fspec = this.CloudRegionSpec.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cloudRegionSpec {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> UnidirectionalReplicationSpec? UnidirectionalSpec
        // GraphQL -> unidirectionalSpec: UnidirectionalReplicationSpec (type)
        if (this.UnidirectionalSpec != null) {
            var fspec = this.UnidirectionalSpec.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "unidirectionalSpec {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> BidirectionalReplicationSpec? BidirectionalSpec
        // GraphQL -> bidirectionalSpec: BidirectionalReplicationSpec (type)
        if (this.BidirectionalSpec == null && ec.Includes("bidirectionalSpec",false))
        {
            this.BidirectionalSpec = new BidirectionalReplicationSpec();
            this.BidirectionalSpec.ApplyExploratoryFieldSpec(ec.NewChild("bidirectionalSpec"));
        }
        //      C# -> ReplicationToCloudLocationSpec? CloudLocationSpec
        // GraphQL -> cloudLocationSpec: ReplicationToCloudLocationSpec (type)
        if (this.CloudLocationSpec == null && ec.Includes("cloudLocationSpec",false))
        {
            this.CloudLocationSpec = new ReplicationToCloudLocationSpec();
            this.CloudLocationSpec.ApplyExploratoryFieldSpec(ec.NewChild("cloudLocationSpec"));
        }
        //      C# -> ReplicationToCloudRegionSpec? CloudRegionSpec
        // GraphQL -> cloudRegionSpec: ReplicationToCloudRegionSpec (type)
        if (this.CloudRegionSpec == null && ec.Includes("cloudRegionSpec",false))
        {
            this.CloudRegionSpec = new ReplicationToCloudRegionSpec();
            this.CloudRegionSpec.ApplyExploratoryFieldSpec(ec.NewChild("cloudRegionSpec"));
        }
        //      C# -> UnidirectionalReplicationSpec? UnidirectionalSpec
        // GraphQL -> unidirectionalSpec: UnidirectionalReplicationSpec (type)
        if (this.UnidirectionalSpec == null && ec.Includes("unidirectionalSpec",false))
        {
            this.UnidirectionalSpec = new UnidirectionalReplicationSpec();
            this.UnidirectionalSpec.ApplyExploratoryFieldSpec(ec.NewChild("unidirectionalSpec"));
        }
    }


    #endregion

    } // class SpecificReplicationSpec
    
    #endregion

    public static class ListSpecificReplicationSpecExtensions
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
            this List<SpecificReplicationSpec> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SpecificReplicationSpec> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SpecificReplicationSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SpecificReplicationSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types