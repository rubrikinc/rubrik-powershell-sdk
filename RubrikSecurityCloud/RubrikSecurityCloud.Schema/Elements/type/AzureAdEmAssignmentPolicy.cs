// AzureAdEmAssignmentPolicy.cs
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
    #region AzureAdEmAssignmentPolicy
    public class AzureAdEmAssignmentPolicy: BaseType
    {
        #region members

        //      C# -> EmAllowedTargetScope? AllowedTargetScope
        // GraphQL -> allowedTargetScope: EmAllowedTargetScope! (enum)
        [JsonProperty("allowedTargetScope")]
        public EmAllowedTargetScope? AllowedTargetScope { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.Boolean? IsAccessReviewRequired
        // GraphQL -> isAccessReviewRequired: Boolean! (scalar)
        [JsonProperty("isAccessReviewRequired")]
        public System.Boolean? IsAccessReviewRequired { get; set; }

        //      C# -> System.Boolean? IsApprovalRequired
        // GraphQL -> isApprovalRequired: Boolean! (scalar)
        [JsonProperty("isApprovalRequired")]
        public System.Boolean? IsApprovalRequired { get; set; }

        //      C# -> System.Boolean? IsJustificationRequired
        // GraphQL -> isJustificationRequired: Boolean! (scalar)
        [JsonProperty("isJustificationRequired")]
        public System.Boolean? IsJustificationRequired { get; set; }

        //      C# -> List<System.String>? SpecificAllowedTargets
        // GraphQL -> specificAllowedTargets: [String!]! (scalar)
        [JsonProperty("specificAllowedTargets")]
        public List<System.String>? SpecificAllowedTargets { get; set; }

        //      C# -> List<System.String>? WhoCanRequestAccess
        // GraphQL -> whoCanRequestAccess: [String!]! (scalar)
        [JsonProperty("whoCanRequestAccess")]
        public List<System.String>? WhoCanRequestAccess { get; set; }

        //      C# -> AzureAdEmExpiration? Expiration
        // GraphQL -> expiration: AzureAdEmExpiration (type)
        [JsonProperty("expiration")]
        public AzureAdEmExpiration? Expiration { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdEmAssignmentPolicy";
    }

    public AzureAdEmAssignmentPolicy Set(
        EmAllowedTargetScope? AllowedTargetScope = null,
        System.String? Description = null,
        System.String? DisplayName = null,
        System.Boolean? IsAccessReviewRequired = null,
        System.Boolean? IsApprovalRequired = null,
        System.Boolean? IsJustificationRequired = null,
        List<System.String>? SpecificAllowedTargets = null,
        List<System.String>? WhoCanRequestAccess = null,
        AzureAdEmExpiration? Expiration = null
    ) 
    {
        if ( AllowedTargetScope != null ) {
            this.AllowedTargetScope = AllowedTargetScope;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( IsAccessReviewRequired != null ) {
            this.IsAccessReviewRequired = IsAccessReviewRequired;
        }
        if ( IsApprovalRequired != null ) {
            this.IsApprovalRequired = IsApprovalRequired;
        }
        if ( IsJustificationRequired != null ) {
            this.IsJustificationRequired = IsJustificationRequired;
        }
        if ( SpecificAllowedTargets != null ) {
            this.SpecificAllowedTargets = SpecificAllowedTargets;
        }
        if ( WhoCanRequestAccess != null ) {
            this.WhoCanRequestAccess = WhoCanRequestAccess;
        }
        if ( Expiration != null ) {
            this.Expiration = Expiration;
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
        //      C# -> EmAllowedTargetScope? AllowedTargetScope
        // GraphQL -> allowedTargetScope: EmAllowedTargetScope! (enum)
        if (this.AllowedTargetScope != null) {
            if (conf.Flat) {
                s += conf.Prefix + "allowedTargetScope\n" ;
            } else {
                s += ind + "allowedTargetScope\n" ;
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
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
        //      C# -> System.Boolean? IsAccessReviewRequired
        // GraphQL -> isAccessReviewRequired: Boolean! (scalar)
        if (this.IsAccessReviewRequired != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAccessReviewRequired\n" ;
            } else {
                s += ind + "isAccessReviewRequired\n" ;
            }
        }
        //      C# -> System.Boolean? IsApprovalRequired
        // GraphQL -> isApprovalRequired: Boolean! (scalar)
        if (this.IsApprovalRequired != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isApprovalRequired\n" ;
            } else {
                s += ind + "isApprovalRequired\n" ;
            }
        }
        //      C# -> System.Boolean? IsJustificationRequired
        // GraphQL -> isJustificationRequired: Boolean! (scalar)
        if (this.IsJustificationRequired != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isJustificationRequired\n" ;
            } else {
                s += ind + "isJustificationRequired\n" ;
            }
        }
        //      C# -> List<System.String>? SpecificAllowedTargets
        // GraphQL -> specificAllowedTargets: [String!]! (scalar)
        if (this.SpecificAllowedTargets != null) {
            if (conf.Flat) {
                s += conf.Prefix + "specificAllowedTargets\n" ;
            } else {
                s += ind + "specificAllowedTargets\n" ;
            }
        }
        //      C# -> List<System.String>? WhoCanRequestAccess
        // GraphQL -> whoCanRequestAccess: [String!]! (scalar)
        if (this.WhoCanRequestAccess != null) {
            if (conf.Flat) {
                s += conf.Prefix + "whoCanRequestAccess\n" ;
            } else {
                s += ind + "whoCanRequestAccess\n" ;
            }
        }
        //      C# -> AzureAdEmExpiration? Expiration
        // GraphQL -> expiration: AzureAdEmExpiration (type)
        if (this.Expiration != null) {
            var fspec = this.Expiration.AsFieldSpec(conf.Child("expiration"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "expiration" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> EmAllowedTargetScope? AllowedTargetScope
        // GraphQL -> allowedTargetScope: EmAllowedTargetScope! (enum)
        if (ec.Includes("allowedTargetScope",true))
        {
            if(this.AllowedTargetScope == null) {

                this.AllowedTargetScope = new EmAllowedTargetScope();

            } else {


            }
        }
        else if (this.AllowedTargetScope != null && ec.Excludes("allowedTargetScope",true))
        {
            this.AllowedTargetScope = null;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
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
        //      C# -> System.Boolean? IsAccessReviewRequired
        // GraphQL -> isAccessReviewRequired: Boolean! (scalar)
        if (ec.Includes("isAccessReviewRequired",true))
        {
            if(this.IsAccessReviewRequired == null) {

                this.IsAccessReviewRequired = true;

            } else {


            }
        }
        else if (this.IsAccessReviewRequired != null && ec.Excludes("isAccessReviewRequired",true))
        {
            this.IsAccessReviewRequired = null;
        }
        //      C# -> System.Boolean? IsApprovalRequired
        // GraphQL -> isApprovalRequired: Boolean! (scalar)
        if (ec.Includes("isApprovalRequired",true))
        {
            if(this.IsApprovalRequired == null) {

                this.IsApprovalRequired = true;

            } else {


            }
        }
        else if (this.IsApprovalRequired != null && ec.Excludes("isApprovalRequired",true))
        {
            this.IsApprovalRequired = null;
        }
        //      C# -> System.Boolean? IsJustificationRequired
        // GraphQL -> isJustificationRequired: Boolean! (scalar)
        if (ec.Includes("isJustificationRequired",true))
        {
            if(this.IsJustificationRequired == null) {

                this.IsJustificationRequired = true;

            } else {


            }
        }
        else if (this.IsJustificationRequired != null && ec.Excludes("isJustificationRequired",true))
        {
            this.IsJustificationRequired = null;
        }
        //      C# -> List<System.String>? SpecificAllowedTargets
        // GraphQL -> specificAllowedTargets: [String!]! (scalar)
        if (ec.Includes("specificAllowedTargets",true))
        {
            if(this.SpecificAllowedTargets == null) {

                this.SpecificAllowedTargets = new List<System.String>();

            } else {


            }
        }
        else if (this.SpecificAllowedTargets != null && ec.Excludes("specificAllowedTargets",true))
        {
            this.SpecificAllowedTargets = null;
        }
        //      C# -> List<System.String>? WhoCanRequestAccess
        // GraphQL -> whoCanRequestAccess: [String!]! (scalar)
        if (ec.Includes("whoCanRequestAccess",true))
        {
            if(this.WhoCanRequestAccess == null) {

                this.WhoCanRequestAccess = new List<System.String>();

            } else {


            }
        }
        else if (this.WhoCanRequestAccess != null && ec.Excludes("whoCanRequestAccess",true))
        {
            this.WhoCanRequestAccess = null;
        }
        //      C# -> AzureAdEmExpiration? Expiration
        // GraphQL -> expiration: AzureAdEmExpiration (type)
        if (ec.Includes("expiration",false))
        {
            if(this.Expiration == null) {

                this.Expiration = new AzureAdEmExpiration();
                this.Expiration.ApplyExploratoryFieldSpec(ec.NewChild("expiration"));

            } else {

                this.Expiration.ApplyExploratoryFieldSpec(ec.NewChild("expiration"));

            }
        }
        else if (this.Expiration != null && ec.Excludes("expiration",false))
        {
            this.Expiration = null;
        }
    }


    #endregion

    } // class AzureAdEmAssignmentPolicy
    
    #endregion

    public static class ListAzureAdEmAssignmentPolicyExtensions
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
            this List<AzureAdEmAssignmentPolicy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdEmAssignmentPolicy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdEmAssignmentPolicy> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdEmAssignmentPolicy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdEmAssignmentPolicy> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types