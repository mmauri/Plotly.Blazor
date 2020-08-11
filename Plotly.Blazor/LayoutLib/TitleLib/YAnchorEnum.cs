/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.TitleLib
{
    /// <summary>
    ///     Sets the title&#39;s vertical alignment with respect to its y position.
    ///     <c>top</c> means that the title&#39;s cap line is at y, <c>bottom</c> means
    ///     that the title&#39;s baseline is at y and <c>middle</c> means that the title&#39;s
    ///     midline is at y. <c>auto</c> divides <c>yref</c> by three and calculates
    ///     the <c>yanchor</c> value automatically based on the value of <c>y</c>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum YAnchorEnum
    {
        [EnumMember(Value=@"auto")]
        Auto = 0,
        [EnumMember(Value=@"top")]
        Top,
        [EnumMember(Value=@"middle")]
        Middle,
        [EnumMember(Value=@"bottom")]
        Bottom
    }
}