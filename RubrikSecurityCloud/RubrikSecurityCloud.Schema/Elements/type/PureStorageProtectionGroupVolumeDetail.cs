// PureStorageProtectionGroupVolumeDetail.cs
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
    #region PureStorageProtectionGroupVolumeDetail
    public class PureStorageProtectionGroupVolumeDetail: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsExcludedFromSnapshots
        // GraphQL -> isExcludedFromSnapshots: Boolean (scalar)
        [JsonProperty("isExcludedFromSnapshots")]
        public System.Boolean? IsExcludedFromSnapshots { get; set; }

        //      C# -> System.String? ProtectionGroupId
        // GraphQL -> protectionGroupId: String (scalar)
        [JsonProperty("protectionGroupId")]
        public System.String? ProtectionGroupId { get; set; }

        //      C# -> System.String? VolumeId
        // GraphQL -> volumeId: String (scalar)
        [JsonProperty("volumeId")]
        public System.String? VolumeId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PureStorageProtectionGroupVolumeDetail";
    }

    public PureStorageProtectionGroupVolumeDetail Set(
        System.Boolean? IsExcludedFromSnapshots = null,
        System.String? ProtectionGroupId = null,
        System.String? VolumeId = null
    ) 
    {
        if ( IsExcludedFromSnapshots != null ) {
            this.IsExcludedFromSnapshots = IsExcludedFromSnapshots;
        }
        if ( ProtectionGroupId != null ) {
            this.ProtectionGroupId = ProtectionGroupId;
        }
        if ( VolumeId != null ) {
            this.VolumeId = VolumeId;
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
        //      C# -> System.Boolean? IsExcludedFromSnapshots
        // GraphQL -> isExcludedFromSnapshots: Boolean (scalar)
        if (this.IsExcludedFromSnapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isExcludedFromSnapshots\n" ;
            } else {
                s += ind + "isExcludedFromSnapshots\n" ;
            }
        }
        //      C# -> System.String? ProtectionGroupId
        // GraphQL -> protectionGroupId: String (scalar)
        if (this.ProtectionGroupId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionGroupId\n" ;
            } else {
                s += ind + "protectionGroupId\n" ;
            }
        }
        //      C# -> System.String? VolumeId
        // GraphQL -> volumeId: String (scalar)
        if (this.VolumeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "volumeId\n" ;
            } else {
                s += ind + "volumeId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? IsExcludedFromSnapshots
        // GraphQL -> isExcludedFromSnapshots: Boolean (scalar)
        if (ec.Includes("isExcludedFromSnapshots",true))
        {
            if(this.IsExcludedFromSnapshots == null) {

                this.IsExcludedFromSnapshots = true;

            } else {


            }
        }
        else if (this.IsExcludedFromSnapshots != null && ec.Excludes("isExcludedFromSnapshots",true))
        {
            this.IsExcludedFromSnapshots = null;
        }
        //      C# -> System.String? ProtectionGroupId
        // GraphQL -> protectionGroupId: String (scalar)
        if (ec.Includes("protectionGroupId",true))
        {
            if(this.ProtectionGroupId == null) {

                this.ProtectionGroupId = "FETCH";

            } else {


            }
        }
        else if (this.ProtectionGroupId != null && ec.Excludes("protectionGroupId",true))
        {
            this.ProtectionGroupId = null;
        }
        //      C# -> System.String? VolumeId
        // GraphQL -> volumeId: String (scalar)
        if (ec.Includes("volumeId",true))
        {
            if(this.VolumeId == null) {

                this.VolumeId = "FETCH";

            } else {


            }
        }
        else if (this.VolumeId != null && ec.Excludes("volumeId",true))
        {
            this.VolumeId = null;
        }
    }


    #endregion

    } // class PureStorageProtectionGroupVolumeDetail
    
    #endregion

    public static class ListPureStorageProtectionGroupVolumeDetailExtensions
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
            this List<PureStorageProtectionGroupVolumeDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PureStorageProtectionGroupVolumeDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PureStorageProtectionGroupVolumeDetail> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PureStorageProtectionGroupVolumeDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PureStorageProtectionGroupVolumeDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types