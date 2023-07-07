using System;
using System.Collections;
using System.Windows.Forms;
using AndroidSideloader;

public class ListViewColumnSorter : IComparer
{
    private readonly CaseInsensitiveComparer ObjectCompare;

    public ListViewColumnSorter()
    {
        SortColumn = 0;
        Order = SortOrder.Ascending;
        ObjectCompare = new CaseInsensitiveComparer();
    }

    public int Compare(object x, object y)
    {
        ListViewItem listviewX, listviewY;

        listviewX = (ListViewItem)x;
        listviewY = (ListViewItem)y;

        // Validate SortColumn
        int maxIndex = Math.Min(listviewX.SubItems.Count, listviewY.SubItems.Count) - 1;
        if (SortColumn > maxIndex)
        {
            SortColumn = maxIndex;
        }

        if (SortColumn == 5)
        {
            try
            {
                int yNum = int.Parse(cleanNumber(listviewY.SubItems[SortColumn].Text));
                int xNum = int.Parse(cleanNumber(listviewX.SubItems[SortColumn].Text));
                return xNum == yNum ? 0 : xNum > yNum && Order == SortOrder.Ascending ? -1 : 1;
            }
            catch (Exception e)
            {
                _ = Logger.Log(e.Message);
                _ = Logger.Log(e.StackTrace);
            }
        }

        int compareResult = ObjectCompare.Compare(listviewX.SubItems[SortColumn].Text, listviewY.SubItems[SortColumn].Text);

        if (Order == SortOrder.Ascending)
        {
            return compareResult;
        }
        else if (Order == SortOrder.Descending)
        {
            return -compareResult;
        }
        else
        {
            return 0;
        }
    }

    public int SortColumn { set; get; }
    public SortOrder Order { set; get; }

    private string cleanNumber(string number)
    {
        return number.Substring(0); // Consider cleaning up the non-numeric characters
    }
}