using Microsoft.AspNetCore.Components;

namespace Brysageek.Grid
{
    public partial class Grid
    {
        [Parameter] public required RenderFragment ChildContent { get; set; }
        [Parameter] public string Columns { get; set; } = "1fr";
        [Parameter] public string Rows { get; set; } = "1fr";
        [Parameter] public string Width { get; set; } = "100%";
        [Parameter] public string Height { get; set; } = "100%";
        [Parameter] public string Gap { get; set; } = "5px 5px";    
    }
}