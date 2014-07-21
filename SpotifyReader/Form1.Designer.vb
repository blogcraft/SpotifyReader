<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TboxBusqueda = New System.Windows.Forms.TextBox()
        Me.DgvBusqueda = New System.Windows.Forms.DataGridView()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DgvResultadoSp = New System.Windows.Forms.DataGridView()
        Me.DgvArtistasGuardados = New System.Windows.Forms.DataGridView()
        CType(Me.DgvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DgvResultadoSp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvArtistasGuardados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBuscar.Location = New System.Drawing.Point(643, 5)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 0
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TboxBusqueda
        '
        Me.TboxBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TboxBusqueda.Location = New System.Drawing.Point(6, 7)
        Me.TboxBusqueda.Name = "TboxBusqueda"
        Me.TboxBusqueda.Size = New System.Drawing.Size(631, 20)
        Me.TboxBusqueda.TabIndex = 1
        '
        'DgvBusqueda
        '
        Me.DgvBusqueda.AllowUserToAddRows = False
        Me.DgvBusqueda.AllowUserToDeleteRows = False
        Me.DgvBusqueda.AllowUserToResizeRows = False
        Me.DgvBusqueda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBusqueda.Location = New System.Drawing.Point(6, 33)
        Me.DgvBusqueda.MultiSelect = False
        Me.DgvBusqueda.Name = "DgvBusqueda"
        Me.DgvBusqueda.ReadOnly = True
        Me.DgvBusqueda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DgvBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvBusqueda.Size = New System.Drawing.Size(712, 290)
        Me.DgvBusqueda.TabIndex = 2
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardar.Location = New System.Drawing.Point(6, 329)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(712, 23)
        Me.BtnGuardar.TabIndex = 3
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(732, 384)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DgvBusqueda)
        Me.TabPage1.Controls.Add(Me.BtnGuardar)
        Me.TabPage1.Controls.Add(Me.BtnBuscar)
        Me.TabPage1.Controls.Add(Me.TboxBusqueda)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(724, 358)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Busqueda"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DgvResultadoSp)
        Me.TabPage2.Controls.Add(Me.DgvArtistasGuardados)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(724, 358)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mis artistas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DgvResultadoSp
        '
        Me.DgvResultadoSp.AllowUserToAddRows = False
        Me.DgvResultadoSp.AllowUserToDeleteRows = False
        Me.DgvResultadoSp.AllowUserToResizeRows = False
        Me.DgvResultadoSp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvResultadoSp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvResultadoSp.Location = New System.Drawing.Point(237, 6)
        Me.DgvResultadoSp.MultiSelect = False
        Me.DgvResultadoSp.Name = "DgvResultadoSp"
        Me.DgvResultadoSp.ReadOnly = True
        Me.DgvResultadoSp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DgvResultadoSp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvResultadoSp.Size = New System.Drawing.Size(481, 346)
        Me.DgvResultadoSp.TabIndex = 4
        '
        'DgvArtistasGuardados
        '
        Me.DgvArtistasGuardados.AllowUserToAddRows = False
        Me.DgvArtistasGuardados.AllowUserToDeleteRows = False
        Me.DgvArtistasGuardados.AllowUserToResizeRows = False
        Me.DgvArtistasGuardados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DgvArtistasGuardados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvArtistasGuardados.Location = New System.Drawing.Point(6, 6)
        Me.DgvArtistasGuardados.MultiSelect = False
        Me.DgvArtistasGuardados.Name = "DgvArtistasGuardados"
        Me.DgvArtistasGuardados.ReadOnly = True
        Me.DgvArtistasGuardados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DgvArtistasGuardados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvArtistasGuardados.Size = New System.Drawing.Size(225, 346)
        Me.DgvArtistasGuardados.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 408)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Spotify Reader"
        CType(Me.DgvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DgvResultadoSp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvArtistasGuardados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents TboxBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents DgvBusqueda As System.Windows.Forms.DataGridView
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DgvArtistasGuardados As System.Windows.Forms.DataGridView
    Friend WithEvents DgvResultadoSp As System.Windows.Forms.DataGridView

End Class
