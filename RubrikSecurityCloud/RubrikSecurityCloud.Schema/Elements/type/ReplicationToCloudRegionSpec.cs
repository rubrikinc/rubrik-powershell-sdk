// ReplicationToCloudRegionSpec.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region ReplicationToCloudRegionSpec
    public class ReplicationToCloudRegionSpec: BaseType
    {
        #region members

        //      C# -> CloudProvider? CloudProvider
        // GraphQL -> cloudProvider: CloudProvider! (enum)
        [JsonProperty("cloudProvider")]
        public CloudProvider? CloudProvider { get; set; }

        //      C# -> RetentionUnit? RetentionUnit
        // GraphQL -> retentionUnit: RetentionUnit! (enum)
        [JsonProperty("retentionUnit")]
        public RetentionUnit? RetentionUnit { get; set; }

        //      C# -> System.String? ReplicationTargetRegion
        // GraphQL -> replicationTargetRegion: String! (scalar)
        [JsonProperty("replicationTargetRegion")]
        public System.String? ReplicationTargetRegion { get; set; }

        //      C# -> System.Int32? Retention
        // GraphQL -> retention: Int! (scalar)
        [JsonProperty("retention")]
        public System.Int32? Retention { get; set; }


        #endregion

    #region methods

    public ReplicationToCloudRegionSpec Set(
        CloudProvider? CloudProvider = null,
        RetentionUnit? RetentionUnit = null,
        System.String? ReplicationTargetRegion = null,
        System.Int32? Retention = null
    ) 
    {
        if ( CloudProvider != null ) {
            this.CloudProvider = CloudProvider;
        }
        if ( RetentionUnit != null ) {
            this.RetentionUnit = RetentionUnit;
        }
        if ( ReplicationTargetRegion != null ) {
            this.ReplicationTargetRegion = ReplicationTargetRegion;
        }
        if ( Retention != null ) {
            this.Retention = Retention;
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
        //      C# -> CloudProvider? CloudProvider
        // GraphQL -> cloudProvider: CloudProvider! (enum)
        if (this.CloudProvider != null) {
            s += ind + "cloudProvider\n" ;
        }
        //      C# -> RetentionUnit? RetentionUnit
        // GraphQL -> retentionUnit: RetentionUnit! (enum)
        if (this.RetentionUnit != null) {
            s += ind + "retentionUnit\n" ;
        }
        //      C# -> System.String? ReplicationTargetRegion
        // GraphQL -> replicationTargetRegion: String! (scalar)
        if (this.ReplicationTargetRegion != null) {
            s += ind + "replicationTargetRegion\n" ;
        }
        //      C# -> System.Int32? Retention
        // GraphQL -> retention: Int! (scalar)
        if (this.Retention != null) {
            s += ind + "retention\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> CloudProvider? CloudProvider
        // GraphQL -> cloudProvider: CloudProvider! (enum)
        if (this.CloudProvider == null && Exploration.Includes(parent + ".cloudProvider", true))
        {
            this.CloudProvider = new CloudProvider();
        }
        //      C# -> RetentionUnit? RetentionUnit
        // GraphQL -> retentionUnit: RetentionUnit! (enum)
        if (this.RetentionUnit == null && Exploration.Includes(parent + ".retentionUnit", true))
        {
            this.RetentionUnit = new RetentionUnit();
        }
        //      C# -> System.String? ReplicationTargetRegion
        // GraphQL -> replicationTargetRegion: String! (scalar)
        if (this.ReplicationTargetRegion == null && Exploration.Includes(parent + ".replicationTargetRegion", true))
        {
            this.ReplicationTargetRegion = "FETCH";
        }
        //      C# -> System.Int32? Retention
        // GraphQL -> retention: Int! (scalar)
        if (this.Retention == null && Exploration.Includes(parent + ".retention", true))
        {
            this.Retention = Int32.MinValue;
        }
    }


    #endregion

    } // class ReplicationToCloudRegionSpec
    
    #endregion

    public static class ListReplicationToCloudRegionSpecExtensions
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
            this List<ReplicationToCloudRegionSpec> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ReplicationToCloudRegionSpec> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ReplicationToCloudRegionSpec());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types