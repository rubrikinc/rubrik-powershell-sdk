using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace RubrikSecurityCloud.Types
{
    public abstract class BaseType : IFieldSpec
    {
        // pointer to next object in chain.
        // Used for building up a chain of objects
        // to represent a "composite field spec".
        internal BaseType? _next = null;

        // IFieldSpec interface:
        public abstract string AsFieldSpec(int indent = 0);
        public abstract void ApplyExploratoryFieldSpec(string parent = "");

        // Returns the name of the type as it would appear in a GraphQL schema.
        // Should be overridden if the GraphQL type name is different from 
        // the C# class name.
        public virtual string GetGqlTypeName()
        {
            return this.GetType().Name;
        }
    }

    public static class ListBaseTypeExtensions
    {
        public static string AsFieldSpec(this List<BaseType> list,
                                         int indent = 0)
        {
            string ind = new string(' ', indent*2);
            StringBuilder sb = new StringBuilder();
            foreach (BaseType item in list)
            {
                sb.Append(ind + " ... on " + item.GetType().Name + " {\n" + item.AsFieldSpec(indent+1) + ind + "}\n");
            }
            return sb.ToString();
        }

        public static void ApplyExploratoryFieldSpec(this List<BaseType> list,
                                                     string parent = "")
        {
            foreach (BaseType item in list)
            {
                item.ApplyExploratoryFieldSpec(parent);
            }
        }
    }
}
