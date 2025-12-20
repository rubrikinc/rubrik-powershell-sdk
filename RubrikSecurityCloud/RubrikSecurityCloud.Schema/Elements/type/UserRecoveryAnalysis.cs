// UserRecoveryAnalysis.cs
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
    #region UserRecoveryAnalysis
    public class UserRecoveryAnalysis: BaseType
    {
        #region members

        //      C# -> System.String? UserEmail
        // GraphQL -> userEmail: String! (scalar)
        [JsonProperty("userEmail")]
        public System.String? UserEmail { get; set; }

        //      C# -> System.String? UserId
        // GraphQL -> userId: String! (scalar)
        [JsonProperty("userId")]
        public System.String? UserId { get; set; }

        //      C# -> System.String? UserName
        // GraphQL -> userName: String! (scalar)
        [JsonProperty("userName")]
        public System.String? UserName { get; set; }

        //      C# -> ExchangeAnalysisResult? Exchange
        // GraphQL -> exchange: ExchangeAnalysisResult (type)
        [JsonProperty("exchange")]
        public ExchangeAnalysisResult? Exchange { get; set; }

        //      C# -> OnedriveAnalysisResult? Onedrive
        // GraphQL -> onedrive: OnedriveAnalysisResult (type)
        [JsonProperty("onedrive")]
        public OnedriveAnalysisResult? Onedrive { get; set; }

        //      C# -> SharepointAnalysisResult? Sharepoint
        // GraphQL -> sharepoint: SharepointAnalysisResult (type)
        [JsonProperty("sharepoint")]
        public SharepointAnalysisResult? Sharepoint { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UserRecoveryAnalysis";
    }

    public UserRecoveryAnalysis Set(
        System.String? UserEmail = null,
        System.String? UserId = null,
        System.String? UserName = null,
        ExchangeAnalysisResult? Exchange = null,
        OnedriveAnalysisResult? Onedrive = null,
        SharepointAnalysisResult? Sharepoint = null
    ) 
    {
        if ( UserEmail != null ) {
            this.UserEmail = UserEmail;
        }
        if ( UserId != null ) {
            this.UserId = UserId;
        }
        if ( UserName != null ) {
            this.UserName = UserName;
        }
        if ( Exchange != null ) {
            this.Exchange = Exchange;
        }
        if ( Onedrive != null ) {
            this.Onedrive = Onedrive;
        }
        if ( Sharepoint != null ) {
            this.Sharepoint = Sharepoint;
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
        //      C# -> System.String? UserEmail
        // GraphQL -> userEmail: String! (scalar)
        if (this.UserEmail != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userEmail\n" ;
            } else {
                s += ind + "userEmail\n" ;
            }
        }
        //      C# -> System.String? UserId
        // GraphQL -> userId: String! (scalar)
        if (this.UserId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userId\n" ;
            } else {
                s += ind + "userId\n" ;
            }
        }
        //      C# -> System.String? UserName
        // GraphQL -> userName: String! (scalar)
        if (this.UserName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userName\n" ;
            } else {
                s += ind + "userName\n" ;
            }
        }
        //      C# -> ExchangeAnalysisResult? Exchange
        // GraphQL -> exchange: ExchangeAnalysisResult (type)
        if (this.Exchange != null) {
            var fspec = this.Exchange.AsFieldSpec(conf.Child("exchange"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "exchange" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> OnedriveAnalysisResult? Onedrive
        // GraphQL -> onedrive: OnedriveAnalysisResult (type)
        if (this.Onedrive != null) {
            var fspec = this.Onedrive.AsFieldSpec(conf.Child("onedrive"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "onedrive" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SharepointAnalysisResult? Sharepoint
        // GraphQL -> sharepoint: SharepointAnalysisResult (type)
        if (this.Sharepoint != null) {
            var fspec = this.Sharepoint.AsFieldSpec(conf.Child("sharepoint"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sharepoint" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? UserEmail
        // GraphQL -> userEmail: String! (scalar)
        if (ec.Includes("userEmail",true))
        {
            if(this.UserEmail == null) {

                this.UserEmail = "FETCH";

            } else {


            }
        }
        else if (this.UserEmail != null && ec.Excludes("userEmail",true))
        {
            this.UserEmail = null;
        }
        //      C# -> System.String? UserId
        // GraphQL -> userId: String! (scalar)
        if (ec.Includes("userId",true))
        {
            if(this.UserId == null) {

                this.UserId = "FETCH";

            } else {


            }
        }
        else if (this.UserId != null && ec.Excludes("userId",true))
        {
            this.UserId = null;
        }
        //      C# -> System.String? UserName
        // GraphQL -> userName: String! (scalar)
        if (ec.Includes("userName",true))
        {
            if(this.UserName == null) {

                this.UserName = "FETCH";

            } else {


            }
        }
        else if (this.UserName != null && ec.Excludes("userName",true))
        {
            this.UserName = null;
        }
        //      C# -> ExchangeAnalysisResult? Exchange
        // GraphQL -> exchange: ExchangeAnalysisResult (type)
        if (ec.Includes("exchange",false))
        {
            if(this.Exchange == null) {

                this.Exchange = new ExchangeAnalysisResult();
                this.Exchange.ApplyExploratoryFieldSpec(ec.NewChild("exchange"));

            } else {

                this.Exchange.ApplyExploratoryFieldSpec(ec.NewChild("exchange"));

            }
        }
        else if (this.Exchange != null && ec.Excludes("exchange",false))
        {
            this.Exchange = null;
        }
        //      C# -> OnedriveAnalysisResult? Onedrive
        // GraphQL -> onedrive: OnedriveAnalysisResult (type)
        if (ec.Includes("onedrive",false))
        {
            if(this.Onedrive == null) {

                this.Onedrive = new OnedriveAnalysisResult();
                this.Onedrive.ApplyExploratoryFieldSpec(ec.NewChild("onedrive"));

            } else {

                this.Onedrive.ApplyExploratoryFieldSpec(ec.NewChild("onedrive"));

            }
        }
        else if (this.Onedrive != null && ec.Excludes("onedrive",false))
        {
            this.Onedrive = null;
        }
        //      C# -> SharepointAnalysisResult? Sharepoint
        // GraphQL -> sharepoint: SharepointAnalysisResult (type)
        if (ec.Includes("sharepoint",false))
        {
            if(this.Sharepoint == null) {

                this.Sharepoint = new SharepointAnalysisResult();
                this.Sharepoint.ApplyExploratoryFieldSpec(ec.NewChild("sharepoint"));

            } else {

                this.Sharepoint.ApplyExploratoryFieldSpec(ec.NewChild("sharepoint"));

            }
        }
        else if (this.Sharepoint != null && ec.Excludes("sharepoint",false))
        {
            this.Sharepoint = null;
        }
    }


    #endregion

    } // class UserRecoveryAnalysis
    
    #endregion

    public static class ListUserRecoveryAnalysisExtensions
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
            this List<UserRecoveryAnalysis> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UserRecoveryAnalysis> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UserRecoveryAnalysis> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UserRecoveryAnalysis());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UserRecoveryAnalysis> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types