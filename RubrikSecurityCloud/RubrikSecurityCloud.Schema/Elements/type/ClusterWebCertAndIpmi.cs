// ClusterWebCertAndIpmi.cs
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
    #region ClusterWebCertAndIpmi
    public class ClusterWebCertAndIpmi: BaseType
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        [JsonProperty("error")]
        public System.String? Error { get; set; }

        //      C# -> ClusterWebSignedCertificateReply? CertInfo
        // GraphQL -> certInfo: ClusterWebSignedCertificateReply (type)
        [JsonProperty("certInfo")]
        public ClusterWebSignedCertificateReply? CertInfo { get; set; }

        //      C# -> ModifyIpmiReply? IpmiInfo
        // GraphQL -> ipmiInfo: ModifyIpmiReply (type)
        [JsonProperty("ipmiInfo")]
        public ModifyIpmiReply? IpmiInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterWebCertAndIpmi";
    }

    public ClusterWebCertAndIpmi Set(
        System.String? ClusterUuid = null,
        System.String? Error = null,
        ClusterWebSignedCertificateReply? CertInfo = null,
        ModifyIpmiReply? IpmiInfo = null
    ) 
    {
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( Error != null ) {
            this.Error = Error;
        }
        if ( CertInfo != null ) {
            this.CertInfo = CertInfo;
        }
        if ( IpmiInfo != null ) {
            this.IpmiInfo = IpmiInfo;
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
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (this.Error != null) {
            if (conf.Flat) {
                s += conf.Prefix + "error\n" ;
            } else {
                s += ind + "error\n" ;
            }
        }
        //      C# -> ClusterWebSignedCertificateReply? CertInfo
        // GraphQL -> certInfo: ClusterWebSignedCertificateReply (type)
        if (this.CertInfo != null) {
            var fspec = this.CertInfo.AsFieldSpec(conf.Child("certInfo"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "certInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ModifyIpmiReply? IpmiInfo
        // GraphQL -> ipmiInfo: ModifyIpmiReply (type)
        if (this.IpmiInfo != null) {
            var fspec = this.IpmiInfo.AsFieldSpec(conf.Child("ipmiInfo"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ipmiInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
        }
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (ec.Includes("error",true))
        {
            if(this.Error == null) {

                this.Error = "FETCH";

            } else {


            }
        }
        else if (this.Error != null && ec.Excludes("error",true))
        {
            this.Error = null;
        }
        //      C# -> ClusterWebSignedCertificateReply? CertInfo
        // GraphQL -> certInfo: ClusterWebSignedCertificateReply (type)
        if (ec.Includes("certInfo",false))
        {
            if(this.CertInfo == null) {

                this.CertInfo = new ClusterWebSignedCertificateReply();
                this.CertInfo.ApplyExploratoryFieldSpec(ec.NewChild("certInfo"));

            } else {

                this.CertInfo.ApplyExploratoryFieldSpec(ec.NewChild("certInfo"));

            }
        }
        else if (this.CertInfo != null && ec.Excludes("certInfo",false))
        {
            this.CertInfo = null;
        }
        //      C# -> ModifyIpmiReply? IpmiInfo
        // GraphQL -> ipmiInfo: ModifyIpmiReply (type)
        if (ec.Includes("ipmiInfo",false))
        {
            if(this.IpmiInfo == null) {

                this.IpmiInfo = new ModifyIpmiReply();
                this.IpmiInfo.ApplyExploratoryFieldSpec(ec.NewChild("ipmiInfo"));

            } else {

                this.IpmiInfo.ApplyExploratoryFieldSpec(ec.NewChild("ipmiInfo"));

            }
        }
        else if (this.IpmiInfo != null && ec.Excludes("ipmiInfo",false))
        {
            this.IpmiInfo = null;
        }
    }


    #endregion

    } // class ClusterWebCertAndIpmi
    
    #endregion

    public static class ListClusterWebCertAndIpmiExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ClusterWebCertAndIpmi> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClusterWebCertAndIpmi> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterWebCertAndIpmi> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterWebCertAndIpmi());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterWebCertAndIpmi> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types