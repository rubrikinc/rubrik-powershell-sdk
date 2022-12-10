// ProtectedObjects.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:35.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region ProtectedObjects
 
    public class ProtectedObjects: IFragment, ProtectedObjectSummary
    {
        #region members
        //      C# -> System.String? EffectiveSlaOpt
        // GraphQL -> effectiveSlaOpt: String (scalar)
        [JsonProperty("effectiveSlaOpt")]
        public System.String? EffectiveSlaOpt { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.Boolean? IsUnprotected
        // GraphQL -> isUnprotected: Boolean! (scalar)
        [JsonProperty("isUnprotected")]
        public System.Boolean? IsUnprotected { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> ManagedObjectType? ObjectType
        // GraphQL -> objectType: ManagedObjectType (enum)
        [JsonProperty("objectType")]
        public ManagedObjectType? ObjectType { get; set; }

        #endregion

    #region methods

    public ProtectedObjects Set(
        System.String? EffectiveSlaOpt = null,
        System.String? Id = null,
        System.Boolean? IsArchived = null,
        System.Boolean? IsUnprotected = null,
        System.String? Name = null,
        System.Boolean? SlaPauseStatus = null,
        ManagedObjectType? ObjectType = null
    ) 
    {
        if ( EffectiveSlaOpt != null ) {
            this.EffectiveSlaOpt = EffectiveSlaOpt;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( IsUnprotected != null ) {
            this.IsUnprotected = IsUnprotected;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? EffectiveSlaOpt
            // GraphQL -> effectiveSlaOpt: String (scalar)
            if (this.EffectiveSlaOpt != null)
            {
                 s += ind + "effectiveSlaOpt\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsArchived
            // GraphQL -> isArchived: Boolean! (scalar)
            if (this.IsArchived != null)
            {
                 s += ind + "isArchived\n";

            }
            //      C# -> System.Boolean? IsUnprotected
            // GraphQL -> isUnprotected: Boolean! (scalar)
            if (this.IsUnprotected != null)
            {
                 s += ind + "isUnprotected\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.Boolean? SlaPauseStatus
            // GraphQL -> slaPauseStatus: Boolean (scalar)
            if (this.SlaPauseStatus != null)
            {
                 s += ind + "slaPauseStatus\n";

            }
            //      C# -> ManagedObjectType? ObjectType
            // GraphQL -> objectType: ManagedObjectType (enum)
            if (this.ObjectType != null)
            {
                 s += ind + "objectType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? EffectiveSlaOpt
            // GraphQL -> effectiveSlaOpt: String (scalar)
            if (this.EffectiveSlaOpt == null && Exploration.Includes(parent + ".effectiveSlaOpt$"))
            {
                this.EffectiveSlaOpt = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsArchived
            // GraphQL -> isArchived: Boolean! (scalar)
            if (this.IsArchived == null && Exploration.Includes(parent + ".isArchived$"))
            {
                this.IsArchived = new System.Boolean();
            }
            //      C# -> System.Boolean? IsUnprotected
            // GraphQL -> isUnprotected: Boolean! (scalar)
            if (this.IsUnprotected == null && Exploration.Includes(parent + ".isUnprotected$"))
            {
                this.IsUnprotected = new System.Boolean();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.Boolean? SlaPauseStatus
            // GraphQL -> slaPauseStatus: Boolean (scalar)
            if (this.SlaPauseStatus == null && Exploration.Includes(parent + ".slaPauseStatus$"))
            {
                this.SlaPauseStatus = new System.Boolean();
            }
            //      C# -> ManagedObjectType? ObjectType
            // GraphQL -> objectType: ManagedObjectType (enum)
            if (this.ObjectType == null && Exploration.Includes(parent + ".objectType$"))
            {
                this.ObjectType = new ManagedObjectType();
            }
        }


    #endregion

    } // class ProtectedObjects
    #endregion

    public static class ListProtectedObjectsExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<ProtectedObjects> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ProtectedObjects> list, 
            String parent = "")
        {
            var item = new ProtectedObjects();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types