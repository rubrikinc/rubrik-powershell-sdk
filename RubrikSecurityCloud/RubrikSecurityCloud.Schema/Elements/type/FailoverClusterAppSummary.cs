// FailoverClusterAppSummary.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region FailoverClusterAppSummary
    public class FailoverClusterAppSummary: BaseType
    {
        #region members

        //      C# -> FailoverClusterAppConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: FailoverClusterAppConnectionStatus! (enum)
        [JsonProperty("connectionStatus")]
        public FailoverClusterAppConnectionStatus? ConnectionStatus { get; set; }

        //      C# -> FailoverClusterOsType? OperatingSystemType
        // GraphQL -> operatingSystemType: FailoverClusterOsType (enum)
        [JsonProperty("operatingSystemType")]
        public FailoverClusterOsType? OperatingSystemType { get; set; }

        //      C# -> SlaAssignment? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignment (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignment? SlaAssignment { get; set; }

        //      C# -> System.String? FailoverClusterName
        // GraphQL -> failoverClusterName: String (scalar)
        [JsonProperty("failoverClusterName")]
        public System.String? FailoverClusterName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        [JsonProperty("primaryClusterId")]
        public System.String? PrimaryClusterId { get; set; }

        //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
        // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
        [JsonProperty("effectiveSlaHolder")]
        public EffectiveSlaHolder? EffectiveSlaHolder { get; set; }

        //      C# -> FailoverClusterAppConfig? FailoverClusterAppConfig
        // GraphQL -> failoverClusterAppConfig: FailoverClusterAppConfig (type)
        [JsonProperty("failoverClusterAppConfig")]
        public FailoverClusterAppConfig? FailoverClusterAppConfig { get; set; }

        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        [JsonProperty("slaAssignable")]
        public SlaAssignable? SlaAssignable { get; set; }


        #endregion

    #region methods

    public FailoverClusterAppSummary Set(
        FailoverClusterAppConnectionStatus? ConnectionStatus = null,
        FailoverClusterOsType? OperatingSystemType = null,
        SlaAssignment? SlaAssignment = null,
        System.String? FailoverClusterName = null,
        System.String? Id = null,
        System.String? PrimaryClusterId = null,
        EffectiveSlaHolder? EffectiveSlaHolder = null,
        FailoverClusterAppConfig? FailoverClusterAppConfig = null,
        SlaAssignable? SlaAssignable = null
    ) 
    {
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( OperatingSystemType != null ) {
            this.OperatingSystemType = OperatingSystemType;
        }
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
        if ( FailoverClusterName != null ) {
            this.FailoverClusterName = FailoverClusterName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( PrimaryClusterId != null ) {
            this.PrimaryClusterId = PrimaryClusterId;
        }
        if ( EffectiveSlaHolder != null ) {
            this.EffectiveSlaHolder = EffectiveSlaHolder;
        }
        if ( FailoverClusterAppConfig != null ) {
            this.FailoverClusterAppConfig = FailoverClusterAppConfig;
        }
        if ( SlaAssignable != null ) {
            this.SlaAssignable = SlaAssignable;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> FailoverClusterAppConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: FailoverClusterAppConnectionStatus! (enum)
        if (this.ConnectionStatus != null) {
            s += ind + "connectionStatus\n" ;
        }
        //      C# -> FailoverClusterOsType? OperatingSystemType
        // GraphQL -> operatingSystemType: FailoverClusterOsType (enum)
        if (this.OperatingSystemType != null) {
            s += ind + "operatingSystemType\n" ;
        }
        //      C# -> SlaAssignment? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignment (enum)
        if (this.SlaAssignment != null) {
            s += ind + "slaAssignment\n" ;
        }
        //      C# -> System.String? FailoverClusterName
        // GraphQL -> failoverClusterName: String (scalar)
        if (this.FailoverClusterName != null) {
            s += ind + "failoverClusterName\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId != null) {
            s += ind + "primaryClusterId\n" ;
        }
        //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
        // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
        if (this.EffectiveSlaHolder != null) {
            s += ind + "effectiveSlaHolder {\n" + this.EffectiveSlaHolder.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> FailoverClusterAppConfig? FailoverClusterAppConfig
        // GraphQL -> failoverClusterAppConfig: FailoverClusterAppConfig (type)
        if (this.FailoverClusterAppConfig != null) {
            s += ind + "failoverClusterAppConfig {\n" + this.FailoverClusterAppConfig.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable != null) {
            s += ind + "slaAssignable {\n" + this.SlaAssignable.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> FailoverClusterAppConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: FailoverClusterAppConnectionStatus! (enum)
        if (this.ConnectionStatus == null && Exploration.Includes(parent + ".connectionStatus", true))
        {
            this.ConnectionStatus = new FailoverClusterAppConnectionStatus();
        }
        //      C# -> FailoverClusterOsType? OperatingSystemType
        // GraphQL -> operatingSystemType: FailoverClusterOsType (enum)
        if (this.OperatingSystemType == null && Exploration.Includes(parent + ".operatingSystemType", true))
        {
            this.OperatingSystemType = new FailoverClusterOsType();
        }
        //      C# -> SlaAssignment? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignment (enum)
        if (this.SlaAssignment == null && Exploration.Includes(parent + ".slaAssignment", true))
        {
            this.SlaAssignment = new SlaAssignment();
        }
        //      C# -> System.String? FailoverClusterName
        // GraphQL -> failoverClusterName: String (scalar)
        if (this.FailoverClusterName == null && Exploration.Includes(parent + ".failoverClusterName", true))
        {
            this.FailoverClusterName = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId == null && Exploration.Includes(parent + ".primaryClusterId", true))
        {
            this.PrimaryClusterId = "FETCH";
        }
        //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
        // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
        if (this.EffectiveSlaHolder == null && Exploration.Includes(parent + ".effectiveSlaHolder"))
        {
            this.EffectiveSlaHolder = new EffectiveSlaHolder();
            this.EffectiveSlaHolder.ApplyExploratoryFieldSpec(parent + ".effectiveSlaHolder");
        }
        //      C# -> FailoverClusterAppConfig? FailoverClusterAppConfig
        // GraphQL -> failoverClusterAppConfig: FailoverClusterAppConfig (type)
        if (this.FailoverClusterAppConfig == null && Exploration.Includes(parent + ".failoverClusterAppConfig"))
        {
            this.FailoverClusterAppConfig = new FailoverClusterAppConfig();
            this.FailoverClusterAppConfig.ApplyExploratoryFieldSpec(parent + ".failoverClusterAppConfig");
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable == null && Exploration.Includes(parent + ".slaAssignable"))
        {
            this.SlaAssignable = new SlaAssignable();
            this.SlaAssignable.ApplyExploratoryFieldSpec(parent + ".slaAssignable");
        }
    }


    #endregion

    } // class FailoverClusterAppSummary
    
    #endregion

    public static class ListFailoverClusterAppSummaryExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<FailoverClusterAppSummary> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FailoverClusterAppSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverClusterAppSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types