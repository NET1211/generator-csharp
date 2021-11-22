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

namespace Testing.BasicLro.Snippets
{
    // [START lro_generated_BasicLro_Method1_async]
    using Google.LongRunning;
    using System.Threading.Tasks;
    using Testing.BasicLro;

    public sealed partial class GeneratedBasicLroClientStandaloneSnippets
    {
        /// <summary>Snippet for Method1Async</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task Method1RequestObjectAsync()
        {
            // Create client
            BasicLroClient basicLroClient = await BasicLroClient.CreateAsync();
            // Initialize request argument(s)
            Request request = new Request { };
            // Make the request
            Operation<LroResponse, LroMetadata> response = await basicLroClient.Method1Async(request);

            // Poll until the returned long-running operation is complete
            Operation<LroResponse, LroMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            LroResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LroResponse, LroMetadata> retrievedResponse = await basicLroClient.PollOnceMethod1Async(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LroResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END lro_generated_BasicLro_Method1_async]
}
