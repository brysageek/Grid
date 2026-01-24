namespace Brysageek.Grid.Placement
{
    public static class JustifySelfExtensions
    {
        public static string ToAttributeValue(this JustifySelf justifySelf)
        {
            return justifySelf switch
            {
                JustifySelf.Auto => "auto",
                JustifySelf.Start => "start",
                JustifySelf.End => "end",
                JustifySelf.Center => "center",
                JustifySelf.Stretch => "stretch",
                _ => "auto"
            };
        }
    }
}
