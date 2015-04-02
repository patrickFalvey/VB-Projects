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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.homeButton = New System.Windows.Forms.Button()
        Me.awayButton = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.timeButton = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.dateButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'homeButton
        '
        Me.homeButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.homeButton.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.homeButton.Location = New System.Drawing.Point(166, 399)
        Me.homeButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.homeButton.Name = "homeButton"
        Me.homeButton.Size = New System.Drawing.Size(148, 46)
        Me.homeButton.TabIndex = 2
        Me.homeButton.Text = "Scrape Home"
        Me.homeButton.UseVisualStyleBackColor = False
        '
        'awayButton
        '
        Me.awayButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.awayButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.awayButton.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.awayButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.awayButton.Location = New System.Drawing.Point(771, 399)
        Me.awayButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.awayButton.Name = "awayButton"
        Me.awayButton.Size = New System.Drawing.Size(152, 46)
        Me.awayButton.TabIndex = 3
        Me.awayButton.Text = "Scrape Away"
        Me.awayButton.UseVisualStyleBackColor = False
        '
        'ListBox2
        '
        Me.ListBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ListBox2.Font = New System.Drawing.Font("Bradley Hand ITC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.ForeColor = System.Drawing.SystemColors.Info
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 24
        Me.ListBox2.Location = New System.Drawing.Point(615, 34)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(452, 364)
        Me.ListBox2.TabIndex = 5
        '
        'timeButton
        '
        Me.timeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.timeButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.timeButton.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeButton.Location = New System.Drawing.Point(166, 764)
        Me.timeButton.Name = "timeButton"
        Me.timeButton.Size = New System.Drawing.Size(170, 45)
        Me.timeButton.TabIndex = 6
        Me.timeButton.Text = "Scrape Times"
        Me.timeButton.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ListBox1.Font = New System.Drawing.Font("Bradley Hand ITC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.SystemColors.Info
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 24
        Me.ListBox1.Location = New System.Drawing.Point(40, 34)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(442, 364)
        Me.ListBox1.TabIndex = 7
        '
        'ListBox3
        '
        Me.ListBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ListBox3.Font = New System.Drawing.Font("Bradley Hand ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox3.ForeColor = System.Drawing.SystemColors.Info
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 26
        Me.ListBox3.Location = New System.Drawing.Point(615, 466)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(452, 264)
        Me.ListBox3.TabIndex = 8
        '
        'ListBox4
        '
        Me.ListBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ListBox4.Font = New System.Drawing.Font("Bradley Hand ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox4.ForeColor = System.Drawing.SystemColors.Info
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 26
        Me.ListBox4.Location = New System.Drawing.Point(40, 466)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(442, 264)
        Me.ListBox4.TabIndex = 9
        '
        'dateButton
        '
        Me.dateButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dateButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.dateButton.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateButton.Location = New System.Drawing.Point(771, 766)
        Me.dateButton.Name = "dateButton"
        Me.dateButton.Size = New System.Drawing.Size(153, 44)
        Me.dateButton.TabIndex = 10
        Me.dateButton.Text = "Scrape Date"
        Me.dateButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1104, 888)
        Me.Controls.Add(Me.dateButton)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.timeButton)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.awayButton)
        Me.Controls.Add(Me.homeButton)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.Text = "Soup Box"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents homeButton As System.Windows.Forms.Button
    Friend WithEvents awayButton As System.Windows.Forms.Button
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents timeButton As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents dateButton As System.Windows.Forms.Button

End Class
