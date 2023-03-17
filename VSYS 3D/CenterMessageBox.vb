Imports System.Text
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices

'USAGE
'Using New CenterMessageBox(me)
'   messagebox.show(montext.....)
'End Using

Public Class CenterMessageBox
    Implements IDisposable
    Private _mTries As Integer = 0
    Private _mOwner As Form

    Public Sub New(owner As Form)
        _mOwner = owner
        owner.BeginInvoke(New MethodInvoker(AddressOf FindDialog))
    End Sub

    Private Sub FindDialog()
        ' Enumerate windows to find the message box
        If _mTries < 0 Then
            Return
        End If
        Dim callback As New EnumThreadWndProc(AddressOf CheckWindow)
        If EnumThreadWindows(GetCurrentThreadId(), callback, IntPtr.Zero) Then
            If Threading.Interlocked.Increment(_mTries) < 10 Then
                _mOwner.BeginInvoke(New MethodInvoker(AddressOf FindDialog))
            End If
        End If
    End Sub
    Private Function CheckWindow(hWnd As IntPtr, lp As IntPtr) As Boolean
        ' Checks if <hWnd> is a dialog
        Dim sb As New StringBuilder(260)
        GetClassName(hWnd, sb, sb.Capacity)
        If sb.ToString() <> "#32770" Then
            Return True
        End If
        ' Got it
        Dim frmRect As New Rectangle(_mOwner.Location, _mOwner.Size)
        Dim dlgRect As RECT
        GetWindowRect(hWnd, dlgRect)
        MoveWindow(hWnd, frmRect.Left + (frmRect.Width - dlgRect.Right + dlgRect.Left) \ 2, frmRect.Top + (frmRect.Height - dlgRect.Bottom + dlgRect.Top) \ 2, dlgRect.Right - dlgRect.Left, dlgRect.Bottom - dlgRect.Top, True)
        Return False
    End Function
    Public Sub Dispose() Implements IDisposable.Dispose
        _mTries = -1
    End Sub

    ' P/Invoke declarations
    Private Delegate Function EnumThreadWndProc(hWnd As IntPtr, lp As IntPtr) As Boolean
    <DllImport("user32.dll")> _
    Private Shared Function EnumThreadWindows(tid As Integer, callback As EnumThreadWndProc, lp As IntPtr) As Boolean
    End Function
    <DllImport("kernel32.dll")> _
    Private Shared Function GetCurrentThreadId() As Integer
    End Function
    <DllImport("user32.dll")> _
    Private Shared Function GetClassName(hWnd As IntPtr, buffer As StringBuilder, buflen As Integer) As Integer
    End Function
    <DllImport("user32.dll")> _
    Private Shared Function GetWindowRect(hWnd As IntPtr, ByRef rc As RECT) As Boolean
    End Function
    <DllImport("user32.dll")> _
    Private Shared Function MoveWindow(hWnd As IntPtr, x As Integer, y As Integer, w As Integer, h As Integer, repaint As Boolean) As Boolean
    End Function
    Private Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure
End Class