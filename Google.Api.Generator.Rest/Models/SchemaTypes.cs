﻿// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Generator.Utils;
using Google.Apis.Discovery.v1.Data;
using Google.Apis.Util;
using System;
using System.Collections.Generic;

namespace Google.Api.Generator.Rest.Models
{
    internal static class SchemaTypes
    {
        private static readonly IDictionary<(string, string), Type> s_schemaTypeAndFormatToType =
            new Dictionary<(string, string), Type>()
            {
                { ("any", null), typeof(object) },
                { ("boolean", null), typeof(bool) },
                { ("integer", null), typeof(int) },
                { ("number", null), typeof(double) },
                { ("integer", "int16"), typeof(short) },
                { ("integer", "int32"), typeof(int) },
                { ("integer", "uint32"), typeof(long) },
                { ("number", "double"), typeof(double) },
                { ("number", "float"), typeof(float) },
                { ("string", null), typeof(string) },
                { ("string", "byte"), typeof(string) },
                { ("string", "date"), typeof(string) },
                { ("string", "date-time"), typeof(DateTime) },
                { ("string", "int64"), typeof(long) },
                { ("string", "uint64"), typeof(ulong) },
                { ("object", null), typeof(object) },
            };

        internal static Typ GetTypFromSchema(PackageModel package, JsonSchema schema, string name, Typ currentTyp)
        {
            // TODO: Additional properties, becoming a dictionary.
            if (schema.Repeated ?? false)
            {
                return Typ.Of<Repeatable<string>>();
            }
            if (schema.Ref__ is object)
            {
                return package.GetDataModelByReference(schema.Ref__).Typ;
            }
            else if (schema.Type == "array")
            {
                Typ elementType = GetTypFromSchema(package, schema.Items, name, currentTyp);
                return Typ.Generic(typeof(IList<>), elementType);
            }
            else if (schema.Properties is object)
            {
                // Anonymous schema embedded in the current type.
                return Typ.Nested(currentTyp, name.ToUpperCamelCase() + "Data");
            }
            if (schema.Enum__ is object)
            {
                Typ enumTyp = Typ.Nested(currentTyp, name.ToUpperCamelCase() + "Enum", isEnum: true);
                return (schema.Required ?? false) ? enumTyp : Typ.Generic(Typ.Of(typeof(Nullable<>)), enumTyp);
            }
            else if (schema.Type is object)
            {
                return GetSimpleTypeFromTypeAndFormat(schema.Type, schema.Format, schema.Required ?? false);
            }
            else
            {
                throw new ArgumentException($"Unhandled data model for {name}");
            }
        }

        private static Typ GetSimpleTypeFromTypeAndFormat(string schemaType, string schemaFormat, bool isRequired)
        {
            // Note: we return a Typ rather than a Type as this way we end up with Nullable<bool> etc instead of bool?
            Type requiredType = s_schemaTypeAndFormatToType[(schemaType, schemaFormat)];
            Typ requiredTyp = Typ.Of(requiredType);
            return !isRequired && requiredType.IsValueType
                ? Typ.Generic(Typ.Of(typeof(Nullable<>)), requiredTyp)
                : requiredTyp;
        }
    }
}
