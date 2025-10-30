// ValidatePermissionsForFeatureReply.cs
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
    #region ValidatePermissionsForFeatureReply
    public class ValidatePermissionsForFeatureReply: BaseType
    {
        #region members

        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        [JsonProperty("feature")]
        public CloudAccountFeature? Feature { get; set; }

        //      C# -> SuccessStatus? Status
        // GraphQL -> status: SuccessStatus! (enum)
        [JsonProperty("status")]
        public SuccessStatus? Status { get; set; }

        //      C# -> System.Int32? NumMissingPermissions
        // GraphQL -> numMissingPermissions: Int! (scalar)
        [JsonProperty("numMissingPermissions")]
        public System.Int32? NumMissingPermissions { get; set; }

        //      C# -> List<ValidatePermissionsForRoleReply>? RoleResults
        // GraphQL -> roleResults: [ValidatePermissionsForRoleReply!]! (type)
        [JsonProperty("roleResults")]
        public List<ValidatePermissionsForRoleReply>? RoleResults { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ValidatePermissionsForFeatureReply";
    }

    public ValidatePermissionsForFeatureReply Set(
        CloudAccountFeature? Feature = null,
        SuccessStatus? Status = null,
        System.Int32? NumMissingPermissions = null,
        List<ValidatePermissionsForRoleReply>? RoleResults = null
    ) 
    {
        if ( Feature != null ) {
            this.Feature = Feature;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( NumMissingPermissions != null ) {
            this.NumMissingPermissions = NumMissingPermissions;
        }
        if ( RoleResults != null ) {
            this.RoleResults = RoleResults;
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
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (this.Feature != null) {
            if (conf.Flat) {
                s += conf.Prefix + "feature\n" ;
            } else {
                s += ind + "feature\n" ;
            }
        }
        //      C# -> SuccessStatus? Status
        // GraphQL -> status: SuccessStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.Int32? NumMissingPermissions
        // GraphQL -> numMissingPermissions: Int! (scalar)
        if (this.NumMissingPermissions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numMissingPermissions\n" ;
            } else {
                s += ind + "numMissingPermissions\n" ;
            }
        }
        //      C# -> List<ValidatePermissionsForRoleReply>? RoleResults
        // GraphQL -> roleResults: [ValidatePermissionsForRoleReply!]! (type)
        if (this.RoleResults != null) {
            var fspec = this.RoleResults.AsFieldSpec(conf.Child("roleResults"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "roleResults" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (ec.Includes("feature",true))
        {
            if(this.Feature == null) {

                this.Feature = new CloudAccountFeature();

            } else {


            }
        }
        else if (this.Feature != null && ec.Excludes("feature",true))
        {
            this.Feature = null;
        }
        //      C# -> SuccessStatus? Status
        // GraphQL -> status: SuccessStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new SuccessStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.Int32? NumMissingPermissions
        // GraphQL -> numMissingPermissions: Int! (scalar)
        if (ec.Includes("numMissingPermissions",true))
        {
            if(this.NumMissingPermissions == null) {

                this.NumMissingPermissions = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumMissingPermissions != null && ec.Excludes("numMissingPermissions",true))
        {
            this.NumMissingPermissions = null;
        }
        //      C# -> List<ValidatePermissionsForRoleReply>? RoleResults
        // GraphQL -> roleResults: [ValidatePermissionsForRoleReply!]! (type)
        if (ec.Includes("roleResults",false))
        {
            if(this.RoleResults == null) {

                this.RoleResults = new List<ValidatePermissionsForRoleReply>();
                this.RoleResults.ApplyExploratoryFieldSpec(ec.NewChild("roleResults"));

            } else {

                this.RoleResults.ApplyExploratoryFieldSpec(ec.NewChild("roleResults"));

            }
        }
        else if (this.RoleResults != null && ec.Excludes("roleResults",false))
        {
            this.RoleResults = null;
        }
    }


    #endregion

    } // class ValidatePermissionsForFeatureReply
    
    #endregion

    public static class ListValidatePermissionsForFeatureReplyExtensions
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
            this List<ValidatePermissionsForFeatureReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ValidatePermissionsForFeatureReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ValidatePermissionsForFeatureReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ValidatePermissionsForFeatureReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ValidatePermissionsForFeatureReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types