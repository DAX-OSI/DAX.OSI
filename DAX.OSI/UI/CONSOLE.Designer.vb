<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CONSOLE
    Inherits UI.Window

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
        Me.ConsoleWidget = New DAX.OSI.UI.UIConsole()
        Me.SuspendLayout()
        '
        'ConsoleWidget
        '
        Me.ConsoleWidget.BackColor = System.Drawing.Color.Transparent
        Me.ConsoleWidget.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConsoleWidget.Location = New System.Drawing.Point(2, 24)
        Me.ConsoleWidget.Name = "ConsoleWidget"
        Me.ConsoleWidget.Size = New System.Drawing.Size(558, 219)
        Me.ConsoleWidget.TabIndex = 1
        '
        'CONSOLE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 245)
        Me.Controls.Add(Me.ConsoleWidget)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "CONSOLE"
        Me.ShowIcon = False
        Me.Text = "DAX OSI Console"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ConsoleWidget As UI.UIConsole
End Class
