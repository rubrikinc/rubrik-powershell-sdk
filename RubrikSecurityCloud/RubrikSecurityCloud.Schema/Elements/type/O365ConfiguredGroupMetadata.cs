// O365ConfiguredGroupMetadata.cs
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
    #region O365ConfiguredGroupMetadata
    public class O365ConfiguredGroupMetadata: BaseType
    {
        #region members

        //      C# -> System.Int32? SharepointObjects
        // GraphQL -> sharepointObjects: Int (scalar)
        [JsonProperty("sharepointObjects")]
        public System.Int32? SharepointObjects { get; set; }

        //      C# -> System.Int32? TeamsObjects
        // GraphQL -> teamsObjects: Int (scalar)
        [JsonProperty("teamsObjects")]
        public System.Int32? TeamsObjects { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365ConfiguredGroupMetadata";
    }

    public O365ConfiguredGroupMetadata Set(
        System.Int32? SharepointObjects = null,
        System.Int32? TeamsObjects = null
    ) 
    {
        if ( SharepointObjects != null ) {
            this.SharepointObjects = SharepointObjects;
        }
        if ( TeamsObjects != null ) {
            this.TeamsObjects = TeamsObjects;
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
        //      C# -> System.Int32? SharepointObjects
        // GraphQL -> sharepointObjects: Int (scalar)
        if (this.SharepointObjects != null) {
            s += ind + "sharepointObjects\n" ;
        }
        //      C# -> System.Int32? TeamsObjects
        // GraphQL -> teamsObjects: Int (scalar)
        if (this.TeamsObjects != null) {
            s += ind + "teamsObjects\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? SharepointObjects
        // GraphQL -> sharepointObjects: Int (scalar)
        if (this.SharepointObjects == null && ec.Includes("sharepointObjects",true))
        {
            this.SharepointObjects = Int32.MinValue;
        }
        //      C# -> System.Int32? TeamsObjects
        // GraphQL -> teamsObjects: Int (scalar)
        if (this.TeamsObjects == null && ec.Includes("teamsObjects",true))
        {
            this.TeamsObjects = Int32.MinValue;
        }
    }


    #endregion

    } // class O365ConfiguredGroupMetadata
    
    #endregion

    public static class ListO365ConfiguredGroupMetadataExtensions
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
            this List<O365ConfiguredGroupMetadata> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365ConfiguredGroupMetadata> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365ConfiguredGroupMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<O365ConfiguredGroupMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types