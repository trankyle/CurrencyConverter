<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblTitle = New Label()
        cmbFromCurrency = New ComboBox()
        cmbToCurrency = New ComboBox()
        txtAmount = New TextBox()
        txtResult = New TextBox()
        btnConvert = New Button()
        lblStatus = New Label()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(97, 34)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(188, 25)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Currency Converter"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cmbFromCurrency
        ' 
        cmbFromCurrency.FormattingEnabled = True
        cmbFromCurrency.Location = New Point(12, 89)
        cmbFromCurrency.Name = "cmbFromCurrency"
        cmbFromCurrency.Size = New Size(150, 23)
        cmbFromCurrency.TabIndex = 1
        cmbFromCurrency.Text = "Select Currency"
        ' 
        ' cmbToCurrency
        ' 
        cmbToCurrency.FormattingEnabled = True
        cmbToCurrency.Location = New Point(222, 89)
        cmbToCurrency.Name = "cmbToCurrency"
        cmbToCurrency.Size = New Size(150, 23)
        cmbToCurrency.TabIndex = 2
        cmbToCurrency.Text = "Select Currency"
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(12, 146)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(150, 23)
        txtAmount.TabIndex = 3
        ' 
        ' txtResult
        ' 
        txtResult.Location = New Point(222, 146)
        txtResult.Name = "txtResult"
        txtResult.ReadOnly = True
        txtResult.Size = New Size(150, 23)
        txtResult.TabIndex = 4
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(65, 208)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(75, 23)
        btnConvert.TabIndex = 5
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(146, 212)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(77, 15)
        lblStatus.TabIndex = 6
        lblStatus.Text = "Status: Ready"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(384, 261)
        Controls.Add(lblStatus)
        Controls.Add(btnConvert)
        Controls.Add(txtResult)
        Controls.Add(txtAmount)
        Controls.Add(cmbToCurrency)
        Controls.Add(cmbFromCurrency)
        Controls.Add(lblTitle)
        Name = "Form1"
        Text = "Currency Converter"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents cmbFromCurrency As ComboBox
    Friend WithEvents cmbToCurrency As ComboBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents lblStatus As Label

End Class
