// TprRequestedChangeTprRuleEntry.cs
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
    #region TprRequestedChangeTprRuleEntry
    public class TprRequestedChangeTprRuleEntry: BaseType
    {
        #region members

        //      C# -> List<TprRule>? NewValue
        // GraphQL -> newValue: [TprRule!]! (enum)
        [JsonProperty("newValue")]
        public List<TprRule>? NewValue { get; set; }

        //      C# -> List<TprRule>? OldValue
        // GraphQL -> oldValue: [TprRule!]! (enum)
        [JsonProperty("oldValue")]
        public List<TprRule>? OldValue { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TprRequestedChangeTprRuleEntry";
    }

    public TprRequestedChangeTprRuleEntry Set(
        List<TprRule>? NewValue = null,
        List<TprRule>? OldValue = null
    ) 
    {
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
        //      C# -> List<TprRule>? NewValue
        // GraphQL -> newValue: [TprRule!]! (enum)
        if (this.NewValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "newValue\n" ;
            } else {
                s += ind + "newValue\n" ;
            }
        }
        //      C# -> List<TprRule>? OldValue
        // GraphQL -> oldValue: [TprRule!]! (enum)
        if (this.OldValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oldValue\n" ;
            } else {
                s += ind + "oldValue\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<TprRule>? NewValue
        // GraphQL -> newValue: [TprRule!]! (enum)
        if (ec.Includes("newValue",true))
        {
            if(this.NewValue == null) {

                this.NewValue = new List<TprRule>();

            } else {


            }
        }
        else if (this.NewValue != null && ec.Excludes("newValue",true))
        {
            this.NewValue = null;
        }
        //      C# -> List<TprRule>? OldValue
        // GraphQL -> oldValue: [TprRule!]! (enum)
        if (ec.Includes("oldValue",true))
        {
            if(this.OldValue == null) {

                this.OldValue = new List<TprRule>();

            } else {


            }
        }
        else if (this.OldValue != null && ec.Excludes("oldValue",true))
        {
            this.OldValue = null;
        }
    }


    #endregion

    } // class TprRequestedChangeTprRuleEntry
    
    #endregion

    public static class ListTprRequestedChangeTprRuleEntryExtensions
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
            this List<TprRequestedChangeTprRuleEntry> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TprRequestedChangeTprRuleEntry> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TprRequestedChangeTprRuleEntry> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TprRequestedChangeTprRuleEntry());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TprRequestedChangeTprRuleEntry> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types