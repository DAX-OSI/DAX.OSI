<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EVENT_HANDLER
    Inherits UI.BlankWindow

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
        Me.LblProcessingEvent = New DAX.OSI.UI.UILabel()
        Me.SuspendLayout()
        '
        'LblProcessingEvent
        '
        Me.LblProcessingEvent.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LblProcessingEvent.BackColor = System.Drawing.Color.Transparent
        Me.LblProcessingEvent.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProcessingEvent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblProcessingEvent.Location = New System.Drawing.Point(165, 400)
        Me.LblProcessingEvent.Name = "LblProcessingEvent"
        Me.LblProcessingEvent.Size = New System.Drawing.Size(310, 17)
        Me.LblProcessingEvent.TabIndex = 0
        Me.LblProcessingEvent.Text = "Processing event...Please wait..."
        Me.LblProcessingEvent.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EVENT_HANDLER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(640, 480)
        Me.Controls.Add(Me.LblProcessingEvent)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "EVENT_HANDLER"
        Me.Text = "EVENT_HANDLER"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblProcessingEvent As UI.UILabel
End Class
