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
        btnTotal = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtPrice = New TextBox()
        txtQuantity = New TextBox()
        Label3 = New Label()
        txtNameOfCustomer = New TextBox()
        SuspendLayout()
        ' 
        ' btnTotal
        ' 
        btnTotal.Location = New Point(300, 229)
        btnTotal.Name = "btnTotal"
        btnTotal.Size = New Size(178, 29)
        btnTotal.TabIndex = 0
        btnTotal.Text = "Total for Customer"
        btnTotal.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(164, 106)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 20)
        Label1.TabIndex = 1
        Label1.Text = "Price Per Item"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(172, 154)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 20)
        Label2.TabIndex = 2
        Label2.Text = "Quantity"
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(343, 102)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(125, 27)
        txtPrice.TabIndex = 3
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(344, 149)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(125, 27)
        txtQuantity.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(187, 197)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 20)
        Label3.TabIndex = 5
        Label3.Text = "Name of Customer"
        ' 
        ' txtNameOfCustomer
        ' 
        txtNameOfCustomer.Location = New Point(343, 190)
        txtNameOfCustomer.Name = "txtNameOfCustomer"
        txtNameOfCustomer.Size = New Size(125, 27)
        txtNameOfCustomer.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(txtNameOfCustomer)
        Controls.Add(txtQuantity)
        Controls.Add(txtPrice)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnTotal)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTotal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNameOfCustomer As TextBox
End Class
