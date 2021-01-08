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

namespace Testing.Keywords.Snippets
{
    public sealed partial class GeneratedKeywordsClientStandaloneSnippets
    {
        /// <summary>Snippet for Method1</summary>
        public void Method1()
        {
            // Snippet: Method1(string, int, Enum, string, string, CallSettings)
            // Create client
            KeywordsClient keywordsClient = KeywordsClient.Create();
            // Initialize request argument(s)
            string @event = "items/[ITEM_ID]";
            int @switch = 0;
            Enum @void = Enum.Void;
            string request = "";
            string types = "";
            // Make the request
            Response response = keywordsClient.Method1(@event, @switch, @void, request, types);
            // End snippet
        }
    }
}