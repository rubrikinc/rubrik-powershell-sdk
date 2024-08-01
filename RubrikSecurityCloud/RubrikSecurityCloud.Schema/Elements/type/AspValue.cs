// AspValue.cs
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
    #region AspValue
    public class AspValue: BaseType
    {
        #region members

        //      C# -> System.String? Value
        // GraphQL -> value: String! (scalar)
        [JsonProperty("value")]
        public System.String? Value { get; set; }

        //      C# -> AspKey? Key
        // GraphQL -> key: ASPKey (type)
        [JsonProperty("key")]
        public AspKey? Key { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ASPValue";
    }

    public AspValue Set(
        System.String? Value = null,
        AspKey? Key = null
    ) 
    {
        if ( Value != null ) {
            this.Value = Value;
        }
        if ( Key != null ) {
            this.Key = Key;
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
        //      C# -> System.String? Value
        // GraphQL -> value: String! (scalar)
        if (this.Value != null) {
            if (conf.Flat) {
                s += conf.Prefix + "value\n" ;
            } else {
                s += ind + "value\n" ;
            }
        }
        //      C# -> AspKey? Key
        // GraphQL -> key: ASPKey (type)
        if (this.Key != null) {
            var fspec = this.Key.AsFieldSpec(conf.Child("key"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "key" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Value
        // GraphQL -> value: String! (scalar)
        if (ec.Includes("value",true))
        {
            if(this.Value == null) {

                this.Value = "FETCH";

            } else {


            }
        }
        else if (this.Value != null && ec.Excludes("value",true))
        {
            this.Value = null;
        }
        //      C# -> AspKey? Key
        // GraphQL -> key: ASPKey (type)
        if (ec.Includes("key",false))
        {
            if(this.Key == null) {

                this.Key = new AspKey();
                this.Key.ApplyExploratoryFieldSpec(ec.NewChild("key"));

            } else {

                this.Key.ApplyExploratoryFieldSpec(ec.NewChild("key"));

            }
        }
        else if (this.Key != null && ec.Excludes("key",false))
        {
            this.Key = null;
        }
    }


    #endregion

    } // class AspValue
    
    #endregion

    public static class ListAspValueExtensions
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
            this List<AspValue> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AspValue> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AspValue> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AspValue());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AspValue> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types