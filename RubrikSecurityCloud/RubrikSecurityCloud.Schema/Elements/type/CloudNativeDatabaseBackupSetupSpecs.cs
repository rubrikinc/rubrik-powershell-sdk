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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region CloudNativeDatabaseBackupSetupSpecs
    public class CloudNativeDatabaseBackupSetupSpecs: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Boolean? IsSetupSuccessful
        // GraphQL -> isSetupSuccessful: Boolean! (scalar)
        if (this.IsSetupSuccessful != null) {
            s += ind + "isSetupSuccessful\n" ;
        }
        //      C# -> PathNode? SetupSourceObject
        // GraphQL -> setupSourceObject: PathNode! (type)
        if (this.SetupSourceObject != null) {
            s += ind + "setupSourceObject {\n" + this.SetupSourceObject.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsSetupSuccessful
        // GraphQL -> isSetupSuccessful: Boolean! (scalar)
        if (this.IsSetupSuccessful == null && Exploration.Includes(parent + ".isSetupSuccessful", true))
        {
            this.IsSetupSuccessful = true;
        }
        //      C# -> PathNode? SetupSourceObject
        // GraphQL -> setupSourceObject: PathNode! (type)
        if (this.SetupSourceObject == null && Exploration.Includes(parent + ".setupSourceObject"))
        {
            this.SetupSourceObject = new PathNode();
            this.SetupSourceObject.ApplyExploratoryFieldSpec(parent + ".setupSourceObject");
        }
    }


    #endregion

    } // class CloudNativeDatabaseBackupSetupSpecs
    
    #endregion

    public static class ListCloudNativeDatabaseBackupSetupSpecsExtensions
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
            this List<CloudNativeDatabaseBackupSetupSpecs> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeDatabaseBackupSetupSpecs> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeDatabaseBackupSetupSpecs());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types