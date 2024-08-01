// KmsInstance.cs
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
    #region KmsInstance
    public class KmsInstance: BaseType
    {
        #region members

        //      C# -> KmsType? KmsType
        // GraphQL -> kmsType: KmsType! (enum)
        [JsonProperty("kmsType")]
        public KmsType? KmsType { get; set; }

        //      C# -> KeyVaultInfo? KeyVaultInfo
        // GraphQL -> keyVaultInfo: KeyVaultInfo! (interface)
        [JsonProperty("keyVaultInfo")]
        public KeyVaultInfo? KeyVaultInfo { get; set; }

        //      C# -> System.Int32? DataLocationsCount
        // GraphQL -> dataLocationsCount: Int! (scalar)
        [JsonProperty("dataLocationsCount")]
        public System.Int32? DataLocationsCount { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String! (scalar)
        [JsonProperty("naturalId")]
        public System.String? NaturalId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "KmsInstance";
    }

    public KmsInstance Set(
        KmsType? KmsType = null,
        KeyVaultInfo? KeyVaultInfo = null,
        System.Int32? DataLocationsCount = null,
        System.String? Description = null,
        System.String? Name = null,
        System.String? NaturalId = null
    ) 
    {
        if ( KmsType != null ) {
            this.KmsType = KmsType;
        }
        if ( KeyVaultInfo != null ) {
            this.KeyVaultInfo = KeyVaultInfo;
        }
        if ( DataLocationsCount != null ) {
            this.DataLocationsCount = DataLocationsCount;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NaturalId != null ) {
            this.NaturalId = NaturalId;
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
        //      C# -> KmsType? KmsType
        // GraphQL -> kmsType: KmsType! (enum)
        if (this.KmsType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kmsType\n" ;
            } else {
                s += ind + "kmsType\n" ;
            }
        }
        //      C# -> KeyVaultInfo? KeyVaultInfo
        // GraphQL -> keyVaultInfo: KeyVaultInfo! (interface)
        if (this.KeyVaultInfo != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.KeyVaultInfo, conf.Child("keyVaultInfo"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "keyVaultInfo" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.Int32? DataLocationsCount
        // GraphQL -> dataLocationsCount: Int! (scalar)
        if (this.DataLocationsCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataLocationsCount\n" ;
            } else {
                s += ind + "dataLocationsCount\n" ;
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String! (scalar)
        if (this.NaturalId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "naturalId\n" ;
            } else {
                s += ind + "naturalId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> KmsType? KmsType
        // GraphQL -> kmsType: KmsType! (enum)
        if (ec.Includes("kmsType",true))
        {
            if(this.KmsType == null) {

                this.KmsType = new KmsType();

            } else {


            }
        }
        else if (this.KmsType != null && ec.Excludes("kmsType",true))
        {
            this.KmsType = null;
        }
        //      C# -> KeyVaultInfo? KeyVaultInfo
        // GraphQL -> keyVaultInfo: KeyVaultInfo! (interface)
        if (ec.Includes("keyVaultInfo",false))
        {
            if(this.KeyVaultInfo == null) {

                var impls = new List<KeyVaultInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("keyVaultInfo"));
                this.KeyVaultInfo = (KeyVaultInfo)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<KeyVaultInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("keyVaultInfo"));
                this.KeyVaultInfo = (KeyVaultInfo)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.KeyVaultInfo != null && ec.Excludes("keyVaultInfo",false))
        {
            this.KeyVaultInfo = null;
        }
        //      C# -> System.Int32? DataLocationsCount
        // GraphQL -> dataLocationsCount: Int! (scalar)
        if (ec.Includes("dataLocationsCount",true))
        {
            if(this.DataLocationsCount == null) {

                this.DataLocationsCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.DataLocationsCount != null && ec.Excludes("dataLocationsCount",true))
        {
            this.DataLocationsCount = null;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String! (scalar)
        if (ec.Includes("naturalId",true))
        {
            if(this.NaturalId == null) {

                this.NaturalId = "FETCH";

            } else {


            }
        }
        else if (this.NaturalId != null && ec.Excludes("naturalId",true))
        {
            this.NaturalId = null;
        }
    }


    #endregion

    } // class KmsInstance
    
    #endregion

    public static class ListKmsInstanceExtensions
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
            this List<KmsInstance> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<KmsInstance> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<KmsInstance> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new KmsInstance());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<KmsInstance> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types