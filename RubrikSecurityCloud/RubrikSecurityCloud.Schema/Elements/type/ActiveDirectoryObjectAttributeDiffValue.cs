// ActiveDirectoryObjectAttributeDiffValue.cs
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
    #region ActiveDirectoryObjectAttributeDiffValue
    public class ActiveDirectoryObjectAttributeDiffValue: BaseType
    {
        #region members

        //      C# -> System.String? LeftValue
        // GraphQL -> leftValue: String (scalar)
        [JsonProperty("leftValue")]
        public System.String? LeftValue { get; set; }

        //      C# -> System.String? RightValue
        // GraphQL -> rightValue: String (scalar)
        [JsonProperty("rightValue")]
        public System.String? RightValue { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActiveDirectoryObjectAttributeDiffValue";
    }

    public ActiveDirectoryObjectAttributeDiffValue Set(
        System.String? LeftValue = null,
        System.String? RightValue = null
    ) 
    {
        if ( LeftValue != null ) {
            this.LeftValue = LeftValue;
        }
        if ( RightValue != null ) {
            this.RightValue = RightValue;
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
        //      C# -> System.String? LeftValue
        // GraphQL -> leftValue: String (scalar)
        if (this.LeftValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "leftValue\n" ;
            } else {
                s += ind + "leftValue\n" ;
            }
        }
        //      C# -> System.String? RightValue
        // GraphQL -> rightValue: String (scalar)
        if (this.RightValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rightValue\n" ;
            } else {
                s += ind + "rightValue\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? LeftValue
        // GraphQL -> leftValue: String (scalar)
        if (ec.Includes("leftValue",true))
        {
            if(this.LeftValue == null) {

                this.LeftValue = "FETCH";

            } else {


            }
        }
        else if (this.LeftValue != null && ec.Excludes("leftValue",true))
        {
            this.LeftValue = null;
        }
        //      C# -> System.String? RightValue
        // GraphQL -> rightValue: String (scalar)
        if (ec.Includes("rightValue",true))
        {
            if(this.RightValue == null) {

                this.RightValue = "FETCH";

            } else {


            }
        }
        else if (this.RightValue != null && ec.Excludes("rightValue",true))
        {
            this.RightValue = null;
        }
    }


    #endregion

    } // class ActiveDirectoryObjectAttributeDiffValue
    
    #endregion

    public static class ListActiveDirectoryObjectAttributeDiffValueExtensions
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
            this List<ActiveDirectoryObjectAttributeDiffValue> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ActiveDirectoryObjectAttributeDiffValue> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActiveDirectoryObjectAttributeDiffValue> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActiveDirectoryObjectAttributeDiffValue());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActiveDirectoryObjectAttributeDiffValue> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types