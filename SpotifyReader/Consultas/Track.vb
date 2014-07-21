Imports Newtonsoft.Json

Public Class Track
    Private _album As Album
    Private _artists As List(Of Artist)
    Private _available_markets As ArrayList
    Private _disc_number As Integer
    Private _duration_ms As Integer
    Private _explicit As Boolean
    Private _external_ids As Dictionary(Of String, String)
    Private _external_urls As Dictionary(Of String, String)
    Private _href As String
    Private _id As String
    Private _name As String
    Private _popularity As Integer
    Private _preview_url As String
    Private _track_number As Integer
    Private _type As String
    Private _uri As String

    <JsonProperty("album")> Public Property albums() As Album
        Get
            Return _album
        End Get
        Set(value As Album)
            _album = value
        End Set
    End Property

    <JsonProperty("artists")> Public Property artists() As List(Of Artist)
        Get
            Return _artists
        End Get
        Set(value As List(Of Artist))
            _artists = value
        End Set
    End Property

    <JsonProperty("available_markets")> Public Property available_markets() As ArrayList
        Get
            Return _available_markets
        End Get
        Set(value As ArrayList)
            _available_markets = value
        End Set
    End Property
    <JsonProperty("disc_number")> Public Property disc_number() As Integer
        Get
            Return _disc_number
        End Get
        Set(value As Integer)
            _disc_number = value
        End Set
    End Property
    <JsonProperty("duration_ms")> Public Property duration_ms() As Integer
        Get
            Return _duration_ms
        End Get
        Set(value As Integer)
            _duration_ms = value
        End Set
    End Property
    <JsonProperty("explicit")> Public Property explicit() As Boolean
        Get
            Return _explicit
        End Get
        Set(value As Boolean)
            _explicit = value
        End Set
    End Property
    <JsonProperty("external_ids")> Public Property external_ids() As Dictionary(Of String, String)
        Get
            Return _external_ids
        End Get
        Set(value As Dictionary(Of String, String))
            _external_ids = value
        End Set
    End Property
    <JsonProperty("external_urls")> Public Property external_urls() As Dictionary(Of String, String)
        Get
            Return _external_urls
        End Get
        Set(value As Dictionary(Of String, String))
            _external_urls = value
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
    <JsonProperty("preview_url")> Public Property preview_url() As String
        Get
            Return _preview_url
        End Get
        Set(value As String)
            _preview_url = value
        End Set
    End Property
    <JsonProperty("track_number")> Public Property track_number() As String
        Get
            Return _track_number
        End Get
        Set(value As String)
            _track_number = value
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
