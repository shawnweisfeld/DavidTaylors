@Code
    ViewData("Title") = "Index"
End Code

<h2>Index</h2>

@Using Html.BeginForm("Add", "Calculator")
    @<div>
        @Html.TextBox("NumberOne")
        <br />
        @Html.TextBox("NumberTwo")
        <br />
        <input type="submit" value="Add" />
    </div>
End Using
