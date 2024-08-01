// PostgreSqlDbClusterStatus.cs
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
    #region PostgreSqlDbClusterStatus
    public class PostgreSqlDbClusterStatus: BaseType
    {
        #region members

        //      C# -> EntityStatus? Status
        // GraphQL -> status: EntityStatus! (enum)
        [JsonProperty("status")]
        public EntityStatus? Status { get; set; }

        //      C# -> List<KosmosUserMessage>? StatusMessages
        // GraphQL -> statusMessages: [KosmosUserMessage!]! (type)
        [JsonProperty("statusMessages")]
        public List<KosmosUserMessage>? StatusMessages { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PostgreSQLDbClusterStatus";
    }

    public PostgreSqlDbClusterStatus Set(
        EntityStatus? Status = null,
        List<KosmosUserMessage>? StatusMessages = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( StatusMessages != null ) {
            this.StatusMessages = StatusMessages;
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
        //      C# -> EntityStatus? Status
        // GraphQL -> status: EntityStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> List<KosmosUserMessage>? StatusMessages
        // GraphQL -> statusMessages: [KosmosUserMessage!]! (type)
        if (this.StatusMessages != null) {
            var fspec = this.StatusMessages.AsFieldSpec(conf.Child("statusMessages"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "statusMessages" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> EntityStatus? Status
        // GraphQL -> status: EntityStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new EntityStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> List<KosmosUserMessage>? StatusMessages
        // GraphQL -> statusMessages: [KosmosUserMessage!]! (type)
        if (ec.Includes("statusMessages",false))
        {
            if(this.StatusMessages == null) {

                this.StatusMessages = new List<KosmosUserMessage>();
                this.StatusMessages.ApplyExploratoryFieldSpec(ec.NewChild("statusMessages"));

            } else {

                this.StatusMessages.ApplyExploratoryFieldSpec(ec.NewChild("statusMessages"));

            }
        }
        else if (this.StatusMessages != null && ec.Excludes("statusMessages",false))
        {
            this.StatusMessages = null;
        }
    }


    #endregion

    } // class PostgreSqlDbClusterStatus
    
    #endregion

    public static class ListPostgreSqlDbClusterStatusExtensions
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
            this List<PostgreSqlDbClusterStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PostgreSqlDbClusterStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PostgreSqlDbClusterStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PostgreSqlDbClusterStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PostgreSqlDbClusterStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types