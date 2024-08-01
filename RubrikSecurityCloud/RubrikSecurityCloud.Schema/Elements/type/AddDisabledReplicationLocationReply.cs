// AddDisabledReplicationLocationReply.cs
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
    #region AddDisabledReplicationLocationReply
    public class AddDisabledReplicationLocationReply: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> DisabledReplicationLocationDefinition? DisabledReplicationLocationDefinition
        // GraphQL -> disabledReplicationLocationDefinition: DisabledReplicationLocationDefinition (type)
        [JsonProperty("disabledReplicationLocationDefinition")]
        public DisabledReplicationLocationDefinition? DisabledReplicationLocationDefinition { get; set; }

        //      C# -> ReplicationTargetSummary? ReplicationTargetSummary
        // GraphQL -> replicationTargetSummary: ReplicationTargetSummary (type)
        [JsonProperty("replicationTargetSummary")]
        public ReplicationTargetSummary? ReplicationTargetSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AddDisabledReplicationLocationReply";
    }

    public AddDisabledReplicationLocationReply Set(
        System.String? Id = null,
        DisabledReplicationLocationDefinition? DisabledReplicationLocationDefinition = null,
        ReplicationTargetSummary? ReplicationTargetSummary = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( DisabledReplicationLocationDefinition != null ) {
            this.DisabledReplicationLocationDefinition = DisabledReplicationLocationDefinition;
        }
        if ( ReplicationTargetSummary != null ) {
            this.ReplicationTargetSummary = ReplicationTargetSummary;
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> DisabledReplicationLocationDefinition? DisabledReplicationLocationDefinition
        // GraphQL -> disabledReplicationLocationDefinition: DisabledReplicationLocationDefinition (type)
        if (this.DisabledReplicationLocationDefinition != null) {
            var fspec = this.DisabledReplicationLocationDefinition.AsFieldSpec(conf.Child("disabledReplicationLocationDefinition"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "disabledReplicationLocationDefinition" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ReplicationTargetSummary? ReplicationTargetSummary
        // GraphQL -> replicationTargetSummary: ReplicationTargetSummary (type)
        if (this.ReplicationTargetSummary != null) {
            var fspec = this.ReplicationTargetSummary.AsFieldSpec(conf.Child("replicationTargetSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "replicationTargetSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> DisabledReplicationLocationDefinition? DisabledReplicationLocationDefinition
        // GraphQL -> disabledReplicationLocationDefinition: DisabledReplicationLocationDefinition (type)
        if (ec.Includes("disabledReplicationLocationDefinition",false))
        {
            if(this.DisabledReplicationLocationDefinition == null) {

                this.DisabledReplicationLocationDefinition = new DisabledReplicationLocationDefinition();
                this.DisabledReplicationLocationDefinition.ApplyExploratoryFieldSpec(ec.NewChild("disabledReplicationLocationDefinition"));

            } else {

                this.DisabledReplicationLocationDefinition.ApplyExploratoryFieldSpec(ec.NewChild("disabledReplicationLocationDefinition"));

            }
        }
        else if (this.DisabledReplicationLocationDefinition != null && ec.Excludes("disabledReplicationLocationDefinition",false))
        {
            this.DisabledReplicationLocationDefinition = null;
        }
        //      C# -> ReplicationTargetSummary? ReplicationTargetSummary
        // GraphQL -> replicationTargetSummary: ReplicationTargetSummary (type)
        if (ec.Includes("replicationTargetSummary",false))
        {
            if(this.ReplicationTargetSummary == null) {

                this.ReplicationTargetSummary = new ReplicationTargetSummary();
                this.ReplicationTargetSummary.ApplyExploratoryFieldSpec(ec.NewChild("replicationTargetSummary"));

            } else {

                this.ReplicationTargetSummary.ApplyExploratoryFieldSpec(ec.NewChild("replicationTargetSummary"));

            }
        }
        else if (this.ReplicationTargetSummary != null && ec.Excludes("replicationTargetSummary",false))
        {
            this.ReplicationTargetSummary = null;
        }
    }


    #endregion

    } // class AddDisabledReplicationLocationReply
    
    #endregion

    public static class ListAddDisabledReplicationLocationReplyExtensions
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
            this List<AddDisabledReplicationLocationReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AddDisabledReplicationLocationReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AddDisabledReplicationLocationReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AddDisabledReplicationLocationReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AddDisabledReplicationLocationReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types