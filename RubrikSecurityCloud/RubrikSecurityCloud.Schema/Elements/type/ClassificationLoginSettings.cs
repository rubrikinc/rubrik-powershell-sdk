// ClassificationLoginSettings.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region ClassificationLoginSettings
    public class ClassificationLoginSettings: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsLoginEnabled
        // GraphQL -> isLoginEnabled: Boolean! (scalar)
        [JsonProperty("isLoginEnabled")]
        public System.Boolean? IsLoginEnabled { get; set; }

        //      C# -> System.String? LoginText
        // GraphQL -> loginText: String! (scalar)
        [JsonProperty("loginText")]
        public System.String? LoginText { get; set; }


        #endregion

    #region methods

    public ClassificationLoginSettings Set(
        System.Boolean? IsLoginEnabled = null,
        System.String? LoginText = null
    ) 
    {
        if ( IsLoginEnabled != null ) {
            this.IsLoginEnabled = IsLoginEnabled;
        }
        if ( LoginText != null ) {
            this.LoginText = LoginText;
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
        //      C# -> System.Boolean? IsLoginEnabled
        // GraphQL -> isLoginEnabled: Boolean! (scalar)
        if (this.IsLoginEnabled != null) {
            s += ind + "isLoginEnabled\n" ;
        }
        //      C# -> System.String? LoginText
        // GraphQL -> loginText: String! (scalar)
        if (this.LoginText != null) {
            s += ind + "loginText\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsLoginEnabled
        // GraphQL -> isLoginEnabled: Boolean! (scalar)
        if (this.IsLoginEnabled == null && Exploration.Includes(parent + ".isLoginEnabled", true))
        {
            this.IsLoginEnabled = true;
        }
        //      C# -> System.String? LoginText
        // GraphQL -> loginText: String! (scalar)
        if (this.LoginText == null && Exploration.Includes(parent + ".loginText", true))
        {
            this.LoginText = "FETCH";
        }
    }


    #endregion

    } // class ClassificationLoginSettings
    
    #endregion

    public static class ListClassificationLoginSettingsExtensions
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
            this List<ClassificationLoginSettings> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClassificationLoginSettings> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClassificationLoginSettings());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types