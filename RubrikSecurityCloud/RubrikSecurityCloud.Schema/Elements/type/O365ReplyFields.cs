// O365ReplyFields.cs
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
    #region O365ReplyFields
    public class O365ReplyFields: BaseType
    {
        #region members

        //      C# -> O365SharePointDrive? SpDriveItem
        // GraphQL -> spDriveItem: O365SharePointDrive (type)
        [JsonProperty("spDriveItem")]
        public O365SharePointDrive? SpDriveItem { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365ReplyFields";
    }

    public O365ReplyFields Set(
        O365SharePointDrive? SpDriveItem = null
    ) 
    {
        if ( SpDriveItem != null ) {
            this.SpDriveItem = SpDriveItem;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> O365SharePointDrive? SpDriveItem
        // GraphQL -> spDriveItem: O365SharePointDrive (type)
        if (this.SpDriveItem != null) {
            var fspec = this.SpDriveItem.AsFieldSpec(conf.Child("spDriveItem"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "spDriveItem {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> O365SharePointDrive? SpDriveItem
        // GraphQL -> spDriveItem: O365SharePointDrive (type)
        if (ec.Includes("spDriveItem",false))
        {
            if(this.SpDriveItem == null) {

                this.SpDriveItem = new O365SharePointDrive();
                this.SpDriveItem.ApplyExploratoryFieldSpec(ec.NewChild("spDriveItem"));

            } else {

                this.SpDriveItem.ApplyExploratoryFieldSpec(ec.NewChild("spDriveItem"));

            }
        }
        else if (this.SpDriveItem != null && ec.Excludes("spDriveItem",false))
        {
            this.SpDriveItem = null;
        }
    }


    #endregion

    } // class O365ReplyFields
    
    #endregion

    public static class ListO365ReplyFieldsExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<O365ReplyFields> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365ReplyFields> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365ReplyFields());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365ReplyFields> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types