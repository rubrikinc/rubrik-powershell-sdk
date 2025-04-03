// ArchivalStorageUsage.cs
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
    #region ArchivalStorageUsage
    public class ArchivalStorageUsage: BaseType
    {
        #region members

        //      C# -> DateTime? LogTimestamp
        // GraphQL -> logTimestamp: DateTime! (scalar)
        [JsonProperty("logTimestamp")]
        public DateTime? LogTimestamp { get; set; }

        //      C# -> System.Int64? StorageUsage
        // GraphQL -> storageUsage: Long! (scalar)
        [JsonProperty("storageUsage")]
        public System.Int64? StorageUsage { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ArchivalStorageUsage";
    }

    public ArchivalStorageUsage Set(
        DateTime? LogTimestamp = null,
        System.Int64? StorageUsage = null
    ) 
    {
        if ( LogTimestamp != null ) {
            this.LogTimestamp = LogTimestamp;
        }
        if ( StorageUsage != null ) {
            this.StorageUsage = StorageUsage;
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
        //      C# -> DateTime? LogTimestamp
        // GraphQL -> logTimestamp: DateTime! (scalar)
        if (this.LogTimestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logTimestamp\n" ;
            } else {
                s += ind + "logTimestamp\n" ;
            }
        }
        //      C# -> System.Int64? StorageUsage
        // GraphQL -> storageUsage: Long! (scalar)
        if (this.StorageUsage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageUsage\n" ;
            } else {
                s += ind + "storageUsage\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DateTime? LogTimestamp
        // GraphQL -> logTimestamp: DateTime! (scalar)
        if (ec.Includes("logTimestamp",true))
        {
            if(this.LogTimestamp == null) {

                this.LogTimestamp = new DateTime();

            } else {


            }
        }
        else if (this.LogTimestamp != null && ec.Excludes("logTimestamp",true))
        {
            this.LogTimestamp = null;
        }
        //      C# -> System.Int64? StorageUsage
        // GraphQL -> storageUsage: Long! (scalar)
        if (ec.Includes("storageUsage",true))
        {
            if(this.StorageUsage == null) {

                this.StorageUsage = new System.Int64();

            } else {


            }
        }
        else if (this.StorageUsage != null && ec.Excludes("storageUsage",true))
        {
            this.StorageUsage = null;
        }
    }


    #endregion

    } // class ArchivalStorageUsage
    
    #endregion

    public static class ListArchivalStorageUsageExtensions
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
            this List<ArchivalStorageUsage> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ArchivalStorageUsage> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ArchivalStorageUsage> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchivalStorageUsage());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ArchivalStorageUsage> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types