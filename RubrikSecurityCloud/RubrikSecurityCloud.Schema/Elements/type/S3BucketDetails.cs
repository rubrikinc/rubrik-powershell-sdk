// S3BucketDetails.cs
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
    #region S3BucketDetails
    public class S3BucketDetails: BaseType
    {
        #region members

        //      C# -> AwsCloudAccountRegion? RegionEnum
        // GraphQL -> regionEnum: AwsCloudAccountRegion! (enum)
        [JsonProperty("regionEnum")]
        public AwsCloudAccountRegion? RegionEnum { get; set; }

        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        [JsonProperty("arn")]
        public System.String? Arn { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        [JsonProperty("region")]
        public System.String? Region { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "S3BucketDetails";
    }

    public S3BucketDetails Set(
        AwsCloudAccountRegion? RegionEnum = null,
        System.String? Arn = null,
        System.String? Name = null,
        System.String? Region = null
    ) 
    {
        if ( RegionEnum != null ) {
            this.RegionEnum = RegionEnum;
        }
        if ( Arn != null ) {
            this.Arn = Arn;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Region != null ) {
            this.Region = Region;
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
        //      C# -> AwsCloudAccountRegion? RegionEnum
        // GraphQL -> regionEnum: AwsCloudAccountRegion! (enum)
        if (this.RegionEnum != null) {
            if (conf.Flat) {
                s += conf.Prefix + "regionEnum\n" ;
            } else {
                s += ind + "regionEnum\n" ;
            }
        }
        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        if (this.Arn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "arn\n" ;
            } else {
                s += ind + "arn\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AwsCloudAccountRegion? RegionEnum
        // GraphQL -> regionEnum: AwsCloudAccountRegion! (enum)
        if (ec.Includes("regionEnum",true))
        {
            if(this.RegionEnum == null) {

                this.RegionEnum = new AwsCloudAccountRegion();

            } else {


            }
        }
        else if (this.RegionEnum != null && ec.Excludes("regionEnum",true))
        {
            this.RegionEnum = null;
        }
        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        if (ec.Includes("arn",true))
        {
            if(this.Arn == null) {

                this.Arn = "FETCH";

            } else {


            }
        }
        else if (this.Arn != null && ec.Excludes("arn",true))
        {
            this.Arn = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
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
    }


    #endregion

    } // class S3BucketDetails
    
    #endregion

    public static class ListS3BucketDetailsExtensions
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
            this List<S3BucketDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<S3BucketDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<S3BucketDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new S3BucketDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<S3BucketDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types