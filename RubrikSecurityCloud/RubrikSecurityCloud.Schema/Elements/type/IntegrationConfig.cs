// IntegrationConfig.cs
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
    #region IntegrationConfig
    public class IntegrationConfig: BaseType
    {
        #region members

        //      C# -> CrowdStrikeIntegrationConfig? CrowdStrike
        // GraphQL -> crowdStrike: CrowdStrikeIntegrationConfig (type)
        [JsonProperty("crowdStrike")]
        public CrowdStrikeIntegrationConfig? CrowdStrike { get; set; }

        //      C# -> DlpConfig? DataLossPrevention
        // GraphQL -> dataLossPrevention: DlpConfig (type)
        [JsonProperty("dataLossPrevention")]
        public DlpConfig? DataLossPrevention { get; set; }

        //      C# -> MicrosoftPurviewConfig? MicrosoftPurview
        // GraphQL -> microsoftPurview: MicrosoftPurviewConfig (type)
        [JsonProperty("microsoftPurview")]
        public MicrosoftPurviewConfig? MicrosoftPurview { get; set; }

        //      C# -> OktaIntegrationConfig? Okta
        // GraphQL -> okta: OktaIntegrationConfig (type)
        [JsonProperty("okta")]
        public OktaIntegrationConfig? Okta { get; set; }

        //      C# -> PamIntegrationConfig? Pam
        // GraphQL -> pam: PamIntegrationConfig (type)
        [JsonProperty("pam")]
        public PamIntegrationConfig? Pam { get; set; }

        //      C# -> ServiceNowItsmIntegrationConfig? ServiceNowItsm
        // GraphQL -> serviceNowItsm: ServiceNowItsmIntegrationConfig (type)
        [JsonProperty("serviceNowItsm")]
        public ServiceNowItsmIntegrationConfig? ServiceNowItsm { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IntegrationConfig";
    }

    public IntegrationConfig Set(
        CrowdStrikeIntegrationConfig? CrowdStrike = null,
        DlpConfig? DataLossPrevention = null,
        MicrosoftPurviewConfig? MicrosoftPurview = null,
        OktaIntegrationConfig? Okta = null,
        PamIntegrationConfig? Pam = null,
        ServiceNowItsmIntegrationConfig? ServiceNowItsm = null
    ) 
    {
        if ( CrowdStrike != null ) {
            this.CrowdStrike = CrowdStrike;
        }
        if ( DataLossPrevention != null ) {
            this.DataLossPrevention = DataLossPrevention;
        }
        if ( MicrosoftPurview != null ) {
            this.MicrosoftPurview = MicrosoftPurview;
        }
        if ( Okta != null ) {
            this.Okta = Okta;
        }
        if ( Pam != null ) {
            this.Pam = Pam;
        }
        if ( ServiceNowItsm != null ) {
            this.ServiceNowItsm = ServiceNowItsm;
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
        //      C# -> CrowdStrikeIntegrationConfig? CrowdStrike
        // GraphQL -> crowdStrike: CrowdStrikeIntegrationConfig (type)
        if (this.CrowdStrike != null) {
            var fspec = this.CrowdStrike.AsFieldSpec(conf.Child("crowdStrike"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "crowdStrike" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> DlpConfig? DataLossPrevention
        // GraphQL -> dataLossPrevention: DlpConfig (type)
        if (this.DataLossPrevention != null) {
            var fspec = this.DataLossPrevention.AsFieldSpec(conf.Child("dataLossPrevention"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dataLossPrevention" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MicrosoftPurviewConfig? MicrosoftPurview
        // GraphQL -> microsoftPurview: MicrosoftPurviewConfig (type)
        if (this.MicrosoftPurview != null) {
            var fspec = this.MicrosoftPurview.AsFieldSpec(conf.Child("microsoftPurview"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "microsoftPurview" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> OktaIntegrationConfig? Okta
        // GraphQL -> okta: OktaIntegrationConfig (type)
        if (this.Okta != null) {
            var fspec = this.Okta.AsFieldSpec(conf.Child("okta"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "okta" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PamIntegrationConfig? Pam
        // GraphQL -> pam: PamIntegrationConfig (type)
        if (this.Pam != null) {
            var fspec = this.Pam.AsFieldSpec(conf.Child("pam"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pam" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ServiceNowItsmIntegrationConfig? ServiceNowItsm
        // GraphQL -> serviceNowItsm: ServiceNowItsmIntegrationConfig (type)
        if (this.ServiceNowItsm != null) {
            var fspec = this.ServiceNowItsm.AsFieldSpec(conf.Child("serviceNowItsm"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "serviceNowItsm" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CrowdStrikeIntegrationConfig? CrowdStrike
        // GraphQL -> crowdStrike: CrowdStrikeIntegrationConfig (type)
        if (ec.Includes("crowdStrike",false))
        {
            if(this.CrowdStrike == null) {

                this.CrowdStrike = new CrowdStrikeIntegrationConfig();
                this.CrowdStrike.ApplyExploratoryFieldSpec(ec.NewChild("crowdStrike"));

            } else {

                this.CrowdStrike.ApplyExploratoryFieldSpec(ec.NewChild("crowdStrike"));

            }
        }
        else if (this.CrowdStrike != null && ec.Excludes("crowdStrike",false))
        {
            this.CrowdStrike = null;
        }
        //      C# -> DlpConfig? DataLossPrevention
        // GraphQL -> dataLossPrevention: DlpConfig (type)
        if (ec.Includes("dataLossPrevention",false))
        {
            if(this.DataLossPrevention == null) {

                this.DataLossPrevention = new DlpConfig();
                this.DataLossPrevention.ApplyExploratoryFieldSpec(ec.NewChild("dataLossPrevention"));

            } else {

                this.DataLossPrevention.ApplyExploratoryFieldSpec(ec.NewChild("dataLossPrevention"));

            }
        }
        else if (this.DataLossPrevention != null && ec.Excludes("dataLossPrevention",false))
        {
            this.DataLossPrevention = null;
        }
        //      C# -> MicrosoftPurviewConfig? MicrosoftPurview
        // GraphQL -> microsoftPurview: MicrosoftPurviewConfig (type)
        if (ec.Includes("microsoftPurview",false))
        {
            if(this.MicrosoftPurview == null) {

                this.MicrosoftPurview = new MicrosoftPurviewConfig();
                this.MicrosoftPurview.ApplyExploratoryFieldSpec(ec.NewChild("microsoftPurview"));

            } else {

                this.MicrosoftPurview.ApplyExploratoryFieldSpec(ec.NewChild("microsoftPurview"));

            }
        }
        else if (this.MicrosoftPurview != null && ec.Excludes("microsoftPurview",false))
        {
            this.MicrosoftPurview = null;
        }
        //      C# -> OktaIntegrationConfig? Okta
        // GraphQL -> okta: OktaIntegrationConfig (type)
        if (ec.Includes("okta",false))
        {
            if(this.Okta == null) {

                this.Okta = new OktaIntegrationConfig();
                this.Okta.ApplyExploratoryFieldSpec(ec.NewChild("okta"));

            } else {

                this.Okta.ApplyExploratoryFieldSpec(ec.NewChild("okta"));

            }
        }
        else if (this.Okta != null && ec.Excludes("okta",false))
        {
            this.Okta = null;
        }
        //      C# -> PamIntegrationConfig? Pam
        // GraphQL -> pam: PamIntegrationConfig (type)
        if (ec.Includes("pam",false))
        {
            if(this.Pam == null) {

                this.Pam = new PamIntegrationConfig();
                this.Pam.ApplyExploratoryFieldSpec(ec.NewChild("pam"));

            } else {

                this.Pam.ApplyExploratoryFieldSpec(ec.NewChild("pam"));

            }
        }
        else if (this.Pam != null && ec.Excludes("pam",false))
        {
            this.Pam = null;
        }
        //      C# -> ServiceNowItsmIntegrationConfig? ServiceNowItsm
        // GraphQL -> serviceNowItsm: ServiceNowItsmIntegrationConfig (type)
        if (ec.Includes("serviceNowItsm",false))
        {
            if(this.ServiceNowItsm == null) {

                this.ServiceNowItsm = new ServiceNowItsmIntegrationConfig();
                this.ServiceNowItsm.ApplyExploratoryFieldSpec(ec.NewChild("serviceNowItsm"));

            } else {

                this.ServiceNowItsm.ApplyExploratoryFieldSpec(ec.NewChild("serviceNowItsm"));

            }
        }
        else if (this.ServiceNowItsm != null && ec.Excludes("serviceNowItsm",false))
        {
            this.ServiceNowItsm = null;
        }
    }


    #endregion

    } // class IntegrationConfig
    
    #endregion

    public static class ListIntegrationConfigExtensions
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
            this List<IntegrationConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IntegrationConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IntegrationConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IntegrationConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IntegrationConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types