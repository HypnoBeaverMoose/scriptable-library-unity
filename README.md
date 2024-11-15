# Scriptable Library

A small library of scriptable objects. Useful for better code organization, and prototyping.

### Features

 - Variables: *ScriptableObject*s, that can be used to create global values in the editor and use those in scripts. Allows for modifications from scripts, that don't change the serialized value, and the ability to override the current value through the editor. Extend  `Variable<T>` to implement any type of variable needed.
```
    public class BoolVariable : Variable<bool>
    {
    }
```
 - References: `VariableReference<T>` allows to pass a variable to a script, while maintaining the ability to use constants directly in the inspector.
```
[SerializeField] private VariableReference<float> _variable
```
- Events: ScriptableObject events allow to create global events, that are easily accessible, tracible and testable. Every event can be invoked manually through the inspector. New event types can be created by extending `TypedEvent<T>`
```
public class StringEvent : TypedEvent<string> { }
```

