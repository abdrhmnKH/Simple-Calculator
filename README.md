
# Simple Calculator

A simple desktop calculator built with **C# and Windows Forms (.NET Framework 4.7.2)**. It supports the basic arithmetic operations through a clean button-based interface.

## Features

- Basic operations: addition (`+`), subtraction (`-`), multiplication (`x`), division (`/`), and modulo (`%`)
- Decimal numbers using the `.` button
- `Del` button to remove the last character
- `Clear` button to reset the display
- `=` button to calculate and show the result

## How It Works

Every button stores its value in its `Tag` property. A single shared click handler (`ChangeTextboxString`) appends that value to the text box. When `=` is pressed, the app scans the text for the operator, splits the expression into two numbers, parses them as `float`, and computes the result with a `switch` statement.

## Usage

1. Click the number buttons and an operator to build an expression, for example `12+5`.
2. Press `=` to see the result.
3. Use `Del` to fix a mistake or `Clear` to start over.

## Known Limitations

- Only one operation per expression is supported (for example `12+5`, not `12+5*2`).
- Negative numbers as the first operand are not supported.
- Pressing `=` with an incomplete or empty expression is not handled and may cause an error.

These are good starting points for future improvements.

## Author

Created by [abdrhmnKH](https://github.com/abdrhmnKH).
