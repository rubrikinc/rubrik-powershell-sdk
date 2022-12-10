// SnapshotFile.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:19.
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
    #region SnapshotFile
    public class SnapshotFile: IFragment
    {
        #region members
        //      C# -> System.String? AbsolutePath
        // GraphQL -> absolutePath: String! (scalar)
        [JsonProperty("absolutePath")]
        public System.String? AbsolutePath { get; set; }

        //      C# -> System.String? DisplayPath
        // GraphQL -> displayPath: String! (scalar)
        [JsonProperty("displayPath")]
        public System.String? DisplayPath { get; set; }

        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        [JsonProperty("filename")]
        public System.String? Filename { get; set; }

        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime! (scalar)
        [JsonProperty("lastModified")]
        public DateTime? LastModified { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String! (scalar)
        [JsonProperty("statusMessage")]
        public System.String? StatusMessage { get; set; }

        //      C# -> QuarantineInfo? QuarantineInfo
        // GraphQL -> quarantineInfo: QuarantineInfo (type)
        [JsonProperty("quarantineInfo")]
        public QuarantineInfo? QuarantineInfo { get; set; }

        //      C# -> WorkloadFields? WorkloadFields
        // GraphQL -> workloadFields: WorkloadFields (type)
        [JsonProperty("workloadFields")]
        public WorkloadFields? WorkloadFields { get; set; }

        //      C# -> FileModeEnum? FileMode
        // GraphQL -> fileMode: FileModeEnum! (enum)
        [JsonProperty("fileMode")]
        public FileModeEnum? FileMode { get; set; }

        #endregion

    #region methods

    public SnapshotFile Set(
        System.String? AbsolutePath = null,
        System.String? DisplayPath = null,
        System.String? Filename = null,
        DateTime? LastModified = null,
        System.String? Path = null,
        System.Int64? Size = null,
        System.String? StatusMessage = null,
        QuarantineInfo? QuarantineInfo = null,
        WorkloadFields? WorkloadFields = null,
        FileModeEnum? FileMode = null
    ) 
    {
        if ( AbsolutePath != null ) {
            this.AbsolutePath = AbsolutePath;
        }
        if ( DisplayPath != null ) {
            this.DisplayPath = DisplayPath;
        }
        if ( Filename != null ) {
            this.Filename = Filename;
        }
        if ( LastModified != null ) {
            this.LastModified = LastModified;
        }
        if ( Path != null ) {
            this.Path = Path;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( StatusMessage != null ) {
            this.StatusMessage = StatusMessage;
        }
        if ( QuarantineInfo != null ) {
            this.QuarantineInfo = QuarantineInfo;
        }
        if ( WorkloadFields != null ) {
            this.WorkloadFields = WorkloadFields;
        }
        if ( FileMode != null ) {
            this.FileMode = FileMode;
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
            //      C# -> System.String? AbsolutePath
            // GraphQL -> absolutePath: String! (scalar)
            if (this.AbsolutePath != null)
            {
                 s += ind + "absolutePath\n";

            }
            //      C# -> System.String? DisplayPath
            // GraphQL -> displayPath: String! (scalar)
            if (this.DisplayPath != null)
            {
                 s += ind + "displayPath\n";

            }
            //      C# -> System.String? Filename
            // GraphQL -> filename: String! (scalar)
            if (this.Filename != null)
            {
                 s += ind + "filename\n";

            }
            //      C# -> DateTime? LastModified
            // GraphQL -> lastModified: DateTime! (scalar)
            if (this.LastModified != null)
            {
                 s += ind + "lastModified\n";

            }
            //      C# -> System.String? Path
            // GraphQL -> path: String! (scalar)
            if (this.Path != null)
            {
                 s += ind + "path\n";

            }
            //      C# -> System.Int64? Size
            // GraphQL -> size: Long! (scalar)
            if (this.Size != null)
            {
                 s += ind + "size\n";

            }
            //      C# -> System.String? StatusMessage
            // GraphQL -> statusMessage: String! (scalar)
            if (this.StatusMessage != null)
            {
                 s += ind + "statusMessage\n";

            }
            //      C# -> QuarantineInfo? QuarantineInfo
            // GraphQL -> quarantineInfo: QuarantineInfo (type)
            if (this.QuarantineInfo != null)
            {
                 s += ind + "quarantineInfo\n";

                 s += ind + "{\n" + 
                 this.QuarantineInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> WorkloadFields? WorkloadFields
            // GraphQL -> workloadFields: WorkloadFields (type)
            if (this.WorkloadFields != null)
            {
                 s += ind + "workloadFields\n";

                 s += ind + "{\n" + 
                 this.WorkloadFields.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> FileModeEnum? FileMode
            // GraphQL -> fileMode: FileModeEnum! (enum)
            if (this.FileMode != null)
            {
                 s += ind + "fileMode\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AbsolutePath
            // GraphQL -> absolutePath: String! (scalar)
            if (this.AbsolutePath == null && Exploration.Includes(parent + ".absolutePath$"))
            {
                this.AbsolutePath = new System.String("FETCH");
            }
            //      C# -> System.String? DisplayPath
            // GraphQL -> displayPath: String! (scalar)
            if (this.DisplayPath == null && Exploration.Includes(parent + ".displayPath$"))
            {
                this.DisplayPath = new System.String("FETCH");
            }
            //      C# -> System.String? Filename
            // GraphQL -> filename: String! (scalar)
            if (this.Filename == null && Exploration.Includes(parent + ".filename$"))
            {
                this.Filename = new System.String("FETCH");
            }
            //      C# -> DateTime? LastModified
            // GraphQL -> lastModified: DateTime! (scalar)
            if (this.LastModified == null && Exploration.Includes(parent + ".lastModified$"))
            {
                this.LastModified = new DateTime();
            }
            //      C# -> System.String? Path
            // GraphQL -> path: String! (scalar)
            if (this.Path == null && Exploration.Includes(parent + ".path$"))
            {
                this.Path = new System.String("FETCH");
            }
            //      C# -> System.Int64? Size
            // GraphQL -> size: Long! (scalar)
            if (this.Size == null && Exploration.Includes(parent + ".size$"))
            {
                this.Size = new System.Int64();
            }
            //      C# -> System.String? StatusMessage
            // GraphQL -> statusMessage: String! (scalar)
            if (this.StatusMessage == null && Exploration.Includes(parent + ".statusMessage$"))
            {
                this.StatusMessage = new System.String("FETCH");
            }
            //      C# -> QuarantineInfo? QuarantineInfo
            // GraphQL -> quarantineInfo: QuarantineInfo (type)
            if (this.QuarantineInfo == null && Exploration.Includes(parent + ".quarantineInfo"))
            {
                this.QuarantineInfo = new QuarantineInfo();
                this.QuarantineInfo.ApplyExploratoryFragment(parent + ".quarantineInfo");
            }
            //      C# -> WorkloadFields? WorkloadFields
            // GraphQL -> workloadFields: WorkloadFields (type)
            if (this.WorkloadFields == null && Exploration.Includes(parent + ".workloadFields"))
            {
                this.WorkloadFields = new WorkloadFields();
                this.WorkloadFields.ApplyExploratoryFragment(parent + ".workloadFields");
            }
            //      C# -> FileModeEnum? FileMode
            // GraphQL -> fileMode: FileModeEnum! (enum)
            if (this.FileMode == null && Exploration.Includes(parent + ".fileMode$"))
            {
                this.FileMode = new FileModeEnum();
            }
        }


    #endregion

    } // class SnapshotFile
    #endregion

    public static class ListSnapshotFileExtensions
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
            this List<SnapshotFile> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SnapshotFile> list, 
            String parent = "")
        {
            var item = new SnapshotFile();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types