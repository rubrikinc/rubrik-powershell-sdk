// IsVolumeSnapshotRestorableReply.cs
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
    #region IsVolumeSnapshotRestorableReply
    public class IsVolumeSnapshotRestorableReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsRestorable
        // GraphQL -> isRestorable: Boolean! (scalar)
        [JsonProperty("isRestorable")]
        public System.Boolean? IsRestorable { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IsVolumeSnapshotRestorableReply";
    }

    public IsVolumeSnapshotRestorableReply Set(
        System.Boolean? IsRestorable = null
    ) 
    {
        if ( IsRestorable != null ) {
            this.IsRestorable = IsRestorable;
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
        //      C# -> System.Boolean? IsRestorable
        // GraphQL -> isRestorable: Boolean! (scalar)
        if (this.IsRestorable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRestorable\n" ;
            } else {
                s += ind + "isRestorable\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsRestorable
        // GraphQL -> isRestorable: Boolean! (scalar)
        if (ec.Includes("isRestorable",true))
        {
            if(this.IsRestorable == null) {

                this.IsRestorable = true;

            } else {


            }
        }
        else if (this.IsRestorable != null && ec.Excludes("isRestorable",true))
        {
            this.IsRestorable = null;
        }
    }


    #endregion

    } // class IsVolumeSnapshotRestorableReply
    
    #endregion

    public static class ListIsVolumeSnapshotRestorableReplyExtensions
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
            this List<IsVolumeSnapshotRestorableReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<IsVolumeSnapshotRestorableReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IsVolumeSnapshotRestorableReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IsVolumeSnapshotRestorableReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types