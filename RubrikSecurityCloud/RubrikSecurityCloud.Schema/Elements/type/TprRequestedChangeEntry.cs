// TprRequestedChangeEntry.cs
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
    #region TprRequestedChangeEntry
    public class TprRequestedChangeEntry: BaseType
    {
        #region members

        //      C# -> System.String? Attribute
        // GraphQL -> attribute: String! (scalar)
        [JsonProperty("attribute")]
        public System.String? Attribute { get; set; }

        //      C# -> System.String? NewValue
        // GraphQL -> newValue: String! (scalar)
        [JsonProperty("newValue")]
        public System.String? NewValue { get; set; }

        //      C# -> System.String? OldValue
        // GraphQL -> oldValue: String! (scalar)
        [JsonProperty("oldValue")]
        public System.String? OldValue { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TprRequestedChangeEntry";
    }

    public TprRequestedChangeEntry Set(
        System.String? Attribute = null,
        System.String? NewValue = null,
        System.String? OldValue = null
    ) 
    {
        if ( Attribute != null ) {
            this.Attribute = Attribute;
        }
        if ( NewValue != null ) {
            this.NewValue = NewValue;
        }
        if ( OldValue != null ) {
            this.OldValue = OldValue;
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
        //      C# -> System.String? Attribute
        // GraphQL -> attribute: String! (scalar)
        if (this.Attribute != null) {
            if (conf.Flat) {
                s += conf.Prefix + "attribute\n" ;
            } else {
                s += ind + "attribute\n" ;
            }
        }
        //      C# -> System.String? NewValue
        // GraphQL -> newValue: String! (scalar)
        if (this.NewValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "newValue\n" ;
            } else {
                s += ind + "newValue\n" ;
            }
        }
        //      C# -> System.String? OldValue
        // GraphQL -> oldValue: String! (scalar)
        if (this.OldValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oldValue\n" ;
            } else {
                s += ind + "oldValue\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Attribute
        // GraphQL -> attribute: String! (scalar)
        if (ec.Includes("attribute",true))
        {
            if(this.Attribute == null) {

                this.Attribute = "FETCH";

            } else {


            }
        }
        else if (this.Attribute != null && ec.Excludes("attribute",true))
        {
            this.Attribute = null;
        }
        //      C# -> System.String? NewValue
        // GraphQL -> newValue: String! (scalar)
        if (ec.Includes("newValue",true))
        {
            if(this.NewValue == null) {

                this.NewValue = "FETCH";

            } else {


            }
        }
        else if (this.NewValue != null && ec.Excludes("newValue",true))
        {
            this.NewValue = null;
        }
        //      C# -> System.String? OldValue
        // GraphQL -> oldValue: String! (scalar)
        if (ec.Includes("oldValue",true))
        {
            if(this.OldValue == null) {

                this.OldValue = "FETCH";

            } else {


            }
        }
        else if (this.OldValue != null && ec.Excludes("oldValue",true))
        {
            this.OldValue = null;
        }
    }


    #endregion

    } // class TprRequestedChangeEntry
    
    #endregion

    public static class ListTprRequestedChangeEntryExtensions
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
            this List<TprRequestedChangeEntry> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TprRequestedChangeEntry> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TprRequestedChangeEntry> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TprRequestedChangeEntry());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TprRequestedChangeEntry> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types