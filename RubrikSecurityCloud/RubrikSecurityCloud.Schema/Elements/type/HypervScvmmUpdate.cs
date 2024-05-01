// HypervScvmmUpdate.cs
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
    #region HypervScvmmUpdate
    public class HypervScvmmUpdate: BaseType
    {
        #region members

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.String? RunAsAccount
        // GraphQL -> runAsAccount: String (scalar)
        [JsonProperty("runAsAccount")]
        public System.String? RunAsAccount { get; set; }

        //      C# -> System.Boolean? ShouldDeployAgent
        // GraphQL -> shouldDeployAgent: Boolean (scalar)
        [JsonProperty("shouldDeployAgent")]
        public System.Boolean? ShouldDeployAgent { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HypervScvmmUpdate";
    }

    public HypervScvmmUpdate Set(
        System.String? ConfiguredSlaDomainId = null,
        System.String? Hostname = null,
        System.String? RunAsAccount = null,
        System.Boolean? ShouldDeployAgent = null
    ) 
    {
        if ( ConfiguredSlaDomainId != null ) {
            this.ConfiguredSlaDomainId = ConfiguredSlaDomainId;
        }
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( RunAsAccount != null ) {
            this.RunAsAccount = RunAsAccount;
        }
        if ( ShouldDeployAgent != null ) {
            this.ShouldDeployAgent = ShouldDeployAgent;
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
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        if (this.ConfiguredSlaDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configuredSlaDomainId\n" ;
            } else {
                s += ind + "configuredSlaDomainId\n" ;
            }
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String (scalar)
        if (this.Hostname != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostname\n" ;
            } else {
                s += ind + "hostname\n" ;
            }
        }
        //      C# -> System.String? RunAsAccount
        // GraphQL -> runAsAccount: String (scalar)
        if (this.RunAsAccount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "runAsAccount\n" ;
            } else {
                s += ind + "runAsAccount\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldDeployAgent
        // GraphQL -> shouldDeployAgent: Boolean (scalar)
        if (this.ShouldDeployAgent != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldDeployAgent\n" ;
            } else {
                s += ind + "shouldDeployAgent\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        if (ec.Includes("configuredSlaDomainId",true))
        {
            if(this.ConfiguredSlaDomainId == null) {

                this.ConfiguredSlaDomainId = "FETCH";

            } else {


            }
        }
        else if (this.ConfiguredSlaDomainId != null && ec.Excludes("configuredSlaDomainId",true))
        {
            this.ConfiguredSlaDomainId = null;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String (scalar)
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
        //      C# -> System.String? RunAsAccount
        // GraphQL -> runAsAccount: String (scalar)
        if (ec.Includes("runAsAccount",true))
        {
            if(this.RunAsAccount == null) {

                this.RunAsAccount = "FETCH";

            } else {


            }
        }
        else if (this.RunAsAccount != null && ec.Excludes("runAsAccount",true))
        {
            this.RunAsAccount = null;
        }
        //      C# -> System.Boolean? ShouldDeployAgent
        // GraphQL -> shouldDeployAgent: Boolean (scalar)
        if (ec.Includes("shouldDeployAgent",true))
        {
            if(this.ShouldDeployAgent == null) {

                this.ShouldDeployAgent = true;

            } else {


            }
        }
        else if (this.ShouldDeployAgent != null && ec.Excludes("shouldDeployAgent",true))
        {
            this.ShouldDeployAgent = null;
        }
    }


    #endregion

    } // class HypervScvmmUpdate
    
    #endregion

    public static class ListHypervScvmmUpdateExtensions
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
            this List<HypervScvmmUpdate> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HypervScvmmUpdate> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HypervScvmmUpdate> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HypervScvmmUpdate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HypervScvmmUpdate> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types