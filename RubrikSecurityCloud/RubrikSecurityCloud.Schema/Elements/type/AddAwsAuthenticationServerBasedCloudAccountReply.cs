// AddAwsAuthenticationServerBasedCloudAccountReply.cs
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
    #region AddAwsAuthenticationServerBasedCloudAccountReply
    public class AddAwsAuthenticationServerBasedCloudAccountReply: BaseType
    {
        #region members

        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> AwsCloudAccount? AwsAccount
        // GraphQL -> awsAccount: AwsCloudAccount (type)
        [JsonProperty("awsAccount")]
        public AwsCloudAccount? AwsAccount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AddAwsAuthenticationServerBasedCloudAccountReply";
    }

    public AddAwsAuthenticationServerBasedCloudAccountReply Set(
        System.String? Message = null,
        AwsCloudAccount? AwsAccount = null
    ) 
    {
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( AwsAccount != null ) {
            this.AwsAccount = AwsAccount;
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
        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        if (this.Message != null) {
            if (conf.Flat) {
                s += conf.Prefix + "message\n" ;
            } else {
                s += ind + "message\n" ;
            }
        }
        //      C# -> AwsCloudAccount? AwsAccount
        // GraphQL -> awsAccount: AwsCloudAccount (type)
        if (this.AwsAccount != null) {
            var fspec = this.AwsAccount.AsFieldSpec(conf.Child("awsAccount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsAccount {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        if (ec.Includes("message",true))
        {
            if(this.Message == null) {

                this.Message = "FETCH";

            } else {


            }
        }
        else if (this.Message != null && ec.Excludes("message",true))
        {
            this.Message = null;
        }
        //      C# -> AwsCloudAccount? AwsAccount
        // GraphQL -> awsAccount: AwsCloudAccount (type)
        if (ec.Includes("awsAccount",false))
        {
            if(this.AwsAccount == null) {

                this.AwsAccount = new AwsCloudAccount();
                this.AwsAccount.ApplyExploratoryFieldSpec(ec.NewChild("awsAccount"));

            } else {

                this.AwsAccount.ApplyExploratoryFieldSpec(ec.NewChild("awsAccount"));

            }
        }
        else if (this.AwsAccount != null && ec.Excludes("awsAccount",false))
        {
            this.AwsAccount = null;
        }
    }


    #endregion

    } // class AddAwsAuthenticationServerBasedCloudAccountReply
    
    #endregion

    public static class ListAddAwsAuthenticationServerBasedCloudAccountReplyExtensions
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
            this List<AddAwsAuthenticationServerBasedCloudAccountReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AddAwsAuthenticationServerBasedCloudAccountReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AddAwsAuthenticationServerBasedCloudAccountReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AddAwsAuthenticationServerBasedCloudAccountReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AddAwsAuthenticationServerBasedCloudAccountReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types