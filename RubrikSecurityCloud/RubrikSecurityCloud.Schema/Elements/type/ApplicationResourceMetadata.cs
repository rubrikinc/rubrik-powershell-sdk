// ApplicationResourceMetadata.cs
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
    #region ApplicationResourceMetadata
    public class ApplicationResourceMetadata: BaseType
    {
        #region members

        //      C# -> System.String? CloudNativeAccountId
        // GraphQL -> cloudNativeAccountId: String! (scalar)
        [JsonProperty("cloudNativeAccountId")]
        public System.String? CloudNativeAccountId { get; set; }

        //      C# -> System.String? NativeName
        // GraphQL -> nativeName: String! (scalar)
        [JsonProperty("nativeName")]
        public System.String? NativeName { get; set; }

        //      C# -> System.String? NativeUri
        // GraphQL -> nativeUri: String! (scalar)
        [JsonProperty("nativeUri")]
        public System.String? NativeUri { get; set; }

        //      C# -> CloudRegion? Region
        // GraphQL -> region: CloudRegion (type)
        [JsonProperty("region")]
        public CloudRegion? Region { get; set; }

        //      C# -> ResourceTag? Tags
        // GraphQL -> tags: ResourceTag! (type)
        [JsonProperty("tags")]
        public ResourceTag? Tags { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ApplicationResourceMetadata";
    }

    public ApplicationResourceMetadata Set(
        System.String? CloudNativeAccountId = null,
        System.String? NativeName = null,
        System.String? NativeUri = null,
        CloudRegion? Region = null,
        ResourceTag? Tags = null
    ) 
    {
        if ( CloudNativeAccountId != null ) {
            this.CloudNativeAccountId = CloudNativeAccountId;
        }
        if ( NativeName != null ) {
            this.NativeName = NativeName;
        }
        if ( NativeUri != null ) {
            this.NativeUri = NativeUri;
        }
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( Tags != null ) {
            this.Tags = Tags;
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
        //      C# -> System.String? CloudNativeAccountId
        // GraphQL -> cloudNativeAccountId: String! (scalar)
        if (this.CloudNativeAccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudNativeAccountId\n" ;
            } else {
                s += ind + "cloudNativeAccountId\n" ;
            }
        }
        //      C# -> System.String? NativeName
        // GraphQL -> nativeName: String! (scalar)
        if (this.NativeName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nativeName\n" ;
            } else {
                s += ind + "nativeName\n" ;
            }
        }
        //      C# -> System.String? NativeUri
        // GraphQL -> nativeUri: String! (scalar)
        if (this.NativeUri != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nativeUri\n" ;
            } else {
                s += ind + "nativeUri\n" ;
            }
        }
        //      C# -> CloudRegion? Region
        // GraphQL -> region: CloudRegion (type)
        if (this.Region != null) {
            var fspec = this.Region.AsFieldSpec(conf.Child("region"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "region" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ResourceTag? Tags
        // GraphQL -> tags: ResourceTag! (type)
        if (this.Tags != null) {
            var fspec = this.Tags.AsFieldSpec(conf.Child("tags"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "tags" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? CloudNativeAccountId
        // GraphQL -> cloudNativeAccountId: String! (scalar)
        if (ec.Includes("cloudNativeAccountId",true))
        {
            if(this.CloudNativeAccountId == null) {

                this.CloudNativeAccountId = "FETCH";

            } else {


            }
        }
        else if (this.CloudNativeAccountId != null && ec.Excludes("cloudNativeAccountId",true))
        {
            this.CloudNativeAccountId = null;
        }
        //      C# -> System.String? NativeName
        // GraphQL -> nativeName: String! (scalar)
        if (ec.Includes("nativeName",true))
        {
            if(this.NativeName == null) {

                this.NativeName = "FETCH";

            } else {


            }
        }
        else if (this.NativeName != null && ec.Excludes("nativeName",true))
        {
            this.NativeName = null;
        }
        //      C# -> System.String? NativeUri
        // GraphQL -> nativeUri: String! (scalar)
        if (ec.Includes("nativeUri",true))
        {
            if(this.NativeUri == null) {

                this.NativeUri = "FETCH";

            } else {


            }
        }
        else if (this.NativeUri != null && ec.Excludes("nativeUri",true))
        {
            this.NativeUri = null;
        }
        //      C# -> CloudRegion? Region
        // GraphQL -> region: CloudRegion (type)
        if (ec.Includes("region",false))
        {
            if(this.Region == null) {

                this.Region = new CloudRegion();
                this.Region.ApplyExploratoryFieldSpec(ec.NewChild("region"));

            } else {

                this.Region.ApplyExploratoryFieldSpec(ec.NewChild("region"));

            }
        }
        else if (this.Region != null && ec.Excludes("region",false))
        {
            this.Region = null;
        }
        //      C# -> ResourceTag? Tags
        // GraphQL -> tags: ResourceTag! (type)
        if (ec.Includes("tags",false))
        {
            if(this.Tags == null) {

                this.Tags = new ResourceTag();
                this.Tags.ApplyExploratoryFieldSpec(ec.NewChild("tags"));

            } else {

                this.Tags.ApplyExploratoryFieldSpec(ec.NewChild("tags"));

            }
        }
        else if (this.Tags != null && ec.Excludes("tags",false))
        {
            this.Tags = null;
        }
    }


    #endregion

    } // class ApplicationResourceMetadata
    
    #endregion

    public static class ListApplicationResourceMetadataExtensions
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
            this List<ApplicationResourceMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ApplicationResourceMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ApplicationResourceMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ApplicationResourceMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ApplicationResourceMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types