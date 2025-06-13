// GeneratePresignedUrlForDownloadReply.cs
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
    #region GeneratePresignedUrlForDownloadReply
    public class GeneratePresignedUrlForDownloadReply: BaseType
    {
        #region members

        //      C# -> System.Int64? ExpiresAt
        // GraphQL -> expiresAt: Long! (scalar)
        [JsonProperty("expiresAt")]
        public System.Int64? ExpiresAt { get; set; }

        //      C# -> System.String? PresignedUrl
        // GraphQL -> presignedUrl: String! (scalar)
        [JsonProperty("presignedUrl")]
        public System.String? PresignedUrl { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GeneratePresignedUrlForDownloadReply";
    }

    public GeneratePresignedUrlForDownloadReply Set(
        System.Int64? ExpiresAt = null,
        System.String? PresignedUrl = null
    ) 
    {
        if ( ExpiresAt != null ) {
            this.ExpiresAt = ExpiresAt;
        }
        if ( PresignedUrl != null ) {
            this.PresignedUrl = PresignedUrl;
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
        //      C# -> System.Int64? ExpiresAt
        // GraphQL -> expiresAt: Long! (scalar)
        if (this.ExpiresAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expiresAt\n" ;
            } else {
                s += ind + "expiresAt\n" ;
            }
        }
        //      C# -> System.String? PresignedUrl
        // GraphQL -> presignedUrl: String! (scalar)
        if (this.PresignedUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "presignedUrl\n" ;
            } else {
                s += ind + "presignedUrl\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? ExpiresAt
        // GraphQL -> expiresAt: Long! (scalar)
        if (ec.Includes("expiresAt",true))
        {
            if(this.ExpiresAt == null) {

                this.ExpiresAt = new System.Int64();

            } else {


            }
        }
        else if (this.ExpiresAt != null && ec.Excludes("expiresAt",true))
        {
            this.ExpiresAt = null;
        }
        //      C# -> System.String? PresignedUrl
        // GraphQL -> presignedUrl: String! (scalar)
        if (ec.Includes("presignedUrl",true))
        {
            if(this.PresignedUrl == null) {

                this.PresignedUrl = "FETCH";

            } else {


            }
        }
        else if (this.PresignedUrl != null && ec.Excludes("presignedUrl",true))
        {
            this.PresignedUrl = null;
        }
    }


    #endregion

    } // class GeneratePresignedUrlForDownloadReply
    
    #endregion

    public static class ListGeneratePresignedUrlForDownloadReplyExtensions
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
            this List<GeneratePresignedUrlForDownloadReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GeneratePresignedUrlForDownloadReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GeneratePresignedUrlForDownloadReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GeneratePresignedUrlForDownloadReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GeneratePresignedUrlForDownloadReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types