// ValidateCloudNativeFileRecoveryFeasibilityReply.cs
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
    #region ValidateCloudNativeFileRecoveryFeasibilityReply
    public class ValidateCloudNativeFileRecoveryFeasibilityReply: BaseType
    {
        #region members

        //      C# -> List<CloudNativeFileRecoveryFeasibility>? SnapshotFileRecoveryFeasibility
        // GraphQL -> snapshotFileRecoveryFeasibility: [CloudNativeFileRecoveryFeasibility!]! (type)
        [JsonProperty("snapshotFileRecoveryFeasibility")]
        public List<CloudNativeFileRecoveryFeasibility>? SnapshotFileRecoveryFeasibility { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ValidateCloudNativeFileRecoveryFeasibilityReply";
    }

    public ValidateCloudNativeFileRecoveryFeasibilityReply Set(
        List<CloudNativeFileRecoveryFeasibility>? SnapshotFileRecoveryFeasibility = null
    ) 
    {
        if ( SnapshotFileRecoveryFeasibility != null ) {
            this.SnapshotFileRecoveryFeasibility = SnapshotFileRecoveryFeasibility;
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
        //      C# -> List<CloudNativeFileRecoveryFeasibility>? SnapshotFileRecoveryFeasibility
        // GraphQL -> snapshotFileRecoveryFeasibility: [CloudNativeFileRecoveryFeasibility!]! (type)
        if (this.SnapshotFileRecoveryFeasibility != null) {
            var fspec = this.SnapshotFileRecoveryFeasibility.AsFieldSpec(conf.Child("snapshotFileRecoveryFeasibility"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotFileRecoveryFeasibility {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<CloudNativeFileRecoveryFeasibility>? SnapshotFileRecoveryFeasibility
        // GraphQL -> snapshotFileRecoveryFeasibility: [CloudNativeFileRecoveryFeasibility!]! (type)
        if (ec.Includes("snapshotFileRecoveryFeasibility",false))
        {
            if(this.SnapshotFileRecoveryFeasibility == null) {

                this.SnapshotFileRecoveryFeasibility = new List<CloudNativeFileRecoveryFeasibility>();
                this.SnapshotFileRecoveryFeasibility.ApplyExploratoryFieldSpec(ec.NewChild("snapshotFileRecoveryFeasibility"));

            } else {

                this.SnapshotFileRecoveryFeasibility.ApplyExploratoryFieldSpec(ec.NewChild("snapshotFileRecoveryFeasibility"));

            }
        }
        else if (this.SnapshotFileRecoveryFeasibility != null && ec.Excludes("snapshotFileRecoveryFeasibility",false))
        {
            this.SnapshotFileRecoveryFeasibility = null;
        }
    }


    #endregion

    } // class ValidateCloudNativeFileRecoveryFeasibilityReply
    
    #endregion

    public static class ListValidateCloudNativeFileRecoveryFeasibilityReplyExtensions
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
            this List<ValidateCloudNativeFileRecoveryFeasibilityReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ValidateCloudNativeFileRecoveryFeasibilityReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ValidateCloudNativeFileRecoveryFeasibilityReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ValidateCloudNativeFileRecoveryFeasibilityReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types