<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ttls = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dlt = New System.Windows.Forms.Button()
        Me.bno = New System.Windows.Forms.NumericUpDown()
        Me.show = New System.Windows.Forms.Button()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView
        '
        Me.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridView.Location = New System.Drawing.Point(0, 134)
        Me.GridView.Name = "GridView"
        Me.GridView.RowTemplate.Height = 25
        Me.GridView.Size = New System.Drawing.Size(800, 316)
        Me.GridView.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(337, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Book Store"
        '
        'ttls
        '
        Me.ttls.FormattingEnabled = True
        Me.ttls.Location = New System.Drawing.Point(12, 105)
        Me.ttls.Name = "ttls"
        Me.ttls.Size = New System.Drawing.Size(314, 23)
        Me.ttls.TabIndex = 2
        Me.ttls.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(460, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Delete book by book id"
        '
        'dlt
        '
        Me.dlt.Location = New System.Drawing.Point(713, 105)
        Me.dlt.Name = "dlt"
        Me.dlt.Size = New System.Drawing.Size(75, 23)
        Me.dlt.TabIndex = 5
        Me.dlt.Text = "Delete"
        Me.dlt.UseVisualStyleBackColor = True
        '
        'bno
        '
        Me.bno.Location = New System.Drawing.Point(618, 105)
        Me.bno.Name = "bno"
        Me.bno.Size = New System.Drawing.Size(89, 23)
        Me.bno.TabIndex = 6
        '
        'show
        '
        Me.show.Location = New System.Drawing.Point(337, 105)
        Me.show.Name = "show"
        Me.show.Size = New System.Drawing.Size(75, 23)
        Me.show.TabIndex = 7
        Me.show.Text = "Show all"
        Me.show.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.show)
        Me.Controls.Add(Me.bno)
        Me.Controls.Add(Me.dlt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ttls)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridView)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ttls As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dlt As Button
    Friend WithEvents bno As NumericUpDown
    Friend WithEvents show As Button
End Class
