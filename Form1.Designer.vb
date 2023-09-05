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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txthk1 = New TextBox()
        txthk2 = New TextBox()
        txttb = New TextBox()
        txtkq = New TextBox()
        txthl = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(107, 125)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 15)
        Label1.TabIndex = 0
        Label1.Text = "Điểm HKI"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(107, 168)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 0
        Label2.Text = "Điểm HKII"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(107, 215)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 15)
        Label3.TabIndex = 0
        Label3.Text = "Điểm Trung Bình"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(107, 258)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 15)
        Label4.TabIndex = 0
        Label4.Text = "Kết Quả"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(107, 295)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 15)
        Label5.TabIndex = 0
        Label5.Text = "Xếp Loại Học Lực"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(231, 25)
        Label6.Name = "Label6"
        Label6.Size = New Size(300, 54)
        Label6.TabIndex = 0
        Label6.Text = "kết quả học tập"
        ' 
        ' txthk1
        ' 
        txthk1.Location = New Point(231, 117)
        txthk1.Name = "txthk1"
        txthk1.Size = New Size(219, 23)
        txthk1.TabIndex = 1
        ' 
        ' txthk2
        ' 
        txthk2.Location = New Point(231, 165)
        txthk2.Name = "txthk2"
        txthk2.Size = New Size(219, 23)
        txthk2.TabIndex = 1
        ' 
        ' txttb
        ' 
        txttb.Location = New Point(231, 212)
        txttb.Name = "txttb"
        txttb.Size = New Size(219, 23)
        txttb.TabIndex = 1
        ' 
        ' txtkq
        ' 
        txtkq.Location = New Point(231, 255)
        txtkq.Name = "txtkq"
        txtkq.Size = New Size(219, 23)
        txtkq.TabIndex = 1
        ' 
        ' txthl
        ' 
        txthl.Location = New Point(231, 295)
        txthl.Name = "txthl"
        txthl.Size = New Size(219, 23)
        txthl.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(352, 353)
        Button1.Name = "Button1"
        Button1.Size = New Size(98, 32)
        Button1.TabIndex = 2
        Button1.Text = "Xem Kết Quả"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(txthl)
        Controls.Add(txtkq)
        Controls.Add(txttb)
        Controls.Add(txthk2)
        Controls.Add(txthk1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label6)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txthk1 As TextBox
    Friend WithEvents txthk2 As TextBox
    Friend WithEvents txttb As TextBox
    Friend WithEvents txtkq As TextBox
    Friend WithEvents txthl As TextBox
    Friend WithEvents Button1 As Button
End Class
