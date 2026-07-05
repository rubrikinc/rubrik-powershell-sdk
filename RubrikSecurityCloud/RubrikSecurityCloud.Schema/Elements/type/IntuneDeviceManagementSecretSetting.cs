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

        //      C# -> IntuneSettingItemKeyType? ItemKeyType
        // GraphQL -> itemKeyType: IntuneSettingItemKeyType! (enum)
        [JsonProperty("itemKeyType")]
        public IntuneSettingItemKeyType? ItemKeyType { get; set; }

        //      C# -> IntuneDeviceManagementSecretSettingType? SettingType
        // GraphQL -> settingType: IntuneDeviceManagementSecretSettingType! (enum)
        [JsonProperty("settingType")]
        public IntuneDeviceManagementSecretSettingType? SettingType { get; set; }

        //      C# -> System.String? CollectionDefinitionId
        // GraphQL -> collectionDefinitionId: String! (scalar)
        [JsonProperty("collectionDefinitionId")]
        public System.String? CollectionDefinitionId { get; set; }

        //      C# -> System.String? ItemKeyValue
        // GraphQL -> itemKeyValue: String! (scalar)
        [JsonProperty("itemKeyValue")]
        public System.String? ItemKeyValue { get; set; }

        //      C# -> System.Int32? PasswordCount
        // GraphQL -> passwordCount: Int! (scalar)
        [JsonProperty("passwordCount")]
        public System.Int32? PasswordCount { get; set; }

        //      C# -> System.Int32? RowIndex
        // GraphQL -> rowIndex: Int! (scalar)
        [JsonProperty("rowIndex")]
        public System.Int32? RowIndex { get; set; }

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
        IntuneSettingItemKeyType? ItemKeyType = null,
        IntuneDeviceManagementSecretSettingType? SettingType = null,
        System.String? CollectionDefinitionId = null,
        System.String? ItemKeyValue = null,
        System.Int32? PasswordCount = null,
        System.Int32? RowIndex = null,
        System.String? SettingDefinitionId = null
    ) 
    {
        if ( ItemKeyType != null ) {
            this.ItemKeyType = ItemKeyType;
        }
        if ( SettingType != null ) {
            this.SettingType = SettingType;
        }
        if ( CollectionDefinitionId != null ) {
            this.CollectionDefinitionId = CollectionDefinitionId;
        }
        if ( ItemKeyValue != null ) {
            this.ItemKeyValue = ItemKeyValue;
        }
        if ( PasswordCount != null ) {
            this.PasswordCount = PasswordCount;
        }
        if ( RowIndex != null ) {
            this.RowIndex = RowIndex;
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
        //      C# -> IntuneSettingItemKeyType? ItemKeyType
        // GraphQL -> itemKeyType: IntuneSettingItemKeyType! (enum)
        if (this.ItemKeyType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "itemKeyType\n" ;
            } else {
                s += ind + "itemKeyType\n" ;
            }
        }
        //      C# -> IntuneDeviceManagementSecretSettingType? SettingType
        // GraphQL -> settingType: IntuneDeviceManagementSecretSettingType! (enum)
        if (this.SettingType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "settingType\n" ;
            } else {
                s += ind + "settingType\n" ;
            }
        }
        //      C# -> System.String? CollectionDefinitionId
        // GraphQL -> collectionDefinitionId: String! (scalar)
        if (this.CollectionDefinitionId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "collectionDefinitionId\n" ;
            } else {
                s += ind + "collectionDefinitionId\n" ;
            }
        }
        //      C# -> System.String? ItemKeyValue
        // GraphQL -> itemKeyValue: String! (scalar)
        if (this.ItemKeyValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "itemKeyValue\n" ;
            } else {
                s += ind + "itemKeyValue\n" ;
            }
        }
        //      C# -> System.Int32? PasswordCount
        // GraphQL -> passwordCount: Int! (scalar)
        if (this.PasswordCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "passwordCount\n" ;
            } else {
                s += ind + "passwordCount\n" ;
            }
        }
        //      C# -> System.Int32? RowIndex
        // GraphQL -> rowIndex: Int! (scalar)
        if (this.RowIndex != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rowIndex\n" ;
            } else {
                s += ind + "rowIndex\n" ;
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
        //      C# -> IntuneSettingItemKeyType? ItemKeyType
        // GraphQL -> itemKeyType: IntuneSettingItemKeyType! (enum)
        if (ec.Includes("itemKeyType",true))
        {
            if(this.ItemKeyType == null) {

                this.ItemKeyType = new IntuneSettingItemKeyType();

            } else {


            }
        }
        else if (this.ItemKeyType != null && ec.Excludes("itemKeyType",true))
        {
            this.ItemKeyType = null;
        }
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
        //      C# -> System.String? CollectionDefinitionId
        // GraphQL -> collectionDefinitionId: String! (scalar)
        if (ec.Includes("collectionDefinitionId",true))
        {
            if(this.CollectionDefinitionId == null) {

                this.CollectionDefinitionId = "FETCH";

            } else {


            }
        }
        else if (this.CollectionDefinitionId != null && ec.Excludes("collectionDefinitionId",true))
        {
            this.CollectionDefinitionId = null;
        }
        //      C# -> System.String? ItemKeyValue
        // GraphQL -> itemKeyValue: String! (scalar)
        if (ec.Includes("itemKeyValue",true))
        {
            if(this.ItemKeyValue == null) {

                this.ItemKeyValue = "FETCH";

            } else {


            }
        }
        else if (this.ItemKeyValue != null && ec.Excludes("itemKeyValue",true))
        {
            this.ItemKeyValue = null;
        }
        //      C# -> System.Int32? PasswordCount
        // GraphQL -> passwordCount: Int! (scalar)
        if (ec.Includes("passwordCount",true))
        {
            if(this.PasswordCount == null) {

                this.PasswordCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.PasswordCount != null && ec.Excludes("passwordCount",true))
        {
            this.PasswordCount = null;
        }
        //      C# -> System.Int32? RowIndex
        // GraphQL -> rowIndex: Int! (scalar)
        if (ec.Includes("rowIndex",true))
        {
            if(this.RowIndex == null) {

                this.RowIndex = Int32.MinValue;

            } else {


            }
        }
        else if (this.RowIndex != null && ec.Excludes("rowIndex",true))
        {
            this.RowIndex = null;
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