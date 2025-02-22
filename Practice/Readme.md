# Strongly typed view in ASP.NET
It is used to pass data from controller to view like viewdata, viewbag and tempdata.
We can bind any class to view as model.
A view which binds with any model is called `strongly type view`.

## In View Section we have to include the model first
@model Practice.Model.employee
            or
@model List<Practice.Modal.employee> // if any list is coming from controller

after that we can use it like 
foreach(var i in model)
{
    @i.Name;
    @i.email;
}

# Partial View
It is like a reusable component.
It is of two type 1.static 2.dynamic

for static partial view we use two methods of html helper class
1. Html.Partial
2. Html.RenderPartial

for dynamic partial view we use two methods of html helper class
1. Html.Action
2. Html.RenderAction


# Strongly typed partial view
Those partial view which are strongly typed.
Each and everything is same like above.
