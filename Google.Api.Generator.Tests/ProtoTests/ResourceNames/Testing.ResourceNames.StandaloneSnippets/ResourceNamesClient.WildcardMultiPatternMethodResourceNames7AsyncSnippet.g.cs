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
    using Google.Api.Gax;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public sealed partial class GeneratedResourceNamesClientStandaloneSnippets
    {
        /// <summary>Snippet for WildcardMultiPatternMethodAsync</summary>
        public async Task WildcardMultiPatternMethodResourceNames7Async()
        {
            // Snippet: WildcardMultiPatternMethodAsync(IResourceName, IResourceName, IEnumerable<WildcardMultiPatternName>, CallSettings)
            // Additional: WildcardMultiPatternMethodAsync(IResourceName, IResourceName, IEnumerable<WildcardMultiPatternName>, CancellationToken)
            // Create client
            ResourceNamesClient resourceNamesClient = await ResourceNamesClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            IResourceName @ref = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<WildcardMultiPatternName> repeatedRef = new WildcardMultiPatternName[]
            {
                WildcardMultiPatternName.FromSingularItem(),
            };
            // Make the request
            Response response = await resourceNamesClient.WildcardMultiPatternMethodAsync(name, @ref, repeatedRef);
            // End snippet
        }
    }
}