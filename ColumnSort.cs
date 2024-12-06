using System.Collections;
using System.Windows.Forms;

/// <summary>
/// A custom comparer for sorting ListView columns, implementing the 'IComparer' interface.
/// </summary>
public class ListViewColumnSorter : IComparer
{
    /// <summary>
    /// Case-insensitive comparer object used for comparing strings.
    /// </summary>
    private readonly CaseInsensitiveComparer ObjectCompare;

    /// <summary>
    /// Initializes a new instance of the ListViewColumnSorter class and sets default sorting parameters.
    /// </summary>
    public ListViewColumnSorter()
    {
        // Default column index for sorting
        SortColumn = 0;

        // Default sorting order
        Order = SortOrder.Ascending;

        // Initialize the case-insensitive comparer
        ObjectCompare = new CaseInsensitiveComparer();
    }

    /// <summary>
    /// Compares two ListViewItem objects based on the specified column index and sorting order.
    /// </summary>
    /// <param name="x">First ListViewItem object to compare.</param>
    /// <param name="y">Second ListViewItem object to compare.</param>
    /// <returns>
    /// A signed integer indicating the relative values of x and y: 
    /// "0" if equal, a negative number if x is less than y, and a positive number if x is greater than y.
    /// </returns>
    public int Compare(object x, object y)
    {
        int compareResult;
        ListViewItem listviewX = (ListViewItem)x;
        ListViewItem listviewY = (ListViewItem)y;

        // Determine if the column requires numeric comparison
        if (SortColumn == 3 || SortColumn == 5 || SortColumn == 6) // Numeric columns: VersionCodeIndex, VersionNameIndex, DownloadsIndex
        {
            try
            {
                // Parse and compare numeric values directly
                int xNum = ParseNumber(listviewX.SubItems[SortColumn].Text);
                int yNum = ParseNumber(listviewY.SubItems[SortColumn].Text);

                // Compare numerically
                compareResult = xNum.CompareTo(yNum);
            }
            catch
            {
                // Fallback to string comparison if parsing fails
                compareResult = ObjectCompare.Compare(listviewX.SubItems[SortColumn].Text, listviewY.SubItems[SortColumn].Text);
            }
        }
        else
        {
            // Default to string comparison for non-numeric columns
            compareResult = ObjectCompare.Compare(listviewX.SubItems[SortColumn].Text, listviewY.SubItems[SortColumn].Text);
        }

        // Determine the return value based on the specified sort order
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
            return 0; // Indicate equality
        }
    }

    /// <summary>
    /// Parses a numeric value from a string for accurate numeric comparison.
    /// </summary>
    /// <param name="text">The string representation of the number.</param>
    /// <returns>The parsed integer value; returns 0 if parsing fails.</returns>
    private int ParseNumber(string text)
    {
        // Directly attempt to parse the string as an integer
        return int.TryParse(text, out int result) ? result : 0;
    }

    /// <summary>
    /// Gets or sets the index of the column to be sorted (default is '0').
    /// </summary>
    public int SortColumn { get; set; }

    /// <summary>
    /// Gets or sets the order of sorting (Ascending or Descending).
    /// </summary>
    public SortOrder Order { get; set; }
}
