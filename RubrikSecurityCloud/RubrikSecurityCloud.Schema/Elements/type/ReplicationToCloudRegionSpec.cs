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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "ReplicationToCloudRegionSpec";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> CloudProvider? CloudProvider
        // GraphQL -> cloudProvider: CloudProvider! (enum)
        if (this.CloudProvider != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudProvider\n" ;
            } else {
                s += ind + "cloudProvider\n" ;
            }
        }
        //      C# -> RetentionUnit? RetentionUnit
        // GraphQL -> retentionUnit: RetentionUnit! (enum)
        if (this.RetentionUnit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "retentionUnit\n" ;
            } else {
                s += ind + "retentionUnit\n" ;
            }
        }
        //      C# -> System.String? ReplicationTargetRegion
        // GraphQL -> replicationTargetRegion: String! (scalar)
        if (this.ReplicationTargetRegion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "replicationTargetRegion\n" ;
            } else {
                s += ind + "replicationTargetRegion\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CloudProvider? CloudProvider
        // GraphQL -> cloudProvider: CloudProvider! (enum)
        if (ec.Includes("cloudProvider",true))
        {
            if(this.CloudProvider == null) {

                this.CloudProvider = new CloudProvider();

            } else {


            }
        }
        else if (this.CloudProvider != null && ec.Excludes("cloudProvider",true))
        {
            this.CloudProvider = null;
        }
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
        //      C# -> System.String? ReplicationTargetRegion
        // GraphQL -> replicationTargetRegion: String! (scalar)
        if (ec.Includes("replicationTargetRegion",true))
        {
            if(this.ReplicationTargetRegion == null) {

                this.ReplicationTargetRegion = "FETCH";

            } else {


            }
        }
        else if (this.ReplicationTargetRegion != null && ec.Excludes("replicationTargetRegion",true))
        {
            this.ReplicationTargetRegion = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ReplicationToCloudRegionSpec> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReplicationToCloudRegionSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ReplicationToCloudRegionSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types