﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Forgot_password
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
        Panel3 = New Panel()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        Label9 = New Label()
        Label8 = New Label()
        save = New Button()
        confirm_password = New TextBox()
        password = New TextBox()
        Label6 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Label11 = New Label()
        Label10 = New Label()
        Label7 = New Label()
        proceed = New Button()
        otp = New TextBox()
        Label2 = New Label()
        Panel4 = New Panel()
        Label14 = New Label()
        Label13 = New Label()
        provider = New CheckBox()
        customer = New CheckBox()
        incorrect = New Label()
        send = New Button()
        Email = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Panel1 = New Panel()
        designlabel1 = New Label()
        taskmakerrbtn = New Button()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(CheckBox2)
        Panel3.Controls.Add(CheckBox1)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(save)
        Panel3.Controls.Add(confirm_password)
        Panel3.Controls.Add(password)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(589, 167)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(488, 305)
        Panel3.TabIndex = 10
        Panel3.Visible = False
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(377, 114)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(67, 24)
        CheckBox2.TabIndex = 15
        CheckBox2.Text = "Show"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(377, 68)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(67, 24)
        CheckBox1.TabIndex = 14
        CheckBox1.Text = "Show"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 15.0F)
        Label9.Location = New Point(5, 3)
        Label9.Name = "Label9"
        Label9.Size = New Size(186, 35)
        Label9.TabIndex = 13
        Label9.Text = "Password Reset"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 8.0F)
        Label8.ForeColor = Color.Red
        Label8.Location = New Point(171, 137)
        Label8.Name = "Label8"
        Label8.Size = New Size(49, 19)
        Label8.TabIndex = 12
        Label8.Text = "Label8"
        Label8.Visible = False
        ' 
        ' save
        ' 
        save.BackColor = Color.FromArgb(CByte(173), CByte(103), CByte(200))
        save.FlatStyle = FlatStyle.Flat
        save.Font = New Font("Segoe UI", 12.0F)
        save.ForeColor = Color.White
        save.Location = New Point(133, 177)
        save.Name = "save"
        save.Size = New Size(109, 38)
        save.TabIndex = 4
        save.Text = "SAVE"
        save.UseVisualStyleBackColor = False
        ' 
        ' confirm_password
        ' 
        confirm_password.Location = New Point(173, 109)
        confirm_password.Name = "confirm_password"
        confirm_password.PasswordChar = "*"c
        confirm_password.Size = New Size(198, 27)
        confirm_password.TabIndex = 3
        ' 
        ' password
        ' 
        password.Location = New Point(171, 64)
        password.Name = "password"
        password.PasswordChar = "*"c
        password.Size = New Size(200, 27)
        password.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.0F)
        Label6.Location = New Point(21, 113)
        Label6.Name = "Label6"
        Label6.Size = New Size(146, 23)
        Label6.TabIndex = 1
        Label6.Text = "Confrim Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.0F)
        Label1.Location = New Point(21, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 23)
        Label1.TabIndex = 0
        Label1.Text = "New Password"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(proceed)
        Panel2.Controls.Add(otp)
        Panel2.Location = New Point(582, 170)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(359, 305)
        Panel2.TabIndex = 9
        Panel2.Visible = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(8, 84)
        Label11.Name = "Label11"
        Label11.Size = New Size(106, 20)
        Label11.TabIndex = 13
        Label11.Text = "Enter your OTP"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 15.0F)
        Label10.Location = New Point(5, 3)
        Label10.Name = "Label10"
        Label10.Size = New Size(186, 35)
        Label10.TabIndex = 12
        Label10.Text = "Password Reset"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.Control
        Label7.Font = New Font("Segoe UI", 8.0F)
        Label7.ForeColor = Color.Red
        Label7.Location = New Point(37, 132)
        Label7.Name = "Label7"
        Label7.Size = New Size(96, 19)
        Label7.TabIndex = 11
        Label7.Text = "Incorrect OTP "
        Label7.Visible = False
        ' 
        ' proceed
        ' 
        proceed.BackColor = Color.FromArgb(CByte(173), CByte(103), CByte(200))
        proceed.FlatStyle = FlatStyle.Flat
        proceed.Font = New Font("Segoe UI", 12.0F)
        proceed.ForeColor = Color.White
        proceed.Location = New Point(86, 169)
        proceed.Name = "proceed"
        proceed.Size = New Size(117, 38)
        proceed.TabIndex = 2
        proceed.Text = "Proceed"
        proceed.UseVisualStyleBackColor = False
        ' 
        ' otp
        ' 
        otp.Location = New Point(37, 107)
        otp.Name = "otp"
        otp.Size = New Size(166, 27)
        otp.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 23)
        Label2.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label14)
        Panel4.Controls.Add(Label13)
        Panel4.Controls.Add(provider)
        Panel4.Controls.Add(customer)
        Panel4.Controls.Add(incorrect)
        Panel4.Controls.Add(send)
        Panel4.Controls.Add(Email)
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(Label5)
        Panel4.Location = New Point(579, 167)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(359, 328)
        Panel4.TabIndex = 8
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 8.0F)
        Label14.ForeColor = Color.Red
        Label14.Location = New Point(17, 231)
        Label14.Name = "Label14"
        Label14.Size = New Size(57, 19)
        Label14.TabIndex = 17
        Label14.Text = "Label14"
        Label14.Visible = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(17, 184)
        Label13.Name = "Label13"
        Label13.Size = New Size(269, 17)
        Label13.TabIndex = 16
        Label13.Text = "Select whether you are customer or provider"
        ' 
        ' provider
        ' 
        provider.AutoSize = True
        provider.Location = New Point(193, 204)
        provider.Name = "provider"
        provider.Size = New Size(86, 24)
        provider.TabIndex = 15
        provider.Text = "Provider"
        provider.UseVisualStyleBackColor = True
        ' 
        ' customer
        ' 
        customer.AutoSize = True
        customer.Location = New Point(17, 204)
        customer.Name = "customer"
        customer.Size = New Size(94, 24)
        customer.TabIndex = 14
        customer.Text = "Customer"
        customer.UseVisualStyleBackColor = True
        ' 
        ' incorrect
        ' 
        incorrect.AutoSize = True
        incorrect.Font = New Font("Segoe UI", 8.0F)
        incorrect.ForeColor = Color.Red
        incorrect.Location = New Point(17, 158)
        incorrect.Name = "incorrect"
        incorrect.Size = New Size(151, 19)
        incorrect.TabIndex = 4
        incorrect.Text = "Please enter valid Email"
        incorrect.Visible = False
        ' 
        ' send
        ' 
        send.BackColor = Color.FromArgb(CByte(173), CByte(103), CByte(200))
        send.FlatStyle = FlatStyle.Flat
        send.Font = New Font("Segoe UI", 12.0F)
        send.ForeColor = Color.White
        send.Location = New Point(67, 287)
        send.Name = "send"
        send.Size = New Size(175, 38)
        send.TabIndex = 1
        send.Text = "Send OTP"
        send.UseVisualStyleBackColor = False
        ' 
        ' Email
        ' 
        Email.Location = New Point(17, 133)
        Email.Name = "Email"
        Email.Size = New Size(292, 27)
        Email.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 2
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(5, 47)
        Label4.Name = "Label4"
        Label4.Size = New Size(338, 40)
        Label4.TabIndex = 1
        Label4.Text = "Enter your email address below, and we will send " & vbCrLf & "you a OTP to your Email."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.0F)
        Label5.Location = New Point(5, 3)
        Label5.Name = "Label5"
        Label5.Size = New Size(186, 35)
        Label5.TabIndex = 0
        Label5.Text = "Password Reset"
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.Landing_Logo1
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(designlabel1)
        Panel1.Controls.Add(taskmakerrbtn)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(425, 673)
        Panel1.TabIndex = 2
        ' 
        ' designlabel1
        ' 
        designlabel1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        designlabel1.BackColor = Color.Transparent
        designlabel1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        designlabel1.Location = New Point(41, 508)
        designlabel1.Name = "designlabel1"
        designlabel1.Size = New Size(337, 36)
        designlabel1.TabIndex = 1
        designlabel1.Text = "Get thousands of services at one click"
        designlabel1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' taskmakerrbtn
        ' 
        taskmakerrbtn.BackColor = Color.Transparent
        taskmakerrbtn.BackgroundImage = My.Resources.Resources.TM_Logo_1
        taskmakerrbtn.BackgroundImageLayout = ImageLayout.Stretch
        taskmakerrbtn.FlatAppearance.BorderSize = 0
        taskmakerrbtn.FlatStyle = FlatStyle.Flat
        taskmakerrbtn.Location = New Point(25, 25)
        taskmakerrbtn.Name = "taskmakerrbtn"
        taskmakerrbtn.Size = New Size(56, 56)
        taskmakerrbtn.TabIndex = 0
        taskmakerrbtn.UseVisualStyleBackColor = False
        ' 
        ' Forgot_password
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(1134, 673)
        Controls.Add(Panel1)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Name = "Forgot_password"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Forgot_password"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents save As Button
    Friend WithEvents confirm_password As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents proceed As Button
    Friend WithEvents otp As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents send As Button
    Friend WithEvents Email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents designlabel1 As Label
    Friend WithEvents taskmakerrbtn As Button
    Friend WithEvents incorrect As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents customer As CheckBox
    Friend WithEvents provider As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
