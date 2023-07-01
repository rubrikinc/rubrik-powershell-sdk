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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> O365SharePointDrive? SpDriveItem
        // GraphQL -> spDriveItem: O365SharePointDrive (type)
        if (this.SpDriveItem != null) {
            var fspec = this.SpDriveItem.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "spDriveItem {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> O365SharePointDrive? SpDriveItem
        // GraphQL -> spDriveItem: O365SharePointDrive (type)
        if (this.SpDriveItem == null && Exploration.Includes(parent + ".spDriveItem"))
        {
            this.SpDriveItem = new O365SharePointDrive();
            this.SpDriveItem.ApplyExploratoryFieldSpec(parent + ".spDriveItem");
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365ReplyFields> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new O365ReplyFields());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types