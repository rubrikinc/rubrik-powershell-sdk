// Certificate.cs
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
    #region Certificate
    public class Certificate: BaseType
    {
        #region members

        //      C# -> System.String? CertificateField
        // GraphQL -> certificate: String! (scalar)
        [JsonProperty("certificate")]
        public System.String? CertificateField { get; set; }

        //      C# -> System.Int64? CertificateId
        // GraphQL -> certificateId: Long! (scalar)
        [JsonProperty("certificateId")]
        public System.Int64? CertificateId { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> DateTime? ExpiringAt
        // GraphQL -> expiringAt: DateTime (scalar)
        [JsonProperty("expiringAt")]
        public DateTime? ExpiringAt { get; set; }

        //      C# -> System.Boolean? HasKey
        // GraphQL -> hasKey: Boolean! (scalar)
        [JsonProperty("hasKey")]
        public System.Boolean? HasKey { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<System.String>? UsedBy
        // GraphQL -> usedBy: [String!]! (scalar)
        [JsonProperty("usedBy")]
        public List<System.String>? UsedBy { get; set; }


        #endregion

    #region methods

    public Certificate Set(
        System.String? CertificateField = null,
        System.Int64? CertificateId = null,
        System.String? Description = null,
        DateTime? ExpiringAt = null,
        System.Boolean? HasKey = null,
        System.String? Name = null,
        List<System.String>? UsedBy = null
    ) 
    {
        if ( CertificateField != null ) {
            this.CertificateField = CertificateField;
        }
        if ( CertificateId != null ) {
            this.CertificateId = CertificateId;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( ExpiringAt != null ) {
            this.ExpiringAt = ExpiringAt;
        }
        if ( HasKey != null ) {
            this.HasKey = HasKey;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( UsedBy != null ) {
            this.UsedBy = UsedBy;
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
        //      C# -> System.String? CertificateField
        // GraphQL -> certificate: String! (scalar)
        if (this.CertificateField != null) {
            s += ind + "certificate\n" ;
        }
        //      C# -> System.Int64? CertificateId
        // GraphQL -> certificateId: Long! (scalar)
        if (this.CertificateId != null) {
            s += ind + "certificateId\n" ;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            s += ind + "description\n" ;
        }
        //      C# -> DateTime? ExpiringAt
        // GraphQL -> expiringAt: DateTime (scalar)
        if (this.ExpiringAt != null) {
            s += ind + "expiringAt\n" ;
        }
        //      C# -> System.Boolean? HasKey
        // GraphQL -> hasKey: Boolean! (scalar)
        if (this.HasKey != null) {
            s += ind + "hasKey\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> List<System.String>? UsedBy
        // GraphQL -> usedBy: [String!]! (scalar)
        if (this.UsedBy != null) {
            s += ind + "usedBy\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? CertificateField
        // GraphQL -> certificate: String! (scalar)
        if (this.CertificateField == null && Exploration.Includes(parent + ".certificate", true))
        {
            this.CertificateField = "FETCH";
        }
        //      C# -> System.Int64? CertificateId
        // GraphQL -> certificateId: Long! (scalar)
        if (this.CertificateId == null && Exploration.Includes(parent + ".certificateId", true))
        {
            this.CertificateId = new System.Int64();
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description == null && Exploration.Includes(parent + ".description", true))
        {
            this.Description = "FETCH";
        }
        //      C# -> DateTime? ExpiringAt
        // GraphQL -> expiringAt: DateTime (scalar)
        if (this.ExpiringAt == null && Exploration.Includes(parent + ".expiringAt", true))
        {
            this.ExpiringAt = new DateTime();
        }
        //      C# -> System.Boolean? HasKey
        // GraphQL -> hasKey: Boolean! (scalar)
        if (this.HasKey == null && Exploration.Includes(parent + ".hasKey", true))
        {
            this.HasKey = true;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> List<System.String>? UsedBy
        // GraphQL -> usedBy: [String!]! (scalar)
        if (this.UsedBy == null && Exploration.Includes(parent + ".usedBy", true))
        {
            this.UsedBy = new List<System.String>();
        }
    }


    #endregion

    } // class Certificate
    
    #endregion

    public static class ListCertificateExtensions
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
            this List<Certificate> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Certificate> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Certificate());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types