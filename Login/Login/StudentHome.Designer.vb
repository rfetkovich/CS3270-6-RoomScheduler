<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentHome
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Browse Available Classes")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Search Available Classes")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Delete a Class")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Save Schedule")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Send Daily Schedule")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Print Daily Schedule")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Daily Schedule", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add Room")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Remove Room")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Edit Time")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Edit Name")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Manage Organizations", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9, TreeNode10, TreeNode11})
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add an Organization")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Remove Organization")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Search Profile List")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Browse Profile List")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Profile List", New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Manage Profile", New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode14, TreeNode17})
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add an Alarm")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Edit Sound")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Edit Visual")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Delete Alarm")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Modify Alarm", New System.Windows.Forms.TreeNode() {TreeNode20, TreeNode21, TreeNode22})
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Manage Alarms", New System.Windows.Forms.TreeNode() {TreeNode19, TreeNode23})
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Logout")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Home ")
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "nBrowse"
        TreeNode1.Text = "Browse Available Classes"
        TreeNode2.Name = "nSearch"
        TreeNode2.Text = "Search Available Classes"
        TreeNode3.Name = "nDelete"
        TreeNode3.Text = "Delete a Class"
        TreeNode4.Name = "nSave"
        TreeNode4.Text = "Save Schedule"
        TreeNode5.Name = "nSend"
        TreeNode5.Text = "Send Daily Schedule"
        TreeNode6.Name = "nPrint"
        TreeNode6.Text = "Print Daily Schedule"
        TreeNode7.Name = "nDaily"
        TreeNode7.Text = "Daily Schedule"
        TreeNode8.Name = "nOrgAdd"
        TreeNode8.Text = "Add Room"
        TreeNode9.Name = "nOrgRemove"
        TreeNode9.Text = "Remove Room"
        TreeNode10.Name = "nOrgEditTime"
        TreeNode10.Text = "Edit Time"
        TreeNode11.Name = "nOrgEditName"
        TreeNode11.Text = "Edit Name"
        TreeNode12.Name = "nOrganizations"
        TreeNode12.Text = "Manage Organizations"
        TreeNode13.Name = "nAddOrg"
        TreeNode13.Text = "Add an Organization"
        TreeNode14.Name = "nRemoveOrg"
        TreeNode14.Text = "Remove Organization"
        TreeNode15.Name = "nPLSearch"
        TreeNode15.Text = "Search Profile List"
        TreeNode16.Name = "nPLBrowse"
        TreeNode16.Text = "Browse Profile List"
        TreeNode17.Name = "nProfileList"
        TreeNode17.Text = "Profile List"
        TreeNode18.Name = "nProfile"
        TreeNode18.Text = "Manage Profile"
        TreeNode19.Name = "nAlarmAdd"
        TreeNode19.Text = "Add an Alarm"
        TreeNode20.Name = "nEditSound"
        TreeNode20.Text = "Edit Sound"
        TreeNode21.Name = "nEditVisual"
        TreeNode21.Text = "Edit Visual"
        TreeNode22.Name = "nAlarmDelete"
        TreeNode22.Text = "Delete Alarm"
        TreeNode23.Name = "nAlarmModify"
        TreeNode23.Text = "Modify Alarm"
        TreeNode24.Name = "nAlarms"
        TreeNode24.Text = "Manage Alarms"
        TreeNode25.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        TreeNode25.Name = "nLogout"
        TreeNode25.Text = "Logout"
        TreeNode26.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        TreeNode26.Name = "nHome"
        TreeNode26.Text = "Home "
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode12, TreeNode18, TreeNode24, TreeNode25, TreeNode26})
        Me.TreeView1.Size = New System.Drawing.Size(318, 856)
        Me.TreeView1.TabIndex = 1
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(347, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1543, 166)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'StudentHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1902, 853)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "StudentHome"
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
End Class
