// K8sClusterSummary.cs
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
    #region K8sClusterSummary
    public class K8sClusterSummary: BaseType
    {
        #region members

        //      C# -> System.String? Distribution
        // GraphQL -> distribution: String (scalar)
        [JsonProperty("distribution")]
        public System.String? Distribution { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> DateTime? LastRefreshTime
        // GraphQL -> lastRefreshTime: DateTime (scalar)
        [JsonProperty("lastRefreshTime")]
        public DateTime? LastRefreshTime { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? OnboardingType
        // GraphQL -> onboardingType: String (scalar)
        [JsonProperty("onboardingType")]
        public System.String? OnboardingType { get; set; }

        //      C# -> System.String? Region
        // GraphQL -> region: String (scalar)
        [JsonProperty("region")]
        public System.String? Region { get; set; }

        //      C# -> System.String? Registry
        // GraphQL -> registry: String (scalar)
        [JsonProperty("registry")]
        public System.String? Registry { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> System.String? Transport
        // GraphQL -> transport: String (scalar)
        [JsonProperty("transport")]
        public System.String? Transport { get; set; }

        //      C# -> ServiceAccountInfo? CrdServiceAccountInfo
        // GraphQL -> crdServiceAccountInfo: ServiceAccountInfo (type)
        [JsonProperty("crdServiceAccountInfo")]
        public ServiceAccountInfo? CrdServiceAccountInfo { get; set; }

        //      C# -> KuprServerProxyConfig? KuprServerProxyConfig
        // GraphQL -> kuprServerProxyConfig: KuprServerProxyConfig (type)
        [JsonProperty("kuprServerProxyConfig")]
        public KuprServerProxyConfig? KuprServerProxyConfig { get; set; }

        //      C# -> ServiceAccountInfo? OnboardingServiceAccountInfo
        // GraphQL -> onboardingServiceAccountInfo: ServiceAccountInfo (type)
        [JsonProperty("onboardingServiceAccountInfo")]
        public ServiceAccountInfo? OnboardingServiceAccountInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "K8sClusterSummary";
    }

    public K8sClusterSummary Set(
        System.String? Distribution = null,
        System.String? Id = null,
        DateTime? LastRefreshTime = null,
        System.String? Name = null,
        System.String? OnboardingType = null,
        System.String? Region = null,
        System.String? Registry = null,
        System.String? Status = null,
        System.String? Transport = null,
        ServiceAccountInfo? CrdServiceAccountInfo = null,
        KuprServerProxyConfig? KuprServerProxyConfig = null,
        ServiceAccountInfo? OnboardingServiceAccountInfo = null
    ) 
    {
        if ( Distribution != null ) {
            this.Distribution = Distribution;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LastRefreshTime != null ) {
            this.LastRefreshTime = LastRefreshTime;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( OnboardingType != null ) {
            this.OnboardingType = OnboardingType;
        }
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( Registry != null ) {
            this.Registry = Registry;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Transport != null ) {
            this.Transport = Transport;
        }
        if ( CrdServiceAccountInfo != null ) {
            this.CrdServiceAccountInfo = CrdServiceAccountInfo;
        }
        if ( KuprServerProxyConfig != null ) {
            this.KuprServerProxyConfig = KuprServerProxyConfig;
        }
        if ( OnboardingServiceAccountInfo != null ) {
            this.OnboardingServiceAccountInfo = OnboardingServiceAccountInfo;
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
        //      C# -> System.String? Distribution
        // GraphQL -> distribution: String (scalar)
        if (this.Distribution != null) {
            if (conf.Flat) {
                s += conf.Prefix + "distribution\n" ;
            } else {
                s += ind + "distribution\n" ;
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
        //      C# -> DateTime? LastRefreshTime
        // GraphQL -> lastRefreshTime: DateTime (scalar)
        if (this.LastRefreshTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastRefreshTime\n" ;
            } else {
                s += ind + "lastRefreshTime\n" ;
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
        //      C# -> System.String? OnboardingType
        // GraphQL -> onboardingType: String (scalar)
        if (this.OnboardingType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "onboardingType\n" ;
            } else {
                s += ind + "onboardingType\n" ;
            }
        }
        //      C# -> System.String? Region
        // GraphQL -> region: String (scalar)
        if (this.Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "region\n" ;
            } else {
                s += ind + "region\n" ;
            }
        }
        //      C# -> System.String? Registry
        // GraphQL -> registry: String (scalar)
        if (this.Registry != null) {
            if (conf.Flat) {
                s += conf.Prefix + "registry\n" ;
            } else {
                s += ind + "registry\n" ;
            }
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? Transport
        // GraphQL -> transport: String (scalar)
        if (this.Transport != null) {
            if (conf.Flat) {
                s += conf.Prefix + "transport\n" ;
            } else {
                s += ind + "transport\n" ;
            }
        }
        //      C# -> ServiceAccountInfo? CrdServiceAccountInfo
        // GraphQL -> crdServiceAccountInfo: ServiceAccountInfo (type)
        if (this.CrdServiceAccountInfo != null) {
            var fspec = this.CrdServiceAccountInfo.AsFieldSpec(conf.Child("crdServiceAccountInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "crdServiceAccountInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> KuprServerProxyConfig? KuprServerProxyConfig
        // GraphQL -> kuprServerProxyConfig: KuprServerProxyConfig (type)
        if (this.KuprServerProxyConfig != null) {
            var fspec = this.KuprServerProxyConfig.AsFieldSpec(conf.Child("kuprServerProxyConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "kuprServerProxyConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ServiceAccountInfo? OnboardingServiceAccountInfo
        // GraphQL -> onboardingServiceAccountInfo: ServiceAccountInfo (type)
        if (this.OnboardingServiceAccountInfo != null) {
            var fspec = this.OnboardingServiceAccountInfo.AsFieldSpec(conf.Child("onboardingServiceAccountInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "onboardingServiceAccountInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Distribution
        // GraphQL -> distribution: String (scalar)
        if (ec.Includes("distribution",true))
        {
            if(this.Distribution == null) {

                this.Distribution = "FETCH";

            } else {


            }
        }
        else if (this.Distribution != null && ec.Excludes("distribution",true))
        {
            this.Distribution = null;
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
        //      C# -> DateTime? LastRefreshTime
        // GraphQL -> lastRefreshTime: DateTime (scalar)
        if (ec.Includes("lastRefreshTime",true))
        {
            if(this.LastRefreshTime == null) {

                this.LastRefreshTime = new DateTime();

            } else {


            }
        }
        else if (this.LastRefreshTime != null && ec.Excludes("lastRefreshTime",true))
        {
            this.LastRefreshTime = null;
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
        //      C# -> System.String? OnboardingType
        // GraphQL -> onboardingType: String (scalar)
        if (ec.Includes("onboardingType",true))
        {
            if(this.OnboardingType == null) {

                this.OnboardingType = "FETCH";

            } else {


            }
        }
        else if (this.OnboardingType != null && ec.Excludes("onboardingType",true))
        {
            this.OnboardingType = null;
        }
        //      C# -> System.String? Region
        // GraphQL -> region: String (scalar)
        if (ec.Includes("region",true))
        {
            if(this.Region == null) {

                this.Region = "FETCH";

            } else {


            }
        }
        else if (this.Region != null && ec.Excludes("region",true))
        {
            this.Region = null;
        }
        //      C# -> System.String? Registry
        // GraphQL -> registry: String (scalar)
        if (ec.Includes("registry",true))
        {
            if(this.Registry == null) {

                this.Registry = "FETCH";

            } else {


            }
        }
        else if (this.Registry != null && ec.Excludes("registry",true))
        {
            this.Registry = null;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = "FETCH";

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? Transport
        // GraphQL -> transport: String (scalar)
        if (ec.Includes("transport",true))
        {
            if(this.Transport == null) {

                this.Transport = "FETCH";

            } else {


            }
        }
        else if (this.Transport != null && ec.Excludes("transport",true))
        {
            this.Transport = null;
        }
        //      C# -> ServiceAccountInfo? CrdServiceAccountInfo
        // GraphQL -> crdServiceAccountInfo: ServiceAccountInfo (type)
        if (ec.Includes("crdServiceAccountInfo",false))
        {
            if(this.CrdServiceAccountInfo == null) {

                this.CrdServiceAccountInfo = new ServiceAccountInfo();
                this.CrdServiceAccountInfo.ApplyExploratoryFieldSpec(ec.NewChild("crdServiceAccountInfo"));

            } else {

                this.CrdServiceAccountInfo.ApplyExploratoryFieldSpec(ec.NewChild("crdServiceAccountInfo"));

            }
        }
        else if (this.CrdServiceAccountInfo != null && ec.Excludes("crdServiceAccountInfo",false))
        {
            this.CrdServiceAccountInfo = null;
        }
        //      C# -> KuprServerProxyConfig? KuprServerProxyConfig
        // GraphQL -> kuprServerProxyConfig: KuprServerProxyConfig (type)
        if (ec.Includes("kuprServerProxyConfig",false))
        {
            if(this.KuprServerProxyConfig == null) {

                this.KuprServerProxyConfig = new KuprServerProxyConfig();
                this.KuprServerProxyConfig.ApplyExploratoryFieldSpec(ec.NewChild("kuprServerProxyConfig"));

            } else {

                this.KuprServerProxyConfig.ApplyExploratoryFieldSpec(ec.NewChild("kuprServerProxyConfig"));

            }
        }
        else if (this.KuprServerProxyConfig != null && ec.Excludes("kuprServerProxyConfig",false))
        {
            this.KuprServerProxyConfig = null;
        }
        //      C# -> ServiceAccountInfo? OnboardingServiceAccountInfo
        // GraphQL -> onboardingServiceAccountInfo: ServiceAccountInfo (type)
        if (ec.Includes("onboardingServiceAccountInfo",false))
        {
            if(this.OnboardingServiceAccountInfo == null) {

                this.OnboardingServiceAccountInfo = new ServiceAccountInfo();
                this.OnboardingServiceAccountInfo.ApplyExploratoryFieldSpec(ec.NewChild("onboardingServiceAccountInfo"));

            } else {

                this.OnboardingServiceAccountInfo.ApplyExploratoryFieldSpec(ec.NewChild("onboardingServiceAccountInfo"));

            }
        }
        else if (this.OnboardingServiceAccountInfo != null && ec.Excludes("onboardingServiceAccountInfo",false))
        {
            this.OnboardingServiceAccountInfo = null;
        }
    }


    #endregion

    } // class K8sClusterSummary
    
    #endregion

    public static class ListK8sClusterSummaryExtensions
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
            this List<K8sClusterSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<K8sClusterSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<K8sClusterSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sClusterSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<K8sClusterSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types