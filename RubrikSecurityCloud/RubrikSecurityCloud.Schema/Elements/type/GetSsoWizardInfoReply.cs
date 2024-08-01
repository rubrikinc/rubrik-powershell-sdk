// GetSsoWizardInfoReply.cs
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
    #region GetSsoWizardInfoReply
    public class GetSsoWizardInfoReply: BaseType
    {
        #region members

        //      C# -> SsoSetupStatus? SsoSetupStatus
        // GraphQL -> ssoSetupStatus: SsoSetupStatus! (enum)
        [JsonProperty("ssoSetupStatus")]
        public SsoSetupStatus? SsoSetupStatus { get; set; }

        //      C# -> System.Boolean? IsAllowedAuthDomainControl
        // GraphQL -> isAllowedAuthDomainControl: Boolean! (scalar)
        [JsonProperty("isAllowedAuthDomainControl")]
        public System.Boolean? IsAllowedAuthDomainControl { get; set; }

        //      C# -> System.Boolean? IsSsoConfigured
        // GraphQL -> isSsoConfigured: Boolean! (scalar)
        [JsonProperty("isSsoConfigured")]
        public System.Boolean? IsSsoConfigured { get; set; }

        //      C# -> System.String? SsoMigrationDeadline
        // GraphQL -> ssoMigrationDeadline: String! (scalar)
        [JsonProperty("ssoMigrationDeadline")]
        public System.String? SsoMigrationDeadline { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetSSOWizardInfoReply";
    }

    public GetSsoWizardInfoReply Set(
        SsoSetupStatus? SsoSetupStatus = null,
        System.Boolean? IsAllowedAuthDomainControl = null,
        System.Boolean? IsSsoConfigured = null,
        System.String? SsoMigrationDeadline = null
    ) 
    {
        if ( SsoSetupStatus != null ) {
            this.SsoSetupStatus = SsoSetupStatus;
        }
        if ( IsAllowedAuthDomainControl != null ) {
            this.IsAllowedAuthDomainControl = IsAllowedAuthDomainControl;
        }
        if ( IsSsoConfigured != null ) {
            this.IsSsoConfigured = IsSsoConfigured;
        }
        if ( SsoMigrationDeadline != null ) {
            this.SsoMigrationDeadline = SsoMigrationDeadline;
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
        //      C# -> SsoSetupStatus? SsoSetupStatus
        // GraphQL -> ssoSetupStatus: SsoSetupStatus! (enum)
        if (this.SsoSetupStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ssoSetupStatus\n" ;
            } else {
                s += ind + "ssoSetupStatus\n" ;
            }
        }
        //      C# -> System.Boolean? IsAllowedAuthDomainControl
        // GraphQL -> isAllowedAuthDomainControl: Boolean! (scalar)
        if (this.IsAllowedAuthDomainControl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAllowedAuthDomainControl\n" ;
            } else {
                s += ind + "isAllowedAuthDomainControl\n" ;
            }
        }
        //      C# -> System.Boolean? IsSsoConfigured
        // GraphQL -> isSsoConfigured: Boolean! (scalar)
        if (this.IsSsoConfigured != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSsoConfigured\n" ;
            } else {
                s += ind + "isSsoConfigured\n" ;
            }
        }
        //      C# -> System.String? SsoMigrationDeadline
        // GraphQL -> ssoMigrationDeadline: String! (scalar)
        if (this.SsoMigrationDeadline != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ssoMigrationDeadline\n" ;
            } else {
                s += ind + "ssoMigrationDeadline\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SsoSetupStatus? SsoSetupStatus
        // GraphQL -> ssoSetupStatus: SsoSetupStatus! (enum)
        if (ec.Includes("ssoSetupStatus",true))
        {
            if(this.SsoSetupStatus == null) {

                this.SsoSetupStatus = new SsoSetupStatus();

            } else {


            }
        }
        else if (this.SsoSetupStatus != null && ec.Excludes("ssoSetupStatus",true))
        {
            this.SsoSetupStatus = null;
        }
        //      C# -> System.Boolean? IsAllowedAuthDomainControl
        // GraphQL -> isAllowedAuthDomainControl: Boolean! (scalar)
        if (ec.Includes("isAllowedAuthDomainControl",true))
        {
            if(this.IsAllowedAuthDomainControl == null) {

                this.IsAllowedAuthDomainControl = true;

            } else {


            }
        }
        else if (this.IsAllowedAuthDomainControl != null && ec.Excludes("isAllowedAuthDomainControl",true))
        {
            this.IsAllowedAuthDomainControl = null;
        }
        //      C# -> System.Boolean? IsSsoConfigured
        // GraphQL -> isSsoConfigured: Boolean! (scalar)
        if (ec.Includes("isSsoConfigured",true))
        {
            if(this.IsSsoConfigured == null) {

                this.IsSsoConfigured = true;

            } else {


            }
        }
        else if (this.IsSsoConfigured != null && ec.Excludes("isSsoConfigured",true))
        {
            this.IsSsoConfigured = null;
        }
        //      C# -> System.String? SsoMigrationDeadline
        // GraphQL -> ssoMigrationDeadline: String! (scalar)
        if (ec.Includes("ssoMigrationDeadline",true))
        {
            if(this.SsoMigrationDeadline == null) {

                this.SsoMigrationDeadline = "FETCH";

            } else {


            }
        }
        else if (this.SsoMigrationDeadline != null && ec.Excludes("ssoMigrationDeadline",true))
        {
            this.SsoMigrationDeadline = null;
        }
    }


    #endregion

    } // class GetSsoWizardInfoReply
    
    #endregion

    public static class ListGetSsoWizardInfoReplyExtensions
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
            this List<GetSsoWizardInfoReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetSsoWizardInfoReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetSsoWizardInfoReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetSsoWizardInfoReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetSsoWizardInfoReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types