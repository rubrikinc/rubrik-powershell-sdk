// PvcInformation.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:38.
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
    #region PvcInformation
    public class PvcInformation: IFragment
    {
        #region members
        //      C# -> System.String? AccessMode
        // GraphQL -> accessMode: String! (scalar)
        [JsonProperty("accessMode")]
        public System.String? AccessMode { get; set; }

        //      C# -> System.String? Capacity
        // GraphQL -> capacity: String! (scalar)
        [JsonProperty("capacity")]
        public System.String? Capacity { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Labels
        // GraphQL -> labels: String! (scalar)
        [JsonProperty("labels")]
        public System.String? Labels { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Phase
        // GraphQL -> phase: String! (scalar)
        [JsonProperty("phase")]
        public System.String? Phase { get; set; }

        //      C# -> System.String? StorageClass
        // GraphQL -> storageClass: String! (scalar)
        [JsonProperty("storageClass")]
        public System.String? StorageClass { get; set; }

        //      C# -> System.String? Volume
        // GraphQL -> volume: String! (scalar)
        [JsonProperty("volume")]
        public System.String? Volume { get; set; }

        #endregion

    #region methods

    public PvcInformation Set(
        System.String? AccessMode = null,
        System.String? Capacity = null,
        System.String? Id = null,
        System.String? Labels = null,
        System.String? Name = null,
        System.String? Phase = null,
        System.String? StorageClass = null,
        System.String? Volume = null
    ) 
    {
        if ( AccessMode != null ) {
            this.AccessMode = AccessMode;
        }
        if ( Capacity != null ) {
            this.Capacity = Capacity;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Labels != null ) {
            this.Labels = Labels;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Phase != null ) {
            this.Phase = Phase;
        }
        if ( StorageClass != null ) {
            this.StorageClass = StorageClass;
        }
        if ( Volume != null ) {
            this.Volume = Volume;
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
            //      C# -> System.String? AccessMode
            // GraphQL -> accessMode: String! (scalar)
            if (this.AccessMode != null)
            {
                 s += ind + "accessMode\n";

            }
            //      C# -> System.String? Capacity
            // GraphQL -> capacity: String! (scalar)
            if (this.Capacity != null)
            {
                 s += ind + "capacity\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? Labels
            // GraphQL -> labels: String! (scalar)
            if (this.Labels != null)
            {
                 s += ind + "labels\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? Phase
            // GraphQL -> phase: String! (scalar)
            if (this.Phase != null)
            {
                 s += ind + "phase\n";

            }
            //      C# -> System.String? StorageClass
            // GraphQL -> storageClass: String! (scalar)
            if (this.StorageClass != null)
            {
                 s += ind + "storageClass\n";

            }
            //      C# -> System.String? Volume
            // GraphQL -> volume: String! (scalar)
            if (this.Volume != null)
            {
                 s += ind + "volume\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AccessMode
            // GraphQL -> accessMode: String! (scalar)
            if (this.AccessMode == null && Exploration.Includes(parent + ".accessMode$"))
            {
                this.AccessMode = new System.String("FETCH");
            }
            //      C# -> System.String? Capacity
            // GraphQL -> capacity: String! (scalar)
            if (this.Capacity == null && Exploration.Includes(parent + ".capacity$"))
            {
                this.Capacity = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? Labels
            // GraphQL -> labels: String! (scalar)
            if (this.Labels == null && Exploration.Includes(parent + ".labels$"))
            {
                this.Labels = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? Phase
            // GraphQL -> phase: String! (scalar)
            if (this.Phase == null && Exploration.Includes(parent + ".phase$"))
            {
                this.Phase = new System.String("FETCH");
            }
            //      C# -> System.String? StorageClass
            // GraphQL -> storageClass: String! (scalar)
            if (this.StorageClass == null && Exploration.Includes(parent + ".storageClass$"))
            {
                this.StorageClass = new System.String("FETCH");
            }
            //      C# -> System.String? Volume
            // GraphQL -> volume: String! (scalar)
            if (this.Volume == null && Exploration.Includes(parent + ".volume$"))
            {
                this.Volume = new System.String("FETCH");
            }
        }


    #endregion

    } // class PvcInformation
    #endregion

    public static class ListPvcInformationExtensions
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
            this List<PvcInformation> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<PvcInformation> list, 
            String parent = "")
        {
            var item = new PvcInformation();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types