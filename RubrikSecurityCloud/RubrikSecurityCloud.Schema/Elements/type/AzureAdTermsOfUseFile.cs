// AzureAdTermsOfUseFile.cs
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
    #region AzureAdTermsOfUseFile
    public class AzureAdTermsOfUseFile: BaseType
    {
        #region members

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        [JsonProperty("fileName")]
        public System.String? FileName { get; set; }

        //      C# -> System.String? LanguageCode
        // GraphQL -> languageCode: String! (scalar)
        [JsonProperty("languageCode")]
        public System.String? LanguageCode { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdTermsOfUseFile";
    }

    public AzureAdTermsOfUseFile Set(
        System.String? DisplayName = null,
        System.String? FileName = null,
        System.String? LanguageCode = null
    ) 
    {
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( FileName != null ) {
            this.FileName = FileName;
        }
        if ( LanguageCode != null ) {
            this.LanguageCode = LanguageCode;
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
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayName\n" ;
            } else {
                s += ind + "displayName\n" ;
            }
        }
        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        if (this.FileName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileName\n" ;
            } else {
                s += ind + "fileName\n" ;
            }
        }
        //      C# -> System.String? LanguageCode
        // GraphQL -> languageCode: String! (scalar)
        if (this.LanguageCode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "languageCode\n" ;
            } else {
                s += ind + "languageCode\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (ec.Includes("displayName",true))
        {
            if(this.DisplayName == null) {

                this.DisplayName = "FETCH";

            } else {


            }
        }
        else if (this.DisplayName != null && ec.Excludes("displayName",true))
        {
            this.DisplayName = null;
        }
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
        //      C# -> System.String? LanguageCode
        // GraphQL -> languageCode: String! (scalar)
        if (ec.Includes("languageCode",true))
        {
            if(this.LanguageCode == null) {

                this.LanguageCode = "FETCH";

            } else {


            }
        }
        else if (this.LanguageCode != null && ec.Excludes("languageCode",true))
        {
            this.LanguageCode = null;
        }
    }


    #endregion

    } // class AzureAdTermsOfUseFile
    
    #endregion

    public static class ListAzureAdTermsOfUseFileExtensions
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
            this List<AzureAdTermsOfUseFile> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdTermsOfUseFile> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdTermsOfUseFile> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdTermsOfUseFile());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdTermsOfUseFile> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types