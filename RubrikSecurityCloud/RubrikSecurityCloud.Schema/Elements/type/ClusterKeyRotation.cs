// ClusterKeyRotation.cs
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
    #region ClusterKeyRotation
    public class ClusterKeyRotation: BaseType
    {
        #region members

        //      C# -> ClusterKeyProtection? ProtectionType
        // GraphQL -> protectionType: ClusterKeyProtection! (enum)
        [JsonProperty("protectionType")]
        public ClusterKeyProtection? ProtectionType { get; set; }

        //      C# -> ClusterKeyRotationState? State
        // GraphQL -> state: ClusterKeyRotationState! (enum)
        [JsonProperty("state")]
        public ClusterKeyRotationState? State { get; set; }

        //      C# -> DateTime? CompletedAt
        // GraphQL -> completedAt: DateTime (scalar)
        [JsonProperty("completedAt")]
        public DateTime? CompletedAt { get; set; }


        #endregion

    #region methods

    public ClusterKeyRotation Set(
        ClusterKeyProtection? ProtectionType = null,
        ClusterKeyRotationState? State = null,
        DateTime? CompletedAt = null
    ) 
    {
        if ( ProtectionType != null ) {
            this.ProtectionType = ProtectionType;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( CompletedAt != null ) {
            this.CompletedAt = CompletedAt;
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
        //      C# -> ClusterKeyProtection? ProtectionType
        // GraphQL -> protectionType: ClusterKeyProtection! (enum)
        if (this.ProtectionType != null) {
            s += ind + "protectionType\n" ;
        }
        //      C# -> ClusterKeyRotationState? State
        // GraphQL -> state: ClusterKeyRotationState! (enum)
        if (this.State != null) {
            s += ind + "state\n" ;
        }
        //      C# -> DateTime? CompletedAt
        // GraphQL -> completedAt: DateTime (scalar)
        if (this.CompletedAt != null) {
            s += ind + "completedAt\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ClusterKeyProtection? ProtectionType
        // GraphQL -> protectionType: ClusterKeyProtection! (enum)
        if (this.ProtectionType == null && Exploration.Includes(parent + ".protectionType", true))
        {
            this.ProtectionType = new ClusterKeyProtection();
        }
        //      C# -> ClusterKeyRotationState? State
        // GraphQL -> state: ClusterKeyRotationState! (enum)
        if (this.State == null && Exploration.Includes(parent + ".state", true))
        {
            this.State = new ClusterKeyRotationState();
        }
        //      C# -> DateTime? CompletedAt
        // GraphQL -> completedAt: DateTime (scalar)
        if (this.CompletedAt == null && Exploration.Includes(parent + ".completedAt", true))
        {
            this.CompletedAt = new DateTime();
        }
    }


    #endregion

    } // class ClusterKeyRotation
    
    #endregion

    public static class ListClusterKeyRotationExtensions
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
            this List<ClusterKeyRotation> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterKeyRotation> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterKeyRotation());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types