﻿#region License
// The MIT License (MIT)
// 
// Copyright (c) 2016 João Simões
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
namespace SimpleSoft.IniParser.Impl
{
    /// <summary>
    /// INI deserialization options
    /// </summary>
    public class IniDeserializationOptions
    {
        /// <summary>
        /// Default options instance.
        /// </summary>
        public static readonly IniDeserializationOptions Default = new IniDeserializationOptions();

        /// <summary>
        /// Should the <see cref="IniContainer"/> be normalized after deserialization?
        /// Defaults to <value>true</value>.
        /// </summary>
        public bool NormalizeAfterDeserialization { get; set; } = true;

        /// <summary>
        /// The character used to represent comments. Defaults to <value>';'</value>.
        /// </summary>
        public char CommentIndicator { get; set; } = ';';

        /// <summary>
        /// The character used delimit name/value properties. Defaults to <value>'='</value>.
        /// </summary>
        public char PropertyNameValueDelimiter { get; set; } = '=';

        /// <summary>
        /// Ignore invalid lines? Defaults to <value>true</value>.
        /// </summary>
        public bool FailOnInvalidLines { get; set; } = true;
    }
}