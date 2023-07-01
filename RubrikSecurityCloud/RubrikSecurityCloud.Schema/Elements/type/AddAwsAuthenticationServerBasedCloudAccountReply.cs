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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        if (this.Message != null) {
            s += ind + "message\n" ;
        }
        //      C# -> AwsCloudAccount? AwsAccount
        // GraphQL -> awsAccount: AwsCloudAccount (type)
        if (this.AwsAccount != null) {
            var fspec = this.AwsAccount.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "awsAccount {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        if (this.Message == null && Exploration.Includes(parent + ".message", true))
        {
            this.Message = "FETCH";
        }
        //      C# -> AwsCloudAccount? AwsAccount
        // GraphQL -> awsAccount: AwsCloudAccount (type)
        if (this.AwsAccount == null && Exploration.Includes(parent + ".awsAccount"))
        {
            this.AwsAccount = new AwsCloudAccount();
            this.AwsAccount.ApplyExploratoryFieldSpec(parent + ".awsAccount");
        }
    }


    #endregion

    } // class AddAwsAuthenticationServerBasedCloudAccountReply
    
    #endregion

    public static class ListAddAwsAuthenticationServerBasedCloudAccountReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<AddAwsAuthenticationServerBasedCloudAccountReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AddAwsAuthenticationServerBasedCloudAccountReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AddAwsAuthenticationServerBasedCloudAccountReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types