// AzureSqlDatabaseDbConfig.cs
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
    #region AzureSqlDatabaseDbConfig
    public class AzureSqlDatabaseDbConfig: BaseType
    {
        #region members

        //      C# -> System.Int32? LogRetentionInDays
        // GraphQL -> logRetentionInDays: Int! (scalar)
        [JsonProperty("logRetentionInDays")]
        public System.Int32? LogRetentionInDays { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureSqlDatabaseDbConfig";
    }

    public AzureSqlDatabaseDbConfig Set(
        System.Int32? LogRetentionInDays = null
    ) 
    {
        if ( LogRetentionInDays != null ) {
            this.LogRetentionInDays = LogRetentionInDays;
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
        //      C# -> System.Int32? LogRetentionInDays
        // GraphQL -> logRetentionInDays: Int! (scalar)
        if (this.LogRetentionInDays != null) {
            s += ind + "logRetentionInDays\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? LogRetentionInDays
        // GraphQL -> logRetentionInDays: Int! (scalar)
        if (this.LogRetentionInDays == null && ec.Includes("logRetentionInDays",true))
        {
            this.LogRetentionInDays = Int32.MinValue;
        }
    }


    #endregion

    } // class AzureSqlDatabaseDbConfig
    
    #endregion

    public static class ListAzureSqlDatabaseDbConfigExtensions
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
            this List<AzureSqlDatabaseDbConfig> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureSqlDatabaseDbConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureSqlDatabaseDbConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AzureSqlDatabaseDbConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types