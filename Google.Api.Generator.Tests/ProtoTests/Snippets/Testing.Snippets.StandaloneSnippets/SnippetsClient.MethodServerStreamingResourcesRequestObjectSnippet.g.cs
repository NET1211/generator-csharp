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

namespace Testing.Snippets.Snippets
{
    using Google.Api.Gax.Grpc;
    using System.Threading.Tasks;
    using ts = Testing.Snippets;

    public sealed partial class GeneratedSnippetsClientStandaloneSnippets
    {
        /// <summary>Snippet for MethodServerStreamingResources</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task MethodServerStreamingResourcesRequestObject()
        {
            // Snippet: MethodServerStreamingResources(ResourceSignatureRequest, CallSettings)
            // Create client
            SnippetsClient snippetsClient = SnippetsClient.Create();
            // Initialize request argument(s)
            ResourceSignatureRequest request = new ResourceSignatureRequest
            {
                FirstNameAsSimpleResourceName = SimpleResourceName.FromItem("[ITEM_ID]"),
                SecondNameAsSimpleResourceName = SimpleResourceName.FromItem("[ITEM_ID]"),
                ThirdNameAsSimpleResourceName = SimpleResourceName.FromItem("[ITEM_ID]"),
            };
            // Make the request, returning a streaming response
            SnippetsClient.MethodServerStreamingResourcesStream response = snippetsClient.MethodServerStreamingResources(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<Response> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                Response responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }
    }
}
