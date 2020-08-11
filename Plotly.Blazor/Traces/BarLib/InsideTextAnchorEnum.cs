/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.BarLib
{
    /// <summary>
    ///     Determines if texts are kept at center or start/end points in <c>textposition</c>
    ///     <c>inside</c> mode.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum InsideTextAnchorEnum
    {
        [EnumMember(Value=@"end")]
        End = 0,
        [EnumMember(Value=@"middle")]
        Middle,
        [EnumMember(Value=@"start")]
        Start
    }
}