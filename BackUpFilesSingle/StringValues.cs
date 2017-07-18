using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackUpFilesSingle
{
    class StringValues
    {
        // Runtime
        public static string empty = "";

        public static string colHeadFileName = "Filename";
        public static string colHeadSize = "Size";
        public static string colHeadLastAccess = "Last accessed";

        public static string formClosingTitle = "Warning";
        public static string formClosingBody = "Please wait until the sync finished or abort it.";
        public static string beforeSyncTitle = "PLEASE CONFIRM!";
        public static string beforeSyncBodyFormat = "Files will be synced from\n{0}\nto\n{1}\nChoose Yes to proceed.";

        public static string folderBrowserDialogDescription = "Select a folder.";

        // Form components
        public static string syncAborted = "Aborted";
        public static string syncFinished = "Finished";
        public static string syncStart = "Begin synchronization";
        public static string logNewFolderFormat = "[New Folder] - {0}: {1} -> {2}";
        public static string logNewFileFormat = "[New File] - {0}: {1} -> {2}";
        public static string logUpdatedFileFormat = "[Updated File] - {0}: {1} -> {2}";

        public static string formText = "Backup Assitant";
        public static string buttonBackText = "Back";
        public static string buttonGoUpText = "Go Up";
        public static string buttonRefreshText = "Refresh";
        public static string buttonOpenText = "Open";
        public static string buttonAbortText = "Abort";
        public static string buttonClearText = "Clear";

        public static string labelFolderAText = "Folder A:";
        public static string labelFolderBText = "Folder B:";
        public static string labelScanningText = "Scanning:";

        public static string groupBoxDetailText = "Detail";
        public static string groupBoxViewModeText = "View Mode";

        public static string radioButtionLargeIconText = "Large Icon";
        public static string radioButtionSmallIconText = "Small Icon";
        public static string radioButtionListText = "List";
        public static string radioButtionDetailsText = "Details";
        public static string radioButtionTileText = "Tile";
    }
}
