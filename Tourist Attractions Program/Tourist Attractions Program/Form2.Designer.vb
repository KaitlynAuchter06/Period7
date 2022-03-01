<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim AttractionNameLabel As System.Windows.Forms.Label
        Dim AtractionTypeLabel As System.Windows.Forms.Label
        Dim AmenitiesLabel As System.Windows.Forms.Label
        Dim CostLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim RestaurantsLabel As System.Windows.Forms.Label
        Dim ShoppingLabel As System.Windows.Forms.Label
        Dim Open_CloseLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Me.Tourist_AttractionsDataSet = New Tourist_Attractions_Program.Tourist_AttractionsDataSet()
        Me.TouristAttractionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TouristAttractionsTableAdapter = New Tourist_Attractions_Program.Tourist_AttractionsDataSetTableAdapters.TouristAttractionsTableAdapter()
        Me.TableAdapterManager = New Tourist_Attractions_Program.Tourist_AttractionsDataSetTableAdapters.TableAdapterManager()
        Me.TouristAttractionsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TouristAttractionsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AttractionNameTextBox = New System.Windows.Forms.TextBox()
        Me.AtractionTypeTextBox = New System.Windows.Forms.TextBox()
        Me.AmenitiesTextBox = New System.Windows.Forms.TextBox()
        Me.CostTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.RestaurantsTextBox = New System.Windows.Forms.TextBox()
        Me.ShoppingTextBox = New System.Windows.Forms.TextBox()
        Me.Open_CloseTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        AttractionNameLabel = New System.Windows.Forms.Label()
        AtractionTypeLabel = New System.Windows.Forms.Label()
        AmenitiesLabel = New System.Windows.Forms.Label()
        CostLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        RestaurantsLabel = New System.Windows.Forms.Label()
        ShoppingLabel = New System.Windows.Forms.Label()
        Open_CloseLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        CType(Me.Tourist_AttractionsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TouristAttractionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TouristAttractionsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TouristAttractionsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tourist_AttractionsDataSet
        '
        Me.Tourist_AttractionsDataSet.DataSetName = "Tourist_AttractionsDataSet"
        Me.Tourist_AttractionsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TouristAttractionsBindingSource
        '
        Me.TouristAttractionsBindingSource.DataMember = "TouristAttractions"
        Me.TouristAttractionsBindingSource.DataSource = Me.Tourist_AttractionsDataSet
        '
        'TouristAttractionsTableAdapter
        '
        Me.TouristAttractionsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TouristAttractionsTableAdapter = Me.TouristAttractionsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Tourist_Attractions_Program.Tourist_AttractionsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TouristAttractionsBindingNavigator
        '
        Me.TouristAttractionsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TouristAttractionsBindingNavigator.BindingSource = Me.TouristAttractionsBindingSource
        Me.TouristAttractionsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TouristAttractionsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TouristAttractionsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TouristAttractionsBindingNavigatorSaveItem})
        Me.TouristAttractionsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TouristAttractionsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TouristAttractionsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TouristAttractionsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TouristAttractionsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TouristAttractionsBindingNavigator.Name = "TouristAttractionsBindingNavigator"
        Me.TouristAttractionsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TouristAttractionsBindingNavigator.Size = New System.Drawing.Size(963, 25)
        Me.TouristAttractionsBindingNavigator.TabIndex = 0
        Me.TouristAttractionsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'TouristAttractionsBindingNavigatorSaveItem
        '
        Me.TouristAttractionsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TouristAttractionsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TouristAttractionsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TouristAttractionsBindingNavigatorSaveItem.Name = "TouristAttractionsBindingNavigatorSaveItem"
        Me.TouristAttractionsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TouristAttractionsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AttractionNameLabel
        '
        AttractionNameLabel.AutoSize = True
        AttractionNameLabel.Location = New System.Drawing.Point(29, 55)
        AttractionNameLabel.Name = "AttractionNameLabel"
        AttractionNameLabel.Size = New System.Drawing.Size(86, 13)
        AttractionNameLabel.TabIndex = 3
        AttractionNameLabel.Text = "Attraction Name:"
        '
        'AttractionNameTextBox
        '
        Me.AttractionNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TouristAttractionsBindingSource, "AttractionName", True))
        Me.AttractionNameTextBox.Location = New System.Drawing.Point(121, 52)
        Me.AttractionNameTextBox.Name = "AttractionNameTextBox"
        Me.AttractionNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AttractionNameTextBox.TabIndex = 4
        '
        'AtractionTypeLabel
        '
        AtractionTypeLabel.AutoSize = True
        AtractionTypeLabel.Location = New System.Drawing.Point(29, 81)
        AtractionTypeLabel.Name = "AtractionTypeLabel"
        AtractionTypeLabel.Size = New System.Drawing.Size(79, 13)
        AtractionTypeLabel.TabIndex = 5
        AtractionTypeLabel.Text = "Atraction Type:"
        '
        'AtractionTypeTextBox
        '
        Me.AtractionTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TouristAttractionsBindingSource, "AtractionType", True))
        Me.AtractionTypeTextBox.Location = New System.Drawing.Point(121, 78)
        Me.AtractionTypeTextBox.Name = "AtractionTypeTextBox"
        Me.AtractionTypeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AtractionTypeTextBox.TabIndex = 6
        '
        'AmenitiesLabel
        '
        AmenitiesLabel.AutoSize = True
        AmenitiesLabel.Location = New System.Drawing.Point(29, 107)
        AmenitiesLabel.Name = "AmenitiesLabel"
        AmenitiesLabel.Size = New System.Drawing.Size(55, 13)
        AmenitiesLabel.TabIndex = 7
        AmenitiesLabel.Text = "Amenities:"
        '
        'AmenitiesTextBox
        '
        Me.AmenitiesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TouristAttractionsBindingSource, "Amenities", True))
        Me.AmenitiesTextBox.Location = New System.Drawing.Point(121, 104)
        Me.AmenitiesTextBox.Name = "AmenitiesTextBox"
        Me.AmenitiesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AmenitiesTextBox.TabIndex = 8
        '
        'CostLabel
        '
        CostLabel.AutoSize = True
        CostLabel.Location = New System.Drawing.Point(29, 133)
        CostLabel.Name = "CostLabel"
        CostLabel.Size = New System.Drawing.Size(31, 13)
        CostLabel.TabIndex = 9
        CostLabel.Text = "Cost:"
        '
        'CostTextBox
        '
        Me.CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TouristAttractionsBindingSource, "Cost", True))
        Me.CostTextBox.Location = New System.Drawing.Point(121, 130)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CostTextBox.TabIndex = 10
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Location = New System.Drawing.Point(29, 159)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(51, 13)
        LocationLabel.TabIndex = 11
        LocationLabel.Text = "Location:"
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TouristAttractionsBindingSource, "Location", True))
        Me.LocationTextBox.Location = New System.Drawing.Point(121, 156)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LocationTextBox.TabIndex = 12
        '
        'RestaurantsLabel
        '
        RestaurantsLabel.AutoSize = True
        RestaurantsLabel.Location = New System.Drawing.Point(29, 185)
        RestaurantsLabel.Name = "RestaurantsLabel"
        RestaurantsLabel.Size = New System.Drawing.Size(67, 13)
        RestaurantsLabel.TabIndex = 13
        RestaurantsLabel.Text = "Restaurants:"
        '
        'RestaurantsTextBox
        '
        Me.RestaurantsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TouristAttractionsBindingSource, "Restaurants", True))
        Me.RestaurantsTextBox.Location = New System.Drawing.Point(121, 182)
        Me.RestaurantsTextBox.Name = "RestaurantsTextBox"
        Me.RestaurantsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RestaurantsTextBox.TabIndex = 14
        '
        'ShoppingLabel
        '
        ShoppingLabel.AutoSize = True
        ShoppingLabel.Location = New System.Drawing.Point(29, 211)
        ShoppingLabel.Name = "ShoppingLabel"
        ShoppingLabel.Size = New System.Drawing.Size(55, 13)
        ShoppingLabel.TabIndex = 15
        ShoppingLabel.Text = "Shopping:"
        '
        'ShoppingTextBox
        '
        Me.ShoppingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TouristAttractionsBindingSource, "Shopping", True))
        Me.ShoppingTextBox.Location = New System.Drawing.Point(121, 208)
        Me.ShoppingTextBox.Name = "ShoppingTextBox"
        Me.ShoppingTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ShoppingTextBox.TabIndex = 16
        '
        'Open_CloseLabel
        '
        Open_CloseLabel.AutoSize = True
        Open_CloseLabel.Location = New System.Drawing.Point(29, 237)
        Open_CloseLabel.Name = "Open_CloseLabel"
        Open_CloseLabel.Size = New System.Drawing.Size(65, 13)
        Open_CloseLabel.TabIndex = 17
        Open_CloseLabel.Text = "Open-Close:"
        '
        'Open_CloseTextBox
        '
        Me.Open_CloseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TouristAttractionsBindingSource, "Open-Close", True))
        Me.Open_CloseTextBox.Location = New System.Drawing.Point(121, 234)
        Me.Open_CloseTextBox.Name = "Open_CloseTextBox"
        Me.Open_CloseTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Open_CloseTextBox.TabIndex = 18
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(29, 263)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(81, 13)
        PhoneNumberLabel.TabIndex = 19
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TouristAttractionsBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(121, 260)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PhoneNumberTextBox.TabIndex = 20
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 499)
        Me.Controls.Add(AttractionNameLabel)
        Me.Controls.Add(Me.AttractionNameTextBox)
        Me.Controls.Add(AtractionTypeLabel)
        Me.Controls.Add(Me.AtractionTypeTextBox)
        Me.Controls.Add(AmenitiesLabel)
        Me.Controls.Add(Me.AmenitiesTextBox)
        Me.Controls.Add(CostLabel)
        Me.Controls.Add(Me.CostTextBox)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(RestaurantsLabel)
        Me.Controls.Add(Me.RestaurantsTextBox)
        Me.Controls.Add(ShoppingLabel)
        Me.Controls.Add(Me.ShoppingTextBox)
        Me.Controls.Add(Open_CloseLabel)
        Me.Controls.Add(Me.Open_CloseTextBox)
        Me.Controls.Add(PhoneNumberLabel)
        Me.Controls.Add(Me.PhoneNumberTextBox)
        Me.Controls.Add(Me.TouristAttractionsBindingNavigator)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.Tourist_AttractionsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TouristAttractionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TouristAttractionsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TouristAttractionsBindingNavigator.ResumeLayout(False)
        Me.TouristAttractionsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tourist_AttractionsDataSet As Tourist_AttractionsDataSet
    Friend WithEvents TouristAttractionsBindingSource As BindingSource
    Friend WithEvents TouristAttractionsTableAdapter As Tourist_AttractionsDataSetTableAdapters.TouristAttractionsTableAdapter
    Friend WithEvents TableAdapterManager As Tourist_AttractionsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TouristAttractionsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TouristAttractionsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AttractionNameTextBox As TextBox
    Friend WithEvents AtractionTypeTextBox As TextBox
    Friend WithEvents AmenitiesTextBox As TextBox
    Friend WithEvents CostTextBox As TextBox
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents RestaurantsTextBox As TextBox
    Friend WithEvents ShoppingTextBox As TextBox
    Friend WithEvents Open_CloseTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
End Class
