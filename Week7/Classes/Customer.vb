Public Class Customer
    Sub New()

    End Sub

    Sub New(ID As Integer, Name As String, City As String)
        Me.m_ID = ID
        Me.m_Name = Name
        Me.m_City = City

    End Sub

    Private m_ID As Integer
    Private m_Name As String = ""
    Private m_City As String = ""

    Public Overrides Function toString() As String
        Return (Me.m_ID & ":" & Me.m_Name & ":" & Me.m_City)
    End Function


    Property ID As Integer
        Get
            Return (Me.m_ID)
        End Get
        Set(value As Integer)
            Me.m_ID = value
        End Set
    End Property
    Property Name As String
        Get
            Return (Me.m_Name)
        End Get
        Set(value As String)
            Me.m_Name = value
        End Set
    End Property


End Class
