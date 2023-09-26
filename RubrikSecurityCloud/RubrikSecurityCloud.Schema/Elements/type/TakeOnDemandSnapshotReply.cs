// TakeOnDemandSnapshotReply.cs
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
    #region TakeOnDemandSnapshotReply
    public class TakeOnDemandSnapshotReply: BaseType
    {
        #region members

        //      C# -> List<TakeOnDemandSnapshotError>? Errors
        // GraphQL -> errors: [TakeOnDemandSnapshotError!]! (type)
        [JsonProperty("errors")]
        public List<TakeOnDemandSnapshotError>? Errors { get; set; }

        //      C# -> List<TakeOnDemandSnapshotTaskchainUuid>? TaskchainUuids
        // GraphQL -> taskchainUuids: [TakeOnDemandSnapshotTaskchainUuid!]! (type)
        [JsonProperty("taskchainUuids")]
        public List<TakeOnDemandSnapshotTaskchainUuid>? TaskchainUuids { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TakeOnDemandSnapshotReply";
    }

    public TakeOnDemandSnapshotReply Set(
        List<TakeOnDemandSnapshotError>? Errors = null,
        List<TakeOnDemandSnapshotTaskchainUuid>? TaskchainUuids = null
    ) 
    {
        if ( Errors != null ) {
            this.Errors = Errors;
        }
        if ( TaskchainUuids != null ) {
            this.TaskchainUuids = TaskchainUuids;
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
        //      C# -> List<TakeOnDemandSnapshotError>? Errors
        // GraphQL -> errors: [TakeOnDemandSnapshotError!]! (type)
        if (this.Errors != null) {
            var fspec = this.Errors.AsFieldSpec(conf.Child("errors"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "errors {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TakeOnDemandSnapshotTaskchainUuid>? TaskchainUuids
        // GraphQL -> taskchainUuids: [TakeOnDemandSnapshotTaskchainUuid!]! (type)
        if (this.TaskchainUuids != null) {
            var fspec = this.TaskchainUuids.AsFieldSpec(conf.Child("taskchainUuids"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "taskchainUuids {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<TakeOnDemandSnapshotError>? Errors
        // GraphQL -> errors: [TakeOnDemandSnapshotError!]! (type)
        if (ec.Includes("errors",false))
        {
            if(this.Errors == null) {

                this.Errors = new List<TakeOnDemandSnapshotError>();
                this.Errors.ApplyExploratoryFieldSpec(ec.NewChild("errors"));

            } else {

                this.Errors.ApplyExploratoryFieldSpec(ec.NewChild("errors"));

            }
        }
        else if (this.Errors != null && ec.Excludes("errors",false))
        {
            this.Errors = null;
        }
        //      C# -> List<TakeOnDemandSnapshotTaskchainUuid>? TaskchainUuids
        // GraphQL -> taskchainUuids: [TakeOnDemandSnapshotTaskchainUuid!]! (type)
        if (ec.Includes("taskchainUuids",false))
        {
            if(this.TaskchainUuids == null) {

                this.TaskchainUuids = new List<TakeOnDemandSnapshotTaskchainUuid>();
                this.TaskchainUuids.ApplyExploratoryFieldSpec(ec.NewChild("taskchainUuids"));

            } else {

                this.TaskchainUuids.ApplyExploratoryFieldSpec(ec.NewChild("taskchainUuids"));

            }
        }
        else if (this.TaskchainUuids != null && ec.Excludes("taskchainUuids",false))
        {
            this.TaskchainUuids = null;
        }
    }


    #endregion

    } // class TakeOnDemandSnapshotReply
    
    #endregion

    public static class ListTakeOnDemandSnapshotReplyExtensions
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
            this List<TakeOnDemandSnapshotReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TakeOnDemandSnapshotReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TakeOnDemandSnapshotReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TakeOnDemandSnapshotReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types