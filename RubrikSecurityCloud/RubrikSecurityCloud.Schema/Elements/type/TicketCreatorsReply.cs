// TicketCreatorsReply.cs
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
    #region TicketCreatorsReply
    public class TicketCreatorsReply: BaseType
    {
        #region members

        //      C# -> List<System.String>? AllUserEmail
        // GraphQL -> allUserEmail: [String!]! (scalar)
        [JsonProperty("allUserEmail")]
        public List<System.String>? AllUserEmail { get; set; }

        //      C# -> System.Boolean? HasNext
        // GraphQL -> hasNext: Boolean! (scalar)
        [JsonProperty("hasNext")]
        public System.Boolean? HasNext { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TicketCreatorsReply";
    }

    public TicketCreatorsReply Set(
        List<System.String>? AllUserEmail = null,
        System.Boolean? HasNext = null
    ) 
    {
        if ( AllUserEmail != null ) {
            this.AllUserEmail = AllUserEmail;
        }
        if ( HasNext != null ) {
            this.HasNext = HasNext;
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
        //      C# -> List<System.String>? AllUserEmail
        // GraphQL -> allUserEmail: [String!]! (scalar)
        if (this.AllUserEmail != null) {
            if (conf.Flat) {
                s += conf.Prefix + "allUserEmail\n" ;
            } else {
                s += ind + "allUserEmail\n" ;
            }
        }
        //      C# -> System.Boolean? HasNext
        // GraphQL -> hasNext: Boolean! (scalar)
        if (this.HasNext != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasNext\n" ;
            } else {
                s += ind + "hasNext\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? AllUserEmail
        // GraphQL -> allUserEmail: [String!]! (scalar)
        if (ec.Includes("allUserEmail",true))
        {
            if(this.AllUserEmail == null) {

                this.AllUserEmail = new List<System.String>();

            } else {


            }
        }
        else if (this.AllUserEmail != null && ec.Excludes("allUserEmail",true))
        {
            this.AllUserEmail = null;
        }
        //      C# -> System.Boolean? HasNext
        // GraphQL -> hasNext: Boolean! (scalar)
        if (ec.Includes("hasNext",true))
        {
            if(this.HasNext == null) {

                this.HasNext = true;

            } else {


            }
        }
        else if (this.HasNext != null && ec.Excludes("hasNext",true))
        {
            this.HasNext = null;
        }
    }


    #endregion

    } // class TicketCreatorsReply
    
    #endregion

    public static class ListTicketCreatorsReplyExtensions
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
            this List<TicketCreatorsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TicketCreatorsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TicketCreatorsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TicketCreatorsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TicketCreatorsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types