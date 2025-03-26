// Metadata.cs
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
    #region Metadata
    public class Metadata: BaseType
    {
        #region members

        //      C# -> Value? Value
        // GraphQL -> value: Value (interface)
        [JsonProperty("value")]
        public Value? Value { get; set; }

        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        [JsonProperty("key")]
        public System.String? Key { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Metadata";
    }

    public Metadata Set(
        Value? Value = null,
        System.String? Key = null
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
        //      C# -> Value? Value
        // GraphQL -> value: Value (interface)
        if (this.Value != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.Value, conf.Child("value"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "value" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (this.Key != null) {
            if (conf.Flat) {
                s += conf.Prefix + "key\n" ;
            } else {
                s += ind + "key\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> Value? Value
        // GraphQL -> value: Value (interface)
        if (ec.Includes("value",false))
        {
            if(this.Value == null) {

                var impls = new List<Value>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("value"));
                this.Value = (Value)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<Value>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("value"));
                this.Value = (Value)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.Value != null && ec.Excludes("value",false))
        {
            this.Value = null;
        }
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
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
    }


    #endregion

    } // class Metadata
    
    #endregion

    public static class ListMetadataExtensions
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
            this List<Metadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Metadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Metadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Metadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Metadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types