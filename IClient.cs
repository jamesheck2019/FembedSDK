Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Threading
Imports System.Threading.Tasks
Imports FembedSDK.JSON

Namespace FembedSDK
	Public Interface IClient
		Function ComplaintsList() As Task(Of JSON_UserInfo)

		Function UserInfo() As Task(Of JSON_UserInfo)

		Function UploadLocalFile(FileToUP As Object, TheUpType As FClient.UploadTypes, DestinationFolderID As String, Optional Filename As String = Nothing, Optional ReportCls As IProgress(Of ReportStatus) = Nothing, Optional _proxi As ProxyConfig = Nothing, Optional token As CancellationToken = Nothing) As Task(Of JSON_CompleteUpload)

		Function YoutubeRemoteUpload(FilesUrls As List(Of String)) As Task(Of JSON_YoutubeRemoteUpload)

		Function RemoteUpload(FilesUrls As List(Of String)) As Task(Of JSON_YoutubeRemoteUpload)

		Function GetDirectUrl(VideoUrl As String) As Task(Of JSON_GetDirectUrl)

		Function DownloadFile(FileUrl As String, FileSaveDir As String, FileName As String, Optional ReportCls As IProgress(Of ReportStatus) = Nothing, Optional _proxi As ProxyConfig = Nothing, Optional TimeOut As Integer = 60, Optional token As CancellationToken = Nothing) As Task

		Function DownloadFileAsStream(FileUrl As String, Optional ReportCls As IProgress(Of ReportStatus) = Nothing, Optional _proxi As ProxyConfig = Nothing, Optional TimeOut As Integer = 60, Optional token As CancellationToken = Nothing) As Task(Of Stream)

		Function ListRemoteUpload() As Task(Of JSON_YoutubeRemoteUpload)

		Function RemoteUploadStatus(JobID As String) As Task(Of JSON_RemoteUploadStatus)

		Function SetVideoThumbnail_Local(VideoID As String, ImageFile As String) As Task(Of JSON_SetVideoThumbnail)

		Function SetVideoThumbnail_Remote(VideoID As String, ImageFile As String) As Task(Of JSON_SetVideoThumbnail)
	End Interface
End Namespace
