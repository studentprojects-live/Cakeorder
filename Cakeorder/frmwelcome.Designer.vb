<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmwelcome
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MASTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FLAVOURToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CAKESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.REPORTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ORDERREPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.USERREPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.REGISTRATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ORDERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SALESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MASTERToolStripMenuItem, Me.ORDERToolStripMenuItem, Me.SALESToolStripMenuItem, Me.LOGOUTToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(664, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MASTERToolStripMenuItem
        '
        Me.MASTERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FLAVOURToolStripMenuItem, Me.CAKESToolStripMenuItem, Me.REPORTSToolStripMenuItem, Me.REGISTRATIONToolStripMenuItem})
        Me.MASTERToolStripMenuItem.Name = "MASTERToolStripMenuItem"
        Me.MASTERToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.MASTERToolStripMenuItem.Text = "MASTER"
        '
        'FLAVOURToolStripMenuItem
        '
        Me.FLAVOURToolStripMenuItem.Name = "FLAVOURToolStripMenuItem"
        Me.FLAVOURToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.FLAVOURToolStripMenuItem.Text = "FLAVOUR"
        '
        'CAKESToolStripMenuItem
        '
        Me.CAKESToolStripMenuItem.Name = "CAKESToolStripMenuItem"
        Me.CAKESToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.CAKESToolStripMenuItem.Text = "CAKES"
        '
        'REPORTSToolStripMenuItem
        '
        Me.REPORTSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ORDERREPORTToolStripMenuItem, Me.USERREPORTToolStripMenuItem})
        Me.REPORTSToolStripMenuItem.Name = "REPORTSToolStripMenuItem"
        Me.REPORTSToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.REPORTSToolStripMenuItem.Text = "REPORTS"
        '
        'ORDERREPORTToolStripMenuItem
        '
        Me.ORDERREPORTToolStripMenuItem.Name = "ORDERREPORTToolStripMenuItem"
        Me.ORDERREPORTToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ORDERREPORTToolStripMenuItem.Text = "ORDER REPORT"
        '
        'USERREPORTToolStripMenuItem
        '
        Me.USERREPORTToolStripMenuItem.Name = "USERREPORTToolStripMenuItem"
        Me.USERREPORTToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.USERREPORTToolStripMenuItem.Text = "USER REPORT"
        '
        'REGISTRATIONToolStripMenuItem
        '
        Me.REGISTRATIONToolStripMenuItem.Name = "REGISTRATIONToolStripMenuItem"
        Me.REGISTRATIONToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.REGISTRATIONToolStripMenuItem.Text = "REGISTRATION"
        '
        'ORDERToolStripMenuItem
        '
        Me.ORDERToolStripMenuItem.Name = "ORDERToolStripMenuItem"
        Me.ORDERToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ORDERToolStripMenuItem.Text = "ORDER"
        '
        'SALESToolStripMenuItem
        '
        Me.SALESToolStripMenuItem.Name = "SALESToolStripMenuItem"
        Me.SALESToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.SALESToolStripMenuItem.Text = "SALES"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.LOGOUTToolStripMenuItem.Text = "LOGOUT"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'frmwelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cakeorder.My.Resources.Resources.cake1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(664, 301)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmwelcome"
        Me.Text = "Cake Ordering System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MASTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FLAVOURToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CAKESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REGISTRATIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ORDERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ORDERREPORTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents USERREPORTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
