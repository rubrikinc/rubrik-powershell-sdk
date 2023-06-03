// GetUsersSummaryReply.cs
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
    #region GetUsersSummaryReply
    public class GetUsersSummaryReply: BaseType
    {
        #region members

        //      C# -> SummaryCount? SecureUsers
        // GraphQL -> secureUsers: SummaryCount! (type)
        [JsonProperty("secureUsers")]
        public SummaryCount? SecureUsers { get; set; }

        //      C# -> SummaryCount? VulnerableUsers
        // GraphQL -> vulnerableUsers: SummaryCount! (type)
        [JsonProperty("vulnerableUsers")]
        public SummaryCount? VulnerableUsers { get; set; }


        #endregion

    #region methods

    public GetUsersSummaryReply Set(
        SummaryCount? SecureUsers = null,
        SummaryCount? VulnerableUsers = null
    ) 
    {
        if ( SecureUsers != null ) {
            this.SecureUsers = SecureUsers;
        }
        if ( VulnerableUsers != null ) {
            this.VulnerableUsers = VulnerableUsers;
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
        //      C# -> SummaryCount? SecureUsers
        // GraphQL -> secureUsers: SummaryCount! (type)
        if (this.SecureUsers != null) {
            s += ind + "secureUsers {\n" + this.SecureUsers.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SummaryCount? VulnerableUsers
        // GraphQL -> vulnerableUsers: SummaryCount! (type)
        if (this.VulnerableUsers != null) {
            s += ind + "vulnerableUsers {\n" + this.VulnerableUsers.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SummaryCount? SecureUsers
        // GraphQL -> secureUsers: SummaryCount! (type)
        if (this.SecureUsers == null && Exploration.Includes(parent + ".secureUsers"))
        {
            this.SecureUsers = new SummaryCount();
            this.SecureUsers.ApplyExploratoryFieldSpec(parent + ".secureUsers");
        }
        //      C# -> SummaryCount? VulnerableUsers
        // GraphQL -> vulnerableUsers: SummaryCount! (type)
        if (this.VulnerableUsers == null && Exploration.Includes(parent + ".vulnerableUsers"))
        {
            this.VulnerableUsers = new SummaryCount();
            this.VulnerableUsers.ApplyExploratoryFieldSpec(parent + ".vulnerableUsers");
        }
    }


    #endregion

    } // class GetUsersSummaryReply
    
    #endregion

    public static class ListGetUsersSummaryReplyExtensions
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
            this List<GetUsersSummaryReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetUsersSummaryReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GetUsersSummaryReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types