# Q15. Static Binding (`new`) vs Dynamic Binding (`override`)

| Feature | Static Binding (`new`) | Dynamic Binding (`override`) |
|---|---|---|
| **Keyword in base** | No special keyword required | `virtual` |
| **Keyword in derived** | `new` | `override` |
| **Resolved at** | Compile time | Runtime |
| **Behavior via base reference** | Calls the base method | Calls the overridden derived method |
| **Main purpose** | Hides the base method | Changes the behavior of the inherited virtual method |

### Explanation

- `new` **hides** the base method. The method that is called depends on the **reference type**.
- `override` **overrides** a virtual method. The method that is called depends on the **actual object type at runtime**.

---

# Q16. Why does C# require `virtual` before `override`, but `new` works on any method?

`override` means that the derived class is providing a new implementation for a method that was specifically designed to support overriding.

Therefore, the base method must be marked with `virtual` (or be `abstract`/`override`) to tell C# that derived classes are allowed to replace its behavior.

On the other hand, `new` does not override the base method. It simply **hides** it with another method that has the same name.

That's why `new` can be used with a normal method even if the base method is not `virtual`.

### In simple words:

```text
virtual  → "Derived classes are allowed to change this behavior."

override → "I am changing that virtual behavior."

new      → "I am hiding the base method with my own method."
```