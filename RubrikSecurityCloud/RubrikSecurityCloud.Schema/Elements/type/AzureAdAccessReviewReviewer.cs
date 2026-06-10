// AzureAdAccessReviewReviewer.cs
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
    #region AzureAdAccessReviewReviewer
    public class AzureAdAccessReviewReviewer: BaseType
    {
        #region members

        //      C# -> AzureAdObjectType? Type
        // GraphQL -> type: AzureAdObjectType! (enum)
        [JsonProperty("type")]
        public AzureAdObjectType? Type { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.Boolean? IsFallback
        // GraphQL -> isFallback: Boolean! (scalar)
        [JsonProperty("isFallback")]
        public System.Boolean? IsFallback { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdAccessReviewReviewer";
    }

    public AzureAdAccessReviewReviewer Set(
        AzureAdObjectType? Type = null,
        System.String? DisplayName = null,
        System.Boolean? IsFallback = null
    ) 
    {
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( IsFallback != null ) {
            this.IsFallback = IsFallback;
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
        //      C# -> AzureAdObjectType? Type
        // GraphQL -> type: AzureAdObjectType! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayName\n" ;
            } else {
                s += ind + "displayName\n" ;
            }
        }
        //      C# -> System.Boolean? IsFallback
        // GraphQL -> isFallback: Boolean! (scalar)
        if (this.IsFallback != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isFallback\n" ;
            } else {
                s += ind + "isFallback\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AzureAdObjectType? Type
        // GraphQL -> type: AzureAdObjectType! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new AzureAdObjectType();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
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
        //      C# -> System.Boolean? IsFallback
        // GraphQL -> isFallback: Boolean! (scalar)
        if (ec.Includes("isFallback",true))
        {
            if(this.IsFallback == null) {

                this.IsFallback = true;

            } else {


            }
        }
        else if (this.IsFallback != null && ec.Excludes("isFallback",true))
        {
            this.IsFallback = null;
        }
    }


    #endregion

    } // class AzureAdAccessReviewReviewer
    
    #endregion

    public static class ListAzureAdAccessReviewReviewerExtensions
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
            this List<AzureAdAccessReviewReviewer> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdAccessReviewReviewer> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdAccessReviewReviewer> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdAccessReviewReviewer());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdAccessReviewReviewer> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types