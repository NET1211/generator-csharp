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

namespace Testing.Basic.Snippets
{
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedBasicClientSnippets
    {
        /// <summary>Snippet for AMethod</summary>
        public void AMethod_RequestObject()
        {
            // Snippet: AMethod(Request, CallSettings)
            // Create client
            BasicClient basicClient = BasicClient.Create();
            // Initialize request argument(s)
            Request request = new Request { };
            // Make the request
            Response response = basicClient.AMethod(request);
            // End snippet
        }

        /// <summary>Snippet for AMethodAsync</summary>
        public async Task AMethodAsync_RequestObject()
        {
            // Snippet: AMethodAsync(Request, CallSettings)
            // Additional: AMethodAsync(Request, CancellationToken)
            // Create client
            BasicClient basicClient = await BasicClient.CreateAsync();
            // Initialize request argument(s)
            Request request = new Request { };
            // Make the request
            Response response = await basicClient.AMethodAsync(request);
            // End snippet
        }

        /// <summary>Snippet for VoidMethod</summary>
        public void VoidMethod_RequestObject()
        {
            // Snippet: VoidMethod(Request, CallSettings)
            // Create client
            BasicClient basicClient = BasicClient.Create();
            // Initialize request argument(s)
            Request request = new Request { };
            // Make the request
            basicClient.VoidMethod(request);
            // End snippet
        }

        /// <summary>Snippet for VoidMethodAsync</summary>
        public async Task VoidMethodAsync_RequestObject()
        {
            // Snippet: VoidMethodAsync(Request, CallSettings)
            // Additional: VoidMethodAsync(Request, CancellationToken)
            // Create client
            BasicClient basicClient = await BasicClient.CreateAsync();
            // Initialize request argument(s)
            Request request = new Request { };
            // Make the request
            await basicClient.VoidMethodAsync(request);
            // End snippet
        }
    }
}
