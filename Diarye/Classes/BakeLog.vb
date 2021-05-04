Public Class BakeLog
    Sub New()

    End Sub

    Private m_BakeDate As Date
    Private m_StarterUsed As String
    Private m_RecipeUsed As String
    Private m_Autolyse As Boolean
    Private m_AutolyseTime As Integer
    Private m_GlutenDevMethod As String
    Private m_GlutenDevCount As Integer
    Private m_GlutenDevInterval As Integer
    Private m_BulkFermentTime As Integer
    Private m_AmbientTemp As Integer
    Private m_AmbientHumidity As Integer
    Private m_ColdProof As Boolean
    Private m_ColdProofTime As Integer
    Private m_Phase1Temp As Integer
    Private m_Phase1Time As Integer
    Private m_Phase2Temp As Integer
    Private m_Phase2Time As Integer
    Private ReadOnly m_TotalBakeTime As Integer
    Private m_RiseRating As Integer
    Private m_CrustRating As Integer
    Private m_CrumbRating As Integer
    Private m_ColorRating As Integer
    Private m_TasteRating As Integer
    Private m_HasEar As Boolean
    Private m_HasBlistering As Boolean
    Private m_isSuccess As Boolean

    Public Property BakeDate As Date
        Get
            Return m_BakeDate
        End Get
        Set(value As Date)
            m_BakeDate = value
        End Set
    End Property

    Public Property StarterUsed As String
        Get
            Return m_StarterUsed
        End Get
        Set(value As String)
            m_StarterUsed = value
        End Set
    End Property

    Public Property RecipeUsed As String
        Get
            Return m_RecipeUsed
        End Get
        Set(value As String)
            m_RecipeUsed = value
        End Set
    End Property

    Public Property Autolyse As Boolean
        Get
            Return m_Autolyse
        End Get
        Set(value As Boolean)
            m_Autolyse = value
        End Set
    End Property

    Public Property AutolyseTime As Integer
        Get
            Return m_AutolyseTime
        End Get
        Set(value As Integer)
            m_AutolyseTime = value
        End Set
    End Property

    Public Property GlutenDevMethod As String
        Get
            Return m_GlutenDevMethod
        End Get
        Set(value As String)
            m_GlutenDevMethod = value
        End Set
    End Property

    Public Property GlutenDevCount As Integer
        Get
            Return m_GlutenDevCount
        End Get
        Set(value As Integer)
            m_GlutenDevCount = value
        End Set
    End Property

    Public Property GlutenDevInterval As Integer
        Get
            Return m_GlutenDevInterval
        End Get
        Set(value As Integer)
            m_GlutenDevInterval = value
        End Set
    End Property

    Public Property BulkFermentTime As Integer
        Get
            Return m_BulkFermentTime
        End Get
        Set(value As Integer)
            m_BulkFermentTime = value
        End Set
    End Property

    Public Property AmbientTemp As Integer
        Get
            Return m_AmbientTemp
        End Get
        Set(value As Integer)
            m_AmbientTemp = value
        End Set
    End Property

    Public Property AmbientHumidity As Integer
        Get
            Return m_AmbientHumidity
        End Get
        Set(value As Integer)
            m_AmbientHumidity = value
        End Set
    End Property

    Public Property ColdProof As Boolean
        Get
            Return m_ColdProof
        End Get
        Set(value As Boolean)
            m_ColdProof = value
        End Set
    End Property

    Public Property ColdProofTime As Integer
        Get
            Return m_ColdProofTime
        End Get
        Set(value As Integer)
            m_ColdProofTime = value
        End Set
    End Property

    Public Property Phase1Temp As Integer
        Get
            Return m_Phase1Temp
        End Get
        Set(value As Integer)
            m_Phase1Temp = value
        End Set
    End Property

    Public Property Phase1Time As Integer
        Get
            Return m_Phase1Time
        End Get
        Set(value As Integer)
            m_Phase1Time = value
        End Set
    End Property

    Public Property Phase2Temp As Integer
        Get
            Return m_Phase2Temp
        End Get
        Set(value As Integer)
            m_Phase2Temp = value
        End Set
    End Property
    Public Property Phase2Time As Integer
        Get
            Return m_Phase2Time
        End Get
        Set(value As Integer)
            m_Phase2Time = value
        End Set
    End Property
    Public ReadOnly Property TotalBakeTime As Integer
        Get
            Return m_Phase1Time + m_Phase2Time
        End Get
    End Property

    Public Property RiseRating As Integer
        Get
            Return m_RiseRating
        End Get
        Set(value As Integer)
            m_RiseRating = value
        End Set
    End Property

    Public Property CrustRating As Integer
        Get
            Return m_CrustRating
        End Get
        Set(value As Integer)
            m_CrustRating = value
        End Set
    End Property

    Public Property CrumbRating As Integer
        Get
            Return m_CrumbRating
        End Get
        Set(value As Integer)
            m_CrumbRating = value
        End Set
    End Property

    Public Property ColorRating As Integer
        Get
            Return m_ColorRating
        End Get
        Set(value As Integer)
            m_ColorRating = value
        End Set
    End Property

    Public Property TasteRating As Integer
        Get
            Return m_TasteRating
        End Get
        Set(value As Integer)
            m_TasteRating = value
        End Set
    End Property

    Public Property HasEar As Boolean
        Get
            Return m_HasEar
        End Get
        Set(value As Boolean)
            m_HasEar = value
        End Set
    End Property

    Public Property HasBlistering As Boolean
        Get
            Return m_HasBlistering
        End Get
        Set(value As Boolean)
            m_HasBlistering = value
        End Set
    End Property

    Public Property IsSuccess As Boolean
        Get
            Return m_isSuccess
        End Get
        Set(value As Boolean)
            m_isSuccess = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return ("Bake Date: " & BakeDate & vbCrLf &
                "Starter Used: " & StarterUsed & vbCrLf &
                "Recipe Used: " & RecipeUsed & vbCrLf &
                "Autolyse: " & Autolyse & vbCrLf &
                "Autolyse Time: " & AutolyseTime & vbCrLf &
                "Gluten Development Method: " & GlutenDevMethod & vbCrLf &
                "Gluten Devolopment Count: " & GlutenDevCount & vbCrLf &
                "Gluten Development Interval (minutes): " & GlutenDevInterval & vbCrLf &
                "Bulk Ferment Time: " & BulkFermentTime & vbCrLf &
                "Ambient Temperature: " & AmbientTemp & vbCrLf &
                "Ambient Humidity: " & AmbientHumidity & vbCrLf &
                "Cold Proof: " & ColdProof & vbCrLf &
                "Cold Proof Time: " & ColdProofTime & vbCrLf &
                "Phase 1 Temp: " & Phase1Temp & vbCrLf &
                "Phase 1 Time: " & Phase1Time & vbCrLf &
                "Phase 2 Temp: " & Phase2Temp & vbCrLf &
                "Phase 2 Time: " & Phase2Time & vbCrLf &
                "Rise Rating: " & RiseRating & vbCrLf &
                "Crumb Rating: " & CrumbRating & vbCrLf &
                "Crust Rating: " & CrustRating & vbCrLf &
                "Color Rating: " & ColorRating & vbCrLf &
                "Taste Rating: " & TasteRating & vbCrLf &
                "Has Ear: " & HasEar & vbCrLf &
                "Has Blistering: " & HasBlistering & vbCrLf &
                "Success?: " & IsSuccess & vbCrLf & vbCrLf)
    End Function
End Class