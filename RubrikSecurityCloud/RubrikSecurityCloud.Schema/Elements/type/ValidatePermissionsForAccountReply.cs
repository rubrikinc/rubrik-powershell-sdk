// ValidatePermissionsForAccountReply.cs
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
    #region ValidatePermissionsForAccountReply
    public class ValidatePermissionsForAccountReply: BaseType
    {
        #region members

        //      C# -> SuccessStatus? Status
        // GraphQL -> status: SuccessStatus! (enum)
        [JsonProperty("status")]
        public SuccessStatus? Status { get; set; }

        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String! (scalar)
        [JsonProperty("cloudAccountId")]
        public System.String? CloudAccountId { get; set; }

        //      C# -> System.String? CloudAccountName
        // GraphQL -> cloudAccountName: String! (scalar)
        [JsonProperty("cloudAccountName")]
        public System.String? CloudAccountName { get; set; }

        //      C# -> System.String? CloudAccountNativeId
        // GraphQL -> cloudAccountNativeId: String! (scalar)
        [JsonProperty("cloudAccountNativeId")]
        public System.String? CloudAccountNativeId { get; set; }

        //      C# -> System.Int32? NumMissingPermissions
        // GraphQL -> numMissingPermissions: Int! (scalar)
        [JsonProperty("numMissingPermissions")]
        public System.Int32? NumMissingPermissions { get; set; }

        //      C# -> System.Boolean? PermissionMissingForSimulation
        // GraphQL -> permissionMissingForSimulation: Boolean! (scalar)
        [JsonProperty("permissionMissingForSimulation")]
        public System.Boolean? PermissionMissingForSimulation { get; set; }

        //      C# -> List<ValidatePermissionsForFeatureReply>? FeatureResults
        // GraphQL -> featureResults: [ValidatePermissionsForFeatureReply!]! (type)
        [JsonProperty("featureResults")]
        public List<ValidatePermissionsForFeatureReply>? FeatureResults { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ValidatePermissionsForAccountReply";
    }

    public ValidatePermissionsForAccountReply Set(
        SuccessStatus? Status = null,
        System.String? CloudAccountId = null,
        System.String? CloudAccountName = null,
        System.String? CloudAccountNativeId = null,
        System.Int32? NumMissingPermissions = null,
        System.Boolean? PermissionMissingForSimulation = null,
        List<ValidatePermissionsForFeatureReply>? FeatureResults = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( CloudAccountId != null ) {
            this.CloudAccountId = CloudAccountId;
        }
        if ( CloudAccountName != null ) {
            this.CloudAccountName = CloudAccountName;
        }
        if ( CloudAccountNativeId != null ) {
            this.CloudAccountNativeId = CloudAccountNativeId;
        }
        if ( NumMissingPermissions != null ) {
            this.NumMissingPermissions = NumMissingPermissions;
        }
        if ( PermissionMissingForSimulation != null ) {
            this.PermissionMissingForSimulation = PermissionMissingForSimulation;
        }
        if ( FeatureResults != null ) {
            this.FeatureResults = FeatureResults;
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
        //      C# -> SuccessStatus? Status
        // GraphQL -> status: SuccessStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String! (scalar)
        if (this.CloudAccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudAccountId\n" ;
            } else {
                s += ind + "cloudAccountId\n" ;
            }
        }
        //      C# -> System.String? CloudAccountName
        // GraphQL -> cloudAccountName: String! (scalar)
        if (this.CloudAccountName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudAccountName\n" ;
            } else {
                s += ind + "cloudAccountName\n" ;
            }
        }
        //      C# -> System.String? CloudAccountNativeId
        // GraphQL -> cloudAccountNativeId: String! (scalar)
        if (this.CloudAccountNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudAccountNativeId\n" ;
            } else {
                s += ind + "cloudAccountNativeId\n" ;
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
        //      C# -> System.Boolean? PermissionMissingForSimulation
        // GraphQL -> permissionMissingForSimulation: Boolean! (scalar)
        if (this.PermissionMissingForSimulation != null) {
            if (conf.Flat) {
                s += conf.Prefix + "permissionMissingForSimulation\n" ;
            } else {
                s += ind + "permissionMissingForSimulation\n" ;
            }
        }
        //      C# -> List<ValidatePermissionsForFeatureReply>? FeatureResults
        // GraphQL -> featureResults: [ValidatePermissionsForFeatureReply!]! (type)
        if (this.FeatureResults != null) {
            var fspec = this.FeatureResults.AsFieldSpec(conf.Child("featureResults"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "featureResults" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
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
        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String! (scalar)
        if (ec.Includes("cloudAccountId",true))
        {
            if(this.CloudAccountId == null) {

                this.CloudAccountId = "FETCH";

            } else {


            }
        }
        else if (this.CloudAccountId != null && ec.Excludes("cloudAccountId",true))
        {
            this.CloudAccountId = null;
        }
        //      C# -> System.String? CloudAccountName
        // GraphQL -> cloudAccountName: String! (scalar)
        if (ec.Includes("cloudAccountName",true))
        {
            if(this.CloudAccountName == null) {

                this.CloudAccountName = "FETCH";

            } else {


            }
        }
        else if (this.CloudAccountName != null && ec.Excludes("cloudAccountName",true))
        {
            this.CloudAccountName = null;
        }
        //      C# -> System.String? CloudAccountNativeId
        // GraphQL -> cloudAccountNativeId: String! (scalar)
        if (ec.Includes("cloudAccountNativeId",true))
        {
            if(this.CloudAccountNativeId == null) {

                this.CloudAccountNativeId = "FETCH";

            } else {


            }
        }
        else if (this.CloudAccountNativeId != null && ec.Excludes("cloudAccountNativeId",true))
        {
            this.CloudAccountNativeId = null;
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
        //      C# -> System.Boolean? PermissionMissingForSimulation
        // GraphQL -> permissionMissingForSimulation: Boolean! (scalar)
        if (ec.Includes("permissionMissingForSimulation",true))
        {
            if(this.PermissionMissingForSimulation == null) {

                this.PermissionMissingForSimulation = true;

            } else {


            }
        }
        else if (this.PermissionMissingForSimulation != null && ec.Excludes("permissionMissingForSimulation",true))
        {
            this.PermissionMissingForSimulation = null;
        }
        //      C# -> List<ValidatePermissionsForFeatureReply>? FeatureResults
        // GraphQL -> featureResults: [ValidatePermissionsForFeatureReply!]! (type)
        if (ec.Includes("featureResults",false))
        {
            if(this.FeatureResults == null) {

                this.FeatureResults = new List<ValidatePermissionsForFeatureReply>();
                this.FeatureResults.ApplyExploratoryFieldSpec(ec.NewChild("featureResults"));

            } else {

                this.FeatureResults.ApplyExploratoryFieldSpec(ec.NewChild("featureResults"));

            }
        }
        else if (this.FeatureResults != null && ec.Excludes("featureResults",false))
        {
            this.FeatureResults = null;
        }
    }


    #endregion

    } // class ValidatePermissionsForAccountReply
    
    #endregion

    public static class ListValidatePermissionsForAccountReplyExtensions
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
            this List<ValidatePermissionsForAccountReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ValidatePermissionsForAccountReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ValidatePermissionsForAccountReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ValidatePermissionsForAccountReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ValidatePermissionsForAccountReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types