using System.IO;
using System.Windows.Controls;

namespace UtilityD.Modules
{
    class ListBoxFunction
    {
        public static void ListBoxRefresh(ListBox listBox, string Folder, string FileType)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Folder);
            FileInfo[] files = directoryInfo.GetFiles(FileType);
            foreach (FileInfo fileInfo in files)
            {
                listBox.Items.Clear();
                listBox.Items.Add(fileInfo.Name);
            }
        }
    }
}
