// GetBrandLogoReply.cs
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
    #region GetBrandLogoReply
    public class GetBrandLogoReply: BaseType
    {
        #region members

        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        [JsonProperty("fileName")]
        public System.String? FileName { get; set; }

        //      C# -> System.Int32? FileSizeBytes
        // GraphQL -> fileSizeBytes: Int! (scalar)
        [JsonProperty("fileSizeBytes")]
        public System.Int32? FileSizeBytes { get; set; }

        //      C# -> System.String? ImageBase64
        // GraphQL -> imageBase64: String! (scalar)
        [JsonProperty("imageBase64")]
        public System.String? ImageBase64 { get; set; }

        //      C# -> System.Boolean? IsUrlEnabled
        // GraphQL -> isUrlEnabled: Boolean! (scalar)
        [JsonProperty("isUrlEnabled")]
        public System.Boolean? IsUrlEnabled { get; set; }

        //      C# -> System.String? Url
        // GraphQL -> url: String! (scalar)
        [JsonProperty("url")]
        public System.String? Url { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetBrandLogoReply";
    }

    public GetBrandLogoReply Set(
        System.String? FileName = null,
        System.Int32? FileSizeBytes = null,
        System.String? ImageBase64 = null,
        System.Boolean? IsUrlEnabled = null,
        System.String? Url = null
    ) 
    {
        if ( FileName != null ) {
            this.FileName = FileName;
        }
        if ( FileSizeBytes != null ) {
            this.FileSizeBytes = FileSizeBytes;
        }
        if ( ImageBase64 != null ) {
            this.ImageBase64 = ImageBase64;
        }
        if ( IsUrlEnabled != null ) {
            this.IsUrlEnabled = IsUrlEnabled;
        }
        if ( Url != null ) {
            this.Url = Url;
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
        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        if (this.FileName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileName\n" ;
            } else {
                s += ind + "fileName\n" ;
            }
        }
        //      C# -> System.Int32? FileSizeBytes
        // GraphQL -> fileSizeBytes: Int! (scalar)
        if (this.FileSizeBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileSizeBytes\n" ;
            } else {
                s += ind + "fileSizeBytes\n" ;
            }
        }
        //      C# -> System.String? ImageBase64
        // GraphQL -> imageBase64: String! (scalar)
        if (this.ImageBase64 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "imageBase64\n" ;
            } else {
                s += ind + "imageBase64\n" ;
            }
        }
        //      C# -> System.Boolean? IsUrlEnabled
        // GraphQL -> isUrlEnabled: Boolean! (scalar)
        if (this.IsUrlEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isUrlEnabled\n" ;
            } else {
                s += ind + "isUrlEnabled\n" ;
            }
        }
        //      C# -> System.String? Url
        // GraphQL -> url: String! (scalar)
        if (this.Url != null) {
            if (conf.Flat) {
                s += conf.Prefix + "url\n" ;
            } else {
                s += ind + "url\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        if (ec.Includes("fileName",true))
        {
            if(this.FileName == null) {

                this.FileName = "FETCH";

            } else {


            }
        }
        else if (this.FileName != null && ec.Excludes("fileName",true))
        {
            this.FileName = null;
        }
        //      C# -> System.Int32? FileSizeBytes
        // GraphQL -> fileSizeBytes: Int! (scalar)
        if (ec.Includes("fileSizeBytes",true))
        {
            if(this.FileSizeBytes == null) {

                this.FileSizeBytes = Int32.MinValue;

            } else {


            }
        }
        else if (this.FileSizeBytes != null && ec.Excludes("fileSizeBytes",true))
        {
            this.FileSizeBytes = null;
        }
        //      C# -> System.String? ImageBase64
        // GraphQL -> imageBase64: String! (scalar)
        if (ec.Includes("imageBase64",true))
        {
            if(this.ImageBase64 == null) {

                this.ImageBase64 = "FETCH";

            } else {


            }
        }
        else if (this.ImageBase64 != null && ec.Excludes("imageBase64",true))
        {
            this.ImageBase64 = null;
        }
        //      C# -> System.Boolean? IsUrlEnabled
        // GraphQL -> isUrlEnabled: Boolean! (scalar)
        if (ec.Includes("isUrlEnabled",true))
        {
            if(this.IsUrlEnabled == null) {

                this.IsUrlEnabled = true;

            } else {


            }
        }
        else if (this.IsUrlEnabled != null && ec.Excludes("isUrlEnabled",true))
        {
            this.IsUrlEnabled = null;
        }
        //      C# -> System.String? Url
        // GraphQL -> url: String! (scalar)
        if (ec.Includes("url",true))
        {
            if(this.Url == null) {

                this.Url = "FETCH";

            } else {


            }
        }
        else if (this.Url != null && ec.Excludes("url",true))
        {
            this.Url = null;
        }
    }


    #endregion

    } // class GetBrandLogoReply
    
    #endregion

    public static class ListGetBrandLogoReplyExtensions
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
            this List<GetBrandLogoReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetBrandLogoReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetBrandLogoReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetBrandLogoReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetBrandLogoReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types