// Copyright 2020 Google Inc. All Rights Reserved.
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

using System;
using Xunit;

namespace Testing.ResourceNames
{
    public class ManualTests
    {
        [Fact]
        public void ParseNoSuffix()
        {
            Assert.Equal("a", WildcardMultiPatternMultipleName.Parse("itemsA/a").ItemAId);
            Assert.Throws<ArgumentException>(() => WildcardMultiPatternMultipleName.Parse("itemsA/a/a"));
        }

        [Fact]
        public void ParseSingleStarSuffix()
        {
            Assert.Equal("b", WildcardMultiPatternMultipleName.Parse("itemsB/b").ItemBId);
            Assert.Throws<ArgumentException>(() => WildcardMultiPatternMultipleName.Parse("itemsB/b/b"));
        }

        [Fact]
        public void ParseDoubleStarSuffix()
        {
            Assert.Equal("c", WildcardMultiPatternMultipleName.Parse("itemsC/c").ItemCId);
            Assert.Equal("c/c", WildcardMultiPatternMultipleName.Parse("itemsC/c/c").ItemCId);
        }
    }
}
