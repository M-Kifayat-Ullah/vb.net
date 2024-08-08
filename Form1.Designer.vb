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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.userid = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.userage = New System.Windows.Forms.TextBox()
        Me.Physics = New System.Windows.Forms.CheckBox()
        Me.Math = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AddRow = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.update = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CrystalReport = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(77, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1124, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UserId"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(74, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "UserName"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(74, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "UserAge"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(150, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 17)
        Me.Label4.TabIndex = 3
        '
        'userid
        '
        Me.userid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.userid.Location = New System.Drawing.Point(165, 57)
        Me.userid.Name = "userid"
        Me.userid.Size = New System.Drawing.Size(1269, 22)
        Me.userid.TabIndex = 4
        '
        'username
        '
        Me.username.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.username.Location = New System.Drawing.Point(165, 95)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(1269, 22)
        Me.username.TabIndex = 5
        '
        'userage
        '
        Me.userage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.userage.Location = New System.Drawing.Point(165, 133)
        Me.userage.Name = "userage"
        Me.userage.Size = New System.Drawing.Size(1269, 22)
        Me.userage.TabIndex = 6
        '
        'Physics
        '
        Me.Physics.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Physics.AutoSize = True
        Me.Physics.BackColor = System.Drawing.SystemColors.GrayText
        Me.Physics.ForeColor = System.Drawing.SystemColors.Control
        Me.Physics.Location = New System.Drawing.Point(213, 183)
        Me.Physics.Name = "Physics"
        Me.Physics.Size = New System.Drawing.Size(78, 21)
        Me.Physics.TabIndex = 7
        Me.Physics.Text = "Physics"
        Me.Physics.UseVisualStyleBackColor = False
        '
        'Math
        '
        Me.Math.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Math.AutoSize = True
        Me.Math.BackColor = System.Drawing.SystemColors.GrayText
        Me.Math.ForeColor = System.Drawing.SystemColors.Control
        Me.Math.Location = New System.Drawing.Point(316, 183)
        Me.Math.Name = "Math"
        Me.Math.Size = New System.Drawing.Size(61, 21)
        Me.Math.TabIndex = 8
        Me.Math.Text = "Math"
        Me.Math.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GrayText
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(436, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 46)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AddRow
        '
        Me.AddRow.BackColor = System.Drawing.SystemColors.GrayText
        Me.AddRow.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddRow.ForeColor = System.Drawing.SystemColors.Control
        Me.AddRow.Location = New System.Drawing.Point(566, 225)
        Me.AddRow.Name = "AddRow"
        Me.AddRow.Size = New System.Drawing.Size(110, 46)
        Me.AddRow.TabIndex = 10
        Me.AddRow.Text = "Add Row"
        Me.AddRow.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(451, 335)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 55
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(653, 310)
        Me.DataGridView1.TabIndex = 11
        '
        'update
        '
        Me.update.BackColor = System.Drawing.SystemColors.GrayText
        Me.update.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update.ForeColor = System.Drawing.SystemColors.Control
        Me.update.Location = New System.Drawing.Point(697, 225)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(110, 46)
        Me.update.TabIndex = 12
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.GrayText
        Me.Button3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Location = New System.Drawing.Point(844, 225)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 46)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'CrystalReport
        '
        Me.CrystalReport.BackColor = System.Drawing.SystemColors.GrayText
        Me.CrystalReport.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CrystalReport.ForeColor = System.Drawing.SystemColors.Control
        Me.CrystalReport.Location = New System.Drawing.Point(981, 225)
        Me.CrystalReport.Name = "CrystalReport"
        Me.CrystalReport.Size = New System.Drawing.Size(132, 46)
        Me.CrystalReport.TabIndex = 14
        Me.CrystalReport.Text = "Crystal Report"
        Me.CrystalReport.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1492, 751)
        Me.Controls.Add(Me.CrystalReport)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.AddRow)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Math)
        Me.Controls.Add(Me.Physics)
        Me.Controls.Add(Me.userage)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.userid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Crystal Report"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents userid As TextBox
	Friend WithEvents username As TextBox
	Friend WithEvents userage As TextBox
	Friend WithEvents Physics As CheckBox
	Friend WithEvents Math As CheckBox
	Friend WithEvents Button1 As Button
    Friend WithEvents AddRow As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents update As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents CrystalReport As Button
End Class
