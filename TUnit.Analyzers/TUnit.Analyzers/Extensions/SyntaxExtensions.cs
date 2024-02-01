﻿using Microsoft.CodeAnalysis;

namespace TUnit.Analyzers.Extensions;

public static class SyntaxExtensions
{
    public static TOutput? GetAncestorSyntaxOfType<TOutput>(this SyntaxNode input) 
        where TOutput : SyntaxNode
    {
        var parent = input.Parent;
        
        while (parent != null && parent is not TOutput)
        {
            parent = parent.Parent;
        }

        return parent as TOutput;
    }
}