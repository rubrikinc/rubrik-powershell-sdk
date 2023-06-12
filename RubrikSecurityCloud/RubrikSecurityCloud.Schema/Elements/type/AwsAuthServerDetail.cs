// AwsAuthServerDetail.cs
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
    #region AwsAuthServerDetail
    public class AwsAuthServerDetail: BaseType
    {
        #region members

        //      C# -> List<AwsAuthServerBasedCloudAccountRegion>? AuthServerAwsRegions
        // GraphQL -> authServerAwsRegions: [AwsAuthServerBasedCloudAccountRegion!]! (enum)
        [JsonProperty("authServerAwsRegions")]
        public List<AwsAuthServerBasedCloudAccountRegion>? AuthServerAwsRegions { get; set; }

        //      C# -> System.String? Agency
        // GraphQL -> agency: String! (scalar)
        [JsonProperty("agency")]
        public System.String? Agency { get; set; }

        //      C# -> System.Int64? AuthServerCaCertId
        // GraphQL -> authServerCaCertId: Long! (scalar)
        [JsonProperty("authServerCaCertId")]
        public System.Int64? AuthServerCaCertId { get; set; }

        //      C# -> System.String? AuthServerHostName
        // GraphQL -> authServerHostName: String! (scalar)
        [JsonProperty("authServerHostName")]
        public System.String? AuthServerHostName { get; set; }

        //      C# -> System.Int64? AuthServerUserClientCertId
        // GraphQL -> authServerUserClientCertId: Long! (scalar)
        [JsonProperty("authServerUserClientCertId")]
        public System.Int64? AuthServerUserClientCertId { get; set; }

        //      C# -> System.String? RoleName
        // GraphQL -> roleName: String! (scalar)
        [JsonProperty("roleName")]
        public System.String? RoleName { get; set; }


        #endregion

    #region methods

    public AwsAuthServerDetail Set(
        List<AwsAuthServerBasedCloudAccountRegion>? AuthServerAwsRegions = null,
        System.String? Agency = null,
        System.Int64? AuthServerCaCertId = null,
        System.String? AuthServerHostName = null,
        System.Int64? AuthServerUserClientCertId = null,
        System.String? RoleName = null
    ) 
    {
        if ( AuthServerAwsRegions != null ) {
            this.AuthServerAwsRegions = AuthServerAwsRegions;
        }
        if ( Agency != null ) {
            this.Agency = Agency;
        }
        if ( AuthServerCaCertId != null ) {
            this.AuthServerCaCertId = AuthServerCaCertId;
        }
        if ( AuthServerHostName != null ) {
            this.AuthServerHostName = AuthServerHostName;
        }
        if ( AuthServerUserClientCertId != null ) {
            this.AuthServerUserClientCertId = AuthServerUserClientCertId;
        }
        if ( RoleName != null ) {
            this.RoleName = RoleName;
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
        //      C# -> List<AwsAuthServerBasedCloudAccountRegion>? AuthServerAwsRegions
        // GraphQL -> authServerAwsRegions: [AwsAuthServerBasedCloudAccountRegion!]! (enum)
        if (this.AuthServerAwsRegions != null) {
            s += ind + "authServerAwsRegions\n" ;
        }
        //      C# -> System.String? Agency
        // GraphQL -> agency: String! (scalar)
        if (this.Agency != null) {
            s += ind + "agency\n" ;
        }
        //      C# -> System.Int64? AuthServerCaCertId
        // GraphQL -> authServerCaCertId: Long! (scalar)
        if (this.AuthServerCaCertId != null) {
            s += ind + "authServerCaCertId\n" ;
        }
        //      C# -> System.String? AuthServerHostName
        // GraphQL -> authServerHostName: String! (scalar)
        if (this.AuthServerHostName != null) {
            s += ind + "authServerHostName\n" ;
        }
        //      C# -> System.Int64? AuthServerUserClientCertId
        // GraphQL -> authServerUserClientCertId: Long! (scalar)
        if (this.AuthServerUserClientCertId != null) {
            s += ind + "authServerUserClientCertId\n" ;
        }
        //      C# -> System.String? RoleName
        // GraphQL -> roleName: String! (scalar)
        if (this.RoleName != null) {
            s += ind + "roleName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<AwsAuthServerBasedCloudAccountRegion>? AuthServerAwsRegions
        // GraphQL -> authServerAwsRegions: [AwsAuthServerBasedCloudAccountRegion!]! (enum)
        if (this.AuthServerAwsRegions == null && Exploration.Includes(parent + ".authServerAwsRegions", true))
        {
            this.AuthServerAwsRegions = new List<AwsAuthServerBasedCloudAccountRegion>();
        }
        //      C# -> System.String? Agency
        // GraphQL -> agency: String! (scalar)
        if (this.Agency == null && Exploration.Includes(parent + ".agency", true))
        {
            this.Agency = "FETCH";
        }
        //      C# -> System.Int64? AuthServerCaCertId
        // GraphQL -> authServerCaCertId: Long! (scalar)
        if (this.AuthServerCaCertId == null && Exploration.Includes(parent + ".authServerCaCertId", true))
        {
            this.AuthServerCaCertId = new System.Int64();
        }
        //      C# -> System.String? AuthServerHostName
        // GraphQL -> authServerHostName: String! (scalar)
        if (this.AuthServerHostName == null && Exploration.Includes(parent + ".authServerHostName", true))
        {
            this.AuthServerHostName = "FETCH";
        }
        //      C# -> System.Int64? AuthServerUserClientCertId
        // GraphQL -> authServerUserClientCertId: Long! (scalar)
        if (this.AuthServerUserClientCertId == null && Exploration.Includes(parent + ".authServerUserClientCertId", true))
        {
            this.AuthServerUserClientCertId = new System.Int64();
        }
        //      C# -> System.String? RoleName
        // GraphQL -> roleName: String! (scalar)
        if (this.RoleName == null && Exploration.Includes(parent + ".roleName", true))
        {
            this.RoleName = "FETCH";
        }
    }


    #endregion

    } // class AwsAuthServerDetail
    
    #endregion

    public static class ListAwsAuthServerDetailExtensions
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
            this List<AwsAuthServerDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsAuthServerDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsAuthServerDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types