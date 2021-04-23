''' <summary>
''' Tim Gilmore
''' Quiz 5 - Modeling a Class
''' </summary>

Public Class MemoryStick
    Sub New(COLOR As String, CAPACITY As Long, LABEL As String)
        Me.m_color = COLOR
        Me.m_capacity = CAPACITY
        Me.m_label = LABEL
    End Sub


    Private m_capacity As Long
    Private m_color As String
    Private m_label As String = ""
    Private m_spaceUsed As Long = 0

    ReadOnly Property COLOR As String
        Get
            Return (Me.m_color)
        End Get
    End Property

    ReadOnly Property CAPACITY As Long
        Get
            Return (Me.m_capacity)
        End Get
    End Property

    Property LABEL As String
        Get
            If Me.m_label.Length > 10 Then
                Return (Me.m_label.Substring(0, 11))
            Else
                Return (Me.m_label)
            End If
        End Get
        Set(value As String)
            Me.m_label = value
        End Set
    End Property

    Property SPACEUSED As Long
        Get
            Return (Me.m_spaceUsed)
        End Get
        Set(value As Long)
            Me.m_spaceUsed = value
        End Set
    End Property

    Sub addFile(filename As String, size As Long)
        Me.m_spaceUsed = Me.m_spaceUsed + size
    End Sub
    Function getFreeSpace()
        Return (CAPACITY - Me.m_spaceUsed)
    End Function

    Public Overrides Function ToString() As String
        If LABEL = "" Then
            Return (COLOR & " " & CAPACITY & "GB memory stick " & "has " & getFreeSpace() & "GB remaining.")
        Else
            Return (COLOR & " " & CAPACITY & "GB memory stick labeled " & LABEL & " has " & getFreeSpace() & "GB remaining.")
        End If

    End Function

End Class
