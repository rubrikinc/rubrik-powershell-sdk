// DcMetadata.cs
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
    #region DcMetadata
    public class DcMetadata: BaseType
    {
        #region members

        //      C# -> System.String? ComputerObjectDn
        // GraphQL -> computerObjectDn: String (scalar)
        [JsonProperty("computerObjectDn")]
        public System.String? ComputerObjectDn { get; set; }

        //      C# -> System.String? ConfigurationNc
        // GraphQL -> configurationNc: String (scalar)
        [JsonProperty("configurationNc")]
        public System.String? ConfigurationNc { get; set; }

        //      C# -> System.String? DnsForestName
        // GraphQL -> dnsForestName: String (scalar)
        [JsonProperty("dnsForestName")]
        public System.String? DnsForestName { get; set; }

        //      C# -> List<System.String>? DnsServerForwarders
        // GraphQL -> dnsServerForwarders: [String!] (scalar)
        [JsonProperty("dnsServerForwarders")]
        public List<System.String>? DnsServerForwarders { get; set; }

        //      C# -> System.Int32? DomainFunctionalLevel
        // GraphQL -> domainFunctionalLevel: Int (scalar)
        [JsonProperty("domainFunctionalLevel")]
        public System.Int32? DomainFunctionalLevel { get; set; }

        //      C# -> System.String? DomainGuid
        // GraphQL -> domainGuid: String (scalar)
        [JsonProperty("domainGuid")]
        public System.String? DomainGuid { get; set; }

        //      C# -> System.Int32? ForestFunctionalLevel
        // GraphQL -> forestFunctionalLevel: Int (scalar)
        [JsonProperty("forestFunctionalLevel")]
        public System.Int32? ForestFunctionalLevel { get; set; }

        //      C# -> System.String? MachineDnName
        // GraphQL -> machineDnName: String (scalar)
        [JsonProperty("machineDnName")]
        public System.String? MachineDnName { get; set; }

        //      C# -> System.String? RootDomain
        // GraphQL -> rootDomain: String (scalar)
        [JsonProperty("rootDomain")]
        public System.String? RootDomain { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DcMetadata";
    }

    public DcMetadata Set(
        System.String? ComputerObjectDn = null,
        System.String? ConfigurationNc = null,
        System.String? DnsForestName = null,
        List<System.String>? DnsServerForwarders = null,
        System.Int32? DomainFunctionalLevel = null,
        System.String? DomainGuid = null,
        System.Int32? ForestFunctionalLevel = null,
        System.String? MachineDnName = null,
        System.String? RootDomain = null
    ) 
    {
        if ( ComputerObjectDn != null ) {
            this.ComputerObjectDn = ComputerObjectDn;
        }
        if ( ConfigurationNc != null ) {
            this.ConfigurationNc = ConfigurationNc;
        }
        if ( DnsForestName != null ) {
            this.DnsForestName = DnsForestName;
        }
        if ( DnsServerForwarders != null ) {
            this.DnsServerForwarders = DnsServerForwarders;
        }
        if ( DomainFunctionalLevel != null ) {
            this.DomainFunctionalLevel = DomainFunctionalLevel;
        }
        if ( DomainGuid != null ) {
            this.DomainGuid = DomainGuid;
        }
        if ( ForestFunctionalLevel != null ) {
            this.ForestFunctionalLevel = ForestFunctionalLevel;
        }
        if ( MachineDnName != null ) {
            this.MachineDnName = MachineDnName;
        }
        if ( RootDomain != null ) {
            this.RootDomain = RootDomain;
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
        //      C# -> System.String? ComputerObjectDn
        // GraphQL -> computerObjectDn: String (scalar)
        if (this.ComputerObjectDn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "computerObjectDn\n" ;
            } else {
                s += ind + "computerObjectDn\n" ;
            }
        }
        //      C# -> System.String? ConfigurationNc
        // GraphQL -> configurationNc: String (scalar)
        if (this.ConfigurationNc != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configurationNc\n" ;
            } else {
                s += ind + "configurationNc\n" ;
            }
        }
        //      C# -> System.String? DnsForestName
        // GraphQL -> dnsForestName: String (scalar)
        if (this.DnsForestName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dnsForestName\n" ;
            } else {
                s += ind + "dnsForestName\n" ;
            }
        }
        //      C# -> List<System.String>? DnsServerForwarders
        // GraphQL -> dnsServerForwarders: [String!] (scalar)
        if (this.DnsServerForwarders != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dnsServerForwarders\n" ;
            } else {
                s += ind + "dnsServerForwarders\n" ;
            }
        }
        //      C# -> System.Int32? DomainFunctionalLevel
        // GraphQL -> domainFunctionalLevel: Int (scalar)
        if (this.DomainFunctionalLevel != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domainFunctionalLevel\n" ;
            } else {
                s += ind + "domainFunctionalLevel\n" ;
            }
        }
        //      C# -> System.String? DomainGuid
        // GraphQL -> domainGuid: String (scalar)
        if (this.DomainGuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domainGuid\n" ;
            } else {
                s += ind + "domainGuid\n" ;
            }
        }
        //      C# -> System.Int32? ForestFunctionalLevel
        // GraphQL -> forestFunctionalLevel: Int (scalar)
        if (this.ForestFunctionalLevel != null) {
            if (conf.Flat) {
                s += conf.Prefix + "forestFunctionalLevel\n" ;
            } else {
                s += ind + "forestFunctionalLevel\n" ;
            }
        }
        //      C# -> System.String? MachineDnName
        // GraphQL -> machineDnName: String (scalar)
        if (this.MachineDnName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "machineDnName\n" ;
            } else {
                s += ind + "machineDnName\n" ;
            }
        }
        //      C# -> System.String? RootDomain
        // GraphQL -> rootDomain: String (scalar)
        if (this.RootDomain != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rootDomain\n" ;
            } else {
                s += ind + "rootDomain\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ComputerObjectDn
        // GraphQL -> computerObjectDn: String (scalar)
        if (ec.Includes("computerObjectDn",true))
        {
            if(this.ComputerObjectDn == null) {

                this.ComputerObjectDn = "FETCH";

            } else {


            }
        }
        else if (this.ComputerObjectDn != null && ec.Excludes("computerObjectDn",true))
        {
            this.ComputerObjectDn = null;
        }
        //      C# -> System.String? ConfigurationNc
        // GraphQL -> configurationNc: String (scalar)
        if (ec.Includes("configurationNc",true))
        {
            if(this.ConfigurationNc == null) {

                this.ConfigurationNc = "FETCH";

            } else {


            }
        }
        else if (this.ConfigurationNc != null && ec.Excludes("configurationNc",true))
        {
            this.ConfigurationNc = null;
        }
        //      C# -> System.String? DnsForestName
        // GraphQL -> dnsForestName: String (scalar)
        if (ec.Includes("dnsForestName",true))
        {
            if(this.DnsForestName == null) {

                this.DnsForestName = "FETCH";

            } else {


            }
        }
        else if (this.DnsForestName != null && ec.Excludes("dnsForestName",true))
        {
            this.DnsForestName = null;
        }
        //      C# -> List<System.String>? DnsServerForwarders
        // GraphQL -> dnsServerForwarders: [String!] (scalar)
        if (ec.Includes("dnsServerForwarders",true))
        {
            if(this.DnsServerForwarders == null) {

                this.DnsServerForwarders = new List<System.String>();

            } else {


            }
        }
        else if (this.DnsServerForwarders != null && ec.Excludes("dnsServerForwarders",true))
        {
            this.DnsServerForwarders = null;
        }
        //      C# -> System.Int32? DomainFunctionalLevel
        // GraphQL -> domainFunctionalLevel: Int (scalar)
        if (ec.Includes("domainFunctionalLevel",true))
        {
            if(this.DomainFunctionalLevel == null) {

                this.DomainFunctionalLevel = Int32.MinValue;

            } else {


            }
        }
        else if (this.DomainFunctionalLevel != null && ec.Excludes("domainFunctionalLevel",true))
        {
            this.DomainFunctionalLevel = null;
        }
        //      C# -> System.String? DomainGuid
        // GraphQL -> domainGuid: String (scalar)
        if (ec.Includes("domainGuid",true))
        {
            if(this.DomainGuid == null) {

                this.DomainGuid = "FETCH";

            } else {


            }
        }
        else if (this.DomainGuid != null && ec.Excludes("domainGuid",true))
        {
            this.DomainGuid = null;
        }
        //      C# -> System.Int32? ForestFunctionalLevel
        // GraphQL -> forestFunctionalLevel: Int (scalar)
        if (ec.Includes("forestFunctionalLevel",true))
        {
            if(this.ForestFunctionalLevel == null) {

                this.ForestFunctionalLevel = Int32.MinValue;

            } else {


            }
        }
        else if (this.ForestFunctionalLevel != null && ec.Excludes("forestFunctionalLevel",true))
        {
            this.ForestFunctionalLevel = null;
        }
        //      C# -> System.String? MachineDnName
        // GraphQL -> machineDnName: String (scalar)
        if (ec.Includes("machineDnName",true))
        {
            if(this.MachineDnName == null) {

                this.MachineDnName = "FETCH";

            } else {


            }
        }
        else if (this.MachineDnName != null && ec.Excludes("machineDnName",true))
        {
            this.MachineDnName = null;
        }
        //      C# -> System.String? RootDomain
        // GraphQL -> rootDomain: String (scalar)
        if (ec.Includes("rootDomain",true))
        {
            if(this.RootDomain == null) {

                this.RootDomain = "FETCH";

            } else {


            }
        }
        else if (this.RootDomain != null && ec.Excludes("rootDomain",true))
        {
            this.RootDomain = null;
        }
    }


    #endregion

    } // class DcMetadata
    
    #endregion

    public static class ListDcMetadataExtensions
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
            this List<DcMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DcMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DcMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DcMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DcMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types