<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.teks = New System.Windows.Forms.TextBox()
        Me.bbarcode = New System.Windows.Forms.Button()
        Me.bqrcode = New System.Windows.Forms.Button()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic1
        '
        Me.pic1.BackColor = System.Drawing.Color.White
        Me.pic1.Location = New System.Drawing.Point(10, 2)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(434, 438)
        Me.pic1.TabIndex = 0
        Me.pic1.TabStop = False
        '
        'teks
        '
        Me.teks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teks.Location = New System.Drawing.Point(10, 446)
        Me.teks.Name = "teks"
        Me.teks.Size = New System.Drawing.Size(430, 39)
        Me.teks.TabIndex = 1
        '
        'bbarcode
        '
        Me.bbarcode.Location = New System.Drawing.Point(9, 497)
        Me.bbarcode.Name = "bbarcode"
        Me.bbarcode.Size = New System.Drawing.Size(213, 80)
        Me.bbarcode.TabIndex = 2
        Me.bbarcode.Text = "Generate Barcode"
        Me.bbarcode.UseVisualStyleBackColor = True
        '
        'bqrcode
        '
        Me.bqrcode.Location = New System.Drawing.Point(231, 497)
        Me.bqrcode.Name = "bqrcode"
        Me.bqrcode.Size = New System.Drawing.Size(213, 80)
        Me.bqrcode.TabIndex = 3
        Me.bqrcode.Text = "Generate QRCode"
        Me.bqrcode.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 589)
        Me.Controls.Add(Me.bqrcode)
        Me.Controls.Add(Me.bbarcode)
        Me.Controls.Add(Me.teks)
        Me.Controls.Add(Me.pic1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic1 As PictureBox
    Friend WithEvents teks As TextBox
    Friend WithEvents bbarcode As Button
    Friend WithEvents bqrcode As Button
End Class
