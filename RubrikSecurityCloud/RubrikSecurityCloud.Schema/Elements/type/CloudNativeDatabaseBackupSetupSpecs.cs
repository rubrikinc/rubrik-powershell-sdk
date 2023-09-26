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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "CloudNativeDatabaseBackupSetupSpecs";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? IsSetupSuccessful
        // GraphQL -> isSetupSuccessful: Boolean! (scalar)
        if (this.IsSetupSuccessful != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSetupSuccessful\n" ;
            } else {
                s += ind + "isSetupSuccessful\n" ;
            }
        }
        //      C# -> PathNode? SetupSourceObject
        // GraphQL -> setupSourceObject: PathNode! (type)
        if (this.SetupSourceObject != null) {
            var fspec = this.SetupSourceObject.AsFieldSpec(conf.Child("setupSourceObject"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "setupSourceObject {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsSetupSuccessful
        // GraphQL -> isSetupSuccessful: Boolean! (scalar)
        if (ec.Includes("isSetupSuccessful",true))
        {
            if(this.IsSetupSuccessful == null) {

                this.IsSetupSuccessful = true;

            } else {


            }
        }
        else if (this.IsSetupSuccessful != null && ec.Excludes("isSetupSuccessful",true))
        {
            this.IsSetupSuccessful = null;
        }
        //      C# -> PathNode? SetupSourceObject
        // GraphQL -> setupSourceObject: PathNode! (type)
        if (ec.Includes("setupSourceObject",false))
        {
            if(this.SetupSourceObject == null) {

                this.SetupSourceObject = new PathNode();
                this.SetupSourceObject.ApplyExploratoryFieldSpec(ec.NewChild("setupSourceObject"));

            } else {

                this.SetupSourceObject.ApplyExploratoryFieldSpec(ec.NewChild("setupSourceObject"));

            }
        }
        else if (this.SetupSourceObject != null && ec.Excludes("setupSourceObject",false))
        {
            this.SetupSourceObject = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeDatabaseBackupSetupSpecs> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeDatabaseBackupSetupSpecs());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudNativeDatabaseBackupSetupSpecs> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types