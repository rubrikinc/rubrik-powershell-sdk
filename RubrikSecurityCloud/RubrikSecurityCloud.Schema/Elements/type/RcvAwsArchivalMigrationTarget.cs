// RcvAwsArchivalMigrationTarget.cs
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
    #region RcvAwsArchivalMigrationTarget
    public class RcvAwsArchivalMigrationTarget: BaseType
    {
        #region members

        //      C# -> RcsTierEnumType? RcvTier
        // GraphQL -> rcvTier: RcsTierEnumType! (enum)
        [JsonProperty("rcvTier")]
        public RcsTierEnumType? RcvTier { get; set; }

        //      C# -> RcvRedundancy? Redundancy
        // GraphQL -> redundancy: RcvRedundancy! (enum)
        [JsonProperty("redundancy")]
        public RcvRedundancy? Redundancy { get; set; }

        //      C# -> AwsRegion? Region
        // GraphQL -> region: AwsRegion! (enum)
        [JsonProperty("region")]
        public AwsRegion? Region { get; set; }

        //      C# -> System.String? Bucket
        // GraphQL -> bucket: String! (scalar)
        [JsonProperty("bucket")]
        public System.String? Bucket { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RcvAwsArchivalMigrationTarget";
    }

    public RcvAwsArchivalMigrationTarget Set(
        RcsTierEnumType? RcvTier = null,
        RcvRedundancy? Redundancy = null,
        AwsRegion? Region = null,
        System.String? Bucket = null
    ) 
    {
        if ( RcvTier != null ) {
            this.RcvTier = RcvTier;
        }
        if ( Redundancy != null ) {
            this.Redundancy = Redundancy;
        }
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( Bucket != null ) {
            this.Bucket = Bucket;
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
        //      C# -> RcsTierEnumType? RcvTier
        // GraphQL -> rcvTier: RcsTierEnumType! (enum)
        if (this.RcvTier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rcvTier\n" ;
            } else {
                s += ind + "rcvTier\n" ;
            }
        }
        //      C# -> RcvRedundancy? Redundancy
        // GraphQL -> redundancy: RcvRedundancy! (enum)
        if (this.Redundancy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "redundancy\n" ;
            } else {
                s += ind + "redundancy\n" ;
            }
        }
        //      C# -> AwsRegion? Region
        // GraphQL -> region: AwsRegion! (enum)
        if (this.Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "region\n" ;
            } else {
                s += ind + "region\n" ;
            }
        }
        //      C# -> System.String? Bucket
        // GraphQL -> bucket: String! (scalar)
        if (this.Bucket != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bucket\n" ;
            } else {
                s += ind + "bucket\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> RcsTierEnumType? RcvTier
        // GraphQL -> rcvTier: RcsTierEnumType! (enum)
        if (ec.Includes("rcvTier",true))
        {
            if(this.RcvTier == null) {

                this.RcvTier = new RcsTierEnumType();

            } else {


            }
        }
        else if (this.RcvTier != null && ec.Excludes("rcvTier",true))
        {
            this.RcvTier = null;
        }
        //      C# -> RcvRedundancy? Redundancy
        // GraphQL -> redundancy: RcvRedundancy! (enum)
        if (ec.Includes("redundancy",true))
        {
            if(this.Redundancy == null) {

                this.Redundancy = new RcvRedundancy();

            } else {


            }
        }
        else if (this.Redundancy != null && ec.Excludes("redundancy",true))
        {
            this.Redundancy = null;
        }
        //      C# -> AwsRegion? Region
        // GraphQL -> region: AwsRegion! (enum)
        if (ec.Includes("region",true))
        {
            if(this.Region == null) {

                this.Region = new AwsRegion();

            } else {


            }
        }
        else if (this.Region != null && ec.Excludes("region",true))
        {
            this.Region = null;
        }
        //      C# -> System.String? Bucket
        // GraphQL -> bucket: String! (scalar)
        if (ec.Includes("bucket",true))
        {
            if(this.Bucket == null) {

                this.Bucket = "FETCH";

            } else {


            }
        }
        else if (this.Bucket != null && ec.Excludes("bucket",true))
        {
            this.Bucket = null;
        }
    }


    #endregion

    } // class RcvAwsArchivalMigrationTarget
    
    #endregion

    public static class ListRcvAwsArchivalMigrationTargetExtensions
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
            this List<RcvAwsArchivalMigrationTarget> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RcvAwsArchivalMigrationTarget> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RcvAwsArchivalMigrationTarget> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RcvAwsArchivalMigrationTarget());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RcvAwsArchivalMigrationTarget> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types