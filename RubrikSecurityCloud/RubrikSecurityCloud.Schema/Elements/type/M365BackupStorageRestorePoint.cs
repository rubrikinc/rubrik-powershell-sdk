// M365BackupStorageRestorePoint.cs
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
    #region M365BackupStorageRestorePoint
    public class M365BackupStorageRestorePoint: BaseType
    {
        #region members

        //      C# -> RestorePointTagType? Type
        // GraphQL -> type: RestorePointTagType! (enum)
        [JsonProperty("type")]
        public RestorePointTagType? Type { get; set; }

        //      C# -> DateTime? ExpirationDateTime
        // GraphQL -> expirationDateTime: DateTime (scalar)
        [JsonProperty("expirationDateTime")]
        public DateTime? ExpirationDateTime { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> DateTime? ProtectionDateTime
        // GraphQL -> protectionDateTime: DateTime (scalar)
        [JsonProperty("protectionDateTime")]
        public DateTime? ProtectionDateTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "M365BackupStorageRestorePoint";
    }

    public M365BackupStorageRestorePoint Set(
        RestorePointTagType? Type = null,
        DateTime? ExpirationDateTime = null,
        System.String? Id = null,
        DateTime? ProtectionDateTime = null
    ) 
    {
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( ExpirationDateTime != null ) {
            this.ExpirationDateTime = ExpirationDateTime;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( ProtectionDateTime != null ) {
            this.ProtectionDateTime = ProtectionDateTime;
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
        //      C# -> RestorePointTagType? Type
        // GraphQL -> type: RestorePointTagType! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> DateTime? ExpirationDateTime
        // GraphQL -> expirationDateTime: DateTime (scalar)
        if (this.ExpirationDateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expirationDateTime\n" ;
            } else {
                s += ind + "expirationDateTime\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> DateTime? ProtectionDateTime
        // GraphQL -> protectionDateTime: DateTime (scalar)
        if (this.ProtectionDateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDateTime\n" ;
            } else {
                s += ind + "protectionDateTime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RestorePointTagType? Type
        // GraphQL -> type: RestorePointTagType! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new RestorePointTagType();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
        //      C# -> DateTime? ExpirationDateTime
        // GraphQL -> expirationDateTime: DateTime (scalar)
        if (ec.Includes("expirationDateTime",true))
        {
            if(this.ExpirationDateTime == null) {

                this.ExpirationDateTime = new DateTime();

            } else {


            }
        }
        else if (this.ExpirationDateTime != null && ec.Excludes("expirationDateTime",true))
        {
            this.ExpirationDateTime = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
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
        //      C# -> DateTime? ProtectionDateTime
        // GraphQL -> protectionDateTime: DateTime (scalar)
        if (ec.Includes("protectionDateTime",true))
        {
            if(this.ProtectionDateTime == null) {

                this.ProtectionDateTime = new DateTime();

            } else {


            }
        }
        else if (this.ProtectionDateTime != null && ec.Excludes("protectionDateTime",true))
        {
            this.ProtectionDateTime = null;
        }
    }


    #endregion

    } // class M365BackupStorageRestorePoint
    
    #endregion

    public static class ListM365BackupStorageRestorePointExtensions
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
            this List<M365BackupStorageRestorePoint> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<M365BackupStorageRestorePoint> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<M365BackupStorageRestorePoint> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new M365BackupStorageRestorePoint());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<M365BackupStorageRestorePoint> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types