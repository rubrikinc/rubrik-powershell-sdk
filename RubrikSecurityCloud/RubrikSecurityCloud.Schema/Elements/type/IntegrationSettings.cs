// IntegrationSettings.cs
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
    #region IntegrationSettings
    public class IntegrationSettings: BaseType
    {
        #region members

        //      C# -> CrowdStrikeIntegrationSettings? CrowdStrike
        // GraphQL -> crowdStrike: CrowdStrikeIntegrationSettings (type)
        [JsonProperty("crowdStrike")]
        public CrowdStrikeIntegrationSettings? CrowdStrike { get; set; }

        //      C# -> MicrosoftDefenderIntegrationSettings? MicrosoftDefender
        // GraphQL -> microsoftDefender: MicrosoftDefenderIntegrationSettings (type)
        [JsonProperty("microsoftDefender")]
        public MicrosoftDefenderIntegrationSettings? MicrosoftDefender { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IntegrationSettings";
    }

    public IntegrationSettings Set(
        CrowdStrikeIntegrationSettings? CrowdStrike = null,
        MicrosoftDefenderIntegrationSettings? MicrosoftDefender = null
    ) 
    {
        if ( CrowdStrike != null ) {
            this.CrowdStrike = CrowdStrike;
        }
        if ( MicrosoftDefender != null ) {
            this.MicrosoftDefender = MicrosoftDefender;
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
        //      C# -> CrowdStrikeIntegrationSettings? CrowdStrike
        // GraphQL -> crowdStrike: CrowdStrikeIntegrationSettings (type)
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
        //      C# -> MicrosoftDefenderIntegrationSettings? MicrosoftDefender
        // GraphQL -> microsoftDefender: MicrosoftDefenderIntegrationSettings (type)
        if (this.MicrosoftDefender != null) {
            var fspec = this.MicrosoftDefender.AsFieldSpec(conf.Child("microsoftDefender"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "microsoftDefender" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CrowdStrikeIntegrationSettings? CrowdStrike
        // GraphQL -> crowdStrike: CrowdStrikeIntegrationSettings (type)
        if (ec.Includes("crowdStrike",false))
        {
            if(this.CrowdStrike == null) {

                this.CrowdStrike = new CrowdStrikeIntegrationSettings();
                this.CrowdStrike.ApplyExploratoryFieldSpec(ec.NewChild("crowdStrike"));

            } else {

                this.CrowdStrike.ApplyExploratoryFieldSpec(ec.NewChild("crowdStrike"));

            }
        }
        else if (this.CrowdStrike != null && ec.Excludes("crowdStrike",false))
        {
            this.CrowdStrike = null;
        }
        //      C# -> MicrosoftDefenderIntegrationSettings? MicrosoftDefender
        // GraphQL -> microsoftDefender: MicrosoftDefenderIntegrationSettings (type)
        if (ec.Includes("microsoftDefender",false))
        {
            if(this.MicrosoftDefender == null) {

                this.MicrosoftDefender = new MicrosoftDefenderIntegrationSettings();
                this.MicrosoftDefender.ApplyExploratoryFieldSpec(ec.NewChild("microsoftDefender"));

            } else {

                this.MicrosoftDefender.ApplyExploratoryFieldSpec(ec.NewChild("microsoftDefender"));

            }
        }
        else if (this.MicrosoftDefender != null && ec.Excludes("microsoftDefender",false))
        {
            this.MicrosoftDefender = null;
        }
    }


    #endregion

    } // class IntegrationSettings
    
    #endregion

    public static class ListIntegrationSettingsExtensions
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
            this List<IntegrationSettings> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IntegrationSettings> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IntegrationSettings> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IntegrationSettings());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IntegrationSettings> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types