// CloudNativeLabel.cs
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
    #region CloudNativeLabel
    public class CloudNativeLabel: BaseType
    {
        #region members

        //      C# -> System.String? LabelKey
        // GraphQL -> labelKey: String! (scalar)
        [JsonProperty("labelKey")]
        public System.String? LabelKey { get; set; }

        //      C# -> System.String? LabelValue
        // GraphQL -> labelValue: String! (scalar)
        [JsonProperty("labelValue")]
        public System.String? LabelValue { get; set; }

        //      C# -> System.Boolean? MatchAllValues
        // GraphQL -> matchAllValues: Boolean! (scalar)
        [JsonProperty("matchAllValues")]
        public System.Boolean? MatchAllValues { get; set; }


        #endregion

    #region methods

    public CloudNativeLabel Set(
        System.String? LabelKey = null,
        System.String? LabelValue = null,
        System.Boolean? MatchAllValues = null
    ) 
    {
        if ( LabelKey != null ) {
            this.LabelKey = LabelKey;
        }
        if ( LabelValue != null ) {
            this.LabelValue = LabelValue;
        }
        if ( MatchAllValues != null ) {
            this.MatchAllValues = MatchAllValues;
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
        //      C# -> System.String? LabelKey
        // GraphQL -> labelKey: String! (scalar)
        if (this.LabelKey != null) {
            s += ind + "labelKey\n" ;
        }
        //      C# -> System.String? LabelValue
        // GraphQL -> labelValue: String! (scalar)
        if (this.LabelValue != null) {
            s += ind + "labelValue\n" ;
        }
        //      C# -> System.Boolean? MatchAllValues
        // GraphQL -> matchAllValues: Boolean! (scalar)
        if (this.MatchAllValues != null) {
            s += ind + "matchAllValues\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? LabelKey
        // GraphQL -> labelKey: String! (scalar)
        if (this.LabelKey == null && Exploration.Includes(parent + ".labelKey", true))
        {
            this.LabelKey = "FETCH";
        }
        //      C# -> System.String? LabelValue
        // GraphQL -> labelValue: String! (scalar)
        if (this.LabelValue == null && Exploration.Includes(parent + ".labelValue", true))
        {
            this.LabelValue = "FETCH";
        }
        //      C# -> System.Boolean? MatchAllValues
        // GraphQL -> matchAllValues: Boolean! (scalar)
        if (this.MatchAllValues == null && Exploration.Includes(parent + ".matchAllValues", true))
        {
            this.MatchAllValues = true;
        }
    }


    #endregion

    } // class CloudNativeLabel
    
    #endregion

    public static class ListCloudNativeLabelExtensions
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
            this List<CloudNativeLabel> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeLabel> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeLabel());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types