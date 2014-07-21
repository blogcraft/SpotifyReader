Imports Newtonsoft.Json

Public Class Artist

    Private _ExternalUrls As Dictionary(Of String, String)
    Private _genres As ArrayList
    Private _href As String
    Private _id As String
    Private _images As List(Of images)
    Private _name
    Private _popularity As Integer
    Private _type
    Private _uri

    <JsonProperty("external_urls")> Public Property ExternalUrls() As Dictionary(Of String, String)
        Get
            Return _ExternalUrls
        End Get
        Set(value As Dictionary(Of String, String))
            _ExternalUrls = value
        End Set
    End Property
    <JsonProperty("genres")> Public Property generes() As ArrayList
        Get
            Return _genres
        End Get
        Set(value As ArrayList)
            _genres = value
        End Set
    End Property
    <JsonProperty("href")> Public Property href() As String
        Get
            Return _href
        End Get
        Set(value As String)
            _href = value
        End Set
    End Property
    <JsonProperty("id")> Public Property id() As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property
    <JsonProperty("images")> Public Property image() As List(Of images)
        Get
            Return _images
        End Get
        Set(value As List(Of images))
            _images = value
        End Set
    End Property

    Public Class images
        Private _height As String
        Private _url As String
        Private _width As String
        <JsonProperty("height")> Public Property height() As String
            Get
                Return _height
            End Get
            Set(value As String)
                _height = value
            End Set
        End Property
        <JsonProperty("url")> Public Property url() As String
            Get
                Return _url
            End Get
            Set(value As String)
                _url = value
            End Set
        End Property
        <JsonProperty("width")> Public Property width() As String
            Get
                Return _width
            End Get
            Set(value As String)
                _width = value
            End Set
        End Property
    End Class
    <JsonProperty("name")> Public Property name() As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property
    <JsonProperty("popularity")> Public Property popularity() As Integer
        Get
            Return _popularity
        End Get
        Set(value As Integer)
            _popularity = value
        End Set
    End Property
    <JsonProperty("type")> Public Property type() As String
        Get
            Return _type
        End Get
        Set(value As String)
            _type = value
        End Set
    End Property
    <JsonProperty("uri")> Public Property uri() As String
        Get
            Return _uri
        End Get
        Set(value As String)
            _uri = value
        End Set
    End Property
End Class