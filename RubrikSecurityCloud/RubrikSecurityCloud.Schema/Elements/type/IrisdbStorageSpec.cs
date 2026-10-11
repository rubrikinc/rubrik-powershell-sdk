// IrisdbStorageSpec.cs
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
    #region IrisdbStorageSpec
    public class IrisdbStorageSpec: BaseType
    {
        #region members

        //      C# -> List<System.String>? MountPaths
        // GraphQL -> mountPaths: [String!]! (scalar)
        [JsonProperty("mountPaths")]
        public List<System.String>? MountPaths { get; set; }

        //      C# -> List<System.String>? ProtectionGroupIds
        // GraphQL -> protectionGroupIds: [String!]! (scalar)
        [JsonProperty("protectionGroupIds")]
        public List<System.String>? ProtectionGroupIds { get; set; }

        //      C# -> System.String? StorageId
        // GraphQL -> storageId: String! (scalar)
        [JsonProperty("storageId")]
        public System.String? StorageId { get; set; }

        //      C# -> List<IrisdbVolume>? Volumes
        // GraphQL -> volumes: [IrisdbVolume!]! (type)
        [JsonProperty("volumes")]
        public List<IrisdbVolume>? Volumes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IrisdbStorageSpec";
    }

    public IrisdbStorageSpec Set(
        List<System.String>? MountPaths = null,
        List<System.String>? ProtectionGroupIds = null,
        System.String? StorageId = null,
        List<IrisdbVolume>? Volumes = null
    ) 
    {
        if ( MountPaths != null ) {
            this.MountPaths = MountPaths;
        }
        if ( ProtectionGroupIds != null ) {
            this.ProtectionGroupIds = ProtectionGroupIds;
        }
        if ( StorageId != null ) {
            this.StorageId = StorageId;
        }
        if ( Volumes != null ) {
            this.Volumes = Volumes;
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
        //      C# -> List<System.String>? MountPaths
        // GraphQL -> mountPaths: [String!]! (scalar)
        if (this.MountPaths != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountPaths\n" ;
            } else {
                s += ind + "mountPaths\n" ;
            }
        }
        //      C# -> List<System.String>? ProtectionGroupIds
        // GraphQL -> protectionGroupIds: [String!]! (scalar)
        if (this.ProtectionGroupIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionGroupIds\n" ;
            } else {
                s += ind + "protectionGroupIds\n" ;
            }
        }
        //      C# -> System.String? StorageId
        // GraphQL -> storageId: String! (scalar)
        if (this.StorageId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageId\n" ;
            } else {
                s += ind + "storageId\n" ;
            }
        }
        //      C# -> List<IrisdbVolume>? Volumes
        // GraphQL -> volumes: [IrisdbVolume!]! (type)
        if (this.Volumes != null) {
            var fspec = this.Volumes.AsFieldSpec(conf.Child("volumes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "volumes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<System.String>? MountPaths
        // GraphQL -> mountPaths: [String!]! (scalar)
        if (ec.Includes("mountPaths",true))
        {
            if(this.MountPaths == null) {

                this.MountPaths = new List<System.String>();

            } else {


            }
        }
        else if (this.MountPaths != null && ec.Excludes("mountPaths",true))
        {
            this.MountPaths = null;
        }
        //      C# -> List<System.String>? ProtectionGroupIds
        // GraphQL -> protectionGroupIds: [String!]! (scalar)
        if (ec.Includes("protectionGroupIds",true))
        {
            if(this.ProtectionGroupIds == null) {

                this.ProtectionGroupIds = new List<System.String>();

            } else {


            }
        }
        else if (this.ProtectionGroupIds != null && ec.Excludes("protectionGroupIds",true))
        {
            this.ProtectionGroupIds = null;
        }
        //      C# -> System.String? StorageId
        // GraphQL -> storageId: String! (scalar)
        if (ec.Includes("storageId",true))
        {
            if(this.StorageId == null) {

                this.StorageId = "FETCH";

            } else {


            }
        }
        else if (this.StorageId != null && ec.Excludes("storageId",true))
        {
            this.StorageId = null;
        }
        //      C# -> List<IrisdbVolume>? Volumes
        // GraphQL -> volumes: [IrisdbVolume!]! (type)
        if (ec.Includes("volumes",false))
        {
            if(this.Volumes == null) {

                this.Volumes = new List<IrisdbVolume>();
                this.Volumes.ApplyExploratoryFieldSpec(ec.NewChild("volumes"));

            } else {

                this.Volumes.ApplyExploratoryFieldSpec(ec.NewChild("volumes"));

            }
        }
        else if (this.Volumes != null && ec.Excludes("volumes",false))
        {
            this.Volumes = null;
        }
    }


    #endregion

    } // class IrisdbStorageSpec
    
    #endregion

    public static class ListIrisdbStorageSpecExtensions
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
            this List<IrisdbStorageSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IrisdbStorageSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IrisdbStorageSpec> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IrisdbStorageSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IrisdbStorageSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types