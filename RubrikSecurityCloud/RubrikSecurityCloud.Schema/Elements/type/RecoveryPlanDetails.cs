// RecoveryPlanDetails.cs
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
    #region RecoveryPlanDetails
    public class RecoveryPlanDetails: BaseType
    {
        #region members

        //      C# -> RecoveryPlanType? Type
        // GraphQL -> type: RecoveryPlanType! (enum)
        [JsonProperty("type")]
        public RecoveryPlanType? Type { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsVisible
        // GraphQL -> isVisible: Boolean! (scalar)
        [JsonProperty("isVisible")]
        public System.Boolean? IsVisible { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RecoveryPlanDetails";
    }

    public RecoveryPlanDetails Set(
        RecoveryPlanType? Type = null,
        System.String? Id = null,
        System.Boolean? IsVisible = null,
        System.String? Name = null
    ) 
    {
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsVisible != null ) {
            this.IsVisible = IsVisible;
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
        //      C# -> RecoveryPlanType? Type
        // GraphQL -> type: RecoveryPlanType! (enum)
        if (this.Type != null) {
            s += ind + "type\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsVisible
        // GraphQL -> isVisible: Boolean! (scalar)
        if (this.IsVisible != null) {
            s += ind + "isVisible\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RecoveryPlanType? Type
        // GraphQL -> type: RecoveryPlanType! (enum)
        if (this.Type == null && ec.Includes("type",true))
        {
            this.Type = new RecoveryPlanType();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsVisible
        // GraphQL -> isVisible: Boolean! (scalar)
        if (this.IsVisible == null && ec.Includes("isVisible",true))
        {
            this.IsVisible = true;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
    }


    #endregion

    } // class RecoveryPlanDetails
    
    #endregion

    public static class ListRecoveryPlanDetailsExtensions
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
            this List<RecoveryPlanDetails> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RecoveryPlanDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RecoveryPlanDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<RecoveryPlanDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types