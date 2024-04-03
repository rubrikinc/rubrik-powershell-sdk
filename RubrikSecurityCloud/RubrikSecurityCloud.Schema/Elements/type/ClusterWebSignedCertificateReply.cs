// ClusterWebSignedCertificateReply.cs
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
    #region ClusterWebSignedCertificateReply
    public class ClusterWebSignedCertificateReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? WebServerConfiguredWithCaSignedCertificate
        // GraphQL -> webServerConfiguredWithCaSignedCertificate: Boolean! (scalar)
        [JsonProperty("webServerConfiguredWithCaSignedCertificate")]
        public System.Boolean? WebServerConfiguredWithCaSignedCertificate { get; set; }

        //      C# -> AddClusterCertificateReply? Cert
        // GraphQL -> cert: AddClusterCertificateReply (type)
        [JsonProperty("cert")]
        public AddClusterCertificateReply? Cert { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterWebSignedCertificateReply";
    }

    public ClusterWebSignedCertificateReply Set(
        System.Boolean? WebServerConfiguredWithCaSignedCertificate = null,
        AddClusterCertificateReply? Cert = null
    ) 
    {
        if ( WebServerConfiguredWithCaSignedCertificate != null ) {
            this.WebServerConfiguredWithCaSignedCertificate = WebServerConfiguredWithCaSignedCertificate;
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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? WebServerConfiguredWithCaSignedCertificate
        // GraphQL -> webServerConfiguredWithCaSignedCertificate: Boolean! (scalar)
        if (this.WebServerConfiguredWithCaSignedCertificate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "webServerConfiguredWithCaSignedCertificate\n" ;
            } else {
                s += ind + "webServerConfiguredWithCaSignedCertificate\n" ;
            }
        }
        //      C# -> AddClusterCertificateReply? Cert
        // GraphQL -> cert: AddClusterCertificateReply (type)
        if (this.Cert != null) {
            var fspec = this.Cert.AsFieldSpec(conf.Child("cert"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cert" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? WebServerConfiguredWithCaSignedCertificate
        // GraphQL -> webServerConfiguredWithCaSignedCertificate: Boolean! (scalar)
        if (ec.Includes("webServerConfiguredWithCaSignedCertificate",true))
        {
            if(this.WebServerConfiguredWithCaSignedCertificate == null) {

                this.WebServerConfiguredWithCaSignedCertificate = true;

            } else {


            }
        }
        else if (this.WebServerConfiguredWithCaSignedCertificate != null && ec.Excludes("webServerConfiguredWithCaSignedCertificate",true))
        {
            this.WebServerConfiguredWithCaSignedCertificate = null;
        }
        //      C# -> AddClusterCertificateReply? Cert
        // GraphQL -> cert: AddClusterCertificateReply (type)
        if (ec.Includes("cert",false))
        {
            if(this.Cert == null) {

                this.Cert = new AddClusterCertificateReply();
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

    } // class ClusterWebSignedCertificateReply
    
    #endregion

    public static class ListClusterWebSignedCertificateReplyExtensions
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
            this List<ClusterWebSignedCertificateReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClusterWebSignedCertificateReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterWebSignedCertificateReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterWebSignedCertificateReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterWebSignedCertificateReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types