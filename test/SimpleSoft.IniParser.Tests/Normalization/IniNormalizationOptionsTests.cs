﻿#region License
// The MIT License (MIT)
// 
// Copyright (c) 2017 João Simões
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
#endregion

using SimpleSoft.IniParser.Impl;
using Xunit;

namespace SimpleSoft.IniParser.Tests.Normalization
{
    public class IniNormalizationOptionsTests
    {
        [Fact]
        public void GivenANormalizationOptionsInstanceUsingTheDefaultConstrutorThenIncludeEmptyCommentsMustBeFalse()
        {
            var options = new IniNormalizationOptions();
            Assert.False(options.IncludeEmptyComments);
        }

        [Fact]
        public void GivenANormalizationOptionsInstanceUsingTheDefaultConstrutorThenIncludeEmptySectionsMustBeFalse()
        {
            var options = new IniNormalizationOptions();
            Assert.False(options.IncludeEmptySections);
        }

        [Fact]
        public void GivenANormalizationOptionsInstanceUsingTheDefaultConstrutorThenIncludeEmptyPropertiesMustBeFalse()
        {
            var options = new IniNormalizationOptions();
            Assert.False(options.IncludeEmptyProperties);
        }

        [Fact]
        public void GivenANormalizationOptionsInstanceUsingTheDefaultConstrutorThenIsCaseSensitiveMustBeFalse()
        {
            var options = new IniNormalizationOptions();
            Assert.False(options.IsCaseSensitive);
        }

        [Fact]
        public void GivenANormalizationOptionsInstanceUsingTheDefaultConstrutorThenReplaceOnDuplicatedPropertiesMustBeFalse()
        {
            var options = new IniNormalizationOptions();
            Assert.False(options.ReplaceOnDuplicatedProperties);
        }

        [Fact]
        public void GivenANormalizationOptionsInstanceUsingTheDefaultConstrutorThenMergeOnDuplicatedSectionsMustBeFalse()
        {
            var options = new IniNormalizationOptions();
            Assert.False(options.MergeOnDuplicatedSections);
        }

        [Fact]
        public void GivenANormalizationOptionsInstanceUsingTheDefaultConstrutorThenIgnoreErrorsMustBeFalse()
        {
            var options = new IniNormalizationOptions();
            Assert.True(options.ThrowExceptions);
        }

        [Fact]
        public void GivenANormalizationOptionsInstanceUsingTheDefaultConstrutorThenSortSectionsMustBeNone()
        {
            var options = new IniNormalizationOptions();
            Assert.Equal(IniNormalizationSortType.None, options.SortSections);
        }

        [Fact]
        public void GivenANormalizationOptionsInstanceUsingTheDefaultConstrutorThenSortPropertiesMustBeNone()
        {
            var options = new IniNormalizationOptions();
            Assert.Equal(IniNormalizationSortType.None, options.SortProperties);
        }
    }
}
