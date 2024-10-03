Imports System.Data.OleDb
Public Class Form2
    Private connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\vnnba\Documents\Visual Studio 2010\Projects\RestaurantManagementSystem\RestaurantManagementSystem\Database.mdb"
    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        Dim prices As New Dictionary(Of String, Double) From {
            {"Tea", 10.0},
            {"Coke", 20.0},
            {"Water", 5.0},
            {"Coffee", 15.0},
            {"Orange Juice", 12.0},
            {"Mango Juice", 12.0},
            {"Mocktail", 30.0},
            {"Cocktail", 40.0},
            {"Strawberry Shake", 25.0},
            {"Vanilla Shake", 25.0},
            {"Chocolate Shake", 25.0},
            {"Fries", 35.0},
            {"Salad", 20.0},
            {"Chips Masala", 40.0},
            {"Pilau", 50.0},
            {"Ugali Fish", 60.0},
            {"Chicken Salad", 55.0},
            {"Cheese Sandwich", 30.0}
        }

        Dim costOfDrinks As Double = 0
        Dim costOfMeals As Double = 0
        Dim taxRate As Double = 0.1 ' 10% tax
        Dim subTotal As Double
        Dim total As Double
        Dim receipt As String = "Purchase Receipt" & Environment.NewLine & "=====================" & Environment.NewLine

        ' Calculate cost of drinks
        If chkTea.Checked Then
            costOfDrinks += prices("Tea") * Val(txtTeaQty.Text)
            receipt &= "Tea: " & prices("Tea").ToString("C2") & " x " & Val(txtTeaQty.Text) & " = " & (prices("Tea") * Val(txtTeaQty.Text)).ToString("C2") & Environment.NewLine
        End If
        If chkCoke.Checked Then
            costOfDrinks += prices("Coke") * Val(txtCokeQty.Text)
            receipt &= "Coke: " & prices("Coke").ToString("C2") & " x " & Val(txtCokeQty.Text) & " = " & (prices("Coke") * Val(txtCokeQty.Text)).ToString("C2") & Environment.NewLine
        End If
        If chkWater.Checked Then
            costOfDrinks += prices("Water") * Val(txtWaterQty.Text)
            receipt &= "Water: " & prices("Water").ToString("C2") & " x " & Val(txtWaterQty.Text) & " = " & (prices("Water") * Val(txtWaterQty.Text)).ToString("C2") & Environment.NewLine
        End If
        If chkCoffee.Checked Then
            costOfDrinks += prices("Coffee") * Val(txtCoffeeQty.Text)
            receipt &= "Coffee: " & prices("Coffee").ToString("C2") & " x " & Val(txtCoffeeQty.Text) & " = " & (prices("Coffee") * Val(txtCoffeeQty.Text)).ToString("C2") & Environment.NewLine
        End If
        If chkOrangeJuice.Checked Then
            costOfDrinks += prices("Orange Juice") * Val(txtOrangeJuiceQty.Text)
            receipt &= "Orange Juice: " & prices("Orange Juice").ToString("C2") & " x " & Val(txtOrangeJuiceQty.Text) & " = " & (prices("Orange Juice") * Val(txtOrangeJuiceQty.Text)).ToString("C2") & Environment.NewLine
        End If
        If chkMangoJuice.Checked Then
            costOfDrinks += prices("Mango Juice") * Val(txtMangoJuiceQty.Text)
            receipt &= "Mango Juice: " & prices("Mango Juice").ToString("C2") & " x " & Val(txtMangoJuiceQty.Text) & " = " & (prices("Mango Juice") * Val(txtMangoJuiceQty.Text)).ToString("C2") & Environment.NewLine
        End If
        If chkMocktail.Checked Then
            costOfDrinks += prices("Mocktail") * Val(txtMocktailQty.Text)
            receipt &= "Mocktail: " & prices("Mocktail").ToString("C2") & " x " & Val(txtMocktailQty.Text) & " = " & (prices("Mocktail") * Val(txtMocktailQty.Text)).ToString("C2") & Environment.NewLine
        End If
        If chkCocktail.Checked Then
            costOfDrinks += prices("Cocktail") * Val(txtCocktailQty.Text)
            receipt &= "Cocktail: " & prices("Cocktail").ToString("C2") & " x " & Val(txtCocktailQty.Text) & " = " & (prices("Cocktail") * Val(txtCocktailQty.Text)).ToString("C2") & Environment.NewLine
        End If
        If chkStrawberryShake.Checked Then
            costOfDrinks += prices("Strawberry Shake") * Val(txtStrawberryShakeQty.Text)
            receipt &= "Strawberry Shake: " & prices("Strawberry Shake").ToString("C2") & " x " & Val(txtStrawberryShakeQty.Text) & " = " & (prices("Strawberry Shake") * Val(txtStrawberryShakeQty.Text)).ToString("C2") & Environment.NewLine
        End If
        If chkVanillaShake.Checked Then
            costOfDrinks += prices("Vanilla Shake") * Val(txtVanillaShakeQty.Text)
            receipt &= "Vanilla Shake: " & prices("Vanilla Shake").ToString("C2") & " x " & Val(txtVanillaShakeQty.Text) & " = " & (prices("Vanilla Shake") * Val(txtVanillaShakeQty.Text)).ToString("C2") & Environment.NewLine
        End If
        If chkChocolateShake.Checked Then
            costOfDrinks += prices("Chocolate Shake") * Val(txtChocolateShakeQty.Text)
            receipt &= "Chocolate Shake: " & prices("Chocolate Shake").ToString("C2") & " x " & Val(txtChocolateShakeQty.Text) & " = " & (prices("Chocolate Shake") * Val(txtChocolateShakeQty.Text)).ToString("C2") & Environment.NewLine
        End If

        ' Calculate cost of meals
        If chkFries.Checked Then
            costOfMeals += prices("Fries") * Val(txtFriesQty.Text)
            receipt &= "Fries: " & prices("Fries").ToString("C2") & " x " & Val(txtFriesQty.Text) & " = " & (prices("Fries") * Val(txtFriesQty.Text)).ToString("C2") & Environment.NewLine
        End If
        If chkSalad.Checked Then
            costOfMeals += prices("Salad") * Val(txtSaladQty.Text)
            receipt &= "Salad: " & prices("Salad").ToString("C2") & " x " & Val(txtSaladQty.Text) & " = " & (prices("Salad") * Val(txtSaladQty.Text)).ToString("C2") & Environment.NewLine
        End If
        If chkChipsMasala.Checked Then
            costOfMeals += prices("Chips Masala") * Val(txtChipsMasalaQty.Text)
            receipt &= "Chips Masala: " & prices("Chips Masala").ToString("C2") & " x " & Val(txtChipsMasalaQty.Text) & " = " & (prices("Chips Masala") * Val(txtChipsMasalaQty.Text)).ToString("C2") & Environment.NewLine
        End If
        If chkPilau.Checked Then
            costOfMeals += prices("Pilau") * Val(txtPilauQty.Text)
            receipt &= "Pilau: " & prices("Pilau").ToString("C2") & " x " & Val(txtPilauQty.Text) & " = " & (prices("Pilau") * Val(txtPilauQty.Text)).ToString("C2") & Environment.NewLine
        End If
        If chkUgaliFish.Checked Then
            costOfMeals += prices("Ugali Fish") * Val(txtUgaliFishQty.Text)
            receipt &= "Ugali Fish: " & prices("Ugali Fish").ToString("C2") & " x " & Val(txtUgaliFishQty.Text) & " = " & (prices("Ugali Fish") * Val(txtUgaliFishQty.Text)).ToString("C2") & Environment.NewLine
        End If
        If chkChickenSalad.Checked Then
            costOfMeals += prices("Chicken Salad") * Val(txtChickenSaladQty.Text)
            receipt &= "Chicken Salad: " & prices("Chicken Salad").ToString("C2") & " x " & Val(txtChickenSaladQty.Text) & " = " & (prices("Chicken Salad") * Val(txtChickenSaladQty.Text)).ToString("C2") & Environment.NewLine
        End If
        If chkCheeseSandwich.Checked Then
            costOfMeals += prices("Cheese Sandwich") * Val(txtCheeseSandwichQty.Text)
            receipt &= "Cheese Sandwich: " & prices("Cheese Sandwich").ToString("C2") & " x " & Val(txtCheeseSandwichQty.Text) & " = " & (prices("Cheese Sandwich") * Val(txtCheeseSandwichQty.Text)).ToString("C2") & Environment.NewLine
        End If

        subTotal = costOfDrinks + costOfMeals
        total = subTotal + (subTotal * taxRate)

        txtSubTotal.Text = subTotal.ToString("C2")
        txtTotal.Text = total.ToString("C2")
        txtTax.Text = (subTotal * taxRate).ToString("C2")

        receipt &= "=====================" & Environment.NewLine
        receipt &= "Sub Total: " & subTotal.ToString("C2") & Environment.NewLine
        receipt &= "Tax: " & (subTotal * taxRate).ToString("C2") & Environment.NewLine
        receipt &= "Total: " & total.ToString("C2") & Environment.NewLine

        txtReceipt.Text = receipt
    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtTeaQty_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTeaQty.TextChanged

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ' Uncheck all checkboxes
        chkTea.Checked = False
        chkCoke.Checked = False
        chkWater.Checked = False
        chkCoffee.Checked = False
        chkOrangeJuice.Checked = False
        chkMangoJuice.Checked = False
        chkMocktail.Checked = False
        chkCocktail.Checked = False
        chkStrawberryShake.Checked = False
        chkVanillaShake.Checked = False
        chkChocolateShake.Checked = False
        chkFries.Checked = False
        chkSalad.Checked = False
        chkChipsMasala.Checked = False
        chkPilau.Checked = False
        chkUgaliFish.Checked = False
        chkChickenSalad.Checked = False
        chkCheeseSandwich.Checked = False

        ' Clear all textboxes
        txtTeaQty.Text = ""
        txtCokeQty.Text = ""
        txtWaterQty.Text = ""
        txtCoffeeQty.Text = ""
        txtOrangeJuiceQty.Text = ""
        txtMangoJuiceQty.Text = ""
        txtMocktailQty.Text = ""
        txtCocktailQty.Text = ""
        txtStrawberryShakeQty.Text = ""
        txtVanillaShakeQty.Text = ""
        txtChocolateShakeQty.Text = ""
        txtFriesQty.Text = ""
        txtSaladQty.Text = ""
        txtChipsMasalaQty.Text = ""
        txtPilauQty.Text = ""
        txtUgaliFishQty.Text = ""
        txtChickenSaladQty.Text = ""
        txtCheeseSandwichQty.Text = ""
        txtSubTotal.Text = ""
        txtTotal.Text = ""
        txtTax.Text = ""
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub InsertData()
        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()

                ' Insert Drinks
                Dim drinksQuery As String = "INSERT INTO tblDrinks (DrinkName, Quantity, Price) VALUES (@DrinkName, @Quantity, @Price)"
                Using drinksCommand As New OleDbCommand(drinksQuery, connection)
                    If chkTea.Checked Then
                        drinksCommand.Parameters.AddWithValue("@DrinkName", "Tea")
                        drinksCommand.Parameters.AddWithValue("@Quantity", If(String.IsNullOrEmpty(txtTeaQty.Text), 0, Convert.ToInt32(txtTeaQty.Text)))
                        drinksCommand.Parameters.AddWithValue("@Price", 20.0) ' Example price
                        drinksCommand.ExecuteNonQuery()
                    End If

                    If chkCoke.Checked Then
                        drinksCommand.Parameters.Clear()
                        drinksCommand.Parameters.AddWithValue("@DrinkName", "Coke")
                        drinksCommand.Parameters.AddWithValue("@Quantity", If(String.IsNullOrEmpty(txtCokeQty.Text), 0, Convert.ToInt32(txtCokeQty.Text)))
                        drinksCommand.Parameters.AddWithValue("@Price", 10.0)
                        drinksCommand.ExecuteNonQuery()
                    End If

                    If chkWater.Checked Then
                        drinksCommand.Parameters.Clear()
                        drinksCommand.Parameters.AddWithValue("@DrinkName", "Water")
                        drinksCommand.Parameters.AddWithValue("@Quantity", If(String.IsNullOrEmpty(txtWaterQty.Text), 0, Convert.ToInt32(txtWaterQty.Text)))
                        drinksCommand.Parameters.AddWithValue("@Price", 5.0) ' Example price
                        drinksCommand.ExecuteNonQuery()
                    End If

                    If chkCoffee.Checked Then
                        drinksCommand.Parameters.Clear()
                        drinksCommand.Parameters.AddWithValue("@DrinkName", "Coffee")
                        drinksCommand.Parameters.AddWithValue("@Quantity", If(String.IsNullOrEmpty(txtCoffeeQty.Text), 0, Convert.ToInt32(txtCoffeeQty.Text)))
                        drinksCommand.Parameters.AddWithValue("@Price", 25.0) ' Example price
                        drinksCommand.ExecuteNonQuery()
                    End If

                    If chkOrangeJuice.Checked Then
                        drinksCommand.Parameters.Clear()
                        drinksCommand.Parameters.AddWithValue("@DrinkName", "Orange Juice")
                        drinksCommand.Parameters.AddWithValue("@Quantity", If(String.IsNullOrEmpty(txtOrangeJuiceQty.Text), 0, Convert.ToInt32(txtOrangeJuiceQty.Text)))
                        drinksCommand.Parameters.AddWithValue("@Price", 30.0) ' Example price
                        drinksCommand.ExecuteNonQuery()
                    End If

                    If chkMangoJuice.Checked Then
                        drinksCommand.Parameters.Clear()
                        drinksCommand.Parameters.AddWithValue("@DrinkName", "Mango Juice")
                        drinksCommand.Parameters.AddWithValue("@Quantity", If(String.IsNullOrEmpty(txtMangoJuiceQty.Text), 0, Convert.ToInt32(txtMangoJuiceQty.Text)))
                        drinksCommand.Parameters.AddWithValue("@Price", 35.0) ' Example price
                        drinksCommand.ExecuteNonQuery()
                    End If

                    If chkMocktail.Checked Then
                        drinksCommand.Parameters.Clear()
                        drinksCommand.Parameters.AddWithValue("@DrinkName", "Mocktail")
                        drinksCommand.Parameters.AddWithValue("@Quantity", If(String.IsNullOrEmpty(txtMocktailQty.Text), 0, Convert.ToInt32(txtMocktailQty.Text)))
                        drinksCommand.Parameters.AddWithValue("@Price", 50.0) ' Example price
                        drinksCommand.ExecuteNonQuery()
                    End If

                    If chkCocktail.Checked Then
                        drinksCommand.Parameters.Clear()
                        drinksCommand.Parameters.AddWithValue("@DrinkName", "Cocktail")
                        drinksCommand.Parameters.AddWithValue("@Quantity", If(String.IsNullOrEmpty(txtCocktailQty.Text), 0, Convert.ToInt32(txtCocktailQty.Text)))
                        drinksCommand.Parameters.AddWithValue("@Price", 60.0) ' Example price
                        drinksCommand.ExecuteNonQuery()
                    End If
                End Using

                ' Insert Shakes
                Dim shakesQuery As String = "INSERT INTO tblShakes (ShakesName, Quantity, Price) VALUES (@ShakesName, @Quantity, @Price)"
                Using shakesCommand As New OleDbCommand(shakesQuery, connection)
                    If chkStrawberryShake.Checked Then
                        shakesCommand.Parameters.AddWithValue("@ShakesName", "Strawberry Shake")
                        shakesCommand.Parameters.AddWithValue("@Quantity", If(String.IsNullOrEmpty(txtStrawberryShakeQty.Text), 0, Convert.ToInt32(txtStrawberryShakeQty.Text)))
                        shakesCommand.Parameters.AddWithValue("@Price", 30.0) ' Example price
                        shakesCommand.ExecuteNonQuery()
                    End If

                    If chkVanillaShake.Checked Then
                        shakesCommand.Parameters.Clear()
                        shakesCommand.Parameters.AddWithValue("@ShakesName", "Vanilla Shake")
                        shakesCommand.Parameters.AddWithValue("@Quantity", If(String.IsNullOrEmpty(txtVanillaShakeQty.Text), 0, Convert.ToInt32(txtVanillaShakeQty.Text)))
                        shakesCommand.Parameters.AddWithValue("@Price", 30.0)
                        shakesCommand.ExecuteNonQuery()
                    End If

                    If chkChocolateShake.Checked Then
                        shakesCommand.Parameters.Clear()
                        shakesCommand.Parameters.AddWithValue("@ShakesName", "Chocolate Shake")
                        shakesCommand.Parameters.AddWithValue("@Quantity", If(String.IsNullOrEmpty(txtChocolateShakeQty.Text), 0, Convert.ToInt32(txtChocolateShakeQty.Text)))
                        shakesCommand.Parameters.AddWithValue("@Price", 35.0) ' Example price
                        shakesCommand.ExecuteNonQuery()
                    End If
                End Using

                ' Insert Fast Meals and Vegetarian
                Dim mealQuery As String = "INSERT INTO tblFastMeals (MealName, Quantity, Price) VALUES (@MealName, @Quantity, @Price)"
                Using mealCommand As New OleDbCommand(mealQuery, connection)
                    If chkFries.Checked Then
                        mealCommand.Parameters.AddWithValue("@MealName", "Fries")
                        mealCommand.Parameters.AddWithValue("@Quantity", If(String.IsNullOrEmpty(txtFriesQty.Text), 0, Convert.ToInt32(txtFriesQty.Text)))
                        mealCommand.Parameters.AddWithValue("@Price", 50.0) ' Example price
                        mealCommand.ExecuteNonQuery()
                    End If

                    If chkSalad.Checked Then
                        mealCommand.Parameters.Clear()
                        mealCommand.Parameters.AddWithValue("@MealName", "Salad")
                        mealCommand.Parameters.AddWithValue("@Quantity", If(String.IsNullOrEmpty(txtSaladQty.Text), 0, Convert.ToInt32(txtSaladQty.Text)))
                        mealCommand.Parameters.AddWithValue("@Price", 30.0)
                        mealCommand.ExecuteNonQuery()
                    End If

                    If chkChipsMasala.Checked Then
                        mealCommand.Parameters.Clear()
                        mealCommand.Parameters.AddWithValue("@MealName", "Chips Masala")
                        mealCommand.Parameters.AddWithValue("@Quantity", If(String.IsNullOrEmpty(txtChipsMasalaQty.Text), 0, Convert.ToInt32(txtChipsMasalaQty.Text)))
                        mealCommand.Parameters.AddWithValue("@Price", 40.0) ' Example price
                        mealCommand.ExecuteNonQuery()
                    End If

                    If chkPilau.Checked Then
                        mealCommand.Parameters.Clear()
                        mealCommand.Parameters.AddWithValue("@MealName", "Pilau")
                        mealCommand.Parameters.AddWithValue("@Quantity", If(String.IsNullOrEmpty(txtPilauQty.Text), 0, Convert.ToInt32(txtPilauQty.Text)))
                        mealCommand.Parameters.AddWithValue("@Price", 60.0) ' Example price
                        mealCommand.ExecuteNonQuery()
                    End If

                    If chkUgaliFish.Checked Then
                        mealCommand.Parameters.Clear()
                        mealCommand.Parameters.AddWithValue("@MealName", "Ugali Fish")
                        mealCommand.Parameters.AddWithValue("@Quantity", If(String.IsNullOrEmpty(txtUgaliFishQty.Text), 0, Convert.ToInt32(txtUgaliFishQty.Text)))
                        mealCommand.Parameters.AddWithValue("@Price", 80.0) ' Example price
                        mealCommand.ExecuteNonQuery()
                    End If

                    If chkChickenSalad.Checked Then
                        mealCommand.Parameters.Clear()
                        mealCommand.Parameters.AddWithValue("@MealName", "Chicken Salad")
                        mealCommand.Parameters.AddWithValue("@Quantity", If(String.IsNullOrEmpty(txtChickenSaladQty.Text), 0, Convert.ToInt32(txtChickenSaladQty.Text)))
                        mealCommand.Parameters.AddWithValue("@Price", 70.0) ' Example price
                        mealCommand.ExecuteNonQuery()
                    End If

                    If chkRiceBeef.Checked Then
                        mealCommand.Parameters.Clear()
                        mealCommand.Parameters.AddWithValue("@MealName", "Rice Beef")
                        mealCommand.Parameters.AddWithValue("@Quantity", If(String.IsNullOrEmpty(txtRiceBeefQty.Text), 0, Convert.ToInt32(txtRiceBeefQty.Text)))
                        mealCommand.Parameters.AddWithValue("@Price", 75.0) ' Example price
                        mealCommand.ExecuteNonQuery()
                    End If

                    If chkCheeseSandwich.Checked Then
                        mealCommand.Parameters.Clear()
                        mealCommand.Parameters.AddWithValue("@MealName", "Cheese Sandwich")
                        mealCommand.Parameters.AddWithValue("@Quantity", If(String.IsNullOrEmpty(txtCheeseSandwichQty.Text), 0, Convert.ToInt32(txtCheeseSandwichQty.Text)))
                        mealCommand.Parameters.AddWithValue("@Price", 45.0) ' Example price
                        mealCommand.ExecuteNonQuery()
                    End If
                End Using

                ' Insert Total
                If Not String.IsNullOrEmpty(txtTotal.Text) Then
                    Dim totalQuery As String = "INSERT INTO tblTotal (Tax, SubTotal, Total) VALUES (@Tax, @SubTotal, @Total)"
                    Using totalCommand As New OleDbCommand(totalQuery, connection)
                        totalCommand.Parameters.AddWithValue("@Tax", txtTotal.Text)
                        totalCommand.Parameters.AddWithValue("@SubTotal", txtTotal.Text)
                        totalCommand.Parameters.AddWithValue("@Total", txtTotal.Text)
                        totalCommand.ExecuteNonQuery()
                    End Using
                End If

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
        Form3.Show()
    End Sub

    ' Button Click Event to call InsertData
    Private Sub btnMakePayment_Click(sender As System.Object, e As System.EventArgs) Handles btnMakePayment.Click
        InsertData()
        MessageBox.Show("Data has been saved successfully.")
    End Sub
End Class

