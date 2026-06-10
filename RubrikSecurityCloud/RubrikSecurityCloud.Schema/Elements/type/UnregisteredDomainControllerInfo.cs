// UnregisteredDomainControllerInfo.cs
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
    #region UnregisteredDomainControllerInfo
    public class UnregisteredDomainControllerInfo: BaseType
    {
        #region members

        //      C# -> List<FsmoRoles>? FsmoRoles
        // GraphQL -> fsmoRoles: [FsmoRoles!]! (enum)
        [JsonProperty("fsmoRoles")]
        public List<FsmoRoles>? FsmoRoles { get; set; }

        //      C# -> System.String? DomainControllerGuid
        // GraphQL -> domainControllerGuid: String! (scalar)
        [JsonProperty("domainControllerGuid")]
        public System.String? DomainControllerGuid { get; set; }

        //      C# -> System.String? DomainControllerSite
        // GraphQL -> domainControllerSite: String (scalar)
        [JsonProperty("domainControllerSite")]
        public System.String? DomainControllerSite { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.Boolean? IsGlobalCatalog
        // GraphQL -> isGlobalCatalog: Boolean! (scalar)
        [JsonProperty("isGlobalCatalog")]
        public System.Boolean? IsGlobalCatalog { get; set; }

        //      C# -> System.Boolean? IsReadOnly
        // GraphQL -> isReadOnly: Boolean! (scalar)
        [JsonProperty("isReadOnly")]
        public System.Boolean? IsReadOnly { get; set; }

        //      C# -> DateTime? LastDiscoveredTimestamp
        // GraphQL -> lastDiscoveredTimestamp: DateTime (scalar)
        [JsonProperty("lastDiscoveredTimestamp")]
        public DateTime? LastDiscoveredTimestamp { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UnregisteredDomainControllerInfo";
    }

    public UnregisteredDomainControllerInfo Set(
        List<FsmoRoles>? FsmoRoles = null,
        System.String? DomainControllerGuid = null,
        System.String? DomainControllerSite = null,
        System.String? Hostname = null,
        System.Boolean? IsGlobalCatalog = null,
        System.Boolean? IsReadOnly = null,
        DateTime? LastDiscoveredTimestamp = null
    ) 
    {
        if ( FsmoRoles != null ) {
            this.FsmoRoles = FsmoRoles;
        }
        if ( DomainControllerGuid != null ) {
            this.DomainControllerGuid = DomainControllerGuid;
        }
        if ( DomainControllerSite != null ) {
            this.DomainControllerSite = DomainControllerSite;
        }
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( IsGlobalCatalog != null ) {
            this.IsGlobalCatalog = IsGlobalCatalog;
        }
        if ( IsReadOnly != null ) {
            this.IsReadOnly = IsReadOnly;
        }
        if ( LastDiscoveredTimestamp != null ) {
            this.LastDiscoveredTimestamp = LastDiscoveredTimestamp;
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
        //      C# -> List<FsmoRoles>? FsmoRoles
        // GraphQL -> fsmoRoles: [FsmoRoles!]! (enum)
        if (this.FsmoRoles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fsmoRoles\n" ;
            } else {
                s += ind + "fsmoRoles\n" ;
            }
        }
        //      C# -> System.String? DomainControllerGuid
        // GraphQL -> domainControllerGuid: String! (scalar)
        if (this.DomainControllerGuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domainControllerGuid\n" ;
            } else {
                s += ind + "domainControllerGuid\n" ;
            }
        }
        //      C# -> System.String? DomainControllerSite
        // GraphQL -> domainControllerSite: String (scalar)
        if (this.DomainControllerSite != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domainControllerSite\n" ;
            } else {
                s += ind + "domainControllerSite\n" ;
            }
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostname\n" ;
            } else {
                s += ind + "hostname\n" ;
            }
        }
        //      C# -> System.Boolean? IsGlobalCatalog
        // GraphQL -> isGlobalCatalog: Boolean! (scalar)
        if (this.IsGlobalCatalog != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isGlobalCatalog\n" ;
            } else {
                s += ind + "isGlobalCatalog\n" ;
            }
        }
        //      C# -> System.Boolean? IsReadOnly
        // GraphQL -> isReadOnly: Boolean! (scalar)
        if (this.IsReadOnly != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isReadOnly\n" ;
            } else {
                s += ind + "isReadOnly\n" ;
            }
        }
        //      C# -> DateTime? LastDiscoveredTimestamp
        // GraphQL -> lastDiscoveredTimestamp: DateTime (scalar)
        if (this.LastDiscoveredTimestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastDiscoveredTimestamp\n" ;
            } else {
                s += ind + "lastDiscoveredTimestamp\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<FsmoRoles>? FsmoRoles
        // GraphQL -> fsmoRoles: [FsmoRoles!]! (enum)
        if (ec.Includes("fsmoRoles",true))
        {
            if(this.FsmoRoles == null) {

                this.FsmoRoles = new List<FsmoRoles>();

            } else {


            }
        }
        else if (this.FsmoRoles != null && ec.Excludes("fsmoRoles",true))
        {
            this.FsmoRoles = null;
        }
        //      C# -> System.String? DomainControllerGuid
        // GraphQL -> domainControllerGuid: String! (scalar)
        if (ec.Includes("domainControllerGuid",true))
        {
            if(this.DomainControllerGuid == null) {

                this.DomainControllerGuid = "FETCH";

            } else {


            }
        }
        else if (this.DomainControllerGuid != null && ec.Excludes("domainControllerGuid",true))
        {
            this.DomainControllerGuid = null;
        }
        //      C# -> System.String? DomainControllerSite
        // GraphQL -> domainControllerSite: String (scalar)
        if (ec.Includes("domainControllerSite",true))
        {
            if(this.DomainControllerSite == null) {

                this.DomainControllerSite = "FETCH";

            } else {


            }
        }
        else if (this.DomainControllerSite != null && ec.Excludes("domainControllerSite",true))
        {
            this.DomainControllerSite = null;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (ec.Includes("hostname",true))
        {
            if(this.Hostname == null) {

                this.Hostname = "FETCH";

            } else {


            }
        }
        else if (this.Hostname != null && ec.Excludes("hostname",true))
        {
            this.Hostname = null;
        }
        //      C# -> System.Boolean? IsGlobalCatalog
        // GraphQL -> isGlobalCatalog: Boolean! (scalar)
        if (ec.Includes("isGlobalCatalog",true))
        {
            if(this.IsGlobalCatalog == null) {

                this.IsGlobalCatalog = true;

            } else {


            }
        }
        else if (this.IsGlobalCatalog != null && ec.Excludes("isGlobalCatalog",true))
        {
            this.IsGlobalCatalog = null;
        }
        //      C# -> System.Boolean? IsReadOnly
        // GraphQL -> isReadOnly: Boolean! (scalar)
        if (ec.Includes("isReadOnly",true))
        {
            if(this.IsReadOnly == null) {

                this.IsReadOnly = true;

            } else {


            }
        }
        else if (this.IsReadOnly != null && ec.Excludes("isReadOnly",true))
        {
            this.IsReadOnly = null;
        }
        //      C# -> DateTime? LastDiscoveredTimestamp
        // GraphQL -> lastDiscoveredTimestamp: DateTime (scalar)
        if (ec.Includes("lastDiscoveredTimestamp",true))
        {
            if(this.LastDiscoveredTimestamp == null) {

                this.LastDiscoveredTimestamp = new DateTime();

            } else {


            }
        }
        else if (this.LastDiscoveredTimestamp != null && ec.Excludes("lastDiscoveredTimestamp",true))
        {
            this.LastDiscoveredTimestamp = null;
        }
    }


    #endregion

    } // class UnregisteredDomainControllerInfo
    
    #endregion

    public static class ListUnregisteredDomainControllerInfoExtensions
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
            this List<UnregisteredDomainControllerInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UnregisteredDomainControllerInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UnregisteredDomainControllerInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UnregisteredDomainControllerInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UnregisteredDomainControllerInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types