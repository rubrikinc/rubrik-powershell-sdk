// FailedRestoreItemInfo.cs
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
    #region FailedRestoreItemInfo
    public class FailedRestoreItemInfo: BaseType
    {
        #region members

        //      C# -> System.String? AbsolutePath
        // GraphQL -> absolutePath: String! (scalar)
        [JsonProperty("absolutePath")]
        public System.String? AbsolutePath { get; set; }

        //      C# -> System.String? ErrorMsg
        // GraphQL -> errorMsg: String! (scalar)
        [JsonProperty("errorMsg")]
        public System.String? ErrorMsg { get; set; }

        //      C# -> System.String? ItemName
        // GraphQL -> itemName: String! (scalar)
        [JsonProperty("itemName")]
        public System.String? ItemName { get; set; }

        //      C# -> System.String? ItemType
        // GraphQL -> itemType: String! (scalar)
        [JsonProperty("itemType")]
        public System.String? ItemType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FailedRestoreItemInfo";
    }

    public FailedRestoreItemInfo Set(
        System.String? AbsolutePath = null,
        System.String? ErrorMsg = null,
        System.String? ItemName = null,
        System.String? ItemType = null
    ) 
    {
        if ( AbsolutePath != null ) {
            this.AbsolutePath = AbsolutePath;
        }
        if ( ErrorMsg != null ) {
            this.ErrorMsg = ErrorMsg;
        }
        if ( ItemName != null ) {
            this.ItemName = ItemName;
        }
        if ( ItemType != null ) {
            this.ItemType = ItemType;
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
        //      C# -> System.String? AbsolutePath
        // GraphQL -> absolutePath: String! (scalar)
        if (this.AbsolutePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "absolutePath\n" ;
            } else {
                s += ind + "absolutePath\n" ;
            }
        }
        //      C# -> System.String? ErrorMsg
        // GraphQL -> errorMsg: String! (scalar)
        if (this.ErrorMsg != null) {
            if (conf.Flat) {
                s += conf.Prefix + "errorMsg\n" ;
            } else {
                s += ind + "errorMsg\n" ;
            }
        }
        //      C# -> System.String? ItemName
        // GraphQL -> itemName: String! (scalar)
        if (this.ItemName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "itemName\n" ;
            } else {
                s += ind + "itemName\n" ;
            }
        }
        //      C# -> System.String? ItemType
        // GraphQL -> itemType: String! (scalar)
        if (this.ItemType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "itemType\n" ;
            } else {
                s += ind + "itemType\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? AbsolutePath
        // GraphQL -> absolutePath: String! (scalar)
        if (ec.Includes("absolutePath",true))
        {
            if(this.AbsolutePath == null) {

                this.AbsolutePath = "FETCH";

            } else {


            }
        }
        else if (this.AbsolutePath != null && ec.Excludes("absolutePath",true))
        {
            this.AbsolutePath = null;
        }
        //      C# -> System.String? ErrorMsg
        // GraphQL -> errorMsg: String! (scalar)
        if (ec.Includes("errorMsg",true))
        {
            if(this.ErrorMsg == null) {

                this.ErrorMsg = "FETCH";

            } else {


            }
        }
        else if (this.ErrorMsg != null && ec.Excludes("errorMsg",true))
        {
            this.ErrorMsg = null;
        }
        //      C# -> System.String? ItemName
        // GraphQL -> itemName: String! (scalar)
        if (ec.Includes("itemName",true))
        {
            if(this.ItemName == null) {

                this.ItemName = "FETCH";

            } else {


            }
        }
        else if (this.ItemName != null && ec.Excludes("itemName",true))
        {
            this.ItemName = null;
        }
        //      C# -> System.String? ItemType
        // GraphQL -> itemType: String! (scalar)
        if (ec.Includes("itemType",true))
        {
            if(this.ItemType == null) {

                this.ItemType = "FETCH";

            } else {


            }
        }
        else if (this.ItemType != null && ec.Excludes("itemType",true))
        {
            this.ItemType = null;
        }
    }


    #endregion

    } // class FailedRestoreItemInfo
    
    #endregion

    public static class ListFailedRestoreItemInfoExtensions
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
            this List<FailedRestoreItemInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FailedRestoreItemInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FailedRestoreItemInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FailedRestoreItemInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FailedRestoreItemInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types