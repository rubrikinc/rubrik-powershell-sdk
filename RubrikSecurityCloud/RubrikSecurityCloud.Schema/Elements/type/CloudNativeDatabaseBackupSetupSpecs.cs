// CloudNativeDatabaseBackupSetupSpecs.cs
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
    #region CloudNativeDatabaseBackupSetupSpecs
    public class CloudNativeDatabaseBackupSetupSpecs: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsSetupSuccessful
        // GraphQL -> isSetupSuccessful: Boolean! (scalar)
        [JsonProperty("isSetupSuccessful")]
        public System.Boolean? IsSetupSuccessful { get; set; }

        //      C# -> PathNode? SetupSourceObject
        // GraphQL -> setupSourceObject: PathNode! (type)
        [JsonProperty("setupSourceObject")]
        public PathNode? SetupSourceObject { get; set; }

        #endregion

    #region methods

    public CloudNativeDatabaseBackupSetupSpecs Set(
        System.Boolean? IsSetupSuccessful = null,
        PathNode? SetupSourceObject = null
    ) 
    {
        if ( IsSetupSuccessful != null ) {
            this.IsSetupSuccessful = IsSetupSuccessful;
        }
        if ( SetupSourceObject != null ) {
            this.SetupSourceObject = SetupSourceObject;
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
            //      C# -> System.Boolean? IsSetupSuccessful
            // GraphQL -> isSetupSuccessful: Boolean! (scalar)
            if (this.IsSetupSuccessful != null)
            {
                 s += ind + "isSetupSuccessful\n";

            }
            //      C# -> PathNode? SetupSourceObject
            // GraphQL -> setupSourceObject: PathNode! (type)
            if (this.SetupSourceObject != null)
            {
                 s += ind + "setupSourceObject\n";

                 s += ind + "{\n" + 
                 this.SetupSourceObject.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsSetupSuccessful
            // GraphQL -> isSetupSuccessful: Boolean! (scalar)
            if (this.IsSetupSuccessful == null && Exploration.Includes(parent + ".isSetupSuccessful$"))
            {
                this.IsSetupSuccessful = new System.Boolean();
            }
            //      C# -> PathNode? SetupSourceObject
            // GraphQL -> setupSourceObject: PathNode! (type)
            if (this.SetupSourceObject == null && Exploration.Includes(parent + ".setupSourceObject"))
            {
                this.SetupSourceObject = new PathNode();
                this.SetupSourceObject.ApplyExploratoryFragment(parent + ".setupSourceObject");
            }
        }


    #endregion

    } // class CloudNativeDatabaseBackupSetupSpecs
    #endregion

    public static class ListCloudNativeDatabaseBackupSetupSpecsExtensions
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
            this List<CloudNativeDatabaseBackupSetupSpecs> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CloudNativeDatabaseBackupSetupSpecs> list, 
            String parent = "")
        {
            var item = new CloudNativeDatabaseBackupSetupSpecs();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types