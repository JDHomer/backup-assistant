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

        public static string colHeadFileName = "文件名";
        public static string colHeadSize = "文件大小";
        public static string colHeadLastAccess = "修改日期";

        public static string formClosingTitle = "稍等";
        public static string formClosingBody = "同步未完成。如需退出，请按中止结束同步";
        public static string beforeSyncTitle = "再次确认！";
        public static string beforeSyncBodyFormat = "文件即将从\n{0}\n同步至\n{1}\n是否继续？";

        public static string folderBrowserDialogDescription = "请选择文件夹";

        // Form components
        public static string syncAborted = "同步中止";
        public static string syncFinished = "同步完成";
        public static string syncStart = "开始同步";
        public static string logNewFolderFormat = "【新文件夹】 - {0}: {1} -> {2}";
        public static string logNewFileFormat = "【新文件】 - {0}: {1} -> {2}";
        public static string logUpdatedFileFormat = "【更新文件】 - {0}: {1} -> {2}";

        public static string formText = "同步助手";
        public static string buttonBackText = "后退";
        public static string buttonGoUpText = "向上";
        public static string buttonRefreshText = "刷新";
        public static string buttonOpenText = "打开";
        public static string buttonAbortText = "中止";
        public static string buttonClearText = "清除";

        public static string labelFolderAText = "文件夹A：";
        public static string labelFolderBText = "文件夹B：";
        public static string labelScanningText = "正在扫描：";

        public static string groupBoxDetailText = "详细信息";
        public static string groupBoxViewModeText = "显示样式";

        public static string radioButtionLargeIconText = "大图标";
        public static string radioButtionSmallIconText = "小图标";
        public static string radioButtionListText = "列表";
        public static string radioButtionDetailsText = "详细信息";
        public static string radioButtionTileText = "平铺";
    }
}
