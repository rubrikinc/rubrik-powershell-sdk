// NonCompliantArchivalRetentionWarningsDetails.cs
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
    #region NonCompliantArchivalRetentionWarningsDetails
 
    public class NonCompliantArchivalRetentionWarningsDetails: BaseType, SpecificArchivalLocationWarningDetails
    {
        #region members

        //      C# -> RetentionUnit? FrequencyType
        // GraphQL -> frequencyType: RetentionUnit! (enum)
        [JsonProperty("frequencyType")]
        public RetentionUnit? FrequencyType { get; set; }

        //      C# -> System.Int32? ArchivalRetentionInDaysProvided
        // GraphQL -> archivalRetentionInDaysProvided: Int! (scalar)
        [JsonProperty("archivalRetentionInDaysProvided")]
        public System.Int32? ArchivalRetentionInDaysProvided { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Int32? MaxArchivalRetentionInDaysExpected
        // GraphQL -> maxArchivalRetentionInDaysExpected: Int! (scalar)
        [JsonProperty("maxArchivalRetentionInDaysExpected")]
        public System.Int32? MaxArchivalRetentionInDaysExpected { get; set; }

        //      C# -> System.Int32? MinArchivalRetentionInDaysExpected
        // GraphQL -> minArchivalRetentionInDaysExpected: Int! (scalar)
        [JsonProperty("minArchivalRetentionInDaysExpected")]
        public System.Int32? MinArchivalRetentionInDaysExpected { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NonCompliantArchivalRetentionWarningsDetails";
    }

    public NonCompliantArchivalRetentionWarningsDetails Set(
        RetentionUnit? FrequencyType = null,
        System.Int32? ArchivalRetentionInDaysProvided = null,
        System.String? Id = null,
        System.Int32? MaxArchivalRetentionInDaysExpected = null,
        System.Int32? MinArchivalRetentionInDaysExpected = null,
        System.String? Name = null
    ) 
    {
        if ( FrequencyType != null ) {
            this.FrequencyType = FrequencyType;
        }
        if ( ArchivalRetentionInDaysProvided != null ) {
            this.ArchivalRetentionInDaysProvided = ArchivalRetentionInDaysProvided;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( MaxArchivalRetentionInDaysExpected != null ) {
            this.MaxArchivalRetentionInDaysExpected = MaxArchivalRetentionInDaysExpected;
        }
        if ( MinArchivalRetentionInDaysExpected != null ) {
            this.MinArchivalRetentionInDaysExpected = MinArchivalRetentionInDaysExpected;
        }
        if ( Name != null ) {
            this.Name = Name;
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
        //      C# -> RetentionUnit? FrequencyType
        // GraphQL -> frequencyType: RetentionUnit! (enum)
        if (this.FrequencyType != null) {
            s += ind + "frequencyType\n" ;
        }
        //      C# -> System.Int32? ArchivalRetentionInDaysProvided
        // GraphQL -> archivalRetentionInDaysProvided: Int! (scalar)
        if (this.ArchivalRetentionInDaysProvided != null) {
            s += ind + "archivalRetentionInDaysProvided\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Int32? MaxArchivalRetentionInDaysExpected
        // GraphQL -> maxArchivalRetentionInDaysExpected: Int! (scalar)
        if (this.MaxArchivalRetentionInDaysExpected != null) {
            s += ind + "maxArchivalRetentionInDaysExpected\n" ;
        }
        //      C# -> System.Int32? MinArchivalRetentionInDaysExpected
        // GraphQL -> minArchivalRetentionInDaysExpected: Int! (scalar)
        if (this.MinArchivalRetentionInDaysExpected != null) {
            s += ind + "minArchivalRetentionInDaysExpected\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> RetentionUnit? FrequencyType
        // GraphQL -> frequencyType: RetentionUnit! (enum)
        if (this.FrequencyType == null && Exploration.Includes(parent + ".frequencyType", true))
        {
            this.FrequencyType = new RetentionUnit();
        }
        //      C# -> System.Int32? ArchivalRetentionInDaysProvided
        // GraphQL -> archivalRetentionInDaysProvided: Int! (scalar)
        if (this.ArchivalRetentionInDaysProvided == null && Exploration.Includes(parent + ".archivalRetentionInDaysProvided", true))
        {
            this.ArchivalRetentionInDaysProvided = Int32.MinValue;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Int32? MaxArchivalRetentionInDaysExpected
        // GraphQL -> maxArchivalRetentionInDaysExpected: Int! (scalar)
        if (this.MaxArchivalRetentionInDaysExpected == null && Exploration.Includes(parent + ".maxArchivalRetentionInDaysExpected", true))
        {
            this.MaxArchivalRetentionInDaysExpected = Int32.MinValue;
        }
        //      C# -> System.Int32? MinArchivalRetentionInDaysExpected
        // GraphQL -> minArchivalRetentionInDaysExpected: Int! (scalar)
        if (this.MinArchivalRetentionInDaysExpected == null && Exploration.Includes(parent + ".minArchivalRetentionInDaysExpected", true))
        {
            this.MinArchivalRetentionInDaysExpected = Int32.MinValue;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
    }


    #endregion

    } // class NonCompliantArchivalRetentionWarningsDetails
    
    #endregion

    public static class ListNonCompliantArchivalRetentionWarningsDetailsExtensions
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
            this List<NonCompliantArchivalRetentionWarningsDetails> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NonCompliantArchivalRetentionWarningsDetails> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NonCompliantArchivalRetentionWarningsDetails());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types