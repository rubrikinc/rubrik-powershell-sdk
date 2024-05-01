// AgentDeploymentSettingsInfo.cs
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
    #region AgentDeploymentSettingsInfo
    public class AgentDeploymentSettingsInfo: BaseType
    {
        #region members

        //      C# -> AgentDeploymentSettings? AgentDeploymentSettings
        // GraphQL -> agentDeploymentSettings: AgentDeploymentSettings! (type)
        [JsonProperty("agentDeploymentSettings")]
        public AgentDeploymentSettings? AgentDeploymentSettings { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AgentDeploymentSettingsInfo";
    }

    public AgentDeploymentSettingsInfo Set(
        AgentDeploymentSettings? AgentDeploymentSettings = null,
        Cluster? Cluster = null
    ) 
    {
        if ( AgentDeploymentSettings != null ) {
            this.AgentDeploymentSettings = AgentDeploymentSettings;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
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
        //      C# -> AgentDeploymentSettings? AgentDeploymentSettings
        // GraphQL -> agentDeploymentSettings: AgentDeploymentSettings! (type)
        if (this.AgentDeploymentSettings != null) {
            var fspec = this.AgentDeploymentSettings.AsFieldSpec(conf.Child("agentDeploymentSettings"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "agentDeploymentSettings" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AgentDeploymentSettings? AgentDeploymentSettings
        // GraphQL -> agentDeploymentSettings: AgentDeploymentSettings! (type)
        if (ec.Includes("agentDeploymentSettings",false))
        {
            if(this.AgentDeploymentSettings == null) {

                this.AgentDeploymentSettings = new AgentDeploymentSettings();
                this.AgentDeploymentSettings.ApplyExploratoryFieldSpec(ec.NewChild("agentDeploymentSettings"));

            } else {

                this.AgentDeploymentSettings.ApplyExploratoryFieldSpec(ec.NewChild("agentDeploymentSettings"));

            }
        }
        else if (this.AgentDeploymentSettings != null && ec.Excludes("agentDeploymentSettings",false))
        {
            this.AgentDeploymentSettings = null;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
        }
    }


    #endregion

    } // class AgentDeploymentSettingsInfo
    
    #endregion

    public static class ListAgentDeploymentSettingsInfoExtensions
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
            this List<AgentDeploymentSettingsInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AgentDeploymentSettingsInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AgentDeploymentSettingsInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AgentDeploymentSettingsInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AgentDeploymentSettingsInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types