public class CustomListView : ListView
{
    private string _emptyText = "";
    public string EmptyText
    {
        get { return _emptyText; }
        set { _emptyText = value; Invalidate(); }
    }

    private string _noResultsText = "";
    public string NoResultsText
    {
        get { return _noResultsText; }
        set { _noResultsText = value; Invalidate(); }
    }

    public bool IsSearchResultEmpty { get; set; }

    public CustomListView()
    {
        View = View.Details;
        FullRowSelect = true;
    }

    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);
        if (m.Msg == 0xF)
        {
            if (Items.Count == 0)
                using (var g = Graphics.FromHwnd(Handle))
                {
                    string textToShow = IsSearchResultEmpty ? NoResultsText : EmptyText;
                    TextRenderer.DrawText(g, textToShow, Font, ClientRectangle, ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }
        }
    }
}