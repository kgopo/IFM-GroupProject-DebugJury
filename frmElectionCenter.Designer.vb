<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmElectionCenter
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
        Me.btninitElections = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btninitElections
        '
        Me.btninitElections.Location = New System.Drawing.Point(12, 35)
        Me.btninitElections.Name = "btninitElections"
        Me.btninitElections.Size = New System.Drawing.Size(133, 36)
        Me.btninitElections.TabIndex = 0
        Me.btninitElections.Text = "Button1"
        Me.btninitElections.UseVisualStyleBackColor = True
        '
        'frmElectionCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 271)
        Me.Controls.Add(Me.btninitElections)
        Me.Name = "frmElectionCenter"
        Me.Text = "frmElectionCenter"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btninitElections As Button
End Class
