// GcpOauthUserInfo.cs
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
    #region GcpOauthUserInfo
    public class GcpOauthUserInfo: BaseType
    {
        #region members

        //      C# -> System.String? Domain
        // GraphQL -> domain: String! (scalar)
        [JsonProperty("domain")]
        public System.String? Domain { get; set; }

        //      C# -> System.String? EmailId
        // GraphQL -> emailId: String! (scalar)
        [JsonProperty("emailId")]
        public System.String? EmailId { get; set; }

        //      C# -> System.String? FirstName
        // GraphQL -> firstName: String! (scalar)
        [JsonProperty("firstName")]
        public System.String? FirstName { get; set; }


        #endregion

    #region methods

    public GcpOauthUserInfo Set(
        System.String? Domain = null,
        System.String? EmailId = null,
        System.String? FirstName = null
    ) 
    {
        if ( Domain != null ) {
            this.Domain = Domain;
        }
        if ( EmailId != null ) {
            this.EmailId = EmailId;
        }
        if ( FirstName != null ) {
            this.FirstName = FirstName;
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
        //      C# -> System.String? Domain
        // GraphQL -> domain: String! (scalar)
        if (this.Domain != null) {
            s += ind + "domain\n" ;
        }
        //      C# -> System.String? EmailId
        // GraphQL -> emailId: String! (scalar)
        if (this.EmailId != null) {
            s += ind + "emailId\n" ;
        }
        //      C# -> System.String? FirstName
        // GraphQL -> firstName: String! (scalar)
        if (this.FirstName != null) {
            s += ind + "firstName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Domain
        // GraphQL -> domain: String! (scalar)
        if (this.Domain == null && Exploration.Includes(parent + ".domain", true))
        {
            this.Domain = "FETCH";
        }
        //      C# -> System.String? EmailId
        // GraphQL -> emailId: String! (scalar)
        if (this.EmailId == null && Exploration.Includes(parent + ".emailId", true))
        {
            this.EmailId = "FETCH";
        }
        //      C# -> System.String? FirstName
        // GraphQL -> firstName: String! (scalar)
        if (this.FirstName == null && Exploration.Includes(parent + ".firstName", true))
        {
            this.FirstName = "FETCH";
        }
    }


    #endregion

    } // class GcpOauthUserInfo
    
    #endregion

    public static class ListGcpOauthUserInfoExtensions
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
            this List<GcpOauthUserInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GcpOauthUserInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpOauthUserInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types