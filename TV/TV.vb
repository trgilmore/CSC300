Public Class TV
    Sub New()
    End Sub

    Private m_brandName As String = "Roku SmartTV"
    Private m_manufacturer As String = "TCL"

    Public hasPower As Boolean = False
    Public currentChannel As Integer = 1
    Public currentVolume As Integer = 10

    Private m_minChannel As Integer = 1
    Private m_maxChannel As Integer = 99
    Private m_minVolume As Integer = 0
    Private m_maxVolume As Integer = 30

    Public Sub TogglePower()
        If Me.hasPower = True Then
            Me.hasPower = False
        Else
            Me.hasPower = True
        End If
    End Sub

    Public Function setChannelDown() As Integer
        If Me.hasPower = False Then
            'Pass
        ElseIf Me.currentChannel <= Me.m_minChannel Then
            Me.currentChannel = 99
        Else
            Me.currentChannel = Me.currentChannel - 1
        End If
        Return Me.currentChannel
    End Function
    Public Function setChannelUp() As Integer
        If Me.hasPower = False Then
            'Pass
        ElseIf Me.currentChannel >= Me.m_maxChannel Then
            Me.currentChannel = 1
        Else
            Me.currentChannel = Me.currentChannel + 1
        End If
        Return Me.currentChannel
    End Function
    Public Function setVolumeDown() As Integer
        If Me.hasPower = False Then
            'Pass
        ElseIf Me.currentVolume <= Me.m_minVolume Then
            'Pass
        Else
            Me.currentVolume = Me.currentVolume - 1
        End If
        Return Me.currentVolume
    End Function
    Public Function setVolumeUp() As Integer
        If Me.hasPower = False Then
            'Pass
        ElseIf Me.currentVolume >= Me.m_maxVolume Then
            'Pass
        Else
            Me.currentVolume = Me.currentVolume + 1
        End If
        Return Me.currentVolume
    End Function
    ReadOnly Property Brand As String
        Get
            Return m_brandName
        End Get
    End Property
    ReadOnly Property Mfg As String
        Get
            Return m_manufacturer
        End Get
    End Property
End Class
