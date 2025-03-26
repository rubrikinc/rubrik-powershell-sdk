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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ReplicationToCloudRegionSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ReplicationToCloudRegionSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ReplicationToCloudRegionSpec> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReplicationToCloudRegionSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ReplicationToCloudRegionSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types