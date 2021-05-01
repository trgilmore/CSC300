Public Class Recipe
    Private m_RecipeTitle As String
    Private m_RecipeFlours As New List(Of String)
    Private m_RecipeFlourWeight As Integer
    Private m_RecipeSaltWeight As Integer
    Private m_RecipeWaterWeight As Integer
    Private m_RecipeLevain As String
    Private m_RecipeLevainWeight As Integer
    Private m_Addition1 As String
    Private m_AdditionWeight1 As Integer
    Private m_Addition2 As String
    Private m_AdditionWeight2 As Integer
    Private m_Addition3 As String
    Private m_AdditionWeight3 As Integer
    Private m_Addition4 As String
    Private m_AdditionWeight4 As Integer


    Public Sub New()

    End Sub
    Public Sub New(recipeTitle As String, recipeFlours As List(Of String), recipeFlourWeight As Integer, recipeSaltWeight As Integer, recipeWaterWeight As Integer, recipeLevain As String, recipeLevainWeight As Integer)
        m_RecipeTitle = recipeTitle
        m_RecipeFlours = recipeFlours
        m_RecipeFlourWeight = recipeFlourWeight
        m_RecipeSaltWeight = recipeSaltWeight
        m_RecipeWaterWeight = recipeWaterWeight
        m_RecipeLevain = recipeLevain
        m_RecipeLevainWeight = recipeLevainWeight

    End Sub
    Public Sub New(recipeTitle As String, recipeFlours As List(Of String), recipeFlourWeight As Integer, recipeSaltWeight As Integer, recipeWaterWeight As Integer, recipeLevain As String, recipeLevainWeight As Integer, addition1 As String, additionWeight1 As Integer)
        m_RecipeTitle = recipeTitle
        m_RecipeFlours = recipeFlours
        m_RecipeFlourWeight = recipeFlourWeight
        m_RecipeSaltWeight = recipeSaltWeight
        m_RecipeWaterWeight = recipeWaterWeight
        m_RecipeLevain = recipeLevain
        m_RecipeLevainWeight = recipeLevainWeight
        m_Addition1 = addition1
        m_AdditionWeight1 = additionWeight1
    End Sub
    Public Sub New(recipeTitle As String, recipeFlours As List(Of String), recipeFlourWeight As Integer, recipeSaltWeight As Integer, recipeWaterWeight As Integer, recipeLevain As String, recipeLevainWeight As Integer, addition1 As String, additionWeight1 As Integer, addition2 As String, additionWeight2 As Integer)
        m_RecipeTitle = recipeTitle
        m_RecipeFlours = recipeFlours
        m_RecipeFlourWeight = recipeFlourWeight
        m_RecipeSaltWeight = recipeSaltWeight
        m_RecipeWaterWeight = recipeWaterWeight
        m_RecipeLevain = recipeLevain
        m_RecipeLevainWeight = recipeLevainWeight
        m_Addition1 = addition1
        m_AdditionWeight1 = additionWeight1
        m_Addition2 = addition2
        m_AdditionWeight2 = additionWeight2
    End Sub
    Public Sub New(recipeTitle As String, recipeFlours As List(Of String), recipeFlourWeight As Integer, recipeSaltWeight As Integer, recipeWaterWeight As Integer, recipeLevain As String, recipeLevainWeight As Integer, addition1 As String, additionWeight1 As Integer, addition2 As String, additionWeight2 As Integer, addition3 As String, additionWeight3 As Integer)
        m_RecipeTitle = recipeTitle
        m_RecipeFlours = recipeFlours
        m_RecipeFlourWeight = recipeFlourWeight
        m_RecipeSaltWeight = recipeSaltWeight
        m_RecipeWaterWeight = recipeWaterWeight
        m_RecipeLevain = recipeLevain
        m_RecipeLevainWeight = recipeLevainWeight
        m_Addition1 = addition1
        m_AdditionWeight1 = additionWeight1
        m_Addition2 = addition2
        m_AdditionWeight2 = additionWeight2
        m_Addition3 = addition3
        m_AdditionWeight3 = additionWeight3
    End Sub
    Public Sub New(recipeTitle As String, recipeFlours As List(Of String), recipeFlourWeight As Integer, recipeSaltWeight As Integer, recipeWaterWeight As Integer, recipeLevain As String, recipeLevainWeight As Integer, addition1 As String, additionWeight1 As Integer, addition2 As String, additionWeight2 As Integer, addition3 As String, additionWeight3 As Integer, addition4 As String, additionWeight4 As Integer)
        m_RecipeTitle = recipeTitle
        m_RecipeFlours = recipeFlours
        m_RecipeFlourWeight = recipeFlourWeight
        m_RecipeSaltWeight = recipeSaltWeight
        m_RecipeWaterWeight = recipeWaterWeight
        m_RecipeLevain = recipeLevain
        m_RecipeLevainWeight = recipeLevainWeight
        m_Addition1 = addition1
        m_AdditionWeight1 = additionWeight1
        m_Addition2 = addition2
        m_AdditionWeight2 = additionWeight2
        m_Addition3 = addition3
        m_AdditionWeight3 = additionWeight3
        m_Addition4 = addition4
        m_AdditionWeight4 = additionWeight4
    End Sub

    Property Title As String
        Get
            Return (Me.m_RecipeTitle)
        End Get
        Set(value As String)
            Me.m_RecipeTitle = value
        End Set
    End Property

    Property Flours As List(Of String)
        Get
            Return (Me.m_RecipeFlours)
        End Get
        Set(value As List(Of String))
            Me.m_RecipeFlours = value
        End Set
    End Property

    Property FlourWeight As Integer
        Get
            Return (Me.m_RecipeFlourWeight)
        End Get
        Set(value As Integer)
            Me.m_RecipeFlourWeight = value
        End Set
    End Property

    Property SaltWeight As Integer
        Get
            Return (Me.m_RecipeSaltWeight)
        End Get
        Set(value As Integer)
            Me.m_RecipeSaltWeight = value
        End Set
    End Property

    Property RecipeWaterWeight As Integer
        Get
            Return (Me.m_RecipeWaterWeight)
        End Get
        Set(value As Integer)
            Me.m_RecipeWaterWeight = value
        End Set
    End Property

    Property Levain As String
        Get
            Return (Me.m_RecipeLevain)
        End Get
        Set(value As String)
            Me.m_RecipeLevain = value
        End Set
    End Property

    Property LevainWeight As Integer
        Get
            Return (Me.m_RecipeLevainWeight)
        End Get
        Set(value As Integer)
            Me.m_RecipeLevainWeight = value
        End Set
    End Property

    Property Addition1 As String
        Get
            Return (Me.m_Addition1)
        End Get
        Set(value As String)
            Me.m_Addition1 = value
        End Set
    End Property

    Property AdditionWeight1 As Integer
        Get
            Return (Me.m_AdditionWeight1)
        End Get
        Set(value As Integer)
            Me.m_AdditionWeight1 = value
        End Set
    End Property

    Property Addition2 As String
        Get
            Return (Me.m_Addition2)
        End Get
        Set(value As String)
            Me.m_Addition2 = value
        End Set
    End Property

    Property AdditionWeight2 As Integer
        Get
            Return (Me.m_AdditionWeight2)
        End Get
        Set(value As Integer)
            Me.m_AdditionWeight2 = value
        End Set
    End Property

    Property Addition3 As String
        Get
            Return (Me.m_Addition3)
        End Get
        Set(value As String)
            Me.m_Addition3 = value
        End Set
    End Property

    Property AdditionWeight3 As Integer
        Get
            Return (Me.m_AdditionWeight3)
        End Get
        Set(value As Integer)
            Me.m_AdditionWeight3 = value
        End Set
    End Property

    Property Addition4 As String
        Get
            Return (Me.m_Addition4)
        End Get
        Set(value As String)
            Me.m_Addition4 = value
        End Set
    End Property

    Property AdditionWeight4 As Integer
        Get
            Return (Me.m_AdditionWeight4)
        End Get
        Set(value As Integer)
            Me.m_AdditionWeight4 = value
        End Set
    End Property

    ReadOnly Property TotalDoughWeight As Integer
        Get
            Return (Me.m_RecipeFlourWeight + Me.m_RecipeSaltWeight + Me.m_RecipeWaterWeight + Me.m_RecipeLevainWeight + Me.m_AdditionWeight1 + Me.m_AdditionWeight2 + Me.m_AdditionWeight3 + Me.m_AdditionWeight4)
        End Get
    End Property

    ReadOnly Property RecipeHydration As Double
        Get
            Return ((Me.m_RecipeWaterWeight / Me.m_RecipeFlourWeight) * 100)
        End Get
    End Property

    ReadOnly Property LevainPercent As Double
        Get
            Return ((Me.m_RecipeLevainWeight / Me.m_RecipeFlourWeight) * 100)
        End Get
    End Property
End Class
