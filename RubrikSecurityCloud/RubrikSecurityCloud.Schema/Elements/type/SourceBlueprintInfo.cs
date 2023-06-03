// SourceBlueprintInfo.cs
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
    #region SourceBlueprintInfo
    public class SourceBlueprintInfo: BaseType
    {
        #region members

        //      C# -> System.String? BlueprintId
        // GraphQL -> blueprintId: String! (scalar)
        [JsonProperty("blueprintId")]
        public System.String? BlueprintId { get; set; }

        //      C# -> List<SourceChildInfo>? SourceChildInfos
        // GraphQL -> sourceChildInfos: [SourceChildInfo!]! (type)
        [JsonProperty("sourceChildInfos")]
        public List<SourceChildInfo>? SourceChildInfos { get; set; }


        #endregion

    #region methods

    public SourceBlueprintInfo Set(
        System.String? BlueprintId = null,
        List<SourceChildInfo>? SourceChildInfos = null
    ) 
    {
        if ( BlueprintId != null ) {
            this.BlueprintId = BlueprintId;
        }
        if ( SourceChildInfos != null ) {
            this.SourceChildInfos = SourceChildInfos;
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
        //      C# -> System.String? BlueprintId
        // GraphQL -> blueprintId: String! (scalar)
        if (this.BlueprintId != null) {
            s += ind + "blueprintId\n" ;
        }
        //      C# -> List<SourceChildInfo>? SourceChildInfos
        // GraphQL -> sourceChildInfos: [SourceChildInfo!]! (type)
        if (this.SourceChildInfos != null) {
            s += ind + "sourceChildInfos {\n" + this.SourceChildInfos.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? BlueprintId
        // GraphQL -> blueprintId: String! (scalar)
        if (this.BlueprintId == null && Exploration.Includes(parent + ".blueprintId", true))
        {
            this.BlueprintId = new System.String("FETCH");
        }
        //      C# -> List<SourceChildInfo>? SourceChildInfos
        // GraphQL -> sourceChildInfos: [SourceChildInfo!]! (type)
        if (this.SourceChildInfos == null && Exploration.Includes(parent + ".sourceChildInfos"))
        {
            this.SourceChildInfos = new List<SourceChildInfo>();
            this.SourceChildInfos.ApplyExploratoryFieldSpec(parent + ".sourceChildInfos");
        }
    }


    #endregion

    } // class SourceBlueprintInfo
    
    #endregion

    public static class ListSourceBlueprintInfoExtensions
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
            this List<SourceBlueprintInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SourceBlueprintInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SourceBlueprintInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types