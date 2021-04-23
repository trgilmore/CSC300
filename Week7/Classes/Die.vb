Public Class Die

    Private m_value As Integer
    Private m_sides As Integer = 6
    ReadOnly Property Value As Integer
        Get
            Return (m_value)
        End Get
    End Property
    Public Function Roll() As Integer
        Dim rnd As Random = New Random

        Me.m_value = rnd.Next(1, m_sides + 1)
        Return (Me.m_value)

    End Function

    Public Sub New()
        Me.m_sides = 6
        Me.Roll()

    End Sub
    Public Sub New(sides As Integer)
        If sides > 3 Then
            Me.m_sides = sides
            Me.Roll()
        Else
            Throw New ArgumentException("The number of sides must be greater than three.")
        End If


    End Sub


End Class
