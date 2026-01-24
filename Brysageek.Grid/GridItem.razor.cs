using Brysageek.Grid.Placement;
using Microsoft.AspNetCore.Components;

namespace Brysageek.Grid
{
    public partial class GridItem
    {
        [Parameter]
        public required RenderFragment ChildContent { get; set; }

        [Parameter]
        public string? ColumnStart { get; set; } = "1";

        [Parameter]
        public string? ColumnSpan { get; set; } = "1";

        [Parameter]
        public string? RowStart { get; set; } = "1";

        [Parameter]
        public string? RowSpan { get; set; } = "1";

        [Parameter]
        public JustifySelf JustifySelf { get; set; } = 0;

        [Parameter]
        public AlignSelf AlignSelf { get; set; } = 0;
    }
}
