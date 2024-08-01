// SaasAppCascadeImpactKeys.cs
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
    #region SaasAppCascadeImpactKeys
    public class SaasAppCascadeImpactKeys: BaseType
    {
        #region members

        //      C# -> System.String? ItemKeys
        // GraphQL -> itemKeys: String! (scalar)
        [JsonProperty("itemKeys")]
        public System.String? ItemKeys { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SaasAppCascadeImpactKeys";
    }

    public SaasAppCascadeImpactKeys Set(
        System.String? ItemKeys = null
    ) 
    {
        if ( ItemKeys != null ) {
            this.ItemKeys = ItemKeys;
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
        //      C# -> System.String? ItemKeys
        // GraphQL -> itemKeys: String! (scalar)
        if (this.ItemKeys != null) {
            if (conf.Flat) {
                s += conf.Prefix + "itemKeys\n" ;
            } else {
                s += ind + "itemKeys\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ItemKeys
        // GraphQL -> itemKeys: String! (scalar)
        if (ec.Includes("itemKeys",true))
        {
            if(this.ItemKeys == null) {

                this.ItemKeys = "FETCH";

            } else {


            }
        }
        else if (this.ItemKeys != null && ec.Excludes("itemKeys",true))
        {
            this.ItemKeys = null;
        }
    }


    #endregion

    } // class SaasAppCascadeImpactKeys
    
    #endregion

    public static class ListSaasAppCascadeImpactKeysExtensions
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
            this List<SaasAppCascadeImpactKeys> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SaasAppCascadeImpactKeys> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SaasAppCascadeImpactKeys> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SaasAppCascadeImpactKeys());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SaasAppCascadeImpactKeys> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types