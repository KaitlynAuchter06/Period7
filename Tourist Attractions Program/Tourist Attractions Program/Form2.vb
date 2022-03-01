Public Class Form2
    Private Sub TouristAttractionsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TouristAttractionsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TouristAttractionsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Tourist_AttractionsDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Tourist_AttractionsDataSet.TouristAttractions' table. You can move, or remove it, as needed.
        Me.TouristAttractionsTableAdapter.Fill(Me.Tourist_AttractionsDataSet.TouristAttractions)

    End Sub
End Class