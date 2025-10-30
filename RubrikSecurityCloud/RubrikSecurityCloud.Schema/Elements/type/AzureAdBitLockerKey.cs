// AzureAdBitLockerKey.cs
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
    #region AzureAdBitLockerKey
    public class AzureAdBitLockerKey: BaseType
    {
        #region members

        //      C# -> AzureAdBitLockerVolumeType? VolumeType
        // GraphQL -> volumeType: AzureAdBitLockerVolumeType! (enum)
        [JsonProperty("volumeType")]
        public AzureAdBitLockerVolumeType? VolumeType { get; set; }

        //      C# -> DateTime? CreatedDateTime
        // GraphQL -> createdDateTime: DateTime (scalar)
        [JsonProperty("createdDateTime")]
        public DateTime? CreatedDateTime { get; set; }

        //      C# -> System.String? DeviceName
        // GraphQL -> deviceName: String! (scalar)
        [JsonProperty("deviceName")]
        public System.String? DeviceName { get; set; }

        //      C# -> System.String? Key
        // GraphQL -> key: String (scalar)
        [JsonProperty("key")]
        public System.String? Key { get; set; }

        //      C# -> System.String? KeyId
        // GraphQL -> keyId: String! (scalar)
        [JsonProperty("keyId")]
        public System.String? KeyId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdBitLockerKey";
    }

    public AzureAdBitLockerKey Set(
        AzureAdBitLockerVolumeType? VolumeType = null,
        DateTime? CreatedDateTime = null,
        System.String? DeviceName = null,
        System.String? Key = null,
        System.String? KeyId = null
    ) 
    {
        if ( VolumeType != null ) {
            this.VolumeType = VolumeType;
        }
        if ( CreatedDateTime != null ) {
            this.CreatedDateTime = CreatedDateTime;
        }
        if ( DeviceName != null ) {
            this.DeviceName = DeviceName;
        }
        if ( Key != null ) {
            this.Key = Key;
        }
        if ( KeyId != null ) {
            this.KeyId = KeyId;
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
        //      C# -> AzureAdBitLockerVolumeType? VolumeType
        // GraphQL -> volumeType: AzureAdBitLockerVolumeType! (enum)
        if (this.VolumeType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "volumeType\n" ;
            } else {
                s += ind + "volumeType\n" ;
            }
        }
        //      C# -> DateTime? CreatedDateTime
        // GraphQL -> createdDateTime: DateTime (scalar)
        if (this.CreatedDateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdDateTime\n" ;
            } else {
                s += ind + "createdDateTime\n" ;
            }
        }
        //      C# -> System.String? DeviceName
        // GraphQL -> deviceName: String! (scalar)
        if (this.DeviceName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deviceName\n" ;
            } else {
                s += ind + "deviceName\n" ;
            }
        }
        //      C# -> System.String? Key
        // GraphQL -> key: String (scalar)
        if (this.Key != null) {
            if (conf.Flat) {
                s += conf.Prefix + "key\n" ;
            } else {
                s += ind + "key\n" ;
            }
        }
        //      C# -> System.String? KeyId
        // GraphQL -> keyId: String! (scalar)
        if (this.KeyId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "keyId\n" ;
            } else {
                s += ind + "keyId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AzureAdBitLockerVolumeType? VolumeType
        // GraphQL -> volumeType: AzureAdBitLockerVolumeType! (enum)
        if (ec.Includes("volumeType",true))
        {
            if(this.VolumeType == null) {

                this.VolumeType = new AzureAdBitLockerVolumeType();

            } else {


            }
        }
        else if (this.VolumeType != null && ec.Excludes("volumeType",true))
        {
            this.VolumeType = null;
        }
        //      C# -> DateTime? CreatedDateTime
        // GraphQL -> createdDateTime: DateTime (scalar)
        if (ec.Includes("createdDateTime",true))
        {
            if(this.CreatedDateTime == null) {

                this.CreatedDateTime = new DateTime();

            } else {


            }
        }
        else if (this.CreatedDateTime != null && ec.Excludes("createdDateTime",true))
        {
            this.CreatedDateTime = null;
        }
        //      C# -> System.String? DeviceName
        // GraphQL -> deviceName: String! (scalar)
        if (ec.Includes("deviceName",true))
        {
            if(this.DeviceName == null) {

                this.DeviceName = "FETCH";

            } else {


            }
        }
        else if (this.DeviceName != null && ec.Excludes("deviceName",true))
        {
            this.DeviceName = null;
        }
        //      C# -> System.String? Key
        // GraphQL -> key: String (scalar)
        if (ec.Includes("key",true))
        {
            if(this.Key == null) {

                this.Key = "FETCH";

            } else {


            }
        }
        else if (this.Key != null && ec.Excludes("key",true))
        {
            this.Key = null;
        }
        //      C# -> System.String? KeyId
        // GraphQL -> keyId: String! (scalar)
        if (ec.Includes("keyId",true))
        {
            if(this.KeyId == null) {

                this.KeyId = "FETCH";

            } else {


            }
        }
        else if (this.KeyId != null && ec.Excludes("keyId",true))
        {
            this.KeyId = null;
        }
    }


    #endregion

    } // class AzureAdBitLockerKey
    
    #endregion

    public static class ListAzureAdBitLockerKeyExtensions
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
            this List<AzureAdBitLockerKey> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdBitLockerKey> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdBitLockerKey> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdBitLockerKey());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdBitLockerKey> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types