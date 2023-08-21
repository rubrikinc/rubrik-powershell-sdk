// NasMigrationFilesetDetail.cs
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
    #region NasMigrationFilesetDetail
    public class NasMigrationFilesetDetail: BaseType
    {
        #region members

        //      C# -> System.String? FilesetName
        // GraphQL -> filesetName: String! (scalar)
        [JsonProperty("filesetName")]
        public System.String? FilesetName { get; set; }

        //      C# -> System.String? NewExceptionRule
        // GraphQL -> newExceptionRule: String! (scalar)
        [JsonProperty("newExceptionRule")]
        public System.String? NewExceptionRule { get; set; }

        //      C# -> System.String? NewExcludeRules
        // GraphQL -> newExcludeRules: String! (scalar)
        [JsonProperty("newExcludeRules")]
        public System.String? NewExcludeRules { get; set; }

        //      C# -> System.String? NewFilesetTemplateFid
        // GraphQL -> newFilesetTemplateFid: String! (scalar)
        [JsonProperty("newFilesetTemplateFid")]
        public System.String? NewFilesetTemplateFid { get; set; }

        //      C# -> System.String? NewIncludeRules
        // GraphQL -> newIncludeRules: String! (scalar)
        [JsonProperty("newIncludeRules")]
        public System.String? NewIncludeRules { get; set; }

        //      C# -> System.String? OldFilesetTemplateCdmId
        // GraphQL -> oldFilesetTemplateCdmId: String! (scalar)
        [JsonProperty("oldFilesetTemplateCdmId")]
        public System.String? OldFilesetTemplateCdmId { get; set; }

        //      C# -> System.String? OldFilesetTemplateFid
        // GraphQL -> oldFilesetTemplateFid: String! (scalar)
        [JsonProperty("oldFilesetTemplateFid")]
        public System.String? OldFilesetTemplateFid { get; set; }

        //      C# -> System.String? ProtectionType
        // GraphQL -> protectionType: String! (scalar)
        [JsonProperty("protectionType")]
        public System.String? ProtectionType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NasMigrationFilesetDetail";
    }

    public NasMigrationFilesetDetail Set(
        System.String? FilesetName = null,
        System.String? NewExceptionRule = null,
        System.String? NewExcludeRules = null,
        System.String? NewFilesetTemplateFid = null,
        System.String? NewIncludeRules = null,
        System.String? OldFilesetTemplateCdmId = null,
        System.String? OldFilesetTemplateFid = null,
        System.String? ProtectionType = null
    ) 
    {
        if ( FilesetName != null ) {
            this.FilesetName = FilesetName;
        }
        if ( NewExceptionRule != null ) {
            this.NewExceptionRule = NewExceptionRule;
        }
        if ( NewExcludeRules != null ) {
            this.NewExcludeRules = NewExcludeRules;
        }
        if ( NewFilesetTemplateFid != null ) {
            this.NewFilesetTemplateFid = NewFilesetTemplateFid;
        }
        if ( NewIncludeRules != null ) {
            this.NewIncludeRules = NewIncludeRules;
        }
        if ( OldFilesetTemplateCdmId != null ) {
            this.OldFilesetTemplateCdmId = OldFilesetTemplateCdmId;
        }
        if ( OldFilesetTemplateFid != null ) {
            this.OldFilesetTemplateFid = OldFilesetTemplateFid;
        }
        if ( ProtectionType != null ) {
            this.ProtectionType = ProtectionType;
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
        //      C# -> System.String? FilesetName
        // GraphQL -> filesetName: String! (scalar)
        if (this.FilesetName != null) {
            s += ind + "filesetName\n" ;
        }
        //      C# -> System.String? NewExceptionRule
        // GraphQL -> newExceptionRule: String! (scalar)
        if (this.NewExceptionRule != null) {
            s += ind + "newExceptionRule\n" ;
        }
        //      C# -> System.String? NewExcludeRules
        // GraphQL -> newExcludeRules: String! (scalar)
        if (this.NewExcludeRules != null) {
            s += ind + "newExcludeRules\n" ;
        }
        //      C# -> System.String? NewFilesetTemplateFid
        // GraphQL -> newFilesetTemplateFid: String! (scalar)
        if (this.NewFilesetTemplateFid != null) {
            s += ind + "newFilesetTemplateFid\n" ;
        }
        //      C# -> System.String? NewIncludeRules
        // GraphQL -> newIncludeRules: String! (scalar)
        if (this.NewIncludeRules != null) {
            s += ind + "newIncludeRules\n" ;
        }
        //      C# -> System.String? OldFilesetTemplateCdmId
        // GraphQL -> oldFilesetTemplateCdmId: String! (scalar)
        if (this.OldFilesetTemplateCdmId != null) {
            s += ind + "oldFilesetTemplateCdmId\n" ;
        }
        //      C# -> System.String? OldFilesetTemplateFid
        // GraphQL -> oldFilesetTemplateFid: String! (scalar)
        if (this.OldFilesetTemplateFid != null) {
            s += ind + "oldFilesetTemplateFid\n" ;
        }
        //      C# -> System.String? ProtectionType
        // GraphQL -> protectionType: String! (scalar)
        if (this.ProtectionType != null) {
            s += ind + "protectionType\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? FilesetName
        // GraphQL -> filesetName: String! (scalar)
        if (this.FilesetName == null && Exploration.Includes(parent + ".filesetName", true))
        {
            this.FilesetName = "FETCH";
        }
        //      C# -> System.String? NewExceptionRule
        // GraphQL -> newExceptionRule: String! (scalar)
        if (this.NewExceptionRule == null && Exploration.Includes(parent + ".newExceptionRule", true))
        {
            this.NewExceptionRule = "FETCH";
        }
        //      C# -> System.String? NewExcludeRules
        // GraphQL -> newExcludeRules: String! (scalar)
        if (this.NewExcludeRules == null && Exploration.Includes(parent + ".newExcludeRules", true))
        {
            this.NewExcludeRules = "FETCH";
        }
        //      C# -> System.String? NewFilesetTemplateFid
        // GraphQL -> newFilesetTemplateFid: String! (scalar)
        if (this.NewFilesetTemplateFid == null && Exploration.Includes(parent + ".newFilesetTemplateFid", true))
        {
            this.NewFilesetTemplateFid = "FETCH";
        }
        //      C# -> System.String? NewIncludeRules
        // GraphQL -> newIncludeRules: String! (scalar)
        if (this.NewIncludeRules == null && Exploration.Includes(parent + ".newIncludeRules", true))
        {
            this.NewIncludeRules = "FETCH";
        }
        //      C# -> System.String? OldFilesetTemplateCdmId
        // GraphQL -> oldFilesetTemplateCdmId: String! (scalar)
        if (this.OldFilesetTemplateCdmId == null && Exploration.Includes(parent + ".oldFilesetTemplateCdmId", true))
        {
            this.OldFilesetTemplateCdmId = "FETCH";
        }
        //      C# -> System.String? OldFilesetTemplateFid
        // GraphQL -> oldFilesetTemplateFid: String! (scalar)
        if (this.OldFilesetTemplateFid == null && Exploration.Includes(parent + ".oldFilesetTemplateFid", true))
        {
            this.OldFilesetTemplateFid = "FETCH";
        }
        //      C# -> System.String? ProtectionType
        // GraphQL -> protectionType: String! (scalar)
        if (this.ProtectionType == null && Exploration.Includes(parent + ".protectionType", true))
        {
            this.ProtectionType = "FETCH";
        }
    }


    #endregion

    } // class NasMigrationFilesetDetail
    
    #endregion

    public static class ListNasMigrationFilesetDetailExtensions
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
            this List<NasMigrationFilesetDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NasMigrationFilesetDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NasMigrationFilesetDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types