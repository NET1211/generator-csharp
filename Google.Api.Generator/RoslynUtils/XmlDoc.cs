﻿// Copyright 2018 Google Inc. All Rights Reserved.
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

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Google.Api.Generator.RoslynUtils
{
    /// <summary>
    /// Helper methods to assist with creating XmlDoc elements.
    /// </summary>
    internal static class XmlDoc
    {
        private static XmlNodeSyntax ToNode(object o)
        {
            switch (o)
            {
                case string v:
                    return XmlText(v);
                case XmlNodeSyntax v:
                    return v;
                case ClassDeclarationSyntax v:
                    return XmlSeeElement(NameMemberCref(IdentifierName(v.Identifier)));
                case MethodDeclarationSyntax v:
                    return XmlSeeElement(NameMemberCref(IdentifierName(v.Identifier))
                        .WithParameters(CrefParameterList(SeparatedList(v.ParameterList.Parameters.Select(p => CrefParameter(p.Type))))));
                case TypeSyntax v:
                    return XmlSeeElement(NameMemberCref(v));
                case MemberAccessExpressionSyntax v:
                    // Only for enum elements
                    return XmlSeeElement(QualifiedCref((TypeSyntax)v.Expression, NameMemberCref(v.Name)));
                default:
                    throw new NotSupportedException($"Cannot handle ToNode({o.GetType()})");
            }
        }

        private static SyntaxTrivia XmlDocElement<T>(IEnumerable<object> parts, Func<XmlNodeSyntax[], T> fn) where T : XmlNodeSyntax =>
            Trivia(DocumentationComment(fn(parts.Select(ToNode).ToArray())));

        public static SyntaxTrivia Summary(params object[] parts) => XmlDocElement(parts, XmlSummaryElement);
        public static SyntaxTrivia Remarks(params object[] parts) => XmlDocElement(parts, XmlRemarksElement);
        public static SyntaxTrivia Returns(params object[] parts) => XmlDocElement(parts, XmlReturnsElement);

        public static XmlNodeSyntax C(string c) => XmlElement("c", List(new XmlNodeSyntax[] { XmlText(c) }));

        public static XmlNodeSyntax UL(params object[] items) => UL((IEnumerable<object>)items);
        public static XmlNodeSyntax UL<T>(IEnumerable<T> items) => XmlElement(
            XmlElementStartTag(XmlName("list"), List(new XmlAttributeSyntax[] { XmlTextAttribute("type", "bullet") })),
                List<XmlNodeSyntax>(items.Select(item =>
                {
                    var node = ToNode(item);
                    var desc = XmlElement("description", List(new[] { node }));
                    return XmlElement("item", List(new XmlNodeSyntax[] { desc }));
                })),
                XmlElementEndTag(XmlName("list")));
    }
}
