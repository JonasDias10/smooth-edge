using SmoothEdge.WindowManagement;

namespace SmoothEdge.Views
{
    public partial class Home : Form
    {
        private List<IntPtr> windows = [];

        public Home()
        {
            InitializeComponent();
            StartHome();
        }

        private void StartHome()
        {
            LoadWindows();
            AddWrapTextListBox(ListBoxWindows);
            AddWrapTextListBox(ListBoxAddedWindows);
        }

        private void LoadWindows()
        {
            windows.Clear();
            ListBoxWindows.Items.Clear();
            ListBoxAddedWindows.Items.Clear();

            windows = WindowManager.GetOpenWindows();
            foreach (IntPtr window in windows)
            {
                var title = WindowManager.GetWindowTitle(window);
                var processId = WindowManager.GetWindowProcessId(window);

                ListBoxWindows.Items.Add($"{title} ({processId})");
            }
        }
        private static uint ExtractProcessId(string value)
        {
            var firstIndex = value.IndexOf('(');
            var lastIndex = value.IndexOf(')');

            if (firstIndex == -1 || lastIndex == -1) return 0;

            var precessIdLength = lastIndex - firstIndex - 1;

            if (uint.TryParse(value.AsSpan(firstIndex + 1, precessIdLength), out var processId))
            {
                return processId;
            }

            return 0;
        }

        private void BtnAddWindow_Click(object sender, EventArgs e)
        {
            var index = ListBoxWindows.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("Select a window first.", "Error Adding Window", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MoveItemFromListBox(ListBoxWindows, ListBoxAddedWindows, index);
        }

        private void BtnRemoveWindow_Click(object sender, EventArgs e)
        {
            var index = ListBoxAddedWindows.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("Select a window first.", "Error Removing Window", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MoveItemFromListBox(ListBoxAddedWindows, ListBoxWindows, index);
        }

        private static void MoveItemFromListBox(ListBox from, ListBox to, int index)
        {
            var item = from.Items[index];
            from.Items.RemoveAt(index);
            to.Items.Add(item);
        }

        private void BtnReloadWindows_Click(object sender, EventArgs e)
        {
            LoadWindows();
        }

        private void BtnRemoveBorder_Click(object sender, EventArgs e)
        {
            var addedItems = ListBoxAddedWindows.Items.OfType<string>().ToList();

            if (addedItems.Count == 0)
            {
                MessageBox.Show("It must be one or more windows to remove the border.", "Error Removing Border", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var processIds = addedItems.Select(x => ExtractProcessId(x)).ToList();

            var windowsToModify = windows.Where(window => processIds.Contains(WindowManager.GetWindowProcessId(window))).ToList();

            windowsToModify.ForEach(wnd => WindowManager.RemoveWindowBorder(wnd));
        }


        private void AddWrapTextListBox(ListBox listBox)
        {
            listBox.DrawMode = DrawMode.OwnerDrawVariable;

            listBox.MeasureItem += (sender, e) => {
                if (e.Index >= 0 && e.Index < listBox.Items.Count)
                {
                    var text = listBox.Items[e.Index].ToString();
                    
                    if (string.IsNullOrWhiteSpace(text)) return;
                        
                    SizeF size = e.Graphics.MeasureString(text, listBox.Font, listBox.Width);
                    e.ItemHeight = (int)size.Height;
                }
            };
            
            listBox.DrawItem += (sender, e) => {
                if (e.Index >= 0 && e.Index < listBox.Items.Count)
                {
                    e.DrawBackground();

                    var text = listBox.Items[e.Index].ToString();
                    
                    if (string.IsNullOrWhiteSpace(text)) return;

                    using (Brush brush = new SolidBrush(e.ForeColor))
                    {
                        e.Graphics.DrawString(text, this.Font, brush, e.Bounds);
                    }
                    e.DrawFocusRectangle();
                }
            };
        }
    }
}
