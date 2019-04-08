Imports FembedSDK.JSON

Public Interface IClient


    Function UserInfo() As Task(Of JSON_UserInfo)
    Function UploadLocalFile(FileToUP As Object, TheUpType As FClient.UploadTypes, DestinationFolderID As String, Optional Filename As String = Nothing, Optional ReportCls As IProgress(Of ReportStatus) = Nothing, Optional _proxi As ProxyConfig = Nothing, Optional token As Threading.CancellationToken = Nothing) As Task(Of JSON_UserInfo)
    Function YoutubeRemoteUpload(FilesUrls As List(Of String)) As Task(Of JSON_YoutubeRemoteUpload)

    Function MultiRemoteUpload(FilesUrls As List(Of String)) As Task(Of JSON_YoutubeRemoteUpload)
    Function ListFolder() As Task(Of JSON_UserInfo)
    Function GetDirectUrl(VideoUrl As String) As Task(Of JSON_GetDirectUrl)
    Function DownloadFile(FileUrl As String, FileSaveDir As String, FileName As String, Optional ReportCls As IProgress(Of ReportStatus) = Nothing, Optional _proxi As ProxyConfig = Nothing, Optional TimeOut As Integer = 60, Optional token As Threading.CancellationToken = Nothing) As Task
    Function DownloadFileAsStream(FileUrl As String, Optional ReportCls As IProgress(Of ReportStatus) = Nothing, Optional _proxi As ProxyConfig = Nothing, Optional TimeOut As Integer = 60, Optional token As Threading.CancellationToken = Nothing) As Task(Of IO.Stream)
    Function RemoteUpload(FileUrl As String) As Task(Of JSON_YoutubeRemoteUpload)
    Function ListRemoteUpload() As Task(Of JSON_YoutubeRemoteUpload)
    Function RemoteUploadStatus(JobID As String) As Task(Of JSON_RemoteUploadStatus)
    Function SetVideoThumbnail_Local(VideoID As String, ImageFile As String) As Task(Of JSON_SetVideoThumbnail)
    Function SetVideoThumbnail_Remote(VideoID As String, ImageFile As String) As Task(Of JSON_SetVideoThumbnail)
    Function ImportToYourAccount(VideoID As String, NewName As String) As Task(Of JSON_SetVideoThumbnail)


End Interface
