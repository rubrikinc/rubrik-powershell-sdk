// FinalizeAwsCloudAccountProtectionReply.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region FinalizeAwsCloudAccountProtectionReply
    public class FinalizeAwsCloudAccountProtectionReply: BaseType
    {
        #region members

        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> List<AwsCloudAccount>? AwsChildAccounts
        // GraphQL -> awsChildAccounts: [AwsCloudAccount!]! (type)
        [JsonProperty("awsChildAccounts")]
        public List<AwsCloudAccount>? AwsChildAccounts { get; set; }


        #endregion

    #region methods

    public FinalizeAwsCloudAccountProtectionReply Set(
        System.String? Message = null,
        List<AwsCloudAccount>? AwsChildAccounts = null
    ) 
    {
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( AwsChildAccounts != null ) {
            this.AwsChildAccounts = AwsChildAccounts;
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
        //      C# -> List<AwsCloudAccount>? AwsChildAccounts
        // GraphQL -> awsChildAccounts: [AwsCloudAccount!]! (type)
        if (this.AwsChildAccounts != null) {
            var fspec = this.AwsChildAccounts.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "awsChildAccounts {\n" + fspec + ind + "}\n" ;
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
        //      C# -> List<AwsCloudAccount>? AwsChildAccounts
        // GraphQL -> awsChildAccounts: [AwsCloudAccount!]! (type)
        if (this.AwsChildAccounts == null && Exploration.Includes(parent + ".awsChildAccounts"))
        {
            this.AwsChildAccounts = new List<AwsCloudAccount>();
            this.AwsChildAccounts.ApplyExploratoryFieldSpec(parent + ".awsChildAccounts");
        }
    }


    #endregion

    } // class FinalizeAwsCloudAccountProtectionReply
    
    #endregion

    public static class ListFinalizeAwsCloudAccountProtectionReplyExtensions
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
            this List<FinalizeAwsCloudAccountProtectionReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FinalizeAwsCloudAccountProtectionReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FinalizeAwsCloudAccountProtectionReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types