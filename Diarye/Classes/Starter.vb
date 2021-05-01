<Serializable()>
Public Class Starter
    Sub New()

    End Sub

    Public Sub New(name As String, feedingRecipe As List(Of String), starterWeight As Integer, flourWeight As Integer, waterWeight As Integer, schedule As Integer, creationDate As Date, hibernation As Boolean, hibernationType As String)
        m_name = name
        m_FeedingRecipe = feedingRecipe
        m_StarterWeight = starterWeight
        m_FlourWeight = flourWeight
        m_WaterWeight = waterWeight
        m_Schedule = schedule
        m_CreationDate = creationDate
        m_Hibernation = hibernation
        m_HibernationType = hibernationType
    End Sub

    Public Sub New(name As String, feedingRecipe As List(Of String), starterWeight As Integer, flourWeight As Integer, waterWeight As Integer, schedule As Integer, creationDate As Date, hibernation As Boolean, hibernationType As String, ambientTemp As Double)
        m_name = name
        m_FeedingRecipe = feedingRecipe
        m_StarterWeight = starterWeight
        m_FlourWeight = flourWeight
        m_WaterWeight = waterWeight
        m_Schedule = schedule
        m_CreationDate = creationDate
        m_Hibernation = hibernation
        m_HibernationType = hibernationType
        m_AmbientTemp = ambientTemp
    End Sub

    Public Sub New(name As String, feedingRecipe As List(Of String), starterWeight As Integer, flourWeight As Integer, waterWeight As Integer, schedule As Integer, creationDate As Date, hibernation As Boolean, hibernationType As String, ambientTemp As Double, ambientHumidity As Double)
        m_name = name
        m_FeedingRecipe = feedingRecipe
        m_StarterWeight = starterWeight
        m_FlourWeight = flourWeight
        m_WaterWeight = waterWeight
        m_Schedule = schedule
        m_CreationDate = creationDate
        m_Hibernation = hibernation
        m_HibernationType = hibernationType
        m_AmbientTemp = ambientTemp
        m_AmbientHumidity = ambientHumidity
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

    Public Sub Save()
        Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(Starter))
        Dim file As New System.IO.StreamWriter(
            "C:\Users\tgilm\source\repos\Diarye\data\Starters.xml", True)
        writer.Serialize(file, Me)
        file.Close()
    End Sub
    Public Sub Load()
        Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(Starter))
        Dim file As New System.IO.StreamReader(
            "c:\temp\Starters.xml")
        Dim overview As Starter
        overview = CType(reader.Deserialize(file), Starter)
        Console.WriteLine(overview.Name)
        file.Close()
    End Sub

    Public Overrides Function ToString() As String
        Return ("Name: " & Name & vbCrLf &
                "Creation Date: " & CreationDate & vbCrLf &
                "Recipe: " & FeedingRecipe.ToString() & vbCrLf &
                "Hydration: " & StarterHydration & vbCrLf &
                "Schedule: " & Schedule & vbCrLf &
                "Hibernation Status: " & Hibernation & vbCrLf &
                "Hibernation Type: " & HibernationType & vbCrLf &
                "Ambient Temperature: " & AmbientTemp & vbCrLf &
                "Ambient Humidity: " & AmbientHumidity & vbCrLf)
    End Function

    Private Function Join(feedingRecipe As Array) As String
        '
        Dim S As String = ""
        For Each item As String In feedingRecipe
            S &= item & ", "
        Next
        Return S
    End Function
End Class

Public Class StartersList : Inherits List(Of Starter)
End Class