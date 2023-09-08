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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "GetUsersSummaryReply";
    }

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
            var fspec = this.SecureUsers.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "secureUsers {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SummaryCount? VulnerableUsers
        // GraphQL -> vulnerableUsers: SummaryCount! (type)
        if (this.VulnerableUsers != null) {
            var fspec = this.VulnerableUsers.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "vulnerableUsers {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SummaryCount? SecureUsers
        // GraphQL -> secureUsers: SummaryCount! (type)
        if (this.SecureUsers == null && ec.Includes("secureUsers",false))
        {
            this.SecureUsers = new SummaryCount();
            this.SecureUsers.ApplyExploratoryFieldSpec(ec.NewChild("secureUsers"));
        }
        //      C# -> SummaryCount? VulnerableUsers
        // GraphQL -> vulnerableUsers: SummaryCount! (type)
        if (this.VulnerableUsers == null && ec.Includes("vulnerableUsers",false))
        {
            this.VulnerableUsers = new SummaryCount();
            this.VulnerableUsers.ApplyExploratoryFieldSpec(ec.NewChild("vulnerableUsers"));
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
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetUsersSummaryReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetUsersSummaryReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<GetUsersSummaryReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types