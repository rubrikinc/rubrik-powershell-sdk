// AuthorizedOps.cs
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
    #region AuthorizedOps
    public class AuthorizedOps: BaseType
    {
        #region members

        //      C# -> List<AuthorizedOperation>? Operations
        // GraphQL -> operations: [AuthorizedOperation!]! (enum)
        [JsonProperty("operations")]
        public List<AuthorizedOperation>? Operations { get; set; }

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: UUID! (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AuthorizedOps";
    }

    public AuthorizedOps Set(
        List<AuthorizedOperation>? Operations = null,
        System.String? ObjectId = null
    ) 
    {
        if ( Operations != null ) {
            this.Operations = Operations;
        }
        if ( ObjectId != null ) {
            this.ObjectId = ObjectId;
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
        //      C# -> List<AuthorizedOperation>? Operations
        // GraphQL -> operations: [AuthorizedOperation!]! (enum)
        if (this.Operations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "operations\n" ;
            } else {
                s += ind + "operations\n" ;
            }
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: UUID! (scalar)
        if (this.ObjectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectId\n" ;
            } else {
                s += ind + "objectId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AuthorizedOperation>? Operations
        // GraphQL -> operations: [AuthorizedOperation!]! (enum)
        if (ec.Includes("operations",true))
        {
            if(this.Operations == null) {

                this.Operations = new List<AuthorizedOperation>();

            } else {


            }
        }
        else if (this.Operations != null && ec.Excludes("operations",true))
        {
            this.Operations = null;
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: UUID! (scalar)
        if (ec.Includes("objectId",true))
        {
            if(this.ObjectId == null) {

                this.ObjectId = "FETCH";

            } else {


            }
        }
        else if (this.ObjectId != null && ec.Excludes("objectId",true))
        {
            this.ObjectId = null;
        }
    }


    #endregion

    } // class AuthorizedOps
    
    #endregion

    public static class ListAuthorizedOpsExtensions
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
            this List<AuthorizedOps> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AuthorizedOps> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AuthorizedOps> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AuthorizedOps());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AuthorizedOps> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types