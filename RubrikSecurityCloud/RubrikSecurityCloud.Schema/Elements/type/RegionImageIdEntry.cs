// RegionImageIdEntry.cs
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
    #region RegionImageIdEntry
    public class RegionImageIdEntry: BaseType
    {
        #region members

        //      C# -> AwsCommonRegion? Region
        // GraphQL -> region: AwsCommonRegion! (enum)
        [JsonProperty("region")]
        public AwsCommonRegion? Region { get; set; }

        //      C# -> System.String? ImageId
        // GraphQL -> imageId: String! (scalar)
        [JsonProperty("imageId")]
        public System.String? ImageId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RegionImageIdEntry";
    }

    public RegionImageIdEntry Set(
        AwsCommonRegion? Region = null,
        System.String? ImageId = null
    ) 
    {
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( ImageId != null ) {
            this.ImageId = ImageId;
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
        //      C# -> AwsCommonRegion? Region
        // GraphQL -> region: AwsCommonRegion! (enum)
        if (this.Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "region\n" ;
            } else {
                s += ind + "region\n" ;
            }
        }
        //      C# -> System.String? ImageId
        // GraphQL -> imageId: String! (scalar)
        if (this.ImageId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "imageId\n" ;
            } else {
                s += ind + "imageId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AwsCommonRegion? Region
        // GraphQL -> region: AwsCommonRegion! (enum)
        if (ec.Includes("region",true))
        {
            if(this.Region == null) {

                this.Region = new AwsCommonRegion();

            } else {


            }
        }
        else if (this.Region != null && ec.Excludes("region",true))
        {
            this.Region = null;
        }
        //      C# -> System.String? ImageId
        // GraphQL -> imageId: String! (scalar)
        if (ec.Includes("imageId",true))
        {
            if(this.ImageId == null) {

                this.ImageId = "FETCH";

            } else {


            }
        }
        else if (this.ImageId != null && ec.Excludes("imageId",true))
        {
            this.ImageId = null;
        }
    }


    #endregion

    } // class RegionImageIdEntry
    
    #endregion

    public static class ListRegionImageIdEntryExtensions
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
            this List<RegionImageIdEntry> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RegionImageIdEntry> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RegionImageIdEntry> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RegionImageIdEntry());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RegionImageIdEntry> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types