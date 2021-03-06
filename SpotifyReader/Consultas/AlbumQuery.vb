﻿Imports Newtonsoft.Json

Public Class AlbumQuery

    Private _href As String
    Private _items As List(Of Album)
    Private _limit As String
    Private _next As String
    Private _offset As Integer
    Private _previous As String
    Private _total As Integer

    <JsonProperty("href")> Public Property href() As String
        Get
            Return _href
        End Get
        Set(value As String)
            _href = value
        End Set
    End Property
    <JsonProperty("items")> Public Property item() As List(Of Album)
        Get
            Return _items
        End Get
        Set(value As List(Of Album))
            _items = value
        End Set
    End Property

    <JsonProperty("limit")> Public Property limit() As String
        Get
            Return _limit
        End Get
        Set(value As String)
            _limit = value
        End Set
    End Property
    <JsonProperty("next")> Public Property nex() As String
        Get
            Return _next
        End Get
        Set(value As String)
            _next = value
        End Set
    End Property
    <JsonProperty("offset")> Public Property offset() As String
        Get
            Return _offset
        End Get
        Set(value As String)
            _offset = value
        End Set
    End Property
    <JsonProperty("previous")> Public Property previous() As String
        Get
            Return _previous
        End Get
        Set(value As String)
            _previous = value
        End Set
    End Property
    <JsonProperty("total")> Public Property total() As String
        Get
            Return _total
        End Get
        Set(value As String)
            _total = value
        End Set
    End Property

End Class
