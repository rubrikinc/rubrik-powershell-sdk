// WindowsPartitionInfo.cs
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
    #region WindowsPartitionInfo
    public class WindowsPartitionInfo: BaseType
    {
        #region members

        //      C# -> System.Int64? Length
        // GraphQL -> length: Long (scalar)
        [JsonProperty("length")]
        public System.Int64? Length { get; set; }

        //      C# -> System.Int32? Number
        // GraphQL -> number: Int (scalar)
        [JsonProperty("number")]
        public System.Int32? Number { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WindowsPartitionInfo";
    }

    public WindowsPartitionInfo Set(
        System.Int64? Length = null,
        System.Int32? Number = null
    ) 
    {
        if ( Length != null ) {
            this.Length = Length;
        }
        if ( Number != null ) {
            this.Number = Number;
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
        //      C# -> System.Int64? Length
        // GraphQL -> length: Long (scalar)
        if (this.Length != null) {
            if (conf.Flat) {
                s += conf.Prefix + "length\n" ;
            } else {
                s += ind + "length\n" ;
            }
        }
        //      C# -> System.Int32? Number
        // GraphQL -> number: Int (scalar)
        if (this.Number != null) {
            if (conf.Flat) {
                s += conf.Prefix + "number\n" ;
            } else {
                s += ind + "number\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? Length
        // GraphQL -> length: Long (scalar)
        if (ec.Includes("length",true))
        {
            if(this.Length == null) {

                this.Length = new System.Int64();

            } else {


            }
        }
        else if (this.Length != null && ec.Excludes("length",true))
        {
            this.Length = null;
        }
        //      C# -> System.Int32? Number
        // GraphQL -> number: Int (scalar)
        if (ec.Includes("number",true))
        {
            if(this.Number == null) {

                this.Number = Int32.MinValue;

            } else {


            }
        }
        else if (this.Number != null && ec.Excludes("number",true))
        {
            this.Number = null;
        }
    }


    #endregion

    } // class WindowsPartitionInfo
    
    #endregion

    public static class ListWindowsPartitionInfoExtensions
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
            this List<WindowsPartitionInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<WindowsPartitionInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<WindowsPartitionInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WindowsPartitionInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<WindowsPartitionInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types