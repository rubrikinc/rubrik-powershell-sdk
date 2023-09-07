// SaasLicenseDetails.cs
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
    #region SaasLicenseDetails
    public class SaasLicenseDetails: BaseType
    {
        #region members

        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        [JsonProperty("expirationTime")]
        public DateTime? ExpirationTime { get; set; }

        //      C# -> System.String? LicenseName
        // GraphQL -> licenseName: String (scalar)
        [JsonProperty("licenseName")]
        public System.String? LicenseName { get; set; }

        //      C# -> System.Int32? LicensedUsers
        // GraphQL -> licensedUsers: Int (scalar)
        [JsonProperty("licensedUsers")]
        public System.Int32? LicensedUsers { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SaasLicenseDetails";
    }

    public SaasLicenseDetails Set(
        DateTime? ExpirationTime = null,
        System.String? LicenseName = null,
        System.Int32? LicensedUsers = null
    ) 
    {
        if ( ExpirationTime != null ) {
            this.ExpirationTime = ExpirationTime;
        }
        if ( LicenseName != null ) {
            this.LicenseName = LicenseName;
        }
        if ( LicensedUsers != null ) {
            this.LicensedUsers = LicensedUsers;
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
        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        if (this.ExpirationTime != null) {
            s += ind + "expirationTime\n" ;
        }
        //      C# -> System.String? LicenseName
        // GraphQL -> licenseName: String (scalar)
        if (this.LicenseName != null) {
            s += ind + "licenseName\n" ;
        }
        //      C# -> System.Int32? LicensedUsers
        // GraphQL -> licensedUsers: Int (scalar)
        if (this.LicensedUsers != null) {
            s += ind + "licensedUsers\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        if (this.ExpirationTime == null && ec.Includes("expirationTime",true))
        {
            this.ExpirationTime = new DateTime();
        }
        //      C# -> System.String? LicenseName
        // GraphQL -> licenseName: String (scalar)
        if (this.LicenseName == null && ec.Includes("licenseName",true))
        {
            this.LicenseName = "FETCH";
        }
        //      C# -> System.Int32? LicensedUsers
        // GraphQL -> licensedUsers: Int (scalar)
        if (this.LicensedUsers == null && ec.Includes("licensedUsers",true))
        {
            this.LicensedUsers = Int32.MinValue;
        }
    }


    #endregion

    } // class SaasLicenseDetails
    
    #endregion

    public static class ListSaasLicenseDetailsExtensions
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
            this List<SaasLicenseDetails> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SaasLicenseDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SaasLicenseDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SaasLicenseDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types