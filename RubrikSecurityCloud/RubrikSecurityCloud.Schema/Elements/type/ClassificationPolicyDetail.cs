// ClassificationPolicyDetail.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region ClassificationPolicyDetail
    public class ClassificationPolicyDetail: IFragment
    {
        #region members
        //      C# -> System.Int64? CreatedTime
        // GraphQL -> createdTime: Long! (scalar)
        [JsonProperty("createdTime")]
        public System.Int64? CreatedTime { get; set; }

        //      C# -> System.Boolean? Deletable
        // GraphQL -> deletable: Boolean! (scalar)
        [JsonProperty("deletable")]
        public System.Boolean? Deletable { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> List<System.String>? HierarchyObjectIds
        // GraphQL -> hierarchyObjectIds: [String!]! (scalar)
        [JsonProperty("hierarchyObjectIds")]
        public List<System.String>? HierarchyObjectIds { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Int64? LastUpdatedTime
        // GraphQL -> lastUpdatedTime: Long! (scalar)
        [JsonProperty("lastUpdatedTime")]
        public System.Int64? LastUpdatedTime { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumAnalyzers
        // GraphQL -> numAnalyzers: Int! (scalar)
        [JsonProperty("numAnalyzers")]
        public System.Int32? NumAnalyzers { get; set; }

        //      C# -> System.Int32? TotalObjects
        // GraphQL -> totalObjects: Int! (scalar)
        [JsonProperty("totalObjects")]
        public System.Int32? TotalObjects { get; set; }

        //      C# -> List<Analyzer>? Analyzers
        // GraphQL -> analyzers: [Analyzer!]! (type)
        [JsonProperty("analyzers")]
        public List<Analyzer>? Analyzers { get; set; }

        //      C# -> User? Creator
        // GraphQL -> creator: User (type)
        [JsonProperty("creator")]
        public User? Creator { get; set; }

        //      C# -> HierarchyObjectConnection? HierarchyObjectConnection
        // GraphQL -> hierarchyObjectConnection: HierarchyObjectConnection! (type)
        [JsonProperty("hierarchyObjectConnection")]
        public HierarchyObjectConnection? HierarchyObjectConnection { get; set; }

        //      C# -> List<ObjectStatus>? ObjectStatuses
        // GraphQL -> objectStatuses: [ObjectStatus!]! (type)
        [JsonProperty("objectStatuses")]
        public List<ObjectStatus>? ObjectStatuses { get; set; }

        //      C# -> List<ClassificationPolicyWhitelistDetailedEntry>? Whitelists
        // GraphQL -> whitelists: [ClassificationPolicyWhitelistDetailedEntry!]! (type)
        [JsonProperty("whitelists")]
        public List<ClassificationPolicyWhitelistDetailedEntry>? Whitelists { get; set; }

        //      C# -> ClassificationPolicyColor? ColorEnum
        // GraphQL -> colorEnum: ClassificationPolicyColor! (enum)
        [JsonProperty("colorEnum")]
        public ClassificationPolicyColor? ColorEnum { get; set; }

        //      C# -> ClassificationPolicyMode? Mode
        // GraphQL -> mode: ClassificationPolicyMode! (enum)
        [JsonProperty("mode")]
        public ClassificationPolicyMode? Mode { get; set; }

        //      C# -> List<HierarchyObject>? HierarchyObjects
        // GraphQL -> hierarchyObjects: [HierarchyObject]! (interface)
        [JsonProperty("hierarchyObjects")]
        public List<HierarchyObject>? HierarchyObjects { get; set; }

        #endregion

    #region methods

    public ClassificationPolicyDetail Set(
        System.Int64? CreatedTime = null,
        System.Boolean? Deletable = null,
        System.String? Description = null,
        List<System.String>? HierarchyObjectIds = null,
        System.String? Id = null,
        System.Int64? LastUpdatedTime = null,
        System.String? Name = null,
        System.Int32? NumAnalyzers = null,
        System.Int32? TotalObjects = null,
        List<Analyzer>? Analyzers = null,
        User? Creator = null,
        HierarchyObjectConnection? HierarchyObjectConnection = null,
        List<ObjectStatus>? ObjectStatuses = null,
        List<ClassificationPolicyWhitelistDetailedEntry>? Whitelists = null,
        ClassificationPolicyColor? ColorEnum = null,
        ClassificationPolicyMode? Mode = null,
        List<HierarchyObject>? HierarchyObjects = null
    ) 
    {
        if ( CreatedTime != null ) {
            this.CreatedTime = CreatedTime;
        }
        if ( Deletable != null ) {
            this.Deletable = Deletable;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( HierarchyObjectIds != null ) {
            this.HierarchyObjectIds = HierarchyObjectIds;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LastUpdatedTime != null ) {
            this.LastUpdatedTime = LastUpdatedTime;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumAnalyzers != null ) {
            this.NumAnalyzers = NumAnalyzers;
        }
        if ( TotalObjects != null ) {
            this.TotalObjects = TotalObjects;
        }
        if ( Analyzers != null ) {
            this.Analyzers = Analyzers;
        }
        if ( Creator != null ) {
            this.Creator = Creator;
        }
        if ( HierarchyObjectConnection != null ) {
            this.HierarchyObjectConnection = HierarchyObjectConnection;
        }
        if ( ObjectStatuses != null ) {
            this.ObjectStatuses = ObjectStatuses;
        }
        if ( Whitelists != null ) {
            this.Whitelists = Whitelists;
        }
        if ( ColorEnum != null ) {
            this.ColorEnum = ColorEnum;
        }
        if ( Mode != null ) {
            this.Mode = Mode;
        }
        if ( HierarchyObjects != null ) {
            this.HierarchyObjects = HierarchyObjects;
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
            //      C# -> System.Int64? CreatedTime
            // GraphQL -> createdTime: Long! (scalar)
            if (this.CreatedTime != null)
            {
                 s += ind + "createdTime\n";

            }
            //      C# -> System.Boolean? Deletable
            // GraphQL -> deletable: Boolean! (scalar)
            if (this.Deletable != null)
            {
                 s += ind + "deletable\n";

            }
            //      C# -> System.String? Description
            // GraphQL -> description: String! (scalar)
            if (this.Description != null)
            {
                 s += ind + "description\n";

            }
            //      C# -> List<System.String>? HierarchyObjectIds
            // GraphQL -> hierarchyObjectIds: [String!]! (scalar)
            if (this.HierarchyObjectIds != null)
            {
                 s += ind + "hierarchyObjectIds\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Int64? LastUpdatedTime
            // GraphQL -> lastUpdatedTime: Long! (scalar)
            if (this.LastUpdatedTime != null)
            {
                 s += ind + "lastUpdatedTime\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.Int32? NumAnalyzers
            // GraphQL -> numAnalyzers: Int! (scalar)
            if (this.NumAnalyzers != null)
            {
                 s += ind + "numAnalyzers\n";

            }
            //      C# -> System.Int32? TotalObjects
            // GraphQL -> totalObjects: Int! (scalar)
            if (this.TotalObjects != null)
            {
                 s += ind + "totalObjects\n";

            }
            //      C# -> List<Analyzer>? Analyzers
            // GraphQL -> analyzers: [Analyzer!]! (type)
            if (this.Analyzers != null)
            {
                 s += ind + "analyzers\n";

                 s += ind + "{\n" + 
                 this.Analyzers.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> User? Creator
            // GraphQL -> creator: User (type)
            if (this.Creator != null)
            {
                 s += ind + "creator\n";

                 s += ind + "{\n" + 
                 this.Creator.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> HierarchyObjectConnection? HierarchyObjectConnection
            // GraphQL -> hierarchyObjectConnection: HierarchyObjectConnection! (type)
            if (this.HierarchyObjectConnection != null)
            {
                 s += ind + "hierarchyObjectConnection\n";

                 s += ind + "{\n" + 
                 this.HierarchyObjectConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ObjectStatus>? ObjectStatuses
            // GraphQL -> objectStatuses: [ObjectStatus!]! (type)
            if (this.ObjectStatuses != null)
            {
                 s += ind + "objectStatuses\n";

                 s += ind + "{\n" + 
                 this.ObjectStatuses.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ClassificationPolicyWhitelistDetailedEntry>? Whitelists
            // GraphQL -> whitelists: [ClassificationPolicyWhitelistDetailedEntry!]! (type)
            if (this.Whitelists != null)
            {
                 s += ind + "whitelists\n";

                 s += ind + "{\n" + 
                 this.Whitelists.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ClassificationPolicyColor? ColorEnum
            // GraphQL -> colorEnum: ClassificationPolicyColor! (enum)
            if (this.ColorEnum != null)
            {
                 s += ind + "colorEnum\n";

            }
            //      C# -> ClassificationPolicyMode? Mode
            // GraphQL -> mode: ClassificationPolicyMode! (enum)
            if (this.Mode != null)
            {
                 s += ind + "mode\n";

            }
                        //      C# -> List<HierarchyObject>? HierarchyObjects
            // GraphQL -> hierarchyObjects: [HierarchyObject]! (interface)
            if (this.HierarchyObjects != null)
            {
                s += ind + "hierarchyObjects\n";
                s += ind + "{\n";

                s += this.HierarchyObjects.AsFragment(indent+1) +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? CreatedTime
            // GraphQL -> createdTime: Long! (scalar)
            if (this.CreatedTime == null && Exploration.Includes(parent + ".createdTime$"))
            {
                this.CreatedTime = new System.Int64();
            }
            //      C# -> System.Boolean? Deletable
            // GraphQL -> deletable: Boolean! (scalar)
            if (this.Deletable == null && Exploration.Includes(parent + ".deletable$"))
            {
                this.Deletable = new System.Boolean();
            }
            //      C# -> System.String? Description
            // GraphQL -> description: String! (scalar)
            if (this.Description == null && Exploration.Includes(parent + ".description$"))
            {
                this.Description = new System.String("FETCH");
            }
            //      C# -> List<System.String>? HierarchyObjectIds
            // GraphQL -> hierarchyObjectIds: [String!]! (scalar)
            if (this.HierarchyObjectIds == null && Exploration.Includes(parent + ".hierarchyObjectIds$"))
            {
                this.HierarchyObjectIds = new List<System.String>();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Int64? LastUpdatedTime
            // GraphQL -> lastUpdatedTime: Long! (scalar)
            if (this.LastUpdatedTime == null && Exploration.Includes(parent + ".lastUpdatedTime$"))
            {
                this.LastUpdatedTime = new System.Int64();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.Int32? NumAnalyzers
            // GraphQL -> numAnalyzers: Int! (scalar)
            if (this.NumAnalyzers == null && Exploration.Includes(parent + ".numAnalyzers$"))
            {
                this.NumAnalyzers = new System.Int32();
            }
            //      C# -> System.Int32? TotalObjects
            // GraphQL -> totalObjects: Int! (scalar)
            if (this.TotalObjects == null && Exploration.Includes(parent + ".totalObjects$"))
            {
                this.TotalObjects = new System.Int32();
            }
            //      C# -> List<Analyzer>? Analyzers
            // GraphQL -> analyzers: [Analyzer!]! (type)
            if (this.Analyzers == null && Exploration.Includes(parent + ".analyzers"))
            {
                this.Analyzers = new List<Analyzer>();
                this.Analyzers.ApplyExploratoryFragment(parent + ".analyzers");
            }
            //      C# -> User? Creator
            // GraphQL -> creator: User (type)
            if (this.Creator == null && Exploration.Includes(parent + ".creator"))
            {
                this.Creator = new User();
                this.Creator.ApplyExploratoryFragment(parent + ".creator");
            }
            //      C# -> HierarchyObjectConnection? HierarchyObjectConnection
            // GraphQL -> hierarchyObjectConnection: HierarchyObjectConnection! (type)
            if (this.HierarchyObjectConnection == null && Exploration.Includes(parent + ".hierarchyObjectConnection"))
            {
                this.HierarchyObjectConnection = new HierarchyObjectConnection();
                this.HierarchyObjectConnection.ApplyExploratoryFragment(parent + ".hierarchyObjectConnection");
            }
            //      C# -> List<ObjectStatus>? ObjectStatuses
            // GraphQL -> objectStatuses: [ObjectStatus!]! (type)
            if (this.ObjectStatuses == null && Exploration.Includes(parent + ".objectStatuses"))
            {
                this.ObjectStatuses = new List<ObjectStatus>();
                this.ObjectStatuses.ApplyExploratoryFragment(parent + ".objectStatuses");
            }
            //      C# -> List<ClassificationPolicyWhitelistDetailedEntry>? Whitelists
            // GraphQL -> whitelists: [ClassificationPolicyWhitelistDetailedEntry!]! (type)
            if (this.Whitelists == null && Exploration.Includes(parent + ".whitelists"))
            {
                this.Whitelists = new List<ClassificationPolicyWhitelistDetailedEntry>();
                this.Whitelists.ApplyExploratoryFragment(parent + ".whitelists");
            }
            //      C# -> ClassificationPolicyColor? ColorEnum
            // GraphQL -> colorEnum: ClassificationPolicyColor! (enum)
            if (this.ColorEnum == null && Exploration.Includes(parent + ".colorEnum$"))
            {
                this.ColorEnum = new ClassificationPolicyColor();
            }
            //      C# -> ClassificationPolicyMode? Mode
            // GraphQL -> mode: ClassificationPolicyMode! (enum)
            if (this.Mode == null && Exploration.Includes(parent + ".mode$"))
            {
                this.Mode = new ClassificationPolicyMode();
            }
            //      C# -> List<HierarchyObject>? HierarchyObjects
            // GraphQL -> hierarchyObjects: [HierarchyObject]! (interface)
            if (this.HierarchyObjects == null && Exploration.Includes(parent + ".hierarchyObjects"))
            {
                this.HierarchyObjects = new List<HierarchyObject>();
                this.HierarchyObjects.ApplyExploratoryFragment(parent + ".hierarchyObjects");
            }
        }


    #endregion

    } // class ClassificationPolicyDetail
    #endregion

    public static class ListClassificationPolicyDetailExtensions
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
            this List<ClassificationPolicyDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ClassificationPolicyDetail> list, 
            String parent = "")
        {
            var item = new ClassificationPolicyDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types