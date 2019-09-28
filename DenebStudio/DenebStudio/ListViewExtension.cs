using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenebStudio
{
    public static class ListViewExtensions
    {
        // Make the ListView's column headers.
        // The ParamArray entries should alternate between
        // strings and HorizontalAlignment values.
        public static void MakeColumnHeaders(
            this ListView lvw, params object[] header_info)
        {
            // Remove any existing headers.
            lvw.Columns.Clear();

            // Make the column headers.
            for (int i = header_info.GetLowerBound(0);
                     i <= header_info.GetUpperBound(0);
                     i += 3)
            {
                lvw.Columns.Add(
                    (string)header_info[i],
                    (int)header_info[i + 1],
                    (HorizontalAlignment)header_info[i + 2]);
            }
        }

        // Add a row to the ListView.
        public static void AddRow(this ListView lvw, int image_index,
            string item_title, params string[] subitem_titles)
        {
            // Make the item.
            ListViewItem new_item = lvw.Items.Add(item_title, 1);

            // Set the item's image index.
            new_item.ImageIndex = image_index;
            // Make the sub-items.
            for (int i = subitem_titles.GetLowerBound(0);
                     i <= subitem_titles.GetUpperBound(0);
                     i++)
            {
                new_item.SubItems.Add(subitem_titles[i]);
            }
        }
    }
}
