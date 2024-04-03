// AwsCloudAccountValidateResponse.cs
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
    #region AwsCloudAccountValidateResponse
    public class AwsCloudAccountValidateResponse: BaseType
    {
        #region members

        //      C# -> List<AwsAccountValidationResponse>? InvalidAwsAccounts
        // GraphQL -> invalidAwsAccounts: [AwsAccountValidationResponse!]! (type)
        [JsonProperty("invalidAwsAccounts")]
        public List<AwsAccountValidationResponse>? InvalidAwsAccounts { get; set; }

        //      C# -> AwsAccountValidationResponse? InvalidAwsAdminAccount
        // GraphQL -> invalidAwsAdminAccount: AwsAccountValidationResponse (type)
        [JsonProperty("invalidAwsAdminAccount")]
        public AwsAccountValidationResponse? InvalidAwsAdminAccount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsCloudAccountValidateResponse";
    }

    public AwsCloudAccountValidateResponse Set(
        List<AwsAccountValidationResponse>? InvalidAwsAccounts = null,
        AwsAccountValidationResponse? InvalidAwsAdminAccount = null
    ) 
    {
        if ( InvalidAwsAccounts != null ) {
            this.InvalidAwsAccounts = InvalidAwsAccounts;
        }
        if ( InvalidAwsAdminAccount != null ) {
            this.InvalidAwsAdminAccount = InvalidAwsAdminAccount;
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
        //      C# -> List<AwsAccountValidationResponse>? InvalidAwsAccounts
        // GraphQL -> invalidAwsAccounts: [AwsAccountValidationResponse!]! (type)
        if (this.InvalidAwsAccounts != null) {
            var fspec = this.InvalidAwsAccounts.AsFieldSpec(conf.Child("invalidAwsAccounts"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "invalidAwsAccounts" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AwsAccountValidationResponse? InvalidAwsAdminAccount
        // GraphQL -> invalidAwsAdminAccount: AwsAccountValidationResponse (type)
        if (this.InvalidAwsAdminAccount != null) {
            var fspec = this.InvalidAwsAdminAccount.AsFieldSpec(conf.Child("invalidAwsAdminAccount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "invalidAwsAdminAccount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AwsAccountValidationResponse>? InvalidAwsAccounts
        // GraphQL -> invalidAwsAccounts: [AwsAccountValidationResponse!]! (type)
        if (ec.Includes("invalidAwsAccounts",false))
        {
            if(this.InvalidAwsAccounts == null) {

                this.InvalidAwsAccounts = new List<AwsAccountValidationResponse>();
                this.InvalidAwsAccounts.ApplyExploratoryFieldSpec(ec.NewChild("invalidAwsAccounts"));

            } else {

                this.InvalidAwsAccounts.ApplyExploratoryFieldSpec(ec.NewChild("invalidAwsAccounts"));

            }
        }
        else if (this.InvalidAwsAccounts != null && ec.Excludes("invalidAwsAccounts",false))
        {
            this.InvalidAwsAccounts = null;
        }
        //      C# -> AwsAccountValidationResponse? InvalidAwsAdminAccount
        // GraphQL -> invalidAwsAdminAccount: AwsAccountValidationResponse (type)
        if (ec.Includes("invalidAwsAdminAccount",false))
        {
            if(this.InvalidAwsAdminAccount == null) {

                this.InvalidAwsAdminAccount = new AwsAccountValidationResponse();
                this.InvalidAwsAdminAccount.ApplyExploratoryFieldSpec(ec.NewChild("invalidAwsAdminAccount"));

            } else {

                this.InvalidAwsAdminAccount.ApplyExploratoryFieldSpec(ec.NewChild("invalidAwsAdminAccount"));

            }
        }
        else if (this.InvalidAwsAdminAccount != null && ec.Excludes("invalidAwsAdminAccount",false))
        {
            this.InvalidAwsAdminAccount = null;
        }
    }


    #endregion

    } // class AwsCloudAccountValidateResponse
    
    #endregion

    public static class ListAwsCloudAccountValidateResponseExtensions
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
            this List<AwsCloudAccountValidateResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsCloudAccountValidateResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsCloudAccountValidateResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsCloudAccountValidateResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsCloudAccountValidateResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types