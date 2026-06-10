// IntuneDeviceManagementSecretSetting.cs
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
    #region IntuneDeviceManagementSecretSetting
    public class IntuneDeviceManagementSecretSetting: BaseType
    {
        #region members

        //      C# -> IntuneDeviceManagementSecretSettingType? SettingType
        // GraphQL -> settingType: IntuneDeviceManagementSecretSettingType! (enum)
        [JsonProperty("settingType")]
        public IntuneDeviceManagementSecretSettingType? SettingType { get; set; }

        //      C# -> System.String? SettingDefinitionId
        // GraphQL -> settingDefinitionId: String! (scalar)
        [JsonProperty("settingDefinitionId")]
        public System.String? SettingDefinitionId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IntuneDeviceManagementSecretSetting";
    }

    public IntuneDeviceManagementSecretSetting Set(
        IntuneDeviceManagementSecretSettingType? SettingType = null,
        System.String? SettingDefinitionId = null
    ) 
    {
        if ( SettingType != null ) {
            this.SettingType = SettingType;
        }
        if ( SettingDefinitionId != null ) {
            this.SettingDefinitionId = SettingDefinitionId;
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
        //      C# -> IntuneDeviceManagementSecretSettingType? SettingType
        // GraphQL -> settingType: IntuneDeviceManagementSecretSettingType! (enum)
        if (this.SettingType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "settingType\n" ;
            } else {
                s += ind + "settingType\n" ;
            }
        }
        //      C# -> System.String? SettingDefinitionId
        // GraphQL -> settingDefinitionId: String! (scalar)
        if (this.SettingDefinitionId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "settingDefinitionId\n" ;
            } else {
                s += ind + "settingDefinitionId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> IntuneDeviceManagementSecretSettingType? SettingType
        // GraphQL -> settingType: IntuneDeviceManagementSecretSettingType! (enum)
        if (ec.Includes("settingType",true))
        {
            if(this.SettingType == null) {

                this.SettingType = new IntuneDeviceManagementSecretSettingType();

            } else {


            }
        }
        else if (this.SettingType != null && ec.Excludes("settingType",true))
        {
            this.SettingType = null;
        }
        //      C# -> System.String? SettingDefinitionId
        // GraphQL -> settingDefinitionId: String! (scalar)
        if (ec.Includes("settingDefinitionId",true))
        {
            if(this.SettingDefinitionId == null) {

                this.SettingDefinitionId = "FETCH";

            } else {


            }
        }
        else if (this.SettingDefinitionId != null && ec.Excludes("settingDefinitionId",true))
        {
            this.SettingDefinitionId = null;
        }
    }


    #endregion

    } // class IntuneDeviceManagementSecretSetting
    
    #endregion

    public static class ListIntuneDeviceManagementSecretSettingExtensions
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
            this List<IntuneDeviceManagementSecretSetting> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IntuneDeviceManagementSecretSetting> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IntuneDeviceManagementSecretSetting> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IntuneDeviceManagementSecretSetting());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IntuneDeviceManagementSecretSetting> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types