// ManagedVolumePatchConfig.cs
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
    #region ManagedVolumePatchConfig
    public class ManagedVolumePatchConfig: BaseType
    {
        #region members

        //      C# -> List<System.String>? HostPatterns
        // GraphQL -> hostPatterns: [String!]! (scalar)
        [JsonProperty("hostPatterns")]
        public List<System.String>? HostPatterns { get; set; }

        //      C# -> List<System.String>? NodeHint
        // GraphQL -> nodeHint: [String!]! (scalar)
        [JsonProperty("nodeHint")]
        public List<System.String>? NodeHint { get; set; }

        //      C# -> System.String? SmbDomainName
        // GraphQL -> smbDomainName: String (scalar)
        [JsonProperty("smbDomainName")]
        public System.String? SmbDomainName { get; set; }

        //      C# -> List<System.String>? SmbValidIps
        // GraphQL -> smbValidIps: [String!]! (scalar)
        [JsonProperty("smbValidIps")]
        public List<System.String>? SmbValidIps { get; set; }

        //      C# -> List<System.String>? SmbValidUsers
        // GraphQL -> smbValidUsers: [String!]! (scalar)
        [JsonProperty("smbValidUsers")]
        public List<System.String>? SmbValidUsers { get; set; }


        #endregion

    #region methods

    public ManagedVolumePatchConfig Set(
        List<System.String>? HostPatterns = null,
        List<System.String>? NodeHint = null,
        System.String? SmbDomainName = null,
        List<System.String>? SmbValidIps = null,
        List<System.String>? SmbValidUsers = null
    ) 
    {
        if ( HostPatterns != null ) {
            this.HostPatterns = HostPatterns;
        }
        if ( NodeHint != null ) {
            this.NodeHint = NodeHint;
        }
        if ( SmbDomainName != null ) {
            this.SmbDomainName = SmbDomainName;
        }
        if ( SmbValidIps != null ) {
            this.SmbValidIps = SmbValidIps;
        }
        if ( SmbValidUsers != null ) {
            this.SmbValidUsers = SmbValidUsers;
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
        //      C# -> List<System.String>? HostPatterns
        // GraphQL -> hostPatterns: [String!]! (scalar)
        if (this.HostPatterns != null) {
            s += ind + "hostPatterns\n" ;
        }
        //      C# -> List<System.String>? NodeHint
        // GraphQL -> nodeHint: [String!]! (scalar)
        if (this.NodeHint != null) {
            s += ind + "nodeHint\n" ;
        }
        //      C# -> System.String? SmbDomainName
        // GraphQL -> smbDomainName: String (scalar)
        if (this.SmbDomainName != null) {
            s += ind + "smbDomainName\n" ;
        }
        //      C# -> List<System.String>? SmbValidIps
        // GraphQL -> smbValidIps: [String!]! (scalar)
        if (this.SmbValidIps != null) {
            s += ind + "smbValidIps\n" ;
        }
        //      C# -> List<System.String>? SmbValidUsers
        // GraphQL -> smbValidUsers: [String!]! (scalar)
        if (this.SmbValidUsers != null) {
            s += ind + "smbValidUsers\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? HostPatterns
        // GraphQL -> hostPatterns: [String!]! (scalar)
        if (this.HostPatterns == null && Exploration.Includes(parent + ".hostPatterns", true))
        {
            this.HostPatterns = new List<System.String>();
        }
        //      C# -> List<System.String>? NodeHint
        // GraphQL -> nodeHint: [String!]! (scalar)
        if (this.NodeHint == null && Exploration.Includes(parent + ".nodeHint", true))
        {
            this.NodeHint = new List<System.String>();
        }
        //      C# -> System.String? SmbDomainName
        // GraphQL -> smbDomainName: String (scalar)
        if (this.SmbDomainName == null && Exploration.Includes(parent + ".smbDomainName", true))
        {
            this.SmbDomainName = "FETCH";
        }
        //      C# -> List<System.String>? SmbValidIps
        // GraphQL -> smbValidIps: [String!]! (scalar)
        if (this.SmbValidIps == null && Exploration.Includes(parent + ".smbValidIps", true))
        {
            this.SmbValidIps = new List<System.String>();
        }
        //      C# -> List<System.String>? SmbValidUsers
        // GraphQL -> smbValidUsers: [String!]! (scalar)
        if (this.SmbValidUsers == null && Exploration.Includes(parent + ".smbValidUsers", true))
        {
            this.SmbValidUsers = new List<System.String>();
        }
    }


    #endregion

    } // class ManagedVolumePatchConfig
    
    #endregion

    public static class ListManagedVolumePatchConfigExtensions
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
            this List<ManagedVolumePatchConfig> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumePatchConfig> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumePatchConfig());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types