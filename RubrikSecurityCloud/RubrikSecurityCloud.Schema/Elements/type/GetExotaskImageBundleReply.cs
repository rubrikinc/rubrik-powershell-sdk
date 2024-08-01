// GetExotaskImageBundleReply.cs
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
    #region GetExotaskImageBundleReply
    public class GetExotaskImageBundleReply: BaseType
    {
        #region members

        //      C# -> System.String? BundleVersion
        // GraphQL -> bundleVersion: String! (scalar)
        [JsonProperty("bundleVersion")]
        public System.String? BundleVersion { get; set; }

        //      C# -> System.String? EksVersion
        // GraphQL -> eksVersion: String! (scalar)
        [JsonProperty("eksVersion")]
        public System.String? EksVersion { get; set; }

        //      C# -> System.String? RepoUrl
        // GraphQL -> repoUrl: String! (scalar)
        [JsonProperty("repoUrl")]
        public System.String? RepoUrl { get; set; }

        //      C# -> List<BundleImage>? BundleImages
        // GraphQL -> bundleImages: [BundleImage!]! (type)
        [JsonProperty("bundleImages")]
        public List<BundleImage>? BundleImages { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetExotaskImageBundleReply";
    }

    public GetExotaskImageBundleReply Set(
        System.String? BundleVersion = null,
        System.String? EksVersion = null,
        System.String? RepoUrl = null,
        List<BundleImage>? BundleImages = null
    ) 
    {
        if ( BundleVersion != null ) {
            this.BundleVersion = BundleVersion;
        }
        if ( EksVersion != null ) {
            this.EksVersion = EksVersion;
        }
        if ( RepoUrl != null ) {
            this.RepoUrl = RepoUrl;
        }
        if ( BundleImages != null ) {
            this.BundleImages = BundleImages;
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
        //      C# -> System.String? BundleVersion
        // GraphQL -> bundleVersion: String! (scalar)
        if (this.BundleVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bundleVersion\n" ;
            } else {
                s += ind + "bundleVersion\n" ;
            }
        }
        //      C# -> System.String? EksVersion
        // GraphQL -> eksVersion: String! (scalar)
        if (this.EksVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eksVersion\n" ;
            } else {
                s += ind + "eksVersion\n" ;
            }
        }
        //      C# -> System.String? RepoUrl
        // GraphQL -> repoUrl: String! (scalar)
        if (this.RepoUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "repoUrl\n" ;
            } else {
                s += ind + "repoUrl\n" ;
            }
        }
        //      C# -> List<BundleImage>? BundleImages
        // GraphQL -> bundleImages: [BundleImage!]! (type)
        if (this.BundleImages != null) {
            var fspec = this.BundleImages.AsFieldSpec(conf.Child("bundleImages"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "bundleImages" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? BundleVersion
        // GraphQL -> bundleVersion: String! (scalar)
        if (ec.Includes("bundleVersion",true))
        {
            if(this.BundleVersion == null) {

                this.BundleVersion = "FETCH";

            } else {


            }
        }
        else if (this.BundleVersion != null && ec.Excludes("bundleVersion",true))
        {
            this.BundleVersion = null;
        }
        //      C# -> System.String? EksVersion
        // GraphQL -> eksVersion: String! (scalar)
        if (ec.Includes("eksVersion",true))
        {
            if(this.EksVersion == null) {

                this.EksVersion = "FETCH";

            } else {


            }
        }
        else if (this.EksVersion != null && ec.Excludes("eksVersion",true))
        {
            this.EksVersion = null;
        }
        //      C# -> System.String? RepoUrl
        // GraphQL -> repoUrl: String! (scalar)
        if (ec.Includes("repoUrl",true))
        {
            if(this.RepoUrl == null) {

                this.RepoUrl = "FETCH";

            } else {


            }
        }
        else if (this.RepoUrl != null && ec.Excludes("repoUrl",true))
        {
            this.RepoUrl = null;
        }
        //      C# -> List<BundleImage>? BundleImages
        // GraphQL -> bundleImages: [BundleImage!]! (type)
        if (ec.Includes("bundleImages",false))
        {
            if(this.BundleImages == null) {

                this.BundleImages = new List<BundleImage>();
                this.BundleImages.ApplyExploratoryFieldSpec(ec.NewChild("bundleImages"));

            } else {

                this.BundleImages.ApplyExploratoryFieldSpec(ec.NewChild("bundleImages"));

            }
        }
        else if (this.BundleImages != null && ec.Excludes("bundleImages",false))
        {
            this.BundleImages = null;
        }
    }


    #endregion

    } // class GetExotaskImageBundleReply
    
    #endregion

    public static class ListGetExotaskImageBundleReplyExtensions
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
            this List<GetExotaskImageBundleReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetExotaskImageBundleReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetExotaskImageBundleReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetExotaskImageBundleReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetExotaskImageBundleReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types