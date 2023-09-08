// MongoConfig.cs
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
    #region MongoConfig
    public class MongoConfig: BaseType
    {
        #region members

        //      C# -> Duration? LogFrequency
        // GraphQL -> logFrequency: Duration (type)
        [JsonProperty("logFrequency")]
        public Duration? LogFrequency { get; set; }

        //      C# -> Duration? LogRetention
        // GraphQL -> logRetention: Duration (type)
        [JsonProperty("logRetention")]
        public Duration? LogRetention { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MongoConfig";
    }

    public MongoConfig Set(
        Duration? LogFrequency = null,
        Duration? LogRetention = null
    ) 
    {
        if ( LogFrequency != null ) {
            this.LogFrequency = LogFrequency;
        }
        if ( LogRetention != null ) {
            this.LogRetention = LogRetention;
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
        //      C# -> Duration? LogFrequency
        // GraphQL -> logFrequency: Duration (type)
        if (this.LogFrequency != null) {
            var fspec = this.LogFrequency.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "logFrequency {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Duration? LogRetention
        // GraphQL -> logRetention: Duration (type)
        if (this.LogRetention != null) {
            var fspec = this.LogRetention.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "logRetention {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> Duration? LogFrequency
        // GraphQL -> logFrequency: Duration (type)
        if (this.LogFrequency == null && ec.Includes("logFrequency",false))
        {
            this.LogFrequency = new Duration();
            this.LogFrequency.ApplyExploratoryFieldSpec(ec.NewChild("logFrequency"));
        }
        //      C# -> Duration? LogRetention
        // GraphQL -> logRetention: Duration (type)
        if (this.LogRetention == null && ec.Includes("logRetention",false))
        {
            this.LogRetention = new Duration();
            this.LogRetention.ApplyExploratoryFieldSpec(ec.NewChild("logRetention"));
        }
    }


    #endregion

    } // class MongoConfig
    
    #endregion

    public static class ListMongoConfigExtensions
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
            this List<MongoConfig> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MongoConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MongoConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<MongoConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types