# FembedSDK
.NET API Library for fembed.net

# Requirements
1. .NET 4.5.2
1. Newtonsoft.Json

# List of Functions
* DownloadFile
* DownloadFileAsStream
* GetDirectUrl
* ImportToYourAccount
* ListFolder
* ListRemoteUpload
* MultiRemoteUpload
* RemoteUpload
* RemoteUploadStatus
* SetVideoThumbnail_Local
* SetVideoThumbnail_Remote
* UploadLocalFile
* UserInfo
* YoutubeRemoteUpload

# Functions:
[https://github.com/jamesheck2019/FembedSDK/blob/master/IClient.cs](https://github.com/jamesheck2019/FembedSDK/blob/master/IClient.cs)

# Example:
set client
```vb.net
Dim Clnt As FembedSDK.IClient = New FembedSDK.FClient("xxxx", "xxxx")
```
get user info:
```vb.net
Dim RSLT = Await Clnt.UserInfo()
```
upload (local file)
```vb.net
        Try
            Dim frm As New DeQma.FileFolderDialogs.VistaOpenFileDialog With {.Multiselect = False, .Title = "Select image/s to upload"}
            If frm.ShowDialog = DialogResult.OK AndAlso Not String.IsNullOrEmpty(frm.FileName) Then
                Dim UploadCancellationToken As New Threading.CancellationTokenSource()
                Dim prog_ReportCls As New Progress(Of FembedSDK.ReportStatus)(Sub(ReportClass As FembedSDK.ReportStatus)
                                                                                  Label1.Text = String.Format("{0}/{1}", ISisFunctions.Bytes_To_KbMbGb.SetBytes(ReportClass.BytesTransferred), ISisFunctions.Bytes_To_KbMbGb.SetBytes(ReportClass.TotalBytes))
                                                                                  ProgressBar1.Value = CInt(ReportClass.ProgressPercentage)
                                                                                  Label2.Text = If(CStr(ReportClass.TextStatus) Is Nothing, "Uploading...", CStr(ReportClass.TextStatus))
                                                                              End Sub)
                Dim RSLT = Await Clnt.UploadLocalFile(frm.FileName, FembedSDK.FClient.UploadTypes.FilePath, "", IO.Path.GetFileName(frm.FileName), prog_ReportCls, Nothing, UploadCancellationToken.Token)
                DataGridView1.Rows.Add(RSLT.VideoUrl)
            End If
        Catch ex As FembedSDK.FembedException
            MsgBox(ex.Message)
        End Try
```
