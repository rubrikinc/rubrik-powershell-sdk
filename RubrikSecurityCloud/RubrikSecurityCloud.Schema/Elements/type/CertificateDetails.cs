// CertificateDetails.cs
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
    #region CertificateDetails
    public class CertificateDetails: BaseType
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
        // GraphQL -> expiration: DateTime! (scalar)
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

        //      C# -> System.String? UsedBy
        // GraphQL -> usedBy: String! (scalar)
        [JsonProperty("usedBy")]
        public System.String? UsedBy { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CertificateDetails";
    }

    public CertificateDetails Set(
        System.String? CertId = null,
        System.String? Description = null,
        DateTime? Expiration = null,
        System.Boolean? HasKey = null,
        System.Boolean? IsTrusted = null,
        System.String? Name = null,
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
        //      C# -> System.String? CertId
        // GraphQL -> certId: String! (scalar)
        if (this.CertId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "certId\n" ;
            } else {
                s += ind + "certId\n" ;
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
            }
        }
        //      C# -> DateTime? Expiration
        // GraphQL -> expiration: DateTime! (scalar)
        if (this.Expiration != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expiration\n" ;
            } else {
                s += ind + "expiration\n" ;
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
        //      C# -> System.Boolean? IsTrusted
        // GraphQL -> isTrusted: Boolean (scalar)
        if (this.IsTrusted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isTrusted\n" ;
            } else {
                s += ind + "isTrusted\n" ;
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
        //      C# -> System.String? UsedBy
        // GraphQL -> usedBy: String! (scalar)
        if (this.UsedBy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usedBy\n" ;
            } else {
                s += ind + "usedBy\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CertId
        // GraphQL -> certId: String! (scalar)
        if (ec.Includes("certId",true))
        {
            if(this.CertId == null) {

                this.CertId = "FETCH";

            } else {


            }
        }
        else if (this.CertId != null && ec.Excludes("certId",true))
        {
            this.CertId = null;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
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
        //      C# -> DateTime? Expiration
        // GraphQL -> expiration: DateTime! (scalar)
        if (ec.Includes("expiration",true))
        {
            if(this.Expiration == null) {

                this.Expiration = new DateTime();

            } else {


            }
        }
        else if (this.Expiration != null && ec.Excludes("expiration",true))
        {
            this.Expiration = null;
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
        //      C# -> System.Boolean? IsTrusted
        // GraphQL -> isTrusted: Boolean (scalar)
        if (ec.Includes("isTrusted",true))
        {
            if(this.IsTrusted == null) {

                this.IsTrusted = true;

            } else {


            }
        }
        else if (this.IsTrusted != null && ec.Excludes("isTrusted",true))
        {
            this.IsTrusted = null;
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
        //      C# -> System.String? UsedBy
        // GraphQL -> usedBy: String! (scalar)
        if (ec.Includes("usedBy",true))
        {
            if(this.UsedBy == null) {

                this.UsedBy = "FETCH";

            } else {


            }
        }
        else if (this.UsedBy != null && ec.Excludes("usedBy",true))
        {
            this.UsedBy = null;
        }
    }


    #endregion

    } // class CertificateDetails
    
    #endregion

    public static class ListCertificateDetailsExtensions
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
            this List<CertificateDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CertificateDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CertificateDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CertificateDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CertificateDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types