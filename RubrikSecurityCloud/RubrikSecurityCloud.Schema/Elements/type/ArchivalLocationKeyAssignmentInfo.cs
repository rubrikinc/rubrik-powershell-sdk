// ArchivalLocationKeyAssignmentInfo.cs
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
    #region ArchivalLocationKeyAssignmentInfo
    public class ArchivalLocationKeyAssignmentInfo: BaseType
    {
        #region members

        //      C# -> ArchivalLocationEncryptionKeyType? KeyType
        // GraphQL -> keyType: ArchivalLocationEncryptionKeyType! (enum)
        [JsonProperty("keyType")]
        public ArchivalLocationEncryptionKeyType? KeyType { get; set; }

        //      C# -> ArchivalLocationKeyVaultAssignmentInfo? KeyVaultAssignmentInfo
        // GraphQL -> keyVaultAssignmentInfo: ArchivalLocationKeyVaultAssignmentInfo (interface)
        [JsonProperty("keyVaultAssignmentInfo")]
        public ArchivalLocationKeyVaultAssignmentInfo? KeyVaultAssignmentInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ArchivalLocationKeyAssignmentInfo";
    }

    public ArchivalLocationKeyAssignmentInfo Set(
        ArchivalLocationEncryptionKeyType? KeyType = null,
        ArchivalLocationKeyVaultAssignmentInfo? KeyVaultAssignmentInfo = null
    ) 
    {
        if ( KeyType != null ) {
            this.KeyType = KeyType;
        }
        if ( KeyVaultAssignmentInfo != null ) {
            this.KeyVaultAssignmentInfo = KeyVaultAssignmentInfo;
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
        //      C# -> ArchivalLocationEncryptionKeyType? KeyType
        // GraphQL -> keyType: ArchivalLocationEncryptionKeyType! (enum)
        if (this.KeyType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "keyType\n" ;
            } else {
                s += ind + "keyType\n" ;
            }
        }
        //      C# -> ArchivalLocationKeyVaultAssignmentInfo? KeyVaultAssignmentInfo
        // GraphQL -> keyVaultAssignmentInfo: ArchivalLocationKeyVaultAssignmentInfo (interface)
        if (this.KeyVaultAssignmentInfo != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.KeyVaultAssignmentInfo, conf.Child("keyVaultAssignmentInfo"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "keyVaultAssignmentInfo" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ArchivalLocationEncryptionKeyType? KeyType
        // GraphQL -> keyType: ArchivalLocationEncryptionKeyType! (enum)
        if (ec.Includes("keyType",true))
        {
            if(this.KeyType == null) {

                this.KeyType = new ArchivalLocationEncryptionKeyType();

            } else {


            }
        }
        else if (this.KeyType != null && ec.Excludes("keyType",true))
        {
            this.KeyType = null;
        }
        //      C# -> ArchivalLocationKeyVaultAssignmentInfo? KeyVaultAssignmentInfo
        // GraphQL -> keyVaultAssignmentInfo: ArchivalLocationKeyVaultAssignmentInfo (interface)
        if (ec.Includes("keyVaultAssignmentInfo",false))
        {
            if(this.KeyVaultAssignmentInfo == null) {

                var impls = new List<ArchivalLocationKeyVaultAssignmentInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("keyVaultAssignmentInfo"));
                this.KeyVaultAssignmentInfo = (ArchivalLocationKeyVaultAssignmentInfo)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<ArchivalLocationKeyVaultAssignmentInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("keyVaultAssignmentInfo"));
                this.KeyVaultAssignmentInfo = (ArchivalLocationKeyVaultAssignmentInfo)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.KeyVaultAssignmentInfo != null && ec.Excludes("keyVaultAssignmentInfo",false))
        {
            this.KeyVaultAssignmentInfo = null;
        }
    }


    #endregion

    } // class ArchivalLocationKeyAssignmentInfo
    
    #endregion

    public static class ListArchivalLocationKeyAssignmentInfoExtensions
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
            this List<ArchivalLocationKeyAssignmentInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ArchivalLocationKeyAssignmentInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ArchivalLocationKeyAssignmentInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchivalLocationKeyAssignmentInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ArchivalLocationKeyAssignmentInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types