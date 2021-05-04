<Serializable()>
Public Class Starter
    Sub New()

    End Sub

    Private m_name As String
    Private m_FeedingRecipe As New List(Of String)
    Private m_StarterWeight As Integer
    Private m_FlourWeight As Integer
    Private m_WaterWeight As Integer
    Private m_Schedule As Integer
    Private m_CreationDate As Date
    Private m_Hibernation As Boolean
    Private m_HibernationType As String
    Private m_AmbientTemp As Double
    Private m_AmbientHumidity As Double

    Property Name As String
        Get
            Return (Me.m_name)
        End Get
        Set(value As String)
            Me.m_name = value
        End Set
    End Property

    Property FeedingRecipe As List(Of String)
        Get
            Return (Me.m_FeedingRecipe)
        End Get
        Set(value As List(Of String))
            Me.m_FeedingRecipe = value
        End Set
    End Property
    Property StarterWeight As Integer
        Get
            Return (Me.m_StarterWeight)
        End Get
        Set(value As Integer)
            Me.m_StarterWeight = value
        End Set
    End Property

    Property FlourWeight As Integer
        Get
            Return (Me.m_FlourWeight)
        End Get
        Set(value As Integer)
            Me.m_FlourWeight = value
        End Set
    End Property

    Property WaterWeight As Integer
        Get
            Return (Me.m_WaterWeight)
        End Get
        Set(value As Integer)
            Me.m_WaterWeight = value
        End Set
    End Property

    Property Schedule As Integer
        Get
            Return (Me.m_Schedule)
        End Get
        Set(value As Integer)
            Me.m_Schedule = value
        End Set
    End Property

    Property CreationDate As Date
        Get
            Return (Me.m_CreationDate)
        End Get
        Set(value As Date)
            Me.m_CreationDate = value
        End Set
    End Property

    Property Hibernation As Boolean
        Get
            Return (Me.m_Hibernation)
        End Get
        Set(value As Boolean)
            Me.m_Hibernation = value
        End Set
    End Property

    Property HibernationType As String
        Get
            Return (Me.m_HibernationType)
        End Get
        Set(value As String)
            Me.m_HibernationType = value
        End Set
    End Property

    Property AmbientTemp As Double
        Get
            Return (Me.m_AmbientTemp)
        End Get
        Set(value As Double)
            Me.m_AmbientTemp = value
        End Set
    End Property

    Property AmbientHumidity As Double
        Get
            Return (Me.m_AmbientHumidity)
        End Get
        Set(value As Double)
            Me.m_AmbientHumidity = value
        End Set
    End Property

    ReadOnly Property StarterHydration As Double
        Get
            Return ((Me.m_WaterWeight / Me.m_FlourWeight) * 100)
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return ("Name: " & Name & vbCrLf &
                "Creation Date: " & CreationDate & vbCrLf &
                "Recipe: " & Me.JoinElements() & vbCrLf &
                "Hydration: " & StarterHydration & vbCrLf &
                "Schedule: " & Schedule & vbCrLf &
                "Hibernation Status: " & Hibernation & vbCrLf &
                "Hibernation Type: " & HibernationType & vbCrLf &
                "Ambient Temperature: " & AmbientTemp & vbCrLf &
                "Ambient Humidity: " & AmbientHumidity & vbCrLf & vbCrLf)
    End Function

    Private Function JoinElements() As String
        Dim S As String = ""
        For Each item As String In FeedingRecipe
            S &= item & ", "
        Next
        Return S
    End Function
End Class