// OpenstackCephSetting.cs
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
    #region OpenstackCephSetting
    public class OpenstackCephSetting: BaseType
    {
        #region members

        //      C# -> System.String? Fsid
        // GraphQL -> fsid: String (scalar)
        [JsonProperty("fsid")]
        public System.String? Fsid { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Keyring
        // GraphQL -> keyring: String (scalar)
        [JsonProperty("keyring")]
        public System.String? Keyring { get; set; }

        //      C# -> System.String? OpenstackAvailabilityZoneId
        // GraphQL -> openstackAvailabilityZoneId: String! (scalar)
        [JsonProperty("openstackAvailabilityZoneId")]
        public System.String? OpenstackAvailabilityZoneId { get; set; }

        //      C# -> System.String? VolumePoolName
        // GraphQL -> volumePoolName: String! (scalar)
        [JsonProperty("volumePoolName")]
        public System.String? VolumePoolName { get; set; }

        //      C# -> System.String? VolumeTypeId
        // GraphQL -> volumeTypeId: String! (scalar)
        [JsonProperty("volumeTypeId")]
        public System.String? VolumeTypeId { get; set; }

        //      C# -> List<OpenstackMonHost>? MonHosts
        // GraphQL -> monHosts: [OpenstackMonHost!]! (type)
        [JsonProperty("monHosts")]
        public List<OpenstackMonHost>? MonHosts { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OpenstackCephSetting";
    }

    public OpenstackCephSetting Set(
        System.String? Fsid = null,
        System.String? Id = null,
        System.String? Keyring = null,
        System.String? OpenstackAvailabilityZoneId = null,
        System.String? VolumePoolName = null,
        System.String? VolumeTypeId = null,
        List<OpenstackMonHost>? MonHosts = null
    ) 
    {
        if ( Fsid != null ) {
            this.Fsid = Fsid;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Keyring != null ) {
            this.Keyring = Keyring;
        }
        if ( OpenstackAvailabilityZoneId != null ) {
            this.OpenstackAvailabilityZoneId = OpenstackAvailabilityZoneId;
        }
        if ( VolumePoolName != null ) {
            this.VolumePoolName = VolumePoolName;
        }
        if ( VolumeTypeId != null ) {
            this.VolumeTypeId = VolumeTypeId;
        }
        if ( MonHosts != null ) {
            this.MonHosts = MonHosts;
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
        //      C# -> System.String? Fsid
        // GraphQL -> fsid: String (scalar)
        if (this.Fsid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fsid\n" ;
            } else {
                s += ind + "fsid\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? Keyring
        // GraphQL -> keyring: String (scalar)
        if (this.Keyring != null) {
            if (conf.Flat) {
                s += conf.Prefix + "keyring\n" ;
            } else {
                s += ind + "keyring\n" ;
            }
        }
        //      C# -> System.String? OpenstackAvailabilityZoneId
        // GraphQL -> openstackAvailabilityZoneId: String! (scalar)
        if (this.OpenstackAvailabilityZoneId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "openstackAvailabilityZoneId\n" ;
            } else {
                s += ind + "openstackAvailabilityZoneId\n" ;
            }
        }
        //      C# -> System.String? VolumePoolName
        // GraphQL -> volumePoolName: String! (scalar)
        if (this.VolumePoolName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "volumePoolName\n" ;
            } else {
                s += ind + "volumePoolName\n" ;
            }
        }
        //      C# -> System.String? VolumeTypeId
        // GraphQL -> volumeTypeId: String! (scalar)
        if (this.VolumeTypeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "volumeTypeId\n" ;
            } else {
                s += ind + "volumeTypeId\n" ;
            }
        }
        //      C# -> List<OpenstackMonHost>? MonHosts
        // GraphQL -> monHosts: [OpenstackMonHost!]! (type)
        if (this.MonHosts != null) {
            var fspec = this.MonHosts.AsFieldSpec(conf.Child("monHosts"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "monHosts" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Fsid
        // GraphQL -> fsid: String (scalar)
        if (ec.Includes("fsid",true))
        {
            if(this.Fsid == null) {

                this.Fsid = "FETCH";

            } else {


            }
        }
        else if (this.Fsid != null && ec.Excludes("fsid",true))
        {
            this.Fsid = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? Keyring
        // GraphQL -> keyring: String (scalar)
        if (ec.Includes("keyring",true))
        {
            if(this.Keyring == null) {

                this.Keyring = "FETCH";

            } else {


            }
        }
        else if (this.Keyring != null && ec.Excludes("keyring",true))
        {
            this.Keyring = null;
        }
        //      C# -> System.String? OpenstackAvailabilityZoneId
        // GraphQL -> openstackAvailabilityZoneId: String! (scalar)
        if (ec.Includes("openstackAvailabilityZoneId",true))
        {
            if(this.OpenstackAvailabilityZoneId == null) {

                this.OpenstackAvailabilityZoneId = "FETCH";

            } else {


            }
        }
        else if (this.OpenstackAvailabilityZoneId != null && ec.Excludes("openstackAvailabilityZoneId",true))
        {
            this.OpenstackAvailabilityZoneId = null;
        }
        //      C# -> System.String? VolumePoolName
        // GraphQL -> volumePoolName: String! (scalar)
        if (ec.Includes("volumePoolName",true))
        {
            if(this.VolumePoolName == null) {

                this.VolumePoolName = "FETCH";

            } else {


            }
        }
        else if (this.VolumePoolName != null && ec.Excludes("volumePoolName",true))
        {
            this.VolumePoolName = null;
        }
        //      C# -> System.String? VolumeTypeId
        // GraphQL -> volumeTypeId: String! (scalar)
        if (ec.Includes("volumeTypeId",true))
        {
            if(this.VolumeTypeId == null) {

                this.VolumeTypeId = "FETCH";

            } else {


            }
        }
        else if (this.VolumeTypeId != null && ec.Excludes("volumeTypeId",true))
        {
            this.VolumeTypeId = null;
        }
        //      C# -> List<OpenstackMonHost>? MonHosts
        // GraphQL -> monHosts: [OpenstackMonHost!]! (type)
        if (ec.Includes("monHosts",false))
        {
            if(this.MonHosts == null) {

                this.MonHosts = new List<OpenstackMonHost>();
                this.MonHosts.ApplyExploratoryFieldSpec(ec.NewChild("monHosts"));

            } else {

                this.MonHosts.ApplyExploratoryFieldSpec(ec.NewChild("monHosts"));

            }
        }
        else if (this.MonHosts != null && ec.Excludes("monHosts",false))
        {
            this.MonHosts = null;
        }
    }


    #endregion

    } // class OpenstackCephSetting
    
    #endregion

    public static class ListOpenstackCephSettingExtensions
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
            this List<OpenstackCephSetting> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OpenstackCephSetting> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OpenstackCephSetting> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OpenstackCephSetting());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OpenstackCephSetting> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types