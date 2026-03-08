// MicrosoftDefenderIntegrationConfig.cs
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
    #region MicrosoftDefenderIntegrationConfig
    public class MicrosoftDefenderIntegrationConfig: BaseType
    {
        #region members

        //      C# -> System.String? ApplicationId
        // GraphQL -> applicationId: String! (scalar)
        [JsonProperty("applicationId")]
        public System.String? ApplicationId { get; set; }

        //      C# -> System.String? ClientSecret
        // GraphQL -> clientSecret: String! (scalar)
        [JsonProperty("clientSecret")]
        public System.String? ClientSecret { get; set; }

        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        [JsonProperty("domainName")]
        public System.String? DomainName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MicrosoftDefenderIntegrationConfig";
    }

    public MicrosoftDefenderIntegrationConfig Set(
        System.String? ApplicationId = null,
        System.String? ClientSecret = null,
        System.String? DomainName = null
    ) 
    {
        if ( ApplicationId != null ) {
            this.ApplicationId = ApplicationId;
        }
        if ( ClientSecret != null ) {
            this.ClientSecret = ClientSecret;
        }
        if ( DomainName != null ) {
            this.DomainName = DomainName;
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
        //      C# -> System.String? ApplicationId
        // GraphQL -> applicationId: String! (scalar)
        if (this.ApplicationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "applicationId\n" ;
            } else {
                s += ind + "applicationId\n" ;
            }
        }
        //      C# -> System.String? ClientSecret
        // GraphQL -> clientSecret: String! (scalar)
        if (this.ClientSecret != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clientSecret\n" ;
            } else {
                s += ind + "clientSecret\n" ;
            }
        }
        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        if (this.DomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domainName\n" ;
            } else {
                s += ind + "domainName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ApplicationId
        // GraphQL -> applicationId: String! (scalar)
        if (ec.Includes("applicationId",true))
        {
            if(this.ApplicationId == null) {

                this.ApplicationId = "FETCH";

            } else {


            }
        }
        else if (this.ApplicationId != null && ec.Excludes("applicationId",true))
        {
            this.ApplicationId = null;
        }
        //      C# -> System.String? ClientSecret
        // GraphQL -> clientSecret: String! (scalar)
        if (ec.Includes("clientSecret",true))
        {
            if(this.ClientSecret == null) {

                this.ClientSecret = "FETCH";

            } else {


            }
        }
        else if (this.ClientSecret != null && ec.Excludes("clientSecret",true))
        {
            this.ClientSecret = null;
        }
        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        if (ec.Includes("domainName",true))
        {
            if(this.DomainName == null) {

                this.DomainName = "FETCH";

            } else {


            }
        }
        else if (this.DomainName != null && ec.Excludes("domainName",true))
        {
            this.DomainName = null;
        }
    }


    #endregion

    } // class MicrosoftDefenderIntegrationConfig
    
    #endregion

    public static class ListMicrosoftDefenderIntegrationConfigExtensions
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
            this List<MicrosoftDefenderIntegrationConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MicrosoftDefenderIntegrationConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MicrosoftDefenderIntegrationConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MicrosoftDefenderIntegrationConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MicrosoftDefenderIntegrationConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types