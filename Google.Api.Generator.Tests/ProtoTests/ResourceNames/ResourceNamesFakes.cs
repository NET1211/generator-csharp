﻿// Copyright 2019 Google Inc. All Rights Reserved.
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

using Google.Protobuf.Collections;

namespace Testing.Resourcenames
{
    public partial class SimpleResource : ProtoMsgFake<SimpleResource>
    {
        public string Name { get; set; }
    }

    public partial class SimpleInlineResource : ProtoMsgFake<SimpleInlineResource>
    {
        public string Name { get; set; }
    }

    public partial class SimpleRepeatedResource : ProtoMsgFake<SimpleRepeatedResource>
    {
        public RepeatedField<string> Names { get; }
    }

    public partial class WildcardResource : ProtoMsgFake<WildcardResource>
    {
        public string Name { get; set; }
        public RepeatedField<string> Names { get; }
        public string RequiredSingle { get; set; }
        public RepeatedField<string> RequiredRepeated { get; set; }
    }

    public partial class MultiCaseRequest : ProtoMsgFake<MultiCaseRequest>
    {
        public string OptionalSingle { get; set; }
        public RepeatedField<string> OptionalRepeated { get; }
        public string RequiredSingle { get; set; }
        public RepeatedField<string> RequiredRepeated { get; }
    }

    public class Response : ProtoMsgFake<Response> { }
}
