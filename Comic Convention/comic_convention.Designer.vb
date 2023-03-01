<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class comic_convention
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(comic_convention))
        Me.picComic = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.grpBadgeType = New System.Windows.Forms.GroupBox()
        Me.radConvention = New System.Windows.Forms.RadioButton()
        Me.radAutograph = New System.Windows.Forms.RadioButton()
        Me.radSuper = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblCost = New System.Windows.Forms.Label()
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBadgeType.SuspendLayout()
        Me.SuspendLayout()
        '
        'picComic
        '
        Me.picComic.Image = CType(resources.GetObject("picComic.Image"), System.Drawing.Image)
        Me.picComic.Location = New System.Drawing.Point(1, 1)
        Me.picComic.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picComic.Name = "picComic"
        Me.picComic.Size = New System.Drawing.Size(590, 168)
        Me.picComic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picComic.TabIndex = 0
        Me.picComic.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(53, 194)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(484, 45)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Comic Convention Registration"
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSize.Location = New System.Drawing.Point(187, 250)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(132, 30)
        Me.lblSize.TabIndex = 2
        Me.lblSize.Text = "Group Size:"
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(354, 257)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(66, 23)
        Me.txtSize.TabIndex = 3
        '
        'grpBadgeType
        '
        Me.grpBadgeType.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.grpBadgeType.Controls.Add(Me.radConvention)
        Me.grpBadgeType.Controls.Add(Me.radAutograph)
        Me.grpBadgeType.Controls.Add(Me.radSuper)
        Me.grpBadgeType.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBadgeType.ForeColor = System.Drawing.Color.OrangeRed
        Me.grpBadgeType.Location = New System.Drawing.Point(95, 298)
        Me.grpBadgeType.Name = "grpBadgeType"
        Me.grpBadgeType.Size = New System.Drawing.Size(402, 131)
        Me.grpBadgeType.TabIndex = 4
        Me.grpBadgeType.TabStop = False
        Me.grpBadgeType.Text = "Select Badge Type: "
        '
        'radConvention
        '
        Me.radConvention.AutoSize = True
        Me.radConvention.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radConvention.Location = New System.Drawing.Point(26, 98)
        Me.radConvention.Name = "radConvention"
        Me.radConvention.Size = New System.Drawing.Size(126, 31)
        Me.radConvention.TabIndex = 2
        Me.radConvention.Text = "Convention"
        Me.radConvention.UseVisualStyleBackColor = True
        '
        'radAutograph
        '
        Me.radAutograph.AutoSize = True
        Me.radAutograph.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAutograph.Location = New System.Drawing.Point(26, 65)
        Me.radAutograph.Name = "radAutograph"
        Me.radAutograph.Size = New System.Drawing.Size(248, 31)
        Me.radAutograph.TabIndex = 1
        Me.radAutograph.Text = "Convention + Autograph"
        Me.radAutograph.UseVisualStyleBackColor = True
        '
        'radSuper
        '
        Me.radSuper.AutoSize = True
        Me.radSuper.Checked = True
        Me.radSuper.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSuper.Location = New System.Drawing.Point(26, 32)
        Me.radSuper.Name = "radSuper"
        Me.radSuper.Size = New System.Drawing.Size(356, 31)
        Me.radSuper.TabIndex = 0
        Me.radSuper.TabStop = True
        Me.radSuper.Text = "Convention + Superhero Experience"
        Me.radSuper.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(123, 442)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Registration Costs:"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCalculate.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCalculate.Location = New System.Drawing.Point(95, 502)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(116, 37)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnClear.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClear.Location = New System.Drawing.Point(383, 502)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 37)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(362, 442)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(115, 30)
        Me.lblCost.TabIndex = 8
        Me.lblCost.Text = "$0000.00"
        '
        'comic_convention
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 565)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpBadgeType)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picComic)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.OrangeRed
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "comic_convention"
        Me.Text = "Comic Convention Registration"
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBadgeType.ResumeLayout(False)
        Me.grpBadgeType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picComic As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblSize As Label
    Friend WithEvents txtSize As TextBox
    Friend WithEvents grpBadgeType As GroupBox
    Friend WithEvents radConvention As RadioButton
    Friend WithEvents radAutograph As RadioButton
    Friend WithEvents radSuper As RadioButton

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles radAutograph.CheckedChanged

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button

    Private Sub comic_convention_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This event handler is executed whne the Comic Convention Form is loaded

        lblCost.Text = ""
    End Sub

    Friend WithEvents lblCost As Label

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'This event handler is executes when the user clicks the Calculate button.
        'It calculate the total registration costs.
        'Declaration section
        Dim intGroup As Integer = 0
        Dim decRegistration As Decimal
        Dim decTotalCost As Decimal
        Dim decSuperHero As Decimal = 380D
        Dim decAutographs As Decimal = 275D
        Dim decConvention As Decimal = 209D

        'Did user enter a numeric value 
        If IsNumeric(txtSize.Text) Then
            intGroup = Convert.ToInt32(txtSize.Text)
            'Is number of group greater than zero
            If intGroup > 0 And intGroup < 20 Then
                'Calculate and display cost
                If radSuper.Checked Then
                    decRegistration = decSuperHero
                ElseIf radAutograph.Checked Then
                    decRegistration = decAutographs
                ElseIf radConvention.Checked Then
                    decRegistration = decConvention
                End If

                decTotalCost = (intGroup * decRegistration)
                lblCost.Text = decTotalCost.ToString("C")
            Else
                'Display error messageis user entered a negative number
                MsgBox("Enter a positive number between 1 and 20", , "Invalid Number Error")
            End If
        Else
            'Display error message is user enterd a nonnumeric value
            MsgBox("Enter a reasonable number between 1 and 20", , "Invalid Entry Error")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSize.Clear()
        lblCost.Text = ""
        radSuper.Checked = True
        radAutograph.Checked = False
        radConvention.Checked = False
        txtSize.Focus()
    End Sub
End Class
