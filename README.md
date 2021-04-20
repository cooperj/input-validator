# Josh's Input Validator

Tool for validating user input in C# console applications.

## Using the package

To use the package install the [uk.joshc.InputValidator](https://www.nuget.org/packages/uk.joshc.InputValidator/) NuGet package.

Import the package with `using InputValidator;` where you need it.

## Methods

All methods can be accessed from the `Input` class.

### Validate Yes/No

Validate that the user is using Y/N terms.

```cs
Input.ValidateYN(string displayMessage)
```

Takes a display message, which is displayed to the user.

Returns true for yes,
false for no.

Acceptable input from the user is:

- Yes
- Y
- No
- N

Input is not case sensitive.

### Validate Array

Inputs can be validated to ensure they the message is within the array.

```cs
Input.ValidateArray(string displayMessage, string[] acceptedValues)
```

Takes a display message, which is displayed to the user and a string array including all the values of that are accepted.

Returns a lowercase string with the input if it is accepted.

#### Example

```cs
string mainMenuInput = Input.ValidateArray("What would you like to do?" +
                "\n [L]ist current cards in deck" +
                "\n [S]huffle Cards in deck" +
                "\n [D]eal a card" +
                "\n [E]xit",
                    new string[] { "l", "s", "d", "e" });
```
