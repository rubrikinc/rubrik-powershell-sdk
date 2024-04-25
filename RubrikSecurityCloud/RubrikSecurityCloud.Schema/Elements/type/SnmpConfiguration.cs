// SnmpConfiguration.cs
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
    #region SnmpConfiguration
    public class SnmpConfiguration: BaseType
    {
        #region members

        //      C# -> System.String? CommunityString
        // GraphQL -> communityString: String (scalar)
        [JsonProperty("communityString")]
        public System.String? CommunityString { get; set; }

        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        [JsonProperty("isEnabled")]
        public System.Boolean? IsEnabled { get; set; }

        //      C# -> System.Int32? SnmpAgentPort
        // GraphQL -> snmpAgentPort: Int! (scalar)
        [JsonProperty("snmpAgentPort")]
        public System.Int32? SnmpAgentPort { get; set; }

        //      C# -> List<System.String>? Users
        // GraphQL -> users: [String!]! (scalar)
        [JsonProperty("users")]
        public List<System.String>? Users { get; set; }

        //      C# -> List<SnmpTrapReceiverConfig>? TrapReceiverConfigs
        // GraphQL -> trapReceiverConfigs: [SnmpTrapReceiverConfig!]! (type)
        [JsonProperty("trapReceiverConfigs")]
        public List<SnmpTrapReceiverConfig>? TrapReceiverConfigs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SnmpConfiguration";
    }

    public SnmpConfiguration Set(
        System.String? CommunityString = null,
        System.Boolean? IsEnabled = null,
        System.Int32? SnmpAgentPort = null,
        List<System.String>? Users = null,
        List<SnmpTrapReceiverConfig>? TrapReceiverConfigs = null
    ) 
    {
        if ( CommunityString != null ) {
            this.CommunityString = CommunityString;
        }
        if ( IsEnabled != null ) {
            this.IsEnabled = IsEnabled;
        }
        if ( SnmpAgentPort != null ) {
            this.SnmpAgentPort = SnmpAgentPort;
        }
        if ( Users != null ) {
            this.Users = Users;
        }
        if ( TrapReceiverConfigs != null ) {
            this.TrapReceiverConfigs = TrapReceiverConfigs;
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
        //      C# -> System.String? CommunityString
        // GraphQL -> communityString: String (scalar)
        if (this.CommunityString != null) {
            if (conf.Flat) {
                s += conf.Prefix + "communityString\n" ;
            } else {
                s += ind + "communityString\n" ;
            }
        }
        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        if (this.IsEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEnabled\n" ;
            } else {
                s += ind + "isEnabled\n" ;
            }
        }
        //      C# -> System.Int32? SnmpAgentPort
        // GraphQL -> snmpAgentPort: Int! (scalar)
        if (this.SnmpAgentPort != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snmpAgentPort\n" ;
            } else {
                s += ind + "snmpAgentPort\n" ;
            }
        }
        //      C# -> List<System.String>? Users
        // GraphQL -> users: [String!]! (scalar)
        if (this.Users != null) {
            if (conf.Flat) {
                s += conf.Prefix + "users\n" ;
            } else {
                s += ind + "users\n" ;
            }
        }
        //      C# -> List<SnmpTrapReceiverConfig>? TrapReceiverConfigs
        // GraphQL -> trapReceiverConfigs: [SnmpTrapReceiverConfig!]! (type)
        if (this.TrapReceiverConfigs != null) {
            var fspec = this.TrapReceiverConfigs.AsFieldSpec(conf.Child("trapReceiverConfigs"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "trapReceiverConfigs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CommunityString
        // GraphQL -> communityString: String (scalar)
        if (ec.Includes("communityString",true))
        {
            if(this.CommunityString == null) {

                this.CommunityString = "FETCH";

            } else {


            }
        }
        else if (this.CommunityString != null && ec.Excludes("communityString",true))
        {
            this.CommunityString = null;
        }
        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        if (ec.Includes("isEnabled",true))
        {
            if(this.IsEnabled == null) {

                this.IsEnabled = true;

            } else {


            }
        }
        else if (this.IsEnabled != null && ec.Excludes("isEnabled",true))
        {
            this.IsEnabled = null;
        }
        //      C# -> System.Int32? SnmpAgentPort
        // GraphQL -> snmpAgentPort: Int! (scalar)
        if (ec.Includes("snmpAgentPort",true))
        {
            if(this.SnmpAgentPort == null) {

                this.SnmpAgentPort = Int32.MinValue;

            } else {


            }
        }
        else if (this.SnmpAgentPort != null && ec.Excludes("snmpAgentPort",true))
        {
            this.SnmpAgentPort = null;
        }
        //      C# -> List<System.String>? Users
        // GraphQL -> users: [String!]! (scalar)
        if (ec.Includes("users",true))
        {
            if(this.Users == null) {

                this.Users = new List<System.String>();

            } else {


            }
        }
        else if (this.Users != null && ec.Excludes("users",true))
        {
            this.Users = null;
        }
        //      C# -> List<SnmpTrapReceiverConfig>? TrapReceiverConfigs
        // GraphQL -> trapReceiverConfigs: [SnmpTrapReceiverConfig!]! (type)
        if (ec.Includes("trapReceiverConfigs",false))
        {
            if(this.TrapReceiverConfigs == null) {

                this.TrapReceiverConfigs = new List<SnmpTrapReceiverConfig>();
                this.TrapReceiverConfigs.ApplyExploratoryFieldSpec(ec.NewChild("trapReceiverConfigs"));

            } else {

                this.TrapReceiverConfigs.ApplyExploratoryFieldSpec(ec.NewChild("trapReceiverConfigs"));

            }
        }
        else if (this.TrapReceiverConfigs != null && ec.Excludes("trapReceiverConfigs",false))
        {
            this.TrapReceiverConfigs = null;
        }
    }


    #endregion

    } // class SnmpConfiguration
    
    #endregion

    public static class ListSnmpConfigurationExtensions
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
            this List<SnmpConfiguration> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SnmpConfiguration> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SnmpConfiguration> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SnmpConfiguration());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SnmpConfiguration> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types