// RansomwareInvestigationObjectsReply.cs
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
    #region RansomwareInvestigationObjectsReply
    public class RansomwareInvestigationObjectsReply: BaseType
    {
        #region members

        //      C# -> System.Int64? ObjectsNoAnomalies
        // GraphQL -> objectsNoAnomalies: Long! (scalar)
        [JsonProperty("objectsNoAnomalies")]
        public System.Int64? ObjectsNoAnomalies { get; set; }

        //      C# -> System.Int64? ObjectsNoThreats
        // GraphQL -> objectsNoThreats: Long! (scalar)
        [JsonProperty("objectsNoThreats")]
        public System.Int64? ObjectsNoThreats { get; set; }

        //      C# -> System.Int64? ObjectsWithAnomalies
        // GraphQL -> objectsWithAnomalies: Long! (scalar)
        [JsonProperty("objectsWithAnomalies")]
        public System.Int64? ObjectsWithAnomalies { get; set; }

        //      C# -> System.Int64? ObjectsWithThreats
        // GraphQL -> objectsWithThreats: Long! (scalar)
        [JsonProperty("objectsWithThreats")]
        public System.Int64? ObjectsWithThreats { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RansomwareInvestigationObjectsReply";
    }

    public RansomwareInvestigationObjectsReply Set(
        System.Int64? ObjectsNoAnomalies = null,
        System.Int64? ObjectsNoThreats = null,
        System.Int64? ObjectsWithAnomalies = null,
        System.Int64? ObjectsWithThreats = null
    ) 
    {
        if ( ObjectsNoAnomalies != null ) {
            this.ObjectsNoAnomalies = ObjectsNoAnomalies;
        }
        if ( ObjectsNoThreats != null ) {
            this.ObjectsNoThreats = ObjectsNoThreats;
        }
        if ( ObjectsWithAnomalies != null ) {
            this.ObjectsWithAnomalies = ObjectsWithAnomalies;
        }
        if ( ObjectsWithThreats != null ) {
            this.ObjectsWithThreats = ObjectsWithThreats;
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
        //      C# -> System.Int64? ObjectsNoAnomalies
        // GraphQL -> objectsNoAnomalies: Long! (scalar)
        if (this.ObjectsNoAnomalies != null) {
            s += ind + "objectsNoAnomalies\n" ;
        }
        //      C# -> System.Int64? ObjectsNoThreats
        // GraphQL -> objectsNoThreats: Long! (scalar)
        if (this.ObjectsNoThreats != null) {
            s += ind + "objectsNoThreats\n" ;
        }
        //      C# -> System.Int64? ObjectsWithAnomalies
        // GraphQL -> objectsWithAnomalies: Long! (scalar)
        if (this.ObjectsWithAnomalies != null) {
            s += ind + "objectsWithAnomalies\n" ;
        }
        //      C# -> System.Int64? ObjectsWithThreats
        // GraphQL -> objectsWithThreats: Long! (scalar)
        if (this.ObjectsWithThreats != null) {
            s += ind + "objectsWithThreats\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? ObjectsNoAnomalies
        // GraphQL -> objectsNoAnomalies: Long! (scalar)
        if (this.ObjectsNoAnomalies == null && Exploration.Includes(parent + ".objectsNoAnomalies", true))
        {
            this.ObjectsNoAnomalies = new System.Int64();
        }
        //      C# -> System.Int64? ObjectsNoThreats
        // GraphQL -> objectsNoThreats: Long! (scalar)
        if (this.ObjectsNoThreats == null && Exploration.Includes(parent + ".objectsNoThreats", true))
        {
            this.ObjectsNoThreats = new System.Int64();
        }
        //      C# -> System.Int64? ObjectsWithAnomalies
        // GraphQL -> objectsWithAnomalies: Long! (scalar)
        if (this.ObjectsWithAnomalies == null && Exploration.Includes(parent + ".objectsWithAnomalies", true))
        {
            this.ObjectsWithAnomalies = new System.Int64();
        }
        //      C# -> System.Int64? ObjectsWithThreats
        // GraphQL -> objectsWithThreats: Long! (scalar)
        if (this.ObjectsWithThreats == null && Exploration.Includes(parent + ".objectsWithThreats", true))
        {
            this.ObjectsWithThreats = new System.Int64();
        }
    }


    #endregion

    } // class RansomwareInvestigationObjectsReply
    
    #endregion

    public static class ListRansomwareInvestigationObjectsReplyExtensions
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
            this List<RansomwareInvestigationObjectsReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RansomwareInvestigationObjectsReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RansomwareInvestigationObjectsReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types