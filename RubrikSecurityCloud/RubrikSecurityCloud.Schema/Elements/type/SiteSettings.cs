// SiteSettings.cs
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
    #region SiteSettings
    public class SiteSettings: BaseType
    {
        #region members

        //      C# -> KerberosEnforceType? KerberosEnforceNfs4
        // GraphQL -> kerberosEnforceNfs4: KerberosEnforceType! (enum)
        [JsonProperty("kerberosEnforceNfs4")]
        public KerberosEnforceType? KerberosEnforceNfs4 { get; set; }

        //      C# -> CloudDirectOfflineFilesBehaviour? OfflineFilesBehaviour
        // GraphQL -> offlineFilesBehaviour: CloudDirectOfflineFilesBehaviour! (enum)
        [JsonProperty("offlineFilesBehaviour")]
        public CloudDirectOfflineFilesBehaviour? OfflineFilesBehaviour { get; set; }

        //      C# -> System.String? CloudDirectId
        // GraphQL -> cloudDirectId: String! (scalar)
        [JsonProperty("cloudDirectId")]
        public System.String? CloudDirectId { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? SupportSystemFiles
        // GraphQL -> supportSystemFiles: Boolean! (scalar)
        [JsonProperty("supportSystemFiles")]
        public System.Boolean? SupportSystemFiles { get; set; }

        //      C# -> List<KdcCredential>? KdcCredentials
        // GraphQL -> kdcCredentials: [KdcCredential!]! (type)
        [JsonProperty("kdcCredentials")]
        public List<KdcCredential>? KdcCredentials { get; set; }

        //      C# -> GlobalSmbAuthSettings? SmbCreds
        // GraphQL -> smbCreds: GlobalSmbAuthSettings (type)
        [JsonProperty("smbCreds")]
        public GlobalSmbAuthSettings? SmbCreds { get; set; }

        //      C# -> WanThrottleSettings? WanThrottle
        // GraphQL -> wanThrottle: WanThrottleSettings (type)
        [JsonProperty("wanThrottle")]
        public WanThrottleSettings? WanThrottle { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SiteSettings";
    }

    public SiteSettings Set(
        KerberosEnforceType? KerberosEnforceNfs4 = null,
        CloudDirectOfflineFilesBehaviour? OfflineFilesBehaviour = null,
        System.String? CloudDirectId = null,
        System.String? ClusterUuid = null,
        System.String? Id = null,
        System.Boolean? SupportSystemFiles = null,
        List<KdcCredential>? KdcCredentials = null,
        GlobalSmbAuthSettings? SmbCreds = null,
        WanThrottleSettings? WanThrottle = null
    ) 
    {
        if ( KerberosEnforceNfs4 != null ) {
            this.KerberosEnforceNfs4 = KerberosEnforceNfs4;
        }
        if ( OfflineFilesBehaviour != null ) {
            this.OfflineFilesBehaviour = OfflineFilesBehaviour;
        }
        if ( CloudDirectId != null ) {
            this.CloudDirectId = CloudDirectId;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( SupportSystemFiles != null ) {
            this.SupportSystemFiles = SupportSystemFiles;
        }
        if ( KdcCredentials != null ) {
            this.KdcCredentials = KdcCredentials;
        }
        if ( SmbCreds != null ) {
            this.SmbCreds = SmbCreds;
        }
        if ( WanThrottle != null ) {
            this.WanThrottle = WanThrottle;
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
        //      C# -> KerberosEnforceType? KerberosEnforceNfs4
        // GraphQL -> kerberosEnforceNfs4: KerberosEnforceType! (enum)
        if (this.KerberosEnforceNfs4 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kerberosEnforceNfs4\n" ;
            } else {
                s += ind + "kerberosEnforceNfs4\n" ;
            }
        }
        //      C# -> CloudDirectOfflineFilesBehaviour? OfflineFilesBehaviour
        // GraphQL -> offlineFilesBehaviour: CloudDirectOfflineFilesBehaviour! (enum)
        if (this.OfflineFilesBehaviour != null) {
            if (conf.Flat) {
                s += conf.Prefix + "offlineFilesBehaviour\n" ;
            } else {
                s += ind + "offlineFilesBehaviour\n" ;
            }
        }
        //      C# -> System.String? CloudDirectId
        // GraphQL -> cloudDirectId: String! (scalar)
        if (this.CloudDirectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudDirectId\n" ;
            } else {
                s += ind + "cloudDirectId\n" ;
            }
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? SupportSystemFiles
        // GraphQL -> supportSystemFiles: Boolean! (scalar)
        if (this.SupportSystemFiles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "supportSystemFiles\n" ;
            } else {
                s += ind + "supportSystemFiles\n" ;
            }
        }
        //      C# -> List<KdcCredential>? KdcCredentials
        // GraphQL -> kdcCredentials: [KdcCredential!]! (type)
        if (this.KdcCredentials != null) {
            var fspec = this.KdcCredentials.AsFieldSpec(conf.Child("kdcCredentials"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "kdcCredentials" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> GlobalSmbAuthSettings? SmbCreds
        // GraphQL -> smbCreds: GlobalSmbAuthSettings (type)
        if (this.SmbCreds != null) {
            var fspec = this.SmbCreds.AsFieldSpec(conf.Child("smbCreds"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "smbCreds" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> WanThrottleSettings? WanThrottle
        // GraphQL -> wanThrottle: WanThrottleSettings (type)
        if (this.WanThrottle != null) {
            var fspec = this.WanThrottle.AsFieldSpec(conf.Child("wanThrottle"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "wanThrottle" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> KerberosEnforceType? KerberosEnforceNfs4
        // GraphQL -> kerberosEnforceNfs4: KerberosEnforceType! (enum)
        if (ec.Includes("kerberosEnforceNfs4",true))
        {
            if(this.KerberosEnforceNfs4 == null) {

                this.KerberosEnforceNfs4 = new KerberosEnforceType();

            } else {


            }
        }
        else if (this.KerberosEnforceNfs4 != null && ec.Excludes("kerberosEnforceNfs4",true))
        {
            this.KerberosEnforceNfs4 = null;
        }
        //      C# -> CloudDirectOfflineFilesBehaviour? OfflineFilesBehaviour
        // GraphQL -> offlineFilesBehaviour: CloudDirectOfflineFilesBehaviour! (enum)
        if (ec.Includes("offlineFilesBehaviour",true))
        {
            if(this.OfflineFilesBehaviour == null) {

                this.OfflineFilesBehaviour = new CloudDirectOfflineFilesBehaviour();

            } else {


            }
        }
        else if (this.OfflineFilesBehaviour != null && ec.Excludes("offlineFilesBehaviour",true))
        {
            this.OfflineFilesBehaviour = null;
        }
        //      C# -> System.String? CloudDirectId
        // GraphQL -> cloudDirectId: String! (scalar)
        if (ec.Includes("cloudDirectId",true))
        {
            if(this.CloudDirectId == null) {

                this.CloudDirectId = "FETCH";

            } else {


            }
        }
        else if (this.CloudDirectId != null && ec.Excludes("cloudDirectId",true))
        {
            this.CloudDirectId = null;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? SupportSystemFiles
        // GraphQL -> supportSystemFiles: Boolean! (scalar)
        if (ec.Includes("supportSystemFiles",true))
        {
            if(this.SupportSystemFiles == null) {

                this.SupportSystemFiles = true;

            } else {


            }
        }
        else if (this.SupportSystemFiles != null && ec.Excludes("supportSystemFiles",true))
        {
            this.SupportSystemFiles = null;
        }
        //      C# -> List<KdcCredential>? KdcCredentials
        // GraphQL -> kdcCredentials: [KdcCredential!]! (type)
        if (ec.Includes("kdcCredentials",false))
        {
            if(this.KdcCredentials == null) {

                this.KdcCredentials = new List<KdcCredential>();
                this.KdcCredentials.ApplyExploratoryFieldSpec(ec.NewChild("kdcCredentials"));

            } else {

                this.KdcCredentials.ApplyExploratoryFieldSpec(ec.NewChild("kdcCredentials"));

            }
        }
        else if (this.KdcCredentials != null && ec.Excludes("kdcCredentials",false))
        {
            this.KdcCredentials = null;
        }
        //      C# -> GlobalSmbAuthSettings? SmbCreds
        // GraphQL -> smbCreds: GlobalSmbAuthSettings (type)
        if (ec.Includes("smbCreds",false))
        {
            if(this.SmbCreds == null) {

                this.SmbCreds = new GlobalSmbAuthSettings();
                this.SmbCreds.ApplyExploratoryFieldSpec(ec.NewChild("smbCreds"));

            } else {

                this.SmbCreds.ApplyExploratoryFieldSpec(ec.NewChild("smbCreds"));

            }
        }
        else if (this.SmbCreds != null && ec.Excludes("smbCreds",false))
        {
            this.SmbCreds = null;
        }
        //      C# -> WanThrottleSettings? WanThrottle
        // GraphQL -> wanThrottle: WanThrottleSettings (type)
        if (ec.Includes("wanThrottle",false))
        {
            if(this.WanThrottle == null) {

                this.WanThrottle = new WanThrottleSettings();
                this.WanThrottle.ApplyExploratoryFieldSpec(ec.NewChild("wanThrottle"));

            } else {

                this.WanThrottle.ApplyExploratoryFieldSpec(ec.NewChild("wanThrottle"));

            }
        }
        else if (this.WanThrottle != null && ec.Excludes("wanThrottle",false))
        {
            this.WanThrottle = null;
        }
    }


    #endregion

    } // class SiteSettings
    
    #endregion

    public static class ListSiteSettingsExtensions
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
            this List<SiteSettings> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SiteSettings> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SiteSettings> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SiteSettings());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SiteSettings> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types