// GetPendingSlaAssignmentsReply.cs
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
    #region GetPendingSlaAssignmentsReply
    public class GetPendingSlaAssignmentsReply: BaseType
    {
        #region members

        //      C# -> List<System.String>? InvalidIds
        // GraphQL -> invalidIds: [String!]! (scalar)
        [JsonProperty("invalidIds")]
        public List<System.String>? InvalidIds { get; set; }

        //      C# -> List<ManagedObjectSlaInfo>? ObjectsWithNoOp
        // GraphQL -> objectsWithNoOp: [ManagedObjectSlaInfo!]! (type)
        [JsonProperty("objectsWithNoOp")]
        public List<ManagedObjectSlaInfo>? ObjectsWithNoOp { get; set; }

        //      C# -> List<ManagedObjectPendingSlaInfo>? ObjectsWithPendingOp
        // GraphQL -> objectsWithPendingOp: [ManagedObjectPendingSlaInfo!]! (type)
        [JsonProperty("objectsWithPendingOp")]
        public List<ManagedObjectPendingSlaInfo>? ObjectsWithPendingOp { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetPendingSlaAssignmentsReply";
    }

    public GetPendingSlaAssignmentsReply Set(
        List<System.String>? InvalidIds = null,
        List<ManagedObjectSlaInfo>? ObjectsWithNoOp = null,
        List<ManagedObjectPendingSlaInfo>? ObjectsWithPendingOp = null
    ) 
    {
        if ( InvalidIds != null ) {
            this.InvalidIds = InvalidIds;
        }
        if ( ObjectsWithNoOp != null ) {
            this.ObjectsWithNoOp = ObjectsWithNoOp;
        }
        if ( ObjectsWithPendingOp != null ) {
            this.ObjectsWithPendingOp = ObjectsWithPendingOp;
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
        //      C# -> List<System.String>? InvalidIds
        // GraphQL -> invalidIds: [String!]! (scalar)
        if (this.InvalidIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "invalidIds\n" ;
            } else {
                s += ind + "invalidIds\n" ;
            }
        }
        //      C# -> List<ManagedObjectSlaInfo>? ObjectsWithNoOp
        // GraphQL -> objectsWithNoOp: [ManagedObjectSlaInfo!]! (type)
        if (this.ObjectsWithNoOp != null) {
            var fspec = this.ObjectsWithNoOp.AsFieldSpec(conf.Child("objectsWithNoOp"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objectsWithNoOp" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ManagedObjectPendingSlaInfo>? ObjectsWithPendingOp
        // GraphQL -> objectsWithPendingOp: [ManagedObjectPendingSlaInfo!]! (type)
        if (this.ObjectsWithPendingOp != null) {
            var fspec = this.ObjectsWithPendingOp.AsFieldSpec(conf.Child("objectsWithPendingOp"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objectsWithPendingOp" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? InvalidIds
        // GraphQL -> invalidIds: [String!]! (scalar)
        if (ec.Includes("invalidIds",true))
        {
            if(this.InvalidIds == null) {

                this.InvalidIds = new List<System.String>();

            } else {


            }
        }
        else if (this.InvalidIds != null && ec.Excludes("invalidIds",true))
        {
            this.InvalidIds = null;
        }
        //      C# -> List<ManagedObjectSlaInfo>? ObjectsWithNoOp
        // GraphQL -> objectsWithNoOp: [ManagedObjectSlaInfo!]! (type)
        if (ec.Includes("objectsWithNoOp",false))
        {
            if(this.ObjectsWithNoOp == null) {

                this.ObjectsWithNoOp = new List<ManagedObjectSlaInfo>();
                this.ObjectsWithNoOp.ApplyExploratoryFieldSpec(ec.NewChild("objectsWithNoOp"));

            } else {

                this.ObjectsWithNoOp.ApplyExploratoryFieldSpec(ec.NewChild("objectsWithNoOp"));

            }
        }
        else if (this.ObjectsWithNoOp != null && ec.Excludes("objectsWithNoOp",false))
        {
            this.ObjectsWithNoOp = null;
        }
        //      C# -> List<ManagedObjectPendingSlaInfo>? ObjectsWithPendingOp
        // GraphQL -> objectsWithPendingOp: [ManagedObjectPendingSlaInfo!]! (type)
        if (ec.Includes("objectsWithPendingOp",false))
        {
            if(this.ObjectsWithPendingOp == null) {

                this.ObjectsWithPendingOp = new List<ManagedObjectPendingSlaInfo>();
                this.ObjectsWithPendingOp.ApplyExploratoryFieldSpec(ec.NewChild("objectsWithPendingOp"));

            } else {

                this.ObjectsWithPendingOp.ApplyExploratoryFieldSpec(ec.NewChild("objectsWithPendingOp"));

            }
        }
        else if (this.ObjectsWithPendingOp != null && ec.Excludes("objectsWithPendingOp",false))
        {
            this.ObjectsWithPendingOp = null;
        }
    }


    #endregion

    } // class GetPendingSlaAssignmentsReply
    
    #endregion

    public static class ListGetPendingSlaAssignmentsReplyExtensions
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
            this List<GetPendingSlaAssignmentsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetPendingSlaAssignmentsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetPendingSlaAssignmentsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetPendingSlaAssignmentsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetPendingSlaAssignmentsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types