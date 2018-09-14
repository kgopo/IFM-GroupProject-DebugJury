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
        Me.btnClubDetails = New System.Windows.Forms.Button()
        Me.txtClubDesplay = New System.Windows.Forms.TextBox()
        Me.btnUpdateMember = New System.Windows.Forms.Button()
        Me.btnAddMember = New System.Windows.Forms.Button()
        Me.btnInitElections = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClubDetails
        '
        Me.btnClubDetails.Location = New System.Drawing.Point(12, 12)
        Me.btnClubDetails.Name = "btnClubDetails"
        Me.btnClubDetails.Size = New System.Drawing.Size(110, 48)
        Me.btnClubDetails.TabIndex = 0
        Me.btnClubDetails.Text = "Update Club Details"
        Me.btnClubDetails.UseVisualStyleBackColor = True
        '
        'txtClubDesplay
        '
        Me.txtClubDesplay.Location = New System.Drawing.Point(128, 12)
        Me.txtClubDesplay.Multiline = True
        Me.txtClubDesplay.Name = "txtClubDesplay"
        Me.txtClubDesplay.ReadOnly = True
        Me.txtClubDesplay.Size = New System.Drawing.Size(344, 210)
        Me.txtClubDesplay.TabIndex = 1
        '
        'btnUpdateMember
        '
        Me.btnUpdateMember.Location = New System.Drawing.Point(12, 66)
        Me.btnUpdateMember.Name = "btnUpdateMember"
        Me.btnUpdateMember.Size = New System.Drawing.Size(110, 48)
        Me.btnUpdateMember.TabIndex = 2
        Me.btnUpdateMember.Text = "Update Member"
        Me.btnUpdateMember.UseVisualStyleBackColor = True
        '
        'btnAddMember
        '
        Me.btnAddMember.Location = New System.Drawing.Point(12, 120)
        Me.btnAddMember.Name = "btnAddMember"
        Me.btnAddMember.Size = New System.Drawing.Size(110, 48)
        Me.btnAddMember.TabIndex = 3
        Me.btnAddMember.Text = "Add Memeber"
        Me.btnAddMember.UseVisualStyleBackColor = True
        '
        'btnInitElections
        '
        Me.btnInitElections.Location = New System.Drawing.Point(12, 174)
        Me.btnInitElections.Name = "btnInitElections"
        Me.btnInitElections.Size = New System.Drawing.Size(110, 48)
        Me.btnInitElections.TabIndex = 4
        Me.btnInitElections.Text = "Initialise Elections"
        Me.btnInitElections.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 230)
        Me.Controls.Add(Me.btnInitElections)
        Me.Controls.Add(Me.btnAddMember)
        Me.Controls.Add(Me.btnUpdateMember)
        Me.Controls.Add(Me.txtClubDesplay)
        Me.Controls.Add(Me.btnClubDetails)
        Me.Name = "Form1"
        Me.Text = "DebugDury(studio)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClubDetails As Button
    Friend WithEvents txtClubDesplay As TextBox
    Friend WithEvents btnUpdateMember As Button
    Friend WithEvents btnAddMember As Button
    Friend WithEvents btnInitElections As Button
End Class
