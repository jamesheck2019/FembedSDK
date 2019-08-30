using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using FembedSDK.JSON;

namespace FembedSDK
{
	public interface IClient
	{
		Task<JSON_UserInfo> ComplaintsList();

		Task<JSON_UserInfo> UserInfo();

		Task<JSON_CompleteUpload> UploadLocalFile(object FileToUP, FClient.UploadTypes TheUpType, string DestinationFolderID, string Filename = null, IProgress<ReportStatus> ReportCls = null, ProxyConfig _proxi = null, CancellationToken token = default(CancellationToken));

		Task<JSON_YoutubeRemoteUpload> YoutubeRemoteUpload(List<string> FilesUrls);

		Task<JSON_YoutubeRemoteUpload> RemoteUpload(List<string> FilesUrls);

		Task<JSON_GetDirectUrl> GetDirectUrl(string VideoUrl);

		Task DownloadFile(string FileUrl, string FileSaveDir, string FileName, IProgress<ReportStatus> ReportCls = null, ProxyConfig _proxi = null, int TimeOut = 60, CancellationToken token = default(CancellationToken));

		Task<Stream> DownloadFileAsStream(string FileUrl, IProgress<ReportStatus> ReportCls = null, ProxyConfig _proxi = null, int TimeOut = 60, CancellationToken token = default(CancellationToken));

		Task<JSON_YoutubeRemoteUpload> ListRemoteUpload();

		Task<JSON_RemoteUploadStatus> RemoteUploadStatus(string JobID);

		Task<JSON_SetVideoThumbnail> SetVideoThumbnail_Local(string VideoID, string ImageFile);

		Task<JSON_SetVideoThumbnail> SetVideoThumbnail_Remote(string VideoID, string ImageFile);
	}
}
