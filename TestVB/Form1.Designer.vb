﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.cmdReadMW100 = New System.Windows.Forms.Button()
        Me.cmdWriteMW100 = New System.Windows.Forms.Button()
        Me.cmdShowConfig = New System.Windows.Forms.Button()
        Me.cmdReadMulti = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdReadMW100
        '
        Me.cmdReadMW100.Location = New System.Drawing.Point(12, 45)
        Me.cmdReadMW100.Name = "cmdReadMW100"
        Me.cmdReadMW100.Size = New System.Drawing.Size(108, 27)
        Me.cmdReadMW100.TabIndex = 0
        Me.cmdReadMW100.Text = "MW100 lesen"
        Me.cmdReadMW100.UseVisualStyleBackColor = True
        '
        'cmdWriteMW100
        '
        Me.cmdWriteMW100.Location = New System.Drawing.Point(12, 78)
        Me.cmdWriteMW100.Name = "cmdWriteMW100"
        Me.cmdWriteMW100.Size = New System.Drawing.Size(108, 31)
        Me.cmdWriteMW100.TabIndex = 1
        Me.cmdWriteMW100.Text = "MW100 schreiben"
        Me.cmdWriteMW100.UseVisualStyleBackColor = True
        '
        'cmdShowConfig
        '
        Me.cmdShowConfig.Location = New System.Drawing.Point(12, 12)
        Me.cmdShowConfig.Name = "cmdShowConfig"
        Me.cmdShowConfig.Size = New System.Drawing.Size(108, 27)
        Me.cmdShowConfig.TabIndex = 0
        Me.cmdShowConfig.Text = "Show Config"
        Me.cmdShowConfig.UseVisualStyleBackColor = True
        '
        'cmdReadMulti
        '
        Me.cmdReadMulti.Location = New System.Drawing.Point(13, 129)
        Me.cmdReadMulti.Name = "cmdReadMulti"
        Me.cmdReadMulti.Size = New System.Drawing.Size(108, 42)
        Me.cmdReadMulti.TabIndex = 0
        Me.cmdReadMulti.Text = "Mehrere Werte lesen"
        Me.cmdReadMulti.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(133, 183)
        Me.Controls.Add(Me.cmdWriteMW100)
        Me.Controls.Add(Me.cmdShowConfig)
        Me.Controls.Add(Me.cmdReadMulti)
        Me.Controls.Add(Me.cmdReadMW100)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdReadMW100 As System.Windows.Forms.Button
    Friend WithEvents cmdWriteMW100 As System.Windows.Forms.Button
    Friend WithEvents cmdShowConfig As System.Windows.Forms.Button
    Friend WithEvents cmdReadMulti As System.Windows.Forms.Button

End Class
