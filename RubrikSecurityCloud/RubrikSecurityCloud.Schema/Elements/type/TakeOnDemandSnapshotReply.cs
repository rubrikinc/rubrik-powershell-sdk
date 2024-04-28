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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<TakeOnDemandSnapshotError>? Errors
        // GraphQL -> errors: [TakeOnDemandSnapshotError!]! (type)
        if (this.Errors != null) {
            var fspec = this.Errors.AsFieldSpec(conf.Child("errors"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "errors" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TakeOnDemandSnapshotTaskchainUuid>? TaskchainUuids
        // GraphQL -> taskchainUuids: [TakeOnDemandSnapshotTaskchainUuid!]! (type)
        if (this.TaskchainUuids != null) {
            var fspec = this.TaskchainUuids.AsFieldSpec(conf.Child("taskchainUuids"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "taskchainUuids" + " " + "{\n" + fspec + ind + "}\n" ;
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
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<TakeOnDemandSnapshotReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TakeOnDemandSnapshotReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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