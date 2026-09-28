# Delegates, Func, Action, Predicate & Events
#### Note: I Have Used AI To Enhance And Mark This README File

## Q1 — What is the difference between `PriceCalculator` and `Func<Order, decimal>`?

`PriceCalculator` is a **custom delegate**, while `Func<Order, decimal>` is a **built-in generic delegate** with the same signature.

```csharp
public delegate decimal PriceCalculator(Order order);

// Equivalent built-in delegate
Func<Order, decimal>
```

The main difference is that a custom delegate can have a **meaningful domain-specific name**, while `Func<>` is more generic and avoids creating a custom delegate.

---

## Q2 — What is the difference between `Action<Order>` and `Func<Order, decimal>`?

The main difference is the **return value**:

```csharp
Action<Order>
```

- Takes an `Order`
- Returns `void`
- Used when we want to **perform an action**

```csharp
Func<Order, decimal>
```

- Takes an `Order`
- Returns a `decimal`
- Used when we want to **calculate and return a value**

Example:

```csharp
Action<Order> printOrder = order =>
{
    Console.WriteLine(order.Id);
};

Func<Order, decimal> calculatePrice = order =>
{
    return order.Price * order.Quantity;
};
```

---

## Q3 — Why does `Predicate<T>` return `bool`?

`Predicate<T>` is designed to represent a **condition, test, or validation rule**.

It returns:

```csharp
true
```

if the object satisfies the condition, or:

```csharp
false
```

if it does not.

Example:

```csharp
Predicate<Order> validOrder =
    order => order.Quantity > 0;
```

So:

```text
Predicate<T> → "Does this object satisfy this condition?"
```

---

## Q4 — What is the difference between a delegate and an event?

A **delegate** is a type that can reference one or more methods and can be invoked.

An **event** is a mechanism built on delegates that allows a class to **notify subscribers when something happens**.

### Delegate

```csharp
Action<Order> action;

action(order);
```

The delegate can be invoked by code that has access to it.

### Event

```csharp
public event Action<Order> OrderProcessed;
```

External code can subscribe:

```csharp
orderService.OrderProcessed += Handler;
```

But the event should normally be raised only by the class that owns it:

```csharp
OrderProcessed?.Invoke(order);
```

**In short:**

```text
Delegate → stores/invokes methods

Event   → provides controlled notification to subscribers
```

---

## Q5 — Why can't external code normally invoke an event declared in another class?

Because an event is designed so that **only the declaring class can raise/invoke it**.

External code can:

- `+=` → Subscribe
- `-=` → Unsubscribe

But it cannot normally do:

```csharp
orderService.OrderProcessed?.Invoke(order); // ❌
```

The class that owns the event controls **when the event is raised**.

This protects the event from being triggered incorrectly by external code.

---

## Q6 — What happens when multiple handlers subscribe to the same event?

All subscribed handlers are stored in the event's **invocation list**.

When the event is raised:

```csharp
OrderProcessed?.Invoke(order);
```

all subscribed handlers are executed, in their subscription order.

Example:

```csharp
orderService.OrderProcessed += PrintOrderProcessed;
orderService.OrderProcessed += SendOrderNotification;
orderService.OrderProcessed += WriteOrderAudit;
```

When the event is raised:

```text
PrintOrderProcessed
        ↓
SendOrderNotification
        ↓
WriteOrderAudit
```

All three handlers execute.

---

## Q7 — Explain:

```csharp
orderService.OrderProcessed += HandleOrderProcessed;
```

This statement means:

### `OrderProcessed`

The **event** that belongs to `orderService`.

```csharp
orderService.OrderProcessed
```

### `+=`

The **subscription operator**.

It means:

> Add this handler to the event's subscribers.

### `HandleOrderProcessed`

The **handler method** that will be executed when the event is raised.

So the complete statement means:

> Subscribe `HandleOrderProcessed` to the `OrderProcessed` event.

```text
OrderProcessed
      +
      =
      ↓
Subscribe HandleOrderProcessed
```

---

## Q8 — Challenge

### What is the difference between:

```csharp
Action<Order>
```

and:

```csharp
event Action<Order>
```

Although both use `Action<Order>`, they have different purposes and access rules.

### `Action<Order>`

A normal delegate variable:

```csharp
Action<Order> action;
```

It can hold a method and can be invoked:

```csharp
action(order);
```

It represents a **callable behavior**.

---

### `event Action<Order>`

An event:

```csharp
public event Action<Order> OrderProcessed;
```

It is used for **notification**.

Other classes can subscribe:

```csharp
orderService.OrderProcessed += HandleOrderProcessed;
```

And unsubscribe:

```csharp
orderService.OrderProcessed -= HandleOrderProcessed;
```

But external code cannot normally raise the event.

Only the class that declares the event should control when it is triggered:

```csharp
OrderProcessed?.Invoke(order);
```

### Why use an event?

Because an event provides **encapsulation and controlled notification**.

```text
Action<Order>
    ↓
Callable delegate
    ↓
Can be invoked directly


event Action<Order>
    ↓
Notification mechanism
    ↓
External code → Subscribe / Unsubscribe
    ↓
Owner class → Raise the event
```

### Key takeaway

> **Delegate = behavior**  
> **Event = notification mechanism built around a delegate**

This is why an event is preferred when you want other parts of the application to **listen for something happening** without allowing them to trigger that notification themselves.