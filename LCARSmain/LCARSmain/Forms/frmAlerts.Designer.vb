﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlerts
    Inherits LCARS.LCARSForm

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
        Me.tbTitle = New LCARS.Controls.TextButton
        Me.tbBottom = New LCARS.Controls.TextButton
        Me.myGrid = New LCARS.Controls.ButtonGrid
        Me.FlatButton1 = New LCARS.Controls.FlatButton
        Me.SuspendLayout()
        '
        'tbTitle
        '
        Me.tbTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTitle.ButtonText = "ALERTS"
        Me.tbTitle.ButtonTextHeight = 24
        Me.tbTitle.Color = LCARS.LCARScolorStyles.FunctionOffline
        Me.tbTitle.Location = New System.Drawing.Point(13, 13)
        Me.tbTitle.Name = "tbTitle"
        Me.tbTitle.Size = New System.Drawing.Size(519, 24)
        Me.tbTitle.TabIndex = 1
        Me.tbTitle.Text = "ALERTS"
        '
        'tbBottom
        '
        Me.tbBottom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbBottom.ButtonText = ""
        Me.tbBottom.ButtonTextHeight = 24
        Me.tbBottom.Color = LCARS.LCARScolorStyles.FunctionOffline
        Me.tbBottom.Location = New System.Drawing.Point(12, 406)
        Me.tbBottom.Name = "tbBottom"
        Me.tbBottom.Size = New System.Drawing.Size(520, 24)
        Me.tbBottom.TabIndex = 2
        '
        'myGrid
        '
        Me.myGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.myGrid.Location = New System.Drawing.Point(13, 42)
        Me.myGrid.MinimumSize = New System.Drawing.Size(50, 50)
        Me.myGrid.Name = "myGrid"
        Me.myGrid.Size = New System.Drawing.Size(371, 358)
        Me.myGrid.TabIndex = 3
        Me.myGrid.Text = "ButtonGrid1"
        '
        'FlatButton1
        '
        Me.FlatButton1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatButton1.ButtonText = "CANCEL ALERT"
        Me.FlatButton1.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.FlatButton1.ButtonTextHeight = 22
        Me.FlatButton1.Color = LCARS.LCARScolorStyles.CriticalFunction
        Me.FlatButton1.Location = New System.Drawing.Point(390, 42)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Size = New System.Drawing.Size(142, 358)
        Me.FlatButton1.TabIndex = 4
        Me.FlatButton1.Text = "CANCEL ALERT"
        '
        'frmAlerts
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(544, 438)
        Me.Controls.Add(Me.FlatButton1)
        Me.Controls.Add(Me.myGrid)
        Me.Controls.Add(Me.tbBottom)
        Me.Controls.Add(Me.tbTitle)
        Me.Font = New System.Drawing.Font("LCARS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Orange
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Name = "frmAlerts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Alerts"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbTitle As LCARS.Controls.TextButton
    Friend WithEvents tbBottom As LCARS.Controls.TextButton
    Friend WithEvents myGrid As LCARS.Controls.ButtonGrid
    Friend WithEvents FlatButton1 As LCARS.Controls.FlatButton
End Class
