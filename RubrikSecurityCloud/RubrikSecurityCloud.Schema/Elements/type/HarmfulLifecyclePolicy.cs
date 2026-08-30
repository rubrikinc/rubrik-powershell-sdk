// HarmfulLifecyclePolicy.cs
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
    #region HarmfulLifecyclePolicy
    public class HarmfulLifecyclePolicy: BaseType
    {
        #region members

        //      C# -> TargetType? LocationType
        // GraphQL -> locationType: TargetType! (enum)
        [JsonProperty("locationType")]
        public TargetType? LocationType { get; set; }

        //      C# -> System.String? BucketName
        // GraphQL -> bucketName: String! (scalar)
        [JsonProperty("bucketName")]
        public System.String? BucketName { get; set; }

        //      C# -> System.String? DefaultStorageClass
        // GraphQL -> defaultStorageClass: String! (scalar)
        [JsonProperty("defaultStorageClass")]
        public System.String? DefaultStorageClass { get; set; }

        //      C# -> System.String? LocationId
        // GraphQL -> locationId: UUID! (scalar)
        [JsonProperty("locationId")]
        public System.String? LocationId { get; set; }

        //      C# -> System.String? LocationName
        // GraphQL -> locationName: String! (scalar)
        [JsonProperty("locationName")]
        public System.String? LocationName { get; set; }

        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        [JsonProperty("region")]
        public System.String? Region { get; set; }

        //      C# -> System.String? RuleId
        // GraphQL -> ruleId: String! (scalar)
        [JsonProperty("ruleId")]
        public System.String? RuleId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HarmfulLifecyclePolicy";
    }

    public HarmfulLifecyclePolicy Set(
        TargetType? LocationType = null,
        System.String? BucketName = null,
        System.String? DefaultStorageClass = null,
        System.String? LocationId = null,
        System.String? LocationName = null,
        System.String? Region = null,
        System.String? RuleId = null
    ) 
    {
        if ( LocationType != null ) {
            this.LocationType = LocationType;
        }
        if ( BucketName != null ) {
            this.BucketName = BucketName;
        }
        if ( DefaultStorageClass != null ) {
            this.DefaultStorageClass = DefaultStorageClass;
        }
        if ( LocationId != null ) {
            this.LocationId = LocationId;
        }
        if ( LocationName != null ) {
            this.LocationName = LocationName;
        }
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( RuleId != null ) {
            this.RuleId = RuleId;
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
        //      C# -> TargetType? LocationType
        // GraphQL -> locationType: TargetType! (enum)
        if (this.LocationType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationType\n" ;
            } else {
                s += ind + "locationType\n" ;
            }
        }
        //      C# -> System.String? BucketName
        // GraphQL -> bucketName: String! (scalar)
        if (this.BucketName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bucketName\n" ;
            } else {
                s += ind + "bucketName\n" ;
            }
        }
        //      C# -> System.String? DefaultStorageClass
        // GraphQL -> defaultStorageClass: String! (scalar)
        if (this.DefaultStorageClass != null) {
            if (conf.Flat) {
                s += conf.Prefix + "defaultStorageClass\n" ;
            } else {
                s += ind + "defaultStorageClass\n" ;
            }
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: UUID! (scalar)
        if (this.LocationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationId\n" ;
            } else {
                s += ind + "locationId\n" ;
            }
        }
        //      C# -> System.String? LocationName
        // GraphQL -> locationName: String! (scalar)
        if (this.LocationName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationName\n" ;
            } else {
                s += ind + "locationName\n" ;
            }
        }
        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        if (this.Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "region\n" ;
            } else {
                s += ind + "region\n" ;
            }
        }
        //      C# -> System.String? RuleId
        // GraphQL -> ruleId: String! (scalar)
        if (this.RuleId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ruleId\n" ;
            } else {
                s += ind + "ruleId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> TargetType? LocationType
        // GraphQL -> locationType: TargetType! (enum)
        if (ec.Includes("locationType",true))
        {
            if(this.LocationType == null) {

                this.LocationType = new TargetType();

            } else {


            }
        }
        else if (this.LocationType != null && ec.Excludes("locationType",true))
        {
            this.LocationType = null;
        }
        //      C# -> System.String? BucketName
        // GraphQL -> bucketName: String! (scalar)
        if (ec.Includes("bucketName",true))
        {
            if(this.BucketName == null) {

                this.BucketName = "FETCH";

            } else {


            }
        }
        else if (this.BucketName != null && ec.Excludes("bucketName",true))
        {
            this.BucketName = null;
        }
        //      C# -> System.String? DefaultStorageClass
        // GraphQL -> defaultStorageClass: String! (scalar)
        if (ec.Includes("defaultStorageClass",true))
        {
            if(this.DefaultStorageClass == null) {

                this.DefaultStorageClass = "FETCH";

            } else {


            }
        }
        else if (this.DefaultStorageClass != null && ec.Excludes("defaultStorageClass",true))
        {
            this.DefaultStorageClass = null;
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: UUID! (scalar)
        if (ec.Includes("locationId",true))
        {
            if(this.LocationId == null) {

                this.LocationId = "FETCH";

            } else {


            }
        }
        else if (this.LocationId != null && ec.Excludes("locationId",true))
        {
            this.LocationId = null;
        }
        //      C# -> System.String? LocationName
        // GraphQL -> locationName: String! (scalar)
        if (ec.Includes("locationName",true))
        {
            if(this.LocationName == null) {

                this.LocationName = "FETCH";

            } else {


            }
        }
        else if (this.LocationName != null && ec.Excludes("locationName",true))
        {
            this.LocationName = null;
        }
        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        if (ec.Includes("region",true))
        {
            if(this.Region == null) {

                this.Region = "FETCH";

            } else {


            }
        }
        else if (this.Region != null && ec.Excludes("region",true))
        {
            this.Region = null;
        }
        //      C# -> System.String? RuleId
        // GraphQL -> ruleId: String! (scalar)
        if (ec.Includes("ruleId",true))
        {
            if(this.RuleId == null) {

                this.RuleId = "FETCH";

            } else {


            }
        }
        else if (this.RuleId != null && ec.Excludes("ruleId",true))
        {
            this.RuleId = null;
        }
    }


    #endregion

    } // class HarmfulLifecyclePolicy
    
    #endregion

    public static class ListHarmfulLifecyclePolicyExtensions
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
            this List<HarmfulLifecyclePolicy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HarmfulLifecyclePolicy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HarmfulLifecyclePolicy> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HarmfulLifecyclePolicy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HarmfulLifecyclePolicy> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types