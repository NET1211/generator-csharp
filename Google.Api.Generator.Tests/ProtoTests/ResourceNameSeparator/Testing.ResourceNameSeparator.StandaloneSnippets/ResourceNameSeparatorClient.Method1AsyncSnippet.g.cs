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

namespace Testing.ResourceNameSeparator.Snippets
{
    using System.Threading.Tasks;
    using Testing.ResourceNameSeparator;

    public sealed partial class GeneratedResourceNameSeparatorClientStandaloneSnippets
    {
        /// <summary>Snippet for Method1Async</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task Method1Async()
        {
            // Create client
            ResourceNameSeparatorClient resourceNameSeparatorClient = await ResourceNameSeparatorClient.CreateAsync();
            // Initialize request argument(s)
            string name = "items/[ITEM_A_ID].[ITEM_B_ID]/details/[DETAILS_A_ID]_[DETAILS_B_ID]-[DETAILS_C_ID]/extra/[EXTRA_ID]";
            string @ref = "items/[ITEM_A_ID].[ITEM_B_ID]/details/[DETAILS_A_ID]_[DETAILS_B_ID]-[DETAILS_C_ID]/extra/[EXTRA_ID]";
            // Make the request
            Response response = await resourceNameSeparatorClient.Method1Async(name, @ref);
        }
    }
}
