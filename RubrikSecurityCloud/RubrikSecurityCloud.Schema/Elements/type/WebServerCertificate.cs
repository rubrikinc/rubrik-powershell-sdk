// WebServerCertificate.cs
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
    #region WebServerCertificate
    public class WebServerCertificate: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsConfiguredWithCaSignedCertificate
        // GraphQL -> isConfiguredWithCaSignedCertificate: Boolean! (scalar)
        [JsonProperty("isConfiguredWithCaSignedCertificate")]
        public System.Boolean? IsConfiguredWithCaSignedCertificate { get; set; }

        //      C# -> CertificateDetails? Cert
        // GraphQL -> cert: CertificateDetails! (type)
        [JsonProperty("cert")]
        public CertificateDetails? Cert { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WebServerCertificate";
    }

    public WebServerCertificate Set(
        System.Boolean? IsConfiguredWithCaSignedCertificate = null,
        CertificateDetails? Cert = null
    ) 
    {
        if ( IsConfiguredWithCaSignedCertificate != null ) {
            this.IsConfiguredWithCaSignedCertificate = IsConfiguredWithCaSignedCertificate;
        }
        if ( Cert != null ) {
            this.Cert = Cert;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? IsConfiguredWithCaSignedCertificate
        // GraphQL -> isConfiguredWithCaSignedCertificate: Boolean! (scalar)
        if (this.IsConfiguredWithCaSignedCertificate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isConfiguredWithCaSignedCertificate\n" ;
            } else {
                s += ind + "isConfiguredWithCaSignedCertificate\n" ;
            }
        }
        //      C# -> CertificateDetails? Cert
        // GraphQL -> cert: CertificateDetails! (type)
        if (this.Cert != null) {
            var fspec = this.Cert.AsFieldSpec(conf.Child("cert"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cert {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsConfiguredWithCaSignedCertificate
        // GraphQL -> isConfiguredWithCaSignedCertificate: Boolean! (scalar)
        if (ec.Includes("isConfiguredWithCaSignedCertificate",true))
        {
            if(this.IsConfiguredWithCaSignedCertificate == null) {

                this.IsConfiguredWithCaSignedCertificate = true;

            } else {


            }
        }
        else if (this.IsConfiguredWithCaSignedCertificate != null && ec.Excludes("isConfiguredWithCaSignedCertificate",true))
        {
            this.IsConfiguredWithCaSignedCertificate = null;
        }
        //      C# -> CertificateDetails? Cert
        // GraphQL -> cert: CertificateDetails! (type)
        if (ec.Includes("cert",false))
        {
            if(this.Cert == null) {

                this.Cert = new CertificateDetails();
                this.Cert.ApplyExploratoryFieldSpec(ec.NewChild("cert"));

            } else {

                this.Cert.ApplyExploratoryFieldSpec(ec.NewChild("cert"));

            }
        }
        else if (this.Cert != null && ec.Excludes("cert",false))
        {
            this.Cert = null;
        }
    }


    #endregion

    } // class WebServerCertificate
    
    #endregion

    public static class ListWebServerCertificateExtensions
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
            this List<WebServerCertificate> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<WebServerCertificate> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<WebServerCertificate> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WebServerCertificate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<WebServerCertificate> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types