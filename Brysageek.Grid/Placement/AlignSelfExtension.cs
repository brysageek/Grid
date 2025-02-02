namespace Brysageek.Grid.Placement
{
    public static class AlignSelfExtensions
    {
        public static string ToAttributeValue(this AlignSelf alignSelf)
        {
            return alignSelf switch
            {
                AlignSelf.Auto => "auto",
                AlignSelf.Start => "start",
                AlignSelf.End => "end",
                AlignSelf.Center => "center",
                AlignSelf.Stretch => "stretch",
                _ => "auto"
            };
        }
    }
}
