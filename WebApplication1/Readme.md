# Data Annotations
These are used with model properties to ensure that the basic that is required from user may not be missed.

Syntax:

[Required]
model-property(like public int Age {get; set;})

this ensure that Age is not empty.
Note-> By default the required data annotation is applied for date and integer values automatically in MVC.

## Some data annotations are
- Required(ErrorMessage = "if any")
- StringLength(`<max-length>`,MinimumLength=`<min-length>`,ErrorMessage="if any") --> it checks length of length
- RegularExpression(`<pattern>`) --> used to accept user input in a specific format. Used for email or password
- Range(min_value,max-length) -> it checks length that if the number exceed that range than it through error. [Range(18,30)] for Age.
- Compare(`<field_name_which has to compare>`,ErrorMessage = "if any")
- ReadOnly
- DisplayName
- DataType
