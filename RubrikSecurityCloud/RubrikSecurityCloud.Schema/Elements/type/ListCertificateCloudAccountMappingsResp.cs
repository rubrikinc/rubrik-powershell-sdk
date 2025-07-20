// ListCertificateCloudAccountMappingsResp.cs
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
    #region ListCertificateCloudAccountMappingsResp
    public class ListCertificateCloudAccountMappingsResp: BaseType
    {
        #region members

        //      C# -> CloudType? CloudType
        // GraphQL -> cloudType: CloudType! (enum)
        [JsonProperty("cloudType")]
        public CloudType? CloudType { get; set; }

        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String! (scalar)
        [JsonProperty("cloudAccountId")]
        public System.String? CloudAccountId { get; set; }

        //      C# -> List<CloudNativeCertificateInfo>? Certificates
        // GraphQL -> certificates: [CloudNativeCertificateInfo!]! (type)
        [JsonProperty("certificates")]
        public List<CloudNativeCertificateInfo>? Certificates { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ListCertificateCloudAccountMappingsResp";
    }

    public ListCertificateCloudAccountMappingsResp Set(
        CloudType? CloudType = null,
        System.String? CloudAccountId = null,
        List<CloudNativeCertificateInfo>? Certificates = null
    ) 
    {
        if ( CloudType != null ) {
            this.CloudType = CloudType;
        }
        if ( CloudAccountId != null ) {
            this.CloudAccountId = CloudAccountId;
        }
        if ( Certificates != null ) {
            this.Certificates = Certificates;
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
        //      C# -> CloudType? CloudType
        // GraphQL -> cloudType: CloudType! (enum)
        if (this.CloudType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudType\n" ;
            } else {
                s += ind + "cloudType\n" ;
            }
        }
        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String! (scalar)
        if (this.CloudAccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudAccountId\n" ;
            } else {
                s += ind + "cloudAccountId\n" ;
            }
        }
        //      C# -> List<CloudNativeCertificateInfo>? Certificates
        // GraphQL -> certificates: [CloudNativeCertificateInfo!]! (type)
        if (this.Certificates != null) {
            var fspec = this.Certificates.AsFieldSpec(conf.Child("certificates"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "certificates" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CloudType? CloudType
        // GraphQL -> cloudType: CloudType! (enum)
        if (ec.Includes("cloudType",true))
        {
            if(this.CloudType == null) {

                this.CloudType = new CloudType();

            } else {


            }
        }
        else if (this.CloudType != null && ec.Excludes("cloudType",true))
        {
            this.CloudType = null;
        }
        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String! (scalar)
        if (ec.Includes("cloudAccountId",true))
        {
            if(this.CloudAccountId == null) {

                this.CloudAccountId = "FETCH";

            } else {


            }
        }
        else if (this.CloudAccountId != null && ec.Excludes("cloudAccountId",true))
        {
            this.CloudAccountId = null;
        }
        //      C# -> List<CloudNativeCertificateInfo>? Certificates
        // GraphQL -> certificates: [CloudNativeCertificateInfo!]! (type)
        if (ec.Includes("certificates",false))
        {
            if(this.Certificates == null) {

                this.Certificates = new List<CloudNativeCertificateInfo>();
                this.Certificates.ApplyExploratoryFieldSpec(ec.NewChild("certificates"));

            } else {

                this.Certificates.ApplyExploratoryFieldSpec(ec.NewChild("certificates"));

            }
        }
        else if (this.Certificates != null && ec.Excludes("certificates",false))
        {
            this.Certificates = null;
        }
    }


    #endregion

    } // class ListCertificateCloudAccountMappingsResp
    
    #endregion

    public static class ListListCertificateCloudAccountMappingsRespExtensions
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
            this List<ListCertificateCloudAccountMappingsResp> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ListCertificateCloudAccountMappingsResp> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ListCertificateCloudAccountMappingsResp> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ListCertificateCloudAccountMappingsResp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ListCertificateCloudAccountMappingsResp> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types