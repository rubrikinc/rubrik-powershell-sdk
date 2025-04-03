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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "Certificate";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? CertificateField
        // GraphQL -> certificate: String! (scalar)
        if (this.CertificateField != null) {
            if (conf.Flat) {
                s += conf.Prefix + "certificate\n" ;
            } else {
                s += ind + "certificate\n" ;
            }
        }
        //      C# -> System.Int64? CertificateId
        // GraphQL -> certificateId: Long! (scalar)
        if (this.CertificateId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "certificateId\n" ;
            } else {
                s += ind + "certificateId\n" ;
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
            }
        }
        //      C# -> DateTime? ExpiringAt
        // GraphQL -> expiringAt: DateTime (scalar)
        if (this.ExpiringAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expiringAt\n" ;
            } else {
                s += ind + "expiringAt\n" ;
            }
        }
        //      C# -> System.Boolean? HasKey
        // GraphQL -> hasKey: Boolean! (scalar)
        if (this.HasKey != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasKey\n" ;
            } else {
                s += ind + "hasKey\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> List<System.String>? UsedBy
        // GraphQL -> usedBy: [String!]! (scalar)
        if (this.UsedBy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usedBy\n" ;
            } else {
                s += ind + "usedBy\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? CertificateField
        // GraphQL -> certificate: String! (scalar)
        if (ec.Includes("certificate",true))
        {
            if(this.CertificateField == null) {

                this.CertificateField = "FETCH";

            } else {


            }
        }
        else if (this.CertificateField != null && ec.Excludes("certificate",true))
        {
            this.CertificateField = null;
        }
        //      C# -> System.Int64? CertificateId
        // GraphQL -> certificateId: Long! (scalar)
        if (ec.Includes("certificateId",true))
        {
            if(this.CertificateId == null) {

                this.CertificateId = new System.Int64();

            } else {


            }
        }
        else if (this.CertificateId != null && ec.Excludes("certificateId",true))
        {
            this.CertificateId = null;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
        }
        //      C# -> DateTime? ExpiringAt
        // GraphQL -> expiringAt: DateTime (scalar)
        if (ec.Includes("expiringAt",true))
        {
            if(this.ExpiringAt == null) {

                this.ExpiringAt = new DateTime();

            } else {


            }
        }
        else if (this.ExpiringAt != null && ec.Excludes("expiringAt",true))
        {
            this.ExpiringAt = null;
        }
        //      C# -> System.Boolean? HasKey
        // GraphQL -> hasKey: Boolean! (scalar)
        if (ec.Includes("hasKey",true))
        {
            if(this.HasKey == null) {

                this.HasKey = true;

            } else {


            }
        }
        else if (this.HasKey != null && ec.Excludes("hasKey",true))
        {
            this.HasKey = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> List<System.String>? UsedBy
        // GraphQL -> usedBy: [String!]! (scalar)
        if (ec.Includes("usedBy",true))
        {
            if(this.UsedBy == null) {

                this.UsedBy = new List<System.String>();

            } else {


            }
        }
        else if (this.UsedBy != null && ec.Excludes("usedBy",true))
        {
            this.UsedBy = null;
        }
    }


    #endregion

    } // class Certificate
    
    #endregion

    public static class ListCertificateExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<Certificate> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Certificate> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Certificate> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Certificate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Certificate> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types