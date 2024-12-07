# F# Mutability and Shadowing Bug

This example demonstrates a potential confusion caused by mutable variables and variable shadowing in F#.

The `add` function is designed to add two numbers, but the behavior may not be as intuitive as expected due to the mutable nature of the `x` and `y` variables.

The solution shows how to address this using immutability or explicit parameter passing to avoid confusion.