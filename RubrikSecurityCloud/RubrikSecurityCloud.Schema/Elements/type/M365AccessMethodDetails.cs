// M365AccessMethodDetails.cs
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
    #region M365AccessMethodDetails
 
    public class M365AccessMethodDetails: BaseType, AccessMethodDetailsType
    {
        #region members

        //      C# -> System.String? ItemName
        // GraphQL -> itemName: String! (scalar)
        [JsonProperty("itemName")]
        public System.String? ItemName { get; set; }

        //      C# -> System.String? ItemPath
        // GraphQL -> itemPath: String! (scalar)
        [JsonProperty("itemPath")]
        public System.String? ItemPath { get; set; }

        //      C# -> System.String? SharingLink
        // GraphQL -> sharingLink: String! (scalar)
        [JsonProperty("sharingLink")]
        public System.String? SharingLink { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "M365AccessMethodDetails";
    }

    public M365AccessMethodDetails Set(
        System.String? ItemName = null,
        System.String? ItemPath = null,
        System.String? SharingLink = null
    ) 
    {
        if ( ItemName != null ) {
            this.ItemName = ItemName;
        }
        if ( ItemPath != null ) {
            this.ItemPath = ItemPath;
        }
        if ( SharingLink != null ) {
            this.SharingLink = SharingLink;
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
        //      C# -> System.String? ItemName
        // GraphQL -> itemName: String! (scalar)
        if (this.ItemName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "itemName\n" ;
            } else {
                s += ind + "itemName\n" ;
            }
        }
        //      C# -> System.String? ItemPath
        // GraphQL -> itemPath: String! (scalar)
        if (this.ItemPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "itemPath\n" ;
            } else {
                s += ind + "itemPath\n" ;
            }
        }
        //      C# -> System.String? SharingLink
        // GraphQL -> sharingLink: String! (scalar)
        if (this.SharingLink != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sharingLink\n" ;
            } else {
                s += ind + "sharingLink\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
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
        //      C# -> System.String? ItemPath
        // GraphQL -> itemPath: String! (scalar)
        if (ec.Includes("itemPath",true))
        {
            if(this.ItemPath == null) {

                this.ItemPath = "FETCH";

            } else {


            }
        }
        else if (this.ItemPath != null && ec.Excludes("itemPath",true))
        {
            this.ItemPath = null;
        }
        //      C# -> System.String? SharingLink
        // GraphQL -> sharingLink: String! (scalar)
        if (ec.Includes("sharingLink",true))
        {
            if(this.SharingLink == null) {

                this.SharingLink = "FETCH";

            } else {


            }
        }
        else if (this.SharingLink != null && ec.Excludes("sharingLink",true))
        {
            this.SharingLink = null;
        }
    }


    #endregion

    } // class M365AccessMethodDetails
    
    #endregion

    public static class ListM365AccessMethodDetailsExtensions
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
            this List<M365AccessMethodDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<M365AccessMethodDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<M365AccessMethodDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new M365AccessMethodDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<M365AccessMethodDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types