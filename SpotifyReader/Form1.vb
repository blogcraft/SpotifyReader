Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports System.Data.SqlClient

Public Class Form1

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim tipoConsulta As String

        tipoConsulta = "artist"

        Dim responseFromServer As String
        responseFromServer = SpotifyRequest("https://api.spotify.com/v1/search?q=" & TboxBusqueda.Text & "&type=" & tipoConsulta)

        Dim objeto As ArtistQuery
        objeto = JsonConvert.DeserializeObject(Of ArtistQuery)(responseFromServer)

        Dim dt As New DataTable
        dt.TableName = "Artists"
        dt.Columns.Add("id", Type.GetType("System.String"))
        dt.Columns.Add("name", Type.GetType("System.String"))
        'dt.Columns.Add("popularity", Type.GetType("System.String"))
        'dt.Columns.Add("uri", Type.GetType("System.String"))

        For Each artist In objeto.artist.item
            Dim dr As DataRow
            dr = dt.NewRow
            dr("id") = artist.id
            dr("name") = artist.name
            'dr("popularity") = artist.popularity
            'dr("uri") = artist.uri
            dt.Rows.Add(dr)
        Next (artist)

        Dim ds As New DataSet
        ds.Tables.Add(dt)

        DgvBusqueda.AutoGenerateColumns = True
        DgvBusqueda.DataMember = "Artists"
        DgvBusqueda.DataSource = ds
        DgvBusqueda.Columns(0).Visible = False
        DgvBusqueda.Columns(1).HeaderText = "Artista"
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim ds As DataSet
        Dim tabla As String
        ds = DgvBusqueda.DataSource
        tabla = "Artists"

        Cursor.Current = Cursors.WaitCursor
        For Each drSearch As DataRow In ds.Tables(tabla).Rows
            If Not existe(drSearch("id"), tabla) Then
                Dim responseFromServer As String
                responseFromServer = SpotifyRequest("https://api.spotify.com/v1/artists/" & drSearch("id"))

                Dim objArtist As Artist
                objArtist = JsonConvert.DeserializeObject(Of Artist)(responseFromServer)

                Dim dtArtist As New DataTable
                dtArtist.TableName = "Artists"
                dtArtist.Columns.Add("id", Type.GetType("System.String"))
                dtArtist.Columns.Add("name", Type.GetType("System.String"))
                dtArtist.Columns.Add("popularity", Type.GetType("System.String"))
                dtArtist.Columns.Add("uri", Type.GetType("System.String"))

                Dim drArtist As DataRow
                drArtist = dtArtist.NewRow
                drArtist("id") = objArtist.id
                drArtist("name") = objArtist.name
                drArtist("popularity") = objArtist.popularity
                drArtist("uri") = objArtist.uri

                guardar(drArtist, tabla)

                responseFromServer = SpotifyRequest("https://api.spotify.com/v1/artists/" & drSearch("id") & "/albums")

                Dim albums As AlbumQuery
                albums = JsonConvert.DeserializeObject(Of AlbumQuery)(responseFromServer)

                For Each album In albums.item
                    If Not existe(drSearch("id"), "Albums") Then
                        responseFromServer = SpotifyRequest("https://api.spotify.com/v1/albums/" & album.id)
                        Dim objAlbum As Album
                        objAlbum = JsonConvert.DeserializeObject(Of Album)(responseFromServer)

                        Dim dtAlbum As New DataTable
                        dtAlbum.TableName = "Albums"
                        dtAlbum.Columns.Add("id", Type.GetType("System.String"))
                        dtAlbum.Columns.Add("name", Type.GetType("System.String"))
                        dtAlbum.Columns.Add("uri", Type.GetType("System.String"))
                        dtAlbum.Columns.Add("popularity", Type.GetType("System.Int32"))
                        dtAlbum.Columns.Add("release_date", Type.GetType("System.String"))
                        dtAlbum.Columns.Add("artist_id", Type.GetType("System.String"))

                        Dim drAlbum As DataRow
                        drAlbum = dtAlbum.NewRow
                        drAlbum("id") = objAlbum.id
                        drAlbum("name") = objAlbum.name
                        drAlbum("uri") = objAlbum.uri
                        drAlbum("popularity") = objAlbum.popularity
                        drAlbum("release_date") = objAlbum.release_date
                        drAlbum("artist_id") = objArtist.id
                        guardar(drAlbum, "Albums")

                    End If

                    responseFromServer = SpotifyRequest("https://api.spotify.com/v1/albums/" & album.id & "/tracks")
                    Dim Tracks As TrackQuery
                    Tracks = JsonConvert.DeserializeObject(Of TrackQuery)(responseFromServer)

                    Dim dtTrack As New DataTable
                    dtTrack.TableName = "Tracks"
                    dtTrack.Columns.Add("id", Type.GetType("System.String"))
                    dtTrack.Columns.Add("name", Type.GetType("System.String"))
                    dtTrack.Columns.Add("uri", Type.GetType("System.String"))
                    dtTrack.Columns.Add("duration_ms", Type.GetType("System.Int32"))
                    dtTrack.Columns.Add("album_id", Type.GetType("System.String"))
                    dtTrack.Columns.Add("popularity", Type.GetType("System.Int32"))

                    For Each track In Tracks.item
                        Dim drAlbum As DataRow
                        drAlbum = dtTrack.NewRow
                        drAlbum("id") = track.id
                        drAlbum("name") = track.name
                        drAlbum("uri") = track.uri
                        drAlbum("duration_ms") = track.duration_ms
                        drAlbum("album_id") = album.id
                        drAlbum("popularity") = track.popularity
                        If Not existe(drSearch("id"), "Tracks") Then
                            guardar(drAlbum, "Tracks")
                        End If
                    Next
                Next
            End If
        Next
        Cursor.Current = Cursors.Default
        MsgBox("Operacion Finalizada")
    End Sub
    Private Function existe(ByVal id As String, ByVal tabla As String) As Boolean
        Dim resultado As Boolean

        Dim myconnect As New SqlClient.SqlConnection
        Dim mycommand As SqlCommand = New SqlCommand()

        myconnect.ConnectionString = "Server=(localdb)\v11.0;Integrated Security=true;AttachDbFilename=|DataDirectory|\SpotifyDB.mdf"
        mycommand.Connection = myconnect
        mycommand.CommandText = "SELECT * FROM " & tabla & " WHERE id = @id"
        myconnect.Open()

        mycommand.Parameters.AddWithValue("@id", id)
        Using reader As SqlDataReader = mycommand.ExecuteReader()
            If reader.HasRows Then
                resultado = True
            Else
                resultado = False
            End If
        End Using
        myconnect.Close()
        Return resultado
    End Function

    Private Function guardar(ByVal dr As DataRow, ByVal tabla As String) As Boolean
        Dim myconnect As New SqlClient.SqlConnection
        Dim mycommand As SqlCommand = New SqlCommand()
        Dim columnas As String

        If tabla = "Artists" Then
            columnas = " (id, name, popularity, uri) VALUES (@id, @name, @popularity, @uri)"
        ElseIf tabla = "Tracks" Then
            columnas = " (id, name, popularity, uri, duration_ms, album_id) VALUES (@id, @name, @popularity, @uri, @duration_ms, @album_id)"
        Else
            columnas = " (id, name, popularity, uri, release_date, artist_id) VALUES (@id, @name, @popularity, @uri, @release_date, @artist_id)"
        End If

        myconnect.ConnectionString = "Server=(localdb)\v11.0;Integrated Security=true;AttachDbFilename=|DataDirectory|\SpotifyDB.mdf"
        mycommand.Connection = myconnect
        mycommand.CommandText = "INSERT INTO " & tabla & columnas
        myconnect.Open()

        Try
            mycommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = dr("id")
            mycommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = dr("name")
            mycommand.Parameters.Add("@popularity", SqlDbType.Int).Value = dr("popularity")
            mycommand.Parameters.Add("@uri", SqlDbType.NVarChar).Value = dr("uri")
            If tabla = "Tracks" Then
                mycommand.Parameters.Add("@duration_ms", SqlDbType.Int).Value = dr("duration_ms")
                mycommand.Parameters.Add("@album_id", SqlDbType.NVarChar).Value = dr("album_id")
            End If
            If tabla = "Albums" Then
                mycommand.Parameters.Add("@release_date", SqlDbType.NVarChar).Value = dr("release_date").ToString.Substring(0, 4)
                mycommand.Parameters.Add("@artist_id", SqlDbType.NVarChar).Value = dr("artist_id")
            End If
            mycommand.ExecuteNonQuery()
            Return True
        Catch ex As SqlException
            Cursor.Current = Cursors.Default
            MsgBox(tabla & " " & ex.Message)
            Return False
        End Try
        myconnect.Close()
        Return True
    End Function

    Public Function SpotifyRequest(URL As String) As String
        Dim request As WebRequest = WebRequest.Create(URL)
        ' If required by the server, set the credentials.
        request.Credentials = CredentialCache.DefaultCredentials

        ' Get the response. 
        Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
        ' Display the status.
        Console.WriteLine(response.StatusDescription)
        ' Get the stream containing content returned by the server. 
        Dim dataStream As Stream = response.GetResponseStream()
        ' Open the stream using a StreamReader for easy access. 
        Dim reader As New StreamReader(dataStream)
        ' Read the content. 
        Dim responseFromServer As String = reader.ReadToEnd()
        ' Display the content.
        Console.WriteLine(responseFromServer)
        ' Cleanup the streams and the response.
        reader.Close()
        dataStream.Close()
        response.Close()

        Return responseFromServer
    End Function

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

        Dim tabla As String
        Dim myconnect As New SqlClient.SqlConnection
        Dim mycommand As SqlCommand = New SqlCommand()


        tabla = "Artists"
        myconnect.ConnectionString = "Server=(localdb)\v11.0;Integrated Security=true;AttachDbFilename=|DataDirectory|\SpotifyDB.mdf"
        myconnect.Open()
        mycommand.Connection = myconnect
        mycommand.CommandText = "SELECT Id, name FROM " & tabla
        Dim myadapter As New SqlDataAdapter(mycommand)
        Dim ds As New DataSet
        myadapter.Fill(ds, tabla)

        myconnect.Close()

        DgvArtistasGuardados.AutoGenerateColumns = True
        DgvArtistasGuardados.DataMember = "Artists"
        DgvArtistasGuardados.DataSource = ds
        DgvArtistasGuardados.Columns(0).Visible = False
        DgvArtistasGuardados.Columns(1).HeaderText = "Artista"
        DgvArtistasGuardados.Columns(1).Width = 100
    End Sub

    Private Sub DgvArtistasGuardados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvArtistasGuardados.CellContentClick
        Dim tabla As String
        Dim myconnect As New SqlClient.SqlConnection
        Dim mycommand As SqlCommand = New SqlCommand()


        tabla = "Artists"
        myconnect.ConnectionString = "Server=(localdb)\v11.0;Integrated Security=true;AttachDbFilename=|DataDirectory|\SpotifyDB.mdf"
        myconnect.Open()
        mycommand.Connection = myconnect
        mycommand.CommandText = "exec ConsultaPorArtista @Id='" & DgvArtistasGuardados.Rows(e.RowIndex).Cells(0).Value & "'"
        Dim myadapter As New SqlDataAdapter(mycommand)
        Dim ds As New DataSet
        myadapter.Fill(ds, tabla)

        myconnect.Close()

        DgvResultadoSp.AutoGenerateColumns = True
        DgvResultadoSp.DataMember = "Artists"
        DgvResultadoSp.DataSource = ds
        DgvResultadoSp.Columns(0).HeaderText = "Album"
        DgvResultadoSp.Columns(1).HeaderText = "Fecha de Lanzamiento"
        DgvResultadoSp.Columns(2).HeaderText = "Popularidad Promedio"
        DgvResultadoSp.Columns(3).HeaderText = "Canción Más Larga"
        DgvResultadoSp.Columns(4).HeaderText = "Duración de Canción Más Larga"
    End Sub
End Class
