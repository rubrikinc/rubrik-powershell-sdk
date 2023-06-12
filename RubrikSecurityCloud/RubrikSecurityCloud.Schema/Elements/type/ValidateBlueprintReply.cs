// ValidateBlueprintReply.cs
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
    #region ValidateBlueprintReply
    public class ValidateBlueprintReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsValidationSucceeded
        // GraphQL -> isValidationSucceeded: Boolean! (scalar)
        [JsonProperty("isValidationSucceeded")]
        public System.Boolean? IsValidationSucceeded { get; set; }

        //      C# -> System.String? BlueprintId
        // GraphQL -> blueprintId: id (type)
        [JsonProperty("blueprintId")]
        public System.String? BlueprintId { get; set; }

        //      C# -> List<ValidationStatusInfo>? StatusInfos
        // GraphQL -> statusInfos: [ValidationStatusInfo!]! (type)
        [JsonProperty("statusInfos")]
        public List<ValidationStatusInfo>? StatusInfos { get; set; }


        #endregion

    #region methods

    public ValidateBlueprintReply Set(
        System.Boolean? IsValidationSucceeded = null,
        System.String? BlueprintId = null,
        List<ValidationStatusInfo>? StatusInfos = null
    ) 
    {
        if ( IsValidationSucceeded != null ) {
            this.IsValidationSucceeded = IsValidationSucceeded;
        }
        if ( BlueprintId != null ) {
            this.BlueprintId = BlueprintId;
        }
        if ( StatusInfos != null ) {
            this.StatusInfos = StatusInfos;
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
        //      C# -> System.Boolean? IsValidationSucceeded
        // GraphQL -> isValidationSucceeded: Boolean! (scalar)
        if (this.IsValidationSucceeded != null) {
            s += ind + "isValidationSucceeded\n" ;
        }
        //      C# -> System.String? BlueprintId
        // GraphQL -> blueprintId: id (type)
        if (this.BlueprintId != null) {
            s += ind + "blueprintId\n" ;
        }
        //      C# -> List<ValidationStatusInfo>? StatusInfos
        // GraphQL -> statusInfos: [ValidationStatusInfo!]! (type)
        if (this.StatusInfos != null) {
            var fspec = this.StatusInfos.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "statusInfos {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsValidationSucceeded
        // GraphQL -> isValidationSucceeded: Boolean! (scalar)
        if (this.IsValidationSucceeded == null && Exploration.Includes(parent + ".isValidationSucceeded", true))
        {
            this.IsValidationSucceeded = true;
        }
        //      C# -> System.String? BlueprintId
        // GraphQL -> blueprintId: id (type)
        if (this.BlueprintId == null && Exploration.Includes(parent + ".blueprintId", true))
        {
            this.BlueprintId = "FETCH";
        }
        //      C# -> List<ValidationStatusInfo>? StatusInfos
        // GraphQL -> statusInfos: [ValidationStatusInfo!]! (type)
        if (this.StatusInfos == null && Exploration.Includes(parent + ".statusInfos"))
        {
            this.StatusInfos = new List<ValidationStatusInfo>();
            this.StatusInfos.ApplyExploratoryFieldSpec(parent + ".statusInfos");
        }
    }


    #endregion

    } // class ValidateBlueprintReply
    
    #endregion

    public static class ListValidateBlueprintReplyExtensions
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
            this List<ValidateBlueprintReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ValidateBlueprintReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ValidateBlueprintReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types