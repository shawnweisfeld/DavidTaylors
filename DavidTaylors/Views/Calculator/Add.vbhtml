@ModelType DavidTaylors.CalculatorResult

@Code
    ViewData("Title") = "Add"
End Code

<h2>Add</h2>

@Model.NumberOne + @Model.NumberTwo = @Model.Result
