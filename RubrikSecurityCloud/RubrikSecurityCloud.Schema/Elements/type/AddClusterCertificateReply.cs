// AddClusterCertificateReply.cs
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
    #region AddClusterCertificateReply
    public class AddClusterCertificateReply: BaseType
    {
        #region members

        //      C# -> System.String? CertId
        // GraphQL -> certId: String! (scalar)
        [JsonProperty("certId")]
        public System.String? CertId { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> DateTime? Expiration
        // GraphQL -> expiration: DateTime (scalar)
        [JsonProperty("expiration")]
        public DateTime? Expiration { get; set; }

        //      C# -> System.Boolean? HasKey
        // GraphQL -> hasKey: Boolean! (scalar)
        [JsonProperty("hasKey")]
        public System.Boolean? HasKey { get; set; }

        //      C# -> System.Boolean? IsTrusted
        // GraphQL -> isTrusted: Boolean (scalar)
        [JsonProperty("isTrusted")]
        public System.Boolean? IsTrusted { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? PemFile
        // GraphQL -> pemFile: String! (scalar)
        [JsonProperty("pemFile")]
        public System.String? PemFile { get; set; }

        //      C# -> System.String? UsedBy
        // GraphQL -> usedBy: String! (scalar)
        [JsonProperty("usedBy")]
        public System.String? UsedBy { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AddClusterCertificateReply";
    }

    public AddClusterCertificateReply Set(
        System.String? CertId = null,
        System.String? Description = null,
        DateTime? Expiration = null,
        System.Boolean? HasKey = null,
        System.Boolean? IsTrusted = null,
        System.String? Name = null,
        System.String? PemFile = null,
        System.String? UsedBy = null
    ) 
    {
        if ( CertId != null ) {
            this.CertId = CertId;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Expiration != null ) {
            this.Expiration = Expiration;
        }
        if ( HasKey != null ) {
            this.HasKey = HasKey;
        }
        if ( IsTrusted != null ) {
            this.IsTrusted = IsTrusted;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PemFile != null ) {
            this.PemFile = PemFile;
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
        //      C# -> System.String? CertId
        // GraphQL -> certId: String! (scalar)
        if (this.CertId != null) {
            s += ind + "certId\n" ;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        if (this.Description != null) {
            s += ind + "description\n" ;
        }
        //      C# -> DateTime? Expiration
        // GraphQL -> expiration: DateTime (scalar)
        if (this.Expiration != null) {
            s += ind + "expiration\n" ;
        }
        //      C# -> System.Boolean? HasKey
        // GraphQL -> hasKey: Boolean! (scalar)
        if (this.HasKey != null) {
            s += ind + "hasKey\n" ;
        }
        //      C# -> System.Boolean? IsTrusted
        // GraphQL -> isTrusted: Boolean (scalar)
        if (this.IsTrusted != null) {
            s += ind + "isTrusted\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? PemFile
        // GraphQL -> pemFile: String! (scalar)
        if (this.PemFile != null) {
            s += ind + "pemFile\n" ;
        }
        //      C# -> System.String? UsedBy
        // GraphQL -> usedBy: String! (scalar)
        if (this.UsedBy != null) {
            s += ind + "usedBy\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CertId
        // GraphQL -> certId: String! (scalar)
        if (this.CertId == null && ec.Includes("certId",true))
        {
            this.CertId = "FETCH";
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        if (this.Description == null && ec.Includes("description",true))
        {
            this.Description = "FETCH";
        }
        //      C# -> DateTime? Expiration
        // GraphQL -> expiration: DateTime (scalar)
        if (this.Expiration == null && ec.Includes("expiration",true))
        {
            this.Expiration = new DateTime();
        }
        //      C# -> System.Boolean? HasKey
        // GraphQL -> hasKey: Boolean! (scalar)
        if (this.HasKey == null && ec.Includes("hasKey",true))
        {
            this.HasKey = true;
        }
        //      C# -> System.Boolean? IsTrusted
        // GraphQL -> isTrusted: Boolean (scalar)
        if (this.IsTrusted == null && ec.Includes("isTrusted",true))
        {
            this.IsTrusted = true;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? PemFile
        // GraphQL -> pemFile: String! (scalar)
        if (this.PemFile == null && ec.Includes("pemFile",true))
        {
            this.PemFile = "FETCH";
        }
        //      C# -> System.String? UsedBy
        // GraphQL -> usedBy: String! (scalar)
        if (this.UsedBy == null && ec.Includes("usedBy",true))
        {
            this.UsedBy = "FETCH";
        }
    }


    #endregion

    } // class AddClusterCertificateReply
    
    #endregion

    public static class ListAddClusterCertificateReplyExtensions
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
            this List<AddClusterCertificateReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AddClusterCertificateReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AddClusterCertificateReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AddClusterCertificateReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types