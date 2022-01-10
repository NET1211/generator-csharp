﻿// Copyright 2019 Google LLC
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

// Generated code. DO NOT EDIT!

namespace Testing.ResourceNames.Snippets
{
    // [START unknown_generated_ResourceNames_WildcardOnlyPatternMethod_sync_flattened_resourceNames]
    using Google.Api.Gax;
    using System.Collections.Generic;
    using Testing.ResourceNames;

    public sealed partial class GeneratedResourceNamesClientSnippets
    {
        /// <summary>Snippet for WildcardOnlyPatternMethod</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void WildcardOnlyPatternMethodResourceNames()
        {
            // Create client
            ResourceNamesClient resourceNamesClient = ResourceNamesClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            IResourceName @ref = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<IResourceName> repeatedRef = new IResourceName[]
            {
                new UnparsedResourceName("a/wildcard/resource"),
            };
            IResourceName refSugar = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<IResourceName> repeatedRefSugar = new IResourceName[]
            {
                new UnparsedResourceName("a/wildcard/resource"),
            };
            // Make the request
            Response response = resourceNamesClient.WildcardOnlyPatternMethod(name, @ref, repeatedRef, refSugar, repeatedRefSugar);
        }
    }
    // [END unknown_generated_ResourceNames_WildcardOnlyPatternMethod_sync_flattened_resourceNames]
}