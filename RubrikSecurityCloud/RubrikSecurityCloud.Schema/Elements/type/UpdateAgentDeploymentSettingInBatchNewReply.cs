// UpdateAgentDeploymentSettingInBatchNewReply.cs
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
    #region UpdateAgentDeploymentSettingInBatchNewReply
    public class UpdateAgentDeploymentSettingInBatchNewReply: BaseType
    {
        #region members

        //      C# -> List<AgentDeploymentSettingsInfo>? Settings
        // GraphQL -> settings: [AgentDeploymentSettingsInfo!]! (type)
        [JsonProperty("settings")]
        public List<AgentDeploymentSettingsInfo>? Settings { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateAgentDeploymentSettingInBatchNewReply";
    }

    public UpdateAgentDeploymentSettingInBatchNewReply Set(
        List<AgentDeploymentSettingsInfo>? Settings = null
    ) 
    {
        if ( Settings != null ) {
            this.Settings = Settings;
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
        //      C# -> List<AgentDeploymentSettingsInfo>? Settings
        // GraphQL -> settings: [AgentDeploymentSettingsInfo!]! (type)
        if (this.Settings != null) {
            var fspec = this.Settings.AsFieldSpec(conf.Child("settings"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "settings" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<AgentDeploymentSettingsInfo>? Settings
        // GraphQL -> settings: [AgentDeploymentSettingsInfo!]! (type)
        if (ec.Includes("settings",false))
        {
            if(this.Settings == null) {

                this.Settings = new List<AgentDeploymentSettingsInfo>();
                this.Settings.ApplyExploratoryFieldSpec(ec.NewChild("settings"));

            } else {

                this.Settings.ApplyExploratoryFieldSpec(ec.NewChild("settings"));

            }
        }
        else if (this.Settings != null && ec.Excludes("settings",false))
        {
            this.Settings = null;
        }
    }


    #endregion

    } // class UpdateAgentDeploymentSettingInBatchNewReply
    
    #endregion

    public static class ListUpdateAgentDeploymentSettingInBatchNewReplyExtensions
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
            this List<UpdateAgentDeploymentSettingInBatchNewReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UpdateAgentDeploymentSettingInBatchNewReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UpdateAgentDeploymentSettingInBatchNewReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateAgentDeploymentSettingInBatchNewReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpdateAgentDeploymentSettingInBatchNewReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types